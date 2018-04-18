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
    public partial class 主管工资查询 : Form
    {
        public 主管工资查询()
        {
            InitializeComponent();
        }

        private void 主管工资查询_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“salaryDataSet6._工资总表_主管_”中。您可以根据需要移动或删除它。
            this.工资总表_主管_TableAdapter.Fill(this.salaryDataSet6._工资总表_主管_);

        }

        private void 主管查询ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.工资总表_主管_TableAdapter.主管查询(this.salaryDataSet6._工资总表_主管_, x5ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
              
            }
        }

        private void x5ToolStripLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
