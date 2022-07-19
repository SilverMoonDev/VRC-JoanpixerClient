using System.Linq;
using UnityEngine;
using VRC.SDKBase;
using VRC.UI.Elements;

public class VRCUtils
{
    public static bool IsQuickMenuOpen => Resources.FindObjectsOfTypeAll<VRC.UI.Elements.QuickMenu>().FirstOrDefault(Menu => Menu != null && Menu.gameObject.active) != null;
}