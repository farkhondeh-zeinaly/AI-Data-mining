namespace FPGrowth
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDimCount = new System.Windows.Forms.Label();
            this.labeltransactionsCount = new System.Windows.Forms.Label();
            this.buttonLoadTransaction = new System.Windows.Forms.Button();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.textBoxTransactionFile = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonFPTree = new System.Windows.Forms.Button();
            this.treeViewFP = new System.Windows.Forms.TreeView();
            this.textBoxMinSup = new System.Windows.Forms.TextBox();
            this.dataGridViewItemsFrequency = new System.Windows.Forms.DataGridView();
            this.ColumnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnfrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLoadItemFrequency = new System.Windows.Forms.Button();
            this.numericUpDownPreferDimCount = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewApriori = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonApriori = new System.Windows.Forms.Button();
            this.numericUpDownMinSup = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPreferDimCountApriori = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreferDimCount)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApriori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreferDimCountApriori)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(184, 91);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 13);
            label4.TabIndex = 8;
            label4.Text = "اندازه ابعاد:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(560, 26);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 13);
            label2.TabIndex = 5;
            label2.Text = "فایل تراکنش ها:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(184, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 13);
            label1.TabIndex = 0;
            label1.Text = "تعداد رکورد خوانده شده:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(25, 55);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(47, 13);
            label6.TabIndex = 28;
            label6.Text = "FP_Tree";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(533, 50);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 13);
            label5.TabIndex = 22;
            label5.Text = "Min_Sup:";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(533, 23);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(92, 13);
            label3.TabIndex = 20;
            label3.Text = "تعداد ابعاد مطلوب:";
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(533, 50);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(51, 13);
            label7.TabIndex = 28;
            label7.Text = "Min_Sup:";
            // 
            // label8
            // 
            label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(533, 23);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(92, 13);
            label8.TabIndex = 26;
            label8.Text = "تعداد ابعاد مطلوب:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelDimCount);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.labeltransactionsCount);
            this.groupBox1.Controls.Add(this.buttonLoadTransaction);
            this.groupBox1.Controls.Add(this.buttonBrowseFile);
            this.groupBox1.Controls.Add(this.textBoxTransactionFile);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(658, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنظیمات";
            // 
            // labelDimCount
            // 
            this.labelDimCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDimCount.AutoSize = true;
            this.labelDimCount.Location = new System.Drawing.Point(98, 91);
            this.labelDimCount.Name = "labelDimCount";
            this.labelDimCount.Size = new System.Drawing.Size(11, 13);
            this.labelDimCount.TabIndex = 9;
            this.labelDimCount.Text = "-";
            // 
            // labeltransactionsCount
            // 
            this.labeltransactionsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltransactionsCount.AutoSize = true;
            this.labeltransactionsCount.Location = new System.Drawing.Point(98, 67);
            this.labeltransactionsCount.Name = "labeltransactionsCount";
            this.labeltransactionsCount.Size = new System.Drawing.Size(11, 13);
            this.labeltransactionsCount.TabIndex = 4;
            this.labeltransactionsCount.Text = "-";
            // 
            // buttonLoadTransaction
            // 
            this.buttonLoadTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadTransaction.Location = new System.Drawing.Point(385, 58);
            this.buttonLoadTransaction.Name = "buttonLoadTransaction";
            this.buttonLoadTransaction.Size = new System.Drawing.Size(169, 30);
            this.buttonLoadTransaction.TabIndex = 3;
            this.buttonLoadTransaction.Text = "بارگزاری تراکنش ها";
            this.buttonLoadTransaction.UseVisualStyleBackColor = true;
            this.buttonLoadTransaction.Click += new System.EventHandler(this.buttonLoadTransaction_Click);
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseFile.Location = new System.Drawing.Point(17, 21);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFile.TabIndex = 2;
            this.buttonBrowseFile.Text = "Browse";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.buttonBrowseFile_Click);
            // 
            // textBoxTransactionFile
            // 
            this.textBoxTransactionFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTransactionFile.Location = new System.Drawing.Point(98, 23);
            this.textBoxTransactionFile.Name = "textBoxTransactionFile";
            this.textBoxTransactionFile.ReadOnly = true;
            this.textBoxTransactionFile.Size = new System.Drawing.Size(456, 21);
            this.textBoxTransactionFile.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 134);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 387);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(label6);
            this.tabPage1.Controls.Add(this.buttonFPTree);
            this.tabPage1.Controls.Add(this.treeViewFP);
            this.tabPage1.Controls.Add(this.textBoxMinSup);
            this.tabPage1.Controls.Add(label5);
            this.tabPage1.Controls.Add(this.dataGridViewItemsFrequency);
            this.tabPage1.Controls.Add(this.buttonLoadItemFrequency);
            this.tabPage1.Controls.Add(this.numericUpDownPreferDimCount);
            this.tabPage1.Controls.Add(label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage1.Size = new System.Drawing.Size(650, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FP_Growth";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonFPTree
            // 
            this.buttonFPTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFPTree.Location = new System.Drawing.Point(204, 19);
            this.buttonFPTree.Name = "buttonFPTree";
            this.buttonFPTree.Size = new System.Drawing.Size(134, 49);
            this.buttonFPTree.TabIndex = 27;
            this.buttonFPTree.Text = "ساخت درخت FP_Tree";
            this.buttonFPTree.UseVisualStyleBackColor = true;
            this.buttonFPTree.Click += new System.EventHandler(this.buttonFPTree_Click);
            // 
            // treeViewFP
            // 
            this.treeViewFP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewFP.Location = new System.Drawing.Point(25, 74);
            this.treeViewFP.Name = "treeViewFP";
            this.treeViewFP.Size = new System.Drawing.Size(313, 268);
            this.treeViewFP.TabIndex = 26;
            // 
            // textBoxMinSup
            // 
            this.textBoxMinSup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMinSup.Enabled = false;
            this.textBoxMinSup.Location = new System.Drawing.Point(444, 47);
            this.textBoxMinSup.Name = "textBoxMinSup";
            this.textBoxMinSup.Size = new System.Drawing.Size(83, 21);
            this.textBoxMinSup.TabIndex = 25;
            this.textBoxMinSup.Text = "0";
            this.textBoxMinSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewItemsFrequency
            // 
            this.dataGridViewItemsFrequency.AllowUserToAddRows = false;
            this.dataGridViewItemsFrequency.AllowUserToDeleteRows = false;
            this.dataGridViewItemsFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItemsFrequency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemsFrequency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItem,
            this.Columnfrequency});
            this.dataGridViewItemsFrequency.Location = new System.Drawing.Point(344, 74);
            this.dataGridViewItemsFrequency.Name = "dataGridViewItemsFrequency";
            this.dataGridViewItemsFrequency.ReadOnly = true;
            this.dataGridViewItemsFrequency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItemsFrequency.Size = new System.Drawing.Size(278, 268);
            this.dataGridViewItemsFrequency.TabIndex = 24;
            // 
            // ColumnItem
            // 
            this.ColumnItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnItem.DataPropertyName = "Item";
            this.ColumnItem.HeaderText = "آیتم";
            this.ColumnItem.Name = "ColumnItem";
            this.ColumnItem.ReadOnly = true;
            // 
            // Columnfrequency
            // 
            this.Columnfrequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Columnfrequency.DataPropertyName = "Frequency";
            this.Columnfrequency.HeaderText = "تعداد تکرار";
            this.Columnfrequency.Name = "Columnfrequency";
            this.Columnfrequency.ReadOnly = true;
            // 
            // buttonLoadItemFrequency
            // 
            this.buttonLoadItemFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadItemFrequency.Location = new System.Drawing.Point(344, 19);
            this.buttonLoadItemFrequency.Name = "buttonLoadItemFrequency";
            this.buttonLoadItemFrequency.Size = new System.Drawing.Size(94, 49);
            this.buttonLoadItemFrequency.TabIndex = 23;
            this.buttonLoadItemFrequency.Text = "ساخت جدول تعداد تکرار";
            this.buttonLoadItemFrequency.UseVisualStyleBackColor = true;
            this.buttonLoadItemFrequency.Click += new System.EventHandler(this.buttonLoadItemFrequency_Click);
            // 
            // numericUpDownPreferDimCount
            // 
            this.numericUpDownPreferDimCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPreferDimCount.Enabled = false;
            this.numericUpDownPreferDimCount.Location = new System.Drawing.Point(444, 19);
            this.numericUpDownPreferDimCount.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownPreferDimCount.Name = "numericUpDownPreferDimCount";
            this.numericUpDownPreferDimCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownPreferDimCount.Size = new System.Drawing.Size(83, 21);
            this.numericUpDownPreferDimCount.TabIndex = 21;
            this.numericUpDownPreferDimCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewApriori);
            this.tabPage2.Controls.Add(this.buttonApriori);
            this.tabPage2.Controls.Add(this.numericUpDownMinSup);
            this.tabPage2.Controls.Add(label7);
            this.tabPage2.Controls.Add(this.numericUpDownPreferDimCountApriori);
            this.tabPage2.Controls.Add(label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage2.Size = new System.Drawing.Size(650, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Apriori";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewApriori
            // 
            this.dataGridViewApriori.AllowUserToAddRows = false;
            this.dataGridViewApriori.AllowUserToDeleteRows = false;
            this.dataGridViewApriori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewApriori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApriori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewApriori.Location = new System.Drawing.Point(13, 19);
            this.dataGridViewApriori.Name = "dataGridViewApriori";
            this.dataGridViewApriori.ReadOnly = true;
            this.dataGridViewApriori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewApriori.Size = new System.Drawing.Size(414, 336);
            this.dataGridViewApriori.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn1.HeaderText = "آیتم";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Frequency";
            this.dataGridViewTextBoxColumn2.HeaderText = "تعداد تکرار";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // buttonApriori
            // 
            this.buttonApriori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApriori.Location = new System.Drawing.Point(444, 75);
            this.buttonApriori.Name = "buttonApriori";
            this.buttonApriori.Size = new System.Drawing.Size(83, 38);
            this.buttonApriori.TabIndex = 30;
            this.buttonApriori.Text = "انجام عملیات";
            this.buttonApriori.UseVisualStyleBackColor = true;
            this.buttonApriori.Click += new System.EventHandler(this.buttonApriori_Click);
            // 
            // numericUpDownMinSup
            // 
            this.numericUpDownMinSup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownMinSup.Enabled = false;
            this.numericUpDownMinSup.Location = new System.Drawing.Point(444, 48);
            this.numericUpDownMinSup.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownMinSup.Name = "numericUpDownMinSup";
            this.numericUpDownMinSup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownMinSup.Size = new System.Drawing.Size(83, 21);
            this.numericUpDownMinSup.TabIndex = 29;
            this.numericUpDownMinSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownPreferDimCountApriori
            // 
            this.numericUpDownPreferDimCountApriori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPreferDimCountApriori.Enabled = false;
            this.numericUpDownPreferDimCountApriori.Location = new System.Drawing.Point(444, 19);
            this.numericUpDownPreferDimCountApriori.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownPreferDimCountApriori.Name = "numericUpDownPreferDimCountApriori";
            this.numericUpDownPreferDimCountApriori.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownPreferDimCountApriori.Size = new System.Drawing.Size(83, 21);
            this.numericUpDownPreferDimCountApriori.TabIndex = 27;
            this.numericUpDownPreferDimCountApriori.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 533);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MinimumSize = new System.Drawing.Size(698, 572);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FP_Growth via Apriori";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreferDimCount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApriori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreferDimCountApriori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDimCount;
        private System.Windows.Forms.Label labeltransactionsCount;
        private System.Windows.Forms.Button buttonLoadTransaction;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.TextBox textBoxTransactionFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonFPTree;
        private System.Windows.Forms.TreeView treeViewFP;
        private System.Windows.Forms.TextBox textBoxMinSup;
        private System.Windows.Forms.DataGridView dataGridViewItemsFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnfrequency;
        private System.Windows.Forms.Button buttonLoadItemFrequency;
        private System.Windows.Forms.NumericUpDown numericUpDownPreferDimCount;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numericUpDownMinSup;
        private System.Windows.Forms.NumericUpDown numericUpDownPreferDimCountApriori;
        private System.Windows.Forms.DataGridView dataGridViewApriori;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonApriori;
    }
}

