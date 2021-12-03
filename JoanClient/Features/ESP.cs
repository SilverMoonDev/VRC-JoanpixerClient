using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC;
using VRC.Core;

namespace JoanpixerClient.Features
{
    internal class HighlightsComponent
    {
        public static bool ESPEnabled = false;
        private static HighlightsFXStandalone _friendsHighlights;
        private static HighlightsFXStandalone _othersHighlights;
        private static HighlightsFXStandalone _pickupHighlights;
        private static HighlightsFXStandalone GetHighlightsFX(APIUser apiUser)
        {
            if (APIUser.IsFriendsWith(apiUser.id) && Worlds.Murder4.worldLoaded && Worlds.Murder4.MurderText.GetComponent<Text>().text == apiUser.displayName)
                return _pickupHighlights;
            else if (APIUser.IsFriendsWith(apiUser.id))
                return _friendsHighlights;
            if (Worlds.Murder4.worldLoaded)
                if (Worlds.Murder4.MurderText.GetComponent<Text>().text == apiUser.displayName)
                    return _pickupHighlights;
            return _othersHighlights;
        }

        public void OnUiManagerInitEarly()
        {
            var highlightsFx = HighlightsFX.field_Private_Static_HighlightsFX_0;

            _friendsHighlights = highlightsFx.gameObject.AddComponent<HighlightsFXStandalone>();
            _friendsHighlights.highlightColor = Color.green;
            _othersHighlights = highlightsFx.gameObject.AddComponent<HighlightsFXStandalone>();
            _othersHighlights.highlightColor = Color.magenta;
            _pickupHighlights = highlightsFx.gameObject.AddComponent<HighlightsFXStandalone>();
            _pickupHighlights.highlightColor = Color.red;
        }
        public static void ToggleESP(bool enabled)
        {
            var playerManager = PlayerManager.field_Private_Static_PlayerManager_0;
            if (playerManager == null)
                return;

            foreach (var player in Utils.GetAllPlayers())
            {
                HighlightPlayer(player, enabled);
            }
        }

        public static void DisableESP()
        {
            var playerManager = PlayerManager.field_Private_Static_PlayerManager_0;
            if (playerManager == null)
                return;

            foreach (var player in Utils.GetAllPlayers())
            {
                DisableESPChecker(player);
            }
        }

        private static void DisableESPChecker(Player player)
        {
            if (player.field_Private_APIUser_0.IsSelf)
                return;

            var selectRegion = player.transform.Find("SelectRegion");
            if (selectRegion == null)
                return;

            _othersHighlights.Method_Public_Void_Renderer_Boolean_0(selectRegion.GetComponent<Renderer>(), false);
            _friendsHighlights.Method_Public_Void_Renderer_Boolean_0(selectRegion.GetComponent<Renderer>(), false);
            _pickupHighlights.Method_Public_Void_Renderer_Boolean_0(selectRegion.GetComponent<Renderer>(), false);
        }

        public static void HighlightPlayer(Player player, bool highlighted)
        {
            if (player.field_Private_APIUser_0.IsSelf)
                return;

            var selectRegion = player.transform.Find("SelectRegion");
            if (selectRegion == null)
                return;

            GetHighlightsFX(player.field_Private_APIUser_0).Method_Public_Void_Renderer_Boolean_0(selectRegion.GetComponent<Renderer>(), highlighted);
        }

        public static void PickupESP(bool on)
        {
            foreach (var Pickup in Resources.FindObjectsOfTypeAll<VRC.SDK3.Components.VRCPickup>())
            {
                Utils.ToggleOutline(Pickup.gameObject.GetComponent<Renderer>(), on);
                Utils.ToggleOutline(Pickup.gameObject.GetComponent<MeshRenderer>(), on);
            }
        }
    }
}