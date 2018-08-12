﻿using System;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random random = new Random();
            for (int i = 0; i < words.Length-1; i++)
            {
                int index = random.Next(0, words.Length);
                var temp = words[i];
                words[i] = words[index];
                words[index] = temp;

            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
