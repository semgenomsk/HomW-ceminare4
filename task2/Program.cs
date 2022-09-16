// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigits(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum = sum + number % 10;
        number = number/10;
    }
    return sum;
}

int number = ReadNumber("Введите пипеццное число: ");
int result = SumDigits(number);
Console.WriteLine($"Сумма цифр в числе {number}: {Math.Abs(result)}");