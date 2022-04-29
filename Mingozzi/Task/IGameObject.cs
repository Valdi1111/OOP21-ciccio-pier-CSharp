﻿using System.Drawing;

namespace Task
{
    public interface IGameObject
    {
        /// <summary>
        /// Get the width of the Entity
        /// </summary>
        /// <returns>The Entity width</returns>
        int GetWidth();

        /// <summary>
        /// Get the height of the Entity
        /// </summary>
        /// <returns>The Entity height</returns>
        int GetHeight();
        
        /// <summary>
        /// Get the position in the world
        /// </summary>
        /// <returns> The position</returns>
        Vector2D GetPos();

        /// <summary>
        /// Set the position inside the World
        /// </summary>
        /// <param name="pos"> The new position</param>
        void SetPos(Vector2D pos);

        Rectangle GetBounds();

        
    }
}