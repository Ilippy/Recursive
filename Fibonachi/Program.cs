internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        foreach (int number in array) PrintFibonachi(number);

    }

    // f(n) = f(n-1) + f(n-2);
    // 1, 1, 2, 3, 5, 8, 13, 21, ...
    static int Fibonachi(int n)
    {
        switch (n)
        {
            case 0:
                return 0;
                break;
            case 1:
                return 1;
                break;
            default:
                return Fibonachi(n - 1) + Fibonachi(n - 2);
                break;
        }
        if (n == 1) return 1;

        else return n * Fibonachi(n - 1);
    }

    static void PrintFibonachi(int number)
    {
        int fibonachi = Fibonachi(number);
        System.Console.WriteLine($"Функция Фибоначи числа {number} равняется {fibonachi}");
    }

}