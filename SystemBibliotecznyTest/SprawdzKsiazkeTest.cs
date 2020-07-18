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
            bool actual = Program.SprawdzKsiazke1("Nic smiesznego");

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BookCheck2()
        {
            //Arrange   
            bool expected = false;

            //Act
            bool actual = Program.SprawdzKsiazke1("Nie ma nic");

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
