using System;
using System.Linq;
using ForbiddenButtonAPI;
using ForbiddenButtonAPI.Controls;
using ForbiddenButtonAPI.Controls.Grouping;
using ForbiddenButtonAPI.Pages;
using ForbiddenClient.API;
using ForbiddenClient.Features.Worlds;
using ForbiddenClient.FoldersManager;
using MelonLoader;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.Udon;
using ForbiddenClient.Modules;
using ForbiddenClient.Features;
using System.Threading.Tasks;
using VRC.UI.Core.Styles;
using System.Threading;
using VRC.Core;
using ForbiddenButtonAPI.Misc;
using VRC.UI.Elements.Menus;
using ForbiddenButtonAPI.External_Libraries;

namespace ForbiddenClient
{
    internal class MenuUI
    {

        //internal static ForbiddenButtonAPI.Controls.Slider RedColour;
        //internal static ForbiddenButtonAPI.Controls.Slider GreenColour;
        //internal static ForbiddenButtonAPI.Controls.Slider BlueColour;
        //internal static SimpleSingleButton ApplyUiColour;
        //internal static SimpleSingleButton ResetUIColour;
        //internal static Transform awa;
        internal static ToggleButton Noclip;
        internal static ToggleButton Speedhack;
        private static ToggleButton Murderer4;
        private static ToggleButton CrateESPPrison;
        private static ToggleButton ESPPrison;
        private static ToggleButton ChangeStatus;
        private static ToggleButton AntiVoteOut;
        private static ToggleButton AntiBlock;
        private static ToggleButton PreventAvatarChange;
        private static ToggleButton PatronSelfMurder;
        private static ToggleButton PatronSelfPrisonGold;
        private static ToggleButton IrrblossSongVersion1;
        private static ToggleButton IrrblossSongVersion2;
        private static ToggleButton PatronSelfPrisonGreen;
        private static ToggleButton PatronSelfPrisonBlue;
        private static ToggleButton PatronSelfPrisonPurple;
        private static ToggleButton PatronSelfPrisonRed;
        private static ToggleButton PatronSelfPrisonRainbow;
        private static ToggleButton DoorsOffButton;
        internal static ToggleButton Headlight;
        private static ToggleButton Laser;
        private static ToggleButton AntiTheftuwu;
        internal static ToggleButton ButterKnife;
        private static ToggleButton WeaponsInCooldown;
        private static ToggleButton GodMode;
        private static ToggleButton CluesESP;
        private static ToggleButton PickupBeartrapsButton;
        private static ToggleButton ESP;
        public static SingleButton WorldHacks;
        public static SingleButton WorldHacksPlayer;
        public static SimpleSingleButton GiveOneShotPrisonEscape;
        private static ToggleButton Murderer3;
        private static ToggleButton AnnounceImposters;
        private static ToggleButton LogKills;
        private static ToggleButton OneClickOpenDoor;
        private static ToggleButton AnnounceGhost;
        internal static ToggleButton Aimbot;
        internal static SimpleSingleButton PatronList;
        internal static SimpleSingleButton PrivatePrisonEscapeStuff;
        internal static SimpleSingleButton Touch;
        internal static SingleButton KillSelf;
        internal static ToggleButton TouchMurderer;
        internal static ToggleButton NoCooldownGuns;
        internal static ToggleButton TouchBystander;
        internal static ToggleButton LogCheatersa;
        internal static ToggleButton Audio;
        internal static ToggleButton HUD;
        internal static ToggleButton TouchVoteOut;
        internal static ToggleButton TouchDetective;
        internal static ToggleButton TouchFlash;
        internal static ToggleButton Snake;
        private static ToggleButton TouchKill;
        internal static ToggleButton TouchCooldown;
        internal static ToggleButton TouchGrenade;
        internal static ToggleButton TouchClues;
        internal static ToggleButton TouchBeartrap;
        private static ToggleButton Jump;
        internal static string touchsystoggle = string.Empty;
        internal static bool NoclipOn;
        internal static bool givepatreon;
        internal static bool cached;
        internal static Transform UdonTransform;
        internal static bool SpeedOn;

