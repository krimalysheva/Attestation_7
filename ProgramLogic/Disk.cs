using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public class Disk
    {
        public static List<Composition> Sort(List<Composition> composition)
        {
            List<Composition> newCompositionList = new List<Composition>(composition);
            newCompositionList.Sort();
            return newCompositionList;
        }

        public static double CountSound(List<Composition> compositions)
        {
            double duration = 0.0;

            foreach (Composition composition in compositions)
            {
                duration += composition.Time;
            }

            return duration;
        }

        public static List<Composition> Search(List<Composition> compositions, double from, double to)
        {
            //List<Composition> newCompositionList = new List<Composition>(composition);
            List<Composition> newCompositionList = new List<Composition>();
            foreach (Composition composition in compositions)
            {
                if (composition.Time > from && composition.Time < to)
                    newCompositionList.Add(composition);
                else continue;
            }
            return newCompositionList;

        }

    }
}

