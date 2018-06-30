using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 编程练习_6_27_2
{
    public partial class Form_hr : Form
    {
        public Form_hr()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form_Emp emps = new Form_Emp();
            emps.Show();
        }
    }
}
