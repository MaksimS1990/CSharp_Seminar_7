// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.WriteLine("Введите количество строк");
int rows;
while (!int.TryParse(Console.ReadLine()!, out rows) || rows<=0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите количество строк");   
}

Console.WriteLine("Введите количество столбцов");
int columns;
while (!int.TryParse(Console.ReadLine()!, out columns) || columns<=0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ("Неверный ввод");
    Console.ResetColor(); 
    Console.WriteLine("Введите количество столбцов");   
}

int [,] matrix = new int [rows, columns];
var random = new Random();

void PrintArray(int[,] matr)
{

    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
            Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
            if (matr[i, j]==100) Console.Write($" {matr[i, j]} ");
            else if (matr[i, j]<100 && matr[i, j]>9 ) Console.Write($" {matr[i, j]}  ");
            else Console.Write($" {matr[i, j]}   ");
            Console.ResetColor(); 
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        for (int j=0; j<matr.GetLength(1); j++)
        {
           matr[i, j] = i+j;
        }
    }
}

Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);

