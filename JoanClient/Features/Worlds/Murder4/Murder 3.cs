using VRC.Udon;
using UnityEngine;
using System.Collections;
using JoanpixerClient.Modules;
using VRC.SDKBase;

namespace JoanpixerClient.Features.Worlds
{
    class Murder3
    {
        public static bool worldLoaded = false;
        public static bool revolverspam = false;
        public static bool patreonself = false;
        public static bool givepatreon = false;
        public static bool pickupweapontoggle = false;
        public static bool CluesESP = false; 
        public static bool spamsounds = false;
        public static GameObject MurderText = null;
        public static UdonBehaviour gameLogic = null;
        public static UdonBehaviour fragudon = null;
        public static UdonBehaviour revolver = null;
        public static UdonBehaviour bomb = null;
        public static VRC_Pickup revolverpickup = null;


        public static void Initialize()
        {
            // TODO: Check world ID aswell.

            if (RoomManager.field_Internal_Static_ApiWorldInstance_0?.worldId == "wrld_726c8a44-8222-4858-8b33-49e70d495b62")
            {
                worldLoaded = true;
                MurderText = GameObject.Find("Game Logic/Game Canvas/Postgame/Murderer Name");
                Murder4Items.smokebomb = GameObject.Find("Game Logic/Weapons/Unlockables/Smoke (0)");
                Murder4Items.Beartrap = GameObject.Find("Game Logic/Weapons/Bear Trap (0)");
                Murder4Items.knife = GameObject.Find("Game Logic/Weapons/Sickle (0)");
                Murder4Items.revolverobject = GameObject.Find("Game Logic/Weapons/Revolver");
                Murder4Items.luger = GameObject.Find("Game Logic/Weapons/Unlockables/Luger (0)");
                Murder4Items.shotgun = GameObject.Find("Game Logic/Weapons/Unlockables/Shotgun (0)");
                Murder4Items.frag = GameObject.Find("Game Logic/Weapons/Unlockables/Frag (0)");
                fragudon = GameObject.Find("Game Logic/Weapons/Unlockables/Frag (0)")?.GetComponent<UdonBehaviour>();
                gameLogic = GameObject.Find("Game Logic")?.GetComponent<UdonBehaviour>();
                revolver = GameObject.Find("Game Logic/Weapons/Revolver")?.GetComponent<UdonBehaviour>();
                revolverpickup = Murder4Items.revolverobject.GetComponent<VRC_Pickup>();
            }
            else
            {
                worldLoaded = false;
            }
        }
        public static IEnumerator KillSelectedPlayerKnife(VRC.Player player)
        {
            if (!player.field_Private_VRCPlayerApi_0.gameObject) yield break;
            if (!Murder4Items.knife) yield break;
            var knifeoriginalpos = Murder4Items.knife.transform.position;
            Items.TakeOwnershipIfNecessary(Murder4Items.knife);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(-0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(-0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(-0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(-0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(-0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(-0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(-0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = knifeoriginalpos;
        }
        public static IEnumerator KillSelectedPlayerFrag(VRC.Player player)
        {
            if (!Murder4Items.frag) yield break;
            Items.TakeOwnershipIfNecessary(Murder4Items.frag);
            Udon.CallUdonEvent(fragudon, "SyncArm");
            yield return new WaitForSeconds(0.1f);
            Murder4Items.frag.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0.1f, 0.1f, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.frag.transform.position = player.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0.1f, 0.1f, 0);
            Udon.CallUdonEvent(fragudon, "Explode");
            yield return new WaitForSeconds(0.1f);
            Udon.CallUdonEvent(fragudon, "_Reset");
            yield return new WaitForSeconds(0.1f);
            Udon.CallUdonEvent(fragudon, "Respawn");
        }

        public static IEnumerator KillLocalPlayerFrag()
        {
            if (!Murder4Items.frag) yield break;
            var player = Utils.GetLocalPlayer();
            Items.TakeOwnershipIfNecessary(Murder4Items.frag);
            Udon.CallUdonEvent(fragudon, "SyncArm");
            yield return new WaitForSeconds(0.1f);
            Murder4Items.frag.transform.position = Utils.GetLocalPlayer().gameObject.transform.position + new Vector3(0.1f, 0.1f, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.frag.transform.position = Utils.GetLocalPlayer().gameObject.transform.position + new Vector3(0.1f, 0.1f, 0);
            Udon.CallUdonEvent(fragudon, "Explode");
            yield return new WaitForSeconds(0.1f);
            Udon.CallUdonEvent(fragudon, "_Reset");
            yield return new WaitForSeconds(0.1f);
            Udon.CallUdonEvent(fragudon, "Respawn");
        }

        public static IEnumerator SpamSounds(float delay)
        {
            while (spamsounds)
            {
                foreach (var sounds in Resources.FindObjectsOfTypeAll<UdonBehaviour>())
                {
                    if (sounds.gameObject.name.Contains("sound"))
                    {
                        Udon.CallUdonEvent(sounds, "Play");
                        yield return new WaitForSeconds(delay);
                    }
                }
            }
        }

        public static void CluesESPCoro()
        {
            foreach (var clue in Resources.FindObjectsOfTypeAll<Renderer>())
            {
                if (clue.gameObject.name == "geo" && clue.gameObject.transform.parent.gameObject.name.Contains("Clue"))
                {
                    Utils.ToggleOutline(clue, false);
                }
                if (clue.gameObject.name == "geo" && clue.gameObject.transform.parent.gameObject.name.Contains("Clue") && clue.gameObject.active)
                {
                    Utils.ToggleOutline(clue, true);
                }
            }
        }

        public static IEnumerator PickupBearTraps()
        {
            foreach (var beartrap in Resources.FindObjectsOfTypeAll<UdonBehaviour>())
            {
                if (beartrap.gameObject.name.Contains("Bear Trap"))
                {
                    beartrap.enabled = false;
                    yield return new WaitForSeconds(0.2f);
                    beartrap.gameObject.GetComponent<VRC_Pickup>().pickupable = true;
                }
            }
        }

        public static void DisablePickupBearTraps()
        {
            foreach (var beartrap in Resources.FindObjectsOfTypeAll<UdonBehaviour>())
            {
                if (beartrap.gameObject.name.Contains("Bear Trap"))
                {
                    beartrap.enabled = true;
                }
            }
        }

        public static IEnumerator GivePatreonSelf()
        {
            while (patreonself)
            {
                yield return new WaitForSeconds(0.2f);
                try
                {
                    var nonpatronobject = GameObject.Find("Game Logic/Weapons/Revolver/Recoil Anim/Recoil/geo");
                    if (revolverpickup.currentPlayer.playerId == Utils.GetLocalPlayer().field_Private_VRCPlayerApi_0.playerId && nonpatronobject.active)
                    {
                        CallRevolver("PatronSkin");
                    }
                }
                catch
                {
                }
            }
            yield return new WaitForSeconds(0.1f);
            
        }

        public static IEnumerator GivePatreonTarget(VRC.Player player)
        {
            while (givepatreon)
            {
                yield return new WaitForSeconds(0.2f);
                try
                {
                    var nonpatronobject = GameObject.Find("Game Logic/Weapons/Revolver/Recoil Anim/Recoil/geo");
                    if (revolverpickup.currentPlayer.playerId ==
                        player.prop_VRCPlayerApi_0.playerId && nonpatronobject.active)
                    {
                        CallRevolver("PatronSkin");
                    }
                }
                catch
                {
                }
            }
            yield return new WaitForSeconds(0.1f);
        }

        public static IEnumerator PickupWeaponInCooldown()
        {
            while (pickupweapontoggle)
            {
                foreach (VRC_Pickup PickupCooldown in Resources.FindObjectsOfTypeAll<VRC_Pickup>())
                {
                    PickupCooldown.pickupable = true;
                    yield return new WaitForSeconds(0.1f);
                }
            }
        }

        public static IEnumerator Fire()
        {
            while (revolverspam)
            {
                CallRevolver("Fire");
                yield return new WaitForSeconds(1);
            }
        }

        public static IEnumerator BWin()
        {
            CallRevolver("SyncFire");
            yield return new WaitForSeconds(1);
            CallGameLogic("SyncVictoryB");
        }

        /// <summary>
        /// Calls a UDON event.
        /// </summary>
        /// <param name="eventName">The name of the event to call.</param>
        public static void CallGameLogic(string eventName)
        {
            Udon.CallUdonEvent(gameLogic, eventName);
        }
        public static void CallRevolver(string eventName)
        {
            Udon.CallUdonEvent(revolver, eventName);
        }

        /// Available UDON events:
        /// GetLocalPlayerNode
        /// SyncTrySabotageLights
        /// SyncBodyFound
        /// SyncRepairComms
        /// SyncRepairOxygenB
    }
}
