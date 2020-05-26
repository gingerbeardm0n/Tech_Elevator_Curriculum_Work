namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        //-----VARIABLES----------------------------------------------------------------------
        

        //------PROPERTIES-------------------------------------------------------------------

        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; }
        public string SubmitterName { get; }
        public string LetterGrade
        {
            get
            {
                double dubsEarned = (double)EarnedMarks;
                double dubsPossible = (double)PossibleMarks;
                double dubsGrade = EarnedMarks / PossibleMarks;
                int grade = (int)dubsGrade;

                if (EarnedMarks >= 90 && EarnedMarks <= 100)
                {
                    return "A";
                }
                else if (EarnedMarks >= 80 && EarnedMarks <= 89)
                {
                    return "B";
                }
                else if (EarnedMarks >= 70 && EarnedMarks <= 79)
                {
                    return "C";
                }
                else if (EarnedMarks >= 60 && EarnedMarks <= 69)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }

        //--------CONSTRUCTORS-----------------------------------------------------------------

        }
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            this.PossibleMarks = possibleMarks;
            this.SubmitterName = submitterName;
        }

        //--------METHODS----------------------------------------------------------------------

    }
}



