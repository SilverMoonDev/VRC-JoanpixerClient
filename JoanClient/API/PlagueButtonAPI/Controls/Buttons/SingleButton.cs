using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using MelonLoader;
using ForbiddenButtonAPI.Misc;
using ForbiddenButtonAPI.Controls.Grouping;
using ForbiddenButtonAPI.Pages;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Core.Styles;
using Object = UnityEngine.Object;

namespace ForbiddenButtonAPI.Controls
{
    public class SingleButton : Base_Classes.Button
    {
        public SingleButton(Transform parent, string text, string tooltip, Action click, bool SubMenuIcon = false, Sprite icon = null, bool preserveColor = false, TextAlignmentOptions TextAlignment = TextAlignmentOptions.Center)
        {

            if (icon == null)
            {
                var btn = new SimpleSingleButton(parent, text, tooltip, click, SubMenuIcon);

                gameObject = btn.gameObject;

                return;
            }

            gameObject = UnityEngine.Object.Instantiate(ButtonAPI.singleButtonBase, parent);

            this.text.text = text;
            this.text.alignment = TextAlignment;

            button.onClick = new Button.ButtonClickedEvent();

            if (click != null)
            {
                button.onClick.AddListener(click);
            }

            if (!string.IsNullOrEmpty(tooltip))
            {
                this.tooltip.field_Public_String_0 = tooltip;
            }
            else
            {
                this.tooltip.enabled = false;
            }

            if (icon != null)
            {
                buttonImage.sprite = icon;
                buttonImage.overrideSprite = icon;

                buttonImage.gameObject.SetActive(true);

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

        [Obsolete("This constructor is obsolete. Please use YourMenuPage.AddSingleButton() instead.", true)]
        public SingleButton(MenuPage pge, string text, string tooltip, Action click, bool SubMenuIcon = false, Sprite icon = null, bool preserveColor = false, TextAlignmentOptions TextAlignment = TextAlignmentOptions.Center)
            : this(pge.menuContents, text, tooltip, click, SubMenuIcon, icon, preserveColor, TextAlignment)
        {
        }

        [Obsolete("This constructor is obsolete. Please use YourButtonGroup.AddSingleButton() instead.", true)]
        public SingleButton(ButtonGroup grp, string text, string tooltip, Action click, bool SubMenuIcon = false, Sprite icon = null, bool preserveColor = false, TextAlignmentOptions TextAlignment = TextAlignmentOptions.Center)
            : this(grp.transform, text, tooltip, click, SubMenuIcon, icon, preserveColor, TextAlignment)
        {
        }

        [Obsolete("This constructor is obsolete. Please use YourCollapsibleButtonGroup.AddSingleButton() instead.", true)]
        public SingleButton(CollapsibleButtonGroup grp, string text, string tooltip, Action click, bool SubMenuIcon = false, Sprite icon = null, bool preserveColor = false, TextAlignmentOptions TextAlignment = TextAlignmentOptions.Center)
            : this(grp.buttonGroup, text, tooltip, click, SubMenuIcon, icon, preserveColor, TextAlignment)
        {
        }
    }
}
