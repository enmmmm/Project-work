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
    public partial class 工资变动查询 : Form
    {
        public 工资变动查询()
        {
            InitializeComponent();
        }

        private void 工资变动查询_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“salaryDataSet5.工资变动表”中。您可以根据需要移动或删除它。
            this.工资变动表TableAdapter.Fill(this.salaryDataSet5.工资变动表);

        }

        private void 工资变动ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.工资变动表TableAdapter.工资变动(this.salaryDataSet5.工资变动表, x4ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
