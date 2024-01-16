using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schachbibiliothek
{
     public abstract class Piece
    {

        public abstract pieceType Type { get; }
        public abstract player Color { get; }
        public bool Hasmoved { get; set; } = false;

        public abstract Piece Copy();
    }
}
