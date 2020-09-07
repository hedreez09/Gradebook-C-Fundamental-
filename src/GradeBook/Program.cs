using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {            static void Main(string[] args)
        {
            var book = new Book("Dijah's kitchen book");
			while (true)
			{
                Console.WriteLine("Enter a grade or 'q' to quit: ");
                var input = Console.ReadLine();

                if(input == "q")
				{
                    break;
				}
                var grade = double.Parse(input);
                book.AddGrade(grade);
			}


            //book.GetStatistics();   

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is: {stats.Average :N1}");// the N1 tell it to give me one approximation
            Console.WriteLine($"The Letter grade is:{stats.Letter} ");
        }
    }

}