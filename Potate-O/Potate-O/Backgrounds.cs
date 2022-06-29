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
    class Backgrounds
    {
        public Texture2D texture;
        public  Rectangle rectangle;

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
        class Scrolling : Backgrounds
        {
            public Scrolling(Texture2D newTexture, Rectangle newRectangle)
            {
                texture = newTexture;
                rectangle = newRectangle;
            }

            public void Update()
            {
                KeyboardState keys = Keyboard.GetState();

                if (keys.IsKeyDown(Keys.D))
                {
                    rectangle.X -= 3;
                }
        }



    }
}
