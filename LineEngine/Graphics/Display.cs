namespace LineEngine
{
    public interface IDisplay
    {
        Point Point { get; set; }
        char Character { get; set; }
        Display Adjusted(Point origin);
    }
    public struct Display : IDisplay
    {
        public Point Point { get; set; }
        public char Character { get; set; }
        
        public Display(Point point)
        {
            Point = point;
            Character = ' ';
        }
        public Display(int x, int y, char display)
        {
            Point = new Point(x, y);
            Character = display;
        }
        public Display(char display)
        {
            Point = new Point(0, 0);
            Character = display;
        }
        public Display(Point point, char display)
        {
            Point = point;
            Character = display;
        }
        public Display(char display, Point point)
        {
            Point = point;
            Character = display;
        }

        public Display Adjusted(Point origin)
        {
            return new Display
            {
                Point = Point + origin,
                Character = Character
            };
        }
    }
}
