using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public class Disk
    {
        public List<Composition> Compositions { get; private set; } = new List<Composition>();
        public double Duration => Compositions.Sum(x => x.Time);

        public Disk()
        {

        }

        public Disk(List<Composition> compositions)
        {
            Compositions = compositions;
        }

        public void WriteCompositions(List<Composition> compositions)
        {
            Compositions = compositions;
        }

        public void Sort()
        {
            Compositions.Sort();
        }

        public List<Composition> Search(double from, double to)
        {
            List<Composition> newCompositionList = new List<Composition>();
            foreach (Composition composition in Compositions)
            {
                if (composition.Time > from && composition.Time < to)
                    newCompositionList.Add(composition);
                else continue;
            }
            return newCompositionList;
        }

    }
}

