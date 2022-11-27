using Microsoft.VisualStudio.TestTools.UnitTesting;
using T34_Unit_test_deliveries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T34_Unit_test_deliveries.Tests
{
    [TestClass()]
    public class ArrayCalcTests
    {
        [TestMethod()]
        public void SumTest()
        {
            // arrange
            ArrayCalc calc = new();
            double[] testarray = { 3.3, 5.5, -8.2 };
            double[] testarray1 = {};
            double exptected = 0;

            // act
            double actual = testarray1.Sum();

            // assert
            Assert.AreEqual(exptected,Math.Round(actual,1));
        }

        [TestMethod()]
        public void AverageTest()
        {
            // arrange
            ArrayCalc calc = new();
            double[] testarray = { };
            double exptected = 0;
            // act
            double actual = testarray.Average();
            // assert
            Assert.AreEqual(exptected, Math.Round(actual,1));
            
        }

        [TestMethod()]
        public void MinTest()
        {
            // arrange
            ArrayCalc calc = new();
            double[] testarray = { 3.3, 5.5, -8.2 };
            double exptected = -8.2;
            // act
            double actual = testarray.Min();
            // assert
            Assert.AreEqual(exptected, Math.Round(actual,1));
            
        }

        [TestMethod()]
        public void MaxTest()
        {
            // arrange
            ArrayCalc calc = new();
            double[] testarray = { 3.3, 5.5, -8.2 };
            double exptected = 5.5;
            // act
            double actual = testarray.Max();
            // assert
            Assert.AreEqual(exptected, Math.Round(actual, 1));
        }
    }
}