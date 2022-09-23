
namespace Bolig
{
    // Inheriting all private fields and properties from Bolig class and in addition having two more fields and properties applicable to Lejlighed
    // class
    // Lejlighed class is a sealed class as we do not want it to be instantiated further.

    public sealed class Lejlighed:Bolig
    {
        private int onwhichfloor;
        private string th_eller_tv;

        public int OnWhichFloor
        {
            get { return onwhichfloor; }
            set
            {
                if (value != 0) onwhichfloor = value;
                else Console.WriteLine("This lejlighed should be on stue or a valid floor.");

            }
        }
        public string TH_Or_TV
        {
            get { return th_eller_tv; }
            set
            {
                if (value != null) th_eller_tv = value;
                else Console.WriteLine("This lejlighed should be on TH or TV.");

            }
        }

    }
}

