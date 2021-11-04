using System.Collections;
using JoanpixerClient.Extensions;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace JoanpixerClient.Buttons
{
    class ConsoleMenu
    {
        internal static QMInfo QMInfo;

        public static void Initialize()
        {
            QMInfo = new QMInfo(Utils.QuickMenu.transform.Find("ShortcutMenu"), "", 2000, 220, 1300, 1250, false);
            QMInfo.Text.color = Color.white;
            QMInfo.Text.alignment = TextAnchor.LowerLeft;
            QMInfo.Text.supportRichText = true;
            QMInfo.Text.fontSize = 42;
            QMInfo.Text.fontStyle = FontStyle.Bold;
            QMInfo.Text.resizeTextForBestFit = false;
            
        }
    }
}