using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IcbergCubeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Cuboid> _cuboids;

        List<string[]> _allTransactions;
        List<string> _dimensions;

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
            numericUpDownPreferDimCount.Enabled = true;

            numericUpDownMinSup.Minimum = 0;
            numericUpDownMinSup.Maximum = _allTransactions.Count;
            numericUpDownMinSup.Enabled = true;

        }

        private void buttonCreateCuboids_Click(object sender, EventArgs e)
        {

            int preferDimsCount = Convert.ToInt32(numericUpDownPreferDimCount.Value);

            var preferDims = _dimensions.OrderBy(d => Convert.ToInt32(d)).Take(preferDimsCount).ToArray();


            _cuboids = new List<Cuboid>();

            for (int i = 0; i < Math.Pow(2, preferDimsCount); i++)
            {
                string[] combination = new string[preferDimsCount];
                for (int j = 0; j < preferDimsCount; j++)
                {
                    if ((i & (1 << (preferDimsCount - j - 1))) != 0)
                    {
                        combination[j] = preferDims[j];
                    }
                }

                var cares = new bool[preferDimsCount];
                for (int j = 0; j < combination.Length; j++)
                {
                    cares[j] = combination[j] != null;
                }
                _cuboids.Add(new Cuboid()
                {
                    Care = cares,
                    //Aggregates = 0,
                });
            }




            foreach (var currentCuboid in _cuboids)
            {
                List<DimAggregate> aggreagates = new List<DimAggregate>();


                int cuboidCareCount = currentCuboid.Care.Count(c => c);

                for (int i = 0; i < Math.Pow(2, cuboidCareCount); i++)
                {
                    string[] combination = new string[cuboidCareCount];
                    for (int j = 0; j < cuboidCareCount; j++)
                    {
                        if ((i & (1 << (cuboidCareCount - j - 1))) != 0)
                        {
                            combination[j] = preferDims[j];
                        }
                    }

                    var presentations = new bool[cuboidCareCount];
                    for (int j = 0; j < combination.Length; j++)
                    {
                        presentations[j] = combination[j] != null;
                    }


                    var currentCuboidTransactions = _allTransactions.ToList();

                    int currentDimIndex = 0;
                    for (int j = 0; j < currentCuboid.Care.Length; j++)
                    {
                        if (currentCuboid.Care[j])
                        {
                            if (presentations[currentDimIndex])
                            {
                                currentCuboidTransactions.RemoveAll(t => !t.Contains(j.ToString()));
                            }
                            else
                            {
                                currentCuboidTransactions.RemoveAll(t => t.Contains(j.ToString()));
                            }

                            currentDimIndex++;
                        }

                    }


                    aggreagates.Add(new DimAggregate()
                    {
                        Presentation = presentations,
                        Aggregate = currentCuboidTransactions.Count
                    });

                }

                currentCuboid.Aggregates = aggreagates.ToArray();
            }



            DataTable dt = new DataTable();
            for (int i = 0; i < preferDimsCount; i++)
            {
                dt.Columns.Add(i.ToString());
            }

            dataGridViewDims.Columns.Clear();

            DataRow dr = dt.NewRow();

            for (int i = 0; i < preferDimsCount; i++)
            {
                DataGridViewComboBoxColumn comboboxColumn = new DataGridViewComboBoxColumn();
                comboboxColumn.HeaderText = i.ToString();
                comboboxColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                comboboxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                comboboxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                comboboxColumn.DataPropertyName = i.ToString();
                comboboxColumn.DataSource = new string[] { "*", "Select" };
                dataGridViewDims.Columns.Add(comboboxColumn);

                dr[i] = "*";
            }
            dt.Rows.Add(dr);
            dataGridViewDims.DataSource = dt;

            SetGridCuboidValues(_cuboids.SingleOrDefault(c => c.Index == 0));

        }

        private void dataGridViewDims_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            var SelectedCuboidCares = new bool[Convert.ToInt32(numericUpDownPreferDimCount.Value)];

            foreach (DataGridViewColumn column in dataGridViewDims.Columns)
            {
                if (column.GetType() == typeof(DataGridViewComboBoxColumn))
                    SelectedCuboidCares[column.Index] = dataGridViewDims.Rows[e.RowIndex].Cells[column.Index].Value.ToString() == "*" ? false : true;
            }


            var selectedCuboid = _cuboids.SingleOrDefault(c => c.Index == GetIntegerValue(SelectedCuboidCares));
            if (selectedCuboid == null)
            {
                MessageBox.Show("Cuboid Unavailable!");
                return;
            }

            SetGridCuboidValues(selectedCuboid);

        }

        private void SetGridCuboidValues(Cuboid cuboid)
        {
            DataTable dt = new DataTable();
            dataGridViewCuboid.Columns.Clear();

            string aggregateIndex = "AggregateIndex";
            dt.Columns.Add(aggregateIndex);
            DataGridViewTextBoxColumn aggregateIndexColumn = new DataGridViewTextBoxColumn();
            aggregateIndexColumn.HeaderText = "Aggregate Index";
            aggregateIndexColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            aggregateIndexColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            aggregateIndexColumn.DefaultCellStyle.BackColor = Color.LightGray;
            aggregateIndexColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            aggregateIndexColumn.DataPropertyName = aggregateIndex;
            dataGridViewCuboid.Columns.Add(aggregateIndexColumn);

            for (int i = 0; i < cuboid.Care.Length; i++)
            {
                dt.Columns.Add(i.ToString());

                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = i.ToString();
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.DataPropertyName = i.ToString();
                dataGridViewCuboid.Columns.Add(column);
            }

            string agg = "Aggregate";
            dt.Columns.Add(agg);
            DataGridViewTextBoxColumn aggregateColumn = new DataGridViewTextBoxColumn();
            aggregateColumn.HeaderText = agg;
            aggregateColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            aggregateColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            aggregateColumn.DefaultCellStyle.BackColor = Color.LightGreen;
            aggregateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            aggregateColumn.DataPropertyName = agg;
            dataGridViewCuboid.Columns.Add(aggregateColumn);


            foreach (var currentAggregate in cuboid.Aggregates)
            {
                if (currentAggregate.Aggregate >= Convert.ToInt32(numericUpDownMinSup.Value))
                {
                    DataRow dr = dt.NewRow();

                    dr[agg] = currentAggregate.Aggregate;
                    dr[aggregateIndex] = "#" + currentAggregate.Index;

                    int presentIndex = 0;
                    for (int i = 0; i < cuboid.Care.Length; i++)
                    {
                        if (cuboid.Care[i])
                        {
                            dr[i.ToString()] = currentAggregate.Presentation[presentIndex] ? "1" : "0";
                            presentIndex++;
                        }
                        else
                        {
                            dr[i.ToString()] = "*";
                        }
                    }

                    dt.Rows.Add(dr);
                }
            }


            dataGridViewCuboid.DataSource = dt;
            dataGridViewCuboid.ClearSelection();

            dataGridViewCuboid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridViewCuboid.EnableHeadersVisualStyles = false;
        }

        private int GetIntegerValue(bool[] booleanArray)
        {
            int sumBase = 0;
            for (int i = 0; i < booleanArray.Length; i++)
            {
                sumBase += (booleanArray[i] ? 1 : 0) * (Convert.ToInt32(Math.Pow(2, i)));
            }

            return sumBase;
        }

        private void numericUpDownMinSup_ValueChanged(object sender, EventArgs e)
        {
            var SelectedCuboidCares = new bool[Convert.ToInt32(numericUpDownPreferDimCount.Value)];

            foreach (DataGridViewColumn column in dataGridViewDims.Columns)
            {
                if (column.GetType() == typeof(DataGridViewComboBoxColumn))
                    SelectedCuboidCares[column.Index] = dataGridViewDims.Rows[0].Cells[column.Index].Value.ToString() == "*" ? false : true;
            }


            var selectedCuboid = _cuboids.SingleOrDefault(c => c.Index == GetIntegerValue(SelectedCuboidCares));
            if (selectedCuboid == null)
            {
                MessageBox.Show("Cuboid Unavailable!");
                return;
            }

            SetGridCuboidValues(selectedCuboid);
        }

    }
}
