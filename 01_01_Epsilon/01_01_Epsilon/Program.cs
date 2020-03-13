using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _01_01_Epsilon.Calculations;

namespace _01_01_Epsilon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n 1.1. Comparing fractions: \n\n");

            Console.WriteLine($"Epsilon value: {double.Epsilon}");

            double enumerator = 1;
            double denominator = 126;
            double dbValue = 0.007936507;
            double epsilon = 0.0001;

            Console.WriteLine($"Is equal to : " + 
                $"{IsApproximatelyEqualTo(enumerator, denominator, dbValue, epsilon)}");


            Console.WriteLine("\n\n 1.2. 1.3 Degree to rad and inverse conversion:\n");

            double degree = 120;
            double radians = 2;

            Console.WriteLine($"Deg: {degree} - Rad: {DegreeToRadConversion(degree)}");
            Console.WriteLine($"Deg: {radians} - Rad: {RadToDegreeConversion(radians)}");


            Console.WriteLine("\n\n 1.4. Bit negation:\n");

            byte byteNumber = 0;
            Console.WriteLine($"number: {byteNumber} - negation: {NegateNumber(byteNumber)}");


            Console.WriteLine("\n\n 1.5. Even/Odd numbers check \n");

            int numberEven = 2;
            int numberOdd = 3;

            Console.WriteLine($"Number: {numberEven} is even: {IsEven(numberEven)}");
            Console.WriteLine($"Number: {numberOdd} is even: {IsOdd(numberOdd)}");


            Console.WriteLine("\n\n 1.6. Obtaining LSW, MSW from 32 bit number \n");

            int numberToGetMswAndLsw = (int)Math.Pow(2, 17) + (int)Math.Pow(2, 16) + 3;

            Console.WriteLine($"Number: {numberToGetMswAndLsw} - MSW: {GetMFW(numberToGetMswAndLsw)}," +
                $" LSW: {GetLSW(numberToGetMswAndLsw)}");


            Console.WriteLine("\n\n 1.7. Conversion from numbers of different systems \n");

            int hexB = 0xFA;
            string hexBase = "FA";
            string octBase = "27";
            string binBase = "11111111";

            Console.WriteLine($"Num {hexBase} - Dec: {Convert.ToInt32(hexBase, 16)}");
            Console.WriteLine($"Num {hexBase} - Dec: {Convert.ToInt32(octBase, 8)}");
            Console.WriteLine($"Num {hexBase} - Dec: {Convert.ToInt32(binBase, 2)}");
            Console.WriteLine($"No conversion required: {hexB}");

            Console.WriteLine("\n\n 1.8. Checking reprosentation of a string \n");

            string strToCheck = "12,5";
            double numberToWrite;

            TryToParseStringToDouble(strToCheck, out numberToWrite);

            Console.WriteLine("\n\n 1.9. - 1.10 Round a number \n");

            Console.WriteLine($" Round a number: " + 
                $"\n\tRound of 2.9 equals {Math.Round(2.9)}" +
                $"\n\tCeiling of 2.3 equals {Math.Ceiling(2.3)}" + 
                $"\n\tFloor of 2.8 equals {Math.Floor(2.8)}");

            Console.WriteLine("\n\n 1.11. - 1.12 Changing Celcius to Fahrenheit and reversely - skipped \n");

            Console.WriteLine("\n\n 1.13. - Safe conversion \n");

            int sourceValue = 3400;
            short destinationValue;

            ConvertFromIntToShort(sourceValue, out destinationValue);

            Console.WriteLine("\n\n 1.14. - 1.15 Triangle calculations - skipped \n");

            Console.WriteLine("\n\n1.16 - enums\n");

            ValidShapes shape = ValidShapes.Circle;

            Console.WriteLine($"shape decimal equivalent: {shape.ToString("D")}");
            Console.WriteLine($"shape general representation: {ValidShapes.Cylinder.ToString("G")}");
            Console.WriteLine($"shape hex representation: {shape.ToString("X")}");

            ValidColors validColor = ValidColors.Blue | ValidColors.Green;

            Console.WriteLine($"\nColors flags attributes usage Blue OR Green: {validColor}");
            Console.WriteLine($"Colors flags attribute usage Blue OR Green: {validColor.ToString("D")}");

            Console.ReadKey();
        }

        

    }
}
