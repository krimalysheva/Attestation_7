using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public class Disk
    {
        public List<Composition> Compositions { get; set; } = new List<Composition>();
        public double Duration => Compositions.Sum(x => x.Time);

        public Disk(List<Composition> compositions)
        {
            Compositions = compositions;
        }

        public void Sort()
        {
            Compositions.Sort();
        }

        //public static double CountSound(List<Composition> compositions)
        //{
        //    double duration = 0.0;

        //    foreach (Composition composition in compositions)
        //    {
        //        duration += composition.Time;
        //    }

        //    return duration;
        //}

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

