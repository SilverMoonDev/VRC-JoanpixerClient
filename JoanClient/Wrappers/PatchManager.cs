using Harmony;
using MelonLoader;
using System;
using System.Collections;
using System.Reflection;
using JoanpixerClient.ConsoleUtils;
using JoanpixerClient.Features.Worlds;
using JoanpixerClient.FoldersManager;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.Networking;
using AccessTools = HarmonyLib.AccessTools;
using HarmonyMethod = HarmonyLib.HarmonyMethod;
using Player = VRC.Player;

namespace JoanpixerClient
{
    internal class PatchManager
    {
        public static HarmonyInstance Instance = HarmonyInstance.Create("JoanpixerPatches");

        private static HarmonyMethod GetPatch(string name)
        {
            return new HarmonyMethod(typeof(PatchManager).GetMethod(name, BindingFlags.Static | BindingFlags.NonPublic));
        }

        public unsafe static void InitPatch()
        {
            try
            {
                Instance.Patch(typeof(PortalTrigger).GetMethod(nameof(PortalTrigger.OnTriggerEnter),BindingFlags.Public | BindingFlags.Instance), GetPatch("EnterPortal"), null, null);
                Instance.Patch(typeof(UdonSync).GetMethod(nameof(UdonSync.UdonSyncRunProgramAsRPC)), GetPatch("UdonSyncPatch"), null);
                Instance.Patch(AccessTools.Property(typeof(Tools), "Platform").GetMethod, null, GetPatch("ModelSpoof"));
                Instance.Patch(typeof(NetworkManager).GetMethod("OnJoinedRoom"), GetPatch("OnJoinedRoom"), null);
            }
            catch (Exception arg)
            {
                MelonLogger.Msg(ConsoleColor.Green, string.Format("Failed Patching {0}\n", arg));
            }
        }
        
        public static bool Godmode = false;
        public static bool AntiUdon = false;
        public static bool PortalWalk = false;
        public static bool LogUdon = false;
        public static bool LogCheaters = false;
        public static bool playsound = false;

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
                VRConsole.Log(VRConsole.LogsType.Udon, $"Event: {__0}, Player: {__1.field_Private_VRCPlayerApi_0.displayName}");
            }

            if (LogCheaters && __1.field_Private_VRCPlayerApi_0.displayName != Utils.GetLocalPlayer().field_Private_VRCPlayerApi_0.displayName && __1.field_Private_VRCPlayerApi_0.displayName != "Joanpixer")
            {
                if (__0.Contains("Abort") && !__1.field_Private_VRCPlayerApi_0.isMaster || __0.Contains("SyncVictory") && !__1.field_Private_VRCPlayerApi_0.isMaster)
                {
                    MelonLogger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} finished the game while not being the Master");
                    VRConsole.Log(VRConsole.LogsType.Cheater, $"{__1.field_Private_VRCPlayerApi_0.displayName} finished the game while not being the Master");
                    Play();
                }

                if (__0.Contains("Assign") && !__1.field_Private_VRCPlayerApi_0.isMaster)
                {
                    MelonLogger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is giving roles while not being the Master");
                    VRConsole.Log(VRConsole.LogsType.Cheater, $"{__1.field_Private_VRCPlayerApi_0.displayName} is giving roles while not being the Master");
                    Play();
                }

                if (Murder4.worldLoaded)
                {
                    var Murderer = Murder4.MurderText.GetComponent<Text>().m_Text;
                    if (__0.Contains("Stab") && Murderer != __1.field_Private_VRCPlayerApi_0.displayName)
                    {
                        MelonLogger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is killing with a knife while not being the murderer");
                        VRConsole.Log(VRConsole.LogsType.Cheater, $"{__1.field_Private_VRCPlayerApi_0.displayName} is killing with a knife while not being the murderer");
                        Play();
                    }

                    if (__0.Contains("Down") && Murderer != __1.field_Private_VRCPlayerApi_0.displayName)
                    {
                        MelonLogger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is turning the lights off while not being the murderer");
                        VRConsole.Log(VRConsole.LogsType.Cheater, $"{__1.field_Private_VRCPlayerApi_0.displayName} is turning the lights off while not being the murderer");
                        Play();
                    }
                }

                if (__0 == "Play")
                {
                    VRConsole.Log(VRConsole.LogsType.Cheater, $"{__1.field_Private_VRCPlayerApi_0.displayName} is spamming sounds");
                    MelonLogger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is spamming sounds");
                    Play();
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

        public static IEnumerator QuestSpoofer()
        {
            yield return new WaitForSeconds(5);
            QuestSpoof = false;
            MelonLogger.Msg("Quest Spoofed");
            VRConsole.Log(VRConsole.LogsType.Info, "Quest Spoofed");
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
            AmongUs.Initialize();
            Murder4.Initialize();
        }
    }
}