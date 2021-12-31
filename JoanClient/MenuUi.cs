﻿using System;
using Il2CppSystem.IO;
using JoanpixerButtonAPI;
using JoanpixerButtonAPI.Controls;
using JoanpixerButtonAPI.Controls.Grouping;
using JoanpixerButtonAPI.Pages;
using JoanpixerClient.Features.Worlds;
using JoanpixerClient.Modules;
using MelonLoader;
using UnityEngine;
using LoadSprite;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC;
using VRC.UI.Elements.Menus;

namespace JoanpixerClient
{
    internal class MenuUi
    {
        private static ToggleButton Noclip = null;
        private static ToggleButton Speedhack = null;
        private static ToggleButton QuestSpoofOn = null;
        private static bool NoclipOn = false;
        private static bool SpeedOn = false;

        internal static void MainMenu()
        {
            ButtonAPI.OnInit += () =>
            {
                Player selectedplayer = null;
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

                var teleportsmurder4 = new MenuPage("TeleportsM4", "Teleports Menu", false);

                var teleportsmurder4buttons = new ButtonGroup(teleportsmurder4, null);

                #endregion

                #region Murder3

                var Murder3Menu = new MenuPage("Murder3", "Murder 3", false);

                var Murder3Buttons = new ButtonGroup(Murder3Menu, null);

                var annoy3 = new MenuPage("Annoy3", "Annoy Functions", false);

                var annoy3buttons = new ButtonGroup(annoy3, null);

                #endregion

                #region PlayerOptionsQuickMenu

                var Murder4QuickMenu = new MenuPage("Murder4QuickMenu", "Murder 4", false);

                var Murder4QuickMenuButtons = new ButtonGroup(Murder4QuickMenu, null);

                var Murder3QuickMenu = new MenuPage("Murder3QuickMenu", "Murder 3", false);

                var Murder3QuickMenuButtons = new ButtonGroup(Murder3QuickMenu, null);

                var quickmenuplayeroptions = new ButtonGroup(Utils.SelectedUserLocal.transform.Find("ScrollRect").GetComponent<ScrollRect>().content, "Joanpixer Client\n");

                new SimpleSingleButton(quickmenuplayeroptions, "Teleport", "Teleports to player", () =>
                {
                    selectedplayer = Utils.GetCurrentlySelectedPlayer();
                    Utils.TPLocalPlayer(selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position);
                });

                new SimpleSingleButton(quickmenuplayeroptions, "Fav/UnFav Avatar", "Favorite/Unfavorites avatar", () =>
                {
                    selectedplayer = Utils.GetCurrentlySelectedPlayer();
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
                    var player = selectedplayer;
                    MelonCoroutines.Start(Murder4.KillSelectedPlayerKnife(player));
                    MelonCoroutines.Stop(Murder4.KillSelectedPlayerKnife(player));
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, "Kill Frag", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    MelonCoroutines.Start(Murder4.KillSelectedPlayerFrag(selectedplayer));
                    MelonCoroutines.Stop(Murder4.KillSelectedPlayerFrag(selectedplayer));
                });

                new ToggleButton(Murder4QuickMenuButtons, "Give Patreon", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
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
                }).SetToggleState(false, true);

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
                }).SetToggleState(false, true);

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
                    var player = selectedplayer;
                    MelonCoroutines.Start(Murder3.KillSelectedPlayerKnife(player));
                    MelonCoroutines.Stop(Murder3.KillSelectedPlayerKnife(player));
                });

                new SimpleSingleButton(Murder3QuickMenuButtons, "Kill Frag", null, () =>
                {
                    if (!Murder3.worldLoaded) return;
                    MelonCoroutines.Start(Murder3.KillSelectedPlayerFrag(selectedplayer));
                    MelonCoroutines.Stop(Murder3.KillSelectedPlayerFrag(selectedplayer));
                });

                new ToggleButton(Murder3QuickMenuButtons, "Give Patreon", null, null, (val) =>
                {
                    if (!Murder3.worldLoaded) return;
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
                }).SetToggleState(false, true);

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
                }).SetToggleState(false, true);

                #endregion

                var Murder4Icon = (Environment.CurrentDirectory + "\\Joanpixer\\knife.png").LoadSpriteFromDisk();

                new SimpleSingleButton(quickmenuplayeroptions, "TP Pickups", "TP all pickups to the target", () =>
                {
                    selectedplayer = Utils.GetCurrentlySelectedPlayer();
                    Items.ItemsToPlayer(selectedplayer);
                });

                new SingleButton(quickmenuplayeroptions, "Murder 4", "Open Murder 4 Target Options", () =>
                {
                    selectedplayer = Utils.GetCurrentlySelectedPlayer();
                    Murder4QuickMenu.OpenMenu();
                    Murder4QuickMenu.SetTitle(selectedplayer.prop_VRCPlayerApi_0.displayName);
                }, false, Murder4Icon);

                new SingleButton(quickmenuplayeroptions, "Murder 3", "Open Murder 3 Target Options", () =>
                {
                    selectedplayer = Utils.GetCurrentlySelectedPlayer();
                    Murder3QuickMenu.OpenMenu();
                    Murder3QuickMenu.SetTitle(selectedplayer.prop_VRCPlayerApi_0.displayName);
                }, false, Murder4Icon);

                #endregion

                #endregion

                #region Murder4



                new SingleButton(MainMenuButtons, "Murder 4", "Opens Murder 4 Exploits Menu", () =>
                {
                    Murder4Menu.OpenMenu();
                }, false, Murder4Icon);

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

                new SimpleSingleButton(Murder4Buttons, "Bystanders Win", "Forces Bystanders to win", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    MelonCoroutines.Start(Murder4.BWin());
                    MelonCoroutines.Stop(Murder4.BWin());
                });

                new SimpleSingleButton(Murder4Buttons, "Murderer Win", "Forces Murderer to win", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.CallGameLogic("SyncVictoryM");
                });

                new SimpleSingleButton(Murder4Buttons, "Abort Game", "Aborts Game", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.CallGameLogic("SyncAbort");
                });

                var DoorsOffIcon = (Environment.CurrentDirectory + "\\Joanpixer\\doorsoff.png").LoadSpriteFromDisk();

                new ToggleButton(Murder4Buttons, "Doors Off", "Disable Doors", "Enable Doors", (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    if (val)
                    {
                        Murder4.doors.SetActive(false);
                    }
                    else
                    {
                        Murder4.doors.SetActive(true);
                    }
                }, DoorsOffIcon, null).SetToggleState(false, true);

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
                    Murder4.doorlock = val;
                    if (val)
                    {
                        MelonCoroutines.Start(Murder4.LockDoors());
                    }
                    else
                    {
                        MelonCoroutines.Stop(Murder4.LockDoors());
                    }
                }).SetToggleState(false, true);

                new ToggleButton(annoybuttons, "Lock Drawers", "Enable Drawers Lock", "Disable Drawers Lock", (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.lockdrawers = val;
                    if (val)
                    {
                        MelonCoroutines.Start(Murder4.LockDrawers());
                    }
                    else
                    {
                        MelonCoroutines.Stop(Murder4.LockDrawers());
                    }
                }).SetToggleState(false, true);

                new ToggleButton(annoybuttons, "Spam Revolver", "Enable Revolver Spam", "Disable Revolver Spam", (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.revolverspam = val;
                    if (val)
                    {
                        MelonCoroutines.Start(Murder4.Fire());
                    }
                    else
                    {
                        MelonCoroutines.Stop(Murder4.Fire());
                    }
                }).SetToggleState(false, true);

                new ToggleButton(annoybuttons, "Lights Off", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.lightsoff = val;
                    if (val)
                    {
                        MelonCoroutines.Start(Murder4.TurnLightsOff());
                    }
                    else
                    {
                        MelonCoroutines.Stop(Murder4.TurnLightsOff());
                    }
                }).SetToggleState(false, true);

                new ToggleButton(annoybuttons, "Spam sounds", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.spamsounds = val;
                    if (val)
                    {
                        MelonCoroutines.Start(Murder4.SpamSounds(0));
                    }
                    else
                    {
                        MelonCoroutines.Stop(Murder4.SpamSounds(0));
                    }
                }).SetToggleState(false, true);

                #endregion

                new ToggleButton(Murder4Buttons, "Patreon Self", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
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
                }).SetToggleState(false, true);

                new ToggleButton(Murder4Buttons, "Pickup Beartraps", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.pickupweapontoggle = val;
                    if (val)
                    {
                        MelonCoroutines.Start(Murder4.PickupBearTraps());
                        MelonCoroutines.Stop(Murder4.PickupBearTraps());
                    }
                    else
                    {
                        Murder4.DisablePickupBearTraps();
                    }
                }).SetToggleState(false, true);

                new SimpleSingleButton(Murder4Buttons, "Show Murderer", "Shows you the Murderer", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    var Murderer = $"Murderer is {Murder4.MurderText.GetComponent<Text>().m_Text}";
                    MelonCoroutines.Start(Utils.Notification(Murderer, Color.red));
                });

                new ToggleButton(Murder4Buttons, "Pickup Weapon in Cooldown", "Allows you to pickup every weapon that's in cooldown", "Allows you to pickup every weapon that's in cooldown", (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.pickupweapontoggle = val;
                    if (val)
                    {
                        MelonCoroutines.Start(Murder4.PickupWeaponInCooldown());
                    }
                    else
                    {
                        MelonCoroutines.Stop(Murder4.PickupWeaponInCooldown());
                    }
                }).SetToggleState(false, true);

                #region Teleports

                new SimpleSingleButton(Murder4Buttons, "Teleports", null, () =>
                {
                    teleportsmurder4.OpenMenu();
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Kitchen", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-20.8f, 0, 121.6f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Lounge", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-15.9f, 0, 130.1f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Dining Room", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-11.3f, 0, 119.2f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Grand Hall", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(0.6f, 0, 116.4f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Library", null,  () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(12.2f, 0, 119.7f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Piano", null,  () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(15.9f, 0, 131.5f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Garage", null,  () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(17.3f, 0, 140.4f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Outside", null,  () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(2.8f, 0, 140.5f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Conservatory", null,  () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-0.4f, 0, 146));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Billard", null,  () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-14.7f, 0, 140.2f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Cellar", null,  () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-2.1f, -3, 130.8f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Bedroom", null,  () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-9.9f, 3.6f, 129.2f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Detective Room", null,  () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(5, 3, 122.8f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Bathroom", null,  () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(-0.4f, 3, 133.4f));
                });

                new SimpleSingleButton(teleportsmurder4buttons, "Closet", null, () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.TPLocalPlayer(new Vector3(0.4673f, 2.995f, 124.234f));
                });

                #endregion

                new ToggleButton(Murder4Buttons, "Clues ESP", null, null, (val) =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.CluesESP = val;
                    if (!val)
                    {
                        foreach (var clue in Resources.FindObjectsOfTypeAll<Renderer>())
                        {
                            if (clue.gameObject.name == "geo" && clue.gameObject.transform.parent.gameObject.name.Contains("Clue"))
                            {
                                Utils.ToggleOutline(clue, false);
                            }
                        }
                    }
                }).SetToggleState(false, true);

                new ToggleButton(Murder4Buttons, "Auto TP Detective", "TP to Detective Room when the game starts", "TP to Detective Room when the game starts", (val) =>
                {
                    PatchManager.TPDetective = val;
                }).SetToggleState(false, true);

                #endregion

                #region Murder3

                new SingleButton(MainMenuButtons, "Murder 3", "Opens Murder 3 Exploits Menu", () =>
                {
                    Murder3Menu.OpenMenu();
                }, false, Murder4Icon);

                new SimpleSingleButton(Murder3Buttons, "Bystanders Win", "Forces Bystanders to win", () =>
                {
                    if (!Murder3.worldLoaded) return;
                    MelonCoroutines.Start(Murder3.BWin());
                    MelonCoroutines.Stop(Murder3.BWin());
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
                    Murder3.revolverspam = val;
                    if (val)
                    {
                        MelonCoroutines.Start(Murder3.Fire());
                    }
                    else
                    {
                        MelonCoroutines.Stop(Murder3.Fire());
                    }
                }).SetToggleState(false, true);

                new ToggleButton(annoy3buttons, "Spam sounds", null, null, (val) =>
                {
                    if (!Murder3.worldLoaded) return;
                    Murder3.spamsounds = val;
                    if (val)
                    {
                        MelonCoroutines.Start(Murder3.SpamSounds(0));
                    }
                    else
                    {
                        MelonCoroutines.Stop(Murder3.SpamSounds(0));
                    }
                }).SetToggleState(false, true);

                #endregion

                new ToggleButton(Murder3Buttons, "Patreon Self", null, null, (val) =>
                {
                    if (!Murder3.worldLoaded) return;
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
                }).SetToggleState(false, true);

                new ToggleButton(Murder3Buttons, "Pickup Beartraps", null, null, (val) =>
                {
                    if (!Murder3.worldLoaded) return;
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
                }).SetToggleState(false, true);

                new SimpleSingleButton(Murder3Buttons, "Show Murderer", "Shows you the Murderer", () =>
                {
                    if (!Murder3.worldLoaded) return;
                    var Murderer = $"Murderer is {Murder3.MurderText.GetComponent<Text>().m_Text}";
                    MelonCoroutines.Start(Utils.Notification(Murderer, Color.red));
                });

                new ToggleButton(Murder3Buttons, "Pickup Weapon in Cooldown", "Allows you to pickup every weapon that's in cooldown", "Allows you to pickup every weapon that's in cooldown", (val) =>
                {
                    if (!Murder3.worldLoaded) return;
                    Murder3.pickupweapontoggle = val;
                    if (val)
                    {
                        MelonCoroutines.Start(Murder3.PickupWeaponInCooldown());
                    }
                    else
                    {
                        MelonCoroutines.Stop(Murder3.PickupWeaponInCooldown());
                    }
                }).SetToggleState(false, true);

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
                                Utils.ToggleOutline(clue, false);
                            }
                        }
                    }
                }).SetToggleState(false, true);

                new ToggleButton(Murder3Buttons, "Auto TP Detective", "TP to Detective Room when the game starts", "TP to Detective Room when the game starts", (val) =>
                {
                    PatchManager.TPDetective = val;
                }).SetToggleState(false, true);

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
                }).SetToggleState(false, true);

                new ToggleButton(ProtectionsButtons, "Portal Walktrough", "Allows you to walk trough Portals", "Allows you to walk trough Portals", (val) =>
                {
                    PatchManager.PortalWalk = val;
                }).SetToggleState(false, true);

                QuestSpoofOn = new ToggleButton(ProtectionsButtons, "Quest Spoof", "Enable Quest Spoof (requires restart!)", "Disable Quest Spoof (requires restart!)", (val) => 
                { 
                        FoldersManager.Create.Ini.SetBool("Toggles", "QuestSpoof", val);
                });

                QuestSpoofOn.SetToggleState(PatchManager.QuestSpoof);

                new ToggleButton(ProtectionsButtons, "Log Udon", "Logs all Udon Events onto the MLConsole", "Logs all Udon Events onto the MLConsole", (val) =>
                {
                    PatchManager.LogUdon = val;
                }).SetToggleState(false, true);

                new ToggleButton(ProtectionsButtons, "Log Cheaters", "Logs all client users abusing udon events onto the MLConsole", "Logs all client users abusing udon events onto the MLConsole", (val) =>
                {
                    PatchManager.LogCheaters = val;
                }).SetToggleState(false, true);

                new ToggleButton(ProtectionsButtons, "Log Cheaters Audio", "Plays an Audio every time a log is triggered", "Plays an Audio every time a log is triggered", (val) =>
                {
                    PatchManager.playsound = val;
                }).SetToggleState(false, true);

                #endregion

                #region Pickups

                var PickupsIcon = (Environment.CurrentDirectory + "\\Joanpixer\\pickup.png").LoadSpriteFromDisk();


                new SingleButton(MainMenuButtons, "Pickups", "Opens Pickup Menu", () =>
                {
                    Pickups.OpenMenu();
                }, false, PickupsIcon);

                new ToggleButton(PickupsButtons, "Auto Drop", "Auto Drop all the Pickups", "Auto Drop all the Pickups", (val) =>
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
                }).SetToggleState(false, true);

                new ToggleButton(PickupsButtons, "Thief", "Allows Thief of Pickups", "Allows Thief of Pickups", (val) =>
                {
                    if (val)
                    {
                        Items.AllowThief();
                    }
                    else
                    {
                        Items.DisallowThief();
                    }
                }).SetToggleState(false, true);

                new SimpleSingleButton(PickupsButtons, "Respawn Pickups", null, () =>
                {
                    Items.RespawnPickups();
                });

                #endregion

                var GodmodeIcon = (Environment.CurrentDirectory + "\\Joanpixer\\god.png").LoadSpriteFromDisk();

                new ToggleButton(MainMenuButtons, "GodMode", "Gives you Immortality", "Gives you Immortality", (val) =>
                {
                    PatchManager.Godmode = val;
                }, GodmodeIcon, null).SetToggleState(false, true);

                var KillSelfIcon = (Environment.CurrentDirectory + "\\Joanpixer\\killself.png").LoadSpriteFromDisk();

                new SingleButton(MainMenuButtons, "Kill Self", "Kill Self with Grenade", () =>
                {
                    if (Murder4.worldLoaded)
                        MelonCoroutines.Start(Murder4.KillLocalPlayerFrag());
                        MelonCoroutines.Stop(Murder4.KillLocalPlayerFrag());
                    if (Murder3.worldLoaded)
                        MelonCoroutines.Start(Murder3.KillLocalPlayerFrag());
                        MelonCoroutines.Stop(Murder3.KillLocalPlayerFrag());
                }, false, KillSelfIcon);


                var Movement = new ButtonGroup(mainmenu, "Movement");

                new ToggleButton(Movement, "ESP", "Allows you to see players through walls", "Allows you to see players through walls", (val) =>
                {
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
                }).SetToggleState(false, true);
                if (!File.Exists(Environment.CurrentDirectory + "\\Mods\\AbyssLoader.dll"))
                {
                    Noclip = new ToggleButton(Movement, "Noclip", null, null, (val) =>
                    {
                        if (val)
                        {
                            FlightMod.PlayerExtensions.LocalPlayer.gameObject.GetComponent<CharacterController>()
                                .enabled = false;
                            FlightMod.Flight.player = FlightMod.PlayerExtensions.LocalPlayer.gameObject;
                            FlightMod.Flight.flying = true;
                            NoclipOn = true;
                        }
                        else
                        {
                            try
                            {
                                FlightMod.PlayerExtensions.LocalPlayer.gameObject.GetComponent<CharacterController>()
                                    .enabled = true;
                                FlightMod.Flight.flying = false;
                                NoclipOn = false;
                            }
                            catch
                            {
                            }
                        }
                    });
                    Noclip.SetToggleState(false, true);
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

                Speedhack.SetToggleState(false, true);

                new SimpleSingleButton(Movement, "Enable Jump", "Enables Jump in World", () =>
                {
                    if (Networking.LocalPlayer.GetJumpImpulse() > 1f)
                    {
                        MelonLogger.Msg("[Enable Jump]: Jump Already Enabled In World");
                    }
                    else
                    {
                        Networking.LocalPlayer.SetJumpImpulse(4);
                    }
                });

                new ToggleButton(Movement, "Pickup ESP", "Being Fixed", "Being Fixed", (val) =>
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
                }).SetToggleState(false, true);

                new JoanpixerButtonAPI.Controls.Slider(mainmenu, "Speedhack Speed", null, (val) =>
                {
                    Features.Speedhack.speedMultiplier = val;
                    FlightMod.Flight.flySpeed = val;
                }, 1, 20, 5);
            };
        }

        public static void OnUpdate()
        {
            if (!PatchManager.loggedin) return;
            if (!File.Exists(Environment.CurrentDirectory + "\\Mods\\AbyssLoader"))
            {
                if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyUp(KeyCode.F))
                {
                    if (NoclipOn)
                    {
                        Noclip.SetToggleState(false, true);
                        NoclipOn = false;
                    }
                    else
                    {
                        Noclip.SetToggleState(true, true);
                        NoclipOn = true;
                    }
                }
            }

            if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyUp(KeyCode.X))
            {
                if (SpeedOn)
                {
                    Speedhack.SetToggleState(false, true);
                    SpeedOn = false;
                }
                else
                {
                    Speedhack.SetToggleState(true, true);
                    SpeedOn = true;
                }
            }

        }
    }
}
