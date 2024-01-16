using schachbibiliothek.Figuren;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace schachbibiliothek
{
    internal class Board
    {
        private readonly Piece[,] pieces = new Piece[8, 8];

        public Piece this[int row, int col]
        { 
            get { return pieces[row, col];} 
            set { pieces[row, col] = value;}
        }
        public Piece this[position pos]
        {
            get { return this[pos.Row, pos.Column]; }
            set { this[pos.Row, pos.Column] = value;}
            
        }
        public static Board Initial()
        {
            Board board = new Board();
            board.addStartPieces();
            return board;
        }
        private void addStartPieces()
        {
            this[0, 0] = new Rock(player.black);
            this[0, 1] = new knight(player.black);
            this[0, 2] = new Bishop(player.black);
            this[0, 3] = new Queen(player.black);
            this[0, 4] = new King(player.black);
            this[0, 5] = new Bishop(player.black);
            this[0, 6] = new knight(player.black);
            this[0, 7] = new Rock(player.black);


            this[7, 0] = new Rock(player.white);
            this[7, 1] = new knight(player.white);
            this[7, 2] = new Bishop(player.white);
            this[7, 3] = new Queen(player.white);
            this[7, 4] = new King(player.white);
            this[7, 5] = new Bishop(player.white);
            this[7, 6] = new knight(player.white);
            this[7, 7] = new Rock(player.white);

            for (int c = 0; c < 8; c++)
            {
                this[1,c] = new Pawn(player.black);
                this[6,c] = new Pawn(player.white);
            }
         
        }
        public static bool isinside(position pos)
        {
            return pos.Row >= 0 && pos.Row < 8 && pos.Column >= 0 && pos.Column < 8;
        }
        public bool isempty(position pos)
        {
            return this[pos] == null;

        }
    }
}
