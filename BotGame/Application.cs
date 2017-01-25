using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BotGame
{
    class Application : Game
    {
        private SpriteBatch _spriteBatch;

        public Application()
        {
            var graphics = new GraphicsDeviceManager(this);

            graphics.SynchronizeWithVerticalRetrace = true;
            graphics.PreferredBackBufferWidth = 640;
            graphics.PreferredBackBufferHeight = 480;

            graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            base.Draw(gameTime);
            
        }
    }
}