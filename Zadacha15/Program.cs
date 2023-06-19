// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


Console.Write ("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case (1):
    Console.Write ("Понедельник");
    break;

    case (2):
    Console.Write ("Вторник");
    break;

    case (3):
    Console.Write ("Среда");
    break;

    case (4):
    Console.Write ("Четверг");
    break;

    case (5):
    Console.Write ("Пятница");
    break;

    case (6):
    Console.Write ("Суббота");
    break;

    case (7):
    Console.Write ("Воскресенье");
    break;

}