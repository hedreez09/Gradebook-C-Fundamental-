using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {            static void Main(string[] args)
        {
            var book = new Book("Dijah's kitchen book");
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded -= OnGradeAdded;
            book.GradeAdded += OnGradeAdded;

                
            while (true)
			{
                Console.WriteLine("Enter a grade or 'q' to quit: ");
                var input = Console.ReadLine();

                if(input == "q") 
				{
                    break;
				}
				try
				{
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
				{
                    Console.WriteLine(ex.Message);
				}
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }  

            var stats = book.GetStatistics();

            book.Name = "";
            Console.WriteLine($"For the book named {book.Name}"); //this read the property which invoke the getter method
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is: {stats.Average :N1}");// the N1 tell it to give me one approximation
            Console.WriteLine($"The Letter grade is:{stats.Letter} ");
        }

        static void OnGradeAdded(object sender, EventArgs e)
		{
            Console.WriteLine("A grade was added");
		}
    }

}