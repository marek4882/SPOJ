using System;

public static class Program
{
    private static void Main()
    {
        int przypadkitestowe = int.Parse(Console.ReadLine());
        while (przypadkitestowe-- > 0)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine(
                ADDREV.Solve(line[0], line[1]));
        }
    }
}
public static class ADDREV
{
    public static int Solve(int a, int b) => (a.Reverse() + b.Reverse()).Reverse();

    private static int Reverse(this int a)
    {
        int reverse = 0;
        while (a != 0)
        {
            reverse = reverse * 10 + a % 10;
            a = a / 10;
        }
        return reverse;
    }
}


