using System;

namespace Task
{
    public class Vector2D
    {
        private double _x;
        private double _y;

        /// <summary>
        /// Default constructor sets x,y to 0
        /// </summary>
        public Vector2D()
        {
            this._x = 0;
            this._y = 0;
        }

        /// <summary>
        /// Constructor with params x,y coordinate of the cartesian plane
        /// </summary>
        /// <param name="x">coordinate</param>
        /// <param name="y">coordinate</param>
        public Vector2D(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        /// <summary>
        /// Get the X coordinate
        /// </summary>
        /// <returns> The x value of the Vector</returns>
        public int GetX()
        {
            return (int)Math.Round(this._x);
        }
        
        /// <summary>
        /// Get the X coordinate as double
        /// </summary>
        /// <returns> The x value of the Vector</returns>
        public double GetDoubleX()
        {
            return this._x;
        }
        
        /// <summary>
        /// Get the Y coordinate
        /// </summary>
        /// <returns> The y value of the Vector</returns>
        public int GetY()
        {
            return (int)Math.Round(this._y);
        }

        /// <summary>
        /// Get the Y coordinate as double
        /// </summary>
        /// <returns> The y value of the Vector</returns>
        public double GetDoubleY()
        {
            return this._y;
        }
        
        public void Add(Vector2D vector)
        {
            this._x += vector._x;
        }

        public Vector2D AddVector(Vector2D vector) 
        {
            return new Vector2D(this._x + vector.GetX(), this._y + vector.GetY());
        }
        
        public Vector2D SubVector(Vector2D vector) 
        {
            return new Vector2D(this._x - vector.GetX(), this._y - vector.GetY());
        }
        
        public void SetX(double x) {
            this._x = x;
        }


        public void SetY(double y) {
            this._y = y;
        }
        
        ///<inheritdoc /> 
        public override string ToString()
        {
            return "Vector2d{" +
                   "x=" + this._x +
                   ", y=" + this._y +
                   '}';
        }
    }
}