using NUnit.Framework;

namespace Classes.Tests
{

    [TestFixture]
    public class Tests
    {
        Store blockBuster; 
        [SetUp]
        public void Setup()
        {
            blockBuster = new("Block Buster");
            blockBuster.LoadData("customers");
            blockBuster.LoadData("inventory");
        }

        /// <summary>
        /// Asserting that the number of customers loaded from CSV is 6
        /// </summary>
        [Test]
        public void Test001DataUnpackedFromCuvCustomers()
        {
            Assert.That(Customer.Customers, Has.Count.EqualTo(6));
        }


    }
}