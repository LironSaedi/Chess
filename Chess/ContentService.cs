using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class ContentService
    {
        public Dictionary<string, Texture2D> Textures { get; private set; }
        public Dictionary<string, SpriteFont> Fonts { get; private set; }


        private static ContentService instance;
        private ContentManager content;

        private ContentService()
        {
            Textures = new Dictionary<string, Texture2D>();
            Fonts = new Dictionary<string, SpriteFont>();
        }

        public void LoadContent(ContentManager Content, GraphicsDevice graphicsDevice, SpriteBatch spriteBatch)
        {

        }

    }

}
