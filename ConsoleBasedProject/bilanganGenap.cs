using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class bilanganGenap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BILANGAN GENAP 1 - 50 ===\n");

            int i = 2; // mulai dari 2 karena 2 adalah bilangan genap pertama
            while (i <= 100)
            {
                Console.Write($"{i} ");
                i += 2; // tambahkan 2 agar tetap bilangan genap
            }

            Console.WriteLine("\n\nProgram selesai. Tekan ENTER untuk keluar...");
            Console.ReadLine();
        }
    }
}
