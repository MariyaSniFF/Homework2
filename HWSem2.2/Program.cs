﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(100>num)
{
    Console.WriteLine("Третьей цифры нет");
}
 else {
    while(num > 1000)
    {
        num/=10;
    }
        int result = num%10;

Console.WriteLine($"Третья цифра {result}");
     }