using MelonLoader;
using System;
using System.Collections;
using JoanpixerClient.Modules;
using UnityEngine;
using UnityEngine.UI;
using VRC.Core;

namespace JoanpixerClient.Features
{
    class ForceInvite
    {

        GameObject socialMenu;
        Image background;

        public void Start()
        {
            MelonCoroutines.Start(UiManagerInitializer());
        }

        public IEnumerator UiManagerInitializer()
        {
            while (VRCUiManager.prop_VRCUiManager_0 == null) yield return null;

            socialMenu = GameObject.Find("UserInterface/MenuContent/Screens/Social");
            background = GameObject.Find("UserInterface/MenuContent/Backdrop/Backdrop/Background").GetComponent<Image>();

            GameObject userInfo = GameObject.Find("UserInterface/MenuContent/Screens/UserInfo");
            Button button = GameObject.Find("UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons/Invite").GetComponent<Button>();

            userInfo.AddComponent<EnableDisableListener>().OnEnabled += () => {
                MelonCoroutines.Start(delayRun(() => {
                    if (RoomManager.field_Internal_Static_ApiWorldInstance_0?.type == InstanceAccessType.InvitePlus || RoomManager.field_Internal_Static_ApiWorldInstance_0?.type == InstanceAccessType.InviteOnly)
                    {
                        button.interactable = true;
                        button.m_Interactable = true;
                    }
                }));
            };
        }

        public IEnumerator delayRun(Action action)
        {
            yield return new WaitForSeconds(0.1f);

            if (socialMenu.active)
                while (socialMenu.active == true)
                    yield return null;

            if (background.color.a < 0.9)
                while (background.color.a < 0.9)
                    yield return null;

            action.Invoke();
        }

    }
}