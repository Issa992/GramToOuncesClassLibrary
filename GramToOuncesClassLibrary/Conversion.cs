using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GramToOuncesClassLibrary
{
    public class Conversion
    {
        public const double ToOunce = 0.035274;
        public const double ToGram = 28.34952;

        public static double ConvertToOunce(double input)
        {

            return input * ToOunce;
        }
        public static double ConvertToGram(double input)
        {
            return input * ToGram;
        }
    }
}
