﻿using UnitTest.APP;

namespace xUnitTest.Test
{
    public class CalculatorTest
    {
        // Test işlemi 3 evreden olusur: Arrange,Act,Assert
        [Fact]
        public void AddTest() {

            //Arrange : Degiskenlerin initialize edildigi yer bu kisimdir veya nesne örnegi olusturulan kisim
            int a =5; int b = 10;
            var calculator = new Calculator();

            //Act
            var total = calculator.add(a, b);

            //Assert
            Assert.Equal<int>(15,total);
        }
    }
}
