using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Torment.States
{
    public class MainMenuState : IGameState
    {
        public string StateType { get; set; }
        public List<GameObject> Entities { get; set; }

        public MainMenuState()
        {
            this.StateType = "Main Menu";
        }
        
        
        public void Tick(GameTime gameTime)
        {
            foreach (var gameObject in Entities)
            {
                gameObject.Tick(gameTime);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var gameObject in Entities)
            {
                gameObject.Draw(spriteBatch);
            }
        }
    }
}