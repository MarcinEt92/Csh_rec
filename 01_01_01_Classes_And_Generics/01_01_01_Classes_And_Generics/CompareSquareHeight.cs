using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _01_01_01_Classes_And_Generics
{
    class CompareSquareHeight : IComparer<SortableSquare>
    {
        public int Compare([AllowNull] SortableSquare x, [AllowNull] SortableSquare y)
        {
            return x.Height.CompareTo(y.Height);
        }
    }
}
