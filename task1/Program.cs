// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadNumber(string message)
{
    Console.Write(message);    
    return Convert.ToInt32(Console.ReadLine());    
}

int exp(int numberA,int numberB)
{
    if (numberB > 0)     //если A >= одному, то работаем дальше
    {
        int pow=numberA;        
        for (int i=1;i<numberB;i++)
        {
            pow = pow*numberA;
        }
        return pow;     //вернем накопившуюся сумму
    }
    else
    {        
        return -1;  //не корректно посчитанная сумма (код ошибки)
    }
}

int numberA = ReadNumber("Введите пипеццное число A: ");
int numberB = ReadNumber("Введите пипеццное число B: ");
int result = exp(numberA,numberB);

if(result==-1)  
{
    Console.WriteLine("Число B должно быть натуральным!");
}
else
{
    Console.WriteLine($"Пипецное ччисло A возведенное в пипеццную степень = {result}");
}

