using System;

namespace Tasks
{
    /// <summary>
    /// A simple 2d Vector class
    /// </summary>
    public class Vector2d
    {
        private double _x;
        private double _y;

        /// <summary>
        /// Default constructor sets x,y to 0
        /// </summary>
        public Vector2d()
        {
            _x = 0;
            _y = 0;
        }

        /// <summary>
        /// Constructor with params x,y coordinate of the cartesian plane
        /// </summary>
        /// <param name="x">coordinate</param>
        /// <param name="y">coordinate</param>
        public Vector2d(double x, double y)
        {
            _x = x;
            _y = y;
        }

        /// <summary>
        /// Get the X coordinate
        /// </summary>
        public int X => (int)Math.Round(_x);

        /// <summary>
        /// Get the Y coordinate
        /// </summary>
        public int Y => (int)Math.Round(_y);

        /// <summary>
        /// get and set the x value
        /// </summary>
        public double DoubleX
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// get and set the y value
        /// </summary>
        public double DoubleY
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// Add a vector to the current vector
        /// </summary>
        /// <param name="v1">vector to add</param>
        public void Add(Vector2d v1)
        {
            _x += v1.DoubleX;
            _y += v1.DoubleY;
        }

        /// <summary>
        ///Get the squared length of the vector
        /// </summary>
        /// <returns>squared length</returns>
        public double GetMagnitudeSq()
        {
            return Math.Pow(_x, 2) + Math.Pow(_y, 2);
        }

        /// <summary>
        /// Get the length of the vector
        /// </summary>
        /// <returns>length</returns>
        public double GetMagnitude()
        {
            return Math.Sqrt(GetMagnitudeSq());
        }

        /// <summary>
        /// Set the length of the vector to 1
        /// </summary>
        public void Normalize()
        {
            double length = Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_y, 2));

            _x /= length;
            _y /= length;
        }

        /// <summary>
        /// Multiply the length of the vector scalar time
        /// </summary>
        /// <param name="scalar">to multiply</param>
        public void Scale(double scalar)
        {
            _x *= scalar;
            _y *= scalar;
        }

        /// <summary>
        /// Set the maximus length that the vector can get
        /// </summary>
        /// <param name="max">length of the vector</param>
        public void SetLimiter(double max)
        {
            if (GetMagnitudeSq() > Math.Pow(max, 2))
            {
                Normalize();
                Scale(max);
            }
        }

        /// <summary>
        ///Set the length of a vector
        /// </summary>
        /// <param name="length">length desired to be</param>
        public void SetMagnitude(double length)
        {
            Normalize();
            Scale(length);
        }

        /// <summary>
        /// Set the variables x,y
        /// </summary>
        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        public void Set(double x, double y)
        {
            _x = x;
            _y = y;
        }

        /// <summary>
        ///Get the angle of the vector in radians
        /// </summary>
        /// <returns>angle</returns>
        public double GetAngle()
        {
            return Math.Atan2(_y, _x);
        }

        /// <summary>
        ///Rotate the vector by x degree
        /// </summary>
        /// <param name="degree">how much the vector need to rotate</param>
        public void RotateInDegree(double degree)
        {
            double x0 = _x;
            double y0 = _y;
            double straightAngle = 180d;
            double radiant = (Math.PI * degree) / straightAngle;

            _x = x0 * Math.Cos(radiant) - y0 * Math.Sin(radiant);
            _y = x0 * Math.Sin(radiant) + y0 * Math.Cos(radiant);
        }

        /// <summary>
        /// Add two vectors 
        /// </summary>
        /// <param name="v2">second vector</param>
        /// <returns>a vector</returns>
        public Vector2d AddVector(Vector2d v2)
        {
            return new Vector2d(_x + v2.X, _y + v2.Y);
        }

        /// <summary>
        /// Subtract the second vector from the first
        /// Current vector - v2
        /// </summary>
        /// <param name="v2">second vector</param>
        /// <returns>a vector</returns>
        public Vector2d SubVector(Vector2d v2)
        {
            return new Vector2d(_x - v2.X, _y - v2.Y);
        }

        /// <summary>
        /// Get a vector that points from this to the second with the same length
        /// Current vector ----> v2
        /// </summary>
        /// <param name="v2">second vector</param>
        /// <returns>a vector</returns>
        public Vector2d DirectionVector(Vector2d v2)
        {
            return new Vector2d(v2.X - _x, v2.Y - _y);
        }

        /// <summary>
        /// Get the euclidean distance of 2 vectors current and v2
        /// </summary>
        /// <param name="v2">second vector</param>
        /// <returns> the distance</returns>
        public double EuclidDistance(Vector2d v2)
        {
            double first = Math.Pow(_x - v2.X, 2);
            double second = Math.Pow(_y - v2.Y, 2);

            return Math.Sqrt(first + second);
        }

        /// <summary>
        /// Get a cloned verison of this vector
        /// </summary>
        /// <returns> a vector</returns>
        public Vector2d Clone()
        {
            return new Vector2d(_x, _y);
        }
    }
}