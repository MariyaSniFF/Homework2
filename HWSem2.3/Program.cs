// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//
Console.WriteLine("Введите номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine("Не входной");
        break;
    case 2:
        Console.WriteLine("Не входной");
        break;
    case 3:
        Console.WriteLine("Не входной");
        break;
    case 4:
        Console.WriteLine("Не входной");
        break;
    case 5:
        Console.WriteLine("Не входной");
        break;
    case 6:
        Console.WriteLine("Выходной");
        break;
    case 7:
        Console.WriteLine("Выходной");
        break;
    default:
        Console.WriteLine("Цифра не обозначает день недели");
        break;
}
