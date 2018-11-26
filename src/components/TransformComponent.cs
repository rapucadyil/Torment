using System;
using Microsoft.Xna.Framework;
namespace Torment.Components
{
    [Serializable]
    public class TransformComponent : IComponent
    {
     
        public Vector2 Position { get; set; }
        public GameObject Parent { get; set; }
        
        private readonly Vector2 _grav = new Vector2(0, 9.8f);
        
        public float MaxJumpHeight { get;}
        
        public TransformComponent(GameObject parent)
        {
            this.Position = Vector2.Zero;
            this.Parent = parent;
            MaxJumpHeight = this.Position.Y + 10;
        }

        public TransformComponent(Vector2 position, GameObject parent)
        {
            this.Position = position;
            this.Parent = parent;
            MaxJumpHeight = this.Position.Y + 10;
        }

        public void PhysicsUpdate()
        {
            this.Move(_grav);
        }
        
        public void Move(Vector2 velocity)
        {
            this.Position += velocity;
        }

        public GameObject GetParent()
        {
            return this.Parent;
        }
    }
}