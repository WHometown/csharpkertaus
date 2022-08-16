using System;

public class Example
{
    public static void Main()
    {
        var date1 = DateTime.Now.ToString("s", System.Globalization.CultureInfo.InvariantCulture);
        Console.WriteLine(date1);
    }
}