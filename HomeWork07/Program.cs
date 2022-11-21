//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7

Console.WriteLine("Введите цифру обозначающую день недели ");
int number = Convert.ToInt32(Console.ReadLine()!);


if(number ! >= 8 && number ! < 1) 
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    if(number == 1) Console.WriteLine("Понедельник - рабочий день");
    if(number == 2) Console.WriteLine("Вторник - рабочий день");
    if(number == 3) Console.WriteLine("Среда - рабочий день");
    if(number == 4) Console.WriteLine("Четверг - рабочий день");
    if(number == 5) Console.WriteLine("Пятница - рабочий день");
    if(number == 6) Console.WriteLine("Суббота - выходной день");
    if(number == 7) Console.WriteLine("Воскресенье - выходной день");
}
