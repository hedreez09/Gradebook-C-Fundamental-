using System.Collections.Generic;
using System;


namespace GradeBook
{
    public class Book
    {
      public Book(string name)
      {
         grades = new List<double>();  
         Name  = name;
      }

        public void AddLetterGrade(char letter)
		{
			switch (letter)
			{
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;

				default:
                    AddGrade(0);
                    break;

            }
                
		}

        public double AddGrade(double grade)
        {
            if (grade <= 100.0 && grade >= 0.0)
			{
                grades.Add(grade);
            }
			else
			{
                throw new ArgumentException($"Invalid {nameof(grade)}");
			}
            return grade;
        }

        public Statistics GetStatistics()
      {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            
            foreach(var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                 result.Average += grade;
            }
              result.Average  /= grades.Count;  //this get the total number in the list and use it to find the average  

			switch (result.Average)
			{
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'A';
                    break;
            }
            return result;
      }
       
         private List<double> grades; // this are instance member of this class 
         public string Name;
    }
}
