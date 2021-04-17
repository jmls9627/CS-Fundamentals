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
           book.AddGrade(89.1);
           book.AddGrade(39.23);
           book.AddGrade(8.11);

            //act
          var result = book.GetStats();

            //assert
           Assert.Equal(45.5, result.Average,1);
           Assert.Equal(89.1, result.High,1);
           Assert.Equal(8.1, result.Low,1);
        }
    }
}
