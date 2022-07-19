using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

namespace ForbiddenClient.API.ConsoleUtils
{
    public class VRConsole
    {
		private static GameObject CanvasObject;

		private static GameObject BackgroundObject;

		private static GameObject TextObject;

		private static Image BackgroundImage;

		private static TextMeshProUGUI TextText;

		public static bool Initialized = false;

		public static bool enabled = true;

		public static IEnumerator Create()
		{
			while (GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Button/Icon") == null)
            {
				yield return null;
            }
			CanvasObject = new GameObject("ForbiddenClientConsole");
			CanvasObject.transform.parent = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Button/Icon").transform;
			CanvasObject.transform.localScale = new Vector3(1.6f, 1.6f, 1.6f);
			CanvasObject.transform.localPosition = new Vector3(77.5542f, 59f, 0f);
			CanvasObject.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
			BackgroundObject = new GameObject("Background");
			BackgroundObject.AddComponent<CanvasRenderer>();
			BackgroundImage = BackgroundObject.AddComponent<Image>();
			BackgroundObject.GetComponent<RectTransform>().anchorMin = new Vector2(0f, 1f);
			BackgroundObject.GetComponent<RectTransform>().anchorMax = new Vector2(0f, 1f);
			BackgroundObject.GetComponent<RectTransform>().pivot = new Vector2(0f, 1f);
			BackgroundObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, -5f);
			BackgroundObject.GetComponent<RectTransform>().sizeDelta = new Vector2(670, 765);
			BackgroundObject.transform.SetParent(CanvasObject.transform, false);
			BackgroundImage.sprite = (Environment.CurrentDirectory + "\\Forbidden\\Console.png").LoadSpriteFromDisk();
			BackgroundImage.color = new Color(0.6557f, 0f, 0.8492f, 0.4f);
			TextObject = new GameObject("Text");
			TextObject.AddComponent<CanvasRenderer>();
			TextObject.transform.SetParent(BackgroundObject.transform, false);
			TextText = TextObject.AddComponent<TextMeshProUGUI>();
			TextText.alignment = 0;
			TextText.fontSize = 15f;
			TextText.text = "";
			TextObject.GetComponent<RectTransform>().sizeDelta = new Vector2(610f, 768f);
			TextObject.transform.localPosition = new Vector3(7.38f, 0f, 0f);
			CanvasObject.SetActive(true);
			TextObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-315.112f, 350);
			TextObject.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(-315.112f, 350, 0);
			TextObject.GetComponent<RectTransform>().offsetMax = new Vector2(19.888f, 734);
			TextObject.GetComponent<RectTransform>().offsetMin = new Vector2(-650.112f, -34);
			Initialized = true;
			yield return null;
			yield break;
		}
		public static void SetText(string text)
        {
			TextText.text = text;
        }
        public GameObject InfoIconObject;
        public GameObject InfoGameObject;
        public Text Text;
        public Image Image;
    }
}