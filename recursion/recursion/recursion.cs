using System;

class recursion
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string professor(int i)
        {
            if (i == 1)
            {
                return "1";
            }
            else
            {
                return professor(i - 1) + i + professor(i - 1);
            }
        }
        Console.WriteLine(professor(n));
    }
}
