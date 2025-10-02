using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class nilaiSiswa
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan jumlah siswa: ");
            int jumlah = int.Parse(Console.ReadLine());

            int[] nilai = new int[jumlah];

            for (int i = 0; i < jumlah; i++)
            {
                Console.Write($"Masukkan nilai siswa ke-{i + 1}: ");
                nilai[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n=== Daftar Nilai Siswa ===");
            foreach (int n in nilai)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine($"\nRata-rata: {nilai.Average():F2}");
            Console.WriteLine($"Nilai tertinggi: {nilai.Max()}");
            Console.WriteLine($"Nilai terendah : {nilai.Min()}");

            Console.ReadLine();
        }
    }
}
