using System;
using MelonLoader;
using UnityEngine;
using VRC.Core;
using VRC.SDKBase;

namespace JoanpixerClient.Features
{
    class Speedhack
    {
        public static bool speedEnabled = false;
        public static float speedMultiplier = 5;

        private static float originalWalkSpeed = 0f;
        private static float originalRunSpeed = 0f;
        private static float originalStrafeSpeed = 0f;

        public static void Toggle()
        {
            // MelonLogger.Msg("Speedhack toggled.");
            speedEnabled = !speedEnabled;
        }

        public static void Main()
        {
            try
            {
                // Make sure our player is valid.
                if (Networking.LocalPlayer == null)
                {
                    return;
                }

                try
                {
                    Networking.LocalPlayer.GetWalkSpeed();
                }
                catch
                {
                    return;
                }

                if (originalWalkSpeed == 0f || originalRunSpeed == 0f || originalStrafeSpeed == 0f)
                {
                    originalWalkSpeed = Networking.LocalPlayer.GetWalkSpeed();
                    originalRunSpeed = Networking.LocalPlayer.GetRunSpeed();
                    originalStrafeSpeed = Networking.LocalPlayer.GetStrafeSpeed();
                }

                if (speedEnabled)
                {
                    Networking.LocalPlayer.SetWalkSpeed(originalWalkSpeed * speedMultiplier);
                    Networking.LocalPlayer.SetRunSpeed(originalRunSpeed * speedMultiplier);
                    Networking.LocalPlayer.SetStrafeSpeed(originalStrafeSpeed * speedMultiplier);
                }
                else
                {
                    Networking.LocalPlayer.SetWalkSpeed(originalWalkSpeed);
                    Networking.LocalPlayer.SetRunSpeed(originalRunSpeed);
                    Networking.LocalPlayer.SetStrafeSpeed(originalStrafeSpeed);
                    originalRunSpeed = 0f;
                    originalWalkSpeed = 0f;
                    originalStrafeSpeed = 0f;
                }
            } 
            catch (Exception e)
            {
                // SHUT THE FUCK UP NULL REFERENCE EXCEPTION.
                MelonLogger.Msg("Swallowing caught exception in Speedhack.Main(). ->\n" + e.ToString());
            }

        }
    }
}
