// 002. Даны два числа. Показать большее и меньшее.

Console.Clear();

int num1 = new Random().Next(1,100);
Console.WriteLine("num1 = " + num1);

int num2 = new Random().Next(1,100);
Console.WriteLine("num2 = " + num2);

if (num1 < num2)
{
    Console.WriteLine($"(min = {num1}, max = {num2})");
}
else
{
    Console.WriteLine($"(min = {num2}, max = {num1})");
}
