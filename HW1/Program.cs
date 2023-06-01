/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

/*
Console.WriteLine ("Введите первое число");

int a = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите второе число");

int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.Write ("max = ");
    Console.Write (a);
}
else
{
    Console.Write ("max = ");
    Console.Write (b);
}
*/



/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

/*
Console.WriteLine("Введите число");

int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");

int y = int.Parse(Console.ReadLine());

Console.WriteLine("Введите последнее число");

int z = int.Parse(Console.ReadLine());

int max = x;

if (y > max)
{
    max = y;
}
if (z > max)
{
    max = z;
}

Console.Write (max);
*/




/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

/*
Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());

double resulte = (double)number % 2;

if (resulte == 0)
{
    Console.Write("да");
}
else 
{
    Console.Write("нет");
}
*/





/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */


Console.WriteLine("Введите число");

int N = int.Parse(Console.ReadLine());

int i = 0;

if (N == 1)
{
    Console.WriteLine("В заданном диапазоне нет четных чисел");
    return;
}

if (N > 1)
{
    while (i < N - 1)
    {
        i = i + 2;
        Console.Write(i);
        Console.Write(" ");
    }
    return;
}

if (N < 1)
{
    while (i >= N)
    {
        Console.Write(i);
        Console.Write(" ");
        i = i - 2;

    }
    return;
}