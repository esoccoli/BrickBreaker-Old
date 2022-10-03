using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{
    /// <summary>
    /// The bricks that appear on screen
    /// Manages the position, hitbox, color,
    /// and whether it is broken
    /// </summary>
    internal class Brick
    {
        private Rectangle hitbox;
        private Color color;
        private bool isBroken;

        /// <summary>
        /// Used to create a Brick object
        /// </summary>
        /// <param name="hitbox">The position of the rectangle</param>
        /// <param name="color">The color of the rectangle</param>
        public Brick(Rectangle hitbox, Color color)
        {
            this.hitbox = hitbox;
            this.color = color;
            this.isBroken = false;
        }

        public void UpdateBrick(Rectangle BallPos)
        {

        }
    }
}
