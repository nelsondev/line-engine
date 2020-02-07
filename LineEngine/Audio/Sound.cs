using System.Collections.Generic;

namespace LineEngine
{
    public struct Sound
    {
        private Dictionary<string, System.Media.SoundPlayer> Sounds { get; set; }

        public System.Media.SoundPlayer Schedule(string name, string path)
        {
            var player = new System.Media.SoundPlayer(path);
            Sounds.Add(name, player);
            return player;
        }
        public void Play(string name, string path)
        {
            var player = Sounds[name];

            if (player == null)
                player = Schedule(name, path);

            player.Play();
        }
        public void PlayLooping(string name, string path)
        {
            var player = Sounds[name];

            if (player == null)
                player = Schedule(name, path);

            player.PlayLooping();
        }
        public void Stop(string name)
        {
            var player = Sounds[name];

            if (player == null)
                return;

            player.Stop();
        }
    }
}