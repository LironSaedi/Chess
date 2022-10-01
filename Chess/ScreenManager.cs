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

        private DriverClass game;
    }
}
