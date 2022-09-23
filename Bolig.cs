// this class has all the private fields and properties (with get and set) for all bolig types.
namespace Bolig
{
    public class Bolig
    {
        private string property_type;
        private int sqmeter;
        private int price;
        private int number_of_rooms;
        private int number_of_baths;

        public string PropertyType
        {
            get { return property_type; }
            set
            {
                if (value != null) property_type = value;
                else Console.WriteLine("The type of the property is either villa/rækkehus/lejlighed(V/R/L).");

            }
        }

        public int Sqmeter
        {
            get { return sqmeter; }
            set {
                if (value != null ) sqmeter = value;
                else Console.WriteLine("The size of the property cannot be null.");

                }
        }
        public int Price
        {
            get { return price; }
            set {
                if (value != 0) price = value;
                else Console.WriteLine("The price of the property cannot be null.");
                }
        }

        
        public int NumberOfRooms
        {
            get { return number_of_rooms; }
            set {
                if (value != 0) number_of_rooms = value;
                else Console.WriteLine("The number of rooms in the property cannot be null.");
                } 
        }

        public int NumberOfBaths
        {
            get { return number_of_baths; }
            set {
                if (value != 0) number_of_baths = value;
                else Console.WriteLine("The number of baths in the property cannot be null.");
                }
        }

        
        
        
    }
    
}

