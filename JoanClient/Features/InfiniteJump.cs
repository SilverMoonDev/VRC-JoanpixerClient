using VRC.SDKBase;
using UnityEngine;

namespace ForbiddenClient.Features
{
    public class InfiniteJump
    {
        public static bool InfJumpEnabled = false;
        public static bool BHOP = false;

        public static void OnUpdate()
        {
            if (InfJumpEnabled)
            {
                try
                {
                    if (VRCInputManager.Method_Public_Static_VRCInput_String_0("Jump").prop_Boolean_2 && RoomManager.field_Internal_Static_ApiWorld_0 != null && !Networking.LocalPlayer.IsPlayerGrounded())
                    {
                    
                        Vector3 velocity = Networking.LocalPlayer.GetVelocity();
                        velocity.y = Networking.LocalPlayer.GetJumpImpulse();
                        Networking.LocalPlayer.SetVelocity(velocity);
                    }
                }
                catch { }
            }
            if (BHOP)
            {
                try
                {
                    if (VRCInputManager.Method_Public_Static_VRCInput_String_0("Jump").prop_Boolean_2 && RoomManager.field_Internal_Static_ApiWorld_0 != null && Networking.LocalPlayer.IsPlayerGrounded())
                    {
                    
                        Vector3 velocity = Networking.LocalPlayer.GetVelocity();
                        velocity.y = Networking.LocalPlayer.GetJumpImpulse();
                        Networking.LocalPlayer.SetVelocity(velocity);
                    
                    }
                }
                catch { }
            }

        }
    }
}
