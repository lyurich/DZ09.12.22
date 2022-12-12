// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(PrintNumbers(N, 1));

// string PrintNumbers (int end, int start)
// {
//     if (start == end) return end.ToString();
//     return (end + " " + PrintNumbers(end - 1, start));
// }



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Write("Введите число M: ");
// int M = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Сумма натуральных элементов в заданном прмежутке: {SumMtoN(M, N)}");

// int SumMtoN(int M, int N)
// {
//     if (M == N) return M;
//     return (M += SumMtoN(M + 1, N));
// }



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);


Console.WriteLine(Akkerman(m,n));

int Akkerman(int m, int n)
{
    if (m == 0) {
            return n + 1;
        } // Шаг рекурсии / рекурсивное условие
        else if (n == 0 && m > 0) {
            return Akkerman(m - 1, 1);
        } // Шаг рекурсии / рекурсивное условие
        else {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
}