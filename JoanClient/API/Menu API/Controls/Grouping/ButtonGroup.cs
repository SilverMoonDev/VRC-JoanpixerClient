using MelonLoader;
using JoanpixerButtonAPI.Misc;
using JoanpixerButtonAPI.Pages;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace JoanpixerButtonAPI.Controls.Grouping
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
            }

            gameObject = Object.Instantiate(ButtonAPI.buttonGroupBase, parent);
            gameObject.transform.DestroyChildren();

            gameObject.GetOrAddComponent<GridLayoutGroup>().childAlignment = ButtonAlignment;
            parentMenuMask = parent.parent.GetOrAddComponent<RectMask2D>();

            var Handler = gameObject.GetOrAddComponent<ObjectHandler>();

            Handler.OnUpdateEachSecond += (obj, IsEnabled) =>
            {
                if (IsEnabled)
                {
                    var rows = (int) Mathf.Ceil((obj.transform.childCount / 4f));

                    obj.GetComponent<RectTransform>().sizeDelta = new Vector2(1024, (208 * rows));
                }
            };
        }

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
    }
}