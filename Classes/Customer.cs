namespace Classes
{
    /// <summary>
    /// Base Customer Class
    /// </summary>
    public class Customer
    {
        // Initialize a static Dictionary for all customers
        public static Dictionary<int, object> Customers = [];

        // Public Fields
        public int id;
        public string accountType;
        public string firstName;
        public string lastName;
        public string currentVideoRentals;

        public static Dictionary<string, string> CreateCustomer()
        {
            // This is calculated as an int then stored as a string
            int _id;
            string _firstName;
            string _lastName;
            string _accountType;
     
            Dictionary<string, string> _result = new();

            // Get the count of elements in Customers and increment it for this id
            _id = Customers.Count + 1;

            // Prompt for inputs, assume they are entered correctly
            _firstName = Console.ReadLine();
            _lastName = Console.ReadLine();
            _accountType = Console.ReadLine();

            Console.WriteLine($"Inputs for id {_id} First Name {_firstName} Last Name {_lastName} Account Type {_accountType}");

            _result.Add("id", _id.ToString());
            _result.Add("firstName", _firstName);
            _result.Add("lastName", _lastName);
            _result.Add("accountType", _accountType);

            return _result;
        }
    }
}
