using System;

namespace LineEngine
{
    public class Behavior
    {
        public Game Game { get; set; }
        public bool Threaded { get; protected set; }
        public string Name { get; }

        protected Behavior()
        {
            Threaded = false;
            Name = GetType().Name;
        }

        protected void Input(Action<char> call)
        {
            while (Game.State != Game.ExitState)
            {
                call(Console.ReadKey().KeyChar);
            }
        }

        public virtual void Execute()
        {
            Game.Continue();
        }
    }
}
