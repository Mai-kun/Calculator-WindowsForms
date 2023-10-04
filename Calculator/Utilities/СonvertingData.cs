using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Utilities
{
    static class СonvertingData
    {
        public static string Convert(double number, int selectedState1, int selectedState2)
        {
            if (selectedState1 < selectedState2)
            {
                if (selectedState1 == 0)
                {
                    number /= 8;
                    selectedState1++;
                }
                for (int i = selectedState1; i < selectedState2; i++)
                {
                    number /= 1024;
                }
                return number.ToString("0." + new string('#', 60));
            }

            if (selectedState1 > selectedState2)
            {
                for (int i = selectedState2; i < selectedState1 - 1; i++)
                {
                    number *= 1024;
                }
                if (selectedState2 == 0)
                {
                    number *= 8;
                }
                return number.ToString();
            }

            if (selectedState1 == selectedState2)
            {
                return number.ToString("0." + new string('#', 60));
            }

            return "";
        }
    }
}
