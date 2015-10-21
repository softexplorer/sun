using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 软件测试2
{
    class Program
    {
        public class calculate
        {
            public string name;
            public int bir_year;
            public calculate()
            {
                name="";
                bir_year = 1;
            }
            public int CountAge(int year_t,int year)
            {
                if (year_t < 0 && year < 0)
                    return 0;
                else
                {
                    bir_year = year_t;
                    int age;
                    age = year - bir_year + 1;
                    if (age < 0)
                        return 0;
                    else 
                        return age;
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
