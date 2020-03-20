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

            // ref nie wymaga zainicjalizowania w ciele metody ale wymaga zainicjalizowania przed wywołaniem

            ConvertFromIntToShort(sourceValue, out destinationValue);

            // unchecked powoduje zawiniecie do liczby ujemnej, checked powoduje wyjątek na etapie wykonania
            // niezapakowanie w checked lub unchecked powoduje błąd kompilacji

            unchecked
            {
                Console.WriteLine($"{ int.MaxValue + 1}");
            }

            int a = int.MaxValue;
            double b = int.MaxValue + 0.2;

            // utrata informacji, wartość -1

            Console.WriteLine($"{(short)a}, {(short)b}");

            Console.WriteLine("\n\n 1.14. - 1.15 Triangle calculations - skipped \n");

            Console.WriteLine("\n\n1.16 - enums\n");

            ValidShapes shape = ValidShapes.Circle;

            Console.WriteLine($"shape decimal equivalent: {shape.ToString("D")}");
            Console.WriteLine($"shape general representation: {ValidShapes.Cylinder.ToString("G")}");
            Console.WriteLine($"shape flag representation: {ValidShapes.Cylinder.ToString("F")}");
            Console.WriteLine($"shape hex representation: {shape.ToString("X")}");
            Console.WriteLine($"Def shape: {shape}");

            ValidColors validColor = ValidColors.Blue | ValidColors.Green;

            Console.WriteLine($"\nColors flags attributes usage Blue OR Green: {validColor.ToString("G")}");
            Console.WriteLine($"Colors flags attribute usage Blue OR Green: {validColor.ToString("D")}");

            Console.WriteLine("\n\n1.17 - enums conversion\n");


            try
            {
                //Language lang1 = (Language)Enum.Parse(typeof(Language), "Undefined");
                Language lang2 = (Language)Enum.Parse(typeof(Language), "VBNET, CSharp");
                //Console.WriteLine(lang1);
                Console.WriteLine(lang2.ToString("F"));
            }
            catch(ArgumentException e)
            {
                Console.WriteLine($"Conversion Failed {e.ToString()}");
            }

            Console.WriteLine("\n\n1.18 - enums check if type is correct\n");

            Console.WriteLine(IsHandledEnumValueCorrect(Language.MgdCpp));
            Console.WriteLine(IsHandledEnumValueCorrect((Language)7));

            Console.WriteLine("\n\n1.19 - enums check if type is correct using flags attribute\n");

            // we chceck that not only a single value is corret, but also combinantions which is sum of flags

            Console.WriteLine(IsHandledEnumValueCorrect(Language.VB6));

            Console.WriteLine("\n\n1.20 - enums check if flag i set\n");

            Language lang = Language.CSharp | Language.VB6;
            Language flagToCheck = Language.VBNET;

            Console.WriteLine(IsEnumFlagSet(lang, flagToCheck));

            Console.WriteLine("\n\n1.21 - enums check if multiple flags were enabled\n");

            // sprawdzamy czy zawiera się w zbiorze wartości dozwolonych
            // we can also use OR | operator instead of & to check in lang has only one particular flag

            if ((lang & (Language.CSharp | Language.VB6)) == (Language.CSharp | Language.VB6))
            {
                Console.WriteLine("True - Flags enabled");
            }
            else
            {
                Console.WriteLine("False - Flags disabled");
            }

            Console.WriteLine("\n\n1.22 - enums check if one particular flag is enabled\n");

            // sprawdzamy czy zawiera wyłącznie konkretną wartość dozwoloną (inne flagi muszą być wyłączone żeby dało true)

            Console.WriteLine(IsEnumParticulatFlagSet(lang, Language.CSharp));

            Console.WriteLine("\n\n1.23 - czesc calkowita liczby\n");

            Console.WriteLine(Math.Truncate(Math.PI));

            WriteSth();

            Console.ReadKey();
        }

        

    }
}
