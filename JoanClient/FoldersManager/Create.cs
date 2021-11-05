using System;
using MelonLoader;
using System.IO;
using LoadSprite;

namespace JoanpixerClient.FoldersManager
{
    class Create
    {
        public static IniFile Ini;

        public static void Initialize()
        {
            if (!Directory.Exists("Joanpixer"))
            {
                Directory.CreateDirectory("Joanpixer");
            }
            if (!File.Exists("Joanpixer\\MainMenu.png"))
            {
                var client = new System.Net.WebClient();
                client.DownloadFile(new Uri("https://i.imgur.com/35gOq2v.png"), "Joanpixer\\MainMenu.png");
            }
            if (!File.Exists("Joanpixer\\VRConsole.png"))
            {
                var client = new System.Net.WebClient();
                client.DownloadFile(new Uri("https://i.imgur.com/DlWsdFh.png"), "Joanpixer\\VRConsole.png");
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\ButtonBackground.png"))
            {
                var client = new System.Net.WebClient();
                MelonLogger.Msg("Downloading ButtonBackground.png");
                client.DownloadFile(new Uri("https://i.imgur.com/2oDXFrz.png"), "Joanpixer\\ButtonBackground.png");
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\sound.wav"))
            {
                var client = new System.Net.WebClient();
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                MelonLogger.Msg("Downloading sound.wav");
                client.DownloadFile(new Uri("https://joanpixertest.glitch.me/SDK/sound.wav"), "Joanpixer\\sound.wav");
            }
            if (File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\ButtonBackground.png"))
            {
                JoanpixerMain.Background = (Environment.CurrentDirectory + "\\Joanpixer\\ButtonBackground.png").LoadSpriteFromDisk();
            }
            if (!File.Exists("Joanpixer\\Config.ini"))
            {
                File.Create("Joanpixer\\Config.ini");
                Ini = new IniFile("Joanpixer\\Config.ini");
                Ini.SetBool("Toggles", "QuestSpoof", false);
            }
            else
            {
                Ini = new IniFile("Joanpixer\\Config.ini");
            }
        }
    }
}