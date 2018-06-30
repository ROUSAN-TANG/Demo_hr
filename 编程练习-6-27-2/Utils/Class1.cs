using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    /// <summary>
    /// 用于访问数据库的工具类
    /// </summary>
    public class SqlHelp
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static String connString = "server=Localhost ;Database = hr;Uid = root;pwd = 13762937456tang";
        ///<summary>
        /// 完成增，删，改
        ///</summary>
        public static int Execute(String sql, params SqlParameter[] ps)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (ps != null) cmd.Parameters.AddRange(ps);
                return cmd.ExecuteNonQuery();

            }
        }
        ///<summary>
        /// 执行查询，返回SqlDataReader，要关闭
        ///</summary>
        public static SqlDataReader Reader(String sql, params SqlParameter[] ps)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql ,conn);
            if (ps != null) cmd.Parameters.AddRange(ps);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
