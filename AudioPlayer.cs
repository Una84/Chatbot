using System;
using System.Media;
using System.IO;

public static class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            // Skip audio in CI environment
            if (Environment.OSVersion.Platform == PlatformID.Unix)
                return;

            string path = Path.Combine("Assets", "greeting.wav");

            if (File.Exists(path))
            {
                SoundPlayer player = new SoundPlayer(path);
                player.PlaySync();
            }
        }
        catch
        {
            Console.WriteLine("Audio failed.");
        }
    }
}
