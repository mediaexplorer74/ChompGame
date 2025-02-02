﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameManager
{
	public interface IAnimation
	{
		Texture2D CurrentFrame { get; set; }

		void Reset();

		void Update(GameTime gameTime);
	}
}
