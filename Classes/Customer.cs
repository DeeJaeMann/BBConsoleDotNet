namespace Classes
{
    /// <summary>
    /// Base Customer Class
    /// </summary>
    public class Customer
    {
        // Initialize a static Dictionary for all customers
        public static Dictionary<int, Customer> Customers = [];
        public int id;
        public string accountType;
        public string firstName;
        public string lastName;
        public string currentVideoRentals;
    }
}
