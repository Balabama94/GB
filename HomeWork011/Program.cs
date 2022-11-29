// // Напишите программу замены элементов массива: поменять положительные элементы на соотвествуеющие отрицательные, и наоборот.
/*
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-50, 51);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void ChangePosToNeg(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int[] numbers = new int[10];

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();
ChangePosToNeg(numbers);
PrintArray(numbers);
*/


//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 11);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
string FindInArray(int[] arr, int number)
{
    string result = $"Числа {number} в массиве нет";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        {
            result = $"Число {number} в массиве есть";
            break;
        }
    }
    return result;
}

int[] randomArray = new int[10];

Console.WriteLine("Введите искомое число");
int num = Convert.ToInt32(Console.ReadLine());
FillArray(randomArray);
PrintArray(randomArray);
Console.WriteLine();
Console.WriteLine(FindInArray(randomArray, num));
*/

//Задайте массив из 123 случайных чисел. Найдите количество элементов массива, лежащих в отрезке [10, 99]

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-200, 100);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] numbers = new int[123];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= 10 && numbers[i] <= 99) count += 1;
}
Console.WriteLine($"Количество чисел в отрезке [10,99] равно {count}");