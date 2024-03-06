// Задайте двумерный массив из целых чисел. 
//Сформируйте новый одномерный массив, состоящий из средних арифметических значений по строкам двумерного массива.

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

void Show2dArray(int[,] array)
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

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] CreateNewArray(int[,] array)
{
    int[] newArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        newArray[i] = sum / array.GetLength(1);
    }
    return newArray;
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
Show2dArray(array);
Console.WriteLine();

int[] newArray = CreateNewArray(array);
ShowArray(newArray);