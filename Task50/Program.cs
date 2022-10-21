/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. */

int GetPosition(string message)
{
    Console.Write(message);
    bool isCorrect = false;
    int result = 0;
    while (!isCorrect) 
    if (int.TryParse(Console.ReadLine(), out result))
        if (result <= 6 && result > 0)
            isCorrect = true;
        else 
            Console.WriteLine("Введите число в диапазоне 1-6 ");
    else 
        Console.WriteLine("Введено некорректное число. Повторите ввод.");
    
    return result;
}

(int, int) GenerateRowColumn()
{
    Random rnd = new Random();
    int row = rnd.Next(2,7); 
    int column = rnd.Next(2,7);
    return (row, column);
}

int[,] InitArray(int m, int n)
{
    int[,] newArray = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i,j] = rnd.Next(0, 10);
        }
    }
    return newArray;
}

object TakeNumberInMatrix(int row, int column, int[,] matrix)
{
    
    if (row  > matrix.GetLength(0) || column > matrix.GetLength(1))
        return "Такого элемента в масиве нет.";
    else
        return matrix[row-1, column-1]; 
}


void PrintMatrix(int[,] matrix)
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

int row = GetPosition("Введите номер строки (1-6): ");
int column = GetPosition("Введите номер столбца (1-6): ");
(int rowSize, int columnSize) = GenerateRowColumn();
int[,] matrix = InitArray(rowSize, columnSize);
PrintMatrix(matrix);
var result = TakeNumberInMatrix(row, column, matrix);
Console.WriteLine($"Результат поиска в массиве на позиции строка {row}, столбец {column} -> {result}.");
