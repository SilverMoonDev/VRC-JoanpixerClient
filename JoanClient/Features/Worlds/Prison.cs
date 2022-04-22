using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoanpixerClient.Features.Worlds
{
    internal class Prison
    {
        public static bool worldLoaded;
        public static void Initialize()
        {
            if (RoomManager.field_Internal_Static_ApiWorldInstance_0?.worldId == "wrld_14750dd6-26a1-4edb-ae67-cac5bcd9ed6a")
            {
                var prison = (Environment.CurrentDirectory + "\\Joanpixer\\prison.png").LoadSpriteFromDisk();
                Utils.WorldHacks.SetIcon(prison);
                Utils.WorldHacks.SetText("Prison Escape");
                worldLoaded = true;
            }
            else
            {
                worldLoaded = false;
            }
        }
        //StartGameCountdown
    }
}
