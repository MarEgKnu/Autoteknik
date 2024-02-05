using Autoteknik;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoteknikTests
{
    [TestClass]
    public class TestCarRegNoValidator
    {
        [TestMethod]
        public void Test_CarRegNoValidator_IsValid()
        {
            // Arrange
            IValidator carValidator = new CarRegNoValidator();
            string gyldigtRegistreringsnummer = "AA54314";

            // Act
            bool resultat = carValidator.Validate(gyldigtRegistreringsnummer);

            // Assert
            Assert.IsTrue(resultat);
        }
        [TestMethod]
        public void Test_CarRegNoValidator_IsInvalid_OnlyNumbers()
        {
            // Arrange
            IValidator carValidator = new CarRegNoValidator();
            string gyldigtRegistreringsnummer = "1154314";

            // Act
            bool resultat = carValidator.Validate(gyldigtRegistreringsnummer);

            // Assert
            Assert.IsFalse(resultat);
        }
        [TestMethod]
        public void Test_CarRegNoValidator_IsInvalid_OnlyLetters()
        {
            // Arrange
            IValidator carValidator = new CarRegNoValidator();
            string gyldigtRegistreringsnummer = "ABCDEFG";

            // Act
            bool resultat = carValidator.Validate(gyldigtRegistreringsnummer);

            // Assert
            Assert.IsFalse(resultat);
        }
        [TestMethod]
        public void Test_CarRegNoValidator_IsInvalid_WrongPlacement()
        {
            // Arrange
            IValidator carValidator = new CarRegNoValidator();
            string gyldigtRegistreringsnummer = "12ABCDE";

            // Act
            bool resultat = carValidator.Validate(gyldigtRegistreringsnummer);

            // Assert
            Assert.IsFalse(resultat);
        }
        [TestMethod]
        public void Test_CarRegNoValidator_IsInvalid_TooShort()
        {
            // Arrange
            IValidator carValidator = new CarRegNoValidator();
            string gyldigtRegistreringsnummer = "AB71";

            // Act
            bool resultat = carValidator.Validate(gyldigtRegistreringsnummer);

            // Assert
            Assert.IsFalse(resultat);
        }
        [TestMethod]
        public void Test_CarRegNoValidator_IsInvalid_TooLong()
        {
            // Arrange
            IValidator carValidator = new CarRegNoValidator();
            string gyldigtRegistreringsnummer = "AB7123456";

            // Act
            bool resultat = carValidator.Validate(gyldigtRegistreringsnummer);

            // Assert
            Assert.IsFalse(resultat);
        }
        [TestMethod]
        public void Test_CarRegNoValidator_IsInvalid_EmptyString()
        {
            // Arrange
            IValidator carValidator = new CarRegNoValidator();
            string gyldigtRegistreringsnummer = "";

            // Act
            bool resultat = carValidator.Validate(gyldigtRegistreringsnummer);

            // Assert
            Assert.IsFalse(resultat);
        }
        [TestMethod]
        public void Test_CarRegNoValidator_IsInvalid_Null()
        {
            // Arrange
            IValidator carValidator = new CarRegNoValidator();
            string gyldigtRegistreringsnummer = null;

            // Act
            bool resultat = carValidator.Validate(gyldigtRegistreringsnummer);

            // Assert
            Assert.IsFalse(resultat);
        }
        [TestMethod]
        public void Test_CarRegNoValidator_IsInvalid_ContainsSpace()
        {
            // Arrange
            IValidator carValidator = new CarRegNoValidator();
            string gyldigtRegistreringsnummer = "AB 62345";

            // Act
            bool resultat = carValidator.Validate(gyldigtRegistreringsnummer);

            // Assert
            Assert.IsFalse(resultat);
        }
        public void Test_CarRegNoValidator_IsInvalid_NonCapitalLetters()
        {
            // Arrange
            IValidator carValidator = new CarRegNoValidator();
            string gyldigtRegistreringsnummer = "ab62345";

            // Act
            bool resultat = carValidator.Validate(gyldigtRegistreringsnummer);

            // Assert
            Assert.IsFalse(resultat);
        }
    }
}
