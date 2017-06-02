using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XnaProjectPract.Engine;

namespace XnaProjectPract.GameObjects
{
    class Wall:GameObject
    {

       
        public Wall(int x, int y, int width, int height,Rectangle rectSect, Color color, Game game)
        {
            this.x = x;
            this.y = y;
            this.widthX = width;
            this.heightY = height;
            this.setSolid(true);

            this.init(x, y, width, height,rectSect, color, game, 0, WALL_ID,false);
        }
    }
}
