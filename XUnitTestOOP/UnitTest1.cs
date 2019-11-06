using System;
using Xunit;
using ConsoleAppOOP.Models;

namespace XUnitTestOOP
{
    public class CarTest
    {
        [Fact]
        public void CreateCarOk()
        {
            //Arrange
            string brand = "testBrand";
            string modelName = "testModel";
            string regPlate = "tes123";

            //Act
            Car testCar = new Car(brand, modelName, regPlate);

            //Assert
            Assert.NotNull(testCar);
        }

        [Fact]
        public void CreateCarBad()
        {
            //Arrange
            string brand = "testBrand";
            string modelName = "testModel";
            string regPlate = "Bad123456";
            Car testCar = null;
            string excpectedMsg = "6 symbols on reg.plate only (Parameter 'Reg.Plate')";
            string errorMsg = "";


            //Act
            try
            {
                testCar = new Car(brand, modelName, regPlate);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                errorMsg = exception.Message;
            }
            
            //Assert
            Assert.Null(testCar);
            Assert.Equal(excpectedMsg, errorMsg);
        }

        [Fact]
        public void ToString_Info_Ok()
        {
            //Arrange
            string brand = "testBrand";
            string modelName = "testModel";
            string regPlate = "tes123";
            Car testCar = new Car(brand, modelName, regPlate);

            //Act
            string result = testCar.ToString();

            //Assert
            Assert.Contains(testCar.Id.ToString(), result);
            Assert.Contains(brand, result);
            Assert.Contains(modelName, result);

            Assert.DoesNotContain(regPlate, result);
        }

        [Fact]
        public void InfoMethod_Ok()
        {
            //Arrange
            string brand = "testBrand";
            string modelName = "testModel";
            string regPlate = "tes123";
            int wheels = 6;
            Car testCar = new Car(brand, modelName, regPlate, wheels);

            //Act
            string result = testCar.Info();

            //Assert
            Assert.Contains(testCar.Id.ToString(), result);
            Assert.Contains(brand, result);
            Assert.Contains(modelName, result);
            Assert.Contains(regPlate, result);
            Assert.Contains(wheels.ToString(), result);
        }
    }
}
/*

*/
