using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Potate_O
{
    class Camera1
    {
        private Matrix transform;
        public Matrix Transform
        {
            get { return transform; }
        }

        public Vector2 center;
        private Viewport viewport;

        public float X
        {
            get { return center.X; }
            set { center.X = value; }
        }
        public float Y
        {
            get { return center.Y; }
            set { center.Y = value; }
        }

        public Camera1(Viewport newViewport)
        {
            viewport = newViewport;
        }

        public void Update(Vector2 position)
        {
            center = new Vector2(position.X, position.Y);
            transform = Matrix.CreateScale(new Vector3(1, 1, 0)) * Matrix.CreateTranslation(new Vector3(-center.X, -center.Y, 0)) * Matrix.CreateTranslation(new Vector3(viewport.Width / 2 - 20, viewport.Height / 2 - 20, 0));
        }
    }
}
