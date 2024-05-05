using System;
try
{
    Console.Write("Введите число ");
    int num = int.Parse(Console.ReadLine());
    int i = 2;

    if (num % 1 == 0)
    {
        Console.WriteLine("Целое число");
    }

    if (num % 2 == 0)
    {
        Console.WriteLine("Число четное");

    }
    else
    {
        Console.WriteLine("Число нечетное");
    }
    for (; i < num; i++)
    {
        if (num % i == 0)
        {
            Console.WriteLine("Число составное");
            break;
        }
        else
        {
            Console.WriteLine("Число простое");
            break;
        }
    }
}
catch
{
    Console.WriteLine("Похоже вы ввели не целое число. Повторите попытку");
}
