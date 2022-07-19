using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnhollowerRuntimeLib.XrefScans;

namespace ForbiddenClient.API
{
    internal static class Popups
    {
        public delegate void ShowStandardPopupV21Fn(VRCUiPopupManager popupManager, string title, string body, string buttonText, Il2CppSystem.Action onClick, Il2CppSystem.Action<VRCUiPopup> additionalSetup = null);

        private static ShowStandardPopupV21Fn _showStandardPopupV21Fn;

        private static ShowStandardPopupV21Fn ShowUiStandardPopupV21
        {
            get
            {
                if (_showStandardPopupV21Fn != null)
                {
                    return _showStandardPopupV21Fn;
                }
                var methodInfo = typeof(VRCUiPopupManager).GetMethods(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault(it => {
                    if (it.GetParameters().Length == 5 && !it.Name.Contains("PDM"))
                    {
                        return XrefScanner.XrefScan(it).Any(delegate (XrefInstance jt)
                        {
                            if (jt.Type != XrefType.Global) return false;
                            var @object = jt.ReadAsObject();
                            return @object?.ToString() == "UserInterface/MenuContent/Popups/StandardPopupV2";
                        });
                    }
                    return false;
                });
                _showStandardPopupV21Fn = (ShowStandardPopupV21Fn)Delegate.CreateDelegate(typeof(ShowStandardPopupV21Fn), methodInfo);
                return _showStandardPopupV21Fn;
            }
        }

        internal static void ShowConfirmPopup(string title, string message, string oktext, Action okaction, string canceltext, Action cancelaction)
        {
            VRCUiPopupManager.field_Private_Static_VRCUiPopupManager_0.ShowStandardPopupV2(title, message, oktext, okaction, canceltext, cancelaction, null);
        }

        public static void ShowStandardPopupV2(this VRCUiPopupManager popupManager, string title, string body, string buttonText,
            Action onClick, Action<VRCUiPopup> onCreated = null)
        {
            ShowUiStandardPopupV21(popupManager, title, body, buttonText, onClick, onCreated);
        }

        public static void ShowStandardPopupV2(this VRCUiPopupManager popupManager, string title, string body, string leftButtonText,
            Action leftButtonAction, string rightButtonText, Action rightButtonAction,
            Action<VRCUiPopup> additonalSetup)
        {
            popupManager.Method_Public_Void_String_String_String_Action_String_Action_Action_1_VRCUiPopup_0(title, body, leftButtonText, leftButtonAction, rightButtonText, rightButtonAction, additonalSetup);
        }

        public static void HideCurrentPopup(this VRCUiPopupManager vrcUiPopupManager)
        {
            VRCUiManagerEx.Instance.HideScreen("POPUP");
        }
    }
    internal class VRCUiManagerEx
    {
        private static VRCUiManager _uiManagerInstance;

        public static VRCUiManager Instance
        {
            get
            {
                if (_uiManagerInstance == null)
                {
                    _uiManagerInstance = (VRCUiManager)typeof(VRCUiManager).GetMethods().First(x => x.ReturnType == typeof(VRCUiManager)).Invoke(null, new object[0]);
                }

                return _uiManagerInstance;
            }
        }

        public static bool IsOpen => Instance.field_Private_Boolean_0;
    }
}
