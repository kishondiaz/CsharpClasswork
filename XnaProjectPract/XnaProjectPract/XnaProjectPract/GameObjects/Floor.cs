using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XnaProjectPract.Engine;

namespace XnaProjectPract.GameObjects
{
    class Floor:GameObject
    {
        public Floor(int x,int y, int width, int height, Color color, Game game)
        {
            this.x = x;
            this.y = y;
            this.widthX = width;
            this.heightY = height;
            this.type = FLOOR_ID;
            this.init(x, y, width, height, new Rectangle(0, 0, 0, 0), color, game, 0, type,false);
        }
    }
}
