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
    public partial class Form_Emp : Form
    {
        List<Emp> emps = null;
        public Form_Emp()
        {
            InitializeComponent();
            BindData();
        }
        //绑定员工信息到网络
        public void BindData()
        {
            emps = new List<Emp>();
          //  using (SqlConnection conn = new SqlConnection("server=DESKTOP-VT84G0E;uid=sa;pwd=957463375;database=hr;"))
          //  {
                //conn.Open();
                ////将执行的sql
                //String sql = "select Id,Name,Phone,Height,Memo from Empp";
                ////创建命令对象，指定要执行sql语句与连接对象conn
                //SqlCommand cmd = new SqlCommand(sql, conn);
                ////执行查询返回结果集
                //SqlDataReader sdr = cmd.ExecuteReader();
                ////下移游标，读取一行，如果没有数据了则返回false

                 SqlDataReader sdr = SqlHelper.Reader("select Id,Name,Phone,Height,Memo from Empp where Name like @Name", new SqlParameter("@Name",'%'+ textBox1.Text.Trim()+ "%"));
                while (sdr.Read())
                {
                    Emp emp = new Emp();
                    emp.Id = Convert.ToInt32(sdr["Id"]);
                    emp.Name = sdr["Name"] + "";
                    emp.Phone = sdr["Phone"] + "";
                    emp.Height = Convert.ToInt32(sdr["Height"]);
                    emp.Memo = sdr["Memo"] + "";
                    emps.Add(emp);

            }
            sdr.Close();
            dgvEmp.DataSource = emps;
               

            
        }

        //新增
        private void button1_Click(object sender, EventArgs e)
        {
            Form_add add = new Form_add();
            add.ShowDialog();
            BindData();
        }

        private void coon_Click(object sender, EventArgs e)
        {
        //    // 创建连接对象，指定连接字符串参数
        //     SqlConnection conn = new SqlConnection("server=%;uid=root;pwd=13762937456tang;database=hr;");
        //    //打开数据
        //    conn.Open();
        //    MessageBox.Show("打开成功，状态" + conn.State);
        //    conn.Close();
        //    MessageBox.Show("关闭数据库成功");


        }
        //删除
        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvEmp.SelectedRows[0].Cells[0].Value);
            int rows = SqlHelper.Execute("delete from Empp where Id=@Id", new SqlParameter("@Id", id));
            MessageBox.Show("删除成功" + rows + "行");
            BindData();

        }
        //修改
        private void button3_Click(object sender, EventArgs e)
        {
            //取得索引
            int index = dgvEmp.SelectedRows[0].Index;
            Form_Update edit = new Form_Update();
            edit.emp = emps[index];
            edit.ShowDialog();
            BindData();
        }
        //查询
        private void button4_Click(object sender, EventArgs e)
        {
            BindData();
        }





    }
}
