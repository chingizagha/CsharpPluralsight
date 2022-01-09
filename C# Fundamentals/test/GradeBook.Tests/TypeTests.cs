using Practice;
using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void Test1()
        {
            int name = 5;

            MakeUpper(name);

            Assert.Equal(6, name);
        }

        private void MakeUpper(int name1)
        {
            name1 = 6;
        }




        ///////////////////////////////////////////////////////

        //[Fact]
        //public void Test1()
        //{
        //    var x = GetInt();
        //    SetInt(ref x);

        //    Assert.Equal(42, x);
        //}

        //private void SetInt(ref int x)
        //{
        //    x = 42;
        //}

        //private int GetInt()
        //{
        //    return 3;
        //}



        ///////////////////////////////////////////////////////


        //[Fact]
        //public void Test2()
        //{
        //    var book1 = GetBook("Book 1");
        //    GetBookSetName(ref book1, "Name");

        //    Assert.Equal("Name", book1.Name);
        //}

        //private void GetBookSetName(ref Book book, string name)
        //{
        //    book = new Book(name);
        //}



        ///////////////////////////////////////////////////////



        //[Fact]
        //public void Test2()
        //{
        //    var book1 = GetBook("Book 1");
        //    GetBookSetName(book1, "Name");

        //    Assert.Equal("Book 1", book1.Name);
        //}

        //private void GetBookSetName(Book book, string name)
        //{
        //    book = new Book(name);
        //}



        ///////////////////////////////////////////////////////


        //[Fact]
        //public void Test1()
        //{
        //    var book1 = GetBook("Book 1");
        //    SetName(book1, "Name");

        //    Assert.Equal("Name", book1.Name);
        //}

        //private void SetName(Book book, string name)
        //{
        //    book.Name = name;
        //}



        ///////////////////////////////////////////////////////




        //[Fact]
        //public void GetBookReturnsDifferentObjects()
        //{
        //    var book1 = GetBook("Book 1");
        //    var book2 = GetBook("Book 2");

        //    Assert.Equal("Book 2", book1.Name);
        //    Assert.Equal("Book 2", book2.Name);
        //}

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
