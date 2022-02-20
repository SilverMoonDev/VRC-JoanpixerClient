using System;
using System.Net;
using MelonLoader;
using VRC.Core;

namespace JoanpixerClient.Features
{
    internal class VRCA
    {
        public static void DownloadVRCA(ApiAvatar avatar)
        {
			try
			{
				string assetUrl = avatar.assetUrl;
				string imageUrl = avatar.imageUrl;
				using (WebClient webClient = new WebClient())
				{
					webClient.DownloadFileAsync(new Uri(assetUrl), "Joanpixer\\VRCA\\" + avatar.name + ".vrca");
				}
				using (WebClient webClient2 = new WebClient())
				{
					webClient2.DownloadFileAsync(new Uri(imageUrl), "Joanpixer\\VRCA\\" + avatar.name + ".png");
				}
				MelonLogger.Msg("[VRCA] Downloaded " + avatar.name);
			}
			catch (Exception)
			{
				MelonLogger.Msg("[VRCA]Download Error");
			}
        }
    }
}
