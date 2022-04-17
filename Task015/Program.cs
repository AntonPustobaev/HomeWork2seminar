using System;

Console.Clear();

Console.Write("Введите число от 1 до 7: ");

int numDay = Convert.ToInt32(Console.ReadLine());

string[] days = {" 1 = понедельник", "2 = вторник", "3 = среда", "4 =четверг", "5 = пятница", "6 = суббота", "7 = воскресенье"};

string result = (numDay>5)?$"{numDay} -> Выходной!!":$"{numDay} -> Не выходной!!";

Console.WriteLine(result);