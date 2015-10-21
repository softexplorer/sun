using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrammarAnalysers
{ 
    public class Word
    {
        char cName;
        List<string> vTranforms;

        public Word(char name)
        {
            vTranforms = new List<string>();
            cName = name;
        }

        //获取本个非终结符的名字
        public char GetName()
        {
            return cName;
        }
        
        //插入本个非终结符可转换的字符串
        public void InsertTranform(string sTranform)
        {
            vTranforms.Add(sTranform);
        }

        //查询转换字符串为指定字符的
        public string HeadSearchTranform(char head)
        {
            for (int i = 0; i < vTranforms.Count; i++)
            {
                if (vTranforms[i][0] == head)
                {
                    return vTranforms[i];
                }
            }
            return null;
        }
    }
}