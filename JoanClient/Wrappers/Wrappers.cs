using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRC;

namespace JoanpixerClient
{
    public static class Wrappers
    {
        public static QuickMenu GetQuickMenu() { return QuickMenu.prop_QuickMenu_0; }

        public static void SelectPlayer(this QuickMenu instance, Player player) => instance.Method_Public_Void_Player_0(player);
    }
}
