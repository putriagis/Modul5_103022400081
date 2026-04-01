// See https://aka.ms/new-console-template for more information
using System;
namespace Modul5_103022400081;

class program
{
    private static void Main(string[] args)
    {
        SimpleDataBase<int> Database = new SimpleDataBase<int>();
        Database.addNewData(81);
        Database.addNewData(00);
        Database.addNewData(40);
        Database.printAllData();
    }
}


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

