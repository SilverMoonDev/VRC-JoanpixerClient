using System.Drawing;
using System.IO;

namespace ForbiddenClient.Resources
{
    internal static class IconsVars
    {
        internal static readonly byte[] MainMenu = Properties.Resources.MainMenu.GetBytes();

        internal static readonly byte[] ActionOff = Properties.Resources.ActionOff.GetBytes();

        internal static readonly byte[] ActionOn = Properties.Resources.ActionOn.GetBytes();

        internal static readonly byte[] AmongUs = Properties.Resources.amongus.GetBytes();

        internal static readonly byte[] JustBClub = Properties.Resources.JustBClub.GetBytes();

        internal static readonly byte[] KillSelf = Properties.Resources.killself.GetBytes();

        internal static readonly byte[] Knife = Properties.Resources.knife.GetBytes();

        internal static readonly byte[] Player = Properties.Resources.Player.GetBytes();

        internal static readonly byte[] PrisonEscape = Properties.Resources.prison.GetBytes();

        internal static readonly byte[] pickups = Properties.Resources.pickup.GetBytes();

        internal static readonly byte[] Protections = Properties.Resources.Protections_Icon.GetBytes();

        internal static readonly byte[] Restart = Properties.Resources.restart.GetBytes();

        internal static readonly byte[] UIColour = Properties.Resources.UIColour.GetBytes();

        internal static readonly byte[] ToggleOn = Properties.Resources.ToggleOn.GetBytes();

        internal static readonly byte[] Unlock = Properties.Resources.unlock.GetBytes();

        internal static readonly byte[] FateIrbloss = Properties.Resources.fate.GetBytes();

        internal static readonly byte[] blockicon = Properties.Resources.block.GetBytes();

        internal static readonly byte[] plusimage = Properties.Resources.addimage.GetBytes();

        internal static readonly byte[] Ghost = Properties.Resources.Ghost.GetBytes();

        internal static readonly byte[] Settings = Properties.Resources.Settings.GetBytes();

        internal static readonly byte[] Infested = Properties.Resources.infested.GetBytes();

        internal static readonly byte[] DoorsOff = Properties.Resources.doorsoff.GetBytes();

        internal static readonly byte[] UICustomize = Properties.Resources.UICustomize.GetBytes();

        static byte[] GetBytes(this Bitmap image)
        {
            using (var stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }
}
