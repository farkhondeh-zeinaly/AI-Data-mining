namespace IcbergCubeProject
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDimCount = new System.Windows.Forms.Label();
            this.labeltransactionsCount = new System.Windows.Forms.Label();
            this.buttonLoadTransaction = new System.Windows.Forms.Button();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.textBoxTransactionFile = new System.Windows.Forms.TextBox();
            this.numericUpDownPreferDimCount = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDims = new System.Windows.Forms.DataGridView();
            this.buttonCreateCuboids = new System.Windows.Forms.Button();
            this.dataGridViewCuboid = new System.Windows.Forms.DataGridView();
            this.numericUpDownMinSup = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreferDimCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDims)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuboid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinSup)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(289, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 13);
            label1.TabIndex = 0;
            label1.Text = "تعداد رکورد خوانده شده:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(549, 26);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 13);
            label2.TabIndex = 5;
            label2.Text = "فایل تراکنش ها:";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(549, 36);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(92, 13);
            label3.TabIndex = 6;
            label3.Text = "تعداد ابعاد مطلوب:";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(118, 67);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 13);
            label4.TabIndex = 8;
            label4.Text = "اندازه ابعاد:";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(572, 62);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(72, 13);
            label5.TabIndex = 10;
            label5.Text = "انتخاب Cuboid";
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
            this.groupBox1.Size = new System.Drawing.Size(647, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنظیمات";
            // 
            // labelDimCount
            // 
            this.labelDimCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDimCount.AutoSize = true;
            this.labelDimCount.Location = new System.Drawing.Point(87, 67);
            this.labelDimCount.Name = "labelDimCount";
            this.labelDimCount.Size = new System.Drawing.Size(11, 13);
            this.labelDimCount.TabIndex = 9;
            this.labelDimCount.Text = "-";
            // 
            // labeltransactionsCount
            // 
            this.labeltransactionsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltransactionsCount.AutoSize = true;
            this.labeltransactionsCount.Location = new System.Drawing.Point(221, 67);
            this.labeltransactionsCount.Name = "labeltransactionsCount";
            this.labeltransactionsCount.Size = new System.Drawing.Size(11, 13);
            this.labeltransactionsCount.TabIndex = 4;
            this.labeltransactionsCount.Text = "-";
            // 
            // buttonLoadTransaction
            // 
            this.buttonLoadTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadTransaction.Location = new System.Drawing.Point(432, 58);
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
            this.buttonBrowseFile.Location = new System.Drawing.Point(6, 21);
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
            this.textBoxTransactionFile.Location = new System.Drawing.Point(87, 23);
            this.textBoxTransactionFile.Name = "textBoxTransactionFile";
            this.textBoxTransactionFile.ReadOnly = true;
            this.textBoxTransactionFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTransactionFile.Size = new System.Drawing.Size(456, 21);
            this.textBoxTransactionFile.TabIndex = 1;
            // 
            // numericUpDownPreferDimCount
            // 
            this.numericUpDownPreferDimCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPreferDimCount.Enabled = false;
            this.numericUpDownPreferDimCount.Location = new System.Drawing.Point(492, 34);
            this.numericUpDownPreferDimCount.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownPreferDimCount.Name = "numericUpDownPreferDimCount";
            this.numericUpDownPreferDimCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownPreferDimCount.Size = new System.Drawing.Size(51, 21);
            this.numericUpDownPreferDimCount.TabIndex = 7;
            this.numericUpDownPreferDimCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.numericUpDownMinSup);
            this.groupBox2.Controls.Add(label7);
            this.groupBox2.Controls.Add(label6);
            this.groupBox2.Controls.Add(this.dataGridViewCuboid);
            this.groupBox2.Controls.Add(label5);
            this.groupBox2.Controls.Add(this.dataGridViewDims);
            this.groupBox2.Controls.Add(this.buttonCreateCuboids);
            this.groupBox2.Controls.Add(this.numericUpDownPreferDimCount);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(647, 577);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "گزارش";
            // 
            // dataGridViewDims
            // 
            this.dataGridViewDims.AllowUserToAddRows = false;
            this.dataGridViewDims.AllowUserToDeleteRows = false;
            this.dataGridViewDims.AllowUserToResizeColumns = false;
            this.dataGridViewDims.AllowUserToResizeRows = false;
            this.dataGridViewDims.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDims.Location = new System.Drawing.Point(6, 78);
            this.dataGridViewDims.Name = "dataGridViewDims";
            this.dataGridViewDims.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDims.Size = new System.Drawing.Size(635, 44);
            this.dataGridViewDims.TabIndex = 9;
            this.dataGridViewDims.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDims_CellValueChanged);
            // 
            // buttonCreateCuboids
            // 
            this.buttonCreateCuboids.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateCuboids.Location = new System.Drawing.Point(370, 27);
            this.buttonCreateCuboids.Name = "buttonCreateCuboids";
            this.buttonCreateCuboids.Size = new System.Drawing.Size(116, 34);
            this.buttonCreateCuboids.TabIndex = 8;
            this.buttonCreateCuboids.Text = "ساخت Cuboid ها";
            this.buttonCreateCuboids.UseVisualStyleBackColor = true;
            this.buttonCreateCuboids.Click += new System.EventHandler(this.buttonCreateCuboids_Click);
            // 
            // dataGridViewCuboid
            // 
            this.dataGridViewCuboid.AllowUserToAddRows = false;
            this.dataGridViewCuboid.AllowUserToDeleteRows = false;
            this.dataGridViewCuboid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCuboid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuboid.Location = new System.Drawing.Point(6, 152);
            this.dataGridViewCuboid.Name = "dataGridViewCuboid";
            this.dataGridViewCuboid.ReadOnly = true;
            this.dataGridViewCuboid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCuboid.Size = new System.Drawing.Size(635, 419);
            this.dataGridViewCuboid.TabIndex = 11;
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(573, 136);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(71, 13);
            label6.TabIndex = 12;
            label6.Text = "مقادیر Cuboid";
            // 
            // numericUpDownMinSup
            // 
            this.numericUpDownMinSup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownMinSup.Enabled = false;
            this.numericUpDownMinSup.Location = new System.Drawing.Point(118, 34);
            this.numericUpDownMinSup.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownMinSup.Name = "numericUpDownMinSup";
            this.numericUpDownMinSup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownMinSup.Size = new System.Drawing.Size(132, 21);
            this.numericUpDownMinSup.TabIndex = 14;
            this.numericUpDownMinSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMinSup.ValueChanged += new System.EventHandler(this.numericUpDownMinSup_ValueChanged);
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(256, 38);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(51, 13);
            label7.TabIndex = 13;
            label7.Text = "Min_Sup:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 709);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MinimumSize = new System.Drawing.Size(687, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Icberg Cube";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreferDimCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDims)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuboid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinSup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labeltransactionsCount;
        private System.Windows.Forms.Button buttonLoadTransaction;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.TextBox textBoxTransactionFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelDimCount;
        private System.Windows.Forms.NumericUpDown numericUpDownPreferDimCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewDims;
        private System.Windows.Forms.Button buttonCreateCuboids;
        private System.Windows.Forms.DataGridView dataGridViewCuboid;
        private System.Windows.Forms.NumericUpDown numericUpDownMinSup;
    }
}

