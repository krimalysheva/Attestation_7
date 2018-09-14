using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Text {
    public class Sentence
    {
        private List<Word> _wordsList = new List<Word>();

        public void AddWord(Word word)
        {
            this._wordsList.Add(word);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            string delimeter = " ";

            for (int i = 0; i < _wordsList.Count; i++)
            {
                if (i == 0)
                {
                    builder.Append(_wordsList[0].Capitalized());
                    builder.Append(delimeter);
                }
                else if (i == (_wordsList.Count - 1))
                {
                    builder.Append(_wordsList[i] + ".");
                }
                else
                {
                    builder.Append(_wordsList[i]);
                    builder.Append(delimeter);
                }
            }
            return builder.ToString();
        }
    }
}
