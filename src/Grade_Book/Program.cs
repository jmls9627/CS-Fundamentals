using System;
using System.Collections.Generic;

namespace Grade_Book
{
    class Program
    {
        static void Main(string[] args)
        {   
           var book = new Book("Pepe's Book");
           var done=false;

           
           while(!done)
           {
               Console.WriteLine("Enter a Grade or Press 'q' to exit");
               var input=Console.ReadLine();
                            
               if (input=="q")
               {
                   done=true;
                   continue;
               }
               
                 try
                 {
                     var grade=double.Parse(input);
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
     
         var Stats = book.GetStats();

           Console.WriteLine($"the average grade is: {Stats.Average:N1}");
           Console.WriteLine($"the lowest grade is: {Stats.Low:N1} ");
           Console.WriteLine($"the hihgest grade is: {Stats.High:N1}");
           Console.WriteLine($"the Letter grade is: {Stats.Letter}");
        }
    }
}
