using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumLenght(23423));
            Console.ReadLine();
        }
        static int NumLenght(int num)
        {
            int cont = 0;
            while (num > 0)
            {
               num= num / 10;
                cont++;
            }
            return cont;
        }
    }
}
