//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] MatrixProduct(int[,] mas, int[,] mas2)
{
    if(mas.GetLength(1) != mas2.GetLength(0))
    {
        int[,] mas4 = new int[0,0];
        Console.WriteLine($"Матрицы не согласованы, перемножение невозможно");
        return mas4;
    }
    int[,] mas3 = new int[mas.GetLength(0), mas2.GetLength(1)];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas2.GetLength(1); j++)
        {
            for (int k = 0; k < mas2.GetLength(0); k++)
            {
                mas3[i,j] += mas[i,k] * mas2[k,j];
            }
        }
    }
    return mas3;

}

void PrintMas(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GenerateMas(int rows, int columns, int numMin, int numMax)
{
    int[,] mas = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            mas[i,j] = new Random().Next(numMin, numMax);
        }
    }
    return mas;
}

int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInput("Введите количество строк в массиве: ");
int columns = GetInput("Введите количество столбцов в массиве: ");
int numMin = GetInput("Введите минимальный элемент массива: ");
int numMax = GetInput("Введите максимальный элемент массива: ");
Console.WriteLine();
int[,] mas = GenerateMas(rows, columns, numMin, numMax);
PrintMas(mas);
int rows2 = GetInput("Введите количество строк в массиве: ");
int columns2 = GetInput("Введите количество столбцов в массиве: ");
int numMin2 = GetInput("Введите минимальный элемент массива: ");
int numMax2 = GetInput("Введите максимальный элемент массива: ");
Console.WriteLine();
int[,] mas2 = GenerateMas(rows2, columns2, numMin2, numMax2);
PrintMas(mas2);
Console.WriteLine();
int[,] mas3 = MatrixProduct(mas, mas2);
PrintMas(mas3);