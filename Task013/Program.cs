using System;
Console.Clear();

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num/100>0)
    {
    string numS = num.ToString();
    int a3 = Convert.ToInt32(numS[2].ToString());
    System.Console.WriteLine($"Третья цифра числа {num} -> {a3}");
    }
else
    {
    System.Console.WriteLine($"У числа {num} нет третьей цифры");
    }