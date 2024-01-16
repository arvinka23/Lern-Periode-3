using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schachbibiliothek.Figuren
{
    internal class knight : Piece
    {
        public override pieceType Type => pieceType.Knight;
        public override player Color { get; }
        public knight(player Color)
        {
            Color = Color;
        }
        public override Piece Copy()
        {
            knight copy = new knight(Color);
            copy.Hasmoved = Hasmoved;
            return copy;
        }
    }
}