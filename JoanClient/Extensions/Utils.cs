using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using MelonLoader;
using VRC.SDKBase;
using VRC.UI.Elements;
using VRC.UI.Elements.Menus;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using Il2CppSystem.Collections.Generic;

namespace JoanpixerClient
{
    class Utils
    {

        private static QuickMenu _quickMenuInstance;

        private static SelectedUserMenuQM _selectedUserLocal;

        public static QuickMenu Instance
        {
            get
            {
                if (_quickMenuInstance == null)
                {
                    _quickMenuInstance = GameObject.Find("UserInterface").GetComponentInChildren<QuickMenu>(true);
                }
                return _quickMenuInstance;
            }
        }

        internal static Player GetCurrentlySelectedPlayer()
        {
            if (GameObject.Find("UserInterface").GetComponentInChildren<SelectedUserMenuQM>() == null)
            {
                return null;
            }

            return GetPlayerFromIDInLobby(GameObject.Find("UserInterface").gameObject.GetComponentInChildren<SelectedUserMenuQM>().field_Private_IUser_0.prop_String_0);
        }

        public static SelectedUserMenuQM SelectedUserLocal
        {
            get
            {
                if (Utils._selectedUserLocal == null)
                {
                    Utils._selectedUserLocal = Utils.Instance.field_Public_Transform_0.Find("Window/QMParent/Menu_SelectedUser_Local").GetComponent<SelectedUserMenuQM>();
                }
                return Utils._selectedUserLocal;
            }
        }
        public static bool IsWorldLoaded => Resources.FindObjectsOfTypeAll<VRC_SceneDescriptor>() != null;

        /// <summary>
        /// Returns the local VRCPlayer.
        /// </summary>
        public static VRCPlayer GetLocalPlayer()
        {
            return VRCPlayer.field_Internal_Static_VRCPlayer_0;
        }

        public static Vector3 TPLocalPlayer(Vector3 position)
        {
            return GetLocalPlayer().transform.position = position;
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

        internal static Player GetPlayerFromIDInLobby(string id)
        {
            Il2CppSystem.Collections.Generic.List<Player> all_player = GetAllPlayers();

            foreach (var player in all_player)
            {
                if (player != null && player.prop_APIUser_0 != null)
                {
                    if (player.prop_APIUser_0.id == id)
                    {
                        return player;
                    }
                }
            }

            return null;
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

        public static string GetGameObjectPathWithObjectName(GameObject obj)
        {
            string path = "/" + obj.name;
            while (obj.transform.parent != null)
            {
                obj = obj.transform.parent.gameObject;
                path = "/" + obj.name + path;
            }
            return path;
        }

        public static string GetGameObjectPath(GameObject obj)
        {
            string path = "/";
            while (obj.transform.parent != null)
            {
                obj = obj.transform.parent.gameObject;
                path = "/" + obj.name + path;
            }
            return path;
        }

        public class Serialization
        {
            public static byte[] ToByteArray(Il2CppSystem.Object obj)
            {
                if (obj == null) return null;
                var bf = new Il2CppSystem.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                var ms = new Il2CppSystem.IO.MemoryStream();
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
            public static byte[] ToByteArray(object obj)
            {
                if (obj == null) return null;
                var bf = new BinaryFormatter();
                var ms = new MemoryStream();
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }

            public static T FromByteArray<T>(byte[] data)
            {
                if (data == null) return default(T);
                BinaryFormatter bf = new BinaryFormatter();
                using (MemoryStream ms = new MemoryStream(data))
                {
                    object obj = bf.Deserialize(ms);
                    return (T)obj;
                }
            }
            public static T IL2CPPFromByteArray<T>(byte[] data)
            {
                if (data == null) return default(T);
                var bf = new Il2CppSystem.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                var ms = new Il2CppSystem.IO.MemoryStream(data);
                object obj = bf.Deserialize(ms);
                return (T)obj;
            }

            public static T FromIL2CPPToManaged<T>(Il2CppSystem.Object obj)
            {
                return FromByteArray<T>(ToByteArray(obj));
            }

            public static T FromManagedToIL2CPP<T>(object obj)
            {
                return IL2CPPFromByteArray<T>(ToByteArray(obj));
            }

            public static object[] FromIL2CPPArrayToManagedArray(Il2CppSystem.Object[] obj)
            {
                object[] Parameters = new object[obj.Length];
                for (int i = 0; i < obj.Length; i++)
                    Parameters[i] = FromIL2CPPToManaged<object>(obj[i]);
                return Parameters;
            }
            public static Il2CppSystem.Object[] FromManagedArrayToIL2CPPArray(object[] obj)
            {
                Il2CppSystem.Object[] Parameters = new Il2CppSystem.Object[obj.Length];
                for (int i = 0; i < obj.Length; i++)
                    Parameters[i] = FromManagedToIL2CPP<Il2CppSystem.Object>(obj[i]);
                return Parameters;
            }
        }

        public static IEnumerator Notification(string Text, Color color)
        {
            var hudRoot = GameObject.Find("UserInterface/UnscaledUI/HudContent/Hud");
            var requestedParent = hudRoot.transform.Find("NotificationDotParent");
            var indicator = UnityEngine.Object.Instantiate(hudRoot.transform.Find("NotificationDotParent/NotificationDot").gameObject, requestedParent, false).Cast<GameObject>();
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
            text.color = color;
            gameObject.SetActive(true);
            text.text = Text;
            MelonCoroutines.Start(FadeTextToFullAlpha(2, text));
            yield return new WaitForSeconds(3);
            MelonCoroutines.Start(FadeTextToZeroAlpha(4, text));
            yield return new WaitForSeconds(5);
            UnityEngine.Object.Destroy(indicator);
        }

        public static IEnumerator FadeTextToFullAlpha(float t, Text i)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
            while (i.color.a < 1.0f)
            {
                i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
                yield return null;
            }
        }

        public static IEnumerator FadeTextToZeroAlpha(float t, Text i)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
            while (i.color.a > 0.0f)
            {
                i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
                yield return null;
            }
        }

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
