using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using MelonLoader;
using ForbiddenButtonAPI.Misc;
using ForbiddenButtonAPI.Pages;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace ForbiddenButtonAPI.Controls.Grouping
{
    public class ButtonGroup : Base_Classes.GenericControl
    {
        public readonly TextMeshProUGUI headerText;

        public readonly GameObject headerGameObject;

        public readonly RectMask2D parentMenuMask;

        private readonly bool WasNoText;
        
        public ButtonGroup(Transform parent, string text, bool NoText = false, TextAnchor ButtonAlignment = TextAnchor.UpperCenter)
        {
            WasNoText = NoText;

            if (!NoText)
            {

                headerGameObject = Object.Instantiate(ButtonAPI.buttonGroupHeaderBase, parent);
                headerText = headerGameObject.GetComponentInChildren<TextMeshProUGUI>(true);
                headerText.text = text;
                headerText.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(915f, 50f);

                headerGameObject.transform.Find("Background_Button").gameObject.SetActive(false);
                headerGameObject.transform.Find("Arrow").gameObject.SetActive(false);
            }

            gameObject = Object.Instantiate(ButtonAPI.buttonGroupBase, parent);
            gameObject.transform.DestroyChildren();

            var Layout = gameObject.GetOrAddComponent<GridLayoutGroup>();
            Layout.childAlignment = ButtonAlignment;

            parentMenuMask = parent.parent.GetOrAddComponent<RectMask2D>();
        }

        [Obsolete("This constructor is obsolete. Please use YourMenuPage.AddButtonGroup() instead.", true)]
        public ButtonGroup(MenuPage parent, string text, bool NoText = false, TextAnchor ButtonAlignment = TextAnchor.UpperCenter) : this(parent.menuContents, text, NoText, ButtonAlignment)
        {
        }

        public void SetText(string newText)
        {
            if (!WasNoText)
            {
                headerText.text = newText;
            }
        }

        #region Useful Helper Methods
        public static MenuPage CreatePage(string menuName, string pageTitle, bool root = false, bool backButton = true, bool expandButton = false, Action expandButtonAction = null, string expandButtonTooltip = "", Sprite expandButtonSprite = null, bool preserveColor = false, bool Gridify = false)
        {
            return MenuPage.CreatePage(menuName, pageTitle, root, backButton, expandButton, expandButtonAction, expandButtonTooltip, expandButtonSprite, preserveColor, Gridify);
        }

        public (MenuPage, SimpleSingleButton) AddSubMenu(string menuName, string pageTitle, bool backButton = true, bool expandButton = false, Action expandButtonAction = null, string expandButtonTooltip = "", Sprite expandButtonSprite = null, bool preserveColor = false, bool Gridify = false)
        {
            var NewMenu = MenuPage.CreatePage(menuName, pageTitle, false, backButton, expandButton, expandButtonAction, expandButtonTooltip, expandButtonSprite, preserveColor, Gridify);

            return (NewMenu, new SimpleSingleButton(transform, pageTitle, $"Opens The {pageTitle} SubMenu.", NewMenu.OpenMenu, true));
        }

        public (MenuPage, SingleButton) AddSubMenu(Sprite icon, string menuName, string pageTitle, bool backButton = true, bool expandButton = false, Action expandButtonAction = null, string expandButtonTooltip = "", Sprite expandButtonSprite = null, bool preserveColor = false, bool Gridify = false)
        {
            var NewMenu = MenuPage.CreatePage(menuName, pageTitle, false, backButton, expandButton, expandButtonAction, expandButtonTooltip, expandButtonSprite, preserveColor, Gridify);

            return (NewMenu, new SingleButton(transform, pageTitle, $"Opens The {pageTitle} SubMenu.", NewMenu.OpenMenu, true, icon, preserveColor));
        }

        public SingleButton AddSingleButton(string text, string tooltip, Action click, bool SubMenuIcon = false, Sprite icon = null, bool preserveColor = false, TextAlignmentOptions TextAlignment = TextAlignmentOptions.Center)
        {
            return new SingleButton(transform, text, tooltip, click, SubMenuIcon, icon, preserveColor, TextAlignment);
        }

        public SimpleSingleButton AddSimpleSingleButton(string text, string tooltip, Action click, bool SubMenuIcon = false)
        {
            return new SimpleSingleButton(transform, text, tooltip, click, SubMenuIcon);
        }

        public Label AddLabel(string text, string tooltip, Action onClick = null)
        {
            return new Label(transform, text, tooltip, onClick);
        }

        public ToggleButton AddToggleButton(string text, string tooltipWhileDisabled, string tooltipWhileEnabled, Action<bool> stateChanged, bool DefaultState = false, Sprite OnImage = null, Sprite OffImage = null)
        {
            return new ToggleButton(transform, text, tooltipWhileDisabled, tooltipWhileEnabled, stateChanged, OnImage, OffImage, DefaultState);
        }

        public ToggleButton AddToggleButton(string text, string tooltip, Action<bool> stateChanged, bool DefaultState = false, Sprite OnImage = null, Sprite OffImage = null)
        {
            return new ToggleButton(transform, text, tooltip, tooltip, stateChanged, OnImage, OffImage, DefaultState);
        }

        public Slider AddSlider(string text, string tooltip, Action<float> onSliderAdjust, float minValue = 0f, float maxValue = 100f, float defaultValue = 50f, bool floor = false, bool percent = true, bool PureValue = false)
        {
            return new Slider(transform, text, tooltip, onSliderAdjust, minValue, maxValue, defaultValue, floor, percent, false, PureValue)
            {
                sliderText =
                {
                    text = "\r\n\r\n\r\n" + text
                }
            };
        }
        #endregion
    }
}
