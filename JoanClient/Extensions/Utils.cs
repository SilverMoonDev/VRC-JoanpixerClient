﻿using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using System.Collections.Generic;
using JoanpixerClient.Features.Worlds;
using MelonLoader;
using VRC.Core;

namespace JoanpixerClient
{
    class Utils
    {
        /// <summary>
        /// Returns the local VRCPlayer.
        /// </summary>
        public static VRCPlayer GetLocalPlayer()
        {
            return VRCPlayer.field_Internal_Static_VRCPlayer_0;
        }

        /// <summary>
        /// Returns a list of active players.
        /// </summary>
        public static Il2CppSystem.Collections.Generic.List<Player> GetAllPlayers()
        {
            // Make sure the PlayerManager exists first.
            if (PlayerManager.field_Private_Static_PlayerManager_0 == null)
            {
                return null;
            }

            return PlayerManager.field_Private_Static_PlayerManager_0?.field_Private_List_1_Player_0;
        }

        public static VRCPlayer CurrentUser
        {
            get
            {
                return VRCPlayer.field_Internal_Static_VRCPlayer_0;
            }
            set
            {
                CurrentUser = CurrentUser;
            }
        }

        public static void SelectYourself()
        {
            Wrappers.GetQuickMenu().SelectPlayer(GetLocalPlayer().prop_Player_0);
        }

        /// <summary>
        /// Get a player object out of the specified player id.
        /// </summary>
        /// <param name="playerId">The player id to fetch.</param>
        public static Player GetPlayer(string playerId)
        {
            var players = GetAllPlayers();

            foreach (Player player in players)
            {
                // Make sure the player is valid first.
                if (player == null)
                {
                    continue;
                }

                if (player.field_Private_APIUser_0.id == playerId)
                {
                    return player;
                }
            }

            return null;
        }

        public static string GetGameObjectPath(GameObject obj)
        {
            string path = "/" + obj.name;
            while (obj.transform.parent != null)
            {
                obj = obj.transform.parent.gameObject;
                path = "/" + obj.name + path;
            }
            return path;
        }

        public static QuickMenu quickmenuuser = null;

        public static QuickMenu GetQuickMenuInstance()
        {
            if (quickmenuuser == null)
            {
                quickmenuuser = QuickMenu.prop_QuickMenu_0;
            }
            return quickmenuuser;
        }

        public static QuickMenu QuickMenu
        {
            get
            {
                return QuickMenu.prop_QuickMenu_0;
            }
        }

        private const string sound = "Joanpixer/JN-Join.ogg";

        public static IEnumerator Notification(string Text)
        {
            var hudRoot = GameObject.Find("UserInterface/UnscaledUI/HudContent/Hud");
            var requestedParent = hudRoot.transform.Find("NotificationDotParent");
            var indicator = Object.Instantiate(hudRoot.transform.Find("NotificationDotParent/NotificationDot").gameObject, requestedParent, false).Cast<GameObject>();
            indicator.name = "NotifyDot-" + "Murderer";
            indicator.GetComponent<Image>().enabled = false;
            indicator.SetActive(true);
            indicator.transform.localPosition += Vector3.right * 200;
            var gameObject = new GameObject(indicator.gameObject.name + "-text");
            gameObject.AddComponent<Text>();
            gameObject.transform.SetParent(indicator.transform, false);
            gameObject.transform.localScale = Vector3.one;
            gameObject.transform.localPosition = Vector3.up * 400;
            var text = gameObject.GetComponent<Text>();
            text.color = Color.white;
            text.fontStyle = FontStyle.Bold;
            text.horizontalOverflow = HorizontalWrapMode.Overflow;
            text.verticalOverflow = VerticalWrapMode.Overflow;
            text.alignment = TextAnchor.MiddleCenter;
            text.fontSize = 34;
            text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            text.supportRichText = true;
            text.color = new Color(1, 0, 0, 0);
            gameObject.SetActive(true);
            text.text = Text;
            MelonCoroutines.Start(FadeTextToFullAlpha(2, text));
            yield return new WaitForSeconds(3);
            MelonCoroutines.Start(FadeTextToZeroAlpha(4, text));
            yield return new WaitForSeconds(5);
            Object.Destroy(indicator);
        }

        public static System.Collections.IEnumerator FadeTextToFullAlpha(float t, Text i)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
            while (i.color.a < 1.0f)
            {
                i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
                yield return null;
            }
        }

        public static System.Collections.IEnumerator FadeTextToZeroAlpha(float t, Text i)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
            while (i.color.a > 0.0f)
            {
                i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
                yield return null;
            }
        }

        public static VRCPlayer GetSelectedPlayer() { return GetQuickMenuInstance().field_Private_Player_0._vrcplayer; }

        public static void ToggleOutline(Renderer renderer, bool state)
        {
            if (HighlightsFX.prop_HighlightsFX_0 == null)
            {
                return;
            }
            HighlightsFX.prop_HighlightsFX_0.Method_Public_Void_Renderer_Boolean_0(renderer, state);
        }
        
    }
}
