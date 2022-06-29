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

namespace Potate_O //Made by Eugene Potato Kim
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics; //These are all random variables that hold songs, sound effects, pictures, etc. Everything. Don't touch.
        SpriteBatch spriteBatch;
        int miles = 3000;
        int randY, randX;
        Song mineturtlesong;
        Song dubstep;
        SoundEffect effect7;
        Song bossbattlemusic;
        Random random = new Random();
        Song nyancat;
        Song gangnamstyle;
        Song castlemusic;
        int bossgenerator = 0;
        Map map;
        Player player;
        int level8generator = 0;
        int level7generator = 0;
        SoundEffect effect;
        SoundEffect effect2;
        SoundEffect effect3;
        SoundEffect effect6;
        int level5generator = 0;
        Song sky;
        SoundEffect effect4;
        SoundEffect effect5;
        int level3generator = 0;
        Camera camera;
        Camera1 camera1;
public string upgrade;
        int deadwait = 0;
        int riddle;
        Texture2D background;
        Texture2D title;
        Texture2D house;
        Texture2D letter;
        Texture2D titleText;
        Rectangle titleTxt;
         int riddlewait = 0;
        int level2generator = 0;
        Rectangle gate;
        List<Enemy> enemies = new List<Enemy>();
        Vector2 textposition;
        bool turtleremove;
        Boolean menu;
        Rectangle gate2;
        Texture2D boxman2;
        int level6generator = 0;
        Rectangle backrect;
        Rectangle houserect;
        Rectangle letterect;
        int minigamegenerator = 0;
        Texture2D objectives;
        Texture2D castleTexture;
        Rectangle objbox;
        Rectangle startR;
        Rectangle exitR;
        Rectangle castle;
        Texture2D back;
        Rectangle backR;
        Song underground;
        Texture2D letter2;
        Song mario;
        Texture2D start;
        Texture2D exit;
        Song pokemon;
        String lastlevel;
        Scrolling scrolling1;
        SpriteFont font;
        List <SpaceEnemy> catList = new List <SpaceEnemy>();
        int letterwait = 0;
        int instructwait = 0;
        GameSpriteStruct[] icecream;
        Texture2D iceTexture;
        Texture2D boxman;
        KeyboardState oldkeys;
        Scrolling scrolling2;
        List<Rectangle> lavaR = new List<Rectangle>(); 
        List<IceCream> icecreams = new List<IceCream>();
        Ship ship = new Ship();
        Texture2D lava;
        string lastgamestate;
        int score = 0;
        int level1generator = 0;
        int introgenerator = 0;
        int level4generator = 0;
        string camerastate;
        string gamestate;
        int finalgenerator = 0;
        string buttonstate;
        List<Enemy> enemies2 = new List<Enemy>();
        List<Bullets> bullets = new List<Bullets>();
        string nextgamestate;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        struct GameSpriteStruct
        {
            public Texture2D SpriteTexture;
            public Rectangle SpriteRectangle;
            public float X;
            public float Y;
            public float XSpeed;
            public float YSpeed;
            public float WidthFactor;
            public float TicksToCrossScreen;
            public bool Visible;
        }


        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            map = new Map();
            player = new Player();

            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 800;
            //graphics.IsFullScreen = true;
            graphics.ApplyChanges();
            icecream = new GameSpriteStruct[5];

            base.Initialize();


        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent() //Loads most of the items.
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            back = Content.Load<Texture2D>("back");
            Tiles.Content = Content;
            effect7 = Content.Load<SoundEffect>("win");
            castlemusic = Content.Load<Song>("castlemusic");
            scrolling1 = new Scrolling(Content.Load<Texture2D>("background"), new Rectangle(0, 0, 1280, 1007));
            scrolling2 = new Scrolling(Content.Load<Texture2D>("background"), new Rectangle(1280, 0, 1280, 1007));
            castleTexture = Content.Load<Texture2D>("castle");
            mineturtlesong = Content.Load<Song>("mineturtlesong");
           bossbattlemusic = Content.Load<Song>("marioboss");
            effect = Content.Load<SoundEffect>("Jump");
            effect6 = Content.Load<SoundEffect>("explode");
            nyancat = Content.Load<Song>("NyanCat");
            gangnamstyle = Content.Load<Song>("gangnam");
            mario = Content.Load<Song>("mario");
            dubstep = Content.Load<Song>("dubstep");
            sky = Content.Load<Song>("skyMusic");
            pokemon = Content.Load<Song>("pokemon");
            underground = Content.Load<Song>("underground");
            effect2= Content.Load<SoundEffect>("Plop");
            effect3 = Content.Load<SoundEffect>("Boom");
            effect4= Content.Load<SoundEffect>("Coin");
            effect5 = Content.Load<SoundEffect>("dead");
            lava = Content.Load<Texture2D>("lava");
            boxman = Content.Load<Texture2D>("gate");
            buttonstate = "start";
            start = Content.Load<Texture2D>("start");
            exit = Content.Load<Texture2D>("exit");
            lavaR.Add(new Rectangle(0, 0, 0,0));
           backR = new Rectangle(300, 225, 175, 75);
            startR = new Rectangle(300, 325, 175, 75);
            exitR = new Rectangle(300, 425, 175, 75);

            font = Content.Load<SpriteFont>("SpriteFont1");
            camera = new Camera(GraphicsDevice.Viewport);
            camera1 = new Camera1(GraphicsDevice.Viewport);

            background = Content.Load<Texture2D>("sky");
            boxman2 = Content.Load<Texture2D>("troll");

            gate2 = new Rectangle(2800, 915, 100, 115);
            title = Content.Load<Texture2D>("titleBack");
            house = Content.Load<Texture2D>("castle");
            letter = Content.Load<Texture2D>("note1");
            letter2 = Content.Load<Texture2D>("note2");

           titleText = Content.Load<Texture2D>("title1");
            titleTxt = new Rectangle(50, 150, 700, 125);

            backrect = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);

           houserect = new Rectangle(1125, 135, 250, 250);


           objectives= Content.Load<Texture2D>("objectives");

            //background = Content.Load<Texture2D>("background1");
            iceTexture = Content.Load<Texture2D>("smallice");

            camerastate = "camera";

            gamestate = "title";

            for (int i = 0; i < 5; i++)
            {
                icecream[i].SpriteTexture = iceTexture;
                setupSprite(ref icecream[i], 0.03f, 1000.0f, i * 1000 / 5, 100.0f, true);
                //setupSprite(ref icecream[i], 0.03f, 1000.0f, i * GraphicsDevice.Viewport.Width / 5, 100.0f, true);
            }

            player.Load(Content);
            ship.LoadContent(Content);

            // TODO: use this.Content to load your game content here
        }

        void setupSprite(ref GameSpriteStruct sprite, float widthFactor, float ticksToCrossScreen, float initialX, float initialY, bool initialVisibility)
        {
            sprite.WidthFactor = widthFactor;
            sprite.TicksToCrossScreen = ticksToCrossScreen;
            sprite.SpriteRectangle.Width = (int)((GraphicsDevice.Viewport.Width * widthFactor) + 0.5f);
            float aspectRatio = (float)sprite.SpriteTexture.Width / sprite.SpriteTexture.Height;
            sprite.SpriteRectangle.Height = (int)((sprite.SpriteRectangle.Width / aspectRatio) + 0.5f);
            sprite.X = initialX;
            sprite.Y = initialY;
            sprite.SpriteRectangle.X = (int)sprite.X;
            sprite.SpriteRectangle.Y = (int)sprite.Y;
            sprite.XSpeed = GraphicsDevice.Viewport.Width / ticksToCrossScreen;
            sprite.YSpeed = sprite.XSpeed;
            sprite.Visible = initialVisibility;
        }

        void drawText(string text, SpriteFont textFont, Color textColor, float x, float y)
        {
            Vector2 textVector = new Vector2(x, y);
            spriteBatch.DrawString(textFont, text, textVector, textColor);
        }
        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();

            MediaState media = MediaPlayer.State;

            KeyboardState keys = Keyboard.GetState();

            // TODO: Add your update logic here

            if (gamestate != "level1" && gamestate != "menu" && gamestate != "instructions" && lastgamestate != "level1") //These basically reset the game. Or at least help to.
            {
                level1generator = 0;
            }
            if (gamestate != "level2" && gamestate != "menu" && gamestate != "instructions"  && lastgamestate != "level2")
            {
                level2generator = 0;
            }
            if (gamestate != "level3" && gamestate != "menu" && gamestate != "instructions"  && lastgamestate != "level3")
            {
                level3generator = 0;
            }
            if (gamestate != "level4" && gamestate != "menu" && gamestate != "instructions"  && lastgamestate != "level4")
            {
                level4generator = 0;
            }
            if (gamestate != "level5" && gamestate != "menu" && gamestate != "instructions" && lastgamestate != "level5")
            {
                level5generator = 0;
            }
            if (gamestate != "level6" && gamestate != "menu" && gamestate != "instructions"  && lastgamestate != "level6")
            {
                level6generator = 0;
            }
            if (gamestate != "level7" && gamestate != "menu" && gamestate != "instructions"  && lastgamestate != "level7") 
            {
                level7generator = 0;
            }
            if (gamestate != "level8" && gamestate != "menu" && gamestate != "instructions"  && lastgamestate != "level8")
            {
                level8generator = 0;
            }
            if (gamestate != "boss" && gamestate != "menu" && gamestate != "instructions"  && lastgamestate != "boss")
            {
                bossgenerator = 0;
            }
            if (gamestate != "intro" && gamestate != "menu" && gamestate != "instructions"  && lastgamestate != "intro")
            {
               introgenerator = 0;
            }
            if (gamestate != "final" && gamestate != "menu" && gamestate != "instructions"  && lastgamestate != "final")
            {
                finalgenerator = 0;
            }
            if (gamestate == "dead")
            {
                deadwait++;

                if (deadwait ==1)
                    buttonstate = "yes";
                if (buttonstate == "yes" && keys.IsKeyDown(Keys.S) && deadwait > 120)
                {
                    effect2.Play();
                    buttonstate = "exit";
                }
                if (buttonstate == "exit" && keys.IsKeyDown(Keys.W) && deadwait > 120)
                {
                    effect2.Play();
                    buttonstate = "yes";
                }
            }

            if (gamestate == "dead")
            {
                deadwait++;
            }
            if (gamestate != "dead")
                deadwait = 0;

            foreach (IceCream icecream in icecreams)
                if (player.rectangle.Intersects(icecream.rectangle))
                {
                    if (icecream.rectangle.Width != 0)
                    {
                        score += 1;
                        effect4.Play();
                    }
                    icecream.rectangle.Width = 0;
                    icecream.rectangle.Height = 0;
                }

            if (Keyboard.GetState().IsKeyDown(Keys.Enter) && gamestate == "title" &&  buttonstate == "start")
            {
                effect2.Play();
                gamestate = "letter";
                buttonstate = "instructions";
            }

            if (buttonstate == "start" && Keyboard.GetState().IsKeyDown(Keys.S) && gamestate == "title")
            {
                effect2.Play();
                buttonstate = "exit";
            }

            if (buttonstate == "exit" && Keyboard.GetState().IsKeyDown(Keys.W) && gamestate == "title")
            {
                effect2.Play();
                buttonstate = "start";
            }


            if (buttonstate == "instructions" && Keyboard.GetState().IsKeyDown(Keys.S) && oldkeys.IsKeyUp(Keys.S) && gamestate == "menu")
            {
                effect2.Play();
                buttonstate = "exit";
            }

            if (buttonstate == "instructions" && Keyboard.GetState().IsKeyDown(Keys.W) && oldkeys.IsKeyUp(Keys.W) && gamestate == "menu")
            {
                effect2.Play();
                buttonstate = "back";
            }

            if (buttonstate == "back" && Keyboard.GetState().IsKeyDown(Keys.S) && oldkeys.IsKeyUp(Keys.S) && gamestate == "menu")
            {
                effect2.Play();
                buttonstate = "instructions";
              
            }

            if (buttonstate == "exit" && Keyboard.GetState().IsKeyDown(Keys.W) && oldkeys.IsKeyUp(Keys.W) && gamestate == "menu")
            {
                effect2.Play();
                buttonstate = "instructions";
            }

            if (buttonstate == "instructions" && Keyboard.GetState().IsKeyDown(Keys.Enter) && gamestate == "menu")
            {
                effect2.Play();
                gamestate = "instructions";
            }
            if (buttonstate == "exit" && Keyboard.GetState().IsKeyDown(Keys.Enter))
                this.Exit();
            if (buttonstate == "back" && Keyboard.GetState().IsKeyDown(Keys.Enter) && gamestate == "menu")
            {
                effect2.Play();
                gamestate = lastgamestate;

                if (lastgamestate == "level6" || lastgamestate == "level7" || lastgamestate == "level8" || lastgamestate == "minigame1" || lastgamestate == "level5" || lastgamestate == "level1" || lastgamestate == "level2" || lastgamestate == "intro" || lastgamestate == "level3" || lastgamestate == "level4" || lastgamestate == "boss")
                    MediaPlayer.Resume();
            }

            if(gamestate == "letter")
                letterwait++;
            if (menu != true)
                menu = false;

            if (gamestate != "letter" && gamestate != "start" && gamestate != "dead" && gamestate != "intro" && gamestate != "riddle" && gamestate != "win" && gamestate != "note" && gamestate != "instructions" && Keyboard.GetState().IsKeyDown(Keys.X))
            {
                if (gamestate != "menu")
                    effect2.Play();
                //gamestate = "instructions";
                instructwait = 0;
                //menu = true;
                gamestate = "menu";
                buttonstate = "instructions";
                if (lastgamestate == "level6" || lastgamestate == "level7" || lastgamestate == "level8" || lastgamestate == "minigame1" || lastgamestate == "level5" || lastgamestate == "level1" || lastgamestate == "boss"|| lastgamestate == "level2" || lastgamestate == "intro" || lastgamestate == "level3" || lastgamestate == "level4")
                    MediaPlayer.Pause();
            }

            
            
            if (Keyboard.GetState().IsKeyDown(Keys.Enter) && gamestate == "letter" && letterwait > 60 && player.position.X > 1000)
            {
                effect2.Play();
                gamestate = "instructions";
                lastgamestate = "letter";
            }

            if (gamestate == "instructions")
                instructwait++;

       

            if (Keyboard.GetState().IsKeyDown(Keys.Enter) && gamestate == "instructions" && instructwait > 60 && lastgamestate == "letter")
            {
                effect2.Play();
                gamestate = "level1";
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Enter) && gamestate == "instructions" && instructwait > 60 && lastgamestate != "letter")
            {
                effect2.Play();
                gamestate = lastgamestate;

                if (lastgamestate == "level6" || lastgamestate == "level7" || lastgamestate == "level8" || lastgamestate == "minigame1" || lastgamestate == "level5" || lastgamestate == "level1" || lastgamestate == "level2" || lastgamestate == "intro" || lastgamestate == "level3" || lastgamestate == "level4")
                    MediaPlayer.Resume();
            }


            if (Keyboard.GetState().IsKeyDown(Keys.Enter) && gamestate == "letter" && letterwait > 60)
            {
                effect2.Play();
                gamestate = "intro";
                letter = letter2;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Enter) && deadwait > 120 && gamestate == "dead" && buttonstate == "yes")
            {
                effect2.Play();
                gamestate = lastgamestate;
                player.position = new Vector2(100, 0);
                if (lastgamestate == "level1")
                {
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(1000, 240)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(1200, 240)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(1416, 368)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(2000, 368)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(2579, 368)));
                }
                if (lastgamestate == "level4")
                {
                    foreach (Enemy enemy in enemies)
                    {

                        enemy.position.X = 100000;
                    }
                    enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(400, 335), 150));
                                        //enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(600, 335), 150));
                    enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(800, 335), 150));

                }
                if (lastgamestate == "level6")
                {
                    foreach (Enemy enemy in enemies)
                    {

                        enemy.position.X = 100000;
                    }
                    enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(700, 335), 150));
                    //enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(950, 320), 150));
                    enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(1200, 310), 150));
                    enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(1800, 335), 150));
                    //enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(2000, 320), 150));
                    //enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(2300, 310), 150));
                }
                if (lastgamestate == "level7")
                {
                    foreach (Enemy enemy in enemies)
                    {

                        enemy.position.X = 100000;
                    }
                    foreach (IceCream icecream in icecreams)
                    {
                        icecream.rectangle.X = 100000;
                    }
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(2442, 180)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(594, 200)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(3139, 60)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(2060, 180)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(4230, 928)));
                    enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(3340, 250), 160));
                    enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(5000, 250), 160));
                    //enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(950, 320), 150));
                    //enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(1200, 310), 150));
                    //enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(1800, 335), 150));
                    //enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(2000, 320), 150));
                    //enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(2300, 310), 150));
                }
                if (lastgamestate == "boss")
                {
                    foreach (Enemy enemy in enemies)
                    {

                        enemy.position.X = 100000;
                    } 
                    foreach (Enemy enemy in enemies2)
                    {

                        enemy.position.X = 100000;
                    }
                    enemies.Add(new Enemy(Content.Load<Texture2D>("carrot1"), new Vector2(400, 250), 160));
                    enemies2.Add(new Enemy(Content.Load<Texture2D>("psy"), new Vector2(300, 300), 160));
                    enemies2.Add(new Enemy(Content.Load<Texture2D>("psy"), new Vector2(600, 300), 160));
                }
            }

            if (gamestate == "intro")
            {
                if (MediaPlayer.State.ToString() == "Stopped")
                    MediaPlayer.Play(pokemon);

                if (player.position.X > 1000 && Keyboard.GetState().IsKeyDown(Keys.Enter))
                {MediaPlayer.Stop();
                    effect2.Play();
                    letterwait = 0;
                    gamestate = "letter";  
                }
                lastgamestate = "intro";
                player.Update(gameTime, effect);
         
               

                /*
                if (player.position.X - enemy.position.X >= -200 && player.position.X - enemy.position.X <= 200)
                {
                    if (player.position.X - enemy.position.X < -1)
                        enemy.velocity.X = -1f;
                    if (player.position.X - enemy.position.X > 1)
                        enemy.velocity.X = 1f;
                    else if (player.position.X - enemy.position.X == 0)
                    {
                        enemy.velocity.X = 0f;
                    }
                }
                */
                introgenerator++;

                backrect = new Rectangle(0, -(GraphicsDevice.Viewport.Height / 4), map.Width, GraphicsDevice.Viewport.Height + map.Height);

                foreach (CollisionTiles tile in map.CollisionTiles)
                {
                    player.Collision(tile.Rectangle, map.Width, map.Height);
                    if (camerastate == "camera")
                    {
                        camera.Update(player.Position, map.Width, map.Height);
                    }
                }
                //backrect = new Rectangle(0, 250 -(GraphicsDevice.Viewport.Height), map.Width, GraphicsDevice.Viewport.Height + map.Height);
                if (Keyboard.GetState().IsKeyDown(Keys.Q))
                    camerastate = "camera";

                if (camerastate == "camera1")
                {
                    camera1.Update(player.Position);

                }
                if (introgenerator == 1)
                {
                    background = Content.Load<Texture2D>("sky");
                    houserect = new Rectangle(1050, -100, 350, 500);
                    house = Content.Load<Texture2D>("castle");
                    map.Dispose();
                    map.Generate(new int[,]{
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
                {2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
            }, 64);
                    player.Load(Content);

                    score = 0;


                }




                if (player.position.Y > (map.Height - player.rectangle.Height) - 1)
                {
                    effect5.Play();
                    gamestate = "dead";
                }

                objbox = new Rectangle((int)camera.center.X - 375, (int)camera.center.Y - 275, 250, 150);
                oldkeys = keys;
            }
            // TODO: use this.Content to load your game content here

            if (gamestate == "level1")
            {
                if (MediaPlayer.State.ToString() == "Stopped")
                    MediaPlayer.Play(mario);
                lastgamestate = "level1";
                /*
                if (scrolling1.rectangle.X + scrolling1.texture.Width <= (int)camera.center.X - 400)
                {
                    scrolling1.rectangle.X = scrolling2.rectangle.X + scrolling2.texture.Width;
                }
                if (scrolling2.rectangle.X + scrolling2.texture.Width <= (int)camera.center.X - 400)
                {
                    scrolling2.rectangle.X = scrolling1.rectangle.X + scrolling1.texture.Width;
                }
                scrolling1.Update();
                scrolling2.Update();
                 */

                player.Update(gameTime, effect);
                level1generator++;
                backrect = new Rectangle(0, -(GraphicsDevice.Viewport.Height / 4), map.Width, GraphicsDevice.Viewport.Height + map.Height * 2 + 500);
                background = Content.Load<Texture2D>("background");




                foreach (CollisionTiles tile in map.CollisionTiles)
                {
                    player.Collision(tile.Rectangle, map.Width, map.Height);
                    if (camerastate == "camera")
                    {
                        camera.Update(player.Position, map.Width, map.Height);
                    }
                }
                //backrect = new Rectangle(0, 250 -(GraphicsDevice.Viewport.Height), map.Width, GraphicsDevice.Viewport.Height + map.Height);

                if (level1generator == 1)
                {
                    map.Generate(new int[,]{
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,3,3},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,3,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,2,2,0,2,2,2,2,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1,2,2,2,2,2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            }, 64);
                    
                    player.Load(Content);
                    player.position = new Vector2(100, 180);
                    score = 0;
                    gate = new Rectangle(2680, -5, 135, 135);
                    boxman = Content.Load<Texture2D>("gate");
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(1000, 240)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(1200, 240)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(1416, 368)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(2000, 368)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(2579, 368)));
                }



                if (player.position.Y > (map.Height - player.rectangle.Height) - 1)
                {
                    gamestate = "dead";
                }
                if (player.position.X > 2500 && player.position.Y < 200 && score >= 5 && keys.IsKeyDown(Keys.Enter))
                {
                    MediaPlayer.Stop();
                    effect2.Play();
                    player.position.X = 100;
                    gamestate = "level2"; 
                }




                objbox = new Rectangle((int)camera.center.X - 375, (int)camera.center.Y - 275, 250, 150);
                oldkeys = keys;
            }

            if (gamestate == "level2")
            {
                if(MediaPlayer.State.ToString() == "Stopped")
                    MediaPlayer.Play(underground);
                if (player.position.X > 1000 && keys.IsKeyDown(Keys.Enter))
                {
                    effect2.Play();
                    gamestate = "riddle";
                    riddle = 1;
                    buttonstate = "yes";
                }

                lastgamestate = "level2";
                player.Update(gameTime, effect);
                level2generator++;
                backrect = new Rectangle(0, -(GraphicsDevice.Viewport.Height / 4), map.Width, GraphicsDevice.Viewport.Height + map.Height * 2);
                background = Content.Load<Texture2D>("background");
                foreach (CollisionTiles tile in map.CollisionTiles)
                {
                    player.Collision(tile.Rectangle, map.Width, map.Height);
                    if (camerastate == "camera")
                    {
                        camera.Update(player.Position, map.Width, map.Height);
                    }
                }
                //backrect = new Rectangle(0, 250 -(GraphicsDevice.Viewport.Height), map.Width, GraphicsDevice.Viewport.Height + map.Height);

                if (level2generator == 1)
                {
                    map.Dispose();
                    map.Generate(new int[,]{
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4},
                {4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4},
            }, 64);
                    
                    player.Load(Content);
                    player.position = new Vector2(100, 180);
                    gate = new Rectangle(1100, 260,100, 125);
                    score = 0;
                    boxman = Content.Load<Texture2D>("riddler");
                }

                if (player.position.Y > (map.Height - player.rectangle.Height) - 1)
                {
                    MediaPlayer.Stop();
                    effect5.Play();
                    gamestate = "dead";
                }
                if (player.position.X > 2500 && player.position.Y < 200 && score >= 5 && keys.IsKeyDown(Keys.Enter))
                {
                    
                    gamestate = "level3";
                }
                objbox = new Rectangle((int)camera.center.X - 375, (int)camera.center.Y - 275, 250, 150);
                oldkeys = keys;
            }

            
            if (gamestate == "level3")
            {
                if (MediaPlayer.State.ToString() == "Stopped")
                    MediaPlayer.Play(sky);
                lastgamestate = "level3";
                player.Update(gameTime, effect);
                level3generator++;
                backrect = new Rectangle(0, -(GraphicsDevice.Viewport.Height / 4), map.Width, GraphicsDevice.Viewport.Height + map.Height * 2);
                background = Content.Load<Texture2D>("sky2");
                foreach (CollisionTiles tile in map.CollisionTiles)
                {
                    player.Collision(tile.Rectangle, map.Width, map.Height);
                    if (camerastate == "camera")
                    {
                        camera.Update(player.Position, map.Width, map.Height);
                    }
                }
                //backrect = new Rectangle(0, 250 -(GraphicsDevice.Viewport.Height), map.Width, GraphicsDevice.Viewport.Height + map.Height);

                if (level3generator == 1)
                {
                    map.Dispose();
                    map.Generate(new int[,]{
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {3,3,3,0,0,0,3,3,0,0,0,3,3,0,0,0,3,0,0,0,0,3,0,0,0,3,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,3,3,3,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,3,3,3,3,3},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            }, 64);
                    player.Load(Content);
                    player.position = new Vector2(100, 180);
                    gate = new Rectangle(1100, 260, 100, 125);
                    score = 0;
                   
                }

                if (player.position.X > 3800 && keys.IsKeyDown(Keys.Enter))
                {
                    MediaPlayer.Stop();
                    effect2.Play();
                    gamestate = "level4";
                }
                if (player.position.Y > (map.Height - player.rectangle.Height) - 1)
                {
                    MediaPlayer.Stop();
                    effect5.Play();
                    gamestate = "dead";
                }
                objbox = new Rectangle((int)camera.center.X - 375, (int)camera.center.Y - 275, 250, 150);
                oldkeys = keys;
            }
                 
            if (gamestate == "level4")
            {
                if (MediaPlayer.State.ToString() == "Stopped")
                    MediaPlayer.Play(mineturtlesong);
                lastgamestate = "level4";
                player.Update(gameTime, effect);
               
                level4generator++;
                backrect = new Rectangle(0, -(GraphicsDevice.Viewport.Height / 4), map.Width, GraphicsDevice.Viewport.Height + map.Height * 2);
                background = Content.Load<Texture2D>("sky2");
                foreach (CollisionTiles tile in map.CollisionTiles)
                {
                    player.Collision(tile.Rectangle, map.Width, map.Height);
                    if (camerastate == "camera")
                    {
                        camera.Update(player.Position, map.Width, map.Height);
                    }
                }
               
                //backrect = new Rectangle(0, 250 -(GraphicsDevice.Viewport.Height), map.Width, GraphicsDevice.Viewport.Height + map.Height);

                if (level4generator == 1)
                {
                    map.Dispose();
                    map.Generate(new int[,]{
                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
                {2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
            }, 64);
                    enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(400, 335), 150));
                    //enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(600, 335), 150));
                    enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(800, 335), 150));
                    player.Load(Content);
                    
                    player.position = new Vector2(100, 180);
                    gate = new Rectangle(1100, 260, 100, 125);
                    score = 0;
                }
                foreach (Enemy enemy in enemies)
                {
                enemy.Update(player);
                if (enemy.velocity.X > 0)
                    enemy.texture = Content.Load<Texture2D>("MineTurtle2");
                else if (enemy.velocity.X < 0)
                    enemy.texture = Content.Load<Texture2D>("mineturtle");
                if (player.rectangle.Intersects(enemy.rectangle))
                {
                    MediaPlayer.Stop();
                    effect5.Play();

                    gamestate = "dead";
                }
                }

                if (player.position.X > 1200 && keys.IsKeyDown(Keys.Enter))
                {
                    foreach (Enemy enemy in enemies)
                    {

                        enemy.position.X = 100000;
                    }
                    MediaPlayer.Stop();
                    effect2.Play();
                    gamestate = "level5";
                }
                objbox = new Rectangle((int)camera.center.X - 375, (int)camera.center.Y - 275, 250, 150);
                oldkeys = keys;
            }

            if (gamestate == "level5")
            {
                if (MediaPlayer.State.ToString() == "Stopped")
                    MediaPlayer.Play(underground);
              

                lastgamestate = "level5";
                player.Update(gameTime, effect);
                level5generator++;
                backrect = new Rectangle(0, -(GraphicsDevice.Viewport.Height / 4), map.Width, GraphicsDevice.Viewport.Height + map.Height * 2);
                background = Content.Load<Texture2D>("background");
                foreach (CollisionTiles tile in map.CollisionTiles)
                {
                    player.Collision(tile.Rectangle, map.Width, map.Height);
                    if (camerastate == "camera")
                    {
                        camera.Update(player.Position, map.Width, map.Height);
                    }
                }
                //backrect = new Rectangle(0, 250 -(GraphicsDevice.Viewport.Height), map.Width, GraphicsDevice.Viewport.Height + map.Height);

                if (level5generator == 1)
                {
                    map.Dispose();
                    map.Generate(new int[,]{
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4},
                {4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4},
            }, 64);

                    player.Load(Content);
                    player.position = new Vector2(100, 180);
                    gate = new Rectangle(1100, 260, 100, 125);
                    score = 0;
                    boxman = Content.Load<Texture2D>("riddler");
                }

                if (player.position.Y > (map.Height - player.rectangle.Height) - 1)
                {
                    MediaPlayer.Stop();
                    effect5.Play();
                    gamestate = "dead";
                }
                if (player.position.X > 1000 && keys.IsKeyDown(Keys.Enter))
                {
                    effect2.Play();
                    gamestate = "riddle";
                    riddle = 2;
                    buttonstate = "yes";
                }
                objbox = new Rectangle((int)camera.center.X - 375, (int)camera.center.Y - 275, 250, 150);
                oldkeys = keys;
            }

            
            if (gamestate == "level6")
            {
               
                if (media.ToString() == "Stopped")
                {
                    MediaPlayer.Play(nyancat);
                }
                lastgamestate = "level6";
                player.Update(gameTime, effect);
                camerastate = "camera1";
                level6generator++;
                backrect = new Rectangle(0, -(GraphicsDevice.Viewport.Height / 4), map.Width, GraphicsDevice.Viewport.Height + map.Height * 2);
                background = Content.Load<Texture2D>("sky2");
                foreach (CollisionTiles tile in map.CollisionTiles)
                {
                    player.Collision(tile.Rectangle, map.Width, map.Height);
                    if (camerastate == "camera1")
                    {
                        camera1.Update(player.Position);
                    }
                }
                if (player.position.X > 1500)
                {
                    boxman = Content.Load<Texture2D>("rocket"); 
gate = new Rectangle(2600, 215, 95, 166);
                    
                }
                if (player.position.X < 1500)
                {
                    boxman = Content.Load<Texture2D>("celery");

                    gate = new Rectangle(150, 270, 40, 130);
                }

             
                //backrect = new Rectangle(0, 250 -(GraphicsDevice.Viewport.Height), map.Width, GraphicsDevice.Viewport.Height + map.Height);
                if (player.position.X > 2450 && keys.IsKeyDown(Keys.Enter))
                {
                    foreach (Enemy enemy in enemies)
                    {

                        enemy.position.X = 100000;
                    }
                    objbox = new Rectangle(GraphicsDevice.Viewport.Width/2 - 360, GraphicsDevice.Viewport.Height / 2- 260, 250, 150);
                    gate = new Rectangle(100, 470, 60 , 106);
                    MediaPlayer.Stop();
                    gamestate = "minigame1";
                }
                if (level6generator == 1)
                {
                    MediaPlayer.Play(nyancat);
                    player.gravity = .2f;
                    map.Dispose();
                    map.Generate(new int[,]{
                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5}, 
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            }, 64);
                   
                    player.Load(Content);
                    enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(800, 335), 150));
                   // enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(950, 320), 150));
                    enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(1200, 310), 150));
                    enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(1800, 335), 150));
                  //  enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(2000, 320), 150));
                    //enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(2300, 310), 150));
                    player.position = new Vector2(100, 180);
                  
                    gate = new Rectangle(150, 270, 40, 130);
                    
                    miles = 3000;
                }
               
                foreach (Enemy enemy in enemies)
                {
                    enemy.speed = 3f;
                    enemy.speed2 = -3f;
                    enemy.Update(player);
                    if (enemy.velocity.X > 0)
                        enemy.texture = Content.Load<Texture2D>("nyan");
                    else if (enemy.velocity.X < 0)
                        enemy.texture = Content.Load<Texture2D>("nyan2");
                    if (player.rectangle.Intersects(enemy.rectangle))
                    {
                        MediaPlayer.Stop();

                        effect5.Play();
                        gamestate = "dead";

                    }
                }
                if (player.position.Y > (map.Height - player.rectangle.Height) - 1)
                {
                    gamestate = "dead";
                    MediaPlayer.Stop();
                }
                objbox = new Rectangle((int)camera1.center.X - 360, (int)camera1.center.Y - 260, 250, 150);
                oldkeys = keys;
            }

            if (gamestate == "minigame1")
            {
                if (MediaPlayer.State.ToString() == "Stopped")
                {
                    MediaPlayer.Play(dubstep);
                }

                lastgamestate = "minigame1";
                ship.Update(gameTime);
                ship.LoadContent(Content);

                LoadCats();

                foreach (SpaceEnemy c in catList)
                {
                    if (ship.boundingBox.Intersects(c.boundingBox))
                    {
                        c.position.X = random.Next(10, 700);
                        c.position.Y = 620;
                        ship.position.X = 300;
                        miles= 3000;
                        effect5.Play();
                        MediaPlayer.Stop();
                        gamestate = "dead";
                        c.isVisible = false;
                        c.position.X = random.Next(10, 700);
                    }
                    for (int i = 0; i < ship.bulletList.Count; i++ )
                    {
                        if (c.boundingBox.Intersects(ship.bulletList[i].boundingBox))
                        {
                            effect6.Play();
                            c.position.X = random.Next(10, 700);
                            c.isVisible = false;
                            ship.bulletList.ElementAt(i).isVisible = false;
                            c.position.X = random.Next(10, 700);
                        }
                    }
             c.Update(gameTime);


                }

                objbox = new Rectangle(GraphicsDevice.Viewport.Width / 2 - 360, GraphicsDevice.Viewport.Height / 2 - 260, 250, 150);
                miles--;
                if (miles <= 0)
                {
                    MediaPlayer.Stop();
                    letterwait = 0;
                    gamestate = "note";
                }

            }

            if (gamestate == "note")
            {
                letterwait++;
                if (letterwait > 60 && keys.IsKeyDown(Keys.Enter))
                {
                    effect2.Play();
                    gamestate = "level7";
                    letterwait = 0;
                }
            }


            if (gamestate == "level7")
            {
                if (keys.IsKeyDown(Keys.I))
                {
                   
                }
                if (media.ToString() == "Stopped")
                {
                    MediaPlayer.Play(gangnamstyle);
                }
                lastgamestate = "level7";
                player.Update(gameTime, effect);
                camerastate = "camera";
                level7generator++;
                backrect = new Rectangle((int)camera.center.X - 400, (int)camera.center.Y - 300, 800, 600);
                foreach (CollisionTiles tile in map.CollisionTiles)
                {
                    player.Collision(tile.Rectangle, map.Width, map.Height);
                    if (camerastate == "camera")
                    {
                        camera.Update(player.Position, map.Width, map.Height);
                    }
                }
                if (player.position.X > 1500 && player.position.Y < 600)
                {
                    boxman = Content.Load<Texture2D>("arrow");
                    gate = new Rectangle(5520, 215, 95, 166);

                }
                if (player.position.X < 1500 && player.position.Y < 600)
                {
                    boxman = Content.Load<Texture2D>("rocket");

                    gate = new Rectangle(150, 215, 95, 166);
                }


                //backrect = new Rectangle(0, 250 -(GraphicsDevice.Viewport.Height), map.Width, GraphicsDevice.Viewport.Height + map.Height);
                if (player.position.X < 3000 && player.position.Y > 600 && keys.IsKeyDown(Keys.Enter))
                {
                    if (score >= 5)
                    {
                        buttonstate = "yes";
                        objbox = new Rectangle((int)camera.center.X - 375, (int)camera.center.Y - 275, 250, 150);
                        
                        gamestate = "riddle";
                        player.position.X = 100;
                        player.position.Y = 180;
                        riddle = 3;

                    }
                }

                if (level7generator == 1)
                {
                    boxman2 = Content.Load<Texture2D>("troll");
                    map.Dispose();
                    gate2 = new Rectangle(2805, 915, 100, 115);
                
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(2442, 180)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(594, 200)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(3139, 60)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(2060, 180)));
                    icecreams.Add(new IceCream(Content.Load<Texture2D>("smallice"), new Vector2(4230, 928)));
                    background = Content.Load<Texture2D>("titleback");
                    player.gravity = 0.35f;
                    castle = new Rectangle(2695, 530, 350, 500);
                    castleTexture = Content.Load<Texture2D>("castle2");
                    map.Dispose();
                    map.Generate(new int[,]{
                       
                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,3,3,3,0,0,0,0,3,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {5,5,5,5,5,5,5,5,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0,0,0,0,0,0,0,0,0,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,0,0,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,5,0,0,0,0}, 
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,5,5,5,5,5,5,5,5,5,0,0,0,0,0,3,0,0,0,0,3,0,0,0,0,3,0,0,0,0,3,0,0,0,3,0,0,0,0,0,5,5,5,5,5,5,5},
               
            }, 64);
                    enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(3340, 250), 160));
                    enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(5000, 250), 160));
                    player.Load(Content);
                    //enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(800, 335), 150));
                    // enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(950, 320), 150));
                   // enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(1200, 310), 150));
                    //enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(1800, 335), 150));
                    //  enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(2000, 320), 150));
                    //enemies.Add(new Enemy(Content.Load<Texture2D>("smallpotato"), new Vector2(2300, 310), 150));
                    player.position = new Vector2(100, 180);

                  
                }

                foreach (Enemy enemy in enemies)
                {
                    enemy.rectangle.Height = 150;
                    enemy.rectangle.Width = 125;
                    enemy.speed = 3f;
                    enemy.speed2 = -3f;
                    enemy.Update(player);
                    if (enemy.velocity.X > 0)
                        enemy.texture = Content.Load<Texture2D>("psy");
                    else if (enemy.velocity.X < 0)
                        enemy.texture = Content.Load<Texture2D>("psy2");
                    if (player.rectangle.Intersects(enemy.rectangle))
                    {
                        MediaPlayer.Stop();

                        effect5.Play();
                        gamestate = "dead";

                    }
                }
                if (player.position.Y > (map.Height - player.rectangle.Height) - 1)
                {
                    effect5.Play();
                    gamestate = "dead";
                    MediaPlayer.Stop();
                }
                objbox = new Rectangle((int)camera.center.X - 375, (int)camera.center.Y - 275, 250, 150);
                oldkeys = keys;
            }

            if (gamestate == "level8")
            {
                if (MediaPlayer.State.ToString() == "Stopped")
                    MediaPlayer.Play(castlemusic);

            
                lastgamestate = "level8";
                player.Update(gameTime, effect);

              

                /*
                if (player.position.X - enemy.position.X >= -200 && player.position.X - enemy.position.X <= 200)
                {
                    if (player.position.X - enemy.position.X < -1)
                        enemy.velocity.X = -1f;
                    if (player.position.X - enemy.position.X > 1)
                        enemy.velocity.X = 1f;
                    else if (player.position.X - enemy.position.X == 0)
                    {
                        enemy.velocity.X = 0f;
                    }
                }
                */
                level8generator++;

                houserect = new Rectangle(3950, 145, 175, 175);

                foreach (CollisionTiles tile in map.CollisionTiles)
                {
                    player.Collision(tile.Rectangle, map.Width, map.Height);
                    if (camerastate == "camera")
                    {
                        camera.Update(player.Position, map.Width, map.Height);
                    }
                }
                //backrect = new Rectangle(0, 250 -(GraphicsDevice.Viewport.Height), map.Width, GraphicsDevice.Viewport.Height + map.Height);
                if (Keyboard.GetState().IsKeyDown(Keys.Q))
                    camerastate = "camera";

                if (camerastate == "camera1")
                {
                    camera1.Update(player.Position);

                }
                if (level8generator == 1)
                {
                    map.Dispose();
                    lavaR.Add(new Rectangle(315, 460, 200, 60));
                    lavaR.Add(new Rectangle(514, 460, 200, 60));
                    lavaR.Add(new Rectangle(713, 460, 200, 60));
                    lavaR.Add(new Rectangle(912, 460, 200, 60));
                    lavaR.Add(new Rectangle(1111, 460, 200, 60));
                    lavaR.Add(new Rectangle(1310, 460, 200, 60));
                    lavaR.Add(new Rectangle(1509, 460, 200, 60));
                    lavaR.Add(new Rectangle(1708, 460, 200, 60));
                    lavaR.Add(new Rectangle(1907, 460, 200, 60));
                    lavaR.Add(new Rectangle(2106, 460, 200, 60));
                    lavaR.Add(new Rectangle(2305, 460, 200, 60));
                    lavaR.Add(new Rectangle(2504, 460, 200, 60));
                    lavaR.Add(new Rectangle(2703, 460, 200, 60));
                    lavaR.Add(new Rectangle(2902, 460, 200, 60));
                    lavaR.Add(new Rectangle(3101, 460, 200, 60));
                    lavaR.Add(new Rectangle(3200, 460, 200, 60));
                    lavaR.Add(new Rectangle(3399, 460, 200, 60));
                    lavaR.Add(new Rectangle(3497, 460, 200, 60));
                    lavaR.Add(new Rectangle(3596, 460, 200, 60));
                    lavaR.Add(new Rectangle(3695, 460, 200, 60));
                    lavaR.Add(new Rectangle(3794, 460, 200, 60));
                    lavaR.Add(new Rectangle(3893, 460, 200, 60));
                    lavaR.Add(new Rectangle(3992, 460, 200, 60));
                    foreach (Enemy enemy in enemies)
                    {

                        enemy.position.X = 100000;
                    }
                    foreach (IceCream icecream in icecreams)
                        icecream.rectangle.X = 100000;
                    map.Dispose();
                    house = Content.Load<Texture2D>("door");
                    map.Generate(new int[,]{
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,3,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,3,3,3,3},
                {4,4,4,4,4,0,0,0,0,0,3,0,0,0,0,0,3,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {4,4,4,4,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
            }, 64);
                    player.Load(Content);

                    score = 0;


                }

                if (player.position.X > 3800 && keys.IsKeyDown(Keys.Enter))
                {
                    effect2.Play();
                    MediaPlayer.Stop();
                    player.position.X = 100;
                    player.position.Y = 0;
                    gamestate = "boss";
                }

                foreach (Rectangle r in lavaR)
                {
                    if (player.rectangle.Intersects(r))
                    {
                        effect5.Play();
                        MediaPlayer.Stop();
                        gamestate = "dead";
                    }
                }

                if (player.position.Y > (map.Height - player.rectangle.Height) - 1)
                {
                    effect5.Play();
                    MediaPlayer.Stop();
                    gamestate = "dead";
                }

                if (keys.IsKeyDown(Keys.C))
                {
                    player.position.X = 4000;
                }
                objbox = new Rectangle((int)camera.center.X - 375, (int)camera.center.Y - 275, 250, 150);
                oldkeys = keys;
            }

            if (gamestate == "boss")
            {

                if (media.ToString() == "Stopped")
                {
                    MediaPlayer.Play(bossbattlemusic);
                }

                lastgamestate = "boss";
                player.Update(gameTime, effect);



                /*
                if (player.position.X - enemy.position.X >= -200 && player.position.X - enemy.position.X <= 200)
                {
                    if (player.position.X - enemy.position.X < -1)
                        enemy.velocity.X = -1f;
                    if (player.position.X - enemy.position.X > 1)
                        enemy.velocity.X = 1f;
                    else if (player.position.X - enemy.position.X == 0)
                    {
                        enemy.velocity.X = 0f;
                    }
                }
                */
                bossgenerator++;

                backrect = new Rectangle(0, -(GraphicsDevice.Viewport.Height / 4), map.Width, GraphicsDevice.Viewport.Height + map.Height);

                foreach (CollisionTiles tile in map.CollisionTiles)
                {
                    player.Collision(tile.Rectangle, map.Width, map.Height);
                    if (camerastate == "camera")
                    {
                        camera.Update(player.Position, map.Width, map.Height);
                    }
                }
                //backrect = new Rectangle(0, 250 -(GraphicsDevice.Viewport.Height), map.Width, GraphicsDevice.Viewport.Height + map.Height);
                if (Keyboard.GetState().IsKeyDown(Keys.Q))
                    camerastate = "camera";

                if (camerastate == "camera1")
                {
                    camera1.Update(player.Position);

                }
                if (bossgenerator == 1)
                {
                    houserect = new Rectangle(1450, 295, 150, 150);
                    house = Content.Load<Texture2D>("button");
                    enemies.Add(new Enemy(Content.Load<Texture2D>("carrot1"), new Vector2(400, 250), 160));
                   enemies2.Add(new Enemy(Content.Load<Texture2D>("psy"), new Vector2(300, 300), 160));
                   enemies2.Add(new Enemy(Content.Load<Texture2D>("psy"), new Vector2(600, 300), 160));
                    map.Dispose();
                    map.Generate(new int[,]{
                                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {3,3,3,0,0,0,0,0,3,0,0,0,0,0,3,0,0,0,0,0,4,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0},
                {4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4},
                {4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4},
            }, 64);
                    player.Load(Content);

                    score = 0;


                }

                if (player.position.X > 1400 && keys.IsKeyDown(Keys.Enter))
                {
                    foreach (Enemy enemy in enemies)
                    {

                        enemy.position.X = 100000;
                    } foreach (Enemy enemy in enemies2)
                    {

                        enemy.position.X = 100000;
                    }
                    MediaPlayer.Stop();
                    effect6.Play();
                    gamestate = "final";
                }
                foreach (Enemy enemy in enemies)
                {
                    if (enemy.position.X > 1250)
                    {
                        enemy.velocity.X = enemy.speed2;
                    }
                    enemy.rectangle.Height = 200;
                    enemy.rectangle.Width = 30;
                    enemy.speed = 5f;
                    enemy.speed2 = -5f;
                    enemy.Update(player);
                    if (enemy.velocity.X > 0)
                        enemy.texture = Content.Load<Texture2D>("carrot2");
                    else if (enemy.velocity.X < 0)
                        enemy.texture = Content.Load<Texture2D>("carrot1");
                    if (player.rectangle.Intersects(enemy.rectangle))
                    {
                        MediaPlayer.Stop();

                        effect5.Play();
                        gamestate = "dead";

                    }
                }

                foreach (Enemy enemy in enemies2)
                {
                    if (enemy.position.X > 1165)
                    {
                        enemy.velocity.X = enemy.speed2;
                    }
                    enemy.rectangle.Height = 150;
                    enemy.rectangle.Width = 125;
                    enemy.speed = 3f;
                    enemy.speed2 = -3f;
                    enemy.Update(player);
                    if (enemy.velocity.X > 0)
                        enemy.texture = Content.Load<Texture2D>("psy");
                    else if (enemy.velocity.X < 0)
                        enemy.texture = Content.Load<Texture2D>("psy2");
                    if (player.rectangle.Intersects(enemy.rectangle))
                    {
                        MediaPlayer.Stop();

                        effect5.Play();
                        gamestate = "dead";

                    }
                }
                if (player.position.Y > (map.Height - player.rectangle.Height) - 1)
                {
                    effect5.Play();
                    gamestate = "dead";
                }

                objbox = new Rectangle((int)camera.center.X - 375, (int)camera.center.Y - 275, 250, 150);
                oldkeys = keys;
            }

            if (gamestate == "final")
            {



                lastgamestate = "final";
                player.Update(gameTime, effect);



                /*
                if (player.position.X - enemy.position.X >= -200 && player.position.X - enemy.position.X <= 200)
                {
                    if (player.position.X - enemy.position.X < -1)
                        enemy.velocity.X = -1f;
                    if (player.position.X - enemy.position.X > 1)
                        enemy.velocity.X = 1f;
                    else if (player.position.X - enemy.position.X == 0)
                    {
                        enemy.velocity.X = 0f;
                    }
                }
                */
                finalgenerator++;

                backrect = new Rectangle(0, -(GraphicsDevice.Viewport.Height / 4), map.Width, GraphicsDevice.Viewport.Height + map.Height);

                foreach (CollisionTiles tile in map.CollisionTiles)
                {
                    player.Collision(tile.Rectangle, map.Width, map.Height);
                    if (camerastate == "camera")
                    {
                        camera.Update(player.Position, map.Width, map.Height);
                    }
                }
                //backrect = new Rectangle(0, 250 -(GraphicsDevice.Viewport.Height), map.Width, GraphicsDevice.Viewport.Height + map.Height);
                if (Keyboard.GetState().IsKeyDown(Keys.Q))
                    camerastate = "camera";

                if (camerastate == "camera1")
                {
                    camera1.Update(player.Position);

                }
                if (finalgenerator == 1)
                {
                    lavaR.Add(new Rectangle(315, 460, 200, 60));
                    lavaR.Add(new Rectangle(514, 460, 200, 60));
                    lavaR.Add(new Rectangle(713, 460, 200, 60));
                    lavaR.Add(new Rectangle(912, 460, 200, 60));
                    lavaR.Add(new Rectangle(1111, 460, 200, 60));
                    lavaR.Add(new Rectangle(1310, 460, 200, 60));            
                    houserect = new Rectangle(1450, 295, 150, 150);
                    house = Content.Load<Texture2D>("button");
                  
                    map.Dispose();
                    map.Generate(new int[,]{
                                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4},
            }, 64);
                    player.Load(Content);

                    score = 0;


                }

                if (player.position.X > 2000)
                {
                    houserect = new Rectangle(2450, 352, 58, 95);
                    house = Content.Load<Texture2D>("princess1");
                }
                if (player.position.X > 2200 && keys.IsKeyDown(Keys.Enter))
                {
                    effect2.Play();
                    buttonstate = "yes";
                    letterwait = 0;
                    gamestate = "win";
                    effect7.Play();
                }
                if(player.position.X < 2000)
                {
                    houserect = new Rectangle(1450, 295, 150, 150);
                    house = Content.Load<Texture2D>("button");
            }
                if (player.position.Y > (map.Height - player.rectangle.Height) - 1)
                {
                    effect5.Play();
                    gamestate = "dead";
                }

                objbox = new Rectangle((int)camera.center.X - 375, (int)camera.center.Y - 275, 250, 150);
                oldkeys = keys;
            }

            if (gamestate == "win")
            {
                letterwait++;
                if (letterwait > 300 && buttonstate == "yes" && keys.IsKeyDown(Keys.S))
                {
                    effect2.Play();
                    buttonstate = "no";
                }
                if (letterwait > 300 && buttonstate == "no" && keys.IsKeyDown(Keys.W))
                {
                    effect2.Play();
                    buttonstate = "yes";
                }
                  if (letterwait > 300 && buttonstate == "yes" && keys.IsKeyDown(Keys.Enter))
                  {
                      foreach (Enemy enemy in enemies2)
                      {

                          enemy.position.X = 100000;
                      }
                      letter = letter2;
                      effect2.Play();
                      player.position.X = 100;
                      player.position.Y = 0;
                      gamestate = "intro";
                  }
                  if (letterwait > 300 && buttonstate == "no" && keys.IsKeyDown(Keys.Enter))
                  {
                      this.Exit();
                  }
            }

            oldkeys = keys;
           
            if (gamestate == "riddle")
            {
                
                riddlewait++;

                if (riddle == 1)
                {
                    if (buttonstate == "yes" && keys.IsKeyDown(Keys.S))
                    {
                        effect2.Play();
                        buttonstate = "no";
                    }
                    if (buttonstate == "no" && keys.IsKeyDown(Keys.W))
                    {
                        effect2.Play();
                        buttonstate = "yes";
                    }

                    if (buttonstate == "yes" && keys.IsKeyDown(Keys.Enter) && riddlewait > 30)
                    {
                        MediaPlayer.Stop();
                        effect2.Play();
                        buttonstate = "instructions";
                        gamestate = "level3";
                        riddlewait = 0;
                    }
                    if (buttonstate == "no" && keys.IsKeyDown(Keys.Enter) && riddlewait > 30)
                    {
                        MediaPlayer.Stop();
                        effect5.Play();
                        effect2.Play();
                        buttonstate = "instructions";
                        gamestate = "dead";
                        riddlewait = 0;
                    }
                }
                    if( riddle == 2)
{
                    if (buttonstate == "yes" && keys.IsKeyDown(Keys.S))
                    {
                        effect2.Play();
                        buttonstate = "no";
                    }
                    if (buttonstate == "no" && keys.IsKeyDown(Keys.W))
                    {
                        effect2.Play();
                        buttonstate = "yes";
                    }

                    if (buttonstate == "no" && keys.IsKeyDown(Keys.Enter) && riddlewait > 30)
                    {
                        gamestate = "level6";
                        MediaPlayer.Stop();
                        effect2.Play();
                        buttonstate = "instructions";
                        
                        riddlewait = 0;
                    }
                    if (buttonstate == "yes" && keys.IsKeyDown(Keys.Enter) && riddlewait > 30)
                    {
                        MediaPlayer.Stop();
                        effect5.Play();
                        effect2.Play();
                        buttonstate = "instructions";
                        gamestate = "dead";
                        riddlewait = 0;
                    }
                }
                    if (riddle == 3)
                    {
                        if (buttonstate == "yes" && keys.IsKeyDown(Keys.S))
                        {
                            effect2.Play();
                            buttonstate = "no";
                        }
                        if (buttonstate == "no" && keys.IsKeyDown(Keys.W))
                        {
                            effect2.Play();
                            buttonstate = "yes";
                        }

                        if (buttonstate == "yes" && keys.IsKeyDown(Keys.Enter) && riddlewait > 30)
                        {
                            MediaPlayer.Stop();
                            effect2.Play();
                            buttonstate = "instructions";
                            gamestate = "level8";
                            riddlewait = 0;
                        }
                        if (buttonstate == "no" && keys.IsKeyDown(Keys.Enter) && riddlewait > 30)
                        {
                            MediaPlayer.Stop();
                            effect5.Play();
                            effect2.Play();
                            buttonstate = "instructions";
                            gamestate = "dead";
                            riddlewait = 0;
                        }
                    }
            }
            base.Update(gameTime);

        }
        /*
        public void UpdateBullets()
        {
            foreach (Bullets bullet in bullets)
            {
                bullet.position += bullet.velocity;
                if (Vector2.Distance(bullet.position, spritePosition) > 500)
                    bullet.isVisible = false;
            }

            for (int i = 0; i < bullets.Count; i++)
            {
                if (!bullets[i].isVisible)
                {
                    bullets.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Shoot()
        {
            Bullets newBullet = new Bullets(Content.Load<Texture2D>("Bullet"));
            newBullet.velocity = new Vector2((float)Math.Cos(rotation), (float)Math.Sin(rotation)) * 5f + spriteVelocity;
            newBullet.position = spritePosition + newBullet.velocity * 5;
            newBullet.isVisible = true;

            if (bullets.Count() < 20)
                bullets.Add(newBullet);
        }
        */
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime) //Draws all of the items. Without this, you would see nothing.
        {

            // TODO: Add your drawing code here
            GraphicsDevice.Clear(Color.Black);
            if (camerastate == "camera" && gamestate != "title" && gamestate != "letter" && gamestate != "instructions" && gamestate != "menu" && gamestate != "riddle" && gamestate != "dead" && gamestate != "minigame1" && gamestate != "note" && gamestate != "win")
            {
                spriteBatch.Begin(SpriteSortMode.Deferred,
                    BlendState.AlphaBlend,
                    null, null, null, null,
                    camera.Transform);
            }
            if (camerastate == "camera1" && gamestate != "title" && gamestate != "letter" && gamestate != "instructions" && gamestate != "menu" && gamestate != "riddle" && gamestate != "dead" && gamestate != "minigame1" && gamestate != "note" && gamestate != "win")
            {
                spriteBatch.Begin(SpriteSortMode.Deferred,
                    BlendState.AlphaBlend,
                    null, null, null, null,
                    camera1.Transform);
            }
            if (camerastate != "camera" && camerastate != "camera1")
                spriteBatch.Begin();
            if (gamestate == "intro")
            {
                spriteBatch.Draw(background, backrect, Color.White);
                spriteBatch.Draw(house, houserect, Color.White);
                player.Draw(spriteBatch);
                map.Draw(spriteBatch);
                
                spriteBatch.Draw(objectives, objbox, Color.White);
                drawText("[Objectives]", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 275);
                drawText("Go to Princess Patata's", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 245);
                drawText("castle.", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 225);
                drawText("Use WASD to move.", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 205);
                if (player.position.X > 1000)
                {
                    drawText("There's a note on the door.", font, Color.Black, (float)camera.center.X - 150, (float)camera.center.Y - 50);
                    drawText("[Press enter to continue]", font, Color.Black, (float)camera.center.X - 150, (float)camera.center.Y);
                }
            }
            if (gamestate == "level1")
            {
                spriteBatch.Draw(background, backrect, Color.White);
                //scrolling1.Draw(spriteBatch);
                //scrolling2.Draw(spriteBatch);
                spriteBatch.Draw(boxman, gate, Color.White);
                player.Draw(spriteBatch);
                map.Draw(spriteBatch);
               
                drawText("Ice Creams: " + score, font, Color.White, (float)camera.center.X + 225, (float)camera.center.Y + 200);
                spriteBatch.Draw(objectives, objbox, Color.White);
                
                drawText("[Objectives]", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 275);
                drawText("Collect 5 Ice Creams", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 245);
                drawText("and give them to the", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 225);
                drawText("man at the end.", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 205);
                foreach (IceCream icecream in icecreams)
                    icecream.Draw(spriteBatch);
                if (player.position.X > 2500 && player.position.Y < 200)
                {
                    if (score < 5)
                    {
                        drawText("You don't have enough cones.", font, Color.Black, (float)camera.center.X - 150, (float)camera.center.Y);
                    }
                    if (score >= 5)
                    {
                        drawText("Thanks for the icecream.", font, Color.Black, (float)camera.center.X - 150, (float)camera.center.Y - 50);
                        drawText("I'll take you to the next level.", font, Color.Black, (float)camera.center.X - 150, (float)camera.center.Y);
                        drawText("[Press enter to continue]", font, Color.Black, (float)camera.center.X - 150, (float)camera.center.Y + 50);
                    }
                }
            }
            if (gamestate == "level2")
            {

                GraphicsDevice.Clear(Color.Black);
                spriteBatch.Draw(boxman, gate, Color.White);
                player.Draw(spriteBatch);
                
                map.Draw(spriteBatch);

              
                spriteBatch.Draw(objectives, objbox, Color.White);
                drawText("[Objectives]", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 275);
                drawText("Solve the riddle.", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 245);

                if (player.position.X > 1000)
                {
                    drawText("[Press enter to continue]", font, Color.White, (float)camera.center.X - 150, (float)camera.center.Y);
                }
            }
            if (gamestate == "level3")
            {
                spriteBatch.Draw(background, backrect, Color.White);
                
                player.Draw(spriteBatch);

                map.Draw(spriteBatch);

           
                spriteBatch.Draw(objectives, objbox, Color.White);
                drawText("[Objectives]", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 275);
                drawText("Reach the end.", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 245);

                if (player.position.X > 3800)
                {
                    drawText("[Press enter to continue]", font, Color.White, (float)camera.center.X - 150, (float)camera.center.Y);
                }
            }
            if (gamestate == "level4")
            {
                spriteBatch.Draw(background, backrect, Color.White);
                player.Draw(spriteBatch);
                map.Draw(spriteBatch);
                foreach(Enemy enemy in enemies)
                enemy.Draw(spriteBatch);
                spriteBatch.Draw(objectives, objbox, Color.White);
                drawText("[Objectives]", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 275);
                drawText("Avoid the turtles.", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 245);
               
                if (player.position.X > 1200)
                {
                    drawText("[Press enter to continue]", font, Color.Black, (float)camera.center.X - 150, (float)camera.center.Y);
                }
            }
            if (gamestate == "level5")
            {

                GraphicsDevice.Clear(Color.Black);
                spriteBatch.Draw(boxman, gate, Color.White);
                player.Draw(spriteBatch);

                map.Draw(spriteBatch);

            
                spriteBatch.Draw(objectives, objbox, Color.White);
                drawText("[Objectives]", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 275);
                drawText("Solve the riddle.", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 245);

                if (player.position.X > 1000)
                {
                    drawText("[Press enter to continue]", font, Color.White, (float)camera.center.X - 150, (float)camera.center.Y);
                }
            }
            if (gamestate == "level6")
            {

                spriteBatch.Draw(boxman, gate, Color.White);
                player.Draw(spriteBatch);
                map.Draw(spriteBatch);
                foreach (Enemy enemy in enemies)
                    enemy.Draw(spriteBatch);
                spriteBatch.Draw(objectives, objbox, Color.White);
                drawText("[Objectives]", font, Color.White, (int)camera1.center.X - 355, (int)camera1.center.Y - 260);
                drawText("Somehow you're in", font, Color.White, (int)camera1.center.X - 355, (int)camera1.center.Y - 230);
                drawText("space.", font, Color.White, (int)camera1.center.X - 355, (int)camera1.center.Y - 210);
                drawText("Ride the space ship", font, Color.White, (int)camera1.center.X - 355, (int)camera1.center.Y - 190);
                drawText("back to earth.", font, Color.White, (int)camera1.center.X - 355, (int)camera1.center.Y - 170);
                drawText("Now you know this game is random!", font, Color.White, 10, 230);
   
                if (player.position.X > 2450)
                {
                    spriteBatch.Draw(boxman, gate, Color.White);
                    drawText("[Press enter to continue]", font, Color.White, (float)camera1.center.X - 150, (float)camera1.center.Y);
                }
            }
            if (gamestate == "level7")
            {
                GraphicsDevice.Clear(Color.White);
                spriteBatch.Draw(background, backrect, Color.White);
                spriteBatch.Draw(boxman, gate, Color.White);

                spriteBatch.Draw(castleTexture, castle, Color.White); 
                spriteBatch.Draw(boxman2, gate2, Color.White);
                player.Draw(spriteBatch);
                map.Draw(spriteBatch);
                foreach (Enemy enemy in enemies)
                    enemy.Draw(spriteBatch);
                foreach (IceCream icecream in icecreams)
                    icecream.Draw(spriteBatch);
                spriteBatch.Draw(objectives, objbox, Color.White);
            
                drawText("Ice Creams: " + score, font, Color.Black, (float)camera.center.X + 225, (float)camera.center.Y + 200);
                spriteBatch.Draw(objectives, objbox, Color.White);
                drawText("[Objectives]", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 275);
                drawText("Collect 5 Ice Creams.", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 245);
                drawText("Solve the riddle.", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 225);
                drawText("Avoid the Psys.", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 205);
                drawText("Reach the end.", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 185);
                if (player.position.X > 2500 && player.position.X < 3000 && player.position.Y > 900)
                {
                    spriteBatch.Draw(boxman, gate, Color.White);
                    if (score >= 5)
                    {
                        drawText("[Press enter to continue]", font, Color.Orange, (float)camera.center.X - 150, (float)camera.center.Y);
                    }
                    if (score < 5)
                    {
                        drawText("You don't have enough cones.", font, Color.Orange, (float)camera.center.X - 150, (float)camera.center.Y);
                    }
                }
            }
            if (gamestate == "level8")
            {
                if (player.position.X > 3800)
                {
                    drawText("[Press enter to continue]", font, Color.White, (float)camera.center.X - 150, (float)camera.center.Y);
                }
                
                spriteBatch.Draw(house, houserect, Color.White);
                player.Draw(spriteBatch);
                foreach (Rectangle r in lavaR)
                {
                    spriteBatch.Draw(lava, r, Color.White);
                }
                map.Draw(spriteBatch);
                
                spriteBatch.Draw(objectives, objbox, Color.White);
                drawText("[Objectives]", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 275);
                drawText("Reach John's room", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 245);
                drawText("at the end of the castle.", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 225);

            }
            if (gamestate == "boss")
            {
                spriteBatch.Draw(house, houserect, Color.White);
                player.Draw(spriteBatch);
                map.Draw(spriteBatch);
                foreach (Enemy enemy in enemies2)
                    enemy.Draw(spriteBatch);
                foreach (Enemy enemy in enemies)
                    enemy.Draw(spriteBatch);
             
                spriteBatch.Draw(objectives, objbox, Color.White);
                drawText("[Objectives]", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 275);
                drawText("Defeat John.", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 245);             
                if (player.position.X > 1400)
                {
                    drawText("[Press enter to continue]", font, Color.White, (float)camera.center.X - 150, (float)camera.center.Y);
                }
            } if (gamestate == "final")
            {
                spriteBatch.Draw(house, houserect, Color.White);
                player.Draw(spriteBatch); foreach (Rectangle r in lavaR)
                {
                    spriteBatch.Draw(lava, r, Color.White);
                }
                map.Draw(spriteBatch);
              
                
                spriteBatch.Draw(objectives, objbox, Color.White);
                drawText("[Objectives]", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 275);
                drawText("Find Princess Patata.", font, Color.White, (int)camera.center.X - 370, (int)camera.center.Y - 245);
                if (player.position.X > 2200)
                {
                    drawText("[Press enter to continue]", font, Color.White, (float)camera.center.X - 150, (float)camera.center.Y);
                }
            }
            if (gamestate == "minigame1")
            {
                  spriteBatch.Begin();
                  foreach (SpaceEnemy c in catList)
                  {
                      c.Draw(spriteBatch);
                  }
                  ship.Draw(spriteBatch);
                foreach (Bullets bullet in bullets)
                    bullet.Draw(spriteBatch);
                drawText("Miles to go: " +miles.ToString(), font, Color.White, GraphicsDevice.Viewport.Width / 2 + 150, GraphicsDevice.Viewport.Height / 2 + 125);
                spriteBatch.Draw(objectives, objbox, Color.White);
                drawText("[Objectives]", font, Color.White, GraphicsDevice.Viewport.Width / 2 - 355, GraphicsDevice.Viewport.Height / 2 - 260);
                drawText("As you're heading to", font, Color.White, GraphicsDevice.Viewport.Width / 2 - 355, GraphicsDevice.Viewport.Height / 2 - 230);
                drawText("earth, destroy the cats", font, Color.White, GraphicsDevice.Viewport.Width / 2 - 355, GraphicsDevice.Viewport.Height / 2 - 210);
                drawText("with the ship's gun.", font, Color.White, GraphicsDevice.Viewport.Width / 2 - 355, GraphicsDevice.Viewport.Height / 2 - 190);
                drawText("Hold [Space] to shoot.", font, Color.White, GraphicsDevice.Viewport.Width / 2 - 355, GraphicsDevice.Viewport.Height / 2 - 170);
               
                //drawText(player.position.X + "," + player.position.Y, font, Color.White, (float)camera1.center.X + 225, (float)camera1.center.Y + 100);
            }
            if (gamestate == "title")
            {
                spriteBatch.Begin();
                spriteBatch.Draw(title, backrect, Color.White);
                spriteBatch.Draw(start, startR, Color.White);
                spriteBatch.Draw(exit, exitR, Color.White);
                spriteBatch.Draw(titleText, titleTxt, Color.White);
                if (buttonstate == "start")
                {
                    start = Content.Load<Texture2D>("start");
                    exit = Content.Load<Texture2D>("exit2");
                  
                }
                if (buttonstate == "exit")
                {
                    start = Content.Load<Texture2D>("start2");
                    exit = Content.Load<Texture2D>("exit");
                }
            } if (gamestate == "note")
            {
                spriteBatch.Begin(); 
                backrect = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
                spriteBatch.Draw(title, backrect, Color.White);
                drawText("You've safely made it back to earth.", font, Color.Black, GraphicsDevice.Viewport.Width / 4, GraphicsDevice.Viewport.Height / 2 - 25);
                drawText("Apparently, you've crashed directly", font, Color.Black, GraphicsDevice.Viewport.Width / 4 , GraphicsDevice.Viewport.Height / 2);
                drawText("on Psyland, where John's fortress lies.", font, Color.Black, GraphicsDevice.Viewport.Width / 4 - 10, GraphicsDevice.Viewport.Height / 2 + 25);
                if (letterwait > 60)
                {
                    drawText("[Press enter to continue]", font, Color.Black, (float)250, 500);
                }
            }
            if (gamestate == "win")
            {
                spriteBatch.Begin();
                backrect = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
                spriteBatch.Draw(title, backrect, Color.White);
                if (letterwait < 300)
                {
                    drawText("You win!", font, Color.Black, GraphicsDevice.Viewport.Width / 4 + 125, GraphicsDevice.Viewport.Height / 2 - 50);
                }
                if (letterwait > 300)
                {
                    spriteBatch.Draw(start, startR, Color.White);
                    spriteBatch.Draw(exit, exitR, Color.White);
                    drawText("Thank you for rescuing me.", font, Color.Black, GraphicsDevice.Viewport.Width / 4 + 20, GraphicsDevice.Viewport.Height / 2 - 50);
                    drawText("Would you like to meet me for lunch tomorrow?", font, Color.Black, GraphicsDevice.Viewport.Width / 4 - 50, GraphicsDevice.Viewport.Height / 2 - 25);
                    if (buttonstate == "yes")
                    {
                        start = Content.Load<Texture2D>("yes");
                        exit = Content.Load<Texture2D>("no2");
                    }
                    if (buttonstate == "no")
                    {
                        start = Content.Load<Texture2D>("yes2");
                        exit = Content.Load<Texture2D>("no");

                    }
                  
                }
                
            }
            if (gamestate == "riddle")
            {

                spriteBatch.Begin();
                backrect = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
                spriteBatch.Draw(title, backrect, Color.White);
                spriteBatch.Draw(start, startR, Color.White);
                spriteBatch.Draw(exit, exitR, Color.White);
                backrect = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
                if (buttonstate == "yes")
                {
                    start = Content.Load<Texture2D>("yes");
                    exit = Content.Load<Texture2D>("no2");
                }
                if (buttonstate == "no")
                {
                    start = Content.Load<Texture2D>("yes2");
                    exit = Content.Load<Texture2D>("no");

                }
                if (riddle == 1)
                {
                    drawText("Are you a potato? Yes or No?", font, Color.Black, GraphicsDevice.Viewport.Width / 4  + 25, GraphicsDevice.Viewport.Height / 2 - 30);

                }
                if (riddle == 2)
                {
                    drawText("What number is your favorite purple?", font, Color.Black, GraphicsDevice.Viewport.Width / 4, GraphicsDevice.Viewport.Height / 2 - 30);
                }
                if (riddle == 3)
                {
                    drawText("Am I The Grumpy Old Troll Who Lives Under The Bridge?", font, Color.Black, GraphicsDevice.Viewport.Width / 4 - 90, GraphicsDevice.Viewport.Height / 2 - 30);
                }
            }
            if (gamestate == "letter")
            {
                //backrect = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
                //backrect = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
                // player.position.X = 0;
                //player.position.Y = 0;
                spriteBatch.Begin();
                backrect = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
                spriteBatch.Draw(letter, backrect, Color.White);
                if (letterwait > 60)
                {
                    drawText("[Press enter to continue]", font, Color.Black, (float)250, 500);
                }
            }

            if (gamestate == "instructions")
            {
                //backrect = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
                //backrect = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
                // player.position.X = 0;
                //player.position.Y = 0;
                spriteBatch.Begin();
                backrect = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
                spriteBatch.Draw(title, backrect, Color.White);
                drawText("Oh no! Princess Patata has been kidnapped!", font, Color.Black, GraphicsDevice.Viewport.Width / 2 - 225, GraphicsDevice.Viewport.Height / 2 - 150);
                drawText("Journey to John's fortress to save her!", font, Color.Black, GraphicsDevice.Viewport.Width / 2 - 200, GraphicsDevice.Viewport.Height / 2 - 125);
                drawText("[INSTRUCTIONS]", font, Color.Black, GraphicsDevice.Viewport.Width / 3 + 40, GraphicsDevice.Viewport.Height / 2 - 50);
                drawText("-Use the [A] and [D] keys to make Bob Potato", font, Color.Black, GraphicsDevice.Viewport.Width / 4 - 40, GraphicsDevice.Viewport.Height / 2 + 25);
                drawText(" move either forward or backwards.", font, Color.Black, GraphicsDevice.Viewport.Width / 4 - 40, GraphicsDevice.Viewport.Height / 2 + 50);
                drawText("-Press/hold [Space] to make Bob Potato jump.", font, Color.Black, GraphicsDevice.Viewport.Width / 4 - 40, GraphicsDevice.Viewport.Height / 2 + 75);
                drawText("-Press [X] to open the menu.", font, Color.Black, GraphicsDevice.Viewport.Width / 4 - 40, GraphicsDevice.Viewport.Height / 2 + 100);
                if (instructwait > 60)
                {
                    drawText("[Press enter to play]", font, Color.Black, (float)290, 500);
                }
            }

            if (gamestate == "dead")
            {
                spriteBatch.Begin();
                GraphicsDevice.Clear(Color.Black);
                textposition = new Vector2(340, 200);
                if(deadwait < 120)
                    spriteBatch.DrawString(font, "Dead :(", textposition, Color.White);
                if (deadwait > 120)
                {
                    textposition = new Vector2(330, 200);
                    spriteBatch.DrawString(font, "Continue?", textposition, Color.White);
                    spriteBatch.Draw(start, startR, Color.White);
                    spriteBatch.Draw(exit, exitR, Color.White);
                    backrect = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
                    if (buttonstate == "yes")
                    {
                        start = Content.Load<Texture2D>("yes");
                        exit = Content.Load<Texture2D>("exit2");
                    }
                    if (buttonstate == "exit")
                    {
                        start = Content.Load<Texture2D>("yes2");
                        exit = Content.Load<Texture2D>("exit");

                    }
                }
                score = 0;
            }

            if (gamestate == "menu")
            {
                spriteBatch.Begin();
                spriteBatch.Draw(title, backrect, Color.White);
                spriteBatch.Draw(start, startR, Color.White);
                spriteBatch.Draw(exit, exitR, Color.White);
                spriteBatch.Draw(back, backR, Color.White);

                backrect = new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
                if (buttonstate == "back")
                {
                    back = Content.Load<Texture2D>("back");
                    start = Content.Load<Texture2D>("instructions2");
                    exit = Content.Load<Texture2D>("exit2");
                }
                if (buttonstate == "instructions")
                {
                    back = Content.Load<Texture2D>("back2");
                    start = Content.Load<Texture2D>("instructions");
                    exit = Content.Load<Texture2D>("exit2");

                }
                if (buttonstate == "exit")
                {
                    back = Content.Load<Texture2D>("back2");
                    start = Content.Load<Texture2D>("instructions2");
                    exit = Content.Load<Texture2D>("exit");
                }
            }
            //drawText(gamestate, font, Color.White, (float)camera.center.X + 225, (float)camera.center.Y + 200);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        public void LoadCats()
        {
                        
                randX = random.Next(10, 700);
                randY = random.Next(-600, -50);
            if(catList.Count() < 15)
            {
               catList.Add(new SpaceEnemy(Content.Load<Texture2D>("cat"), new Vector2(randX, randY)));
            }

            for (int i = 0; i < catList.Count(); i++)
            {
                if (!catList[i].isVisible)
                {

                
                    catList.RemoveAt(i);
                    i--;


                }
            }
        }
    }
}
