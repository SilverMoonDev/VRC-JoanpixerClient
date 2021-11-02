using Harmony;
using MelonLoader;
using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using JoanpixerClient.FoldersManager;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.Core;
using VRC.Networking;
using AccessTools = HarmonyLib.AccessTools;
using HarmonyMethod = HarmonyLib.HarmonyMethod;
using Logger = UnityEngine.Logger;

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
                Instance.Patch(
                    typeof(PortalTrigger).GetMethod(nameof(PortalTrigger.OnTriggerEnter),
                        BindingFlags.Public | BindingFlags.Instance), GetPatch("EnterPortal"), null, null);
                Instance.Patch(typeof(UdonSync).GetMethod(nameof(UdonSync.UdonSyncRunProgramAsRPC)),
                    GetPatch("UdonSyncPatch"), null);
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

        private static bool UdonSyncPatch(string __0, Player __1)
        {
            if (LogUdon)
            {
                MelonLogger.Msg($"Udon Event: {__0}, Player: {__1.field_Private_VRCPlayerApi_0.displayName}");
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

        public static IEnumerator QuestSpoofDelay()
        {
            yield return new WaitForSeconds(4);
            QuestSpoof = false;
            yield break;
        }

        private static void OnJoinedRoom()
        {
            if (LoginDelay)
            {
                LoginDelay = false;
                MelonCoroutines.Start(QuestSpoofDelay());
            }
        }

        public static bool LoginDelay = true;

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

        public static IEnumerator Awa()
        {
            yield return new WaitForSeconds(5);
            QuestSpoof = false;
            LoginDelay = false;
            MelonLogger.Msg("Quest Spoofed");
        }

        public static void QuestIni()
        {
            QuestSpoof = Create.Ini.GetBool("Toggles", "QuestSpoof");
            LoginDelay = Create.Ini.GetBool("Toggles", "QuestSpoof");
            if (QuestSpoof)
            {
                MelonCoroutines.Start(Awa());
            }
        }
    }
}