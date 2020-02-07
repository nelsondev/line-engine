namespace LineEngine
{
    public struct Window
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Bottom => Height - 1;
        public static int Top => 0;
        public static int Left => 0;
        public int Right => Width - 1;
        public Point Middle => new Point(Right / 2, Bottom / 2);
        public Point TopMiddle => new Point(Right / 2, Top);
        public Point BottomMiddle => new Point(Right / 2, Bottom);
        public Point BottomLeft => new Point(Left, Bottom);
        public Point BottomRight => new Point(Right, Bottom);
        public Point TopLeft => new Point(Left, Top);
        public Point TopRight => new Point(Right, Top);
        public Point LeftMiddle => new Point(Left, Bottom / 2);
        public Point RightMiddle => new Point(Right, Bottom / 2);
        public Grid Grid { get; }

        public Window(int width, int height)
        {
            Width = width;
            Height = height;

            Grid = new Grid(width, height);
        }

        public void Clear()
        {
            Grid.Clear();
        }
    }
}
