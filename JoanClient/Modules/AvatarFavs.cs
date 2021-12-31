using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using MelonLoader;
using System.Collections;
using VRC.Core;
using VRC.UI;
using JoanpixerClient.Api;
using JoanpixerClient.Api.Object;
using System.IO;
using Newtonsoft.Json;

namespace JoanpixerClient.Modules
{
    class AvatarFavs : MonoBehaviour
    {
        public void Start()
        {
            avatarPage = GameObject.Find("UserInterface/MenuContent/Screens/Avatar");
            PublicAvatarList = GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Favorite Avatar List");
            currPageAvatar = avatarPage.GetComponent<PageAvatar>();
            AvatarList = new VRCList(PublicAvatarList.transform.parent, "Joanpixer Favorites", 0);
            AvatarObjects = JsonConvert.DeserializeObject<List<AvatarObject>>(File.ReadAllText("Joanpixer\\AvatarFavorites.json"));
            GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Joanpixer Favorites/GetMoreFavorites").SetActive(true);
            GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Joanpixer Favorites/GetMoreFavorites/MoreFavoritesButton").GetComponent<Image>().color = Color.magenta;
            GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Joanpixer Favorites/GetMoreFavorites").GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
            GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Joanpixer Favorites/GetMoreFavorites").GetComponent<Button>().onClick.AddListener(new Action(() => { FavButton_OnClick(); })); 
            GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Joanpixer Favorites/GetMoreFavorites/MoreFavoritesText").GetComponent<Text>().text = " Fav/UnFav Avatar";
            GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Joanpixer Favorites/GetMoreFavorites/MoreFavoritesText").GetComponent<Text>().color = Color.white;
            GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Joanpixer Favorites/GetMoreFavorites/MoreFavoritesText").name = "Fav/UnFav Text";
            GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Joanpixer Favorites/GetMoreFavorites/MoreFavoritesButton").name = "Fav/UnFav Button Color";
            GameObject.Find("UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Joanpixer Favorites/GetMoreFavorites").name = "Fav/UnFav Button";
        }

        public void Update()
        {
            try
            {
                if (avatarPage.activeSelf && !JustOpened)
                {
                    JustOpened = true;
                    MelonCoroutines.Start(RefreshMenu(1f));
                }
                else if (!avatarPage.activeSelf && JustOpened)
                    JustOpened = false;
            }
            catch { }
        }

        public static IEnumerator RefreshMenu(float v)
        {
            yield return new WaitForSeconds(v);
            var avilist = new Il2CppSystem.Collections.Generic.List<ApiAvatar>();
            AvatarObjects.ForEach(avi => avilist.Add(avi.ToApiAvatar()));
            AvatarList.RenderElement(avilist);
            yield break;
        }

        internal static void FavoriteAvatar(ApiAvatar avatar)
        {
            if (!AvatarObjects.Exists(avi => avi.id == avatar.id))
                AvatarObjects.Insert(0, new AvatarObject(avatar));
            MelonCoroutines.Start(RefreshMenu(1f));
            string contents = JsonConvert.SerializeObject(AvatarObjects, Formatting.Indented);
            File.WriteAllText("Joanpixer\\AvatarFavorites.json", contents);
        }
        internal static void UnfavoriteAvatar(ApiAvatar avatar)
        {
            if (AvatarObjects.Exists(avi => avi.id == avatar.id))
            {
                AvatarObjects.Remove(AvatarObjects.Where(avi => avi.id == avatar.id).FirstOrDefault());
            }
            MelonCoroutines.Start(RefreshMenu(1f));
            string contents = JsonConvert.SerializeObject(AvatarObjects, Formatting.Indented);
            File.WriteAllText("Joanpixer\\AvatarFavorites.json", contents);
        }

        void FavButton_OnClick()
        {
            if (!AvatarObjects.Exists(m => m.id == currPageAvatar.field_Public_SimpleAvatarPedestal_0.field_Internal_ApiAvatar_0.id))
            {
                FavoriteAvatar(currPageAvatar.field_Public_SimpleAvatarPedestal_0.field_Internal_ApiAvatar_0);
            }
            else
            {
                UnfavoriteAvatar(currPageAvatar.field_Public_SimpleAvatarPedestal_0.field_Internal_ApiAvatar_0);
            }
            MelonCoroutines.Start(AvatarFavs.RefreshMenu(1));
        }

        private static VRCList AvatarList;
        public static List<AvatarObject> AvatarObjects = new List<AvatarObject>();
        private bool JustOpened = false;
        private static GameObject avatarPage;
        private static PageAvatar currPageAvatar;
        private static GameObject PublicAvatarList;
        public AvatarFavs(IntPtr ptr) : base(ptr) { }
    }
}
