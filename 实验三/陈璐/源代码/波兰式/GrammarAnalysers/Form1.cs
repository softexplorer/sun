using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrammarAnalysers
{
    public partial class AnaForm : Form
    {
        GrammarAnalyser graanalyser = new GrammarAnalyser();
        WordAnalyser woanalyser = new WordAnalyser();
        PolandAnalyser poanalyser = new PolandAnalyser();
        public AnaForm()
        {
            InitializeComponent();
            Word[] words = new Word[4];
            RecInitialWords(words);
            for (int i = 0; i < words.Length; i++)
            {
                woanalyser.InsertWord(words[i]);
            }
            woanalyser.SetStartWord('E');
        }

               private void RecInitialWords(Word[] words)
        {
            words[0] = new Word('E');
            words[0].InsertTranform("eBaA");
            words[1] = new Word('A');
            words[1].InsertTranform("a");
            words[1].InsertTranform("bAcB");
            words[2] = new Word('B');
            words[2].InsertTranform("dEd");
            words[2].InsertTranform("aC");
            words[3] = new Word('C');
            words[3].InsertTranform("e");
            words[3].InsertTranform("dC");
        }

        private void woanabutton_Click(object sender, EventArgs e)
        {
            string sIn;
            sIn = Input.Text;
            Output.Text = graanalyser.Analyse(sIn);
        }

        private void grabutton_Click(object sender, EventArgs e)
        {
            string sIn;
            sIn = Input.Text;
            Output.Text = woanalyser.RecAnalysing(sIn);
        }

        private void polbutton_Click(object sender, EventArgs e)
        {
            string sIn;
            sIn = Input.Text;
            Output.Text = poanalyser.Analyse(sIn);
        }
    }
}
