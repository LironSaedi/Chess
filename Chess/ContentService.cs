using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Chess
{
    class ContentService<TEnum> where TEnum : Enum
    {
        public Dictionary<TEnum, Texture2D> Textures { get; private set; }
        
        public Dictionary<TEnum, SpriteFont> Fonts { get; private set; }


        public static ContentService<TEnum> instance { get; } = new ContentService<TEnum>();
        private ContentManager content;

        private ContentService()
        {
            Textures = new Dictionary<TEnum, Texture2D>();
            Fonts = new Dictionary<TEnum, SpriteFont>();
        }

        public void LoadContentTextures(ContentManager Content, string name, TEnum key)
        {
            Texture2D  storage = Content.Load<Texture2D>(name);
            Textures.Add(key, storage);
        }

        public void LoadContentFonts(ContentManager Content, string name, TEnum key)
        {
            SpriteFont storage = Content.Load<SpriteFont>(name);
            Fonts.Add(key, storage);
        }
        

    }

}
