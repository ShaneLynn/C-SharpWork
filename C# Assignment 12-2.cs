//Christopher S Lynn
//CISS 201
//Agile Software Development
//Programming Example 7.2 pg 199
//Assignment Date: 02/23/2021

namespace dropbox12
{
    class LetterGrade
    {
        //Setup a private field variable to hold the student's score
        private double studentScore;

        //Setup a property to access/update the values 
        public double StudentScore
        {
            get { return studentScore; }
            set { studentScore = value; }
        }

        //Create the constructor to collect a student's score
        public LetterGrade(double studentScore)
        {
            this.studentScore = studentScore;
        }

        //This method compares the exam score and assigns the corresponding letter grade
        public string FinalGrade()
        {
            string grade = "X";
            
            if (studentScore >= 97)
                grade = "A+";
            else if (studentScore >= 93)
                grade = "A";
            else if (studentScore >= 90)
                grade = "A-";
            else if (studentScore >= 86)
                grade = "B+";
            else if (studentScore >= 83)
                grade = "B";
            else if (studentScore >= 80)
                grade = "B-";
            else if (studentScore >= 76)
                grade = "C+";
            else if (studentScore >= 73)
                grade = "C";
            else if (studentScore >= 70)
                grade = "C-";
            else if (studentScore >= 65)
                grade = "D";
            else
                grade = "F";

            return grade;
        }
    }
}
