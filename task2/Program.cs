// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
    return array;
}

void SearchPosition(int[,] array, int m, int n)
{
    if (m > array.GetLength(0) || n > array.GetLength(1)) Console.WriteLine("Такого числа в массиве нет");
    else Console.WriteLine("В указанной позиции число " + array[m - 1, n - 1]);
}


Console.Write("Введите число строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = int.Parse(Console.ReadLine());
int[,] array = FillArray(m, n);

Console.Write("Введите номер cтроки массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца массива: ");
int columns = int.Parse(Console.ReadLine());
SearchPosition(array, rows, columns);
