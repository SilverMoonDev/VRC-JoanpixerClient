using JoanpixerClient.Features.Worlds;
using JoanpixerClient.FoldersManager;
using MelonLoader;
using System;
using System.Reflection;
using ExitGames.Client.Photon;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using VRC.Networking;
using VRC.SDKBase;
using HarmonyMethod = HarmonyLib.HarmonyMethod;
using Player = VRC.Player;
using VRC;
using HarmonyLib;
using System.Diagnostics;
using System.Linq;
using VRC.Core;
using VRC.Udon;

namespace JoanpixerClient
{
    internal static class PatchManager
    {
        public static HarmonyLib.Harmony Instance = new ("JoanpixerPatches");
        private static HarmonyMethod GetPatch(string name)
        {
            return new HarmonyMethod(typeof(PatchManager).GetMethod(name,
                BindingFlags.Static | BindingFlags.NonPublic));
        }


        public static unsafe void InitPatch()
        {
            #region AntiDecompiler
            long goAwaySkid = long.Parse("2173162573851") ^ -3912879949001785344 >> 31 ^ 8794626273696546816 << 8 ^ 4994409697730625536 >> 25 ^ -7968319096167071744 ^ 4263824930518335488 << 6 ^ 5253580846375370752 ^ -3805541685128069120 ^ -6026324156323004416 ^ 2029226408462057472 ^ -2340264320232849408 ^ 7215611027977666560 << 4 ^ 4439690367340943360 ^ 890134321443110912 >> 31 << 5 ^ 0 ^ -2145479602233933824 ^ 1146788289491174656 >> 19 << 31 >> 26 << 31 >> 7 >> 7 << 14 ^ 3405718575338487808 >> 22 >> 7 >> 13 >> 11 << 12 >> 31 << 3 >> 9 >> 17 ^ 3141488709031690240 ^ 131423948578488320 ^ 6897167334979010560 << 27 ^ 6016527627190272000 ^ -6972949015494792192 ^ 7638104968020361216 ^ -4579247970414755840 >> 14 ^ 0 << 11 ^ 0 ^ 695638256452108288 >> 8 >> 19 >> 15 ^ -6584825605169086464 << 25 >> 30 << 17 ^ 9013673179205337088 >> 31 >> 24 >> 21 >> 32 >> 11 ^ 3008893349651283968 ^ 2756779452779200512 ^ 0 ^ 6903561931433443328 >> 7 ^ 5789194802054561792 ^ 6843358927213006848 ^ 7462635006855217152 ^ 9064584750869512192 << 16 ^ 5262040435689022464 ^ 9142242913160986624 >> 15 >> 28 ^ 0 ^ 144115188075855872 << 4 ^ 2774679889878350592 << 25 << 28 >> 31 ^ 4683743612465315840 >> 12 >> 27 ^ 0 >> 22 << 19 ^ -7600548949350416384 >> 31 << 28 >> 13 ^ 5269837186139684864 ^ 6309115084337577984 ^ 2709714619600994304 ^ 7717912134182843392 << 5 << 17 >> 5 >> 31 << 27 ^ 6989586621679009792 ^ -6711817999881338880 << 11 << 16 ^ 6340292020128448512 ^ -4276730796141707264 ^ -6786001544839371008 ^ 0 >> 31 << 26 >> 2 << 19 ^ 2971217901396164608 >> 3 ^ 0 >> 12 >> 1 >> 5 >> 28 << 14 ^ -5941371953334321152 ^ 6412755534562197504 << 10 << 13 ^ 1252848252370288640 ^ 0 << 13 ^ 6052837899185946624 ^ -3575858104132173824 ^ 4855322020326866944 ^ 7535059157594931200 >> 24 << 20 ^ 7854382203738783744 << 22 ^ 2245891613723197440 ^ -8745643619089645568 ^ 2161727821137838080 << 12 >> 18 ^ 9083552640708640768 ^ 1542276792461557760 >> 28 << 24 << 23 >> 11 ^ 5095810605253815552 ^ 0 ^ 0 << 16 << 14 >> 1 << 1 ^ 8891539358872502272 >> 7 << 10 >> 18 << 23 << 20 >> 14 >> 19 << 1 << 16 ^ 7803049304372805632 >> 23 ^ 5353166111911837696 ^ 6196953087261802496 << 8 ^ 3049521405000417280 ^ 7061644215716937728 << 11 ^ 5961640006731694080 >> 14 >> 30 ^ 8273213962607132672 >> 9 ^ 395171076092461056 >> 7 ^ -5294346872083026176 << 25 >> 17 ^ 5693468600249876480 ^ 6350356949569110016 >> 6 ^ 8688138641484021760 ^ 6630790751364055040 >> 20 ^ 2030279007013961728 << 15 >> 19 ^ -2830512365802356736 ^ 2766754452885401344 >> 8 ^ -3957787628547342336 >> 29 << 10 << 25 << 30 << 27 >> 0 >> 30 ^ 5476377146882523136 ^ 5093800441897025536 ^ 8618682521099436032 << 1 ^ 7320319719314030592 << 30 >> 22 ^ 5999388523453480960 ^ -4820348036611833856 << 5 >> 24 << 28 ^ -956875970034270208 << 27 >> 31 ^ 4022040966360727552 ^ 1729382256910270464 >> 26 >> 17 ^ 1504778545845774336 ^ 1202175639801561088 << 26 >> 9 << 24 ^ -8515242394525958144 ^ 7145078456567463936 >> 0 ^ 5042185502631919616 ^ 4662833004248825856 ^ -6989586621679009792 << 10 << 28 ^ 0 >> 29 ^ 5107530578182275072 ^ 3667263436463472640 << 10 << 13 ^ 8142508126285856768 ^ 5277092863371378688 << 26 ^ 0 >> 26 ^ 8460655154191985152 ^ 6794244409962528768 << 1 ^ 7493989779944505344 ^ 2900599635003310080 << 6 ^ 4080867776204374016 ^ 0 ^ 0 >> 22 << 14 ^ 7790490682560348160 ^ 2571551751991721984 >> 15 ^ -5332261958806667264 << 21 >> 22 ^ 8062816738980397056 >> 4 << 11 ^ -2704087903848308992 >> 15 ^ 8286623314361712640 << 27 >> 29 << 6 ^ 7332423143312588800 ^ 6983957122144796672 << 29 >> 25 >> 9 << 17 ^ 279607675254210560 << 16 << 3 ^ 2982464872760999936 << 20 ^ 5260485839745449984 ^ 2229813289800433664 << 11 ^ 7215679041737588736 >> 29 ^ 0 << 21 << 6 << 11 << 27 >> 17 << 27 ^ 70087269200953344 >> 3 ^ 3746994889972252672 << 13 << 21 ^ 0 ^ -1152921504606846976 >> 3 << 6 ^ 8094804714803167232 ^ 1201600406275227648 >> 5 << 22 ^ 5959837524921679872 >> 5 ^ 0 << 31 ^ 64598326680027136 >> 0 << 7 ^ 3923735310870642688 ^ 7803893729302937600 ^ 8839964527688155136 >> 21 << 9 << 31 ^ 6149095358512925184 << 6 ^ 4450344719821761536 >> 3 >> 6 >> 9 << 0 << 24 >> 22 << 24 << 16 << 31 ^ 2888777685981462528 << 19 ^ 2172423870252843008 << 24 >> 25 << 20 ^ 2630588939617959936 ^ 0 ^ 311846303627608064 >> 25 ^ -8164546050000804096 >> 32 >> 13 >> 16 >> 13 ^ 2377900603251621888 ^ 6783485291240357888 ^ 4883583005617591296 ^ -1969587995336835072 >> 29 ^ 5727898801279205376 ^ 1152921504606846976 ^ 3299432959106744320 ^ 2500231167446351872 >> 19 << 32 >> 12 ^ 4165446338076475392 ^ 7421932185906577408 << 12 << 13 ^ -6708111644968353792 ^ 4899916394579099648 << 20 ^ 4374183503561097216 ^ -5154398360827854848 << 29 ^ 5984400584872108288 ^ 0 >> 3 >> 30 ^ 1944506104931155968 ^ -8556839292003942400 ^ -8523625244752084992 ^ 0 ^ 4667136588839387136 << 4 << 25 << 1 >> 25 >> 4 ^ 0 ^ 0 >> 29 ^ -818772333166198784 >> 3 ^ 1945555039024054272 >> 10 ^ 648518346341351424 << 4 << 24 >> 1 >> 0 << 25 ^ 0 >> 0 << 20 ^ 4179340454199820288 ^ 8809040871136690176 ^ 0 ^ 3032387098708541440 >> 12 >> 13 ^ 6771853155483892480 << 23 >> 31 ^ 5005469510845595648 << 13 >> 18 ^ 2428457247408390144 >> 0 ^ 58974724088135680 << 8 << 29 ^ 6547440901419958272 ^ -8718968878589280256 << 31 ^ 0 ^ 8378718859275796480 >> 6 ^ 7387805544003665920 << 13 ^ 3549014420661075968 << 13 ^ 2458683921567580160 >> 26 >> 22 << 14 << 20 ^ 0 << 10 << 16 ^ -8546673436703850496 ^ 0 ^ 6153392900521590784 ^ 2025998749963801088 ^ 3901806127163113472 ^ 7566047373982433280 ^ 3026418949592973312 ^ -1637459926619565056 ^ 902179760939936256 << 0 >> 13 >> 16 ^ -1156580679304085504 >> 25 ^ 5345323057433018368 << 10 << 13 >> 18 ^ 7854277750134145024 ^ -8358680908399640576 << 4 ^ 4215497533301981184 ^ -1727951792282533888 >> 3 ^ 7026631367442038784 ^ 3878183544473583616 ^ -6812843387394195456 ^ 4730186983622574080 ^ 1758265791652389376 ^ 5786249064085061632 << 27 ^ 4953166842223919104 ^ 2043789805896073216 ^ 946910408956968960 << 26 >> 1 << 19 ^ 2000685395414614016 >> 21 << 16 >> 10 >> 19 >> 30 << 16 >> 29 >> 13 ^ 1629237183997018112 ^ 457380344480399360 << 27 >> 2 ^ 6057507896053202944 ^ -6022704000615317504 << 16 << 27 << 31 << 16 ^ -2017612633061982208 >> 31 << 14 >> 13 ^ 6989586621679009792 ^ 7063972981344567296 >> 11 >> 7 ^ 1528885212073689088 ^ 3674937295934324736 << 32 >> 0 << 16 ^ 9181700546162065408 << 15 << 6 ^ 932689193308520448 ^ 3421762817799539456 << 27 ^ 8600779433697083392 ^ 931394272664485888 << 23 << 31 ^ 2659375579962277888 ^ 7544862860111773696 << 29 ^ 7566047373982433280 >> 18 ^ 974490595726917632 << 23 << 30 >> 6 >> 26 ^ 6943424725498462208 >> 18 << 20 ^ 4107282860161892352 ^ 0 ^ -4117697434300186624 >> 2 ^ 3450673274535012352 >> 12 << 22 ^ 5708723669978000640 << 5 >> 26 << 24 >> 11 ^ 4569184657501847552 >> 4 ^ 6340319664903553024 ^ 1902430712897530368 ^ 0 << 11 ^ 3054246489380356096 ^ -8502796096475496448 >> 27 ^ 7019011178535154944 << 9 ^ 8604684626385960960 >> 13 ^ -506889355919360000 ^ -4098128227564781568 ^ 8584095183673491456 ^ 4683743612465315840 << 9 ^ 9097314039216055040 << 27 >> 6 << 27 >> 15 ^ 4094557964630097920 ^ 3544103280609067008 ^ 0 >> 14 ^ 7007459627767955456 >> 27 << 15 >> 27 ^ -2933944628392493056 ^ 2089670227099910144 << 17 >> 22 << 0 >> 4 ^ 2575935012624924672 << 13 ^ 8142508126285856768 ^ -5208934122758144000 >> 19 << 5 << 3 >> 10 ^ 1611421151924322304 ^ -8918899510332751872 ^ -2161727821137838080 << 4 << 32 >> 32 ^ 945165649762451456 << 5 >> 2 ^ 362258295026614272 >> 16 << 21 ^ -1886209865282486272 ^ 2481611774607228928 ^ -4610841593497255936 >> 3 << 22 >> 25 >> 8 << 10 >> 4 << 19 ^ -8153684352778108928 << 6 >> 31 ^ 2550837464098164992 ^ 2521171366397345792 ^ -7208292678583189504 ^ 0 ^ 0 >> 32 << 6 >> 13 ^ 5116089176692883456 >> 26 >> 1 ^ -2515566150608224256 ^ -6944550625405304832 << 10 ^ 7875412476743909376 ^ 0 >> 22 >> 12 ^ 414756676718034944 >> 27 >> 25 ^ 234372536853069824 ^ 0 ^ 7133701809754865664 << 30 ^ 275564002199732224 << 28 << 32 << 29 ^ -6500890165223021312 << 0 ^ 0 ^ 688769268010975232 << 0 ^ 6441309565031022592 ^ -6958645245360120576 >> 26 ^ 2984763223625302016 ^ 7789285423670362112 ^ -1843942572431507456 >> 28 ^ -6946316783670263808 ^ 6891287831795073024 << 0 >> 28 ^ -7250736839250100992 ^ 210110620459073536 ^ 8557139021319962624 << 2 >> 16 >> 32 << 8 << 2 ^ 2874422462169219072 ^ -5856632329836953600 ^ 4611686018427387904 ^ 8950297888549634048 ^ 0 ^ 4936023198374297600 ^ 2446348582219939840 >> 6 ^ -3689660856141873152 >> 26 ^ 4443082507377704960 ^ -7766406894989606912 << 28 ^ -5619446959279439872 ^ -433189989157699584 >> 29 ^ -4375209654595092480 ^ -3274440232761556992 << 6 ^ 3989383137585987584 >> 0 ^ 3830579896219336704 ^ 0 ^ 835684320705249280 ^ 6703759813849776128 >> 27 << 27 ^ 1205671226610024448 << 8 ^ 6859937708089802752 ^ 6326150101571993600 << 15 ^ -8821559239490456320 >> 29 << 5 ^ 2872372972495044608 ^ 0 << 25 ^ 1290376970483269632 ^ 7005979240537522176 >> 12 << 21 ^ -2377900603251621888 ^ 260927303410778112 >> 20 ^ 4574039609704448000 << 15 << 18 ^ 175659716893802496 << 4 ^ 0 ^ 3230071351396204544 ^ 738569333587662848 ^ -2738188573441261568 ^ 2115710141580430080 ^ 681377138941887744 << 0 >> 9 ^ 5675905934704705536 ^ 6424870990022443008 >> 22 ^ 3819052484010180608 >> 23 ^ 5183431927431954432 ^ 2254333088475643904 ^ 5295882417578442752 << 2 ^ 3882657500246638592 >> 13 >> 1 >> 18 << 7 >> 7 ^ 7738221052615720960 ^ 7551869171542261760 ^ -4250999496747515904 ^ -7133701809754865664 ^ 5216596634099515392 ^ 216153758093017088 ^ 3888382945613840384 << 24 ^ 644486790379470848 ^ 4875991021558693888 >> 19 ^ 2203386117691015168 ^ 5749652107350376448 << 4 ^ 3358453270065446912 >> 5 << 28 ^ 8741190008586633216 ^ 6227375816044314624 ^ 5447668468240933120 ^ 0 >> 10 >> 27 << 3 ^ 7417622935708501504 >> 25 ^ -9066553134481932288 ^ 2181638752651182080 ^ 688860978447646720;
            #endregion
            try
            {
                Instance.Patch(typeof(APIUser).GetMethod("LocalAddFriend"), GetPatch("FriendAdded"), null);
                Instance.Patch(typeof(APIUser).GetMethod("UnfriendUser"), GetPatch("UnFriended"), null);
                Instance.Patch(typeof(PortalTrigger).GetMethod(nameof(PortalTrigger.OnTriggerEnter), BindingFlags.Public | BindingFlags.Instance), GetPatch("EnterPortal"), null, null);
                Instance.Patch(typeof(UdonSync).GetMethod(nameof(UdonSync.UdonSyncRunProgramAsRPC)), GetPatch("UdonSyncPatch"), null);
                Instance.Patch(typeof(NetworkManager).GetMethod("Method_Public_Void_Player_1"), GetPatch("OnPlayerJoin"), null);
                Instance.Patch(typeof(NetworkManager).GetMethod("Method_Public_Void_Player_0"), GetPatch("OnPlayerLeft"), null);
                Instance.Patch(typeof(NetworkManager).GetMethod("OnJoinedRoom"), GetPatch("OnJoinedRoom"), null);
                Instance.Patch(typeof(NetworkManager).GetMethod("OnLeftRoom"), GetPatch("OnLeftRoom"), null);
                Instance.Patch(typeof(VRC_Pickup).GetMethod(nameof(VRC_Pickup.Awake)), GetPatch("Pickupsuwu"), null);
                //Instance.Patch(AccessTools.Property(typeof(Tools), "Platform").GetMethod, null, GetPatch("PlatformSpoof"));
                Instance.Patch(typeof(VRC_Interactable).GetMethod(nameof(VRC_Interactable.Awake)), GetPatch("Triggers"), null);
                Instance.Patch(typeof(LoadBalancingClient).GetMethod("Method_Public_Virtual_New_Boolean_Byte_Object_RaiseEventOptions_SendOptions_0"), GetPatch("OpRaiseEventPrefix"), null, null);
                Instance.Patch(typeof(VRCHandGrasper).GetMethod(nameof(VRCHandGrasper.Method_Public_Static_VRCPlayerApi_VRC_Pickup_PDM_0)), GetPatch("Grasper"), null);
            }
            catch (Exception arg)
            {
                JoanpixerMain.Logger.Msg(ConsoleColor.Green, string.Format($"Failed Patching\n", arg));
            }
        }

