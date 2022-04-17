using System;
Console.Clear();

int num;

Console.WriteLine("Введите трёхзначное число: ");

num = Convert.ToInt32(Console.ReadLine());

string numS = num.ToString();
int a1 = Convert.ToInt32(numS[0].ToString());
int a2 = Convert.ToInt32(numS[1].ToString());
int a3 = Convert.ToInt32(numS[2].ToString());

Console.WriteLine($"второе число {a2}");