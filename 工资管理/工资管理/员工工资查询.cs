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
    public partial class 员工工资查询 : Form
    {
        public 员工工资查询()
        {
            InitializeComponent();
        }

        private void 职工工资查询_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“salaryDataSet1.工资总表员工”中。您可以根据需要移动或删除它。
            this.工资总表员工TableAdapter.Fill(this.salaryDataSet1.工资总表员工);
            // TODO: 这行代码将数据加载到表“salaryDataSet2._工资总表_员工_”中。您可以根据需要移动或删除它。
            this.工资总表_员工_TableAdapter.Fill(this.salaryDataSet2._工资总表_员工_);

        }

        private void 员工工资查询ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.工资总表_员工_TableAdapter.员工工资查询(this.salaryDataSet2._工资总表_员工_, x2ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
