using System;

class App
{
    static void Main()
    {
        Console.WriteLine("Калькулятор");
        
        int result = Subtract(30, 12);
        Console.WriteLine($"Разность: {result}");
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }
}
