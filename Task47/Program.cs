/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect) 
    if (int.TryParse(Console.ReadLine(), out result))
        isCorrect = true;
    else 
        Console.WriteLine("Введено не число. Повторите ввод.");
    
    return result;
}

double[,] InitArray(int m, int n)
{
    double[,] newArray = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i,j] = rnd.Next(-99, 100)/10d;
        }
    }
    return newArray;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}  ");
        }
        Console.WriteLine();
    }
}

int row = GetNumber("Введите количество строк: ");
int column = GetNumber("Введите количество столбцов: ");
double[,] matrix = InitArray(row, column);
PrintMatrix(matrix);