﻿using Microsoft.Xna.Framework.Content.Pipeline.Graphics;
using System.Collections.Generic;

namespace Pipefoxe.Atlas
{
	/// <summary>
	/// Basic atlas container. Stores list of frames or sprites and their texture. 
	/// </summary>
	/// <typeparam name="T">Frame or Sprite.</typeparam>
	public class AtlasContainer<T>
	{
		public List<T> Items;
		public TextureContent Texture;

		public AtlasContainer() =>
			Items = new List<T>();
		
		public void Add(T item) =>
			Items.Add(item);
	}
}