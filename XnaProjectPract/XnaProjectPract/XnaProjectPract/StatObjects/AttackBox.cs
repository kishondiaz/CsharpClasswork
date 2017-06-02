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
using System.Collections;


namespace XnaProjectPract.StatObjects
{
    class AttackBox : RectangleOverlay
    {

        int x, y;

      
        public AttackBox(int x, int y, int width, int height,Color color,Game game):base(x,y,width,height,color,game)
        {
            this.x = x;
            this.y = y;
            
            

        }

        public Color AttackBoxColor
        {
            get { return Colori; }
            set { Colori = value; }
        }


        public bool Attacking()
        {
            return Visible;
        }

        public void AdjustAttackBox(int x, int y)
        {
            this.dummyRectangle.X = x;
            this.dummyRectangle.Y = y;
        }

        public void update(int x, int y)
        {
            dummyRectangle.X = x;
            dummyRectangle.Y = y;

           
        }  
        
    }
}
