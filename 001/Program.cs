// 001. По двум заданным числам проверять является ли первое квадратом второго

Console.Clear();

int num1 = new Random().Next(1,10);
Console.WriteLine("num1 = " + num1);

int num2 = new Random().Next(1,10);
Console.WriteLine("num2 = " + num2);

if (num1 == num2 * num2)
{
    Console.WriteLine($"{num1} является квадратом {num2}");
}
else
{
    Console.WriteLine($"{num1} НЕ является квадратом {num2}");
}
