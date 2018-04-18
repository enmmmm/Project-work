using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 工资管理
{
    public partial class 职工档案查询 : Form
    {
        public 职工档案查询()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“salaryDataSet.档案表”中。您可以根据需要移动或删除它。
            this.档案表TableAdapter.Fill(this.salaryDataSet.档案表);

        }

        private void 档案查询ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.档案表TableAdapter.档案查询(this.salaryDataSet.档案表, x1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
