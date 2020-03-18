using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _01_01_01_Classes_And_Generics
{
    class SortableSquare : IComparable<SortableSquare>
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public SortableSquare()
        {
            this.Width = 1;
            this.Height = 1;
        }
        public SortableSquare(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int CompareTo([AllowNull] SortableSquare other)
        {
            int thisArea = this.Height * this.Width;
            int otherArea = other.Height * other.Width;

            return thisArea.CompareTo(otherArea);
        }

        public override string ToString()
        {
            return $"Width: {this.Width}, Height: {this.Height}";
        }
    }
}
