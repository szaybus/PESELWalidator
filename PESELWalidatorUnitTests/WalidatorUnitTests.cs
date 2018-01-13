using Microsoft.VisualStudio.TestTools.UnitTesting;
using PESELWalidator;

namespace PESELWalidatorUnitTests {
    [TestClass]
    public class WalidatorUnitTests {
        Walidator w;

        [TestInitialize]
        public void PrzygotujWalidator() {
            w = new Walidator("02070803628");
        }
        /*
        [TestMethod]
        public void TestSumaKontrolna() {
            int suma = w.SumaKontrolna();
            Assert.AreEqual(8, suma);
        }
        */
        [TestMethod]
        public void DumbTest() {
            Assert.IsTrue(true);
        }

    }
}
