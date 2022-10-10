using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;


namespace BrickBreaker
{
    /// <summary>
    /// The ball that move on the screen and breaks bricks
    /// Manages the hitbox, color, and velocity
    /// </summary>
    internal class Ball
    {
        private float xPos;
        private float yPos;
        private int radius;
        private Rectangle hitbox;
        private Color color;
        private Vector2 velocity;

        /// <summary>
        /// Creates a ball of given size, position, and color tint
        /// </summary>
        /// <param name="xPos">x-coordinate of top left corner</param>
        /// <param name="yPos">y-coordinate of top left corner</param>
        /// <param name="radius">Radius of ball</param>
        /// <param name="color">Tint color of ball</param>
        public Ball(int xPos, int yPos, int radius, Color color)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.radius = radius;
            this.color = color;
            this.velocity = new Vector2(0,0);

            hitbox = new Rectangle(xPos, yPos, radius * 2, radius * 2);
        }

        /// <summary>
        /// Retrieves the hitbox of the ball
        /// </summary>
        /// <returns>Hitbix of the ball</returns>
        public Rectangle GetHitbox()
        {
            return hitbox;
        }

        public void Move()
        {
            velocity.X += 10f;
            velocity.Y += 10f;
            xPos += velocity.X;
            yPos += velocity.Y;
            return;
        }
        
        public void UpdatePos()
        {

        }

    }
}
