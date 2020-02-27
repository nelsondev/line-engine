using System.Collections.Generic;
using System.Media;

namespace LineEngine
{
    public interface ISound
    {
        void Play(string name, string path);
        void PlayLooping(string name, string path);
        void Stop(string name);
    }
    
    public struct Sound : ISound
    {
        public Sound(Dictionary<string, SoundPlayer> sounds)
        {
            Sounds = sounds;
        }

        private Dictionary<string, SoundPlayer> Sounds { get; }
        private SoundPlayer Schedule(string name, string path)
        {
            var player = new SoundPlayer(path);
            Sounds.Add(name, player);
            return player;
        }
        public void Play(string name, string path)
        {
            var player = Sounds[name] ?? Schedule(name, path);

            player.Play();
        }
        public void PlayLooping(string name, string path)
        {
            var player = Sounds[name] ?? Schedule(name, path);
            player.PlayLooping();
        }
        public void Stop(string name)
        {
            var player = Sounds[name];

            player?.Stop();
        }
    }
}