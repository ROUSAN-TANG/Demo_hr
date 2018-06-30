﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace 编程练习_6_27_2.Utils
{
    /// <summary>
    /// 用于访问SQLServer数据库的工具类
    /// </summary>
  public  class SqlHelper
    {
        // <summary>
        /// 连接字符串 write once,only once!  
        /// </summary>
        public static String connString = "server=DESKTOP-VT84G0E;uid=sa;pwd=957463375;database=hr;";


        /// <summary>
        /// 完成增，删，改
        /// </summary>
        /// <param name="sql">将要执行的sql</param>
        /// <param name="ps">可变参数，指定sql中的参数</param>
        /// <returns>影响行数</returns>
        public static int Execute(String sql, params SqlParameter[] ps)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //打开连接
                conn.Open();
                //创建命令对象，指定sql与连接对象conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //指定参数
                if (ps != null) cmd.Parameters.AddRange(ps);
                //执行sql命令，返回影响行数
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 执行查询，返回SqlDataReader，一定要关闭
        /// </summary>
        /// <param name="sql">将要执行的sql</param>
        /// <param name="ps">可变参数，指定sql中的参数</param>
        /// <returns>SqlDataReader结果集</returns>
        public static SqlDataReader Reader(String sql, params SqlParameter[] ps)
        {
            //定义一个连接对象，指定连接字符串using,sa sa MyCar .
            SqlConnection conn = new SqlConnection(connString);
              //打开数据库
                conn.Open();
                //定义命令对象，指定要执行的sql与conn连接参数
                SqlCommand cmd = new SqlCommand(sql, conn);
                //指定参数
                if (ps != null)
                    cmd.Parameters.AddRange(ps);
            //执行SQL查询，返回结果集给sdr，关闭reader时也关闭连接
             //    cmd = new SqlCommand("select Id,Name,Phone,Height,Memo from Empp", conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
              //  return cmd.ExecuteReader();
            
        }


    }
}
