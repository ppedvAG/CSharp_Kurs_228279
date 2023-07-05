using Fahrzeugpark;

namespace UnitTests
{
    [TestClass]
    public class PKW_Test
    {
        [TestMethod]
        public void Beschleunige_PKW_über_MaxG()
        {
            PKW pkw = new PKW("BMW", 200, 23000, 4);

            pkw.StarteMotor();
            pkw.Beschleunige(pkw.MaxGeschwindigkeit + 1);

            Assert.AreEqual(pkw.MaxGeschwindigkeit, pkw.AktGeschwindigkeit);
        }

        [TestMethod]
        public void Bremse_PKW_unter_0()
        {
            PKW pkw = new PKW("BMW", 200, 23000, 4);

            pkw.StarteMotor();
            pkw.Beschleunige(100);
            pkw.Beschleunige(-101);

            Assert.AreEqual(0, pkw.AktGeschwindigkeit);
        }
    }
}