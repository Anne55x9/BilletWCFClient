using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;





namespace UnitTestProjectBilletClient
{
    [TestClass]
    public class UnitTestBilleClient
    {
        [TestMethod]
        public void GetPrisBillMuedBrobizz()
        {
            using (var client = new ServiceReference1.BilletServiceClient("BasicHttpBinding_IBilletService"))
            {
                //Arrange
                //Act
                var pris = client.GetPrisBilMedBrobizz();
                //Assert
                Assert.AreEqual(228, pris);
            }

        }

        [TestMethod]
        public void GetPrisBillUdenBrobizz()
        {
            using (var client = new ServiceReference1.BilletServiceClient("BasicHttpBinding_IBilletService"))
            {
                //Arrange
                //Act
                var pris = client.GetPrisBilUBrobizz();
                //Assert
                Assert.AreEqual(240, pris);
            }

        }

        [TestMethod]
        public void GetPrisMcMedBrobizz()
        {
            using (var client = new ServiceReference1.BilletServiceClient("BasicHttpBinding_IBilletService"))
            {
                //Arrange
                //Act
                var pris = client.GetPrisMCMedBrobizz();
                //Assert
                Assert.AreEqual(118, pris);
            }

        }

        [TestMethod]
        public void GetPrisMCUdenBrobizz()
        {
            using (var client = new ServiceReference1.BilletServiceClient("BasicHttpBinding_IBilletService"))
            {
                //Arrange
                //Act
                var pris = client.GetPrisMCUBrobizz();
                //Assert
                Assert.AreEqual(125, pris);
            }

        }
    }
}
