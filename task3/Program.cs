// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] Create2dArray(int min, int max, int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindSumOfDiagonalElements(int[,] array)
{
    int sum = 0;
    // for (int i = 0; i < array.GetLength(0); i++)
    // {

    //     for (int j = 0; j < array.GetLength(1); j++)
    //     {
    //         if (j == i) sum += array[i, j];
    //     }

    // }

    if (array.GetLength(0) > array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum += array[i, i];
        }
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, i];
        }
    }

    return sum;
}

Console.Write("Введите минимальное значение массива ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк массива ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2dArray(min, max, rows, cols);
int sum = FindSumOfDiagonalElements(array);
// Console.Write(array.GetLength(0));
// Console.Write(array.GetLength(1));
ShowArray(array);
Console.WriteLine();
Console.Write($"Сумма элементов на главной диагонали = {sum}");