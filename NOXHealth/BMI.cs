using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOXHealth
{
    class BMI
    {
        public double BMILevel { get; set; }

        public double calculateValue(int Age, double Height, double Weight)
        {
            double Value = 0;
            double BMIvalue = Weight / (Height * Height);
            double ageLevel;
            double BMILevel;

            if (BMIvalue > 25) //obesitas
            {
                BMILevel = 1;
            }
            else if (BMIvalue < 18.5) //kurus
            {
                BMILevel = 5;
            }
            else //ideal
            {
                BMILevel = 3;
            }

            //Age Level
            if (Age > 45)
            {
                ageLevel = 1;
            }
            else if (Age > 30)
            {
                ageLevel = 2;
            }
            else if (Age > 20)
            {
                ageLevel = 4;
            }
            else if (Age > 12)
            {
                ageLevel = 8;
            }
            else
            {
                ageLevel = 6;
            }

            Value = (ageLevel + 2*BMILevel) / 2;


            return Value;
        }
    }
}
