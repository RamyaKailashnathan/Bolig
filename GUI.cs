
namespace Bolig
{
    // GUI class-Take all the inputs from the user

    internal class GUI
    {
        Bolig bolig = new();
        Lejlighed lejlighed = new();
        
        Villa villa = new();
        
       public GUI()
        {
            string ans;
            do
            {
                Create_Bolig();
                ShowData();
                Console.Write("Would you like to repeat?(Y/N)");
                ans = Console.ReadLine();

            } while (ans == "y") ;

        }
       
        #region getdata
        //Data input for Villa,Rækkehus and Lejlighed
        private string GetType()
        {
            //Checking if the type of the property is not null
           
                Console.Write("Enter the property type(V for villa/L for lejlighed/R for rækkehus): ");
            bolig.PropertyType = Console.ReadLine();                
      
            return bolig.PropertyType;
        }

        //Applicable for Villa,Rækkehus and Lejlighed
        private void GetSqm()
        {
            //Checking if the square meter(area) of the property is not null
            do
            {
                Console.Write("Enter the square meter of the property: ");
                bolig.Sqmeter = Convert.ToInt16(Console.ReadLine());
            }
            while (bolig.Sqmeter == 0);
        }
        //Applicable for Villa,Rækkehus and Lejlighed
        private void GetPrice()
        {
            //Checking if the price of the property is not null
            do
            {
                Console.Write("Enter the price of the property: ");
                bolig.Price = Convert.ToInt32(Console.ReadLine());
            }
            while (bolig.Price == 0);
        }
        //Applicable for Villa,Rækkehus and Lejlighed
        private void GetNumberOfRooms()
        {
            //Checking if the number of rooms in the property is not null
            do
            {
                Console.Write("Enter the number of rooms in this property: ");

                bolig.NumberOfRooms = Convert.ToInt16(Console.ReadLine());
            }
            while (bolig.NumberOfRooms == 0);
            
        }
        //Applicable for Villa,Rækkehus and Lejlighed
        private void GetNumberOfBaths()
        {
            //Checking if the number of bathrooms in the property is not null
            do
            {
                Console.Write("Enter the number of bathrooms in this property: ");
                bolig.NumberOfBaths = Convert.ToInt16(Console.ReadLine());
            }
            while (bolig.NumberOfBaths == 0);
        }

        //Applicable for only Lejlighed
        private string Get_TH_Or_TV(string th_tv)
        {
            //Checking if the lejlighed is TV or TH
           
                Console.Write("Enter if the lejlighed is either TV or TH : ");
                lejlighed.TH_Or_TV= Console.ReadLine();
            return lejlighed.TH_Or_TV;
        }
        //Applicable for only Lejlighed
        private int Get_OnWhichFloor(int floor_number)
        {
            //Checking which floor the lejlighed is located
            
                Console.Write("Enter the floor on which the lejlighed is located : ");
                lejlighed.OnWhichFloor = Convert.ToInt16(Console.ReadLine());
            return lejlighed.OnWhichFloor;
        }

