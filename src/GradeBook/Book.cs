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

            return result;
      }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
         private List<double> grades; // this are instance member of this class 
         public string Name;
    }
}
