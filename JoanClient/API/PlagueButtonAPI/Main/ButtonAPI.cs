using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using ForbiddenClient;
using Harmony;
using MelonLoader;
using ForbiddenButtonAPI.Main;
using ForbiddenButtonAPI.Misc;
using ForbiddenButtonAPI.Pages;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;

namespace ForbiddenButtonAPI
{
    public class ButtonAPI : MelonLoaderEvents
    {
        public static List<MenuPage> AllCreatedPages = new List<MenuPage>();

        public static GameObject singleButtonBase;

        public static GameObject toggleButtonBase;

        public static GameObject buttonGroupBase;

        public static GameObject buttonGroupHeaderBase;

        public static GameObject menuPageBase;

        public static GameObject menuTabBase;

        public static GameObject wingSingleButtonBase;

        public static GameObject sliderBase;

        public static GameObject userinterface;

        public static Sprite onIconSprite;

        public static Sprite xIconSprite;

        public static bool HasInit;

        public static bool PauseInit;

        public static VRC.UI.Elements.QuickMenu GetQuickMenuInstance()
        {
            return Resources.FindObjectsOfTypeAll<VRC.UI.Elements.QuickMenu>().FirstOrDefault();
        }

        public static MenuStateController GetMenuStateControllerInstance()
        {
            return Resources.FindObjectsOfTypeAll<VRC.UI.Elements.QuickMenu>().FirstOrDefault()?.gameObject.GetOrAddComponent<MenuStateController>();
        }

        public static GameObject GetEyeCamera()
        {
            return GameObject.Find("Camera (eye)");
        }

        public override void OnUiManagerInit()
        {
            MelonCoroutines.Start(WaitForQMClone());
        }

        internal static string[] Nono;

        internal static GameObject QuickMenuObj;


        [HarmonyShield]
        [PatchShield]
        internal static IEnumerator WaitForQMClone()
        {

            yield return new WaitForSeconds(2f);

            userinterface = GetQuickMenuInstance().transform.parent.gameObject;


            while (userinterface?.transform?.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/")?.gameObject == null || userinterface?.transform?.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Wing_Left/Container/InnerContainer/WingMenu/ScrollRect/Viewport/VerticalLayoutGroup/Button_Explore")?.gameObject == null || GetMenuStateControllerInstance() == null)
            {
                yield return new WaitForEndOfFrame();
            }

            yield return new WaitForSeconds(4f); // Just In Case!


            singleButtonBase = userinterface.transform.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn")?.gameObject;

            if (singleButtonBase == null)
            {
                MelonLogger.Error("singleButtonBase == null!");
            }

            toggleButtonBase = userinterface.transform.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_ToggleQMInfo")?.gameObject;

            if (toggleButtonBase == null)
            {
                MelonLogger.Error("toggleButtonBase == null!");
            }

            buttonGroupBase = userinterface.transform.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions")?.gameObject;

            if (buttonGroupBase == null)
            {
                MelonLogger.Error("buttonGroupBase == null!");
            }

            buttonGroupHeaderBase = userinterface.transform.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/QM_Foldout_UI_Elements")?.gameObject;

            if (buttonGroupHeaderBase == null)
            {
                MelonLogger.Error("buttonGroupHeaderBase == null!");
            }

            menuPageBase = userinterface.transform.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard")?.gameObject;

            if (menuPageBase == null)
            {
                MelonLogger.Error("menuPageBase == null!");
            }

            menuTabBase = userinterface.transform.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings")?.gameObject;

            if (menuTabBase == null)
            {
                MelonLogger.Error("menuTabBase == null!");
            }

            wingSingleButtonBase = userinterface.transform.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Wing_Left/Container/InnerContainer/WingMenu/ScrollRect/Viewport/VerticalLayoutGroup/Button_Explore")?.gameObject;

            if (wingSingleButtonBase == null)
            {
                MelonLogger.Error("wingSingleButtonBase == null!");
            }

            sliderBase = userinterface.transform.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_AudioSettings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Audio/Audio/VolumeSlider_Master")?.gameObject;

            if (sliderBase == null)
            {
                MelonLogger.Error("sliderBase == null!");
            }

            //For Toggles
            onIconSprite = userinterface.transform.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Notifications/Panel_NoNotifications_Message/Icon")?.GetComponent<Image>()?.sprite;

            if (onIconSprite == null)
            {
                MelonLogger.Error("onIconSprite == null!");
            }

            xIconSprite = userinterface.transform.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Here/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_WorldActions/Button_FavoriteWorld/Icon_Secondary")?.GetComponent<Image>()?.sprite;

            if (xIconSprite == null)
            {
                MelonLogger.Error("xIconSprite == null!");
            }

            OnInit?.Invoke();

            HasInit = true;

            yield break;

        }

        public static event Action OnInit;
    }

    /// <summary>
    ///   A Component For Hooking To Generic Events Such As A Object Becoming Enabled, Disabled, Destroyed And For Events Such
    ///   As Update.
    /// </summary>
    [RegisterTypeInIl2Cpp]
    public class ObjectHandler : MonoBehaviour
    {
        private bool IsEnabled;
        public Action<GameObject> OnDestroyed = null;
        public Action<GameObject> OnDisabled = null;

        public Action<GameObject> OnEnabled = null;
        public Action<GameObject, bool> OnUpdate = null;
        public Action<GameObject, bool> OnUpdateEachSecond = null;
        private float UpdateDelay = 0f;

        public ObjectHandler(IntPtr instance) : base(instance)
        {
        }

        private void OnEnable()
        {
            if (gameObject.active)
            {
                OnEnabled?.Invoke(gameObject);
                IsEnabled = true;
            }
        }

        private void OnDisable()
        {
            if (!gameObject.active)
            {
                OnDisabled?.Invoke(gameObject);
                IsEnabled = false;
            }
        }

        private void OnDestroy()
        {
            OnDestroyed?.Invoke(gameObject);
        }

        private void Update()
        {
            OnUpdate?.Invoke(gameObject, IsEnabled);

            if (UpdateDelay < Time.time)
            {
                UpdateDelay = Time.time + 1f;

                OnUpdateEachSecond?.Invoke(gameObject, IsEnabled);
            }
        }
    }
}