using JoanpixerClient.Features.Worlds;
using PlagueButtonAPI;
using UnityEngine;
using UnityEngine.UI;
using JoanpixerClient.Modules;
using MelonLoader;
using VRC.SDKBase;

namespace JoanpixerClient
{
    internal class MenuUi
    {
        internal static void MainMenu()
        {
            Color bordercolor = Color.magenta;

            #region SubMenus
            //Menus
            var mainmenu = ButtonAPI.MakeEmptyPage("MainMenu", "Main Menu", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            var pianomenu = ButtonAPI.MakeEmptyPage("Piano", "Piano Songs", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            var murder42ndpage = ButtonAPI.MakeEmptyPage("Murder42ndpage", "Murder 4 2nd page", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            var Protections = ButtonAPI.MakeEmptyPage("Protections", "Protections", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            var Itemstpmurder = ButtonAPI.MakeEmptyPage("Murder4TpPlayerOptions", "Items Teleport", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            var playeroptions = ButtonAPI.MakeEmptyPage("PlayerOptions", "Player Options", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            var murderteleportmenu = ButtonAPI.MakeEmptyPage("TeleportMenu", "Teleports Murder 4", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            var murderteleport2nmenu = ButtonAPI.MakeEmptyPage("TeleportMenu2n", "Teleports Murder 4 2nd page", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            var amongussabotages = ButtonAPI.MakeEmptyPage("SabotagesMenu", "Sabotages", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            var Microphonemenu = ButtonAPI.MakeEmptyPage("Microphone", "Microphone Settings", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            var PickupsMenu = ButtonAPI.MakeEmptyPage("Pickups", "Pickups Exploits", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            var Murder4Annoy = ButtonAPI.MakeEmptyPage("Murder4Annoy", "Murder 4 Annoy", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            var worldssubmenu = ButtonAPI.MakeEmptyPage("WorldHacks", "Worlds Hacks", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            var WorldMurder4 = ButtonAPI.MakeEmptyPage("Murder4", "Murder 4", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            var WorldAmongUs = ButtonAPI.MakeEmptyPage("AmongUs", "Among Us", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            var Movement = ButtonAPI.MakeEmptyPage("Movement", "Movement", null,
                Color.magenta /*An Optional OnColour For The Title If You're Making It A Toggle, You Can Pass Null Otherwise*/,
                Color.white /*An Optional OffColour Here, This Sets The Standard Colour Of The Title, And The OnColour If Being Made A Toggle, If Either This Or OnColour Are Defined, It Will Use That Colour By Default If It Is Available, If Both Are Null, It Will Use Color.white.*/,
                null);

            #endregion

            #region MainMenu

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Main\nMenu", "Opens Main Menu", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, null/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(mainmenu/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, JoanpixerMain.MainMenuImage/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.PlagueButton Noclip = null;
            ButtonAPI.PlagueButton Speedhack = null;

            Noclip = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Noclip\nOff", "Allows you fly trough walls", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.TopButton, mainmenu.transform, delegate (bool a)
            {
                if (!Features.Noclip.noclipEnabled)
                {
                    a = Features.Noclip.noclipEnabled;
                    Noclip.SetText("Noclip\nOn");
                    Features.Noclip.Toggle();
                }
                else
                {
                    a = Features.Noclip.noclipEnabled;
                    Noclip.SetText("Noclip\nOff");
                    Features.Noclip.Toggle();
                }
            }, Color.red, Color.green, bordercolor, false, false, false, false, null, true);

            Speedhack = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Speedhack\nOff", "Allows you go faster", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.TopButton, mainmenu.transform, delegate (bool a)
            {
                if (!Features.Speedhack.speedEnabled)
                {
                    a = Features.Speedhack.speedEnabled;
                    Speedhack.SetText("Speedhack\nOn");
                    Features.Speedhack.Toggle();
                }
                else
                {
                    a = Features.Speedhack.speedEnabled;
                    Speedhack.SetText("Speedhack\nOff");
                    Features.Speedhack.Toggle();
                }
            }, Color.red, Color.green, bordercolor, false, true, false, false, null, true);

            ButtonAPI.PlagueButton ESP = null;

            ESP = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "ESP\nOff", "Allows you to see players through walls", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.SecondButton, mainmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Features.ESP.espEnabled)
                {
                    ESP.SetText("ESP\nOn");
                    Features.ESP.Toggle();
                }
                else
                {
                    ESP.SetText("ESP\nOff");
                    Features.ESP.Toggle();
                }
            }, Color.red, Color.green, bordercolor, false, false, false, false, null, true);

            #region Worlds

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Worlds", "Opens World Hacks", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, mainmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(worldssubmenu);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            #region Murder4

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Murder 4", "Opens Murder 4 Functions", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, worldssubmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(WorldMurder4);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //Murder 4 Exploits
            ButtonAPI.PlagueButton SpamRevolverEnable = null;
            ButtonAPI.PlagueButton SpamMeeting = null;
            ButtonAPI.PlagueButton LockDoors = null;
            ButtonAPI.PlagueButton LightOff = null;
            ButtonAPI.PlagueButton SoundsAnnoy = null;
            ButtonAPI.PlagueButton SoundsAnnoyFaster = null;

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Unlock Doors", "Unlocks all doors", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, WorldMurder4.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Murder4.UnLockDoors();
            }, Color.blue/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            #region Annoy

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Annoy", "Opens Annoying Functions", ButtonAPI.HorizontalPosition.FourthButtonPos, ButtonAPI.VerticalPosition.SecondButton, WorldMurder4.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(Murder4Annoy/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white, Color.magenta, bordercolor, true, false, false, false, null, true);

            SpamRevolverEnable = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Spam Revolver\nOff", "Spams Revolver Fire", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, Murder4Annoy.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Murder4.revolverspam = a;
                if (a)
                {
                    SpamRevolverEnable.SetText("Spam Revolver\nOn");
                    MelonCoroutines.Start(Murder4.Fire());
                }
                else
                {
                    SpamRevolverEnable.SetText("Spam Revolver\nOff");
                    MelonCoroutines.Stop(Murder4.Fire());
                }
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            LockDoors = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Lock Doors\nOff", "Locks all doors", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, Murder4Annoy.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Murder4.doorlock = a;
                if (a)
                {
                    LockDoors.SetText("Lock Doors\nOn");
                    MelonCoroutines.Start(Murder4.LockDoors());
                }
                else
                {
                    LockDoors.SetText("Lock Doors\nOff");
                    MelonCoroutines.Stop(Murder4.LockDoors());
                }
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            LightOff = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Lights Off\nOff", "", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.TopButton, Murder4Annoy.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Murder4.lightsoff = a;
                if (a)
                {
                    LightOff.SetText("Lights Off\nOn");
                    MelonCoroutines.Start(Murder4.TurnLightsOff());
                }
                else
                {
                    LightOff.SetText("Lights Off\nOff");
                    MelonCoroutines.Stop(Murder4.TurnLightsOff());
                }
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            SoundsAnnoy = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Spam sounds slow\nOff", null, ButtonAPI.HorizontalPosition.FourthButtonPos, ButtonAPI.VerticalPosition.TopButton, Murder4Annoy.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Murder4.spamsounds = a;
                if (a)
                {
                    MelonCoroutines.Stop(Murder4.SpamSounds(0));
                    SoundsAnnoyFaster.SetToggleState(false);
                    SoundsAnnoyFaster.SetText("Spam sounds fast\nOff");
                    SoundsAnnoyFaster.text.color = Color.red;
                    SoundsAnnoy.SetText("Spam sounds slow\nOn");
                    MelonCoroutines.Start(Murder4.SpamSounds(0.03f));
                }
                else
                {
                    SoundsAnnoy.SetText("Spam sounds slow\nOff");
                    MelonCoroutines.Stop(Murder4.SpamSounds(0.03f));
                }
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            SoundsAnnoyFaster = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Spam sounds fast\nOff", null, ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.SecondButton, Murder4Annoy.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Murder4.spamsounds = a;
                if (a)
                {
                    MelonCoroutines.Stop(Murder4.SpamSounds(0.03f));
                    SoundsAnnoy.SetToggleState(false);
                    SoundsAnnoy.SetText("Spam sounds slow\nOff");
                    SoundsAnnoy.text.color = Color.red;
                    SoundsAnnoyFaster.SetText("Spam sounds fast\nOn");
                    MelonCoroutines.Start(Murder4.SpamSounds(0));
                }
                else
                {
                    SoundsAnnoyFaster.SetText("Spam sounds fast\nOff");
                    MelonCoroutines.Stop(Murder4.SpamSounds(0));
                }
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            #endregion

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Lights On", "Turns Lights On", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.SecondButton, WorldMurder4.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Murder4.TurnLightsOn();
            }, Color.blue/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Start", "Forces Game Start", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, WorldMurder4.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Murder4.CallGameLogic("SyncStart");
            }, Color.green/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Abort Game", "Aborts Game", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.TopButton, WorldMurder4.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Murder4.CallGameLogic("SyncAbort");
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Bystanders Win", "Forces Bystanders to win", ButtonAPI.HorizontalPosition.FourthButtonPos, ButtonAPI.VerticalPosition.TopButton, WorldMurder4.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                MelonCoroutines.Start(Murder4.BWin());
                MelonCoroutines.Stop(Murder4.BWin());
            }, Color.blue/*ToggledOffColour*/, Color.magenta, bordercolor, true, false, false, false, null, true);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Murderer\nWin", "Forces Murderer to win", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.SecondButton, WorldMurder4.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Murder4.CallGameLogic("SyncVictoryM");
            }, Color.red, Color.red, bordercolor, true, false, false, false, null, true);

            ButtonAPI.PlagueButton Doors = null;

            Doors = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Doors\nOn", "Disables all doors", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.SecondButton, WorldMurder4.transform, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Murder4.doorcollision = a;
                if (a)
                {
                    Doors.SetText("Doors\nOff");
                    Murder4.doors.SetActive(false);
                }
                else
                {
                    Doors.SetText("Doors\nOn");
                    Murder4.doors.SetActive(true);
                }
            }, Color.green, Color.red, bordercolor, true, false, false, false, null, true);

            ButtonAPI.PlagueButton PatreonSelf = null;

            PatreonSelf = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Patreon Self\nOff", "Gives patreon to you", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.BottomButton, WorldMurder4.transform/*Your Parent Transform*/, delegate (bool a)
            {
                Murder4.patreonself = a;
                if (a)
                {
                    PatreonSelf.SetText("Patreon Self\nOn");
                    MelonCoroutines.Start(Murder4.GivePatreonSelf());
                }
                else
                {
                    PatreonSelf.SetText("Patreon Self\nOff");
                    MelonCoroutines.Stop(Murder4.GivePatreonSelf());
                    Murder4.CallRevolver("NonPatronSkin");
                }
            }, Color.red, Color.magenta, bordercolor, true, false, false, false, null, true);

            ButtonAPI.PlagueButton MurderxD = null;

            MurderxD = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Show Murderer", "Shows you the Murderer", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.BottomButton, WorldMurder4.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                var Murderer = Murder4.MurderText.GetComponent<Text>().m_Text;
                MurderxD.SetTooltip($"Murderer is {Murderer}");
            }, Color.white, Color.magenta, bordercolor, true, false, false, false, null, true);

