//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write ("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = 0;

if (num1 !< 100)
{
    Console.Write ("третьей цифры нет");
}
while (num1 != num1%100)
{
    num2 = num1%10;
    num1 = num1/10;
}
Console.Write (num2);
      
