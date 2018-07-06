﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassicUO.Game.WorldObjects
{
    public abstract class WorldRenderObject
    {
        public WorldRenderObject(in WorldObject parent)
        {
            WorldObject = parent;
        }

        public WorldObject WorldObject { get; }
        public Texture2D Texture { get; private set; }


        public virtual void Draw()
        {

        }

        public void AssignTexture(in Texture2D texture) => Texture = texture;
    }
}