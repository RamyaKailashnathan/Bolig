
namespace Bolig
{
    public class Villa : Rækkehus
    {
        
        private bool backyard;
        public bool Backyard {
            get { return backyard; }
            set
            {
                if (value != false) backyard = value;
                else Console.WriteLine("This property does not have a backyard.");

            }
        }
       
    }
}

