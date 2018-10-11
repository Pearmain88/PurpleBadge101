using System;
using _03_Defining_Classes_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Defining_Classes_Tests
{
    [TestClass]
    public class EmployeeTests
    {  
        //--Field
        private Employee _employee;

        [TestInitialize]
        public void Arrange()
        {
            //-- Arrange
            _employee = new Employee();
            _employee.EmployeeID = 1;
            _employee.LastName = "Pearmain";
            _employee.TotalHours = 450;
            _employee.Age = 30;
        }

        [TestMethod]
        public void Employee_EmployeeLastName_ShouldBeString()
        {
            //--Act
            var expected = "Pearmain";
            var actual = _employee.LastName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_EmployeeID_IsInt()
        {            
            //--Act
            var expected = 1;
            var actual = _employee.EmployeeID;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] 
        public void Employee_EmployeeAge_IsInt()
        {
            //-- Act
            var expected = 30;
            var actual = _employee.Age;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Employee_EmployeeHours_IsInt()
        {
            //-- Act
            var expected = 450;
            var actual = _employee.TotalHours;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
