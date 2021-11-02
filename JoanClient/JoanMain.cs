using Il2CppSystem.Diagnostics;
using JoanpixerClient.Features.Worlds;
using UnityEngine;
using MelonLoader;
using LoadSprite;
using UnityEngine.UI;
using VRC.Udon;
using Environment = System.Environment;

[assembly: MelonInfo(typeof(JoanpixerClient.JoanpixerMain), "JoanpixerClient", "1.0.0", "Joanpixer")]
[assembly: MelonGame("VRChat", "VRChat")]

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
            }
            if (Background != null)
            {
                try
                {
                    if (GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background").gameObject.scene.name == "DontDestroyOnLoad")
                    {
                        GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background").GetComponent<Image>().sprite = Background;
                        GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background").GetComponent<Image>().color = new Color(0.02f, 0.26f, 1, 0.473f);
                    }
                }
                catch { }
            }
            foreach (var buttons in Resources.FindObjectsOfTypeAll<Button>())
            {
                if (buttons.gameObject.scene.name == "DontDestroyOnLoad")
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
        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {

            JustBClub.Initialize(sceneName);
            AmongUs.Initialize(sceneName);
            Murder4.Initialize(sceneName);
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

        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
