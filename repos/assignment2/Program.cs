using System;
 class Programa
 {
    public static void Main (string[] args)
    {
        int i = 1;
        while (i<50)
        {
            if (i%2!=0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
        Console.ReadLine();
    }
 }

