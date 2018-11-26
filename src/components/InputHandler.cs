using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Torment.Components
{
    [Serializable]
    public class InputHandler : IComponent
    {
        public GameObject Parent { get; set; }

        private bool _isJumping;
        
        public InputHandler(GameObject parent)
        {
            this.Parent = parent;
        }

        public void HandleUserInput(Vector2 velocity)
        {
            KeyboardState state = Keyboard.GetState();
            KeyboardState oldState = new KeyboardState();
            if (state.IsKeyDown(Keys.Left))
            {
                Parent.Transform.Move(-velocity);
            }

            if (state.IsKeyDown(Keys.Right))
            {
                Parent.Transform.Move(velocity);
            }

            if (state.IsKeyDown(Keys.Up) && oldState.IsKeyUp(Keys.Up))
            {
                Parent.Transform.Move(new Vector2(0, -10));
            }

            if (state.IsKeyUp(Keys.Up) && oldState.IsKeyDown(Keys.Up))
            {
                Parent.Transform.Move(new Vector2(0, 10));
            }

            state = oldState;

        }

        public GameObject GetParent()
        {
            return this.Parent;
        }
    }
}