using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSoop
{
    /// <summary>
    /// This class represents a point in two-dimensional space.
    /// </summary>
    internal class Point
    {
        // These two are auto-properties; they provide uncontrolled access.
        public double X {  get; set; }  // Horizontal coordinate of the point.
        public double Y { get; set; }   // vertical coordinate of the point.

        /// <summary>
        /// The default constructor starts with zero values for both coordinates.
        /// </summary>
        public Point() { X = 0; Y=0; }

        /// <summary>
        /// The constructor with parameters assign initial values to coordinates.
        /// </summary>
        public Point(double xinit, double yinit)
        {  X = xinit; Y = yinit; }

        /// <summary>
        /// We override the ToString() function inherited from the parent class object.
        /// The result is a string output where the components' values appear within parentheses,
        /// like (3.45608221376 : 0.0075543d92)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "(" + X + " : " + Y + ")";
        }
        /* The following two member functions are combined in the final function's code.
                /// <summary>
                /// This member function calculates the distance of this point to the origin.
                /// </summary>
                /// <returns></returns>
                public double Distance()
                {
                    return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
                }

                /// <summary>
                /// This member function calculates the distance between this point
                /// with another point p.
                /// </summary>
                /// <param name="p">The reference variable pointing to the other Point object</param>
                /// <returns></returns>
                public double Distance(Point p)
                {
                    return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
                }
        */

        /// <summary>
        /// This member function calculates the distance between this point
        /// with another point p.
        /// The parameter p is a nullable reference field.
        /// If no Point object is sent as the parameter,
        /// p reference will be null (will have address zero).
        /// Then the function calculates and returns the distance
        /// of this point to the origin.
        /// </summary>
        /// <param name="p">The nullable reference variable which may be pointing to the other Point object</param>
        /// <returns></returns>
        public double Distance(Point? p = null)
        {
            if(p == null)
            { p = new Point(); }

            return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2));
        }
    }
}
