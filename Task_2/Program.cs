// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(minValue, maxValue + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

void TranceponArray(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("В массиве с введенной размерностью не могут быть поменяны местами строки и столбцы");
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i; j < array.GetLength(1); j++)
            {
                // int temp = array[i, j];
                // array[i, j] = array[j, i];
                // array[j, i] = temp;

                (array[i, j], array[j, i]) = (array[j, i], array[i, j]); // короткая запись 3х строк выше
            }
        }
    }
}

int rows = InputNum("Введите количетсво сторок: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] array = Create2DArray(rows, columns);

int min = InputNum("Введите значиение минимального элемента: ");
int max = InputNum("Введите значиение максимального элемента: ");

Fill2DArray(array, min, max);
Print2DArray(array);
Console.WriteLine();
TranceponArray(array);
Print2DArray(array);