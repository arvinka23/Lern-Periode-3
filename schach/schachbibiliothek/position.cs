namespace schachbibiliothek
{
    public class position
    {
        public int Row { get; }
        public int Column { get; }

        public position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public position()
        {
        }

        public player squarecolour()
        {
            if ((Row + Column) % 2 == 0)
            {
                return player.white;
            }

            return player.black;
        }

        public override bool Equals(object obj)
        {
            return obj is position position &&
                   Row == position.Row &&
                   Column == position.Column;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }

        public static bool operator ==(position left, position right)
        {
            return EqualityComparer<position>.Default.Equals(left, right);
        }

        public static bool operator !=(position left, position right)
        {
            return !(left == right);
        }
        public static position operator +(position pos, Direction dir)
        {
            return new position(pos.Row + dir.RowDelta , pos.Column + dir.Columndelta);
        }
    }
}
