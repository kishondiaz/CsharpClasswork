using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XnaProjectPract
{
    class RectangleOverlay : DrawableGameComponent
    {
        protected SpriteBatch spriteBatch;
        protected Texture2D dummyTexture;
        protected Rectangle dummyRectangle;
        protected Color Colori;
        protected Game game;

        public RectangleOverlay(Rectangle rect, Color colori, Game game)
            : base(game)
        {
            // Choose a high number, so we will draw on top of other components.
            this.game = game;
            DrawOrder = 1000;
            dummyRectangle = rect;
            Colori = colori;
        }
        public RectangleOverlay(int x,int y, int width, int height , Color colori, Game game)
            : base(game)
        {
            // Choose a high number, so we will draw on top of other components.
            this.game = game;
            DrawOrder = 1000;
            dummyRectangle = new Rectangle(x, y, width, height);
            Colori = colori;
        }

        public void Load()
        {
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
            dummyTexture = new Texture2D(game.GraphicsDevice, 1, 1);
            dummyTexture.SetData(new Color[] { Color.White });
        }

        public Rectangle Rect
        {
            get { return dummyRectangle; }
            set { dummyRectangle = value; }
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
            dummyTexture = new Texture2D(game.GraphicsDevice, 1, 1);
            dummyTexture.SetData(new Color[] { Color.White });
            base.LoadContent();
        }

        public void Draw()
        {
            spriteBatch.Begin();
            if(Visible)
                spriteBatch.Draw(dummyTexture, dummyRectangle, Colori);
            spriteBatch.End();
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(dummyTexture, dummyRectangle, Colori);
            spriteBatch.End();
        }
    }
}
