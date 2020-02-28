using System.Threading;
using System.Threading.Tasks;

namespace LineEngine
{
    public class Animation
    {
        public string Name { get; set; }
        public Sprite[] Sprites { get; set; }
        public int Frame { get; set; }
        public int Speed { get; set; }
        public bool IsAnimated { get; set; }
        private Task Task { get; set; }
        public Sprite Sprite => Sprites[Frame];

        public Animation()
        {
            Name = null;
            Sprites = null;
            Frame = 0;
            Speed = 0;
            IsAnimated = false;
            Task = null;
        }

        public Animation(string name)
        {
            Name = name;
            Sprites = null;
            Frame = 0;
            Speed = 0;
            IsAnimated = false;
            Task = null;
        }
        public Animation(Sprite[] sprites, int speed)
        {
            Name = null;
            Sprites = sprites;
            Frame = 0;
            Speed = speed;
            IsAnimated = false;
            Task = null;
        }
        public Animation(Sprite sprite, int speed)
        {
            Sprites = new[] { sprite };
            Frame = 0;
            Speed = speed;
            IsAnimated = false;
            Task = null;
        }

        public Animation(Sprite sprite)
        {
            Sprites = new[] { sprite };
            Frame = 0;
            Speed = 0;
            IsAnimated = false;
            Task = null;
        }
        public Animation(int speed)
        {
            Sprites = new Sprite[0];
            Frame = 0;
            Speed = speed;
            IsAnimated = false;
            Task = null;
        }

        // Doesn't refresh on frame
        public Animation Start()
        {
            var self = this;

            if (Task != null)
                return this;

            Task = new Task(() =>
            {
                IsAnimated = true;

                do
                {
                    // shift sprite
                    self.Next();

                    // sleep for frame time
                    Thread.Sleep(self.Speed);
                } while (self.IsAnimated);
            });

            Task.Start();

            return this;
        }
        // Refreshes on frame
        public void Start(Game game)
        {
            var self = this;

            if (Speed == 0) return;
            if (Task != null) return;

            Task = new Task(() =>
            {
                IsAnimated = true;
                do
                {
                    self.Next();
                    game.Refresh();

                    // sleep for frame time
                    Thread.Sleep(self.Speed);
                } while (self.IsAnimated);
            });

            Task.Start();
        }
        public void Stop()
        {
            // If task isn't scheduled, or isn't animated then return
            if (Task == null)
                return;

            if (!IsAnimated)
                return;

            // Attempt to close the animation loop
            IsAnimated = false;

            // If the task isn't completed return
            if (!Task.IsCompleted)
                return;

            // Dispose of task
            Task.Dispose();
            Task = null;
        }
        public void Restart()
        {
            Frame = 0;
        }
        public void Next()
        {
            Frame = Frame != Sprites.Length - 1 ? Frame + 1 : 0;
        }
        public void Previous()
        {
            Frame = Frame != 0 ? Sprites.Length - 1 : Frame - 1;
        }
        public void Beginning()
        {
            Frame = 0;
        }
        public void End()
        {
            Frame = Sprites.Length - 1;
        }
    }
}
