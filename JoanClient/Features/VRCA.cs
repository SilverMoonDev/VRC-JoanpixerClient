using System;
using System.Net;
using MelonLoader;
using VRC.Core;
using System.IO;
using ForbiddenClient;
using System.Threading;
using VRC;

namespace ForbiddenClient.Features
{
    internal static class VRCA
    {
		public static void DownloadAvatar(this Player player, string image = null)
        {
			var avatar = player.prop_ApiAvatar_0;
				new Thread(() =>
                {
					try
					{
						Utils.Notification($"[VRCA] Downloading {avatar.name}", UnityEngine.Color.blue);
						ForbiddenClient.Utils.ConsoleLog(Utils.ConsoleLogType.Msg, $"[VRCA] Downloading {avatar.name}", ConsoleColor.Blue);
						if (!Directory.Exists($"Forbidden\\VRCA\\{avatar.name}"))
						{
							Directory.CreateDirectory($"Forbidden\\VRCA\\{avatar.name}");
						}
						Int64 FileSize;
						using (WebClient webClient = new WebClient())
						{
							webClient.Headers.Add("User-Agent: Other");
							webClient.DownloadFile(new Uri(avatar.assetUrl), $"Forbidden\\VRCA\\{avatar.name}\\" + avatar.name + ".vrca");
							FileSize = Convert.ToInt64(webClient.ResponseHeaders["Content-Length"]) / 1024 / 1024;
						}
						if (!string.IsNullOrEmpty(image))
						{
							using (WebClient webClient2 = new WebClient())
							{
								webClient2.Headers.Add("User-Agent: Other");
								webClient2.DownloadFile(new Uri(image), $"Forbidden\\VRCA\\{avatar.name}\\" + avatar.name + ".png");
							}
						}
						Utils.Notification($"[VRCA] Finished Downloading {avatar.name}: " + FileSize + "MB", UnityEngine.Color.green);
						Utils.ConsoleLog(Utils.ConsoleLogType.Msg, $"[VRCA] Finished Downloading {avatar.name}: " + FileSize + "MB", ConsoleColor.Green);
					}
					catch (Exception)
					{
						Utils.Notification($"[VRCA] Error Downloading {avatar.name}", UnityEngine.Color.red);
						Utils.ConsoleLog(Utils.ConsoleLogType.Msg, $"[VRCA] Error Downloading {avatar.name}", ConsoleColor.Red);
					}
				}).Start();
			}

		public static void DownloadVRCA(this ApiAvatar avatar, string image = null)
		{
			new Thread(() =>
			{
				try
				{
					Utils.Notification($"[VRCA] Downloading {avatar.name}", UnityEngine.Color.blue);
					ForbiddenClient.Utils.ConsoleLog(Utils.ConsoleLogType.Msg, $"[VRCA] Downloading {avatar.name}", ConsoleColor.Blue);
					if (!Directory.Exists($"Forbidden\\VRCA\\{avatar.name}"))
					{
						Directory.CreateDirectory($"Forbidden\\VRCA\\{avatar.name}");
					}
					Int64 FileSize;
					using (WebClient webClient = new WebClient())
					{
						webClient.Headers.Add("User-Agent: Other");
						webClient.DownloadFile(new Uri(avatar.assetUrl), $"Forbidden\\VRCA\\{avatar.name}\\" + avatar.name + ".vrca");
						FileSize = Convert.ToInt64(webClient.ResponseHeaders["Content-Length"]) / 1024 / 1024;
					}
					if (!string.IsNullOrEmpty(image))
					{
						using (WebClient webClient2 = new WebClient())
						{
							webClient2.Headers.Add("User-Agent: Other");
							webClient2.DownloadFile(new Uri(image), $"Forbidden\\VRCA\\{avatar.name}\\" + avatar.name + ".png");
						}
					}
					Utils.Notification($"[VRCA] Finished Downloading {avatar.name}: " + FileSize + "MB", UnityEngine.Color.green);
					Utils.ConsoleLog(Utils.ConsoleLogType.Msg, $"[VRCA] Finished Downloading {avatar.name}: " + FileSize + "MB", ConsoleColor.Green);
				}
				catch (Exception)
				{
					Utils.Notification($"[VRCA] Error Downloading {avatar.name}", UnityEngine.Color.red);
					Utils.ConsoleLog(Utils.ConsoleLogType.Msg, $"[VRCA] Error Downloading {avatar.name}", ConsoleColor.Red);
				}
			}).Start();
		}

	}
    }
