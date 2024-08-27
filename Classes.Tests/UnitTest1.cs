using NUnit.Framework;

namespace Classes.Tests
{


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

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}