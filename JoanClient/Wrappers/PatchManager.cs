using Harmony;
using MelonLoader;
using System;
using System.Reflection;
using JoanpixerClient.Features.Worlds;
using JoanpixerClient.FoldersManager;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.Networking;
using AccessTools = HarmonyLib.AccessTools;
using HarmonyMethod = HarmonyLib.HarmonyMethod;
using Player = VRC.Player;
using Newtonsoft.Json.Linq;
using FlightMod;
using ExitGames.Client.Photon;
using VRC.Core;
using VRC.SDKBase;

namespace JoanpixerClient
{
    internal class PatchManager
    {
        public static HarmonyLib.Harmony Instance = new ("JoanpixerPatches");

        private static HarmonyMethod GetPatch(string name)
        {
            return new HarmonyMethod(typeof(PatchManager).GetMethod(name,
                BindingFlags.Static | BindingFlags.NonPublic));
        }


        public static unsafe void InitPatch()
        {
            try
            {
                Instance.Patch(typeof(PortalTrigger).GetMethod(nameof(PortalTrigger.OnTriggerEnter), BindingFlags.Public | BindingFlags.Instance), GetPatch("EnterPortal"), null, null);
                Instance.Patch(typeof(UdonSync).GetMethod(nameof(UdonSync.UdonSyncRunProgramAsRPC)), GetPatch("UdonSyncPatch"), null);
                Instance.Patch(AccessTools.Property(typeof(Tools), "Platform").GetMethod, null, GetPatch("PlatformSpoof"));
                Instance.Patch(typeof(NetworkManager).GetMethod("OnJoinedRoom"), GetPatch("OnJoinedRoom"), null);
                Instance.Patch(typeof(NetworkManager).GetMethod("Method_Public_Void_Player_0"), GetPatch("OnPlayerJoin"), null);
            }
            catch (Exception arg)
            {
                MelonLogger.Msg(ConsoleColor.Green, string.Format("Failed Patching {0}\n", arg));
            }
        }

        public static bool Godmode;
        public static bool AntiUdon;
        public static Player player;
        public static bool PortalWalk;
        public static bool AutoKill;
        public static bool TPDetective;
        public static bool LogUdon;
        public static bool LogCheaters;
        public static bool playsound;
        public static bool loggedin;

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
                    MelonLogger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} finished the game while not being the Master");
                    Play();
                }

                if (__0.Contains("Assign") && !__1.field_Private_VRCPlayerApi_0.isMaster)
                {
                    
                    MelonLogger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is giving roles while not being the Master");
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
                            MelonLogger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is killing with a knife while not being the murderer");
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
                            MelonLogger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} released the snake while not being the murderer");
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
                            MelonLogger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is turning the lights off while not being the murderer");
                            Play();
                        }
                    }
                    if (__0 == "Play")
                    {
                        MelonLogger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is spamming sounds");
                        Play();
                    }
                }

                if (Murder3.worldLoaded)
                {
                    var Murderer = Murder3.MurderText.GetComponent<Text>().m_Text;
                    if (__0.Contains("Stab"))
                    {
                        if (Murderer.Contains(__1.field_Private_VRCPlayerApi_0.displayName))
                        {
                        }
                        else
                        {
                            MelonLogger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is killing with a knife while not being the murderer");
                            Play();
                        }
                    }
                }
            }

            if (Murder3.worldLoaded || Murder4.worldLoaded)
            {
                if (__0 == "SyncPenalty") return false;
            }

            if (Murder4.worldLoaded || Murder3.worldLoaded)
            {
                if (__0.Contains("AssignM"))
                {
                    MelonCoroutines.Start(ShowMurderer());
                }
            }

            if (__0.Contains("Kill") && Godmode)
            {
                return false;
            }

            return !AntiUdon;
        }

        private static System.Collections.IEnumerator ShowMurderer()
        {
            yield return new WaitForSeconds(0.3f);
            var Murderer = "";
            if (Murder4.worldLoaded)
            {
                Murderer = $"Murderer is {Murder4.MurderText.GetComponent<Text>().m_Text}";
                if (Murder4.MurderText.GetComponent<Text>().m_Text == Utils.GetLocalPlayer().field_Private_VRCPlayerApi_0.displayName)
                    Udon.CallUdonEvent(Murder4Items.snakedispenser, "DispenseSnake");
                if (TPDetective && Murder4.MurderText.GetComponent<Text>().m_Text != Utils.GetLocalPlayer().field_Private_VRCPlayerApi_0.displayName)
                    Utils.TPLocalPlayer(GameObject.Find("Game Logic/Detective Spawn").transform.position);
            }
            if (Murder3.worldLoaded)
            {
                Murderer = $"Murderer is {Murder3.MurderText.GetComponent<Text>().m_Text}";
                if (TPDetective && Murder3.MurderText.GetComponent<Text>().m_Text !=
                    Utils.GetLocalPlayer().field_Private_VRCPlayerApi_0.displayName)
                {
                    Utils.TPLocalPlayer(GameObject.Find("Game Logic/Detective Spawn").transform.position);
                }
            }
            yield return new WaitForSeconds(0.7f);
            MelonCoroutines.Start(Utils.Notification(Murderer, Color.red));
            if (Murder4.worldLoaded && Features.HighlightsComponent.ESPEnabled)
            {
                Features.HighlightsComponent.DisableESP();
                foreach (var player in Utils.GetAllPlayers())
                {
                    Features.HighlightsComponent.ToggleESP(true);
                }
            }
            if (Murder3.worldLoaded && Features.HighlightsComponent.ESPEnabled)
            {
                Features.HighlightsComponent.DisableESP();
                foreach (var player in Utils.GetAllPlayers())
                {
                    Features.HighlightsComponent.ToggleESP(true);
                }
            }
            if (AutoKill && Murder4.worldLoaded && Murder4Items.knife)
            {
                MelonCoroutines.Start(Murder4.KillSelectedPlayerKnife(player));
                MelonCoroutines.Stop(Murder4.KillSelectedPlayerKnife(player));
            }
            if (AutoKill && Murder3.worldLoaded && Murder4Items.knife)
            {
                MelonCoroutines.Start(Murder3.KillSelectedPlayerKnife(player));
                MelonCoroutines.Stop(Murder3.KillSelectedPlayerKnife(player));
            }
        }

        private static bool EnterPortal()
        {
            return !PortalWalk;
        }

        public static bool QuestSpoof = false;

        private static void PlatformSpoof(ref string __result)
        {
            if (QuestSpoof)
            {
                if (RoomManager.field_Internal_Static_ApiWorldInstance_0 == null && loggedin == false)
                {
                    __result = "android";
                }
            }
        }

        public static System.Collections.IEnumerator QuestSpoofer()
        {
            yield return new WaitForSeconds(5);
            loggedin = true;
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
                Play();
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
            Murder3.Initialize();
            loggedin = true;
        }

        private static void OnPlayerJoin(Player __0)
        {
            if (Features.HighlightsComponent.ESPEnabled)
                Features.HighlightsComponent.HighlightPlayer(__0, true);
        }
    }
}