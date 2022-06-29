using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Potate_O
{
    class Bullets
    {
        public Texture2D texture;
        public Vector2 position;
        public Vector2 velocity;
        public Vector2 origin;
        public Rectangle boundingBox;
        public bool isVisible;

        public Bullets(Texture2D newTexture)
        {
            texture = newTexture;
            isVisible = false;
        }

        public void Update(GameTime gameTime)
        {
            boundingBox = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if(isVisible)
            spriteBatch.Draw(texture, position, null, Color.White, 0f, origin, 1f, SpriteEffects.None, 0);
        }
    }
}
