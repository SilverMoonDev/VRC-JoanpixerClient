using System;
using ForbiddenButtonAPI.Helpers;
using ForbiddenButtonAPI.Types;
using ForbiddenClient;
using UnityEngine;


namespace ForbiddenButtonAPI.Pedals
{
    public sealed class PedalToggle : PedalStruct
    {
        public PedalToggle(string text, Action<bool> onToggle, bool toggled, Texture2D icon = null,
            bool locked = false)
        {
            this.text = text;
            this.toggled = toggled;
            this.icon = icon;
            triggerEvent = delegate
            {
                //MelonLogger.Msg($"Old state: {this.toggled}, New state: {!this.toggled}");
                this.toggled = !this.toggled;
                if (this.toggled)
                    pedal.SetPedalTypeIcon(ForbiddenClient.Resources.IconsVars.ActionOn.LoadTexture());
                else
                    pedal.SetPedalTypeIcon(ForbiddenClient.Resources.IconsVars.ActionOff.LoadTexture());
                onToggle.Invoke(toggled);
            };
            Type = PedalType.Toggle;
            this.locked = locked;
        }

        public bool toggled { get; set; }

        public PedalOption pedal { get; set; }
    }
}