using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace цикл_wile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "";
            while (password == "exit")

            {
                Console.Write("Введите пароль: ");
                password = Console.ReadLine();

            }
        }
    }
}
