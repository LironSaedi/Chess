using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
     class ScreenManager : IScreenManager
    {
        private Stack<IScreen> listOfScreens = new Stack<IScreen>();
        private IScreen currentScreen;

   //     private DriverClass game;

        public void ChangeScreen()
        {
            throw new NotImplementedException();
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }

        public void ExitGame()
        {
            throw new NotImplementedException();
        }

        public void PopScreen()
        {
            throw new NotImplementedException();
        }

        public void PushScreen(IScreen screen)
        {
            throw new NotImplementedException();
        }

        public void RemoveAllScreens()
        {
            throw new NotImplementedException();
        }

        public void Update(GameTime gameTime, Input currentInput, Input previousInput)
        {
            throw new NotImplementedException();
        }
    }
}
