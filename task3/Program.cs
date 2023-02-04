// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillMatrix(int rows, int cols)  
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }

    return matr;
}

void PrintMatrix(int[,] matr)
{               
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void MatrixSumCols(int[,] matrix)
{
    int j =0;
    while (j < matrix.GetLength(1))
    {
    double result = 0;
    double averageNumber = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        result = result + matrix[i, j];

    }
    averageNumber = Math.Round(result / matrix.GetLength(0), 2);
    System.Console.Write(averageNumber + "\t");
    j++;
    }
}

System.Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
System.Console.WriteLine();

System.Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
MatrixSumCols(matrix);
