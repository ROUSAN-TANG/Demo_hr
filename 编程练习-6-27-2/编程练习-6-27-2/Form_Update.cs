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
using 编程练习_6_27_2.Models;
using System.Data.SqlClient;


namespace 编程练习_6_27_2
{
    public partial class Form_Update : Form
    {
        public Form_Update()
        {
            InitializeComponent();
        }
        public Emp emp { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "update Empp set Name=@Name,Phone=@Phone,Height=@Height,Memo=@Memo Where Id=@Id";
            int rows = SqlHelper.Execute(sql,
                new SqlParameter("@Name", txtName.Text),
                new SqlParameter("@Phone", txtPhone.Text),
                new SqlParameter("@Height", txtHeight.Text),
                new SqlParameter("@Memo", txtMemo.Text),
                new SqlParameter("@Id", emp.Id));

            MessageBox.Show("修改成功" + rows + "行!");

        }

        private void Form_Update_Load(object sender, EventArgs e)
        {
            txtHeight.Text = emp.Height + "";
            txtMemo.Text = emp.Memo;
            txtName.Text = emp.Name;
            txtPhone.Text = emp.Phone;
        }
    }
}
