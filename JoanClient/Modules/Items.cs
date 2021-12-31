//using System;
using UnityEngine;
using VRC;
using System.Collections;
//using System.Collections.Generic;
//using VRCSDK2;
using VRC.SDKBase;
//using System.Linq;
//using static VRC.SDKBase.VRC_EventHandler;

namespace JoanpixerClient.Modules
{
	class Items
	{
        public static bool AutoDropToggle = false;
        public static IEnumerator AutoDrop()
        {
            while (AutoDropToggle)
            {
                yield return new WaitForSeconds(1);
                foreach (VRC_Pickup vrc_Pickup in Resources.FindObjectsOfTypeAll<VRC_Pickup>())
                {
                    if (vrc_Pickup.IsHeld && GetOwnerOfGameObject(vrc_Pickup.gameObject) != Utils.GetLocalPlayer())
                    {
                        TakeOwnershipIfNecessary(vrc_Pickup.gameObject);
                    }
                }
            }
        }

        public static void RespawnPickups()
        {
            foreach (VRC_Pickup vrc_Pickup in Resources.FindObjectsOfTypeAll<VRC_Pickup>())
            {
                TakeOwnershipIfNecessary(vrc_Pickup.gameObject);
                vrc_Pickup.gameObject.transform.position = new Vector3(0, -1000, 0);
            }
        }

        public static void AllowThief()
        {
            foreach (VRC_Pickup vrc_Pickup in Resources.FindObjectsOfTypeAll<VRC_Pickup>())
            {
                vrc_Pickup.DisallowTheft = false;
                vrc_Pickup.pickupable = true;
            }
        }

        public static void DisallowThief()
        {
            foreach (VRC_Pickup vrc_Pickup in Resources.FindObjectsOfTypeAll<VRC_Pickup>())
            {
                vrc_Pickup.DisallowTheft = true;
                vrc_Pickup.pickupable = true;
            }
        }

        public static void TakeOwnershipIfNecessary(GameObject gameObject)
        {
            if (GetOwnerOfGameObject(gameObject) != Utils.GetLocalPlayer())
            {
                Networking.SetOwner(Utils.GetLocalPlayer().field_Private_VRCPlayerApi_0, gameObject);
            }
        }

        public static Player GetOwnerOfGameObject(GameObject gameObject)
        {
            foreach (Player player in Utils.GetAllPlayers())
            {
                if (player.field_Private_VRCPlayerApi_0.IsOwner(gameObject))
                {
                    return player;
                }
            }
            return null;
        }
        public static void ItemsToPlayer(Player player)
        {
            foreach (VRC_Pickup vrc_Pickup in Resources.FindObjectsOfTypeAll<VRC_Pickup>())
            {
                Networking.SetOwner(Utils.GetLocalPlayer().field_Private_VRCPlayerApi_0, vrc_Pickup.gameObject);
                vrc_Pickup.transform.rotation = new Quaternion(-0.7f, 0f, 0f, 0.7f);
                vrc_Pickup.transform.position = player.transform.position;
                Networking.SetOwner(Utils.GetLocalPlayer().field_Private_VRCPlayerApi_0, vrc_Pickup.gameObject);
            }
        }

