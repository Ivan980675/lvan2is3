using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class28
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            string result = "";
            bool toUpper = true;
            foreach (char c in input)
            {
                if (toUpper)
                    result += char.ToUpper(c);
                else
                    result += char.ToLower(c);

                toUpper = !toUpper;
            }

            Console.WriteLine("Результат: " + result);

            Console.Write("Введите число до 1000: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i.ToString("D3"));
            }
            int[] array = new int[5];
            Console.WriteLine("Введите пять элементов массива:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Массив в обратном порядке:");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}





















