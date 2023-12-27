using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CmarProject
{
    public partial class Form1 : Form
    {
        List<Dimension> _items;
        List<string[]> _allTrans;
        List<TransactionInfo> _allTransactions;
        List<ItemFrequency> _itemsFrequencies;
        List<Rule> _rules;

        public Form1()
        {
            InitializeComponent();
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

            _items = new List<Dimension>();
            _allTrans = new List<string[]>();
            _allTransactions = new List<TransactionInfo>();

            var allTrans = File.ReadAllLines(textBoxTransactionFile.Text);

            bool dataReached = false;
            for (int i = 0; i < allTrans.Length; i++)
            {
                if (dataReached)
                {
                    var currentTrans = allTrans[i].Trim().Split(',');
                    _allTrans.Add(currentTrans);

                    List<string> tran = new List<string>();
                    string className = "";
                    for (int j = 0; j < currentTrans.Length; j++)
                    {

                        if (currentTrans[j] == "t")
                        {
                            tran.Add(j.ToString());
                        }
                        else if (currentTrans[j] != "t")
                        {
                            className = currentTrans[j];
                        }
                    }

                    _allTransactions.Add(new TransactionInfo()
                    {
                        Transaction = tran.ToArray(),
                        ClassName = className,
                    });

                }
                else
                {
                    if (allTrans[i].StartsWith("@attribute"))
                    {
                        int indexNameStart = allTrans[i].IndexOf("'");
                        int indexNameFinish = allTrans[i].IndexOf("'", indexNameStart + 1);
                        string itemName = allTrans[i].Substring(indexNameStart + 1, indexNameFinish - indexNameStart - 1);

                        _items.Add(new Dimension()
                        {
                            Index = i,
                            Name = itemName,
                        });
                    }
                    else if (allTrans[i].StartsWith("@data"))
                    {
                        _items.Last().IsClassAttribute = true;
                        dataReached = true;
                    }
                }
            }

            labeltransactionsCount.Text = _allTrans.Count.ToString();
            dataGridViewItems.DataSource = _items;
            textBoxMinSup.Enabled = true;
            textBoxTrainRecords.Enabled = true;
        }

        private void buttonBrowseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxTransactionFile.Text = openFileDialog1.FileName;
            }
        }

        private void buttonLoadItemFrequency_Click(object sender, EventArgs e)
        {
            try
            {
                _itemsFrequencies = new List<ItemFrequency>();
                int preferdDims = _items.Count;
                int minSup = Convert.ToInt32(textBoxMinSup.Text);
                foreach (var item in _allTransactions)
                {
                    for (int i = 0; i < item.Transaction.Length; i++)
                    {
                        if (Convert.ToInt32(item.Transaction[i]) < preferdDims)
                        {
                            var currentFreq = _itemsFrequencies.FirstOrDefault(f => f.Item == item.Transaction[i]);
                            if (currentFreq == null)
                            {
                                _itemsFrequencies.Add(new ItemFrequency() { Item = item.Transaction[i], Frequency = 1 });
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

                int trainRecordsCount = Convert.ToInt32(textBoxTrainRecords.Text);
                for (int i = 0; i < trainRecordsCount; i++)
                {
                    SetTran(_allTransactions[i].Transaction.ToList(), treeViewFP.Nodes[0], items, trainRecordsCount, _allTransactions[i].ClassName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetTran(List<string> tran, TreeNode treeNode, string[] items, int totalRecords, string className)
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

                    double conf = 0;
                    if (itemNode == null)
                    {
                        conf = ((double)currentTranItemFrequency / totalRecords) * 100;
                        itemNode = new TreeNode();
                        itemNode.Text = item + ":" + currentTranItemFrequency.ToString() + "," + conf.ToString("0.00");
                        itemNode.Tag = new ItemFrequency() { Item = item, Frequency = currentTranItemFrequency, Confidency = conf };

                        treeNode.Nodes.Add(itemNode);
                    }
                    else
                    {
                        ((ItemFrequency)itemNode.Tag).Frequency += currentTranItemFrequency;
                        conf = ((double)((ItemFrequency)itemNode.Tag).Frequency / totalRecords) * 100;
                        ((ItemFrequency)itemNode.Tag).Confidency = conf;
                        itemNode.Text = item + ":" + ((ItemFrequency)itemNode.Tag).Frequency.ToString() + "," + conf.ToString("0.00");
                    }

                    tran.RemoveAll(t => t == item);

                    if (tran.Count == 0)
                    {
                        ((ItemFrequency)itemNode.Tag).ClassName = className;
                        itemNode.Text = item + ":" + className + "," + ((ItemFrequency)itemNode.Tag).Frequency.ToString() + "," + conf.ToString("0.00");
                    }

                    SetTran(tran, itemNode, items, totalRecords, className);
                }
            }

        }


        private void buttonRules_Click(object sender, EventArgs e)
        {
            _rules = new List<Rule>();

            foreach (TreeNode node in treeViewFP.Nodes)
            {
                TraceRule(node);
            }

            labelRulesCount.Text = _rules.Count.ToString();
            dataGridViewRules.DataSource = _rules;
        }

        private void TraceRule(TreeNode node)
        {
            if (node.Nodes.Count == 0)
            {
                var rules = GetRules(node);
                _rules.Add(new Rule()
                {
                    Index = _rules.Count + 1,
                    ClassName = ((ItemFrequency)node.Tag).ClassName,
                    Items = rules.Select(r => r.Item).ToList(),
                    Conf = ((ItemFrequency)node.Tag).Confidency,
                    Sup = ((ItemFrequency)node.Tag).Frequency,
                });
            }
            else
            {
                foreach (TreeNode child in node.Nodes)
                {
                    TraceRule(child);
                }
            }
        }

        private List<ItemFrequency> GetRules(TreeNode node)
        {
            List<ItemFrequency> rules = new List<ItemFrequency>();
            if (((ItemFrequency)node.Tag).Item != "-1")
            {
                rules.Add(new ItemFrequency()
                {
                    Item = ((ItemFrequency)node.Tag).Item,
                    Frequency = ((ItemFrequency)node.Tag).Frequency,
                    Confidency = ((ItemFrequency)node.Tag).Confidency
                });
            }

            if (node.Parent != null)
            {
                rules.AddRange(GetRules(node.Parent));
            }

            return rules;
        }


        private void buttonPrune_Click(object sender, EventArgs e)
        {
            foreach (var R1 in _rules.Where(r => !r.Pruned))
            {
                foreach (var R2 in _rules.Where(r => (!r.Pruned) && r.Index != R1.Index))
                {
                    bool isGeneral = !R1.Items.Except(R2.Items).Any();
                    bool hasHigherRank = false;

                    if (R1.Conf > R2.Conf)
                    {
                        hasHigherRank = true;

                    }
                    else if (R1.Conf == R2.Conf && R1.Sup > R2.Sup)
                    {
                        hasHigherRank = true;
                    }
                    else if (R1.Conf == R2.Conf && R1.Sup == R2.Sup && R1.Items.Count < R2.Items.Count)
                    {
                        hasHigherRank = true;
                    }

                    if (isGeneral && hasHigherRank)
                    {
                        R2.Pruned = true;
                    }
                }
            }

            _rules.RemoveAll(r => r.Pruned);
            labelRulesCount.Text = _rules.Count().ToString();
            dataGridViewRules.DataSource = _rules.ToList();

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {

            int trainCount = Convert.ToInt32(textBoxTrainRecords.Text);
            int testTotal = 0;
            int testCorrect = 0;

            List<MatchResult> results = new List<MatchResult>();

            for (int i = trainCount; i < _allTransactions.Count; i++)
            {
               

                List<Rule> matchedRules = new List<Rule>();

                foreach (var rule in _rules.Where(r => !r.Pruned))
                {

                    //check subsetting
                    if (!rule.Items.ToArray().Except(_allTransactions[i].Transaction).Any())
                    {
                        var intersect = rule.Items.Intersect(_allTransactions[i].Transaction);
                        //if (_allTransactions[i].Transaction.Length - intersect.Count() < 5)
                        //{
                        //    matchedRules.Add(rule);
                        //}
                        matchedRules.Add(rule);
                    }
                }

                List<MatchedRule> ruleGroup = new List<MatchedRule>();
                foreach (var rule in matchedRules)
                {
                    var currentGroup = ruleGroup.FirstOrDefault(r => r.ClassName == rule.ClassName);
                    if (currentGroup == null)
                    {
                        ruleGroup.Add(new MatchedRule()
                        {
                            ClassName = rule.ClassName,
                            Sup = rule.Sup,
                            Conf = rule.Conf,
                        });
                    }
                    else
                    {
                        currentGroup.Sup += rule.Sup;
                        currentGroup.Conf += rule.Conf;
                    }
                }

                if (ruleGroup.Count > 0)
                {
                    var selectedRuleGroup = ruleGroup.OrderByDescending(r => r.Conf * r.Sup).First();
                    testTotal++;
                    MatchResult currentResult = new MatchResult()
                    {
                        Index = i - trainCount + 1,
                        ClassName = _allTransactions[i].ClassName,
                    };
                    currentResult.ClassNameResult = selectedRuleGroup.ClassName;
                    if (_allTransactions[i].ClassName == selectedRuleGroup.ClassName)
                    {
                        testCorrect++;

                        currentResult.Result = true;
                    }
                    results.Add(currentResult);
                }

            }

            labelTestResult.Text = ((double)testCorrect / testTotal * 100).ToString("0.00") + "%   " + testCorrect.ToString();
            labelTotalTest.Text = testTotal.ToString();
            dataGridViewResults.DataSource = results;
        }

        private void dataGridViewResults_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Myrow in dataGridViewResults.Rows)
                if ((bool)Myrow.Cells[3].Value)
                {
                    Myrow.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.LightPink;
                }
        }
    }


}
