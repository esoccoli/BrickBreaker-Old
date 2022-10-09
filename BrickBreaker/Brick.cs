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
        // ============================= FIELDS =============================

        // Size and position
        private int xPos;
        private int yPos;
        private int width;
        private int height;

        private Rectangle hitbox;
        private Color color;
        private bool isBroken;


        // ============================= CONSTRUCTORS =============================

        /// <summary>
        /// Creates a brick with specified size, position, and color
        /// </summary>
        /// <param name="xPos">x-coordinate of top left corner</param>
        /// <param name="yPos">y-coordinate of top left corner</param>
        /// <param name="width">Width of the brick</param>
        /// <param name="height">Height of the brick</param>
        /// <param name="color">Color of the brick</param>
        public Brick(int xPos, int yPos, int width, int height, Color color)
        {
            // Size and position
            this.xPos = xPos;
            this.yPos = yPos;
            this.width = width;
            this.height = height;
            
            this.color = color;
            hitbox = new Rectangle(xPos, yPos, width, height);
            isBroken = false;
        }

        /// <summary>
        /// Creates a brick at given size and position
        /// </summary>
        /// <param name="xPos">x-coordinate of the top left corner</param>
        /// <param name="yPos">y-coordinate of the top left corner</param>
        /// <param name="width">Width of the brick</param>
        /// <param name="height">Height of the brick</param>
        public Brick(int xPos, int yPos, int width, int height)
        {
            // Size and position
            this.xPos = xPos;
            this.yPos = yPos;
            this.width = width;
            this.height = height;

            hitbox = new Rectangle(xPos, yPos, width, height);
            color = Color.Red;
            isBroken = false;
        }

        /// <summary>
        /// Creates a brick at given position
        /// </summary>
        /// <param name="xPos">x-coordinate of top left corner</param>
        /// <param name="yPos">y-coordinate of top left corner</param>
        public Brick(int xPos, int yPos)
        {
            // Size and position
            this.xPos = xPos;
            this.yPos = yPos;
            width = 75;
            height = 25;

            hitbox = new Rectangle(xPos, yPos, width, height);
            color = Color.Red;
            isBroken = false;
        }

        /// <summary>
        /// Creates a default brick
        /// </summary>
        public Brick()
        {
            // Size and position
            xPos = 50;
            yPos = 70;
            width = 75;
            height = 25;

            hitbox = new Rectangle(xPos, yPos, width, height);
            color = Color.Red;
            isBroken = false;
        }

        // ============================= METHODS =============================

        /// <summary>
        /// Retreives the x-coordinate of the top left corner
        /// </summary>
        /// <returns>x-coordinate of the brick</returns>
        public int GetX()
        {
            return xPos;
        }

        /// <summary>
        /// Retrieves the y-coordinate of the top left corner
        /// </summary>
        /// <returns>y-coordinate of the brick</returns>
        public int GetY()
        {
            return yPos;
        }

        /// <summary>
        /// Retrieves the width of the brick
        /// </summary>
        /// <returns>Width of the brick</returns>
        public int GetWidth()
        {
            return width;
        }

        /// <summary>
        /// Retrieves the height of the brick
        /// </summary>
        /// <returns>Height of the brick</returns>
        public int GetHeight()
        {
            return height;
        }

        /// <summary>
        /// Retrieves the hitbox of the brick
        /// </summary>
        /// <returns>Hitbox of the brick</returns>
        public Rectangle GetHitbox()
        {
            return hitbox;
        }

        /// <summary>
        /// Retrieves the color of the brick
        /// </summary>
        /// <returns>Color of the brick</returns>
        public Color GetColor()
        {
            return color;
        }

        /// <summary>
        /// Determines if the current brick has been broken
        /// </summary>
        /// <returns>True if the brick was broken, false otherwise</returns>
        public bool GetState()
        {
            return this.isBroken;
        }

        public void UpdateBrick(Rectangle BallPos)
        {
            
        }
    }
}
