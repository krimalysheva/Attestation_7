using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var text = new Text();
            var sentence = new Sentence();
            sentence.AddWord(new Word("vitochka"));
            sentence.AddWord(new Word("programmist"));

            var sentence2 = new Sentence();
            sentence2.AddWord(new Word("the"));
            sentence2.AddWord(new Word("best"));

            text.Title = "Title";
            text.AddSentence(sentence);
            text.AddSentence(sentence2);

            this.textBox1.Text = text.ToString();
        }
    }
}
