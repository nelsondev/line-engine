using System;
using System.Collections.Generic;
using System.Text;

namespace LineEngine
{
    public struct Grid
    {
        private int Width { get; set; }
        private int Height { get; set; }
        private char[,] List { get; }

        public Grid(int width, int height)
        {
            Width = width;
            Height = height;

            List = new char[height, width];
        }

        public void Place(Point point, char c)
        {
            if (point.X >= 0 && point.Y >= 0 && point.X < Width && point.Y < Height)
                List[point.Y, point.X] = c;
        }

        public void Place(IEnumerable<Point> points, char c)
        {
            foreach (var point in points)
                Place(point, c);
        }

        public void Clear(char c = ' ')
        {
            var self = this;

            ForEach((i, j) =>
            {
                self.List[i, j] = c;
            });
        }

        private void ForEach(Action<int, int> call)
        {
            for (var i = 0; i < List.GetLength(0); i++)
            {
                for (var j = 0; j < List.GetLength(1); j++)
                {
                    call(i, j);
                }
            }
        }

        public void ForEach(Action<char> call)
        {
            for (var i = 0; i < List.GetLength(0); i++)
            {
                for (var j = 0; j < List.GetLength(1); j++)
                {
                    call(List[i, j]);
                }
            }
        }

        public void ForEachLine(Action<string> call)
        {
            for (var i = 0; i < List.GetLength(0); i++)
            {
                var sb = new StringBuilder();
                for (var j = 0; j < List.GetLength(1); j++)
                {
                    sb.Append(List[i, j]);
                }
                call(sb.ToString());
            }
        }
    }
}
