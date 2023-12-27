using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FPGrowth
{
    public partial class Form1 : Form
    {
        List<string[]> _allTransactions;
        List<string> _dimensions;
        List<ItemFrequency> _itemsFrequencies;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxTransactionFile.Text = openFileDialog1.FileName;
            }
        }

        private void buttonLoadTransaction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTransactionFile.Text))
            {
                MessageBox.Show("فایل تراکنش ها انتخاب نشده است");
                return;
            }

            if (!File.Exists(textBoxTransactionFile.Text))
            {
                MessageBox.Show("فایل تراکنش ها وجود ندارد");
                return;
            }

            _dimensions = new List<string>();

            _allTransactions = new List<string[]>();

            var allTrans = File.ReadAllLines(textBoxTransactionFile.Text);

            for (int i = 0; i < allTrans.Length; i++)
            {
                var currentTrans = allTrans[i].Trim().Split(' ');
                for (int j = 0; j < currentTrans.Length; j++)
                {
                    if (!_dimensions.Contains(currentTrans[j]))
                    {
                        _dimensions.Add(currentTrans[j]);
                    }
                }

                _allTransactions.Add(currentTrans);
            }

            labeltransactionsCount.Text = _allTransactions.Count.ToString();
            labelDimCount.Text = _dimensions.Count.ToString();

            numericUpDownPreferDimCount.Minimum = 0;
            numericUpDownPreferDimCount.Maximum = _dimensions.Count;
            numericUpDownPreferDimCount.Value = numericUpDownPreferDimCount.Maximum;
            numericUpDownPreferDimCount.Enabled = true;

            textBoxMinSup.Text = "0";
            textBoxMinSup.Enabled = true;

            numericUpDownPreferDimCountApriori.Minimum = 0;
            numericUpDownPreferDimCountApriori.Maximum = _dimensions.Count;
            numericUpDownPreferDimCountApriori.Value = numericUpDownPreferDimCount.Maximum;
            numericUpDownPreferDimCountApriori.Enabled = true;

            numericUpDownMinSup.Minimum = 0;
            numericUpDownMinSup.Maximum = _allTransactions.Count;
            numericUpDownMinSup.Value = numericUpDownMinSup.Minimum;
            numericUpDownMinSup.Enabled = true;
        }

        private void buttonLoadItemFrequency_Click(object sender, EventArgs e)
        {
            try
            {
                _itemsFrequencies = new List<ItemFrequency>();
                int preferdDims = Convert.ToInt32(numericUpDownPreferDimCount.Value);
                int minSup = Convert.ToInt32(textBoxMinSup.Text);
                foreach (var item in _allTransactions)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (Convert.ToInt32(item[i]) < preferdDims)
                        {
                            var currentFreq = _itemsFrequencies.FirstOrDefault(f => f.Item == item[i]);
                            if (currentFreq == null)
                            {
                                _itemsFrequencies.Add(new ItemFrequency() { Item = item[i], Frequency = 1 });
                            }
                            else
                            {
                                currentFreq.Frequency++;
                            }
                        }
                    }
                }

                dataGridViewItemsFrequency.DataSource = _itemsFrequencies.Where(f => f.Frequency >= minSup).OrderByDescending(f => f.Frequency).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFPTree_Click(object sender, EventArgs e)
        {
            try
            {
                int minSup = Convert.ToInt32(textBoxMinSup.Text);
                string[] items = _itemsFrequencies.Where(f => f.Frequency >= minSup).OrderByDescending(f => f.Frequency).Select(f => f.Item).ToArray();

                treeViewFP.Nodes.Clear();

                TreeNode rootNode = new TreeNode();
                rootNode.Text = "{}";
                rootNode.Tag = new ItemFrequency() { Item = "-1", Frequency = 0 };

                treeViewFP.Nodes.Add(rootNode);

                for (int i = 0; i < _allTransactions.Count; i++)
                {
                    SetTran(_allTransactions[i].ToList(), treeViewFP.Nodes[0], items);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetTran(List<string> tran, TreeNode treeNode, string[] items)
        {
            foreach (var item in items)
            {
                int currentTranItemFrequency = tran.Count(t => t == item);
                if (currentTranItemFrequency > 0)
                {
                    TreeNode itemNode = null;
                    foreach (TreeNode childNode in treeNode.Nodes)
                    {
                        if (((ItemFrequency)childNode.Tag).Item == item)
                        {
                            itemNode = childNode;
                            break;
                        }
                    }

                    if (itemNode == null)
                    {
                        itemNode = new TreeNode();
                        itemNode.Text = item + ":" + currentTranItemFrequency.ToString();
                        itemNode.Tag = new ItemFrequency() { Item = item, Frequency = currentTranItemFrequency };

                        treeNode.Nodes.Add(itemNode);
                    }
                    else
                    {
                        ((ItemFrequency)itemNode.Tag).Frequency += currentTranItemFrequency;
                        itemNode.Text = item + ":" + ((ItemFrequency)itemNode.Tag).Frequency.ToString();
                    }

                    tran.RemoveAll(t => t == item);

                    SetTran(tran, itemNode, items);
                }
            }
        }



        private void buttonApriori_Click(object sender, EventArgs e)
        {
            List<ItemFrequency> itemFrequencies = new List<ItemFrequency>();

            int minSup = Convert.ToInt32(numericUpDownMinSup.Value);
            var allTrans = _allTransactions.ToList();
            int preferedDimsCount = Convert.ToInt32(numericUpDownPreferDimCountApriori.Value);
            var allSubsets = SubsetsOf(_dimensions.Where(d => Convert.ToInt32(d) < preferedDimsCount));
            for (int i = 0; i <= preferedDimsCount; i++)
            {
                var currentSubsets = allSubsets.Where(d => d.Count() == i);
                foreach (var subset in currentSubsets)
                {
                    int currentFrequency = allTrans.Count(t => !subset.Except(t).Any());
                    if (currentFrequency >= minSup)
                    {
                        itemFrequencies.Add(new ItemFrequency() { Item = "{" + string.Join(",", subset) + "}", Frequency = currentFrequency });
                    }
                    else
                    {
                        allTrans.RemoveAll(t => !subset.Except(t).Any());
                    }
                }

            }

            dataGridViewApriori.DataSource = itemFrequencies;

        }

        public static IEnumerable<IEnumerable<T>> SubsetsOf<T>(IEnumerable<T> source)
        {
            if (!source.Any())
            {
                return Enumerable.Repeat(Enumerable.Empty<T>(), 1);
            }

            var element = source.Take(1);

            var haveNots = SubsetsOf(source.Skip(1));
            var haves = haveNots.Select(set => element.Concat(set));

            return haves.Concat(haveNots);
        }
    }
}
