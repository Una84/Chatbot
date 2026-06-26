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
                string file = Path.Combine("Assets", "greeting.wav");

                if (File.Exists(file))
                {
                    SoundPlayer player = new SoundPlayer(file);

                    player.Play();
                }
            }
            catch
            {

            }
        }
    }
}
