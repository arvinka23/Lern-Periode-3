using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schachbibiliothek.Figuren
{
    internal class Queen : Piece
    {
        public override pieceType Type => pieceType.Queen;
        public override player Color { get; }
        public Queen(player Color)
        {
            Color = Color;
        }
        public override Piece Copy()
        {
            Queen copy = new Queen(Color);
            copy.Hasmoved = Hasmoved;
            return copy;
        }
    }
}

