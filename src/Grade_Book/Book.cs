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

     public void AddLetter(char letter)
     {
         switch(letter)
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

            case 'D':
                 AddGrade(60);
                 break;     

               default:
               AddGrade(0); 
               break; 
         }

     }
        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            {
               grades.Add(grade);
            }
          else
          {
            Console.WriteLine("Invalid value");
           } 
        }

        public Stats GetStats(){
             char letter=' ';
             var result=0.0;
             var highGrade= double.MinValue;
             var lowGrade= double.MaxValue;

            for(int i=0;i<grades.Count;i++)
            {
                if(grades[i]==42.1)
                {
                 continue; // break, goto done:
                }              
                 lowGrade= Math.Min(grades[i], lowGrade);
                 highGrade= Math.Max(grades[i], highGrade);
                 result += grades[i];
             }
             result/=grades.Count;
            switch(result)
            {
                case var d when d >= 90.0:   //or using if statements
                     letter='A';
                      goto done;

                case var d when d >= 80.0:
                     letter='B';
                     goto done;

                case var d when d >= 70.0:  
                     letter='C';
                      goto done;

                case var d when d >= 60.0:  
                     letter='D';
                     goto done;

                default:
                     letter='F';
                     goto done;
            }
             done:
             return new Stats(result,highGrade,lowGrade, letter);
        }
    }
}