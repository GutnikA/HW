﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

/**
Console.WriteLine("Введите трёхзначное число");

int N = int.Parse(Console.ReadLine());

if (N < 100 | N >= 1000)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

int P = N / 10;
int R = P % 10;

Console.WriteLine(R);
*/




/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6  */

/*
Console.WriteLine("Введите число");

int N = int.Parse(Console.ReadLine());

if (N > 99 & N < 1000)
{
    N = N % 10;
    Console.WriteLine(N);
    return;
}

if (N < 99)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}

if (N >= 1000)
{
    while (N > 999)
    {
        N = N / 10;
    }
    N = N % 10;
    Console.WriteLine(N);
    return;
}
*/




/*  Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет  */

/*
Console.WriteLine("Введите число");

int W = int.Parse(Console.ReadLine());

if (W > 7 | W < 1)
{ 
    Console.WriteLine("Такого дня недели не существует");
}

if (W >=1 & W <= 5)
{
       Console.WriteLine("Нет"); 
       return;
}

if (W == 6 | W == 7)
{
       Console.WriteLine("Да"); 
       return;
}
*/










 /*
int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);  */

