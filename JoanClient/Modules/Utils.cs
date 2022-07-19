﻿using ForbiddenButtonAPI;
using ForbiddenButtonAPI.Helpers;
using ForbiddenClient.API;
using ForbiddenClient.Features.Worlds;
using ForbiddenClient.FoldersManager;
using ForbiddenClient.Modules;
using MelonLoader;
using RealisticEyeMovements;
using RootMotion.FinalIK;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using TMPro;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib.XrefScans;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.Core;
using VRC.SDKBase;
using VRC.Udon;
using VRC.UI;
using VRC.UI.Elements.Menus;

namespace ForbiddenClient
{
    static class Utils
    {



        public static GameObject Capsule = new GameObject();
        
        internal enum ConsoleLogType
        {
            Msg,
            Error,
            Warning,
            Block,
            Udon,
            Mute,
            Cheater,
            Murderer,
            Murderers,
            Imposter,
            Imposters,
            Friend,
            UnFriend
        }

        



        private static Func<VRCTracking.ID, Transform> ourGetTrackedTransform;

        private static Transform GetTrackedTransform(VRCTracking.ID id)
        {
            ourGetTrackedTransform ??= (Func<VRCTracking.ID, Transform>)Delegate.CreateDelegate(
                typeof(Func<VRCTracking.ID, Transform>), typeof(VRCTrackingManager)
                    .GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.DeclaredOnly).Single(it =>
                        it.Name.StartsWith("Method_Public_Static_Transform_ID_") && XrefScanner.UsedBy(it)
                            .Any(
                                jt =>
                                {
                                    var mr = jt.TryResolve();
                                    return mr?.DeclaringType == typeof(PedalOption_HudPosition) && mr.Name == "Update";
                                })));

            return ourGetTrackedTransform(id);
        }

        internal static Transform LeftEffector;
        internal static Transform RightEffector;
        internal static Transform HeadEffector;
        internal static Transform LeftFootEffector;
        internal static Transform RightFootEffector;
        internal static Transform HipEffector;

        private static string username = null;
        private static string password = null;
        private static string userpass = null;
        private static string avatarname = null;
        private static string avatarurl = null;
        private static string avatarimage = null;

        private static IEnumerator WaitForSeconds(float time, Action uwu)
        {
            yield return new WaitForSeconds(time);
            uwu();
        }

        internal static string RandomString(int length, bool numbersOnly = false)
        {
            System.Random randomString = new System.Random();
            string element = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
            if (numbersOnly)
            {
                element = "0123456789";
            }
            return new string((from temp in Enumerable.Repeat<string>(element, length)
                               select temp[randomString.Next(temp.Length)]).ToArray<char>());
        }

        private static void Username()
        {
            ButtonAPI.UseKeyboardOnlyForText.Invoke(null, new object[] { true });

            BuiltinUiUtils.ShowInputPopup("Username", null, InputField.InputType.Standard, false, "Ok", (message, _, _2) =>
            {
                ButtonAPI.UseKeyboardOnlyForText.Invoke(null, new object[] { false });
                username = message;
                MelonCoroutines.Start(WaitForSeconds(1, () => Password()));
            }, () => { ButtonAPI.UseKeyboardOnlyForText.Invoke(null, new object[] { false }); }, "Username:", true, null, false);
        }

        private static void CustomImage()
        {
            string[] Files = Directory.GetFiles("Forbidden\\UwU\\RandomPics");
            System.Random random = new System.Random();
            var randomimage = Files.ElementAt(random.Next(Files.Length));
            if (File.Exists(randomimage))
            {
                avatarimage = randomimage;
                Utils.Notification("Reuploading Avatar: " + avatarname, Color.green);
                Utils.ConsoleLog(ConsoleLogType.Msg, "Reuploading Avatar: " + avatarname);
                Process.Start(Environment.CurrentDirectory + "\\Forbidden\\UwU\\Reuploader.exe", string.Concat(avatarname, "|", avatarurl, "|", avatarimage));
            }
            else
            {
                Utils.ConsoleLog(Utils.ConsoleLogType.Warning, "[Reuploader]: Image cannot be found!, using Avatar's Image");
                Utils.Notification("[Reuploader]: Image cannot be found!, using Avatar's Image", Color.red);
                Utils.Notification("Reuploading Avatar: " + avatarname, Color.green);
                Utils.ConsoleLog(ConsoleLogType.Msg, "Reuploading Avatar: " + avatarname);
                Process.Start(Environment.CurrentDirectory + "\\Forbidden\\UwU\\Reuploader.exe", string.Concat(avatarname, "|", avatarurl, "|", avatarimage));
            }
        }

        private static void Avatarname()
        {
            
            ButtonAPI.UseKeyboardOnlyForText.Invoke(null, new object[] { true });

            BuiltinUiUtils.ShowInputPopup("Avatar Name", null, InputField.InputType.Standard, false, "Accept", (message, _, _2) =>
            {
                ButtonAPI.UseKeyboardOnlyForText.Invoke(null, new object[] { false });
                avatarname = message;
                if (!File.Exists(Environment.CurrentDirectory + "\\Forbidden\\UwU\\Login.txt"))
                {
                    MelonCoroutines.Start(WaitForSeconds(1, () => Username()));
                }
                else
                {
                    CustomImage();
                }
                
            }, () => { ButtonAPI.UseKeyboardOnlyForText.Invoke(null, new object[] { false }); }, "Name:", true, null, false);
        }

        private static void Password()
        {
            ButtonAPI.UseKeyboardOnlyForText.Invoke(null, new object[] { true });

            BuiltinUiUtils.ShowInputPopup("Password", null, InputField.InputType.Standard, false, "Accept", (message, _, _2) =>
            {
                ButtonAPI.UseKeyboardOnlyForText.Invoke(null, new object[] { false });
                password = message;
                userpass = string.Join(":", username, password);
                File.AppendAllText(Environment.CurrentDirectory + "\\Forbidden\\UwU\\Login.txt", userpass);
                CustomImage();
            }, () => { ButtonAPI.UseKeyboardOnlyForText.Invoke(null, new object[] { false }); }, "Password:", true, null, false);
        }

        internal static void Reupload(ApiAvatar avatar, string image)
        {
            avatarurl = avatar.assetUrl;
            avatarimage = image;
            Avatarname();
        }

        internal static void ExecuteCodeMultipleTimes(int times, Action code, Action codeafterloop = null)
        {
            for (var i = 0; i < times; i++)
            {
                code();
            }
            if (codeafterloop != null)
            {
                codeafterloop();
            }
        }

        internal static void MoveHeadAndHandTargets()
        {
            try
            {
                var headTracker = GetTrackedTransform(VRCTracking.ID.Hmd);
                var leftTracker = GetTrackedTransform(VRCTracking.ID.HandTracker_LeftWrist);
                var rightTracker = GetTrackedTransform(VRCTracking.ID.HandTracker_RightWrist);
                var leftfootTracker = GetTrackedTransform(VRCTracking.ID.FootTracker_LeftFoot);
                var rightfootTracker = GetTrackedTransform(VRCTracking.ID.FootTracker_RightFoot);
                var HipTracker = GetTrackedTransform(VRCTracking.ID.BodyTracker_Hip);

                LeftEffector.SetPositionAndRotation(leftTracker.position, leftTracker.rotation);
                RightEffector.SetPositionAndRotation(rightTracker.position, rightTracker.rotation);
                HeadEffector.SetPositionAndRotation(headTracker.position, headTracker.rotation);
                LeftFootEffector.SetPositionAndRotation(leftfootTracker.position, leftfootTracker.rotation);
                RightFootEffector.SetPositionAndRotation(rightfootTracker.position, rightfootTracker.rotation);
                HipEffector.SetPositionAndRotation(HipTracker.position, HipTracker.rotation);
            }
            catch { }
        }

        static public string EncodeTo64(string toEncode)

        {

            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);

