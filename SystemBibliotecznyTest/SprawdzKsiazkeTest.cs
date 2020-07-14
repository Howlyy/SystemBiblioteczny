using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemBiblioteczny;
using System;



namespace SystemBibliotecznyTest
{
    [TestClass]
    public class SprawdzKsiazkeTest
    {
        

    [TestMethod]
        public void BookCheck()
        {
            //Arrange   
            bool expected = true;

            //Act
            bool actual = Program.SprawdzKsiazke1("Lel");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
