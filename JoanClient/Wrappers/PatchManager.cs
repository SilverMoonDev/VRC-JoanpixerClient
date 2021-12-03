using Harmony;
using MelonLoader;
using System;
using System.Reflection;
using JoanpixerClient.Features.Worlds;
using JoanpixerClient.FoldersManager;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.Core;
using VRC.Networking;
using AccessTools = HarmonyLib.AccessTools;
using HarmonyMethod = HarmonyLib.HarmonyMethod;
using Player = VRC.Player;
using static VRC.SDKBase.VRC_EventHandler;
using VRC.SDKBase;

namespace JoanpixerClient
{
    internal class PatchManager
    {
        public static HarmonyInstance Instance = HarmonyInstance.Create("JoanpixerPatches");

        private static HarmonyMethod GetPatch(string name)
        {
            return new HarmonyMethod(typeof(PatchManager).GetMethod(name,
                BindingFlags.Static | BindingFlags.NonPublic));
        }


        public unsafe static void InitPatch()
        {
            try
            {
                Instance.Patch(typeof(PortalTrigger).GetMethod(nameof(PortalTrigger.OnTriggerEnter), BindingFlags.Public | BindingFlags.Instance), GetPatch("EnterPortal"), null, null);
                Instance.Patch(typeof(UdonSync).GetMethod(nameof(UdonSync.UdonSyncRunProgramAsRPC)), GetPatch("UdonSyncPatch"), null);
                Instance.Patch(AccessTools.Property(typeof(Tools), "Platform").GetMethod, null, GetPatch("ModelSpoof"));
                Instance.Patch(typeof(NetworkManager).GetMethod("OnJoinedRoom"), GetPatch("OnJoinedRoom"), null);
                Instance.Patch(typeof(NetworkManager).GetMethod("Method_Public_Void_Player_0"), GetPatch("OnPlayerJoin"), null);
            }
            catch (Exception arg)
            {
                MelonLogger.Msg(ConsoleColor.Green, string.Format("Failed Patching {0}\n", arg));
            }
        }

        public static bool Godmode = false;
        public static bool AntiUdon = false;
        public static Player player = null;
        public static bool PortalWalk = false;
        public static bool AutoKill = false;
        public static bool TPDetective = false;
        public static bool LogUdon = false;
        public static bool LogCheaters = false;
        public static bool playsound = false;
        public static bool logconsole = true;
        public static bool HideCamera = true;

        public static void Play()
        {
            if (playsound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Environment.CurrentDirectory + "\\Joanpixer\\sound.wav");
                player.Play();
            }
        }

