using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public class Composition : IComparable 
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public double Time {
            get {
                return _time;
            }
            set
            {
                if (value < 0)
                    throw new Exception();

                _time = value;
            }
        }
        
        private double _time;

        public Composition(string name, double time, string genre)
        {
            this.Name = name;
            this.Time = time;
            this.Genre = genre;
        }

        public int CompareTo(object obj)
        {
            Composition otherComposition = obj as Composition;

            if (otherComposition == null)
                throw new ArgumentException();

            return Genre.CompareTo(otherComposition.Genre);
              
        }
    }
}
