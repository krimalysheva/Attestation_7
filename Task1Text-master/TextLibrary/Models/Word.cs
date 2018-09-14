using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Text
{
    public class Word
    {
        private string _value;

        public Word(string value)
        {
            this._value = value;
        }

        public override string ToString()
        {
            return _value;
        }

        public string Capitalized() {
            if (String.IsNullOrEmpty(_value)) {
                return "";
            }

            string newValue = _value.Remove(0, 1);
            return newValue.Insert(0, Char.ToUpper(_value[0]).ToString());
        }
    }
}
