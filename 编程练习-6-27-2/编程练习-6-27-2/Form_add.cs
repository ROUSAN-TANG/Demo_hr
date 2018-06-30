using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using 编程练习_6_27_2.Utils;
using System.Data.SqlClient;

namespace 编程练习_6_27_2
{
    public partial class Form_add : Form
    {
        public Form_add()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "insert into Empp(Name,Phone,Height,Memo) values(@Name,@Phone,@Height,@Memo);";
            int rows = SqlHelper.Execute(sql,
                new SqlParameter("@Name", txtName.Text),
                new SqlParameter("@Phone", txtPhone.Text),
                new SqlParameter("@Height", txtHeight.Text),
                new SqlParameter("@Memo", txtMemo.Text));
            MessageBox.Show("新增成功"+rows+"行!");
        }
    }
}
