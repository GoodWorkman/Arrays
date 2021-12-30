/*1.	Дан  целочисленный  массив  из 20 элементов. 
 * Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
 * Заполнить случайными числами.  
 * Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
 * В данной задаче под парой подразумевается два подряд идущих элемента массива.
 * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
 * 
 */

using System;
using System.IO;

namespace _2212Massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Random newRand = new Random();
            int amount = 0;
            int value = 20;
            //string data = File.ReadAllText(@"");
            //int a = int.Parse(data);

            int[] array = new int[value];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = newRand.Next(-10000, 10000);
                Console.WriteLine(array[i]);
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 && array[i + 1] % 3 != 0)
                {
                    amount++;
                }
                else if (array[i+1] % 3 == 0 && array[i] % 3 != 0)
                {
                    amount++;
                }
                

            }

            Console.WriteLine($"pair mount = {amount}");
            Console.ReadLine();
        }
    }
}
