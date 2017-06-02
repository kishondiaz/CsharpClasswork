using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using XnaProjectPract.Engine;

namespace XnaProjectPract.GOItem
{
    class Item:GameObject
    {
        protected int value;
        public Item(int x, int y, int width, int height,Color color,Game game)
        {
            this.x = x;
            this.y = y;
            this.widthX = width;
            this.heightY = height;
            this.type = ITEM_ID;
            this.layerDepth = 0;
            this.objectInfo = "Apple";
            this.init(x, y, width, height, new Rectangle(0,0,0,0), color, game,0, type,false);
            this.value = 12;

            this.setTexture("apple_PNG38");
            this.DrawSpriteClass.HitBoxColor = Color.Transparent;
            this.DrawSpriteClass.EmptyColor = Color.Transparent;
            
        }

        public int Value
        {
            get { return value; }
        }

        public string getString()
        {
            return objectInfo;
        }

    }
}
