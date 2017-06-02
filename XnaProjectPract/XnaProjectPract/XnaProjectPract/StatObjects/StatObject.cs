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
using XnaProjectPract.Engine;


namespace XnaProjectPract.StatObjects
{
    class StatObject:GameObject
    {
        AttackBox attckBox;
        HealthBar healthbar;
        protected int MaxHealth;
        protected int currentHealth;
        private bool isDamaged;
        private static int damages;

        public void UpdateAttackBox(int x, int y)
        {
            this.attckBox.update(x, y);
            
        }

        public void HealthBarUpdate()
        {
            this.healthbar.update();
        }

        public void HealthBarVisiavle(bool visiable)
        {
            healthbar.Visiable = visiable;
        }

        public void AdjustAttackBox(int x, int y)
        {
            attckBox.AdjustAttackBox(x, y);
        }

        public void AttackBoxVisiablity(bool isVisiable)
        {
            this.attckBox.Visible = isVisiable;
        }

        public Rectangle AttackBoxProp
        {
            get { return attckBox.Rect; }
        }
        public Rectangle HealthBarProp
        {
            get { return healthbar.Rect; }
        }

        public void HitBox(int x, int y, int width, int height)
        {
            this.HitBoxRectangle(x, y, width, height);
        }
        public bool Attacking
        {
            get { return attckBox.Attacking(); }
        }



        public void damage(Rectangle rec1, Rectangle rec2,int damage)
        {
           
            if (Physics.checkCollision(rec1, rec2))
            {

                damages = damage;
                
            }
         

        }
        public void addToHealth(int value)
        {
            healthbar.RateOfChange -= value;
        }
        public int HealthTotal
        {
            get { return healthbar.HealthTotal; }
            set { healthbar.HealthTotal = value; }
        }

        public Color AttackBoxColor
        {
            get { return attckBox.AttackBoxColor; }
            set { attckBox.AttackBoxColor = value; }
        }

        public void UpdateDamage(bool isReset)
        {
            if (!isReset)
            {
                
                healthbar.RateOfChange += damages;
                currentHealth -= damages;

            }else
            {
                healthbar.RateOfChange = 0;
            }
          

        }
        public bool IsDamaged
        {
            get { return isDamaged; }
            set { isDamaged = value; }
        }

        public int CurrentHealth
        {
            get { return currentHealth; }
            set { currentHealth = value; }
        }


        public void attackLoad()
        {
            attckBox.Load();
        }
        public void healthBarLoad(ContentManager content)
        {
            healthbar.LoadContent(content);
        }

        public override void update(GameTime gameTime)
        {
            base.update(gameTime);
        }
   
        public void drawToRender()
        {
            attckBox.Draw();
           
        }
        public void HealthBarDraw(SpriteBatch spriteBatch)
        {
            healthbar.Draw(spriteBatch);
        }
       
        public void HealthBarPosition(int x, int y)
        {
            healthbar.Position = new Vector2(x, y);
        }

        public void HealthBarOffsetSize(int width,int height)
        {
            healthbar.OffSetHeight = height;
            healthbar.OffsetWidth = width;

        }

        public void initAttackBox(int x, int y, int width, int height, Color color, Game game)
        {


            attckBox = new AttackBox(x, y, width, height, color, game);
            this.layerDepth = 0;
        }
        public void initHealthBar(ContentManager content)
        {
           
            
            healthbar = new HealthBar(content,MaxHealth);
            healthbar.FullHealth = MaxHealth;
            currentHealth = healthbar.FullHealth;
            
        }

    }
}
