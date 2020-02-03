using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;  
            int b = (a = 2) * a; // a devine 2 iar b devine 4
            int c = b * (b = 5); // b devine 5
            Console.WriteLine("a =" +a+ ", b =" +b+ ", c ="+c);

            // afiseaza : a=2, b=5, c=20;
        }
    }
}
