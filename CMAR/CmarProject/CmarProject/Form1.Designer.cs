namespace CmarProject
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label4;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ColumnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnfrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsClassAttribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labeltransactionsCount = new System.Windows.Forms.Label();
            this.buttonLoadTransaction = new System.Windows.Forms.Button();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.textBoxTransactionFile = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxTrainRecords = new System.Windows.Forms.TextBox();
            this.buttonFPTree = new System.Windows.Forms.Button();
            this.treeViewFP = new System.Windows.Forms.TreeView();
            this.textBoxMinSup = new System.Windows.Forms.TextBox();
            this.dataGridViewItemsFrequency = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConfidency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLoadItemFrequency = new System.Windows.Forms.Button();
            this.buttonPrune = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelRulesCount = new System.Windows.Forms.Label();
            this.buttonRules = new System.Windows.Forms.Button();
            this.dataGridViewRules = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRuleText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPruned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelTestResult = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.labelTotalTest = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassNameResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsFrequency)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRules)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(362, 26);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 13);
            label2.TabIndex = 5;
            label2.Text = "فایل تراکنش ها:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(110, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 13);
            label1.TabIndex = 0;
            label1.Text = "تعداد رکوردهای داده:";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(654, 29);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 13);
            label5.TabIndex = 31;
            label5.Text = "Min_Sup:";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(305, 26);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(103, 13);
            label3.TabIndex = 38;
            label3.Text = "تعداد رکورد آموزشی:";
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(361, 30);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(65, 13);
            label7.TabIndex = 36;
            label7.Text = "تعداد قوانین:";
            // 
            // label8
            // 
            label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(130, 20);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(112, 13);
            label8.TabIndex = 38;
            label8.Text = "تعداد داده های تستی:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewItems);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.labeltransactionsCount);
            this.groupBox1.Controls.Add(this.buttonLoadTransaction);
            this.groupBox1.Controls.Add(this.buttonBrowseFile);
            this.groupBox1.Controls.Add(this.textBoxTransactionFile);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Location = new System.Drawing.Point(734, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(460, 524);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنظیمات";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItem,
            this.Columnfrequency,
            this.ColumnIsClassAttribute});
            this.dataGridViewItems.Location = new System.Drawing.Point(15, 106);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.ReadOnly = true;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(439, 412);
            this.dataGridViewItems.TabIndex = 25;
            // 
            // ColumnItem
            // 
            this.ColumnItem.DataPropertyName = "Index";
            this.ColumnItem.HeaderText = "#";
            this.ColumnItem.Name = "ColumnItem";
            this.ColumnItem.ReadOnly = true;
            this.ColumnItem.Width = 50;
            // 
            // Columnfrequency
            // 
            this.Columnfrequency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Columnfrequency.DataPropertyName = "Name";
            this.Columnfrequency.HeaderText = "آیتم";
            this.Columnfrequency.Name = "Columnfrequency";
            this.Columnfrequency.ReadOnly = true;
            // 
            // ColumnIsClassAttribute
            // 
            this.ColumnIsClassAttribute.DataPropertyName = "IsClassAttribute";
            this.ColumnIsClassAttribute.HeaderText = "کلاس";
            this.ColumnIsClassAttribute.Name = "ColumnIsClassAttribute";
            this.ColumnIsClassAttribute.ReadOnly = true;
            this.ColumnIsClassAttribute.Width = 70;
            // 
            // labeltransactionsCount
            // 
            this.labeltransactionsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltransactionsCount.AutoSize = true;
            this.labeltransactionsCount.Location = new System.Drawing.Point(15, 67);
            this.labeltransactionsCount.Name = "labeltransactionsCount";
            this.labeltransactionsCount.Size = new System.Drawing.Size(11, 13);
            this.labeltransactionsCount.TabIndex = 4;
            this.labeltransactionsCount.Text = "-";
            // 
            // buttonLoadTransaction
            // 
            this.buttonLoadTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadTransaction.Location = new System.Drawing.Point(245, 58);
            this.buttonLoadTransaction.Name = "buttonLoadTransaction";
            this.buttonLoadTransaction.Size = new System.Drawing.Size(111, 30);
            this.buttonLoadTransaction.TabIndex = 3;
            this.buttonLoadTransaction.Text = "بارگزاری تراکنش ها";
            this.buttonLoadTransaction.UseVisualStyleBackColor = true;
            this.buttonLoadTransaction.Click += new System.EventHandler(this.buttonLoadTransaction_Click);
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseFile.Location = new System.Drawing.Point(15, 21);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(89, 23);
            this.buttonBrowseFile.TabIndex = 2;
            this.buttonBrowseFile.Text = "Browse";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.buttonBrowseFile_Click);
            // 
            // textBoxTransactionFile
            // 
            this.textBoxTransactionFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTransactionFile.Location = new System.Drawing.Point(110, 23);
            this.textBoxTransactionFile.Name = "textBoxTransactionFile";
            this.textBoxTransactionFile.ReadOnly = true;
            this.textBoxTransactionFile.Size = new System.Drawing.Size(246, 21);
            this.textBoxTransactionFile.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.textBoxTrainRecords);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.buttonFPTree);
            this.groupBox2.Controls.Add(this.treeViewFP);
            this.groupBox2.Controls.Add(this.textBoxMinSup);
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(this.dataGridViewItemsFrequency);
            this.groupBox2.Controls.Add(this.buttonLoadItemFrequency);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(716, 524);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CR_Tree";
            // 
            // textBoxTrainRecords
            // 
            this.textBoxTrainRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTrainRecords.Enabled = false;
            this.textBoxTrainRecords.Location = new System.Drawing.Point(216, 23);
            this.textBoxTrainRecords.Name = "textBoxTrainRecords";
            this.textBoxTrainRecords.Size = new System.Drawing.Size(83, 21);
            this.textBoxTrainRecords.TabIndex = 39;
            this.textBoxTrainRecords.Text = "0";
            this.textBoxTrainRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonFPTree
            // 
            this.buttonFPTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFPTree.Location = new System.Drawing.Point(76, 12);
            this.buttonFPTree.Name = "buttonFPTree";
            this.buttonFPTree.Size = new System.Drawing.Size(134, 32);
            this.buttonFPTree.TabIndex = 36;
            this.buttonFPTree.Text = "ساخت درخت CR_Tree";
            this.buttonFPTree.UseVisualStyleBackColor = true;
            this.buttonFPTree.Click += new System.EventHandler(this.buttonFPTree_Click);
            // 
            // treeViewFP
            // 
            this.treeViewFP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewFP.Location = new System.Drawing.Point(11, 58);
            this.treeViewFP.Name = "treeViewFP";
            this.treeViewFP.Size = new System.Drawing.Size(397, 460);
            this.treeViewFP.TabIndex = 35;
            // 
            // textBoxMinSup
            // 
            this.textBoxMinSup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMinSup.Enabled = false;
            this.textBoxMinSup.Location = new System.Drawing.Point(565, 26);
            this.textBoxMinSup.Name = "textBoxMinSup";
            this.textBoxMinSup.Size = new System.Drawing.Size(83, 21);
            this.textBoxMinSup.TabIndex = 34;
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
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ColumnConfidency,
            this.ColumnClassName});
            this.dataGridViewItemsFrequency.Location = new System.Drawing.Point(414, 58);
            this.dataGridViewItemsFrequency.Name = "dataGridViewItemsFrequency";
            this.dataGridViewItemsFrequency.ReadOnly = true;
            this.dataGridViewItemsFrequency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItemsFrequency.Size = new System.Drawing.Size(288, 460);
            this.dataGridViewItemsFrequency.TabIndex = 33;
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
            // ColumnConfidency
            // 
            this.ColumnConfidency.DataPropertyName = "Confidency";
            this.ColumnConfidency.HeaderText = "Confidency";
            this.ColumnConfidency.Name = "ColumnConfidency";
            this.ColumnConfidency.ReadOnly = true;
            this.ColumnConfidency.Visible = false;
            // 
            // ColumnClassName
            // 
            this.ColumnClassName.DataPropertyName = "ClassName";
            this.ColumnClassName.HeaderText = "ClassName";
            this.ColumnClassName.Name = "ColumnClassName";
            this.ColumnClassName.ReadOnly = true;
            this.ColumnClassName.Visible = false;
            // 
            // buttonLoadItemFrequency
            // 
            this.buttonLoadItemFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadItemFrequency.Location = new System.Drawing.Point(414, 15);
            this.buttonLoadItemFrequency.Name = "buttonLoadItemFrequency";
            this.buttonLoadItemFrequency.Size = new System.Drawing.Size(145, 32);
            this.buttonLoadItemFrequency.TabIndex = 32;
            this.buttonLoadItemFrequency.Text = "ساخت جدول تعداد تکرار";
            this.buttonLoadItemFrequency.UseVisualStyleBackColor = true;
            this.buttonLoadItemFrequency.Click += new System.EventHandler(this.buttonLoadItemFrequency_Click);
            // 
            // buttonPrune
            // 
            this.buttonPrune.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrune.Location = new System.Drawing.Point(477, 20);
            this.buttonPrune.Name = "buttonPrune";
            this.buttonPrune.Size = new System.Drawing.Size(134, 32);
            this.buttonPrune.TabIndex = 33;
            this.buttonPrune.Text = "هرس کردن درخت";
            this.buttonPrune.UseVisualStyleBackColor = true;
            this.buttonPrune.Click += new System.EventHandler(this.buttonPrune_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.labelRulesCount);
            this.groupBox3.Controls.Add(label7);
            this.groupBox3.Controls.Add(this.buttonRules);
            this.groupBox3.Controls.Add(this.dataGridViewRules);
            this.groupBox3.Controls.Add(this.buttonPrune);
            this.groupBox3.Location = new System.Drawing.Point(426, 542);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(768, 315);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "قوانین";
            // 
            // labelRulesCount
            // 
            this.labelRulesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRulesCount.AutoSize = true;
            this.labelRulesCount.Location = new System.Drawing.Point(266, 30);
            this.labelRulesCount.Name = "labelRulesCount";
            this.labelRulesCount.Size = new System.Drawing.Size(11, 13);
            this.labelRulesCount.TabIndex = 37;
            this.labelRulesCount.Text = "-";
            // 
            // buttonRules
            // 
            this.buttonRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRules.Location = new System.Drawing.Point(620, 20);
            this.buttonRules.Name = "buttonRules";
            this.buttonRules.Size = new System.Drawing.Size(134, 32);
            this.buttonRules.TabIndex = 35;
            this.buttonRules.Text = "ساخت قوانین";
            this.buttonRules.UseVisualStyleBackColor = true;
            this.buttonRules.Click += new System.EventHandler(this.buttonRules_Click);
            // 
            // dataGridViewRules
            // 
            this.dataGridViewRules.AllowUserToAddRows = false;
            this.dataGridViewRules.AllowUserToDeleteRows = false;
            this.dataGridViewRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.ColumnConf,
            this.ColumnSup,
            this.ColumnRuleText,
            this.ColumnPruned,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewRules.Location = new System.Drawing.Point(6, 58);
            this.dataGridViewRules.Name = "dataGridViewRules";
            this.dataGridViewRules.ReadOnly = true;
            this.dataGridViewRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRules.Size = new System.Drawing.Size(748, 251);
            this.dataGridViewRules.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Index";
            this.dataGridViewTextBoxColumn3.HeaderText = "#";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RuleText";
            this.dataGridViewTextBoxColumn4.HeaderText = "قانون";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ColumnConf
            // 
            this.ColumnConf.DataPropertyName = "Conf";
            this.ColumnConf.HeaderText = "Conf";
            this.ColumnConf.Name = "ColumnConf";
            this.ColumnConf.ReadOnly = true;
            this.ColumnConf.Width = 70;
            // 
            // ColumnSup
            // 
            this.ColumnSup.DataPropertyName = "Sup";
            this.ColumnSup.HeaderText = "Sup";
            this.ColumnSup.Name = "ColumnSup";
            this.ColumnSup.ReadOnly = true;
            this.ColumnSup.Width = 70;
            // 
            // ColumnRuleText
            // 
            this.ColumnRuleText.DataPropertyName = "Rule";
            this.ColumnRuleText.HeaderText = "ColumnRuleText";
            this.ColumnRuleText.Name = "ColumnRuleText";
            this.ColumnRuleText.ReadOnly = true;
            this.ColumnRuleText.Visible = false;
            // 
            // ColumnPruned
            // 
            this.ColumnPruned.DataPropertyName = "Pruned";
            this.ColumnPruned.HeaderText = "Pruned";
            this.ColumnPruned.Name = "ColumnPruned";
            this.ColumnPruned.ReadOnly = true;
            this.ColumnPruned.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ClassName";
            this.dataGridViewTextBoxColumn5.HeaderText = "کلاس";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.labelTotalTest);
            this.groupBox4.Controls.Add(label4);
            this.groupBox4.Controls.Add(this.dataGridViewResults);
            this.groupBox4.Controls.Add(this.labelTestResult);
            this.groupBox4.Controls.Add(label8);
            this.groupBox4.Controls.Add(this.buttonTest);
            this.groupBox4.Location = new System.Drawing.Point(12, 542);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(405, 315);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تست";
            // 
            // labelTestResult
            // 
            this.labelTestResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTestResult.AutoSize = true;
            this.labelTestResult.Location = new System.Drawing.Point(11, 39);
            this.labelTestResult.Name = "labelTestResult";
            this.labelTestResult.Size = new System.Drawing.Size(11, 13);
            this.labelTestResult.TabIndex = 39;
            this.labelTestResult.Text = "-";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(294, 20);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(105, 32);
            this.buttonTest.TabIndex = 0;
            this.buttonTest.Text = "انجام عملیات تست";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn12,
            this.ColumnClassNameResult,
            this.ColumnResult});
            this.dataGridViewResults.Location = new System.Drawing.Point(6, 58);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ReadOnly = true;
            this.dataGridViewResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResults.Size = new System.Drawing.Size(393, 251);
            this.dataGridViewResults.TabIndex = 38;
            this.dataGridViewResults.DataSourceChanged += new System.EventHandler(this.dataGridViewResults_DataSourceChanged);
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(130, 39);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(158, 13);
            label4.TabIndex = 40;
            label4.Text = "داده های پیش بینی شده صحیح:";
            // 
            // labelTotalTest
            // 
            this.labelTotalTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalTest.AutoSize = true;
            this.labelTotalTest.Location = new System.Drawing.Point(11, 20);
            this.labelTotalTest.Name = "labelTotalTest";
            this.labelTotalTest.Size = new System.Drawing.Size(11, 13);
            this.labelTotalTest.TabIndex = 41;
            this.labelTotalTest.Text = "-";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Index";
            this.dataGridViewTextBoxColumn6.HeaderText = "#";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ClassName";
            this.dataGridViewTextBoxColumn12.HeaderText = "کلاس اصلی";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // ColumnClassNameResult
            // 
            this.ColumnClassNameResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnClassNameResult.DataPropertyName = "ClassNameResult";
            this.ColumnClassNameResult.HeaderText = "کلاس پیش بینی شده";
            this.ColumnClassNameResult.Name = "ColumnClassNameResult";
            this.ColumnClassNameResult.ReadOnly = true;
            // 
            // ColumnResult
            // 
            this.ColumnResult.DataPropertyName = "Result";
            this.ColumnResult.HeaderText = "نتیجه";
            this.ColumnResult.Name = "ColumnResult";
            this.ColumnResult.ReadOnly = true;
            this.ColumnResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 869);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMAR";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsFrequency)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRules)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Label labeltransactionsCount;
        private System.Windows.Forms.Button buttonLoadTransaction;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.TextBox textBoxTransactionFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnfrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIsClassAttribute;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFPTree;
        private System.Windows.Forms.TreeView treeViewFP;
        private System.Windows.Forms.TextBox textBoxMinSup;
        private System.Windows.Forms.DataGridView dataGridViewItemsFrequency;
        private System.Windows.Forms.Button buttonLoadItemFrequency;
        private System.Windows.Forms.TextBox textBoxTrainRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConfidency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassName;
        private System.Windows.Forms.Button buttonPrune;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewRules;
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.Label labelRulesCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRuleText;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPruned;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelTestResult;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label labelTotalTest;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassNameResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResult;
    }
}

