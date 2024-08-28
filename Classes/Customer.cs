namespace Classes
{
    /// <summary>
    /// Base Customer Class
    /// </summary>
    public class Customer
    {
        // Initialize a static Dictionary for all customers
        public static Dictionary<int, object> Customers = [];

        int _id;
        string _accountType;
        string[] _currentVideoRentals;
        // Public Fields
        public string firstName;
        public string lastName;

        /// <summary>
        /// Customer ID Property
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// Customer Account Type Property
        /// </summary>
        public string AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
        }

        /// <summary>
        /// Customer CurrentVideoRentals Property
        /// Setter splits string parameter to store array of strings
        /// </summary>
        public string[] CurrentVideoRentals
        {
            get { return _currentVideoRentals;  }
            set { _currentVideoRentals = value[0].Split('/'); }
        }

        /// <summary>
        /// Prompts for user input to create a customer
        /// NOTE: This does not display any output for prompts!
        /// Prompt order: First Name, Last Name, Account Type
        /// </summary>
        /// <returns>Dictionary with new customer data</returns>
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

            //Console.WriteLine($"Inputs for id {_id} First Name {_firstName} Last Name {_lastName} Account Type {_accountType}");

            _result.Add("id", _id.ToString());
            _result.Add("firstName", _firstName);
            _result.Add("lastName", _lastName);
            _result.Add("accountType", _accountType);

            return _result;
        }

        public static object GetCustomerByID()
        {
            int _id;
            _id = int.Parse(Console.ReadLine());

            return Customer.Customers[_id];
        }
    }
}
