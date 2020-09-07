using NUnit.Framework;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [SetUp]
        public void Setup()
        {
        }



  //      [Test]
  //      public void test1()
		//{
  //          //Arrange
  //          var book = new Book("Hedreez book");

  //           //Act
  //          var result = book.AddGrade(100.0);

  //          //Assert
  //          Assert.AreEqual(100,result); 
		//}

        [Test]
        public void BookCalculateAnAverageGrade()
        {   
            //Arrange
            var book = new Book("Hedreez book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            //act
            var result = book.GetStatistics();
            //assert
            Assert.AreEqual(85.6, result.Average, 1);
            Assert.AreEqual(90.5, result.High, 1);
            Assert.AreEqual(77.3, result.Low, 1);
            Assert.AreEqual('B', result.Letter);
        }
    }
}