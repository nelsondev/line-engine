using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LineEngine
{
    /// <summary>
    /// 
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Time in milliseconds for max game refresh time
        /// </summary>
        public const int GameSpeed = 60;

        //Default states
        public const int RefreshState = 1;
        public const int ContinueState = 0;
        public const int ExitState = -1;

        //Props
        public int State { get; set; }
        public Graphics Graphics { get; }
        public ISound Sound { get; }
        private List<Behavior> Behaviors { get; }
        private Dictionary<string, Task> Tasks { get; }
        private Task Renderer { get; set; }

        /// <summary>
        /// Create a standard game instance.
        /// </summary>
        /// <param name="window">
        /// Window object. The size of the grid you want your game to be at.
        /// </param>
        public Game(Window window)
        {
            State = ContinueState;
            Graphics = new Graphics(window);
            Sound = new Sound();
            Behaviors = new List<Behavior>();
            Tasks = new Dictionary<string, Task>();
        }

        /// <summary>
        /// Add a behavior to the event stack.
        /// </summary>
        public void Do<T>() where T : Behavior, new()
        {
            Behaviors.Add(new T() { Game = this });
        }

        /* Start Threaded Events
         * This function selects all game events in the event stack defined to be threaded. If a game event is threaded,
         * it is then sent to a new thread to be executed on It's own.
         * 
         * Threaded events are removed so they dont get rescheduled / re-ran on the main game loop.
         * 
         * @no parameters
         * @return void
         */
        /// <summary>
        /// Schedule all to be threaded behaviors, and reschedule if they need refreshing.
        /// </summary>
        private void StartThreadedEvents()
        {
            // Grab all threaded game events
            var query = Behaviors.Where(b => b.Threaded);

            query.ToList().ForEach((b) =>
            {
                var task = new Task(b.Execute, TaskCreationOptions.LongRunning);
                // Start respective threads for each threaded game event.
                task.Start();
                // Add thread by name to the threads dictionary.
                Tasks.Add(b.Name, task);
                // Remove from event stack so no more threads are started
                Behaviors.Remove(b);
            });
        }

        /// <summary>
        /// Schedule a new task for the renderer process to reduce load off the main game
        /// loop. Less flicker can be seen.
        /// </summary>
        private void ScheduleRenderer()
        {
            // if renderer is completed, dispose of the thread
            if (Renderer != null && Renderer.IsCompleted)
                Renderer.Dispose();

            // create a new task to render the next frame. Then set
            // game state to continue.
            Renderer = new Task(() =>
            {
                Graphics.Print();
                Continue();
            });

            // Start renderer thread
            Renderer.Start();
        }

        /* Start
         * MAIN GAME START METHOD.
         * This function handles the main game loop as well as starts threaded events.
         * 
         * The main game loop loops though all game events stored in the event stack,
         * then calls their Execute method. The thread is then slept for 33ms to
         * simulate a "30fps."
         */
        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            var count = 0;

            do
            {
                StartThreadedEvents();

                foreach (var b in Behaviors)
                {
                    b.Execute();
                }

                if (State == RefreshState)
                    ScheduleRenderer();

                if (count >= 2048)
                {
                    Console.Clear();
                    Refresh();
                    count = 0;
                }

                count++;

                Thread.Sleep(GameSpeed);
            } while (State != ExitState);
        }

        public void Stop()
        {
            State = ExitState;
        }

        public void Refresh()
        {
            State = RefreshState;
        }

        public void Continue()
        {
            if (State != RefreshState)
                State = ContinueState;
        }

        public Renderable GetObject(string id) =>
            Graphics.GetRenderable(id);
        public IEnumerable<Renderable> GetObjects(string id) =>
            Graphics.GetRenderables(id);

        public void Draw<T>() where T : Renderable, new()
        {
            Graphics.Render(new T().Start(this));
        }
    }
}
