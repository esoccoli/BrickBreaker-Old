using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace BrickBreaker
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D brickTexture;
        private Texture2D ballTexture;
        private int xPos, yPos, width, height;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            _graphics.PreferredBackBufferWidth = 420;
            _graphics.PreferredBackBufferHeight = 980;
            _graphics.ApplyChanges();

            xPos = 50;
            yPos = 70;
            width = 75;
            height = 25;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            ballTexture = this.Content.Load<Texture2D>("bouncy");
            // TODO: use this.Content to load your game content here

            brickTexture = this.Content.Load<Texture2D>("brick");
            //brickTexture.SetData(new Color[] { Color.White });
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            //Brick[,] brickList = new Brick[15, 4]; // Creates array of bricks
            Ball ball = new Ball(xPos, yPos, 10, Color.White);
            _spriteBatch.Begin();

            _spriteBatch.Draw(ballTexture, new Vector2(200, 800), Color.White);

            for (int row = 0; row < 15; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Brick currBrick = new Brick(xPos, yPos, width, height, Color.DarkGreen);
                    _spriteBatch.Draw(brickTexture, currBrick.GetHitbox(), Color.White);
                    xPos += 80;
                }
                yPos += 30;
                xPos = 50;
            }
            yPos = 70;

            ball.Move();
            // 15 rows and 4 columns of bricks
            // Each brick is 75 wide, 25 high
            // First brick has top left corner at (50, 70)
            // x-coordinate is 80 more than previous brick in row
            // y-coordinate is 30 more than previous brick in column
            _spriteBatch.End();
        }
    }
}