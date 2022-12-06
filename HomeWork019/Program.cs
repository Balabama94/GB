// Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, 
// но отсортированный по возрастанию(от меньшего числа к большему).
Console.Clear();

Console.Write("Введите число N (число элементов массива): ");
int N = 10;
int[] array1 = RandArray(N);

Console.WriteLine();
Console.WriteLine($"Массив: [{String.Join(", ", array1)}]");
Console.WriteLine($"Количество чётных чисел в массиве равно {СountArray(array1)}");

//Метод вывода массива RandArray:
int[] RandArray(int N)
{
int[] arrayN = new int[N];
for (int i = 0; i < N; i++)
{
arrayN[i] = new Random().Next(100);
}
return arrayN;
}

// Метод подсчёта количества чётных элементов массива:
int СountArray(int[] arrayA)
{
int count = 0;
foreach (int i in arrayA)
if (i % 2 == 0) count++;
return count;
}