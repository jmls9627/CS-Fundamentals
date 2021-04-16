using System;
using System.Collections.Generic;

namespace Grade_Book
{
    class Program
    {
        static void Main(string[] args)
        {   
           var book = new Book("Pepe's Book");
           book.AddGrade(89.1); 
           book.AddGrade(34.4);       
           book.AddGrade(12.3);
           book.AddGrade(33.54);

           book.ShowStats();
      
        }
    }
}
