using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lingkaran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float r, luas, keliling, phi;
            Console.WriteLine("Carilah luas dan keliling lingkaran jika phi = 3,14");
            Console.WriteLine("masukan r : ");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Hasilnya : ");
            Console.WriteLine();
            phi = (float) 3.14;
            luas = phi * r * r;
            keliling = phi * 2 * r;

            Console.WriteLine("Luas : " + luas);
            Console.WriteLine("Keliling : " + keliling);

        }
    }
}
