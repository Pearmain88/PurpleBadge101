using System;
using _02_reference_Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Reference_Types_Unit_Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void Customer_SetFirstNameAsString()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Jenna";

            //--Act
            var actual = customer.FirstName;
            var expected = "Jenna";

            Console.WriteLine($"Actual: {actual}");

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_SetLastNameAsString()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.LastName = "Pearmain";

            //--Act
            var actual = customer.LastName;
            var expected = "Pearmain";

            Console.WriteLine($"Actual: {actual}");

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
