using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schachbibiliothek
{
    internal class Gamestate
    {
        public Board Board { get;}
        public player Currentplayer { get; private set;}
        public Gamestate(player player,Board board)
        {
            Currentplayer = player;
            Board = board;
        }
    }
}
