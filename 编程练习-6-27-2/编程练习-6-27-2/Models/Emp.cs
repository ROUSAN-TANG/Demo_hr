using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 编程练习_6_27_2.Models
{

    /// <summary>
    /// 员工
    /// </summary>
    public class Emp
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public String Phone { get; set; }
        /// <summary>
        /// 身高
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public String Memo { get; set; }

    }
}
