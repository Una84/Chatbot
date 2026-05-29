using System.IO;
using System.Media;

namespace CybersecurityAwarenessBot
{
    public static class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                string path = Path.Combine("Assets", "greeting.wav");

                if (File.Exists(path))
                {
                    SoundPlayer player = new SoundPlayer(path);
                    player.Play();
                }
            }
            catch
            {

            }
        }
    }
}
