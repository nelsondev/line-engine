using System;

namespace LineEngine
{
    public struct Point : IEquatable<Point>, ICloneable
    {
        //Properties
        public int X { get; set; }
        public int Y { get; set; }

        //Constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Methods
        public double Distance(int x, int y)
        {
            return Distance(this, new Point(x, y));
        }
        public double Distance(Point point)
        {
            return Distance(this, point);
        }
        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
        }

        //Implement
        public override string ToString() { return $"Point({X}, {Y})"; }
        public object Clone() { return new Point(X, Y); }

        //Deserialize from string
        public Point FromString(string str)
        {
            int x;
            int y;

            // remove prefix and suffix
            str = str.Replace("Point(", "").Replace(")", "");
            var list = str.Split(',');

            // parse integers after removing white space
            x = int.Parse(list[0].Trim());
            y = int.Parse(list[1].Trim());

            // return new point
            return new Point()
            {
                X = x,
                Y = y
            };
        }

        //So points can be keys in hash tables
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ (X.GetHashCode() << 2);
        }

        //Compare points
        public bool Equals(Point other)
        {
            return (X == other.X && Y == other.Y);
        }
        public override bool Equals(object other)
        {
            return other is Point point && Equals(point);
        }
        public static bool Equals(Point a, Point b)
        {
            return (a.X == b.X && a.Y == b.Y);
        }

        /*
         * Transform
         */
        // Instance
        public Point Set(Point a) { X = a.X; Y = a.Y; return this; }
        public Point Set(int x, int y) { return Set(new Point(x, y)); }
        public Point Add(Point a) { return Add(this, a); }
        public Point Add(int x, int y) { return Add(X, Y, x, y); }
        public Point AddX(int x) { return AddX(this, x); }
        public Point AddY(int y) { return AddY(this, y); }

        public Point Subtract(Point a) { return Subtract(this, a); }
        public Point SubtractX(int x) { return SubtractX(this, x); }
        public Point SubtractY(int y) { return SubtractY(this, y); }

        public Point Negate() { return Negate(this); }
        public Point NegateX() { return NegateX(this); }
        public Point NegateY() { return NegateY(this); }

        public Point Multiply(Point a) { return Multiply(this, a); }
        public Point Divide(Point a) { return Divide(this, a); }

        // Static 
        public static Point Add(int a, int b, int x, int y) { return new Point(a + x, b + y); }
        public static Point Add(Point a, Point b) { return new Point(a.X + b.X, a.Y + b.Y); }
        public static Point AddX(Point a, int x) { return new Point(a.X + x, a.Y); }
        public static Point AddY(Point a, int y) { return new Point(a.X, a.Y + y); }

        public static Point Subtract(Point a, Point b) { return new Point(a.X - b.X, a.Y - b.Y); }
        public static Point SubtractX(Point a, int x) { return new Point(a.X - x, a.Y); }
        public static Point SubtractY(Point a, int y) { return new Point(a.X, a.Y - y); }

        public static Point Negate(Point a) { return new Point(-a.X, -a.Y); }
        public static Point NegateX(Point a) { return new Point(-a.X, a.Y); }
        public static Point NegateY(Point a) { return new Point(a.X, -a.Y); }

        public static Point Multiply(Point a, Point b) { return new Point(a.X * b.X, a.Y * b.Y); }
        public static Point MultiplyX(Point a, int x) { return new Point(a.X * x, a.Y); }
        public static Point MultiplyY(Point a, int y) { return new Point(a.X, a.Y * y); }

        public static Point Divide(Point a, Point b) { return new Point(a.X / b.X, a.Y / b.Y); }
        public static Point DivideX(Point a, int x) { return new Point(a.X / x, a.Y); }
        public static Point DivideY(Point a, int y) { return new Point(a.X, a.Y / y); }

        /* 
         * Operators
         */

        //Add two points
        public static Point operator +(Point a, Point b) { return Add(a, b); }
        //Subtract two points
        public static Point operator -(Point a, Point b) { return Subtract(a, b); }
        //Negate a point
        public static Point operator -(Point a) { return Negate(a); }
        //Multiply two points
        public static Point operator *(Point a, Point b) { return Multiply(a, b); }
        //Divide two points
        public static Point operator /(Point a, Point b) { return Divide(a, b); }
        //Compare two points
        public static bool operator ==(Point a, Point b) { return Equals(a, b); }
        //Compare two points
        public static bool operator !=(Point a, Point b) { return !Equals(a, b); }
    }
}
