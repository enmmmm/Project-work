namespace 工资管理
{
    partial class 职工档案查询
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.职工号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职位DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入职年份DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出生年月DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.密码DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.档案表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryDataSet = new 工资管理.SalaryDataSet();
            this.档案查询ToolStrip = new System.Windows.Forms.ToolStrip();
            this.x1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.x1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.档案查询ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.档案表TableAdapter = new 工资管理.SalaryDataSetTableAdapters.档案表TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.档案表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet)).BeginInit();
            this.档案查询ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.职工号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.职位DataGridViewTextBoxColumn,
            this.入职年份DataGridViewTextBoxColumn,
            this.出生年月DataGridViewTextBoxColumn,
            this.密码DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.档案表BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(779, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // 职工号DataGridViewTextBoxColumn
            // 
            this.职工号DataGridViewTextBoxColumn.DataPropertyName = "职工号";
            this.职工号DataGridViewTextBoxColumn.HeaderText = "职工号";
            this.职工号DataGridViewTextBoxColumn.Name = "职工号DataGridViewTextBoxColumn";
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            // 
            // 职位DataGridViewTextBoxColumn
            // 
            this.职位DataGridViewTextBoxColumn.DataPropertyName = "职位";
            this.职位DataGridViewTextBoxColumn.HeaderText = "职位";
            this.职位DataGridViewTextBoxColumn.Name = "职位DataGridViewTextBoxColumn";
            // 
            // 入职年份DataGridViewTextBoxColumn
            // 
            this.入职年份DataGridViewTextBoxColumn.DataPropertyName = "入职年份";
            this.入职年份DataGridViewTextBoxColumn.HeaderText = "入职年份";
            this.入职年份DataGridViewTextBoxColumn.Name = "入职年份DataGridViewTextBoxColumn";
            // 
            // 出生年月DataGridViewTextBoxColumn
            // 
            this.出生年月DataGridViewTextBoxColumn.DataPropertyName = "出生年月";
            this.出生年月DataGridViewTextBoxColumn.HeaderText = "出生年月";
            this.出生年月DataGridViewTextBoxColumn.Name = "出生年月DataGridViewTextBoxColumn";
            // 
            // 密码DataGridViewTextBoxColumn
            // 
            this.密码DataGridViewTextBoxColumn.DataPropertyName = "密码";
            this.密码DataGridViewTextBoxColumn.HeaderText = "密码";
            this.密码DataGridViewTextBoxColumn.Name = "密码DataGridViewTextBoxColumn";
            // 
            // 档案表BindingSource
            // 
            this.档案表BindingSource.DataMember = "档案表";
            this.档案表BindingSource.DataSource = this.salaryDataSet;
            // 
            // salaryDataSet
            // 
            this.salaryDataSet.DataSetName = "SalaryDataSet";
            this.salaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 档案查询ToolStrip
            // 
            this.档案查询ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x1ToolStripLabel,
            this.x1ToolStripTextBox,
            this.档案查询ToolStripButton});
            this.档案查询ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.档案查询ToolStrip.Name = "档案查询ToolStrip";
            this.档案查询ToolStrip.Size = new System.Drawing.Size(803, 27);
            this.档案查询ToolStrip.TabIndex = 1;
            this.档案查询ToolStrip.Text = "2档案查询ToolStrip";
            // 
            // x1ToolStripLabel
            // 
            this.x1ToolStripLabel.Name = "x1ToolStripLabel";
            this.x1ToolStripLabel.Size = new System.Drawing.Size(54, 24);
            this.x1ToolStripLabel.Text = "职工号";
            // 
            // x1ToolStripTextBox
            // 
            this.x1ToolStripTextBox.Name = "x1ToolStripTextBox";
            this.x1ToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // 档案查询ToolStripButton
            // 
            this.档案查询ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.档案查询ToolStripButton.Name = "档案查询ToolStripButton";
            this.档案查询ToolStripButton.Size = new System.Drawing.Size(73, 24);
            this.档案查询ToolStripButton.Text = "档案查询";
            this.档案查询ToolStripButton.Click += new System.EventHandler(this.档案查询ToolStripButton_Click);
            // 
            // 档案表TableAdapter
            // 
            this.档案表TableAdapter.ClearBeforeFill = true;
            // 
            // 职工档案查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 508);
            this.Controls.Add(this.档案查询ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "职工档案查询";
            this.Text = "职工档案查询";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.档案表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet)).EndInit();
            this.档案查询ToolStrip.ResumeLayout(false);
            this.档案查询ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SalaryDataSet salaryDataSet;
        private System.Windows.Forms.BindingSource 档案表BindingSource;
        private SalaryDataSetTableAdapters.档案表TableAdapter 档案表TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职工号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职位DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入职年份DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出生年月DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 密码DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip 档案查询ToolStrip;
        private System.Windows.Forms.ToolStripLabel x1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox x1ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 档案查询ToolStripButton;
    }
}

