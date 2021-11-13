using System;
using MelonLoader;
using System.IO;
using System.Net;
using LoadSprite;

namespace JoanpixerClient.FoldersManager
{
    class Create
    {
        public static IniFile Ini;

        private static WebClient client = new WebClient();

        public static void Initialize()
        {
            if (!Directory.Exists("Joanpixer"))
            {
                Directory.CreateDirectory("Joanpixer");
            }
            if (!File.Exists("Joanpixer\\MainMenu.png"))
            {
                client.DownloadFile(new Uri("https://i.imgur.com/35gOq2v.png"), "Joanpixer\\MainMenu.png");
            }
            if (!File.Exists("Joanpixer\\VRConsole.png"))
            {
                client.DownloadFile(new Uri("https://i.imgur.com/DlWsdFh.png"), "Joanpixer\\VRConsole.png");
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\ButtonBackground.png"))
            {
                MelonLogger.Msg("Downloading ButtonBackground.png");
                client.DownloadFile(new Uri("https://i.imgur.com/2oDXFrz.png"), "Joanpixer\\ButtonBackground.png");
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\Protections Icon.png"))
            {
                MelonLogger.Msg("Downloading Protections Icon.png");
                client.DownloadFile(new Uri("https://i.imgur.com/PTvpxmx.png"), "Joanpixer\\Protections Icon.png");
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\sound.wav"))
            {
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