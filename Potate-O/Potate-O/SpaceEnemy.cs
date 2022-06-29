using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;

namespace Potate_O
{
    public class SpaceEnemy
    {
        public Rectangle boundingBox;
        public Texture2D texture;
        public Vector2 position;
        public Vector2 origin;
        public float rotationAngle;
        public int speed;
        //public bool isColliding, destroyed;
        public bool isVisible;

        Random random = new Random();
        public float randX, randY;


        public SpaceEnemy(Texture2D newTexture, Vector2 newPosition)
        {
            position = newPosition;
            texture = newTexture;
            speed = 4;

            randX = random.Next(10, 700);
            randY = random.Next(-600, -50);

            isVisible = true;
        }

        public void LoadContent(ContentManager Content)
        {

        }

        public void Update(GameTime gameTime)
        {
            boundingBox = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);


            origin.X = texture.Width / 2;
            origin.Y = texture.Height / 2;

            position.Y += speed;
            if (position.Y >= 600)
            {
                isVisible = false;
            }


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (isVisible)
            {
                spriteBatch.Draw(texture, position, Color.White);
            }
        }
    }
}
