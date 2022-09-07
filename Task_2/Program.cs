void PrintArray(int[,] matr)
{
    for (int i=0; i<matr.GetLength(0); i++) // i = строка int [i, j]
    {
        for (int j=0; j<matr.GetLength(1); j++) // j = столбец int [i, j]
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int [, ] matr)
{
    for (int i=0; i<matr.GetLength(0); i++) // i = строка int [i, j]
    {
        for (int j=0; j<matr.GetLength(1); j++) // j = столбец int [i, j]
        {
            matr[i, j] = new Random().Next(1, 25); // заполнение массива [i, j] числами от 1 до 25
        }
    }
}

int [, ] matrix = new int [3, 4];
PrintArray (matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray (matrix);