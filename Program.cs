﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели начиная с понедельника"); //приглашение пользователя ввести информацию
int N = Convert.ToInt32( Console.ReadLine());
int n=N;
if (N <= 0 || N>7)
{
    Console.WriteLine("Нет такого дня недели");
}
else if (N >= 1 && N <6)
{
        Console.Write("Не является выходным днём");
    }
else Console.Write("Является выходным днём");