        public static IEnumerator MenuCreate()
        {
            #region AntiDecompiler
            long uwu = long.Parse("2173162573851") ^ -3912879949001785344 >> 31 ^ 8794626273696546816 << 8 ^ 4994409697730625536 >> 25 ^ -7968319096167071744 ^ 4263824930518335488 << 6 ^ 5253580846375370752 ^ -3805541685128069120 ^ -6026324156323004416 ^ 2029226408462057472 ^ -2340264320232849408 ^ 7215611027977666560 << 4 ^ 4439690367340943360 ^ 890134321443110912 >> 31 << 5 ^ 0 ^ -2145479602233933824 ^ 1146788289491174656 >> 19 << 31 >> 26 << 31 >> 7 >> 7 << 14 ^ 3405718575338487808 >> 22 >> 7 >> 13 >> 11 << 12 >> 31 << 3 >> 9 >> 17 ^ 3141488709031690240 ^ 131423948578488320 ^ 6897167334979010560 << 27 ^ 6016527627190272000 ^ -6972949015494792192 ^ 7638104968020361216 ^ -4579247970414755840 >> 14 ^ 0 << 11 ^ 0 ^ 695638256452108288 >> 8 >> 19 >> 15 ^ -6584825605169086464 << 25 >> 30 << 17 ^ 9013673179205337088 >> 31 >> 24 >> 21 >> 32 >> 11 ^ 3008893349651283968 ^ 2756779452779200512 ^ 0 ^ 6903561931433443328 >> 7 ^ 5789194802054561792 ^ 6843358927213006848 ^ 7462635006855217152 ^ 9064584750869512192 << 16 ^ 5262040435689022464 ^ 9142242913160986624 >> 15 >> 28 ^ 0 ^ 144115188075855872 << 4 ^ 2774679889878350592 << 25 << 28 >> 31 ^ 4683743612465315840 >> 12 >> 27 ^ 0 >> 22 << 19 ^ -7600548949350416384 >> 31 << 28 >> 13 ^ 5269837186139684864 ^ 6309115084337577984 ^ 2709714619600994304 ^ 7717912134182843392 << 5 << 17 >> 5 >> 31 << 27 ^ 6989586621679009792 ^ -6711817999881338880 << 11 << 16 ^ 6340292020128448512 ^ -4276730796141707264 ^ -6786001544839371008 ^ 0 >> 31 << 26 >> 2 << 19 ^ 2971217901396164608 >> 3 ^ 0 >> 12 >> 1 >> 5 >> 28 << 14 ^ -5941371953334321152 ^ 6412755534562197504 << 10 << 13 ^ 1252848252370288640 ^ 0 << 13 ^ 6052837899185946624 ^ -3575858104132173824 ^ 4855322020326866944 ^ 7535059157594931200 >> 24 << 20 ^ 7854382203738783744 << 22 ^ 2245891613723197440 ^ -8745643619089645568 ^ 2161727821137838080 << 12 >> 18 ^ 9083552640708640768 ^ 1542276792461557760 >> 28 << 24 << 23 >> 11 ^ 5095810605253815552 ^ 0 ^ 0 << 16 << 14 >> 1 << 1 ^ 8891539358872502272 >> 7 << 10 >> 18 << 23 << 20 >> 14 >> 19 << 1 << 16 ^ 7803049304372805632 >> 23 ^ 5353166111911837696 ^ 6196953087261802496 << 8 ^ 3049521405000417280 ^ 7061644215716937728 << 11 ^ 5961640006731694080 >> 14 >> 30 ^ 8273213962607132672 >> 9 ^ 395171076092461056 >> 7 ^ -5294346872083026176 << 25 >> 17 ^ 5693468600249876480 ^ 6350356949569110016 >> 6 ^ 8688138641484021760 ^ 6630790751364055040 >> 20 ^ 2030279007013961728 << 15 >> 19 ^ -2830512365802356736 ^ 2766754452885401344 >> 8 ^ -3957787628547342336 >> 29 << 10 << 25 << 30 << 27 >> 0 >> 30 ^ 5476377146882523136 ^ 5093800441897025536 ^ 8618682521099436032 << 1 ^ 7320319719314030592 << 30 >> 22 ^ 5999388523453480960 ^ -4820348036611833856 << 5 >> 24 << 28 ^ -956875970034270208 << 27 >> 31 ^ 4022040966360727552 ^ 1729382256910270464 >> 26 >> 17 ^ 1504778545845774336 ^ 1202175639801561088 << 26 >> 9 << 24 ^ -8515242394525958144 ^ 7145078456567463936 >> 0 ^ 5042185502631919616 ^ 4662833004248825856 ^ -6989586621679009792 << 10 << 28 ^ 0 >> 29 ^ 5107530578182275072 ^ 3667263436463472640 << 10 << 13 ^ 8142508126285856768 ^ 5277092863371378688 << 26 ^ 0 >> 26 ^ 8460655154191985152 ^ 6794244409962528768 << 1 ^ 7493989779944505344 ^ 2900599635003310080 << 6 ^ 4080867776204374016 ^ 0 ^ 0 >> 22 << 14 ^ 7790490682560348160 ^ 2571551751991721984 >> 15 ^ -5332261958806667264 << 21 >> 22 ^ 8062816738980397056 >> 4 << 11 ^ -2704087903848308992 >> 15 ^ 8286623314361712640 << 27 >> 29 << 6 ^ 7332423143312588800 ^ 6983957122144796672 << 29 >> 25 >> 9 << 17 ^ 279607675254210560 << 16 << 3 ^ 2982464872760999936 << 20 ^ 5260485839745449984 ^ 2229813289800433664 << 11 ^ 7215679041737588736 >> 29 ^ 0 << 21 << 6 << 11 << 27 >> 17 << 27 ^ 70087269200953344 >> 3 ^ 3746994889972252672 << 13 << 21 ^ 0 ^ -1152921504606846976 >> 3 << 6 ^ 8094804714803167232 ^ 1201600406275227648 >> 5 << 22 ^ 5959837524921679872 >> 5 ^ 0 << 31 ^ 64598326680027136 >> 0 << 7 ^ 3923735310870642688 ^ 7803893729302937600 ^ 8839964527688155136 >> 21 << 9 << 31 ^ 6149095358512925184 << 6 ^ 4450344719821761536 >> 3 >> 6 >> 9 << 0 << 24 >> 22 << 24 << 16 << 31 ^ 2888777685981462528 << 19 ^ 2172423870252843008 << 24 >> 25 << 20 ^ 2630588939617959936 ^ 0 ^ 311846303627608064 >> 25 ^ -8164546050000804096 >> 32 >> 13 >> 16 >> 13 ^ 2377900603251621888 ^ 6783485291240357888 ^ 4883583005617591296 ^ -1969587995336835072 >> 29 ^ 5727898801279205376 ^ 1152921504606846976 ^ 3299432959106744320 ^ 2500231167446351872 >> 19 << 32 >> 12 ^ 4165446338076475392 ^ 7421932185906577408 << 12 << 13 ^ -6708111644968353792 ^ 4899916394579099648 << 20 ^ 4374183503561097216 ^ -5154398360827854848 << 29 ^ 5984400584872108288 ^ 0 >> 3 >> 30 ^ 1944506104931155968 ^ -8556839292003942400 ^ -8523625244752084992 ^ 0 ^ 4667136588839387136 << 4 << 25 << 1 >> 25 >> 4 ^ 0 ^ 0 >> 29 ^ -818772333166198784 >> 3 ^ 1945555039024054272 >> 10 ^ 648518346341351424 << 4 << 24 >> 1 >> 0 << 25 ^ 0 >> 0 << 20 ^ 4179340454199820288 ^ 8809040871136690176 ^ 0 ^ 3032387098708541440 >> 12 >> 13 ^ 6771853155483892480 << 23 >> 31 ^ 5005469510845595648 << 13 >> 18 ^ 2428457247408390144 >> 0 ^ 58974724088135680 << 8 << 29 ^ 6547440901419958272 ^ -8718968878589280256 << 31 ^ 0 ^ 8378718859275796480 >> 6 ^ 7387805544003665920 << 13 ^ 3549014420661075968 << 13 ^ 2458683921567580160 >> 26 >> 22 << 14 << 20 ^ 0 << 10 << 16 ^ -8546673436703850496 ^ 0 ^ 6153392900521590784 ^ 2025998749963801088 ^ 3901806127163113472 ^ 7566047373982433280 ^ 3026418949592973312 ^ -1637459926619565056 ^ 902179760939936256 << 0 >> 13 >> 16 ^ -1156580679304085504 >> 25 ^ 5345323057433018368 << 10 << 13 >> 18 ^ 7854277750134145024 ^ -8358680908399640576 << 4 ^ 4215497533301981184 ^ -1727951792282533888 >> 3 ^ 7026631367442038784 ^ 3878183544473583616 ^ -6812843387394195456 ^ 4730186983622574080 ^ 1758265791652389376 ^ 5786249064085061632 << 27 ^ 4953166842223919104 ^ 2043789805896073216 ^ 946910408956968960 << 26 >> 1 << 19 ^ 2000685395414614016 >> 21 << 16 >> 10 >> 19 >> 30 << 16 >> 29 >> 13 ^ 1629237183997018112 ^ 457380344480399360 << 27 >> 2 ^ 6057507896053202944 ^ -6022704000615317504 << 16 << 27 << 31 << 16 ^ -2017612633061982208 >> 31 << 14 >> 13 ^ 6989586621679009792 ^ 7063972981344567296 >> 11 >> 7 ^ 1528885212073689088 ^ 3674937295934324736 << 32 >> 0 << 16 ^ 9181700546162065408 << 15 << 6 ^ 932689193308520448 ^ 3421762817799539456 << 27 ^ 8600779433697083392 ^ 931394272664485888 << 23 << 31 ^ 2659375579962277888 ^ 7544862860111773696 << 29 ^ 7566047373982433280 >> 18 ^ 974490595726917632 << 23 << 30 >> 6 >> 26 ^ 6943424725498462208 >> 18 << 20 ^ 4107282860161892352 ^ 0 ^ -4117697434300186624 >> 2 ^ 3450673274535012352 >> 12 << 22 ^ 5708723669978000640 << 5 >> 26 << 24 >> 11 ^ 4569184657501847552 >> 4 ^ 6340319664903553024 ^ 1902430712897530368 ^ 0 << 11 ^ 3054246489380356096 ^ -8502796096475496448 >> 27 ^ 7019011178535154944 << 9 ^ 8604684626385960960 >> 13 ^ -506889355919360000 ^ -4098128227564781568 ^ 8584095183673491456 ^ 4683743612465315840 << 9 ^ 9097314039216055040 << 27 >> 6 << 27 >> 15 ^ 4094557964630097920 ^ 3544103280609067008 ^ 0 >> 14 ^ 7007459627767955456 >> 27 << 15 >> 27 ^ -2933944628392493056 ^ 2089670227099910144 << 17 >> 22 << 0 >> 4 ^ 2575935012624924672 << 13 ^ 8142508126285856768 ^ -5208934122758144000 >> 19 << 5 << 3 >> 10 ^ 1611421151924322304 ^ -8918899510332751872 ^ -2161727821137838080 << 4 << 32 >> 32 ^ 945165649762451456 << 5 >> 2 ^ 362258295026614272 >> 16 << 21 ^ -1886209865282486272 ^ 2481611774607228928 ^ -4610841593497255936 >> 3 << 22 >> 25 >> 8 << 10 >> 4 << 19 ^ -8153684352778108928 << 6 >> 31 ^ 2550837464098164992 ^ 2521171366397345792 ^ -7208292678583189504 ^ 0 ^ 0 >> 32 << 6 >> 13 ^ 5116089176692883456 >> 26 >> 1 ^ -2515566150608224256 ^ -6944550625405304832 << 10 ^ 7875412476743909376 ^ 0 >> 22 >> 12 ^ 414756676718034944 >> 27 >> 25 ^ 234372536853069824 ^ 0 ^ 7133701809754865664 << 30 ^ 275564002199732224 << 28 << 32 << 29 ^ -6500890165223021312 << 0 ^ 0 ^ 688769268010975232 << 0 ^ 6441309565031022592 ^ -6958645245360120576 >> 26 ^ 2984763223625302016 ^ 7789285423670362112 ^ -1843942572431507456 >> 28 ^ -6946316783670263808 ^ 6891287831795073024 << 0 >> 28 ^ -7250736839250100992 ^ 210110620459073536 ^ 8557139021319962624 << 2 >> 16 >> 32 << 8 << 2 ^ 2874422462169219072 ^ -5856632329836953600 ^ 4611686018427387904 ^ 8950297888549634048 ^ 0 ^ 4936023198374297600 ^ 2446348582219939840 >> 6 ^ -3689660856141873152 >> 26 ^ 4443082507377704960 ^ -7766406894989606912 << 28 ^ -5619446959279439872 ^ -433189989157699584 >> 29 ^ -4375209654595092480 ^ -3274440232761556992 << 6 ^ 3989383137585987584 >> 0 ^ 3830579896219336704 ^ 0 ^ 835684320705249280 ^ 6703759813849776128 >> 27 << 27 ^ 1205671226610024448 << 8 ^ 6859937708089802752 ^ 6326150101571993600 << 15 ^ -8821559239490456320 >> 29 << 5 ^ 2872372972495044608 ^ 0 << 25 ^ 1290376970483269632 ^ 7005979240537522176 >> 12 << 21 ^ -2377900603251621888 ^ 260927303410778112 >> 20 ^ 4574039609704448000 << 15 << 18 ^ 175659716893802496 << 4 ^ 0 ^ 3230071351396204544 ^ 738569333587662848 ^ -2738188573441261568 ^ 2115710141580430080 ^ 681377138941887744 << 0 >> 9 ^ 5675905934704705536 ^ 6424870990022443008 >> 22 ^ 3819052484010180608 >> 23 ^ 5183431927431954432 ^ 2254333088475643904 ^ 5295882417578442752 << 2 ^ 3882657500246638592 >> 13 >> 1 >> 18 << 7 >> 7 ^ 7738221052615720960 ^ 7551869171542261760 ^ -4250999496747515904 ^ -7133701809754865664 ^ 5216596634099515392 ^ 216153758093017088 ^ 3888382945613840384 << 24 ^ 644486790379470848 ^ 4875991021558693888 >> 19 ^ 2203386117691015168 ^ 5749652107350376448 << 4 ^ 3358453270065446912 >> 5 << 28 ^ 8741190008586633216 ^ 6227375816044314624 ^ 5447668468240933120 ^ 0 >> 10 >> 27 << 3 ^ 7417622935708501504 >> 25 ^ -9066553134481932288 ^ 2181638752651182080 ^ 688860978447646720;
            #endregion
            ButtonAPI.OnInit += () =>
            {
                #region Menus

                //Menus
                var mainmenu = MenuPage.CreatePage("MainMenu", "Forbidden Client", true, false);

                new Tab(mainmenu, "Forbidden Client", ForbiddenMain.ButtonImage);

                #region Main Menu
                var MainMenuButtons = mainmenu.AddButtonGroup("World");

                var UdonEventsMenu = MenuPage.CreatePage("UdonEvents", "Udon Events", false);

                var Miscellaneous = mainmenu.AddButtonGroup("Miscellaneous");

                var PlayerMenu = MenuPage.CreatePage("Player", "Local Player", false);

                var PlayerMenuLocal = PlayerMenu.AddButtonGroup("Local");

                var PlayerMenuMovement = PlayerMenu.AddButtonGroup("Movement");

                var UdonEventsButtons = UdonEventsMenu.AddButtonGroup(null);

                var UdonEventMenu = MenuPage.CreatePage("Event", null, false);

                var UdonEventButtons = UdonEventMenu.AddButtonGroup(null);

                #region Protections

                var Protections = MenuPage.CreatePage("Protections", "Protections", false);
                var ProtectionsButtons = Protections.AddButtonGroup(null);

                var LogCheaters = MenuPage.CreatePage("LogCheaters", "Log Cheaters", false);
                var LogCheatersButtons = LogCheaters.AddButtonGroup(null);

                #endregion

                var TouchSystemMenu = MenuPage.CreatePage("TouchSystem", "Touch System", false);
                var TouchSystemButtons = TouchSystemMenu.AddButtonGroup(null);

                var Pickups = MenuPage.CreatePage("Pickups", "Pickups", false);
                var PickupsButtons = Pickups.AddButtonGroup(null);
                var PickupsLag = MenuPage.CreatePage("Pickups Exploits", "PickupsExp", false);
                var PickupsLagButtons = PickupsLag.AddButtonGroup(null);

                #endregion

                #region JustBClub

                var JustBClubMenu = MenuPage.CreatePage("JustBClub", "Just B Club", false);

                var JustBClubButtons = JustBClubMenu.AddButtonGroup(null);

                var JustBClubRoomsMenu = MenuPage.CreatePage("JustBClubRooms", "Just B Club Rooms", false);

                var JustBClubRoomsButtons = JustBClubRoomsMenu.AddButtonGroup(null);

                #endregion

                #region Murder4

                var Murder4Menu = MenuPage.CreatePage("Murder4", "Murder 4", false);

                var Murder4Buttons = Murder4Menu.AddButtonGroup(null);

                var Murder4Pickups = MenuPage.CreatePage("Murder4Pickups", "Murder 4 Pickups", false);

                var Murder4PickupsButtons = Murder4Pickups.AddButtonGroup(null);

                var Murder4Patron = MenuPage.CreatePage("Murder4Patron", "Murder 4 Patrons", false);

                var Murder4PatronButtons = Murder4Patron.AddButtonGroup(null);

                var annoy = MenuPage.CreatePage("Annoy", "Annoy Functions", false);

                var annoybuttons = annoy.AddButtonGroup(null);

                var ending = MenuPage.CreatePage("Endings", "End Game Functions", false);

                var endingbuttons = ending.AddButtonGroup(null);

                var teleportsmurder4 = MenuPage.CreatePage("TeleportsM4", "Locations Menu", false);

                var teleportsmurder4buttons = teleportsmurder4.AddButtonGroup(null);

                #endregion

                //#region Settings

                //var SettingsMenu = MenuPage.CreatePage("Settings", "Settings", false);

                //var SettingsMenuButtons = SettingsMenu.AddButtonGroup(null);

                //var UIMenu = MenuPage.CreatePage("UI", "UI Settings", false);

                //var UIMenuButtons = UIMenu.AddButtonGroup(null);


                //var UIColour = MenuPage.CreatePage("UIColour", "UI Colour", false);

                //var UIColourButtons = UIColour.AddButtonGroup(null);

                //#endregion

                #region Ghost

                var GhostMenu = MenuPage.CreatePage("Ghost", "Ghost", false);

                var GhostButtons = GhostMenu.AddButtonGroup(null);

                var FunMenu = MenuPage.CreatePage("Fun", "Ghost Fun", false);

                var FunButtons = FunMenu.AddButtonGroup(null);

                #endregion

                #region AmongUs

                var AmongUsMenu = MenuPage.CreatePage("AmongUs", "Among Us", false);

                var AmongUsButtons = AmongUsMenu.AddButtonGroup(null);

                var EndingsMenu = MenuPage.CreatePage("EndingsAmong Us", "Among Us", false);

                var EndingsButtons = EndingsMenu.AddButtonGroup(null);

                var AmongUsSabotagesMenu = MenuPage.CreatePage("AmongUsSabotages", "Sabotages", false);

                var AmongUsSabotagesButtons = AmongUsSabotagesMenu.AddButtonGroup(null);

                var VotingMenu = MenuPage.CreatePage("Voting", "Voting Functions", false);

                var VotingButtons = VotingMenu.AddButtonGroup(null);

                #endregion

                #region Murder3

                var Murder3Menu = MenuPage.CreatePage("Murder3", "Murder 3", false);

                var Murder3Buttons = Murder3Menu.AddButtonGroup(null);

                var annoy3 = MenuPage.CreatePage("Annoy3", "Annoy Functions", false);

                var annoy3buttons = annoy3.AddButtonGroup(null);

                #endregion

                #region Prison Escape

                var PrisonMenu = MenuPage.CreatePage("PrisonEscape", "Prison Escape", false);

                var PrisonButtons = PrisonMenu.AddButtonGroup(null);

                var PrisonPatronMenu = MenuPage.CreatePage("PrisonEscapePatron", "Patreon Colours", false);

                var PrisonPatronButtons = PrisonPatronMenu.AddButtonGroup(null);

                var PrisonTpMenu = MenuPage.CreatePage("Teleports", "Prison Tp", false);

                var PrisonTpButtons = PrisonTpMenu.AddButtonGroup(null);

                var PrisonPrivStuffMenu = MenuPage.CreatePage("PrisonEscapePatr3on", "Private Stuff", false);

                var PrisonPrivStuffButtons = PrisonPrivStuffMenu.AddButtonGroup(null);

                var PrisonMoneyMenu = MenuPage.CreatePage("PrisonEscapeMny", "Money", false);

                var PrisonMoneyButtons = PrisonMoneyMenu.AddButtonGroup(null);

                var PrisonWantedMenu = MenuPage.CreatePage("PrisonEscapeWanted", "Get Wanted", false);

                var PrisonWantedButtons = PrisonWantedMenu.AddButtonGroup(null);

                #endregion

                #region Fate of the Irrbloss

                var IrrblossMenu = MenuPage.CreatePage("FateoftheIrrbloss", "Fate of the Irrbloss", false);

                var IrrblossButtons = IrrblossMenu.AddButtonGroup(null);

                var IrrblossPreGameMenu = MenuPage.CreatePage("FateoftheIrrblossPreGame", "Pregame", false);

                var IrrblossPreGameButtons = IrrblossPreGameMenu.AddButtonGroup(null);

                var IrrblossInGameMenu = MenuPage.CreatePage("FateoftheIrrblossInGame", "InGame", false);

                var IrrblossInGameButtons = IrrblossInGameMenu.AddButtonGroup(null);

                var IrrblossInGameShipMenu = MenuPage.CreatePage("FateoftheIrrblossInGameShip", "Ship", false);

                var IrrblossInGameShipButtons = IrrblossInGameShipMenu.AddButtonGroup(null);

                var IrrblossInGameUpgradesMenu = MenuPage.CreatePage("FateoftheIrrblossInGameUpgrades", "Upgrades", false);

                var IrrblossInGameUpgradesButtons = IrrblossInGameUpgradesMenu.AddButtonGroup(null);

                var IrrblossInGameDoorsMenu = MenuPage.CreatePage("FateoftheIrrblossInGameDoors", "Doors", false);

                var IrrblossInGameDoorsButtons = IrrblossInGameDoorsMenu.AddButtonGroup(null);

                var IrrblossInGameEnemyShipMenu = MenuPage.CreatePage("FateoftheIrrblossInGameEnemyShip", "Enemy Ship", false);

                var IrrblossInGameEnemyShipButtons = IrrblossInGameEnemyShipMenu.AddButtonGroup(null);

                var IrrblossMusicMenu = MenuPage.CreatePage("FateoftheIrrblossMusic", "Music", false);

                var IrrblossMusicButtons = IrrblossMusicMenu.AddButtonGroup(null);

                #endregion

                #region Ghost

                var InfestedMenu = MenuPage.CreatePage("Infection", "Infection", false);

                var InfestedButtons = InfestedMenu.AddButtonGroup(null);

                #endregion

                #endregion
                var block = ForbiddenClient.Resources.IconsVars.blockicon.LoadSprite();
                WorldHacks = MainMenuButtons.AddSingleButton("Worlds Hacks", "Opens Worlds Exploits Menu", () =>
                {
                    if (Murder4.worldLoaded)
                        Murder4Menu.OpenMenu();
                    else if (Just_B_Club.worldLoaded)
                        JustBClubMenu.OpenMenu();
                    else if (Ghost.worldLoaded)
                        GhostMenu.OpenMenu();
                    else if (Murder3.worldLoaded)
                        Murder3Menu.OpenMenu();
                    else if (AmongUs.worldLoaded)
                        AmongUsMenu.OpenMenu();
                    else if (Prison.worldLoaded)
                        PrisonMenu.OpenMenu();
                    else if (FateOfTheIrrbloss.worldLoaded)
                        IrrblossMenu.OpenMenu();
                    else if (Infested.worldLoaded)
                        InfestedMenu.OpenMenu();
                    else if (ForbiddenMain.Devs.Contains(APIUser.CurrentUser.id) || APIUser.CurrentUser.id == "usr_2f003553-45a4-4d6e-878b-3ab9a7aff207")
                        Utils.Notification("Available Worlds: Murder 3/4, Among Us, Ghost, \nJust B Club, Prison Escape and Fate Of The Irrbloss", Color.green);
                    else
                        Utils.Notification("Available Worlds: Murder 3/4, Among Us, Ghost, \nJust B Club and Prison Escape", Color.green);
                }, true, block);

                #region Murder4

                Murderer4 = Murder4Buttons.AddToggleButton("Announce Murderer", "Shows you the Murderer", "Shows you the Murderer", (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    Create.Ini.SetBool("Murder4", "AnnounceMurderer", val);
                    if (val)
                    {
                        try
                        {
                            foreach (var uwu in PatchManager.Murderers.Keys)
                            {
                                MelonCoroutines.Start(Utils.MurdererNameplate(Utils.GetPlayerFromNameInLobby(uwu)));
                            }
                        }
                        catch {}
                        Features.ESP.CheckMurdererESP();
                        PatchManager.AnnounceMurderer4 = true;
                        Create.Ini.SetBool("Murder4", "AnnounceMurderer", true);
                        if (PatchManager.Murderers.Count != 0)
                        {
                            if (PatchManager.Murderers.Count == 1)
                            {
                                Utils.Notification($"Murderer: {String.Join("", PatchManager.Murderers.Keys)}", Color.red);
                                Utils.ConsoleLog(Utils.ConsoleLogType.Msg, $"Murderer: {String.Join("", PatchManager.Murderers.Keys)}", ConsoleColor.Red);
                            }
                            else
                            {
                                Utils.Notification($"Murderers: {String.Join(", ", PatchManager.Murderers.Keys)}", Color.red);
                                Utils.ConsoleLog(Utils.ConsoleLogType.Msg, $"Murderers: {String.Join(", ", PatchManager.Murderers.Keys)}", ConsoleColor.Red);
                            }
                        }
                    }
                    else
                    {
                        PatchManager.AnnounceMurderer4 = false;
                        foreach (var murderer in PatchManager.Murderers.Values)
                        {
                            try
                            {
                                UnityEngine.Object.DestroyImmediate(murderer.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Imposter Nameplate").gameObject);
                            }
                            catch { }
                        }
                        Create.Ini.SetBool("Murder4", "AnnounceMurderer", false);
                    }
                });

                Murderer4.SetToggleState(Create.Ini.GetBool("Murder4", "AnnounceMurderer"));

                var UnlockIcon = ForbiddenClient.Resources.IconsVars.Unlock.LoadSprite();

                Murder4Buttons.AddSimpleSingleButton( "Start Game", "Forces Start Game", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.CallGameLogic("SyncStart");
                });

                Murder4Buttons.AddSimpleSingleButton( "Endings", "Open Endings of the game", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    ending.OpenMenu();
                }, true);

                endingbuttons.AddSimpleSingleButton("Bystanders Win", "Forces Bystanders to win", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        MelonCoroutines.Start(Murder4.BWin());
                    }
                    catch { }
                });

