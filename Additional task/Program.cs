// Выведите матрицу, полученную транспонированием исходной
// матрицы относительно горизонтали.

Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0,101);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Releasematrix(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0)/2; i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
         temp = matrix [i,j];
         matrix [i,j] = matrix[matrix.GetLength(0)-1-i,j]; 
         matrix[matrix.GetLength(0)-1-i,j] = temp;   
        }
    }
}    

Console.Write("Задайте количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine ("Исходная матрица: ");
PrintMatrix(matrix);
Releasematrix(matrix);
Console.WriteLine ("Транспонированная матрица: ");
PrintMatrix(matrix);