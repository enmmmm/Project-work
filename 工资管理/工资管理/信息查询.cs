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
    public partial class 信息查询 : Form
    {
        public 信息查询()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            职工档案查询 s = new 职工档案查询();
            s.Show();
          //  s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            员工工资查询 s = new 员工工资查询();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           主管工资查询 s = new 主管工资查询();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            工资变动查询 s = new 工资变动查询();
            s.Show();
        }

        private void 信息查询_Load(object sender, EventArgs e)
        {

        }
    }
}
