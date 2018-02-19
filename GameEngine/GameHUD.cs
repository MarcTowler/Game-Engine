﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace GameEngine
{
    public class GameHUD
    {
        SpriteFont font;
        public void Load(ContentManager content)
        {
            font = content.Load<SpriteFont>("Fonts\\Arial");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.DrawString(font, "Score: " + Player.score.ToString(), Vector2.Zero, Color.White);
            spriteBatch.End();
        }
    }
}