namespace Individual.Exercises.Classes
{
    public class Television
    {
        //-----VARIABLES------------------------------------------------------------------------------------------------

        //-----PROPERTIES-----------------------------------------------------------------------------------------------

        public bool IsOn { get; private set; }
        public int CurrentChannel { get; private set; }
        public int CurrentVolume { get; private set; }


        //-----CONSTRUCTORS---------------------------------------------------------------------------------------------

        public Television()
        {
            IsOn = false;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }

        //-----METHODS--------------------------------------------------------------------------------------------------

        public void TurnOff()
        {
            IsOn = false;
        }
        public void TurnOn()
        {
            IsOn = true;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }
        public void ChangeChannel(int newChannel)
        {
            if ((IsOn == true) && (newChannel > 2 && newChannel < 19))
            {
                CurrentChannel = newChannel;
            }

        }
        public void ChannelUp()
        {
            if(IsOn == true)
            {
                if (CurrentChannel == 18)
                {
                    CurrentChannel = 3;
                }
                else
                {
                    CurrentChannel += 1;
                }
            }
        }
        public void ChannelDown()
        {
            if (IsOn == true)
            {
                if (CurrentChannel == 3)
                {
                    CurrentChannel = 18;
                }
                else
                {
                    CurrentChannel -= 1;
                }
            }
        }
        public void RaiseVolume()
        {
            if (IsOn == true)
            {
                if (CurrentVolume == 10)
                {
                    CurrentVolume = 10;
                }
                else
                {
                    CurrentVolume += 1;
                }
            }
        }
        public void LowerVolume()
        {
            if (IsOn == true)
            {
                if (CurrentVolume == 0)
                {
                    CurrentVolume = 0;
                }
                else
                {
                    CurrentVolume -= 1;
                }
            }

        }

    }
}
