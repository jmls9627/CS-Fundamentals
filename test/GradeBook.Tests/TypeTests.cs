using System;
using Grade_Book;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
         [Fact]
        public void CSharpCanPassByReff()
        {
          var book1= GetBook("Book 1");
          GetBookSetName(ref book1,"New Name"); //ref or out(does it pass by reference but its has not been initialaized you would have an error)
          
          Assert.Equal( "New Name",book1.name);
        }

        private void GetBookSetName(ref Book book, string Name)
        {
           book=new Book(Name);
          
        }

         [Fact]
        public void CSharpIsPassByValue()
        {
          var book1= GetBook("Book 1");
          GetBookSetName(book1,"New Name");
          
          Assert.Equal( "New Name",book1.name);
        }

        private void GetBookSetName(Book book, string Name)
        {
           book=new Book(Name);
          
        }

         [Fact]
        public void CanSetNameFromReference()
        {
          var book1= GetBook("Book 1");
          SetName(book1,"New Name");
          
          Assert.Equal( "New Name",book1.name);
        }

        private void SetName(Book book1, string Name)
        {
            book1.name=Name;
        }

        [Fact]
        public void GetBookReturnDifferentObjects()
        {
          var book1= GetBook("Book 1");
          var book2= GetBook("Book 2");
          
          Assert.Equal("Book 1", book1.name);
          Assert.Equal("Book 2", book2.name);
          Assert.NotSame(book1,book2);
        }
       
        [Fact]
        public void TwoVarsCanReferenceSameObj()
        {
          var book1= GetBook("Book 1");
          var book2= book1;
          
         Assert.Same(book1,book2);
         Assert.True(Object.ReferenceEquals(book1,book2));

        }
         

      Book GetBook(string name)
        {
           return new Book(name);
        }
    }
}
