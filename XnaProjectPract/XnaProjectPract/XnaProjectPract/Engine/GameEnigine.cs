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
using XnaProjectPract.GameObjects;
using XnaProjectPract.GOItem;


namespace XnaProjectPract.Engine
{
    public static class GameEnigine
    {

        public static void InitGameEngine(ArrayList arg)
        {
            GamePlay.gameplay = new GamePlay(arg);
            
        }

        public static void Init()
        {

            GamePlay.gameplay.Init();
          
        }

        public static void loadContent(SpriteBatch spriteBatch)
        {
            GamePlay.gameplay.loadContent(spriteBatch);

        }

        public static void update(GameTime gameTime)
        {

            GamePlay.gameplay.update(gameTime);
        }

        public static void Input()
        {
            GamePlay.gameplay.Input();

        }

        public static void render(GameTime gameTime)
        {
            GamePlay.gameplay.render(gameTime);
            
           
        }

    }
}
