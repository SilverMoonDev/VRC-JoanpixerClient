using VRC;
using VRC.Core;
using UnityEngine;
using MelonLoader;
using System;

namespace JoanpixerClient.Features
{
    class ESP
    {
        public static bool espEnabled = false;

        /// <summary>
        /// Responsible for toggling ESP on or off.
        /// </summary>
        public static void Toggle()
        {
            if (!espEnabled)
            {
                espEnabled = !espEnabled;
            }
            else
            {
                espEnabled = !espEnabled;
                
                // This code is required to disable SelectRegionESP.

                GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("Player");

                foreach (GameObject playerObject in playerObjects)
                {
                    if (playerObject.transform.Find("SelectRegion"))
                    {
                        playerObject.transform.Find("SelectRegion").GetComponent<Renderer>().material.SetColor("_Color", Color.magenta);
                        playerObject.transform.Find("SelectRegion").GetComponent<Renderer>().sharedMaterial.SetColor("_Color", Color.magenta);
                        Utils.ToggleOutline(playerObject.transform.Find("SelectRegion").GetComponent<Renderer>(), false);
                    }
                }
            }
        }

        private static void SelectRegionESP(GameObject player)
        {
            if (player.transform.Find("SelectRegion"))
            {
                // Get the selection region for the player.
                var renderer = player.transform.Find("SelectRegion").GetComponent<Renderer>();

                if (renderer == null)
                {
                    return;
                }

                // Toggle the player outline.
                Utils.ToggleOutline(renderer, true);
            }

            if (player.transform.Find("SelectRegion"))
            {
                // Get the selection region for the player.
                var renderer = player.transform.Find("SelectRegion").GetComponent<Renderer>();

                if (renderer == null)
                {
                    return;
                }

                // Toggle the player outline.
                Utils.ToggleOutline(renderer, true);
            }
        }
        public static void Main()
        {
            if (espEnabled)
            {
                GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("Player");

                // Loop through all the player objects in the world.
                for (int i = 0; i < playerObjects.Length; i++)
                {
                    GameObject playerObject = playerObjects[i];

                    // Make sure the player is valid.
                    if (playerObject == null)
                    {
                        continue;
                    }
                    // Render ESP for users.
                    SelectRegionESP(playerObject);
                }
            }
        }
    }
}
