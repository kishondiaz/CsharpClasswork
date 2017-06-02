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

namespace XnaProjectPract
{
    public class DrawSprite : DrawableGameComponent
    {
        private SpriteBatch spritebatch;
        private Texture2D drawingTexture,newTexture,emptyTexture,hitBoxTexture;
        private Rectangle emptyRectangle,rectSection,drawingRect,hitBox,hitBoxRectSec;
        private Vector2 vec;
        private Color emptyColor,drawingColor,hitBoxColor;
        private Game game;
        private bool hasTexture,hasNewTexture,hasHitBox,isAnimated;
        private SpriteSortMode spriteSortMode;
        private int drawingX,sumX,hitBoxX,hitSumX;
        private int drawingY,sumY,hitBoxY,hitSumY;
        private int drawingWidth,sumW,hitBoxWidth,hitSumW;
        private int drawingHeight,sumH,hitBoxHeight,hitSumH;
        private Animation animeation;
        private int frameNumber;
        private float frameSpeed;
        
      
        private float layerDepth;
        public DrawSprite(Rectangle rect,Color color,Game game):base(game)
        {
            this.game = game;
            DrawOrder = 1000;
            emptyRectangle = rect;
            this.emptyColor = color;
            this.hasTexture = false;
           
        }


        public DrawSprite(Rectangle rect,Rectangle rectSect , Color color, float layerDepth ,Game game,bool hasHitBox)
            : base(game)
        {
            this.game = game;
            DrawOrder = 1000;
            emptyRectangle = rect;
            this.emptyColor = color;
            this.drawingColor = color;
            this.hasHitBox = hasHitBox;
            this.hitBoxColor = color;
            this.frameNumber = 2;

            this.frameSpeed = 250f;
           
            this.hasTexture = false;
            this.isAnimated = false;
            this.rectSection = rectSect;
            this.hitBoxRectSec = rectSect;
            spriteSortMode = new SpriteSortMode();
            spriteSortMode = SpriteSortMode.BackToFront;
            this.layerDepth = layerDepth;
            this.drawingX = 0;
            this.drawingY = 0;
            this.drawingWidth =0;
            this.drawingHeight=0;

            

        }

        public DrawSprite(Texture2D texture,Vector2 vec, Color color, Game game): base(game)
        {
            this.game = game;
            DrawOrder = 1000;
            this.vec = vec;
            this.emptyColor = color;
            this.drawingTexture = texture;
            this.hasNewTexture = false;
        }

        public void Load()
        {

            spritebatch = new SpriteBatch(game.GraphicsDevice);
            emptyTexture = new Texture2D(game.GraphicsDevice, 1, 1);
            emptyTexture.SetData(new Color[] { Color.White });
            hitBoxTexture = new Texture2D(game.GraphicsDevice, 1, 1);
            hitBoxTexture.SetData(new Color[] { Color.White });
            
            if (!emptyRectangle.IsEmpty)
            {
                if (!hasTexture)
                {
                    drawingTexture = new Texture2D(game.GraphicsDevice, 1, 1);
                    drawingTexture.SetData(new Color[] { Color.White });
                }
                else
                {
                    drawingTexture = newTexture;
                }
            }
            animeation = new Animation(game.Content, drawingTexture,frameSpeed, frameNumber, true);

        }
        public int FrameNumber
        {
            get { return frameNumber; }
            set { frameNumber = value; }
        }

        public void setRects(int x, int y, int width, int height)
        {
            drawingRect = new Rectangle(x,y,width,height);

        }
        public Rectangle DrawingRect 
        {
            get { return drawingRect; }
            set { drawingRect = value; } 
        }
        public void setSpriteSortMode(SpriteSortMode spriteSortMode)
        {
            this.spriteSortMode = spriteSortMode;
        }

        public void setTexture(Texture2D texture)
        {
            this.newTexture = texture;
            hasTexture = true;
            hasNewTexture = true;
        }
        public void setTexture(string texture)
        {
            this.newTexture = game.Content.Load<Texture2D>(texture);
            hasTexture = true;
            hasNewTexture = true;
        }
        

        public int X
        {
            get { return emptyRectangle.X; }
            set { emptyRectangle.X = value; }
        }
     

        public int Y
        {
            get { return emptyRectangle.Y; }
            set { emptyRectangle.Y = value; }
        }

        public int DrawImageWidth
        {
            get { return drawingRect.Width; }
        }
        public int DrawImageHeight
        {
            get { return drawingRect.Height; }
        }

        public Color HitBoxColor
        {
            get { return hitBoxColor;}
            set { hitBoxColor = value; }

        }

        public Color DrawImageColor 
        {
            get { return drawingColor; }
            set { drawingColor = value; }
        }

        public Color EmptyColor
        {
            get { return emptyColor; }
            set { emptyColor = value; }
        }
       

