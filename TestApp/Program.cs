using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine();
            var num = 250;
            
            var hundreds = Convert.ToInt32(Math.Truncate(num / 100.0));
            var tens = Convert.ToInt32(Math.Truncate((num - (hundreds * 100.0)) / 10));
            var ones = Convert.ToInt32(Math.Truncate((num - ((hundreds * 100.0) + (tens * 10)))));

            
            
            

            



            Console.WriteLine("Resultado: " + combinacoes[num]);
            Console.ReadKey();
        }
    }
}
