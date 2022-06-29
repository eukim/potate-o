using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Potate_O
{
    class IceCream
    {
        public Texture2D texture;
        public Vector2 position;
        public Rectangle rectangle;

        public IceCream(Texture2D newTexture, Vector2 newPosition)
        {
            texture = newTexture;
            position = newPosition;

            rectangle = new Rectangle((int)position.X, (int)position.Y,
                texture.Width, texture.Height);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }

    }
}
