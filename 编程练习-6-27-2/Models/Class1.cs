using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 员工
    /// </summary>
    public class Emp
    {
        ///<summary>
        /// 编号
        /// </summary>
        public int ID { get; set; }
        ///<summary>
        /// 名字
        /// </summary>
        public String Name { get; set; }
        ///<summary>
        /// 电话
        /// </summary>
        public int Phone{ get; set; }
        ///<summary>
        /// 备注
        /// </summary>
        public int Memo { get; set; }
    }
}
