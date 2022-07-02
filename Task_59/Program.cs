// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rndNum.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Двумерный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] FindMin(int[,] array)
{
    int IndexI = 0;
    int IndexJ = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min) min = array[i, j];
            IndexI = i;
            IndexJ = j;
        }
    }
    return new int[] { IndexI, IndexJ, min };
}

int[,] ResultArray(int[,] arr, int idxs)
{
    int flagI = 0;
    int flagJ = 0;
    int newArray = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < arr.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            if (i >= idxs[0]) {flagI = 1;}
            else {flagI = 0;}
            if (j >= idxs[1]) {flagJ = 1;}
            else {flagJ = 0;}
            newArray[i, j] = arr[i + flagI, j + flagJ];
        }
    }
    return newArray;
}

int[,] arr = GetArray(3, 3);
PrintArray(arr);

Console.WriteLine();

int[] Indexes = FindMin(arr);
int[,] resultArr = ResultArray(arr, Indexes);
PrintArray(resultArr);


