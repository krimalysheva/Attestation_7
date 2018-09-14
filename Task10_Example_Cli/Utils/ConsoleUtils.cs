using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class ConsoleUtils
    {
        public static T ReadValue<T>(string name, Func<T, bool> validator = null)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите " + name + ": ");
                    T value = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

                    if (validator != null && !validator(value))
                        throw new Exception();

                    return value;
                }
                catch (Exception e)
                {

                }
            }
        }

        public static bool Confirm(string question)
        {
            ConsoleKey key;

            do
            {
                Console.Write(question + " [y/n]: ");
                key = Console.ReadKey(false).Key;

                if (key != ConsoleKey.Enter)
                {
                    Console.WriteLine();
                }

            } while (key != ConsoleKey.Y && key != ConsoleKey.N);

            return key == ConsoleKey.Y;
        }
    }
}
