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

Console.Write("Введите минимальное значение массива ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк массива ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива ");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] array = Create2dArray(min, max, rows, cols);
ShowArray(array);