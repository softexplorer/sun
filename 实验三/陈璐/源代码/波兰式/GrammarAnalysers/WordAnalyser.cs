using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrammarAnalysers
{
    class WordAnalyser
    {
        List<Word> lWords;
        char cStartword;
        int index = 0;

        public WordAnalyser()
        {
            lWords = new List<Word>();
            cStartword = 'S';
        }
        //插入新的语法
        public void InsertWord(Word newword)
        {
            lWords.Add(newword);
        }

        //设置开始符号
        public void SetStartWord(char word)
        {
            if (word < 'A' || word > 'Z')
            {
                cStartword = 'S';
            }
            else
                cStartword = word;
        }

        //查询拥有指定名称的非终结符
        public Word SearchWord(char name)
        {
            for (int i = 0; i < lWords.Count; i++)
            {
                if (lWords[i].GetName() == name)
                    return lWords[i];
            }
            return null;
        }

        //检测栈中元素是否按照指定顺序排列
 /*       private bool IfFinished(string input, Stack<char> stack)
        {
            for (int i = 0; i < stack.Count; i++)
            {
            }
            return true;
        }
*/
        //判断元素是否为终结符
        private bool IfEndChar(char word)
        {
            if (word >= 'a' && word <= 'z')
                return true;
            else
                return false;
        }

        //查询栈中所有元素
        private string StringInStack(Stack<char> stack)
        {
            string temp = "";
            char[] chars = new char[stack.Count];
            stack.CopyTo(chars, 0);
            for (int i = 0; i < chars.Length; i++)
            {
                temp += chars[i];
            }
            return temp;
        }
        
        //递归下降法递归分析函数
        public bool Rec(string words, string mywords, StringBuilder output)
        {
            Word wtemp;
            bool depend = true;
            if (mywords == null)
                return false;
            for (int i = 0; i < mywords.Length; i++)
            {
                if (words[index] == mywords[i])
                {
                    output.AppendLine(words[index] + "fit");
                    index++;
                }
                else if (IfEndChar(mywords[i]))
                {
                    output.AppendLine("can't fit word " + words[index]);
                    return false;
                }
                else
                {
                    wtemp = SearchWord(mywords[i]);
                    if (wtemp == null)
                    {
                        output.AppendLine("there are not word to fit " + words[index]);
                        return false;
                    }
                    output.AppendLine("extent" + mywords[i]);
                    if (Rec(words, wtemp.HeadSearchTranform(words[index]), output) == false)
                    {
                        depend = false;
                        break;
                    }

                }
            }
            return depend;
        }

        //递归下降分析法
        public string RecAnalysing(string words)
        {
            StringBuilder temoutput = new StringBuilder();
            string output = "";
            string temp = "";
            temp += cStartword;
            temp += '#';
            index = 0;
            if (Rec(words, temp, temoutput) == true)
                temoutput.AppendLine("finish");
            else
                temoutput.AppendLine("fail");
            for (int i = 0; i < temoutput.Length; i++)
                output += temoutput[i];
            return output;
        }

        //递归下降分析法
 /*       public string RecAnalysing(string words)
        {
            string output = "";
            string stemp, mywords = "";
            string tranform;
            Word wtemp;
            mywords += cStartword;
            mywords +='#';
            for (int i = 0; i < mywords.Length && i < words.Length; i++)
            {
                stemp = "";
                if (words[i] == mywords[i])
                    continue;
                else 
                {
                    if (IfEndChar(mywords[i]))
                    {
                        output += "wrong!Can't find char to fit";
                        return output;
                    }
                    else
                    {
                        wtemp = SearchWord(mywords[i]);
                        if (wtemp == null)
                        {
                            output += "wrong! Can't find word to fit";
                            return output;
                        }
                        tranform =wtemp.HeadSearchTranform(words[i]);
                        if (tranform == null)
                        {
                            output += "wrong!Can't find tranform to fit";
                            return output;
                        }
                        for (int j = 0; j < i; j++)
                            stemp += mywords[j];
                        stemp += tranform;
                        for (int j = i + 1; j < mywords.Length; j++)
                            stemp += mywords[j];
                        output += stemp + "\r\n";
                        mywords = stemp;
                    }
                }
            }
            output += "finish\r\n";
            output += words + "为合法字符串\r\n";
            return output;
        }
*/
        //LL(1)分析法
        public string LL1Analysing(string words)
        {
            Stack<char> tempstack = new Stack<char>();
            string output = "", stemp;
            char ctemp;
            Word wtemp;
            int index = 0;

            tempstack.Push('#');
            tempstack.Push(cStartword);

            for (int i = 0; i < 10000 && tempstack.Count != 0 && index < words.Length; i++)
            {
                ctemp = tempstack.Pop();
                output += ctemp + "出栈\r\n";
                if (IfEndChar(ctemp) || ctemp == '#')
                {
                    if (ctemp == words[index])
                    {
                        index++;
                        continue;
                    }
                    else
                    {
                        output += "can't fit char" + words[index] + "\r\n";
                        return output;
                    }
                    
                }
                else
                {
                    wtemp = SearchWord(ctemp);
                    if (wtemp == null)
                    {
                        output += ctemp + "wrong! can't find this char\r\n";
                        return output;
                    }
                    else
                    {
                        stemp = wtemp.HeadSearchTranform(words[index]);
                        if (stemp == null)
                        {
                            output += "wrong! there is no tranform string in " + wtemp.GetName() + " have this head\r\n";
                            return output;
                        }
                        for (int j = stemp.Length - 1; j >= 0; j--)
                        {
                            tempstack.Push(stemp[j]);
                            output += stemp[j] + "入栈\r\n" + "栈中情况" + StringInStack(tempstack) + "\r\n";
                        }
                    }
                }

            }
            if (tempstack.Count != 0)
            {
                output += "wrong! there are some char can't fit\r\n";
                for (int i = 0; tempstack.Count != 0; i++)
                    output += tempstack.Pop();
                return output;
            }
            return output + "finish";
        }
    }
}
