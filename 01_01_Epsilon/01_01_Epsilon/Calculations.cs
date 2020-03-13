using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_01_Epsilon
{
    public static class Calculations
    {
        public enum ValidShapes
        {
            Square, Circle, Cylinder, Octagon
        }

        [Flags]
        public enum ValidColors
        {
            Red = 0, Green = 1, Blue = 2
        }

        public static void ConvertFromIntToShort(int sourceValue, out short destinationValue)
        {
            destinationValue = 0;

            if(sourceValue <= short.MaxValue && sourceValue >= short.MinValue)
            {
                destinationValue = (short)sourceValue;
                Console.WriteLine($"Convert From Int To Short Success! {destinationValue}");
            }
            else
            {
                Console.WriteLine("Convert From Int To Short Fail!");
            }
        }

        public static double DegreeToRadConversion(double degree)
        {
            return (Math.PI / 180) * degree;
        }

        public static int GetLSW(int number)
        {
            int setOfLswSixteenBits = (int)Math.Pow(2, 16) - 1;
            return number & setOfLswSixteenBits;
        }

        public static int GetMFW(int number)
        {
            int setOfMswSixteenBits = (int)(Math.Pow(2, 16) - 1) << 16;
            return number & setOfMswSixteenBits;
        }

        public static bool IsApproximatelyEqualTo(double enumerator, double denominator, double dbValue)
        {
            return IsApproximatelyEqualTo(enumerator, denominator, dbValue, double.Epsilon);
        }

        public static bool IsApproximatelyEqualTo(double enumerator, double denominator, double dbValue,
            double epsilon)
        {
            double difference = (enumerator / denominator) - dbValue;

            if (Math.Abs(difference) < epsilon)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsEven(int number)
        {
            return (number % 2) == 0;
        }

        public static bool IsOdd(int number)
        {
            return (number % 2) != 0;
        }

        public static byte NegateNumber(byte num)
        {
            return (byte)~num;
        }

        public static void TryToParseStringToDouble(string word, out double num)
        {
            if (double.TryParse(word, out num))
            {
                Console.WriteLine($"Parse success: {num}");
            }
            else
            {
                Console.WriteLine("Parse Fail");
            }
        }

        public static double RadToDegreeConversion(double radians)
        {
            return (180 / Math.PI) * radians;
        }
    }
}
