//Christopher S Lynn
//CISS 201
//Agile Software Development
//Programming Example 5.3 pg 128-137
//Assignment Date: 02/11/2021

namespace dropbox09
{
    class Player
    {
        //Setup the variable fields used by the class to store data
        private CellValue playerName;
        private int selectedRow;
        private int selectedColumn;

        //Setup the property fields to allow to the program to input and retrieve the values
        public CellValue PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public int SelectedRow
        {
            get { return selectedRow; }
            set { selectedRow = value; }
        }

        public int Column
        {
            get { return selectedColumn; }
            set { selectedColumn = value; }
        }
        //Setup the constructor to receive values for the player
        public Player(int selectedRow, int selectedColumn, CellValue playerName)
        {
            //Process the values received on the right and store in the field variables on the left
            this.selectedRow = selectedRow;
            this.selectedColumn = selectedColumn;
            this.playerName = playerName;
        }

        //Methods
        //This method updates the board with the player's move information
        public void PlayerMove(Board board)
        {
            board.AllCells[SelectedRow, selectedColumn] = PlayerName;
        }

        
        //This method checks winning conditions
        public bool IsPlayerWin(Board board)
        {
            bool wins = false;
            
            //Checks horizontal 
            if (board.AllCells[0, 0] != CellValue.E &&
                board.AllCells[0, 0] == board.AllCells[1, 1] &&
                board.AllCells[1, 1] == board.AllCells[2, 2])

            {
                wins = true;
            }
            //Checks diagnal
            if (board.AllCells[0, 2] != CellValue.E &&
                board.AllCells[0, 2] == board.AllCells[1, 1] &&
                board.AllCells[1, 1] == board.AllCells[2, 0])

            {
                wins = true;
            }
            //Use a for loop to step through each row to check for win conditions in all directions
            for (int r = 0; r < 3; r++)
            {
                if (board.AllCells[r, 0] != CellValue.E &&
                    board.AllCells[r, 0] == board.AllCells[r, 1] &&
                    board.AllCells[r, 1] == board.AllCells[r, 2])
                {
                    wins = true;
                }

            }
            //Use a for loop to step through each column to check for win conditions in all directions
            for (int c = 0; c < 3; c++)
            {
                if (board.AllCells[0, c] != CellValue.E &&
                    board.AllCells[0, c] == board.AllCells[1, c] &&
                    board.AllCells[1, c] == board.AllCells[2, c])
                {
                    wins = true;
                }
            }
            return wins;       
        }

        


    }
}
