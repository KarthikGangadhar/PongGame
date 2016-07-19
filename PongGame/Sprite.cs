using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PongGame
{
    public abstract class Sprite
    {
        protected Texture2D texture;
        protected Vector2 location;
        protected Vector2 velocity = Vector2.Zero;
        protected Rectangle screenBounds;
        public  Sprite(Texture2D texture, Vector2 location)
        {
            // TODO: Complete member initialization
            this.texture = texture;
            this.location = location;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture,location, Color.White);
        }

        public  virtual void Update(GameTime gameTime)
        {
            location += velocity;
            CheckBounds(); 
        }

        protected abstract void CheckBounds();
         
    }
}
