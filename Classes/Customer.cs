using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    /// <summary>
    /// Base Customer Class
    /// </summary>
    public class Customer
    {
        public Customer() {}

        /// <summary>
        /// Constructor
        /// Creates new customer
        /// </summary>
        /// <param name="newId">ID</param>
        /// <param name="newFirstName">First Name</param>
        /// <param name="newLastName">Last Name</param>
        /// <param name="newAccountType">Account Type</param>
        public Customer(int newId, string newFirstName, string newLastName, string newAccountType)
        {
            _id = newId;
            firstName = newFirstName;
            lastName = newLastName;
            _accountType = newAccountType;
        }

        /// <summary>
        /// Creates new customer with video rentals
        /// </summary>
        /// <param name="newId">ID</param>
        /// <param name="newFirstName">First Name</param>
        /// <param name="newLastName">Last Name</param>
        /// <param name="newAccountType">Account Type</param>
        /// <param name="newCurrentVideoRentals">Current Video Rentals (String with / seperator between videos)</param>
        public Customer(int newId, string newFirstName, string newLastName, string newAccountType, string newCurrentVideoRentals)
        {
            _id = newId;
            firstName = newFirstName;
            lastName = newLastName;
            _accountType = newAccountType;
            _currentVideoRentals = newCurrentVideoRentals.Split('/');
        }

        // Initialize a static Dictionary for all customers
        public static Dictionary<int, object> Customers = [];

        int _id;
        string _accountType;
        string[]? _currentVideoRentals;
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
            get 
            {
                if (_currentVideoRentals != null) return _currentVideoRentals;
                else return Array.Empty<string>();
            }
            set { _currentVideoRentals = value[0].Split('/'); }
        }

        /// <summary>
        /// Setter
        /// Removes video from array
        /// </summary>
        public string ReturnAVideo
        {
            set 
            {
                // Ensure that we have current videos to remove from
                if(_currentVideoRentals != null)
                {
                    // Temp array to store other videos
                    string[] _result = new string[_currentVideoRentals.Length - 1];
                    int _resultIndex = 0;
                    // Iterate through current video rentals to find value
                    for(int index = 0; index < _currentVideoRentals.Length; index++)
                    {
                        // If we don't match, add this video to the new array
                        if(_currentVideoRentals[index] != value)
                        {
                            _result[_resultIndex] = _currentVideoRentals[index];
                            _resultIndex++;
                        }
                    }
                    // replace the old array with the new one
                    _currentVideoRentals = _result;
                }
            }
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

        /// <summary>
        /// Retrieves customer object by id
        /// Uses Console for input
        /// </summary>
        /// <returns>Customer object</returns>
        public static object GetCustomerByID()
        {
            int _id;
            _id = int.Parse(Console.ReadLine());

            return Customer.Customers[_id];
        }

    }
}
