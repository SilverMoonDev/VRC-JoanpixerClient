using System;
using PlagueButtonAPI;
using PlagueButtonAPI.Controls;
using PlagueButtonAPI.Controls.Grouping;
using PlagueButtonAPI.Pages;
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
        internal static void MainMenu()
        {
            ButtonAPI.OnInit += () =>
            {
                Player selectedplayer = null;
                //Menus
                var mainmenu = new MenuPage("MainMenu", "Main Menu");

                new Tab(mainmenu, JoanpixerMain.ButtonImage);

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

                #region PlayerOptionsQuickMenu

                var Murder4QuickMenu = new MenuPage("Murder4QuickMenu", "Murder 4", false);

                var Murder4QuickMenuButtons = new ButtonGroup(Murder4QuickMenu, null);

                var quickmenuplayeroptions = new ButtonGroup(Utils.SelectedUserLocal.transform.Find("ScrollRect").GetComponent<ScrollRect>().content, "Joanpixer Client");

                new SimpleSingleButton(quickmenuplayeroptions, "Teleports to player", "Teleport", () =>
                {
                    selectedplayer = Utils.GetCurrentlySelectedPlayer();
                    Utils.GetLocalPlayer().field_Private_VRCPlayerApi_0.gameObject.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position;
                });

                new SimpleSingleButton(quickmenuplayeroptions, "Favorite/Unfavorite avatar", "Fav/UnFav Avatar", () =>
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

                new SimpleSingleButton(Murder4QuickMenuButtons, null, "Revolver", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.revolverobject);
                    Murder4Items.revolverobject.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, null, "Knife", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.knife);
                    Murder4Items.knife.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, null, "Luger", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.luger);
                    Murder4Items.luger.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, null, "Shotgun", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.shotgun);
                    Murder4Items.shotgun.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, null, "Grenade", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.frag);
                    Murder4Items.frag.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, null, "Smoke Bomb", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.smokebomb);
                    Murder4Items.smokebomb.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, null, "Bear Trap", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Items.TakeOwnershipIfNecessary(Murder4Items.Beartrap);
                    Murder4Items.Beartrap.transform.position = selectedplayer.field_Private_VRCPlayerApi_0.gameObject.transform.position + new Vector3(0, 0.1f, 0);
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, null, "Kill Knife", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    var player = selectedplayer;
                    MelonCoroutines.Start(Murder4.KillSelectedPlayerKnife(player));
                    MelonCoroutines.Stop(Murder4.KillSelectedPlayerKnife(player));
                });

                new SimpleSingleButton(Murder4QuickMenuButtons, null, "Kill Frag", () =>
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
                var Murder4Icon = (Environment.CurrentDirectory + "\\Joanpixer\\knife.png").LoadSpriteFromDisk();

                new SimpleSingleButton(quickmenuplayeroptions, "TP all pickups to the target", "Bring Pickups", () =>
                {
                    selectedplayer = Utils.GetCurrentlySelectedPlayer();
                    Items.ItemsToPlayer();
                });

                new SingleButton(quickmenuplayeroptions, "Murder 4", "Open Murder 4 Target Options", () =>
                {
                    selectedplayer = Utils.GetCurrentlySelectedPlayer();
                    Murder4QuickMenu.OpenMenu();
                    Murder4QuickMenu.SetTitle(selectedplayer.prop_VRCPlayerApi_0.displayName);
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

                new SimpleSingleButton(Murder4Buttons, "Aborts Game", "Abort Game", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.CallGameLogic("SyncAbort");
                });

                new SimpleSingleButton(Murder4Buttons, "Forces Bystanders to win", "Bystanders Win", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    MelonCoroutines.Start(Murder4.BWin());
                    MelonCoroutines.Stop(Murder4.BWin());
                });

                new SimpleSingleButton(Murder4Buttons, "Forces Murderer to win", "Murderer Win", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.CallGameLogic("SyncVictoryM");
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
                }, DoorsOffIcon).SetToggleState(false, true);

                new SimpleSingleButton(Murder4Buttons, "Turns Lights On", "Lights On", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Murder4.TurnLightsOn();
                });
                #region Annoy
                new SimpleSingleButton(Murder4Buttons, "Annoy Functions", "Annoy", () =>
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

                new SimpleSingleButton(Murder4Buttons, "Shows you the Murderer", "Show Murderer", () =>
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

                new SimpleSingleButton(Murder4Buttons, null, "Teleports", () =>
                {
                    teleportsmurder4.OpenMenu();
                });

                new SimpleSingleButton(teleportsmurder4buttons, null, "Kitchen", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.GetLocalPlayer().transform.position = new Vector3(-20.8f, 0, 121.6f);
                });

                new SimpleSingleButton(teleportsmurder4buttons, null, "Lounge", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.GetLocalPlayer().transform.position = new Vector3(-15.9f, 0, 130.1f);
                });

                new SimpleSingleButton(teleportsmurder4buttons, null, "Dining Room", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.GetLocalPlayer().transform.position = new Vector3(-11.3f, 0, 119.2f);
                });

                new SimpleSingleButton(teleportsmurder4buttons, null, "Grand Hall", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.GetLocalPlayer().transform.position = new Vector3(0.6f, 0, 116.4f);
                });

                new SimpleSingleButton(teleportsmurder4buttons, null, "Library", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.GetLocalPlayer().transform.position = new Vector3(12.2f, 0, 119.7f);
                });

                new SimpleSingleButton(teleportsmurder4buttons, null, "Piano", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.GetLocalPlayer().transform.position = new Vector3(15.9f, 0, 131.5f);
                });

                new SimpleSingleButton(teleportsmurder4buttons, null, "Garage", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.GetLocalPlayer().transform.position = new Vector3(17.3f, 0, 140.4f);
                });

                new SimpleSingleButton(teleportsmurder4buttons, null, "Outside", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.GetLocalPlayer().transform.position = new Vector3(2.8f, 0, 140.5f);
                });

                new SimpleSingleButton(teleportsmurder4buttons, null, "Conservatory", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.GetLocalPlayer().transform.position = new Vector3(-0.4f, 0, 146);
                });

                new SimpleSingleButton(teleportsmurder4buttons, null, "Billard", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.GetLocalPlayer().transform.position = new Vector3(-14.7f, 0, 140.2f);
                });

                new SimpleSingleButton(teleportsmurder4buttons, null, "Cellar", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.GetLocalPlayer().transform.position = new Vector3(-2.1f, -3, 130.8f);
                });

                new SimpleSingleButton(teleportsmurder4buttons, null, "Bedroom", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.GetLocalPlayer().transform.position = new Vector3(-9.9f, 3.6f, 129.2f);
                });

                new SimpleSingleButton(teleportsmurder4buttons, null, "Detective Room", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.GetLocalPlayer().transform.position = new Vector3(5, 3, 122.8f);
                });

                new SimpleSingleButton(teleportsmurder4buttons, null, "Bathroom", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.GetLocalPlayer().transform.position = new Vector3(-0.4f, 3, 133.4f);
                });

                new SimpleSingleButton(teleportsmurder4buttons, null, "Closet", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    Utils.GetLocalPlayer().transform.position = new Vector3(0.4673f, 2.995f, 124.234f);
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

                if (PatchManager.QuestSpoof)
                {
                    new ToggleButton(ProtectionsButtons, "Quest Spoof", "Enable Quest Spoof (requires restart!)", "Disable Quest Spoof (requires restart!)", (val) =>
                    {
                        PatchManager.QuestSpoof = val;
                        if (PatchManager.QuestSpoof)
                        {
                            FoldersManager.Create.Ini.SetBool("Toggles", "QuestSpoof", true);
                        }
                        else
                        {
                            FoldersManager.Create.Ini.SetBool("Toggles", "QuestSpoof", false);
                        }
                    }).SetToggleState(true, true);
                }
                else if (!PatchManager.QuestSpoof)
                {
                    new ToggleButton(ProtectionsButtons, "Quest Spoof", "Enable Quest Spoof (requires restart!)", "Disable Quest Spoof (requires restart!)", (val) =>
                    {
                        PatchManager.QuestSpoof = val;
                        if (PatchManager.QuestSpoof)
                        {
                            FoldersManager.Create.Ini.SetBool("Toggles", "QuestSpoof", true);
                        }
                        else
                        {
                            FoldersManager.Create.Ini.SetBool("Toggles", "QuestSpoof", false);
                        }
                    }).SetToggleState(false, true);
                }

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

                new SimpleSingleButton(PickupsButtons, null, "Respawn Pickups", () =>
                {
                    Items.RespawnPickups();
                });

                #endregion

                var GodmodeIcon = (Environment.CurrentDirectory + "\\Joanpixer\\god.png").LoadSpriteFromDisk();

                new ToggleButton(MainMenuButtons, "GodMode", "Gives you Immortality", "Gives you Immortality", (val) =>
                {
                    PatchManager.Godmode = val;
                }, GodmodeIcon).SetToggleState(false, true);

                var KillSelfIcon = (Environment.CurrentDirectory + "\\Joanpixer\\killself.png").LoadSpriteFromDisk();

                new SingleButton(MainMenuButtons, "Kill Self", "Kill Self with Grenade", () =>
                {
                    if (!Murder4.worldLoaded) return;
                    MelonCoroutines.Start(Murder4.KillLocalPlayerFrag());
                    MelonCoroutines.Stop(Murder4.KillLocalPlayerFrag());
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
                        Features.HighlightsComponent.ToggleESP(false);
                    }
                }).SetToggleState(false, true);

                new ToggleButton(Movement, "Noclip", null, null, (val) =>
                {
                    if (val)
                    {
                        FlightMod.PlayerExtensions.LocalPlayer.gameObject.GetComponent<CharacterController>().enabled = false;
                        FlightMod.Flight.player = FlightMod.PlayerExtensions.LocalPlayer.gameObject;
                        FlightMod.Flight.flying = true;
                    }
                    else
                    {
                        try
                        {
                            FlightMod.PlayerExtensions.LocalPlayer.gameObject.GetComponent<CharacterController>().enabled = true;
                            FlightMod.Flight.flying = false;
                        }
                        catch { }
                    }
                }).SetToggleState(false, true);

                new ToggleButton(Movement, "Speedhack", null, null, (val) =>
                {
                    if (val)
                    {
                        Features.Speedhack.speedEnabled = true;
                    }
                    else
                    {
                        Features.Speedhack.speedEnabled = false;
                    }
                }).SetToggleState(false, true);

                new SimpleSingleButton(Movement, "Enables Jump in World", "Enable Jump", () =>
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

                new ToggleButton(Movement, "Pickup ESP", null, null, (val) =>
                {
                    if (val)
                    {
                        Features.HighlightsComponent.PickupESP(true);
                    }
                    else
                    {
                        Features.HighlightsComponent.PickupESP(false);
                    }
                }).SetToggleState(false, true);

                new PlagueButtonAPI.Controls.Slider(mainmenu, "Speedhack Speed", null, (val) =>
                {
                    Features.Speedhack.speedMultiplier = val;
                });
            };
        }
    }
}
