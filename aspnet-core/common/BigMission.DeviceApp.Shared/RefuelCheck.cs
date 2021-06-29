using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BigMission.DeviceApp.Shared
{
    public class RefuelCheck
    {
        private readonly List<float> fuelLevelSamples = new List<float>();
        private const int MAX_SPEED_CHECK = 4;
        private const int MAX_FL_SAMPLES = 10;
        private const float FL_INC_THRESHOLD = 2.5f;
        private readonly TimeSpan MaxRefuelInterval = TimeSpan.FromMinutes(15);
        private DateTime lastRefuel;

        public bool IsRefuling(int speed, float fuelLevel)
        {
            if (speed < MAX_SPEED_CHECK)
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
                        var timeInt = DateTime.Now - lastRefuel;
                        if (timeInt > MaxRefuelInterval)
                        {
                            lastRefuel = DateTime.Now;
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
