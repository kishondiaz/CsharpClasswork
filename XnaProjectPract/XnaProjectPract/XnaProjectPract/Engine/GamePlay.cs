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
using System.Drawing;
using System.Collections;
using XnaProjectPract.GameObjects;
using XnaProjectPract.GOItem;
using XnaProjectPract.StatObjects;

namespace XnaProjectPract.Engine
{

    class GamePlay:Game
    {
        public static GamePlay gameplay;
        ContentManager content;
        Game XNAGame;
        GraphicsDeviceManager graphic;
        SpriteBatch spriteBatch;
        Texture2D texture2d, enemyTexture,wallTexture;
        RectangleOverlay rect;
        DrawSprite draw, newDraw;
        List<GameObject> objects,newObjects;
        List<GameObject> remove;
        Player player;
        Enemy enemy,reserveredEnemy;
        bool removed = false;
        int enemeyCount = 0;

        public GamePlay(ArrayList arg)
        {
            XNAGame = (Game1)arg[0];
            graphic = (GraphicsDeviceManager)arg[1];

            objects = new List<GameObject>();
            newObjects = new List<GameObject>();
            remove = new List<GameObject>();

        }
        public void Init()
        {

            graphic.PreferredBackBufferHeight = 800;
            graphic.PreferredBackBufferWidth = 1200;
            graphic.ApplyChanges();

            foreach (GameObject go in objects)
            {
                go.Initialzation();
                
            }
        }

        public void loadContent(SpriteBatch spriteBatch)
        {

            this.spriteBatch = spriteBatch;

            texture2d = XNAGame.Content.Load<Texture2D>("ashshowpic");

            wallTexture = XNAGame.Content.Load<Texture2D>("historic-front-street");

            enemyTexture = new Texture2D(XNAGame.GraphicsDevice, 1, 1);
            enemyTexture.SetData(new Microsoft.Xna.Framework.Color[] { Microsoft.Xna.Framework.Color.White });
            player = new Player(0, 400, 60, 48, new Microsoft.Xna.Framework.Rectangle(0, 0, 60, 86), Microsoft.Xna.Framework.Color.White, XNAGame, 0);
         
            Enemy enemy2 = new Enemy(700,650,60,48,new Microsoft.Xna.Framework.Rectangle(0,0,60,86),Microsoft.Xna.Framework.Color.Green,XNAGame,1);
            enemy = new Enemy(300, 400, 60, 48, new Microsoft.Xna.Framework.Rectangle(0, 0, 60, 86), Microsoft.Xna.Framework.Color.Red, XNAGame, 0);
            reserveredEnemy = new Enemy(1200, 390, 60, 48, new Microsoft.Xna.Framework.Rectangle(0, 0, 60, 86), Microsoft.Xna.Framework.Color.Cyan, XNAGame, 0);
            Item item = new Item(80, 600, 40, 40, Microsoft.Xna.Framework.Color.White, XNAGame);
            WallBounds bounds = new WallBounds(0, 759, 3000, 60,Microsoft.Xna.Framework.Color.White,XNAGame);
            WallBounds bounds2 = new WallBounds(-60,0, 60, 808, Microsoft.Xna.Framework.Color.White, XNAGame);
            Wall wall = new Wall(0, 0, 3000, 380,new Microsoft.Xna.Framework.Rectangle(0,180,890,52),Microsoft.Xna.Framework.Color.White, XNAGame);
            Floor floor1 = new Floor(0, 350, 3000, 500, Microsoft.Xna.Framework.Color.Gray, XNAGame);

            objects.Add(floor1);
            objects.Add(bounds2);
            objects.Add(bounds);
            objects.Add(wall);
            objects.Add(item);
            objects.Add(reserveredEnemy);
            objects.Add(enemy2);
            objects.Add(enemy);
           
            objects.Add(player);

            wall.setTexture(wallTexture);


            foreach (GameObject go in objects)
            {
                go.load(spriteBatch);

            }
      

        }

        public void update(GameTime gameTime)
        {
            Input();
            objects = objects.OrderBy(o => o.LayerLevel).ToList();

            
            foreach (GameObject go in objects)
            {
              

                if (!go.getRemove())
                {
                   
                   
                    if(go.getType() == GameObject.ENEMY_ID)
                    {
                 

                        enemeyCount = go.Count;

                    }
                  
                    go.update(gameTime);
                }
                else
                {
                    
                    remove.Add(go);
                }


            }

            
            foreach (GameObject go in remove)
            {
                if (go.getType() == GameObject.ENEMY_ID)
                {
                    go.Count -= 1;
                    enemeyCount = go.Count;


                }
                 objects.Remove(go);
                 removed = true;
                 
                
            }

          
            if (enemeyCount < GameObject.Length)
            {
                reserveredEnemy.SightRange = 1600;
            }
            if(removed)
            {
                remove.Clear();
                removed = false;
            }

           
          
        }

        public void Input()
        {
            player.input();

        }

        public void render(GameTime gameTime)
        {
            XNAGame.GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.CornflowerBlue);


            spriteBatch.Begin();
            foreach (GameObject go in objects)
            {
                go.render(gameTime);


            }
            spriteBatch.End();

        }


        public static List<GameObject> sphereCollide(float x, float y, float radius)
        {
            List<GameObject> result = new List<GameObject>();

            foreach (GameObject go in gameplay.objects)
            {
                if (Util.dist(go.X, go.Y, x, y) < radius)
                {
                    result.Add(go);
                }

            }

            return result;
        }

        public static List<GameObject> rectangleCollide(float x1, float y1, float x2, float y2)
        {
            List<GameObject> results = new List<GameObject>();

            float sizeX = x2 - x1;
            float sizeY = y2 - y1;

            System.Drawing.Rectangle collider = new System.Drawing.Rectangle((int)x1, (int)y1, (int)sizeX, (int)sizeY);

            foreach (GameObject go in gameplay.objects)
            {
                if (Physics.checkCollision(collider, go) != null)
                {
                    results.Add(go);


                }

            }

            return results;
        }

        
    }
}
