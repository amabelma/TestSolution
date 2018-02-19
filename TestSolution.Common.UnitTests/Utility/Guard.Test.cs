using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestSolution.Common.Utility;

namespace TestSolution.Common.UnitTests.Utility
{
    [TestClass]
    public class GuardTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AgainstInvalidId_GivenNegativeNumberAsLong_ThrowsArgumentException()
        {
            Guard.AgainstInvalidId((long)(-1), "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AgainstInvalidId_GivenZeroAsLong_ThrowsArgumentException()
        {
            Guard.AgainstInvalidId((long)0, "Test");
        }

        [TestMethod]
        public void AgainstInvalidId_GivenPositiveNumberAsLong_DoesNotThrowArgumentException()
        {
            Guard.AgainstInvalidId((long)1, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AgainstInvalidId_GivenNegativeNumberAsInt_ThrowsArgumentException()
        {
            Guard.AgainstInvalidId(-1, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AgainstInvalidId_GivenZeroAsInt_ThrowsArgumentException()
        {
            Guard.AgainstInvalidId(0, "Test");
        }

        [TestMethod]
        public void AgainstInvalidId_GivenPositiveNumberAsInt_DoesNotThrowArgumentException()
        {
            Guard.AgainstInvalidId(1, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AgainstNegativeValue_GivenNegativeNumberAsDecimal_ThrowsArgumentException()
        {
            Guard.AgainstNegativeValue((decimal)(-1), "Test");
        }

        [TestMethod]
        public void AgainstNegativeValue_GivenZeroAsDecimal_DoesNotThrowArgumentException()
        {
            Guard.AgainstNegativeValue((decimal)0, "Test");
        }

        [TestMethod]
        public void AgainstNegativeValue_GivenPositiveNumberAsDecimal_DoesNotThrowArgumentException()
        {
            Guard.AgainstNegativeValue((decimal)1, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AgainstNegativeValue_GivenNegativeNumberAsShort_ThrowsArgumentException()
        {
            Guard.AgainstNegativeValue((short)(-1), "Test");
        }

        [TestMethod]
        public void AgainstNegativeValue_GivenZeroAsShort_DoesNotThrowArgumentException()
        {
            Guard.AgainstNegativeValue((short)0, "Test");
        }

        [TestMethod]
        public void AgainstNegativeValue_GivenPositiveNumberAsShort_DoesNotThrowArgumentException()
        {
            Guard.AgainstNegativeValue((short)1, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AgainstInvalidXmlString_GivenInvalidXml_ThrowsArgumentException()
        {
            Guard.AgainstInvalidXmlString("Test", "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AgainstInvalidXmlString_GivenEmptyXml_ThrowsArgumentException()
        {
            Guard.AgainstInvalidXmlString(string.Empty, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AgainstInvalidXml_GivenNullXml_ThrowsArgumentException()
        {
            Guard.AgainstInvalidXmlString(null, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AgainstInvalidXmlString_GivenWhitespaceXml_ThrowsArgumentException()
        {
            Guard.AgainstInvalidXmlString(" ", "Test");
        }

        [TestMethod]
        public void AgainstInvalidXmlString_GivenValidXml_DoesNotThrowArgumentException()
        {
            Guard.AgainstInvalidXmlString("<test>Valid!</test>", "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AgainstNullEmptyOrWhitespaceString_GivenEmptyString_ThrowsArgumentException()
        {
            Guard.AgainstNullEmptyOrWhitespaceString(string.Empty, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AgainstNullEmptyOrWhitespaceString_GivenNullString_ThrowsArgumentException()
        {
            Guard.AgainstNullEmptyOrWhitespaceString(null, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AgainstNullEmptyOrWhitespaceString_GivenWhitespaceString_ThrowsArgumentException()
        {
            Guard.AgainstNullEmptyOrWhitespaceString(" ", "Test");
        }

        [TestMethod]
        public void AgainstNullEmptyOrWhitespaceString_GivenStringWithContents_DoesNotThrowArgumentException()
        {
            Guard.AgainstNullEmptyOrWhitespaceString("Test", "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AgainstNullObject_GivenNull_ThrowsArgumentNullException()
        {
            object test = null;

            Guard.AgainstNullObject(test, nameof(test));
        }

        [TestMethod]
        public void AgainstNullObject_GivenAnyNonNullObject_DoesNotThrowArgumentNullException()
        {
            object test = new object{ };

            Guard.AgainstNullObject(test, nameof(test));
        }
    }
}