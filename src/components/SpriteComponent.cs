using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Torment.Components
{
    [Serializable]
    public class SpriteComponent
    {
        // TODO: anim stuff
        // TODO: streamline with game object
        public Texture2D Sprite { get; set; }
        public GameObject Parent { get; set; }

        public SpriteComponent(string file, ContentManager content)
        {
            Sprite = content.Load<Texture2D>(file);
        }

        public void Render(SpriteBatch spriteBatch, Vector2 pos)
        {
            spriteBatch.Draw(Sprite, pos, null, Color.White, 0f, 
                Vector2.Zero, 0.25f, SpriteEffects.None, 0f);
        }
    }
}