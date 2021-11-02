using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Il2CppSystem.Collections.Generic;
using JoanpixerClient.Wrappers;
using UnityEngine;
using VRC;
using System.Collections.Generic;
using VRC.Core;

namespace JoanpixerClient
{
    class Utils
    {
        /// <summary>
        /// Returns the local VRCPlayer.
        /// </summary>
        public static VRCPlayer GetLocalPlayer()
        {
            return VRCPlayer.field_Internal_Static_VRCPlayer_0;
        }

        /// <summary>
        /// Returns a list of active players.
        /// </summary>
        public static Il2CppSystem.Collections.Generic.List<Player> GetAllPlayers()
        {
            // Make sure the PlayerManager exists first.
            if (PlayerManager.field_Private_Static_PlayerManager_0 == null)
            {
                return null;
            }

            return PlayerManager.field_Private_Static_PlayerManager_0?.field_Private_List_1_Player_0;
        }


        public static void SelectYourself()
        {
            Wrappers.Wrappers.GetQuickMenu().SelectPlayer(GetLocalPlayer().prop_Player_0);
        }

        /// <summary>
        /// Get a player object out of the specified player id.
        /// </summary>
        /// <param name="playerId">The player id to fetch.</param>
        public static Player GetPlayer(string playerId)
        {
            var players = GetAllPlayers();

            foreach (Player player in players)
            {
                // Make sure the player is valid first.
                if (player == null)
                {
                    continue;
                }

                if (player.field_Private_APIUser_0.id == playerId)
                {
                    return player;
                }
            }

            return null;
        }

        public static string GetGameObjectPath(GameObject obj)
        {
            string path = "/" + obj.name;
            while (obj.transform.parent != null)
            {
                obj = obj.transform.parent.gameObject;
                path = "/" + obj.name + path;
            }
            return path;
        }

        public static QuickMenu quickmenuuser = null;

        public static QuickMenu GetQuickMenuInstance()
        {
            if (quickmenuuser == null)
            {
                quickmenuuser = QuickMenu.prop_QuickMenu_0;
            }
            return quickmenuuser;
        }

        public static VRCPlayer GetSelectedPlayer() { return GetQuickMenuInstance().field_Private_Player_0._vrcplayer; }

        public static void ToggleOutline(Renderer renderer, bool state)
        {
            if (HighlightsFX.prop_HighlightsFX_0 == null)
            {
                return;
            }

            HighlightsFX.prop_HighlightsFX_0.Method_Public_Void_Renderer_Boolean_0(renderer, state);
        }

        [System.Serializable]
        public struct HSBColor
        {
            public float h;
            public float s;
            public float b;
            public float a;

            public HSBColor(float h, float s, float b, float a)
            {
                this.h = h;
                this.s = s;
                this.b = b;
                this.a = a;
            }

            public HSBColor(float h, float s, float b)
            {
                this.h = h;
                this.s = s;
                this.b = b;
                this.a = 1f;
            }

            public HSBColor(Color col)
            {
                HSBColor temp = FromColor(col);
                h = temp.h;
                s = temp.s;
                b = temp.b;
                a = temp.a;
            }

            public static HSBColor FromColor(Color color)
            {
                HSBColor ret = new HSBColor(0f, 0f, 0f, color.a);

                float r = color.r;
                float g = color.g;
                float b = color.b;

                float max = Mathf.Max(r, Mathf.Max(g, b));

                if (max <= 0)
                {
                    return ret;
                }

                float min = Mathf.Min(r, Mathf.Min(g, b));
                float dif = max - min;

                if (max > min)
                {
                    if (g == max)
                    {
                        ret.h = (b - r) / dif * 60f + 120f;
                    }
                    else if (b == max)
                    {
                        ret.h = (r - g) / dif * 60f + 240f;
                    }
                    else if (b > g)
                    {
                        ret.h = (g - b) / dif * 60f + 360f;
                    }
                    else
                    {
                        ret.h = (g - b) / dif * 60f;
                    }
                    if (ret.h < 0)
                    {
                        ret.h = ret.h + 360f;
                    }
                }
                else
                {
                    ret.h = 0;
                }

                ret.h *= 1f / 360f;
                ret.s = (dif / max) * 1f;
                ret.b = max;

                return ret;
            }

