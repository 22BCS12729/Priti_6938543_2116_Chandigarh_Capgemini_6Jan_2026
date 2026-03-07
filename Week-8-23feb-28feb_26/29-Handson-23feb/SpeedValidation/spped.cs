using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedValidation
{

    public class CarSpeed
    {
        public string speed { get; set; }
    }

    public class SpeedInvalidException : Exception
    {
        public SpeedInvalidException(string message) : base(message)
        {
        }
    }

    public class CarSpeedImplementation
    {
        public string setCarSpeed(CarSpeed sp, int spd)
        {
            if (spd < 30 || spd > 90)
            {
                throw new SpeedInvalidException("Speed must be between 30 and 90.");
            }

            sp.speed = spd.ToString();
            return "Speed set successfully to " + sp.speed;
        }
    }
}