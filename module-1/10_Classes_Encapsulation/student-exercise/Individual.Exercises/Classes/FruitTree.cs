namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        //-----VARIABLES------------------------------------------------------------------------------------------------
        //int startingPiecesOfFruit = 0;
        //int numberOfPiecesToRemove = 0;

        //-----PROPERTIES-----------------------------------------------------------------------------------------------

        public string TypeOfFruit { get; }
        public int PiecesOfFruitLeft { get; private set; }
        //public int StartingPiecesOfFruit { get; set; }

        //-----CONSTRUCTORS---------------------------------------------------------------------------------------------

        public FruitTree (string typeOfFruit, int startingPiecesOfFruit)
        {
            this.TypeOfFruit = typeOfFruit;
            this.PiecesOfFruitLeft = startingPiecesOfFruit;
        }

        //-----METHODS--------------------------------------------------------------------------------------------------

        public bool PickFruit (int numberOfPiecesToRemove)
        {
            int startingFruit = PiecesOfFruitLeft;

            if (PiecesOfFruitLeft > numberOfPiecesToRemove)
            {
                PiecesOfFruitLeft = PiecesOfFruitLeft - numberOfPiecesToRemove;
                return true;
            }
            else
            {
                return false;
            }

            

        }
    }
}
