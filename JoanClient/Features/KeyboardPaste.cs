using MelonLoader;
using UnityEngine;
using System;
using System.Collections;
using System.Reflection;
using System.Linq;
using UnityEngine.UI;

namespace JoanpixerClient.Features
{
    class KeyPaste
    {
        private GameObject keybardPasteButton;

        public void OnApplicationStart() // Runs after Game Initialization.
        {
            MelonCoroutines.Start(GetAssembly());
        }

        private void OnUiManagerInit() => MelonCoroutines.Start(CreateButton());

        public void OnPreferencesSaved()
        {
            if (keybardPasteButton == null)
                MelonCoroutines.Start(CreateButton(true));
            else if (keybardPasteButton != null)
            {
                GameObject.Destroy(keybardPasteButton);
            }
        }

        private IEnumerator CreateButton(bool ignoreWait = false)
        {
            if (!ignoreWait) yield return new WaitForSeconds(8f);
            try
            {
                // Hey skids, if you're gonna take this and add to your mod, at least give me some credit. Much appreciated!
                keybardPasteButton = UnityEngine.Object.Instantiate<GameObject>(GameObject.Find("/UserInterface/MenuContent/Popups/InputPopup/ButtonLeft"), VRCUiPopupManager.field_Public_VRCUiPopupInput_0.transform);
                keybardPasteButton.GetComponent<RectTransform>().anchoredPosition = new Vector2(335f, -275f);
                keybardPasteButton.GetComponentInChildren<Text>().text = "Paste";
                keybardPasteButton.name = "KeyboardPasteButton";
                keybardPasteButton.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
                keybardPasteButton.GetComponent<Button>().m_Interactable = true;
                keybardPasteButton.GetComponent<Button>().onClick.AddListener(new Action(() =>
                {
                    try
                    {
                        if (GUIUtility.systemCopyBuffer.Length < 256)
                        {
                            GameObject.Find("UserInterface/MenuContent/Popups/InputPopup/InputField").GetComponent<InputField>().text = GUIUtility.systemCopyBuffer;
                        }
                        else MelonLogger.Warning("You cannot paste something more than 256 characters long in the keyboard.");
                    }
                    catch (Exception e) { MelonLogger.Error("An error has occurred:\n" + e.ToString()); }
                }));
            }
            catch (Exception e)
            {
                MelonLogger.Error("Keyboard Paste Button failure:\n" + e.ToString());
            }
            yield break;
        }

        public VRCUiPopupManager VRCUiPopupManager
        {
            get { return VRCUiPopupManager.field_Private_Static_VRCUiPopupManager_0; }
        }

        private IEnumerator GetAssembly()
        {
            Assembly assemblyCSharp = null;
            while (true)
            {
                assemblyCSharp = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(assembly => assembly.GetName().Name == "Assembly-CSharp");
                if (assemblyCSharp == null)
                    yield return null;
                else
                    break;
            }

            MelonCoroutines.Start(WaitForUiManagerInit(assemblyCSharp));
        }

        private IEnumerator WaitForUiManagerInit(Assembly assemblyCSharp)
        {
            Type vrcUiManager = assemblyCSharp.GetType("VRCUiManager");
            PropertyInfo uiManagerSingleton = vrcUiManager.GetProperties().First(pi => pi.PropertyType == vrcUiManager);
            while (uiManagerSingleton.GetValue(null) == null)
                yield return null;
            OnUiManagerInit();
        }
    }
}