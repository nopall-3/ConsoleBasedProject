using System;

namespace ConsoleAppIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nama Anda: ");
            string nama = Console.ReadLine();

            Console.Write("Masukkan umur Anda: ");
            int umur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Halo " + nama + ", umur Anda " + umur + " tahun.");
            Console.ReadKey();
        }
    }
}
