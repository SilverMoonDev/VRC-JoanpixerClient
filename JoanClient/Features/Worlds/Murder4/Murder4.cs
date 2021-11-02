using System;
using VRC.Udon;
using UnityEngine;
using System.Collections;
using JoanpixerClient.Modules;
using MelonLoader;
using Photon.Pun;
using VRC.Networking;
using VRC.SDKBase;

namespace JoanpixerClient.Features.Worlds
{
    class Murder4
    {
        public static bool worldLoaded = false;
        public static bool revolverspam = false;
        public static bool doorlock = false;
        public static bool doorcollision = false;
        public static bool lightsoff = false;
        public static bool patreonself = false;
        public static bool pickupweapontoggle = false;
        public static bool halloweensong = false;
        public static bool spamsounds = false;
        public static GameObject doors = null;
        public static GameObject MurderText = null;
        public static UdonBehaviour gameLogic = null;
        public static UdonBehaviour fragudon = null;
        public static UdonBehaviour revolver = null;
        public static UdonBehaviour bomb = null;
        public static UdonBehaviour piano = null;
        public static VRC_Pickup revolverpickup = null;


        public static void Initialize(string sceneName)
        {
            // TODO: Check world ID aswell.

            if (sceneName == "Nevermore Halloween")
            {
                piano = GameObject.Find("Game Logic/PianoKeys (continuous)")?.GetComponent<UdonBehaviour>();
                MurderText = GameObject.Find("Game Logic/Game Canvas/Postgame/Murderer Name");
                doors = GameObject.Find("Environment/Doors");
                Murder4Items.Beartrap = GameObject.Find("Game Logic/Weapons/Bear Trap (0)");
                Murder4Items.knife = GameObject.Find("Game Logic/Weapons/Knife (0)");
                Murder4Items.revolverobject = GameObject.Find("Game Logic/Weapons/Revolver");
                Murder4Items.luger = GameObject.Find("Game Logic/Weapons/Unlockables/Luger (0)");
                Murder4Items.shotgun = GameObject.Find("Game Logic/Weapons/Unlockables/Shotgun (0)");
                Murder4Items.frag = GameObject.Find("Game Logic/Weapons/Unlockables/Frag (0)");
                fragudon = GameObject.Find("Game Logic/Weapons/Unlockables/Frag (0)")?.GetComponent<UdonBehaviour>();
                bomb = GameObject.Find("Game Logic/Skulls Unlock CursedBomb/CursedBomb")?.GetComponent<UdonBehaviour>();
                gameLogic = GameObject.Find("Game Logic")?.GetComponent<UdonBehaviour>();
                revolver = GameObject.Find("Game Logic/Weapons/Revolver")?.GetComponent<UdonBehaviour>();
                revolverpickup = Murder4Items.revolverobject.GetComponent<VRC_Pickup>();
                if (gameLogic != null && revolver != null)
                {
                    worldLoaded = true;
                }
            }
            else
            {
                worldLoaded = false;
            }
        }
        public static IEnumerator KillSelectedPlayerKnife(VRCPlayer player)
        {
            var knifeoriginalpos = Murder4Items.knife.transform.position;
            Items.TakeOwnershipIfNecessary(Murder4Items.knife);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.transform.position + new Vector3(0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.transform.position + new Vector3(-0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.transform.position + new Vector3(0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.transform.position + new Vector3(-0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.transform.position + new Vector3(0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.transform.position + new Vector3(-0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.transform.position + new Vector3(0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.transform.position + new Vector3(-0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.transform.position + new Vector3(0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.transform.position + new Vector3(-0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.transform.position + new Vector3(0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.transform.position + new Vector3(-0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.transform.position + new Vector3(0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = player.transform.position + new Vector3(-0.2f, 1, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.knife.transform.position = knifeoriginalpos;
        }
        public static IEnumerator KillSelectedPlayerFrag(VRCPlayer player)
        {
            Items.TakeOwnershipIfNecessary(Murder4Items.frag);
            Udon.CallUdonEvent(fragudon, "SyncArm");
            yield return new WaitForSeconds(0.1f);
            Murder4Items.frag.transform.position = player.transform.position + new Vector3(0.1f, 0.1f, 0);
            yield return new WaitForSeconds(0.1f);
            Murder4Items.frag.transform.position = player.transform.position + new Vector3(0.1f, 0.1f, 0);
            Udon.CallUdonEvent(fragudon, "Explode");
            yield return new WaitForSeconds(0.1f);
            Udon.CallUdonEvent(fragudon, "_Reset");
            yield return new WaitForSeconds(0.1f);
            Udon.CallUdonEvent(fragudon, "Respawn");
        }

        public static IEnumerator PlayPiano()
        {
            if (halloweensong)
            {
                Udon.CallUdonEvent(piano, "PlaySong0");
                while (halloweensong)
                {
                    Udon.CallUdonEvent(piano, "PlayContinue");
                    yield return new WaitForSeconds(1);
                }
            }
        }

        public static IEnumerator LockDoors()
        {
            while (doorlock)
            {
                yield return new WaitForSeconds(2);
                foreach (var door in Resources.FindObjectsOfTypeAll<UdonBehaviour>())
                {
                    if (door.gameObject.name.Contains("Door ("))
                    {
                        UdonBehaviour door1 = GameObject.Find(doors + "/Door")?.GetComponent<UdonBehaviour>();
                        Udon.CallUdonEvent(door, "SyncLock");
                        Udon.CallUdonEvent(door1, "SyncLock");
                    }
                }
            }
        }

        public static IEnumerator SpamSounds()
        {
            while (spamsounds)
            {
                foreach (var sounds in Resources.FindObjectsOfTypeAll<UdonBehaviour>())
                {
                    if (sounds.gameObject.name.Contains("sound"))
                    {
                        Udon.CallUdonEvent(sounds, "Play");
                        yield return new WaitForSeconds(0.03f);
                    }
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
                    if (revolverpickup.currentPlayer.playerId ==
                        Utils.GetLocalPlayer().field_Private_VRCPlayerApi_0.playerId)
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

        public static IEnumerator TurnLightsOff()
        {
            while (lightsoff)
            {
                yield return new WaitForSeconds(1);
                foreach (var switchboxes in Resources.FindObjectsOfTypeAll<UdonBehaviour>())
                {
                    if (switchboxes.gameObject.name.Contains("Switchbox ("))
                    {
                        Udon.CallUdonEvent(switchboxes, "SwitchDown");
                    }
                }
            }
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

        public static void TurnLightsOn()
        {
            foreach (var switchboxes in Resources.FindObjectsOfTypeAll<UdonBehaviour>())
            {
                if (switchboxes.gameObject.name.Contains("Switchbox ("))
                {
                    Udon.CallUdonEvent(switchboxes, "SwitchUp");
                }
            }
        }

        public static void UnLockDoors()
        {
            foreach (var door in Resources.FindObjectsOfTypeAll<UdonBehaviour>())
            {
                if (door.gameObject.name.Contains("Door ("))
                {
                    UdonBehaviour door1 = GameObject.Find(doors + "/Door")?.GetComponent<UdonBehaviour>();
                    Udon.CallUdonEvent(door, "SyncUnlockL");
                    Udon.CallUdonEvent(door, "SyncOpenL");
                    Udon.CallUdonEvent(door1, "SyncUnlockL");
                    Udon.CallUdonEvent(door1, "SyncOpenL");
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
