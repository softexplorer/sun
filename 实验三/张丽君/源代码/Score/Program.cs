using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Score
{
    class Program
    {   
        class Calculate
        {
            private double Area1;
            private double Length;
            public Calculate()
            {
            }
            public double S
              {
                 get { return Area1; }
              }
            public double L
              {
                 get { return Length; }
              }
              
              public double Area(double x,double y)
              {    
                  if(x<0||y<0)
                      return 0;
                 else 
                      return   Area1=x*y;
              }
             public double Long(double x,double y)
              {    if (x<0||y<0)
                    return 0;
              else return  Length=(x+y)*2;
              }
        }
 
         public static void Main()
        {
           Calculate Square=new Calculate();   
              Square.Area(2.3,3.5);
             Square.Long(2.3,3.5);  
             Console.WriteLine("该长方形面积为："+Square.Area(2.3,3.5)+"该长方形长度："+Square.Long(2.3,3.5));
        }
    }
}
