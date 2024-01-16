using schachbibiliothek.Figuren;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schachbibiliothek
{ 
    internal class Bishop : Piece
{
    public override pieceType Type => pieceType.Bishop;
    public override player Color { get; }
    public Bishop(player Color)
    {
        Color = Color;
    }
    public override Piece Copy()
    {
        Bishop copy = new Bishop(Color);
        copy.Hasmoved = Hasmoved;
        return copy;
    }
}
}
