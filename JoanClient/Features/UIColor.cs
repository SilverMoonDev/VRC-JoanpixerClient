using ForbiddenClient;
using ForbiddenClient.FoldersManager;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace ForbiddenClient.Features
{
    class UIColor
    {

        internal static string action;
        internal static float Red = Create.Ini.GetFloat("UIColour", "Red");
        internal static float Green = Create.Ini.GetFloat("UIColour", "Green");
        internal static float Blue = Create.Ini.GetFloat("UIColour", "Blue");

        internal static IEnumerator UiColor()
        {
            if (!PatchManager.loggedin)
            {
                if (ForbiddenMain.Background != null)
                {
                    try
                    {
                        if (GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background").gameObject.scene.name == "DontDestroyOnLoad")
                        {
                            GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background").GetComponent<Image>().sprite = ForbiddenMain.Background;
                            GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background").GetComponent<Image>().overrideSprite = ForbiddenMain.Background;
                            GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background").GetComponent<Image>().color = new Color(0.02f, 0.26f, 1, 0.473f);
                        }
                    }
                    catch { }
                }

                foreach (var buttons in UnityEngine.Resources.FindObjectsOfTypeAll<Button>())
                {
                    if (buttons.gameObject.scene.name == "DontDestroyOnLoad")
                    {
                        if (Utils.GetGameObjectPath(buttons.gameObject).Contains("UserInterface") && !Utils.GetGameObjectPath(buttons.gameObject).Contains("Canvas_QuickMenu(Clone)"))
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

                foreach (var settings in UnityEngine.Resources.FindObjectsOfTypeAll<Image>())
                {
                    if (settings.gameObject.scene.name == "DontDestroyOnLoad")
                    {
                        if (Utils.GetGameObjectPath(settings.gameObject).Contains("Settings") &&
                            settings.gameObject.name != "SettingsButton" && settings.gameObject.name != "SelectPrevMic" && settings.gameObject.name != "SelectNextMic" && settings.gameObject.name != "Button_ClearChanges" && settings.gameObject.name != "Exit" && settings.gameObject.name != "Logout" && settings.gameObject.name != "UpgradeAccount" && settings.gameObject.gameObject.name != "SettingsPageTab" && settings.gameObject.name != "ExpandButton" && settings.gameObject.name != "Button_EditBindings" && settings.gameObject.name != "Button_AdvancedOptions")
                        {
                            settings.color = new Color(0.4f, 0, 0.32f, 0.5f);
                            if (settings.gameObject.name.Contains("Panel") &&
                                !settings.gameObject.name.Contains("Panel_Header"))
                            {
                                settings.color = new Color(0, 0, 0, 0.5725f);
                            }

                            try
                            {
                                if (settings.gameObject.name.Contains("Volume"))
                                {
                                    ColorBlock uwu = settings.gameObject.GetComponent<Slider>().colors;
                                    uwu.m_NormalColor = new Color(1, 0, 0.8f, 0.7f);
                                    uwu.m_HighlightedColor = new Color(0.5f, 0.5f, 0.5f, 1);
                                    uwu.m_PressedColor = new Color(0.5f, 0.5f, 0.5f, 1);
                                    uwu.m_SelectedColor = new Color(1, 0, 0.8f, 0.7f);
                                    uwu.m_DisabledColor = new Color(1, 0, 0.8f, 0.7f);
                                    settings.gameObject.GetComponent<Slider>().colors = uwu;
                                    settings.color = new Color(1, 1, 1, 1);
                                }
                            }
                            catch
                            {
                            }

                            GameObject.Find("UserInterface/MenuContent/Screens/Settings/UserVolumeOptions")
                                .GetComponent<Image>().color = new Color(0, 0, 0, 0.5725f);
                            if (settings.gameObject.name == "Checkmark")
                            {
                                settings.color = new Color(0, 0, 0, 1);
                                var parent = settings.gameObject.transform.parent;
                                parent.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                            }

                            if (Utils.GetGameObjectPath(settings.gameObject).Contains("Toggle") &&
                                settings.gameObject.name != "Checkmark" || settings.gameObject.name == "Background" &&
                                !Utils.GetGameObjectPath(settings.gameObject).Contains("SensitivitySlider") &&
                                !Utils.GetGameObjectPath(settings.gameObject).Contains("VolumeDisplay"))
                            {
                                settings.color = new Color(1, 1, 1, 1);
                            }

                            if (settings.gameObject.name == "Background" && Utils.GetGameObjectPath(settings.gameObject).Contains("ModSettingsTopExpando"))
                            {
                                settings.color = new Color(1, 0, 1, 0.5736f);
                            }
                        }
                    }
                }
            }
            yield break;
        }
        internal static IEnumerator ChangeColour()
        {
            if (!PatchManager.loggedin)
            {
                if (ForbiddenMain.Background != null)
                {
                    try
                    {
                        if (GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background").gameObject.scene.name == "DontDestroyOnLoad")
                        {
                            GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background").GetComponent<Image>().sprite = ForbiddenMain.Background;
                            GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background").GetComponent<Image>().overrideSprite = ForbiddenMain.Background;
                            GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background").GetComponent<Image>().color = new Color(0.02f, 0.26f, 1, 0.473f);
                        }
                    }
                    catch { }
                }

                foreach (var buttons in UnityEngine.Resources.FindObjectsOfTypeAll<Button>())
                {
                    if (buttons.gameObject.scene.name == "DontDestroyOnLoad")
                    {
                        if (Utils.GetGameObjectPath(buttons.gameObject).Contains("UserInterface") && !Utils.GetGameObjectPath(buttons.gameObject).Contains("Canvas_QuickMenu(Clone)"))
                        {
                            ColorBlock cb = buttons.colors;
                            cb.m_NormalColor = new Color(Red, Green, Blue, 1);
                            cb.m_PressedColor = new Color(Red, Green, Blue, 0.2f);
                            cb.m_HighlightedColor = new Color(Red, Green, Blue, 0.5f);
                            cb.m_DisabledColor = new Color(Red, Green, Blue, 0.1f);
                            cb.m_SelectedColor = new Color(Red, Green, Blue, 0.5f);
                            buttons.colors = cb;
                        }
                    }
                }

                foreach (var settings in UnityEngine.Resources.FindObjectsOfTypeAll<Image>())
                {
                    if (settings.gameObject.scene.name == "DontDestroyOnLoad")
                    {
                        if (Utils.GetGameObjectPath(settings.gameObject).Contains("Settings") &&
                            settings.gameObject.name != "SettingsButton" && settings.gameObject.name != "SelectPrevMic" && settings.gameObject.name != "SelectNextMic" && settings.gameObject.name != "Button_ClearChanges" && settings.gameObject.name != "Exit" && settings.gameObject.name != "Logout" && settings.gameObject.name != "UpgradeAccount" && settings.gameObject.gameObject.name != "SettingsPageTab" && settings.gameObject.name != "ExpandButton" && settings.gameObject.name != "Button_EditBindings" && settings.gameObject.name != "Button_AdvancedOptions")
                        {
                            settings.color = new Color(Red, Green, Blue, 0.5f);
                            if (settings.gameObject.name.Contains("Panel") &&
                                !settings.gameObject.name.Contains("Panel_Header"))
                            {
                                settings.color = new Color(0, 0, 0, 0.5725f);
                            }

                            try
                            {
                                if (settings.gameObject.name.Contains("Volume"))
                                {
                                    ColorBlock uwu = settings.gameObject.GetComponent<Slider>().colors;
                                    uwu.m_NormalColor = new Color(Red, Green, Blue, 0.7f);
                                    uwu.m_HighlightedColor = new Color(0.5f, 0.5f, 0.5f, 1);
                                    uwu.m_PressedColor = new Color(0.5f, 0.5f, 0.5f, 1);
                                    uwu.m_SelectedColor = new Color(Red, Green, Blue, 0.7f);
                                    uwu.m_DisabledColor = new Color(Red, Green, Blue, 0.7f);
                                    settings.gameObject.GetComponent<Slider>().colors = uwu;
                                    settings.color = new Color(1, 1, 1, 1);
                                }
                            }
                            catch
                            {
                            }

                            GameObject.Find("UserInterface/MenuContent/Screens/Settings/UserVolumeOptions").GetComponent<Image>().color = new Color(0, 0, 0, 0.5725f);
                            if (settings.gameObject.name == "Checkmark")
                            {
                                settings.color = new Color(0, 0, 0, 1);
                                var parent = settings.gameObject.transform.parent;
                                parent.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                            }

                            if (Utils.GetGameObjectPath(settings.gameObject).Contains("Toggle") &&
                                settings.gameObject.name != "Checkmark" || settings.gameObject.name == "Background" &&
                                !Utils.GetGameObjectPath(settings.gameObject).Contains("SensitivitySlider") &&
                                !Utils.GetGameObjectPath(settings.gameObject).Contains("VolumeDisplay"))
                            {
                                settings.color = new Color(1, 1, 1, 1);
                            }

                            if (settings.gameObject.name == "Background" && Utils.GetGameObjectPath(settings.gameObject).Contains("ModSettingsTopExpando"))
                            {
                                settings.color = new Color(Red, Green, Blue, 0.5736f);
                            }
                        }
                    }
                }
            }
            yield break;
        }

        internal static void Thread()
        {
                if (action == "Apply")
                {
                    try
                    {
                        foreach (var buttons in UnityEngine.Resources.FindObjectsOfTypeAll<Button>())
                        {
                            if (buttons.gameObject.scene.name == "DontDestroyOnLoad")
                            {
                                if (Utils.GetGameObjectPath(buttons.gameObject).Contains("UserInterface"))
                                {
                                    ColorBlock cb = buttons.colors;
                                    cb.m_NormalColor = new Color(Red, Green, Blue, 1);
                                    cb.m_PressedColor = new Color(Red, Green, Blue, 0.2f);
                                    cb.m_HighlightedColor = new Color(Red, Green, Blue, 0.5f);
                                    cb.m_DisabledColor = new Color(Red, Green, Blue, 0.1f);
                                    cb.m_SelectedColor = new Color(Red, Green, Blue, 0.5f);
                                    buttons.colors = cb;
                                }
                            }
                        }

                        foreach (var settings in UnityEngine.Resources.FindObjectsOfTypeAll<Image>())
                        {
                            if (settings.gameObject.scene.name == "DontDestroyOnLoad")
                            {
                                if (Utils.GetGameObjectPath(settings.gameObject).Contains("Settings") &&
                                    settings.gameObject.name != "SettingsButton" && settings.gameObject.name != "SelectPrevMic" && settings.gameObject.name != "SelectNextMic" && settings.gameObject.name != "Button_ClearChanges" && settings.gameObject.name != "Exit" && settings.gameObject.name != "Logout" && settings.gameObject.name != "UpgradeAccount" && settings.gameObject.gameObject.name != "SettingsPageTab" && settings.gameObject.name != "ExpandButton" && settings.gameObject.name != "Button_EditBindings" && settings.gameObject.name != "Button_AdvancedOptions")
                                {
                                    settings.color = new Color(Red, Green, Blue, 0.5f);
                                    if (settings.gameObject.name.Contains("Panel") &&
                                        !settings.gameObject.name.Contains("Panel_Header"))
                                    {
                                        settings.color = new Color(0, 0, 0, 0.5725f);
                                    }

                                    try
                                    {
                                        if (settings.gameObject.name.Contains("Volume"))
                                        {
                                            ColorBlock uwu = settings.gameObject.GetComponent<Slider>().colors;
                                            uwu.m_NormalColor = new Color(Red, Green, Blue, 0.7f);
                                            uwu.m_HighlightedColor = new Color(0.5f, 0.5f, 0.5f, 1);
                                            uwu.m_PressedColor = new Color(0.5f, 0.5f, 0.5f, 1);
                                            uwu.m_SelectedColor = new Color(Red, Green, Blue, 0.7f);
                                            uwu.m_DisabledColor = new Color(Red, Green, Blue, 0.7f);
                                            settings.gameObject.GetComponent<Slider>().colors = uwu;
                                            settings.color = new Color(1, 1, 1, 1);
                                        }
                                    }
                                    catch { }

                                    GameObject.Find("UserInterface/MenuContent/Screens/Settings/UserVolumeOptions").GetComponent<Image>().color = new Color(0, 0, 0, 0.5725f);
                                    if (settings.gameObject.name == "Checkmark")
                                    {
                                        settings.color = new Color(0, 0, 0, 1);
                                        var parent = settings.gameObject.transform.parent;
                                        parent.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                                    }

                                    if (Utils.GetGameObjectPath(settings.gameObject).Contains("Toggle") &&
                                        settings.gameObject.name != "Checkmark" || settings.gameObject.name == "Background" &&
                                        !Utils.GetGameObjectPath(settings.gameObject).Contains("SensitivitySlider") &&
                                        !Utils.GetGameObjectPath(settings.gameObject).Contains("VolumeDisplay"))
                                    {
                                        settings.color = new Color(1, 1, 1, 1);
                                    }

                                    if (settings.gameObject.name == "Background" && Utils.GetGameObjectPath(settings.gameObject).Contains("ModSettingsTopExpando"))
                                    {
                                        settings.color = new Color(Red, Green, Blue, 0.5736f);
                                    }
                                }
                            }
                        }
                    }
                    catch { }
                }
                else
                {
                    try
                    {
                        foreach (var buttons in UnityEngine.Resources.FindObjectsOfTypeAll<Button>())
                        {
                            if (buttons.gameObject.scene.name == "DontDestroyOnLoad")
                            {
                                if (Utils.GetGameObjectPath(buttons.gameObject).Contains("UserInterface") && !Utils.GetGameObjectPath(buttons.gameObject).Contains("Canvas_QuickMenu(Clone)"))
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

                        foreach (var settings in UnityEngine.Resources.FindObjectsOfTypeAll<Image>())
                        {
                            if (settings.gameObject.scene.name == "DontDestroyOnLoad")
                            {
                                if (Utils.GetGameObjectPath(settings.gameObject).Contains("Settings") &&
                                    settings.gameObject.name != "SettingsButton" && settings.gameObject.name != "SelectPrevMic" && settings.gameObject.name != "SelectNextMic" && settings.gameObject.name != "Button_ClearChanges" && settings.gameObject.name != "Exit" && settings.gameObject.name != "Logout" && settings.gameObject.name != "UpgradeAccount" && settings.gameObject.gameObject.name != "SettingsPageTab" && settings.gameObject.name != "ExpandButton" && settings.gameObject.name != "Button_EditBindings" && settings.gameObject.name != "Button_AdvancedOptions")
                                {
                                    settings.color = new Color(0.4f, 0, 0.32f, 0.5f);
                                    if (settings.gameObject.name.Contains("Panel") &&
                                        !settings.gameObject.name.Contains("Panel_Header"))
                                    {
                                        settings.color = new Color(0, 0, 0, 0.5725f);
                                    }

                                    try
                                    {
                                        if (settings.gameObject.name.Contains("Volume"))
                                        {
                                            ColorBlock uwu = settings.gameObject.GetComponent<Slider>().colors;
                                            uwu.m_NormalColor = new Color(1, 0, 0.8f, 0.7f);
                                            uwu.m_HighlightedColor = new Color(0.5f, 0.5f, 0.5f, 1);
                                            uwu.m_PressedColor = new Color(0.5f, 0.5f, 0.5f, 1);
                                            uwu.m_SelectedColor = new Color(1, 0, 0.8f, 0.7f);
                                            uwu.m_DisabledColor = new Color(1, 0, 0.8f, 0.7f);
                                            settings.gameObject.GetComponent<Slider>().colors = uwu;
                                            settings.color = new Color(1, 1, 1, 1);
                                        }
                                    }
                                    catch
                                    {
                                    }

                                    GameObject.Find("UserInterface/MenuContent/Screens/Settings/UserVolumeOptions")
                                        .GetComponent<Image>().color = new Color(0, 0, 0, 0.5725f);
                                    if (settings.gameObject.name == "Checkmark")
                                    {
                                        settings.color = new Color(0, 0, 0, 1);
                                        var parent = settings.gameObject.transform.parent;
                                        parent.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                                    }

                                    if (Utils.GetGameObjectPath(settings.gameObject).Contains("Toggle") &&
                                        settings.gameObject.name != "Checkmark" || settings.gameObject.name == "Background" &&
                                        !Utils.GetGameObjectPath(settings.gameObject).Contains("SensitivitySlider") &&
                                        !Utils.GetGameObjectPath(settings.gameObject).Contains("VolumeDisplay"))
                                    {
                                        settings.color = new Color(1, 1, 1, 1);
                                    }

                                    if (settings.gameObject.name == "Background" && Utils.GetGameObjectPath(settings.gameObject).Contains("ModSettingsTopExpando"))
                                    {
                                        settings.color = new Color(1, 0, 1, 0.5736f);
                                    }
                                }
                            }
                        }
                    }
                    catch { }
                }
        }
    }
}
