using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temaApp1
{
    class Program
    {
        public class Asignare
        {
            public static void Main(string[] args)
            {
                int a = 3;
                int b = (a = 2) * a;
                int c = b * (b = 5);
                Console.WriteLine(“a =” +a + “, b =” +b + “, c =” +c);
                Console.Read();


            }
        }

    }
}
