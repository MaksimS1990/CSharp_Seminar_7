// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
int[,] CreateArray(int rows, int columns)
{
    var random = new Random();

    int[,] array = new int[rows, columns];

    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(-10, 11);
        }
    }

    return array;
}

int[,] Square(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                input[i, j] = input[i, j] * input[i, j];
            }
        }
    }
    return input;
}

void PrintArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);

            if (j != input.GetLength(1) - 1)
                Console.Write(", ");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк массива = ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбов массива = ");
int n = int.Parse(Console.ReadLine()!);

var array = CreateArray(m, n);
PrintArray(array);

Console.WriteLine("");
PrintArray(Square(array));
