using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace PongGame
{
    class Paddle: Sprite
    {       
        public Paddle(Texture2D texture, Vector2 location, Rectangle screenBounds): base(texture,location)
        {
            // TODO: Complete member initialization
            this.texture = texture;
            this.location = location;
        }

        public override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
                velocity = new Vector2(0, -0.9f);
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
                velocity = new Vector2(0, 0.9f);
            base.Update(gameTime);
        }

        protected override void CheckBounds()
        {
            //location.Y = MathHelper.Clamp(location.Y, 0, screenBounds.Height - texture.Height);
            
            if (location.Y <= 0)
                location.Y = 0;
            else if (location.Y >= (screenBounds.Height - texture.Height))
                location.Y = screenBounds.Height - texture.Height;
        }

        
    }
}