        //Applicable for Rækkehus
        private int Get_HowManyFloors(int total_count_of_floors)
        {
            //Taking the input for the total count of floors in the property

            Console.Write("Enter the number of floors : ");
            villa.NumberOfFloors  = Convert.ToInt16(Console.ReadLine());
            return villa.NumberOfFloors;
        }
        //Applicable for Rækkehus
        private bool Get_Basement()
        {
            //Taking the input if the basement exists or not

            Console.Write("Enter if there is basement(true/false) : ");
            villa.Basement  = Convert.ToBoolean(Console.ReadLine());
            return villa.Basement;
        }
        //Applicable for Rækkehus
        private bool Get_Carpark()
        {
            //Taking the input if the carpark exists or not

            Console.Write("Enter if there is carpark(true/false) : ");
            villa.CarPark = Convert.ToBoolean(Console.ReadLine());

            return villa.CarPark;
        }
        //Applicable for Villa
        private bool Get_Backyard()
        {
            //Taking the input if the Backyard exists or not

            Console.Write("Enter if there is backyard(true/false) : ");
            villa.Backyard = Convert.ToBoolean(Console.ReadLine());
            return villa.Backyard;
        }
        #endregion
        public void Create_Bolig()
        {
            //CreateBolig method creates a new bolig with sq.m,price and Number of rooms
            //We get input thru the methods(GetType,GetSqm,GetPrice,GetNumberOfRooms,GetNumberOfBaths)
            //The values are added to the private fields mentioned in the properties in the Bolig class.

            Console.WriteLine("Bolig Data Entry");
            
            bolig.PropertyType=GetType();
            GetSqm();
            GetPrice();
            GetNumberOfRooms();
            GetNumberOfBaths();


            //This case  will work only if the type of the bolig is lejlighed
            //check if the lejlighed is tv or th and store the value in the property TH_Or_TV
            switch (bolig.PropertyType)
            {
                case ("l"):
                    {


                        if (Get_TH_Or_TV("tv") == "tv")
                        {
                            lejlighed.TH_Or_TV = "tv";
                        }
                        else
                        {
                            lejlighed.TH_Or_TV = "th";
                        }
                        //Get the next input for the lejighed asking the user to enter the floor number
                        Get_OnWhichFloor(lejlighed.OnWhichFloor);
                        break;
                    }

                //This case  will work only if the type of the bolig is Rækkehus
                //Take input for number of floors,if there is a basement and if there is a carpark in the rækkehus
                case ("r"):
                    
                    {
                     if (Get_Basement() == true)
                          villa.Basement = true;        
                     else
                          villa.Basement = false;
              
                    //Get the next input for the rækkehus asking the user to enter number of floors
                    Get_HowManyFloors(villa.NumberOfFloors);

                    //Get the next input for the rækkehus asking the user to enter if the basement exists or not
                     if (Get_Carpark() == true)
                        villa.CarPark = true;
                    else
                         villa.CarPark = false;
                        break;
                    }
                //This case will work only if the type of the bolig is villa
                //check if the villa has a backyard or not
                case ("v"):
                    {
                        Get_HowManyFloors(villa.NumberOfFloors);

                        if (Get_Basement() == true)
                            villa.Basement = true;
                        else
                            villa.Basement = false;

                        if (Get_Backyard() == true)
                            villa.Backyard = true;
                        else
                            villa.Backyard = false;

                        if (Get_Carpark() == true)
                            villa.CarPark = true;
                        else
                            villa.CarPark = false;
                        break;
                    }
            }
           
        }

       

        public void ShowData()
        {
           
            Console.WriteLine("BOLIG PORTAL");
            string type="";
            if (bolig.PropertyType == "v") type = "Villa";
            else if (bolig.PropertyType == "r") type = "Rækkehus";
            else if (bolig.PropertyType == "v") type = "Lejlighed";
            Console.WriteLine("This property is a : {0} ",type);
            
            Console.WriteLine("The {0} is priced at {1} kr.",type,bolig.Price);
            Console.WriteLine("The {0} has {1}  rooms.",type,bolig.NumberOfRooms);
            Console.WriteLine("The {0} has {1} baths.",type,bolig.NumberOfBaths);

            Console.WriteLine("The {0} is {1} sq.meter",type,bolig.Sqmeter);
            switch(bolig.PropertyType)
            {
                case ("l"):
                {
                    Console.WriteLine("The lejlighed is on the {0} ", lejlighed.OnWhichFloor, " floor.");
                    Console.WriteLine("The lejlighed is {0} ", lejlighed.TH_Or_TV);
                    break;
                }
                case ("v"):
                {
                        Console.WriteLine("The villa has {0} ", villa.NumberOfFloors, " floors.");

                        if(villa.Basement== true) Console.WriteLine("The villa has a basement. ");
                        else Console.WriteLine("The villa does not have a basement. ");

                        if (villa.CarPark == true) Console.WriteLine("The villa has a carpark. ");
                        else Console.WriteLine("The villa does not have a carpark. ");

                        if (villa.Backyard == true) Console.WriteLine("The villa has a backyard. ");
                        else Console.WriteLine("The villa does not have a backyard. ");
                        break;
                }
                case ("r"):// as Rækkehus class is abstract, it cannot be instantiated and we will be using villa which is derived from the Rækkehus class
                    {
                        Console.WriteLine("The rækkehus has {0} ", villa.NumberOfFloors, " floors.");

                        if (villa.Basement == true) Console.WriteLine("The rækkehus has a basement. ");
                        else Console.WriteLine("The rækkehus does not have a basement. ");

                        if (villa.CarPark == true) Console.WriteLine("The ræækehus has a carpark. ");
                        else Console.WriteLine("The ræækehus does not have a carpark. ");
                        break;
                    }
            }
                

        }

    }
}

