using System;
using System.Threading;
using LineEngine;

namespace CommandWing
{
    internal class KeyboardMovement : Behavior
    {
        public KeyboardMovement()
        {
            Threaded = true;
        }

        public override void Execute()
        {
            Input(key =>
            {
                var ship = Game.GetObject("ship");
                
                switch (key)
                {
                    case 'w':
                        ship.Translate(0, 1);
                        break;
                    case 'a':
                        ship.Translate(-1, 0);
                        break;
                    case 's':
                        ship.Translate(0, -1);
                        break;
                    case 'd':
                        ship.Translate(1, 0);
                        break;
                    case ' ':
                        var bullet = Game.Draw<Bullet>();
                        bullet.Translate(ship.Sprite.Origin);
                        break;
                    case 'x':
                        Game.Stop();
                        break;
                }
            });
        }
    }

    internal class BulletPhysics : Behavior
    {
        private const int BulletSpeed = 50;
        public BulletPhysics()
        {
            Threaded = true;
        }
        public override void Execute()
        {
            while (Game.State != Game.ExitState)
            {
                var bullets = Game.GetObjects("bullet");

                foreach (var bullet in bullets)
                {
                    if (bullet.Sprite.IsOnScreen(Game.Graphics.Window))
                        bullet.Translate(1, 0);
                    else
                        Game.Graphics.Destroy(bullet);
                }
                
                Thread.Sleep(BulletSpeed);
            }
        }
    }
    
    internal class Ship : Renderable
    {
        public Ship() : base("ship")
        {
            var sprite00 = new Sprite() 
            {
                Origin = new Point(0, 0),
                Displays = new
                    [] 
                {
                    // > characters 
                    new Display(0, 0, '>'),
                    new Display(0, 2, '>'),

                    // # characters 
                    new Display(1, 0, '#'),
                    new Display(1, 1, '#'),
                    new Display(2, 1, '#'),
                    new Display(3, 1, '#'),
                    new Display(4, 1, '#'),
                    new Display(5, 1, '#'),
                    new Display(6, 1, '#'),
                    new Display(1, 2, '#'),

                    // - characters 
                    new Display(2, 0, '-'),
                    new Display(3, 0, '-'),
                    new Display(2, 2, '-'),
                    new Display(3, 2, '-'),

                }
            };
            
            var sprite01 = new Sprite() 
            {
                Origin = new Point(0, 0),
                Displays = new Display[] 
                {
                    // * characters 
                    new Display(0, 0, '*'),
                    new Display(0, 2, '*'),

                    // # characters 
                    new Display(1, 0, '#'),
                    new Display(1, 1, '#'),
                    new Display(2, 1, '#'),
                    new Display(3, 1, '#'),
                    new Display(4, 1, '#'),
                    new Display(5, 1, '#'),
                    new Display(6, 1, '#'),
                    new Display(1, 2, '#'),

                    // - characters 
                    new Display(2, 0, '-'),
                    new Display(3, 0, '-'),
                    new Display(2, 2, '-'),
                    new Display(3, 2, '-'),

                }
            };
            
            var animation = new Animation(new [] { sprite00, sprite01 }, 50);
            SetDefaultAnimation(animation);
        }
    }

    internal class Bullet : Renderable
    {
        public Bullet() : base("bullet")
        {
            var animation = new Animation(new Sprite() 
            {
                Origin = new Point(4, 0),
                Displays = new[] 
                {
                    // . characters 
                    new Display(0, 0, '.'),
                    new Display(0, 2, '.'),

                }
            }, 0);
            SetDefaultAnimation(animation);
        }
    }

    internal class Meteor : Renderable
    {
        public Meteor() : base("Meteor")
        {
            var animation = new Animation(new Sprite() 
            {
                Origin = new Point(0, 0),
                Displays = new[] 
                {
                    // # characters 
                    new Display(0, 0, '#'),
                    new Display(1, 0, '#'),
                    new Display(0, 1, '#'),
                    new Display(1, 1, '#')
                }
            }, 0);
            SetDefaultAnimation(animation);
        }
    }
   
    internal static class Program
    {
        private static void Main()
        {
            var window = new Window(21, 11);
            var game = new Game(window);

            game.Do<KeyboardMovement>();
            game.Do<BulletPhysics>();
            
            game.Draw<Ship>();
            game.Draw<Meteor>();
            
            game.Start();
        }
    }
}