        private static bool Grasper(VRC_Pickup __0)
        {
            try
            {
                if (Modules.Items.AntiTheftenabled && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right) == __0 || Modules.Items.AntiTheftenabled && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left) == __0)
                {
                    if (!butterknife && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right) == __0 && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right).gameObject.name.Contains("knife") || !butterknife && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right) == __0 && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right).gameObject.name.Contains("Knife") || !butterknife && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left) == __0 && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left).gameObject.name.Contains("knife") || !butterknife && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left) == __0 && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left).gameObject.name.Contains("Knife"))
                    {
                        return true;
                    }
                    else
                    {
                        var nonpatronobject = GameObject.Find("Game Logic/Weapons/Revolver/Recoil Anim/Recoil/geo");
                        if (Murder4.patreonself && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right) == __0 && __0 == Murder4.revolverpickup && nonpatronobject.active || Murder4.patreonself && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left) == __0 && __0 == Murder4.revolverpickup && nonpatronobject.active)
                        {
                            Murder4.CallRevolver("PatronSkin");
                        }
                        if (Murder4.worldLoaded && Murder4.LaserSight && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right) == __0 && __0 == Murder4.revolverpickup || Murder4.worldLoaded && Murder4.LaserSight && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left) == __0 && __0 == Murder4.revolverpickup)
                        {
                            if (Murder4Items.revolverline.gameObject.GetComponent<UdonBehaviour>().enabled) Murder4Items.revolverline.gameObject.GetComponent<UdonBehaviour>().enabled = false;
                            if (!Murder4Items.revolverline.enabled) Murder4Items.revolverline.enabled = true;
                        }
                        return false;
                    }
                }
                if (Murder4.worldLoaded || Murder3.worldLoaded)
                {
                    if (butterknife && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right) == __0 || butterknife && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left) == __0)
                    {
                        if (Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right) == __0 && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right).gameObject.name.Contains("knife") || Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right) == __0 && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right).gameObject.name.Contains("Knife") || Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left) == __0 && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left).gameObject.name.Contains("knife") || Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left) == __0 && Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left).gameObject.name.Contains("Knife"))
                        {
                            return false;
                        }
                    }
                }
            }
            catch {}
            return true;
        }

		public static bool Godmode = Create.Ini.GetBool("Toggles", "GodMode");
        public static bool AntiUdon;
        public static Player player;
        public static bool PortalWalk;
        public static bool AutoKill;
        public static bool compatible;
        public static bool TPDetective;
        public static bool butterknife;
        public static bool LogUdon;
        public static bool LogCheaters;
        internal static bool rainbow;
        internal static bool inv;
        public static bool playsound;
        public static bool loggedin;
        public static bool LockInstance;
        public static bool AntiVoteout = Create.Ini.GetBool("AmongUs", "AntiVoteOut");
        public static bool WalkingBomb;
        public static bool pickup;
        public static bool snake = Create.Ini.GetBool("Murder4", "Snake");
        public static bool justjoined;
        public static bool serialize;
        public static bool AntiSetRoleExploit = true;
        public static bool AnnounceMurderer4 = Create.Ini.GetBool("Murder4", "AnnounceMurderer");
        public static bool AnnounceMurderer3 = Create.Ini.GetBool("Toggles", "Murder3");
        public static bool AnnounceGhost = Create.Ini.GetBool("Toggles", "Ghost");
        public static bool InMurderGame;
        public static string UwU = string.Empty;
        public static List<VRC_Pickup> Pickups = new List<VRC_Pickup>();

        public static void Play()
        {
            if (playsound)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Environment.CurrentDirectory + "\\Joanpixer\\sound.wav");
                player.Play();
            }
        }
        private static void Pickupsuwu(ref VRC_Pickup __instance)
        {
            __instance.proximity = float.MaxValue;
            __instance.AutoHold = VRC_Pickup.AutoHoldMode.Yes;
            __instance.ThrowVelocityBoostMinSpeed = float.MaxValue;
        }
        private static void Triggers(ref VRC_Interactable __instance)
        {
            __instance.proximity = float.MaxValue;
        }

        private static void FriendAdded(APIUser __0)
        {
            JoanpixerMain.Logger.Msg(ConsoleColor.Green, $"New Friend: {__0.displayName}");
            MelonCoroutines.Start(Utils.Notification($"New Friend: {__0.displayName}", Color.green));
            if (Features.HighlightsComponent.ESPEnabled)
            {
                Features.HighlightsComponent.DisableESP();
                foreach (var player in Utils.GetAllPlayers())
                {
                    Features.HighlightsComponent.ToggleESP(true);
                }
            }

        }

        private static void UnFriended(APIUser __0)
        {
            JoanpixerMain.Logger.Msg(ConsoleColor.Red, $"{__0.displayName} UnFriended you");
            MelonCoroutines.Start(Utils.Notification($"{__0.displayName} UnFriended you", Color.red));
            if (Features.HighlightsComponent.ESPEnabled)
            {
                Features.HighlightsComponent.DisableESP();
                foreach (var player in Utils.GetAllPlayers())
                {
                    Features.HighlightsComponent.ToggleESP(true);
                }
            }
        }

        private static bool UdonSyncPatch(string __0, Player __1)
        {
            #region AntiDecompiler
            long goAwaySkid = long.Parse("2173162573851") ^ -3912879949001785344 >> 31 ^ 8794626273696546816 << 8 ^ 4994409697730625536 >> 25 ^ -7968319096167071744 ^ 4263824930518335488 << 6 ^ 5253580846375370752 ^ -3805541685128069120 ^ -6026324156323004416 ^ 2029226408462057472 ^ -2340264320232849408 ^ 7215611027977666560 << 4 ^ 4439690367340943360 ^ 890134321443110912 >> 31 << 5 ^ 0 ^ -2145479602233933824 ^ 1146788289491174656 >> 19 << 31 >> 26 << 31 >> 7 >> 7 << 14 ^ 3405718575338487808 >> 22 >> 7 >> 13 >> 11 << 12 >> 31 << 3 >> 9 >> 17 ^ 3141488709031690240 ^ 131423948578488320 ^ 6897167334979010560 << 27 ^ 6016527627190272000 ^ -6972949015494792192 ^ 7638104968020361216 ^ -4579247970414755840 >> 14 ^ 0 << 11 ^ 0 ^ 695638256452108288 >> 8 >> 19 >> 15 ^ -6584825605169086464 << 25 >> 30 << 17 ^ 9013673179205337088 >> 31 >> 24 >> 21 >> 32 >> 11 ^ 3008893349651283968 ^ 2756779452779200512 ^ 0 ^ 6903561931433443328 >> 7 ^ 5789194802054561792 ^ 6843358927213006848 ^ 7462635006855217152 ^ 9064584750869512192 << 16 ^ 5262040435689022464 ^ 9142242913160986624 >> 15 >> 28 ^ 0 ^ 144115188075855872 << 4 ^ 2774679889878350592 << 25 << 28 >> 31 ^ 4683743612465315840 >> 12 >> 27 ^ 0 >> 22 << 19 ^ -7600548949350416384 >> 31 << 28 >> 13 ^ 5269837186139684864 ^ 6309115084337577984 ^ 2709714619600994304 ^ 7717912134182843392 << 5 << 17 >> 5 >> 31 << 27 ^ 6989586621679009792 ^ -6711817999881338880 << 11 << 16 ^ 6340292020128448512 ^ -4276730796141707264 ^ -6786001544839371008 ^ 0 >> 31 << 26 >> 2 << 19 ^ 2971217901396164608 >> 3 ^ 0 >> 12 >> 1 >> 5 >> 28 << 14 ^ -5941371953334321152 ^ 6412755534562197504 << 10 << 13 ^ 1252848252370288640 ^ 0 << 13 ^ 6052837899185946624 ^ -3575858104132173824 ^ 4855322020326866944 ^ 7535059157594931200 >> 24 << 20 ^ 7854382203738783744 << 22 ^ 2245891613723197440 ^ -8745643619089645568 ^ 2161727821137838080 << 12 >> 18 ^ 9083552640708640768 ^ 1542276792461557760 >> 28 << 24 << 23 >> 11 ^ 5095810605253815552 ^ 0 ^ 0 << 16 << 14 >> 1 << 1 ^ 8891539358872502272 >> 7 << 10 >> 18 << 23 << 20 >> 14 >> 19 << 1 << 16 ^ 7803049304372805632 >> 23 ^ 5353166111911837696 ^ 6196953087261802496 << 8 ^ 3049521405000417280 ^ 7061644215716937728 << 11 ^ 5961640006731694080 >> 14 >> 30 ^ 8273213962607132672 >> 9 ^ 395171076092461056 >> 7 ^ -5294346872083026176 << 25 >> 17 ^ 5693468600249876480 ^ 6350356949569110016 >> 6 ^ 8688138641484021760 ^ 6630790751364055040 >> 20 ^ 2030279007013961728 << 15 >> 19 ^ -2830512365802356736 ^ 2766754452885401344 >> 8 ^ -3957787628547342336 >> 29 << 10 << 25 << 30 << 27 >> 0 >> 30 ^ 5476377146882523136 ^ 5093800441897025536 ^ 8618682521099436032 << 1 ^ 7320319719314030592 << 30 >> 22 ^ 5999388523453480960 ^ -4820348036611833856 << 5 >> 24 << 28 ^ -956875970034270208 << 27 >> 31 ^ 4022040966360727552 ^ 1729382256910270464 >> 26 >> 17 ^ 1504778545845774336 ^ 1202175639801561088 << 26 >> 9 << 24 ^ -8515242394525958144 ^ 7145078456567463936 >> 0 ^ 5042185502631919616 ^ 4662833004248825856 ^ -6989586621679009792 << 10 << 28 ^ 0 >> 29 ^ 5107530578182275072 ^ 3667263436463472640 << 10 << 13 ^ 8142508126285856768 ^ 5277092863371378688 << 26 ^ 0 >> 26 ^ 8460655154191985152 ^ 6794244409962528768 << 1 ^ 7493989779944505344 ^ 2900599635003310080 << 6 ^ 4080867776204374016 ^ 0 ^ 0 >> 22 << 14 ^ 7790490682560348160 ^ 2571551751991721984 >> 15 ^ -5332261958806667264 << 21 >> 22 ^ 8062816738980397056 >> 4 << 11 ^ -2704087903848308992 >> 15 ^ 8286623314361712640 << 27 >> 29 << 6 ^ 7332423143312588800 ^ 6983957122144796672 << 29 >> 25 >> 9 << 17 ^ 279607675254210560 << 16 << 3 ^ 2982464872760999936 << 20 ^ 5260485839745449984 ^ 2229813289800433664 << 11 ^ 7215679041737588736 >> 29 ^ 0 << 21 << 6 << 11 << 27 >> 17 << 27 ^ 70087269200953344 >> 3 ^ 3746994889972252672 << 13 << 21 ^ 0 ^ -1152921504606846976 >> 3 << 6 ^ 8094804714803167232 ^ 1201600406275227648 >> 5 << 22 ^ 5959837524921679872 >> 5 ^ 0 << 31 ^ 64598326680027136 >> 0 << 7 ^ 3923735310870642688 ^ 7803893729302937600 ^ 8839964527688155136 >> 21 << 9 << 31 ^ 6149095358512925184 << 6 ^ 4450344719821761536 >> 3 >> 6 >> 9 << 0 << 24 >> 22 << 24 << 16 << 31 ^ 2888777685981462528 << 19 ^ 2172423870252843008 << 24 >> 25 << 20 ^ 2630588939617959936 ^ 0 ^ 311846303627608064 >> 25 ^ -8164546050000804096 >> 32 >> 13 >> 16 >> 13 ^ 2377900603251621888 ^ 6783485291240357888 ^ 4883583005617591296 ^ -1969587995336835072 >> 29 ^ 5727898801279205376 ^ 1152921504606846976 ^ 3299432959106744320 ^ 2500231167446351872 >> 19 << 32 >> 12 ^ 4165446338076475392 ^ 7421932185906577408 << 12 << 13 ^ -6708111644968353792 ^ 4899916394579099648 << 20 ^ 4374183503561097216 ^ -5154398360827854848 << 29 ^ 5984400584872108288 ^ 0 >> 3 >> 30 ^ 1944506104931155968 ^ -8556839292003942400 ^ -8523625244752084992 ^ 0 ^ 4667136588839387136 << 4 << 25 << 1 >> 25 >> 4 ^ 0 ^ 0 >> 29 ^ -818772333166198784 >> 3 ^ 1945555039024054272 >> 10 ^ 648518346341351424 << 4 << 24 >> 1 >> 0 << 25 ^ 0 >> 0 << 20 ^ 4179340454199820288 ^ 8809040871136690176 ^ 0 ^ 3032387098708541440 >> 12 >> 13 ^ 6771853155483892480 << 23 >> 31 ^ 5005469510845595648 << 13 >> 18 ^ 2428457247408390144 >> 0 ^ 58974724088135680 << 8 << 29 ^ 6547440901419958272 ^ -8718968878589280256 << 31 ^ 0 ^ 8378718859275796480 >> 6 ^ 7387805544003665920 << 13 ^ 3549014420661075968 << 13 ^ 2458683921567580160 >> 26 >> 22 << 14 << 20 ^ 0 << 10 << 16 ^ -8546673436703850496 ^ 0 ^ 6153392900521590784 ^ 2025998749963801088 ^ 3901806127163113472 ^ 7566047373982433280 ^ 3026418949592973312 ^ -1637459926619565056 ^ 902179760939936256 << 0 >> 13 >> 16 ^ -1156580679304085504 >> 25 ^ 5345323057433018368 << 10 << 13 >> 18 ^ 7854277750134145024 ^ -8358680908399640576 << 4 ^ 4215497533301981184 ^ -1727951792282533888 >> 3 ^ 7026631367442038784 ^ 3878183544473583616 ^ -6812843387394195456 ^ 4730186983622574080 ^ 1758265791652389376 ^ 5786249064085061632 << 27 ^ 4953166842223919104 ^ 2043789805896073216 ^ 946910408956968960 << 26 >> 1 << 19 ^ 2000685395414614016 >> 21 << 16 >> 10 >> 19 >> 30 << 16 >> 29 >> 13 ^ 1629237183997018112 ^ 457380344480399360 << 27 >> 2 ^ 6057507896053202944 ^ -6022704000615317504 << 16 << 27 << 31 << 16 ^ -2017612633061982208 >> 31 << 14 >> 13 ^ 6989586621679009792 ^ 7063972981344567296 >> 11 >> 7 ^ 1528885212073689088 ^ 3674937295934324736 << 32 >> 0 << 16 ^ 9181700546162065408 << 15 << 6 ^ 932689193308520448 ^ 3421762817799539456 << 27 ^ 8600779433697083392 ^ 931394272664485888 << 23 << 31 ^ 2659375579962277888 ^ 7544862860111773696 << 29 ^ 7566047373982433280 >> 18 ^ 974490595726917632 << 23 << 30 >> 6 >> 26 ^ 6943424725498462208 >> 18 << 20 ^ 4107282860161892352 ^ 0 ^ -4117697434300186624 >> 2 ^ 3450673274535012352 >> 12 << 22 ^ 5708723669978000640 << 5 >> 26 << 24 >> 11 ^ 4569184657501847552 >> 4 ^ 6340319664903553024 ^ 1902430712897530368 ^ 0 << 11 ^ 3054246489380356096 ^ -8502796096475496448 >> 27 ^ 7019011178535154944 << 9 ^ 8604684626385960960 >> 13 ^ -506889355919360000 ^ -4098128227564781568 ^ 8584095183673491456 ^ 4683743612465315840 << 9 ^ 9097314039216055040 << 27 >> 6 << 27 >> 15 ^ 4094557964630097920 ^ 3544103280609067008 ^ 0 >> 14 ^ 7007459627767955456 >> 27 << 15 >> 27 ^ -2933944628392493056 ^ 2089670227099910144 << 17 >> 22 << 0 >> 4 ^ 2575935012624924672 << 13 ^ 8142508126285856768 ^ -5208934122758144000 >> 19 << 5 << 3 >> 10 ^ 1611421151924322304 ^ -8918899510332751872 ^ -2161727821137838080 << 4 << 32 >> 32 ^ 945165649762451456 << 5 >> 2 ^ 362258295026614272 >> 16 << 21 ^ -1886209865282486272 ^ 2481611774607228928 ^ -4610841593497255936 >> 3 << 22 >> 25 >> 8 << 10 >> 4 << 19 ^ -8153684352778108928 << 6 >> 31 ^ 2550837464098164992 ^ 2521171366397345792 ^ -7208292678583189504 ^ 0 ^ 0 >> 32 << 6 >> 13 ^ 5116089176692883456 >> 26 >> 1 ^ -2515566150608224256 ^ -6944550625405304832 << 10 ^ 7875412476743909376 ^ 0 >> 22 >> 12 ^ 414756676718034944 >> 27 >> 25 ^ 234372536853069824 ^ 0 ^ 7133701809754865664 << 30 ^ 275564002199732224 << 28 << 32 << 29 ^ -6500890165223021312 << 0 ^ 0 ^ 688769268010975232 << 0 ^ 6441309565031022592 ^ -6958645245360120576 >> 26 ^ 2984763223625302016 ^ 7789285423670362112 ^ -1843942572431507456 >> 28 ^ -6946316783670263808 ^ 6891287831795073024 << 0 >> 28 ^ -7250736839250100992 ^ 210110620459073536 ^ 8557139021319962624 << 2 >> 16 >> 32 << 8 << 2 ^ 2874422462169219072 ^ -5856632329836953600 ^ 4611686018427387904 ^ 8950297888549634048 ^ 0 ^ 4936023198374297600 ^ 2446348582219939840 >> 6 ^ -3689660856141873152 >> 26 ^ 4443082507377704960 ^ -7766406894989606912 << 28 ^ -5619446959279439872 ^ -433189989157699584 >> 29 ^ -4375209654595092480 ^ -3274440232761556992 << 6 ^ 3989383137585987584 >> 0 ^ 3830579896219336704 ^ 0 ^ 835684320705249280 ^ 6703759813849776128 >> 27 << 27 ^ 1205671226610024448 << 8 ^ 6859937708089802752 ^ 6326150101571993600 << 15 ^ -8821559239490456320 >> 29 << 5 ^ 2872372972495044608 ^ 0 << 25 ^ 1290376970483269632 ^ 7005979240537522176 >> 12 << 21 ^ -2377900603251621888 ^ 260927303410778112 >> 20 ^ 4574039609704448000 << 15 << 18 ^ 175659716893802496 << 4 ^ 0 ^ 3230071351396204544 ^ 738569333587662848 ^ -2738188573441261568 ^ 2115710141580430080 ^ 681377138941887744 << 0 >> 9 ^ 5675905934704705536 ^ 6424870990022443008 >> 22 ^ 3819052484010180608 >> 23 ^ 5183431927431954432 ^ 2254333088475643904 ^ 5295882417578442752 << 2 ^ 3882657500246638592 >> 13 >> 1 >> 18 << 7 >> 7 ^ 7738221052615720960 ^ 7551869171542261760 ^ -4250999496747515904 ^ -7133701809754865664 ^ 5216596634099515392 ^ 216153758093017088 ^ 3888382945613840384 << 24 ^ 644486790379470848 ^ 4875991021558693888 >> 19 ^ 2203386117691015168 ^ 5749652107350376448 << 4 ^ 3358453270065446912 >> 5 << 28 ^ 8741190008586633216 ^ 6227375816044314624 ^ 5447668468240933120 ^ 0 >> 10 >> 27 << 3 ^ 7417622935708501504 >> 25 ^ -9066553134481932288 ^ 2181638752651182080 ^ 688860978447646720;
            #endregion

            if (WalkingBomb && Murder4.worldLoaded)
            {
                if (__0.Contains("Kill")) return !WalkingBomb;
            }

            if (LogUdon)
            {
                JoanpixerClient.JoanpixerMain.Logger.Msg($"[Udon]: Event: {__0}, Player: {__1.field_Private_VRCPlayerApi_0.displayName}");
            }

            if (Just_B_Club.worldLoaded && Just_B_Club.freeze)
            {
                if (__0.Contains("OnDesktopTopDownViewStart")) return !Just_B_Club.freeze;
            }

            if (LogCheaters && __1.field_Private_VRCPlayerApi_0.displayName != Utils.CurrentUser.field_Private_VRCPlayerApi_0.displayName && !JoanpixerMain.Joan.Contains(__1.field_Private_APIUser_0.id))
            {
                if (__0.Contains("Abort") && !__1.field_Private_VRCPlayerApi_0.isMaster ||
                    __0.Contains("SyncVictory") && !__1.field_Private_VRCPlayerApi_0.isMaster)
                {
                    JoanpixerClient.JoanpixerMain.Logger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} finished the game while not being the Master");
                    Play();
                }

                if (__0.Contains("Assign") && !__1.field_Private_VRCPlayerApi_0.isMaster)
                {

                    JoanpixerClient.JoanpixerMain.Logger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is giving roles while not being the Master");
                    Play();
                }

                if (Murder4.worldLoaded)
                {
                    var Murderer = Murder4.MurderText.GetComponent<Text>().m_Text;
                    if (!justjoined && __0.Contains("Stab"))
                    {
                        if (Murderer.Contains(__1.field_Private_VRCPlayerApi_0.displayName))
                        {
                        }
                        else
                        {
                            JoanpixerClient.JoanpixerMain.Logger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is killing with a knife while not being the murderer");
                            Play();
                        }
                    }

                    if (!justjoined && __0 == "DispenseSnake")
                    {
                        if (Murderer.Contains(__1.field_Private_VRCPlayerApi_0.displayName))
                        {
                        }
                        else
                        {
                            JoanpixerClient.JoanpixerMain.Logger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} released the snake while not being the murderer");
                            Play();
                        }
                    }

                    if (!justjoined && __0.Contains("Down"))
                    {
                        if (Murderer.Contains(__1.field_Private_VRCPlayerApi_0.displayName))
                        {
                        }
                        else
                        {
                            JoanpixerClient.JoanpixerMain.Logger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is turning the lights off while not being the murderer");
                            Play();
                        }
                    }
                    if (__0 == "Play")
                    {
                        JoanpixerClient.JoanpixerMain.Logger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is spamming sounds");
                        Play();
                    }
                }

                if (Murder3.worldLoaded)
                {
                    var Murderer = Murder3.MurderText.GetComponent<Text>().m_Text;
                    if (__0.Contains("Stab"))
                    {
                        if (Murderer.Contains(__1.field_Private_VRCPlayerApi_0.displayName))
                        {
                        }
                        else
                        {
                            JoanpixerClient.JoanpixerMain.Logger.Msg(ConsoleColor.Yellow, $"[Cheater]: {__1.field_Private_VRCPlayerApi_0.displayName} is killing with a knife while not being the murderer");
                            Play();
                        }
                    }
                }
            }
            
            if (Murder4.worldLoaded && AntiSetRoleExploit && !__1.field_Private_VRCPlayerApi_0.isMaster && __1.field_Private_VRCPlayerApi_0.displayName.ToString() != Networking.LocalPlayer.displayName.ToString() && !JoanpixerMain.Joan.Contains(__1.field_Private_APIUser_0.id))
            {
                if (__0.Contains("Assign")) return false;
            }
            if (Murder4.worldLoaded || Murder3.worldLoaded)
            {
                if (__0.Contains("AssignM"))
                {
                    MelonCoroutines.Start(ShowMurderer());
                }
            }

            if (Murder4.worldLoaded && __0.Contains("Abort") || Murder4.worldLoaded && __0.Contains("SyncVictory") || Murder3.worldLoaded && __0.Contains("Abort") || Murder3.worldLoaded && __0.Contains("SyncVictory"))
                InMurderGame = false;

            if (Ghost.worldLoaded && __0 == "Local_ReadyStartGame" && AnnounceGhost)
            {
                MelonCoroutines.Start(Ghost.ShowGhosts());
            }
            try
            {
                if (AmongUs.worldLoaded && __0 == "SyncVotedOut" && AntiVoteout && Utils.IsWorldLoaded) return false;

                if (__0.Contains("Kill") && Godmode && Utils.IsWorldLoaded || Ghost.worldLoaded && __0.Contains("Damage") && Godmode && Utils.IsWorldLoaded || Prison.worldLoaded && __0.Contains("Damage") && Godmode && Utils.IsWorldLoaded) return false;

                if (inv && __0.Contains("Kill")) return false;
            }
            catch{}


            return !AntiUdon;
        }
        private static System.Collections.IEnumerator ShowMurderer()
        {
            var Murderer = "";
            yield return new WaitForSeconds(0);
            try
            {
                justjoined = false;
                if (Murder4.worldLoaded)
                {
                    Murderer = $"Murderer is {Murder4.MurderText.GetComponent<Text>().m_Text}";
                    if (Murder4.MurderText.GetComponent<Text>().m_Text == Utils.CurrentUser.field_Private_VRCPlayerApi_0.displayName && snake)
                        Udon.CallUdonEvent(Murder4Items.snakedispenser, "DispenseSnake");
                    if (TPDetective && Murder4.MurderText.GetComponent<Text>().m_Text != Utils.CurrentUser.field_Private_VRCPlayerApi_0.displayName)
                        Utils.TPLocalPlayer(GameObject.Find("Game Logic/Detective Spawn").transform.position);
                }
                if (Murder3.worldLoaded)
                {
                    Murderer = $"Murderer is {Murder3.MurderText.GetComponent<Text>().m_Text}";
                    if (TPDetective && Murder3.MurderText.GetComponent<Text>().m_Text != Utils.CurrentUser.field_Private_VRCPlayerApi_0.displayName)
                    {
                        Utils.TPLocalPlayer(GameObject.Find("Game Logic/Detective Spawn").transform.position);
                    }
                }
            }
            catch { }
            try
            {
                if (Create.Ini.GetBool("Murder4", "WeaponsInCooldown"))
                {
                    Murder4.pickupweapontoggle = true;
                    MelonCoroutines.Start(Murder4.PickupWeaponInCooldown());
                }
                if (Create.Ini.GetBool("Murder4", "PickupBeartraps"))
                {
                    MelonCoroutines.Start(Murder4.PickupBearTraps());
                }
                if (AnnounceMurderer4 && Murder4.worldLoaded || AnnounceMurderer3 && Murder3.worldLoaded)
                    MelonCoroutines.Start(Utils.Notification(Murderer, Color.red));
                if (Murder4.worldLoaded && Features.HighlightsComponent.ESPEnabled)
                {
                    Features.HighlightsComponent.DisableESP();
                    foreach (var player in Utils.GetAllPlayers())
                    {
                        Features.HighlightsComponent.ToggleESP(true);
                    }
                }
                if (Murder3.worldLoaded && Features.HighlightsComponent.ESPEnabled)
                {
                    Features.HighlightsComponent.DisableESP();
                    foreach (var player in Utils.GetAllPlayers())
                    {
                        Features.HighlightsComponent.ToggleESP(true);
                    }
                }
                if (AutoKill && Murder4.worldLoaded && Murder4Items.knife && !InMurderGame)
                {
                    Utils.SetRole(player, "Kill");
                }
                if (AutoKill && Murder3.worldLoaded && Murder4Items.knife)
                {
                    Utils.SetRole(player, "Kill");
                }
                InMurderGame = true;
            }
            catch { }
        }
        private static bool EnterPortal()
        {
            return !PortalWalk;
        }
        private static bool OpRaiseEventPrefix(ref byte __0, ref Il2CppSystem.Object __1, ref RaiseEventOptions __2, ref SendOptions __3)
        {
            try
            {
                switch (__0)
                {
                    case 7:
                        return !serialize;
                    case 206:
                        return !serialize;
                    case 201:
                        return !serialize;
                    case 4:
                        return !LockInstance;
                    case 5:
                        return !LockInstance;
                    default:
                        break;
                }
            }
            catch { }
            return true;
        }
        /*public static bool QuestSpoof = false;
       private static void PlatformSpoof(ref string __result)
        {
            if (QuestSpoof)
            {
                if (RoomManager.field_Internal_Static_ApiWorldInstance_0 == null && !loggedin)
                {
                    __result = "android";
                }
            }
        }*/
        /*public static System.Collections.IEnumerator QuestSpoofer()
        {
            yield return new WaitForSeconds(5);
            loggedin = true;
            if (UnityEngine.XR.XRDevice.isPresent)
            {
                JoanpixerClient.JoanpixerMain.Logger.Msg("Quest Spoofed");
            }
            else
            {
                yield return new WaitForSeconds(13);
                JoanpixerClient.JoanpixerMain.Logger.Error("Spoofing Quest In Desktop!");
                MelonCoroutines.Start(Utils.Notification("Warning: Spoofing Quest In Desktop!", Color.red));
                yield return new WaitForSeconds(1);
                Play();
            }
        }*/
        /*public static void QuestIni()
        {
            QuestSpoof = Create.Ini.GetBool("Toggles", "QuestSpoof");
            if (QuestSpoof)
            {
                MelonCoroutines.Start(QuestSpoofer());
            }
        }*/
        private static void OnJoinedRoom()
        {
            #region AntiDecompiler
            long antiudon = long.Parse("2173162573851") ^ -3912879949001785344 >> 31 ^ 8794626273696546816 << 8 ^ 4994409697730625536 >> 25 ^ -7968319096167071744 ^ 4263824930518335488 << 6 ^ 5253580846375370752 ^ -3805541685128069120 ^ -6026324156323004416 ^ 2029226408462057472 ^ -2340264320232849408 ^ 7215611027977666560 << 4 ^ 4439690367340943360 ^ 890134321443110912 >> 31 << 5 ^ 0 ^ -2145479602233933824 ^ 1146788289491174656 >> 19 << 31 >> 26 << 31 >> 7 >> 7 << 14 ^ 3405718575338487808 >> 22 >> 7 >> 13 >> 11 << 12 >> 31 << 3 >> 9 >> 17 ^ 3141488709031690240 ^ 131423948578488320 ^ 6897167334979010560 << 27 ^ 6016527627190272000 ^ -6972949015494792192 ^ 7638104968020361216 ^ -4579247970414755840 >> 14 ^ 0 << 11 ^ 0 ^ 695638256452108288 >> 8 >> 19 >> 15 ^ -6584825605169086464 << 25 >> 30 << 17 ^ 9013673179205337088 >> 31 >> 24 >> 21 >> 32 >> 11 ^ 3008893349651283968 ^ 2756779452779200512 ^ 0 ^ 6903561931433443328 >> 7 ^ 5789194802054561792 ^ 6843358927213006848 ^ 7462635006855217152 ^ 9064584750869512192 << 16 ^ 5262040435689022464 ^ 9142242913160986624 >> 15 >> 28 ^ 0 ^ 144115188075855872 << 4 ^ 2774679889878350592 << 25 << 28 >> 31 ^ 4683743612465315840 >> 12 >> 27 ^ 0 >> 22 << 19 ^ -7600548949350416384 >> 31 << 28 >> 13 ^ 5269837186139684864 ^ 6309115084337577984 ^ 2709714619600994304 ^ 7717912134182843392 << 5 << 17 >> 5 >> 31 << 27 ^ 6989586621679009792 ^ -6711817999881338880 << 11 << 16 ^ 6340292020128448512 ^ -4276730796141707264 ^ -6786001544839371008 ^ 0 >> 31 << 26 >> 2 << 19 ^ 2971217901396164608 >> 3 ^ 0 >> 12 >> 1 >> 5 >> 28 << 14 ^ -5941371953334321152 ^ 6412755534562197504 << 10 << 13 ^ 1252848252370288640 ^ 0 << 13 ^ 6052837899185946624 ^ -3575858104132173824 ^ 4855322020326866944 ^ 7535059157594931200 >> 24 << 20 ^ 7854382203738783744 << 22 ^ 2245891613723197440 ^ -8745643619089645568 ^ 2161727821137838080 << 12 >> 18 ^ 9083552640708640768 ^ 1542276792461557760 >> 28 << 24 << 23 >> 11 ^ 5095810605253815552 ^ 0 ^ 0 << 16 << 14 >> 1 << 1 ^ 8891539358872502272 >> 7 << 10 >> 18 << 23 << 20 >> 14 >> 19 << 1 << 16 ^ 7803049304372805632 >> 23 ^ 5353166111911837696 ^ 6196953087261802496 << 8 ^ 3049521405000417280 ^ 7061644215716937728 << 11 ^ 5961640006731694080 >> 14 >> 30 ^ 8273213962607132672 >> 9 ^ 395171076092461056 >> 7 ^ -5294346872083026176 << 25 >> 17 ^ 5693468600249876480 ^ 6350356949569110016 >> 6 ^ 8688138641484021760 ^ 6630790751364055040 >> 20 ^ 2030279007013961728 << 15 >> 19 ^ -2830512365802356736 ^ 2766754452885401344 >> 8 ^ -3957787628547342336 >> 29 << 10 << 25 << 30 << 27 >> 0 >> 30 ^ 5476377146882523136 ^ 5093800441897025536 ^ 8618682521099436032 << 1 ^ 7320319719314030592 << 30 >> 22 ^ 5999388523453480960 ^ -4820348036611833856 << 5 >> 24 << 28 ^ -956875970034270208 << 27 >> 31 ^ 4022040966360727552 ^ 1729382256910270464 >> 26 >> 17 ^ 1504778545845774336 ^ 1202175639801561088 << 26 >> 9 << 24 ^ -8515242394525958144 ^ 7145078456567463936 >> 0 ^ 5042185502631919616 ^ 4662833004248825856 ^ -6989586621679009792 << 10 << 28 ^ 0 >> 29 ^ 5107530578182275072 ^ 3667263436463472640 << 10 << 13 ^ 8142508126285856768 ^ 5277092863371378688 << 26 ^ 0 >> 26 ^ 8460655154191985152 ^ 6794244409962528768 << 1 ^ 7493989779944505344 ^ 2900599635003310080 << 6 ^ 4080867776204374016 ^ 0 ^ 0 >> 22 << 14 ^ 7790490682560348160 ^ 2571551751991721984 >> 15 ^ -5332261958806667264 << 21 >> 22 ^ 8062816738980397056 >> 4 << 11 ^ -2704087903848308992 >> 15 ^ 8286623314361712640 << 27 >> 29 << 6 ^ 7332423143312588800 ^ 6983957122144796672 << 29 >> 25 >> 9 << 17 ^ 279607675254210560 << 16 << 3 ^ 2982464872760999936 << 20 ^ 5260485839745449984 ^ 2229813289800433664 << 11 ^ 7215679041737588736 >> 29 ^ 0 << 21 << 6 << 11 << 27 >> 17 << 27 ^ 70087269200953344 >> 3 ^ 3746994889972252672 << 13 << 21 ^ 0 ^ -1152921504606846976 >> 3 << 6 ^ 8094804714803167232 ^ 1201600406275227648 >> 5 << 22 ^ 5959837524921679872 >> 5 ^ 0 << 31 ^ 64598326680027136 >> 0 << 7 ^ 3923735310870642688 ^ 7803893729302937600 ^ 8839964527688155136 >> 21 << 9 << 31 ^ 6149095358512925184 << 6 ^ 4450344719821761536 >> 3 >> 6 >> 9 << 0 << 24 >> 22 << 24 << 16 << 31 ^ 2888777685981462528 << 19 ^ 2172423870252843008 << 24 >> 25 << 20 ^ 2630588939617959936 ^ 0 ^ 311846303627608064 >> 25 ^ -8164546050000804096 >> 32 >> 13 >> 16 >> 13 ^ 2377900603251621888 ^ 6783485291240357888 ^ 4883583005617591296 ^ -1969587995336835072 >> 29 ^ 5727898801279205376 ^ 1152921504606846976 ^ 3299432959106744320 ^ 2500231167446351872 >> 19 << 32 >> 12 ^ 4165446338076475392 ^ 7421932185906577408 << 12 << 13 ^ -6708111644968353792 ^ 4899916394579099648 << 20 ^ 4374183503561097216 ^ -5154398360827854848 << 29 ^ 5984400584872108288 ^ 0 >> 3 >> 30 ^ 1944506104931155968 ^ -8556839292003942400 ^ -8523625244752084992 ^ 0 ^ 4667136588839387136 << 4 << 25 << 1 >> 25 >> 4 ^ 0 ^ 0 >> 29 ^ -818772333166198784 >> 3 ^ 1945555039024054272 >> 10 ^ 648518346341351424 << 4 << 24 >> 1 >> 0 << 25 ^ 0 >> 0 << 20 ^ 4179340454199820288 ^ 8809040871136690176 ^ 0 ^ 3032387098708541440 >> 12 >> 13 ^ 6771853155483892480 << 23 >> 31 ^ 5005469510845595648 << 13 >> 18 ^ 2428457247408390144 >> 0 ^ 58974724088135680 << 8 << 29 ^ 6547440901419958272 ^ -8718968878589280256 << 31 ^ 0 ^ 8378718859275796480 >> 6 ^ 7387805544003665920 << 13 ^ 3549014420661075968 << 13 ^ 2458683921567580160 >> 26 >> 22 << 14 << 20 ^ 0 << 10 << 16 ^ -8546673436703850496 ^ 0 ^ 6153392900521590784 ^ 2025998749963801088 ^ 3901806127163113472 ^ 7566047373982433280 ^ 3026418949592973312 ^ -1637459926619565056 ^ 902179760939936256 << 0 >> 13 >> 16 ^ -1156580679304085504 >> 25 ^ 5345323057433018368 << 10 << 13 >> 18 ^ 7854277750134145024 ^ -8358680908399640576 << 4 ^ 4215497533301981184 ^ -1727951792282533888 >> 3 ^ 7026631367442038784 ^ 3878183544473583616 ^ -6812843387394195456 ^ 4730186983622574080 ^ 1758265791652389376 ^ 5786249064085061632 << 27 ^ 4953166842223919104 ^ 2043789805896073216 ^ 946910408956968960 << 26 >> 1 << 19 ^ 2000685395414614016 >> 21 << 16 >> 10 >> 19 >> 30 << 16 >> 29 >> 13 ^ 1629237183997018112 ^ 457380344480399360 << 27 >> 2 ^ 6057507896053202944 ^ -6022704000615317504 << 16 << 27 << 31 << 16 ^ -2017612633061982208 >> 31 << 14 >> 13 ^ 6989586621679009792 ^ 7063972981344567296 >> 11 >> 7 ^ 1528885212073689088 ^ 3674937295934324736 << 32 >> 0 << 16 ^ 9181700546162065408 << 15 << 6 ^ 932689193308520448 ^ 3421762817799539456 << 27 ^ 8600779433697083392 ^ 931394272664485888 << 23 << 31 ^ 2659375579962277888 ^ 7544862860111773696 << 29 ^ 7566047373982433280 >> 18 ^ 974490595726917632 << 23 << 30 >> 6 >> 26 ^ 6943424725498462208 >> 18 << 20 ^ 4107282860161892352 ^ 0 ^ -4117697434300186624 >> 2 ^ 3450673274535012352 >> 12 << 22 ^ 5708723669978000640 << 5 >> 26 << 24 >> 11 ^ 4569184657501847552 >> 4 ^ 6340319664903553024 ^ 1902430712897530368 ^ 0 << 11 ^ 3054246489380356096 ^ -8502796096475496448 >> 27 ^ 7019011178535154944 << 9 ^ 8604684626385960960 >> 13 ^ -506889355919360000 ^ -4098128227564781568 ^ 8584095183673491456 ^ 4683743612465315840 << 9 ^ 9097314039216055040 << 27 >> 6 << 27 >> 15 ^ 4094557964630097920 ^ 3544103280609067008 ^ 0 >> 14 ^ 7007459627767955456 >> 27 << 15 >> 27 ^ -2933944628392493056 ^ 2089670227099910144 << 17 >> 22 << 0 >> 4 ^ 2575935012624924672 << 13 ^ 8142508126285856768 ^ -5208934122758144000 >> 19 << 5 << 3 >> 10 ^ 1611421151924322304 ^ -8918899510332751872 ^ -2161727821137838080 << 4 << 32 >> 32 ^ 945165649762451456 << 5 >> 2 ^ 362258295026614272 >> 16 << 21 ^ -1886209865282486272 ^ 2481611774607228928 ^ -4610841593497255936 >> 3 << 22 >> 25 >> 8 << 10 >> 4 << 19 ^ -8153684352778108928 << 6 >> 31 ^ 2550837464098164992 ^ 2521171366397345792 ^ -7208292678583189504 ^ 0 ^ 0 >> 32 << 6 >> 13 ^ 5116089176692883456 >> 26 >> 1 ^ -2515566150608224256 ^ -6944550625405304832 << 10 ^ 7875412476743909376 ^ 0 >> 22 >> 12 ^ 414756676718034944 >> 27 >> 25 ^ 234372536853069824 ^ 0 ^ 7133701809754865664 << 30 ^ 275564002199732224 << 28 << 32 << 29 ^ -6500890165223021312 << 0 ^ 0 ^ 688769268010975232 << 0 ^ 6441309565031022592 ^ -6958645245360120576 >> 26 ^ 2984763223625302016 ^ 7789285423670362112 ^ -1843942572431507456 >> 28 ^ -6946316783670263808 ^ 6891287831795073024 << 0 >> 28 ^ -7250736839250100992 ^ 210110620459073536 ^ 8557139021319962624 << 2 >> 16 >> 32 << 8 << 2 ^ 2874422462169219072 ^ -5856632329836953600 ^ 4611686018427387904 ^ 8950297888549634048 ^ 0 ^ 4936023198374297600 ^ 2446348582219939840 >> 6 ^ -3689660856141873152 >> 26 ^ 4443082507377704960 ^ -7766406894989606912 << 28 ^ -5619446959279439872 ^ -433189989157699584 >> 29 ^ -4375209654595092480 ^ -3274440232761556992 << 6 ^ 3989383137585987584 >> 0 ^ 3830579896219336704 ^ 0 ^ 835684320705249280 ^ 6703759813849776128 >> 27 << 27 ^ 1205671226610024448 << 8 ^ 6859937708089802752 ^ 6326150101571993600 << 15 ^ -8821559239490456320 >> 29 << 5 ^ 2872372972495044608 ^ 0 << 25 ^ 1290376970483269632 ^ 7005979240537522176 >> 12 << 21 ^ -2377900603251621888 ^ 260927303410778112 >> 20 ^ 4574039609704448000 << 15 << 18 ^ 175659716893802496 << 4 ^ 0 ^ 3230071351396204544 ^ 738569333587662848 ^ -2738188573441261568 ^ 2115710141580430080 ^ 681377138941887744 << 0 >> 9 ^ 5675905934704705536 ^ 6424870990022443008 >> 22 ^ 3819052484010180608 >> 23 ^ 5183431927431954432 ^ 2254333088475643904 ^ 5295882417578442752 << 2 ^ 3882657500246638592 >> 13 >> 1 >> 18 << 7 >> 7 ^ 7738221052615720960 ^ 7551869171542261760 ^ -4250999496747515904 ^ -7133701809754865664 ^ 5216596634099515392 ^ 216153758093017088 ^ 3888382945613840384 << 24 ^ 644486790379470848 ^ 4875991021558693888 >> 19 ^ 2203386117691015168 ^ 5749652107350376448 << 4 ^ 3358453270065446912 >> 5 << 28 ^ 8741190008586633216 ^ 6227375816044314624 ^ 5447668468240933120 ^ 0 >> 10 >> 27 << 3 ^ 7417622935708501504 >> 25 ^ -9066553134481932288 ^ 2181638752651182080 ^ 688860978447646720;
            #endregion

            Murder4.Initialize();
            Murder3.Initialize();
            Ghost.Initialize();
            AmongUs.Initialize();
            Just_B_Club.Initialize();
            Prison.Initialize();
            loggedin = true;
            justjoined = true;
            MelonCoroutines.Start(Delay());
            var block = (Environment.CurrentDirectory + "\\Joanpixer\\block.png").LoadSpriteFromDisk();
            if (Murder3.worldLoaded || Murder4.worldLoaded || Ghost.worldLoaded || AmongUs.worldLoaded || Just_B_Club.worldLoaded || Prison.worldLoaded) return;
            else Utils.WorldHacks.SetIcon(block); Utils.WorldHacks.SetText("World Hacks");
        }

        private static System.Collections.IEnumerator Delay()
        {
            yield return new WaitForSeconds(5);
            if (!JoanpixerMain.Users.Contains(id))
            {
                Play();
                yield return new WaitForSeconds(0.3f);
                Process.GetCurrentProcess().Kill();
            }
            foreach (var Pickup in Resources.FindObjectsOfTypeAll<VRC_Pickup>())
            {
                Pickups.Add(Pickup);
            }
            if (Create.Ini.GetBool("Toggles", "Jump"))
                Utils.EnableJump();
            try
            {
                if (Murder3.worldLoaded || Murder4.worldLoaded || AmongUs.worldLoaded)
                {
                    Utils.WorldHacksPlayer.SetActive(true);
                    Utils.Touch.SetActive(true);
                    if (AmongUs.worldLoaded)
                    {
                        compatible = true;
                        var AmongUsIcon = (Environment.CurrentDirectory + "\\Joanpixer\\amongus.png").LoadSpriteFromDisk();
                        Utils.WorldHacks.SetIcon(AmongUsIcon);
                        Utils.TouchBystander.SetText("Give Crewmate");
                        Utils.TouchMurderer.SetText("Give Imposter");
                        Utils.TouchDetective.SetActive(false);
                        Utils.TouchClues.SetActive(false);
                        Utils.TouchCooldown.SetActive(false);
                        Utils.TouchFlash.SetActive(false);
                        Utils.TouchGrenade.SetActive(false);
                        Utils.TouchBeartrap.SetActive(false);

                    }
                    if (Murder3.worldLoaded || Murder4.worldLoaded)
                    {
                        compatible = true;
                        var Murder4Icon = (Environment.CurrentDirectory + "\\Joanpixer\\knife.png").LoadSpriteFromDisk();
                        Utils.WorldHacks.SetIcon(Murder4Icon);
                        Utils.TouchBystander.SetText("Give Bystander");
                        Utils.TouchMurderer.SetText("Give Murderer");
                        Utils.TouchClues.SetActive(true);
                        Utils.TouchDetective.SetActive(true);
                        Utils.TouchCooldown.SetActive(true);
                        Utils.TouchFlash.SetActive(true);
                        Utils.TouchGrenade.SetActive(true);
                        Utils.TouchBeartrap.SetActive(true);
                        Utils.ButterKnife.SetActive(true);
                    }
                    
                }
                else
                {
                    Utils.WorldHacksPlayer.SetActive(false);
                    Utils.Touch.SetActive(false);
                    Utils.ButterKnife.SetActive(false);
                }
            }
            catch {}
            
            if (Modules.Items.AllowThiefenabled)
                Modules.Items.AllowThief();
            yield break;
        }
        private static void OnLeftRoom()
        {
            if (Create.Ini.GetBool("Murder4", "WeaponsInCooldown"))
            {
                Murder4.pickupweapontoggle = false;
            }
            Pickups.Clear();
            rainbowtags.Clear();
            Utils.touchsystoggle = "";
            Utils.TouchBystander.SetToggleState(false, false);
            Utils.TouchMurderer.SetToggleState(false, false);
            Utils.TouchDetective.SetToggleState(false, false);
            Utils.TouchClues.SetToggleState(false, false);
            Utils.TouchCooldown.SetToggleState(false, false);
            Utils.TouchFlash.SetToggleState(false, false);
            Utils.TouchGrenade.SetToggleState(false, false);
            Utils.TouchBeartrap.SetToggleState(false, false);
        }

        internal static List<TMPro.TextMeshProUGUI> rainbowtags = new List<TMPro.TextMeshProUGUI>();

        internal static string id = string.Empty;

        private static void OnPlayerJoin(Player __0)
        {
            #region AntiDecompiler
            long antiudon = long.Parse("2173162573851") ^ -3912879949001785344 >> 31 ^ 8794626273696546816 << 8 ^ 4994409697730625536 >> 25 ^ -7968319096167071744 ^ 4263824930518335488 << 6 ^ 5253580846375370752 ^ -3805541685128069120 ^ -6026324156323004416 ^ 2029226408462057472 ^ -2340264320232849408 ^ 7215611027977666560 << 4 ^ 4439690367340943360 ^ 890134321443110912 >> 31 << 5 ^ 0 ^ -2145479602233933824 ^ 1146788289491174656 >> 19 << 31 >> 26 << 31 >> 7 >> 7 << 14 ^ 3405718575338487808 >> 22 >> 7 >> 13 >> 11 << 12 >> 31 << 3 >> 9 >> 17 ^ 3141488709031690240 ^ 131423948578488320 ^ 6897167334979010560 << 27 ^ 6016527627190272000 ^ -6972949015494792192 ^ 7638104968020361216 ^ -4579247970414755840 >> 14 ^ 0 << 11 ^ 0 ^ 695638256452108288 >> 8 >> 19 >> 15 ^ -6584825605169086464 << 25 >> 30 << 17 ^ 9013673179205337088 >> 31 >> 24 >> 21 >> 32 >> 11 ^ 3008893349651283968 ^ 2756779452779200512 ^ 0 ^ 6903561931433443328 >> 7 ^ 5789194802054561792 ^ 6843358927213006848 ^ 7462635006855217152 ^ 9064584750869512192 << 16 ^ 5262040435689022464 ^ 9142242913160986624 >> 15 >> 28 ^ 0 ^ 144115188075855872 << 4 ^ 2774679889878350592 << 25 << 28 >> 31 ^ 4683743612465315840 >> 12 >> 27 ^ 0 >> 22 << 19 ^ -7600548949350416384 >> 31 << 28 >> 13 ^ 5269837186139684864 ^ 6309115084337577984 ^ 2709714619600994304 ^ 7717912134182843392 << 5 << 17 >> 5 >> 31 << 27 ^ 6989586621679009792 ^ -6711817999881338880 << 11 << 16 ^ 6340292020128448512 ^ -4276730796141707264 ^ -6786001544839371008 ^ 0 >> 31 << 26 >> 2 << 19 ^ 2971217901396164608 >> 3 ^ 0 >> 12 >> 1 >> 5 >> 28 << 14 ^ -5941371953334321152 ^ 6412755534562197504 << 10 << 13 ^ 1252848252370288640 ^ 0 << 13 ^ 6052837899185946624 ^ -3575858104132173824 ^ 4855322020326866944 ^ 7535059157594931200 >> 24 << 20 ^ 7854382203738783744 << 22 ^ 2245891613723197440 ^ -8745643619089645568 ^ 2161727821137838080 << 12 >> 18 ^ 9083552640708640768 ^ 1542276792461557760 >> 28 << 24 << 23 >> 11 ^ 5095810605253815552 ^ 0 ^ 0 << 16 << 14 >> 1 << 1 ^ 8891539358872502272 >> 7 << 10 >> 18 << 23 << 20 >> 14 >> 19 << 1 << 16 ^ 7803049304372805632 >> 23 ^ 5353166111911837696 ^ 6196953087261802496 << 8 ^ 3049521405000417280 ^ 7061644215716937728 << 11 ^ 5961640006731694080 >> 14 >> 30 ^ 8273213962607132672 >> 9 ^ 395171076092461056 >> 7 ^ -5294346872083026176 << 25 >> 17 ^ 5693468600249876480 ^ 6350356949569110016 >> 6 ^ 8688138641484021760 ^ 6630790751364055040 >> 20 ^ 2030279007013961728 << 15 >> 19 ^ -2830512365802356736 ^ 2766754452885401344 >> 8 ^ -3957787628547342336 >> 29 << 10 << 25 << 30 << 27 >> 0 >> 30 ^ 5476377146882523136 ^ 5093800441897025536 ^ 8618682521099436032 << 1 ^ 7320319719314030592 << 30 >> 22 ^ 5999388523453480960 ^ -4820348036611833856 << 5 >> 24 << 28 ^ -956875970034270208 << 27 >> 31 ^ 4022040966360727552 ^ 1729382256910270464 >> 26 >> 17 ^ 1504778545845774336 ^ 1202175639801561088 << 26 >> 9 << 24 ^ -8515242394525958144 ^ 7145078456567463936 >> 0 ^ 5042185502631919616 ^ 4662833004248825856 ^ -6989586621679009792 << 10 << 28 ^ 0 >> 29 ^ 5107530578182275072 ^ 3667263436463472640 << 10 << 13 ^ 8142508126285856768 ^ 5277092863371378688 << 26 ^ 0 >> 26 ^ 8460655154191985152 ^ 6794244409962528768 << 1 ^ 7493989779944505344 ^ 2900599635003310080 << 6 ^ 4080867776204374016 ^ 0 ^ 0 >> 22 << 14 ^ 7790490682560348160 ^ 2571551751991721984 >> 15 ^ -5332261958806667264 << 21 >> 22 ^ 8062816738980397056 >> 4 << 11 ^ -2704087903848308992 >> 15 ^ 8286623314361712640 << 27 >> 29 << 6 ^ 7332423143312588800 ^ 6983957122144796672 << 29 >> 25 >> 9 << 17 ^ 279607675254210560 << 16 << 3 ^ 2982464872760999936 << 20 ^ 5260485839745449984 ^ 2229813289800433664 << 11 ^ 7215679041737588736 >> 29 ^ 0 << 21 << 6 << 11 << 27 >> 17 << 27 ^ 70087269200953344 >> 3 ^ 3746994889972252672 << 13 << 21 ^ 0 ^ -1152921504606846976 >> 3 << 6 ^ 8094804714803167232 ^ 1201600406275227648 >> 5 << 22 ^ 5959837524921679872 >> 5 ^ 0 << 31 ^ 64598326680027136 >> 0 << 7 ^ 3923735310870642688 ^ 7803893729302937600 ^ 8839964527688155136 >> 21 << 9 << 31 ^ 6149095358512925184 << 6 ^ 4450344719821761536 >> 3 >> 6 >> 9 << 0 << 24 >> 22 << 24 << 16 << 31 ^ 2888777685981462528 << 19 ^ 2172423870252843008 << 24 >> 25 << 20 ^ 2630588939617959936 ^ 0 ^ 311846303627608064 >> 25 ^ -8164546050000804096 >> 32 >> 13 >> 16 >> 13 ^ 2377900603251621888 ^ 6783485291240357888 ^ 4883583005617591296 ^ -1969587995336835072 >> 29 ^ 5727898801279205376 ^ 1152921504606846976 ^ 3299432959106744320 ^ 2500231167446351872 >> 19 << 32 >> 12 ^ 4165446338076475392 ^ 7421932185906577408 << 12 << 13 ^ -6708111644968353792 ^ 4899916394579099648 << 20 ^ 4374183503561097216 ^ -5154398360827854848 << 29 ^ 5984400584872108288 ^ 0 >> 3 >> 30 ^ 1944506104931155968 ^ -8556839292003942400 ^ -8523625244752084992 ^ 0 ^ 4667136588839387136 << 4 << 25 << 1 >> 25 >> 4 ^ 0 ^ 0 >> 29 ^ -818772333166198784 >> 3 ^ 1945555039024054272 >> 10 ^ 648518346341351424 << 4 << 24 >> 1 >> 0 << 25 ^ 0 >> 0 << 20 ^ 4179340454199820288 ^ 8809040871136690176 ^ 0 ^ 3032387098708541440 >> 12 >> 13 ^ 6771853155483892480 << 23 >> 31 ^ 5005469510845595648 << 13 >> 18 ^ 2428457247408390144 >> 0 ^ 58974724088135680 << 8 << 29 ^ 6547440901419958272 ^ -8718968878589280256 << 31 ^ 0 ^ 8378718859275796480 >> 6 ^ 7387805544003665920 << 13 ^ 3549014420661075968 << 13 ^ 2458683921567580160 >> 26 >> 22 << 14 << 20 ^ 0 << 10 << 16 ^ -8546673436703850496 ^ 0 ^ 6153392900521590784 ^ 2025998749963801088 ^ 3901806127163113472 ^ 7566047373982433280 ^ 3026418949592973312 ^ -1637459926619565056 ^ 902179760939936256 << 0 >> 13 >> 16 ^ -1156580679304085504 >> 25 ^ 5345323057433018368 << 10 << 13 >> 18 ^ 7854277750134145024 ^ -8358680908399640576 << 4 ^ 4215497533301981184 ^ -1727951792282533888 >> 3 ^ 7026631367442038784 ^ 3878183544473583616 ^ -6812843387394195456 ^ 4730186983622574080 ^ 1758265791652389376 ^ 5786249064085061632 << 27 ^ 4953166842223919104 ^ 2043789805896073216 ^ 946910408956968960 << 26 >> 1 << 19 ^ 2000685395414614016 >> 21 << 16 >> 10 >> 19 >> 30 << 16 >> 29 >> 13 ^ 1629237183997018112 ^ 457380344480399360 << 27 >> 2 ^ 6057507896053202944 ^ -6022704000615317504 << 16 << 27 << 31 << 16 ^ -2017612633061982208 >> 31 << 14 >> 13 ^ 6989586621679009792 ^ 7063972981344567296 >> 11 >> 7 ^ 1528885212073689088 ^ 3674937295934324736 << 32 >> 0 << 16 ^ 9181700546162065408 << 15 << 6 ^ 932689193308520448 ^ 3421762817799539456 << 27 ^ 8600779433697083392 ^ 931394272664485888 << 23 << 31 ^ 2659375579962277888 ^ 7544862860111773696 << 29 ^ 7566047373982433280 >> 18 ^ 974490595726917632 << 23 << 30 >> 6 >> 26 ^ 6943424725498462208 >> 18 << 20 ^ 4107282860161892352 ^ 0 ^ -4117697434300186624 >> 2 ^ 3450673274535012352 >> 12 << 22 ^ 5708723669978000640 << 5 >> 26 << 24 >> 11 ^ 4569184657501847552 >> 4 ^ 6340319664903553024 ^ 1902430712897530368 ^ 0 << 11 ^ 3054246489380356096 ^ -8502796096475496448 >> 27 ^ 7019011178535154944 << 9 ^ 8604684626385960960 >> 13 ^ -506889355919360000 ^ -4098128227564781568 ^ 8584095183673491456 ^ 4683743612465315840 << 9 ^ 9097314039216055040 << 27 >> 6 << 27 >> 15 ^ 4094557964630097920 ^ 3544103280609067008 ^ 0 >> 14 ^ 7007459627767955456 >> 27 << 15 >> 27 ^ -2933944628392493056 ^ 2089670227099910144 << 17 >> 22 << 0 >> 4 ^ 2575935012624924672 << 13 ^ 8142508126285856768 ^ -5208934122758144000 >> 19 << 5 << 3 >> 10 ^ 1611421151924322304 ^ -8918899510332751872 ^ -2161727821137838080 << 4 << 32 >> 32 ^ 945165649762451456 << 5 >> 2 ^ 362258295026614272 >> 16 << 21 ^ -1886209865282486272 ^ 2481611774607228928 ^ -4610841593497255936 >> 3 << 22 >> 25 >> 8 << 10 >> 4 << 19 ^ -8153684352778108928 << 6 >> 31 ^ 2550837464098164992 ^ 2521171366397345792 ^ -7208292678583189504 ^ 0 ^ 0 >> 32 << 6 >> 13 ^ 5116089176692883456 >> 26 >> 1 ^ -2515566150608224256 ^ -6944550625405304832 << 10 ^ 7875412476743909376 ^ 0 >> 22 >> 12 ^ 414756676718034944 >> 27 >> 25 ^ 234372536853069824 ^ 0 ^ 7133701809754865664 << 30 ^ 275564002199732224 << 28 << 32 << 29 ^ -6500890165223021312 << 0 ^ 0 ^ 688769268010975232 << 0 ^ 6441309565031022592 ^ -6958645245360120576 >> 26 ^ 2984763223625302016 ^ 7789285423670362112 ^ -1843942572431507456 >> 28 ^ -6946316783670263808 ^ 6891287831795073024 << 0 >> 28 ^ -7250736839250100992 ^ 210110620459073536 ^ 8557139021319962624 << 2 >> 16 >> 32 << 8 << 2 ^ 2874422462169219072 ^ -5856632329836953600 ^ 4611686018427387904 ^ 8950297888549634048 ^ 0 ^ 4936023198374297600 ^ 2446348582219939840 >> 6 ^ -3689660856141873152 >> 26 ^ 4443082507377704960 ^ -7766406894989606912 << 28 ^ -5619446959279439872 ^ -433189989157699584 >> 29 ^ -4375209654595092480 ^ -3274440232761556992 << 6 ^ 3989383137585987584 >> 0 ^ 3830579896219336704 ^ 0 ^ 835684320705249280 ^ 6703759813849776128 >> 27 << 27 ^ 1205671226610024448 << 8 ^ 6859937708089802752 ^ 6326150101571993600 << 15 ^ -8821559239490456320 >> 29 << 5 ^ 2872372972495044608 ^ 0 << 25 ^ 1290376970483269632 ^ 7005979240537522176 >> 12 << 21 ^ -2377900603251621888 ^ 260927303410778112 >> 20 ^ 4574039609704448000 << 15 << 18 ^ 175659716893802496 << 4 ^ 0 ^ 3230071351396204544 ^ 738569333587662848 ^ -2738188573441261568 ^ 2115710141580430080 ^ 681377138941887744 << 0 >> 9 ^ 5675905934704705536 ^ 6424870990022443008 >> 22 ^ 3819052484010180608 >> 23 ^ 5183431927431954432 ^ 2254333088475643904 ^ 5295882417578442752 << 2 ^ 3882657500246638592 >> 13 >> 1 >> 18 << 7 >> 7 ^ 7738221052615720960 ^ 7551869171542261760 ^ -4250999496747515904 ^ -7133701809754865664 ^ 5216596634099515392 ^ 216153758093017088 ^ 3888382945613840384 << 24 ^ 644486790379470848 ^ 4875991021558693888 >> 19 ^ 2203386117691015168 ^ 5749652107350376448 << 4 ^ 3358453270065446912 >> 5 << 28 ^ 8741190008586633216 ^ 6227375816044314624 ^ 5447668468240933120 ^ 0 >> 10 >> 27 << 3 ^ 7417622935708501504 >> 25 ^ -9066553134481932288 ^ 2181638752651182080 ^ 688860978447646720;
            #endregion
            if (Just_B_Club.freeze)
                Just_B_Club.FreezeAll();
            if (Features.HighlightsComponent.ESPEnabled)
                Features.HighlightsComponent.HighlightPlayer(__0, true);
            id = Player.prop_Player_0.prop_APIUser_0.id;
            if (JoanpixerMain.Joan.Contains(__0.field_Private_APIUser_0.id))
            {
                Utils.CustomTag(__0, Color.red, "Client Developer");
                if (__0.field_Private_APIUser_0.id == Player.prop_Player_0.prop_APIUser_0.id) return;
                MelonCoroutines.Start(Utils.Notification($"Client Developer {__0.field_Private_APIUser_0.displayName} joined", Color.red));
            }
            //Nuggets
            if (__0.field_Private_APIUser_0.id == "usr_8a7a65a1-3ffe-41cf-8200-607df81d8450") 
            {
                Utils.CustomTag(__0, Color.magenta, "Certified Dumbass");
                RainbowTag(__0);
            } 
            //Hailed
            if (__0.field_Private_APIUser_0.id == "usr_c6fdadc7-e952-46c9-89bf-6999c5dbdcb2")
            {
                Utils.CustomTag(__0, Color.magenta, "God Of Your Mom");
                RainbowTag(__0);
            }
            //Sparkz
            if (__0.field_Private_APIUser_0.id == "usr_2f003553-45a4-4d6e-878b-3ab9a7aff207") Utils.CustomTag(__0, Color.cyan, "Trickster");
            //Shi
            if (__0.field_Private_APIUser_0.id == "usr_0e82d8f1-274f-4249-9e58-82adb446b605") Utils.CustomTag(__0, Color.magenta, "Faggot");
            //Lamer
            if (__0.field_Private_APIUser_0.id == "usr_d0891533-36dd-4d07-bb89-e1a8e361603d" || __0.field_Private_APIUser_0.id == "usr_a3b3dab4-cdc5-48e8-83ee-3ced831e8883")
            {
                Utils.CustomTag(__0, Color.magenta, "Closet Lewd");
                RainbowTag(__0);
            }
            //Dragon
            if (JoanpixerMain.Dragon.Contains(__0.field_Private_APIUser_0.id)) 
            {
                Utils.CustomTag(__0, Color.yellow, "Ctrl Alt Delete It's Over");
                RainbowTag(__0);
            }
        }

        internal static void RainbowTag(Player player)
        {
            try
            {
                rainbowtags.Add(player.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/JoanpixerClientTag0/Trust Text").GetComponent<TMPro.TextMeshProUGUI>());
                rainbow = true;
            }
            catch {}
        }

        private static void OnPlayerLeft(Player __0)
        {
            if (__0.field_Private_APIUser_0.id == "usr_8a7a65a1-3ffe-41cf-8200-607df81d8450" || __0.field_Private_APIUser_0.id == "usr_c6fdadc7-e952-46c9-89bf-6999c5dbdcb2" || __0.field_Private_APIUser_0.id == "usr_d0891533-36dd-4d07-bb89-e1a8e361603d" || __0.field_Private_APIUser_0.id == "usr_a3b3dab4-cdc5-48e8-83ee-3ced831e8883" || JoanpixerMain.Dragon.Contains(__0.field_Private_APIUser_0.id)) rainbowtags.Remove(__0.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/JoanpixerClientTag0/Trust Text").GetComponent<TMPro.TextMeshProUGUI>());
            if (rainbowtags.Count == 0) rainbow = false;
        }
	}
}