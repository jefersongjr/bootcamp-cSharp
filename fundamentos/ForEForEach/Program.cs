﻿public class Program
{
    public static void Main()
    {
        string[] names = new string[] { "Hulk", "Thor", "Loki" };

        //for(int i = 0; i < names.Length; i++) {
        //    Console.WriteLine(names[i]);
        //}
        
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

}