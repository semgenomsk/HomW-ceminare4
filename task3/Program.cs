// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Данные вводятся с консоли пользователем

int[] arr = new int[8];
Console.WriteLine("Введите поочередно элементы массива: ");

for(int i=0;i<arr.Length;i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());    
}
System.Console.WriteLine("Введенный вами массив: ");
System.Console.WriteLine(string.Join(", ", arr));