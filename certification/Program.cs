//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

PrintNumbers(n);

void PrintNumbers(int n)
{
    if (n < 1)
    {
        return;
    }
    Console.WriteLine(n);
    PrintNumbers(--n);
}*/





//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*
Console.Write("Введите значение M и N: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int result = SumNumbersInRange(m, n);
 Console.WriteLine(result);

int SumNumbersInRange(int m, int n)
{
  {
    int sum = m;
    if (m == n)
        return sum;
    else
    {
        m++;
        sum = m + SumNumbersInRange(m, n);
        return sum-1;
    }
}
}
*/




//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите два неотрицательных числа M и N: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int functionAkkerman = Ack(m, n);

Console.Write($"A(m,n) = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}



