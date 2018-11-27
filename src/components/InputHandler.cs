using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Torment.Components
{
    [Serializable]
    public class InputHandler : IComponent
    {
        public GameObject Parent { get; set; }

        public Vector2 JumpForce { get; set; }

        /*Set up key-binds*/
        Keys rightKey = Keys.D;
        Keys leftKey = Keys.A;
        Keys jumpKey = Keys.Space;

        KeyboardState oldState;
        public InputHandler(GameObject parent)
        {
            this.Parent = parent;
            oldState = Keyboard.GetState();
            JumpForce = new Vector2(0, -200);   // TODO (rj): tweak this value when implementing floor collision
        }

        public void HandleUserInput(Vector2 velocity)
        {
            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(leftKey))
            {
                Parent.Transform.Move(-velocity);
                Parent.Sprite.FacingDir = -1;
            }

            if (state.IsKeyDown(rightKey))
            {
                Parent.Transform.Move(velocity);
                Parent.Sprite.FacingDir = 1;
            }

            if (state.IsKeyDown(jumpKey) && oldState.IsKeyUp(jumpKey))
            {
                Parent.Transform.Move(JumpForce);
            }
            oldState = state;

        }

        public GameObject GetParent()
        {
            return this.Parent;
        }
    }
}