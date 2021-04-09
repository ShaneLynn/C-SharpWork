//Christopher S Lynn
//CISS 201
//Agile Software Development
//Programming Example 5.3 pg 128-137
//Assignment Date: 02/11/2021

namespace dropbox09
{
    //Create a new enumerated (programmer defined) data type for the player names and board display
    public enum CellValue { E, X, O}


    class Board
    {
        //Create an array to hold the values for the board position
        private CellValue[ , ] allCells;

        //Setup the property needed for the program to access and update the array.
        public CellValue[ , ] AllCells
        {
            get { return allCells; }
            set { allCells = value; }
        }

        //Setup the default constructor for the class
        public Board()
        {
            allCells = new CellValue[3, 3];
        }

        //Methods
        //This method uses a loop to check the array values to see if the board is full
        public bool HasNoMoreE()
        {
            bool noMoreE = true;
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (allCells[r, c] == CellValue.E)
                        noMoreE = false;
                }
            }
            return noMoreE;
        }

        //This method displays the current board status to the player
        public override string ToString()
        {
            string str;
            str = " \n" +
                    "\n====================\n" +
                  AllCells[0, 0] + " | " + AllCells[0, 1] + " | " + AllCells[0, 2] +
                    "\n----------\n" +
                  AllCells[1, 0] + " | " + AllCells[1, 1] + " | " + AllCells[1, 2] +
                    "\n----------\n" +
                  AllCells[2, 0] + " | " + AllCells[2, 1] + " | " + AllCells[2, 2] +
                  "\n====================\n";

            return str;


        }
    }
}
