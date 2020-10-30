using System;
namespace LoggingKata
{
    public class TacoBell : ITrackable


    {
        //prop tab for properties short cut
        //public object MyProperty { get; set; }

        // Then, you'll need an instance of the TacoBell class
        // With the name and point set correctly

        public string Name { get; set; }

        public Point Location { get; set; }

        public TacoBell()
        {

        }
    }
}