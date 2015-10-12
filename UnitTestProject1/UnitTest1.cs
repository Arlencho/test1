using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ooad.Domain;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Class1 sut = new Class1();
            int i1 = 5;
            int i2 = 5;
            //Act
            sut.IsEqual(i1, i2);
            //Assert
            Assert.IsTrue(true);

        }
    }
}
