namespace LineEngine.Test
{
    internal class Player : Renderable
    {
        public Player() : base("player")
        {

            var defaultSprite = new Sprite()
            {
                Origin = new Point(0, 0),
                Displays = new[]
                {
                    // # characters 
                    new Display(0, 0, '#'),
                    new Display(0, 1, '#'),
                    new Display(1, 1, '#'),
                    new Display(2, 1, '#'),
                    new Display(3, 1, '#'),
                    new Display(4, 1, '#'),
                    new Display(0, 2, '#'),

                    // = characters 
                    new Display(1, 0, '='),
                    new Display(2, 0, '='),
                    new Display(1, 2, '='),
                    new Display(2, 2, '=')
                }
            };

            var flyingSprite = new Sprite()
            {
                Origin = new Point(0, 0),
                Displays = new[]
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
                    new Display(1, 2, '#'),

                    // = characters 
                    new Display(2, 0, '='),
                    new Display(3, 0, '='),
                    new Display(2, 2, '='),
                    new Display(3, 2, '=')
                }
            };

            // Create sprite list for default animation
            var defaultSprites = new[]
            {
                defaultSprite,
                flyingSprite
            };

            // Create default animation
            var defaultAnimation = new Animation(defaultSprites, 1000);

            // Initialize new animation with frame time of 500ms
            SetDefaultAnimation(defaultAnimation);
        }
    }
}