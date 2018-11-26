using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Torment;
namespace Torment.States
{
    /// <summary>
    /// The base interface for a state that the game can be in (i.e. main menu, gameplay, end ...)
    /// </summary>
    public interface IGameState
    {
     
        // the type of game state this is
        string StateType { get; set; }
        // The list of GameObjects in this state
        List<GameObject> Entities { get; set; }
        // ticks every frame
        void Tick(GameTime gameTime);
        // draw logic here
        void Draw(SpriteBatch spriteBatch);

    }
}