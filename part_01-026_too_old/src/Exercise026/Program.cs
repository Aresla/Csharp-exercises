﻿namespace Exercise026
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give your year of birth:");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a < 1900)
            {
                Console.WriteLine("You're old");
            }
        }
    }
}
