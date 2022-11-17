// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 1

int MainDiagonalSum(int[,] input)
{
   var sum = 0;
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
        

            if (i == j) sum = sum + input[i, j];
        }
    }
    return sum;
}
int[,] CreateArray(int rows, int columns)
{

    int[,] array = new int[rows, columns];

    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = i + j;

        }
    }

    return array;
}

void PrintArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);

            if (j != input.GetLength(1) - 1)
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}

var array = CreateArray(5, 6);

PrintArray(array);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(MainDiagonalSum(array));
