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
using XnaProjectPract.StatObjects;

namespace XnaProjectPract.GameObjects
{
    class Enemy : StatObject
    {
        private const float DAMPING = 0.5F;
        private float attackRange = 80f;
        private float sightRange;
        private StatObject target;
        private bool isChasing;
        private Texture2D enimeAttack;
        private Game game;
        private int moveAmountX;
        private int moveAmountY;
        private bool notIsMoving = true,isAttacking = false,isIdle = false ;
        private static int count =0,attackCounter =0;
     


        public Enemy(int x, int y , int width, int height,Rectangle rectSect ,Color color, Game game,float layerDepth)
        {
            Counter++;
            target = null;
            this.x = x;
            this.y = y;
            this.widthX = width;
            this.heightY = height;
            this.type = ENEMY_ID;
            this.sightRange = 290f;
            this.objectInfo = "enemy";
            this.setSolid(true);
            this.isChasing = false;
            this.init(x, y, width, height, rectSect, color,game,layerDepth,type,true);
            this.FrameNumber = 6;
            this.game = game;
            this.setTexture("Alex_Left_Idle");
            this.lastPosition = LEFT;
            count = 0;
            attackCounter =0;
            this.MaxHealth = 50;
       
            
        }

        public override void Initialzation()
        {
            this.DrawImageRectangle(-30, -235, 60, 230);
            this.initAttackBox(x, y, 40, 40, Color.Chartreuse, game);
            this.initHealthBar(game.Content);
            this.HitBox(-50, -300, 80, 240);
            this.DrawSpriteClass.EmptyColor = Color.Transparent;

            this.HealthBarOffsetSize(100, 10);

            this.attackLoad();

            this.healthBarLoad(game.Content);

            this.DrawSpriteClass.HitBoxColor = Color.Transparent;
            this.AttackBoxColor = Color.Transparent;

           
            
          
        }

        public override void update(GameTime gameTime)
        {
            float newX = this.x + moveAmountX;
            float newY = this.y + moveAmountY;


            this.UpdateAttackBox(x, y);

            this.HealthBarPosition(x + 30, y + heightY);

          

            if(target == null)
            {
                this.SetAnimated = false;

                Look();
                
                notIsMoving = true;
                isChasing = false;
                isAttacking = false;
                isIdle = true;
                this.SetAnimated = true;

               
               
            }
            else
            {

                if(Util.LineOfSight(this,target)&& Util.dist(x,y,getTarget().X,getTarget().Y) <= attackRange)
                {
                    if (!isChasing)
                    {
                       
                        if (this.FaceingDirection == LEFT || this.FaceingDirection == RIGHT)
                        {
                            FaceingDirection = ATTACKING;
                            isAttacking = true;
                        }
                        notIsMoving = true;
                        isIdle = true;
                    }                    
                }else
                {
                    if ( Util.dist(x, y, getTarget().X, getTarget().Y) <= sightRange)
                    {
                        this.frameSpeed = 250f;
                        isChasing = chase();
                        notIsMoving = false;
                        isAttacking = false;
                        isIdle = false;
                    }
                    else 
                    {
                        moving(0, 0);
                        sightRange = 600f;
                        notIsMoving = true;
                        isAttacking = false;
                    }                                     
                }

                if (notIsMoving)
                {
                    count++;
                   
                   
                  

                }
                if (count == 8)
                {
                   
                    if (!isAttacking)
                    {
                        if(isIdle)
                        {
                           
                            BackAway();
                            
                        }
                    }
                    count = 0;
                }
               
               
                
                if (y > (getTarget().Y) - 10)
                {
                    this.layerDepth = 1;
                    getTarget().LayerLevel = 0;

                }else
                if (y < (getTarget().Y) - 10)
                {

                    this.layerDepth = 0;
                    getTarget().LayerLevel = 1;

                }

                updateMoving();

                if (this.HealthTotal < 0)
                {
                    this.remove();
                }
                if (getTarget().getRemove())
                {
                    BackAway();
                }
            }

            


            HealthBarUpdate();
        }

