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


namespace XnaProjectPract.Engine
{
    public abstract class GameObject
    {
        public const int DEFAULT_ID = 0, ITEM_ID = 1, PLAYER_ID = 2, ENEMY_ID = 3,WALL_ID=4,FLOOR_ID=5;
        protected const int IDLE = 0, FORWARD = 1, BACKWARD = 2, LEFT = 3, RIGHT = 4,DIAGNOL=5,ATTACKING =6;

        private int facingDirection;
        protected int type,layerDepth;
        protected int lastPosition,aboveOrBelow;
        protected float frameSpeed;

        private DrawSprite draw;
        private Rectangle rec;
        protected string objectInfo;
        private List<GameObject> objects;

        protected bool[] flag = new bool[2];
        public bool inFrontOrBack;
        protected static int Counter = 0,previousCount;

 

        protected int x,y,widthX,heightY;

        public virtual void Initialzation()
        {

        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int FaceingDirection
        {
            get { return facingDirection; }
            set { facingDirection = value; } 
        }

  

        public int LayerLevel
        {
            get { return layerDepth; }
            set { layerDepth = value; }
        }

       

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    

        public int Width
        {
            get { return widthX; }
            set { widthX = value; }
        }

     

        public int Height
        {
            get { return heightY; }
            set { heightY = value; }
        }
        public int Count
        {
            get { return Counter; }
            set { Counter = value; }
        }

        public static int Length
        {
            get { return previousCount; }
           // set { previousCount = value; }
        }
     

        public virtual void render(GameTime gameTime)
        {
            
            draw.Draw(gameTime);
            addToRender(draw.getSpriteBatch());
            drawUpdate();
         
        }

        public virtual void addToRender(SpriteBatch spriteBatch)
        {

        }

        private void drawUpdate()
        {
            draw.X = x;
            draw.Y = y;
            draw.FrameSpeed = frameSpeed;

        }

        public int LastPosition
        {
            get { return lastPosition; }
            set { lastPosition = value; }
        }
        public int AboveOrBelow
        {
            get { return aboveOrBelow;}
            set { aboveOrBelow = value;}
        }


        public int DrawImageRectX
        {
            get { return draw.DrawingImageX ; }
            set { this.draw.DrawingImageX = value; }
        }
        public int FrameNumber
        {
            get { return draw.FrameNumber; }
            set { draw.FrameNumber = value; }
        }
        


        public int DarwImageRectY
        {
            get { return draw.DrawingImageY ; }
            set { draw.DrawingImageY = value; }
        }


     

        public int DrawImageRectWidth
        {
            get { return draw.DrawingImageWidth; }
            set { draw.DrawingImageWidth = value; }
        }

     

        public int DrawImageRectHeight
        {
            get { return draw.DrawingImageHeight; }
            set { draw.DrawingImageHeight = value; }
        }

       
        public Rectangle DrawImageRect
        {
            get { return draw.DrawingRect; }
            set { draw.DrawingRect = value;}
        }

        public Rectangle getDrawIamgeRect()
        {
            return draw.getIamgeRect();
        }

        public Rectangle DrawImageRectProp
        {
            get { return draw.DrawingImageRectProp; }
            set { draw.DrawingImageRectProp = value; }
        }

        public Rectangle HitBoxRectProp
        {
            get { return draw.HitBoxRectProp; }
            set { draw.HitBoxRectProp = value; }
        }

        public DrawSprite DrawSpriteClass
        {
            get { return draw; }
            set { draw = value; }
        }

       

        public float LayerDepth
        {
            get { return draw.LayerDepth; }
            set { draw.LayerDepth = value; }
        }


        public int DrawnOrder
        {
            get { return draw.DrawOrder; }
            set { draw.DrawOrder = value; }
        }

        public void DrawImageRectangle(int x, int y, int width, int height)
        {
            draw.DrawingImageRectangle(x, y, width, height);

        }

        public void HitBoxRectangle(int x, int y, int width, int height)
        {
            draw.HitBoxRectangle(x, y, width, height);
        }

        public int DrawImageHeight
        {
            get { return draw.DrawImageHeight; }
        }

        public int DrawImageWidth
        {
            get { return draw.DrawImageWidth; }
        }
        

        public SpriteBatch GameObjectSpritBatch
        {
            get { return draw.DrawSpriteBatch ; }
            set { draw.DrawSpriteBatch = value; }
        }

        public SpriteSortMode GameObjectSpriteDrawMode 
        {
            get { return draw.DrawSpriteMode; }
            set { draw.DrawSpriteMode = value; } 
        }

        public void setSpritSortMode(SpriteSortMode spriteSortMode)
        {
            draw.setSpriteSortMode(spriteSortMode);
        }


        public void setTexture(Texture2D texture2d)
        {
            draw.setTexture(texture2d);
        }

        public void setTexture(string texture)
        {
            draw.setTexture(texture);
        }

        public bool getRemove()
        {
             return flag[0]; 
        }

        public int getType()
        {
            return type;
        }

        public int Type
        {
            get { return type; }
            
        }

        public void remove()
        {
            flag[0] = true;
        }

        public void setRects(int x, int y, int width, int height)
        {
            draw.setRects(x, y, width, height);
        }
        public void setSolid(bool value)
        {
            flag[1] = value;
        }

        public bool isSolid()
        {
            return flag[1];
        }

        public virtual void update(GameTime gameTime)
        {
           
            render(gameTime);
            
        }

        public List< GameObject> Objects
        {
            get { return objects; }
            set { objects = value; }
        }
        
        public bool SetAnimated
        {
            get { return draw.SetAnimation; }
            set { draw.SetAnimation = value; }
        }
        public virtual void load(SpriteBatch spriteBatch)
        {
            draw.Load();
            
        }

        public virtual void init(int x, int y, int width, int height,Rectangle recSect, Color color, Game game,float layerDepth,int type,bool hitBox)
        {
            this.x = x;
            this.y = y;
            this.type = type;
            rec = new Rectangle(x, y, width, height);
            draw = new DrawSprite(rec,recSect,color,layerDepth, game,hitBox);
            inFrontOrBack = false;
            frameSpeed = draw.FrameSpeed;
            previousCount = Counter;
        }

        public override string ToString()
        {
            return objectInfo;
        }

    }
}
