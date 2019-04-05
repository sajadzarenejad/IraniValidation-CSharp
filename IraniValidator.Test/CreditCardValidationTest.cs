using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IraniValidator.Test
{
    [TestClass]
    public class CreditCardValidationTest
    {
        [TestMethod]
        public void CreditCard_ShouldBeTrue()
        {
            var result1 = "5894631530917210".IsValidCreditCard();
            Assert.AreEqual(result1,true);

            var result2 = "6280231324179851".IsValidCreditCard();
            Assert.AreEqual(result2, true);

            var result3 = "6037997364787169".IsValidCreditCard();
            Assert.AreEqual(result3, true);

            var result4 = "6037997364787168".IsValidCreditCard();
            Assert.AreEqual(result4, false);
        }

    }
}