                endingbuttons.AddSimpleSingleButton("Murderer Win", "Forces Murderer to win", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.CallGameLogic("SyncVictoryM");
                });

                endingbuttons.AddSimpleSingleButton("Abort Game", "Aborts Game", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.CallGameLogic("SyncAbort");
                });

                Murder4Buttons.AddSingleButton("Unlock Doors", "Unlocks all doors", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.UnLockDoors();
                }, false, UnlockIcon);

                var DoorsOffIcon = ForbiddenClient.Resources.IconsVars.DoorsOff.LoadSprite();

                DoorsOffButton = Murder4Buttons.AddToggleButton("Doors Off", "Disable Doors", "Enable Doors", (val) =>
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

                #region Pickups
                Murder4Buttons.AddSingleButton("Pickups", null, () =>
                {
                    Murder4Pickups.OpenMenu();
                }, true, ForbiddenClient.Resources.IconsVars.pickups.LoadSprite());

                WeaponsInCooldown = Murder4PickupsButtons.AddToggleButton("Pickup Weapon in Cooldown", "Allows you to pickup every weapon that's in cooldown", "Allows you to pickup every weapon that's in cooldown", (val) =>
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
                    }
                    catch { }
                });

                WeaponsInCooldown.SetToggleState(Create.Ini.GetBool("Murder4", "WeaponsInCooldown"));

                PickupBeartrapsButton = Murder4PickupsButtons.AddToggleButton("Pickup Beartraps", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        Create.Ini.SetBool("Murder4", "PickupBeartraps", val);
                        if (val)
                        {
                            MelonCoroutines.Start(Murder4.PickupBearTraps());
                        }
                        else
                        {
                            Murder4.DisablePickupBearTraps();
                        }
                    }
                    catch { }
                });

                PickupBeartrapsButton.SetToggleState(Create.Ini.GetBool("Murder4", "PickupBeartraps"));
                #endregion

                Murder4Buttons.AddSimpleSingleButton( "Lights On", "Turns Lights On", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.TurnLightsOn();
                });

                #region Annoy
                Murder4Buttons.AddSimpleSingleButton("Annoy", "Annoy Functions", () =>
                {
                    annoy.OpenMenu();
                }, true);

                annoybuttons.AddToggleButton("Lock Doors", "Enable Door Lock", "Disable Door Lock", (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        Murder4.doorlock = val;
                        if (val)
                        {
                            Murder4.LockDoors();
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                annoybuttons.AddToggleButton("Lock Drawers", "Enable Drawers Lock", "Disable Drawers Lock", (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        Murder4.lockdrawers = val;
                        if (val)
                        {
                            Murder4.LockDrawers();
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                annoybuttons.AddToggleButton("Spam Revolver", "Enable Revolver Spam", "Disable Revolver Spam", (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        Murder4.revolverspam = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Murder4.Fire());
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                annoybuttons.AddToggleButton("Lights Off", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        Murder4.lightsoff = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Murder4.TurnLightsOff());
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                annoybuttons.AddToggleButton("Spam sounds", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        Murder4.spamsounds = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Murder4.SpamSounds(0));
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                annoybuttons.AddToggleButton("Walking Bomb", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    PatchManager.WalkingBomb = val;
                    try
                    {
                        if (val)
                        {
                            MelonCoroutines.Start(Murder4.WalkingBomb());
                        }
                    }
                    catch { }
                }).SetToggleState(false, false);

                #endregion

                PatronSelfMurder = Murder4Buttons.AddToggleButton("Patreon Self", null, null, (val) =>
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

                Murder4Buttons.AddToggleButton("Disable Patreon", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    try
                    {
                        Murder4.disablepatreon = val;
                        if (val)
                        {
                            MelonCoroutines.Start(Murder4.DisablePatreon());
                        }
                        else
                        {
                            MelonCoroutines.Stop(Murder4.DisablePatreon());
                        }
                    }
                    catch { }
                });

                PatronSelfMurder.SetToggleState(Create.Ini.GetBool("Murder4", "PatreonSelf"));

                #region Teleports

                Murder4Buttons.AddSimpleSingleButton( "Teleport Locations", null, () =>
                {
                    teleportsmurder4.OpenMenu();
                }, true);

                teleportsmurder4buttons.AddSimpleSingleButton("Kitchen", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-20.8f, 0, 121.6f));
                });

                teleportsmurder4buttons.AddSimpleSingleButton("Lounge", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-15.9f, 0, 130.1f));
                });

                teleportsmurder4buttons.AddSimpleSingleButton("Dining Room", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-11.3f, 0, 119.2f));
                });

                teleportsmurder4buttons.AddSimpleSingleButton("Grand Hall", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(0.6f, 0, 116.4f));
                });

                teleportsmurder4buttons.AddSimpleSingleButton("Library", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(12.2f, 0, 119.7f));
                });

                teleportsmurder4buttons.AddSimpleSingleButton("Piano", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(15.9f, 0, 131.5f));
                });

                teleportsmurder4buttons.AddSimpleSingleButton("Garage", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(17.3f, 0, 140.4f));
                });

                teleportsmurder4buttons.AddSimpleSingleButton("Outside", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(2.8f, 0, 140.5f));
                });

                teleportsmurder4buttons.AddSimpleSingleButton("Conservatory", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-0.4f, 0, 146));
                });

                teleportsmurder4buttons.AddSimpleSingleButton("Billard", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-14.7f, 0, 140.2f));
                });

                teleportsmurder4buttons.AddSimpleSingleButton("Cellar", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-2.1f, -3, 130.8f));
                });

                teleportsmurder4buttons.AddSimpleSingleButton("Bedroom", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-9.9f, 3.6f, 129.2f));
                });

                teleportsmurder4buttons.AddSimpleSingleButton("Detective Room", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(5, 3, 122.8f));
                });

                teleportsmurder4buttons.AddSimpleSingleButton("Bathroom", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-0.4f, 3, 133.4f));
                });

                teleportsmurder4buttons.AddSimpleSingleButton("Closet", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(0.4673f, 2.995f, 124.234f));
                });

                #endregion

                CluesESP = Murder4Buttons.AddToggleButton("Clues ESP", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.CluesESP = val;
                    Create.Ini.SetBool("Murder4", "CluesESP", val);
                    if (!val)
                    {
                        foreach (var clue in Murder4.Clues)
                        {
                            Features.ESP._cluesHighlights.Method_Public_Void_Renderer_Boolean_0(clue, false);
                        }
                    }
                });

                CluesESP.SetToggleState(Create.Ini.GetBool("Murder4", "CluesESP"));

                Murder4Buttons.AddToggleButton("Auto TP Detective Room", "TP to Detective Room when the game starts", "TP to Detective Room when the game starts", (val) =>
                {
                    PatchManager.TPDetective = val;
                }).SetToggleState(false, false);

                Laser = Murder4Buttons.AddToggleButton("Revolver Laser Sight", "Toggles Laser Sight", "Toggles Laser Sight", (val) =>
                {
                    Create.Ini.SetBool("Murder4", "LaserSight", val);
                    Murder4.LaserSight = val;
                    GameObject.Find("Game Logic/Weapons/Revolver/Recoil Anim/Recoil/Laser Sight").active = val;
                });

                Laser.SetToggleState(Create.Ini.GetBool("Murder4", "LaserSight"));

                Murder4Buttons.AddToggleButton("Anti Set Role Exploit", "Avoids Set Role Exploit", "Avoids Set Role Exploit", (val) =>
                {
                    PatchManager.AntiSetRoleExploit = val;
                }).SetToggleState(true, true);

                NoCooldownGuns = Murder4Buttons.AddToggleButton("No Cooldown", "Allows you to shoot any gun with no delay", "Allows you to shoot any gun with no delay", (val) =>
                {
                    Murder4.nocooldown = val;
                    Create.Ini.SetBool("Murder4", "NoCooldown", val);
                    if (val)
                    {
                        MelonCoroutines.Start(Murder4.NoCooldown());
                    }
                });

                NoCooldownGuns.SetToggleState(Create.Ini.GetBool("Murder4", "NoCooldown"));

                Snake = Murder4Buttons.AddToggleButton("Auto Dispense Snake", "Dispenses Snake when being the murderer", "Dispenses Snake when being the murderer", (val) =>
                {
                    PatchManager.snake = val;
                    Create.Ini.SetBool("Murder4", "Snake", val);
                });

                Snake.SetToggleState(Create.Ini.GetBool("Murder4", "Snake"));

                OneClickOpenDoor = Murder4Buttons.AddToggleButton("One Click Open Door", "Open Doors with one Click", "Open Doors with one Click", (val) =>
                {
                    PatchManager.OneClickDoor = val;
                    Create.Ini.SetBool("Murder4", "OneClickOpen", val);
                });

                OneClickOpenDoor.SetToggleState(Create.Ini.GetBool("Murder4", "OneClickOpen"));

                #endregion

                #region Murder3

                Murderer3 = Murder3Buttons.AddToggleButton("Announce Murderer", "Shows you the Murderer", "Shows you the Murderer", (val) =>
                {
                    if (!Murder3.worldLoaded) return;
                    if (val)
                    {
                        Features.ESP.CheckMurdererESP();
                        PatchManager.AnnounceMurderer3 = true;
                        Create.Ini.SetBool("Toggles", "Murder3", true);
                        var Murderer = $"Murderer is {Murder3.MurderText.GetComponent<Text>().m_Text}";
                        Utils.Notification(Murderer, Color.red);
                    }
                    else
                    {
                        PatchManager.AnnounceMurderer3 = false;
                        Create.Ini.SetBool("Toggles", "Murder3", false);
                    }
                });

                Murderer3.SetToggleState(Create.Ini.GetBool("Toggles", "Murder3"));

                Murder3Buttons.AddSimpleSingleButton("Bystanders Win", "Forces Bystanders to win", () =>
                {
                    if (!Murder3.worldLoaded) return;
                    try
                    {
                        MelonCoroutines.Start(Murder3.BWin());
                        MelonCoroutines.Stop(Murder3.BWin());
                    }
                    catch { }
                });

                Murder3Buttons.AddSimpleSingleButton("Murderer Win", "Forces Murderer to win", () =>
                {
                    if (!Murder3.worldLoaded) return;
                    Murder3.CallGameLogic("SyncVictoryM");
                });

                Murder3Buttons.AddSimpleSingleButton("Abort Game", "Aborts Game", () =>
                {
                    if (!Murder3.worldLoaded) return;
                    Murder4.CallGameLogic("SyncAbort");
                });

                #region Annoy
                Murder3Buttons.AddSimpleSingleButton("Annoy", "Annoy Functions", () =>
                {
                    annoy3.OpenMenu();
                }, true);

                annoy3buttons.AddToggleButton("Spam Revolver", "Enable Revolver Spam", "Disable Revolver Spam", (val) =>
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

                annoy3buttons.AddToggleButton("Spam sounds", null, null, (val) =>
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

                Murder3Buttons.AddToggleButton("Patreon Self", null, null, (val) =>
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

                Murder3Buttons.AddToggleButton("Pickup Beartraps", null, null, (val) =>
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

                Murder3Buttons.AddToggleButton("Pickup Weapon in Cooldown", "Allows you to pickup every weapon that's in cooldown", "Allows you to pickup every weapon that's in cooldown", (val) =>
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

                Murder3Buttons.AddToggleButton("Clues ESP", null, null, (val) =>
                {
                    if (!Murder3.worldLoaded) return;
                    Murder3.CluesESP = val;
                    if (!val)
                    {
                        foreach (var clue in UnityEngine.Resources.FindObjectsOfTypeAll<Renderer>())
                        {
                            if (clue.gameObject.name == "geo" && clue.gameObject.transform.parent.gameObject.name.Contains("Clue"))
                            {
                                Utils.ToggleOutline(clue, false);
                            }
                        }
                    }
                }).SetToggleState(false, false);

                Murder3Buttons.AddToggleButton("Auto TP Detective", "TP to Detective Room when the game starts", "TP to Detective Room when the game starts", (val) =>
                {
                    PatchManager.TPDetective = val;
                }).SetToggleState(false, false);

                #endregion

                #region Ghost

                AnnounceGhost = GhostButtons.AddToggleButton("Announce Ghosts", "Shows you the Ghosts", "Shows you the Ghosts", (val) =>
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

                GhostButtons.AddSingleButton("Unlock 5 Keys Door", "Unlocks a Door Next To The Clues Office", () =>
                {
                    if (!Ghost.worldLoaded) return;
                    Ghost.OpenLockedDoor();
                }, false, UnlockIcon);

                GhostButtons.AddToggleButton("ESP", null, null, (val) =>
                {
                    Ghost.ESPToggle(val);
                }).SetToggleState(false, false);

                #region Fun
                GhostButtons.AddSimpleSingleButton("Fun", "Fun Functions", () =>
                {
                    FunMenu.OpenMenu();
                }, true);

                FunButtons.AddSimpleSingleButton("Give Money To All", "Gives 999 Money To All", () =>
                {
                    if (!Ghost.worldLoaded) return;
                    foreach (var Events in UnityEngine.Resources.FindObjectsOfTypeAll<UdonBehaviour>())
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

                FunButtons.AddSimpleSingleButton("Craft All", "Crafts Every Weapon in the Game", () =>
                {
                    if (!Ghost.worldLoaded) return;
                    Ghost.CraftAll();
                });

                FunButtons.AddSimpleSingleButton("Open All Lockers", "Opens All Lockers on the Map", () =>
                {
                    if (!Ghost.worldLoaded) return;
                    foreach (var Events in UnityEngine.Resources.FindObjectsOfTypeAll<UdonBehaviour>())
                    {
                        if (Events._eventTable.ContainsKey("Local_Unlock"))
                        {
                            Udon.CallUdonEvent(Events, "Local_Unlock");
                        }
                    }
                });

                #endregion

                #endregion

                #region Infested

                InfestedButtons.AddSimpleSingleButton("Get Money", "Get all money in the map", () =>
                {
                    if (!Infested.worldLoaded) return;
                    Infested.GetMoney();
                });

                #endregion

                #region AmongUs

                AnnounceImposters = AmongUsButtons.AddToggleButton("Announce Imposters", null, null, (val) =>
                {
                    foreach (var uwu in PatchManager.Imposters.Keys)
                    {
                        MelonCoroutines.Start(Utils.ImposterNameplate(Utils.GetPlayerFromNameInLobby(uwu)));
                    }
                    MelonCoroutines.Start(PatchManager.ShowImposters());
                    PatchManager.AnnounceImposters = val;
                    Create.Ini.SetBool("AmongUs", "AnnounceImposters", val);
                    if (!val)
                    {
                        foreach (var uwu in Utils.GetAllPlayers())
                        {
                            try
                            {
                                UnityEngine.Object.DestroyImmediate(uwu.field_Private_VRCPlayerApi_0.gameObject.transform.Find("Player Nameplate/Canvas/Nameplate/Contents/Imposter Nameplate").gameObject);
                            }
                            catch { }
                        }
                    }
                });

                AnnounceImposters.SetToggleState(Create.Ini.GetBool("AmongUs", "AnnounceImposters"), false);

                AmongUsButtons.AddSimpleSingleButton("Start Game", "Starts Game", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallGameLogic("SyncStart");
                });

                #region Endings

                AmongUsButtons.AddSimpleSingleButton("Endings", "Endings Functions", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    EndingsMenu.OpenMenu();
                }, true);

                EndingsButtons.AddSimpleSingleButton("Crewmates\nWin", "Forces Crewmates to win", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallGameLogic("SyncVictoryC");
                });

                EndingsButtons.AddSimpleSingleButton("Imposters\nWin", "Forces Imposters to win", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallGameLogic("SyncVictoryI");
                });

                EndingsButtons.AddSimpleSingleButton("Abort Game", "Aborts Game", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallGameLogic("SyncAbort");
                });

                #endregion

                #region Voting

                AmongUsButtons.AddSimpleSingleButton("Voting", "Fun Functions", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    VotingMenu.OpenMenu();
                }, true);

                VotingButtons.AddSimpleSingleButton("Skip Vote", "Fun Functions", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallGameLogic("SyncVoteResultSkip");
                    AmongUs.CallGameLogic("SyncEndVotingPhase");
                });

                AntiVoteOut = VotingButtons.AddToggleButton("Anti Vote Out", "Makes so you can't get voted out", "Makes so you can't get voted out", (val) =>
                {
                    Create.Ini.SetBool("AmongUs", "AntiVoteOut", val);
                    PatchManager.AntiVoteout = val;
                });

                AntiVoteOut.SetToggleState(Create.Ini.GetBool("AmongUs", "AntiVoteOut"));

                #endregion

                #region Sabotages

                AmongUsButtons.AddSimpleSingleButton("Sabotages", "Sabotages", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUsSabotagesMenu.OpenMenu();
                }, true);

                AmongUsSabotagesButtons.AddSimpleSingleButton("Sabotage All Doors", "Sabotages All Doors", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallGameLogic("SyncDoSabotageDoorsElectrical");
                    AmongUs.CallGameLogic("SyncDoSabotageDoorsStorage");
                    AmongUs.CallGameLogic("SyncDoSabotageDoorsSecurity");
                    AmongUs.CallGameLogic("SyncDoSabotageDoorsLower");
                    AmongUs.CallGameLogic("SyncDoSabotageDoorsUpper");
                    AmongUs.CallGameLogic("SyncDoSabotageDoorsMedbay");
                    AmongUs.CallGameLogic("SyncDoSabotageDoorsCafeteria");
                });

                AmongUsSabotagesButtons.AddSimpleSingleButton("Sabotage All", "Sabotages All", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallGameLogic("SyncDoSabotageLights");
                    AmongUs.CallGameLogic("SyncDoSabotageComms");
                    AmongUs.CallGameLogic("SyncDoSabotageReactor");
                    AmongUs.CallGameLogic("SyncDoSabotageOxygen");
                });

                AmongUsSabotagesButtons.AddSimpleSingleButton("Sabotage All + Doors", "Sabotages All and doors", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallGameLogic("SyncDoSabotageDoorsElectrical");
                    AmongUs.CallGameLogic("SyncDoSabotageDoorsStorage");
                    AmongUs.CallGameLogic("SyncDoSabotageDoorsSecurity");
                    AmongUs.CallGameLogic("SyncDoSabotageDoorsLower");
                    AmongUs.CallGameLogic("SyncDoSabotageDoorsUpper");
                    AmongUs.CallGameLogic("SyncDoSabotageDoorsMedbay");
                    AmongUs.CallGameLogic("SyncDoSabotageDoorsCafeteria");
                    AmongUs.CallGameLogic("SyncDoSabotageLights");
                    AmongUs.CallGameLogic("SyncDoSabotageComms");
                    AmongUs.CallGameLogic("SyncDoSabotageReactor");
                    AmongUs.CallGameLogic("SyncDoSabotageOxygen");
                });

                AmongUsSabotagesButtons.AddSimpleSingleButton("Sabotage Lights", "Sabotage Lights", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallGameLogic("SyncDoSabotageLights");
                });

                AmongUsSabotagesButtons.AddSimpleSingleButton("Sabotage Comms", "Sabotage Comms", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallGameLogic("SyncDoSabotageComms");
                });

                AmongUsSabotagesButtons.AddSimpleSingleButton("Sabotage Reactor", "Sabotage Reactor", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallGameLogic("SyncDoSabotageReactor");
                });

                AmongUsSabotagesButtons.AddSimpleSingleButton("Sabotage Oxygen", "Sabotage Oxygen", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallGameLogic("SyncDoSabotageOxygen");
                });

                AmongUsSabotagesButtons.AddSimpleSingleButton("Repair All", "Repairs All", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallGameLogic("CancelAllSabotage");
                });

                #endregion

                AmongUsButtons.AddSimpleSingleButton("Start Admin Scan", "Starts Admin Scan", () =>
                {
                    if (!AmongUs.worldLoaded) return;
                    AmongUs.CallGameLogic("AdminScan");
                });

                LogKills = AmongUsButtons.AddToggleButton("Log Kills", "Logs when someone kills", "Logs when someone kills", (val) =>
                {
                    PatchManager.LogKillsAmongUs = val;
                    Create.Ini.SetBool("AmongUs", "LogKills", val);
                });

                LogKills.SetToggleState(Create.Ini.GetBool("AmongUs", "LogKills"));

                #endregion

                #region Just B Club

                #region Rooms
                JustBClubButtons.AddSimpleSingleButton("Rooms", null, () =>
                {
                    JustBClubRoomsMenu.OpenMenu();
                }, true);

                JustBClubRoomsButtons.AddSimpleSingleButton("1", null, () =>
                {
                    Just_B_Club.Bedroom1.SetActive(true);
                    Just_B_Club.Bedroom2.SetActive(false);
                    Just_B_Club.Bedroom3.SetActive(false);
                    Just_B_Club.Bedroom4.SetActive(false);
                    Just_B_Club.Bedroom5.SetActive(false);
                    Just_B_Club.Bedroom6.SetActive(false);
                    Just_B_Club.Bedroom7.SetActive(false);
                    Utils.TPLocalPlayer(new Vector3(-217.7101f, -11.755f, 151.0652f));
                });

                JustBClubRoomsButtons.AddSimpleSingleButton("2", null, () =>
                {
                    Just_B_Club.Bedroom1.SetActive(false);
                    Just_B_Club.Bedroom2.SetActive(true);
                    Just_B_Club.Bedroom3.SetActive(false);
                    Just_B_Club.Bedroom4.SetActive(false);
                    Just_B_Club.Bedroom5.SetActive(false);
                    Just_B_Club.Bedroom6.SetActive(false);
                    Just_B_Club.Bedroom7.SetActive(false);
                    Utils.TPLocalPlayer(new Vector3(-217.3516f, 55.245f, -91.66356f));
                });

                JustBClubRoomsButtons.AddSimpleSingleButton("3", null, () =>
                {
                    Just_B_Club.Bedroom1.SetActive(false);
                    Just_B_Club.Bedroom2.SetActive(false);
                    Just_B_Club.Bedroom3.SetActive(true);
                    Just_B_Club.Bedroom4.SetActive(false);
                    Just_B_Club.Bedroom5.SetActive(false);
                    Just_B_Club.Bedroom6.SetActive(false);
                    Just_B_Club.Bedroom7.SetActive(false);
                    Utils.TPLocalPlayer(new Vector3(-119.0256f, -11.755f, 151.1068f));
                });

                JustBClubRoomsButtons.AddSimpleSingleButton("4", null, () =>
                {
                    Just_B_Club.Bedroom1.SetActive(false);
                    Just_B_Club.Bedroom2.SetActive(false);
                    Just_B_Club.Bedroom3.SetActive(false);
                    Just_B_Club.Bedroom4.SetActive(true);
                    Just_B_Club.Bedroom5.SetActive(false);
                    Just_B_Club.Bedroom6.SetActive(false);
                    Just_B_Club.Bedroom7.SetActive(false);
                    Utils.TPLocalPlayer(new Vector3(-116.8698f, 55.245f, -91.59067f));
                });

                JustBClubRoomsButtons.AddSimpleSingleButton("5", null, () =>
                {
                    Just_B_Club.Bedroom1.SetActive(false);
                    Just_B_Club.Bedroom2.SetActive(false);
                    Just_B_Club.Bedroom3.SetActive(false);
                    Just_B_Club.Bedroom4.SetActive(false);
                    Just_B_Club.Bedroom5.SetActive(true);
                    Just_B_Club.Bedroom6.SetActive(false);
                    Just_B_Club.Bedroom7.SetActive(false);
                    Utils.TPLocalPlayer(new Vector3(-18.62112f, -11.755f, 150.9862f));
                });

                JustBClubRoomsButtons.AddSimpleSingleButton("6", null, () =>
                {
                    Just_B_Club.Bedroom1.SetActive(false);
                    Just_B_Club.Bedroom2.SetActive(false);
                    Just_B_Club.Bedroom3.SetActive(false);
                    Just_B_Club.Bedroom4.SetActive(false);
                    Just_B_Club.Bedroom5.SetActive(false);
                    Just_B_Club.Bedroom6.SetActive(true);
                    Just_B_Club.Bedroom7.SetActive(false);
                    Utils.TPLocalPlayer(new Vector3(-17.56843f, 55.245f, -91.55622f));
                });

                JustBClubRoomsButtons.AddSimpleSingleButton("VIP Room", null, () =>
                {
                    Just_B_Club.Bedroom1.SetActive(false);
                    Just_B_Club.Bedroom2.SetActive(false);
                    Just_B_Club.Bedroom3.SetActive(false);
                    Just_B_Club.Bedroom4.SetActive(false);
                    Just_B_Club.Bedroom5.SetActive(false);
                    Just_B_Club.Bedroom6.SetActive(false);
                    Just_B_Club.Bedroom7.SetActive(true);
                    Utils.TPLocalPlayer(new Vector3(58.17721f, 62.3625f, -6.299268f));
                });
                #endregion

                #region Fun

                JustBClubButtons.AddToggleButton("Freeze All", null, null, (val) =>
                {
                    Just_B_Club.freeze = val;
                    Just_B_Club.FreezeAll();
                });

                #endregion

                #endregion

                #region Prison Escape

                PrisonButtons.AddSimpleSingleButton("Start Game", "", () =>
                {
                    Prison.gamestate.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "StartGameCountdown");
                });

                #region Patreon

                PrisonButtons.AddSimpleSingleButton("Patreon", "", () =>
                {
                    PrisonPatronMenu.OpenMenu();
                }, true);

                PatronSelfPrisonGold = PrisonPatronButtons.AddToggleButton("Gold", "Gives Patron to yourself", "", (val) =>
                {
                    if (val)
                    {
                        PatronSelfPrisonPurple.SetToggleState(false);
                        PatronSelfPrisonBlue.SetToggleState(false);
                        PatronSelfPrisonGreen.SetToggleState(false);
                        PatronSelfPrisonRed.SetToggleState(false);
                        PatronSelfPrisonRainbow.SetToggleState(false);
                        Create.Ini.SetBool("PrisonEscape", "PatreonSelf", val);
                        Create.Ini.SetString("PrisonEscape", "PatreonColour", "Gold");
                        Prison.Patreoncolor = "Gold";
                        Prison.patreon = false;
                        Prison.patreon = true;
                        MelonCoroutines.Start(Prison.PatronGuns());
                    }
                    else
                    {
                        Prison.patreon = false;
                        VRCHandGrasper[] hand = UnityEngine.Object.FindObjectsOfType<VRCHandGrasper>();
                        if (hand[0].field_Internal_VRC_Pickup_0 != null)
                        {
                            VRC.SDKBase.VRC_Pickup pickup = hand[0].field_Internal_VRC_Pickup_0;
                            UdonBehaviour udon = pickup.gameObject.GetComponent<UdonBehaviour>();
                            if (udon._eventTable.ContainsKey("EnablePatronEffects"))
                            {
                                udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "DisablePatronEffects");
                            }
                        }
                        if (hand[1].field_Internal_VRC_Pickup_0 != null)
                        {
                            VRC.SDKBase.VRC_Pickup pickup = hand[1].field_Internal_VRC_Pickup_0;
                            UdonBehaviour udon = pickup.gameObject.GetComponent<UdonBehaviour>();
                            if (udon._eventTable.ContainsKey("EnablePatronEffects"))
                            {
                                udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "DisablePatronEffects");
                            }
                        }
                    }
                });
                if (Prison.Patreoncolor == "Gold" && Prison.patreon)
                {
                    PatronSelfPrisonGold.SetToggleState(true);
                }

                PatronSelfPrisonGreen = PrisonPatronButtons.AddToggleButton("Green", "Gives Patron to yourself", "", (val) =>
                {
                    if (val)
                    {
                        PatronSelfPrisonPurple.SetToggleState(false);
                        PatronSelfPrisonGold.SetToggleState(false);
                        PatronSelfPrisonBlue.SetToggleState(false);
                        PatronSelfPrisonRed.SetToggleState(false);
                        PatronSelfPrisonRainbow.SetToggleState(false);
                        Create.Ini.SetBool("PrisonEscape", "PatreonSelf", val);
                        Create.Ini.SetString("PrisonEscape", "PatreonColour", "Green");
                        Prison.Patreoncolor = "Green";
                        Prison.patreon = false;
                        Prison.patreon = true;
                        MelonCoroutines.Start(Prison.PatronGuns());
                    }
                    else
                    {
                        Prison.patreon = false;
                        VRCHandGrasper[] hand = UnityEngine.Object.FindObjectsOfType<VRCHandGrasper>();
                        if (hand[0].field_Internal_VRC_Pickup_0 != null)
                        {
                            VRC.SDKBase.VRC_Pickup pickup = hand[0].field_Internal_VRC_Pickup_0;
                            UdonBehaviour udon = pickup.gameObject.GetComponent<UdonBehaviour>();
                            if (udon._eventTable.ContainsKey("EnablePatronEffects"))
                            {
                                udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "DisablePatronEffects");
                            }
                        }
                        if (hand[1].field_Internal_VRC_Pickup_0 != null)
                        {
                            VRC.SDKBase.VRC_Pickup pickup = hand[1].field_Internal_VRC_Pickup_0;
                            UdonBehaviour udon = pickup.gameObject.GetComponent<UdonBehaviour>();
                            if (udon._eventTable.ContainsKey("EnablePatronEffects"))
                            {
                                udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "DisablePatronEffects");
                            }
                        }
                    }
                });
                if (Prison.Patreoncolor == "Green" && Prison.patreon)
                {
                    PatronSelfPrisonGreen.SetToggleState(true);
                }

                PatronSelfPrisonBlue = PrisonPatronButtons.AddToggleButton("Blue", "Gives Patron to yourself", "", (val) =>
                {
                    if (val)
                    {
                        PatronSelfPrisonPurple.SetToggleState(false);
                        PatronSelfPrisonGold.SetToggleState(false);
                        PatronSelfPrisonGreen.SetToggleState(false);
                        PatronSelfPrisonRed.SetToggleState(false);
                        PatronSelfPrisonRainbow.SetToggleState(false);
                        Create.Ini.SetBool("PrisonEscape", "PatreonSelf", val);
                        Create.Ini.SetString("PrisonEscape", "PatreonColour", "Blue");
                        Prison.Patreoncolor = "Blue";
                        Prison.patreon = false;
                        Prison.patreon = true;
                        MelonCoroutines.Start(Prison.PatronGuns());
                    }
                    else
                    {
                        Prison.patreon = false;
                        VRCHandGrasper[] hand = UnityEngine.Object.FindObjectsOfType<VRCHandGrasper>();
                        if (hand[0].field_Internal_VRC_Pickup_0 != null)
                        {
                            VRC.SDKBase.VRC_Pickup pickup = hand[0].field_Internal_VRC_Pickup_0;
                            UdonBehaviour udon = pickup.gameObject.GetComponent<UdonBehaviour>();
                            if (udon._eventTable.ContainsKey("EnablePatronEffects"))
                            {
                                udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "DisablePatronEffects");
                            }
                        }
                        if (hand[1].field_Internal_VRC_Pickup_0 != null)
                        {
                            VRC.SDKBase.VRC_Pickup pickup = hand[1].field_Internal_VRC_Pickup_0;
                            UdonBehaviour udon = pickup.gameObject.GetComponent<UdonBehaviour>();
                            if (udon._eventTable.ContainsKey("EnablePatronEffects"))
                            {
                                udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "DisablePatronEffects");
                            }
                        }
                    }
                });
                if (Prison.Patreoncolor == "Blue" && Prison.patreon)
                {
                    PatronSelfPrisonBlue.SetToggleState(true);
                }


                PatronSelfPrisonPurple = PrisonPatronButtons.AddToggleButton("Purple", "Gives Patron to yourself", "", (val) =>
                {
                    if (val)
                    {
                        PatronSelfPrisonBlue.SetToggleState(false);
                        PatronSelfPrisonGold.SetToggleState(false);
                        PatronSelfPrisonGreen.SetToggleState(false);
                        PatronSelfPrisonRed.SetToggleState(false);
                        PatronSelfPrisonRainbow.SetToggleState(false);
                        Create.Ini.SetBool("PrisonEscape", "PatreonSelf", val);
                        Create.Ini.SetString("PrisonEscape", "PatreonColour", "Purple");
                        Prison.Patreoncolor = "Purple";
                        Prison.patreon = false;
                        Prison.patreon = true;
                        MelonCoroutines.Start(Prison.PatronGuns());
                    }
                    else
                    {
                        Prison.patreon = false;
                        VRCHandGrasper[] hand = UnityEngine.Object.FindObjectsOfType<VRCHandGrasper>();
                        if (hand[0].field_Internal_VRC_Pickup_0 != null)
                        {
                            VRC.SDKBase.VRC_Pickup pickup = hand[0].field_Internal_VRC_Pickup_0;
                            UdonBehaviour udon = pickup.gameObject.GetComponent<UdonBehaviour>();
                            if (udon._eventTable.ContainsKey("EnablePatronEffects"))
                            {
                                udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "DisablePatronEffects");
                            }
                        }
                        if (hand[1].field_Internal_VRC_Pickup_0 != null)
                        {
                            VRC.SDKBase.VRC_Pickup pickup = hand[1].field_Internal_VRC_Pickup_0;
                            UdonBehaviour udon = pickup.gameObject.GetComponent<UdonBehaviour>();
                            if (udon._eventTable.ContainsKey("EnablePatronEffects"))
                            {
                                udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "DisablePatronEffects");
                            }
                        }
                    }
                });
                if (Prison.Patreoncolor == "Purple" && Prison.patreon)
                {
                    PatronSelfPrisonPurple.SetToggleState(true);
                }

                PatronSelfPrisonRed = PrisonPatronButtons.AddToggleButton("Red", "Gives Patron to yourself", "", (val) =>
                {
                    if (val)
                    {
                        PatronSelfPrisonBlue.SetToggleState(false);
                        PatronSelfPrisonGold.SetToggleState(false);
                        PatronSelfPrisonGreen.SetToggleState(false);
                        PatronSelfPrisonPurple.SetToggleState(false);
                        PatronSelfPrisonRainbow.SetToggleState(false);
                        Create.Ini.SetBool("PrisonEscape", "PatreonSelf", val);
                        Create.Ini.SetString("PrisonEscape", "PatreonColour", "Red");
                        Prison.Patreoncolor = "Red";
                        Prison.patreon = false;
                        Prison.patreon = true;
                        MelonCoroutines.Start(Prison.PatronGuns());
                    }
                    else
                    {
                        Prison.patreon = false;
                        VRCHandGrasper[] hand = UnityEngine.Object.FindObjectsOfType<VRCHandGrasper>();
                        if (hand[0].field_Internal_VRC_Pickup_0 != null)
                        {
                            VRC.SDKBase.VRC_Pickup pickup = hand[0].field_Internal_VRC_Pickup_0;
                            UdonBehaviour udon = pickup.gameObject.GetComponent<UdonBehaviour>();
                            if (udon._eventTable.ContainsKey("EnablePatronEffects"))
                            {
                                udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "DisablePatronEffects");
                            }
                        }
                        if (hand[1].field_Internal_VRC_Pickup_0 != null)
                        {
                            VRC.SDKBase.VRC_Pickup pickup = hand[1].field_Internal_VRC_Pickup_0;
                            UdonBehaviour udon = pickup.gameObject.GetComponent<UdonBehaviour>();
                            if (udon._eventTable.ContainsKey("EnablePatronEffects"))
                            {
                                udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "DisablePatronEffects");
                            }
                        }
                    }
                });
                if (Prison.Patreoncolor == "Red" && Prison.patreon)
                {
                    PatronSelfPrisonRed.SetToggleState(true);
                }
                PatronSelfPrisonRainbow = PrisonPatronButtons.AddToggleButton("Rainbow", "Gives Patron to yourself", "", (val) =>
                {
                    if (val)
                    {
                        PatronSelfPrisonBlue.SetToggleState(false);
                        PatronSelfPrisonGold.SetToggleState(false);
                        PatronSelfPrisonPurple.SetToggleState(false);
                        PatronSelfPrisonRed.SetToggleState(false);
                        PatronSelfPrisonGreen.SetToggleState(false);
                        Create.Ini.SetBool("PrisonEscape", "PatreonSelf", val);
                        Create.Ini.SetString("PrisonEscape", "PatreonColour", "Rainbow");
                        Prison.Patreoncolor = "Rainbow";
                        Prison.patreon = false;
                        Prison.patreon = true;
                        MelonCoroutines.Start(Prison.PatronGunsRightRainbow());
                        MelonCoroutines.Start(Prison.PatronGunsLeftRainbow());
                        MelonCoroutines.Start(Prison.SyncRainbow());
                    }
                    else
                    {
                        Prison.patreon = false;
                        VRCHandGrasper[] hand = UnityEngine.Object.FindObjectsOfType<VRCHandGrasper>();
                        if (hand[0].field_Internal_VRC_Pickup_0 != null)
                        {
                            VRC.SDKBase.VRC_Pickup pickup = hand[0].field_Internal_VRC_Pickup_0;
                            UdonBehaviour udon = pickup.gameObject.GetComponent<UdonBehaviour>();
                            if (udon._eventTable.ContainsKey("EnablePatronEffects"))
                            {
                                udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "DisablePatronEffects");
                            }
                        }
                        if (hand[1].field_Internal_VRC_Pickup_0 != null)
                        {
                            VRC.SDKBase.VRC_Pickup pickup = hand[1].field_Internal_VRC_Pickup_0;
                            UdonBehaviour udon = pickup.gameObject.GetComponent<UdonBehaviour>();
                            if (udon._eventTable.ContainsKey("EnablePatronEffects"))
                            {
                                udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "DisablePatronEffects");
                            }
                        }
                    }
                });
                if (Prison.Patreoncolor == "Rainbow" && Prison.patreon)
                {
                    PatronSelfPrisonRainbow.SetToggleState(true);
                }
                #endregion


                PrisonButtons.AddToggleButton("One Shot", "OneShot ppl", "OneShot ppl", (val) =>
                {
                    Prison.OneShot = val;
                });

                PrisonButtons.AddToggleButton("No Cooldown on Smoke & Duck", "", "", (val) =>
                {
                    Prison.smoke = val;
                    MelonCoroutines.Start(Prison.NoCooldownSmoke());
                });

                PrisonButtons.AddSimpleSingleButton("Kill All", "", () =>
                {
                    foreach (var playerdata in Prison.PlayerData)
                    {
                        if (playerdata.active)
                        {
                            playerdata.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "Damage200");
                        }
                    }
                });

                PrisonButtons.AddSimpleSingleButton("Bypass Avatar Height", "", () =>
                {
                    var sign = GameObject.Find("Spawn Area/Avatar Warning Sign");
                    UnityEngine.Object.Destroy(sign);
                    UnityEngine.Object.Destroy(Prison.avatarheightchecker);
                });

                #region Locations

                PrisonButtons.AddSimpleSingleButton("Locations", "Teleport to locations on the map", () =>
                {
                    PrisonTpMenu.OpenMenu();
                }, true);

                PrisonTpButtons.AddSimpleSingleButton( "Right Tower", "Right Tower", () =>
                {
                    Utils.TPLocalPlayer(new Vector3(60.8f, 10.5f, 281.4f));
                });

                PrisonTpButtons.AddSimpleSingleButton( "Left Tower", "Left Tower", () =>
                {
                    Utils.TPLocalPlayer(new Vector3(61.2f, 10.5f, 318.7f));
                });

                PrisonTpButtons.AddSimpleSingleButton( "Guards Spawn", "Tp to Armory", () =>
                {
                    Utils.TPLocalPlayer(new Vector3(25.4f, 4.0f, 303.2f));
                });

                PrisonTpButtons.AddSimpleSingleButton( "Outside", "Tp to ouside next to the gate", () =>
                {
                    Utils.TPLocalPlayer(new Vector3(55.9f, -0.1f, 297.4f));
                });

                PrisonTpButtons.AddSimpleSingleButton( "Gate Control", "Tp to gate control room", () =>
                {
                    Utils.TPLocalPlayer(new Vector3(57.7f, 0.0f, 293.0f));
                });

                PrisonTpButtons.AddSimpleSingleButton( "Exit", "Tp to exit", () =>
                {
                    Utils.TPLocalPlayer(new Vector3(98.1f, -0.1f, 300.4f));
                });
                #endregion

                #region Private Stuff

                PrivatePrisonEscapeStuff = PrisonButtons.AddSimpleSingleButton("Private Stuff", "", () =>
                {
                    if (!Prison.worldLoaded) return;
                    PrisonPrivStuffMenu.OpenMenu();
                }, true);

                PrivatePrisonEscapeStuff.SetActive(false);

                PrisonPrivStuffButtons.AddSimpleSingleButton("Take Keycard", "Literally Takes a Keycard", () =>
                {
                    if (!Prison.worldLoaded) return;
                    Prison.gamemanager.SendCustomEvent("_TakeKeycard");
                });

                PrisonPrivStuffButtons.AddSimpleSingleButton("Respawn In Game", "Literally Spawns you In Game u have to be in the spectator list", () =>
                {
                    if (!Prison.worldLoaded) return;
                    Prison.gamemanager.SendCustomEvent("_SpawnPlayer");
                });

                PrisonPrivStuffButtons.AddSimpleSingleButton("Get Wanted x Times", "", () =>
                {
                    if (!Prison.worldLoaded) return;
                    PrisonWantedMenu.OpenMenu();
                }, true);

                #region Wanted

                int times = 1;

                bool spawningame = true;

                var Wanted = PrisonWantedButtons.AddSimpleSingleButton("Get Wanted 1 Time", "", () =>
                {
                    if (!Prison.worldLoaded) return;
                    if (times != 0)
                    {
                        MelonCoroutines.Start(Prison.GetWanted(times, spawningame));
                    }
                });

                PrisonWantedButtons.AddToggleButton("Spawn In Game After Finishing", "", "", (val) => { spawningame = val; }).SetToggleState(spawningame);

                PrisonWantedMenu.AddSlider("Times", null, (val) =>
                {
                    times = (int)val;
                    if (times == 1)
                    {
                        Wanted.SetText($"Get Wanted {times} Time");
                    }
                    else
                    {
                        Wanted.SetText($"Get Wanted {times} Times");
                    }
                }, 1, 10, 1, true, false);

                #endregion

                PrisonPrivStuffButtons.AddSimpleSingleButton("Money Menu", "Literally A Menu for Giving you Money ", () =>
                {
                    if (!Prison.worldLoaded) return;
                    PrisonMoneyMenu.OpenMenu();
                }, true);

                ESPPrison = PrisonPrivStuffButtons.AddToggleButton("Team ESP", "", "", (val) =>
                {
                    Prison.specialesp = val;
                    Create.Ini.SetBool("PrisonEscape", "TeamESP", val);
                    if (Prison.specialesp)
                    {
                        MelonCoroutines.Start(Prison.ESPCheck());
                    }
                    if (Features.ESP.ESPEnabled)
                    {
                        Features.ESP.ToggleESP(false);
                        Features.ESP.ToggleESP(true);
                    }
                    else
                    {
                        Features.ESP.ToggleESP(false);
                    }
                });

                ESPPrison.SetToggleState(Create.Ini.GetBool("PrisonEscape", "TeamESP"));


                PrisonPrivStuffButtons.AddToggleButton("Inf Ammo", "", "", (val) =>
                {
                    Prison.infammo = val;
                    if (Prison.infammo)
                    {
                        MelonCoroutines.Start(Prison.InfAmmo());
                    }
                });

                #region Money

                PrisonMoneyButtons.AddSimpleSingleButton("Get 50 Bucks", "", () =>
                {
                    if (!Prison.worldLoaded) return;
                    if (GameObject.Find("Scripts/Game Effects/Canvas HUD/Points Canvas/Points Changed Panel/Text Points Changed").GetComponent<TextMeshProUGUI>().text != "+50")
                    {
                        Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("_AddWin");
                        GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
                    }
                    else
                    {
                        Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints");
                        GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
                    }
                });

                PrisonMoneyButtons.AddSimpleSingleButton("Get 100 Bucks", "", () =>
                {
                    if (!Prison.worldLoaded) return;
                    if (GameObject.Find("Scripts/Game Effects/Canvas HUD/Points Canvas/Points Changed Panel/Text Points Changed").GetComponent<TextMeshProUGUI>().text != "+50")
                    {
                        try
                        {
                            Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("_AddWin");
                            GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
                        }
                        finally
                        {
                            Utils.ExecuteCodeMultipleTimes(1, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                        }
                    }
                    else
                    {
                        Utils.ExecuteCodeMultipleTimes(2, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                    }
                });

                PrisonMoneyButtons.AddSimpleSingleButton("Get 150 Bucks", "", () =>
                {
                    if (!Prison.worldLoaded) return;
                    if (GameObject.Find("Scripts/Game Effects/Canvas HUD/Points Canvas/Points Changed Panel/Text Points Changed").GetComponent<TextMeshProUGUI>().text != "+50")
                    {
                        try
                        {
                            Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("_AddWin");
                            GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
                        }
                        finally
                        {
                            Utils.ExecuteCodeMultipleTimes(2, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                        }
                    }
                    else
                    {
                        Utils.ExecuteCodeMultipleTimes(3, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                    }
                });

                PrisonMoneyButtons.AddSimpleSingleButton("Get 200 Bucks", "", () =>
                {
                    if (!Prison.worldLoaded) return;
                    if (GameObject.Find("Scripts/Game Effects/Canvas HUD/Points Canvas/Points Changed Panel/Text Points Changed").GetComponent<TextMeshProUGUI>().text != "+50")
                    {
                        try
                        {
                            Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("_AddWin");
                            GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
                        }
                        finally
                        {
                            Utils.ExecuteCodeMultipleTimes(3, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                        }
                    }
                    else
                    {
                        Utils.ExecuteCodeMultipleTimes(4, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                    }
                });

                PrisonMoneyButtons.AddSimpleSingleButton("Get 250 Bucks", "", () =>
                {
                    if (!Prison.worldLoaded) return;
                    if (GameObject.Find("Scripts/Game Effects/Canvas HUD/Points Canvas/Points Changed Panel/Text Points Changed").GetComponent<TextMeshProUGUI>().text != "+50")
                    {
                        try
                        {
                            Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("_AddWin");
                            GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
                        }
                        finally
                        {
                            Utils.ExecuteCodeMultipleTimes(4, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                        }
                    }
                    else
                    {
                        Utils.ExecuteCodeMultipleTimes(5, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                    }
                });

                PrisonMoneyButtons.AddSimpleSingleButton("Get 300 Bucks", "", () =>
                {
                    if (!Prison.worldLoaded) return;
                    if (GameObject.Find("Scripts/Game Effects/Canvas HUD/Points Canvas/Points Changed Panel/Text Points Changed").GetComponent<TextMeshProUGUI>().text != "+50")
                    {
                        try
                        {
                            Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("_AddWin");
                            GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
                        }
                        finally
                        {
                            Utils.ExecuteCodeMultipleTimes(5, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                        }
                    }
                    else
                    {
                        Utils.ExecuteCodeMultipleTimes(6, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                    }
                });

                PrisonMoneyButtons.AddSimpleSingleButton("Get 350 Bucks", "", () =>
                {
                    if (!Prison.worldLoaded) return;
                    if (GameObject.Find("Scripts/Game Effects/Canvas HUD/Points Canvas/Points Changed Panel/Text Points Changed").GetComponent<TextMeshProUGUI>().text != "+50")
                    {
                        try
                        {
                            Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("_AddWin");
                            GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
                        }
                        finally
                        {
                            Utils.ExecuteCodeMultipleTimes(6, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                        }
                    }
                    else
                    {
                        Utils.ExecuteCodeMultipleTimes(7, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                    }
                });

                PrisonMoneyButtons.AddSimpleSingleButton("Get 400 Bucks", "", () =>
                {
                    if (!Prison.worldLoaded) return;
                    if (GameObject.Find("Scripts/Game Effects/Canvas HUD/Points Canvas/Points Changed Panel/Text Points Changed").GetComponent<TextMeshProUGUI>().text != "+50")
                    {
                        try
                        {
                            Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("_AddWin");
                            GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
                        }
                        finally
                        {
                            Utils.ExecuteCodeMultipleTimes(7, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                        }
                    }
                    else
                    {
                        Utils.ExecuteCodeMultipleTimes(8, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                    }
                });

                PrisonMoneyButtons.AddSimpleSingleButton("Get 450 Bucks", "", () =>
                {
                    if (!Prison.worldLoaded) return;
                    if (GameObject.Find("Scripts/Game Effects/Canvas HUD/Points Canvas/Points Changed Panel/Text Points Changed").GetComponent<TextMeshProUGUI>().text != "+50")
                    {
                        try
                        {
                            Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("_AddWin");
                            GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
                        }
                        finally
                        {
                            Utils.ExecuteCodeMultipleTimes(8, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                        }
                    }
                    else
                    {
                        Utils.ExecuteCodeMultipleTimes(9, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                    }
                });

                PrisonMoneyButtons.AddSimpleSingleButton("Get 500 Bucks", "", () =>
                {
                    if (!Prison.worldLoaded) return;
                    if (GameObject.Find("Scripts/Game Effects/Canvas HUD/Points Canvas/Points Changed Panel/Text Points Changed").GetComponent<TextMeshProUGUI>().text != "+50")
                    {
                        try
                        {
                            Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("_AddWin");
                            GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
                        }
                        finally
                        {
                            Utils.ExecuteCodeMultipleTimes(9, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                        }
                    }
                    else
                    {
                        Utils.ExecuteCodeMultipleTimes(10, () => Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints"), () => GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard"));
                    }
                });

                #endregion

                #endregion

                CrateESPPrison = PrisonButtons.AddToggleButton("Crate ESP", "", "", (val) =>
                {
                    Prison.crateesp = val;
                    Create.Ini.SetBool("PrisonEscape", "CrateESP", val);
                    if (Prison.crateesp)
                    {
                        MelonCoroutines.Start(Prison.CrateESP());
                    }
                });

                CrateESPPrison.SetToggleState(Create.Ini.GetBool("PrisonEscape", "CrateESP"));

                PrisonButtons.AddSimpleSingleButton("Make Everyone Drop their Keycard", null, () =>
                {
                    if (!Prison.worldLoaded) return;
                    Prison.EveryoneDropKeycard();
                }, false);

                #endregion


                #region Fate of the Irrbloss

                #region PreGame

                IrrblossButtons.AddSimpleSingleButton("Pre-Game", "", () =>
                {
                    IrrblossPreGameMenu.OpenMenu();
                }, true);

                IrrblossPreGameButtons.AddSimpleSingleButton("Become All Players", "", () =>
                    {
                        foreach (var udon in FateOfTheIrrbloss.Udons.Where(udon => udon.gameObject.name.StartsWith("PL select")))
                        {
                            Items.TakeOwnershipIfNecessary(udon.gameObject);
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.Owner, "act");
                        }
                    });

                    IrrblossSongVersion1 = IrrblossPreGameButtons.AddToggleButton("Play Song v1", "", "", (val) =>
                    {
                        try
                        {
                            if (val)
                            {
                                FateOfTheIrrbloss.songversion = 1;
                                IrrblossSongVersion2.SetToggleState(false);
                                if (FateOfTheIrrbloss.song)
                                {
                                    MelonCoroutines.Stop(FateOfTheIrrbloss.MakeSongPreGame());
                                }
                                FateOfTheIrrbloss.song = true;
                                MelonCoroutines.Start(FateOfTheIrrbloss.MakeSongPreGame());
                            }
                            else
                            {
                                FateOfTheIrrbloss.song = false;
                            }
                        }
                        catch { }
                    });

                    IrrblossSongVersion2 = IrrblossPreGameButtons.AddToggleButton("Play Song v2", "", "", (val) =>
                    {
                        try
                        {
                            if (val)
                            {
                                FateOfTheIrrbloss.songversion = 2;
                                IrrblossSongVersion1.SetToggleState(false);
                                if (FateOfTheIrrbloss.song)
                                {
                                    MelonCoroutines.Stop(FateOfTheIrrbloss.MakeSongPreGame());
                                }
                                FateOfTheIrrbloss.song = true;
                                MelonCoroutines.Start(FateOfTheIrrbloss.MakeSongPreGame());
                            }
                            else
                            {
                                FateOfTheIrrbloss.song = false;
                            }
                        }
                        catch { }
                    });

                #endregion

                #region InGame

                IrrblossButtons.AddSimpleSingleButton("In-Game", "", () =>
                    {
                        IrrblossInGameMenu.OpenMenu();
                    }, true);

                #region Ship

                IrrblossInGameButtons.AddSimpleSingleButton("Ship", "", () =>
                    {
                        IrrblossInGameShipMenu.OpenMenu();
                    }, true);

                #region Doors

                IrrblossInGameShipButtons.AddSimpleSingleButton("Doors", "", () =>
                    {
                        IrrblossInGameDoorsMenu.OpenMenu();
                    }, true);

                IrrblossInGameDoorsButtons.AddSimpleSingleButton("Open All Doors", "", () =>
                    {
                        foreach (var udon in FateOfTheIrrbloss.Udons.Where(udon => udon.gameObject.name.Equals("Open all")))
                        {
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.Owner, "pressed2");
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.Owner, "released2");
                        }
                    });

                IrrblossInGameDoorsButtons.AddSimpleSingleButton("Close All Doors", "", () =>
                    {
                        foreach (var udon in FateOfTheIrrbloss.Udons.Where(udon => udon.gameObject.name.Equals("Close all")))
                        {
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.Owner, "pressed2");
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.Owner, "released2");
                        }
                    });

                IrrblossInGameDoorsButtons.AddSimpleSingleButton("Repair All Doors", "", () =>
                    {
                        foreach (var udon in FateOfTheIrrbloss.Udons.Where(udon => udon._eventTable.ContainsKey("Sysdamrep") && udon.name.ToLower().Contains("door")))
                        {
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "Sysdamrep");
                        }
                    });

                #endregion

                IrrblossInGameShipButtons.AddSimpleSingleButton("Repair All", "", () =>
                    {
                        foreach (var udon in FateOfTheIrrbloss.Udons.Where(udon => udon._eventTable.ContainsKey("Sysdamrep")))
                        {
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "Sysdamrep");
                        }
                        foreach (var udon in FateOfTheIrrbloss.Udons.Where(udon => udon._eventTable.ContainsKey("takeoutfire")))
                        {
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "takeoutfire");
                        }
                        foreach (var udon in FateOfTheIrrbloss.Udons.Where(udon => udon._eventTable.ContainsKey("Stopfire")))
                        {
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "Stopfire");
                        }
                        foreach (var udon in FateOfTheIrrbloss.Udons.Where(udon => udon._eventTable.ContainsKey("Rep")))
                        {
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "Rep");
                        }
                    });

                IrrblossInGameShipButtons.AddSimpleSingleButton("Heal Ship", "", () =>
                    {
                        foreach (var udon in FateOfTheIrrbloss.Udons.Where(udon => udon.name.Equals("Pilotvariables")))
                        {
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "hullrep");
                        }
                    });

                IrrblossInGameShipButtons.AddSimpleSingleButton("Fully Heal Ship", "", () =>
                    {
                        foreach (var udon in FateOfTheIrrbloss.Udons.Where(udon => udon.name.Equals("Pilotvariables")))
                        {
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "fullrep");
                        }
                    });

                #endregion

                #region Enemy Ship

                IrrblossInGameButtons.AddSimpleSingleButton("Enemy Ship", "", () =>
                    {
                        IrrblossInGameEnemyShipMenu.OpenMenu();
                    }, true);

                IrrblossInGameEnemyShipButtons.AddSimpleSingleButton("Hack Engine", "", () =>
                    {
                        foreach (var udon in FateOfTheIrrbloss.Udons.Where(udon => udon.gameObject.name.Equals("Enemy engine")))
                        {
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "Pilothack");
                        }
                    });

                IrrblossInGameEnemyShipButtons.AddSimpleSingleButton("Hack Pilot", "", () =>
                    {
                        foreach (var udon in FateOfTheIrrbloss.Udons.Where(udon => udon.gameObject.name.Equals("Enemy pilot")))
                        {
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "Pilothack");
                        }
                    });

                IrrblossInGameEnemyShipButtons.AddSimpleSingleButton("Hack Weapons", "", () =>
                    {
                        foreach (var udon in FateOfTheIrrbloss.Udons.Where(udon => udon.gameObject.name.Equals("Weapon slots") && udon.transform.parent.gameObject.name.Equals("Enemy Ship")))
                        {
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "wephack");
                        }
                    });

                IrrblossInGameEnemyShipButtons.AddSimpleSingleButton("Hack Shields", "", () =>
                    {
                        foreach (var udon in FateOfTheIrrbloss.Udons.Where(udon => udon.gameObject.name.Equals("Enemyhealth")))
                        {
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "Shieldhack");
                        }
                    });

                IrrblossInGameEnemyShipButtons.AddSimpleSingleButton("Kill", "", () =>
                    {
                        foreach (var udon in FateOfTheIrrbloss.Udons.Where(udon => udon.gameObject.name.Equals("Enemyhealth")))
                        {
                            udon.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "death");
                        }
                    });

                #endregion

                IrrblossInGameButtons.AddToggleButton("No Cooldown", "", "", (val) =>
                    {
                        FateOfTheIrrbloss.nocooldown = val;
                        MelonCoroutines.Start(FateOfTheIrrbloss.NoCooldown());
                    });

                IrrblossInGameButtons.AddToggleButton("Welder Insta Repair", "", "", (val) =>
                    {
                        FateOfTheIrrbloss.instarepair = val;
                    });

                IrrblossInGameButtons.AddToggleButton("Fire Extinguisher Insta Extinguish", "", "", (val) =>
                    {
                        FateOfTheIrrbloss.instaextinguish = val;
                    });

                #endregion

                #region Music

                IrrblossButtons.AddSimpleSingleButton("Music", "", () =>
                    {
                        IrrblossMusicMenu.OpenMenu();
                    }, true);

                IrrblossMusicButtons.AddSimpleSingleButton("New Sector", "", () =>
                    {
                        FateOfTheIrrbloss.ChangeSong("newsect");
                    });

                    IrrblossMusicButtons.AddSimpleSingleButton("Chill", "", () =>
                    {
                        FateOfTheIrrbloss.ChangeSong("newsong");
                    });

                    IrrblossMusicButtons.AddSimpleSingleButton("Intro", "", () =>
                    {
                        FateOfTheIrrbloss.ChangeSong("intro");
                    });

                    IrrblossMusicButtons.AddSimpleSingleButton("Boss 1", "", () =>
                    {
                        FateOfTheIrrbloss.ChangeSong("boss1");
                    });

                    IrrblossMusicButtons.AddSimpleSingleButton("Boss 2", "", () =>
                    {
                        FateOfTheIrrbloss.ChangeSong("boss2");
                    });

                    IrrblossMusicButtons.AddSimpleSingleButton("Boss 3", "", () =>
                    {
                        FateOfTheIrrbloss.ChangeSong("boss3");
                    });

                    IrrblossMusicButtons.AddSimpleSingleButton("Flying Dialog 1", "", () =>
                    {
                        FateOfTheIrrbloss.ChangeSong("i1");
                    });

                    IrrblossMusicButtons.AddSimpleSingleButton("Flying Dialog 2", "", () =>
                    {
                        FateOfTheIrrbloss.ChangeSong("i2");
                    });

                    IrrblossMusicButtons.AddSimpleSingleButton("Flying Dialog 3", "", () =>
                    {
                        FateOfTheIrrbloss.ChangeSong("i3");
                    });

                    IrrblossMusicButtons.AddSimpleSingleButton("Flying Dialog 4", "", () =>
                    {
                        FateOfTheIrrbloss.ChangeSong("i4");
                    });

                    IrrblossMusicButtons.AddSimpleSingleButton("Flying Dialog 5", "", () =>
                    {
                        FateOfTheIrrbloss.ChangeSong("i5");
                    });

                #endregion

                #endregion


                #region Protections

                var ProtectionsIcon = ForbiddenClient.Resources.IconsVars.Protections.LoadSprite();

                MainMenuButtons.AddSingleButton("Protections", "Opens Protections Menu", () =>
                {
                    Protections.OpenMenu();
                }, true, ProtectionsIcon);

                ProtectionsButtons.AddToggleButton("Anti Udon", "Blocks Every Udon Event", "Blocks Every Udon Event", (val) =>
                {
                    PatchManager.AntiUdon = val;
                }).SetToggleState(false, false);

                ProtectionsButtons.AddToggleButton("Portal Walktrough", "Allows you to walk trough Portals", "Allows you to walk trough Portals", (val) =>
                {
                    PatchManager.PortalWalk = val;
                }).SetToggleState(false, false);

                ProtectionsButtons.AddToggleButton("Log Udon", "Logs all Udon Events onto the MLConsole", "Logs all Udon Events onto the MLConsole", (val) =>
                {
                    PatchManager.LogUdon = val;
                }).SetToggleState(false, false);

                #region Log Cheaters

                ProtectionsButtons.AddSimpleSingleButton("Log Cheaters", "Opens Log Cheaters Menu", () =>
                {
                    LogCheaters.OpenMenu();
                }, true);

                LogCheatersa = LogCheatersButtons.AddToggleButton("Log Cheaters", "Logs all client users abusing udon events onto the MLConsole", "Logs all client users abusing udon events onto the MLConsole", (val) =>
                {
                    Create.Ini.SetBool("LogCheaters", "LogCheaters", val);
                    PatchManager.LogCheaters = val;
                });

                LogCheatersa.SetToggleState(Create.Ini.GetBool("LogCheaters", "LogCheaters"), false);

                Audio = LogCheatersButtons.AddToggleButton("Audio", "Plays an Audio every time a log is triggered", "Plays an Audio every time a log is triggered", (val) =>
                {
                    Create.Ini.SetBool("LogCheaters", "Audio", val);
                    PatchManager.playsound = val;
                });

                Audio.SetToggleState(Create.Ini.GetBool("LogCheaters", "Audio"), false);

                HUD = LogCheatersButtons.AddToggleButton("HUD Notifications", "Logs the cheaters in the HUD", "Logs the cheaters in the HUD", (val) =>
                {
                    Create.Ini.SetBool("LogCheaters", "HUD", val);
                    PatchManager.HUD = val;
                });

                HUD.SetToggleState(Create.Ini.GetBool("LogCheaters", "HUD"), false);

                ChangeStatus = LogCheatersButtons.AddToggleButton("Change Status", "Change your status to the cheater name", "Change your status to the cheater name", (val) =>
                {
                    Create.Ini.SetBool("LogCheaters", "ChangeStatus", val);
                    PatchManager.changestatus = val;
                });

                ChangeStatus.SetToggleState(Create.Ini.GetBool("LogCheaters", "ChangeStatus"), false);

                LogCheatersButtons.AddSimpleSingleButton("Reset Status", "Changes your status to the original you had", () =>
                {
                    if (!string.IsNullOrEmpty(Utils.originaldescription))
                    {
                        MelonCoroutines.Start(Utils.ChangeStatus(Utils.originaldescription));
                        Utils.originaldescription = null;
                    }
                });

                #endregion

                ProtectionsButtons.AddToggleButton("Serialize", "Freezes you for everyone", "Freezes you for everyone", (val) =>
                {
                    PatchManager.serialize = val;
                    Utils.FreezeClone();
                });

                ProtectionsButtons.AddToggleButton("Lock Instance", "Ability to Lock the instance so no one can join", "Ability to Lock the instance so no one can join", (val) =>
                {
                    PatchManager.LockInstance = val;
                });

                //AntiBlock = ProtectionsButtons.AddToggleButton("Anti Block", "Allows you to see people that blocked you", "Allows you to see people that blocked you", (val) =>
                //{
                //    PatchManager.antiblock = val;
                //    Create.Ini.SetBool("Toggles", "AntiBlock", val);
                //});

                //AntiBlock.SetToggleState(Create.Ini.GetBool("Toggles", "AntiBlock"));

                //PreventAvatarChange = ProtectionsButtons.AddToggleButton("Prevent Avatar Change From Blocked Users", "Blocks Avatar Changes From Blocked Users", "Blocks Avatar Changes From Blocked Users", (val) =>
                //{
                //    PatchManager.preventavatarchangefromblockedusers = val;
                //    Create.Ini.SetBool("Toggles", "PreventAvatarChange", val);
                //});

                //PreventAvatarChange.SetToggleState(Create.Ini.GetBool("Toggles", "PreventAvatarChange"));

                var spoofcamera = ProtectionsButtons.AddToggleButton("Spoof Camera", "Makes so ppl can't see that u have the camera on", "Makes so ppl can't see that u have the camera on", (val) =>
                {
                    PatchManager.spoofcam = val;
                    Create.Ini.SetBool("Toggles", "SpoofCamera", val);
                });

                spoofcamera.SetToggleState(Create.Ini.GetBool("Toggles", "SpoofCamera"));

                var hardwarespoof = ProtectionsButtons.AddToggleButton("Spoof All Hardware", "Spoofs All Hardware", "Spoofs All Hardware", (val) =>
                {
                    PatchManager.SpoofAllHardware = val;
                    Create.Ini.SetBool("Toggles", "Hardware", val);
                });

                hardwarespoof.SetToggleState(Create.Ini.GetBool("Toggles", "Hardware"));

                #endregion

                #region Pickups

                var PickupsIcon = ForbiddenClient.Resources.IconsVars.pickups.LoadSprite();


                MainMenuButtons.AddSingleButton("Pickups", "Opens Pickup Menu", () =>
                {
                    Pickups.OpenMenu();
                }, true, PickupsIcon);

                PickupsButtons.AddToggleButton("Auto Drop", "Drop Pickups for everyone", "Drop Pickups for everyone", (val) =>
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

                PickupsButtons.AddToggleButton("Thief", "Allows Thief of Pickups", "Allows Thief of Pickups", (val) =>
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

                AntiTheftuwu = PickupsButtons.AddToggleButton("Anti Theft", "No one can steal your pickups", "No one can steal your pickups", (val) =>
                {
                    Create.Ini.SetBool("Toggles", "AntiTheft", val);
                    Items.antitheft = val;
                    if (val)
                    {
                        MelonCoroutines.Start(Items.AntiTheft());
                    }
                });

                AntiTheftuwu.SetToggleState(Create.Ini.GetBool("Toggles", "AntiTheft"));

                ButterKnife = PickupsButtons.AddToggleButton("Butter Knife", "The knife is like a butter knife", "The knife is like a butter knife", (val) =>
                {
                    PatchManager.butterknife = val;
                });

                ButterKnife.SetActive(false);

                PickupsButtons.AddSimpleSingleButton("Respawn Pickups", null, () =>
                {
                    Items.RespawnPickups();
                });

                PickupsButtons.AddToggleButton("Disable Pickups", "", "", (val) =>
                {
                    Items.pickupsenabled = !val;
                    foreach (var pickup in PatchManager.Pickups)
                    {
                        if (pickup.gameObject.name.Equals("OscDebugConsole") || pickup.gameObject.name.Equals("AvatarDebugConsole") || pickup.gameObject.name.Equals("ViewFinder") || pickup.gameObject.name.Equals("PhotoCamera")){}
                        else
                        {
                            pickup.gameObject.active = Items.pickupsenabled;
                        }
                    }
                });

                #region ItemLag

                PickupsButtons.AddSimpleSingleButton("Item Lag", null, () =>
                {
                    PickupsLag.OpenMenu();
                }, true);

                PickupsLagButtons.AddToggleButton("Item Lag", "", "", (val) =>
                {
                    if (val)
                    {
                        Items.itemlag = true;
                        MelonCoroutines.Start(Items.ItemLagger());
                    }
                    else
                    {
                        Items.itemlag = false;
                    }
                });

                PickupsLagButtons.AddToggleButton("Item Lag 2", "", "", (val) =>
                {
                    if (val)
                    {
                        Items.itemlag2 = true;
                        MelonCoroutines.Start(Items.ItemLagger2());
                    }
                    else
                    {
                        Items.itemlag2 = false;
                    }
                });
                #endregion


                #endregion

                var KillSelfIcon = ForbiddenClient.Resources.IconsVars.KillSelf.LoadSprite();

                KillSelf = MainMenuButtons.AddSingleButton("Kill Self", "Kill Self with Grenade", () =>
                {
                    try
                    {
                        if (Murder4.worldLoaded)
                        {
                            MelonCoroutines.Start(Murder4.KillLocalPlayerFrag());
                        }
                        else if (Murder3.worldLoaded)
                        {
                            MelonCoroutines.Start(Murder3.KillLocalPlayerFrag());
                        }
                        else if (AmongUs.worldLoaded)
                        {
                            Utils.SetRole(Player.prop_Player_0, "Kill");
                        }
                    }
                    catch { }
                }, false, KillSelfIcon);

                KillSelf.SetActive(false);

                GodMode = MainMenuButtons.AddToggleButton("GodMode", "Gives you Immortality", "Gives you Immortality", (val) =>
                {
                    Create.Ini.SetBool("Toggles", "GodMode", val);
                    PatchManager.Godmode = val;
                });

                GodMode.SetToggleState(Create.Ini.GetBool("Toggles", "GodMode"));

                UdonTransform = UdonEventsButtons.gameObject.transform;

                //Udon
                MainMenuButtons.AddSimpleSingleButton("Udon Events", null, () =>
                {
                    UdonEventsMenu.OpenMenu();
                    if (!cached)
                    {
                        foreach (var events in Udon.GetUdonBehaviourGameObjects())
                        {
                            UdonEventsButtons.AddSimpleSingleButton(events.gameObject.name, null, () =>
                            {
                                UdonEventButtons.gameObject.transform.DestroyChildren();
                                UdonEventMenu.OpenMenu();
                                UdonEventMenu.SetTitle(events.gameObject.name);
                                foreach (var uwu in events.GetComponent<UdonBehaviour>()?._eventTable)
                                {
                                if (uwu.Key.StartsWith("_"))
                                    {
                                        UdonEventButtons.AddSimpleSingleButton(uwu.Key, null, () =>
                                        {
                                            events.GetComponent<UdonBehaviour>().SendCustomEvent(uwu.Key);
                                        });
                                    }
                                    else
                                    {
                                        UdonEventButtons.AddSimpleSingleButton(uwu.Key, null, () =>
                                        {
                                            events.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, uwu.Key);
                                        });
                                    }
                                    
                                }
                            }, true);
                        }
                    }
                    cached = true;
                }, true);

                #region TouchSystem

                Touch = MainMenuButtons.AddSimpleSingleButton("Touch System", "", () =>
                {
                    TouchSystemMenu.OpenMenu();
                }, true);

                Touch.SetActive(false);

                TouchBystander = TouchSystemButtons.AddToggleButton("Give Bystander", "Gives Bystander when you close your fist next to someone (Use K in Desktop)", "Gives Bystander when you close your fist next to someone (Use K in Desktop)", (val) =>
                {
                    touchsystoggle = "Bystander";
                    MelonCoroutines.Start(Utils.TouchSysAll());
                    TouchDetective.SetToggleState(false, false);
                    TouchMurderer.SetToggleState(false, false);
                    TouchFlash.SetToggleState(false, false);
                    TouchKill.SetToggleState(false, false);
                    TouchCooldown.SetToggleState(false, false);
                    TouchClues.SetToggleState(false, false);
                    TouchGrenade.SetToggleState(false, false);
                    TouchBeartrap.SetToggleState(false, false);
                    TouchVoteOut.SetToggleState(false, false);
                    if (!val) touchsystoggle = string.Empty;
                });

                TouchDetective = TouchSystemButtons.AddToggleButton("Give Detective", "Gives Detective when you close your fist next to someone (Use K in Desktop)", "Gives Detective when you close your fist next to someone (Use K in Desktop)", (val) =>
                {
                    touchsystoggle = "Detective";
                    MelonCoroutines.Start(Utils.TouchSysAll());
                    TouchBystander.SetToggleState(false, false);
                    TouchMurderer.SetToggleState(false, false);
                    TouchFlash.SetToggleState(false, false);
                    TouchKill.SetToggleState(false, false);
                    TouchCooldown.SetToggleState(false, false);
                    TouchClues.SetToggleState(false, false);
                    TouchGrenade.SetToggleState(false, false);
                    TouchBeartrap.SetToggleState(false, false);
                    TouchVoteOut.SetToggleState(false, false);
                    if (!val) touchsystoggle = string.Empty;
                });

                TouchMurderer = TouchSystemButtons.AddToggleButton("Give Murderer", "Gives Murderer when you close your fist next to someone (Use K in Desktop)", "Gives Murderer when you close your fist next to someone (Use K in Desktop)", (val) =>
                {
                    touchsystoggle = "Murderer";
                    MelonCoroutines.Start(Utils.TouchSysAll());
                    TouchDetective.SetToggleState(false, false);
                    TouchBystander.SetToggleState(false, false);
                    TouchFlash.SetToggleState(false, false);
                    TouchKill.SetToggleState(false, false);
                    TouchCooldown.SetToggleState(false, false);
                    TouchClues.SetToggleState(false, false);
                    TouchGrenade.SetToggleState(false, false);
                    TouchBeartrap.SetToggleState(false, false);
                    TouchVoteOut.SetToggleState(false, false);
                    if (!val) touchsystoggle = string.Empty;
                });

                TouchFlash = TouchSystemButtons.AddToggleButton("Flash", "Flashes when you close your fist next to someone (Use K in Desktop)", "Flashes when you close your fist next to someone (Use K in Desktop)", (val) =>
                {
                    touchsystoggle = "SyncFlashbang";
                    MelonCoroutines.Start(Utils.TouchSysAll());
                    TouchDetective.SetToggleState(false, false);
                    TouchMurderer.SetToggleState(false, false);
                    TouchBystander.SetToggleState(false, false);
                    TouchKill.SetToggleState(false, false);
                    TouchCooldown.SetToggleState(false, false);
                    TouchClues.SetToggleState(false, false);
                    TouchGrenade.SetToggleState(false, false);
                    TouchBeartrap.SetToggleState(false, false);
                    TouchVoteOut.SetToggleState(false, false);
                    if (!val) touchsystoggle = string.Empty;
                });

                TouchKill = TouchSystemButtons.AddToggleButton("Kill", "Kills when you close your fist next to someone (Use K in Desktop)", "Kills when you close your fist next to someone (Use K in Desktop)", (val) =>
                {
                    touchsystoggle = "Kill";
                    MelonCoroutines.Start(Utils.TouchSysAll());
                    TouchDetective.SetToggleState(false, false);
                    TouchMurderer.SetToggleState(false, false);
                    TouchFlash.SetToggleState(false, false);
                    TouchBystander.SetToggleState(false, false);
                    TouchCooldown.SetToggleState(false, false);
                    TouchClues.SetToggleState(false, false);
                    TouchGrenade.SetToggleState(false, false);
                    TouchBeartrap.SetToggleState(false, false);
                    TouchVoteOut.SetToggleState(false, false);
                    if (!val) touchsystoggle = string.Empty;
                });

                TouchCooldown = TouchSystemButtons.AddToggleButton("Cooldown", "Cooldowns when you close your fist next to someone (Use K in Desktop)", "Gives Murderer when you close your fist next to someone (Use K in Desktop)", (val) =>
                {
                    touchsystoggle = "SyncFriendlyStab";
                    MelonCoroutines.Start(Utils.TouchSysAll());
                    TouchDetective.SetToggleState(false, false);
                    TouchMurderer.SetToggleState(false, false);
                    TouchFlash.SetToggleState(false, false);
                    TouchKill.SetToggleState(false, false);
                    TouchBystander.SetToggleState(false, false);
                    TouchClues.SetToggleState(false, false);
                    TouchGrenade.SetToggleState(false, false);
                    TouchBeartrap.SetToggleState(false, false);
                    TouchVoteOut.SetToggleState(false, false);
                    if (!val) touchsystoggle = string.Empty;
                });

                TouchClues = TouchSystemButtons.AddToggleButton("Give Clues", "Gives Clues when you close your fist next to someone (Use K in Desktop)", "Gives Murderer when you close your fist next to someone (Use K in Desktop)", (val) =>
                {
                    touchsystoggle = "Clues";
                    MelonCoroutines.Start(Utils.TouchSysAll());
                    TouchDetective.SetToggleState(false, false);
                    TouchMurderer.SetToggleState(false, false);
                    TouchFlash.SetToggleState(false, false);
                    TouchKill.SetToggleState(false, false);
                    TouchCooldown.SetToggleState(false, false);
                    TouchBystander.SetToggleState(false, false);
                    TouchGrenade.SetToggleState(false, false);
                    TouchBeartrap.SetToggleState(false, false);
                    TouchVoteOut.SetToggleState(false, false);
                    if (!val) touchsystoggle = string.Empty;
                });

                TouchGrenade = TouchSystemButtons.AddToggleButton("Explode Grenade", "Explode a Grenade when you close your fist next to someone (Use K in Desktop)", "Explode a Grenadep when you close your fist next to someone (Use K in Desktop)", (val) =>
                {
                    touchsystoggle = "Grenade";
                    MelonCoroutines.Start(Utils.TouchSysAll());
                    TouchDetective.SetToggleState(false, false);
                    TouchMurderer.SetToggleState(false, false);
                    TouchFlash.SetToggleState(false, false);
                    TouchKill.SetToggleState(false, false);
                    TouchCooldown.SetToggleState(false, false);
                    TouchBystander.SetToggleState(false, false);
                    TouchClues.SetToggleState(false, false);
                    TouchBeartrap.SetToggleState(false, false);
                    TouchVoteOut.SetToggleState(false, false);
                    if (!val) touchsystoggle = string.Empty;
                });

                TouchBeartrap = TouchSystemButtons.AddToggleButton("Spawn Beartrap", "Spawns Beartrap when you close your fist next to someone (Use K in Desktop)", "Spawns a Beartrap when you close your fist next to someone (Use K in Desktop)", (val) =>
                {
                    touchsystoggle = "Beartrap";
                    MelonCoroutines.Start(Utils.TouchSysAll());
                    TouchDetective.SetToggleState(false, false);
                    TouchMurderer.SetToggleState(false, false);
                    TouchFlash.SetToggleState(false, false);
                    TouchKill.SetToggleState(false, false);
                    TouchCooldown.SetToggleState(false, false);
                    TouchBystander.SetToggleState(false, false);
                    TouchClues.SetToggleState(false, false);
                    TouchGrenade.SetToggleState(false, false);
                    TouchVoteOut.SetToggleState(false, false);
                    if (!val) touchsystoggle = string.Empty;
                });

                TouchVoteOut = TouchSystemButtons.AddToggleButton("Vote Out", "Get the player out of the map when you close your fist next to someone (Use K in Desktop)", "Get the player out of the map when you close your fist next to someone (Use K in Desktop)", (val) =>
                {
                    touchsystoggle = "SyncVotedOut";
                    MelonCoroutines.Start(Utils.TouchSysAll());
                    TouchBystander.SetToggleState(false, false);
                    TouchDetective.SetToggleState(false, false);
                    TouchMurderer.SetToggleState(false, false);
                    TouchFlash.SetToggleState(false, false);
                    TouchKill.SetToggleState(false, false);
                    TouchCooldown.SetToggleState(false, false);
                    TouchClues.SetToggleState(false, false);
                    TouchClues.SetToggleState(false, false);
                    TouchGrenade.SetToggleState(false, false);
                    TouchBeartrap.SetToggleState(false, false);
                    if (!val) touchsystoggle = string.Empty;
                });
                #endregion

                #region PatronList

                PatronList = MainMenuButtons.AddSimpleSingleButton("Patrons List", "", () =>
                {
                    Murder4Patron.OpenMenu();
                    Murder4PatronButtons.gameObject.transform.DestroyChildren();
                    foreach (var patrons in Murder4.Patrons)
                    {
                        Murder4PatronButtons.AddSimpleSingleButton(Utils.GetPlayerFromPlayeridInLobby(patrons).field_Private_VRCPlayerApi_0.displayName, "Delete from patrons", () =>
                        {
                            Murder4.Patrons.Remove(patrons);
                            foreach (var buttons in UnityEngine.Resources.FindObjectsOfTypeAll<TextMeshProUGUI>())
                            {
                                if (buttons.text == Utils.GetPlayerFromPlayeridInLobby(patrons).field_Private_VRCPlayerApi_0.displayName && Utils.GetGameObjectPath(buttons.gameObject).Contains("Murder4Patron"))
                                {
                                    UnityEngine.Object.DestroyImmediate(buttons.gameObject.transform.parent.gameObject);
                                }
                            }
                            if (Murder4.Patrons.Count == 0) givepatreon = false;
                        });
                    }
                }, true);

                PatronList.SetActive(false);

                #endregion

                #region Player

                Miscellaneous.AddSingleButton("Player", "Local Player Settings", () =>
                {
                    PlayerMenu.OpenMenu();
                }, true, ForbiddenClient.Resources.IconsVars.Player.LoadSprite());

                #region PlayerLocal

                Headlight = PlayerMenuLocal.AddToggleButton("Headlight", "Local Headlight", "Local Headlight", (val) =>
                {
                    Utils.ToggleHeadLight(!Utils.LightState);
                });

                #endregion

                #region PlayerMovement

                Noclip = PlayerMenuMovement.AddToggleButton("Noclip", null, null, (val) =>
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

                Speedhack = PlayerMenuMovement.AddToggleButton("Speedhack", null, null, (val) =>
                {
                    Features.Speedhack.speedEnabled = val;
                });

                Speedhack.SetToggleState(false, false);

                Jump = PlayerMenuMovement.AddToggleButton("Enable Jump", "Enables Jump in World", "Enables Jump in World", (val) =>
                {
                    Create.Ini.SetBool("Toggles", "Jump", val);
                    Utils.EnableJump();
                });
                Jump.SetToggleState(Create.Ini.GetBool("Toggles", "Jump"));

                PlayerMenuMovement.AddToggleButton("Infinite Jump", "Infinite Jump", "Infinite Jump", (val) =>
                {
                    Features.InfiniteJump.InfJumpEnabled = val;
                });

                PlayerMenuMovement.AddToggleButton("Auto BHOP", "Auto BHOP", "Auto BHOP", (val) =>
                {
                    Features.InfiniteJump.BHOP = val;
                });

                PlayerMenu.AddSlider("Speedhack Speed", null, (val) =>
                {
                    Features.Speedhack.speedMultiplier = val;
                    FlightMod.Flight.flySpeed = val;
                }, 1, 20, 5);

                #endregion

                ESP = Miscellaneous.AddToggleButton("ESP", "Allows you to see players through walls", "Allows you to see players through walls", (val) =>
                {
                    Create.Ini.SetBool("Toggles", "ESP", val);
                    if (val)
                    {
                        Features.ESP.ESPEnabled = true;
                        Features.ESP.ToggleESP(true);
                    }
                    else
                    {
                        Features.ESP.ESPEnabled = false;
                        Features.ESP.ToggleESP(false);
                    }
                });

                ESP.SetToggleState(Create.Ini.GetBool("Toggles", "ESP"));

                Miscellaneous.AddToggleButton("Pickup ESP", "", "", (val) =>
                {
                    if (val)
                    {
                        ForbiddenMain.PickupESP = val;
                    }
                    else
                    {
                        ForbiddenMain.PickupESP = val;
                        Features.ESP.PickupESP(false);
                    }
                }).SetToggleState(false, false);

                #endregion

                //#region Settings

                //Miscellaneous.AddSingleButton("Settings", null, () =>
                //{
                //    UIMenu.OpenMenu();
                //}, true, ForbiddenClient.Resources.IconsVars.Settings.LoadSprite());

                //#region UIColour

                //UIMenuButtons.AddSingleButton("UI Colour", null, () =>
                //{
                //    UIColour.OpenMenu();
                //}, true, ForbiddenClient.Resources.IconsVars.UIColour.LoadSprite());

                //RedColour = UIColour.AddSlider("Red", null, (val) =>
                //{
                //    Create.Ini.SetFloat("UIColour", "Red", val / 255);
                //    Features.UIColor.Red = val / 255;
                //    awa.transform.Find("Background").GetComponent<Image>().color = new Color(UIColor.Red, UIColor.Green, UIColor.Blue, 1);
                //}, 0, 255, Create.Ini.GetFloat("UIColour", "Red") * 255, false, false);

                //RedColour.SetValue(Create.Ini.GetFloat("UIColour", "Red") * 255);

                //GreenColour = UIColour.AddSlider("Green", null, (val) =>
                //{
                //    Create.Ini.SetFloat("UIColour", "Green", val / 255);
                //    Features.UIColor.Green = val / 255;
                //    awa.transform.Find("Background").GetComponent<Image>().color = new Color(UIColor.Red, UIColor.Green, UIColor.Blue, 1);
                //}, 0, 255, Create.Ini.GetFloat("UIColour", "Green") * 255, false, false);

                //GreenColour.SetValue(Create.Ini.GetFloat("UIColour", "Green") * 255);

                //BlueColour = UIColour.AddSlider("Blue", null, (val) =>
                //{
                //    Create.Ini.SetFloat("UIColour", "Blue", val / 255);
                //    UIColor.Blue = val / 255;
                //    awa.transform.Find("Background").GetComponent<Image>().color = new Color(UIColor.Red, UIColor.Green, UIColor.Blue, 1);
                //}, 0, 255, Create.Ini.GetFloat("UIColour", "Blue") * 255, false, false);

                //BlueColour.SetValue(Create.Ini.GetFloat("UIColour", "Blue"));

                //ApplyUiColour = UIColourButtons.AddSimpleSingleButton("Apply", null, () =>
                //{
                //    UIColor.action = "Apply";
                //    UIColor.Thread();
                //});

                //ResetUIColour = UIColourButtons.AddSimpleSingleButton("Reset", null, () =>
                //{
                //    awa.transform.Find("Background").gameObject.GetComponent<Image>().color = new Color(1, 0, 1, 1);
                //    UIColor.action = "Reset";
                //    UIColor.Thread();
                //});

                //awa = UnityEngine.Object.Instantiate<Transform>(ResetUIColour.transform, UIColourButtons.transform);
                //awa.name = "Preview";
                //awa.transform.Find("Text_H4").gameObject.active = false;
                //awa.GetComponent<StyleElement>().enabled = false;
                //awa.GetComponent<Button>().enabled = false;
                //awa.GetComponent<CanvasGroup>().enabled = false;
                //awa.GetComponent<LayoutElement>().enabled = false;
                //awa.transform.Find("Icon").gameObject.active = false;
                //UnityEngine.Object.DestroyImmediate(awa.transform.Find("Background").GetComponent<Image>());
                //if (Create.Ini.GetFloat("UIColour", "Red") == 277 ||
                //Create.Ini.GetFloat("UIColour", "Green") == 277 ||
                //Create.Ini.GetFloat("UIColour", "Blue") == 277)
                //{
                //    awa.transform.Find("Background").gameObject.AddComponent<Image>().color = new Color(1, 0, 1, 1);
                //}
                //else
                //{
                //    awa.transform.Find("Background").gameObject.AddComponent<Image>().color = new Color(UIColor.Red, UIColor.Green, UIColor.Blue, 1);
                //}
                //#endregion

                //#endregion
            };

            #region PlayerOptionsQuickMenu

            while (!ButtonAPI.HasInit || ButtonAPI.userinterface?.transform?.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_SelectedUser_Local/ScrollRect/Viewport/VerticalLayoutGroup") == null)
            {
                yield return null;
            }
            new Listeners().AddListeners();
            Player selectedplayer = null;

            GameObject gameObject = ButtonAPI.userinterface.transform.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_SelectedUser_Local/ScrollRect/Viewport/VerticalLayoutGroup").gameObject;

            var Murder4QuickMenu = MenuPage.CreatePage("Murder4QuickMenu", "Murder 4");

            var Murder4QuickMenuButtons = Murder4QuickMenu.AddButtonGroup(null);

            var Murder4RolesMenu = MenuPage.CreatePage("Murder4RolesMenu", "Murder 4 Roles");

            var Murder4RolesButtons = Murder4RolesMenu.AddButtonGroup(null);

            var AmongUsQuickMenu = MenuPage.CreatePage("AmongUsQuickMenu", "AmongUs", false);

            var AmongUsQuickMenuButtons = AmongUsQuickMenu.AddButtonGroup(null);

            var AmongUsRolesMenu = MenuPage.CreatePage("AmongUsRolesMenu", "AmongUs Roles", false);

            var AmongUsRolesButtons = AmongUsRolesMenu.AddButtonGroup(null);

            var Murder3QuickMenu = MenuPage.CreatePage("Murder3QuickMenu", "Murder 3", false);

            var Murder3QuickMenuButtons = Murder3QuickMenu.AddButtonGroup(null);

            var PrisonEscapeQuickMenu = MenuPage.CreatePage("PrisonEscapQuickMenu", "Prison Escape", false);

            var PrisonEscapeQuickMenuButtons = PrisonEscapeQuickMenu.AddButtonGroup(null);

            var PrisonEscapeScoreboard = MenuPage.CreatePage("PrisonEscapScoreboard", "Scoreboard", false);

            var PrisonEscapeScoreboardButtons = PrisonEscapeScoreboard.AddButtonGroup(null);

            var Murder3RolesMenu = MenuPage.CreatePage("Murder3RolesMenu", "Murder 3 Roles", false);

            var Murder3RolesButtons = Murder3RolesMenu.AddButtonGroup(null);

            var quickmenuplayeroptions = new ButtonGroup(gameObject.transform, "Forbidden Client\n");

            quickmenuplayeroptions.AddSimpleSingleButton("Teleport", "Teleports to player", () =>
            {
                selectedplayer = Utils.GetCurrentlySelectedPlayer();
                Utils.TPLocalPlayer(selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position);
            });

            #region Murder4Items

            Murder4QuickMenuButtons.AddSimpleSingleButton("Revolver", null, () =>
            {
                if (!Murder4.worldLoaded) return;
                MelonCoroutines.Start(Items.GivePickup(selectedplayer, Murder4Items.revolverobject));
            });

            Murder4QuickMenuButtons.AddSimpleSingleButton("Knife", null, () =>
            {
                if (!Murder4.worldLoaded) return;
                MelonCoroutines.Start(Items.GivePickup(selectedplayer, Murder4Items.knife));
            });

            Murder4QuickMenuButtons.AddSimpleSingleButton("Luger", null, () =>
            {
                if (!Murder4.worldLoaded) return;
                MelonCoroutines.Start(Items.GivePickup(selectedplayer, Murder4Items.luger));
            });

            Murder4QuickMenuButtons.AddSimpleSingleButton("Shotgun", null, () =>
            {
                if (!Murder4.worldLoaded) return;
                MelonCoroutines.Start(Items.GivePickup(selectedplayer, Murder4Items.shotgun));
            });

            Murder4QuickMenuButtons.AddSimpleSingleButton("Grenade", null, () =>
            {
                if (!Murder4.worldLoaded) return;
                MelonCoroutines.Start(Items.GivePickup(selectedplayer, Murder4Items.frag));
            });

            Murder4QuickMenuButtons.AddSimpleSingleButton("Smoke Bomb", null, () =>
            {
                if (!Murder4.worldLoaded) return;
                MelonCoroutines.Start(Items.GivePickup(selectedplayer, Murder4Items.smokebomb));
            });

            Murder4QuickMenuButtons.AddSimpleSingleButton("Bear Trap", null, () =>
            {
                if (!Murder4.worldLoaded) return;
                MelonCoroutines.Start(Items.GivePickup(selectedplayer, Murder4Items.Beartrap));
            });

            Murder4QuickMenuButtons.AddSimpleSingleButton("Kill Frag", null, () =>
            {
                if (!Murder4.worldLoaded) return;
                try
                {
                    MelonCoroutines.Start(Murder4.KillSelectedPlayerFrag(selectedplayer));
                    MelonCoroutines.Stop(Murder4.KillSelectedPlayerFrag(selectedplayer));
                }
                catch { }
            });
            Murder4QuickMenuButtons.AddSimpleSingleButton("Kill", null, () =>
            {
                if (!Murder4.worldLoaded) return;
                Utils.SetRole(selectedplayer, "Kill");
            });

            Murder4QuickMenuButtons.AddSimpleSingleButton("Give Clues", null, () =>
            {
                if (!Murder4.worldLoaded) return;
                Utils.SetRole(selectedplayer, "Clues");
            });

            Murder4QuickMenuButtons.AddSimpleSingleButton("Give Roles", null, () =>
            {
                if (!Murder4.worldLoaded) return;
                Murder4RolesMenu.OpenMenu();
            }, true);

            Murder4RolesButtons.AddSimpleSingleButton("Bystander", null, () =>
            {
                if (!Murder4.worldLoaded) return;
                Utils.SetRole(selectedplayer, "Bystander");
            });

            Murder4RolesButtons.AddSimpleSingleButton("Detective", null, () =>
            {
                if (!Murder4.worldLoaded) return;
                Utils.SetRole(selectedplayer, "Detective");
            });

            Murder4RolesButtons.AddSimpleSingleButton("Murderer", null, () =>
            {
                if (!Murder4.worldLoaded) return;
                Utils.SetRole(selectedplayer, "Murderer");
            });

            Murder4QuickMenuButtons.AddSimpleSingleButton("Give Patreon", null, () =>
            {
                if (!Murder4.worldLoaded) return;
                givepatreon = true;
                if (!Murder4.Patrons.Contains(selectedplayer.prop_VRCPlayerApi_0.playerId))
                {
                    Murder4.Patrons.Add(selectedplayer.prop_VRCPlayerApi_0.playerId);
                }
            });

            Murder4QuickMenuButtons.AddToggleButton("Auto Kill", null, null, (val) =>
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

            Murder4QuickMenuButtons.AddToggleButton("Respawn Annoy", null, null, (val) =>
            {
                if (!Murder4.worldLoaded) return;
                if (val)
                {
                    Murder4.respawnannoy = true;
                    PatchManager.player = selectedplayer;
                    MelonCoroutines.Start(Murder4.RespawnAnnoy(selectedplayer));
                }
                else
                {
                    Murder4.respawnannoy = false;
                }
            }).SetToggleState(false, false);

            #endregion

            #region Murder3Items

            Murder3QuickMenuButtons.AddSimpleSingleButton("Revolver", null, () =>
            {
                if (!Murder3.worldLoaded) return;
                Items.TakeOwnershipIfNecessary(Murder4Items.revolverobject);
                Murder4Items.revolverobject.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
            });

            Murder3QuickMenuButtons.AddSimpleSingleButton("Knife", null, () =>
            {
                if (!Murder3.worldLoaded) return;
                Items.TakeOwnershipIfNecessary(Murder4Items.knife);
                Murder4Items.knife.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
            });

            Murder3QuickMenuButtons.AddSimpleSingleButton("Luger", null, () =>
            {
                if (!Murder3.worldLoaded) return;
                Items.TakeOwnershipIfNecessary(Murder4Items.luger);
                Murder4Items.luger.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
            });

            Murder3QuickMenuButtons.AddSimpleSingleButton("Shotgun", null, () =>
            {
                if (!Murder3.worldLoaded) return;
                Items.TakeOwnershipIfNecessary(Murder4Items.shotgun);
                Murder4Items.shotgun.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
            });

            Murder3QuickMenuButtons.AddSimpleSingleButton("Grenade", null, () =>
            {
                if (!Murder3.worldLoaded) return;
                Items.TakeOwnershipIfNecessary(Murder4Items.frag);
                Murder4Items.frag.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
            });

            Murder3QuickMenuButtons.AddSimpleSingleButton("Smoke Bomb", null, () =>
            {
                if (!Murder3.worldLoaded) return;
                Items.TakeOwnershipIfNecessary(Murder4Items.smokebomb);
                Murder4Items.smokebomb.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
            });

            Murder3QuickMenuButtons.AddSimpleSingleButton("Bear Trap", null, () =>
            {
                if (!Murder3.worldLoaded) return;
                Items.TakeOwnershipIfNecessary(Murder4Items.Beartrap);
                Murder4Items.Beartrap.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
            });

            Murder3QuickMenuButtons.AddSimpleSingleButton("Kill Frag", null, () =>
            {
                if (!Murder3.worldLoaded) return;
                try
                {
                    MelonCoroutines.Start(Murder3.KillSelectedPlayerFrag(selectedplayer));
                    MelonCoroutines.Stop(Murder3.KillSelectedPlayerFrag(selectedplayer));
                }
                catch { }
            });

            Murder3QuickMenuButtons.AddSimpleSingleButton("Kill", null, () =>
            {
                if (!Murder3.worldLoaded) return;
                Utils.SetRole(selectedplayer, "Kill");
            });

            Murder3QuickMenuButtons.AddSimpleSingleButton("Give Clues", null, () =>
            {
                if (!Murder3.worldLoaded) return;
                Utils.SetRole(selectedplayer, "Clues");
            });

            Murder3QuickMenuButtons.AddSimpleSingleButton("Give Roles", null, () =>
            {
                if (!Murder3.worldLoaded) return;
                Murder3RolesMenu.OpenMenu();
            }, true);

            Murder3RolesButtons.AddSimpleSingleButton("Bystander", null, () =>
            {
                if (!Murder3.worldLoaded) return;
                Utils.SetRole(selectedplayer, "Bystander");
            });

            Murder3RolesButtons.AddSimpleSingleButton("Detective", null, () =>
            {
                if (!Murder3.worldLoaded) return;
                Utils.SetRole(selectedplayer, "Detective");
            });

            Murder3RolesButtons.AddSimpleSingleButton("Murderer", null, () =>
            {
                if (!Murder3.worldLoaded) return;
                Utils.SetRole(selectedplayer, "Murderer");
            });

            Murder3QuickMenuButtons.AddToggleButton("Give Patreon", null, null, (val) =>
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

            Murder3QuickMenuButtons.AddToggleButton("Auto Kill", null, null, (val) =>
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

            #region AmongUsTarget

            AmongUsQuickMenuButtons.AddSimpleSingleButton("Give Roles", null, () =>
            {
                if (!AmongUs.worldLoaded) return;
                AmongUsRolesMenu.OpenMenu();
            }, true);

            AmongUsRolesButtons.AddSimpleSingleButton("Crewmate", null, () =>
            {
                if (!AmongUs.worldLoaded) return;
                Utils.SetRole(selectedplayer, "Bystander");
            });

            AmongUsRolesButtons.AddSimpleSingleButton("Imposter", null, () =>
            {
                if (!AmongUs.worldLoaded) return;
                Utils.SetRole(selectedplayer, "Murderer");
            });

            AmongUsQuickMenuButtons.AddSimpleSingleButton("Kill", null, () =>
            {
                if (!AmongUs.worldLoaded) return;
                Utils.SetRole(selectedplayer, "Kill");
            });

            AmongUsQuickMenuButtons.AddSimpleSingleButton("Vote Out", null, () =>
            {
                if (!AmongUs.worldLoaded) return;
                Utils.SetRole(selectedplayer, "SyncVotedOut");
            });

            AmongUsQuickMenuButtons.AddToggleButton("Respawn Annoy", null, null, (val) =>
            {
                if (!AmongUs.worldLoaded) return;
                if (val)
                {
                    AmongUs.respawnannoy = true;
                    PatchManager.player = selectedplayer;
                    MelonCoroutines.Start(AmongUs.RespawnAnnoy(selectedplayer));
                }
                else
                {
                    AmongUs.respawnannoy = false;
                }
            }).SetToggleState(false, false);

            #endregion

            #region PrisonEscapeTarget

            #region PrisonScoreboard

            PrisonEscapeQuickMenuButtons.AddSimpleSingleButton("Change Scoreboard Values", null, () =>
            {
                if (!Prison.worldLoaded) return;
                PrisonEscapeScoreboard.OpenMenu();
                PrisonEscapeScoreboard.SetTitle(selectedplayer.prop_VRCPlayerApi_0.displayName + " Scoreboard");
            }, true);

            PrisonEscapeScoreboardButtons.AddSimpleSingleButton("Add Points", null, () =>
            {
                if (!Prison.worldLoaded) return;
                if (GameObject.Find("Scripts/Game Effects/Canvas HUD/Points Canvas/Points Changed Panel/Text Points Changed").GetComponent<TextMeshProUGUI>().text != "+50")
                {
                    try
                    {
                        Player.prop_Player_0.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("_AddWin");
                        GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
                    }
                    finally
                    {
                        selectedplayer.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints");
                        GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
                    }
                }
                else
                {
                    selectedplayer.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPoints");
                    GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
                }
                
            });

            PrisonEscapeScoreboardButtons.AddSimpleSingleButton("Add Guard Kill", null, () =>
            {
                if (!Prison.worldLoaded) return;
                selectedplayer.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("_AddGuardKill");
                GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
            });

            PrisonEscapeScoreboardButtons.AddSimpleSingleButton("Add Prisoner Kill", null, () =>
            {
                if (!Prison.worldLoaded) return;
                selectedplayer.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("__0__AddPrisKill");
                GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
            });

            PrisonEscapeScoreboardButtons.AddSimpleSingleButton("Add Escape", null, () =>
            {
                if (!Prison.worldLoaded) return;
                selectedplayer.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("_AddEscape");
                GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
            });

            PrisonEscapeScoreboardButtons.AddSimpleSingleButton("Add Win", null, () =>
            {
                if (!Prison.worldLoaded) return;
                selectedplayer.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("_AddWin");
                GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
            });

            PrisonEscapeScoreboardButtons.AddSimpleSingleButton("Reset Score", null, () =>
            {
                if (!Prison.worldLoaded) return;
                selectedplayer.GetPlayerScore().GetComponent<UdonBehaviour>().SendCustomEvent("_ClearScorecard");
                GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
            });

            PrisonEscapeScoreboardButtons.AddSimpleSingleButton("Clear All Player Data", null, () =>
            {
                if (!Prison.worldLoaded) return;
                selectedplayer.GetPlayerData().GetComponent<UdonBehaviour>().SendCustomEvent("_ClearData");
                GameObject.Find("Scripts/Scoreboard Display").GetComponent<UdonBehaviour>().SendCustomEvent("_UpdateScoreboard");
            });

            #endregion

            PrisonEscapeQuickMenuButtons.AddSimpleSingleButton("Kill", null, () =>
            {
                if (!Prison.worldLoaded) return;
                selectedplayer.GetPlayerData().GetComponent<UdonBehaviour>().SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "Damage250");
            });

            PrisonEscapeQuickMenuButtons.AddToggleButton("Stun Annoy Player", "Stuns The Player", (val) =>
            {
                if (!Prison.worldLoaded) return;
                Prison.stunannoy = val;
                MelonCoroutines.Start(Prison.StunAnnoy(selectedplayer));
            });

            PrisonEscapeQuickMenuButtons.AddToggleButton("Make Player Unable to Play", "Make Player Unable to Play", (val) =>
            {
                if (!Prison.worldLoaded) return;
                Prison.disableplayer = val;
                MelonCoroutines.Start(Prison.DisablePlayer(selectedplayer));
            });

            #endregion

            var Murder4Icon = ForbiddenClient.Resources.IconsVars.Knife.LoadSprite();

            quickmenuplayeroptions.AddSimpleSingleButton("TP Pickups", "TP all pickups to the target", () =>
            {
                selectedplayer = Utils.GetCurrentlySelectedPlayer();
                Items.ItemsToPlayer(selectedplayer);
            });

            Aimbot = quickmenuplayeroptions.AddToggleButton("Aim at", "Aim at", (val) =>
            {
                if (!PatchManager.worldloaded) return;
                if (val)
                {
                    selectedplayer = Utils.GetCurrentlySelectedPlayer();
                    Utils.Notification($"Aiming at: {selectedplayer.field_Private_VRCPlayerApi_0.displayName}", Color.red);
                    Utils.ConsoleLog(Utils.ConsoleLogType.Msg, $"Aiming at: {selectedplayer.field_Private_VRCPlayerApi_0.displayName}");
                    Utils.targetuwu = selectedplayer.gameObject;
                    Utils.aimatplayer = selectedplayer;

                }
                else
                {
                    Utils.targetuwu = null;
                    Utils.aimatplayer = null;
                }
            });

            WorldHacksPlayer = quickmenuplayeroptions.AddSingleButton("World Hacks", "Open World Target Options", () =>
            {
                selectedplayer = Utils.GetCurrentlySelectedPlayer();
                if (Murder4.worldLoaded)
                {
                    Murder4QuickMenu.OpenMenu();
                    Murder4QuickMenu.SetTitle(selectedplayer.prop_VRCPlayerApi_0.displayName);
                    Aimbot.SetTooltip($"Set Aimbot Target to {selectedplayer.prop_VRCPlayerApi_0.displayName}", $"Set Aimbot Target to {selectedplayer.prop_VRCPlayerApi_0.displayName}");
                }
                else if (Murder3.worldLoaded)
                {
                    Murder3QuickMenu.OpenMenu();
                    Murder3QuickMenu.SetTitle(selectedplayer.prop_VRCPlayerApi_0.displayName);
                }
                else if (AmongUs.worldLoaded)
                {
                    AmongUsQuickMenu.OpenMenu();
                    AmongUsQuickMenu.SetTitle(selectedplayer.prop_VRCPlayerApi_0.displayName);
                }
                else if (ForbiddenMain.Devs.Contains(APIUser.CurrentUser.id) && Prison.worldLoaded || APIUser.CurrentUser.id == "usr_2f003553-45a4-4d6e-878b-3ab9a7aff207" && Prison.worldLoaded)
                {
                    PrisonEscapeQuickMenu.OpenMenu();
                    PrisonEscapeQuickMenu.SetTitle(selectedplayer.prop_VRCPlayerApi_0.displayName);
                }
            }, true, Murder4Icon);

            WorldHacksPlayer.SetActive(false);

            GiveOneShotPrisonEscape = quickmenuplayeroptions.AddSimpleSingleButton("Give One Shot", null, () =>
            {
                Utils.ConsoleLog(Utils.ConsoleLogType.Msg, "Gave One Shot to: " + Utils.GetCurrentlySelectedPlayer().prop_VRCPlayer_0.field_Private_VRCPlayerApi_0.displayName, ConsoleColor.White, API.ConsoleUtils.Type.LogsType.Info);
                Prison.GiveOneShot = Utils.GetCurrentlySelectedPlayer();
            });

            GiveOneShotPrisonEscape.SetActive(false);

            //new SimpleSingleButton(quickmenuplayeroptions, "Fav/UnFav Avatar", "Favourite/Unfavourite avatar", () =>
            //{
            //    selectedplayer = Utils.GetCurrentlySelectedPlayer();
            //    if (!AvatarFavs.AvatarObjects.Exists(m => m.id == selectedplayer.prop_ApiAvatar_0.id))
            //    {
            //        AvatarFavs.FavouriteAvatar(selectedplayer.prop_ApiAvatar_0);
            //        MelonCoroutines.Start(AvatarFavs.RefreshMenu(1));
            //    }
            //    else
            //    {
            //        AvatarFavs.UnfavouriteAvatar(selectedplayer.prop_ApiAvatar_0);
            //        MelonCoroutines.Start(AvatarFavs.RefreshMenu(1));
            //    }
            //});

            quickmenuplayeroptions.AddSimpleSingleButton("Force Clone", null, () =>
            {
                selectedplayer = Utils.GetCurrentlySelectedPlayer();
                selectedplayer.CloneAvatar();
            });

            //new SimpleSingleButton(quickmenuplayeroptions, "Download VRCA", null, () =>
            //{
            //    selectedplayer = Utils.GetCurrentlySelectedPlayer();
            //    selectedplayer.DownloadAvatar(selectedplayer.prop_ApiAvatar_0.imageUrl);
            //});

            #endregion

            yield break;
        }
        
    }

}