            ButtonAPI.PlagueButton Beartraps = null;

            Beartraps = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Pickup Beartraps\nOff", "Allows you to pickup Beartraps even being bystander", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.BottomButton, WorldMurder4.transform/*Your Parent Transform*/, delegate (bool a)
            {
                Murder4.pickupweapontoggle = a;
                if (a)
                {
                    Beartraps.SetText("Pickup Beartraps\nOn");
                    MelonCoroutines.Start(Murder4.PickupBearTraps());
                    MelonCoroutines.Stop(Murder4.PickupBearTraps());
                }
                else
                {
                    Beartraps.SetText("Pickup Beartraps\nOff");
                    Murder4.DisablePickupBearTraps();
                }
            }, Color.red, Color.magenta, bordercolor, true, false, false, false, null, true);

            ButtonAPI.PlagueButton PickupWeapons = null;


            PickupWeapons = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Pickup Weapon in Cooldown\nOff", "Allows you to pickup every weapon that's in cooldown", ButtonAPI.HorizontalPosition.FourthButtonPos, ButtonAPI.VerticalPosition.BottomButton, WorldMurder4.transform/*Your Parent Transform*/, delegate (bool a)
            {
                Murder4.pickupweapontoggle = a;
                if (a)
                {
                    PickupWeapons.SetText("Pickup Weapon in Cooldown\nOn");
                    MelonCoroutines.Start(Murder4.PickupWeaponInCooldown());
                }
                else
                {
                    PickupWeapons.SetText("Pickup Weapon in Cooldown\nOff");
                    MelonCoroutines.Stop(Murder4.PickupWeaponInCooldown());
                }
            }, Color.red, Color.magenta, bordercolor, true, false, false, false, null, true);

            #region Murder42ndpage

            #region Murder4 Teleport Menu Buttons
            ///Teleports
            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Teleports", "Opens Teleports menu", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, murder42ndpage.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(murderteleportmenu/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white, Color.magenta, bordercolor, true, false, false, false, null, true);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Next page", "2nd page of teleports", ButtonAPI.HorizontalPosition.RightOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, murderteleportmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(murderteleport2nmenu/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white, Color.magenta, bordercolor, false, true, false, false, null, true);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back page", "1st page of teleports", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, murderteleport2nmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(murderteleportmenu/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white, Color.magenta, bordercolor, false, true, false, false, null, true);
            #endregion

            #region Murder4 Teleports
            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Kitchen", null, ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, murderteleportmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Utils.GetLocalPlayer().transform.position = new Vector3(-20.8f, 0, 121.6f);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Lounge", null, ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, murderteleportmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Utils.GetLocalPlayer().transform.position = new Vector3(-15.9f, 0, 130.1f);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Dining Room", null, ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.TopButton, murderteleportmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Utils.GetLocalPlayer().transform.position = new Vector3(-11.3f, 0, 119.2f);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Grand Hall", null, ButtonAPI.HorizontalPosition.FourthButtonPos, ButtonAPI.VerticalPosition.TopButton, murderteleportmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Utils.GetLocalPlayer().transform.position = new Vector3(0.6f, 0, 116.4f);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Library", null, ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.SecondButton, murderteleportmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Utils.GetLocalPlayer().transform.position = new Vector3(12.2f, 0, 119.7f);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Piano", null, ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.SecondButton, murderteleportmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Utils.GetLocalPlayer().transform.position = new Vector3(15.9f, 0, 131.5f);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Garage", null, ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.SecondButton, murderteleportmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Utils.GetLocalPlayer().transform.position = new Vector3(17.3f, 0, 140.4f);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Outside", null, ButtonAPI.HorizontalPosition.FourthButtonPos, ButtonAPI.VerticalPosition.SecondButton, murderteleportmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Utils.GetLocalPlayer().transform.position = new Vector3(2.8f, 0, 140.5f);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Conservatory", null, ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.BottomButton, murderteleportmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Utils.GetLocalPlayer().transform.position = new Vector3(-0.4f, 0, 146);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Billard", null, ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.BottomButton, murderteleportmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Utils.GetLocalPlayer().transform.position = new Vector3(-14.7f, 0, 140.2f);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Cellar", null, ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.BottomButton, murderteleportmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Utils.GetLocalPlayer().transform.position = new Vector3(-2.1f, -3, 130.8f);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Bedroom", null, ButtonAPI.HorizontalPosition.FourthButtonPos, ButtonAPI.VerticalPosition.BottomButton, murderteleportmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Utils.GetLocalPlayer().transform.position = new Vector3(-9.9f, 3.6f, 129.2f);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Detective\nRoom", null, ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, murderteleport2nmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Utils.GetLocalPlayer().transform.position = new Vector3(5, 3, 122.8f);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Bathroom", null, ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, murderteleport2nmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Utils.GetLocalPlayer().transform.position = new Vector3(-0.4f, 3, 133.4f);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Closet", null, ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.TopButton, murderteleport2nmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Utils.GetLocalPlayer().transform.position = new Vector3(0.4673f, 2.995f, 124.234f);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);
            #endregion

            #region Piano Songs

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Piano Songs", "Allows you play any song you want to", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, murder42ndpage.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(pianomenu);
            }, Color.white, Color.magenta, bordercolor, true, false, false, false, null, true);

            ButtonAPI.PlagueButton Jojos = null;
            ButtonAPI.PlagueButton Moonlight = null;
            ButtonAPI.PlagueButton Believing = null;
            ButtonAPI.PlagueButton ClocksColdplay = null;
            ButtonAPI.PlagueButton Imagine = null;
            ButtonAPI.PlagueButton megalovania = null;
            ButtonAPI.PlagueButton LinusnLucy = null;

            Jojos = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "JoJo's\nOff", "Giorno's Theme", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, pianomenu.transform /*Your Parent Transform*/, delegate(bool a)
                {
                    Murder4.jojossong = a;
                    Murder4.Prestoagitato = false;
                    Murder4.Believing = false;
                    Murder4.ClocksColdplay = false;
                    Murder4.imagine = false;
                    Murder4.megalovania = false;
                    Murder4.LinusnLucy = false;
                    if (a)
                    {
                        MelonCoroutines.Stop(Murder4.PlayPiano());
                        Moonlight.SetToggleState(false);
                        Moonlight.text.color = Color.red;
                        Believing.SetToggleState(false);
                        Believing.text.color = Color.red;
                        ClocksColdplay.SetToggleState(false);
                        ClocksColdplay.text.color = Color.red;
                        megalovania.SetToggleState(false);
                        megalovania.text.color = Color.red;
                        Imagine.SetToggleState(false);
                        Imagine.SetText("Imagine\nOff");
                        LinusnLucy.SetToggleState(false);
                        LinusnLucy.text.color = Color.red;
                        LinusnLucy.SetText("LinusnLucy\nOff");
                        Imagine.text.color = Color.red;
                        Jojos.SetText("JoJo's\nOn");
                        Moonlight.SetText("Presto Agitato\nOff");
                        Believing.SetText("Believing\nOff");
                        ClocksColdplay.SetText("Clocks\nOff");
                        megalovania.SetText("Megalovania\nOff");
                        MelonCoroutines.Start(Murder4.PlayPiano());
                    }
                    else
                    {
                        Jojos.SetText("JoJo's\nOff");
                        MelonCoroutines.Stop(Murder4.PlayPiano());
                    }
                }, Color.red, Color.magenta, bordercolor, true, false, false, false, null, true);

            Moonlight = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Presto Agitato\nOff", "Moonlight Sonata 3rd movement", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, pianomenu.transform /*Your Parent Transform*/, delegate (bool a)
                {
                    Murder4.jojossong = false;
                    Murder4.Prestoagitato = a;
                    Murder4.Believing = false;
                    Murder4.ClocksColdplay = false;
                    Murder4.imagine = false;
                    Murder4.megalovania = false;
                    Murder4.LinusnLucy = false;
                    if (a)
                    {
                        MelonCoroutines.Stop(Murder4.PlayPiano());
                        Jojos.SetToggleState(false);
                        Jojos.text.color = Color.red;
                        Believing.SetToggleState(false);
                        Believing.text.color = Color.red;
                        ClocksColdplay.SetToggleState(false);
                        ClocksColdplay.text.color = Color.red;
                        megalovania.SetToggleState(false);
                        megalovania.text.color = Color.red;
                        Imagine.SetToggleState(false);
                        Imagine.SetText("Imagine\nOff");
                        Imagine.text.color = Color.red;
                        LinusnLucy.SetToggleState(false);
                        LinusnLucy.text.color = Color.red;
                        LinusnLucy.SetText("LinusnLucy\nOff");
                        Jojos.SetText("JoJo's\nOff");
                        Moonlight.SetText("Presto Agitato\nOn");
                        Believing.SetText("Believing\nOff");
                        ClocksColdplay.SetText("Clocks\nOff");
                        megalovania.SetText("Megalovania\nOff");
                        MelonCoroutines.Start(Murder4.PlayPiano());
                    }
                    else
                    {
                        Moonlight.SetText("Presto Agitato\nOff");
                        MelonCoroutines.Stop(Murder4.PlayPiano());
                    }
                }, Color.red, Color.magenta, bordercolor, true, false, false, false, null, true);

            Believing = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Believing\nOff", "Don't Stop Believing", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.TopButton, pianomenu.transform /*Your Parent Transform*/, delegate (bool a)
            {
                Murder4.jojossong = false;
                Murder4.Prestoagitato = false;
                Murder4.Believing = a;
                Murder4.ClocksColdplay = false;
                Murder4.imagine = false;
                Murder4.megalovania = false;
                Murder4.LinusnLucy = false;
                if (a)
                {
                    MelonCoroutines.Stop(Murder4.PlayPiano());
                    Jojos.SetToggleState(false);
                    Jojos.text.color = Color.red;
                    Moonlight.SetToggleState(false);
                    Moonlight.text.color = Color.red;
                    ClocksColdplay.SetToggleState(false);
                    ClocksColdplay.text.color = Color.red;
                    Imagine.SetToggleState(false);
                    Imagine.text.color = Color.red;
                    megalovania.SetToggleState(false);
                    megalovania.text.color = Color.red;
                    LinusnLucy.SetToggleState(false);
                    LinusnLucy.text.color = Color.red;
                    LinusnLucy.SetText("LinusnLucy\nOff");
                    Jojos.SetText("JoJo's\nOff");
                    Moonlight.SetText("Presto Agitato\nOff");
                    ClocksColdplay.SetText("Clocks\nOff");
                    Imagine.SetText("Imagine\nOff");
                    megalovania.SetText("Megalovania\nOff");
                    Believing.SetText("Believing\nOn");
                    MelonCoroutines.Start(Murder4.PlayPiano());
                }
                else
                {
                    Believing.SetText("Believing\nOff");
                    MelonCoroutines.Stop(Murder4.PlayPiano());
                }
            }, Color.red, Color.magenta, bordercolor, true, false, false, false, null, true);

            ClocksColdplay = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Clocks\nOff", "Clocks from Coldplay", ButtonAPI.HorizontalPosition.FourthButtonPos, ButtonAPI.VerticalPosition.TopButton, pianomenu.transform /*Your Parent Transform*/, delegate (bool a)
            {
                Murder4.jojossong = false;
                Murder4.Prestoagitato = false;
                Murder4.Believing = false;
                Murder4.ClocksColdplay = a;
                Murder4.imagine = false;
                Murder4.megalovania = false;
                Murder4.LinusnLucy = false;
                if (a)
                {
                    MelonCoroutines.Stop(Murder4.PlayPiano());
                    Jojos.SetToggleState(false);
                    Jojos.text.color = Color.red;
                    Moonlight.SetToggleState(false);
                    Moonlight.text.color = Color.red;
                    Believing.SetToggleState(false);
                    Believing.text.color = Color.red;
                    Imagine.SetToggleState(false);
                    Imagine.text.color = Color.red;
                    megalovania.SetToggleState(false);
                    megalovania.text.color = Color.red;
                    LinusnLucy.SetToggleState(false);
                    LinusnLucy.text.color = Color.red;
                    LinusnLucy.SetText("LinusnLucy\nOff");
                    Jojos.SetText("JoJo's\nOff");
                    Moonlight.SetText("Presto Agitato\nOff");
                    Believing.SetText("Believing\nOff");
                    Imagine.SetText("Imagine\nOff");
                    megalovania.SetText("Megalovania\nOff");
                    ClocksColdplay.SetText("Clocks\nOn");
                    MelonCoroutines.Start(Murder4.PlayPiano());
                }
                else
                {
                    ClocksColdplay.SetText("Clocks\nOff");
                    MelonCoroutines.Stop(Murder4.PlayPiano());
                }
            }, Color.red, Color.magenta, bordercolor, true, false, false, false, null, true);

            Imagine = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Imagine\nOff", "Imagine from Shari", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.SecondButton, pianomenu.transform /*Your Parent Transform*/, delegate (bool a)
            {
                Murder4.jojossong = false;
                Murder4.Prestoagitato = false;
                Murder4.Believing = false;
                Murder4.ClocksColdplay = false;
                Murder4.imagine = a;
                Murder4.megalovania = false;
                Murder4.LinusnLucy = false;
                if (a)
                {
                    MelonCoroutines.Stop(Murder4.PlayPiano());
                    Jojos.SetToggleState(false);
                    Jojos.text.color = Color.red;
                    Moonlight.SetToggleState(false);
                    Moonlight.text.color = Color.red;
                    Believing.SetToggleState(false);
                    Believing.text.color = Color.red;
                    ClocksColdplay.SetToggleState(false);
                    ClocksColdplay.text.color = Color.red;
                    megalovania.SetToggleState(false);
                    megalovania.text.color = Color.red;
                    LinusnLucy.SetToggleState(false);
                    LinusnLucy.text.color = Color.red;
                    LinusnLucy.SetText("LinusnLucy\nOff");
                    Jojos.SetText("JoJo's\nOff");
                    Moonlight.SetText("Presto Agitato\nOff");
                    Believing.SetText("Believing\nOff");
                    ClocksColdplay.SetText("Clocks\nOff");
                    megalovania.SetText("Megalovania\nOff");
                    Imagine.SetText("Imagine\nOn");
                    MelonCoroutines.Start(Murder4.PlayPiano());
                }
                else
                {
                    Imagine.SetText("Imagine\nOff");
                    MelonCoroutines.Stop(Murder4.PlayPiano());
                }
            }, Color.red, Color.magenta, bordercolor, true, false, false, false, null, true);

            megalovania = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Megalovania\nOff", "Megalovania from Undertale", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.SecondButton, pianomenu.transform /*Your Parent Transform*/, delegate (bool a)
            {
                Murder4.jojossong = false;
                Murder4.Prestoagitato = false;
                Murder4.Believing = false;
                Murder4.ClocksColdplay = false;
                Murder4.imagine = false;
                Murder4.megalovania = a;
                Murder4.LinusnLucy = false;
                if (a)
                {
                    MelonCoroutines.Stop(Murder4.PlayPiano());
                    Jojos.SetToggleState(false);
                    Jojos.text.color = Color.red;
                    Moonlight.SetToggleState(false);
                    Moonlight.text.color = Color.red;
                    Believing.SetToggleState(false);
                    Believing.text.color = Color.red;
                    ClocksColdplay.SetToggleState(false);
                    ClocksColdplay.text.color = Color.red;
                    LinusnLucy.SetToggleState(false);
                    LinusnLucy.text.color = Color.red;
                    LinusnLucy.SetText("LinusnLucy\nOff");
                    Imagine.SetToggleState(false);
                    Imagine.SetText("Imagine\nOff");
                    Imagine.text.color = Color.red;
                    Jojos.SetText("JoJo's\nOff");
                    Moonlight.SetText("Presto Agitato\nOff");
                    Believing.SetText("Believing\nOff");
                    ClocksColdplay.SetText("Clocks\nOff");
                    megalovania.SetText("Megalovania\nOn");
                    MelonCoroutines.Start(Murder4.PlayPiano());
                }
                else
                {
                    megalovania.SetText("Megalovania\nOff");
                    MelonCoroutines.Stop(Murder4.PlayPiano());
                }
            }, Color.red, Color.magenta, bordercolor, true, false, false, false, null, true);

            LinusnLucy = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "LinusnLucy\nOff", "Vince Guaraldi Trio - Linus And Lucy", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.SecondButton, pianomenu.transform /*Your Parent Transform*/, delegate (bool a)
            {
                Murder4.jojossong = false;
                Murder4.Prestoagitato = false;
                Murder4.Believing = false;
                Murder4.ClocksColdplay = false;
                Murder4.imagine = false;
                Murder4.megalovania = false;
                Murder4.LinusnLucy = a;
                if (a)
                {
                    MelonCoroutines.Stop(Murder4.PlayPiano());
                    Jojos.SetToggleState(false);
                    Jojos.text.color = Color.red;
                    Moonlight.SetToggleState(false);
                    Moonlight.text.color = Color.red;
                    Believing.SetToggleState(false);
                    Believing.text.color = Color.red;
                    ClocksColdplay.SetToggleState(false);
                    ClocksColdplay.text.color = Color.red;
                    Imagine.SetToggleState(false);
                    Imagine.SetText("Imagine\nOff");
                    Imagine.text.color = Color.red;
                    megalovania.SetToggleState(false);
                    megalovania.text.color = Color.red;
                    Jojos.SetText("JoJo's\nOff");
                    Moonlight.SetText("Presto Agitato\nOff");
                    Believing.SetText("Believing\nOff");
                    ClocksColdplay.SetText("Clocks\nOff");
                    megalovania.SetText("Megalovania\nOff");
                    LinusnLucy.SetText("LinusnLucy\nOn");
                    MelonCoroutines.Start(Murder4.PlayPiano());
                }
                else
                {
                    LinusnLucy.SetText("LinusnLucy\nOff");
                    MelonCoroutines.Stop(Murder4.PlayPiano());
                }
            }, Color.red, Color.magenta, bordercolor, true, false, false, false, null, true);

            #endregion

            #endregion

            #endregion

            #region Among Us

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Among Us", "Opens Among Us Functions", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, worldssubmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(WorldAmongUs);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //Among Us Exploits
            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Start", "Forces Game Start", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, WorldAmongUs.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!AmongUs.worldLoaded) return;
                AmongUs.CallUdonEvent("SyncStart");
            }, Color.green/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Abort Game", "Aborts Game", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, WorldAmongUs.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!AmongUs.worldLoaded) return;
                AmongUs.CallUdonEvent("SyncAbort");
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Crewmates\nWin", "Forces Crewmates to win", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.TopButton, WorldAmongUs.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!AmongUs.worldLoaded) return;
                AmongUs.CallUdonEvent("SyncVictoryB");
            }, Color.blue/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Imposters\nWin", "Forces Imposters to win", ButtonAPI.HorizontalPosition.FourthButtonPos, ButtonAPI.VerticalPosition.TopButton, WorldAmongUs.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!AmongUs.worldLoaded) return;
                AmongUs.CallUdonEvent("SyncVictoryM");
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Skip Vote", "Forces Skip Vote", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.SecondButton, WorldAmongUs.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!AmongUs.worldLoaded) return;
                AmongUs.CallUdonEvent("SyncVoteResultSkip");
                AmongUs.CallUdonEvent("SyncEndVotingPhase");
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Admin Scan", "Starts Admin Scan", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.SecondButton, WorldAmongUs.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!AmongUs.worldLoaded) return;
                AmongUs.CallUdonEvent("AdminScan");
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Kill Sound", "Global Kill Sound", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.SecondButton, WorldAmongUs.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!AmongUs.worldLoaded) return;
                AmongUs.CallUdonEvent("OnLocalPlayerKillsOther");
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            SpamMeeting = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Spam Meeting\nOff", "Respawns People with Meeting", ButtonAPI.HorizontalPosition.FourthButtonPos, ButtonAPI.VerticalPosition.SecondButton, WorldAmongUs.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!AmongUs.worldLoaded) return;
                AmongUs.enableEmergencySpam = a;
                if (a)
                {
                    SpamMeeting.SetText("Spam Meeting\nOn");
                    MelonCoroutines.Start(AmongUs.EmergencyButton());
                }
                else
                {
                    SpamMeeting.SetText("Spam Meeting\nOff");
                    MelonCoroutines.Stop(AmongUs.EmergencyButton());

                }
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            #region Among Us Sabotages
            //Sabotages
            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Sabotages\nMenu", "Opens Sabotages menu", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.BottomButton, WorldAmongUs.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(amongussabotages/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);
            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Sabotage All Doors", "Sabotages All Doors", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, amongussabotages.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!AmongUs.worldLoaded) return;
                AmongUs.CallUdonEvent("SyncDoSabotageDoorsElectrical");
                AmongUs.CallUdonEvent("SyncDoSabotageDoorsStorage");
                AmongUs.CallUdonEvent("SyncDoSabotageDoorsSecurity");
                AmongUs.CallUdonEvent("SyncDoSabotageDoorsLower");
                AmongUs.CallUdonEvent("SyncDoSabotageDoorsUpper");
                AmongUs.CallUdonEvent("SyncDoSabotageDoorsMedbay");
                AmongUs.CallUdonEvent("SyncDoSabotageDoorsCafeteria");
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Sabotage Lights", "Sabotages Lights", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, amongussabotages.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!AmongUs.worldLoaded) return;
                AmongUs.CallUdonEvent("SyncDoSabotageLights");
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Sabotage Comms", "Sabotages Communications", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.TopButton, amongussabotages.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!AmongUs.worldLoaded) return;
                AmongUs.CallUdonEvent("SyncDoSabotageComms");
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Sabotage Reactor", "Sabotages Reactor", ButtonAPI.HorizontalPosition.FourthButtonPos, ButtonAPI.VerticalPosition.TopButton, amongussabotages.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!AmongUs.worldLoaded) return;
                AmongUs.CallUdonEvent("SyncDoSabotageReactor");
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Sabotage Oxygen", "Sabotages Oxygen", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.SecondButton, amongussabotages.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!AmongUs.worldLoaded) return;
                AmongUs.CallUdonEvent("SyncDoSabotageOxygen");
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Repair All", "Repairs all including doors", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.SecondButton, amongussabotages.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!AmongUs.worldLoaded) return;
                AmongUs.CallUdonEvent("CancelAllSabotage");
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);
            #endregion

            #endregion

            ButtonAPI.PlagueButton GodMode = null;

            GodMode = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "GodMode\nOff", "Gives you Immortality", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.TopButton, worldssubmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                PatchManager.Godmode = a;
                if (a)
                {
                    GodMode.SetText("GodMode\nOn");
                }
                else
                {
                    GodMode.SetText("GodMode\nOff");

                }
            }, Color.red, Color.magenta, bordercolor, true, false, false, false, null, true);

            #endregion

            #region Movement

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Movement", "Opens Movement Menu", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.TopButton, mainmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(Movement/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Enable Jump", "Allows you to jump in the world", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, Movement.transform, delegate (bool a)
            {
                if (Networking.LocalPlayer.GetJumpImpulse() > 1f)
                {
                    MelonLogger.Msg("Enable Jump: Jump Already Enabled In World");
                }
                else
                {
                    Networking.LocalPlayer.SetJumpImpulse(4);
                }
            }, Color.white, Color.green, bordercolor, true, false, false, false, null, true);

            ButtonAPI.CreateSlider(Movement.transform, delegate (float v)
            {
                Features.Speedhack.speedMultiplier = v;
            }, (float)ButtonAPI.HorizontalPosition.SecondButtonPos, (float)ButtonAPI.VerticalPosition.SecondButton, "Speed Multiplier"/*Text Above The Slider*/, 5f/*The Initial Value When The Slider Is Created*/, 20f/*The Maximum Value The Slider Can Go*/, 5f/*The Minimum Value The Slider Can Go*/);


            #endregion

            #region Protections

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Protections", "Opens Protections Menu", ButtonAPI.HorizontalPosition.FourthButtonPos, ButtonAPI.VerticalPosition.TopButton, mainmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(Protections/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.PlagueButton AntiUdon = null;

            AntiUdon = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Anti Udon\nOff", "Blocks Every Udon Event", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, Protections.transform/*Your Parent Transform*/, delegate (bool a)
            {
                PatchManager.AntiUdon = a;
                AntiUdon.SetText(a ? "Anti Udon\nOn" : "Anti Udon\nOff");
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.PlagueButton AntiPortal = null;

            AntiPortal = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Portal Walkthrough\nOff", "Allows you to walk trough Portals", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, Protections.transform/*Your Parent Transform*/, delegate (bool a)
            {
                PatchManager.PortalWalk = a;
                if (a)
                {
                    AntiPortal.SetText("Portal Walkthrough\nOn");
                }
                else
                {
                    AntiPortal.SetText("Portal Walkthrough\nOff");
                }
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.PlagueButton QuestSpoofButton = null;

            if (PatchManager.QuestSpoof)
            {
                QuestSpoofButton = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Quest Spoof\nOn", "Spoofs you as a Quest", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.TopButton, Protections.transform/*Your Parent Transform*/, delegate (bool a)
                {
                    if (a)
                    {
                        FoldersManager.Create.Ini.SetBool("Toggles", "QuestSpoof", true);
                        QuestSpoofButton.SetText("Quest Spoof\nOn");
                    }
                    else
                    {
                        FoldersManager.Create.Ini.SetBool("Toggles", "QuestSpoof", false);
                        QuestSpoofButton.SetText("Quest Spoof\nOff");
                    }
                }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, true/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);
            }
            else
            {
                QuestSpoofButton = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Quest Spoof\nOff", "Spoofs you as a Quest", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.TopButton, Protections.transform/*Your Parent Transform*/, delegate (bool a)
                {
                    if (a)
                    {
                        FoldersManager.Create.Ini.SetBool("Toggles", "QuestSpoof", true);
                        QuestSpoofButton.SetText("Quest Spoof\nOn");
                    }
                    else
                    {
                        FoldersManager.Create.Ini.SetBool("Toggles", "QuestSpoof", false);
                        QuestSpoofButton.SetText("Quest Spoof\nOff");
                    }
                }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);
            }

            ButtonAPI.PlagueButton LogUdon = null;

            LogUdon = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Log Udon\nOff", "Logs all udon events onto the MLConsole", ButtonAPI.HorizontalPosition.FourthButtonPos, ButtonAPI.VerticalPosition.TopButton, Protections.transform/*Your Parent Transform*/, delegate (bool a)
            {
                PatchManager.LogUdon = a;
                if (a)
                {
                    LogUdon.SetText("Log Udon\nOn");
                }
                else
                {
                    LogUdon.SetText("Log Udon\nOff");
                }
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.PlagueButton LogCheaters = null;

            LogCheaters = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Log Cheaters\nOff", "Logs all client users abusing udon events onto the MLConsole", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.SecondButton, Protections.transform/*Your Parent Transform*/, delegate (bool a)
            {
                PatchManager.LogCheaters = a;
                LogCheaters.SetText(a ? "Log Cheaters\nOn" : "Log Cheaters\nOff");
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.PlagueButton LogCheatersAudio = null;

            LogCheatersAudio = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Log Cheaters Audio\nOff", "Plays an Audio every time a log is triggered", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.SecondButton, Protections.transform/*Your Parent Transform*/, delegate (bool a)
            {
                PatchManager.playsound = a;
                LogCheatersAudio.SetText(a ? "Log Cheaters Audio\nOn" : "Log Cheaters Audio\nOff");
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.PlagueButton LogCheatersConsole = null;

            LogCheatersConsole = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Log Cheaters MLC\nOff", "Enables Logging to the MLConsole", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.SecondButton, Protections.transform/*Your Parent Transform*/, delegate (bool a)
            {
                PatchManager.logconsole = a;
                LogCheatersConsole.SetText(a ? "Log Cheaters MLC\nOn" : "Log Cheaters MLC\nOff");
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            #endregion

            #region PickUp Exploits

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Pickups", "Opens Pickups Exploits", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, mainmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(PickupsMenu/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.PlagueButton AutoDrop = null;

            AutoDrop = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Auto Drop\nOff", "Auto Drop all the Pickups", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, PickupsMenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                Items.AutoDropToggle = a;
                if (a)
                {
                    AutoDrop.SetText("Auto Drop\nOn");
                    MelonCoroutines.Start(Items.AutoDrop());
                }
                else
                {
                    AutoDrop.SetText("Auto Drop\nOff");
                    MelonCoroutines.Stop(Items.AutoDrop());
                }
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.PlagueButton AllowTheft = null;

            AllowTheft = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Thief\nOff", "Allows Thief of Pickups", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, PickupsMenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                Items.AllowThiefToggle = a;
                if (a)
                {
                    AllowTheft.SetText("Thief\nOn");
                    MelonCoroutines.Start(Items.AllowThief());
                }
                else
                {
                    AllowTheft.SetText("Thief\nOff");
                    MelonCoroutines.Stop(Items.AllowThief());
                    Items.DisallowThief();
                    Items.DisallowThief();
                    Items.DisallowThief();
                    Items.DisallowThief();
                }
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Respawn\nPickups", "Respawns all Pickups", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.TopButton, PickupsMenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                Items.RespawnPickups();
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            #endregion

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Select\nYourself", "Selects Yourself in the QuickMenu", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.SecondButton, mainmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.CloseAllSubMenus();
                Utils.SelectYourself();
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Kill Self", "Kill Self with Grenade", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.SecondButton, mainmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                var player = Utils.GetLocalPlayer();
                MelonCoroutines.Start(Murder4.KillSelectedPlayerFrag(player));
                MelonCoroutines.Stop(Murder4.KillSelectedPlayerFrag(player));
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            #endregion

            #region Go back buttons

            /*I Have:
            From Murder TP to Murder Functions
            From Pickups to MainMenu
            From Protections to MainMenu
            From Microphone to MainMenu
            From Murder4 to Worlds
            From Murder4 to Murder42ndpage
            From Piano to Murder42ndpage
            From Murder42ndpage to Murder4
            From Murder4Annoy to Murder4
            From AmongUs to Worlds
            From Worlds to MainMenu
            From AmongUsSabotages to Among Us
            From Player options to UserInteract
            From Murder4Items to UserInteract
            From MainMenu to Quick Menu
             */

            //From Piano to Murder42ndpage

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back", "Go back", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, pianomenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(murder42ndpage/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //From Murder TP to Murder Functions

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back", "Go back", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, murderteleportmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(murder42ndpage/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //From Movement to Main Menu

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back", "Go back", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, Movement.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(mainmenu/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back", "Go back", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, Protections.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(mainmenu/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //From Murder4 to Murder42ndpage

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Next", "Next page", ButtonAPI.HorizontalPosition.RightOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, WorldMurder4.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(murder42ndpage/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //From Murder42ndpage to Murder4

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back", "Go back", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, murder42ndpage.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(WorldMurder4/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //From Pickups to MainMenu

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back", "Go back", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, PickupsMenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(mainmenu/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //From Microphone to MainMenu

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back", "Go back", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, Microphonemenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(mainmenu/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //From Murder4 to Worlds

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back", "Go back", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, WorldMurder4.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(worldssubmenu/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //From Murder4Annoy to Murder4

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back", "Go back", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, Murder4Annoy.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(WorldMurder4/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //From AmongUs to Worlds

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back", "Go back", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, WorldAmongUs.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(worldssubmenu/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //From Worlds to MainMenu

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back", "Go back", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, worldssubmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(mainmenu/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //From AmongUsSabotages to Among Us

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back", "Go back", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, amongussabotages.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(WorldAmongUs/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //From Player options to UserInteract

            var playerquickmenu = GameObject.Find("UserInterface/QuickMenu/UserInteractMenu");

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back", "Go back", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, playeroptions.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.CloseAllSubMenus();
                ButtonAPI.UserInteractMenuTransform.gameObject.SetActive(true);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //From Murder4Items to PlayerOptions

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back", "Go back", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, Itemstpmurder.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(playeroptions);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            //From MainMenu to Quick Menu
            var _1 = GameObject.Find("UserInterface/QuickMenu/QuickMenu_NewElements");
            var _2 = GameObject.Find("UserInterface/QuickMenu/QuickModeTabs");
            var _3 = GameObject.Find("UserInterface/QuickMenu/MicControls");
            var _4 = GameObject.Find("UserInterface/QuickMenu/ShortcutMenu");
            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Back", "Go back", ButtonAPI.HorizontalPosition.LeftOfMenu, ButtonAPI.VerticalPosition.AboveTopButton, mainmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.CloseAllSubMenus();
                _1.gameObject.SetActive(true);
                _2.gameObject.SetActive(true);
                _3.gameObject.SetActive(true);
                _4.gameObject.SetActive(true);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, false/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, true/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);


            #endregion

            #region PlayerOptionsMenu

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Player\nOptions", "Opens Target Options", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TwoBelowBottomButton, playerquickmenu.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(playeroptions/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Teleport", "Teleports to player", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, playeroptions.transform/*Your Parent Transform*/, delegate (bool a)
            {
                Utils.GetLocalPlayer().transform.position = Utils.GetSelectedPlayer().transform.position;
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            #region Murder4Items

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Murder 4 Items", "Opens Murder4 Items Menu", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, playeroptions.transform/*Your Parent Transform*/, delegate (bool a)
            {
                ButtonAPI.EnterSubMenu(Itemstpmurder/*Or You Can Paste The Code Just Above In Here To Make The SubMenu Page As You Enter It, Or Return It If It Was Made Beforehand*/);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, false/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Revolver", "Teleports Revolver to the Target", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.TopButton, Itemstpmurder.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Items.TakeOwnershipIfNecessary(Murder4Items.revolverobject);
                Murder4Items.revolverobject.transform.position = Utils.GetSelectedPlayer().transform.position + new Vector3(0, 0.1f, 0);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Knife", "Teleports a Knife to the Target", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.TopButton, Itemstpmurder.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Items.TakeOwnershipIfNecessary(Murder4Items.knife);
                Murder4Items.knife.transform.position = Utils.GetSelectedPlayer().transform.position + new Vector3(0, 0.1f, 0);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Luger", "Teleports a Luger to the Target", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.TopButton, Itemstpmurder.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Items.TakeOwnershipIfNecessary(Murder4Items.luger);
                Murder4Items.luger.transform.position = Utils.GetSelectedPlayer().transform.position + new Vector3(0, 0.1f, 0);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Shotgun", "Teleports the Shotgun to the Target", ButtonAPI.HorizontalPosition.FourthButtonPos, ButtonAPI.VerticalPosition.TopButton, Itemstpmurder.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Items.TakeOwnershipIfNecessary(Murder4Items.shotgun);
                Murder4Items.shotgun.transform.position = Utils.GetSelectedPlayer().transform.position + new Vector3(0, 0.1f, 0);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Grenade", "Teleports the Grenade to the Target", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.SecondButton, Itemstpmurder.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Items.TakeOwnershipIfNecessary(Murder4Items.frag);
                Murder4Items.frag.transform.position = Utils.GetSelectedPlayer().transform.position + new Vector3(0, 0.1f, 0);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Smoke Bomb", "Teleports the Smoke Bomb to the Target", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.SecondButton, Itemstpmurder.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Items.TakeOwnershipIfNecessary(Murder4Items.smokebomb);
                Murder4Items.smokebomb.transform.position = Utils.GetSelectedPlayer().transform.position + new Vector3(0, 0.1f, 0);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Bear Trap", "Teleports a Bear Trap to the Target", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.SecondButton, Itemstpmurder.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                Items.TakeOwnershipIfNecessary(Murder4Items.Beartrap);
                Murder4Items.Beartrap.transform.position = Utils.GetSelectedPlayer().transform.position + new Vector3(0, 0.1f, 0);
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Kill Knife", "Kill target with Knife", ButtonAPI.HorizontalPosition.FourthButtonPos, ButtonAPI.VerticalPosition.SecondButton, Itemstpmurder.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if(!Murder4.worldLoaded) return;
                var player = Utils.GetSelectedPlayer();
                MelonCoroutines.Start(Murder4.KillSelectedPlayerKnife(player));
                MelonCoroutines.Stop(Murder4.KillSelectedPlayerKnife(player));
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Kill Frag", "Kill target with Grenade", ButtonAPI.HorizontalPosition.FirstButtonPos, ButtonAPI.VerticalPosition.BottomButton, Itemstpmurder.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                var player = Utils.GetSelectedPlayer();
                MelonCoroutines.Start(Murder4.KillSelectedPlayerFrag(player));
                MelonCoroutines.Stop(Murder4.KillSelectedPlayerFrag(player));
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            

            ButtonAPI.PlagueButton GivePatreon = null;

            GivePatreon = ButtonAPI.CreateButton(ButtonAPI.ButtonType.Toggle, "Give Patreon\nOff", "Gives Patreon to the target", ButtonAPI.HorizontalPosition.SecondButtonPos, ButtonAPI.VerticalPosition.BottomButton, Itemstpmurder.transform/*Your Parent Transform*/, delegate (bool a)
            {
                if (!Murder4.worldLoaded) return;
                var player = Utils.GetSelectedPlayer();
                Murder4.givepatreon = a;
                if (a)
                {
                    GivePatreon.SetText("Give Patreon\nOn");
                    MelonCoroutines.Start(Murder4.GivePatreonTarget(player));
                }
                else
                {
                    GivePatreon.SetText("Give Patreon\nOff");
                    MelonCoroutines.Stop(Murder4.GivePatreonTarget(player));
                    Murder4.CallRevolver("NonPatronSkin");
                }
            }, Color.red/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            

            #endregion

            ButtonAPI.CreateButton(ButtonAPI.ButtonType.Default, "Bring Pickups", "TP all pickups to the target", ButtonAPI.HorizontalPosition.ThirdButtonPos, ButtonAPI.VerticalPosition.TopButton, playeroptions.transform/*Your Parent Transform*/, delegate (bool a)
            {
                Items.ItemsToPlayer();
            }, Color.white/*ToggledOffColour*/, Color.magenta/*ToggledOnColour, Always Used On Default ButtonType*/, bordercolor/*BorderColour, Set To Null To Inherit The Current QuickMenu Button Colours*/, true/*FullSizeButton, If You Want The Button To Be Full Size, Or Half The Hight*/, false/*ButtomHalf, If You Want The Button Placed On The Top Half Of The Button (If This Button Is Half Sized) Or The Bottom Half*/, false/*HalfHorizontally, Whether You Want The Button Size Cut In Half Horizontally*/, false/*CurrentToggleState, Typically A Boolean In Your Mod, Only Applies If Current Button Is ButtonType.Toggle*/, null/*SpriteForButton, The Option To Add A Sprite Image As Your Button's Background*/, true/*ChangeColourOnClick, Only Change This If You Will Be Changing The Text Colour To OnColour Manually In Your OnClick Delegate*/);

            #endregion
        }
    }
}