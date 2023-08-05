﻿using System.Linq;
using System;
using System.Collections.Generic;

namespace Cas7AdvVezbe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumber = new List<int> { 79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100 };
            List<int> Numberfrom40to70 = listNumber
                                          .Where(p => p > 40 && p < 70)
                                          .ToList();
            Console.WriteLine("Brojevi liste veci od 40  a manji od 70");
            foreach (int number in Numberfrom40to70)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("......................");

            List<string> listAnimal = new List<string> { "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion", "sheep", "tiger", "wolf" };
            List<string> AnimalWithSixAndMoreCharacters = listAnimal
                                                         .Where(p => p.Length >= 6)
                                                         .Select(p => p.ToUpper())
                                                         .ToList();
            Console.WriteLine("Animal with six and more characters: ");

            foreach (string animal in AnimalWithSixAndMoreCharacters)
                Console.WriteLine(animal);

            Console.WriteLine("......................");

            List<string> AnimalwithH = listAnimal
                                       .Where(p => p.StartsWith("h", StringComparison.OrdinalIgnoreCase) && p.EndsWith("e", StringComparison.OrdinalIgnoreCase))
                                       .ToList();
            Console.WriteLine("Animal start with H and end E:");
            foreach (string animal1 in AnimalwithH)
            {
                Console.WriteLine(animal1);
            }
            Console.WriteLine("......................");
           
            List<string> NumberSquareIsBiggerThan7000 = listNumber
                                                     .Where(p => p * p > 7000)
                                                     .Select(p => $"{p} - {p * p}")
                                                     .ToList();
            Console.WriteLine("Square bigger than 7000:");
            foreach (string n in NumberSquareIsBiggerThan7000)
                Console.WriteLine(n);

            Console.WriteLine("......................");

            List<string> AnimalNamesReplaceAN = listAnimal
                                                .Select(p =>p.Replace("an", "*", StringComparison.OrdinalIgnoreCase))
                                                .ToList();
            Console.WriteLine("Lista nakon zamene \"AN\" u \"*\"");

            foreach(string word in AnimalNamesReplaceAN)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("......................");

            string LastWordE = listAnimal
                                           //.OrderBy(p => p)
                                           .Where(p => p.Contains("e", StringComparison.OrdinalIgnoreCase))
                                           .LastOrDefault();
                                          
            Console.WriteLine("Last word contain (e):");

            Console.WriteLine(LastWordE);

            Console.WriteLine("......................");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            Random random = new Random();
            List<int> listShuffleNumbers = numbers.OrderBy(p => random.Next()).ToList();
            
            Console.WriteLine("Shuffle an sorted list:");

            foreach (int  n in listShuffleNumbers)
                Console.WriteLine(n);

            Console.WriteLine("......................");
           






        }
    }
}