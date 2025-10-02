using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class pengolahanNilai
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan jumlah siswa: ");
            int jumlah = int.Parse(Console.ReadLine());

            int[] nilai = new int[jumlah];

            for (int i = 0; i < jumlah; i++)
            {
                Console.Write($"Nilai siswa ke-{i + 1}: ");
                nilai[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n=== Hasil Kategori Nilai ===");
            foreach (int n in nilai)
            {
                string kategori = "";
                if (n >= 85) kategori = "A";
                else if (n >= 70) kategori = "B";
                else if (n >= 55) kategori = "C";
                else kategori = "D";

                Console.WriteLine($"Nilai {n} -> Kategori {kategori}");
            }
        }

    }
}
