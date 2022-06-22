using System;

namespace Ders_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double val, kuvvet, result;
            System.Console.Write("Bir sayı giriniz : ");
            val = double.Parse(System.Console.ReadLine());
            System.Console.Write("Sayının kuvvetini giriniz : ");
            kuvvet = double.Parse(System.Console.ReadLine());
            result = System.Math.Pow(val, kuvvet);
            System.Console.WriteLine("{0} sayısının {1} kuvveti = {2}", val, kuvvet, result);
        }
    }
}
