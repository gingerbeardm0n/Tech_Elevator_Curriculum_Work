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
        { get
            {
                double dubsEarned = (double)EarnedMarks;
                double dubsPossible = (double)PossibleMarks;
                double dubsGrade = EarnedMarks / PossibleMarks;
                int grade = (int)dubsGrade;
                
                if (grade >= 90 && grade <= 100)
                {
                    return "A";
                }
                else if (grade >= 80 && grade <= 89)
                {
                    return "B";
                }
                else if (grade >= 70 && grade <= 79)
                {
                    return "C";
                }
                else if (grade >= 60 && grade <= 69)
                {
                    return "D";
                }
                else 
                {
                    return "F";
                }


            }
           

        //--------CONSTRUCTORS-----------------------------------------------------------------



        //--------METHODS----------------------------------------------------------------------


    }
}
