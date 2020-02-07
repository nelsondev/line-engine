namespace LineEngine
{
    public class Behavior
    {
        protected Game Game { get; }
        public bool Threaded { get; }
        public string Name { get; }

        protected Behavior(Game game)
        {
            Game = game;
            Threaded = false;
            Name = "";
        }

        public virtual void Execute()
        {
        }
    }
}
