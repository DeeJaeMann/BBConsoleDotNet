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

        }
    }
}
