using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework
{
    class StringChecker
    {
        private bool IsDigit(char cIn)
        {
            if (cIn >= '0' && cIn <= '9')
                return true;
            else
                return false;
        }
        public bool IsDouble(string sIn)
        {
            int pointNum = 0; //小数点的个数
            if (sIn == null || sIn.Length == 0)
            {
                return false;
            }
            if (!IsDigit(sIn[0]) || !IsDigit(sIn[sIn.Length - 1]))
            {
                return false;
            }
            for (int i = 1; i < sIn.Length; i++)
            {
                if (sIn[i] == '.')
                {
                    if (pointNum < 1)
                    {
                        pointNum++;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (!IsDigit(sIn[i]) && sIn[i] != '.')
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsInt(string sIn)
        {
            if (sIn == null)
            {
                return false;
            }
            for (int i = 0; i < sIn.Length; i++)
            {
                if (!IsDigit(sIn[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
