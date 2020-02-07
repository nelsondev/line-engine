using LineEngine;
using System;
using System.Collections.Generic;

namespace LineEngine
{
    public static class Draw
    {
        public static class Line
        {
            // Horizontal
            public static Point[] Horizontal(Point start, Point end)
            {
                var result = new List<Point>();
                var difference = Math.Abs(start.X - end.X);

                for (var i = 0; i < difference + 1; i++)
                {
                    result.Add(start.AddX(i));
                }

                return result.ToArray();
            }
            public static Point[] Horizontal(Point start, int length)
            {
                return Horizontal(start, start.AddX(length));
            }

            // Vertical
            public static Point[] Vertical(Point start, Point end)
            {
                var result = new List<Point>();
                var difference = Math.Abs(start.Y - end.Y);

                Console.WriteLine(difference);

                for (var i = 0; i < difference; i++)
                {
                    result.Add(start.AddY(i));
                }

                return result.ToArray();
            }
            public static IEnumerable<Point> Vertical(Point start, int length)
            {
                return Vertical(start, start.AddY(length));
            }

            // Diagonal
            public static Point[] Diagonal(Point start, Point end)
            {
                var result = new List<Point>();

                // rise / run (slope)

                var run = end.X - start.X;
                var rise = end.Y - start.Y;

                var m = rise / (float)run;

                // solve for b
                // (start with y = mx + b, subtract mx from both sides)
                var b = start.Y - (m * start.X);

                // Iterate through all possible coordinates.
                for (var x = start.X; x <= end.X; ++x)
                {
                    // solve for y
                    var y = (m * x) + b;

                    // round to nearest int
                    var rounded = Convert.ToInt32(Math.Round(y));

                    // convert int result back to float, compare
                    if (Math.Abs(rounded - y) < 1.0f)
                        result.Add(new Point(x, rounded));
                }

                return result.ToArray();
            }
            public static Display[] Diagonal(Point start, Point end, char c)
            {
                var result = new List<Display>();

                // rise / run (slope)

                var run = end.X - start.X;
                var rise = end.Y - start.Y;

                var m = rise / (float)run;

                // solve for b
                // (start with y = mx + b, subtract mx from both sides)
                var b = start.Y - (m * start.X);

                // Iterate through all possible coordinates.
                for (var x = start.X; x <= end.X; ++x)
                {
                    // solve for y
                    var y = (m * x) + b;

                    // round to nearest int
                    var rounded = Convert.ToInt32(Math.Round(y));

                    // convert int result back to float, compare
                    if (Math.Abs(rounded - y) < 1.0f)
                        result.Add(new Display(x, rounded, c));
                }

                return result.ToArray();
            }
            public static Point[] Diagonal(Point start, int length)
            {
                return Diagonal(start, start + new Point(start.X + length, start.Y + length));
            }
        }
        public static Point[] Square(Point start, int length, int width)
        {
            return new Point[] { };
        }
        public static Point[] Sphere(Point start, int length, int width)
        {
            return new Point[] { };
        }
        public static Point[] Polygon(params Point[] points)
        {
            return new Point[] { };
        }
    }
}
