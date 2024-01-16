namespace schachbibiliothek
{
    public class Direction
    {
        public readonly static Direction North = new Direction(-1, 0);
        public readonly static Direction South = new Direction(1, 0);
        public readonly static Direction East = new Direction(0, 1);
        public readonly static Direction West = new Direction(0, -1);
        public readonly static Direction Northwest = North + West;
        public readonly static Direction NorthEast = North + East;
        public readonly static Direction Southwest = South + West;
        public readonly static Direction Southeast = South + East;


        public int RowDelta { get; }
        public int Columndelta { get; }

        public Direction (int rowDelta, int columnDelta)
        {
            RowDelta = rowDelta;
            Columndelta = columnDelta;
        }

        public static Direction operator +(Direction dir1, Direction dir2)
        {
            return new Direction(dir1.RowDelta + dir2.RowDelta, dir1.Columndelta + dir2.Columndelta);
        }
        public static Direction operator *(int scalar , Direction dir)
        {
            return new Direction(scalar * dir.RowDelta, scalar * dir.Columndelta);
        }
    }
}
