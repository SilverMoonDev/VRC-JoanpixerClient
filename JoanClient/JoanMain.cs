using System;
using MelonLoader;
using Il2CppSystem.Diagnostics;
using JoanClient.Features;
using UnityEngine;
using LoadSprite;
using UnhollowerRuntimeLib;
using Environment = System.Environment;
using JoanpixerClient.Modules;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using JoanButtonAPI.Misc;

[assembly: MelonInfo(typeof(JoanpixerClient.JoanpixerMain), "JoanpixerClient", "1.0.0", "Joanpixer")]
[assembly: MelonGame("VRChat", "VRChat")]
[assembly: MelonColor(ConsoleColor.DarkMagenta)]

namespace JoanpixerClient
{
    public class JoanpixerMain : MelonMod
    {

        private static readonly IEnumerable<MelonLoaderEvents> eventListeners = from type in typeof(JoanpixerMain).Assembly.GetTypes()
                                                                                where type.IsSubclassOf(typeof(MelonLoaderEvents))
                                                                                orderby ((PriorityAttribute)Attribute.GetCustomAttribute(type, typeof(PriorityAttribute)))?.priority ?? 0
                                                                                select (MelonLoaderEvents)Activator.CreateInstance(type);

        public static Sprite Background = null;
        internal static Sprite ButtonImage = null;
        internal static bool PickupESP = false;
        internal static JoanpixerMain Instance;
        public override void OnApplicationStart()
        {
            Instance = this;
            ClassInjector.RegisterTypeInIl2Cpp<EnableDisableListener>();
            ClassInjector.RegisterTypeInIl2Cpp<AvatarFavs>();
            OnStart();
            FoldersManager.Create.Initialize();
            PatchManager.InitPatch();
            PatchManager.QuestIni();
            new Features.ForceInvite().Start();
            ButtonImage = (Environment.CurrentDirectory + "\\Joanpixer\\MainMenu.png").LoadSpriteFromDisk();
            MelonUtils.SetConsoleTitle("Joanpixer Client Alpha");
            foreach (var eventListener in eventListeners)
            {
                try
                {
                    eventListener.OnApplicationStart();
                }
                catch (Exception ex)
                {
                    MelonLogger.Error("Encountered an exception while running OnApplicationStart of \"" + eventListener.GetType().FullName + "\":\n" + ex);
                }
            }

            MelonCoroutines.Start(WaitForUIInit());
        }

        public virtual void OnStart()
        {

        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (sceneName == "ui")
            {
                new Features.HighlightsComponent().OnUiManagerInitEarly();
                UIColor.UiColor();
                MenuUi.MainMenu();
                var Client = new GameObject();
                UnityEngine.Object.DontDestroyOnLoad(Client);
                Client.AddComponent<AvatarFavs>();
                Features.ThirdPersonComponent.OnUiManagerInit();
            }
            foreach (var eventListener in eventListeners)
            {
                try
                {
                    eventListener.OnSceneWasLoaded(buildIndex, sceneName);
                }
                catch (Exception ex)
                {
                    MelonLogger.Error("Encountered an exception while running OnSceneLoad of \"" + eventListener.GetType().FullName + "\":\n" + ex);
                }
            }
        }

        public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
        {
            foreach (var eventListener in eventListeners)
            {
                try
                {
                    eventListener.OnSceneWasUnloaded(buildIndex, sceneName);
                }
                catch (Exception ex)
                {
                    MelonLogger.Error("Encountered an exception while running OnSceneUnload of \"" + eventListener.GetType().FullName + "\":\n" + ex);
                }
            }
        }

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            foreach (var eventListener in eventListeners)
            {
                try
                {
                    eventListener.OnSceneWasInitialized(buildIndex, sceneName);
                }
                catch (Exception ex)
                {
                    MelonLogger.Error("Encountered an exception while running OnSceneInit of \"" + eventListener.GetType().FullName + "\":\n" + ex);
                }
            }
        }

        internal static float OnUpdateRoutineDelay = 0f;

        public override void OnUpdate()
        {
            // Speedhack.
            if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyUp(KeyCode.X))
            {
                Features.Speedhack.Toggle();
            }

            /*
            if (Input.GetAxis("Oculus_CrossPlatform_PrimaryHandTrigger") > 0.6f)
            {
                sendInput.Mouse.RightButtonClick();
            }
            */
            if (Time.time > OnUpdateRoutineDelay && VRCUtils.IsWorldLoaded)
            {
                OnUpdateRoutineDelay = Time.time + 5f;
                if (PickupESP)
                    Features.HighlightsComponent.PickupESP(true);
                if (Features.Worlds.Murder4.worldLoaded && Features.Worlds.Murder4.CluesESP)
                {
                    Features.Worlds.Murder4.CluesESPCoro();
                }
            }
            Features.Speedhack.Main();
            FlightMod.Flight.OnUpdate();
            Features.ThirdPersonComponent.OnUpdate();
        }


        public override void OnApplicationQuit()
        {
            Process.GetCurrentProcess().Kill();
        }

        private IEnumerator WaitForUIInit()
        {
            while (VRCUiManager.field_Private_Static_VRCUiManager_0 == null)
            {
                yield return null;
            }

            foreach (var eventListener in eventListeners)
            {
                try
                {
                    eventListener.OnUiManagerInit();
                }
                catch (Exception ex)
                {
                    MelonLogger.Error("Encountered an exception while running UiManagerInit of \"" + eventListener.GetType().FullName + "\":\n" + ex);
                }
            }

            yield break;
        }
    }
}
