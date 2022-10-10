// Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

Console.Clear();

void InputMatrix(int[,] matrix)
{
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i,j] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        Console.Write(matrix[i, j] + "\t");
    Console.WriteLine();
    }
}

void Releasematrix(int[,] matrix)
{
    double [] result = new double [matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
            sum = sum + matrix[i,j];
        result[j] = Math.Round(sum/matrix.GetLength(0), 2);
    }
    Console.WriteLine();
    Console.WriteLine(string.Join("; ", result));
}    

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Releasematrix(matrix);
