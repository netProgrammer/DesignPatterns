using System;
using System.Media;

namespace Adapter
{
    class Program
    {
        static void Main()
        {
            IAudioPlayer player = new SoundPlayerAdapter();

            string wavFile = string.Empty;

            if (!string.IsNullOrEmpty(wavFile))
            {
                player.Load(wavFile);
                player.Play();
            }
        }
    }

    public interface IAudioPlayer
    {
        void Load(string file);

        void Play();
    }

    public class SoundPlayerAdapter : IAudioPlayer
    {
        readonly Lazy<SoundPlayer> _lazyPlayer = new Lazy<SoundPlayer>();

        public void Load(string file)
        {
            _lazyPlayer.Value.SoundLocation = file;
            _lazyPlayer.Value.Load();
        }

        public void Play()
        {
            _lazyPlayer.Value.Play();
        }
    }
}
