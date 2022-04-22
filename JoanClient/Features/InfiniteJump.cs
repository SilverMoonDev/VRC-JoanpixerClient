using VRC.SDKBase;
using UnityEngine;

namespace JoanpixerClient.Features
{
    public class InfiniteJump
    {
        public static bool InfJumpEnabled = false;

        public static void OnUpdate()
        {
            if (VRCInputManager.Method_Public_Static_VRCInput_String_0("Jump").prop_Boolean_2 && RoomManager.field_Internal_Static_ApiWorld_0 != null && !Networking.LocalPlayer.IsPlayerGrounded())
            {
                try
                {
                    Vector3 velocity = Networking.LocalPlayer.GetVelocity();
                    velocity.y = 4;
                    Networking.LocalPlayer.SetVelocity(velocity);
                }
                catch {}
            }
        }
    }
}
