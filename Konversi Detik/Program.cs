using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konversi_Detik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float detik, menit, jam;
            Console.WriteLine("Mengubah detik menjadi menit dan jam");
            Console.WriteLine();
            Console.WriteLine("Masukan detik :");
            detik = int.Parse(Console.ReadLine());
            menit = detik / 60;
            jam = detik / 3600;
            Console.WriteLine();
            Console.WriteLine(menit + " menit");
            Console.WriteLine(jam + " jam");
        }
    }
}
