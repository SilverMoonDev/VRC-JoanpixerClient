using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Il2CppSystem.Collections.Generic;
using JoanpixerClient.Wrappers;
using UnityEngine;
using VRC;
using System.Collections.Generic;
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
