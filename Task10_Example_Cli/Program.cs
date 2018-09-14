using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using ProgramLogic;
using System.IO;

namespace L1_Cli
{
    class Program
    {
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

                }
            }

            Console.WriteLine();
        }

        static void PrintStudentsList(List<Composition> compositions)
        {
            Console.WriteLine("Отсортированный список: ");

            foreach (Composition composition in compositions)
            {
                Console.WriteLine(composition.Name + " " + composition.Time);
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            while (true)
            {

                // Читаем список 
                List<Composition> compositions = ReadCompositionsList();

                // Сортируем список 
                List<Composition> sortedCompositions = disk.Sort();

                PrintStudentsList(sortedCompositions);

                if (ConsoleUtils.Confirm("Сохранить список в файл?"))
                {
                    SaveCompositionsToFile(sortedCompositions);
                }

                if (ConsoleUtils.Confirm("Продолжить работу с программой?"))
                {
                    Console.Clear();
                    continue;
                }

                break;
            }
        }
    }
}
