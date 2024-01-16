using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schachbibiliothek.Figuren
{
    internal class Pawn : Piece
    {
        public override pieceType Type => pieceType.Pawn;
        public override player Color { get ;}
        public Pawn(player Color)
        {
            Color = Color;
        }

        public override Piece Copy()
        {
            Pawn copy = new Pawn(Color);
            copy.Hasmoved = Hasmoved;
            return copy;
        }
    }
}