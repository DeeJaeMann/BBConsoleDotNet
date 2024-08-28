
namespace Classes
{
    /// <summary>
    /// Base Video Class
    /// </summary>
    public class Video
    {
        // Initialize a static Dictionary for all Videos
        public static Dictionary<int, object> Videos = [];

        // Fields
        int _id;
        string _title;
        string _rating;
        int _copiesAvailable;
        public int releaseYear;

        /// <summary>
        /// Video ID Property
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Video Title Property
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        /// <summary>
        /// Video Rating Property
        /// </summary>
        public string Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        /// <summary>
        /// Video Copies Available Property
        /// </summary>
        public int CopiesAvailable
        {
            get { return _copiesAvailable; }
            set { _copiesAvailable = value; }
        }


    }
}
