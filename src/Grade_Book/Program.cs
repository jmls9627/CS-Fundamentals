using System;
using System.Collections.Generic;

namespace Grade_Book
{
    class Program
    {
        static void Main(string[] args)
        {   
            var x=34.1;
            var y=21.43;
            var sum=x+y; //double
           // Console.WriteLine(sum);
//----------------------------------------------------------
            double [] numbs= new[] { 12.7, 32.1, 4.56, 8.6};
          //   var numbs= new[] { 12.7, 32.1, 4.56, 8.6};
          //  numbs[0]=12.7;
          //  numbs[1]=10.47;
          //  numbs[2]=5.72;

            var result=0.0;
            foreach(var number in numbs){
                 result += number;
            }
            Console.WriteLine(result);
//----------------------------------------------------------
            List<double> grades= new List<double>(){ 12.7, 32.1, 4.56, 8.6};
            //var grades= new List<double>();
            grades.Add(25.6);
             
             var result1=0.0;
             foreach(var number in grades){
                 result1 += number;
            }

             result1/=grades.Count;
             Console.WriteLine($"the average grade is: {result1:N1}");
 



           if(args.Length>0) 
            Console.WriteLine($"Hello, {args[0]}!");
            else 
            Console.WriteLine("Hello!!!!");
        }
    }
}
