// Задача 65: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N 
//с помощью рекурсии
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();

// или
// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// PrintMN(m, n);

// void PrintMN(int m, int n)
// {
//     Console.Write(m + ", ");
//     m++;
//     if (m == n)
//     {
//         Console.Write(n);
//         return;
//     }
//     else
//     {
//         PrintMN(m, n);
//     }
// }



int n = 5;
Recurs(n, 20);


void Recurs(int n, int i = 10)
{
    if (n <= i)
    {
        
        Console.Write(n+ ", ");
        n++;
        Recurs(n, i);
    }
    else return;
}