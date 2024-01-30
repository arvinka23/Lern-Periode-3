using System;

class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int currentPlayer = 1;
    static int choice;
    static int flag = 0;

    static void Main()
    {
        do
        {
            Console.Clear(); 
            Console.WriteLine("Player 1: X and Player 2: O");
            Console.WriteLine("\n");

            Console.WriteLine("Turn Player {0}", currentPlayer);
            Console.WriteLine("\n");
            Board();

            // Check if the selected position is already marked//
            bool validInput = false;
            do
            {
                string input = Console.ReadLine();
                validInput = Int32.TryParse(input, out choice);

                if (!validInput || choice < 1 || choice > 9 || board[choice - 1] == 'X' || board[choice - 1] == 'O')
                {
                    Console.WriteLine("Please enter a valid number from 1 to 9");
                    validInput = false;
                }

            } while (!validInput);

            // Mark the position with X or O
            char playerSymbol = (currentPlayer == 1) ? 'X' : 'O';
            board[choice - 1] = playerSymbol;

            flag = CheckWin();
            currentPlayer = (currentPlayer == 1) ? 2 : 1; // Switch player
        }
        while (flag != 1 && flag != -1);

        Console.Clear();
        Board();

        if (flag == 1)
        {
            Console.WriteLine("Player {0} has won!", (currentPlayer == 1) ? 2 : 1);
        }
        else
        {
            Console.WriteLine("It's a draw!");
        }

        Console.ReadLine();
    }

    private static void Board()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
        Console.WriteLine("     |     |      ");
    }

    private static int CheckWin()
    {
        #region Horzontal Winning Condtion
        // Winning Condition For First Row
        if (board[0] == board[1] && board[1] == board[2])
        {
            return 1;
        }
        // Winning Condition For Second Row
        else if (board[3] == board[4] && board[4] == board[5])
        {
            return 1;
        }
        // Winning Condition For Third Row
        else if (board[6] == board[7] && board[7] == board[8])
        {
            return 1;
        }
        #endregion

        #region Vertical Winning Condtion
        // Winning Condition For First Column
        else if (board[0] == board[3] && board[3] == board[6])
        {
            return 1;
        }
        // Winning Condition For Second Column
        else if (board[1] == board[4] && board[4] == board[7])
        {
            return 1;
        }
        // Winning Condition For Third Column
        else if (board[2] == board[5] && board[5] == board[8])
        {
            return 1;
        }
        #endregion

        #region Diagonal Winning Condtion
        else if (board[0] == board[4] && board[4] == board[8])
        {
            return 1;
        }
        else if (board[2] == board[4] && board[4] == board[6])
        {
            return 1;
        }
        #endregion

        #region Checking For Tie
       
        else if (board[0] != '1' && board[1] != '2' && board[2] != '3' && board[3] != '4' && board[4] != '5' && board[5] != '6' && board[6] != '7' && board[7] != '8' && board[8] != '9')
        {
            return -1;
        }
        #endregion

        else
        {
            return 0;
        }
    }
}
