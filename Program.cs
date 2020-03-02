using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи число n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи число m");
            int m = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            Console.WriteLine("Попробуй угадай)))");
            int w = Convert.ToInt32(Console.ReadLine());
            int q = rnd.Next(n, m);
            if (q == w)
            {
                Console.WriteLine("Красава");
            }
            else
            {
                Console.WriteLine("Не то");
            }
            Console.ReadKey();
        }
    }
}
