using System;
using ForbiddenButtonAPI.Misc;
using ForbiddenButtonAPI.Controls.Grouping;
using ForbiddenButtonAPI.Pages;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Core.Styles;

namespace ForbiddenButtonAPI.Controls
{
    public class SingleButton : Base_Classes.Button
    {
        public SingleButton(Transform parent, string text, string tooltip, Action click, bool SubMenuIcon = false, Sprite icon = null, bool preserveColor = false, TextAlignmentOptions TextAlignment = TextAlignmentOptions.Center)
        {
            gameObject = UnityEngine.Object.Instantiate(ButtonAPI.singleButtonBase, parent);

            this.text.text = text;
            this.text.alignment = TextAlignment;
            this.text.fontStyle = FontStyles.Bold;
            buttonBackground.color = new(0.1176f, 0.1176f, 0.1176f, 0.7f);

            button.onClick = new Button.ButtonClickedEvent();

            if (click != null)
            {
                button.onClick.AddListener(click);
            }

            if (!string.IsNullOrEmpty(tooltip))
            {
                foreach (VRC.UI.Elements.Tooltips.UiTooltip tooltips in gameObject?.GetComponentsInChildren<VRC.UI.Elements.Tooltips.UiTooltip>(true))
                {
                    tooltips.field_Public_String_0 = tooltip;
                }
            }
            else
            {
                foreach (VRC.UI.Elements.Tooltips.UiTooltip tooltips in gameObject?.GetComponentsInChildren<VRC.UI.Elements.Tooltips.UiTooltip>(true))
                {
                    tooltips.enabled = false;
                }
            }

            if (icon != null)
            {
                buttonImage.sprite = icon;
                buttonImage.overrideSprite = icon;

                buttonImage.gameObject.SetActive(true);

                buttonImage.color = new Color(0.4157f, 0.8902f, 0.9765f, 0.5f);

                if (preserveColor)
                {
                    buttonImage.color = Color.white;
                    buttonImage.gameObject.GetOrAddComponent<StyleElement>().enabled = false;
                }
            }
            else
            {
                buttonImage.gameObject.SetActive(false);
            }

            if (SubMenuIcon)
            {
                subMenuIcon.gameObject.SetActive(true);
            }
        }

        public SingleButton(MenuPage pge, string text, string tooltip, Action click, bool SubMenuIcon = false, Sprite icon = null, bool preserveColor = false, TextAlignmentOptions TextAlignment = TextAlignmentOptions.Center)
            : this(pge.menuContents, text, tooltip, click, SubMenuIcon, icon, preserveColor, TextAlignment)
        {
        }

        public SingleButton(ButtonGroup grp, string text, string tooltip, Action click, bool SubMenuIcon = false, Sprite icon = null, bool preserveColor = false, TextAlignmentOptions TextAlignment = TextAlignmentOptions.Center)
            : this(grp.gameObject.transform, text, tooltip, click, SubMenuIcon, icon, preserveColor, TextAlignment)
        {
        }

        public SingleButton(CollapsibleButtonGroup grp, string text, string tooltip, Action click, bool SubMenuIcon = false, Sprite icon = null, bool preserveColor = false, TextAlignmentOptions TextAlignment = TextAlignmentOptions.Center)
            : this(grp.buttonGroup, text, tooltip, click, SubMenuIcon, icon, preserveColor, TextAlignment)
        {
        }
    }
}
