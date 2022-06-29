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
    class Player
    {
        public Texture2D texture;
        public Texture2D righttexture;
        public Texture2D lefttexture;
        public Vector2 position = new Vector2(100,180);
        private Vector2 velocity;
        public Rectangle rectangle;

        public float gravity = 0.35f;
        public string upgrade;

        private bool hasJumped = false;

        public Vector2 Position
        {
            get { return position; }
        }

        public Player() { }

        public void Load(ContentManager Content)
        {
            texture = Content.Load<Texture2D>("smallpotato");
            righttexture = Content.Load<Texture2D>("smallpotato");
            lefttexture = Content.Load<Texture2D>("potatoFlip");
        }


        public void Update(GameTime gameTime, SoundEffect effect)
        {
            position += velocity;
            rectangle = new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);

            Input(gameTime, effect);

            if (velocity.Y < 10)
                velocity.Y += gravity;
        }


        private void Input(GameTime gameTime, SoundEffect effect)
        {
            if (upgrade != "jetpack")
            {
                if (Keyboard.GetState().IsKeyDown(Keys.D))
                {
                    texture = righttexture;
                    velocity.X = (float)gameTime.ElapsedGameTime.TotalMilliseconds / 3;
                }
                else if (Keyboard.GetState().IsKeyDown(Keys.A))
                {
                    texture = lefttexture;
                    velocity.X = -(float)gameTime.ElapsedGameTime.TotalMilliseconds / 3;
                }
                else velocity.X = 0f;

                if (Keyboard.GetState().IsKeyDown(Keys.Space) && hasJumped == false)
                {
                    position.Y -= 5f;
                    velocity.Y = -9f;
                    hasJumped = true;
                    effect.Play();
                }
            }
        }

    
        public void Collision(Rectangle newRectangle, int xOffset, int yOffset)
        {
            if (rectangle.TouchTopOf(newRectangle))
            {
                rectangle.Y = newRectangle.Y - rectangle.Height;
                velocity.Y = 0f;
                hasJumped = false;
            }
            if (rectangle.TouchLeftOf(newRectangle))
            {
                position.X = newRectangle.X - rectangle.Width - 2;
            }

            if (rectangle.TouchRightOf(newRectangle))
            {
                position.X = newRectangle.X + newRectangle.Width + 2;
            }

            if (rectangle.TouchBottomOf(newRectangle))
                velocity.Y = 1f;


            if (position.X < 0) position.X = 0;
            if (position.X > xOffset - rectangle.Width) position.X = xOffset - rectangle.Width;
            if (position.Y < 0) velocity.Y = 1f;
            if (position.Y > yOffset - rectangle.Height) position.Y = yOffset - rectangle.Height;
        }

        public void Draw(SpriteBatch spriteBatch)//, SpriteEffects flip)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}
