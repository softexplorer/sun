using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class Course
    {
        #region 成员

        private string number;

        #endregion

        #region 属性

        public string Number { get { return number; } }
        public string Name { get; set; }
        public string Message { get; set; }

        #endregion

        #region 方法

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="number"></param>
        public Course(string number)
        {
            this.number = number;
        }


        #endregion
    }
}
