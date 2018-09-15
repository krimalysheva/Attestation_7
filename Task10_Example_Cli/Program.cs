using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using ProgramLogic;
using System.IO;
using System.Threading;
using System.Globalization;

namespace L1_Cli
{
    class Program
    {
        private static Disk disk = new Disk();

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            while (true)
            {

                // Читаем список 
                List<Composition> compositions = ReadCompositionsList();
                disk.WriteCompositions(compositions);
                // Сортируем список 
                disk.Sort();

                PrintList(disk.Compositions);

                if (ConsoleUtils.Confirm("Сохранить список в файл?"))
                {
                    SaveCompositionsToFile(disk.Compositions);
                }

                if (ConsoleUtils.Confirm("Продолжить работу с программой?"))
                {
                    Console.Clear();
                    continue;
                }

                break;
            }
        }

        static List<Composition> ReadCompositionsList()
        {
            List<Composition> compositions;

            if (ConsoleUtils.Confirm("Ввести данные из файла?"))
            {
                while (true)
                {
                    try
                    {
                        string inputFilePath = ConsoleUtils.ReadValue<string>("путь к файлу",
                            (path) => (File.Exists(path)));

                        compositions = CompositionsFilesUtils.ReadCompositionFromFile(inputFilePath);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            else
            {
                int compositionsCount = ConsoleUtils.ReadValue<int>("количество композиций", (count) => (count > 0));

                compositions = new List<Composition>(compositionsCount);

                for (int i = 0; i < compositionsCount; i++)
                {
                    string name = ConsoleUtils.ReadValue<string>("Название композиции",
                        (string fullName) => fullName != "");
                    string genre = ConsoleUtils.ReadValue<string>("Жанр",
                        (string fullName) => fullName != "");

                    int points = ConsoleUtils.ReadValue<int>("Продолительность", (int p) => p > 0);

                    compositions.Add(new Composition(name, points,genre));
                }
            }

            Console.WriteLine();
            return compositions;
        }

        static void SaveCompositionsToFile(List<Composition> compositions)
        {
            while (true)
            {
                try
                {
                    string outputFilePath = ConsoleUtils.ReadValue<string>("путь к файлу");

                    CompositionsFilesUtils.SaveCompositionsToFile(outputFilePath, compositions);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine();
        }

        static void PrintList(List<Composition> compositions)
        {
            Console.WriteLine("Отсортированный список: ");

            foreach (Composition composition in compositions)
            {
                Console.WriteLine($"\"{composition.Name}\" {composition.Time} {composition.Genre}"); //интерполяция строк. выражения в скобках заменяются их строковым представлением
            }

            Console.WriteLine();
        }

        
    }
}
