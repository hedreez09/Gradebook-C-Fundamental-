using NUnit.Framework;
using System;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Figurine");
            GetBooksetBook(book1, "Figurine");

            Assert.AreEqual("Figurine", book1.Name);
        }

        private void GetBooksetBook(Book book, string name)
        {
             book = new Book(name);
        }

        [Test]
        public void CanSetNameFromRference()
        {
            var book1 = GetBook("Figurine");
            setBook(book1, "Figurine");

            Assert.AreEqual( "Figurine", book1.Name);
        }

		private void setBook(Book book, string name)
		{
            book.Name = name;
		}

		[Test]
        public void GetBookReturnDifferentObject()
        {
            var book1 = GetBook("Figurine");
            var book2 = GetBook("Hidden figures");

            Assert.AreEqual("Figurine", book1.Name);
            Assert.AreEqual("Hidden figures", book2.Name);

        }

        [Test]
        public void GetBookReturnSameObject()
        {
            var book1 = GetBook("Figurine");
            var book2 = book1;


            Assert.AreSame(book1, book2);
            Assert.True(Object.ReferenceEquals(book2, book1));
        }

		Book GetBook(string name)
		{
            return new Book(name);
		}
	}
}