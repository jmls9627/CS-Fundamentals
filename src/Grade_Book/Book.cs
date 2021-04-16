using System;
using System.Collections.Generic;

namespace Grade_Book
{
    public class Book
    { 
      private List<double> grades; 
      private string name;

     public Book( string name)
     {
      this.name=name;
      this.grades= new List<double>();
     }   
        public void AddGrade(double x){
            grades.Add(x);
        }

        public void ShowStats(){
             var result1=0.0;
             var highGrade= double.MinValue;
             var lowGrade= double.MaxValue;

             foreach(var number in this.grades){
                 lowGrade= Math.Min(number, lowGrade);
                 highGrade= Math.Max(number, highGrade);
                 result1 += number;
             }
             result1/=grades.Count;

            Console.WriteLine($"the average grade is: {result1:N1}");
            Console.WriteLine($"the lowest grade is: {lowGrade:N1} ");
            Console.WriteLine($"the hihgest grade is: {highGrade:N1}");
        }
    }
}