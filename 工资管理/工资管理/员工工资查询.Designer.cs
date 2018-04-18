namespace 工资管理
{
    partial class 员工工资查询
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.员工工资查询ToolStrip = new System.Windows.Forms.ToolStrip();
            this.x2ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.x2ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.员工工资查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salaryDataSet1 = new 工资管理.SalaryDataSet1();
            this.工资总表员工BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.工资总表员工TableAdapter = new 工资管理.SalaryDataSet1TableAdapters.工资总表员工TableAdapter();
            this.职工号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职位DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.月基本工资DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.全勤奖DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.扣除工资DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.实得工资DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.员工工资查询ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.工资总表员工BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.职工号DataGridViewTextBoxColumn,
            this.职位DataGridViewTextBoxColumn,
            this.月基本工资DataGridViewTextBoxColumn,
            this.全勤奖DataGridViewTextBoxColumn,
            this.扣除工资DataGridViewTextBoxColumn,
            this.实得工资DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.工资总表员工BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(11, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(612, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // 员工工资查询ToolStrip
            // 
            this.员工工资查询ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x2ToolStripLabel,
            this.x2ToolStripTextBox,
            this.员工工资查询ToolStripButton});
            this.员工工资查询ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.员工工资查询ToolStrip.Name = "员工工资查询ToolStrip";
            this.员工工资查询ToolStrip.Size = new System.Drawing.Size(626, 25);
            this.员工工资查询ToolStrip.TabIndex = 1;
            this.员工工资查询ToolStrip.Text = "员工工资查询ToolStrip";
            // 
            // x2ToolStripLabel
            // 
            this.x2ToolStripLabel.Name = "x2ToolStripLabel";
            this.x2ToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.x2ToolStripLabel.Text = "职工号";
            // 
            // x2ToolStripTextBox
            // 
            this.x2ToolStripTextBox.Name = "x2ToolStripTextBox";
            this.x2ToolStripTextBox.Size = new System.Drawing.Size(76, 25);
            // 
            // 员工工资查询ToolStripButton
            // 
            this.员工工资查询ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.员工工资查询ToolStripButton.Name = "员工工资查询ToolStripButton";
            this.员工工资查询ToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.员工工资查询ToolStripButton.Text = "员工工资查询";
            this.员工工资查询ToolStripButton.Click += new System.EventHandler(this.员工工资查询ToolStripButton_Click);
            // 
            // salaryDataSet1
            // 
            this.salaryDataSet1.DataSetName = "SalaryDataSet1";
            this.salaryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 工资总表员工BindingSource1
            // 
            this.工资总表员工BindingSource1.DataMember = "工资总表员工";
            this.工资总表员工BindingSource1.DataSource = this.salaryDataSet1;
            // 
            // 工资总表员工TableAdapter
            // 
            this.工资总表员工TableAdapter.ClearBeforeFill = true;
            // 
            // 职工号DataGridViewTextBoxColumn
            // 
            this.职工号DataGridViewTextBoxColumn.DataPropertyName = "职工号";
            this.职工号DataGridViewTextBoxColumn.HeaderText = "职工号";
            this.职工号DataGridViewTextBoxColumn.Name = "职工号DataGridViewTextBoxColumn";
            this.职工号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 职位DataGridViewTextBoxColumn
            // 
            this.职位DataGridViewTextBoxColumn.DataPropertyName = "职位";
            this.职位DataGridViewTextBoxColumn.HeaderText = "职位";
            this.职位DataGridViewTextBoxColumn.Name = "职位DataGridViewTextBoxColumn";
            this.职位DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 月基本工资DataGridViewTextBoxColumn
            // 
            this.月基本工资DataGridViewTextBoxColumn.DataPropertyName = "月基本工资";
            this.月基本工资DataGridViewTextBoxColumn.HeaderText = "月基本工资";
            this.月基本工资DataGridViewTextBoxColumn.Name = "月基本工资DataGridViewTextBoxColumn";
            this.月基本工资DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 全勤奖DataGridViewTextBoxColumn
            // 
            this.全勤奖DataGridViewTextBoxColumn.DataPropertyName = "全勤奖";
            this.全勤奖DataGridViewTextBoxColumn.HeaderText = "全勤奖";
            this.全勤奖DataGridViewTextBoxColumn.Name = "全勤奖DataGridViewTextBoxColumn";
            this.全勤奖DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 扣除工资DataGridViewTextBoxColumn
            // 
            this.扣除工资DataGridViewTextBoxColumn.DataPropertyName = "扣除工资";
            this.扣除工资DataGridViewTextBoxColumn.HeaderText = "扣除工资";
            this.扣除工资DataGridViewTextBoxColumn.Name = "扣除工资DataGridViewTextBoxColumn";
            this.扣除工资DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 实得工资DataGridViewTextBoxColumn
            // 
            this.实得工资DataGridViewTextBoxColumn.DataPropertyName = "实得工资";
            this.实得工资DataGridViewTextBoxColumn.HeaderText = "实得工资";
            this.实得工资DataGridViewTextBoxColumn.Name = "实得工资DataGridViewTextBoxColumn";
            this.实得工资DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 员工工资查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 306);
            this.Controls.Add(this.员工工资查询ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "员工工资查询";
            this.Text = "职工工资查询";
            this.Load += new System.EventHandler(this.职工工资查询_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.员工工资查询ToolStrip.ResumeLayout(false);
            this.员工工资查询ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.工资总表员工BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip 员工工资查询ToolStrip;
        private System.Windows.Forms.ToolStripLabel x2ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox x2ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 员工工资查询ToolStripButton;
        private SalaryDataSet1 salaryDataSet1;
        private System.Windows.Forms.BindingSource 工资总表员工BindingSource1;
        private SalaryDataSet1TableAdapters.工资总表员工TableAdapter 工资总表员工TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职工号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职位DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 月基本工资DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 全勤奖DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 扣除工资DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 实得工资DataGridViewTextBoxColumn;

    }
}