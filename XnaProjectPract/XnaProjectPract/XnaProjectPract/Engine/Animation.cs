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

namespace XnaProjectPract.Engine
{
    class Animation
    {
        Texture2D animation;
        Rectangle sourceRect;
        Vector2 position;

        float elapsed;
        float frameTime;
        int numOfFrames;
        int currentFrame;
        int width;
        int height;
        int frameWidth;
        int frameHeight;
        bool looping;

        public Animation(ContentManager Content,string assest, float frameSpeed, int numOfFrames,bool looping)
        {
            this.frameTime = frameSpeed;
            this.numOfFrames = numOfFrames;
            this.looping = looping;
            this.animation = Content.Load<Texture2D>(assest);
            frameWidth = (animation.Width / numOfFrames);
            frameHeight = (animation.Height);
            position = new Vector2(100, 100);
        }
        public Animation(ContentManager Content, Texture2D assest, float frameSpeed, int numOfFrames, bool looping)
        {
            this.frameTime = frameSpeed;
            this.numOfFrames = numOfFrames;
            this.looping = looping;
            this.animation = assest;
            frameWidth = (animation.Width / numOfFrames);
            frameHeight = (animation.Height);
            position = new Vector2(100, 100);
        }

        public void PlayAnim(GameTime gametTime)
        {
            elapsed += (float)gametTime.ElapsedGameTime.TotalMilliseconds;
            sourceRect = new Rectangle(currentFrame * frameWidth, 0, frameWidth, frameHeight);

            if(elapsed >= frameTime)
            {
                if(currentFrame >= numOfFrames - 1)
                {
                    if (looping)
                        currentFrame = 0;
                }
                else
                {
                    currentFrame++;
                }
                elapsed = 0;
            }
        }

        public float CurrentFrame
        {
            get { return currentFrame; }
        }
        public float FrameSpeed
        {
            get { return frameTime; }
            set { frameTime = value; }
        }

        public Rectangle AnimationRect()
        {
            return sourceRect;
        }


        public void Draw(SpriteBatch spriteBach)
        {
            spriteBach.Draw(animation, position, sourceRect, Color.White, 0f, new Vector2(0, 0),1f, SpriteEffects.None, 1f);
        }
    }
}
