namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                logger.LogError("our array.Length is less than 3, something went wrong");

                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0
            var latitude = double.Parse(cells[0]);


            // grab the longitude from your array at index 1

            var longitude = double.Parse(cells[1]);
            // grab the name from your array at index 2

            var name = cells[2];

            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`

            // You'll need to create a TacoBell class
            // that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class
            // -->create a TacoBell.cs class (new class file)
            // With the name and point set correctly
            // -->create NAME and POINT properties inside TacoBell class file


            TacoBell theTacoBell = new TacoBell();

            theTacoBell.Name = name;

            var point = new Point();

            point.Latitude = latitude;
            point.Longitude = longitude;

            theTacoBell.Location = point;





            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable

            return theTacoBell;

            //return null;
        }
    }
}