﻿// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Число кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно одновременно 7 и 23");
}