﻿public class Program
{
    public static void Main()
    {
        var count = 0;

        // while (count < 10
        // {
        //     Console.WriteLine("count " + count);
        //     count++;
        // }
        //A diferença do while para o do while é que o do while
        //executa pelo menos uma vez o código.
        do
        {
            Console.WriteLine("count " + count);
            count++;
        }
        while (count < 10);
    }

}