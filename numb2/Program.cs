/*2. Реализуйте задачу 1 в виде статического класса StaticClass;
а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1
 * 
 */
using System;

namespace numb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random newRand = new Random();
            int amount = 0;
            int value = 4; 
            int[] array = new int[value];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = newRand.Next(-10, 10);
                Console.WriteLine(array[i]);
            }

          

            Console.WriteLine($"pair mount = {StaticClass.Solve(array)}");
            Console.ReadLine();
        }
    }

    static class StaticClass
    {
        public static int Solve(int[] array)
        {
            Random newRand = new Random();
            int amount = 0;
            int value = 4;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 && array[i + 1] % 3 != 0)
                {
                    amount++;
                }
                else if (array[i + 1] % 3 == 0 && array[i] % 3 != 0)
                {
                    amount++;
                }
            }
            return amount;
        }
    }
}
