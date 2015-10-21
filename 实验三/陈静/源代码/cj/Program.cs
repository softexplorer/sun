using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cj
{
    class Date
    {
        public int year;
        public int month;
        public int day;

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public int addYear()
        {
            year++;
            return year;
        }
        public int addMonth(int num)
        {
            month=month+num;
            if (month < 1)
                return 0;
            else if (month > 12)
            {
                int i = month / 12;
               this.year=year+i;
                month=month-12*i;
                return 1;
            }
            else
            {
                month = month + num;
                return 1;
            }
        }
        public void addDay()
        {
            day++;
        }
        public int showYear(int year)
        {
            if (year < 0)
                return 0;
            else if (year > 99999)
                return 0;
            else
                return year;
        }
        public int showMonth()
        {
            return month;
        }
        public int showDay()
        {
            return day;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        
            Date date = new Date(2015,10,21);
            Console.WriteLine("当前日期："+date.year+"年"+date.month +"月"+date.day+"日");
            date.addYear();
            date.addMonth(5);
            date.addDay();
            Console.WriteLine("增加后日期：" + date.year + "年" + date.month + "月" + date.day + "日");
           

        }
    }
}
