using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class tabelPerkalian
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TABEL PERKALIAN 1 - 10 ===\n");

            for (int i = 1; i <= 10; i++) // Baris
            {
                for (int j = 1; j <= 10; j++) // Kolom
                {
                    Console.Write($"{i * j,4}"); // ,4 = lebar 4 spasi agar rata
                }
                Console.WriteLine(); // Ganti baris setelah 1 baris selesai
            }

            Console.WriteLine("\nTekan ENTER untuk keluar...");
            Console.ReadLine();
        }
    }
}
