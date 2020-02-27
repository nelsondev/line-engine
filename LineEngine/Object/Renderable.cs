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

        public Animation GetAnimation()
        {
            return ActualAnimation ?? GetDefaultAnimation();
        }
        public Animation GetDefaultAnimation()
        {
            return Animations["default"];
        }
        public Animation SetDefaultAnimation(Animation animation)
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

        // Translation
        public void Translate(int x, int y)
        {
            foreach (var sprite in Animation.Sprites)
            {
                sprite.Translate(y, x);
            }
        }
        public void Translate(Point point)
        {
            foreach (var sprite in Animation.Sprites)
            {
                sprite.Translate(point);
            }
        }
    }
}
