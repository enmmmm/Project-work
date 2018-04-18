namespace 工资管理
{
    partial class 主管工资查询
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
            this.职工号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职位DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.月基本工资DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.全勤奖DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.扣除工资DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.实得工资DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工资总表主管BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryDataSet6 = new 工资管理.SalaryDataSet6();
            this.主管查询ToolStrip = new System.Windows.Forms.ToolStrip();
            this.x5ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.x5ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.主管查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.工资总表_主管_TableAdapter = new 工资管理.SalaryDataSet6TableAdapters.工资总表_主管_TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.工资总表主管BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet6)).BeginInit();
            this.主管查询ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.职工号DataGridViewTextBoxColumn,
            this.职位DataGridViewTextBoxColumn,
            this.月基本工资DataGridViewTextBoxColumn,
            this.全勤奖DataGridViewTextBoxColumn,
            this.扣除工资DataGridViewTextBoxColumn,
            this.实得工资DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.工资总表主管BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // 职工号DataGridViewTextBoxColumn
            // 
            this.职工号DataGridViewTextBoxColumn.DataPropertyName = "职工号";
            this.职工号DataGridViewTextBoxColumn.HeaderText = "职工号";
            this.职工号DataGridViewTextBoxColumn.Name = "职工号DataGridViewTextBoxColumn";
            // 
            // 职位DataGridViewTextBoxColumn
            // 
            this.职位DataGridViewTextBoxColumn.DataPropertyName = "职位";
            this.职位DataGridViewTextBoxColumn.HeaderText = "职位";
            this.职位DataGridViewTextBoxColumn.Name = "职位DataGridViewTextBoxColumn";
            // 
            // 月基本工资DataGridViewTextBoxColumn
            // 
            this.月基本工资DataGridViewTextBoxColumn.DataPropertyName = "月基本工资";
            this.月基本工资DataGridViewTextBoxColumn.HeaderText = "月基本工资";
            this.月基本工资DataGridViewTextBoxColumn.Name = "月基本工资DataGridViewTextBoxColumn";
            // 
            // 全勤奖DataGridViewTextBoxColumn
            // 
            this.全勤奖DataGridViewTextBoxColumn.DataPropertyName = "全勤奖";
            this.全勤奖DataGridViewTextBoxColumn.HeaderText = "全勤奖";
            this.全勤奖DataGridViewTextBoxColumn.Name = "全勤奖DataGridViewTextBoxColumn";
            // 
            // 扣除工资DataGridViewTextBoxColumn
            // 
            this.扣除工资DataGridViewTextBoxColumn.DataPropertyName = "扣除工资";
            this.扣除工资DataGridViewTextBoxColumn.HeaderText = "扣除工资";
            this.扣除工资DataGridViewTextBoxColumn.Name = "扣除工资DataGridViewTextBoxColumn";
            // 
            // 实得工资DataGridViewTextBoxColumn
            // 
            this.实得工资DataGridViewTextBoxColumn.DataPropertyName = "实得工资";
            this.实得工资DataGridViewTextBoxColumn.HeaderText = "实得工资";
            this.实得工资DataGridViewTextBoxColumn.Name = "实得工资DataGridViewTextBoxColumn";
            // 
            // 工资总表主管BindingSource
            // 
            this.工资总表主管BindingSource.DataMember = "工资总表(主管)";
            this.工资总表主管BindingSource.DataSource = this.salaryDataSet6;
            // 
            // salaryDataSet6
            // 
            this.salaryDataSet6.DataSetName = "SalaryDataSet6";
            this.salaryDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 主管查询ToolStrip
            // 
            this.主管查询ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x5ToolStripLabel,
            this.x5ToolStripTextBox,
            this.主管查询ToolStripButton});
            this.主管查询ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.主管查询ToolStrip.Name = "主管查询ToolStrip";
            this.主管查询ToolStrip.Size = new System.Drawing.Size(671, 27);
            this.主管查询ToolStrip.TabIndex = 1;
            this.主管查询ToolStrip.Text = "主管查询ToolStrip";
            // 
            // x5ToolStripLabel
            // 
            this.x5ToolStripLabel.Name = "x5ToolStripLabel";
            this.x5ToolStripLabel.Size = new System.Drawing.Size(54, 24);
            this.x5ToolStripLabel.Text = "职工号";
            this.x5ToolStripLabel.Click += new System.EventHandler(this.x5ToolStripLabel_Click);
            // 
            // x5ToolStripTextBox
            // 
            this.x5ToolStripTextBox.Name = "x5ToolStripTextBox";
            this.x5ToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // 主管查询ToolStripButton
            // 
            this.主管查询ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.主管查询ToolStripButton.Name = "主管查询ToolStripButton";
            this.主管查询ToolStripButton.Size = new System.Drawing.Size(73, 24);
            this.主管查询ToolStripButton.Text = "主管查询";
            this.主管查询ToolStripButton.Click += new System.EventHandler(this.主管查询ToolStripButton_Click);
            // 
            // 工资总表_主管_TableAdapter
            // 
            this.工资总表_主管_TableAdapter.ClearBeforeFill = true;
            // 
            // 主管工资查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 261);
            this.Controls.Add(this.主管查询ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "主管工资查询";
            this.Text = "主管工资查询";
            this.Load += new System.EventHandler(this.主管工资查询_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.工资总表主管BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet6)).EndInit();
            this.主管查询ToolStrip.ResumeLayout(false);
            this.主管查询ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SalaryDataSet6 salaryDataSet6;
        private System.Windows.Forms.BindingSource 工资总表主管BindingSource;
        private SalaryDataSet6TableAdapters.工资总表_主管_TableAdapter 工资总表_主管_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职工号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职位DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 月基本工资DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 全勤奖DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 扣除工资DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 实得工资DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip 主管查询ToolStrip;
        private System.Windows.Forms.ToolStripLabel x5ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox x5ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 主管查询ToolStripButton;
    }
}