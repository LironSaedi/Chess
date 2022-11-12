using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class ButtonCondition
    {
        enum ButtonCondition
        {
            None,
            Hovered,
            Pressed
        }

        class Button
        {
            #region Members
            public ButtonCondition State { get; protected set; }

            protected Sprite sprite;


            public event EventHandler Click;
            public event EventHandler Hover;
            public event EventHandler UnHover;

            public Color Color
            {
                get { return sprite.Color; }
                set { sprite.Color = value; }
            }



            public Texture2D Texture
            {
                set
                {
                    sprite.Texture = value;
                }
            }


            public Button(Sprite sprite)
            {
                this.sprite = sprite;
            }

            public virtual void Update(Input currentInput, Input previousInput)
            {

                if (currentInput.Mouse.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released &&
                    previousInput.Mouse.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed &&
                    State != ButtonCondition.None)
                {

                    State = ButtonCondition.Pressed;
                    OnClick(EventArgs.Empty);
                }
                else if (State != ButtonCondition.Hovered)
                {
                    if (State == ButtonCondition.None)
                    {
                        OnHover(EventArgs.Empty);
                    }
                    State = ButtonCondition.Hovered;
                }


                else if (State != ButtonCondition.None)
                {
                    OnUnHover(EventArgs.Empty);
                    State = ButtonCondition.None;
                }
            }

            public virtual void Update(MouseState currentInput, Input previousInput)
            {

                if (currentInput.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released &&
                    previousInput.Mouse.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed &&
                    State != ButtonCondition.None)
                {
                    State = ButtonCondition.Pressed;
                    OnClick(EventArgs.Empty);
                }
                else if (State != ButtonCondition.Hovered)
                {
                    if (State == ButtonCondition.None)
                    {
                        OnHover(EventArgs.Empty);
                    }
                    State = ButtonCondition.Hovered;
                }


                else if (State != ButtonCondition.None)
                {
                    OnUnHover(EventArgs.Empty);
                    State = ButtonCondition.None;
                }
            }



            protected virtual void OnClick(EventArgs click)
            {

                EventHandler handler = Click;
                handler?.Invoke(this, click);
            }

            protected virtual void OnHover(EventArgs hover)
            {

                EventHandler handler = Hover;
                handler?.Invoke(this, hover);
            }

            protected virtual void OnUnHover(EventArgs unhover)
            {
                EventHandler handler = UnHover;
                handler?.Invoke(this, unhover);
            }

        }
    }


}