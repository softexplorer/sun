using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrammarAnalysers
{
    class PolandAnalyser
    {
        //运算符优先级表
        List<string>[] operators = new List<string>[17];
        public PolandAnalyser()
        {
            for (int i = 0; i < operators.Length; i++)
            {
                operators[i] = new List<string>();
            }
            operators[2].Add("@-");
            operators[2].Add("++");
            operators[2].Add("--");
            operators[2].Add("!");
            operators[3].Add("/");
            operators[3].Add("*");
            operators[3].Add("%");
            operators[4].Add("+");
            operators[4].Add("-");
            operators[14].Add("=");
            operators[16].Add("#");
        }
        private int Search(string op)
        {
            for (int i = 1; i < operators.Length; i++)
            {
                for (int j = 0; j < operators[i].Count; j++)
                {
                    if (operators[i][j] == op)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }

        //计算2个数的结果
        private double Calculate(double a, double b, string op)
        {
            double sum;
            switch (op)
            {
                case "+":
                    {
                        sum = a + b;
                        break;
                    }
                case "-":
                    {
                        sum = a - b;
                        break;
                    }
                case "*":
                    {
                        sum = a * b;
                        break;
                    }
                case "/":
                    {
                        sum = a / b;
                        break;
                    }
                default:
                    {
                        sum = 0;
                        break;
                    }
            }
            return sum;

        }

        public string Analyse(string In)
        {
            string Out = "";
            string temp = "";
            string tri = "";
            string ret = "";
            string cal = "";
            double sum = 0;
            double dotemp1, dotemp2;
            Stack<double> digi = new Stack<double>();
            Stack<string> op = new Stack<string>();
            Stack<int> sub = new Stack<int>();
            try
            {
                In = In.Trim();
                sub.Push(0);
                for (int i = 0; i < In.Length; )
                {
                    temp = "";
                    tri = "";
                    ret = "";
                    for (; i < In.Length && In[i] >= '0' && In[i] <= '9' || i != 0 && In[i] == '.' && In[i - 1] >= '0' && In[i - 1] <= '9' && In[i + 1] >= '0' && In[i + 1] <= '9'; i++)
                    {
                        temp += In[i];
                    }
                    if (temp.Length != 0)
                    {
                        if (Out.Length != 0 && (Out[Out.Length - 1] >= '0' && Out[Out.Length - 1] <= '9'))
                            Out += '&';
                        Out += temp;
                        digi.Push(double.Parse(temp));
                        temp = "";
                    }
                    for (; i < In.Length && (In[i] < '0' || In[i] > '9'); i++)
                    {
                        temp += In[i];
                    }
                    for (int j = 0; j < temp.Length; j++)
                    {
                        if (temp[j] == '(')
                        {
                            for (; op.Count != sub.Peek() && Search(tri) >= Search(op.Peek()); )
                            {
                                cal = op.Pop();
                                dotemp2 = digi.Pop();
                                dotemp1 = digi.Pop();
                                sum = Calculate(dotemp1, dotemp2, cal);
                                digi.Push(sum);
                                Out += cal;
                            }
                            op.Push(tri);
                            sub.Push(op.Count);
                            tri = "";
                            ret = "";
                            continue;
                        }
                        if (temp[j] == ')')
                        {
                            for (int n = sub.Pop(); op.Count > n; )
                            {
                                cal = op.Pop();
                                dotemp2 = digi.Pop();
                                dotemp1 = digi.Pop();
                                sum = Calculate(dotemp1, dotemp2, cal);
                                digi.Push(sum);
                                Out += cal;
                            }
                            continue;
                        }
                        tri += temp[j];
                        if (Search(tri) == 0)
                        {
                            if (tri.Length <= 1)
                            {
                                return "Unknown Char";
                            }
                            else
                            {
                                j--;
                                for (; op.Count != sub.Peek() && Search(ret) >= Search(op.Peek()); )
                                {
                                    cal = op.Pop();
                                    dotemp2 = digi.Pop();
                                    dotemp1 = digi.Pop();
                                    sum = Calculate(dotemp1, dotemp2, cal);
                                    digi.Push(sum);
                                    Out += cal;
                                }
                                op.Push(ret);
                                tri = "";
                                ret = "";
                            }
                        }
                        else
                        {
                            if (j == temp.Length - 1)
                            {
                                for (; op.Count != sub.Peek() && Search(tri) >= Search(op.Peek()); )
                                {
                                    cal = op.Pop();
                                    dotemp2 = digi.Pop();
                                    dotemp1 = digi.Pop();
                                    sum = Calculate(dotemp1, dotemp2, cal);
                                    digi.Push(sum);
                                    Out += cal;
                                }
                                op.Push(tri);
                            }
                            ret = tri;
                        }
                    }
                }
                Out += "\r\n" + sum.ToString();
            }
            catch (System.Exception)
            {
                return "错误";
            }
            return Out;
        }
    }
}
