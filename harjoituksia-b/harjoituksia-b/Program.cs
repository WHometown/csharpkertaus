using System;

public class Example
{
    public static void Main()
    {
        int x, y;

        Console.WriteLine("syötä luku: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("syötä toinen luku: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("x = " + (y + 3));

        Console.WriteLine("syötä luku: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("syötä toinen luku: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("x = " + (y - 2));

        Console.WriteLine("syötä luku: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("syötä toinen luku: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("x = " + (y * 5));

        Console.WriteLine("syötä luku: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("syötä toinen luku: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("x = " + (x / y));

        Console.WriteLine("syötä luku: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("syötä toinen luku: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("x = " + (x % y));

        Console.WriteLine("syötä luku: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("syötä toinen luku: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("x = " + (x += y));

        Console.WriteLine("syötä luku: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("syötä toinen luku: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("x = " + (x -= y));

        Console.WriteLine("syötä luku: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("syötä toinen luku: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("x = " + (x *= y*5));

        Console.WriteLine("syötä luku: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("syötä toinen luku: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("x = " + (x /= y));
    }
}