        /*public static void ItemsToPlayerHead(Player Player)
        {
            foreach (VRC_ObjectSync vrc_ObjectSync in World_ObjectSyncs)
            {
                Networking.SetOwner(Utils.GetLocalPlayer().field_Private_VRCPlayerApi_0, vrc_ObjectSync.gameObject);
                vrc_ObjectSync.transform.rotation = new Quaternion(-0.7f, 0f, 0f, 0.7f);
                vrc_ObjectSync.transform.position = Player.gameObject.transform.GetComponentInChildren<Animator>().GetBoneTransform(HumanBodyBones.Head).transform.position;
                Networking.SetOwner(Utils.GetLocalPlayer().field_Private_VRCPlayerApi_0, vrc_ObjectSync.gameObject);
            }
        }
        public static IEnumerator DrawCircle(Player Player)
        {
            foreach (VRCSDK2.VRC_Pickup Pickup in UnityEngine.Object.FindObjectsOfType<VRCSDK2.VRC_Pickup>())
            {
                if (!Pickup.transform.parent.name.ToLower().Contains("eraser") && (Pickup.name.ToLower().Contains("pen") || Pickup.name.ToLower().Contains("marker") || Pickup.name.ToLower().Contains("grip")))
                {
                    TakeOwnershipIfNecessary(Pickup.gameObject);
                    Vector3 OriginalPosition = Pickup.transform.position;
                    Quaternion OriginalRotation = Pickup.transform.rotation;
                    float CircleSpeed = 15f;
                    float alpha = 0f;
                    float a = 1f;
                    float b = 1f;
                    Pickup.Drop();
                    Pickup.gameObject.GetComponent<VRC.SDKBase.VRC_Trigger>().OnDrop();
                    Pickup.gameObject.GetComponent<VRC.SDKBase.VRC_Trigger>().OnPickup();
                    Pickup.transform.position = new Vector3(Player.transform.position.x + a * (float)Math.Cos(alpha), Player.transform.position.y + 0.3f, Player.transform.position.z + b * (float)System.Math.Sin(alpha));
                    Pickup.transform.rotation = new Quaternion(-0.7f, 0f, 0f, 0.7f);
                    yield return new WaitForSeconds(0.2f);
                    Pickup.gameObject.GetComponent<VRC.SDKBase.VRC_Trigger>().OnPickupUseDown();
                    yield return new WaitForSeconds(0.01f);
                    for (int i = 0; i < 95; i++)
                    {
                        alpha += Time.deltaTime * CircleSpeed;
                        Pickup.transform.position = new Vector3(Player.transform.position.x + a * (float)Math.Cos(alpha), Player.transform.position.y + 0.3f, Player.transform.position.z + b * (float)System.Math.Sin(alpha));
                        yield return new WaitForSeconds(0.01f);
                    }
                    Pickup.gameObject.GetComponent<VRC.SDKBase.VRC_Trigger>().OnPickupUseUp();
                    yield return new WaitForSeconds(0.01f);
                    Pickup.transform.position = OriginalPosition;
                    Pickup.transform.rotation = OriginalRotation;
                    Pickup.gameObject.GetComponent<VRC.SDKBase.VRC_Trigger>().OnDrop();
                }
            }
            yield break;
        }

        public static List<VRC_ObjectSync> World_ObjectSyncs = new List<VRC_ObjectSync>();

        public static IEnumerator ItemRotate(Player player)
        {
            for (; ; )
            {
                if (!ItemOrbitEnabled)
                {
                    yield break;
                }
                GameObject gameObject = new GameObject();
                Transform transform = gameObject.transform;
                transform.position = player.transform.position + new Vector3(0f, 0.2f, 0f);
                gameObject.transform.Rotate(new Vector3(0f, 360f * Time.time, 0f));
                try
                {
                    foreach (VRC_ObjectSync obj in World_ObjectSyncs)
                    {
                        TakeOwnershipIfNecessary(obj.gameObject);
                        obj.transform.position = gameObject.transform.position + gameObject.transform.forward;
                        obj.transform.LookAt(player.transform);
                        gameObject.transform.Rotate(new Vector3(0f, 360 / World_ObjectSyncs.Count, 0f));
                    }
                }
                catch { }
                UnityEngine.Object.Destroy(gameObject);
                yield return new WaitForSeconds(0.035f);
            }
        }
        public static bool ItemOrbitEnabled = false;
        public static bool PenVirus = false;
        
        public static IEnumerator SpreadVirus()
        {
            foreach (VRCSDK2.VRC_Pickup Pickup in UnityEngine.Object.FindObjectsOfType<VRCSDK2.VRC_Pickup>())
            {
                if (!Pickup.transform.parent.name.ToLower().Contains("eraser") && Pickup != null && (Pickup.name.ToLower().Contains("pen") || Pickup.name.ToLower().Contains("marker") || Pickup.name.ToLower().Contains("grip")))
                {
                    TakeOwnershipIfNecessary(Pickup.gameObject);
                    Pickup.Drop();
                    Pickup.transform.position = Utils.GetLocalPlayer().transform.position;
                    Pickup.gameObject.GetComponent<VRC.SDKBase.VRC_Trigger>().OnDrop();
                    yield return new WaitForSeconds(0.2f);
                    Pickup.gameObject.GetComponent<VRC.SDKBase.VRC_Trigger>().OnPickup();
                    yield return new WaitForSeconds(0.2f);
                    Pickup.gameObject.GetComponent<VRC.SDKBase.VRC_Trigger>().OnPickupUseDown();
                }
            }
            float a = 0f;
            float b = 0f;
            float playerx = Utils.GetLocalPlayer().transform.position.x;
            float playery = Utils.GetLocalPlayer().transform.position.y;
            float playerz = Utils.GetLocalPlayer().transform.position.z;
            for (; ; )
            {
                foreach (VRCSDK2.VRC_Pickup Pickup in UnityEngine.Object.FindObjectsOfType<VRCSDK2.VRC_Pickup>())
                {
                    if (!Pickup.transform.parent.name.ToLower().Contains("eraser") && Pickup != null && (Pickup.name.ToLower().Contains("pen") || Pickup.name.ToLower().Contains("marker") || Pickup.name.ToLower().Contains("grip")))
                    {
                        yield return new WaitForSeconds(0.01f);
                        float CircleSpeed = 9999;
                        float alpha = 0f;
                        Pickup.transform.rotation = new Quaternion(-0.7f, 0f, 0f, 0.7f);
                        for (int x = 0; x < 4000; x++)
                        {
                            alpha += Time.deltaTime * CircleSpeed;
                            Pickup.transform.position = new Vector3(playerx + a * (float)Math.Cos(alpha), playery + 0.3f, playerz + b * (float)Math.Sin(alpha));
                        }
                        a += 0.003f;
                        b += 0.003f;
                    }
                    if (!PenVirus)
                    {
                        yield break;
                    }
                }
            }
        }

        public static IEnumerator Tornado()
        {
            List<VRCSDK2.VRC_Pickup> AllPickups = UnityEngine.Object.FindObjectsOfType<VRCSDK2.VRC_Pickup>().ToList();
            if (AllPickups != null)
            {
                foreach (var Pickup in AllPickups)
                {
                    if (!Pickup.transform.parent.name.ToLower().Contains("eraser") && (Pickup.name.ToLower().Contains("pen") || Pickup.name.ToLower().Contains("marker") || Pickup.name.ToLower().Contains("grip")))
                    {
                        TakeOwnershipIfNecessary(Pickup.gameObject);
                        Pickup.Drop();
                        Pickup.gameObject.GetComponent<VRC.SDKBase.VRC_Trigger>().OnDrop();
                        yield return new WaitForSeconds(0.2f);
                        Pickup.gameObject.GetComponent<VRC.SDKBase.VRC_Trigger>().OnPickup();
                        yield return new WaitForSeconds(0.2f);
                        Pickup.gameObject.GetComponent<VRC.SDKBase.VRC_Trigger>().OnPickupUseDown();
                        Pickup.transform.position = new Vector3(0, 0, 0);
                    }
                }
                float a = 0f;
                float b = 0f;
                float y = 0.5f;
                for (int i = 0; i < 50; i++)
                {
                    foreach (var Pickup in AllPickups)
                    {
                        if (!Pickup.transform.parent.name.ToLower().Contains("eraser") && (Pickup.name.ToLower().Contains("pen") || Pickup.name.ToLower().Contains("marker") || Pickup.name.ToLower().Contains("grip")))
                        {
                            yield return new WaitForSeconds(0.001f);
                            float CircleSpeed = 20;
                            float alpha = 0f;
                            Pickup.transform.rotation = new Quaternion(-0.7f, 0f, 0f, 0.7f);
                            for (int x = 0; x < 95; x++)
                            {
                                alpha += Time.deltaTime * CircleSpeed;
                                Pickup.transform.position = new Vector3(0 + a * (float)Math.Cos(alpha), y, 0 + b * (float)Math.Sin(alpha));
                                yield return new WaitForSeconds(0.001f);
                            }
                            a += 0.03f;
                            b += 0.03f;
                            if (y < 5)
                            {
                                Pickup.transform.position = new Vector3(0, 0.5f, 0);
                                y += 0.03f;
                            }
                        }
                    }
                }
            }
        }*/
    }
}


