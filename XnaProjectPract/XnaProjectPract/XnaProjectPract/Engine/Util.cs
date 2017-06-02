using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XnaProjectPract.Engine
{
    public static class Util
    {
        public static bool LineOfSight(GameObject go1,GameObject go2)
        {
            return true;
        }

        public static float dist(float x1,float y1,float x2,float y2)
        {
            double x = x2 - x1, y = y2 - y1;

            return (float)Math.Sqrt((x * x) + (y * y));
        }
    }
}
