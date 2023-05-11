using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveTask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int arrayLenght = 10;
            int[] numbers = new int[arrayLenght];
            Random arrayRandom = new Random();
            int minNumberInArray = 0;
            int maxNumberInArray = 30;
            int tempNumber = 0;

            Console.WriteLine("\nВыводим для начала сам массив:");

            for (int i = 0; i < numbers.Length; i++) 
            {
                numbers[i] = arrayRandom.Next(minNumberInArray, maxNumberInArray);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\n\nТеперь выведем отсортированный массив:");
            
            for (int i = 0; i < numbers.Length; i++) 
            {
                for (int j = i + 1; j < numbers.Length; j++) 
                {
                    if (numbers[i] > numbers[j]) 
                    {
                        tempNumber = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = tempNumber;
                    }
                }
                
                Console.Write(numbers[i] + " ");
            }
            
            Console.ReadLine();
        }
    }
}
