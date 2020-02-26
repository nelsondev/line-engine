using System.Collections.Generic;

namespace LineEngine
{
    public class Renderable
    {
        public string Id { get; }
        private Animation ActualAnimation { get; set; }
        public Animation Animation => GetAnimation();
        private Dictionary<string, Animation> Animations { get; set; }
        public Sprite Sprite => ActualAnimation == null ? null : Animation.Sprite;

        protected Renderable()
        {
            Id = null;
            ActualAnimation = null;
            Animations = new Dictionary<string, Animation>();
        }
        
        protected Renderable(string id)
        {
            Id = id;
            ActualAnimation = null;
            Animations = new Dictionary<string, Animation>();
        }

        protected Animation GetAnimation()
        {
            return ActualAnimation ?? GetDefaultAnimation();
        }

        protected Animation GetDefaultAnimation()
        {
            return Animations["default"];
        }

        protected void SetDefaultAnimation(Animation animation)
        {
            Animations.Add("default", animation);
            ActualAnimation = Animations["default"];
        }

        public Renderable Start(Game game)
        {
            GetAnimation().Start(game);
            return this;
        }

        // Translation
        // ReSharper disable once UnusedMember.Global
        public void Translate(int x, int y)
        {
            foreach (var sprite in Animation.Sprites)
            {
                sprite.Translate(x, y);
            }
        }
        // ReSharper disable once UnusedMember.Global
        public void Translate(Point point)
        {
            foreach (var sprite in Animation.Sprites)
            {
                sprite.Translate(point);
            }
        }
    }
}
