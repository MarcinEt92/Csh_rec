using System;
using System.Collections.Generic;
using System.Text;

namespace _01_01_01_Classes_And_Generics
{
    class Calculations
    {
        public struct Dimensions
        {
            public int dimWidth;
            public int dimHeight;
            public int dimDepth;

            public override string ToString()
            {
                return $"{dimWidth} - {dimHeight} - {dimDepth}";
            }
        }

        public static void ReturnAndWriteSampleDimensions(out int dimWidth, out int dimHeight, out int dimDepth)
        {
            dimWidth = 2;
            dimHeight = 3;
            dimDepth = 4;

            Console.WriteLine($"dimWidth: {dimWidth}, dimHeight: {dimHeight}, dimDepth: {dimDepth}");
        }

        public static Dimensions ReturnSampleDimensionsFromStruct()
        {
            Dimensions dimensions = new Dimensions();

            dimensions.dimWidth = 4;
            dimensions.dimHeight = 5;
            dimensions.dimDepth = 6;

            return dimensions;
        }

        public static Tuple<int, int, int> ReturnDimensionsAsTuple()
        {
            //Tuple<int, int,int> dimTuple = Tuple.Create<int, int, int>(8, 9, 10);
            Tuple<int, int, int> dimTuple = new Tuple<int, int, int>(7, 8, 9);

            return dimTuple;
        }
    }
}
