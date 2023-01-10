using ForbiddenButtonAPI.Controls.Grouping;
using ForbiddenButtonAPI.Pages;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using MelonLoader;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace ForbiddenButtonAPI.Controls
{
    public class SimpleSingleButton : Base_Classes.Button
    {
        public SimpleSingleButton(Transform parent, string text, string tooltip, Action click, bool SubMenuIcon = false)
        {

            gameObject = UnityEngine.Object.Instantiate(ButtonAPI.singleButtonBase, parent);

            this.text.text = text;
            this.text.fontSize = 28f;
            this.text.transform.localPosition = new Vector3(0f, -19f, 0f);
            this.text.color = new Color(0.9f, 0.9f, 0.9f);

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

            UnityEngine.Object.Destroy(gameObject.transform.Find("Icon").gameObject);
            UnityEngine.Object.Destroy(gameObject.transform.Find("Icon_Secondary").gameObject);

            if (SubMenuIcon)
            {
                gameObject.transform.Find("Badge_MMJump").gameObject.SetActive(true);
            }
        }

        [Obsolete("This constructor is obsolete. Please use YourMenuPage.AddSimpleSingleButton() instead.", true)]
        public SimpleSingleButton(MenuPage pge, string text, string tooltip, Action click, bool SubMenuIcon = false)
            : this(pge.menuContents, text, tooltip, click, SubMenuIcon)
        {
        }

        [Obsolete("This constructor is obsolete. Please use YourButtonGroup.AddSimpleSingleButton() instead.", true)]
        public SimpleSingleButton(ButtonGroup grp, string text, string tooltip, Action click, bool SubMenuIcon = false)
            : this(grp.transform, text, tooltip, click, SubMenuIcon)
        {
        }

        [Obsolete("This constructor is obsolete. Please use YourCollapsibleButtonGroup.AddSimpleSingleButton() instead.", true)]
        public SimpleSingleButton(CollapsibleButtonGroup grp, string text, string tooltip, Action click, bool SubMenuIcon = false)
            : this(grp.buttonGroup, text, tooltip, click, SubMenuIcon)
        {
        }
    }
}
