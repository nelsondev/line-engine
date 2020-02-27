using System.Collections.Generic;
using System.Linq;

namespace LineEngine
{
    public interface IAnimated
    {
        Animation Animation { get; }
        Dictionary<string, Animation> Animations { get; }
        Sprite Sprite { get; }

        Animation GetAnimation();
        Animation GetDefaultAnimation();
        Animation SetDefaultAnimation(Animation animation);
        Animation SetAnimation(string name);
    }

    public interface ITranslatable
    {
        void Translate(int x, int y);
        void Translate(Point point);
        
        // : planned
        // void Rotate();
        // void Scale();
    }

    public interface IPositional
    {
        bool IsTouching();
        bool XIsTouching();
        bool YIsTouching();
        bool IsOffScreen();
    }

    public class Renderable
    {
        public string Id { get; }
        private Animation ActualAnimation { get; set; }
        public Animation Animation => GetAnimation();
        public Dictionary<string, Animation> Animations { get; }
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
            return ActualAnimation;
        }
        public Animation SetAnimation(string name)
        {
            var oldOrigin = Animation.Sprite.Origin;
            var animation = Animations[name];

            if (animation == null)
                return GetDefaultAnimation();

            animation.Sprites.ToList().ForEach(s => s.Origin = oldOrigin);

            return ActualAnimation = animation;
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
                sprite.Translate(y, x);
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
