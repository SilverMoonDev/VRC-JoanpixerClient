using System.Linq;
using ForbiddenClient;
using ForbiddenButtonAPI;
using UnityEngine;
using VRC.SDKBase;
using VRC.UI.Elements;

public class VRCUtils
{
    public static bool IsQuickMenuOpen => ButtonAPI.QuickMenuObj?.active ?? false;
}