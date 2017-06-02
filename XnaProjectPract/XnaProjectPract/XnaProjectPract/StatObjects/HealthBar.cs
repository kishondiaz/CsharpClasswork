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
    class HealthBar
    {
        private Texture2D container, lifeBar, backBar;
        private Vector2 position;
        private Rectangle rec;
        private int fullHealth;
        private int currentHealth = 1;
        private int rateOfChange = 0;
        private Color barColor;
        private int offSetWidth;
        private int offSetHeight;
        private int MaxHealth;
        private int healthTotal;
        private bool visiable= true;

        public HealthBar(ContentManager content,int MaxHealth)
        {
            position = new Vector2(100, 100);
            this.MaxHealth = MaxHealth;
            LoadContent(content);
          
            
        }

       
        public int RateOfChange
        {
            get { return rateOfChange; }
            set { rateOfChange = value; }
        }

        public int FullHealth
        {
            get { return fullHealth; }
            set {fullHealth = value; }
        }
        public int OffSetHeight
        {
            get { return offSetHeight; }
            set { offSetHeight = value; }
        }


        public int OffsetWidth
        {
            get { return offSetWidth; }
            set { offSetWidth = value; }
        }

        public Rectangle Rect
        {
            get { return this.rec; }
        }

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        public void LoadContent(ContentManager content)
        {
            container = content.Load<Texture2D>("containerBar");
            backBar = content.Load<Texture2D>("healthBar");
            lifeBar = content.Load<Texture2D>("healthGuage");

            fullHealth = MaxHealth+offSetWidth;
            //fullHealth = lifeBar.Width+MaxHealth-offSetWidth;
            currentHealth = (fullHealth) ;
           
            

        }

        public void update()
        {

           
           
            HealthColor();

           
           
            if(currentHealth >= fullHealth)
            {
                currentHealth = fullHealth;
            }
            if (currentHealth-offSetWidth >= 0)
            {
                currentHealth -= rateOfChange;
                healthTotal = currentHealth - offSetWidth;
              
            }
            rec = new Rectangle((int)position.X, (int)position.Y, currentHealth-offSetWidth, lifeBar.Height - offSetHeight);

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            if (visiable)
            {
                spriteBatch.Draw(backBar, rec, Color.White);
                spriteBatch.Draw(lifeBar, rec, new Rectangle(50, 0, currentHealth - offSetWidth, lifeBar.Height), barColor);
                spriteBatch.Draw(container, rec, Color.White);
            } 
            spriteBatch.End();
        }

        public bool Visiable
        {
            get { return visiable; }
            set { visiable = value; }
        }

        public int HealthTotal
        {
            get { return healthTotal; }
            set { healthTotal = value; }
        }

        public void HealthColor()
        {
            if (currentHealth-offSetWidth >= (MaxHealth) * 0.75)
            {
                barColor = Color.Green;
            }
            else if (currentHealth-offSetWidth >= (MaxHealth) * 0.25)
            {
                barColor = Color.Yellow;
            }
            else 
            {
                barColor = Color.Red;
            }

        }
    }
}
