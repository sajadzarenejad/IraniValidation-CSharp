using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IraniValidator.Test
{
    [TestClass]
    public class PhoneValidationTest
    {
        [TestMethod]
        public void HamrahAval_PassMobileNumber_ShouldBeTrue()
        {
            var result1 = "09190618636".IsValidMobile(OpratorType.HamrahAval, PhoneFormatType.StartWithZero);
            Assert.AreEqual(result1,true);

            var result2 = "9190618636".IsValidMobile(OpratorType.HamrahAval, PhoneFormatType.StartWithZero);
            Assert.AreEqual(result2,false);

            var result3 = "9190618636".IsValidMobile(OpratorType.HamrahAval, PhoneFormatType.StartWith9);
            Assert.AreEqual(result3, true);

        }
    }
}
