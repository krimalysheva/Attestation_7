using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Text
{
    public class Text
    {
        private List<Sentence> _sentences = new List<Sentence>();
        public string Title { get; set; }

        public void AddSentence(Sentence sentence)
        {
            _sentences.Add(sentence);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string delimeter = " ";

            stringBuilder.AppendLine(Title ?? "No title");

            for (int i = 0; i < _sentences.Count; i++)
            {
                stringBuilder.Append(_sentences[i].ToString());
                if (i != (_sentences.Count - 1))
                {
                    stringBuilder.Append(delimeter);
                }
            }
            return stringBuilder.ToString();
        }
    }
}
