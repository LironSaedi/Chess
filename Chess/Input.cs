using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
     class Input
    {
        public KeyboardState keyboardState;
        public MouseState mouseState;

        public static Input Empty
        {
            get
            {
                return new Input();
            }
        }

        public Input(KeyboardState keyboard, MouseState mouse)
        {
            keyboardState = keyboard;
            mouseState = mouse;
        }

        public Input()
        {
            keyboardState = new KeyboardState();
            mouseState = new MouseState();
        }

        public void Add(Input input)
        {
            /*
            HashSet<Keys> hash = new HashSet<Keys>(Keyboard.GetPressedKeys());
            var keys = input.Keyboard.GetPressedKeys();
            foreach (var item in keys)
            {
                if (!hash.Contains(item))
                {
                    hash.Add(item);
                }
            }
            */
            ButtonState leftBtn = mouseState.LeftButton;
            if (input.mouseState.LeftButton == ButtonState.Pressed)
            {
                leftBtn = ButtonState.Pressed;
            }
            ButtonState rightButton = mouseState.RightButton;
            if (input.mouseState.RightButton == ButtonState.Pressed)
            {
                rightButton = ButtonState.Pressed;
            }
            ButtonState middleBtn = mouseState.MiddleButton;
            if (input.mouseState.MiddleButton == ButtonState.Pressed)
            {
                middleBtn = ButtonState.Pressed;
            }
            mouseState = new MouseState(mouseState.X, mouseState.Y, 0, leftBtn, middleBtn, rightButton, ButtonState.Released, ButtonState.Released);

            keyboardState = Keyboard.GetState();
            mouseState = Mouse.GetState();


        }

    }
}
