using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LineEngine
{
    public class Graphics
    {
        public Window Window { get; }
        private List<Renderable> Renderables { get; }
        public string Header { get; set; }
        public string Footer { get; set; }

        public Graphics(Window window)
        {
            Window = window;
            Renderables = new List<Renderable>();

            Header = "";
            Footer = "";
        }

        public Renderable GetRenderable(string id)
        {
            var query = from renderable
                        in Renderables
                        where renderable.Id == id
                        select renderable;

            return query.First();
        }

        public Renderable[] GetRenderables(string id)
        {
            var query = from renderable
                        in Renderables
                        where renderable.Id == id
                        select renderable;

            return query.ToArray();
        }

        public void Render(Renderable renderable)
        {
            Renderables.Add(renderable);
        }
        public void Render(Renderable[] renderables)
        {
            Renderables.AddRange(renderables);
        }

        public void Destroy(Renderable renderable)
        {
            Renderables.Remove(renderable);
        }
        public void Destroy(Renderable[] renderables)
        {
            foreach (var renderable in Renderables)
                Destroy(renderable);
        }

        private static void PrintWhitespace()
        {
            var s = new StringBuilder();

            for (var i = 0; i < Console.WindowHeight; i++)
            {
                s.Append("\n");
            }

            Console.WriteLine(s.ToString());
        }

        private void Pack()
        {
            Window.Clear();

            foreach (var display in Renderables.SelectMany(r => r.Sprite.Actual))
            {
                Window.Grid.Place(display.Point, display.Character);
            }
        }

        public void Print()
        {
            Pack();

            PrintWhitespace();

            if (Header != "")
                Console.WriteLine(Header);
            
            var sb = new StringBuilder();

            Window.Grid.ForEachLine((str) => sb.Append(str).Append(Environment.NewLine));

            Console.WriteLine(sb.ToString());
            
            if (Footer != "")
                Console.WriteLine(Footer);
        }
    }
}
