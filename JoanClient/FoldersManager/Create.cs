using System;
using MelonLoader;
using System.IO;
using System.Net;
using LoadSprite;
using Newtonsoft.Json;
using JoanpixerClient.Api.Object;
using System.Collections.Generic;

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
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                client.DownloadFile(new Uri("https://joanpixertest.glitch.me/SDK/MainMenu.png"), "Joanpixer\\MainMenu.png");
            }

            if (!File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\Background.png"))
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                MelonLogger.Msg("Downloading Background.png");
                client.DownloadFile(new Uri("https://joanpixertest.glitch.me/SDK/ButtonBackground.png"), "Joanpixer\\Background.png");
            }
            JoanpixerMain.Background = (Environment.CurrentDirectory + "\\Joanpixer\\Background.png").LoadSpriteFromDisk();
            if (!File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\doorsoff.png"))
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                MelonLogger.Msg("Downloading doorsoff.png");
                client.DownloadFile(new Uri("https://joanpixertest.glitch.me/SDK/doorsoff.png"), "Joanpixer\\doorsoff.png");
            }

            if (!File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\god.png"))
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                MelonLogger.Msg("Downloading god.png");
                client.DownloadFile(new Uri("https://joanpixertest.glitch.me/SDK/god.png"), "Joanpixer\\god.png");
            }

            if (!File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\killself.png"))
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                MelonLogger.Msg("Downloading killself.png");
                client.DownloadFile(new Uri("https://joanpixertest.glitch.me/SDK/killself.png"), "Joanpixer\\killself.png");
            }

            if (!File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\Protections Icon.png"))
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                MelonLogger.Msg("Downloading Protections Icon.png");
                client.DownloadFile(new Uri("https://joanpixertest.glitch.me/SDK/Protections%20Icon.png"), "Joanpixer\\Protections Icon.png");
            }

            if (!File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\knife.png"))
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                MelonLogger.Msg("Downloading knife.png");
                client.DownloadFile(new Uri("https://joanpixertest.glitch.me/SDK/knife.png"), "Joanpixer\\knife.png");
            }

            if (!File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\pickup.png"))
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                MelonLogger.Msg("Downloading pickup.png");
                client.DownloadFile(new Uri("https://joanpixertest.glitch.me/SDK/pickup.png"), "Joanpixer\\pickup.png");
            }

            if (!File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\playerlist.png"))
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                MelonLogger.Msg("Downloading playerlist.png");
                client.DownloadFile(new Uri("https://joanpixertest.glitch.me/SDK/playerlist.png"), "Joanpixer\\playerlist.png");
            }

            if (!File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\unlock.png"))
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                MelonLogger.Msg("Downloading unlock.png");
                client.DownloadFile(new Uri("https://joanpixertest.glitch.me/SDK/unlock.png"), "Joanpixer\\unlock.png");
            }

            if (!File.Exists(Environment.CurrentDirectory + "\\Joanpixer\\sound.wav"))
            {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                MelonLogger.Msg("Downloading sound.wav");
                client.DownloadFile(new Uri("https://joanpixertest.glitch.me/SDK/sound.wav"), "Joanpixer\\sound.wav");
            }

            if (!File.Exists("Joanpixer\\Config.ini"))
            {
                File.Create("Joanpixer\\Config.ini");
                Ini = new IniFile("Joanpixer\\Config.ini");
                Ini.SetBool("Toggles", "QuestSpoof", false);
                Ini.SetBool("Toggles", "AntiBlock", false);
            }
            else
            {
                Ini = new IniFile("Joanpixer\\Config.ini");
            }
            if (!File.Exists("Joanpixer\\AvatarFavorites.json"))
            {
                string contents = JsonConvert.SerializeObject(new List<AvatarObject>(), Formatting.Indented);
                File.WriteAllText("Joanpixer\\AvatarFavorites.json", contents);
            }
        }
    }
}