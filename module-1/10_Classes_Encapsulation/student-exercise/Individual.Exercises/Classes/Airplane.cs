namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        //-----VARIABLES------------------------------------------------------------------------------------------------

        //-----PROPERTIES-----------------------------------------------------------------------------------------------
        public string PlaneNumber { get; }
        public int TotalFirstClassSeats { get; }
        public int BookedFirstClassSeats { get; private set; }
        public int AvailableFirstClassSeats
        {
            get
            {
                return TotalFirstClassSeats - BookedFirstClassSeats;
            }
        }
        public int TotalCoachSeats { get; }
        public int BookedCoachSeats { get; private set; }
        public int AvailableCoachSeats
        {
            get
            {
                return TotalCoachSeats - BookedCoachSeats;
            }
        }
        //-----CONSTRUCTORS---------------------------------------------------------------------------------------------

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            this.TotalCoachSeats = totalCoachSeats;
        }

        //-----METHODS--------------------------------------------------------------------------------------------------

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if ((totalNumberOfSeats <= AvailableFirstClassSeats) && (forFirstClass == true))
            {
                BookedFirstClassSeats += totalNumberOfSeats;
                return true;
            }
            else if ((totalNumberOfSeats <= AvailableCoachSeats) && (forFirstClass == false))
            {
                BookedCoachSeats += totalNumberOfSeats;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

