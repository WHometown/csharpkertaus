using System;

public class Example
{
    public static void Main()
    {
        string kluku, kluku2

        Console.WriteLine("Syötä luku: ");
        kluku = Console.ReadLine();
        Console.WriteLine("Syötä toinen luku: ");
        kluku2 = Console.ReadLine();

        int luku;
        if (x > y)
        {
            Console.WriteLine(y + " " + x);
        }
        else
        {
            Console.WriteLine(x + " " + y);
        }

        Console.WriteLine("Syötä luku: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Syötä toinen luku: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Syötä kolmas luku. ");
        z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Suurin luku: " + Math.Max(x, Math.Max(y, z)));

        alku:
        Console.WriteLine("Syötä luku 0-9 välillä");
        luku = Convert.ToInt32(Console.ReadLine());
        switch (luku)
        {
            case 0: Console.WriteLine("nolla");
                break;
            case 1:
                Console.WriteLine("yksi");
                break;
            case 2:
                Console.WriteLine("kaksi");
                break;
            case 3:
                Console.WriteLine("kolme");
                break;
            case 4:
                Console.WriteLine("neljä");
                break;
            case 5:
                Console.WriteLine("viisi");
                break;
            case 6:
                Console.WriteLine("kuusi");
                break;
            case 7:
                Console.WriteLine("seitsemän");
                break;
            case 8:
                Console.WriteLine("kahdeksan");
                break;
            case 9:
                Console.WriteLine("yhdeksän");
                break;
            default: Console.WriteLine("väärin");
                goto alku;
        }

        Console.WriteLine("Syötä luku: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Syötä toinen luku: ");
        y = int.Parse(Console.ReadLine());
        Console.WriteLine("Syötä kolmas luku. ");
        z = int.Parse(Console.ReadLine());
        Console.WriteLine("Syötä neljäs luku: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Syötä viides luku: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Suurin luku: " + Math.Max(x, Math.Max(y, Math.Max(z, Math.Max(a, b)))));

    }
}
