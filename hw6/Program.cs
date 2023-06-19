// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*
Console.WriteLine("Введите числа: ");
int[] numbers = ConvertToNumber(Console.ReadLine());

PositiveValuesArray(numbers);


int[] ConvertToNumber(string input)
{
    int f = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            f++;
        }
    }

    int[] numbers = new int [f];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string tmp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            tmp += input [i].ToString();
            i++;
        }
        else
        {
            tmp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(tmp);
        index++;
    }
    return numbers;
}

void PositiveValuesArray (int[] array)
{
    int positive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
       if (array[i] > 0)
       {
        positive++;
       }
    }
    Console.WriteLine($" положительных чисел введено: {positive}");
}
*/




//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
Console.Write("введите значение b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите число k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите значение b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите число k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());

FindingIntersections(b1, k1, b2, k2);


void FindingIntersections(double b1, double k1, double b2, double k2)
{
    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;

    Console.WriteLine($"прямые пересекутся в точке X: {x}, Y: {y}");
}
*/