using System;
using MelonLoader;
using ForbiddenButtonAPI.Controls.Grouping;
using ForbiddenButtonAPI.Pages;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace ForbiddenButtonAPI.Controls
{
    public class Slider : Base_Classes.GenericControl
    {
        public readonly TextMeshProUGUI sliderText;

        public readonly TextMeshProUGUI sliderPercentText;

        public readonly UnityEngine.UI.Slider sliderSlider;

        public readonly VRC.UI.Elements.Tooltips.UiTooltip sliderTooltip;

        private readonly bool _floor;

        private readonly bool _percent;

        private readonly bool _pureValue;

        public Slider(Transform parent, string text, string tooltip, Action<float> onSliderAdjust, float minValue = 0f, float maxValue = 100f, float defaultValue = 50f, bool floor = false, bool percent = true, bool isGroup = false) : this(parent, text, tooltip, onSliderAdjust, minValue, maxValue, defaultValue, floor, percent, isGroup, false)
        {
        }

        public Slider(Transform parent, string text, string tooltip, Action<float> onSliderAdjust, float minValue = 0f, float maxValue = 100f, float defaultValue = 50f, bool floor = false, bool percent = true, bool isGroup = false, bool PureValue = false)
        {
            var slider = this;
            gameObject = UnityEngine.Object.Instantiate(ButtonAPI.sliderBase, parent);

            sliderText = gameObject.transform.GetChild(0).GetComponentInChildren<TextMeshProUGUI>(true);
            sliderText.text = text;
            if (isGroup)
            {
                sliderText.transform.position -= new Vector3(0f, 35f, 0f);
            }

            sliderPercentText = gameObject.transform.GetChild(1).GetComponentInChildren<TextMeshProUGUI>(true);
            if (isGroup)
            {
                sliderPercentText.transform.position -= new Vector3(0f, 35f, 0f);
            }

            sliderSlider = gameObject.GetComponentInChildren<UnityEngine.UI.Slider>(true);
            sliderSlider.onValueChanged = new UnityEngine.UI.Slider.SliderEvent();
            sliderSlider.minValue = minValue;
            sliderSlider.maxValue = maxValue;
            if (isGroup)
            {
                sliderSlider.transform.position += new Vector3(0f, 40f, 0f);
            }

            sliderSlider.onValueChanged.AddListener((Action<float>)delegate (float val)
            {
                slider.sliderPercentText.text = PureValue ? val.ToString() : (floor ? Mathf.Floor(val).ToString("0.00") : val.ToString("0.00")) + (percent ? "%" : "");
                onSliderAdjust?.Invoke(val);
            });

            sliderSlider.Set(defaultValue, false);

            sliderSlider.value = defaultValue;

            var Handler = slider.sliderPercentText.gameObject.AddComponent<ObjectHandler>();

            Handler.OnEnabled += (obj) =>
            {
                slider.sliderPercentText.text = PureValue ? defaultValue.ToString() : (floor ? Mathf.Floor(defaultValue).ToString() : defaultValue.ToString("0.00")) + (percent ? "%" : "");

                Object.Destroy(Handler);
            };

            sliderTooltip = gameObject.GetComponentInChildren<VRC.UI.Elements.Tooltips.UiTooltip>(true);
            
            if (!string.IsNullOrEmpty(tooltip))
            {
                sliderTooltip.field_Public_String_0 = tooltip;
            }
            else
            {
                sliderTooltip.enabled = false;
            }

            _floor = floor;
            _percent = percent;
        }

        [Obsolete("This constructor is obsolete. Please use YourMenuPage.AddSlider() instead.", true)]
        public Slider(MenuPage pge, string text, string tooltip, Action<float> onSliderAdjust, float minValue = 0f, float maxValue = 100f, float defaultValue = 50f, bool floor = false, bool percent = true, bool isGroup = false) : this(pge, text, tooltip, onSliderAdjust, minValue, maxValue, defaultValue, floor, percent, isGroup, false)
        {
        }

        [Obsolete("This constructor is obsolete. Please use YourMenuPage.AddSlider() instead.", true)]
        public Slider(MenuPage pge, string text, string tooltip, Action<float> onSliderAdjust, float minValue = 0f, float maxValue = 100f, float defaultValue = 50f, bool floor = false, bool percent = true, bool isGroup = false, bool PureValue = false)
            : this(pge.menuContents, text, tooltip, onSliderAdjust, minValue, maxValue, defaultValue, floor, percent, isGroup, PureValue)
        {
            if (!pge.Gridified)
            {
                gameObject.GetComponent<LayoutElement>().minHeight = 115;
            }
            else
            {
                sliderText.text = "\r\n\r\n\r\n" + text;
            }
        }

        [Obsolete("This constructor is obsolete. Please use YourButtonGroup.AddSlider() instead.", true)]
        public Slider(ButtonGroup grp, string text, string tooltip, Action<float> onSliderAdjust, float minValue = 0f, float maxValue = 100f, float defaultValue = 50f, bool floor = false, bool percent = true, bool isGroup = false) : this(grp, text, tooltip, onSliderAdjust, minValue, maxValue, defaultValue, floor, percent, isGroup, false)
        {
            sliderText.text = "\r\n\r\n\r\n" + text;
        }

        [Obsolete("This constructor is obsolete. Please use YourButtonGroup.AddSlider() instead.", true)]
        public Slider(ButtonGroup grp, string text, string tooltip, Action<float> onSliderAdjust, float minValue = 0f, float maxValue = 100f, float defaultValue = 50f, bool floor = false, bool percent = true, bool isGroup = false, bool PureValue = false)
            : this(grp.transform, text, tooltip, onSliderAdjust, minValue, maxValue, defaultValue, floor, percent, isGroup, PureValue)
        {
            sliderText.text = "\r\n\r\n\r\n" + text;
        }

        [Obsolete("This constructor is obsolete. Please use YourCollapsibleButtonGroup.AddSlider() instead.", true)]
        public Slider(CollapsibleButtonGroup grp, string text, string tooltip, Action<float> onSliderAdjust, float minValue = 0f, float maxValue = 100f, float defaultValue = 50f, bool floor = false, bool percent = true, bool isGroup = false) : this(grp, text, tooltip, onSliderAdjust, minValue, maxValue, defaultValue, floor, percent, isGroup, false)
        {
            sliderText.text = "\r\n\r\n\r\n" + text;
        }

        [Obsolete("This constructor is obsolete. Please use YourCollapsibleButtonGroup.AddSlider() instead.", true)]
        public Slider(CollapsibleButtonGroup grp, string text, string tooltip, Action<float> onSliderAdjust, float minValue = 0f, float maxValue = 100f, float defaultValue = 50f, bool floor = false, bool percent = true, bool isGroup = false, bool PureValue = false)
            : this(grp.buttonGroup, text, tooltip, onSliderAdjust, minValue, maxValue, defaultValue, floor, percent, isGroup, PureValue)
        {
            sliderText.text = "\r\n\r\n\r\n" + text;
        }

        public void SetAction(Action<float> newAction)
        {
            sliderSlider.onValueChanged = new UnityEngine.UI.Slider.SliderEvent();
            sliderSlider.onValueChanged.AddListener((Action<float>)delegate (float val)
            {
                sliderPercentText.text = (_floor ? Mathf.Floor(val) : val) + (_percent ? "%" : "");
                newAction(val);
            });
        }

        public void SetText(string newText)
        {
            sliderText.text = newText;
        }

        public void SetTooltip(string newTooltip)
        {
            sliderTooltip.field_Public_String_0 = newTooltip;
        }

        public void SetInteractable(bool val)
        {
            sliderSlider.interactable = val;
        }

        public void SetValue(float newValue, bool invoke = false)
        {
            sliderPercentText.text = _pureValue ? newValue.ToString() : (_floor ? Mathf.Floor(newValue).ToString("0.00") : newValue.ToString("0.00")) + (_percent ? "%" : "");

            var onValueChanged = sliderSlider.onValueChanged;

            sliderSlider.onValueChanged = new UnityEngine.UI.Slider.SliderEvent();
            sliderSlider.value = newValue;
            sliderSlider.onValueChanged = onValueChanged;

            if (invoke)
            {
                try
                {
                    sliderSlider.onValueChanged.Invoke(newValue);
                }
                catch (Exception e)
                {
                    MelonLogger.Error($"Slider: {sliderText.text} Failed To Invoke: {e}");
                }
            }
        }
    }
}