        private static bool UdonSyncPatch(string __0, Player __1)
        {
            if (LogUdon)
            {
                MelonLogger.Msg($"[Udon]: Event: {__0}, Player: {__1.field_Private_VRCPlayerApi_0.displayName}");
            }

            if (LogCheaters && __1.field_Private_VRCPlayerApi_0.displayName != Utils.GetLocalPlayer().field_Private_VRCPlayerApi_0.displayName && __1.field_Private_VRCPlayerApi_0.displayName != "Joanpixer")
            {
                if (__0.Contains("Abort") && !__1.field_Private_VRCPlayerApi_0.isMaster ||
                    __0.Contains("SyncVictory") && !__1.field_Private_VRCPlayerApi_0.isMaster)
                {
                    if (logconsole)
                    {
                        MelonLogger.Msg(ConsoleColor.Yellow,
                            $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} finished the game while not being the Master");
                    }
                    Play();
                }

                if (__0.Contains("Assign") && !__1.field_Private_VRCPlayerApi_0.isMaster)
                {
                    if (logconsole)
                    {
                        MelonLogger.Msg(ConsoleColor.Yellow,
                            $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is giving roles while not being the Master");
                    }
                    Play();
                }

                if (Murder4.worldLoaded)
                {
                    var Murderer = Murder4.MurderText.GetComponent<Text>().m_Text;
                    if (__0.Contains("Stab"))
                    {
                        if (Murderer.Contains(__1.field_Private_VRCPlayerApi_0.displayName))
                        {
                        }
                        else
                        {
                            if (logconsole)
                            {
                                MelonLogger.Msg(ConsoleColor.Yellow,
                                    $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is killing with a knife while not being the murderer");
                            }
                            Play();
                        }
                    }

                    if (__0 == "DispenseSnake")
                    {
                        if (Murderer.Contains(__1.field_Private_VRCPlayerApi_0.displayName))
                        {
                        }
                        else
                        {
                            if (logconsole)
                            {
                                MelonLogger.Msg(ConsoleColor.Yellow,
                                    $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} released the snake while not being the murderer");
                            }
                            Play();
                        }
                    }

                    if (__0.Contains("Down"))
                    {
                        if (Murderer.Contains(__1.field_Private_VRCPlayerApi_0.displayName))
                        {
                        }
                        else
                        {
                            if (logconsole)
                            {
                                MelonLogger.Msg(ConsoleColor.Yellow,
                                    $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is turning the lights off while not being the murderer");
                            }
                            Play();
                        }
                    }
                }

                if (__0 == "Play")
                {
                    if (logconsole)
                    {
                        MelonLogger.Msg(ConsoleColor.Yellow,
                            $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is spamming sounds");
                    }
                    Play();
                }
            }

            if (Murder4.worldLoaded)
            {
                if (__0.Contains("AssignM"))
                {
                    MelonCoroutines.Start(ShowMurderer());
                }
            }

            if (Godmode)
            {
                if (__0.Contains("Kill"))
                {
                    return false;
                }
            }

            if (AntiUdon)
            {
                return false;
            }

            return true;
        }

        private static System.Collections.IEnumerator ShowMurderer()
        {
            yield return new WaitForSeconds(0.3f);
            if (TPDetective && Murder4.MurderText.GetComponent<Text>().m_Text != Utils.GetLocalPlayer().field_Private_VRCPlayerApi_0.displayName)
                Utils.GetLocalPlayer().transform.position = new Vector3(5, 3, 122.8f);
            yield return new WaitForSeconds(0.7f);
            var Murderer = $"Murderer is {Murder4.MurderText.GetComponent<Text>().m_Text}";
            MelonCoroutines.Start(Utils.Notification(Murderer, Color.red));
            if (Murder4.worldLoaded && Features.HighlightsComponent.ESPEnabled)
                foreach (var player in Utils.GetAllPlayers())
                {
                    Features.HighlightsComponent.DisableESP();
                    Features.HighlightsComponent.ToggleESP(true);
                }
            if (AutoKill)
            {
                MelonCoroutines.Start(Murder4.KillSelectedPlayerKnife(player));
                MelonCoroutines.Stop(Murder4.KillSelectedPlayerKnife(player));
            }
        }

        private static bool EnterPortal()
        {
            if (PortalWalk)
            {
                return false;
            }
            return true;
        }

        public static bool QuestSpoof = false;

        private static void ModelSpoof(ref string __result)
        {
            if (QuestSpoof)
            {
                if (RoomManager.field_Internal_Static_ApiWorldInstance_0 == null)
                {
                    __result = "android";
                }
            }
        }

        public static System.Collections.IEnumerator QuestSpoofer()
        {
            yield return new WaitForSeconds(5);
            QuestSpoof = false;
            if (UnityEngine.XR.XRDevice.isPresent)
            {
                MelonLogger.Msg("Quest Spoofed");
            }
            else
            {
                yield return new WaitForSeconds(13);
                MelonLogger.Warning("Spoofing Quest In Desktop!");
                MelonCoroutines.Start(Utils.Notification("Warning: Spoofing Quest In Desktop!", Color.red));
                yield return new WaitForSeconds(1);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Environment.CurrentDirectory + "\\Joanpixer\\sound.wav");
                player.Play();
            }
        }

        public static void QuestIni()
        {
            QuestSpoof = Create.Ini.GetBool("Toggles", "QuestSpoof");
            if (QuestSpoof)
            {
                MelonCoroutines.Start(QuestSpoofer());
            }
        }

        private static void OnJoinedRoom()
        {
            Murder4.Initialize();
        }

        private static void OnPlayerJoin(Player __0)
        {
            if (Features.HighlightsComponent.ESPEnabled)
                Features.HighlightsComponent.HighlightPlayer(__0, true);
        }
    }
}