using System;
using System.Net;
using MelonLoader;
using VRC.Core;
using System.IO;

namespace JoanpixerClient.Features
{
    internal class VRCA
    {
        public static void DownloadVRCA(ApiAvatar avatar, string image)
        {
			try
			{
				string asset = avatar.assetUrl;
				if (!Directory.Exists($"Joanpixer\\VRCA\\{avatar.name}"))
                {
					Directory.CreateDirectory($"Joanpixer\\VRCA\\{avatar.name}");
				}
				using (WebClient webClient = new WebClient())
				{
					webClient.Headers.Add("User-Agent: Other");
					webClient.DownloadFileAsync(new Uri(asset), $"Joanpixer\\VRCA\\{avatar.name}\\" + avatar.name + ".vrca");
				}
				using (WebClient webClient2 = new WebClient())
				{
					webClient2.Headers.Add("User-Agent: Other");
					webClient2.DownloadFileAsync(new Uri(image), $"Joanpixer\\VRCA\\{avatar.name}\\" + avatar.name + ".png");
				}
			}
			catch (Exception)
			{
				MelonLogger.Msg($"[VRCA] Error Downloading {avatar.name}");
			}
        }
    }
}
