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
using XnaProjectPract.StatObjects;
using XnaProjectPract.GOItem;


namespace XnaProjectPract.GameObjects
{
    class Player:StatObject
    {
        //private const int IDLE = 0, FORWARD = 1, BACKWARD = 2, LEFT = 3, RIGHT = 4;
        private int position;
        private KeyboardState keyState;
        public bool playerInFront  = false;
        private int moveAmountX;
        private int moveAmountY;
        Game game;
   
        private StatObject currentTarget = null;
       

        bool movingHealthBar = false,isMoving = false;
        private float sightRange = 100;
        static bool isAttacking = false;
        static int attackCounter = 0;

        public Player(int x, int y, int width, int height,Rectangle rectSect, Color color, Game game,float layerDepth)
        {
            this.x = x;
            this.y = y;
            this.widthX = width;
            this.heightY = height;
            this.type = PLAYER_ID;
            this.position = IDLE;
            this.layerDepth = 0;
            this.game = game;
            this.objectInfo = "Player";
            this.MaxHealth = 100;

          
            this.init(x,y,width,height,rectSect,color,game,layerDepth,type,true);
           
            this.FrameNumber = 6;
      
            this.setTexture("Idle");
            this.LastPosition = RIGHT;
            this.DrawSpriteClass.HitBoxColor = Color.Transparent;

           
        }

        public override void Initialzation()
        {
            

            this.initAttackBox(x, y, 40, 40, Color.Brown, game);
            this.initHealthBar(game.Content);
            this.HitBox(-10, -300, 60, 240);
            
            this.DrawImageRectangle(-30, -235, 60, 230);

            HealthBarOffsetSize(100, 10);

            this.attackLoad();

            this.DrawSpriteClass.HitBoxColor = Color.Transparent;
            this.DrawSpriteClass.EmptyColor = Color.Transparent;
            this.AttackBoxColor = Color.Transparent;

            healthBarLoad(game.Content);           
           
            LoadAsset("Alex_Right_Low_punch", 2);
            
        }

        public void setTarget(StatObject target)
        {
            currentTarget = target;
        }

        public StatObject getTarget()
        {
            return currentTarget;
        }

        public void LoadAsset(string asstet, int frameNumber)
        {
            FrameNumber = frameNumber;
            Attack();            
        }


        public void input()
        {
            keyState = Keyboard.GetState();
            move(0, 0);
            if(keyState.IsKeyDown(Keys.Up)|| keyState.IsKeyDown(Keys.W))
            {
                move(0, -1);
                isMoving = true;
            }
            if (keyState.IsKeyDown(Keys.Down) || keyState.IsKeyDown(Keys.S))
            {
                move(0, 1);
                isMoving = true;
            }
            if (keyState.IsKeyDown(Keys.Left) || keyState.IsKeyDown(Keys.A))
            {
                move(-1, 0);
                isMoving = true;

            }
            
            if (keyState.IsKeyDown(Keys.Right) || keyState.IsKeyDown(Keys.D))
            {
                move(1, 0);
                isMoving = true;

            }
            if(keyState.IsKeyDown(Keys.Space)&& !isMoving)
            {
               
                isMoving = false;
                FaceingDirection = ATTACKING;
     
            }        
            
        }
             

        public void move(int magX, int magY)
        {
            
            if(magX.Equals(0) && magY.Equals(0))
            {
                this.FaceingDirection = IDLE;
            }
            if(magX.Equals(0) && magY.Equals(-1))
            {
                this.FaceingDirection = FORWARD;
            }
            if(magX.Equals(0) && magY.Equals(1))
            {
                this.FaceingDirection = BACKWARD;
            }
            if(magX.Equals(-1) && magY.Equals(0))
            {
                this.FaceingDirection = LEFT;

            }
            if(magX.Equals(1) && magY.Equals(0))
            {
                this.FaceingDirection = RIGHT;
            }
            moveAmountX += 1 * magX;
            moveAmountY += 1 * magY;
            
        }

        public void Attack()
        {
          
            AttackBoxVisiablity(true);
            isAttacking = true;
           
            frameSpeed = 500f;


            if (LastPosition == RIGHT || FaceingDirection == IDLE)
            {
                attackCounter++;
                this.setTexture("Alex_Right_Low_punch");
                this.AdjustAttackBox(x + 46, y - 168);
            }
            else if (LastPosition == LEFT || FaceingDirection == IDLE)
            {
                attackCounter++;
                this.AdjustAttackBox(x-35,y-166);
                
                this.setTexture("Alex_Left_Low_punch");
            }
           
            
           
        }



