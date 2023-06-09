/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */


/*
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    SearchPalindromes(len);
}

else
{
    Console.WriteLine("Число не является пятизначным");
}

void SearchPalindromes(int len)
{

    if (number[0] == number[4] & number[1] == number[3])
    {
        Console.WriteLine($"{number} - да");
    }
    else
    {
        Console.WriteLine($"{number} - нет");
    }
}
*/




/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/*
Console.WriteLine("Введите  координаты первой точки");
Console.Write("x1 = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y1 = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("z1 = ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите  координаты второй точки");
Console.Write("x2 = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y2 = ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("z2 = ");
int z2 = int.Parse(Console.ReadLine());

double distance = DistanceBetweenTwoPoints(x1, y1, z1, x2, y2, z2);

Console.WriteLine("Расстояние между точками = ");
Console.Write(Math.Round(distance, 2));

double DistanceBetweenTwoPoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}
*/




/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */



Console.WriteLine("Введите  число");
Console.Write("number = ");
int n = int.Parse(Console.ReadLine());

int[] result = PrintTableOfSquares(n);

Console.WriteLine(string.Join(",",result)); // используется для вывода массива


//void PrintTableOfSquares(int n)
//{
//    for (int i = 1; i <= n; i++)
//    {
//        Console.Write(i*i);
//        Console.Write(" ");
//    }
//}

int[] PrintTableOfSquares(int number)
{
    int[] tableOfSquares = new int[number];

    for (int i = 0; i < tableOfSquares.Length; i++)
    {
        int tmp = i + 1;
        tableOfSquares[i] = tmp * tmp * tmp;
    }
    return tableOfSquares;
}