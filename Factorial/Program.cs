﻿internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        foreach (int number in array) PrintFactorial(number);

    }

    // F(n) = n!; 5! = 1 * 2 * 3 * 4 * 5 = 120; F(1) = 1; F(0) = 1;
    // Factorial(5)= 5 * Factorial(4) = 5 * 4 * Factorial(3) = 5 * 4 * 3 * Factorial(2) = 5 * 4 * 3 * 2 * 1;
    static int Factorial(int n)
    {
        if (n == 1) return 1;
        else return n * Factorial(n - 1);
    }

    static void PrintFactorial(int number)
    {
        int factorial = Factorial(number);
        System.Console.WriteLine($"Факториал числа {number} равняется {factorial}");
    }

}