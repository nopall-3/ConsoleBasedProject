using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class dataUmur
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Nama Anda : ");
            string nama = Console.ReadLine();

            Console.WriteLine("Masukkan Umur Anda : ");
            int umur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Halo " + nama + " ,umur anda " + umur + " tahun ");
            Console.ReadKey();
        }
    }
}