using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrammarAnalysers
{
    class GrammarAnalyser
    {
        string[] reswords = { "if", "int", "for", "while", "do", "return", "break", "continue" };
        string[] operators = { "+", "-", "*", "/", "=", ">", "<", ">=", "<=", "!=" };
        string[] separators = { ",", ";", "{", "}", "(", ")" };
        public GrammarAnalyser()
        {
        }

        //判断字符串是否只由数字和字母组成
        public bool WordJudege(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                //如果word[i]既不是字母也不是数字
                if (word[i] < '0' || word[i] < 'A' && word[i] > '9' || word[i] > 'z' || word[i] < 'a' && word[i] > 'Z')
                {
                    return false;
                }
            }
            return true;
        }

        //判读字符串是否只含有数字
        public bool NumJudge(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] < '0' || word[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
        //解析单个单词并返回类型
        public int AnalyseWord(string word)
        {
            int i;
            if (word[0] >= 'a' && word[0] <= 'z' || word[0] >= 'A' && word[0] <= 'Z')
            {
                if (WordJudege(word) == false)
                    return -2;
                for (i = 0; i < reswords.Length; i++)
                {
                    if (word == reswords[i])
                        return 1;
                }
                return 2;
            }
            else if (word[0] >= '0' && word[0] <= '9')
            {
                if (NumJudge(word) == false)
                    return -3;
                return 3;
            }
            else
            {
                for (i = 0; i < operators.Length; i++)
                {
                    if (word == operators[i])
                        return 4;
                }
                for (i = 0; i < separators.Length; i++)
                {
                    if (word == separators[i])
                        return 5;
                }
                return -4;
            }
            return 0;
        }
        //将输入内容解析并返回解析内容中
        public string Analyse(string In)
        {
            string temp, pre, Out = "";
            int anaresult = 0;
            for (int i = 0; i < In.Length; i++)
            {
                temp = "";
                pre = temp;
                anaresult = 0;
                for (; i < In.Length && In[i] != ' ' && In[i] != '\r' && In[i] != '\n'; i++)
                {
                    temp += In[i];
                    anaresult = AnalyseWord(temp);
                    if (anaresult <= 0 && pre.Length > 0)
                    {
                        temp = pre;
                        i--;
                        break;
                    }
                    pre = temp;
                }
                if (temp.Length > 0)
                {
                    Out += "{ " + AnalyseWord(temp) + " , " + temp + " }" + "\r\n";
                }
            }
            return Out;
        }
    }
}