        public void updateMoving()
        {
            if (this.FaceingDirection == ATTACKING)
            {
                Attack();
                if (this.Attacking)
                {
                    getTarget().IsDamaged = true;

                    getTarget().damage(this.AttackBoxProp, getTarget().HitBoxRectProp, 2);
                    Console.WriteLine("Players Current Health: " + ((getTarget().HealthTotal)));
                }

            }
            if (this.FaceingDirection == LEFT)
            {

                this.setTexture("Alex_walking_Left");
                this.SetAnimated = true;
                this.lastPosition = FaceingDirection;

            }

            if (this.FaceingDirection == RIGHT)
            {
                this.setTexture("Alex_walking_Right");
                this.SetAnimated = true;
                this.lastPosition = FaceingDirection;
            }
            if (this.FaceingDirection == FORWARD)
            {
                if (this.lastPosition == LEFT && getTarget().LastPosition == LEFT)
                {
                    this.setTexture("Alex_walking_Left");
                    this.SetAnimated = true;

                }
                if (this.lastPosition == RIGHT && getTarget().LastPosition == RIGHT)
                {
                    this.setTexture("Alex_walking_Right");
                    this.SetAnimated = true;

                }
                if (getTarget().AboveOrBelow == FORWARD)
                {
                    if (this.lastPosition == LEFT && getTarget().LastPosition == LEFT)
                    {
                        this.setTexture("Alex_walking_Left");
                        this.SetAnimated = true;
                    }
                    if (this.lastPosition == RIGHT && getTarget().LastPosition == RIGHT)
                    {
                        this.setTexture("Alex_walking_Right");
                        this.SetAnimated = true;
                    }
                    if (this.aboveOrBelow == FORWARD)
                    {
                       
                        if (Util.dist(x, y, getTarget().X, getTarget().Y) <= attackRange)
                        {
                            turnAround();
                        }
                        else
                        {
                            if (this.LastPosition == RIGHT && getTarget().FaceingDirection == LEFT)
                            {
                                this.setTexture("Alex_walking_Right");
                                this.SetAnimated = true;
                            }
                            if (this.LastPosition == LEFT && getTarget().LastPosition == RIGHT)
                            {
                                this.setTexture("Alex_walking_Left");
                                this.SetAnimated = true;
                            }
                        }
                    }

                }
                this.aboveOrBelow = FaceingDirection;
            }
            if (this.FaceingDirection == BACKWARD)
            {

                if (getTarget().AboveOrBelow == BACKWARD)
                {
                    if (this.lastPosition == LEFT && getTarget().LastPosition == LEFT)
                    {
                        this.setTexture("Alex_walking_Left");
                        this.SetAnimated = true;
                    }
                    if (this.lastPosition == RIGHT && getTarget().LastPosition == RIGHT)
                    {
                        this.setTexture("Alex_walking_Right");
                        this.SetAnimated = true;
                    }

                    if (this.aboveOrBelow == BACKWARD)
                    {
                        if (Util.dist(x, y, getTarget().X, getTarget().Y) <= attackRange)
                        {
                            turnAround();
                        }
                        else
                        {
                            if (this.LastPosition == RIGHT && getTarget().FaceingDirection == LEFT)
                            {
                                this.setTexture("Alex_walking_Right");
                                this.SetAnimated = true;
                            }
                            if (this.LastPosition == LEFT && getTarget().LastPosition == RIGHT)
                            {
                                this.setTexture("Alex_walking_Left");
                                this.SetAnimated = true;
                            }
                        }
                    }

                }
                this.aboveOrBelow = FaceingDirection;

            }
            if (this.FaceingDirection == IDLE)
            {

                this.setTexture("Alex_Right_Idle");
                this.SetAnimated = true;

                if (this.lastPosition == LEFT)
                {
                    this.setTexture("Alex_Left_Idle");
                    this.SetAnimated = true;
                }
                if (this.lastPosition == RIGHT)
                {
                    this.setTexture("Alex_Right_Idle");
                    this.SetAnimated = true;
                }

                this.aboveOrBelow = FaceingDirection;
            }
            if (getTarget().AboveOrBelow == IDLE)
            {
                isChasing = false;
                notIsMoving = false;
            }
            if (!notIsMoving)
            {

                if (this.aboveOrBelow == FORWARD)
                {

                    if (this.FaceingDirection == IDLE)
                    {
                        if (this.lastPosition == LEFT)
                        {
                            this.setTexture("Alex_walking_Left");
                            this.SetAnimated = true;
                        }
                        if (this.lastPosition == RIGHT)
                        {
                            this.setTexture("Alex_walking_Right");
                            this.SetAnimated = true;
                        }
                    }

                }
                if (this.aboveOrBelow == BACKWARD)
                {

                    if (this.LastPosition == IDLE)
                    {
                        if (this.lastPosition == LEFT)
                        {
                            this.setTexture("Alex_walking_Left");
                            this.SetAnimated = true;
                        }
                        if (this.lastPosition == RIGHT)
                        {
                            this.setTexture("Alex_walking_Right");
                            this.SetAnimated = true;
                        }
                    }

                }

                if(this.getTarget().getRemove())
                {
                    BackAway();
                    if(this.x >= x)
                    {
                        if (this.lastPosition == LEFT)
                        {
                            this.setTexture("Alex_walking_Right");
                            this.SetAnimated = true;
                        }
                        if (this.lastPosition == RIGHT)
                        {
                            this.setTexture("Alex_walking_Left");
                            this.SetAnimated = true;
                        }
                    }

                   
                }
            }
        }
        public void moving(int magX, int magY)
        {
            attackCounter = 0;
            if (magX.Equals(0) && magY.Equals(0))
            {
                this.FaceingDirection = IDLE;
            }
            if (magX.Equals(0) && magY.Equals(-1))
            {
                this.FaceingDirection = FORWARD;
            }
            if (magX.Equals(0) && magY.Equals(1))
            {
                this.FaceingDirection = BACKWARD;
            }
            if (magX.Equals(-1) && magY.Equals(0))
            {
                this.FaceingDirection = LEFT;

            }
            if (magX.Equals(1) && magY.Equals(0))
            {
                this.FaceingDirection = RIGHT;
            }

        }
        
