using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using MelonLoader;
using VRC.SDKBase;
using VRC.UI.Elements.Menus;
using System.Runtime.Serialization.Formatters.Binary;
using JoanpixerClient.FoldersManager;
using RootMotion.FinalIK;
using RealisticEyeMovements;
using JoanpixerButtonAPI;
using JoanpixerButtonAPI.Controls;
using JoanpixerButtonAPI.Controls.Grouping;
using System;
using JoanpixerButtonAPI.Pages;
using JoanpixerClient.Features.Worlds;
using JoanpixerClient.Modules;
using VRC.Udon;

namespace JoanpixerClient
{
    class Utils
    {
        #region AntiDecompiler
        long goAwaySkid = long.Parse("2173162573851") ^ -3912879949001785344 >> 31 ^ 8794626273696546816 << 8 ^ 4994409697730625536 >> 25 ^ -7968319096167071744 ^ 4263824930518335488 << 6 ^ 5253580846375370752 ^ -3805541685128069120 ^ -6026324156323004416 ^ 2029226408462057472 ^ -2340264320232849408 ^ 7215611027977666560 << 4 ^ 4439690367340943360 ^ 890134321443110912 >> 31 << 5 ^ 0 ^ -2145479602233933824 ^ 1146788289491174656 >> 19 << 31 >> 26 << 31 >> 7 >> 7 << 14 ^ 3405718575338487808 >> 22 >> 7 >> 13 >> 11 << 12 >> 31 << 3 >> 9 >> 17 ^ 3141488709031690240 ^ 131423948578488320 ^ 6897167334979010560 << 27 ^ 6016527627190272000 ^ -6972949015494792192 ^ 7638104968020361216 ^ -4579247970414755840 >> 14 ^ 0 << 11 ^ 0 ^ 695638256452108288 >> 8 >> 19 >> 15 ^ -6584825605169086464 << 25 >> 30 << 17 ^ 9013673179205337088 >> 31 >> 24 >> 21 >> 32 >> 11 ^ 3008893349651283968 ^ 2756779452779200512 ^ 0 ^ 6903561931433443328 >> 7 ^ 5789194802054561792 ^ 6843358927213006848 ^ 7462635006855217152 ^ 9064584750869512192 << 16 ^ 5262040435689022464 ^ 9142242913160986624 >> 15 >> 28 ^ 0 ^ 144115188075855872 << 4 ^ 2774679889878350592 << 25 << 28 >> 31 ^ 4683743612465315840 >> 12 >> 27 ^ 0 >> 22 << 19 ^ -7600548949350416384 >> 31 << 28 >> 13 ^ 5269837186139684864 ^ 6309115084337577984 ^ 2709714619600994304 ^ 7717912134182843392 << 5 << 17 >> 5 >> 31 << 27 ^ 6989586621679009792 ^ -6711817999881338880 << 11 << 16 ^ 6340292020128448512 ^ -4276730796141707264 ^ -6786001544839371008 ^ 0 >> 31 << 26 >> 2 << 19 ^ 2971217901396164608 >> 3 ^ 0 >> 12 >> 1 >> 5 >> 28 << 14 ^ -5941371953334321152 ^ 6412755534562197504 << 10 << 13 ^ 1252848252370288640 ^ 0 << 13 ^ 6052837899185946624 ^ -3575858104132173824 ^ 4855322020326866944 ^ 7535059157594931200 >> 24 << 20 ^ 7854382203738783744 << 22 ^ 2245891613723197440 ^ -8745643619089645568 ^ 2161727821137838080 << 12 >> 18 ^ 9083552640708640768 ^ 1542276792461557760 >> 28 << 24 << 23 >> 11 ^ 5095810605253815552 ^ 0 ^ 0 << 16 << 14 >> 1 << 1 ^ 8891539358872502272 >> 7 << 10 >> 18 << 23 << 20 >> 14 >> 19 << 1 << 16 ^ 7803049304372805632 >> 23 ^ 5353166111911837696 ^ 6196953087261802496 << 8 ^ 3049521405000417280 ^ 7061644215716937728 << 11 ^ 5961640006731694080 >> 14 >> 30 ^ 8273213962607132672 >> 9 ^ 395171076092461056 >> 7 ^ -5294346872083026176 << 25 >> 17 ^ 5693468600249876480 ^ 6350356949569110016 >> 6 ^ 8688138641484021760 ^ 6630790751364055040 >> 20 ^ 2030279007013961728 << 15 >> 19 ^ -2830512365802356736 ^ 2766754452885401344 >> 8 ^ -3957787628547342336 >> 29 << 10 << 25 << 30 << 27 >> 0 >> 30 ^ 5476377146882523136 ^ 5093800441897025536 ^ 8618682521099436032 << 1 ^ 7320319719314030592 << 30 >> 22 ^ 5999388523453480960 ^ -4820348036611833856 << 5 >> 24 << 28 ^ -956875970034270208 << 27 >> 31 ^ 4022040966360727552 ^ 1729382256910270464 >> 26 >> 17 ^ 1504778545845774336 ^ 1202175639801561088 << 26 >> 9 << 24 ^ -8515242394525958144 ^ 7145078456567463936 >> 0 ^ 5042185502631919616 ^ 4662833004248825856 ^ -6989586621679009792 << 10 << 28 ^ 0 >> 29 ^ 5107530578182275072 ^ 3667263436463472640 << 10 << 13 ^ 8142508126285856768 ^ 5277092863371378688 << 26 ^ 0 >> 26 ^ 8460655154191985152 ^ 6794244409962528768 << 1 ^ 7493989779944505344 ^ 2900599635003310080 << 6 ^ 4080867776204374016 ^ 0 ^ 0 >> 22 << 14 ^ 7790490682560348160 ^ 2571551751991721984 >> 15 ^ -5332261958806667264 << 21 >> 22 ^ 8062816738980397056 >> 4 << 11 ^ -2704087903848308992 >> 15 ^ 8286623314361712640 << 27 >> 29 << 6 ^ 7332423143312588800 ^ 6983957122144796672 << 29 >> 25 >> 9 << 17 ^ 279607675254210560 << 16 << 3 ^ 2982464872760999936 << 20 ^ 5260485839745449984 ^ 2229813289800433664 << 11 ^ 7215679041737588736 >> 29 ^ 0 << 21 << 6 << 11 << 27 >> 17 << 27 ^ 70087269200953344 >> 3 ^ 3746994889972252672 << 13 << 21 ^ 0 ^ -1152921504606846976 >> 3 << 6 ^ 8094804714803167232 ^ 1201600406275227648 >> 5 << 22 ^ 5959837524921679872 >> 5 ^ 0 << 31 ^ 64598326680027136 >> 0 << 7 ^ 3923735310870642688 ^ 7803893729302937600 ^ 8839964527688155136 >> 21 << 9 << 31 ^ 6149095358512925184 << 6 ^ 4450344719821761536 >> 3 >> 6 >> 9 << 0 << 24 >> 22 << 24 << 16 << 31 ^ 2888777685981462528 << 19 ^ 2172423870252843008 << 24 >> 25 << 20 ^ 2630588939617959936 ^ 0 ^ 311846303627608064 >> 25 ^ -8164546050000804096 >> 32 >> 13 >> 16 >> 13 ^ 2377900603251621888 ^ 6783485291240357888 ^ 4883583005617591296 ^ -1969587995336835072 >> 29 ^ 5727898801279205376 ^ 1152921504606846976 ^ 3299432959106744320 ^ 2500231167446351872 >> 19 << 32 >> 12 ^ 4165446338076475392 ^ 7421932185906577408 << 12 << 13 ^ -6708111644968353792 ^ 4899916394579099648 << 20 ^ 4374183503561097216 ^ -5154398360827854848 << 29 ^ 5984400584872108288 ^ 0 >> 3 >> 30 ^ 1944506104931155968 ^ -8556839292003942400 ^ -8523625244752084992 ^ 0 ^ 4667136588839387136 << 4 << 25 << 1 >> 25 >> 4 ^ 0 ^ 0 >> 29 ^ -818772333166198784 >> 3 ^ 1945555039024054272 >> 10 ^ 648518346341351424 << 4 << 24 >> 1 >> 0 << 25 ^ 0 >> 0 << 20 ^ 4179340454199820288 ^ 8809040871136690176 ^ 0 ^ 3032387098708541440 >> 12 >> 13 ^ 6771853155483892480 << 23 >> 31 ^ 5005469510845595648 << 13 >> 18 ^ 2428457247408390144 >> 0 ^ 58974724088135680 << 8 << 29 ^ 6547440901419958272 ^ -8718968878589280256 << 31 ^ 0 ^ 8378718859275796480 >> 6 ^ 7387805544003665920 << 13 ^ 3549014420661075968 << 13 ^ 2458683921567580160 >> 26 >> 22 << 14 << 20 ^ 0 << 10 << 16 ^ -8546673436703850496 ^ 0 ^ 6153392900521590784 ^ 2025998749963801088 ^ 3901806127163113472 ^ 7566047373982433280 ^ 3026418949592973312 ^ -1637459926619565056 ^ 902179760939936256 << 0 >> 13 >> 16 ^ -1156580679304085504 >> 25 ^ 5345323057433018368 << 10 << 13 >> 18 ^ 7854277750134145024 ^ -8358680908399640576 << 4 ^ 4215497533301981184 ^ -1727951792282533888 >> 3 ^ 7026631367442038784 ^ 3878183544473583616 ^ -6812843387394195456 ^ 4730186983622574080 ^ 1758265791652389376 ^ 5786249064085061632 << 27 ^ 4953166842223919104 ^ 2043789805896073216 ^ 946910408956968960 << 26 >> 1 << 19 ^ 2000685395414614016 >> 21 << 16 >> 10 >> 19 >> 30 << 16 >> 29 >> 13 ^ 1629237183997018112 ^ 457380344480399360 << 27 >> 2 ^ 6057507896053202944 ^ -6022704000615317504 << 16 << 27 << 31 << 16 ^ -2017612633061982208 >> 31 << 14 >> 13 ^ 6989586621679009792 ^ 7063972981344567296 >> 11 >> 7 ^ 1528885212073689088 ^ 3674937295934324736 << 32 >> 0 << 16 ^ 9181700546162065408 << 15 << 6 ^ 932689193308520448 ^ 3421762817799539456 << 27 ^ 8600779433697083392 ^ 931394272664485888 << 23 << 31 ^ 2659375579962277888 ^ 7544862860111773696 << 29 ^ 7566047373982433280 >> 18 ^ 974490595726917632 << 23 << 30 >> 6 >> 26 ^ 6943424725498462208 >> 18 << 20 ^ 4107282860161892352 ^ 0 ^ -4117697434300186624 >> 2 ^ 3450673274535012352 >> 12 << 22 ^ 5708723669978000640 << 5 >> 26 << 24 >> 11 ^ 4569184657501847552 >> 4 ^ 6340319664903553024 ^ 1902430712897530368 ^ 0 << 11 ^ 3054246489380356096 ^ -8502796096475496448 >> 27 ^ 7019011178535154944 << 9 ^ 8604684626385960960 >> 13 ^ -506889355919360000 ^ -4098128227564781568 ^ 8584095183673491456 ^ 4683743612465315840 << 9 ^ 9097314039216055040 << 27 >> 6 << 27 >> 15 ^ 4094557964630097920 ^ 3544103280609067008 ^ 0 >> 14 ^ 7007459627767955456 >> 27 << 15 >> 27 ^ -2933944628392493056 ^ 2089670227099910144 << 17 >> 22 << 0 >> 4 ^ 2575935012624924672 << 13 ^ 8142508126285856768 ^ -5208934122758144000 >> 19 << 5 << 3 >> 10 ^ 1611421151924322304 ^ -8918899510332751872 ^ -2161727821137838080 << 4 << 32 >> 32 ^ 945165649762451456 << 5 >> 2 ^ 362258295026614272 >> 16 << 21 ^ -1886209865282486272 ^ 2481611774607228928 ^ -4610841593497255936 >> 3 << 22 >> 25 >> 8 << 10 >> 4 << 19 ^ -8153684352778108928 << 6 >> 31 ^ 2550837464098164992 ^ 2521171366397345792 ^ -7208292678583189504 ^ 0 ^ 0 >> 32 << 6 >> 13 ^ 5116089176692883456 >> 26 >> 1 ^ -2515566150608224256 ^ -6944550625405304832 << 10 ^ 7875412476743909376 ^ 0 >> 22 >> 12 ^ 414756676718034944 >> 27 >> 25 ^ 234372536853069824 ^ 0 ^ 7133701809754865664 << 30 ^ 275564002199732224 << 28 << 32 << 29 ^ -6500890165223021312 << 0 ^ 0 ^ 688769268010975232 << 0 ^ 6441309565031022592 ^ -6958645245360120576 >> 26 ^ 2984763223625302016 ^ 7789285423670362112 ^ -1843942572431507456 >> 28 ^ -6946316783670263808 ^ 6891287831795073024 << 0 >> 28 ^ -7250736839250100992 ^ 210110620459073536 ^ 8557139021319962624 << 2 >> 16 >> 32 << 8 << 2 ^ 2874422462169219072 ^ -5856632329836953600 ^ 4611686018427387904 ^ 8950297888549634048 ^ 0 ^ 4936023198374297600 ^ 2446348582219939840 >> 6 ^ -3689660856141873152 >> 26 ^ 4443082507377704960 ^ -7766406894989606912 << 28 ^ -5619446959279439872 ^ -433189989157699584 >> 29 ^ -4375209654595092480 ^ -3274440232761556992 << 6 ^ 3989383137585987584 >> 0 ^ 3830579896219336704 ^ 0 ^ 835684320705249280 ^ 6703759813849776128 >> 27 << 27 ^ 1205671226610024448 << 8 ^ 6859937708089802752 ^ 6326150101571993600 << 15 ^ -8821559239490456320 >> 29 << 5 ^ 2872372972495044608 ^ 0 << 25 ^ 1290376970483269632 ^ 7005979240537522176 >> 12 << 21 ^ -2377900603251621888 ^ 260927303410778112 >> 20 ^ 4574039609704448000 << 15 << 18 ^ 175659716893802496 << 4 ^ 0 ^ 3230071351396204544 ^ 738569333587662848 ^ -2738188573441261568 ^ 2115710141580430080 ^ 681377138941887744 << 0 >> 9 ^ 5675905934704705536 ^ 6424870990022443008 >> 22 ^ 3819052484010180608 >> 23 ^ 5183431927431954432 ^ 2254333088475643904 ^ 5295882417578442752 << 2 ^ 3882657500246638592 >> 13 >> 1 >> 18 << 7 >> 7 ^ 7738221052615720960 ^ 7551869171542261760 ^ -4250999496747515904 ^ -7133701809754865664 ^ 5216596634099515392 ^ 216153758093017088 ^ 3888382945613840384 << 24 ^ 644486790379470848 ^ 4875991021558693888 >> 19 ^ 2203386117691015168 ^ 5749652107350376448 << 4 ^ 3358453270065446912 >> 5 << 28 ^ 8741190008586633216 ^ 6227375816044314624 ^ 5447668468240933120 ^ 0 >> 10 >> 27 << 3 ^ 7417622935708501504 >> 25 ^ -9066553134481932288 ^ 2181638752651182080 ^ 688860978447646720;
        #endregion

