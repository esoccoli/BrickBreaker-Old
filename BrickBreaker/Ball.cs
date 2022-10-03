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
    /// The ball that move on the screen and breaks bricks
    /// Manages the hitbox, color, and velocity
    /// </summary>
    internal class Ball
    {
        private Rectangle hitbox;
        private Color color;
        private Vector2 velocity;
    }
}
