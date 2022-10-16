// Задача 67: Напишите программу, которая будет принимать на вход число 
//и возвращать сумму его цифр с помощью рекурсии.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.Write("Введите число n = ");
int num = Convert.ToInt32(Console.ReadLine());

int result = SumOfDigit(num);
Console.WriteLine("Сумма цифр в " + num + " равна " + result);

int SumOfDigit(int n)
{
    if (n == 0) return 0;
    return n % 10 + SumOfDigit(n / 10);
}