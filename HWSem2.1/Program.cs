// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите любое трехзначное число");
int num = Int32.Parse(Console.ReadLine());
if(num>=100 && num<=1000)
{
    int num1=num/10; 
    int num2=num1%10;
    Console.WriteLine(num2);
}
else 
{
    Console.WriteLine("Число не трёхзначное");
}