using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            bilgisayar b1 = new bilgisayar();

            b1.hardDisk.hardDiskYaz();

            b1.islemci.islemciYaz();

            b1.ram.ramYaz();

            Console.ReadLine();

        }
    }
}
