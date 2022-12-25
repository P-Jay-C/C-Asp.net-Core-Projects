using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;

namespace DemoLibrary.Tests
{
    public class CalculatorTests
    {
        //[Fact]
        //public void Add_SimpleValueShouldCalculate()
        //{
        //    //Arrange  

        //    double expected = 5;

        //    //Act
        //    double actual = Calculator.Add(3, 2);
        //    //Assert

        //    Assert.Equal(expected, actual);
        //}

        [Theory]
        [InlineData(3,4,7)]
        [InlineData(5,6,8)]
        [InlineData(7,8,9)]
        public void Add_SimpleValueShouldCalculate(double x, double y, double expected)
        { 
            //Arrange

            //Act
            double actual = Calculator.Add(x,y);

            //Assert

            Assert.Equal(expected, actual);
        }


    }
}
