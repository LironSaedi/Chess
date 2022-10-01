using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{

    interface IScreen
    {
        void Initialize(ScreenManager screenManager);

        void Draw(GameTime gameTime, SpriteBatch spriteBatch);

        void Update(GameTime gameTime, Input currentInput, previousInput);
    }

    interface IScreenManager
    {
        void Draw(GameTime gameTime, SpriteBatch spriteBatch);

        void Update(GameTime gameTime, Input currentInput, Input previousInput);

        void ChangeScreen();

        void RemoveAllScreens();

        void PopScreen();

        void PushScreen(IScreen screen);

        void ExitGame();
    }
}
