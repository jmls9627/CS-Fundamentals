using System;
using System.Collections.Generic;

namespace Grade_Book
{
    public class Book
    { 
      public List<double> grades; 
      public string name;

     public Book( string name)
     {
      this.name=name;
      this.grades= new List<double>();
     }   
        public void AddGrade(double grade){
            if(grade <= 100 && grade >= 0){
               grades.Add(grade);
            }
            
           else{
            Console.WriteLine("Invalid value");
           } 
           

        }

        public Stats GetStats(){
            
             var result=0.0;
             var highGrade= double.MinValue;
             var lowGrade= double.MaxValue;

            for(int i=0;i<grades.Count;i++){
                if(grades[i]==42.1){
                 continue; // break, goto done
                }
                
                 lowGrade= Math.Min(grades[i], lowGrade);
                 highGrade= Math.Max(grades[i], highGrade);
                 result += grades[i];
             }
             result/=grades.Count;
             //done:
             return new Stats(result,highGrade,lowGrade);
        }
    }
}