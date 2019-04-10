using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace mrk.fiscalcode.test
{
    [TestClass]
    public class CodiceFiscaleTest
    {
        [TestMethod]
        public void FiscalCode_IsValid()
        {
            var cf = new CodiceFiscale("MTTRND05A31D969W");
            Assert.IsTrue(cf.IsValid);
        }
    }
}
