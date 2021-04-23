using System;
using Grade_Book;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {

        [Fact]
        public void BookCalculateAnAverageGrade()
        {
            //arrange
           var book = new Book("");
           book.AddGrade(89.12);
           book.AddGrade(70.2);
           book.AddGrade(86.13);

            //act
          var result = book.GetStats();

            //assert
           Assert.Equal(81.8, result.Average,1);
           Assert.Equal(89.12, result.High,1);
           Assert.Equal(70.2, result.Low,1);

           Assert.Equal(89.12,book.grades[0],1);
           Assert.Equal(70.2,book.grades[1],1);
           Assert.Equal(86.13,book.grades[2],1);
           
           Assert.Equal('B',result.Letter );
        }
    }
}
