using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBased
{
    internal class ConsoleCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Console Calculator");
            Console.WriteLine("-------------------------");

            //input angka pertama
            Console.Write("Masukkan Angka Pertama: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            //input angka kedua
            Console.Write("Masukkan Angka Kedua: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //pilih operasi
            Console.WriteLine("Pilih Operator (+, -, *, /): ");
            char operation = Console.ReadLine()[0];
            double result = 0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Error: Division by zero");
                    return;
                default:
                    Console.WriteLine("Error: Invalid operation");
                    return;
            }
            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            Console.ReadKey(); // Keep the console window open
        }
    }
}