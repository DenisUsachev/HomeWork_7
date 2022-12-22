/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив*/


int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        if(int.TryParse(Console.ReadLine(),  out result) && result > 0) 
        {
            break;
        }
        else 
        {
            Console.WriteLine("Ввели не число. Ввели некорректное число");    
        }
    }
    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



int rows = GetNumber("Введите количество строк: ");
int columns = GetNumber("Введите количество столбцов: ");
int pos1 = GetNumber("Введите строку: ");
int pos2 = GetNumber("Введите столбец: ");


int[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);

if ((pos1 >= matrix.GetLength(0)) || (pos2 >= matrix.GetLength(1))) 
{
    Console.WriteLine($"Элемента с позицией [{pos1},{pos2}] в массиве нет.");
}
else
{
    Console.WriteLine($"Элемента с позицией [{pos1},{pos2}] в массиве есть.");
}