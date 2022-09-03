using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Sprite
    {
        public Texture2D texture;
        public Vector2 Position;
        public Rectangle? rectangle;
        public Color color;
        public float rotation;
        public Vector2 origin;
        public Vector2 scale;
        public SpriteEffects effects;
        public float layerDepth;
        public Sprite(Texture2D texture, Vector2 Poisiton, Rectangle? rectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
        {
            this.texture = texture;
            this.Position = Position;
            this.rectangle = rectangle;
            this.color = color;
            this.rotation = rotation;
            this.origin = origin;
            this.scale = scale;
            this.effects = effects;
            this.layerDepth = layerDepth;
        }



        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, Position, null, Color.White, 0f, new Vector2(0, 0), new Vector2(100, 100), SpriteEffects.None, 0);
        }
    }
}
