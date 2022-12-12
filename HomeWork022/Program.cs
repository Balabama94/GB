﻿// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int m = InputNumbers("Введите размер строки: ");
int n = InputNumbers("Введите размер столбца: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

Console.WriteLine($"Отсортированный массив: ");
OrderArrayLines(array);
WriteArray(array);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

void OrderArrayLines(int[,] array)                                                       /////Метод сортировки массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

int InputNumbers(string input)
{
  Console.Write(input);                                                                  //Метод ввода данных
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

void CreateArray(int[,] array)                                                          //Метод заполнения массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////

void WriteArray(int[,] array)                                                           //Метод вывода массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

