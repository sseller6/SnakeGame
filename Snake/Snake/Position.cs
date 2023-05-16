using System;
using System.Collections.Generic;

namespace Snake
{
    public class Position
    {
        // This class stores a row and a column.
        public int Row { get;}
        public int Col { get;}

        // The constructor takes the row and the column as parameters.
        public Position(int row, int col)
        {
            Row = row;
            Col = col;
        }

        // This method returns the position we get by moving one step in the given direction.
        public Position Translate(Direction dir)
        {
            return new Position(Row + dir.RowOffset, Col + dir.ColOffset);
        }

        // We want ot override equals and get hashcode.
        public override bool Equals(object obj)
        {
            return obj is Position position &&
                Row == position.Row &&
                Col == position.Col;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Col);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }
    }
}
