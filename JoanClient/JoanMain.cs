using System;
using System.Collections;
using Il2CppSystem.Diagnostics;
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
            if (Background != null)
            {
                try
                {
                    if (GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background").gameObject.scene.name == "DontDestroyOnLoad")
                    {
                        GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background").GetComponent<Image>().sprite = Background;
                        GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background").GetComponent<Image>().color = new Color(0.02f, 0.26f, 1, 0.473f);
                        GameObject.Find("_Application/CursorManager/LeftHandBeam/plasma_beam_muzzle_blue").GetComponent<ParticleSystem>().main.startColor = Color.magenta;
                        GameObject.Find("_Application/CursorManager/LeftHandBeam/plasma_beam_flare_blue").GetComponent<ParticleSystem>().main.startColor = Color.magenta;
                        GameObject.Find("_Application/CursorManager/LeftHandBeam/plasma_beam_spark_002").GetComponent<ParticleSystem>().main.startColor = Color.magenta;
                    }
                }
                catch { }
            }
            foreach (var buttons in Resources.FindObjectsOfTypeAll<Button>())
            {
                if (buttons.gameObject.scene.name == "DontDestroyOnLoad")
                {
                    if (Utils.GetGameObjectPath(buttons.gameObject).Contains("UserInterface"))
                    {
                        ColorBlock cb = buttons.colors;
                        cb.m_NormalColor = Color.magenta;
                        cb.m_PressedColor = new Color(1, 0, 1, 0.2f);
                        cb.m_HighlightedColor = new Color(1, 0, 1, 0.5f);
                        cb.m_DisabledColor = Color.magenta;
                        cb.m_SelectedColor = new Color(1, 0, 1, 0.5f);
                        buttons.colors = cb;
                    }
                }
            }
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

            // Noclip.
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.F))
            {
                Features.Noclip.Toggle();
            }
            Features.Speedhack.Main();
            Features.Noclip.Main();
            Features.ESP.Main();
        }


        public override void OnApplicationQuit()
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
