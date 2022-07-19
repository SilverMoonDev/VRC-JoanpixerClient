using System;
using ForbiddenButtonAPI.Types;
using UnityEngine;

namespace ForbiddenButtonAPI.Pedals
{
    public sealed class PedalButton : PedalStruct
    {
        public PedalButton(string text, Texture2D icon, Action triggerEvent, bool locked = false)
        {
            this.text = text;
            this.icon = icon;
            this.triggerEvent = delegate { triggerEvent(); };
            Type = PedalType.Button;
            this.locked = locked;
        }
    }
}