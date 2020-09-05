﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {            static void Main(string[] args)
        {
            var book = new Book("Dijah's kitchen book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);


            book.GetStatistics();   

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is: {stats.Average :N1}");// the N1 tell it to give me one approximation
        }
    }

}