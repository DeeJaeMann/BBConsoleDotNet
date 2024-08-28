using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace Classes
{
    /// <summary>
    /// Video Store class
    /// </summary>
    public class Store
    {
        string _storeName;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="storeName">Video Store Name</param>
        public Store(string storeName)
        {
            _storeName = storeName;
        }

        /// <summary>
        /// Loads data from .CSV file into objects
        /// </summary>
        /// <param name="fileName">Filename to load: customers or inventory</param>
        public void LoadData(string fileName)
        {
            // This is not the best method to locating the files
            // But it works in test mode
            string _custFilePath = "../../../Data/customers.csv";
            string _invFilePath = "../../../Data/inventory.csv";
            string _filePath;

            // Short circuit to 'customers'
            _filePath = _custFilePath;
            /*
            // If the input is not 'customers' then assume 'inventory'
            if(fileName == "customers") _filePath = _custFilePath;
            else _filePath = _invFilePath;
            */

            Console.WriteLine($"File selected {_filePath}");

            // Specify the configuration for CsvReader
            // CultureInfo.InvariantCulture is the most portable for reading and writing  a file
            CsvConfiguration _csvConfig = new(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };

            // Specify the StreamReader using the selected file path and create the csvReader
            using (StreamReader _reader = new(_filePath))
            using (CsvReader _csv = new(_reader, _csvConfig))
            {
                // Register the class map to properly assign the csv data to the object
                _csv.Context.RegisterClassMap<CustomerMap>();
                var records = _csv.GetRecords<Customer>();

                foreach (var record in records)
                {
                    
                    Customer.Customers.Add(record.id, record);
                }
                Console.WriteLine($"Customers {Customer.Customers.Count}");
            }
        }

        /// <summary>
        /// Class to map customers.csv into customer objects
        /// </summary>
        public class CustomerMap : ClassMap<Customer>
        {
            /// <summary>
            /// Constructor
            /// </summary>
            public CustomerMap()
            {
                Map(m => m.id).Name("id");
                Map(m => m.accountType).Name("account_type");
                Map(m => m.firstName).Name("first_name");
                Map(m => m.lastName).Name("last_name");
                Map(m => m.currentVideoRentals).Name("current_video_rentals");
            }
        }

    }
}
