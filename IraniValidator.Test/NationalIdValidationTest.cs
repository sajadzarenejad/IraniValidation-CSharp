using System.IO.Compression;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IraniValidator.Test
{
    [TestClass]
    public class NationalIdValidationTest
    {
        [TestMethod]
        public void Person_NationalId_ShouldBeTrue()
        {
            var result1 = "3962619771".IsValidPersonNationalId();
            Assert.AreEqual(result1,true);

            var result2 = "3962611010".IsValidPersonNationalId();
            Assert.AreEqual(result2, true);

            var result3 = "3874008657".IsValidPersonNationalId();
            Assert.AreEqual(result3, true);

            var result4 = "3874008653".IsValidPersonNationalId();
            Assert.AreEqual(result4, false);
        }


        [TestMethod]
        public void Company_NationalId_ShouldBeTrue()
        {
            var result1 = "10100018975".IsValidCompanyNationalId();
            Assert.AreEqual(result1, true);

            var result2 = "10100049908".IsValidCompanyNationalId();
            Assert.AreEqual(result2, true);

            var result3 = "10100051432".IsValidCompanyNationalId();
            Assert.AreEqual(result3, true);


        }
    }
}