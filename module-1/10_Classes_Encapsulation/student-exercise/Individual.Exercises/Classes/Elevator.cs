namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        //-----VARIABLES------------------------------------------------------------------------------------------------

        //-----PROPERTIES-----------------------------------------------------------------------------------------------
        public int CurrentLevel { get; private set; }
        public int NumberOfLevels { get; }
        public bool DoorIsOpen { get; private set; }
        //-----CONSTRUCTORS---------------------------------------------------------------------------------------------

        public Elevator (int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;
            CurrentLevel = 1;
        }

        //-----METHODS--------------------------------------------------------------------------------------------------

        public void OpenDoor()
        {
            DoorIsOpen = true;
        }

        public void CloseDoor()
        {
            DoorIsOpen = false;
        }

        public void GoUp(int desiredFloor)
        {
            if (DoorIsOpen == false && (desiredFloor > 0 && desiredFloor <= NumberOfLevels) && CurrentLevel < desiredFloor)
            {
                CurrentLevel = desiredFloor;
            }
        }

        public void GoDown(int desiredFloor)
        {
            if (DoorIsOpen == false && (desiredFloor > 0 && desiredFloor <= NumberOfLevels) && CurrentLevel > desiredFloor)
            {
                CurrentLevel = desiredFloor;
            }
        }

    }

}
