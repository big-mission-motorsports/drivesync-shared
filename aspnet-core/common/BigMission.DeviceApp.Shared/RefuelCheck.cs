using BigMission.TestHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BigMission.DeviceApp.Shared
{
    /// <summary>
    /// Determines when the car is being refuled.  This is based on an 
    /// increase in fuel level when the car is stationary.  
    /// </summary>
    public class RefuelCheck
    {
        private readonly IDateTimeHelper dateTimeHelper;
        private readonly List<float> fuelLevelSamples = new List<float>();
        /// <summary>
        /// Consider this speed to be stopped since GPS can float around.
        /// </summary>
        private const int MAX_SPEED_CHECK_MPH = 5;
        private const int MAX_FL_SAMPLES = 10;
        /// <summary>
        /// This is the level increase at which we'll consider the car being refuled.
        /// </summary>
        private const float FL_INC_THRESHOLD = 2.5f;
        private readonly TimeSpan MaxRefuelInterval = TimeSpan.FromMinutes(15);
        private DateTime lastRefuel;


        public RefuelCheck(IDateTimeHelper dateTimeHelper)
        {
            this.dateTimeHelper = dateTimeHelper;
        }


        public bool IsRefuling(int speed, float fuelLevel)
        {
            if (speed < MAX_SPEED_CHECK_MPH)
            {
                while (fuelLevelSamples.Count > MAX_FL_SAMPLES)
                {
                    fuelLevelSamples.RemoveAt(0);
                }

                fuelLevelSamples.Add(fuelLevel);

                if (fuelLevelSamples.Count >= MAX_FL_SAMPLES)
                {
                    // See if fuel level is increasing
                    var delta = fuelLevelSamples.Last() - fuelLevelSamples.First();
                    if (delta >= FL_INC_THRESHOLD)
                    {
                        var timeInt = dateTimeHelper.UtcNow - lastRefuel;
                        if (timeInt > MaxRefuelInterval)
                        {
                            lastRefuel = dateTimeHelper.UtcNow;
                            fuelLevelSamples.Clear();
                            return true;
                        }
                    }
                }
            }
            else
            {
                fuelLevelSamples.Clear();
            }

            return false;
        }
    }
}
