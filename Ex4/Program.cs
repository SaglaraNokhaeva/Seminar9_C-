// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.Write("Введите А: ");
// int A = int.Parse(Console.ReadLine());
// Console.Write("Введите B: ");
// int B = int.Parse(Console.ReadLine());
// Console.WriteLine(MyPow(A, B));

// int MyPow(int A_l, int B_l)
// {
//     if (B_l == 0) return 1;
//     return A_l * MyPow(A_l, B_l - 1);
// }

//или


// int Recurs2(int n, int b)
// {
//     if (b == 0) return 1;
//     return n * Recurs2(n, b - 1);
// }

// System.Console.WriteLine(Recurs2(2, 3));