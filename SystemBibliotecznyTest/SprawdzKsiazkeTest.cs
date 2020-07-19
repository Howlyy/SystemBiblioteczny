using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemBiblioteczny;
using System;



namespace SystemBibliotecznyTest
{
    /// <summary>
    /// Klasa testów
    /// </summary>
    [TestClass]
    public class SprawdzKsiazkeTest
    {
        
        /// <summary>
        /// Metoda testowa 1
        /// </summary>
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
        /// <summary>
        /// Metoda testowa 2
        /// </summary>
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
