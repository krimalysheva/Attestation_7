using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramLogic
{
    public class CompositionsFilesUtils
    {
        public static List<Composition> ReadCompositionFromFile(string path)
        {
            List<Composition> compositionsList = new List<Composition>();
            
            string[] fileLines = File.ReadAllLines(path);

            foreach (string line in fileLines) {
                string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = parts[0] + " " + parts[1];
                double time = double.Parse(parts[2]);
                string genre = parts[3];
                compositionsList.Add(new Composition(name, time, genre));
            }

            return compositionsList;
        }

        public static void SaveCompositionsToFile(string path, List<Composition> compositions) {
            List<string> lines = new List<string>();

            foreach (Composition composition in compositions) {
                lines.Add(composition.Name + " " + composition.Time + " "+ composition.Genre);
            }

            File.WriteAllLines(path, lines);
        }
    }
}
