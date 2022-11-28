using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrades()
        {
            var book = new GradeBook("");
            book.AddGrade(89.1);
            book.AddGrade(90.1);
            book.AddGrade(77.5);

            var result = book.GetStatistics();

            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }
    }
}

