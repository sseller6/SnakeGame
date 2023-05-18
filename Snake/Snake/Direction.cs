using System;
using System.Collections.Generic;

namespace Snake
{
    public class Direction
    {
        // We only need four directions to move on the grid.
        public readonly static Direction Left = new Direction(0, -1);
        public readonly static Direction Right = new Direction(0, 1);
        public readonly static Direction Up = new Direction(-1, 0);
        public readonly static Direction Down = new Direction(1, 0);
        public int RowOffset { get; }
        public int ColOffset { get; }

        // The Constructor is private so that no other class can create an instance of the direction class. This is intentional.
        private Direction(int rowOffset, int colOffset)
        {
            RowOffset = rowOffset;
            ColOffset = colOffset;
        }
        // This method returns the directions opposite.
        public Direction Opposite()
        {
            return new Direction(-RowOffset, -ColOffset);
        }

        // Lines 28 - 49 override Equals and GetHashCode so that the direction class can be used as a key in a dictionary.
        // We can have visual studio do this for us by pressing "ctrl + ." then checking "generate operators" and finally click "okay."
        public override bool Equals(object obj)
        {
            return obj is Direction direction &&
                   RowOffset == direction.RowOffset &&
                   ColOffset == direction.ColOffset;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RowOffset, ColOffset);
        }

        public static bool operator ==(Direction left, Direction right)
        {
            return EqualityComparer<Direction>.Default.Equals(left, right);
        }

        public static bool operator !=(Direction left, Direction right)
        {
            return !(left == right);
        }
    }
}
