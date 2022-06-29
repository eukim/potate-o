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

namespace Potate_O
{
    class Enemy
    {
      public  Texture2D texture;
      public Texture2D texture1;
      public Texture2D texture2;
        public Vector2 position;
        Vector2 origin;
        public Vector2 velocity;
        public Rectangle rectangle;
        bool right = true;
        float rotation = 0f;
        public float speed = 1f;
        public float speed2 = -1f;
        float distance;
        float oldDistance;

       public  float playerDistance;

        public Enemy(Texture2D newTexture, Vector2 newPosition, float newDistance)
        {
            texture = newTexture;
            position = newPosition;
            distance = newDistance;

            oldDistance = distance;

            rectangle = new Rectangle((int)position.X, (int)position.Y,
                    75, 50);
        }

        public void Update(Player player)
        {
            position += velocity;
            rectangle.X = (int)position.X;
            rectangle.Y = (int)position.Y; 
            //origin = new Vector2(texture.Width / 2, texture.Height / 2 + 100);

            if (distance <= origin.X - 100)
            {
                right = true;
                velocity.X = speed;

            }
            else if (distance >= oldDistance)
            {
                right =false;
                velocity.X = speed2;
            }
            if (right) distance += 1; else distance -= 1; ;

            playerDistance = player.Position.X - position.X;

            if (playerDistance >= -200 && playerDistance <= 200)
            {
                if (playerDistance < -1)
                    velocity.X = speed2;
                if (playerDistance > 1)
                    velocity.X = speed;
                else if (playerDistance == 0)
                {
                    velocity.X = 0f; 
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (velocity.X > 0)
            {
                //.Draw(texture, position, null, Color.White, rotation, origin,1f, SpriteEffects.None, 0f);
                            spriteBatch.Draw(texture, rectangle, Color.White);
            }
            else
            {
                //spriteBatch.Draw(texture, position, null, Color.White, rotation, origin, 1f, SpriteEffects.FlipHorizontally, 0f);
                spriteBatch.Draw(texture, rectangle, Color.White);
            }
        }

    }
}
