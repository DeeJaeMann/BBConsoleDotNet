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

        [TearDown]
        public void TearDown()
        {
            Customer.Customers.Clear();
            Video.Videos.Clear();
        }

        /// <summary>
        /// Asserting that the number of customers loaded from CSV is 6
        /// </summary>
        [Test]
        public void Test001DataUnpackedFromCuvCustomers()
        {
            Assert.That(Customer.Customers, Has.Count.EqualTo(6));
        }

        /// <summary>
        /// Asserting that the customer retrieved by ID is the one with ID 6
        /// </summary>
        [Test]
        public void Test002GetCustomerByID()
        {
            StringReader testID = new("6");

            Console.SetIn(testID);
            Customer customer = (Customer)Customer.Customers[6];
            Assert.That(Customer.GetCustomerByID(), Is.EqualTo(customer));
        }
    }
}