using VRC.Udon;
using UnityEngine;

namespace JoanpixerClient.Features.Worlds
{
    class AmongUs
    {
        public static bool worldLoaded = false;
        public static bool enableEmergencySpam = false;
        public static UdonBehaviour gameLogic = null;

        public static void Initialize(string sceneName)
        {
            // TODO: Check world ID aswell.
            if (sceneName == "Skeld")
            {
                gameLogic = GameObject.Find("Game Logic")?.GetComponent<UdonBehaviour>();

                if (gameLogic != null)
                {
                    worldLoaded = true;
                }
            }
            else
            {
                worldLoaded = false;
            }
        }

        /// <summary>
        /// Starts an emergency meeting, this can be spammed and the results are VERY annoying to others aswell.
        /// </summary>
        public static System.Collections.IEnumerator EmergencyButton()
        {
            while (enableEmergencySpam)
            {
                CallUdonEvent("StartMeeting");
                CallUdonEvent("SyncEmergencyMeeting");
                yield return new WaitForSeconds(0.5f);
            }
        }

        /// <summary>
        /// Calls a UDON event.
        /// </summary>
        /// <param name="eventName">The name of the event to call.</param>
        public static void CallUdonEvent(string eventName)
        {
            Udon.CallUdonEvent(gameLogic, eventName);
        }

        /// Available UDON events:
        /// GetLocalPlayerNode
        /// SyncTrySabotageLights
        /// SyncBodyFound
        /// SyncRepairComms
        /// SyncRepairOxygenB
    }
}
