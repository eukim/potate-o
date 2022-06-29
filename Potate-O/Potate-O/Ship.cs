using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;

namespace Potate_O
{
    class Ship
    {
        public Texture2D texture, bullet;
        public float bulletDelay;
        public Vector2 position;
        public int speed;
  public Rectangle boundingBox;
        public bool isColliding;
        public List<Bullets> bulletList;
        SoundEffect shoot;

        public Ship()
        {
            bulletList = new List<Bullets>();
            texture = null;
            position = new Vector2(300, 470);
            speed = 5;
            isColliding = false;
            bulletDelay = 20;
        }

        public void LoadContent(ContentManager Content)
        {
            bullet = Content.Load<Texture2D>("bullet");
            texture = Content.Load<Texture2D>("ship");
            shoot = Content.Load<SoundEffect>("shoot");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
            foreach (Bullets b in bulletList)
            {
                b.Draw(spriteBatch);
            }
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState keyState = Keyboard.GetState();

            boundingBox = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);

            if (keyState.IsKeyDown(Keys.A))
            {
                position.X -= speed;
            } 
            if (keyState.IsKeyDown(Keys.Space))
            {
                Shoot();
             
            }
            UpdateBullets();
            if (keyState.IsKeyDown(Keys.D))
            {
                position.X += speed;
            }
            if (position.X < 0)
            {
                position.X = 0;
            } if (position.X > 800 - texture.Width)
            {
                position.X = 800 - texture.Width;
            }
        }

        public void Shoot()
        {
            if (bulletDelay >= 0)
            {
                bulletDelay--;
            }

            if (bulletDelay <= 0)
            {
                shoot.Play();
                Bullets newBullet = new Bullets(bullet);
                newBullet.position = new Vector2(position.X + 32 - newBullet.texture.Width / 2, position.Y - 30);

                newBullet.isVisible = true;

                if (bulletList.Count() < 20)
                {
                    bulletList.Add(newBullet);
                }

            }

            if (bulletDelay == 0)
                bulletDelay = 20;
        }


        public void UpdateBullets()
        {

            foreach (Bullets b in bulletList)
            {
                b.boundingBox = new Rectangle((int)b.position.X, (int)b.position.Y, b.texture.Width, b.texture.Height);
                b.position.Y = b.position.Y - 10f;
                if (b.position.Y <= 0)
                {
                    b.isVisible = false;   
                }
            }

            for (int i = 0; i < bulletList.Count; i++)
            {
                if (!bulletList[i].isVisible)
                {
                    bulletList.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
