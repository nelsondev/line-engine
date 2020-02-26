namespace LineEngine.Test
{
    internal class Line : Renderable
    {
        public Line() : base("line")
        {
            var sprite = new Sprite(Draw.Line.Diagonal(new Point(2, 2), new Point(4, 6), '$'));
            
            SetDefaultAnimation(new Animation(sprite, 0));
        }
    }
    
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var game = new Game(new Window(21, 11));

            game.Render<Player>();
            game.Render<Line>();
            game.Refresh();
            game.Start();
            game.Refresh();
        }
    }
}
