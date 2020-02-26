namespace LineEngine
{
    public class Behavior
    {
        public Game Game { get; set; }
        public bool Threaded { get; set; }
        public string Name { get; set; }

        protected Behavior()
        {
            Game = null;
            Threaded = false;
            Name = "";
        }

        protected Behavior(string name)
        {
            Threaded = true;
            Name = name;
        }

        public virtual void Execute()
        {
        }
    }
}
