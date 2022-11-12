using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using System;

namespace Chess
{
    
    enum OptionButtonState
    {
        Unmarked,
        Marked
    }

    class OptionsButton : Button
    {
        public OptionButtonState MarkedState { get; private set; }



        public event EventHandler Marked;
        public event EventHandler UnMarked;

        public bool AllowClickToUnmark = true;

        public OptionsButton(Sprite sprite) : base(sprite)
        {
        }
        /*
        public override void Update(Input currentInput, Input previousInput)
        {
            if (currentInput.Contains(previousInput))
                {
                if (currentInput.Mouse.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released &&
                    previousInput.Mouse.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    State = ButtonCondition.Pressed;

                    if (AllowClickToUnmark && MarkedState == OptionButtonState.Marked)
                    {
                        UnMark();
                    }
                    else if (MarkedState != OptionButtonState.Marked)
                    {
                        Mark();
                    }
                    OnClick(EventArgs.Empty);
                }
                else if (State != ButtonCondition.Hovered && MarkedState != OptionButtonState.Marked)
                {
                    if (State == ButtonCondition.None)
                    {

                        OnHover(EventArgs.Empty);
                    }
                    State = ButtonCondition.Hovered;
                }
            }
            else if (State != ButtonCondition.None && MarkedState != OptionButtonState.Marked)
            {

                OnUnHover(EventArgs.Empty);
                State = ButtonCondition.None;
            }
        }

        public override void Update(MouseState currentInput, Input previousInput)
        {
            if (Contains(currentInput.Position))
            {
                if (currentInput.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released &&
                    previousInput.Mouse.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    State = ButtonCondition.Pressed;

                    if (AllowClickToUnmark && MarkedState == OptionButtonState.Marked)
                    {
                        UnMark();
                    }
                    else if (MarkedState != OptionButtonState.Marked)
                    {
                        Mark();
                    }
                    OnClick(EventArgs.Empty);
                }
                else if (State != ButtonCondition.Hovered && MarkedState != OptionButtonState.Marked)
                {
                    if (State == ButtonCondition.None)
                    {

                        OnHover(EventArgs.Empty);
                    }
                    State = ButtonCondition.Hovered;
                }
            }
            else if (State != ButtonCondition.None && MarkedState != OptionButtonState.Marked)
            {

                OnUnHover(EventArgs.Empty);
                State = ButtonCondition.None;
            }
        }

        public void Mark()
        {

            MarkedState = OptionButtonState.Marked;
            OnMarked(EventArgs.Empty);

        }

        public void UnMark()
        {

            MarkedState = OptionButtonState.Unmarked;
            OnUnMarked(EventArgs.Empty);
        }
    */
    }
