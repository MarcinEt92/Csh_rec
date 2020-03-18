using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _01_01_01_Classes_And_Generics
{
    // for probem 3.2 str 113 PL

    class Line : IFormattable
    {
        readonly int x1;
        public int X1 { get { return x1; } }

        readonly int y1;
        public int Y1 { get { return y1; } }

        readonly int x2;
        public int X2 { get { return x2; } }

        readonly int y2;
        public int Y2 { get { return y2; } }

        public Line(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public double GetDirectionInRadians()
        {
            int xSide = x2 - x1;
            int ySide = y2 - y1;
            if (xSide == 0)
            {
                return 0;
            }
            else
            {
                return Math.Atan(ySide / xSide);
            }
        }

        public double GetMagnitude()
        {
            int xSide = x2 - x1;
            int ySide = y2 - y1;
            return Math.Sqrt((xSide * xSide) + (ySide * ySide));
        }

        // overriding method without IFormatable interface
        //public override string ToString()
        //{
        //    return $"X1: {X1}, Y1: {Y1}, X2: {X2}, Y2: {Y2}";
        //}

        public override string ToString()
        {
            return (this.ToString(null, null));
        }

        public string ToString(string format)
        {
            return (this.ToString(format, null));
        }

        public string ToString(IFormatProvider formatProvider)
        {
            return (this.ToString(null, formatProvider));
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (String.IsNullOrEmpty(format))
            {
                format = "G";
            }
            if (formatProvider == null)
            {
                formatProvider = NumberFormatInfo.CurrentInfo;
            }

            StringBuilder compositeStr = new StringBuilder("");

            if (format.ToUpper().Equals("V"))
            {
                double direction = this.GetDirectionInRadians();
                double magnitude = this.GetMagnitude();
                string retStringD = direction.ToString("G5", formatProvider);
                string retStringM = magnitude.ToString("G5", formatProvider);

                compositeStr.Append("direction: ").Append(retStringD).Append("\tmagnitude: ").Append(retStringM);
            }
            else
            {
                string retStringX1 = this.x1.ToString(format, formatProvider);
                string retStringY1 = this.y1.ToString(format, formatProvider);
                string retStringX2 = this.x2.ToString(format, formatProvider);
                string retStringY2 = this.y2.ToString(format, formatProvider);

                compositeStr.Append("X1: ").Append(retStringX1).Append("\tY1: ").Append(retStringY1).Append("\tX2: ").Append(retStringX2)
                    .Append("\tY2: ").Append(retStringY2);
            }

            return compositeStr.ToString();
        }

        


    }
}
