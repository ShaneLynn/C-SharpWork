//Christopher S Lynn
//CISS 201
//Agile Software Development
//Programming Challenge 5.1 pg 125
//Assignment Date: 02/11/2021

using System;


namespace dropbox08
{
    class CollegeStudent
    {
        //Setup the variable fields to hold the data.  Setting as private to avoid outside class editing.
        private string studentName;

        private int homeWork;
        private int midTerm1;
        private int midTerm2;
        private int finalExam;

        //Properties - Setup the public properties so the variables can be called and adjusted outside the class
        //This property adjusts the student name provided by the constructor
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        //This added property adjusts the homework score provided by the constructor
        public int HomeWork
        {
            get { return homeWork; }
            set { homeWork = value; }
        }
        //This added property adjusts the first midterm score provided by the constructor
        public int MidTerm1
        {
            get { return midTerm1; }
            set { midTerm1 = value; }
        }
        //This added property adjusts the second midterm score provided by the constructor
        public int MidTerm2
        {
            get { return midTerm2; }
            set { midTerm2 = value; }
        }
        //This added property adjusts the final exam score provided by the constructor
        public int FinalExam
        {
            get { return finalExam; }
            set { finalExam = value; }
        }
        //Setup the default onstructor for the class that accepts and stores 5 inputs
        public CollegeStudent(string studentName, int homeWork, int midTerm1, int midTerm2, int finalExam)
        {
            this.studentName = studentName;
            this.homeWork = homeWork;
            this.midTerm1 = midTerm1;
            this.midTerm2 = midTerm2;
            this.finalExam = finalExam;
        }
        //Methods - Setup the methods that calculate the field variables and return the student's final scores
       
        //This method calculates the final semester score based on the percentage weight of each activity
        //And, with homeworked added in, adjusted the weight from midterm1 and 2 to .2 (was .3) to compensate
        public double SemesterScore()
        {
            double score;
            score = Math.Round((0.2 * HomeWork + 0.2 * MidTerm1 + 0.2 * MidTerm2 + 0.4 * FinalExam), MidpointRounding.AwayFromZero);
            return score;
        }
        //This method takes the calculated score from SemesterScore() and assigns the corresponding letter grade
        public char SemesterGrade()
        {
            char grade = 'X';
            double finalScore = SemesterScore();

            if (finalScore >= 90)
                grade = 'A';
            else if (finalScore >= 80)
                grade = 'B';
            else if (finalScore >= 70)
                grade = 'C';
            else if (finalScore >= 60)
                grade = 'D';
            else
                grade = 'F';

            return grade;
        }

        //This method overrides the default string return and formats a specific output for each student and their grades
        public override string ToString()
        {
            string display;
            display = string.Format("Student Name: {0} | Semester Score: {1} | Semester grade: {2}", StudentName, SemesterScore(), SemesterGrade());
            return display;
        }

    }
}
