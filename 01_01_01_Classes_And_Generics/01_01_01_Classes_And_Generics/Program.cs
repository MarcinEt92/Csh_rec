using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using static _01_01_01_Classes_And_Generics.Calculations;

namespace _01_01_01_Classes_And_Generics
{
    [StructLayout(LayoutKind.Explicit)]
    struct SignedNumber
    {
        [FieldOffset(0)]
        public sbyte Num1;

        [FieldOffset(0)]
        public short Num2;

        [FieldOffset(0)]
        public int Num3;

        [FieldOffset(0)]
        public long Num4;

        [FieldOffset(0)]
        public float Num5;

        [FieldOffset(0)]
        public double Num6;

        [FieldOffset(0)]
        public decimal Num7;

        [FieldOffset(16)]
        public string Text1;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // union is a type commonly used in C++ for storing variuos data types in one memory location

            Console.WriteLine("\n1.1 eng page 3 Struct that works as an union \n");

            Console.WriteLine("\n\n3.2 Formatting class data (IFormatable) pl str 113 \n");

            Line l1 = new Line(1, 2, 3, 4);

            Console.WriteLine(l1.ToString("V"));

            Console.WriteLine("\n\n1.2 Making a type sortable pl str 127, eng page 6 \n");

            List<SortableSquare> list1 = new List<SortableSquare>
            {
                new SortableSquare(width: 2, height: 3),
                new SortableSquare(width: 4, height: 5),
                new SortableSquare(width: 1, height: 2),
                new SortableSquare(width: 9, height: 1),
                new SortableSquare(width: 8, height: 9),
                new SortableSquare(width: 2, height: 3)
            };

            // Sortujący algorytm korzysta z logiki, którą zaimplementowalismy w metodzie CompareTo klasy SortableSquare

            list1.Sort();

            list1.ForEach(Console.WriteLine);

            list1.Sort(new CompareSquareHeight());

            Console.WriteLine("\nSorted using IComparer interface (height comparison)\n");

            list1.ForEach(Console.WriteLine);

            Console.WriteLine("\nSorting using delegate (width sorting)\n");

            list1.Sort((x, y) => x.Width.CompareTo(y.Width));

            list1.ForEach(Console.WriteLine);

            Console.WriteLine("\n\n1.3 Making a type searcheable pl str 132, eng page 10 \n");

            int found = list1.BinarySearch(new SortableSquare(width: 8, height: 9));

            Console.WriteLine($"Found (8,9): {found}");

            Console.WriteLine("\n\n1.4 Returning multiple values from method eng page 14, pl str 178 (prob 3.21)\n");

            int dimWidth;
            int dimHeight;
            int dimDepth;

            ReturnAndWriteSampleDimensions(out dimWidth, out dimHeight, out dimDepth);

            Console.WriteLine("\nUsing structure:\n");

            Dimensions dimensions = ReturnSampleDimensionsFromStruct();

            //Console.WriteLine($"Dim: {dimensions.dimWidth} {dimensions.dimHeight} {dimensions.dimDepth}");
            Console.WriteLine($"Dimensions from struct: {dimensions.ToString()}");

            Console.WriteLine("\nUsing Tuple:");

            Tuple<int, int, int> dimTuple = ReturnDimensionsAsTuple();

            Console.WriteLine($"Dimensions in a Tuple: {dimTuple.ToString()}");
        }
    }
}
