﻿// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку
// массива.

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

int[,] SwitchRows(int[,] array)
{   int n = array.GetLength(1) -1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[ n, i];
        array[n, i] = temp;
    }
    return array;
}

int[,] arr = GetArray(7, 7);
PrintArray(arr);

Console.WriteLine();

int[,] arr2 = SwitchRows(arr);
PrintArray(arr2);