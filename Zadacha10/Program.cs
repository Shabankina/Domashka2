﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782  -> 8
//918 -> 1

Console.Write ("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int result = (number-(number - (number%100)))/10;
Console.WriteLine(result);