using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schachbibiliothek.Figuren
{

        internal class King : Piece
        {
            public override pieceType Type => pieceType.King;
            public override player Color { get; }
            public King(player Color)
            {
                Color = Color;
            }
            public override Piece Copy()
            {
                King copy = new King(Color);
                copy.Hasmoved = Hasmoved;
                return copy;
            }
        }
    }


