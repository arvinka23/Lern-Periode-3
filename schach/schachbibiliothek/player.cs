using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schachbibiliothek
{
    public enum player
    {
        none,
        white,
        black
    }
    public static class playerextensions
    {
        public static player opponent(this player player)
        {
            return player switch
            {
                player.white => player.black,
                player.black => player.white,
                _ => player.none,
            };
        }
    }


}
