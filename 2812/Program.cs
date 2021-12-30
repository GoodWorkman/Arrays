/*Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
    Создайте структуру Account, содержащую Login и Password.
    */

using System;
using System.IO;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/Users/nikolaj/GITHOMEWORK/textfile.txt";
            string login;
            string password;
            int count = 0;
            int maxTryes = 3;
            string [] data = File.ReadAllLines(path);

            for (int i = 0; i < data.Length; i+=2)
            {
                login = data[i];
                password = data[i+1];

                if (login == "root" && password == "GeekBrains")
                {
                    Console.WriteLine("Success");
                    return;

                }
                else
                {
                    Console.WriteLine("Authecation denied");
                }
            }


            /*do
            {
                Console.WriteLine("\nВведите логин:");
                login = Console.ReadLine();

                Console.WriteLine("\nВведите пароль");
                password = Console.ReadLine();

                count++;

                if (login == "root" && password == "GeekBrains")
                {
                    Console.WriteLine("Authorization Success");
                    return;

                }

                Console.WriteLine($"вам осталось {maxTryes - count} раза из трех");
            }
            while (count < maxTryes);
            Console.WriteLine("Authorization denied");*/
            Console.ReadLine();
        }
    }
}