using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PESELWalidator;

namespace UnitTests {
    [TestClass]
    public class UnitTest1 {
        private Walidator w;

        [TestInitialize]
        public void PrepareTest() {
            w = new Walidator("02070803628");
        }

        [TestMethod]
        public void SprawdzSumeKontrolna() {
            Assert.AreEqual(8, w.SumaKontrolna());
        }

        [TestMethod]
        public void SprawdzPlec() {
            Assert.AreEqual("K", w.Plec());
        }

        [TestMethod]
        public void SprawdzDate() {
            Assert.AreEqual("08071902", w.DataUrodzenia());
        }

        [TestMethod]
        public void SprawdzPesel() {
            Assert.AreEqual(true, w.SprawdzPesel());
        }
    }
}
