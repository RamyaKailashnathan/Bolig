
namespace Bolig
{

    //Rækkehus is a abstract class and it gives a blueprint for villa class.Rækkehus class cannot be instantiated so we will use the villa instantiation for rækkehus.

    public abstract class Rækkehus : Bolig
    {
        private int number_of_floors;
        private bool basement;
        private bool carpark;

        public int NumberOfFloors
        {
            get { return number_of_floors; }
            set
            {
                if (value != 0) number_of_floors = value;
                else Console.WriteLine("This property should have a valid number of floors.");

            }
        }
        public bool Basement
        {
            get { return basement; }
            set
            {
                if (value != true) basement = value;
                else Console.WriteLine("This property does not have basement.");

            }
        }
        public bool CarPark
        {
            get { return carpark; }
            set
            {
                if (value != true) carpark = value;
                else Console.WriteLine("This property does not have a carpark.");

            }
        }
    }
}

