//version 1.0.0 
using System;

class App
{
    static void Main()
    {
        Console.WriteLine("Калькулятор v2.0-FINAL");
        
        int result = Subtract(30, 12);
        Console.WriteLine($"Разность: {result}");
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }
}
