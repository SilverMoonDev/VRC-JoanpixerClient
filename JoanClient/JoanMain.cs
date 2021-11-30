using System;
using MelonLoader;
using Il2CppSystem.Diagnostics;
using JoanClient.Features;
using UnityEngine;
using LoadSprite;
using UnhollowerRuntimeLib;
using Environment = System.Environment;
using JoanpixerClient.Modules;
using VRC.SDKBase;
using static VRC.SDKBase.VRC_EventHandler;

[assembly: MelonInfo(typeof(JoanpixerClient.JoanpixerMain), "JoanpixerClient", "1.0.0", "Joanpixer")]
[assembly: MelonGame("VRChat", "VRChat")]
[assembly: MelonColor(ConsoleColor.DarkMagenta)]

namespace JoanpixerClient
{
    public class JoanpixerMain : MelonMod
    {
        public static Sprite Background = null;

        internal static Sprite ButtonImage = null;
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
    }
}
