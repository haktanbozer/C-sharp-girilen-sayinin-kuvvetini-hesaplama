using System;

namespace Ders_01
{
class Program
{
static void Main(string[] args)
{
int val, kuvvet, result;
System.Console.Write("Bir sayı giriniz : ");
val = int.Parse(System.Console.ReadLine());
System.Console.Write("Sayının kuvvetini giriniz : ");
kuvvet = int.Parse(System.Console.ReadLine());
result = MyMath.MyPow(val, kuvvet);
System.Console.WriteLine("{0} sayısının {1} kuvveti = {2}", val, kuvvet, result);
}
}
class MyMath
{
public static int MyPow(int val, int kuvvet)
{
int result = 1;
for (int i = 0; i < kuvvet; i++)
result *= val; // result = result * val;
return result;
}
}
}
