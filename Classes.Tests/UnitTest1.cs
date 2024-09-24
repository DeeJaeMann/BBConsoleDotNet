using NUnit.Framework;

namespace Classes.Tests
{

    [TestFixture]
    public class Tests
    {
        Store _blockBuster; 

        [SetUp]
        public void Setup()
        {
            _blockBuster = new("Block Buster");
            _blockBuster.LoadData("customers");
            _blockBuster.LoadData("inventory");
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
            Customer _customer = (Customer)Customer.Customers[6];
            Assert.That(Customer.GetCustomerByID(), Is.EqualTo(_customer));
        }

        /// <summary>
        /// Asserting that a customer's current video rentals are updated correctly
        /// </summary>
        [Test]
        public void Test003ReturnAVideo()
        {
            // Get customer with ID 2
            Customer _customer = (Customer)Customer.Customers[2];
            // Set the video to be returned by the customer
            _customer.ReturnAVideo = "The Dark Knight";
            string[] _expected = { "Inception", "The Prestige" };

            //Assert.That(_customer.CurrentVideoRentals, Is.EqualTo())
            CollectionAssert.AreEquivalent(_expected, _customer.CurrentVideoRentals);

        }
    }
}