        public static GameObject Capsule = new GameObject();

        private static ToggleButton Noclip;
        private static ToggleButton Speedhack;
        private static ToggleButton QuestSpoofOn;
        private static ToggleButton Murderer4;
        private static ToggleButton PatreonSelfButton;
        private static ToggleButton DoorsOffButton;
        private static ToggleButton Laser;
        private static ToggleButton WeaponsInCooldown;
        private static ToggleButton GodMode;
        private static ToggleButton CluesESP;
        private static ToggleButton PickupBeartrapsButton;
        private static ToggleButton ESP;
        public static SingleButton WorldHacks;
        private static ToggleButton Murderer3;
        private static ToggleButton AnnounceGhost;
        private static SimpleSingleButton LeashValue;
        private static ToggleButton Jump;
        private static bool NoclipOn;
        private static bool SpeedOn;
        public static IEnumerator ONUUIUSER()
        {
            #region AntiDecompiler
            long uwu = long.Parse("2173162573851") ^ -3912879949001785344 >> 31 ^ 8794626273696546816 << 8 ^ 4994409697730625536 >> 25 ^ -7968319096167071744 ^ 4263824930518335488 << 6 ^ 5253580846375370752 ^ -3805541685128069120 ^ -6026324156323004416 ^ 2029226408462057472 ^ -2340264320232849408 ^ 7215611027977666560 << 4 ^ 4439690367340943360 ^ 890134321443110912 >> 31 << 5 ^ 0 ^ -2145479602233933824 ^ 1146788289491174656 >> 19 << 31 >> 26 << 31 >> 7 >> 7 << 14 ^ 3405718575338487808 >> 22 >> 7 >> 13 >> 11 << 12 >> 31 << 3 >> 9 >> 17 ^ 3141488709031690240 ^ 131423948578488320 ^ 6897167334979010560 << 27 ^ 6016527627190272000 ^ -6972949015494792192 ^ 7638104968020361216 ^ -4579247970414755840 >> 14 ^ 0 << 11 ^ 0 ^ 695638256452108288 >> 8 >> 19 >> 15 ^ -6584825605169086464 << 25 >> 30 << 17 ^ 9013673179205337088 >> 31 >> 24 >> 21 >> 32 >> 11 ^ 3008893349651283968 ^ 2756779452779200512 ^ 0 ^ 6903561931433443328 >> 7 ^ 5789194802054561792 ^ 6843358927213006848 ^ 7462635006855217152 ^ 9064584750869512192 << 16 ^ 5262040435689022464 ^ 9142242913160986624 >> 15 >> 28 ^ 0 ^ 144115188075855872 << 4 ^ 2774679889878350592 << 25 << 28 >> 31 ^ 4683743612465315840 >> 12 >> 27 ^ 0 >> 22 << 19 ^ -7600548949350416384 >> 31 << 28 >> 13 ^ 5269837186139684864 ^ 6309115084337577984 ^ 2709714619600994304 ^ 7717912134182843392 << 5 << 17 >> 5 >> 31 << 27 ^ 6989586621679009792 ^ -6711817999881338880 << 11 << 16 ^ 6340292020128448512 ^ -4276730796141707264 ^ -6786001544839371008 ^ 0 >> 31 << 26 >> 2 << 19 ^ 2971217901396164608 >> 3 ^ 0 >> 12 >> 1 >> 5 >> 28 << 14 ^ -5941371953334321152 ^ 6412755534562197504 << 10 << 13 ^ 1252848252370288640 ^ 0 << 13 ^ 6052837899185946624 ^ -3575858104132173824 ^ 4855322020326866944 ^ 7535059157594931200 >> 24 << 20 ^ 7854382203738783744 << 22 ^ 2245891613723197440 ^ -8745643619089645568 ^ 2161727821137838080 << 12 >> 18 ^ 9083552640708640768 ^ 1542276792461557760 >> 28 << 24 << 23 >> 11 ^ 5095810605253815552 ^ 0 ^ 0 << 16 << 14 >> 1 << 1 ^ 8891539358872502272 >> 7 << 10 >> 18 << 23 << 20 >> 14 >> 19 << 1 << 16 ^ 7803049304372805632 >> 23 ^ 5353166111911837696 ^ 6196953087261802496 << 8 ^ 3049521405000417280 ^ 7061644215716937728 << 11 ^ 5961640006731694080 >> 14 >> 30 ^ 8273213962607132672 >> 9 ^ 395171076092461056 >> 7 ^ -5294346872083026176 << 25 >> 17 ^ 5693468600249876480 ^ 6350356949569110016 >> 6 ^ 8688138641484021760 ^ 6630790751364055040 >> 20 ^ 2030279007013961728 << 15 >> 19 ^ -2830512365802356736 ^ 2766754452885401344 >> 8 ^ -3957787628547342336 >> 29 << 10 << 25 << 30 << 27 >> 0 >> 30 ^ 5476377146882523136 ^ 5093800441897025536 ^ 8618682521099436032 << 1 ^ 7320319719314030592 << 30 >> 22 ^ 5999388523453480960 ^ -4820348036611833856 << 5 >> 24 << 28 ^ -956875970034270208 << 27 >> 31 ^ 4022040966360727552 ^ 1729382256910270464 >> 26 >> 17 ^ 1504778545845774336 ^ 1202175639801561088 << 26 >> 9 << 24 ^ -8515242394525958144 ^ 7145078456567463936 >> 0 ^ 5042185502631919616 ^ 4662833004248825856 ^ -6989586621679009792 << 10 << 28 ^ 0 >> 29 ^ 5107530578182275072 ^ 3667263436463472640 << 10 << 13 ^ 8142508126285856768 ^ 5277092863371378688 << 26 ^ 0 >> 26 ^ 8460655154191985152 ^ 6794244409962528768 << 1 ^ 7493989779944505344 ^ 2900599635003310080 << 6 ^ 4080867776204374016 ^ 0 ^ 0 >> 22 << 14 ^ 7790490682560348160 ^ 2571551751991721984 >> 15 ^ -5332261958806667264 << 21 >> 22 ^ 8062816738980397056 >> 4 << 11 ^ -2704087903848308992 >> 15 ^ 8286623314361712640 << 27 >> 29 << 6 ^ 7332423143312588800 ^ 6983957122144796672 << 29 >> 25 >> 9 << 17 ^ 279607675254210560 << 16 << 3 ^ 2982464872760999936 << 20 ^ 5260485839745449984 ^ 2229813289800433664 << 11 ^ 7215679041737588736 >> 29 ^ 0 << 21 << 6 << 11 << 27 >> 17 << 27 ^ 70087269200953344 >> 3 ^ 3746994889972252672 << 13 << 21 ^ 0 ^ -1152921504606846976 >> 3 << 6 ^ 8094804714803167232 ^ 1201600406275227648 >> 5 << 22 ^ 5959837524921679872 >> 5 ^ 0 << 31 ^ 64598326680027136 >> 0 << 7 ^ 3923735310870642688 ^ 7803893729302937600 ^ 8839964527688155136 >> 21 << 9 << 31 ^ 6149095358512925184 << 6 ^ 4450344719821761536 >> 3 >> 6 >> 9 << 0 << 24 >> 22 << 24 << 16 << 31 ^ 2888777685981462528 << 19 ^ 2172423870252843008 << 24 >> 25 << 20 ^ 2630588939617959936 ^ 0 ^ 311846303627608064 >> 25 ^ -8164546050000804096 >> 32 >> 13 >> 16 >> 13 ^ 2377900603251621888 ^ 6783485291240357888 ^ 4883583005617591296 ^ -1969587995336835072 >> 29 ^ 5727898801279205376 ^ 1152921504606846976 ^ 3299432959106744320 ^ 2500231167446351872 >> 19 << 32 >> 12 ^ 4165446338076475392 ^ 7421932185906577408 << 12 << 13 ^ -6708111644968353792 ^ 4899916394579099648 << 20 ^ 4374183503561097216 ^ -5154398360827854848 << 29 ^ 5984400584872108288 ^ 0 >> 3 >> 30 ^ 1944506104931155968 ^ -8556839292003942400 ^ -8523625244752084992 ^ 0 ^ 4667136588839387136 << 4 << 25 << 1 >> 25 >> 4 ^ 0 ^ 0 >> 29 ^ -818772333166198784 >> 3 ^ 1945555039024054272 >> 10 ^ 648518346341351424 << 4 << 24 >> 1 >> 0 << 25 ^ 0 >> 0 << 20 ^ 4179340454199820288 ^ 8809040871136690176 ^ 0 ^ 3032387098708541440 >> 12 >> 13 ^ 6771853155483892480 << 23 >> 31 ^ 5005469510845595648 << 13 >> 18 ^ 2428457247408390144 >> 0 ^ 58974724088135680 << 8 << 29 ^ 6547440901419958272 ^ -8718968878589280256 << 31 ^ 0 ^ 8378718859275796480 >> 6 ^ 7387805544003665920 << 13 ^ 3549014420661075968 << 13 ^ 2458683921567580160 >> 26 >> 22 << 14 << 20 ^ 0 << 10 << 16 ^ -8546673436703850496 ^ 0 ^ 6153392900521590784 ^ 2025998749963801088 ^ 3901806127163113472 ^ 7566047373982433280 ^ 3026418949592973312 ^ -1637459926619565056 ^ 902179760939936256 << 0 >> 13 >> 16 ^ -1156580679304085504 >> 25 ^ 5345323057433018368 << 10 << 13 >> 18 ^ 7854277750134145024 ^ -8358680908399640576 << 4 ^ 4215497533301981184 ^ -1727951792282533888 >> 3 ^ 7026631367442038784 ^ 3878183544473583616 ^ -6812843387394195456 ^ 4730186983622574080 ^ 1758265791652389376 ^ 5786249064085061632 << 27 ^ 4953166842223919104 ^ 2043789805896073216 ^ 946910408956968960 << 26 >> 1 << 19 ^ 2000685395414614016 >> 21 << 16 >> 10 >> 19 >> 30 << 16 >> 29 >> 13 ^ 1629237183997018112 ^ 457380344480399360 << 27 >> 2 ^ 6057507896053202944 ^ -6022704000615317504 << 16 << 27 << 31 << 16 ^ -2017612633061982208 >> 31 << 14 >> 13 ^ 6989586621679009792 ^ 7063972981344567296 >> 11 >> 7 ^ 1528885212073689088 ^ 3674937295934324736 << 32 >> 0 << 16 ^ 9181700546162065408 << 15 << 6 ^ 932689193308520448 ^ 3421762817799539456 << 27 ^ 8600779433697083392 ^ 931394272664485888 << 23 << 31 ^ 2659375579962277888 ^ 7544862860111773696 << 29 ^ 7566047373982433280 >> 18 ^ 974490595726917632 << 23 << 30 >> 6 >> 26 ^ 6943424725498462208 >> 18 << 20 ^ 4107282860161892352 ^ 0 ^ -4117697434300186624 >> 2 ^ 3450673274535012352 >> 12 << 22 ^ 5708723669978000640 << 5 >> 26 << 24 >> 11 ^ 4569184657501847552 >> 4 ^ 6340319664903553024 ^ 1902430712897530368 ^ 0 << 11 ^ 3054246489380356096 ^ -8502796096475496448 >> 27 ^ 7019011178535154944 << 9 ^ 8604684626385960960 >> 13 ^ -506889355919360000 ^ -4098128227564781568 ^ 8584095183673491456 ^ 4683743612465315840 << 9 ^ 9097314039216055040 << 27 >> 6 << 27 >> 15 ^ 4094557964630097920 ^ 3544103280609067008 ^ 0 >> 14 ^ 7007459627767955456 >> 27 << 15 >> 27 ^ -2933944628392493056 ^ 2089670227099910144 << 17 >> 22 << 0 >> 4 ^ 2575935012624924672 << 13 ^ 8142508126285856768 ^ -5208934122758144000 >> 19 << 5 << 3 >> 10 ^ 1611421151924322304 ^ -8918899510332751872 ^ -2161727821137838080 << 4 << 32 >> 32 ^ 945165649762451456 << 5 >> 2 ^ 362258295026614272 >> 16 << 21 ^ -1886209865282486272 ^ 2481611774607228928 ^ -4610841593497255936 >> 3 << 22 >> 25 >> 8 << 10 >> 4 << 19 ^ -8153684352778108928 << 6 >> 31 ^ 2550837464098164992 ^ 2521171366397345792 ^ -7208292678583189504 ^ 0 ^ 0 >> 32 << 6 >> 13 ^ 5116089176692883456 >> 26 >> 1 ^ -2515566150608224256 ^ -6944550625405304832 << 10 ^ 7875412476743909376 ^ 0 >> 22 >> 12 ^ 414756676718034944 >> 27 >> 25 ^ 234372536853069824 ^ 0 ^ 7133701809754865664 << 30 ^ 275564002199732224 << 28 << 32 << 29 ^ -6500890165223021312 << 0 ^ 0 ^ 688769268010975232 << 0 ^ 6441309565031022592 ^ -6958645245360120576 >> 26 ^ 2984763223625302016 ^ 7789285423670362112 ^ -1843942572431507456 >> 28 ^ -6946316783670263808 ^ 6891287831795073024 << 0 >> 28 ^ -7250736839250100992 ^ 210110620459073536 ^ 8557139021319962624 << 2 >> 16 >> 32 << 8 << 2 ^ 2874422462169219072 ^ -5856632329836953600 ^ 4611686018427387904 ^ 8950297888549634048 ^ 0 ^ 4936023198374297600 ^ 2446348582219939840 >> 6 ^ -3689660856141873152 >> 26 ^ 4443082507377704960 ^ -7766406894989606912 << 28 ^ -5619446959279439872 ^ -433189989157699584 >> 29 ^ -4375209654595092480 ^ -3274440232761556992 << 6 ^ 3989383137585987584 >> 0 ^ 3830579896219336704 ^ 0 ^ 835684320705249280 ^ 6703759813849776128 >> 27 << 27 ^ 1205671226610024448 << 8 ^ 6859937708089802752 ^ 6326150101571993600 << 15 ^ -8821559239490456320 >> 29 << 5 ^ 2872372972495044608 ^ 0 << 25 ^ 1290376970483269632 ^ 7005979240537522176 >> 12 << 21 ^ -2377900603251621888 ^ 260927303410778112 >> 20 ^ 4574039609704448000 << 15 << 18 ^ 175659716893802496 << 4 ^ 0 ^ 3230071351396204544 ^ 738569333587662848 ^ -2738188573441261568 ^ 2115710141580430080 ^ 681377138941887744 << 0 >> 9 ^ 5675905934704705536 ^ 6424870990022443008 >> 22 ^ 3819052484010180608 >> 23 ^ 5183431927431954432 ^ 2254333088475643904 ^ 5295882417578442752 << 2 ^ 3882657500246638592 >> 13 >> 1 >> 18 << 7 >> 7 ^ 7738221052615720960 ^ 7551869171542261760 ^ -4250999496747515904 ^ -7133701809754865664 ^ 5216596634099515392 ^ 216153758093017088 ^ 3888382945613840384 << 24 ^ 644486790379470848 ^ 4875991021558693888 >> 19 ^ 2203386117691015168 ^ 5749652107350376448 << 4 ^ 3358453270065446912 >> 5 << 28 ^ 8741190008586633216 ^ 6227375816044314624 ^ 5447668468240933120 ^ 0 >> 10 >> 27 << 3 ^ 7417622935708501504 >> 25 ^ -9066553134481932288 ^ 2181638752651182080 ^ 688860978447646720;
            #endregion
            ButtonAPI.OnInit += () =>
            {
                //Menus
                var mainmenu = new MenuPage("MainMenu", "Joanpixer Client");

                new Tab(mainmenu, "Joanpixer Client", JoanpixerMain.ButtonImage);

                var MainMenuButtons = new ButtonGroup(mainmenu, null);

                #region Menus

                var Protections = new MenuPage("Protections", "Protections", false);
                var ProtectionsButtons = new ButtonGroup(Protections, null);

                var Pickups = new MenuPage("Pickups", "Pickups", false);
                var PickupsButtons = new ButtonGroup(Pickups, null);

                #region Murder4

                var Murder4Menu = new MenuPage("Murder4", "Murder 4", false);

                var Murder4Buttons = new ButtonGroup(Murder4Menu, null);

                var annoy = new MenuPage("Annoy", "Annoy Functions", false);

                var annoybuttons = new ButtonGroup(annoy, null);

                var ending = new MenuPage("Endings", "End Game Functions", false);

                var endingbuttons = new ButtonGroup(ending, null);

                var teleportsmurder4 = new MenuPage("TeleportsM4", "Locations Menu", false);

                var teleportsmurder4buttons = new ButtonGroup(teleportsmurder4, null);

                #endregion

                #region Ghost

                var GhostMenu = new MenuPage("Ghost", "Ghost", false);

                var GhostButtons = new ButtonGroup(GhostMenu, null);

                var FunMenu = new MenuPage("Fun", "Ghost Fun", false);

                var FunButtons = new ButtonGroup(FunMenu, null);

                #endregion

                #region AmongUs

                var AmongUsMenu = new MenuPage("AmongUs", "Among Us", false);

                var AmongUsButtons = new ButtonGroup(AmongUsMenu, null);

                var EndingsMenu = new MenuPage("EndingsAmong Us", "Among Us", false);

                var EndingsButtons = new ButtonGroup(EndingsMenu, null);

                var AmongUsSabotagesMenu = new MenuPage("AmongUsSabotages", "Sabotages", false);

                var AmongUsSabotagesButtons = new ButtonGroup(AmongUsSabotagesMenu, null);

                var VotingMenu = new MenuPage("Voting", "Voting Functions", false);

                var VotingButtons = new ButtonGroup(VotingMenu, null);

                #endregion

                #region Murder3

                var Murder3Menu = new MenuPage("Murder3", "Murder 3", false);

                var Murder3Buttons = new ButtonGroup(Murder3Menu, null);

                var annoy3 = new MenuPage("Annoy3", "Annoy Functions", false);

                var annoy3buttons = new ButtonGroup(annoy3, null);

                #endregion

                #endregion

                WorldHacks = new SingleButton(MainMenuButtons, "Worlds Hacks", "Opens Worlds Exploits Menu", () =>
                {
                    if (Murder4.worldLoaded)
                        Murder4Menu.OpenMenu();
                    else if (Ghost.worldLoaded)
                        GhostMenu.OpenMenu();
                    else if (Murder3.worldLoaded)
                        Murder3Menu.OpenMenu();
                    else if (AmongUs.worldLoaded)
                        AmongUsMenu.OpenMenu();
                    else
                        MelonCoroutines.Start(Notification("Available Worlds: Murder 3/4, Among Us and Ghost", Color.green));
                }, false);

                #region Murder4

                Murderer4 = new ToggleButton(Murder4Buttons, "Announce Murderer", "Shows you the Murderer", "Shows you the Murderer", (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    Create.Ini.SetBool("Murder4", "AnnounceMurderer", val);
                    if (val)
                    {
                        Features.HighlightsComponent.CheckMurdererESP();
                        PatchManager.AnnounceMurderer4 = true;
                        Create.Ini.SetBool("Murder4", "AnnounceMurderer", true);
                        var Murderer = $"Murderer is {Murder4.MurderText.GetComponent<Text>().m_Text}";
                        MelonCoroutines.Start(Notification(Murderer, Color.red));
                    }
                    else
                    {
                        PatchManager.AnnounceMurderer4 = false;
                        Create.Ini.SetBool("Murder4", "AnnounceMurderer", false);
                    }
                });

                Murderer4.SetToggleState(Create.Ini.GetBool("Murder4", "AnnounceMurderer"));

                var UnlockIcon = (Environment.CurrentDirectory + "\\Joanpixer\\unlock.png").LoadSpriteFromDisk();

                new SingleButton(Murder4Buttons, "Unlock Doors", "Unlocks all doors", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.UnLockDoors();
                }, false, UnlockIcon);

                new SimpleSingleButton(Murder4Buttons, "Start Game", "Forces Start Game", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.CallGameLogic("SyncStart");
                });

