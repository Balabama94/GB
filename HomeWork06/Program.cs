// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000

Console.WriteLine("Введите число ");
string number = Console.ReadLine()!;

if(number.Length ! < 3)
{
    Console.WriteLine("В этом числе третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра числа {number} равна {number[2]}");
}