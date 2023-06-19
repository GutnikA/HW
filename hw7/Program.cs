// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*
Console.WriteLine("введите размер массива");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

double[,] matrix = new double[m, n];
FillMatrixRandomRealNumbers(matrix);
PrintMatrix(matrix);


void FillMatrixRandomRealNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine("");
    }
}

*/




//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//(1,7) -> такого числа в массиве нет
//(0,0) -> 1

/*
Console.WriteLine("введите позицию элемента");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int [,] matrix = new int [5,5];
FillArrayRandomNumbers(matrix);
Console.WriteLine();
PrintMatrix(matrix);

if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
    Console.WriteLine();
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine();
    Console.WriteLine($"значение элемента с индексом ({n}, {m}) = {matrix[n-1,m-1]}");
}



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 10);
            }   
        }
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine("");
    }
}
*/





//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


 Console.WriteLine("введите размер массива");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m, n];
FillArrayRandomNumbers(matrix);

Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
SearchArithmeticMeanInColumn(matrix, m);

void SearchArithmeticMeanInColumn(int[,] matrix, int m)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            avarage = (avarage + matrix[i, j]);
        }
        avarage = avarage / m;
        Console.Write(avarage + "; ");
    }

}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine("");
    }
}
