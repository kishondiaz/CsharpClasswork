using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XnaProjectPract.GameObjects
{
    class WallBounds:Wall
    {
        public WallBounds(int x, int y, int width, int height, Color color, Game game):base(x,y,width,height,new Rectangle(0,0,0,0),color,game)
        {
            this.x = x;
            this.y = y;
            this.widthX = width;
            this.heightY = height;
            

        }
    }
}
