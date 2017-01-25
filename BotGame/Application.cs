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

        public static Application Instance = new Application();

        private Application()
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

            _spriteBatch.Begin();

            int w = 100;
            int h = 100;

            Texture2D t = DrawHelper.createRectangle(w, h, false);

            _spriteBatch.Draw(t, new Rectangle(0, 0, w, h), Color.Blue);

            _spriteBatch.End();

            base.Draw(gameTime);
            
        }
    }
}