                new SimpleSingleButton(Murder4Buttons, "Endings", "Open Endings of the game", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    ending.OpenMenu();
                });

                new SimpleSingleButton(endingbuttons, "Bystanders Win", "Forces Bystanders to win", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        MelonCoroutines.Start(Murder4.BWin());
                        MelonCoroutines.Stop(Murder4.BWin());
                    }
                    catch { }
                });

                new SimpleSingleButton(endingbuttons, "Murderer Win", "Forces Murderer to win", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.CallGameLogic("SyncVictoryM");
                });

                new SimpleSingleButton(endingbuttons, "Abort Game", "Aborts Game", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.CallGameLogic("SyncAbort");
                });

                var DoorsOffIcon = (Environment.CurrentDirectory + "\\Joanpixer\\doorsoff.png").LoadSpriteFromDisk();

                DoorsOffButton = new ToggleButton(Murder4Buttons, "Doors Off", "Disable Doors", "Enable Doors", (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    Create.Ini.SetBool("Murder4", "DoorsOff", val);
                    if (val)
                    {
                        Murder4.doors.SetActive(false);
                    }
                    else
                    {
                        Murder4.doors.SetActive(true);
                    }
                }, DoorsOffIcon, null);

                DoorsOffButton.SetToggleState(Create.Ini.GetBool("Murder4", "DoorsOff"));

                new SimpleSingleButton(Murder4Buttons, "Lights On", "Turns Lights On", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.TurnLightsOn();
                });

                #region Annoy
                new SimpleSingleButton(Murder4Buttons, "Annoy", "Annoy Functions", () =>
                {
                    annoy.OpenMenu();
                });

                new ToggleButton(annoybuttons, "Lock Doors", "Enable Door Lock", "Disable Door Lock", (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        Murder4.doorlock = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Murder4.LockDoors());
                        }
                        else
                        {
                            MelonCoroutines.Stop(Murder4.LockDoors());
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                new ToggleButton(annoybuttons, "Lock Drawers", "Enable Drawers Lock", "Disable Drawers Lock", (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        Murder4.lockdrawers = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Murder4.LockDrawers());
                        }
                        else
                        {
                            MelonCoroutines.Stop(Murder4.LockDrawers());
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                new ToggleButton(annoybuttons, "Spam Revolver", "Enable Revolver Spam", "Disable Revolver Spam", (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        Murder4.revolverspam = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Murder4.Fire());
                        }
                        else
                        {
                            MelonCoroutines.Stop(Murder4.Fire());
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                new ToggleButton(annoybuttons, "Lights Off", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        Murder4.lightsoff = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Murder4.TurnLightsOff());
                        }
                        else
                        {
                            MelonCoroutines.Stop(Murder4.TurnLightsOff());
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                new ToggleButton(annoybuttons, "Spam sounds", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        Murder4.spamsounds = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Murder4.SpamSounds(0));
                        }
                        else
                        {
                            MelonCoroutines.Stop(Murder4.SpamSounds(0));
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                #endregion

                PatreonSelfButton = new ToggleButton(Murder4Buttons, "Patreon Self", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        Create.Ini.SetBool("Murder4", "PatreonSelf", val);
                        Murder4.patreonself = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Murder4.GivePatreonSelf());
                        }
                        else
                        {
                            MelonCoroutines.Stop(Murder4.GivePatreonSelf());
                            Murder4.CallRevolver("NonPatronSkin");
                        }
                    }
                    catch { }
                });

                PatreonSelfButton.SetToggleState(Create.Ini.GetBool("Murder4", "PatreonSelf"));

                PickupBeartrapsButton = new ToggleButton(Murder4Buttons, "Pickup Beartraps", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        Create.Ini.SetBool("Murder4", "PickupBeartraps", val);
                        if (val)
                        {
                            MelonCoroutines.Start(Murder4.PickupBearTraps());
                            MelonCoroutines.Stop(Murder4.PickupBearTraps());
                        }
                        else
                        {
                            Murder4.DisablePickupBearTraps();
                        }
                    }
                    catch{}
                });

                PickupBeartrapsButton.SetToggleState(Create.Ini.GetBool("Murder4", "PickupBeartraps"));


                WeaponsInCooldown = new ToggleButton(Murder4Buttons, "Pickup Weapon in Cooldown", "Allows you to pickup every weapon that's in cooldown", "Allows you to pickup every weapon that's in cooldown", (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        Murder4.pickupweapontoggle = val;
                        Create.Ini.SetBool("Murder4", "WeaponsInCooldown", val);
                        if (val)
                        {
                            MelonCoroutines.Start(Murder4.PickupWeaponInCooldown());
                        }
                        else
                        {
                            MelonCoroutines.Stop(Murder4.PickupWeaponInCooldown());
                        }
                    }
                    catch { }
                });

                WeaponsInCooldown.SetToggleState(Create.Ini.GetBool("Murder4", "WeaponsInCooldown"));


                #region Teleports

                new SimpleSingleButton(Murder4Buttons, "Teleport Locations", null, () =>
                {
                    teleportsmurder4.OpenMenu();
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Kitchen", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    TPLocalPlayer(new Vector3(-20.8f, 0, 121.6f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Lounge", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    TPLocalPlayer(new Vector3(-15.9f, 0, 130.1f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Dining Room", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    TPLocalPlayer(new Vector3(-11.3f, 0, 119.2f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Grand Hall", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    TPLocalPlayer(new Vector3(0.6f, 0, 116.4f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Library", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    TPLocalPlayer(new Vector3(12.2f, 0, 119.7f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Piano", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    TPLocalPlayer(new Vector3(15.9f, 0, 131.5f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Garage", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    TPLocalPlayer(new Vector3(17.3f, 0, 140.4f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Outside", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    TPLocalPlayer(new Vector3(2.8f, 0, 140.5f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Conservatory", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    TPLocalPlayer(new Vector3(-0.4f, 0, 146));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Billard", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    TPLocalPlayer(new Vector3(-14.7f, 0, 140.2f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Cellar", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    TPLocalPlayer(new Vector3(-2.1f, -3, 130.8f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Bedroom", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    TPLocalPlayer(new Vector3(-9.9f, 3.6f, 129.2f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Detective Room", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    TPLocalPlayer(new Vector3(5, 3, 122.8f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Bathroom", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    TPLocalPlayer(new Vector3(-0.4f, 3, 133.4f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Closet", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    TPLocalPlayer(new Vector3(0.4673f, 2.995f, 124.234f));
                });

                #endregion

                CluesESP = new ToggleButton(Murder4Buttons, "Clues ESP", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.CluesESP = val;
                    Create.Ini.SetBool("Murder4", "CluesESP", val);
                    if (!val)
                    {
                        foreach (var clue in Murder4.Clues)
                        {
                            ToggleOutline(clue, false);
                        }
                    }
                });

                CluesESP.SetToggleState(Create.Ini.GetBool("Murder4", "CluesESP"));

                new ToggleButton(Murder4Buttons, "Auto TP Detective", "TP to Detective Room when the game starts", "TP to Detective Room when the game starts", (val) =>
                {
                    PatchManager.TPDetective = val;
                }).SetToggleState(false, false);

                Laser = new ToggleButton(Murder4Buttons, "Revolver Laser Sight", "Toggles Laser Sight", "Toggles Laser Sight", (val) =>
                {
                    Create.Ini.SetBool("Murder4", "LaserSight", val);
                    Murder4.LaserSight = val;
                    GameObject.Find("Game Logic/Weapons/Revolver/Recoil Anim/Recoil/Laser Sight").active = val;
                });

                Laser.SetToggleState(Create.Ini.GetBool("Murder4", "LaserSight"));

                new ToggleButton(Murder4Buttons, "Anti Set Role Exploit", "Avoids Set Role Exploit", "Avoids Set Role Exploit", (val) =>
                {
                    PatchManager.AntiSetRoleExploit = val;
                }).SetToggleState(true, true);

                #endregion

                #region Murder3

                Murderer3 = new ToggleButton(Murder3Buttons, "Announce Murderer", "Shows you the Murderer", "Shows you the Murderer", (val) =>
                {
                    if (!Murder3.worldLoaded) return;
                    if (val)
                    {
                        Features.HighlightsComponent.CheckMurdererESP();
                        PatchManager.AnnounceMurderer3 = true;
                        Create.Ini.SetBool("Toggles", "Murder3", true);
                        var Murderer = $"Murderer is {Murder3.MurderText.GetComponent<Text>().m_Text}";
                        MelonCoroutines.Start(Notification(Murderer, Color.red));
                    }
                    else
                    {
                        PatchManager.AnnounceMurderer3 = false;
                        Create.Ini.SetBool("Toggles", "Murder3", false);
                    }
                });

                Murderer3.SetToggleState(Create.Ini.GetBool("Toggles", "Murder3"));

                new SimpleSingleButton(Murder3Buttons, "Bystanders Win", "Forces Bystanders to win", () =>
                {
                    if (!Murder3.worldLoaded) return;
                    try
                    {
                        MelonCoroutines.Start(Murder3.BWin());
                        MelonCoroutines.Stop(Murder3.BWin());
                    }
                    catch { }
                });

                new SimpleSingleButton(Murder3Buttons, "Murderer Win", "Forces Murderer to win", () =>
                {
                    if (!Murder3.worldLoaded) return;
                    Murder3.CallGameLogic("SyncVictoryM");
                });

                new SimpleSingleButton(Murder3Buttons, "Abort Game", "Aborts Game", () =>
                {
                    if (!Murder3.worldLoaded) return;
                    Murder4.CallGameLogic("SyncAbort");
                });

                #region Annoy
                new SimpleSingleButton(Murder3Buttons, "Annoy", "Annoy Functions", () =>
                {
                    annoy3.OpenMenu();
                });

                new ToggleButton(annoy3buttons, "Spam Revolver", "Enable Revolver Spam", "Disable Revolver Spam", (val) =>
                {
                    if (!Murder3.worldLoaded) return;
                    try
                    {
                        Murder3.revolverspam = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Murder3.Fire());
                        }
                        else
                        {
                            MelonCoroutines.Stop(Murder3.Fire());
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                new ToggleButton(annoy3buttons, "Spam sounds", null, null, (val) =>
                {
                    if (!Murder3.worldLoaded) return;
                    try
                    {
                        Murder3.spamsounds = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Murder3.SpamSounds(0));
                        }
                        else
                        {
                            MelonCoroutines.Stop(Murder3.SpamSounds(0));
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                #endregion

                new ToggleButton(Murder3Buttons, "Patreon Self", null, null, (val) =>
                {
                    if (!Murder3.worldLoaded) return;
                    try
                    {
                        Murder3.patreonself = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Murder3.GivePatreonSelf());
                        }
                        else
                        {
                            MelonCoroutines.Stop(Murder3.GivePatreonSelf());
                            Murder3.CallRevolver("NonPatronSkin");
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                new ToggleButton(Murder3Buttons, "Pickup Beartraps", null, null, (val) =>
                {
                    if (!Murder3.worldLoaded) return;
                    try
                    {
                        Murder3.pickupweapontoggle = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Murder3.PickupBearTraps());
                            MelonCoroutines.Stop(Murder3.PickupBearTraps());
                        }
                        else
                        {
                            Murder3.DisablePickupBearTraps();
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                new ToggleButton(Murder3Buttons, "Pickup Weapon in Cooldown", "Allows you to pickup every weapon that's in cooldown", "Allows you to pickup every weapon that's in cooldown", (val) =>
                {
                    if (!Murder3.worldLoaded) return;
                    try
                    {
                        Murder3.pickupweapontoggle = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Murder3.PickupWeaponInCooldown());
                        }
                        else
                        {
                            MelonCoroutines.Stop(Murder3.PickupWeaponInCooldown());
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                new ToggleButton(Murder3Buttons, "Clues ESP", null, null, (val) =>
                {
                    if (!Murder3.worldLoaded) return;
                    Murder3.CluesESP = val;
                    if (!val)
                    {
                        foreach (var clue in Resources.FindObjectsOfTypeAll<Renderer>())
                        {
                            if (clue.gameObject.name == "geo" && clue.gameObject.transform.parent.gameObject.name.Contains("Clue"))
                            {
                                ToggleOutline(clue, false);
                            }
                        }
                    }
                }).SetToggleState(false, false);

                new ToggleButton(Murder3Buttons, "Auto TP Detective", "TP to Detective Room when the game starts", "TP to Detective Room when the game starts", (val) =>
                {
                    PatchManager.TPDetective = val;
                }).SetToggleState(false, false);

                #endregion

                #region Ghost

                AnnounceGhost = new ToggleButton(GhostButtons, "Announce Ghosts", "Shows you the Ghosts", "Shows you the Ghosts", (val) =>
                {
                    if (!Ghost.worldLoaded) return;
                    if (val)
                    {
                        PatchManager.AnnounceGhost = true;
                        Create.Ini.SetBool("Toggles", "Ghost", true);
                        MelonCoroutines.Start(Ghost.ShowGhosts());
                    }
                    else
                    {
                        PatchManager.AnnounceGhost = false;
                        Create.Ini.SetBool("Toggles", "Ghost", false);
                    }
                });

                AnnounceGhost.SetToggleState(Create.Ini.GetBool("Toggles", "Ghost"));

                new SingleButton(GhostButtons, "Unlock 5 Keys Door", "Unlocks a Door Next To The Clues Office", () =>
                {
                    if (!Ghost.worldLoaded) return;
                    Ghost.OpenLockedDoor();
                }, false, UnlockIcon);

                new ToggleButton(GhostButtons, "ESP", null, null, (val) =>
                {
                    Ghost.ESPToggle(val);
                }).SetToggleState(false, false);

                #region Fun
                new SimpleSingleButton(GhostButtons, "Fun", "Fun Functions", () =>
                {
                    FunMenu.OpenMenu();
                });

                new SimpleSingleButton(FunButtons, "Give Money To All", "Gives 999 Money To All", () =>
                {
                    if (!Ghost.worldLoaded) return;
                    foreach (var Events in Resources.FindObjectsOfTypeAll<UdonBehaviour>())
                    {
                        if (Events._eventTable.ContainsKey("OnStabKill"))
                        {
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                            Udon.CallUdonEvent(Events, "OnStabKill");
                        }
                    }
                });

                new SimpleSingleButton(FunButtons, "Craft All", "Crafts Every Weapon in the Game", () =>
                {
                    if (!Ghost.worldLoaded) return;
                    Ghost.CraftAll();
                });

                new SimpleSingleButton(FunButtons, "Open All Lockers", "Opens All Lockers on the Map", () =>
                {
                    if (!Ghost.worldLoaded) return;
                    foreach (var Events in Resources.FindObjectsOfTypeAll<UdonBehaviour>())
                    {
                        if (Events._eventTable.ContainsKey("Local_Unlock"))
                        {
                            Udon.CallUdonEvent(Events, "Local_Unlock");
                        }
                    }
                });

                #endregion

                #endregion

                #region AmongUs

                new SimpleSingleButton(AmongUsButtons, "Start Game", "Starts Game", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallUdonEvent("SyncStart");
                });

                #region Endings

                new SimpleSingleButton(AmongUsButtons, "Endings", "Endings Functions", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    EndingsMenu.OpenMenu();
                });

                new SimpleSingleButton(EndingsButtons, "Crewmates\nWin", "Forces Crewmates to win", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallUdonEvent("SyncVictoryC");
                });

                new SimpleSingleButton(EndingsButtons, "Imposters\nWin", "Forces Imposters to win", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallUdonEvent("SyncVictoryI");
                });

                new SimpleSingleButton(EndingsButtons, "Abort Game", "Aborts Game", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallUdonEvent("SyncAbort");
                });

                #endregion

                #region Voting

                new SimpleSingleButton(AmongUsButtons, "Voting", "Fun Functions", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    VotingMenu.OpenMenu();
                });

                new SimpleSingleButton(VotingButtons, "Skip Vote", "Fun Functions", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallUdonEvent("SyncVoteResultSkip");
                    AmongUs.CallUdonEvent("SyncEndVotingPhase");
                });

                #endregion

                #region Sabotages

                new SimpleSingleButton(AmongUsButtons, "Sabotages", "Sabotages", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUsSabotagesMenu.OpenMenu();
                });

                new SimpleSingleButton(AmongUsSabotagesButtons, "Sabotage All Doors", "Sabotages All Doors", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallUdonEvent("SyncDoSabotageDoorsElectrical");
                    AmongUs.CallUdonEvent("SyncDoSabotageDoorsStorage");
                    AmongUs.CallUdonEvent("SyncDoSabotageDoorsSecurity");
                    AmongUs.CallUdonEvent("SyncDoSabotageDoorsLower");
                    AmongUs.CallUdonEvent("SyncDoSabotageDoorsUpper");
                    AmongUs.CallUdonEvent("SyncDoSabotageDoorsMedbay");
                    AmongUs.CallUdonEvent("SyncDoSabotageDoorsCafeteria");
                });

                new SimpleSingleButton(AmongUsSabotagesButtons, "Sabotage All", "Sabotages All", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallUdonEvent("SyncDoSabotageLights");
                    AmongUs.CallUdonEvent("SyncDoSabotageComms");
                    AmongUs.CallUdonEvent("SyncDoSabotageReactor");
                    AmongUs.CallUdonEvent("SyncDoSabotageOxygen");
                });

                new SimpleSingleButton(AmongUsSabotagesButtons, "Sabotage All + Doors", "Sabotages All and doors", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallUdonEvent("SyncDoSabotageDoorsElectrical");
                    AmongUs.CallUdonEvent("SyncDoSabotageDoorsStorage");
                    AmongUs.CallUdonEvent("SyncDoSabotageDoorsSecurity");
                    AmongUs.CallUdonEvent("SyncDoSabotageDoorsLower");
                    AmongUs.CallUdonEvent("SyncDoSabotageDoorsUpper");
                    AmongUs.CallUdonEvent("SyncDoSabotageDoorsMedbay");
                    AmongUs.CallUdonEvent("SyncDoSabotageDoorsCafeteria");
                    AmongUs.CallUdonEvent("SyncDoSabotageLights");
                    AmongUs.CallUdonEvent("SyncDoSabotageComms");
                    AmongUs.CallUdonEvent("SyncDoSabotageReactor");
                    AmongUs.CallUdonEvent("SyncDoSabotageOxygen");
                });

                new SimpleSingleButton(AmongUsSabotagesButtons, "Sabotage Lights", "Sabotage Lights", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallUdonEvent("SyncDoSabotageLights");
                });

                new SimpleSingleButton(AmongUsSabotagesButtons, "Sabotage Comms", "Sabotage Comms", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallUdonEvent("SyncDoSabotageComms");
                });

                new SimpleSingleButton(AmongUsSabotagesButtons, "Sabotage Reactor", "Sabotage Reactor", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallUdonEvent("SyncDoSabotageReactor");
                });

                new SimpleSingleButton(AmongUsSabotagesButtons, "Sabotage Oxygen", "Sabotage Oxygen", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallUdonEvent("SyncDoSabotageOxygen");
                });

                new SimpleSingleButton(AmongUsSabotagesButtons, "Repair All", "Repairs All", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallUdonEvent("CancelAllSabotage");
                });

                #endregion

                new SimpleSingleButton(AmongUsButtons, "Start Admin Scan", "Starts Admin Scan", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallUdonEvent("AdminScan");
                });

                #endregion

                #region Protections

                var ProtectionsIcon = (Environment.CurrentDirectory + "\\Joanpixer\\Protections Icon.png").LoadSpriteFromDisk();

                new SingleButton(MainMenuButtons, "Protections", "Opens Protections Menu", () =>
                {
                    Protections.OpenMenu();
                }, false, ProtectionsIcon);

                new ToggleButton(ProtectionsButtons, "Anti Udon", "Blocks Every Udon Event", "Blocks Every Udon Event", (val) =>
                {
                    PatchManager.AntiUdon = val;
                }).SetToggleState(false, false);

                new ToggleButton(ProtectionsButtons, "Portal Walktrough", "Allows you to walk trough Portals", "Allows you to walk trough Portals", (val) =>
                {
                    PatchManager.PortalWalk = val;
                }).SetToggleState(false, false);

                QuestSpoofOn = new ToggleButton(ProtectionsButtons, "Quest Spoof", "Enable Quest Spoof (requires restart!)", "Disable Quest Spoof (requires restart!)", (val) =>
                {
                    Create.Ini.SetBool("Toggles", "QuestSpoof", val);
                });

                QuestSpoofOn.SetToggleState(PatchManager.QuestSpoof);

                new ToggleButton(ProtectionsButtons, "Log Udon", "Logs all Udon Events onto the MLConsole", "Logs all Udon Events onto the MLConsole", (val) =>
                {
                    PatchManager.LogUdon = val;
                }).SetToggleState(false, false);

                new ToggleButton(ProtectionsButtons, "Log Cheaters", "Logs all client users abusing udon events onto the MLConsole", "Logs all client users abusing udon events onto the MLConsole", (val) =>
                {
                    PatchManager.LogCheaters = val;
                }).SetToggleState(false, false);

                new ToggleButton(ProtectionsButtons, "Log Cheaters Audio", "Plays an Audio every time a log is triggered", "Plays an Audio every time a log is triggered", (val) =>
                {
                    PatchManager.playsound = val;
                }).SetToggleState(false, false);

                new ToggleButton(ProtectionsButtons, "Serialize", "Freezes you for everyone", "Freezes you for everyone", (val) =>
                {
                    PatchManager.serialize = val;
                    FreezeClone();
                });

                new ToggleButton(ProtectionsButtons, "Lock Instance", "Ability to Lock the instance so noone can join", "Ability to Lock the instance so noone can join", (val) =>
                {
                    PatchManager.LockInstance = val;
                });

                #endregion

                #region Pickups

                var PickupsIcon = (Environment.CurrentDirectory + "\\Joanpixer\\pickup.png").LoadSpriteFromDisk();


                new SingleButton(MainMenuButtons, "Pickups", "Opens Pickup Menu", () =>
                {
                    Pickups.OpenMenu();
                }, false, PickupsIcon);

                new ToggleButton(PickupsButtons, "Auto Drop", "Drop Pickups for everyone", "Drop Pickups for everyone", (val) =>
                {
                    try
                    {
                        Items.AutoDropToggle = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Items.AutoDrop());
                        }
                        else
                        {
                            MelonCoroutines.Stop(Items.AutoDrop());
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                new ToggleButton(PickupsButtons, "Thief", "Allows Thief of Pickups", "Allows Thief of Pickups", (val) =>
                {
                    Items.AllowThiefenabled = val;
                    if (val)
                    {
                        Items.AllowThief();
                    }
                    else
                    {
                        Items.DisallowThief();
                    }
                }).SetToggleState(false, false);

                new SimpleSingleButton(PickupsButtons, "Respawn Pickups", null, () =>
                {
                    Items.RespawnPickups();
                });

                #endregion

                var KillSelfIcon = (Environment.CurrentDirectory + "\\Joanpixer\\killself.png").LoadSpriteFromDisk();

                new SingleButton(MainMenuButtons, "Kill Self", "Kill Self with Grenade", () =>
                {
                    try
                    {
                        if (Murder4.worldLoaded)
                        {
                            MelonCoroutines.Start(Murder4.KillLocalPlayerFrag());
                            MelonCoroutines.Stop(Murder4.KillLocalPlayerFrag());
                        }
                        else if (Murder3.worldLoaded)
                        {
                            MelonCoroutines.Start(Murder3.KillLocalPlayerFrag());
                            MelonCoroutines.Stop(Murder3.KillLocalPlayerFrag());
                        }
                    }
                    catch { }
                }, false, KillSelfIcon);

                var GodmodeIcon = (Environment.CurrentDirectory + "\\Joanpixer\\god.png").LoadSpriteFromDisk();

                GodMode = new ToggleButton(MainMenuButtons, "GodMode", "Gives you Immortality", "Gives you Immortality", (val) =>
                {
                    Create.Ini.SetBool("Toggles", "GodMode", val);
                    PatchManager.Godmode = val;
                }, GodmodeIcon, null);

                GodMode.SetToggleState(Create.Ini.GetBool("Toggles", "GodMode"));


                var Movement = new ButtonGroup(mainmenu, "Movement");

                ESP = new ToggleButton(Movement, "ESP", "Allows you to see players through walls", "Allows you to see players through walls", (val) =>
                {
                    Create.Ini.SetBool("Toggles", "ESP", val);
                    if (val)
                    {
                        Features.HighlightsComponent.ESPEnabled = true;
                        Features.HighlightsComponent.ToggleESP(true);
                    }
                    else
                    {
                        Features.HighlightsComponent.ESPEnabled = false;
                        Features.HighlightsComponent.DisableESP();
                    }
                });

                ESP.SetToggleState(Create.Ini.GetBool("Toggles", "ESP"));

                if (!System.IO.File.Exists(Environment.CurrentDirectory + "\\Mods\\AbyssLoader.dll"))
                {
                    Noclip = new ToggleButton(Movement, "Noclip", null, null, (val) =>
                    {
                        if (val)
                        {
                            FlightMod.PlayerExtensions.LocalPlayer.gameObject.GetComponent<CharacterController>().enabled = false;
                            FlightMod.Flight.player = FlightMod.PlayerExtensions.LocalPlayer.gameObject;
                            FlightMod.Flight.flying = true;
                            NoclipOn = true;
                        }
                        else
                        {
                            try
                            {
                                FlightMod.PlayerExtensions.LocalPlayer.gameObject.GetComponent<CharacterController>().enabled = true;
                                FlightMod.Flight.flying = false;
                                NoclipOn = false;
                            }
                            catch
                            {
                            }
                        }
                    });
                    Noclip.SetToggleState(false, false);
                }

                Speedhack = new ToggleButton(Movement, "Speedhack", null, null, (val) =>
                {
                    if (val)
                    {
                        Features.Speedhack.speedEnabled = true;
                    }
                    else
                    {
                        Features.Speedhack.speedEnabled = false;
                    }
                });

                Speedhack.SetToggleState(false, false);

                Jump = new ToggleButton(Movement, "Enable Jump", "Enables Jump in World", "Enables Jump in World", (val) =>
                {
                    Create.Ini.SetBool("Toggles", "Jump", val);
                    EnableJump();
                });

                new ToggleButton(Movement, "Infinite Jump", "Infinite Jump", "Infinite Jump", (val) =>
                {
                    if (val)
                        Features.InfiniteJump.InfJumpEnabled = true;
                    else
                        Features.InfiniteJump.InfJumpEnabled = false;
                });

                Jump.SetToggleState(Create.Ini.GetBool("Toggles", "Jump"));

                new ToggleButton(Movement, "Pickup ESP", "", "", (val) =>
                {
                    if (val)
                    {
                        JoanpixerMain.PickupESP = val;
                    }
                    else
                    {
                        JoanpixerMain.PickupESP = val;
                        Features.HighlightsComponent.PickupESP(false);
                    }
                }).SetToggleState(false, false);

                new JoanpixerButtonAPI.Controls.Slider(mainmenu, "Speedhack Speed", null, (val) =>
                {
                    Features.Speedhack.speedMultiplier = val;
                    FlightMod.Flight.flySpeed = val;
                }, 1, 20, 5);
            };
            while (GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local/ScrollRect/Viewport/VerticalLayoutGroup") == null)
            {
                yield return null;
            }
                #region PlayerOptionsQuickMenu

                Player selectedplayer = null;

                GameObject gameObject = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local/ScrollRect/Viewport/VerticalLayoutGroup");

                var Murder4QuickMenu = new MenuPage("Murder4QuickMenu", "Murder 4", false);

                var Murder4QuickMenuButtons = new ButtonGroup(Murder4QuickMenu, null);

                var Murder3QuickMenu = new MenuPage("Murder3QuickMenu", "Murder 3", false);

                var Murder3QuickMenuButtons = new ButtonGroup(Murder3QuickMenu, null);

                var quickmenuplayeroptions = new ButtonGroup(gameObject.transform, "Joanpixer Client\n");

                var LeashConfig = new MenuPage("LeashConfig", "Leash Config", false);

                var LeashConfigButtons = new ButtonGroup(LeashConfig, null);

                new SimpleSingleButton(quickmenuplayeroptions, "Teleport", "Teleports to player", () =>
                {
                    selectedplayer = GetCurrentlySelectedPlayer();
                    TPLocalPlayer(selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position);
                });

                new SimpleSingleButton(quickmenuplayeroptions, "Fav/UnFav Avatar", "Favorite/Unfavorites avatar", () =>
                {
                    selectedplayer = GetCurrentlySelectedPlayer();
                    if (!AvatarFavs.AvatarObjects.Exists(m => m.id == selectedplayer.prop_ApiAvatar_0.id))
                    {
                        AvatarFavs.FavoriteAvatar(selectedplayer.prop_ApiAvatar_0);
                    }
                    else
                    {
                        AvatarFavs.UnfavoriteAvatar(selectedplayer.prop_ApiAvatar_0);
                    }
                    MelonCoroutines.Start(AvatarFavs.RefreshMenu(1));
                });

                #region Murder4Items

                new SimpleSingleButton(Murder4QuickMenuButtons, "Revolver", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.revolverobject);
                    Murder4Items.revolverobject.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, "Knife", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.knife);
                    Murder4Items.knife.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, "Luger", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.luger);
                    Murder4Items.luger.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, "Shotgun", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.shotgun);
                    Murder4Items.shotgun.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, "Grenade", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.frag);
                    Murder4Items.frag.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, "Smoke Bomb", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.smokebomb);
                    Murder4Items.smokebomb.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, "Bear Trap", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.Beartrap);
                    Murder4Items.Beartrap.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, "Kill Knife", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        var player = selectedplayer;
                        MelonCoroutines.Start(Murder4.KillSelectedPlayerKnife(player));
                        MelonCoroutines.Stop(Murder4.KillSelectedPlayerKnife(player));
                    }
                    catch { }
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, "Kill Frag", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        MelonCoroutines.Start(Murder4.KillSelectedPlayerFrag(selectedplayer));
                        MelonCoroutines.Stop(Murder4.KillSelectedPlayerFrag(selectedplayer));
                    }
                    catch { }
                });

                new ToggleButton(Murder4QuickMenuButtons, "Give Patreon", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        if (val)
                        {
                            Murder4.givepatreon = true;
                            MelonCoroutines.Start(Murder4.GivePatreonTarget(selectedplayer));
                        }
                        else
                        {
                            Player player = null;
                            Murder4.givepatreon = false;
                            MelonCoroutines.Stop(Murder4.GivePatreonTarget(player));
                            Murder4.CallRevolver("NonPatronSkin");
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                new ToggleButton(Murder4QuickMenuButtons, "Auto Kill", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    PatchManager.AutoKill = val;
                    if (val)
                    {
                        PatchManager.player = selectedplayer;
                    }
                    else
                    {
                        PatchManager.player = null;
                    }
                }).SetToggleState(false, false);

                #endregion

                #region Murder3Items

                new SimpleSingleButton(Murder3QuickMenuButtons, "Revolver", null, () =>
                {
                    if (!Murder3.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.revolverobject);
                    Murder4Items.revolverobject.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder3QuickMenuButtons, "Knife", null, () =>
                {
                    if (!Murder3.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.knife);
                    Murder4Items.knife.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder3QuickMenuButtons, "Luger", null, () =>
                {
                    if (!Murder3.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.luger);
                    Murder4Items.luger.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder3QuickMenuButtons, "Shotgun", null, () =>
                {
                    if (!Murder3.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.shotgun);
                    Murder4Items.shotgun.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder3QuickMenuButtons, "Grenade", null, () =>
                {
                    if (!Murder3.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.frag);
                    Murder4Items.frag.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder3QuickMenuButtons, "Smoke Bomb", null, () =>
                {
                    if (!Murder3.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.smokebomb);
                    Murder4Items.smokebomb.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder3QuickMenuButtons, "Bear Trap", null, () =>
                {
                    if (!Murder3.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.Beartrap);
                    Murder4Items.Beartrap.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder3QuickMenuButtons, "Kill Knife", null, () =>
                {
                    if (!Murder3.worldLoaded) return;
                    try
                    {
                        var player = selectedplayer;
                        MelonCoroutines.Start(Murder3.KillSelectedPlayerKnife(player));
                        MelonCoroutines.Stop(Murder3.KillSelectedPlayerKnife(player));
                    }
                    catch { }
                });

                new SimpleSingleButton(Murder3QuickMenuButtons, "Kill Frag", null, () =>
                {
                    if (!Murder3.worldLoaded) return;
                    try
                    {
                        MelonCoroutines.Start(Murder3.KillSelectedPlayerFrag(selectedplayer));
                        MelonCoroutines.Stop(Murder3.KillSelectedPlayerFrag(selectedplayer));
                    }
                    catch { }
                });

                new ToggleButton(Murder3QuickMenuButtons, "Give Patreon", null, null, (val) =>
                {
                    if (!Murder3.worldLoaded) return;
                    try
                    {
                        if (val)
                        {
                            Murder3.givepatreon = true;
                            MelonCoroutines.Start(Murder3.GivePatreonTarget(selectedplayer));
                        }
                        else
                        {
                            Player player = null;
                            Murder3.givepatreon = false;
                            MelonCoroutines.Stop(Murder3.GivePatreonTarget(player));
                            Murder3.CallRevolver("NonPatronSkin");
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                new ToggleButton(Murder3QuickMenuButtons, "Auto Kill", null, null, (val) =>
                {
                    if (!Murder3.worldLoaded) return;
                    PatchManager.AutoKill = val;
                    if (val)
                    {
                        PatchManager.player = selectedplayer;
                    }
                    else
                    {
                        PatchManager.player = null;
                    }
                }).SetToggleState(false, false);

                #endregion

                var Murder4Icon = (Environment.CurrentDirectory + "\\Joanpixer\\knife.png").LoadSpriteFromDisk();

                new SimpleSingleButton(quickmenuplayeroptions, "TP Pickups", "TP all pickups to the target", () =>
                {
                    selectedplayer = GetCurrentlySelectedPlayer();
                    Items.ItemsToPlayer(selectedplayer);
                });

                new SingleButton(quickmenuplayeroptions, "World Hacks", "Open World Target Options", () =>
                {
                    selectedplayer = GetCurrentlySelectedPlayer();
                    if (Murder4.worldLoaded)
                    {
                        Murder4QuickMenu.OpenMenu();
                        Murder4QuickMenu.SetTitle(selectedplayer.prop_VRCPlayerApi_0.displayName);
                    }
                    if (!Murder3.worldLoaded) return;
                    Murder3QuickMenu.OpenMenu();
                    Murder3QuickMenu.SetTitle(selectedplayer.prop_VRCPlayerApi_0.displayName);
                }, false, Murder4Icon);

                new ToggleButton(quickmenuplayeroptions, "Leash", "Leashes to the target", "Leashes to the target", (val) =>
                {
                    target = GetCurrentlySelectedPlayer().field_Private_VRCPlayerApi_0;
                    Leashing = val;
                });

                new SimpleSingleButton(quickmenuplayeroptions, "Leash Config", null, () =>
                {
                    LeashConfig.OpenMenu();
                });

                new SimpleSingleButton(LeashConfigButtons, "+ Distance", null, () =>
                {
                    var CurrentValue = Create.Ini.GetFloat("Values", "Leash Distance");
                    Create.Ini.SetFloat("Values", "Leash Distance", CurrentValue + 0.1f);
                    distance = CurrentValue + 0.1f;
                    LeashValue.SetText($"Current Value:\n {Create.Ini.GetFloat("Values", "Leash Distance")}");
                });

                new SimpleSingleButton(LeashConfigButtons, "- Distance", null, () =>
                {
                    var CurrentValue = Create.Ini.GetFloat("Values", "Leash Distance");
                    Create.Ini.SetFloat("Values", "Leash Distance", CurrentValue - 0.1f);
                    distance = CurrentValue - 0.1f;
                    LeashValue.SetText($"Current Value:\n {Create.Ini.GetFloat("Values", "Leash Distance")}");
                });

                LeashValue = new SimpleSingleButton(LeashConfigButtons, $"Current Value:\n {Create.Ini.GetFloat("Values", "Leash Distance")}", null, () => { });

                LeashValue.SetInteractable(false);

                new SimpleSingleButton(quickmenuplayeroptions, "Download VRCA", null, () =>
                {
                    selectedplayer = GetCurrentlySelectedPlayer();
                    Features.VRCA.DownloadVRCA(selectedplayer.prop_ApiAvatar_0, selectedplayer.prop_ApiAvatar_0.imageUrl);
                });

                #endregion
            yield break;
        }

        public static void OnUpdate()
        {
            if (!PatchManager.loggedin) return;

            if (Input.GetKeyDown(KeyCode.X))
            {
                if (SpeedOn)
                {
                    Speedhack.SetToggleState(false, false);
                    SpeedOn = false;
                    Features.Speedhack.speedEnabled = false;
                }
                else
                {
                    Speedhack.SetToggleState(true, false);
                    SpeedOn = true;
                    Features.Speedhack.speedEnabled = true;
                }
            }
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyUp(KeyCode.F) && !System.IO.File.Exists(Environment.CurrentDirectory + "\\Mods\\AbyssLoader.dll"))
            {
                if (NoclipOn)
                {
                    Noclip.SetToggleState(false, false);
                    FlightMod.PlayerExtensions.LocalPlayer.gameObject.GetComponent<CharacterController>().enabled = true;
                    FlightMod.Flight.player = FlightMod.PlayerExtensions.LocalPlayer.gameObject;
                    FlightMod.Flight.flying = false;
                    NoclipOn = false;
                }
                else
                {
                    FlightMod.PlayerExtensions.LocalPlayer.gameObject.GetComponent<CharacterController>().enabled = false;
                    FlightMod.Flight.player = FlightMod.PlayerExtensions.LocalPlayer.gameObject;
                    FlightMod.Flight.flying = true;
                    Noclip.SetToggleState(true, false);
                    NoclipOn = true;
                }
            }
        }

        public static void FreezeClone()
        {
            #region AntiDecompiler
            long goAwaySkid = long.Parse("2173162573851") ^ -3912879949001785344 >> 31 ^ 8794626273696546816 << 8 ^ 4994409697730625536 >> 25 ^ -7968319096167071744 ^ 4263824930518335488 << 6 ^ 5253580846375370752 ^ -3805541685128069120 ^ -6026324156323004416 ^ 2029226408462057472 ^ -2340264320232849408 ^ 7215611027977666560 << 4 ^ 4439690367340943360 ^ 890134321443110912 >> 31 << 5 ^ 0 ^ -2145479602233933824 ^ 1146788289491174656 >> 19 << 31 >> 26 << 31 >> 7 >> 7 << 14 ^ 3405718575338487808 >> 22 >> 7 >> 13 >> 11 << 12 >> 31 << 3 >> 9 >> 17 ^ 3141488709031690240 ^ 131423948578488320 ^ 6897167334979010560 << 27 ^ 6016527627190272000 ^ -6972949015494792192 ^ 7638104968020361216 ^ -4579247970414755840 >> 14 ^ 0 << 11 ^ 0 ^ 695638256452108288 >> 8 >> 19 >> 15 ^ -6584825605169086464 << 25 >> 30 << 17 ^ 9013673179205337088 >> 31 >> 24 >> 21 >> 32 >> 11 ^ 3008893349651283968 ^ 2756779452779200512 ^ 0 ^ 6903561931433443328 >> 7 ^ 5789194802054561792 ^ 6843358927213006848 ^ 7462635006855217152 ^ 9064584750869512192 << 16 ^ 5262040435689022464 ^ 9142242913160986624 >> 15 >> 28 ^ 0 ^ 144115188075855872 << 4 ^ 2774679889878350592 << 25 << 28 >> 31 ^ 4683743612465315840 >> 12 >> 27 ^ 0 >> 22 << 19 ^ -7600548949350416384 >> 31 << 28 >> 13 ^ 5269837186139684864 ^ 6309115084337577984 ^ 2709714619600994304 ^ 7717912134182843392 << 5 << 17 >> 5 >> 31 << 27 ^ 6989586621679009792 ^ -6711817999881338880 << 11 << 16 ^ 6340292020128448512 ^ -4276730796141707264 ^ -6786001544839371008 ^ 0 >> 31 << 26 >> 2 << 19 ^ 2971217901396164608 >> 3 ^ 0 >> 12 >> 1 >> 5 >> 28 << 14 ^ -5941371953334321152 ^ 6412755534562197504 << 10 << 13 ^ 1252848252370288640 ^ 0 << 13 ^ 6052837899185946624 ^ -3575858104132173824 ^ 4855322020326866944 ^ 7535059157594931200 >> 24 << 20 ^ 7854382203738783744 << 22 ^ 2245891613723197440 ^ -8745643619089645568 ^ 2161727821137838080 << 12 >> 18 ^ 9083552640708640768 ^ 1542276792461557760 >> 28 << 24 << 23 >> 11 ^ 5095810605253815552 ^ 0 ^ 0 << 16 << 14 >> 1 << 1 ^ 8891539358872502272 >> 7 << 10 >> 18 << 23 << 20 >> 14 >> 19 << 1 << 16 ^ 7803049304372805632 >> 23 ^ 5353166111911837696 ^ 6196953087261802496 << 8 ^ 3049521405000417280 ^ 7061644215716937728 << 11 ^ 5961640006731694080 >> 14 >> 30 ^ 8273213962607132672 >> 9 ^ 395171076092461056 >> 7 ^ -5294346872083026176 << 25 >> 17 ^ 5693468600249876480 ^ 6350356949569110016 >> 6 ^ 8688138641484021760 ^ 6630790751364055040 >> 20 ^ 2030279007013961728 << 15 >> 19 ^ -2830512365802356736 ^ 2766754452885401344 >> 8 ^ -3957787628547342336 >> 29 << 10 << 25 << 30 << 27 >> 0 >> 30 ^ 5476377146882523136 ^ 5093800441897025536 ^ 8618682521099436032 << 1 ^ 7320319719314030592 << 30 >> 22 ^ 5999388523453480960 ^ -4820348036611833856 << 5 >> 24 << 28 ^ -956875970034270208 << 27 >> 31 ^ 4022040966360727552 ^ 1729382256910270464 >> 26 >> 17 ^ 1504778545845774336 ^ 1202175639801561088 << 26 >> 9 << 24 ^ -8515242394525958144 ^ 7145078456567463936 >> 0 ^ 5042185502631919616 ^ 4662833004248825856 ^ -6989586621679009792 << 10 << 28 ^ 0 >> 29 ^ 5107530578182275072 ^ 3667263436463472640 << 10 << 13 ^ 8142508126285856768 ^ 5277092863371378688 << 26 ^ 0 >> 26 ^ 8460655154191985152 ^ 6794244409962528768 << 1 ^ 7493989779944505344 ^ 2900599635003310080 << 6 ^ 4080867776204374016 ^ 0 ^ 0 >> 22 << 14 ^ 7790490682560348160 ^ 2571551751991721984 >> 15 ^ -5332261958806667264 << 21 >> 22 ^ 8062816738980397056 >> 4 << 11 ^ -2704087903848308992 >> 15 ^ 8286623314361712640 << 27 >> 29 << 6 ^ 7332423143312588800 ^ 6983957122144796672 << 29 >> 25 >> 9 << 17 ^ 279607675254210560 << 16 << 3 ^ 2982464872760999936 << 20 ^ 5260485839745449984 ^ 2229813289800433664 << 11 ^ 7215679041737588736 >> 29 ^ 0 << 21 << 6 << 11 << 27 >> 17 << 27 ^ 70087269200953344 >> 3 ^ 3746994889972252672 << 13 << 21 ^ 0 ^ -1152921504606846976 >> 3 << 6 ^ 8094804714803167232 ^ 1201600406275227648 >> 5 << 22 ^ 5959837524921679872 >> 5 ^ 0 << 31 ^ 64598326680027136 >> 0 << 7 ^ 3923735310870642688 ^ 7803893729302937600 ^ 8839964527688155136 >> 21 << 9 << 31 ^ 6149095358512925184 << 6 ^ 4450344719821761536 >> 3 >> 6 >> 9 << 0 << 24 >> 22 << 24 << 16 << 31 ^ 2888777685981462528 << 19 ^ 2172423870252843008 << 24 >> 25 << 20 ^ 2630588939617959936 ^ 0 ^ 311846303627608064 >> 25 ^ -8164546050000804096 >> 32 >> 13 >> 16 >> 13 ^ 2377900603251621888 ^ 6783485291240357888 ^ 4883583005617591296 ^ -1969587995336835072 >> 29 ^ 5727898801279205376 ^ 1152921504606846976 ^ 3299432959106744320 ^ 2500231167446351872 >> 19 << 32 >> 12 ^ 4165446338076475392 ^ 7421932185906577408 << 12 << 13 ^ -6708111644968353792 ^ 4899916394579099648 << 20 ^ 4374183503561097216 ^ -5154398360827854848 << 29 ^ 5984400584872108288 ^ 0 >> 3 >> 30 ^ 1944506104931155968 ^ -8556839292003942400 ^ -8523625244752084992 ^ 0 ^ 4667136588839387136 << 4 << 25 << 1 >> 25 >> 4 ^ 0 ^ 0 >> 29 ^ -818772333166198784 >> 3 ^ 1945555039024054272 >> 10 ^ 648518346341351424 << 4 << 24 >> 1 >> 0 << 25 ^ 0 >> 0 << 20 ^ 4179340454199820288 ^ 8809040871136690176 ^ 0 ^ 3032387098708541440 >> 12 >> 13 ^ 6771853155483892480 << 23 >> 31 ^ 5005469510845595648 << 13 >> 18 ^ 2428457247408390144 >> 0 ^ 58974724088135680 << 8 << 29 ^ 6547440901419958272 ^ -8718968878589280256 << 31 ^ 0 ^ 8378718859275796480 >> 6 ^ 7387805544003665920 << 13 ^ 3549014420661075968 << 13 ^ 2458683921567580160 >> 26 >> 22 << 14 << 20 ^ 0 << 10 << 16 ^ -8546673436703850496 ^ 0 ^ 6153392900521590784 ^ 2025998749963801088 ^ 3901806127163113472 ^ 7566047373982433280 ^ 3026418949592973312 ^ -1637459926619565056 ^ 902179760939936256 << 0 >> 13 >> 16 ^ -1156580679304085504 >> 25 ^ 5345323057433018368 << 10 << 13 >> 18 ^ 7854277750134145024 ^ -8358680908399640576 << 4 ^ 4215497533301981184 ^ -1727951792282533888 >> 3 ^ 7026631367442038784 ^ 3878183544473583616 ^ -6812843387394195456 ^ 4730186983622574080 ^ 1758265791652389376 ^ 5786249064085061632 << 27 ^ 4953166842223919104 ^ 2043789805896073216 ^ 946910408956968960 << 26 >> 1 << 19 ^ 2000685395414614016 >> 21 << 16 >> 10 >> 19 >> 30 << 16 >> 29 >> 13 ^ 1629237183997018112 ^ 457380344480399360 << 27 >> 2 ^ 6057507896053202944 ^ -6022704000615317504 << 16 << 27 << 31 << 16 ^ -2017612633061982208 >> 31 << 14 >> 13 ^ 6989586621679009792 ^ 7063972981344567296 >> 11 >> 7 ^ 1528885212073689088 ^ 3674937295934324736 << 32 >> 0 << 16 ^ 9181700546162065408 << 15 << 6 ^ 932689193308520448 ^ 3421762817799539456 << 27 ^ 8600779433697083392 ^ 931394272664485888 << 23 << 31 ^ 2659375579962277888 ^ 7544862860111773696 << 29 ^ 7566047373982433280 >> 18 ^ 974490595726917632 << 23 << 30 >> 6 >> 26 ^ 6943424725498462208 >> 18 << 20 ^ 4107282860161892352 ^ 0 ^ -4117697434300186624 >> 2 ^ 3450673274535012352 >> 12 << 22 ^ 5708723669978000640 << 5 >> 26 << 24 >> 11 ^ 4569184657501847552 >> 4 ^ 6340319664903553024 ^ 1902430712897530368 ^ 0 << 11 ^ 3054246489380356096 ^ -8502796096475496448 >> 27 ^ 7019011178535154944 << 9 ^ 8604684626385960960 >> 13 ^ -506889355919360000 ^ -4098128227564781568 ^ 8584095183673491456 ^ 4683743612465315840 << 9 ^ 9097314039216055040 << 27 >> 6 << 27 >> 15 ^ 4094557964630097920 ^ 3544103280609067008 ^ 0 >> 14 ^ 7007459627767955456 >> 27 << 15 >> 27 ^ -2933944628392493056 ^ 2089670227099910144 << 17 >> 22 << 0 >> 4 ^ 2575935012624924672 << 13 ^ 8142508126285856768 ^ -5208934122758144000 >> 19 << 5 << 3 >> 10 ^ 1611421151924322304 ^ -8918899510332751872 ^ -2161727821137838080 << 4 << 32 >> 32 ^ 945165649762451456 << 5 >> 2 ^ 362258295026614272 >> 16 << 21 ^ -1886209865282486272 ^ 2481611774607228928 ^ -4610841593497255936 >> 3 << 22 >> 25 >> 8 << 10 >> 4 << 19 ^ -8153684352778108928 << 6 >> 31 ^ 2550837464098164992 ^ 2521171366397345792 ^ -7208292678583189504 ^ 0 ^ 0 >> 32 << 6 >> 13 ^ 5116089176692883456 >> 26 >> 1 ^ -2515566150608224256 ^ -6944550625405304832 << 10 ^ 7875412476743909376 ^ 0 >> 22 >> 12 ^ 414756676718034944 >> 27 >> 25 ^ 234372536853069824 ^ 0 ^ 7133701809754865664 << 30 ^ 275564002199732224 << 28 << 32 << 29 ^ -6500890165223021312 << 0 ^ 0 ^ 688769268010975232 << 0 ^ 6441309565031022592 ^ -6958645245360120576 >> 26 ^ 2984763223625302016 ^ 7789285423670362112 ^ -1843942572431507456 >> 28 ^ -6946316783670263808 ^ 6891287831795073024 << 0 >> 28 ^ -7250736839250100992 ^ 210110620459073536 ^ 8557139021319962624 << 2 >> 16 >> 32 << 8 << 2 ^ 2874422462169219072 ^ -5856632329836953600 ^ 4611686018427387904 ^ 8950297888549634048 ^ 0 ^ 4936023198374297600 ^ 2446348582219939840 >> 6 ^ -3689660856141873152 >> 26 ^ 4443082507377704960 ^ -7766406894989606912 << 28 ^ -5619446959279439872 ^ -433189989157699584 >> 29 ^ -4375209654595092480 ^ -3274440232761556992 << 6 ^ 3989383137585987584 >> 0 ^ 3830579896219336704 ^ 0 ^ 835684320705249280 ^ 6703759813849776128 >> 27 << 27 ^ 1205671226610024448 << 8 ^ 6859937708089802752 ^ 6326150101571993600 << 15 ^ -8821559239490456320 >> 29 << 5 ^ 2872372972495044608 ^ 0 << 25 ^ 1290376970483269632 ^ 7005979240537522176 >> 12 << 21 ^ -2377900603251621888 ^ 260927303410778112 >> 20 ^ 4574039609704448000 << 15 << 18 ^ 175659716893802496 << 4 ^ 0 ^ 3230071351396204544 ^ 738569333587662848 ^ -2738188573441261568 ^ 2115710141580430080 ^ 681377138941887744 << 0 >> 9 ^ 5675905934704705536 ^ 6424870990022443008 >> 22 ^ 3819052484010180608 >> 23 ^ 5183431927431954432 ^ 2254333088475643904 ^ 5295882417578442752 << 2 ^ 3882657500246638592 >> 13 >> 1 >> 18 << 7 >> 7 ^ 7738221052615720960 ^ 7551869171542261760 ^ -4250999496747515904 ^ -7133701809754865664 ^ 5216596634099515392 ^ 216153758093017088 ^ 3888382945613840384 << 24 ^ 644486790379470848 ^ 4875991021558693888 >> 19 ^ 2203386117691015168 ^ 5749652107350376448 << 4 ^ 3358453270065446912 >> 5 << 28 ^ 8741190008586633216 ^ 6227375816044314624 ^ 5447668468240933120 ^ 0 >> 10 >> 27 << 3 ^ 7417622935708501504 >> 25 ^ -9066553134481932288 ^ 2181638752651182080 ^ 688860978447646720;
            #endregion

            try
            {
                if (PatchManager.serialize)
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
            catch{}
        }

        public static bool Leashing;
        public static VRCPlayerApi target;
        public static float distance = Create.Ini.GetFloat("Values", "Leash Distance");
        public static void Leash()
        {
            if (!target.gameObject) return;
            if (CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position.x >
                target.gameObject.transform.position.x + distance + 5)
            {
                CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position = target.gameObject.transform.position + new Vector3(distance, 0, 0);
            }
            if (CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position.x <
                target.gameObject.transform.position.x - distance - 5)
            {
                CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position = target.gameObject.transform.position + new Vector3(-distance, 0, 0);
            }
            if (CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position.z >
                target.gameObject.transform.position.z + distance + 0.5 + 5)
            {
                CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position = target.gameObject.transform.position + new Vector3(0, 0, distance + 0.5f);
            }
            if (CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position.z <
                target.gameObject.transform.position.z - distance - 0.5 - 5)
            {
                CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position = target.gameObject.transform.position + new Vector3(0, 0, -distance + 0.5f);
            }

            if (CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position.x >
                target.gameObject.transform.position.x + distance)
            {
                CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position = Vector3.Lerp(CurrentUser.field_Private_VRCPlayerApi_0.GetPosition(), target.gameObject.transform.position + new Vector3(distance, 0, 0), 0.05f);
            }
            if (CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position.x <
                    target.gameObject.transform.position.x - distance)
            {
                CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position = Vector3.Lerp(CurrentUser.field_Private_VRCPlayerApi_0.GetPosition(), target.gameObject.transform.position + new Vector3(-distance, 0, 0), 0.05f);
            }
            if (CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position.z >
                target.gameObject.transform.position.z + distance + 0.5)
            {
                CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position = Vector3.Lerp(CurrentUser.field_Private_VRCPlayerApi_0.GetPosition(), target.gameObject.transform.position + new Vector3(0, 0, distance + 0.5f), 0.05f);
            }
            if (CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position.z <
                target.gameObject.transform.position.z - distance + 0.5)
            {
                CurrentUser.field_Private_VRCPlayerApi_0.gameObject.transform.position = Vector3.Lerp(CurrentUser.field_Private_VRCPlayerApi_0.GetPosition(), target.gameObject.transform.position + new Vector3(0, 0, -distance + 0.5f), 0.05f);
            }
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
                    Networking.LocalPlayer.SetJumpImpulse(4);
                }
            }
            catch{}
        }

        public static bool IsWorldLoaded => Resources.FindObjectsOfTypeAll<VRC_SceneDescriptor>() != null;

        public static Vector3 TPLocalPlayer(Vector3 position)
        {
            return CurrentUser.transform.position = position;
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

        internal static Player GetPlayerFromIDInLobby(string id)
        {
            Il2CppSystem.Collections.Generic.List<Player> all_player = GetAllPlayers();

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

        public static IEnumerator Notification(string Text, Color color)
        {
            var hudRoot = GameObject.Find("UserInterface/UnscaledUI/HudContent/Hud");
            var requestedParent = hudRoot.transform.Find("NotificationDotParent");
            var indicator = UnityEngine.Object.Instantiate(hudRoot.transform.Find("NotificationDotParent/NotificationDot").gameObject, requestedParent, false).Cast<GameObject>();
            indicator.name = "NotifyDot-" + "Murderer";
            indicator.GetComponent<Image>().enabled = false;
            indicator.SetActive(true);
            indicator.transform.localPosition += Vector3.right * 200;
            var gameObject = new GameObject(indicator.gameObject.name + "-text");
            gameObject.AddComponent<Text>();
            gameObject.transform.SetParent(indicator.transform, false);
            gameObject.transform.localScale = Vector3.one;
            gameObject.transform.localPosition = Vector3.up * 400;
            var text = gameObject.GetComponent<Text>();
            text.color = Color.white;
            text.fontStyle = FontStyle.Bold;
            text.horizontalOverflow = HorizontalWrapMode.Overflow;
            text.verticalOverflow = VerticalWrapMode.Overflow;
            text.alignment = TextAnchor.MiddleCenter;
            text.fontSize = 34;
            text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            text.supportRichText = true;
            text.color = color;
            gameObject.SetActive(true);
            text.text = Text;
            MelonCoroutines.Start(FadeTextToFullAlpha(2, text));
            yield return new WaitForSeconds(3);
            MelonCoroutines.Start(FadeTextToZeroAlpha(4, text));
            yield return new WaitForSeconds(5);
            UnityEngine.Object.Destroy(indicator);
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
        
    }
}