        public SpriteBatch DrawSpriteBatch
        {
            get { return spritebatch; }
            set { spritebatch = value; }
        }

     

        public SpriteSortMode DrawSpriteMode
        {
            get { return spriteSortMode; }
            set { spriteSortMode = value; }
        }
      

        public float LayerDepth
        {
            get { return layerDepth; }
            set { layerDepth = value; }
        }

        public Rectangle getIamgeRect()
        {
            return drawingRect;
        }
  

        public int DrawingImageX
        {
            get { return drawingX; }
            set { drawingX = value; }
        }

     

        public int DrawingImageY
        {
            get { return drawingY; }
            set { drawingY = value; }
        }

       

        public int DrawingImageWidth
        {
            get { return drawingWidth; }
            set { drawingWidth = value; }
        }

       

        public Rectangle DrawingImageRectProp
        {
            get { return drawingRect; }
            set { drawingRect = value; }
        }

        public Rectangle HitBoxRectProp
        {
            get { return hitBox; }
            set { hitBox = value; }
        }

        public bool SetAnimation
        {
            get { return isAnimated; }
            set { isAnimated = value; }
        }

        public float CurrentFrame
        {
            get { return animeation.CurrentFrame; }
        }

    

        public int DrawingImageHeight
        {
            get { return drawingHeight; }
            set { drawingHeight = value; }
        }

        public void DrawingImageRectangle(int x, int y, int width, int height)
        {
            sumX = x;
            sumY = y;
            sumW = width;
            sumH = height;
             
        }



        public float FrameSpeed
        {
            get { return frameSpeed; }
            set { animeation.FrameSpeed = value;}
        }

        public SpriteBatch getSpriteBatch()
        {
            return spritebatch;
        }

        public void HitBoxRectangle(int x,int y, int width, int height)
        {
            hitSumX = x;
            hitSumY = y;
            hitSumW = width;
            hitSumH = height;
        }


        public override void Draw(GameTime gameTime)
        {
            
            
            spritebatch.Begin(spriteSortMode,BlendState.AlphaBlend);
            animeation.PlayAnim(gameTime);

            drawingX = emptyRectangle.X + sumX;
            drawingY = emptyRectangle.Y + sumY;
            drawingWidth = emptyRectangle.Width + sumW;
            drawingHeight = emptyRectangle.Height + sumH;


            hitBoxX = emptyRectangle.X + hitSumX;
            hitBoxY = emptyRectangle.Y + hitSumY;
            hitBoxWidth = emptyRectangle.Width + hitSumW;
            hitBoxHeight = emptyRectangle.Height + hitSumH;
            
            drawingRect = new Rectangle(drawingX, drawingY, drawingWidth, drawingHeight);
            hitBox = new Rectangle(hitBoxX, hitBoxY, hitBoxWidth, hitBoxHeight);


            if (hasNewTexture)
                drawingTexture = newTexture;

            if (!emptyRectangle.IsEmpty)
            {
                if (!rectSection.IsEmpty)
                {
                    if (Visible)
                    {
                        if (hasHitBox)
                            spritebatch.Draw(hitBoxTexture, hitBox, drawingRect, hitBoxColor, 0, Vector2.Zero, SpriteEffects.None, layerDepth);

                        //Drawing rectangle this is thwe rectangle that holds the image that is drawn on the screen
                        if (!isAnimated)
                            spritebatch.Draw(drawingTexture, drawingRect, rectSection, drawingColor, 0, Vector2.Zero, SpriteEffects.None, layerDepth);
                        else
                        {
                            //Animation 
                            spritebatch.Draw(drawingTexture, drawingRect, animeation.AnimationRect(), drawingColor, 0, Vector2.Zero, SpriteEffects.None, layerDepth);
                        }

                        //MoveMent Rectangle this is the anchor of the GameObject
                        spritebatch.Draw(emptyTexture, emptyRectangle, rectSection, emptyColor, 0, Vector2.Zero, SpriteEffects.None, layerDepth);
                    }
                }
                else
                {
                    if (Visible)
                    {
                        spritebatch.Draw(hitBoxTexture, hitBox, null, hitBoxColor, 0, Vector2.Zero, SpriteEffects.None, layerDepth);

                        //Drawing rectangle this is thwe rectangle that holds the image that is drawn on the screen

                        spritebatch.Draw(drawingTexture, drawingRect, null, drawingColor, 0, Vector2.Zero, SpriteEffects.None, layerDepth);





                        //MoveMent Rectangle this is the anchor of the GameObject
                        spritebatch.Draw(emptyTexture, emptyRectangle, null, emptyColor, 0, Vector2.Zero, SpriteEffects.None, layerDepth);
                    }
                }
            }
            else
            {
                if (hasNewTexture)
                    drawingTexture = newTexture;
                spritebatch.Draw(drawingTexture, this.vec, emptyColor);
            }

           
           
            spritebatch.End();
        }
    }
}
