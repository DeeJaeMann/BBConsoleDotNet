using NUnit.Framework;

namespace Classes.Tests
{

    [TestFixture]
    public class Tests
    {
        Store block_buster; 
        [SetUp]
        public void Setup()
        {
            block_buster = new("Block Buster");
            block_buster.LoadData("customers");
            block_buster.LoadData("inventory");
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