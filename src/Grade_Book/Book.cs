using System;
using System.Collections.Generic;

namespace Grade_Book
{
    public class Book
    { 
      private List<double> grades; 
      public string name;

     public Book( string name)
     {
      this.name=name;
      this.grades= new List<double>();
     }   
        public void AddGrade(double x){
            grades.Add(x);
        }

        public Stats GetStats(){
            
             var result=0.0;
             var highGrade= double.MinValue;
             var lowGrade= double.MaxValue;

             foreach(var number in this.grades){
                 lowGrade= Math.Min(number, lowGrade);
                 highGrade= Math.Max(number, highGrade);
                 result += number;
             }
             result/=grades.Count;

            return new Stats(result,highGrade,lowGrade);
        }
    }
}