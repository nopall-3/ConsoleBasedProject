using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class bilanganGanjil
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BILANGAN GANJIL 1 - 50 ===\n");
        int i = 1; // mulai dari 1 karena bilangan ganjil pertama adalah 1
            do
            {
                Console.Write($"{i} "); // cetak bilangan ganjil
                i += 2; // naik 2 supaya tetap bilangan ganjil
            } while (i <= 50); // akan berhenti jika i > 50

            Console.WriteLine("\\n\\nProgram selesai. Tekan ENTER untuk keluar...");
            Console.ReadLine();
        }
    }
}
