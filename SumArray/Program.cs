internal partial class Program
{
    private static void Main(string[] args)
    {

        int[] array = { 3, 7, 5, 4, 9};
        int result = SumArray(array);
        System.Console.Write("Сумма массива чисел ");
        Console.Write("[{0}]", string.Join(", ", array) );
        System.Console.Write($" равна {result}");
    }

    static int SumArray(int[] array, int i = 0){
        if (i >= array.Length) return 0;
        int result = SumArray(array, i+1);
        return array[i] + result;
    }
}