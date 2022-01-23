using Practice;
using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookSwitch()
        {
            var book = new Book();

            book.AddGrade(55);

            var result = book.GetStatistics();


            Assert.Equal('F', result.Letter);
        }
    
        //[Fact]
        //public void BookIfChal()
        //{
        //    var book = new Book();

        //    book.AddGrade(105);

        //    var result = book.GetStatistics();

        //    Assert.Equal(0, result.High);
        //}
        //[Fact]
        //public void BookCalculateAnAverage()
        //{
            //// Arrange
            //var book = new Book();

            //book.AddGrade(88.1);
            //book.AddGrade(70.1);
            //book.AddGrade(78.3);

            //// Act 
            //var result = book.GetStatistics();

            //// Assert
            //Assert.Equal(77, result.Average, 1);
            //Assert.Equal(88.1, result.High, 1);
            //Assert.Equal(70.1, result.Low, 1);
        //}
    }
}
