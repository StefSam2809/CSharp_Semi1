﻿int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] FillMatrix(int row, int col, int LeftRange, int RightRange)
{
    double[,] TempMatrix = new double[row, col];
    Random rand = new Random();

    for(int i = 0; i < TempMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < TempMatrix.GetLength(1); j++)
        {
            TempMatrix[i, j] = rand.Next(LeftRange, RightRange + 1) + Math.Round(rand.NextDouble(), 2);
        }
    }
    return TempMatrix;
}

void PrintMatrix(double[,] MatrixForPrint)
{
    for(int i = 0; i < MatrixForPrint.GetLength(0); i++)
    {
        for(int j = 0; j < MatrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(MatrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

// -----------

int rows = ReadInt("Введите количество строк:");
int cols = ReadInt("Введите количество столбцов:");
double[,] matrix = FillMatrix(rows, cols, 0, 9);
PrintMatrix(matrix);
