// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число - ");
int Number = int.Parse(Console.ReadLine());
if (Number < 100)
{
    Console.Write("Ошибка, введите трехзначное число");
}
else
{
    int c = 10;
while (true)
{
int Second = Number / c;
if (Second > 10 && Second < 100)
{
    break;
}
else 
{
    c *= 10;
}
}
Console.WriteLine($"Второе число - {(Number / c) % 10}");
}

