using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string zodiacSign;
            string job;
            int age;
            Console.Write("Ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Ваш возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ваш знак зодиака: ");
            zodiacSign = Console.ReadLine();
            Console.Write("Ваша профессия: ");
            job = Console.ReadLine();

            Console.WriteLine("Вас зовут " + name + ", вам " + age + " лет. Ваш знак зодиака " + zodiacSign + ", а ваша профессия " + job);
        }
    }
}
