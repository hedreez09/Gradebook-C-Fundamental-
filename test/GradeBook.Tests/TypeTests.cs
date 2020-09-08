using NUnit.Framework;
using System;

namespace GradeBook.Tests
{
    public delegate string WriteLogDelegaate(string logMessage);

    public class TypeTests
    {
        int count = 0;
        [Test]
        public void WriteLogDelegateCanPointToMethod()
		{

            WriteLogDelegaate log = ReturnMessage;
            log += ReturnMessage;
            log += IncrementCount;

            var result = log("Hello!");
            Assert.AreEqual(3, count);
		}

        string IncrementCount(string message)
		{
            count++;
            return message.ToLower();
        }

        string ReturnMessage(string message)
		{
            count++;
            return message;
		}
        [Test]
        public void ValueTypeAlsoPassByValue()  
		{
            var x = GetInt();
            setInt(out x);

            Assert.AreEqual(42, x);
		}

		private void setInt(out int z)
		{
            z = 42;
		}

		private int GetInt()
		{
            return 3;
		}

		[Test]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Figurine");
            GetBooksetBook(out book1, "Figurine");

            Assert.AreEqual("Figurine", book1.Name);
        }

        private void GetBooksetBook(out Book book, string name)
        {
            book = new Book(name);
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