        public override void update(GameTime gameTime)
        {

            
            float newX = this.x + moveAmountX;
            float newY = this.y + moveAmountY;

            if(IsDamaged)
            {

               
                this.IsDamaged = false;

                UpdateDamage(false);
            }else
            {
                UpdateDamage(true);

            }

            List<GameObject> hobjects = GamePlay.rectangleCollide(newX, newY, newX + (widthX), newY + (heightY));
            List<GameObject> collisionRect = GamePlay.rectangleCollide(DrawImageRectX, DarwImageRectY, DrawImageRectWidth, DrawImageRectHeight);

            List<Item> items = new List<Item>();


            moveAmountX = 0;
            moveAmountY = 0;

            bool move = true, collisionRectMove = true;
            input();
            Look();
            

            if(FaceingDirection == LEFT)
            {
                AttackBoxVisiablity(false);
                this.setTexture("Alex_walking_Left");
                this.SetAnimated = true;
                lastPosition = FaceingDirection;
            }else
            if(FaceingDirection == RIGHT)
            {
                AttackBoxVisiablity(false);
                this.setTexture("Alex_walking_Right");
                this.SetAnimated = true;
                lastPosition = FaceingDirection;
            }else
            if(FaceingDirection== FORWARD)
            {
                AttackBoxVisiablity(false);
                if(lastPosition == LEFT)
                {
                    this.setTexture("Alex_walking_Left");
                    this.SetAnimated = true;
                }
                if(lastPosition == RIGHT)
                {
                    this.setTexture("Alex_walking_Right");
                    this.SetAnimated = true;
                }
                aboveOrBelow = FaceingDirection;
            }else
            if(FaceingDirection == BACKWARD)
            {
                AttackBoxVisiablity(false);
               
                if (lastPosition == LEFT)
                {
                    this.setTexture("Alex_walking_Left");
                    this.SetAnimated = true;
                }
                if (lastPosition == RIGHT)
                {
                    this.setTexture("Alex_walking_Right");
                    this.SetAnimated = true;
                }
                aboveOrBelow = FaceingDirection;

            }else
            if(FaceingDirection == IDLE)
            {
                isMoving = false;
                isAttacking = false;
                AttackBoxVisiablity(false);
                this.setTexture("Alex_Right_Idle");
                this.SetAnimated = true;

                if(lastPosition == LEFT)
                {
                    this.setTexture("Alex_Left_Idle");
                    this.SetAnimated = true;
                }
                if(lastPosition == RIGHT)
                {
                    this.setTexture("Alex_Right_Idle");
                    this.SetAnimated = true;
                }
                aboveOrBelow = FaceingDirection;

            }else
            if(FaceingDirection == ATTACKING)
            {
                Attack();
                if (attackCounter == 40)
                {
                   
                    attackCounter = 0;
                    if (currentTarget != null)
                        getTarget().IsDamaged = true;
                    
                }
                
                
            }

            if (currentTarget != null)
            {
                HealthBarUpdate();

                if (getTarget().IsDamaged)
                {
                    this.damage(this.AttackBoxProp, getTarget().HitBoxRectProp, 6);
                    Console.WriteLine("Current Enemy Health" + getTarget().HealthTotal);
                    getTarget().IsDamaged = false;
                    getTarget().UpdateDamage(false);

                }
                else
                {
                    getTarget().IsDamaged = false;
                    getTarget().UpdateDamage(true);
                }

            }
           
            foreach (GameObject go in hobjects)
            {
               
                if (go.getType() == GameObject.ITEM_ID)
                {

                    items.Add((Item)go);
                    
                }
                if (go.isSolid())
                {

                    move = false;

                }

            }

            foreach (Item item in items)
            {
                addToHealth(item.Value);
            }
           
            if (attackCounter == 100)
            {
                AttackBoxVisiablity(false);
                Console.WriteLine(attackCounter);
                attackCounter = 0;
            }
            
            foreach (GameObject go in items)
            {
                go.remove();


            }

            if (!move)
            { return; }
            else
            {

                this.x = (int)newX;
                this.y = (int)newY;
            }
            render(gameTime);


            if(this.HealthTotal < 0)
            {
                this.remove();
                this.HealthTotal = 0;
            }
            HealthBarUpdate();

        }

        public void Look()
        {
            List<GameObject> gobjects = GamePlay.sphereCollide(x, y, sightRange);

            foreach (GameObject go in gobjects)
            {
                if (go.Type == ENEMY_ID)
                {
                    setTarget((StatObject)go);

                    HealthBarPosition(x, y - DrawImageHeight);


                }else
                {
                    HealthBarPosition(x + 30, y + heightY);

                }
            }

          
        }

        public override void addToRender(SpriteBatch spriteBatch)
        {
            HealthBarDraw(spriteBatch);
            this.drawToRender();
            base.addToRender(spriteBatch);
        }
    }
}
