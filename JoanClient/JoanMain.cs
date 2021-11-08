using System;
using System.Collections;
using Il2CppSystem.Diagnostics;
using JoanClient.Features;
using JoanpixerClient.Buttons;
using JoanpixerClient.Features.Worlds;
using JoanpixerClient.Modules;
using UnityEngine;
using MelonLoader;
using LoadSprite;
using UnityEngine.UI;
using Environment = System.Environment;

[assembly: MelonInfo(typeof(JoanpixerClient.JoanpixerMain), "JoanpixerClient", "1.0.0", "Joanpixer")]
[assembly: MelonGame("VRChat", "VRChat")]
[assembly: MelonColor(ConsoleColor.DarkMagenta)]

namespace JoanpixerClient
{
    public class JoanpixerMain : MelonMod
    {
        public static Sprite Background = null;

        internal static Sprite MainMenuImage = null;

        public override void OnApplicationStart()
        {
            FoldersManager.Create.Initialize();
            PatchManager.InitPatch();
            PatchManager.QuestIni();
            new Features.KeyPaste().OnApplicationStart();
            MainMenuImage = (Environment.CurrentDirectory + "\\Joanpixer\\MainMenu.png").LoadSpriteFromDisk();
            MelonUtils.SetConsoleTitle("Joanpixer Client Alpha");
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (sceneName == "ui")
            {
                MenuUi.MainMenu();
                ConsoleMenu.Initialize();
            }
            UIColor.UiColor();
        }

        public override void OnPreferencesSaved()
        {
            new Features.KeyPaste().OnPreferencesSaved();
        }

        public override void OnUpdate()
        {
            // Speedhack.
            if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyUp(KeyCode.X))
            {
                Features.Speedhack.Toggle();
            }

            // Failsafe for when the game lags while letting go of X preventing speedhack to turn off.
            if (!Input.GetKey(KeyCode.X) && Features.Speedhack.speedEnabled)
            {
                Features.Speedhack.speedEnabled = false;
            }

            /*
            if (Input.GetAxis("Oculus_CrossPlatform_PrimaryHandTrigger") > 0.6f)
            {
                sendInput.Mouse.RightButtonClick();
            }
            */
            Features.Speedhack.Main();
            Features.ESP.Main();
            FlightMod.Flight.OnUpdate();
        }


        public override void OnApplicationQuit()
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
