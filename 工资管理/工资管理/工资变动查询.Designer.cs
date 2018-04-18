namespace 工资管理
{
    partial class 工资变动查询
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
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.基本工资变动DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工资变动表BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryDataSet5 = new 工资管理.SalaryDataSet5();
            this.工资变动ToolStrip = new System.Windows.Forms.ToolStrip();
            this.x4ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.x4ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.工资变动ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.工资变动表TableAdapter = new 工资管理.SalaryDataSet5TableAdapters.工资变动表TableAdapter();
            this.salaryDataSet21 = new 工资管理.SalaryDataSet2();
            this.salaryDataSet22 = new 工资管理.SalaryDataSet2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.工资变动表BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet5)).BeginInit();
            this.工资变动ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet22)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.职工号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.基本工资变动DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.工资变动表BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(520, 140);
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
            // 基本工资变动DataGridViewTextBoxColumn
            // 
            this.基本工资变动DataGridViewTextBoxColumn.DataPropertyName = "基本工资变动";
            this.基本工资变动DataGridViewTextBoxColumn.HeaderText = "基本工资变动";
            this.基本工资变动DataGridViewTextBoxColumn.Name = "基本工资变动DataGridViewTextBoxColumn";
            // 
            // 工资变动表BindingSource
            // 
            this.工资变动表BindingSource.DataMember = "工资变动表";
            this.工资变动表BindingSource.DataSource = this.salaryDataSet5;
            // 
            // salaryDataSet5
            // 
            this.salaryDataSet5.DataSetName = "SalaryDataSet5";
            this.salaryDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 工资变动ToolStrip
            // 
            this.工资变动ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x4ToolStripLabel,
            this.x4ToolStripTextBox,
            this.工资变动ToolStripButton});
            this.工资变动ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.工资变动ToolStrip.Name = "工资变动ToolStrip";
            this.工资变动ToolStrip.Size = new System.Drawing.Size(622, 25);
            this.工资变动ToolStrip.TabIndex = 1;
            this.工资变动ToolStrip.Text = "工资变动ToolStrip";
            // 
            // x4ToolStripLabel
            // 
            this.x4ToolStripLabel.Name = "x4ToolStripLabel";
            this.x4ToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.x4ToolStripLabel.Text = "职工号";
            // 
            // x4ToolStripTextBox
            // 
            this.x4ToolStripTextBox.Name = "x4ToolStripTextBox";
            this.x4ToolStripTextBox.Size = new System.Drawing.Size(76, 25);
            // 
            // 工资变动ToolStripButton
            // 
            this.工资变动ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.工资变动ToolStripButton.Name = "工资变动ToolStripButton";
            this.工资变动ToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.工资变动ToolStripButton.Text = "工资变动";
            this.工资变动ToolStripButton.Click += new System.EventHandler(this.工资变动ToolStripButton_Click);
            // 
            // 工资变动表TableAdapter
            // 
            this.工资变动表TableAdapter.ClearBeforeFill = true;
            // 
            // salaryDataSet21
            // 
            this.salaryDataSet21.DataSetName = "SalaryDataSet2";
            this.salaryDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salaryDataSet22
            // 
            this.salaryDataSet22.DataSetName = "SalaryDataSet2";
            this.salaryDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 工资变动查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 202);
            this.Controls.Add(this.工资变动ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "工资变动查询";
            this.Text = "工资变动查询";
            this.Load += new System.EventHandler(this.工资变动查询_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.工资变动表BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet5)).EndInit();
            this.工资变动ToolStrip.ResumeLayout(false);
            this.工资变动ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryDataSet22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SalaryDataSet5 salaryDataSet5;
        private System.Windows.Forms.BindingSource 工资变动表BindingSource;
        private SalaryDataSet5TableAdapters.工资变动表TableAdapter 工资变动表TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职工号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 基本工资变动DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip 工资变动ToolStrip;
        private System.Windows.Forms.ToolStripLabel x4ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox x4ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton 工资变动ToolStripButton;
        private SalaryDataSet2 salaryDataSet21;
        private SalaryDataSet2 salaryDataSet22;
    }
}