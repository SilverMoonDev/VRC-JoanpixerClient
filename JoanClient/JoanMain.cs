using System;
using System.Collections;
using Il2CppSystem.Diagnostics;
using JoanClient.Features;
using JoanpixerClient.Features.Worlds;
using JoanpixerClient.Modules;
using UnityEngine;
using MelonLoader;
using LoadSprite;
using Environment = System.Environment;
using PlagueButtonAPI;
using PlagueButtonAPI.Controls;
using PlagueButtonAPI.Controls.Grouping;
using PlagueButtonAPI.Pages;
using PlagueButtonAPI.Misc;
using VRC;

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
                MenuUi.MainMenu();
                UIColor.UiColor();
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
