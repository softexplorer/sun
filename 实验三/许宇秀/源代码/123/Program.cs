using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 测试程序1_计算日期
{
    class Program
    {
        public class calculator
        {
            public int year;
            public int month;
            public int day;
            public calculator()
            {
                year = 1;
                month = 1;
                day = 1;
            }
            public bool judge(int t_year)
            {
                if (t_year % 100 == 0)
                {
                    if (t_year % 400 == 0)
                        return true;
                }
                else if (t_year % 4 == 0)
                    return true;
                else return false;
                return false;
            }
            public int countday(int t_year, int t_month, int t_day)
            {
                int i, days = 0;
                for (i = 1; i < t_month; i++)
                {
                    if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                        days += 31;
                    else if (i == 2)
                    {
                        if (judge(t_year))
                            days += 29;
                        else
                            days += 28;
                    }
                    else days += 30;
                }
                days += t_day;
                return days;
            }
        }
        static void Main(string[] args)
        {
            int year, month, day, days;
            Console.WriteLine("写出年和月份和日期");
            string s_month, s_day, s_year, s_days;
            s_year = Console.ReadLine();
            s_month = Console.ReadLine();
            s_day = Console.ReadLine();
            year = Convert.ToUInt16(s_year);
            month = Convert.ToUInt16(s_month);
            day = Convert.ToUInt16(s_day);
            calculator cal1 = new calculator();
            days = cal1.countday(year, month, day);
            s_days = Convert.ToString(days);
            Console.WriteLine(s_days);
            Console.ReadLine();
        }
    }
}
