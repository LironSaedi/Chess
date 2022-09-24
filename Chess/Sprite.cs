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
    class Sprite
    {
        public Texture2D Texture;
        public Vector2 Position;
        public Rectangle? SourceRectangle;
        public Color Color;
        public float Rotation;
        public Vector2 Origin;
        public Vector2 Scale;
        public SpriteEffects Effects;
        public float LayerDepth;

        public Sprite(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
        {
            Texture = texture;
            Position = position;
            SourceRectangle = sourceRectangle;
            Color = color;
            Rotation = rotation;
            Origin = origin;
            Scale = scale;
            Effects = effects;
            LayerDepth = layerDepth;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(Texture, Position, null, Color.White, 0f, new Vector2(0, 0), new Vector2(100, 100), SpriteEffects.None, 0);
        }
    }
}
