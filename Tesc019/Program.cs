// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
int length = array.Length;
int ferstindex = 0;
int secondindex = length;

if (array[ferstindex] == array[secondindex])
{
    if(array[ferstindex+1] == array[secondindex-1])
    {
     Console.WriteLine("Полидромом");
    }
    Console.WriteLine("Не является полидромом");
}
Console.WriteLine("Не является полидромом");

// ничего не работает. дает ошибку "Unhandled exception. System.IndexOutOfRangeException: 
// Index was outside the bounds of the array."
// так понимаю, что беда с массивом, но как исправить не могу сообразить
// либо я намудрила так, что впринципе это работать не может