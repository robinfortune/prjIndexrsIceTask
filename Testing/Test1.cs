using prjIndexrsIceTask;

namespace Testing
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMilage()
        {
            Service serv = new Service(25000, 2020, "Toyota", "Camry");
            Assert.AreEqual(25000, serv["milage"]);
        }

        [TestMethod]
        public void TestYearModel()
        {
            Service serv = new Service(25000, 2020, "Toyota", "Camry");
            Assert.AreEqual(2020, serv["yearModel"]);
        }

        [TestMethod]
        public void TestMake()
        {
            Service serv = new Service(25000, 2020, "Toyota", "Camry");
            Assert.AreEqual("Toyota", serv["make"]);
        }

        [TestMethod]
        public void TestUpdatedMake()
        {
            Service serv = new Service(25000, 2020, "Toyota", "Camry");
            serv["make"] = "Honda";
            Assert.AreEqual("Honda", serv["make"]);
        }

        [TestMethod]
        public void TestUpdatedModel()
        {
            Service serv = new Service(25000, 2020, "Toyota", "Camry");
            serv["model"] = "Accord";
            Assert.AreEqual("Accord", serv["model"]);
        }
        
    }
}
