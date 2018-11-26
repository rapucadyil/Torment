using System;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Torment.Components;

namespace Torment
{
    /// <summary>
    /// Default class for an entity inside of the game i.e. Player, Enemies, NPCs etc...
    /// </summary>
    [XmlRoot("root")]
    public class GameObject
    {
        public uint EntityID { get; set; }
        [XmlAttribute("entity name")]
        public string EntityName { get; set; }
        public TransformComponent Transform { get; set; }
        public SpriteComponent Sprite { get; set; }
        public InputHandler Input { get; set; }

        private  Vector2 _horizontalSpeed;
        private  Vector2 _verticalSpeed;
        
        /// <summary>
        /// Default constructor 
        /// </summary>
        public GameObject()
        {
            EntityID = 0;
            EntityName = "dummy";
            Transform = new TransformComponent(this);
            Sprite = null;    //TODO: make this a default sprite.
            Input = new InputHandler(this);
            _horizontalSpeed = new Vector2(5,0);
            _verticalSpeed = new Vector2(0,5);
        }
        
        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="pos"></param>
        /// <param name="spr"></param>
        /// <param name="content"></param>
        public GameObject(uint id, string name, TransformComponent pos, SpriteComponent spr)
        {
            EntityID = id;
            EntityName = name;
            Transform = pos;
            Sprite = spr;
            Input = new InputHandler(this);
            _horizontalSpeed = new Vector2(5,0);
            _verticalSpeed = new Vector2(0,5);
        }
        
        /// <summary>
        /// Do entity logic in here. Updates per frame
        /// </summary>
        public void Tick(GameTime gameTime)
        {
            KeyboardState state = Keyboard.GetState();
            //this.Transform.PhysicsUpdate();
            Input.HandleUserInput(_horizontalSpeed);
            Console.Write("ticking..." + gameTime.ElapsedGameTime.ToString());
        
        }
        
        public void Draw(SpriteBatch spriteBatch)
        {
            
            Sprite.Render(spriteBatch, Transform.Position);
        }
        
    }
}