Console.WriteLine("Введите число - ");
int Number = int.Parse(Console.ReadLine());
if (Number < 100)
{
    Console.Write("Ошибка, введите как минимум, трехзначное число");
}
else
int c = 10;
int Third = Number / c;
Console.WriteLine($"Третье число - {(Number / c) % 10}");