            public static Color ToColor(HSBColor hsbColor)
            {
                float r = hsbColor.b;
                float g = hsbColor.b;
                float b = hsbColor.b;

                if (hsbColor.s != 0)
                {
                    float max = hsbColor.b;
                    float dif = hsbColor.b * hsbColor.s;
                    float min = hsbColor.b - dif;

                    float h = hsbColor.h * 360f;

                    if (h < 60f)
                    {
                        r = max;
                        g = h * dif / 60f + min;
                        b = min;
                    }
                    else if (h < 120f)
                    {
                        r = -(h - 120f) * dif / 60f + min;
                        g = max;
                        b = min;
                    }
                    else if (h < 180f)
                    {
                        r = min;
                        g = max;
                        b = (h - 120f) * dif / 60f + min;
                    }
                    else if (h < 240f)
                    {
                        r = min;
                        g = -(h - 240f) * dif / 60f + min;
                        b = max;
                    }
                    else if (h < 300f)
                    {
                        r = (h - 240f) * dif / 60f + min;
                        g = min;
                        b = max;
                    }
                    else if (h <= 360f)
                    {
                        r = max;
                        g = min;
                        b = -(h - 360f) * dif / 60 + min;
                    }
                    else
                    {
                        r = 0;
                        g = 0;
                        b = 0;
                    }
                }

                return new Color(Mathf.Clamp01(r), Mathf.Clamp01(g), Mathf.Clamp01(b), hsbColor.a);
            }

            public Color ToColor()
            {
                return ToColor(this);
            }

            public override string ToString()
            {
                return "H:" + h + " S:" + s + " B:" + b;
            }

            public static HSBColor Lerp(HSBColor a, HSBColor b, float t)
            {
                float h, s;

                // check special case black (color.b == 0): interpolate neither hue nor saturation!
                // check special case grey (color.s == 0): don't interpolate hue!
                if (a.b == 0)
                {
                    h = b.h;
                    s = b.s;
                }
                else if (b.b == 0)
                {
                    h = a.h;
                    s = a.s;
                }
                else
                {
                    if (a.s == 0)
                    {
                        h = b.h;
                    }
                    else if (b.s == 0)
                    {
                        h = a.h;
                    }
                    else
                    {
                        // works around bug with LerpAngle
                        float angle = Mathf.LerpAngle(a.h * 360f, b.h * 360f, t);
                       
                        while (angle < 0f)
                        {
                            angle += 360f;
                        }
                        
                        while (angle > 360f)
                        {
                            angle -= 360f;
                        }

                        h = angle / 360f;
                    }

                    s = Mathf.Lerp(a.s, b.s, t);
                }

                return new HSBColor(h, s, Mathf.Lerp(a.b, b.b, t), Mathf.Lerp(a.a, b.a, t));
            }
        }
    }
    public class Serialization
    {
        public static byte[] ToByteArray(Il2CppSystem.Object obj)
        {
            if (obj == null) return null;
            var bf = new Il2CppSystem.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            var ms = new Il2CppSystem.IO.MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }
        public static byte[] ToByteArray(object obj)
        {
            if (obj == null) return null;
            var bf = new BinaryFormatter();
            var ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        public static T FromByteArray<T>(byte[] data)
        {
            if (data == null) return default(T);
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream(data))
            {
                object obj = bf.Deserialize(ms);
                return (T)obj;
            }
        }
        public static T IL2CPPFromByteArray<T>(byte[] data)
        {
            if (data == null) return default(T);
            var bf = new Il2CppSystem.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            var ms = new Il2CppSystem.IO.MemoryStream(data);
            object obj = bf.Deserialize(ms);
            return (T)obj;
        }

        public static T FromIL2CPPToManaged<T>(Il2CppSystem.Object obj)
        {
            return FromByteArray<T>(ToByteArray(obj));
        }

        public static T FromManagedToIL2CPP<T>(object obj)
        {
            return IL2CPPFromByteArray<T>(ToByteArray(obj));
        }

        public static object[] FromIL2CPPArrayToManagedArray(Il2CppSystem.Object[] obj)
        {
            object[] Parameters = new object[obj.Length];
            for (int i = 0; i < obj.Length; i++)
                Parameters[i] = FromIL2CPPToManaged<object>(obj[i]);
            return Parameters;
        }
        public static Il2CppSystem.Object[] FromManagedArrayToIL2CPPArray(object[] obj)
        {
            Il2CppSystem.Object[] Parameters = new Il2CppSystem.Object[obj.Length];
            for (int i = 0; i < obj.Length; i++)
                Parameters[i] = FromManagedToIL2CPP<Il2CppSystem.Object>(obj[i]);
            return Parameters;
        }
    }
}
