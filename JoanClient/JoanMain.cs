using System;
using MelonLoader;
using Il2CppSystem.Diagnostics;
using JoanClient.Features;
using UnityEngine;
using LoadSprite;
using Environment = System.Environment;

[assembly: MelonInfo(typeof(JoanpixerClient.JoanpixerMain), "JoanpixerClient", "1.0.0", "Joanpixer")]
[assembly: MelonGame("VRChat", "VRChat")]
[assembly: MelonColor(ConsoleColor.DarkMagenta)]

namespace JoanpixerClient
{
    public class JoanpixerMain : MelonMod
    {
        public static Sprite Background = null;

        internal static Sprite ButtonImage = null;

        public override void OnApplicationStart()
        {
            FoldersManager.Create.Initialize();
            PatchManager.InitPatch();
            PatchManager.QuestIni();
            ButtonImage = (Environment.CurrentDirectory + "\\Joanpixer\\MainMenu.png").LoadSpriteFromDisk();
            MelonUtils.SetConsoleTitle("Joanpixer Client Alpha");
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (sceneName == "ui")
            {
                UIColor.UiColor();
                MenuUi.MainMenu();
            }

        }

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
