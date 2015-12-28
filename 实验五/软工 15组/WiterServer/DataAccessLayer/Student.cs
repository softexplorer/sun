using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class Student
    {
        #region 成员

        private string number;

        #endregion

        #region 属性

        public string Number { get { return number; } }
        public string Name { get; set; }
        public string Extra { get; set; }

        #endregion

        #region 方法

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="number"></param>
        public Student(string number)
        {
            this.number = number;
        }


        #endregion
    }
}
