// Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого
// элемента или же указание, что такого элемента нет.

Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0,11);
            Console.Write(matrix[i, j] + "\t");
        }
    Console.WriteLine();
    }
}

void Releasematrix(int[,] matrix)
{
    Console.Write("Введите номер строки: ");
    int numberstr = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int numbercol = Convert.ToInt32(Console.ReadLine());

    if (numberstr > matrix.GetLength(0) || numbercol > matrix.GetLength(0))
        Console.WriteLine("Такого элемента нет");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(numberstr == i+1 && numbercol == j+1)
             Console.WriteLine($"Значение элемента на заданных строке и столбце = {matrix[i, j]}");
        }
    }
}    

Console.Write("Задайте количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Releasematrix(matrix);

