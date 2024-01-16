using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schachbibiliothek.Figuren
{
    

        internal class Rock : Piece
        {
            public override pieceType Type => pieceType.Rock;
            public override player Color { get; }
            public Rock(player Color)
            {
                Color = Color;
            }
            public override Piece Copy()
            {
                Rock copy = new Rock(Color);
                copy.Hasmoved = Hasmoved;
                return copy;
            }
        }
    }


