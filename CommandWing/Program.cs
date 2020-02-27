using System;
using LineEngine;

namespace CommandWing
{
    internal class KeyboardMovement : Behavior
    {
        public KeyboardMovement()
        {
            Threaded = true;
        }

        private void KeyPressed(char key)
        {
            if (key == 'x')
                Game.Stop();
        }
        
        public override void Execute()
        {
            Input(KeyPressed);
        }
    }

    internal class Ship : Renderable
    {
        public Ship() : base("Ship")
        {
            var sprite00 = new Sprite() 
            {
                Origin = new Point(0, 0),
                Displays = new[] 
                {
                    // > characters 
                    new Display(0, 0, '>'),
                    new Display(0, 2, '>'),

                    // # characters 
                    new Display(1, 0, '#'),
                    // new Display(0, 1, '#'),
                    new Display(1, 1, '#'),
                    new Display(2, 1, '#'),
                    new Display(3, 1, '#'),
                    new Display(4, 1, '#'),
                    new Display(5, 1, '#'),
                    new Display(1, 2, '#'),

                    // = characters 
                    new Display(2, 0, '='),
                    new Display(3, 0, '='),
                    new Display(2, 2, '='),
                    new Display(3, 2, '='),

                }
            };
            
            var sprite01 = new Sprite() 
            {
                Origin = new Point(0, 0),
                Displays = new[] 
                {
                    // * characters 
                    new Display(0, 0, '*'),
                    new Display(0, 2, '*'),

                    // # characters 
                    new Display(1, 0, '#'),
                    // new Display(0, 1, '#'),
                    new Display(1, 1, '#'),
                    new Display(2, 1, '#'),
                    new Display(3, 1, '#'),
                    new Display(4, 1, '#'),
                    new Display(5, 1, '#'),
                    new Display(1, 2, '#'),

                    // = characters 
                    new Display(2, 0, '='),
                    new Display(3, 0, '='),
                    new Display(2, 2, '='),
                    new Display(3, 2, '='),

                }
            };
            
            var animation = new Animation(new [] { sprite00, sprite01 }, 500);
            SetDefaultAnimation(animation);
        }
    }
    internal class Square : Renderable
    {
        public Square() : base("Square")
        {
            var sprite = new Sprite() 
            {
                Origin = new Point(4, 5),
                Displays = new[] 
                {
                    // ( characters 
                    new Display(0, 0, '('),
                    new Display(0, 1, '('),

                    // ) characters 
                    new Display(3, 0, ')'),
                    new Display(3, 1, ')')
                }
            };
            
            SetDefaultAnimation(new Animation(sprite, 0));
        }
    }

    internal static class Program
    {
        private static void Main()
        {
            var window = new Window(21, 11);
            var game = new Game(window);

            game.Do<KeyboardMovement>();
            
            game.Draw<Ship>();
            game.Draw<Square>();
            
            game.Start();
        }
    }
}