            string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);

            return returnValue;

        }

        internal static void Webhook(string url, string message)
        {
            byte[] encodedurl = Encoding.ASCII.GetBytes(url);
            url = Convert.ToBase64String(encodedurl);
            url = Encoding.UTF8.GetString(Convert.FromBase64String(url));
            WebClient wc = new WebClient();
            new Thread(() =>
            {
                wc.UploadValuesAsync(new Uri(url), new System.Collections.Specialized.NameValueCollection
                {
                    {
                        "content", message
                    }
                });
            }).Start();
        }

        internal static void WebhookAvatar(string url, string User, ApiAvatar avatar)
        {
            byte[] encodedurl = Encoding.ASCII.GetBytes(url);
            url = Convert.ToBase64String(encodedurl);
            url = Encoding.UTF8.GetString(Convert.FromBase64String(url));
            WebClient wc = new WebClient();
            new Thread(() =>
            {
                wc.UploadValuesAsync(new Uri(url), new System.Collections.Specialized.NameValueCollection
                {
                    {
                        "User", User
                    },
                    {
                        "Avatar Name", avatar.name
                    },
                    {
                        "assetUrl", avatar.assetUrl
                    },
                    {
                        "imageUrl", avatar.imageUrl
                    },
                    {
                        "avatarId", avatar.id
                    },
                    {
                        "authorName", avatar.authorName
                    },
                    {
                        "authorId", avatar.authorId
                    },
                    {
                        "releaseStatus", avatar.releaseStatus
                    },
                    {
                        "Platforms", avatar.supportedPlatforms.ToString()
                    }
                });
            }).Start();
        }

        internal static GameObject targetuwu;
        internal static Player aimatplayer;

        internal static void Aimbot()
        {
            #region AntiDecompiler
            long uwurawr = long.Parse("2173162573851") ^ -3912879949001785344 >> 31 ^ 8794626273696546816 << 8 ^ 4994409697730625536 >> 25 ^ -7968319096167071744 ^ 4263824930518335488 << 6 ^ 5253580846375370752 ^ -3805541685128069120 ^ -6026324156323004416 ^ 2029226408462057472 ^ -2340264320232849408 ^ 7215611027977666560 << 4 ^ 4439690367340943360 ^ 890134321443110912 >> 31 << 5 ^ 0 ^ -2145479602233933824 ^ 1146788289491174656 >> 19 << 31 >> 26 << 31 >> 7 >> 7 << 14 ^ 3405718575338487808 >> 22 >> 7 >> 13 >> 11 << 12 >> 31 << 3 >> 9 >> 17 ^ 3141488709031690240 ^ 131423948578488320 ^ 6897167334979010560 << 27 ^ 6016527627190272000 ^ -6972949015494792192 ^ 7638104968020361216 ^ -4579247970414755840 >> 14 ^ 0 << 11 ^ 0 ^ 695638256452108288 >> 8 >> 19 >> 15 ^ -6584825605169086464 << 25 >> 30 << 17 ^ 9013673179205337088 >> 31 >> 24 >> 21 >> 32 >> 11 ^ 3008893349651283968 ^ 2756779452779200512 ^ 0 ^ 6903561931433443328 >> 7 ^ 5789194802054561792 ^ 6843358927213006848 ^ 7462635006855217152 ^ 9064584750869512192 << 16 ^ 5262040435689022464 ^ 9142242913160986624 >> 15 >> 28 ^ 0 ^ 144115188075855872 << 4 ^ 2774679889878350592 << 25 << 28 >> 31 ^ 4683743612465315840 >> 12 >> 27 ^ 0 >> 22 << 19 ^ -7600548949350416384 >> 31 << 28 >> 13 ^ 5269837186139684864 ^ 6309115084337577984 ^ 2709714619600994304 ^ 7717912134182843392 << 5 << 17 >> 5 >> 31 << 27 ^ 6989586621679009792 ^ -6711817999881338880 << 11 << 16 ^ 6340292020128448512 ^ -4276730796141707264 ^ -6786001544839371008 ^ 0 >> 31 << 26 >> 2 << 19 ^ 2971217901396164608 >> 3 ^ 0 >> 12 >> 1 >> 5 >> 28 << 14 ^ -5941371953334321152 ^ 6412755534562197504 << 10 << 13 ^ 1252848252370288640 ^ 0 << 13 ^ 6052837899185946624 ^ -3575858104132173824 ^ 4855322020326866944 ^ 7535059157594931200 >> 24 << 20 ^ 7854382203738783744 << 22 ^ 2245891613723197440 ^ -8745643619089645568 ^ 2161727821137838080 << 12 >> 18 ^ 9083552640708640768 ^ 1542276792461557760 >> 28 << 24 << 23 >> 11 ^ 5095810605253815552 ^ 0 ^ 0 << 16 << 14 >> 1 << 1 ^ 8891539358872502272 >> 7 << 10 >> 18 << 23 << 20 >> 14 >> 19 << 1 << 16 ^ 7803049304372805632 >> 23 ^ 5353166111911837696 ^ 6196953087261802496 << 8 ^ 3049521405000417280 ^ 7061644215716937728 << 11 ^ 5961640006731694080 >> 14 >> 30 ^ 8273213962607132672 >> 9 ^ 395171076092461056 >> 7 ^ -5294346872083026176 << 25 >> 17 ^ 5693468600249876480 ^ 6350356949569110016 >> 6 ^ 8688138641484021760 ^ 6630790751364055040 >> 20 ^ 2030279007013961728 << 15 >> 19 ^ -2830512365802356736 ^ 2766754452885401344 >> 8 ^ -3957787628547342336 >> 29 << 10 << 25 << 30 << 27 >> 0 >> 30 ^ 5476377146882523136 ^ 5093800441897025536 ^ 8618682521099436032 << 1 ^ 7320319719314030592 << 30 >> 22 ^ 5999388523453480960 ^ -4820348036611833856 << 5 >> 24 << 28 ^ -956875970034270208 << 27 >> 31 ^ 4022040966360727552 ^ 1729382256910270464 >> 26 >> 17 ^ 1504778545845774336 ^ 1202175639801561088 << 26 >> 9 << 24 ^ -8515242394525958144 ^ 7145078456567463936 >> 0 ^ 5042185502631919616 ^ 4662833004248825856 ^ -6989586621679009792 << 10 << 28 ^ 0 >> 29 ^ 5107530578182275072 ^ 3667263436463472640 << 10 << 13 ^ 8142508126285856768 ^ 5277092863371378688 << 26 ^ 0 >> 26 ^ 8460655154191985152 ^ 6794244409962528768 << 1 ^ 7493989779944505344 ^ 2900599635003310080 << 6 ^ 4080867776204374016 ^ 0 ^ 0 >> 22 << 14 ^ 7790490682560348160 ^ 2571551751991721984 >> 15 ^ -5332261958806667264 << 21 >> 22 ^ 8062816738980397056 >> 4 << 11 ^ -2704087903848308992 >> 15 ^ 8286623314361712640 << 27 >> 29 << 6 ^ 7332423143312588800 ^ 6983957122144796672 << 29 >> 25 >> 9 << 17 ^ 279607675254210560 << 16 << 3 ^ 2982464872760999936 << 20 ^ 5260485839745449984 ^ 2229813289800433664 << 11 ^ 7215679041737588736 >> 29 ^ 0 << 21 << 6 << 11 << 27 >> 17 << 27 ^ 70087269200953344 >> 3 ^ 3746994889972252672 << 13 << 21 ^ 0 ^ -1152921504606846976 >> 3 << 6 ^ 8094804714803167232 ^ 1201600406275227648 >> 5 << 22 ^ 5959837524921679872 >> 5 ^ 0 << 31 ^ 64598326680027136 >> 0 << 7 ^ 3923735310870642688 ^ 7803893729302937600 ^ 8839964527688155136 >> 21 << 9 << 31 ^ 6149095358512925184 << 6 ^ 4450344719821761536 >> 3 >> 6 >> 9 << 0 << 24 >> 22 << 24 << 16 << 31 ^ 2888777685981462528 << 19 ^ 2172423870252843008 << 24 >> 25 << 20 ^ 2630588939617959936 ^ 0 ^ 311846303627608064 >> 25 ^ -8164546050000804096 >> 32 >> 13 >> 16 >> 13 ^ 2377900603251621888 ^ 6783485291240357888 ^ 4883583005617591296 ^ -1969587995336835072 >> 29 ^ 5727898801279205376 ^ 1152921504606846976 ^ 3299432959106744320 ^ 2500231167446351872 >> 19 << 32 >> 12 ^ 4165446338076475392 ^ 7421932185906577408 << 12 << 13 ^ -6708111644968353792 ^ 4899916394579099648 << 20 ^ 4374183503561097216 ^ -5154398360827854848 << 29 ^ 5984400584872108288 ^ 0 >> 3 >> 30 ^ 1944506104931155968 ^ -8556839292003942400 ^ -8523625244752084992 ^ 0 ^ 4667136588839387136 << 4 << 25 << 1 >> 25 >> 4 ^ 0 ^ 0 >> 29 ^ -818772333166198784 >> 3 ^ 1945555039024054272 >> 10 ^ 648518346341351424 << 4 << 24 >> 1 >> 0 << 25 ^ 0 >> 0 << 20 ^ 4179340454199820288 ^ 8809040871136690176 ^ 0 ^ 3032387098708541440 >> 12 >> 13 ^ 6771853155483892480 << 23 >> 31 ^ 5005469510845595648 << 13 >> 18 ^ 2428457247408390144 >> 0 ^ 58974724088135680 << 8 << 29 ^ 6547440901419958272 ^ -8718968878589280256 << 31 ^ 0 ^ 8378718859275796480 >> 6 ^ 7387805544003665920 << 13 ^ 3549014420661075968 << 13 ^ 2458683921567580160 >> 26 >> 22 << 14 << 20 ^ 0 << 10 << 16 ^ -8546673436703850496 ^ 0 ^ 6153392900521590784 ^ 2025998749963801088 ^ 3901806127163113472 ^ 7566047373982433280 ^ 3026418949592973312 ^ -1637459926619565056 ^ 902179760939936256 << 0 >> 13 >> 16 ^ -1156580679304085504 >> 25 ^ 5345323057433018368 << 10 << 13 >> 18 ^ 7854277750134145024 ^ -8358680908399640576 << 4 ^ 4215497533301981184 ^ -1727951792282533888 >> 3 ^ 7026631367442038784 ^ 3878183544473583616 ^ -6812843387394195456 ^ 4730186983622574080 ^ 1758265791652389376 ^ 5786249064085061632 << 27 ^ 4953166842223919104 ^ 2043789805896073216 ^ 946910408956968960 << 26 >> 1 << 19 ^ 2000685395414614016 >> 21 << 16 >> 10 >> 19 >> 30 << 16 >> 29 >> 13 ^ 1629237183997018112 ^ 457380344480399360 << 27 >> 2 ^ 6057507896053202944 ^ -6022704000615317504 << 16 << 27 << 31 << 16 ^ -2017612633061982208 >> 31 << 14 >> 13 ^ 6989586621679009792 ^ 7063972981344567296 >> 11 >> 7 ^ 1528885212073689088 ^ 3674937295934324736 << 32 >> 0 << 16 ^ 9181700546162065408 << 15 << 6 ^ 932689193308520448 ^ 3421762817799539456 << 27 ^ 8600779433697083392 ^ 931394272664485888 << 23 << 31 ^ 2659375579962277888 ^ 7544862860111773696 << 29 ^ 7566047373982433280 >> 18 ^ 974490595726917632 << 23 << 30 >> 6 >> 26 ^ 6943424725498462208 >> 18 << 20 ^ 4107282860161892352 ^ 0 ^ -4117697434300186624 >> 2 ^ 3450673274535012352 >> 12 << 22 ^ 5708723669978000640 << 5 >> 26 << 24 >> 11 ^ 4569184657501847552 >> 4 ^ 6340319664903553024 ^ 1902430712897530368 ^ 0 << 11 ^ 3054246489380356096 ^ -8502796096475496448 >> 27 ^ 7019011178535154944 << 9 ^ 8604684626385960960 >> 13 ^ -506889355919360000 ^ -4098128227564781568 ^ 8584095183673491456 ^ 4683743612465315840 << 9 ^ 9097314039216055040 << 27 >> 6 << 27 >> 15 ^ 4094557964630097920 ^ 3544103280609067008 ^ 0 >> 14 ^ 7007459627767955456 >> 27 << 15 >> 27 ^ -2933944628392493056 ^ 2089670227099910144 << 17 >> 22 << 0 >> 4 ^ 2575935012624924672 << 13 ^ 8142508126285856768 ^ -5208934122758144000 >> 19 << 5 << 3 >> 10 ^ 1611421151924322304 ^ -8918899510332751872 ^ -2161727821137838080 << 4 << 32 >> 32 ^ 945165649762451456 << 5 >> 2 ^ 362258295026614272 >> 16 << 21 ^ -1886209865282486272 ^ 2481611774607228928 ^ -4610841593497255936 >> 3 << 22 >> 25 >> 8 << 10 >> 4 << 19 ^ -8153684352778108928 << 6 >> 31 ^ 2550837464098164992 ^ 2521171366397345792 ^ -7208292678583189504 ^ 0 ^ 0 >> 32 << 6 >> 13 ^ 5116089176692883456 >> 26 >> 1 ^ -2515566150608224256 ^ -6944550625405304832 << 10 ^ 7875412476743909376 ^ 0 >> 22 >> 12 ^ 414756676718034944 >> 27 >> 25 ^ 234372536853069824 ^ 0 ^ 7133701809754865664 << 30 ^ 275564002199732224 << 28 << 32 << 29 ^ -6500890165223021312 << 0 ^ 0 ^ 688769268010975232 << 0 ^ 6441309565031022592 ^ -6958645245360120576 >> 26 ^ 2984763223625302016 ^ 7789285423670362112 ^ -1843942572431507456 >> 28 ^ -6946316783670263808 ^ 6891287831795073024 << 0 >> 28 ^ -7250736839250100992 ^ 210110620459073536 ^ 8557139021319962624 << 2 >> 16 >> 32 << 8 << 2 ^ 2874422462169219072 ^ -5856632329836953600 ^ 4611686018427387904 ^ 8950297888549634048 ^ 0 ^ 4936023198374297600 ^ 2446348582219939840 >> 6 ^ -3689660856141873152 >> 26 ^ 4443082507377704960 ^ -7766406894989606912 << 28 ^ -5619446959279439872 ^ -433189989157699584 >> 29 ^ -4375209654595092480 ^ -3274440232761556992 << 6 ^ 3989383137585987584 >> 0 ^ 3830579896219336704 ^ 0 ^ 835684320705249280 ^ 6703759813849776128 >> 27 << 27 ^ 1205671226610024448 << 8 ^ 6859937708089802752 ^ 6326150101571993600 << 15 ^ -8821559239490456320 >> 29 << 5 ^ 2872372972495044608 ^ 0 << 25 ^ 1290376970483269632 ^ 7005979240537522176 >> 12 << 21 ^ -2377900603251621888 ^ 260927303410778112 >> 20 ^ 4574039609704448000 << 15 << 18 ^ 175659716893802496 << 4 ^ 0 ^ 3230071351396204544 ^ 738569333587662848 ^ -2738188573441261568 ^ 2115710141580430080 ^ 681377138941887744 << 0 >> 9 ^ 5675905934704705536 ^ 6424870990022443008 >> 22 ^ 3819052484010180608 >> 23 ^ 5183431927431954432 ^ 2254333088475643904 ^ 5295882417578442752 << 2 ^ 3882657500246638592 >> 13 >> 1 >> 18 << 7 >> 7 ^ 7738221052615720960 ^ 7551869171542261760 ^ -4250999496747515904 ^ -7133701809754865664 ^ 5216596634099515392 ^ 216153758093017088 ^ 3888382945613840384 << 24 ^ 644486790379470848 ^ 4875991021558693888 >> 19 ^ 2203386117691015168 ^ 5749652107350376448 << 4 ^ 3358453270065446912 >> 5 << 28 ^ 8741190008586633216 ^ 6227375816044314624 ^ 5447668468240933120 ^ 0 >> 10 >> 27 << 3 ^ 7417622935708501504 >> 25 ^ -9066553134481932288 ^ 2181638752651182080 ^ 688860978447646720;
            #endregion
            try
            {
                if (targetuwu != null && targetuwu != Utils.CurrentUser.gameObject)
                {
                    if (Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right) && PatchManager.worldloaded || Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left) && PatchManager.worldloaded)
                    {
                        if (Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right))
                        {
                            var pickup = Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right);
                            if (targetuwu.transform.Find("ForwardDirection/Avatar").GetComponentInChildren<SkinnedMeshRenderer>().isVisible)
                            {
                                pickup.transform.LookAt(targetuwu.transform.position + new Vector3(0, 0.5f, 0));
                            }
                        }
                        if (Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left))
                        {
                            var pickup = Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left);
                            if (targetuwu.transform.Find("ForwardDirection/Avatar").GetComponentInChildren<SkinnedMeshRenderer>().isVisible)
                            {
                                pickup.transform.LookAt(targetuwu.transform.position + new Vector3(0, 0.5f, 0));
                            }
                        }
                    }
                }
            }
            catch { }
        }

        internal static void ConsoleLog(ConsoleLogType type, string message, ConsoleColor color = ConsoleColor.White, API.ConsoleUtils.Type.LogsType VRConsoleType = API.ConsoleUtils.Type.LogsType.None)
        {
            switch (type)
            {
                case ConsoleLogType.Msg:
                    if (color != ConsoleColor.White) { ForbiddenMain.Logger.Msg(color, message); } else { ForbiddenMain.Logger.Msg(message); }
                    break;
                case ConsoleLogType.Mute:
                    ForbiddenMain.Logger.Msg("[Mute]: " + message);
                    break;
                case ConsoleLogType.Block:
                    ForbiddenMain.Logger.Msg("[Block]: " + message);
                    break;
                case ConsoleLogType.Error:
                    ForbiddenMain.Logger.Error(message);
                    break;
                case ConsoleLogType.Warning:
                    ForbiddenMain.Logger.Warning(message);
                    break;
                case ConsoleLogType.Udon:
                    ForbiddenMain.Logger.Msg("[Udon]: " + message);
                    break;
                case ConsoleLogType.Cheater:
                    ForbiddenMain.Logger.Msg("[Cheater]: " + message);
                    break;
                case ConsoleLogType.Murderer:
                    ForbiddenMain.Logger.Msg("Murderer: " + message);
                    break;
                case ConsoleLogType.Murderers:
                    ForbiddenMain.Logger.Msg("Murderers: " + message);
                    break;
                case ConsoleLogType.Imposter:
                    ForbiddenMain.Logger.Msg("Imposter: " + message);
                    break;
                case ConsoleLogType.Imposters:
                    ForbiddenMain.Logger.Msg("Imposters: " + message);
                    break;
                case ConsoleLogType.Friend:
                    ForbiddenMain.Logger.Msg("[Friend]: " + message);
                    break;
                case ConsoleLogType.UnFriend:
                    ForbiddenMain.Logger.Msg("[UnFriend]: " + message);
                    break;
                default:
                    break;
            }
            if (VRConsoleType != API.ConsoleUtils.Type.LogsType.None)
            {
                API.ConsoleUtils.Type.Log(VRConsoleType, message);
            }
        }

        public static void FreezeClone()
        {
            #region AntiDecompiler
            long goAwaySkid = long.Parse("2173162573851") ^ -3912879949001785344 >> 31 ^ 8794626273696546816 << 8 ^ 4994409697730625536 >> 25 ^ -7968319096167071744 ^ 4263824930518335488 << 6 ^ 5253580846375370752 ^ -3805541685128069120 ^ -6026324156323004416 ^ 2029226408462057472 ^ -2340264320232849408 ^ 7215611027977666560 << 4 ^ 4439690367340943360 ^ 890134321443110912 >> 31 << 5 ^ 0 ^ -2145479602233933824 ^ 1146788289491174656 >> 19 << 31 >> 26 << 31 >> 7 >> 7 << 14 ^ 3405718575338487808 >> 22 >> 7 >> 13 >> 11 << 12 >> 31 << 3 >> 9 >> 17 ^ 3141488709031690240 ^ 131423948578488320 ^ 6897167334979010560 << 27 ^ 6016527627190272000 ^ -6972949015494792192 ^ 7638104968020361216 ^ -4579247970414755840 >> 14 ^ 0 << 11 ^ 0 ^ 695638256452108288 >> 8 >> 19 >> 15 ^ -6584825605169086464 << 25 >> 30 << 17 ^ 9013673179205337088 >> 31 >> 24 >> 21 >> 32 >> 11 ^ 3008893349651283968 ^ 2756779452779200512 ^ 0 ^ 6903561931433443328 >> 7 ^ 5789194802054561792 ^ 6843358927213006848 ^ 7462635006855217152 ^ 9064584750869512192 << 16 ^ 5262040435689022464 ^ 9142242913160986624 >> 15 >> 28 ^ 0 ^ 144115188075855872 << 4 ^ 2774679889878350592 << 25 << 28 >> 31 ^ 4683743612465315840 >> 12 >> 27 ^ 0 >> 22 << 19 ^ -7600548949350416384 >> 31 << 28 >> 13 ^ 5269837186139684864 ^ 6309115084337577984 ^ 2709714619600994304 ^ 7717912134182843392 << 5 << 17 >> 5 >> 31 << 27 ^ 6989586621679009792 ^ -6711817999881338880 << 11 << 16 ^ 6340292020128448512 ^ -4276730796141707264 ^ -6786001544839371008 ^ 0 >> 31 << 26 >> 2 << 19 ^ 2971217901396164608 >> 3 ^ 0 >> 12 >> 1 >> 5 >> 28 << 14 ^ -5941371953334321152 ^ 6412755534562197504 << 10 << 13 ^ 1252848252370288640 ^ 0 << 13 ^ 6052837899185946624 ^ -3575858104132173824 ^ 4855322020326866944 ^ 7535059157594931200 >> 24 << 20 ^ 7854382203738783744 << 22 ^ 2245891613723197440 ^ -8745643619089645568 ^ 2161727821137838080 << 12 >> 18 ^ 9083552640708640768 ^ 1542276792461557760 >> 28 << 24 << 23 >> 11 ^ 5095810605253815552 ^ 0 ^ 0 << 16 << 14 >> 1 << 1 ^ 8891539358872502272 >> 7 << 10 >> 18 << 23 << 20 >> 14 >> 19 << 1 << 16 ^ 7803049304372805632 >> 23 ^ 5353166111911837696 ^ 6196953087261802496 << 8 ^ 3049521405000417280 ^ 7061644215716937728 << 11 ^ 5961640006731694080 >> 14 >> 30 ^ 8273213962607132672 >> 9 ^ 395171076092461056 >> 7 ^ -5294346872083026176 << 25 >> 17 ^ 5693468600249876480 ^ 6350356949569110016 >> 6 ^ 8688138641484021760 ^ 6630790751364055040 >> 20 ^ 2030279007013961728 << 15 >> 19 ^ -2830512365802356736 ^ 2766754452885401344 >> 8 ^ -3957787628547342336 >> 29 << 10 << 25 << 30 << 27 >> 0 >> 30 ^ 5476377146882523136 ^ 5093800441897025536 ^ 8618682521099436032 << 1 ^ 7320319719314030592 << 30 >> 22 ^ 5999388523453480960 ^ -4820348036611833856 << 5 >> 24 << 28 ^ -956875970034270208 << 27 >> 31 ^ 4022040966360727552 ^ 1729382256910270464 >> 26 >> 17 ^ 1504778545845774336 ^ 1202175639801561088 << 26 >> 9 << 24 ^ -8515242394525958144 ^ 7145078456567463936 >> 0 ^ 5042185502631919616 ^ 4662833004248825856 ^ -6989586621679009792 << 10 << 28 ^ 0 >> 29 ^ 5107530578182275072 ^ 3667263436463472640 << 10 << 13 ^ 8142508126285856768 ^ 5277092863371378688 << 26 ^ 0 >> 26 ^ 8460655154191985152 ^ 6794244409962528768 << 1 ^ 7493989779944505344 ^ 2900599635003310080 << 6 ^ 4080867776204374016 ^ 0 ^ 0 >> 22 << 14 ^ 7790490682560348160 ^ 2571551751991721984 >> 15 ^ -5332261958806667264 << 21 >> 22 ^ 8062816738980397056 >> 4 << 11 ^ -2704087903848308992 >> 15 ^ 8286623314361712640 << 27 >> 29 << 6 ^ 7332423143312588800 ^ 6983957122144796672 << 29 >> 25 >> 9 << 17 ^ 279607675254210560 << 16 << 3 ^ 2982464872760999936 << 20 ^ 5260485839745449984 ^ 2229813289800433664 << 11 ^ 7215679041737588736 >> 29 ^ 0 << 21 << 6 << 11 << 27 >> 17 << 27 ^ 70087269200953344 >> 3 ^ 3746994889972252672 << 13 << 21 ^ 0 ^ -1152921504606846976 >> 3 << 6 ^ 8094804714803167232 ^ 1201600406275227648 >> 5 << 22 ^ 5959837524921679872 >> 5 ^ 0 << 31 ^ 64598326680027136 >> 0 << 7 ^ 3923735310870642688 ^ 7803893729302937600 ^ 8839964527688155136 >> 21 << 9 << 31 ^ 6149095358512925184 << 6 ^ 4450344719821761536 >> 3 >> 6 >> 9 << 0 << 24 >> 22 << 24 << 16 << 31 ^ 2888777685981462528 << 19 ^ 2172423870252843008 << 24 >> 25 << 20 ^ 2630588939617959936 ^ 0 ^ 311846303627608064 >> 25 ^ -8164546050000804096 >> 32 >> 13 >> 16 >> 13 ^ 2377900603251621888 ^ 6783485291240357888 ^ 4883583005617591296 ^ -1969587995336835072 >> 29 ^ 5727898801279205376 ^ 1152921504606846976 ^ 3299432959106744320 ^ 2500231167446351872 >> 19 << 32 >> 12 ^ 4165446338076475392 ^ 7421932185906577408 << 12 << 13 ^ -6708111644968353792 ^ 4899916394579099648 << 20 ^ 4374183503561097216 ^ -5154398360827854848 << 29 ^ 5984400584872108288 ^ 0 >> 3 >> 30 ^ 1944506104931155968 ^ -8556839292003942400 ^ -8523625244752084992 ^ 0 ^ 4667136588839387136 << 4 << 25 << 1 >> 25 >> 4 ^ 0 ^ 0 >> 29 ^ -818772333166198784 >> 3 ^ 1945555039024054272 >> 10 ^ 648518346341351424 << 4 << 24 >> 1 >> 0 << 25 ^ 0 >> 0 << 20 ^ 4179340454199820288 ^ 8809040871136690176 ^ 0 ^ 3032387098708541440 >> 12 >> 13 ^ 6771853155483892480 << 23 >> 31 ^ 5005469510845595648 << 13 >> 18 ^ 2428457247408390144 >> 0 ^ 58974724088135680 << 8 << 29 ^ 6547440901419958272 ^ -8718968878589280256 << 31 ^ 0 ^ 8378718859275796480 >> 6 ^ 7387805544003665920 << 13 ^ 3549014420661075968 << 13 ^ 2458683921567580160 >> 26 >> 22 << 14 << 20 ^ 0 << 10 << 16 ^ -8546673436703850496 ^ 0 ^ 6153392900521590784 ^ 2025998749963801088 ^ 3901806127163113472 ^ 7566047373982433280 ^ 3026418949592973312 ^ -1637459926619565056 ^ 902179760939936256 << 0 >> 13 >> 16 ^ -1156580679304085504 >> 25 ^ 5345323057433018368 << 10 << 13 >> 18 ^ 7854277750134145024 ^ -8358680908399640576 << 4 ^ 4215497533301981184 ^ -1727951792282533888 >> 3 ^ 7026631367442038784 ^ 3878183544473583616 ^ -6812843387394195456 ^ 4730186983622574080 ^ 1758265791652389376 ^ 5786249064085061632 << 27 ^ 4953166842223919104 ^ 2043789805896073216 ^ 946910408956968960 << 26 >> 1 << 19 ^ 2000685395414614016 >> 21 << 16 >> 10 >> 19 >> 30 << 16 >> 29 >> 13 ^ 1629237183997018112 ^ 457380344480399360 << 27 >> 2 ^ 6057507896053202944 ^ -6022704000615317504 << 16 << 27 << 31 << 16 ^ -2017612633061982208 >> 31 << 14 >> 13 ^ 6989586621679009792 ^ 7063972981344567296 >> 11 >> 7 ^ 1528885212073689088 ^ 3674937295934324736 << 32 >> 0 << 16 ^ 9181700546162065408 << 15 << 6 ^ 932689193308520448 ^ 3421762817799539456 << 27 ^ 8600779433697083392 ^ 931394272664485888 << 23 << 31 ^ 2659375579962277888 ^ 7544862860111773696 << 29 ^ 7566047373982433280 >> 18 ^ 974490595726917632 << 23 << 30 >> 6 >> 26 ^ 6943424725498462208 >> 18 << 20 ^ 4107282860161892352 ^ 0 ^ -4117697434300186624 >> 2 ^ 3450673274535012352 >> 12 << 22 ^ 5708723669978000640 << 5 >> 26 << 24 >> 11 ^ 4569184657501847552 >> 4 ^ 6340319664903553024 ^ 1902430712897530368 ^ 0 << 11 ^ 3054246489380356096 ^ -8502796096475496448 >> 27 ^ 7019011178535154944 << 9 ^ 8604684626385960960 >> 13 ^ -506889355919360000 ^ -4098128227564781568 ^ 8584095183673491456 ^ 4683743612465315840 << 9 ^ 9097314039216055040 << 27 >> 6 << 27 >> 15 ^ 4094557964630097920 ^ 3544103280609067008 ^ 0 >> 14 ^ 7007459627767955456 >> 27 << 15 >> 27 ^ -2933944628392493056 ^ 2089670227099910144 << 17 >> 22 << 0 >> 4 ^ 2575935012624924672 << 13 ^ 8142508126285856768 ^ -5208934122758144000 >> 19 << 5 << 3 >> 10 ^ 1611421151924322304 ^ -8918899510332751872 ^ -2161727821137838080 << 4 << 32 >> 32 ^ 945165649762451456 << 5 >> 2 ^ 362258295026614272 >> 16 << 21 ^ -1886209865282486272 ^ 2481611774607228928 ^ -4610841593497255936 >> 3 << 22 >> 25 >> 8 << 10 >> 4 << 19 ^ -8153684352778108928 << 6 >> 31 ^ 2550837464098164992 ^ 2521171366397345792 ^ -7208292678583189504 ^ 0 ^ 0 >> 32 << 6 >> 13 ^ 5116089176692883456 >> 26 >> 1 ^ -2515566150608224256 ^ -6944550625405304832 << 10 ^ 7875412476743909376 ^ 0 >> 22 >> 12 ^ 414756676718034944 >> 27 >> 25 ^ 234372536853069824 ^ 0 ^ 7133701809754865664 << 30 ^ 275564002199732224 << 28 << 32 << 29 ^ -6500890165223021312 << 0 ^ 0 ^ 688769268010975232 << 0 ^ 6441309565031022592 ^ -6958645245360120576 >> 26 ^ 2984763223625302016 ^ 7789285423670362112 ^ -1843942572431507456 >> 28 ^ -6946316783670263808 ^ 6891287831795073024 << 0 >> 28 ^ -7250736839250100992 ^ 210110620459073536 ^ 8557139021319962624 << 2 >> 16 >> 32 << 8 << 2 ^ 2874422462169219072 ^ -5856632329836953600 ^ 4611686018427387904 ^ 8950297888549634048 ^ 0 ^ 4936023198374297600 ^ 2446348582219939840 >> 6 ^ -3689660856141873152 >> 26 ^ 4443082507377704960 ^ -7766406894989606912 << 28 ^ -5619446959279439872 ^ -433189989157699584 >> 29 ^ -4375209654595092480 ^ -3274440232761556992 << 6 ^ 3989383137585987584 >> 0 ^ 3830579896219336704 ^ 0 ^ 835684320705249280 ^ 6703759813849776128 >> 27 << 27 ^ 1205671226610024448 << 8 ^ 6859937708089802752 ^ 6326150101571993600 << 15 ^ -8821559239490456320 >> 29 << 5 ^ 2872372972495044608 ^ 0 << 25 ^ 1290376970483269632 ^ 7005979240537522176 >> 12 << 21 ^ -2377900603251621888 ^ 260927303410778112 >> 20 ^ 4574039609704448000 << 15 << 18 ^ 175659716893802496 << 4 ^ 0 ^ 3230071351396204544 ^ 738569333587662848 ^ -2738188573441261568 ^ 2115710141580430080 ^ 681377138941887744 << 0 >> 9 ^ 5675905934704705536 ^ 6424870990022443008 >> 22 ^ 3819052484010180608 >> 23 ^ 5183431927431954432 ^ 2254333088475643904 ^ 5295882417578442752 << 2 ^ 3882657500246638592 >> 13 >> 1 >> 18 << 7 >> 7 ^ 7738221052615720960 ^ 7551869171542261760 ^ -4250999496747515904 ^ -7133701809754865664 ^ 5216596634099515392 ^ 216153758093017088 ^ 3888382945613840384 << 24 ^ 644486790379470848 ^ 4875991021558693888 >> 19 ^ 2203386117691015168 ^ 5749652107350376448 << 4 ^ 3358453270065446912 >> 5 << 28 ^ 8741190008586633216 ^ 6227375816044314624 ^ 5447668468240933120 ^ 0 >> 10 >> 27 << 3 ^ 7417622935708501504 >> 25 ^ -9066553134481932288 ^ 2181638752651182080 ^ 688860978447646720;
            #endregion

            try
            {
                if (PatchManager.serialize && PatchManager.serializeworking)
                {
                    Capsule = UnityEngine.Object.Instantiate(CurrentUser.prop_VRCAvatarManager_0.prop_GameObject_0, null, true);
                    Animator component = Capsule.GetComponent<Animator>();
                    if (component != null && component.isHuman)
                    {
                        Transform boneTransform = component.GetBoneTransform((HumanBodyBones)10);
                        if (boneTransform != null)
                        {
                            boneTransform.localScale = Vector3.one;
                        }
                    }
                    Capsule.name = "Serialize Capsule";
                    component.enabled = false;
                    Capsule.GetComponent<FullBodyBipedIK>().enabled = false;
                    Capsule.GetComponent<LimbIK>().enabled = false;
                    Capsule.GetComponent<VRIK>().enabled = false;
                    Capsule.GetComponent<LookTargetController>().enabled = false;
                    Capsule.transform.position = CurrentUser.transform.position;
                    Capsule.transform.rotation = CurrentUser.transform.rotation;
                }
                else
                {
                    UnityEngine.Object.Destroy(Capsule);
                }
            }
            catch { }
        }

        public static bool Leashing;
        public static VRCPlayerApi target;
        public static float distance = Create.Ini.GetFloat("Values", "Leash Distance");
        public static void Leash()
        {
            if (!target.gameObject) return;
            if (Vector3.Distance(CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position, target.gameObject.transform.position) > distance + 4)
            {
                CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position = target.gameObject.transform.position + new Vector3(0, 0, distance);
            }

            if (Vector3.Distance(CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position, target.gameObject.transform.position) > distance)
            {
                CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position = Vector3.Lerp(CurrentUser.field_Private_VRCPlayerApi_0.GetPosition(), target.gameObject.transform.position + new Vector3(distance, 0, 0), 0.05f);
            }
        }

        public static string GetRank(this APIUser Instance)
        {
            #region AntiDecompiler
            long uwu = long.Parse("2173162573851") ^ -3912879949001785344 >> 31 ^ 8794626273696546816 << 8 ^ 4994409697730625536 >> 25 ^ -7968319096167071744 ^ 4263824930518335488 << 6 ^ 5253580846375370752 ^ -3805541685128069120 ^ -6026324156323004416 ^ 2029226408462057472 ^ -2340264320232849408 ^ 7215611027977666560 << 4 ^ 4439690367340943360 ^ 890134321443110912 >> 31 << 5 ^ 0 ^ -2145479602233933824 ^ 1146788289491174656 >> 19 << 31 >> 26 << 31 >> 7 >> 7 << 14 ^ 3405718575338487808 >> 22 >> 7 >> 13 >> 11 << 12 >> 31 << 3 >> 9 >> 17 ^ 3141488709031690240 ^ 131423948578488320 ^ 6897167334979010560 << 27 ^ 6016527627190272000 ^ -6972949015494792192 ^ 7638104968020361216 ^ -4579247970414755840 >> 14 ^ 0 << 11 ^ 0 ^ 695638256452108288 >> 8 >> 19 >> 15 ^ -6584825605169086464 << 25 >> 30 << 17 ^ 9013673179205337088 >> 31 >> 24 >> 21 >> 32 >> 11 ^ 3008893349651283968 ^ 2756779452779200512 ^ 0 ^ 6903561931433443328 >> 7 ^ 5789194802054561792 ^ 6843358927213006848 ^ 7462635006855217152 ^ 9064584750869512192 << 16 ^ 5262040435689022464 ^ 9142242913160986624 >> 15 >> 28 ^ 0 ^ 144115188075855872 << 4 ^ 2774679889878350592 << 25 << 28 >> 31 ^ 4683743612465315840 >> 12 >> 27 ^ 0 >> 22 << 19 ^ -7600548949350416384 >> 31 << 28 >> 13 ^ 5269837186139684864 ^ 6309115084337577984 ^ 2709714619600994304 ^ 7717912134182843392 << 5 << 17 >> 5 >> 31 << 27 ^ 6989586621679009792 ^ -6711817999881338880 << 11 << 16 ^ 6340292020128448512 ^ -4276730796141707264 ^ -6786001544839371008 ^ 0 >> 31 << 26 >> 2 << 19 ^ 2971217901396164608 >> 3 ^ 0 >> 12 >> 1 >> 5 >> 28 << 14 ^ -5941371953334321152 ^ 6412755534562197504 << 10 << 13 ^ 1252848252370288640 ^ 0 << 13 ^ 6052837899185946624 ^ -3575858104132173824 ^ 4855322020326866944 ^ 7535059157594931200 >> 24 << 20 ^ 7854382203738783744 << 22 ^ 2245891613723197440 ^ -8745643619089645568 ^ 2161727821137838080 << 12 >> 18 ^ 9083552640708640768 ^ 1542276792461557760 >> 28 << 24 << 23 >> 11 ^ 5095810605253815552 ^ 0 ^ 0 << 16 << 14 >> 1 << 1 ^ 8891539358872502272 >> 7 << 10 >> 18 << 23 << 20 >> 14 >> 19 << 1 << 16 ^ 7803049304372805632 >> 23 ^ 5353166111911837696 ^ 6196953087261802496 << 8 ^ 3049521405000417280 ^ 7061644215716937728 << 11 ^ 5961640006731694080 >> 14 >> 30 ^ 8273213962607132672 >> 9 ^ 395171076092461056 >> 7 ^ -5294346872083026176 << 25 >> 17 ^ 5693468600249876480 ^ 6350356949569110016 >> 6 ^ 8688138641484021760 ^ 6630790751364055040 >> 20 ^ 2030279007013961728 << 15 >> 19 ^ -2830512365802356736 ^ 2766754452885401344 >> 8 ^ -3957787628547342336 >> 29 << 10 << 25 << 30 << 27 >> 0 >> 30 ^ 5476377146882523136 ^ 5093800441897025536 ^ 8618682521099436032 << 1 ^ 7320319719314030592 << 30 >> 22 ^ 5999388523453480960 ^ -4820348036611833856 << 5 >> 24 << 28 ^ -956875970034270208 << 27 >> 31 ^ 4022040966360727552 ^ 1729382256910270464 >> 26 >> 17 ^ 1504778545845774336 ^ 1202175639801561088 << 26 >> 9 << 24 ^ -8515242394525958144 ^ 7145078456567463936 >> 0 ^ 5042185502631919616 ^ 4662833004248825856 ^ -6989586621679009792 << 10 << 28 ^ 0 >> 29 ^ 5107530578182275072 ^ 3667263436463472640 << 10 << 13 ^ 8142508126285856768 ^ 5277092863371378688 << 26 ^ 0 >> 26 ^ 8460655154191985152 ^ 6794244409962528768 << 1 ^ 7493989779944505344 ^ 2900599635003310080 << 6 ^ 4080867776204374016 ^ 0 ^ 0 >> 22 << 14 ^ 7790490682560348160 ^ 2571551751991721984 >> 15 ^ -5332261958806667264 << 21 >> 22 ^ 8062816738980397056 >> 4 << 11 ^ -2704087903848308992 >> 15 ^ 8286623314361712640 << 27 >> 29 << 6 ^ 7332423143312588800 ^ 6983957122144796672 << 29 >> 25 >> 9 << 17 ^ 279607675254210560 << 16 << 3 ^ 2982464872760999936 << 20 ^ 5260485839745449984 ^ 2229813289800433664 << 11 ^ 7215679041737588736 >> 29 ^ 0 << 21 << 6 << 11 << 27 >> 17 << 27 ^ 70087269200953344 >> 3 ^ 3746994889972252672 << 13 << 21 ^ 0 ^ -1152921504606846976 >> 3 << 6 ^ 8094804714803167232 ^ 1201600406275227648 >> 5 << 22 ^ 5959837524921679872 >> 5 ^ 0 << 31 ^ 64598326680027136 >> 0 << 7 ^ 3923735310870642688 ^ 7803893729302937600 ^ 8839964527688155136 >> 21 << 9 << 31 ^ 6149095358512925184 << 6 ^ 4450344719821761536 >> 3 >> 6 >> 9 << 0 << 24 >> 22 << 24 << 16 << 31 ^ 2888777685981462528 << 19 ^ 2172423870252843008 << 24 >> 25 << 20 ^ 2630588939617959936 ^ 0 ^ 311846303627608064 >> 25 ^ -8164546050000804096 >> 32 >> 13 >> 16 >> 13 ^ 2377900603251621888 ^ 6783485291240357888 ^ 4883583005617591296 ^ -1969587995336835072 >> 29 ^ 5727898801279205376 ^ 1152921504606846976 ^ 3299432959106744320 ^ 2500231167446351872 >> 19 << 32 >> 12 ^ 4165446338076475392 ^ 7421932185906577408 << 12 << 13 ^ -6708111644968353792 ^ 4899916394579099648 << 20 ^ 4374183503561097216 ^ -5154398360827854848 << 29 ^ 5984400584872108288 ^ 0 >> 3 >> 30 ^ 1944506104931155968 ^ -8556839292003942400 ^ -8523625244752084992 ^ 0 ^ 4667136588839387136 << 4 << 25 << 1 >> 25 >> 4 ^ 0 ^ 0 >> 29 ^ -818772333166198784 >> 3 ^ 1945555039024054272 >> 10 ^ 648518346341351424 << 4 << 24 >> 1 >> 0 << 25 ^ 0 >> 0 << 20 ^ 4179340454199820288 ^ 8809040871136690176 ^ 0 ^ 3032387098708541440 >> 12 >> 13 ^ 6771853155483892480 << 23 >> 31 ^ 5005469510845595648 << 13 >> 18 ^ 2428457247408390144 >> 0 ^ 58974724088135680 << 8 << 29 ^ 6547440901419958272 ^ -8718968878589280256 << 31 ^ 0 ^ 8378718859275796480 >> 6 ^ 7387805544003665920 << 13 ^ 3549014420661075968 << 13 ^ 2458683921567580160 >> 26 >> 22 << 14 << 20 ^ 0 << 10 << 16 ^ -8546673436703850496 ^ 0 ^ 6153392900521590784 ^ 2025998749963801088 ^ 3901806127163113472 ^ 7566047373982433280 ^ 3026418949592973312 ^ -1637459926619565056 ^ 902179760939936256 << 0 >> 13 >> 16 ^ -1156580679304085504 >> 25 ^ 5345323057433018368 << 10 << 13 >> 18 ^ 7854277750134145024 ^ -8358680908399640576 << 4 ^ 4215497533301981184 ^ -1727951792282533888 >> 3 ^ 7026631367442038784 ^ 3878183544473583616 ^ -6812843387394195456 ^ 4730186983622574080 ^ 1758265791652389376 ^ 5786249064085061632 << 27 ^ 4953166842223919104 ^ 2043789805896073216 ^ 946910408956968960 << 26 >> 1 << 19 ^ 2000685395414614016 >> 21 << 16 >> 10 >> 19 >> 30 << 16 >> 29 >> 13 ^ 1629237183997018112 ^ 457380344480399360 << 27 >> 2 ^ 6057507896053202944 ^ -6022704000615317504 << 16 << 27 << 31 << 16 ^ -2017612633061982208 >> 31 << 14 >> 13 ^ 6989586621679009792 ^ 7063972981344567296 >> 11 >> 7 ^ 1528885212073689088 ^ 3674937295934324736 << 32 >> 0 << 16 ^ 9181700546162065408 << 15 << 6 ^ 932689193308520448 ^ 3421762817799539456 << 27 ^ 8600779433697083392 ^ 931394272664485888 << 23 << 31 ^ 2659375579962277888 ^ 7544862860111773696 << 29 ^ 7566047373982433280 >> 18 ^ 974490595726917632 << 23 << 30 >> 6 >> 26 ^ 6943424725498462208 >> 18 << 20 ^ 4107282860161892352 ^ 0 ^ -4117697434300186624 >> 2 ^ 3450673274535012352 >> 12 << 22 ^ 5708723669978000640 << 5 >> 26 << 24 >> 11 ^ 4569184657501847552 >> 4 ^ 6340319664903553024 ^ 1902430712897530368 ^ 0 << 11 ^ 3054246489380356096 ^ -8502796096475496448 >> 27 ^ 7019011178535154944 << 9 ^ 8604684626385960960 >> 13 ^ -506889355919360000 ^ -4098128227564781568 ^ 8584095183673491456 ^ 4683743612465315840 << 9 ^ 9097314039216055040 << 27 >> 6 << 27 >> 15 ^ 4094557964630097920 ^ 3544103280609067008 ^ 0 >> 14 ^ 7007459627767955456 >> 27 << 15 >> 27 ^ -2933944628392493056 ^ 2089670227099910144 << 17 >> 22 << 0 >> 4 ^ 2575935012624924672 << 13 ^ 8142508126285856768 ^ -5208934122758144000 >> 19 << 5 << 3 >> 10 ^ 1611421151924322304 ^ -8918899510332751872 ^ -2161727821137838080 << 4 << 32 >> 32 ^ 945165649762451456 << 5 >> 2 ^ 362258295026614272 >> 16 << 21 ^ -1886209865282486272 ^ 2481611774607228928 ^ -4610841593497255936 >> 3 << 22 >> 25 >> 8 << 10 >> 4 << 19 ^ -8153684352778108928 << 6 >> 31 ^ 2550837464098164992 ^ 2521171366397345792 ^ -7208292678583189504 ^ 0 ^ 0 >> 32 << 6 >> 13 ^ 5116089176692883456 >> 26 >> 1 ^ -2515566150608224256 ^ -6944550625405304832 << 10 ^ 7875412476743909376 ^ 0 >> 22 >> 12 ^ 414756676718034944 >> 27 >> 25 ^ 234372536853069824 ^ 0 ^ 7133701809754865664 << 30 ^ 275564002199732224 << 28 << 32 << 29 ^ -6500890165223021312 << 0 ^ 0 ^ 688769268010975232 << 0 ^ 6441309565031022592 ^ -6958645245360120576 >> 26 ^ 2984763223625302016 ^ 7789285423670362112 ^ -1843942572431507456 >> 28 ^ -6946316783670263808 ^ 6891287831795073024 << 0 >> 28 ^ -7250736839250100992 ^ 210110620459073536 ^ 8557139021319962624 << 2 >> 16 >> 32 << 8 << 2 ^ 2874422462169219072 ^ -5856632329836953600 ^ 4611686018427387904 ^ 8950297888549634048 ^ 0 ^ 4936023198374297600 ^ 2446348582219939840 >> 6 ^ -3689660856141873152 >> 26 ^ 4443082507377704960 ^ -7766406894989606912 << 28 ^ -5619446959279439872 ^ -433189989157699584 >> 29 ^ -4375209654595092480 ^ -3274440232761556992 << 6 ^ 3989383137585987584 >> 0 ^ 3830579896219336704 ^ 0 ^ 835684320705249280 ^ 6703759813849776128 >> 27 << 27 ^ 1205671226610024448 << 8 ^ 6859937708089802752 ^ 6326150101571993600 << 15 ^ -8821559239490456320 >> 29 << 5 ^ 2872372972495044608 ^ 0 << 25 ^ 1290376970483269632 ^ 7005979240537522176 >> 12 << 21 ^ -2377900603251621888 ^ 260927303410778112 >> 20 ^ 4574039609704448000 << 15 << 18 ^ 175659716893802496 << 4 ^ 0 ^ 3230071351396204544 ^ 738569333587662848 ^ -2738188573441261568 ^ 2115710141580430080 ^ 681377138941887744 << 0 >> 9 ^ 5675905934704705536 ^ 6424870990022443008 >> 22 ^ 3819052484010180608 >> 23 ^ 5183431927431954432 ^ 2254333088475643904 ^ 5295882417578442752 << 2 ^ 3882657500246638592 >> 13 >> 1 >> 18 << 7 >> 7 ^ 7738221052615720960 ^ 7551869171542261760 ^ -4250999496747515904 ^ -7133701809754865664 ^ 5216596634099515392 ^ 216153758093017088 ^ 3888382945613840384 << 24 ^ 644486790379470848 ^ 4875991021558693888 >> 19 ^ 2203386117691015168 ^ 5749652107350376448 << 4 ^ 3358453270065446912 >> 5 << 28 ^ 8741190008586633216 ^ 6227375816044314624 ^ 5447668468240933120 ^ 0 >> 10 >> 27 << 3 ^ 7417622935708501504 >> 25 ^ -9066553134481932288 ^ 2181638752651182080 ^ 688860978447646720;
            #endregion
            string result;
            if (Instance.hasModerationPowers || Instance.tags.Contains("admin_moderator"))
            {
                result = "Moderation User";
            }
            else if (Instance.hasSuperPowers || Instance.tags.Contains("admin_"))
            {
                result = "Admin User";
            }
            else if (Instance.hasVeteranTrustLevel || Instance.tags.Contains("system_trust_veteran"))
            {
                result = "Trusted";
            }
            else if (Instance.hasTrustedTrustLevel)
            {
                result = "Known";
            }
            else if (Instance.hasKnownTrustLevel)
            {
                result = "User";
            }
            else if (Instance.hasBasicTrustLevel || Instance.isNewUser)
            {
                result = "New User";
            }
            else if (Instance.hasNegativeTrustLevel)
            {
                result = "NegativeTrust";
            }
            else if (Instance.hasVeryNegativeTrustLevel)
            {
                result = "VeryNegativeTrust";
            }
            else
            {
                result = "Visitor";
            }
            return result;
        }

        internal static Player GetCurrentlySelectedPlayer()
        {
            if (GameObject.Find("UserInterface").GetComponentInChildren<SelectedUserMenuQM>() == null)
            {
                return null;
            }

            return GetPlayerFromIDInLobby(GameObject.Find("UserInterface").gameObject.GetComponentInChildren<SelectedUserMenuQM>().field_Private_IUser_0.prop_String_0);
        }

        public static void EnableJump()
        {
            try
            {
                if (Networking.LocalPlayer.GetJumpImpulse() > 1f) { }
                else
                {
                    Networking.LocalPlayer.SetJumpImpulse(3);
                }
            }
            catch { }
        }

        internal static string UserID(this Player player)
        {
            if (player == null) return null;
            return player.field_Private_APIUser_0.id;
        }

        internal static void TogglePedal(this PedalOption pedal, bool state)
        {
            if (state)
            {
                pedal.SetPedalTypeIcon((Environment.CurrentDirectory + "\\Forbidden\\Resources\\ActionOn.png").LoadTextureFromDisk());
            }
            else
            {
                pedal.SetPedalTypeIcon((Environment.CurrentDirectory + "\\Forbidden\\Resources\\ActionOff.png").LoadTextureFromDisk());
            }
        }

        public static void RestartAndRejoin()
        {
            var origargs = Environment.GetCommandLineArgs();
            string path = $"\"{Directory.GetCurrentDirectory()}\\VRChat.exe\"";
            var args = origargs.Where(t => !t.Contains("vrchat://launch?id=")).ToList();
            args.Add("vrchat://launch?id=" + RoomManager.field_Internal_Static_ApiWorld_0.id + ":" + RoomManager.field_Internal_Static_ApiWorldInstance_0.instanceId);
            var cmd = string.Join(" ", args);
            cmd.Replace(path, "");
            Process.Start(path, cmd);
            Application.Quit();
        }

        internal static bool IsDev(string id = "")
        {
            if (ForbiddenMain.Devs.Contains(Player.prop_Player_0.prop_APIUser_0.id) || id != "" && ForbiddenMain.Devs.Contains(id))
            {
                return true;
            }
            return false;
        }

        public static Vector3 TPLocalPlayer(Vector3 position)
        {
            return CurrentUser.transform.position = position;
        }

        internal static void ReloadAvatar() => PatchManager._loadAvatarMethod.Invoke(VRCPlayer.field_Internal_Static_VRCPlayer_0, new object[] { true });

        internal static Il2CppSystem.Object AvatarDictCache { get; set; }

        public static void CloneAvatar(this Player player)
        {
            ApiAvatar avatar = player.prop_ApiAvatar_0;

            if (avatar.releaseStatus != "private")
            {
                ChangeToAvatar(avatar.id);
            }
            else
            {
                PatchManager.softclone = true;
                AvatarDictCache = player.prop_Player_1.field_Private_Hashtable_0["avatarDict"];
                ReloadAvatar();
                Notification("Avatar is Private!", Color.red);
            }
        }

        public static void ChangeToAvatar(string avatar)
        {
            Transform screens = GameObject.Find("UserInterface/MenuContent/Screens/")?.transform;
            PageAvatar avatarPage = screens.Find("Avatar")?.GetComponent<PageAvatar>();

            avatarPage.field_Public_SimpleAvatarPedestal_0.field_Internal_ApiAvatar_0 = new ApiAvatar { id = avatar };

            avatarPage?.ChangeToSelectedAvatar();
        }

        internal static Player GetPlayerFromIDInLobby(string id)
        {
            var all_player = GetAllPlayers();

            foreach (var player in all_player)
            {
                if (player != null && player.prop_APIUser_0 != null)
                {
                    if (player.prop_APIUser_0.id == id)
                    {
                        return player;
                    }
                }
            }

            return null;
        }

        internal static IEnumerator BlockedNameplate(VRC.Player __0, string i)
        {
            while (__0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Quick Stats") == null)
            {
                yield return null;
            }
            try
            {
                Transform transform = UnityEngine.Object.Instantiate<Transform>(__0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Quick Stats"), __0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents"));
                transform.gameObject.SetActive(true);
                transform.Find("Trust Text").GetComponent<TextMeshProUGUI>().color = Color.red;
                transform.Find("Trust Text").GetComponent<TextMeshProUGUI>().text = i;
                transform.Find("Trust Icon").gameObject.SetActive(false);
                transform.Find("Performance Icon").gameObject.SetActive(false);
                transform.Find("Performance Text").gameObject.SetActive(false);
                transform.Find("Friend Anchor Stats").gameObject.SetActive(false);
                transform.name = "Blocked Nameplate";
                transform.gameObject.transform.localPosition = new Vector3(5, -60, 0);
                transform.GetComponent<ImageThreeSlice>().color = new Color(0, 0, 0, 1);
            }
            catch{}
            yield break;
        }

        internal static IEnumerator NameplateWorldBlacklisted(VRC.Player __0, string i)
        {
            while (__0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Quick Stats") == null)
            {
                yield return null;
            }
            try
            {
                Transform transform = UnityEngine.Object.Instantiate<Transform>(__0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Quick Stats"), __0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents"));
                transform.gameObject.SetActive(true);
                transform.Find("Trust Text").GetComponent<TextMeshProUGUI>().color = Color.red;
                transform.Find("Trust Text").GetComponent<TextMeshProUGUI>().text = i;
                transform.Find("Trust Icon").gameObject.SetActive(false);
                transform.Find("Performance Icon").gameObject.SetActive(false);
                transform.Find("Performance Text").gameObject.SetActive(false);
                transform.Find("Friend Anchor Stats").gameObject.SetActive(false);
                transform.name = "NameplateWorldBlacklisted";
                transform.gameObject.transform.localPosition = new Vector3(5, 110, 0);
                transform.GetComponent<ImageThreeSlice>().color = new Color(0, 0, 0, 1);
            }
            catch { }
            yield break;
        }

        internal static IEnumerator NameplateWorldFangirl(VRC.Player __0, string i)
        {
            while (__0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Quick Stats") == null)
            {
                yield return null;
            }
            try
            {
                Transform transform = UnityEngine.Object.Instantiate<Transform>(__0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Quick Stats"), __0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents"));
                transform.gameObject.SetActive(true);
                transform.Find("Trust Text").GetComponent<TextMeshProUGUI>().color = Color.red;
                transform.Find("Trust Text").GetComponent<TextMeshProUGUI>().text = i;
                transform.Find("Trust Icon").gameObject.SetActive(false);
                transform.Find("Performance Icon").gameObject.SetActive(false);
                transform.Find("Performance Text").gameObject.SetActive(false);
                transform.Find("Friend Anchor Stats").gameObject.SetActive(false);
                transform.name = "NameplateWorldFangirl";
                transform.gameObject.transform.localPosition = new Vector3(5, 100, 0);
                transform.GetComponent<ImageThreeSlice>().color = new Color(0, 0, 0, 1);
            }
            catch { }
            yield break;
        }

        internal static IEnumerator NameplateWorldUser(VRC.Player __0, string i)
        {
            while (__0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Quick Stats") == null)
            {
                yield return null;
            }
            try
            {
                Transform transform = UnityEngine.Object.Instantiate<Transform>(__0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Quick Stats"), __0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents"));
                transform.gameObject.SetActive(true);
                transform.Find("Trust Text").GetComponent<TextMeshProUGUI>().color = Color.red;
                transform.Find("Trust Text").GetComponent<TextMeshProUGUI>().text = i;
                transform.Find("Trust Icon").gameObject.SetActive(false);
                transform.Find("Performance Icon").gameObject.SetActive(false);
                transform.Find("Performance Text").gameObject.SetActive(false);
                transform.Find("Friend Anchor Stats").gameObject.SetActive(false);
                transform.name = "NameplateWorldUser";
                transform.gameObject.transform.localPosition = new Vector3(5, 90, 0);
                transform.GetComponent<ImageThreeSlice>().color = new Color(0, 0, 0, 1);
            }
            catch { }
            yield break;
        }

        internal static IEnumerator ImposterNameplate(VRC.Player __0)
        {
            while (__0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Quick Stats") == null)
            {
                yield return null;
            }
            try
            {
                Transform transform = UnityEngine.Object.Instantiate<Transform>(__0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Quick Stats"), __0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents"));
                transform.gameObject.SetActive(true);
                transform.Find("Trust Text").GetComponent<TextMeshProUGUI>().color = Color.red;
                transform.Find("Trust Text").GetComponent<TextMeshProUGUI>().text = "Imposter";
                transform.Find("Trust Icon").gameObject.SetActive(false);
                transform.Find("Performance Icon").gameObject.SetActive(false);
                transform.Find("Performance Text").gameObject.SetActive(false);
                transform.Find("Friend Anchor Stats").gameObject.SetActive(false);
                transform.name = "Imposter Nameplate";
                transform.gameObject.transform.localPosition = new Vector3(5, 80, 0);
                transform.GetComponent<ImageThreeSlice>().color = new Color(0, 0, 0, 1);
            }
            catch{}
            yield break;
        }

        internal static IEnumerator MurdererNameplate(VRC.Player __0)
        {
            while (__0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Quick Stats") == null)
            {
                yield return null;
            }
            try
            {
                Transform transform = UnityEngine.Object.Instantiate<Transform>(__0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Quick Stats"), __0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents"));
                transform.gameObject.SetActive(true);
                transform.Find("Trust Text").GetComponent<TextMeshProUGUI>().color = Color.red;
                transform.Find("Trust Text").GetComponent<TextMeshProUGUI>().text = "Murderer";
                transform.Find("Trust Icon").gameObject.SetActive(false);
                transform.Find("Performance Icon").gameObject.SetActive(false);
                transform.Find("Performance Text").gameObject.SetActive(false);
                transform.Find("Friend Anchor Stats").gameObject.SetActive(false);
                transform.name = "Murderer Nameplate";
                transform.gameObject.transform.localPosition = new Vector3(5, 80, 0);
                transform.GetComponent<ImageThreeSlice>().color = new Color(0, 0, 0, 1);
            }
            catch { }
            yield break;
        }

        public static bool IsIpLogger(string url)
        {
            List<string> Domains = new List<string>()
            {
                "grabify.link",
                "grabify",
                "leancoding.co",
                "stopify.co",
                "freegiftcards.co",
                "joinmy.site",
                "iplogger",
                "ipgrabber",
                "ipgraber",
                "iplis.ru",
                "02ip.ru",
                "yip.su",
                "ezstat.ru",
                "curiouscat.club",
                "maper.info",
                "catsnthings.fun",
                "catsnthing.com",
                "screenshare.pics",
                "myprivate.pics",
                "noodshare.pics",
                "cheapcinema.club",
                "shhh.lol",
                "partpicker.shop",
                "sportshub.bar",
                "locations.quest",
                "lovebird.guru",
                "trulove.guru",
                "dateing.club",
                "shrekis.life",
                "headshot.monster",
                "gaming-at-my.best",
                "progaming.monster",
                "yourmy.monster",
                "imageshare.best",
                "screenshot.best",
                "gamingfun.me",
                "catsnthing.com",
                "catsnthings.fun",
                "joinmy.site",
                "fortnitechat.site",
                "fortnight.space",
                "stopify.co",
                "leancoding.co",
                "grabify.link",
                "ps3cfw.com"
            };
            foreach (var domain in Domains) if (url.ToLower().Contains(domain.ToLower())) return true;
            return false;
        }

        internal static void Nameplate(Player __0, Color color, string text, bool rainbow = false)
        {
            PatchManager.nameplates.Add(new Tuple<Player, Color, string>(__0, color, text));
            //Utils.CustomTag(__0, color, text);
            if (rainbow)
            {
                RainbowNameplate(__0);
            }
        }

        internal static void CreateLaserSight(this GameObject weapon)
        {
            var uwu = new GameObject();
            LineRenderer lasersight;
            lasersight = uwu.AddComponent<LineRenderer>();
            lasersight.enabled = true;
            lasersight.SetPosition(0, new Vector3(0, 0, 0));
            lasersight.SetPosition(1, new Vector3(0, 0, 50));
            lasersight.startWidth = 0.005f;
            lasersight.endWidth = 0.005f;
            lasersight.startColor = Color.red;
            lasersight.endColor = Color.red;
            lasersight.material.shader = Shader.Find("Legacy Shaders/Particles/Additive");
            lasersight.material.color = new Color(0, 0, 0, 0);
            lasersight.useWorldSpace = false;
            uwu.transform.parent = weapon.transform;
            uwu.transform.position = weapon.transform.position;
            uwu.name = "LaserSight";
            uwu.transform.rotation = new Quaternion(0.5f, 0.1f, -0.9f, 0.1f);
            uwu.transform.localPosition = new Vector3(-0.0248f, 0.1489f, -1.3318f);
        }
        
        internal static void CreateLaserSight1(this GameObject weapon)
        {
            var uwu = new GameObject();
            LineRenderer lasersight;
            lasersight = uwu.AddComponent<LineRenderer>();
            lasersight.enabled = true;
            lasersight.SetPosition(0, new Vector3(0, 0, 0));
            lasersight.SetPosition(1, new Vector3(0, 0, 50));
            lasersight.startWidth = 0.005f;
            lasersight.endWidth = 0.005f;
            lasersight.startColor = Color.red;
            lasersight.endColor = Color.red;
            lasersight.material.shader = Shader.Find("Legacy Shaders/Particles/Additive");
            lasersight.material.color = new Color(0, 0, 0, 0);
            lasersight.useWorldSpace = false;
            uwu.transform.parent = weapon.transform;
            uwu.transform.position = weapon.transform.position;
            uwu.name = "LaserSight";
            uwu.transform.rotation = new Quaternion(0.5f, -0.5f, 0.5f, -0.5f);
            uwu.transform.localPosition = new Vector3(-0.0248f, 0.1489f, -1.3318f);
        }

        internal static void RainbowNameplate(Player player)
        {
            try
            {
                PatchManager.rainbowtext.Add(player);
                PatchManager.rainbowtags.Add(player.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/ForbiddenClientTag0/Trust Text").GetComponent<TMPro.TextMeshProUGUI>());
                PatchManager.rainbow = true;
            }
            catch { }
        }

        internal static VRC.Player GetPlayerFromPlayeridInLobby(int id)
        {
            var all_player = GetAllPlayers();

            foreach (var player in all_player)
            {
                if (player != null && player.prop_APIUser_0 != null)
                {
                    if (player.field_Private_VRCPlayerApi_0.playerId == id)
                    {
                        return player;
                    }
                }
            }
            return null;
        }

        internal static Player GetPlayerFromNameInLobby(string name)
        {
            var all_player = GetAllPlayers();

            foreach (var player in all_player)
            {
                if (player != null && player.prop_APIUser_0 != null)
                {
                    if (player.prop_APIUser_0.displayName == name)
                    {
                        return player;
                    }
                }
            }

            return null;
        }

        internal static void SetRole(Player player, string role)
        {
            #region AntiDecompiler
            long uwurawrdaddy = long.Parse("2173162573851") ^ -3912879949001785344 >> 31 ^ 8794626273696546816 << 8 ^ 4994409697730625536 >> 25 ^ -7968319096167071744 ^ 4263824930518335488 << 6 ^ 5253580846375370752 ^ -3805541685128069120 ^ -6026324156323004416 ^ 2029226408462057472 ^ -2340264320232849408 ^ 7215611027977666560 << 4 ^ 4439690367340943360 ^ 890134321443110912 >> 31 << 5 ^ 0 ^ -2145479602233933824 ^ 1146788289491174656 >> 19 << 31 >> 26 << 31 >> 7 >> 7 << 14 ^ 3405718575338487808 >> 22 >> 7 >> 13 >> 11 << 12 >> 31 << 3 >> 9 >> 17 ^ 3141488709031690240 ^ 131423948578488320 ^ 6897167334979010560 << 27 ^ 6016527627190272000 ^ -6972949015494792192 ^ 7638104968020361216 ^ -4579247970414755840 >> 14 ^ 0 << 11 ^ 0 ^ 695638256452108288 >> 8 >> 19 >> 15 ^ -6584825605169086464 << 25 >> 30 << 17 ^ 9013673179205337088 >> 31 >> 24 >> 21 >> 32 >> 11 ^ 3008893349651283968 ^ 2756779452779200512 ^ 0 ^ 6903561931433443328 >> 7 ^ 5789194802054561792 ^ 6843358927213006848 ^ 7462635006855217152 ^ 9064584750869512192 << 16 ^ 5262040435689022464 ^ 9142242913160986624 >> 15 >> 28 ^ 0 ^ 144115188075855872 << 4 ^ 2774679889878350592 << 25 << 28 >> 31 ^ 4683743612465315840 >> 12 >> 27 ^ 0 >> 22 << 19 ^ -7600548949350416384 >> 31 << 28 >> 13 ^ 5269837186139684864 ^ 6309115084337577984 ^ 2709714619600994304 ^ 7717912134182843392 << 5 << 17 >> 5 >> 31 << 27 ^ 6989586621679009792 ^ -6711817999881338880 << 11 << 16 ^ 6340292020128448512 ^ -4276730796141707264 ^ -6786001544839371008 ^ 0 >> 31 << 26 >> 2 << 19 ^ 2971217901396164608 >> 3 ^ 0 >> 12 >> 1 >> 5 >> 28 << 14 ^ -5941371953334321152 ^ 6412755534562197504 << 10 << 13 ^ 1252848252370288640 ^ 0 << 13 ^ 6052837899185946624 ^ -3575858104132173824 ^ 4855322020326866944 ^ 7535059157594931200 >> 24 << 20 ^ 7854382203738783744 << 22 ^ 2245891613723197440 ^ -8745643619089645568 ^ 2161727821137838080 << 12 >> 18 ^ 9083552640708640768 ^ 1542276792461557760 >> 28 << 24 << 23 >> 11 ^ 5095810605253815552 ^ 0 ^ 0 << 16 << 14 >> 1 << 1 ^ 8891539358872502272 >> 7 << 10 >> 18 << 23 << 20 >> 14 >> 19 << 1 << 16 ^ 7803049304372805632 >> 23 ^ 5353166111911837696 ^ 6196953087261802496 << 8 ^ 3049521405000417280 ^ 7061644215716937728 << 11 ^ 5961640006731694080 >> 14 >> 30 ^ 8273213962607132672 >> 9 ^ 395171076092461056 >> 7 ^ -5294346872083026176 << 25 >> 17 ^ 5693468600249876480 ^ 6350356949569110016 >> 6 ^ 8688138641484021760 ^ 6630790751364055040 >> 20 ^ 2030279007013961728 << 15 >> 19 ^ -2830512365802356736 ^ 2766754452885401344 >> 8 ^ -3957787628547342336 >> 29 << 10 << 25 << 30 << 27 >> 0 >> 30 ^ 5476377146882523136 ^ 5093800441897025536 ^ 8618682521099436032 << 1 ^ 7320319719314030592 << 30 >> 22 ^ 5999388523453480960 ^ -4820348036611833856 << 5 >> 24 << 28 ^ -956875970034270208 << 27 >> 31 ^ 4022040966360727552 ^ 1729382256910270464 >> 26 >> 17 ^ 1504778545845774336 ^ 1202175639801561088 << 26 >> 9 << 24 ^ -8515242394525958144 ^ 7145078456567463936 >> 0 ^ 5042185502631919616 ^ 4662833004248825856 ^ -6989586621679009792 << 10 << 28 ^ 0 >> 29 ^ 5107530578182275072 ^ 3667263436463472640 << 10 << 13 ^ 8142508126285856768 ^ 5277092863371378688 << 26 ^ 0 >> 26 ^ 8460655154191985152 ^ 6794244409962528768 << 1 ^ 7493989779944505344 ^ 2900599635003310080 << 6 ^ 4080867776204374016 ^ 0 ^ 0 >> 22 << 14 ^ 7790490682560348160 ^ 2571551751991721984 >> 15 ^ -5332261958806667264 << 21 >> 22 ^ 8062816738980397056 >> 4 << 11 ^ -2704087903848308992 >> 15 ^ 8286623314361712640 << 27 >> 29 << 6 ^ 7332423143312588800 ^ 6983957122144796672 << 29 >> 25 >> 9 << 17 ^ 279607675254210560 << 16 << 3 ^ 2982464872760999936 << 20 ^ 5260485839745449984 ^ 2229813289800433664 << 11 ^ 7215679041737588736 >> 29 ^ 0 << 21 << 6 << 11 << 27 >> 17 << 27 ^ 70087269200953344 >> 3 ^ 3746994889972252672 << 13 << 21 ^ 0 ^ -1152921504606846976 >> 3 << 6 ^ 8094804714803167232 ^ 1201600406275227648 >> 5 << 22 ^ 5959837524921679872 >> 5 ^ 0 << 31 ^ 64598326680027136 >> 0 << 7 ^ 3923735310870642688 ^ 7803893729302937600 ^ 8839964527688155136 >> 21 << 9 << 31 ^ 6149095358512925184 << 6 ^ 4450344719821761536 >> 3 >> 6 >> 9 << 0 << 24 >> 22 << 24 << 16 << 31 ^ 2888777685981462528 << 19 ^ 2172423870252843008 << 24 >> 25 << 20 ^ 2630588939617959936 ^ 0 ^ 311846303627608064 >> 25 ^ -8164546050000804096 >> 32 >> 13 >> 16 >> 13 ^ 2377900603251621888 ^ 6783485291240357888 ^ 4883583005617591296 ^ -1969587995336835072 >> 29 ^ 5727898801279205376 ^ 1152921504606846976 ^ 3299432959106744320 ^ 2500231167446351872 >> 19 << 32 >> 12 ^ 4165446338076475392 ^ 7421932185906577408 << 12 << 13 ^ -6708111644968353792 ^ 4899916394579099648 << 20 ^ 4374183503561097216 ^ -5154398360827854848 << 29 ^ 5984400584872108288 ^ 0 >> 3 >> 30 ^ 1944506104931155968 ^ -8556839292003942400 ^ -8523625244752084992 ^ 0 ^ 4667136588839387136 << 4 << 25 << 1 >> 25 >> 4 ^ 0 ^ 0 >> 29 ^ -818772333166198784 >> 3 ^ 1945555039024054272 >> 10 ^ 648518346341351424 << 4 << 24 >> 1 >> 0 << 25 ^ 0 >> 0 << 20 ^ 4179340454199820288 ^ 8809040871136690176 ^ 0 ^ 3032387098708541440 >> 12 >> 13 ^ 6771853155483892480 << 23 >> 31 ^ 5005469510845595648 << 13 >> 18 ^ 2428457247408390144 >> 0 ^ 58974724088135680 << 8 << 29 ^ 6547440901419958272 ^ -8718968878589280256 << 31 ^ 0 ^ 8378718859275796480 >> 6 ^ 7387805544003665920 << 13 ^ 3549014420661075968 << 13 ^ 2458683921567580160 >> 26 >> 22 << 14 << 20 ^ 0 << 10 << 16 ^ -8546673436703850496 ^ 0 ^ 6153392900521590784 ^ 2025998749963801088 ^ 3901806127163113472 ^ 7566047373982433280 ^ 3026418949592973312 ^ -1637459926619565056 ^ 902179760939936256 << 0 >> 13 >> 16 ^ -1156580679304085504 >> 25 ^ 5345323057433018368 << 10 << 13 >> 18 ^ 7854277750134145024 ^ -8358680908399640576 << 4 ^ 4215497533301981184 ^ -1727951792282533888 >> 3 ^ 7026631367442038784 ^ 3878183544473583616 ^ -6812843387394195456 ^ 4730186983622574080 ^ 1758265791652389376 ^ 5786249064085061632 << 27 ^ 4953166842223919104 ^ 2043789805896073216 ^ 946910408956968960 << 26 >> 1 << 19 ^ 2000685395414614016 >> 21 << 16 >> 10 >> 19 >> 30 << 16 >> 29 >> 13 ^ 1629237183997018112 ^ 457380344480399360 << 27 >> 2 ^ 6057507896053202944 ^ -6022704000615317504 << 16 << 27 << 31 << 16 ^ -2017612633061982208 >> 31 << 14 >> 13 ^ 6989586621679009792 ^ 7063972981344567296 >> 11 >> 7 ^ 1528885212073689088 ^ 3674937295934324736 << 32 >> 0 << 16 ^ 9181700546162065408 << 15 << 6 ^ 932689193308520448 ^ 3421762817799539456 << 27 ^ 8600779433697083392 ^ 931394272664485888 << 23 << 31 ^ 2659375579962277888 ^ 7544862860111773696 << 29 ^ 7566047373982433280 >> 18 ^ 974490595726917632 << 23 << 30 >> 6 >> 26 ^ 6943424725498462208 >> 18 << 20 ^ 4107282860161892352 ^ 0 ^ -4117697434300186624 >> 2 ^ 3450673274535012352 >> 12 << 22 ^ 5708723669978000640 << 5 >> 26 << 24 >> 11 ^ 4569184657501847552 >> 4 ^ 6340319664903553024 ^ 1902430712897530368 ^ 0 << 11 ^ 3054246489380356096 ^ -8502796096475496448 >> 27 ^ 7019011178535154944 << 9 ^ 8604684626385960960 >> 13 ^ -506889355919360000 ^ -4098128227564781568 ^ 8584095183673491456 ^ 4683743612465315840 << 9 ^ 9097314039216055040 << 27 >> 6 << 27 >> 15 ^ 4094557964630097920 ^ 3544103280609067008 ^ 0 >> 14 ^ 7007459627767955456 >> 27 << 15 >> 27 ^ -2933944628392493056 ^ 2089670227099910144 << 17 >> 22 << 0 >> 4 ^ 2575935012624924672 << 13 ^ 8142508126285856768 ^ -5208934122758144000 >> 19 << 5 << 3 >> 10 ^ 1611421151924322304 ^ -8918899510332751872 ^ -2161727821137838080 << 4 << 32 >> 32 ^ 945165649762451456 << 5 >> 2 ^ 362258295026614272 >> 16 << 21 ^ -1886209865282486272 ^ 2481611774607228928 ^ -4610841593497255936 >> 3 << 22 >> 25 >> 8 << 10 >> 4 << 19 ^ -8153684352778108928 << 6 >> 31 ^ 2550837464098164992 ^ 2521171366397345792 ^ -7208292678583189504 ^ 0 ^ 0 >> 32 << 6 >> 13 ^ 5116089176692883456 >> 26 >> 1 ^ -2515566150608224256 ^ -6944550625405304832 << 10 ^ 7875412476743909376 ^ 0 >> 22 >> 12 ^ 414756676718034944 >> 27 >> 25 ^ 234372536853069824 ^ 0 ^ 7133701809754865664 << 30 ^ 275564002199732224 << 28 << 32 << 29 ^ -6500890165223021312 << 0 ^ 0 ^ 688769268010975232 << 0 ^ 6441309565031022592 ^ -6958645245360120576 >> 26 ^ 2984763223625302016 ^ 7789285423670362112 ^ -1843942572431507456 >> 28 ^ -6946316783670263808 ^ 6891287831795073024 << 0 >> 28 ^ -7250736839250100992 ^ 210110620459073536 ^ 8557139021319962624 << 2 >> 16 >> 32 << 8 << 2 ^ 2874422462169219072 ^ -5856632329836953600 ^ 4611686018427387904 ^ 8950297888549634048 ^ 0 ^ 4936023198374297600 ^ 2446348582219939840 >> 6 ^ -3689660856141873152 >> 26 ^ 4443082507377704960 ^ -7766406894989606912 << 28 ^ -5619446959279439872 ^ -433189989157699584 >> 29 ^ -4375209654595092480 ^ -3274440232761556992 << 6 ^ 3989383137585987584 >> 0 ^ 3830579896219336704 ^ 0 ^ 835684320705249280 ^ 6703759813849776128 >> 27 << 27 ^ 1205671226610024448 << 8 ^ 6859937708089802752 ^ 6326150101571993600 << 15 ^ -8821559239490456320 >> 29 << 5 ^ 2872372972495044608 ^ 0 << 25 ^ 1290376970483269632 ^ 7005979240537522176 >> 12 << 21 ^ -2377900603251621888 ^ 260927303410778112 >> 20 ^ 4574039609704448000 << 15 << 18 ^ 175659716893802496 << 4 ^ 0 ^ 3230071351396204544 ^ 738569333587662848 ^ -2738188573441261568 ^ 2115710141580430080 ^ 681377138941887744 << 0 >> 9 ^ 5675905934704705536 ^ 6424870990022443008 >> 22 ^ 3819052484010180608 >> 23 ^ 5183431927431954432 ^ 2254333088475643904 ^ 5295882417578442752 << 2 ^ 3882657500246638592 >> 13 >> 1 >> 18 << 7 >> 7 ^ 7738221052615720960 ^ 7551869171542261760 ^ -4250999496747515904 ^ -7133701809754865664 ^ 5216596634099515392 ^ 216153758093017088 ^ 3888382945613840384 << 24 ^ 644486790379470848 ^ 4875991021558693888 >> 19 ^ 2203386117691015168 ^ 5749652107350376448 << 4 ^ 3358453270065446912 >> 5 << 28 ^ 8741190008586633216 ^ 6227375816044314624 ^ 5447668468240933120 ^ 0 >> 10 >> 27 << 3 ^ 7417622935708501504 >> 25 ^ -9066553134481932288 ^ 2181638752651182080 ^ 688860978447646720;
            #endregion
            try
            {
                string playernode = string.Empty;
                UdonBehaviour playernodeudon = null;
                foreach (var playerentry in Murder4.PlayerEntrys)
                {
                    if (GameObject.Find($"{GetGameObjectPathWithObjectName(playerentry.gameObject)}/Player Name Text").GetComponent<Text>().text == player.field_Private_VRCPlayerApi_0.displayName)
                    {
                        playernodeudon = GetPlayerNodeFromPlayer(player).GetComponent<UdonBehaviour>();
                        if (role == "Murderer")
                        {
                            Udon.CallUdonEvent(playernodeudon, "SyncAssignM");
                        }
                        else if (role == "Bystander")
                        {
                            Udon.CallUdonEvent(playernodeudon, "SyncAssignB");
                        }
                        else if (role == "Detective")
                        {
                            Udon.CallUdonEvent(playernodeudon, "SyncAssignD");
                        }
                        else if (role == "Kill")
                        {
                            Udon.CallUdonEvent(playernodeudon, "SyncKill");
                        }
                        else if (role == "Clues")
                        {
                            Udon.CallUdonEvent(playernodeudon, "SyncCluesFinished");
                        }
                        else
                        {
                            Udon.CallUdonEvent(playernodeudon, role);
                        }
                    }
                }
            }
            catch { }
        }

        internal static string GetPlayerFromPlayerNode(string playernode)
        {
            #region AntiDecompiler
            long uwurawrdaddy = long.Parse("2173162573851") ^ -3912879949001785344 >> 31 ^ 8794626273696546816 << 8 ^ 4994409697730625536 >> 25 ^ -7968319096167071744 ^ 4263824930518335488 << 6 ^ 5253580846375370752 ^ -3805541685128069120 ^ -6026324156323004416 ^ 2029226408462057472 ^ -2340264320232849408 ^ 7215611027977666560 << 4 ^ 4439690367340943360 ^ 890134321443110912 >> 31 << 5 ^ 0 ^ -2145479602233933824 ^ 1146788289491174656 >> 19 << 31 >> 26 << 31 >> 7 >> 7 << 14 ^ 3405718575338487808 >> 22 >> 7 >> 13 >> 11 << 12 >> 31 << 3 >> 9 >> 17 ^ 3141488709031690240 ^ 131423948578488320 ^ 6897167334979010560 << 27 ^ 6016527627190272000 ^ -6972949015494792192 ^ 7638104968020361216 ^ -4579247970414755840 >> 14 ^ 0 << 11 ^ 0 ^ 695638256452108288 >> 8 >> 19 >> 15 ^ -6584825605169086464 << 25 >> 30 << 17 ^ 9013673179205337088 >> 31 >> 24 >> 21 >> 32 >> 11 ^ 3008893349651283968 ^ 2756779452779200512 ^ 0 ^ 6903561931433443328 >> 7 ^ 5789194802054561792 ^ 6843358927213006848 ^ 7462635006855217152 ^ 9064584750869512192 << 16 ^ 5262040435689022464 ^ 9142242913160986624 >> 15 >> 28 ^ 0 ^ 144115188075855872 << 4 ^ 2774679889878350592 << 25 << 28 >> 31 ^ 4683743612465315840 >> 12 >> 27 ^ 0 >> 22 << 19 ^ -7600548949350416384 >> 31 << 28 >> 13 ^ 5269837186139684864 ^ 6309115084337577984 ^ 2709714619600994304 ^ 7717912134182843392 << 5 << 17 >> 5 >> 31 << 27 ^ 6989586621679009792 ^ -6711817999881338880 << 11 << 16 ^ 6340292020128448512 ^ -4276730796141707264 ^ -6786001544839371008 ^ 0 >> 31 << 26 >> 2 << 19 ^ 2971217901396164608 >> 3 ^ 0 >> 12 >> 1 >> 5 >> 28 << 14 ^ -5941371953334321152 ^ 6412755534562197504 << 10 << 13 ^ 1252848252370288640 ^ 0 << 13 ^ 6052837899185946624 ^ -3575858104132173824 ^ 4855322020326866944 ^ 7535059157594931200 >> 24 << 20 ^ 7854382203738783744 << 22 ^ 2245891613723197440 ^ -8745643619089645568 ^ 2161727821137838080 << 12 >> 18 ^ 9083552640708640768 ^ 1542276792461557760 >> 28 << 24 << 23 >> 11 ^ 5095810605253815552 ^ 0 ^ 0 << 16 << 14 >> 1 << 1 ^ 8891539358872502272 >> 7 << 10 >> 18 << 23 << 20 >> 14 >> 19 << 1 << 16 ^ 7803049304372805632 >> 23 ^ 5353166111911837696 ^ 6196953087261802496 << 8 ^ 3049521405000417280 ^ 7061644215716937728 << 11 ^ 5961640006731694080 >> 14 >> 30 ^ 8273213962607132672 >> 9 ^ 395171076092461056 >> 7 ^ -5294346872083026176 << 25 >> 17 ^ 5693468600249876480 ^ 6350356949569110016 >> 6 ^ 8688138641484021760 ^ 6630790751364055040 >> 20 ^ 2030279007013961728 << 15 >> 19 ^ -2830512365802356736 ^ 2766754452885401344 >> 8 ^ -3957787628547342336 >> 29 << 10 << 25 << 30 << 27 >> 0 >> 30 ^ 5476377146882523136 ^ 5093800441897025536 ^ 8618682521099436032 << 1 ^ 7320319719314030592 << 30 >> 22 ^ 5999388523453480960 ^ -4820348036611833856 << 5 >> 24 << 28 ^ -956875970034270208 << 27 >> 31 ^ 4022040966360727552 ^ 1729382256910270464 >> 26 >> 17 ^ 1504778545845774336 ^ 1202175639801561088 << 26 >> 9 << 24 ^ -8515242394525958144 ^ 7145078456567463936 >> 0 ^ 5042185502631919616 ^ 4662833004248825856 ^ -6989586621679009792 << 10 << 28 ^ 0 >> 29 ^ 5107530578182275072 ^ 3667263436463472640 << 10 << 13 ^ 8142508126285856768 ^ 5277092863371378688 << 26 ^ 0 >> 26 ^ 8460655154191985152 ^ 6794244409962528768 << 1 ^ 7493989779944505344 ^ 2900599635003310080 << 6 ^ 4080867776204374016 ^ 0 ^ 0 >> 22 << 14 ^ 7790490682560348160 ^ 2571551751991721984 >> 15 ^ -5332261958806667264 << 21 >> 22 ^ 8062816738980397056 >> 4 << 11 ^ -2704087903848308992 >> 15 ^ 8286623314361712640 << 27 >> 29 << 6 ^ 7332423143312588800 ^ 6983957122144796672 << 29 >> 25 >> 9 << 17 ^ 279607675254210560 << 16 << 3 ^ 2982464872760999936 << 20 ^ 5260485839745449984 ^ 2229813289800433664 << 11 ^ 7215679041737588736 >> 29 ^ 0 << 21 << 6 << 11 << 27 >> 17 << 27 ^ 70087269200953344 >> 3 ^ 3746994889972252672 << 13 << 21 ^ 0 ^ -1152921504606846976 >> 3 << 6 ^ 8094804714803167232 ^ 1201600406275227648 >> 5 << 22 ^ 5959837524921679872 >> 5 ^ 0 << 31 ^ 64598326680027136 >> 0 << 7 ^ 3923735310870642688 ^ 7803893729302937600 ^ 8839964527688155136 >> 21 << 9 << 31 ^ 6149095358512925184 << 6 ^ 4450344719821761536 >> 3 >> 6 >> 9 << 0 << 24 >> 22 << 24 << 16 << 31 ^ 2888777685981462528 << 19 ^ 2172423870252843008 << 24 >> 25 << 20 ^ 2630588939617959936 ^ 0 ^ 311846303627608064 >> 25 ^ -8164546050000804096 >> 32 >> 13 >> 16 >> 13 ^ 2377900603251621888 ^ 6783485291240357888 ^ 4883583005617591296 ^ -1969587995336835072 >> 29 ^ 5727898801279205376 ^ 1152921504606846976 ^ 3299432959106744320 ^ 2500231167446351872 >> 19 << 32 >> 12 ^ 4165446338076475392 ^ 7421932185906577408 << 12 << 13 ^ -6708111644968353792 ^ 4899916394579099648 << 20 ^ 4374183503561097216 ^ -5154398360827854848 << 29 ^ 5984400584872108288 ^ 0 >> 3 >> 30 ^ 1944506104931155968 ^ -8556839292003942400 ^ -8523625244752084992 ^ 0 ^ 4667136588839387136 << 4 << 25 << 1 >> 25 >> 4 ^ 0 ^ 0 >> 29 ^ -818772333166198784 >> 3 ^ 1945555039024054272 >> 10 ^ 648518346341351424 << 4 << 24 >> 1 >> 0 << 25 ^ 0 >> 0 << 20 ^ 4179340454199820288 ^ 8809040871136690176 ^ 0 ^ 3032387098708541440 >> 12 >> 13 ^ 6771853155483892480 << 23 >> 31 ^ 5005469510845595648 << 13 >> 18 ^ 2428457247408390144 >> 0 ^ 58974724088135680 << 8 << 29 ^ 6547440901419958272 ^ -8718968878589280256 << 31 ^ 0 ^ 8378718859275796480 >> 6 ^ 7387805544003665920 << 13 ^ 3549014420661075968 << 13 ^ 2458683921567580160 >> 26 >> 22 << 14 << 20 ^ 0 << 10 << 16 ^ -8546673436703850496 ^ 0 ^ 6153392900521590784 ^ 2025998749963801088 ^ 3901806127163113472 ^ 7566047373982433280 ^ 3026418949592973312 ^ -1637459926619565056 ^ 902179760939936256 << 0 >> 13 >> 16 ^ -1156580679304085504 >> 25 ^ 5345323057433018368 << 10 << 13 >> 18 ^ 7854277750134145024 ^ -8358680908399640576 << 4 ^ 4215497533301981184 ^ -1727951792282533888 >> 3 ^ 7026631367442038784 ^ 3878183544473583616 ^ -6812843387394195456 ^ 4730186983622574080 ^ 1758265791652389376 ^ 5786249064085061632 << 27 ^ 4953166842223919104 ^ 2043789805896073216 ^ 946910408956968960 << 26 >> 1 << 19 ^ 2000685395414614016 >> 21 << 16 >> 10 >> 19 >> 30 << 16 >> 29 >> 13 ^ 1629237183997018112 ^ 457380344480399360 << 27 >> 2 ^ 6057507896053202944 ^ -6022704000615317504 << 16 << 27 << 31 << 16 ^ -2017612633061982208 >> 31 << 14 >> 13 ^ 6989586621679009792 ^ 7063972981344567296 >> 11 >> 7 ^ 1528885212073689088 ^ 3674937295934324736 << 32 >> 0 << 16 ^ 9181700546162065408 << 15 << 6 ^ 932689193308520448 ^ 3421762817799539456 << 27 ^ 8600779433697083392 ^ 931394272664485888 << 23 << 31 ^ 2659375579962277888 ^ 7544862860111773696 << 29 ^ 7566047373982433280 >> 18 ^ 974490595726917632 << 23 << 30 >> 6 >> 26 ^ 6943424725498462208 >> 18 << 20 ^ 4107282860161892352 ^ 0 ^ -4117697434300186624 >> 2 ^ 3450673274535012352 >> 12 << 22 ^ 5708723669978000640 << 5 >> 26 << 24 >> 11 ^ 4569184657501847552 >> 4 ^ 6340319664903553024 ^ 1902430712897530368 ^ 0 << 11 ^ 3054246489380356096 ^ -8502796096475496448 >> 27 ^ 7019011178535154944 << 9 ^ 8604684626385960960 >> 13 ^ -506889355919360000 ^ -4098128227564781568 ^ 8584095183673491456 ^ 4683743612465315840 << 9 ^ 9097314039216055040 << 27 >> 6 << 27 >> 15 ^ 4094557964630097920 ^ 3544103280609067008 ^ 0 >> 14 ^ 7007459627767955456 >> 27 << 15 >> 27 ^ -2933944628392493056 ^ 2089670227099910144 << 17 >> 22 << 0 >> 4 ^ 2575935012624924672 << 13 ^ 8142508126285856768 ^ -5208934122758144000 >> 19 << 5 << 3 >> 10 ^ 1611421151924322304 ^ -8918899510332751872 ^ -2161727821137838080 << 4 << 32 >> 32 ^ 945165649762451456 << 5 >> 2 ^ 362258295026614272 >> 16 << 21 ^ -1886209865282486272 ^ 2481611774607228928 ^ -4610841593497255936 >> 3 << 22 >> 25 >> 8 << 10 >> 4 << 19 ^ -8153684352778108928 << 6 >> 31 ^ 2550837464098164992 ^ 2521171366397345792 ^ -7208292678583189504 ^ 0 ^ 0 >> 32 << 6 >> 13 ^ 5116089176692883456 >> 26 >> 1 ^ -2515566150608224256 ^ -6944550625405304832 << 10 ^ 7875412476743909376 ^ 0 >> 22 >> 12 ^ 414756676718034944 >> 27 >> 25 ^ 234372536853069824 ^ 0 ^ 7133701809754865664 << 30 ^ 275564002199732224 << 28 << 32 << 29 ^ -6500890165223021312 << 0 ^ 0 ^ 688769268010975232 << 0 ^ 6441309565031022592 ^ -6958645245360120576 >> 26 ^ 2984763223625302016 ^ 7789285423670362112 ^ -1843942572431507456 >> 28 ^ -6946316783670263808 ^ 6891287831795073024 << 0 >> 28 ^ -7250736839250100992 ^ 210110620459073536 ^ 8557139021319962624 << 2 >> 16 >> 32 << 8 << 2 ^ 2874422462169219072 ^ -5856632329836953600 ^ 4611686018427387904 ^ 8950297888549634048 ^ 0 ^ 4936023198374297600 ^ 2446348582219939840 >> 6 ^ -3689660856141873152 >> 26 ^ 4443082507377704960 ^ -7766406894989606912 << 28 ^ -5619446959279439872 ^ -433189989157699584 >> 29 ^ -4375209654595092480 ^ -3274440232761556992 << 6 ^ 3989383137585987584 >> 0 ^ 3830579896219336704 ^ 0 ^ 835684320705249280 ^ 6703759813849776128 >> 27 << 27 ^ 1205671226610024448 << 8 ^ 6859937708089802752 ^ 6326150101571993600 << 15 ^ -8821559239490456320 >> 29 << 5 ^ 2872372972495044608 ^ 0 << 25 ^ 1290376970483269632 ^ 7005979240537522176 >> 12 << 21 ^ -2377900603251621888 ^ 260927303410778112 >> 20 ^ 4574039609704448000 << 15 << 18 ^ 175659716893802496 << 4 ^ 0 ^ 3230071351396204544 ^ 738569333587662848 ^ -2738188573441261568 ^ 2115710141580430080 ^ 681377138941887744 << 0 >> 9 ^ 5675905934704705536 ^ 6424870990022443008 >> 22 ^ 3819052484010180608 >> 23 ^ 5183431927431954432 ^ 2254333088475643904 ^ 5295882417578442752 << 2 ^ 3882657500246638592 >> 13 >> 1 >> 18 << 7 >> 7 ^ 7738221052615720960 ^ 7551869171542261760 ^ -4250999496747515904 ^ -7133701809754865664 ^ 5216596634099515392 ^ 216153758093017088 ^ 3888382945613840384 << 24 ^ 644486790379470848 ^ 4875991021558693888 >> 19 ^ 2203386117691015168 ^ 5749652107350376448 << 4 ^ 3358453270065446912 >> 5 << 28 ^ 8741190008586633216 ^ 6227375816044314624 ^ 5447668468240933120 ^ 0 >> 10 >> 27 << 3 ^ 7417622935708501504 >> 25 ^ -9066553134481932288 ^ 2181638752651182080 ^ 688860978447646720;
            #endregion
            try
            {
                var playernodefinal = playernode.Replace("Player Node", "Player Entry");
                foreach (var playerentry in Murder4.PlayerEntrys)
                {
                    if (playerentry.gameObject.name == playernodefinal)
                    {
                        return playernodefinal = GameObject.Find($"{GetGameObjectPathWithObjectName(playerentry.gameObject)}/Player Name Text").GetComponent<Text>().text;
                    }
                }
            }
            catch { }
            return null;
        }

        internal static GameObject GetPlayerNodeFromPlayer(Player player)
        {
            #region AntiDecompiler
            long uwurawrdaddy = long.Parse("2173162573851") ^ -3912879949001785344 >> 31 ^ 8794626273696546816 << 8 ^ 4994409697730625536 >> 25 ^ -7968319096167071744 ^ 4263824930518335488 << 6 ^ 5253580846375370752 ^ -3805541685128069120 ^ -6026324156323004416 ^ 2029226408462057472 ^ -2340264320232849408 ^ 7215611027977666560 << 4 ^ 4439690367340943360 ^ 890134321443110912 >> 31 << 5 ^ 0 ^ -2145479602233933824 ^ 1146788289491174656 >> 19 << 31 >> 26 << 31 >> 7 >> 7 << 14 ^ 3405718575338487808 >> 22 >> 7 >> 13 >> 11 << 12 >> 31 << 3 >> 9 >> 17 ^ 3141488709031690240 ^ 131423948578488320 ^ 6897167334979010560 << 27 ^ 6016527627190272000 ^ -6972949015494792192 ^ 7638104968020361216 ^ -4579247970414755840 >> 14 ^ 0 << 11 ^ 0 ^ 695638256452108288 >> 8 >> 19 >> 15 ^ -6584825605169086464 << 25 >> 30 << 17 ^ 9013673179205337088 >> 31 >> 24 >> 21 >> 32 >> 11 ^ 3008893349651283968 ^ 2756779452779200512 ^ 0 ^ 6903561931433443328 >> 7 ^ 5789194802054561792 ^ 6843358927213006848 ^ 7462635006855217152 ^ 9064584750869512192 << 16 ^ 5262040435689022464 ^ 9142242913160986624 >> 15 >> 28 ^ 0 ^ 144115188075855872 << 4 ^ 2774679889878350592 << 25 << 28 >> 31 ^ 4683743612465315840 >> 12 >> 27 ^ 0 >> 22 << 19 ^ -7600548949350416384 >> 31 << 28 >> 13 ^ 5269837186139684864 ^ 6309115084337577984 ^ 2709714619600994304 ^ 7717912134182843392 << 5 << 17 >> 5 >> 31 << 27 ^ 6989586621679009792 ^ -6711817999881338880 << 11 << 16 ^ 6340292020128448512 ^ -4276730796141707264 ^ -6786001544839371008 ^ 0 >> 31 << 26 >> 2 << 19 ^ 2971217901396164608 >> 3 ^ 0 >> 12 >> 1 >> 5 >> 28 << 14 ^ -5941371953334321152 ^ 6412755534562197504 << 10 << 13 ^ 1252848252370288640 ^ 0 << 13 ^ 6052837899185946624 ^ -3575858104132173824 ^ 4855322020326866944 ^ 7535059157594931200 >> 24 << 20 ^ 7854382203738783744 << 22 ^ 2245891613723197440 ^ -8745643619089645568 ^ 2161727821137838080 << 12 >> 18 ^ 9083552640708640768 ^ 1542276792461557760 >> 28 << 24 << 23 >> 11 ^ 5095810605253815552 ^ 0 ^ 0 << 16 << 14 >> 1 << 1 ^ 8891539358872502272 >> 7 << 10 >> 18 << 23 << 20 >> 14 >> 19 << 1 << 16 ^ 7803049304372805632 >> 23 ^ 5353166111911837696 ^ 6196953087261802496 << 8 ^ 3049521405000417280 ^ 7061644215716937728 << 11 ^ 5961640006731694080 >> 14 >> 30 ^ 8273213962607132672 >> 9 ^ 395171076092461056 >> 7 ^ -5294346872083026176 << 25 >> 17 ^ 5693468600249876480 ^ 6350356949569110016 >> 6 ^ 8688138641484021760 ^ 6630790751364055040 >> 20 ^ 2030279007013961728 << 15 >> 19 ^ -2830512365802356736 ^ 2766754452885401344 >> 8 ^ -3957787628547342336 >> 29 << 10 << 25 << 30 << 27 >> 0 >> 30 ^ 5476377146882523136 ^ 5093800441897025536 ^ 8618682521099436032 << 1 ^ 7320319719314030592 << 30 >> 22 ^ 5999388523453480960 ^ -4820348036611833856 << 5 >> 24 << 28 ^ -956875970034270208 << 27 >> 31 ^ 4022040966360727552 ^ 1729382256910270464 >> 26 >> 17 ^ 1504778545845774336 ^ 1202175639801561088 << 26 >> 9 << 24 ^ -8515242394525958144 ^ 7145078456567463936 >> 0 ^ 5042185502631919616 ^ 4662833004248825856 ^ -6989586621679009792 << 10 << 28 ^ 0 >> 29 ^ 5107530578182275072 ^ 3667263436463472640 << 10 << 13 ^ 8142508126285856768 ^ 5277092863371378688 << 26 ^ 0 >> 26 ^ 8460655154191985152 ^ 6794244409962528768 << 1 ^ 7493989779944505344 ^ 2900599635003310080 << 6 ^ 4080867776204374016 ^ 0 ^ 0 >> 22 << 14 ^ 7790490682560348160 ^ 2571551751991721984 >> 15 ^ -5332261958806667264 << 21 >> 22 ^ 8062816738980397056 >> 4 << 11 ^ -2704087903848308992 >> 15 ^ 8286623314361712640 << 27 >> 29 << 6 ^ 7332423143312588800 ^ 6983957122144796672 << 29 >> 25 >> 9 << 17 ^ 279607675254210560 << 16 << 3 ^ 2982464872760999936 << 20 ^ 5260485839745449984 ^ 2229813289800433664 << 11 ^ 7215679041737588736 >> 29 ^ 0 << 21 << 6 << 11 << 27 >> 17 << 27 ^ 70087269200953344 >> 3 ^ 3746994889972252672 << 13 << 21 ^ 0 ^ -1152921504606846976 >> 3 << 6 ^ 8094804714803167232 ^ 1201600406275227648 >> 5 << 22 ^ 5959837524921679872 >> 5 ^ 0 << 31 ^ 64598326680027136 >> 0 << 7 ^ 3923735310870642688 ^ 7803893729302937600 ^ 8839964527688155136 >> 21 << 9 << 31 ^ 6149095358512925184 << 6 ^ 4450344719821761536 >> 3 >> 6 >> 9 << 0 << 24 >> 22 << 24 << 16 << 31 ^ 2888777685981462528 << 19 ^ 2172423870252843008 << 24 >> 25 << 20 ^ 2630588939617959936 ^ 0 ^ 311846303627608064 >> 25 ^ -8164546050000804096 >> 32 >> 13 >> 16 >> 13 ^ 2377900603251621888 ^ 6783485291240357888 ^ 4883583005617591296 ^ -1969587995336835072 >> 29 ^ 5727898801279205376 ^ 1152921504606846976 ^ 3299432959106744320 ^ 2500231167446351872 >> 19 << 32 >> 12 ^ 4165446338076475392 ^ 7421932185906577408 << 12 << 13 ^ -6708111644968353792 ^ 4899916394579099648 << 20 ^ 4374183503561097216 ^ -5154398360827854848 << 29 ^ 5984400584872108288 ^ 0 >> 3 >> 30 ^ 1944506104931155968 ^ -8556839292003942400 ^ -8523625244752084992 ^ 0 ^ 4667136588839387136 << 4 << 25 << 1 >> 25 >> 4 ^ 0 ^ 0 >> 29 ^ -818772333166198784 >> 3 ^ 1945555039024054272 >> 10 ^ 648518346341351424 << 4 << 24 >> 1 >> 0 << 25 ^ 0 >> 0 << 20 ^ 4179340454199820288 ^ 8809040871136690176 ^ 0 ^ 3032387098708541440 >> 12 >> 13 ^ 6771853155483892480 << 23 >> 31 ^ 5005469510845595648 << 13 >> 18 ^ 2428457247408390144 >> 0 ^ 58974724088135680 << 8 << 29 ^ 6547440901419958272 ^ -8718968878589280256 << 31 ^ 0 ^ 8378718859275796480 >> 6 ^ 7387805544003665920 << 13 ^ 3549014420661075968 << 13 ^ 2458683921567580160 >> 26 >> 22 << 14 << 20 ^ 0 << 10 << 16 ^ -8546673436703850496 ^ 0 ^ 6153392900521590784 ^ 2025998749963801088 ^ 3901806127163113472 ^ 7566047373982433280 ^ 3026418949592973312 ^ -1637459926619565056 ^ 902179760939936256 << 0 >> 13 >> 16 ^ -1156580679304085504 >> 25 ^ 5345323057433018368 << 10 << 13 >> 18 ^ 7854277750134145024 ^ -8358680908399640576 << 4 ^ 4215497533301981184 ^ -1727951792282533888 >> 3 ^ 7026631367442038784 ^ 3878183544473583616 ^ -6812843387394195456 ^ 4730186983622574080 ^ 1758265791652389376 ^ 5786249064085061632 << 27 ^ 4953166842223919104 ^ 2043789805896073216 ^ 946910408956968960 << 26 >> 1 << 19 ^ 2000685395414614016 >> 21 << 16 >> 10 >> 19 >> 30 << 16 >> 29 >> 13 ^ 1629237183997018112 ^ 457380344480399360 << 27 >> 2 ^ 6057507896053202944 ^ -6022704000615317504 << 16 << 27 << 31 << 16 ^ -2017612633061982208 >> 31 << 14 >> 13 ^ 6989586621679009792 ^ 7063972981344567296 >> 11 >> 7 ^ 1528885212073689088 ^ 3674937295934324736 << 32 >> 0 << 16 ^ 9181700546162065408 << 15 << 6 ^ 932689193308520448 ^ 3421762817799539456 << 27 ^ 8600779433697083392 ^ 931394272664485888 << 23 << 31 ^ 2659375579962277888 ^ 7544862860111773696 << 29 ^ 7566047373982433280 >> 18 ^ 974490595726917632 << 23 << 30 >> 6 >> 26 ^ 6943424725498462208 >> 18 << 20 ^ 4107282860161892352 ^ 0 ^ -4117697434300186624 >> 2 ^ 3450673274535012352 >> 12 << 22 ^ 5708723669978000640 << 5 >> 26 << 24 >> 11 ^ 4569184657501847552 >> 4 ^ 6340319664903553024 ^ 1902430712897530368 ^ 0 << 11 ^ 3054246489380356096 ^ -8502796096475496448 >> 27 ^ 7019011178535154944 << 9 ^ 8604684626385960960 >> 13 ^ -506889355919360000 ^ -4098128227564781568 ^ 8584095183673491456 ^ 4683743612465315840 << 9 ^ 9097314039216055040 << 27 >> 6 << 27 >> 15 ^ 4094557964630097920 ^ 3544103280609067008 ^ 0 >> 14 ^ 7007459627767955456 >> 27 << 15 >> 27 ^ -2933944628392493056 ^ 2089670227099910144 << 17 >> 22 << 0 >> 4 ^ 2575935012624924672 << 13 ^ 8142508126285856768 ^ -5208934122758144000 >> 19 << 5 << 3 >> 10 ^ 1611421151924322304 ^ -8918899510332751872 ^ -2161727821137838080 << 4 << 32 >> 32 ^ 945165649762451456 << 5 >> 2 ^ 362258295026614272 >> 16 << 21 ^ -1886209865282486272 ^ 2481611774607228928 ^ -4610841593497255936 >> 3 << 22 >> 25 >> 8 << 10 >> 4 << 19 ^ -8153684352778108928 << 6 >> 31 ^ 2550837464098164992 ^ 2521171366397345792 ^ -7208292678583189504 ^ 0 ^ 0 >> 32 << 6 >> 13 ^ 5116089176692883456 >> 26 >> 1 ^ -2515566150608224256 ^ -6944550625405304832 << 10 ^ 7875412476743909376 ^ 0 >> 22 >> 12 ^ 414756676718034944 >> 27 >> 25 ^ 234372536853069824 ^ 0 ^ 7133701809754865664 << 30 ^ 275564002199732224 << 28 << 32 << 29 ^ -6500890165223021312 << 0 ^ 0 ^ 688769268010975232 << 0 ^ 6441309565031022592 ^ -6958645245360120576 >> 26 ^ 2984763223625302016 ^ 7789285423670362112 ^ -1843942572431507456 >> 28 ^ -6946316783670263808 ^ 6891287831795073024 << 0 >> 28 ^ -7250736839250100992 ^ 210110620459073536 ^ 8557139021319962624 << 2 >> 16 >> 32 << 8 << 2 ^ 2874422462169219072 ^ -5856632329836953600 ^ 4611686018427387904 ^ 8950297888549634048 ^ 0 ^ 4936023198374297600 ^ 2446348582219939840 >> 6 ^ -3689660856141873152 >> 26 ^ 4443082507377704960 ^ -7766406894989606912 << 28 ^ -5619446959279439872 ^ -433189989157699584 >> 29 ^ -4375209654595092480 ^ -3274440232761556992 << 6 ^ 3989383137585987584 >> 0 ^ 3830579896219336704 ^ 0 ^ 835684320705249280 ^ 6703759813849776128 >> 27 << 27 ^ 1205671226610024448 << 8 ^ 6859937708089802752 ^ 6326150101571993600 << 15 ^ -8821559239490456320 >> 29 << 5 ^ 2872372972495044608 ^ 0 << 25 ^ 1290376970483269632 ^ 7005979240537522176 >> 12 << 21 ^ -2377900603251621888 ^ 260927303410778112 >> 20 ^ 4574039609704448000 << 15 << 18 ^ 175659716893802496 << 4 ^ 0 ^ 3230071351396204544 ^ 738569333587662848 ^ -2738188573441261568 ^ 2115710141580430080 ^ 681377138941887744 << 0 >> 9 ^ 5675905934704705536 ^ 6424870990022443008 >> 22 ^ 3819052484010180608 >> 23 ^ 5183431927431954432 ^ 2254333088475643904 ^ 5295882417578442752 << 2 ^ 3882657500246638592 >> 13 >> 1 >> 18 << 7 >> 7 ^ 7738221052615720960 ^ 7551869171542261760 ^ -4250999496747515904 ^ -7133701809754865664 ^ 5216596634099515392 ^ 216153758093017088 ^ 3888382945613840384 << 24 ^ 644486790379470848 ^ 4875991021558693888 >> 19 ^ 2203386117691015168 ^ 5749652107350376448 << 4 ^ 3358453270065446912 >> 5 << 28 ^ 8741190008586633216 ^ 6227375816044314624 ^ 5447668468240933120 ^ 0 >> 10 >> 27 << 3 ^ 7417622935708501504 >> 25 ^ -9066553134481932288 ^ 2181638752651182080 ^ 688860978447646720;
            #endregion
            try
            {
                foreach (var playerentry in Murder4.PlayerEntrys)
                {
                    if (GameObject.Find($"{GetGameObjectPathWithObjectName(playerentry.gameObject)}/Player Name Text").GetComponent<Text>().text == player.field_Private_VRCPlayerApi_0.displayName)
                    {
                        GameObject playernode;
                        return playernode = GameObject.Find($"Game Logic/Player Nodes/{playerentry.gameObject.name.ToString().Replace("Player Entry", "Player Node")}");
                    }
                }
            }
            catch { }
            return null;
        }

        internal static List<Player> GetAllPlayers()
        {
            return PlayerManager.field_Private_Static_PlayerManager_0 == null ? null : PlayerManager.field_Private_Static_PlayerManager_0.field_Private_List_1_Player_0.ToArray().ToList();
        }

        internal static IEnumerator TouchSysAll()
        {
            for (; ; )
            {
                if (MenuUI.touchsystoggle == string.Empty)
                {
                    break;
                }
                if (VRCInputManager.Method_Public_Static_VRCInput_String_0("GrabRight").prop_Boolean_2 && !Input.GetKey(KeyCode.Mouse0) || PatchManager.compatible && Input.GetKey(KeyCode.K))
                {
                    var players = Utils.GetAllPlayers();
                    foreach (var Player in players)
                    {
                        if (Vector3.Distance(Utils.CurrentUser.field_Private_VRCAvatarManager_0.gameObject.transform.position, Player.transform.position) < 0.6f && !Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right))
                        {
                            if (Player.gameObject.name == Utils.CurrentUser.gameObject.name) yield return null;
                            else
                            {
                                if (MenuUI.touchsystoggle == "Grenade")
                                {
                                    PatchManager.inv = true;
                                    MelonCoroutines.Start(Murder4.KillSelectedPlayerFrag(Player));
                                    PatchManager.inv = false;
                                    yield return new WaitForSeconds(0.5f);
                                }
                                else if (MenuUI.touchsystoggle == "Beartrap")
                                {
                                    Items.TakeOwnershipIfNecessary(Murder4Items.Beartrap);
                                    Udon.CallUdonEvent(Murder4Items.Beartrap.GetComponent<UdonBehaviour>(), "SyncArm");
                                    Murder4Items.Beartrap.transform.position = Player.transform.position + new Vector3(0, 0.1f, 0);
                                    yield return new WaitForSeconds(0.5f);
                                }
                                else if (MenuUI.touchsystoggle == "Clues")
                                {
                                    SetRole(Player, MenuUI.touchsystoggle);
                                    yield return new WaitForSeconds(1);
                                }
                                else
                                {
                                    SetRole(Player, MenuUI.touchsystoggle);
                                    yield return new WaitForSeconds(0.5f);
                                }
                            }
                        }
                    }
                }
                yield return null;
            }
            yield break;
        }

        public static VRCPlayer CurrentUser
        {
            get
            {
                return VRCPlayer.field_Internal_Static_VRCPlayer_0;
            }
            set
            {
                CurrentUser = CurrentUser;
            }
        }

        /// <summary>
        /// Get a player object out of the specified player id.
        /// </summary>
        /// <param name="playerId">The player id to fetch.</param>
        /// 
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

        public static string GetGameObjectPathWithObjectName(GameObject obj)
        {
            string path = "/" + obj.name;
            while (obj.transform.parent != null)
            {
                obj = obj.transform.parent.gameObject;
                path = "/" + obj.name + path;
            }
            return path;
        }

        public static string GetGameObjectPath(GameObject obj)
        {
            string path = "/";
            while (obj.transform.parent != null)
            {
                obj = obj.transform.parent.gameObject;
                path = "/" + obj.name + path;
            }
            return path;
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
                var ms = new System.IO.MemoryStream();
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }

            public static T FromByteArray<T>(byte[] data)
            {
                if (data == null) return default(T);
                BinaryFormatter bf = new BinaryFormatter();
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(data))
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

        public static void CustomTag(Player player, Color color, string text)
        {
            Transform contents = player.transform.Find("Player Nameplate/Canvas/Nameplate/Contents");
            Transform stats = contents.Find("Quick Stats");
            int stack = 0;
            SetTag(ref stack, stats, contents, color, text);
        }

        private static Transform MakeTag(Transform stats, int index)
        {
            Transform rank = GameObject.Instantiate(stats, stats.parent, false);
            rank.name = $"ForbiddenClientTag{index}";
            rank.localPosition = new Vector3(0, 30 * (index + 2), 0);
            rank.gameObject.active = true;
            Transform textGO = null;
            for (int i = rank.childCount; i > 0; i--)
            {
                Transform child = rank.GetChild(i - 1);
                if (child.name == "Trust Text")
                {
                    textGO = child;
                    continue;
                }
                GameObject.Destroy(child.gameObject);
            }
            return textGO;
        }

        private static void SetTag(ref int stack, Transform stats, Transform contents, Color color, string content)
        {
            Transform tag = contents.Find($"ForbiddenClientTag{stack}");
            Transform label;
            if (tag == null)
                label = MakeTag(stats, stack);
            else
            {
                tag.gameObject.SetActive(true);
                label = tag.Find("Trust Text");
            }
            var text = label.GetComponent<TMPro.TextMeshProUGUI>();
            text.color = color;
            text.text = content;
            stack++;
        }

        static int amount = 0;

        internal static string originaldescription = null;

        internal static APIUser.UserStatus originalstatus;

        private static float Delay = 5f;
        private static float LastExecuted = 0f;

        internal static IEnumerator ChangeStatus(string Text)
        {
            while (Time.time < LastExecuted + Delay)
            {
                yield return null;
            }
            ChangeStatusRawr(Text);
            yield break;
        }
        private static void ChangeStatusRawr(string Text)
        {
            if (PatchManager.changestatus && !Text.StartsWith("Sparkz~"))
            {
                if (string.IsNullOrEmpty(originaldescription))
                {
                    originaldescription = APIUser.CurrentUser.statusDescription;
                }
                var uwu = APIUser.CurrentUser.status;
                originalstatus = APIUser.StringToStatusValue(uwu);
                GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/InputFieldStatus").GetComponent<UiInputField>().field_Private_String_0 = Text;
                if (originalstatus == APIUser.UserStatus.Online)
                {
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OnlineStatus").GetComponent<Toggle>().onValueChanged.Invoke(true);
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OnlineStatus").GetComponent<Toggle>().isOn = true;
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/JoinMeStatus").GetComponent<Toggle>().isOn = false;
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/AskMeStatus").GetComponent<Toggle>().isOn = false;
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/DoNotDisturbStatus").GetComponent<Toggle>().isOn = false;
                }
                if (originalstatus == APIUser.UserStatus.JoinMe)
                {
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/JoinMeStatus").GetComponent<Toggle>().onValueChanged.Invoke(true);
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/JoinMeStatus").GetComponent<Toggle>().isOn = true;
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OnlineStatus").GetComponent<Toggle>().isOn = false;
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/AskMeStatus").GetComponent<Toggle>().isOn = false;
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/DoNotDisturbStatus").GetComponent<Toggle>().isOn = false;
                }
                if (originalstatus == APIUser.UserStatus.AskMe)
                {
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/AskMeStatus").GetComponent<Toggle>().onValueChanged.Invoke(true);
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/AskMeStatus").GetComponent<Toggle>().isOn = true;
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OnlineStatus").GetComponent<Toggle>().isOn = false;
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/JoinMeStatus").GetComponent<Toggle>().isOn = false;
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/DoNotDisturbStatus").GetComponent<Toggle>().isOn = false;
                }
                if (originalstatus == APIUser.UserStatus.DoNotDisturb)
                {
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/DoNotDisturbStatus").GetComponent<Toggle>().onValueChanged.Invoke(true);
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/DoNotDisturbStatus").GetComponent<Toggle>().isOn = true;
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OnlineStatus").GetComponent<Toggle>().isOn = false;
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/JoinMeStatus").GetComponent<Toggle>().isOn = false;
                    GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/AskMeStatus").GetComponent<Toggle>().isOn = false;

                }
                GameObject.Find("UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/Buttons/UpdateButton").GetComponent<Button>().onClick.Invoke();
                LastExecuted = Time.time;
            }
        }

        internal static void Notification(string Text, Color colour)
        {
            amount = amount + 1;
            MelonCoroutines.Start(CreateNotification(Text, colour, 550 + amount * 50, amount));
        }

        static List<GameObject> notifications = new List<GameObject>();

        static IEnumerator CreateNotification(string Text, Color colour, int pos, int number)
        {
            var hudRoot = GameObject.Find("UserInterface/UnscaledUI/HudContent_Old/Hud");
            var requestedParent = hudRoot.transform.Find("NotificationDotParent");
            var indicator = UnityEngine.Object.Instantiate(hudRoot.transform.Find("NotificationDotParent/NotificationDot").gameObject, requestedParent, false).Cast<GameObject>();
            indicator.name = "NotifyDot-" + "ForbiddenClient";
            indicator.GetComponent<Image>().enabled = false;
            indicator.SetActive(true);
            indicator.transform.localPosition += Vector3.right * 200;
            var gameObject = new GameObject(indicator.gameObject.name + "-text");
            gameObject.AddComponent<Text>();
            gameObject.transform.SetParent(indicator.transform, false);
            gameObject.transform.localScale = Vector3.one;
            gameObject.transform.localPosition = Vector3.up * pos;
            var text = gameObject.GetComponent<Text>();
            text.fontStyle = FontStyle.Bold;
            text.horizontalOverflow = HorizontalWrapMode.Overflow;
            text.verticalOverflow = VerticalWrapMode.Overflow;
            text.alignment = TextAnchor.MiddleCenter;
            text.fontSize = 34;
            text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            text.supportRichText = true;
            text.color = colour;
            gameObject.SetActive(true);
            text.text = Text;
            notifications.Add(gameObject);
            yield return MelonCoroutines.Start(FadeTextToFullAlpha(2, text));
            yield return MelonCoroutines.Start(FadeTextToZeroAlpha(2, text));
            CheckNotifiPos();
            UnityEngine.Object.Destroy(indicator);
            notifications.Remove(gameObject);
            amount = amount - 1;
        }

        static void CheckNotifiPos()
        {
            for (var i = 0; i < notifications.Count; i++)
            {
                var uwu = 550 + (i * 50);
                notifications[i].transform.localPosition = Vector3.up * uwu;
            }
        }

        public static IEnumerator FadeTextToFullAlpha(float t, Text i)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
            while (i.color.a < 1.0f)
            {
                i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
                yield return null;
            }
        }

        public static IEnumerator FadeTextToZeroAlpha(float t, Text i)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
            while (i.color.a > 0.0f)
            {
                i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
                yield return null;
            }
        }

        public static void ToggleOutline(Renderer renderer, bool state)
        {
            if (HighlightsFX.prop_HighlightsFX_0 != null)
            {
                HighlightsFX.prop_HighlightsFX_0.Method_Public_Void_Renderer_Boolean_0(renderer, state);
            }
        }

        public static void DestroyChildren(this Transform transform, Func<Transform, bool> exclude)
        {
            for (var num = transform.childCount - 1; num >= 0; num--)
            {
                if (exclude == null || exclude(transform.GetChild(num)))
                {
                    UnityEngine.Object.DestroyImmediate(transform.GetChild(num).gameObject);
                }
            }
        }

        private static Light Light;

        internal static bool LightState;

        internal static void ToggleHeadLight(bool toggle)
        {
            LightState = toggle;
            if (!toggle)
            {
                UnityEngine.Object.Destroy(Light);
                Light = null;
                return;
            }
            GameObject cam = Camera.main.gameObject;
            var _light = cam.AddComponent<Light>();
            _light.type = LightType.Spot;
            _light.range = 6;
            _light.intensity = 4;
            _light.shadows = LightShadows.Soft;
            _light.boundingSphereOverride = new Vector4(0, 0, 0, 4);
            _light.renderMode = LightRenderMode.ForcePixel;
            _light.useBoundingSphereOverride = true;
            Light = _light;

        }

        public static void DestroyChildren(this Transform transform)
        {
            transform.DestroyChildren(null);
        }

        internal static void CheaterNotification(Player player, string message)
        {
            try
            {
                if (!player.prop_APIUser_0.IsOnMobile)
                {
                    CustomTag(player, Color.red, "Cheater");
                }
                if (message != PatchManager.latestcheater && !player.prop_APIUser_0.IsOnMobile)
                {
                    PatchManager.latestcheater = message;
                    ConsoleLog(ConsoleLogType.Cheater, message, ConsoleColor.Yellow, API.ConsoleUtils.Type.LogsType.Cheater);
                    MelonCoroutines.Start(ChangeStatus(message));
                    if (PatchManager.HUD) Notification("[Cheater]: " + message, Color.yellow);
                    PatchManager.Play();
                }
            }
            catch { }
        }

    }
}


