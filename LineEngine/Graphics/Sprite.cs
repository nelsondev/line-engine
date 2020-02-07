using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineEngine
{
    public class Sprite
    {
        public static Point DefaultOrigin = new Point(0, 0);
        public Point Origin { get; set; }
        public Display[] Displays { get; set; }
        public Display[] Actual { 
            get
            {
                return Displays.Select(display => display.Adjusted(Origin)).ToArray();
            }
        }

        public Sprite()
        {
            Origin = DefaultOrigin;
            Displays = new Display[0];
        }
        public Sprite(Point origin)
        {
            Origin = origin;
            Displays = new Display[0];
        }
        public Sprite(Display display)
        {
            Origin = DefaultOrigin;
            Displays = new[] { display };
        }
        public Sprite(Display[] displays)
        {
            Origin = DefaultOrigin;
            Displays = displays;
        }
        public Sprite(Point origin, Display display)
        {
            Origin = origin;
            Displays = new[] { display };
        }
        public Sprite(Point origin, Display[] displays)
        {
            Origin = origin;
            Displays = displays;
        }
        
        // Set
        public void Set(int x, int y)
        {
            foreach (var d in Displays)
            {
                d.Point.Set(x, y);
            }
        }
        public void Set(Point point)
        {
            foreach (Display d in Displays)
            {
                d.Point.Set(point);
            }
        }

        // Translation
        public void Translate(int horizontal, int vertical)
        {
            Origin = Origin.Add(vertical, horizontal);
        }
        public void Translate(Point point)
        {
            Origin += point;
        }

        // Positional
        public bool IsTouching(Point point)
        {
            var result = false;

            foreach (var d in Actual)
            {
                if (d.Point == point)
                    result = true;
            }

            return result;
        }
        public bool IsTouching(int x, int y)
        {
            return IsTouching(new Point(x, y));
        }
        public bool IsTouching(IEnumerable<Point> points)
        {
            var result = false;

            foreach (var point in points)
            {
                result = IsTouching(point);

                if (result)
                    break;
            }

            return result;
        }
        public bool IsTouching(IEnumerable<Display> displays)
        {
            var result = false;

            foreach (var display in displays)
            {
                result = IsTouching(display.Point);

                if (result)
                    break;
            }

            return result;
        }
        public bool IsTouching(Renderable renderable)
        {
            return IsTouching(renderable.Sprite.Actual);
        }

        public bool XIsTouching(int x)
        {
            var result = false;

            foreach (var d in Displays)
            {
                if (x == d.Point.X)
                    result = true;
            }

            return result;
        }
        public bool YIsTouching(int y)
        {
            var result = false;

            foreach (var d in Displays)
            {
                if (y == d.Point.Y)
                    result = true;
            }

            return result;
        }

        public bool IsOffScreen(Window window)
        {
            return Displays.Any(d => d.Point.X >= window.Right 
                                     || d.Point.Y <= Window.Left 
                                     || d.Point.X < 0 
                                     || d.Point.Y < 0);
        }
        
        // Factory
        public static Sprite Text(string text)
        {
            var x = 0;
            var point = new Point(0, 0);
            var displays = new List<Display>();
            
            foreach (var c in text)
            {
                point += point.AddX(x++);
                displays.Add(new Display(point, c));
            }
            
            return new Sprite(displays.ToArray());
        }
    }
}
