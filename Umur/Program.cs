using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nama;
            int Tahun;
            Console.WriteLine("Masukan nama anda :");
            nama = Console.ReadLine();
            Console.WriteLine("Masukan tahun lahir anda :");
            Tahun = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Nama Anda : " + nama);
            Console.WriteLine("Umur Anda : " + (2024 - Tahun) + " tahun");
        }
    }
}
