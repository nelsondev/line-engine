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
        public const int GameSpeed = 1000;

        //Default states
        public const int REFRESH_STATE = 1;
        public const int CONTINUE_STATE = 0;
        public const int EXIT_STATE = -1;

        //Props
        public int State { get; set; }
        public Graphics Graphics { get; }
        public Sound Sound { get; }
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
            State = CONTINUE_STATE;
            Graphics = new Graphics(window);
            Sound = new Sound();
            Behaviors = new List<Behavior>();
            Tasks = new Dictionary<string, Task>();
        }

        /// <summary>
        /// Add a behavior to the event stack.
        /// </summary>
        /// <param name="b">
        /// Behavior or child of. To be registered in stack.
        /// </param>
        public void Register(Behavior b)
        {
            Behaviors.Add(b);
        }
        /// <summary>
        /// Add a list behavior to the event stack.
        /// </summary>
        /// <param name="b">
        /// List of behaviors or children of. To be registered in stack.
        /// </param>
        public void Register(IEnumerable<Behavior> b)
        {
            Behaviors.AddRange(b);
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
            var query = from behavior
                        in Behaviors
                        where behavior.Threaded
                        select behavior;

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
                State = CONTINUE_STATE;
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
            int count = 0;

            do
            {
                StartThreadedEvents();

                foreach (var b in Behaviors)
                {
                    b.Execute();
                }

                if (State == REFRESH_STATE)
                    ScheduleRenderer();

                if (count >= 2048)
                {
                    Console.Clear();
                    Refresh();
                    count = 0;
                }

                count++;

                Thread.Sleep(GameSpeed);
            } while (State != EXIT_STATE);
        }

        public void Stop()
        {
            State = EXIT_STATE;
        }

        public void Refresh()
        {
            State = REFRESH_STATE;
        }

        public void Continue()
        {
            if (State != REFRESH_STATE)
                State = CONTINUE_STATE;
        }

        public Renderable GetObject(string id) =>
            Graphics.GetRenderable(id);
        public IEnumerable<Renderable> GetObjects(string id) =>
            Graphics.GetRenderables(id);
        public Renderable GetRenderable(string id) =>
            Graphics.GetRenderable(id);
        public Renderable[] GetRenderables(string id) =>
            Graphics.GetRenderables(id);
        public void Render(Renderable renderable) =>
            Graphics.Render(renderable);
        public void Render(Renderable[] list) =>
            Graphics.Render(list);
    }
}
