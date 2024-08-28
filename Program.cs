using Classes;

namespace BBConsoleDotNet
{
    /// <summary>
    /// C# demonstration of Code Platoon OOP Assessment - Video Store
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Store blockBuster = new("Block Buster");
            blockBuster.LoadData("inventory");
            blockBuster.LoadData("customers");

            //Customer.CreateCustomer();
            //Customer customer = (Customer)Customer.GetCustomerByID();
            //Console.WriteLine(customer.ID);
        }
    }
}
