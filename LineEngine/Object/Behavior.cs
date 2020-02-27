namespace LineEngine
{
    public class Behavior
    {
        protected Game Game { get; }
        public bool Threaded { get; }
        public string Name { get; }

        protected Behavior(Game game, string name = null)
        {
            Game = game;

            if (name != null)
                Threaded = true;
            else
                Threaded = false;

            Name = name;
        }

        public virtual void Execute()
        {
        }
    }
}