        public StatObject getTarget()
        {
            return target;
        }

        protected void Attack()
        {


            AttackBoxVisiablity(true);
            this.frameSpeed = 500f;
        
   
          
            if (LastPosition == LEFT)
            {
                attackCounter++;

                this.AdjustAttackBox(x - 35, y - 166);
                AttackBoxVisiablity(false);
                setTexture("Alex_Left_Low_punch");
            }else     
            if (LastPosition == RIGHT)
            {
                
                attackCounter++;

                this.AdjustAttackBox(x +46, y - 168);
                AttackBoxVisiablity(false);
                setTexture("Alex_Right_Low_punch");
            }
            if (attackCounter == 60)
            {
                
                AttackBoxVisiablity(true);
                attackCounter = 0;
            }
            this.SetAnimated = true;
        }
        public void LoadAsset(string asstet, int frameNumber)
        {
            FrameNumber = frameNumber;
            enimeAttack = game.Content.Load<Texture2D>(asstet);
        }

        protected void Look()
        {
            List<GameObject> gobjects = GamePlay.sphereCollide(x,y,sightRange);

            foreach (GameObject go in gobjects)
            {              
                if(go.Type == PLAYER_ID)
                {
                    setTarget((StatObject)go);
                }
            } 
        }

        protected bool chase()
        {
            bool isChasing = false;
            float speedX = (getTarget().X - x),
                  speedY = (getTarget().Y - y);
            

            float maxSpeed = 4f*DAMPING;

            

            if (speedX > maxSpeed)
            {
                speedX = maxSpeed;
              
                isChasing = true;

                moving(1, 0);
            }
            if (speedX < -maxSpeed)
            {
                speedX = -maxSpeed;
               
                isChasing = true;

                moving(-1, 0);

            }
            if (speedY > maxSpeed)
            {
                speedY = maxSpeed;

                moving(0, 1);
               
                isChasing = true;
            }
            if (speedY < -maxSpeed)
            {
                speedY = -maxSpeed;

                moving(0, -1);
               
                isChasing = true;
            }
         

            if(target.FaceingDirection == FORWARD)
            {
                y += (int)speedY / 2;
               
            }
            if(target.FaceingDirection == BACKWARD)
            {
                y += (int)speedY / 2;
            }if(target.FaceingDirection == LEFT )
            {
                if (target.FaceingDirection != LEFT)
                    x -= (int)speedX / 2;
                

                y += (int)speedY/2;
            }
            if (target.FaceingDirection == RIGHT)
            {
                if (target.FaceingDirection != RIGHT)
                    x += (int)speedX / 2;


                y += (int)speedY / 2;
            }
          
            if(this.FaceingDirection== IDLE && getTarget().FaceingDirection == IDLE)
            {
                isChasing = false;
                notIsMoving = true;
            }
      

            x +=(int) speedX/2;
            y +=(int) speedY/2;

            return isChasing;          

        }

        protected void turnAround()
        {
            float speedX = (getTarget().X - x),
                  speedY = (getTarget().Y - y);
            float maxSpeed = 4f * DAMPING;



            if (speedX > maxSpeed)
            {
                speedX = maxSpeed;

               
            }
            if (speedX < -maxSpeed)
            {
                speedX = -maxSpeed;

             

            }
            if (speedY > maxSpeed)
            {
                speedY = maxSpeed;
            
            }
            if (speedY < -maxSpeed)
            {
                speedY = -maxSpeed;

            }

            x -=(int) speedX ;
            y -= 0/getTarget().Y ;


        }

        protected void BackAway()
        {
            float speedX = (getTarget().X - x),
                  speedY = (getTarget().Y - y);
            float maxSpeed =4f * DAMPING;



            if (speedX > maxSpeed)
            {
                speedX = maxSpeed;


            }
            if (speedX < -maxSpeed)
            {
                speedX = -maxSpeed;



            }
            if (speedY > maxSpeed)
            {
                speedY = maxSpeed;

            }
            if (speedY < -maxSpeed)
            {
                speedY = -maxSpeed;

            }

           
            x -= ((int)speedX);
         


        }


        public float SightRange
        {
            get { return sightRange; }
            set { sightRange = value; }
        }

        public override void addToRender(SpriteBatch spriteBatch)
        {
            this.HealthBarDraw(spriteBatch);

            this.drawToRender();
            base.addToRender(spriteBatch);
        }



        public void setTarget(StatObject go)
        {
            target = go;
        }
    }

    
}
