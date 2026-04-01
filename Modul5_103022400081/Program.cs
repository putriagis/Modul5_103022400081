// See https://aka.ms/new-console-template for more information
using Modul5_103022400081;
using System;

namespace Modul5_10302240081
{
    internal class program
    {
        static void Main(string[] args)
        {
            PemrosesData nilai = new PemrosesData();
            float terbesar = nilai.DapatkanNilaiTerbesar(10, 30, 22);
            Console.WriteLine("nilai terbesar: " + terbesar);
        }
    }
    
}
