using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Microsoft.Xna.Framework;

namespace XnaProjectPract.Engine
{
    class Physics
    {
        public static GameObject checkCollision(GameObject go1, GameObject go2)
        {
            return checkCollision(new System.Drawing.Rectangle(go1.X, go1.Y, go1.Width, go1.Height), go2);
        }

        public static GameObject checkCollision(System.Drawing.Rectangle rec1,GameObject go2)
        {
            System.Drawing.Rectangle rec2 = new System.Drawing.Rectangle(go2.X, go2.Y, go2.Width, go2.Height);

            bool result = rec1.IntersectsWith(rec2);

            if (result)
            {
                return go2;
            }
            else
                return null;
        }

        public static bool checkCollision(Microsoft.Xna.Framework.Rectangle rec1,Microsoft.Xna.Framework.Rectangle rec2)
        {
            bool result = rec1.Intersects(rec2);

            if (result)
            {
                return true;
            }
            else
                return false;

        }
    }
}
