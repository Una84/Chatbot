using System.Media;
using System.IO;

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
                player.PlaySync();
            }
        }
        catch
        {
            Console.WriteLine("⚠️ Audio could not be played.");
        }
    }
}