/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

int[,] InitArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = rnd.Next(0, 10);
        }
    }
    return newArray;
}

string GetAveregeOfColumn(int[,] matrix)
{
    int summ = 0;
    double averege;
    List<double> aList = new List<double>();
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        summ = 0;
        averege = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            summ += matrix[j, i];
        }
        averege = Math.Round((double)summ / matrix.GetLength(0), 2);
        aList.Add(averege);

    }
    return string.Join("; ", aList.ToArray());
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int row = GetNumber("Введите количество строк: ");
int column = GetNumber("Введите количество столбцов: ");
int[,] matrix = InitArray(row, column);
PrintMatrix(matrix);
string averegeOfColumn = GetAveregeOfColumn(matrix);
Console.WriteLine($"\nСреднее арифметическое каждого столбца: {averegeOfColumn}");

