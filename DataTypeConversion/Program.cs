using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            long l = 120;
            l = i; 
            i = Convert.ToInt32(l);
            l = Convert.ToInt64(Console.ReadLine());
            double dl = 10.5;
            decimal d2= (decimal)dl;
            char c = 'a';
            c = Convert.ToChar(i);
            Console.ReadKey();

        }
    }
}
