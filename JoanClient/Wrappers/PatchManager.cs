using Harmony;
using MelonLoader;
using System;
using System.Collections;
using System.Reflection;
using JoanpixerClient.Features.Worlds;
using JoanpixerClient.FoldersManager;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.Core;
using VRC.Networking;
using VRC.SDK.Internal.Shootout;
using VRC.SDK3.Components;
using VRC.SDKBase;
using AccessTools = HarmonyLib.AccessTools;
using HarmonyMethod = HarmonyLib.HarmonyMethod;
using Object = System.Object;
using Player = VRC.Player;

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
                Instance.Patch(typeof(PortalTrigger).GetMethod(nameof(PortalTrigger.OnTriggerEnter), BindingFlags.Public | BindingFlags.Instance), GetPatch("EnterPortal"),null, null);
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
        public static bool PortalWalk = false;
        public static bool LogUdon = false;
        public static bool LogCheaters = false;
        public static bool playsound = false;
        public static bool logconsole = true;

        public static void Play()
        {
            if (playsound)
            {
                System.Media.SoundPlayer player =
                    new System.Media.SoundPlayer(Environment.CurrentDirectory + "\\Joanpixer\\sound.wav");
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

        private static IEnumerator ShowMurderer()
        {
            yield return new WaitForSeconds(1);
            var Murderer = $"Murderer is {Murder4.MurderText.GetComponent<Text>().m_Text}";
            MelonCoroutines.Start(Utils.Notification(Murderer));
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
            if (UnityEngine.XR.XRDevice.isPresent)
            {
                MelonLogger.Msg("Quest Spoofed");
            }
            else
            {
                yield return new WaitForSeconds(13);
                MelonLogger.Warning("Spoofing Quest In Desktop!");
                MelonCoroutines.Start(Utils.Notification("Warning: Spoofing Quest In Desktop!"));
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
            AmongUs.Initialize();
            Murder4.Initialize();
            try
            {
                GameObject.Find("_Application/CursorManager/BlueFireballMouse/Ball").GetComponent<ParticleSystem>().main.startColor = Color.magenta;
                GameObject.Find("_Application/CursorManager/BlueFireballMouse/Glow").GetComponent<ParticleSystem>().main.startColor = Color.magenta;
                GameObject.Find("_Application/CursorManager/BlueFireballMouse/Trail").GetComponent<ParticleSystem>().main.startColor = Color.magenta;
                GameObject.Find("_Application/CursorManager/BlueFireballGaze/Ball").GetComponent<ParticleSystem>().main.startColor = Color.magenta;
                GameObject.Find("_Application/CursorManager/BlueFireballGaze/Glow").GetComponent<ParticleSystem>().main.startColor = Color.magenta;
                GameObject.Find("_Application/CursorManager/BlueFireballGaze/Trail").GetComponent<ParticleSystem>().main.startColor = Color.magenta;
                GameObject.Find("_Application/CursorManager/RightHandBeam/plasma_beam_muzzle_blue").GetComponent<ParticleSystem>().main.startColor = Color.magenta;
                GameObject.Find("_Application/CursorManager/RightHandBeam/plasma_beam_flare_blue").GetComponent<ParticleSystem>().main.startColor = Color.magenta;
                GameObject.Find("_Application/CursorManager/RightHandBeam/plasma_beam_spark_002").GetComponent<ParticleSystem>().main.startColor = Color.magenta;
            }
            catch {}
        }

        private static void OnPlayerJoin(Player __0)
        {
            if (APIUser.CurrentUser.id == __0.field_Private_APIUser_0.id) return;
            if (APIUser.CurrentUser.friendIDs.Contains(__0.field_Private_APIUser_0.id))
            {
                __0.field_Private_VRCPlayerApi_0.gameObject.transform.Find("SelectRegion").GetComponent<Renderer>().material.SetColor("_Color", Color.green);
                __0.field_Private_VRCPlayerApi_0.gameObject.transform.Find("SelectRegion").GetComponent<Renderer>().sharedMaterial.SetColor("_Color", Color.green);
            }
            else
            {
                __0.field_Private_VRCPlayerApi_0.gameObject.transform.Find("SelectRegion").GetComponent<Renderer>().material.SetColor("_Color", Color.magenta);
                __0.field_Private_VRCPlayerApi_0.gameObject.transform.Find("SelectRegion").GetComponent<Renderer>().sharedMaterial.SetColor("_Color", Color.magenta);
            }
        }
    }
}