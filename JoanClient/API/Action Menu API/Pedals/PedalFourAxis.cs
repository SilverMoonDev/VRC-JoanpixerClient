﻿using System;
using ForbiddenButtonAPI.Helpers;
using ForbiddenButtonAPI.Managers;
using ForbiddenButtonAPI.Types;
using UnityEngine;

namespace ForbiddenButtonAPI.Pedals
{
    public sealed class PedalFourAxis : PedalStruct
    {
        public PedalFourAxis(string text, Texture2D icon, Action<Vector2> onUpdate, string topButtonText,
            string rightButtonText, string downButtonText, string leftButtonText, bool locked = false)
        {
            this.text = text;
            this.icon = icon;
            triggerEvent = delegate
            {
                FourAxisPuppetManager.OpenFourAxisMenu(text, onUpdate, pedal);
                FourAxisPuppetManager.current.GetButtonUp().SetButtonText(topButtonText);
                FourAxisPuppetManager.current.GetButtonRight().SetButtonText(rightButtonText);
                FourAxisPuppetManager.current.GetButtonDown().SetButtonText(downButtonText);
                FourAxisPuppetManager.current.GetButtonLeft().SetButtonText(leftButtonText);
            };
            Type = PedalType.FourAxisPuppet;
            this.locked = locked;
        }

        public PedalOption pedal { get; set; }
    }
}