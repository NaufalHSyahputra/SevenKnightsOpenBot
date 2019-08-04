using SevenKnightsAI.Classes.Extensions;
using SevenKnightsAI.Classes.Imaging;
using SevenKnightsAI.Classes.Mappings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Telegram;
using Tesseract;

namespace SevenKnightsAI.Classes
{
    internal class SevenKnightsCore
    {
        #region Public Fields

        public BlueStacks BlueStacks;

        #endregion Public Fields

        #region Private Fields

        private readonly Color COLOR_ARENA = Color.RosyBrown;
        private readonly Color COLOR_BUY_KEYS = Color.IndianRed;
        private readonly Color COLOR_DEATH = Color.Indigo;
        private readonly Color COLOR_HONOR = Color.Navy;
        private readonly Color COLOR_INBOX = Color.MediumTurquoise;
        private readonly Color COLOR_POWER_UP = Color.Orchid;
        private readonly Color COLOR_FUSE = Color.DeepPink;
        private readonly Color COLOR_LEVEL_30 = Color.MediumPurple;
        private readonly Color COLOR_LEVEL_UP = Color.Orchid;
        private readonly Color COLOR_LIMIT = Color.Peru;
        private readonly Color COLOR_SELL_HEROES = Color.MediumVioletRed;
        private readonly Color COLOR_SELL_ITEMS = Color.SeaGreen;
        private readonly Color COLOR_SMART_MODE = Color.SteelBlue;
        private readonly Color COLOR_WAVE = Color.RoyalBlue;

        private AIProfiles AIProfiles;
        private Objective CurrentObjective;
        private Scene CurrentScene;
        private TimeSpan AdventureKeyTime;
        private TimeSpan ArenaKeyTime;
        private int AdventureCount;
        private int AdventureCount2;
        private int AdventureKeys;
        private int AdventureLimitCount;
        private int AdventureLimitCount2;
        private int AdventureLimitPowerUp;
        private int AdventureLimitFuse;
        private int AdventureLimitCheckSlot;
        private int AdventureLimitCollectInbox;
        private int ArenaKeys;
        private int ArenaLimitCount;
        private int ArenaLoseCount;
        private int ArenaRubiesCount;
        private int ArenaWinCount;
        private int ArenaRank;
        private int CooldownInbox;
        private int CooldownSellHeroes;
        private int CooldownSellItems;
        private int CooldownSendHonors;
        private int[] CurrentFingerprint;
        private int CurrentSequence;
        private int CurrentSequenceCount;
        private int CurrentSequenceCount2;
        private int CurrentWave;
        private int GoldCount;
        private int HangCounter;
        private int HonorCount;
        private int IdleCounter;
        private int KeysBoughtHonors;
        private int KeysBoughtRubies;
        private int MapCheckCount;
        private int MapSelectCounter;
        private bool IsAdventureLimit;
        private bool IsAlreadyAdvEnd;
        private bool IsAlreadyAdvLoot;
        private bool IsAlreadyAdvLootAuto;
        private bool alreadyCollectInboxBuyKeys;
        private System.Timers.Timer OneSecTimer;
        private int[] PreviousFingerprint;
        private Objective PreviousObjective;
        private Scene PreviousScene;
        private readonly Scene DefaultScene = new Scene(SceneType.NOT_FOUND);
        private int RubyCount;
        private int HeroCount;
        private int ItemCount;
        private bool MaxHeroUpCount;
        private bool nomorehero30;
        private int HeroMax;
        private int ItemMax;
        private SynchronizationContext SynchronizationContext;
        private Tesseractor Tesseractor;
        private int TopazCount;
        private int TowerKeys;
        private TimeSpan TowerKeyTime;
        private BackgroundWorker Worker;
        private string MapZone;
        private bool Hottimeloop;
        private bool Hottimeactive = true; //debug
        private string PlayerName = "";
        private bool CheckPlayaName;
        private bool checkslothero;
        private bool changemap;
        private bool checkslotitem;
        private bool herofull;
        private bool itemfull;
        private bool isboostsequence;
        private int goldadv;
        private int heroadv;
        private int itemadv;
        private int entrytolv30;
        private int h30;
        private World world3; //for give delay to adventure_fight
        private readonly World world4;
        private readonly int stage4;
        private int internetdc;
        private int SmartModeCount;
        private int GoldenCrystalCount;
        private int HornCount;
        private int ScaleCount;
        private int EssecenseCount;
        private int StarCount;
        private int SoulCount;
        private bool unknowncollected;
        private bool isboostalreadylimit;
        private bool alreadystop = false;
        int testhero = 0;
        private bool alreadyadvready;
        private int CurrentBoost;
        private World currentworld;
        private int currentStage = 0;

        #endregion Private Fields

        #region Private Properties

        private AISettings AISettings => AIProfiles.CurrentProfile;

        #endregion Private Properties

        #region Public Constructors

        public SevenKnightsCore(AIProfiles profile)
        {
            AIProfiles = profile;
            if (AIProfiles.ST_EnableTelegram)
            {
                bot.token = AIProfiles.ST_TelegramToken;
            }
            OneSecTimer = new System.Timers.Timer(1000.0);
            OneSecTimer.Elapsed += new ElapsedEventHandler(OnOneSecEvent);
            try
            {
                Tesseractor = new Tesseractor("eng");
            }
            catch (TesseractException)
            {
                MessageBox.Show("Tesseract engine could not be initialized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Tesseractor = null;
            }
        }

        #endregion Public ConstructorsA

        #region Public Methods

        public static bool IsConnectedToInternet()
        {
            bool returnValue = false;
            try
            {

                returnValue = Utility.InternetGetConnectedState(out int Desc, 0);
            }
            catch
            {
                returnValue = false;
            }
            return returnValue;
        }

        public void SyncSequenceCount()
        {
            CurrentSequenceCount2 = CurrentSequenceCount;
        }

        public BackgroundWorker Start(SynchronizationContext synchronizationContext)
        {
            SynchronizationContext = synchronizationContext;
            Worker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            Worker.DoWork += new DoWorkEventHandler(MainLoop);
            Worker.RunWorkerAsync();
            return Worker;
        }

        public void ChangeMode(Objective OBJA)
        {
            ChangeObjective(OBJA);
        }

        public void DisableMode(Objective OBJA)
        {
            DisableObjective(OBJA);
        }

        public string GetMode()
        {
            if (CurrentObjective == Objective.IDLE)
            {
                return "Current Objective : Idle";
            }
            else if (CurrentObjective == Objective.ADVENTURE)
            {
                return "Current Objective : Adventure";
            }
            else if (CurrentObjective == Objective.ARENA)
            {
                return "Current Objective : Arena";
            }
            else if (CurrentObjective == Objective.CHECK_SLOT_HERO)
            {
                return "Current Objective : Checking Hero Slot";
            }
            else if (CurrentObjective == Objective.CHECK_SLOT_ITEM)
            {
                return "Current Objective : Checking Item Slot";
            }
            else if (CurrentObjective == Objective.SELL_HEROES)
            {
                return "Current Objective : Sell Heroes";
            }
            else if (CurrentObjective == Objective.SELL_ITEMS)
            {
                return "Current Objective : Sell Items";
            }
            else if (CurrentObjective == Objective.BUY_KEYS)
            {
                return "Current Objective : Buy Keys";
            }
            else if (CurrentObjective == Objective.COLLECT_INBOX)
            {
                return "Current Objective : Collect Inbox";
            }
            else if (CurrentObjective == Objective.COLLECT_QUESTS)
            {
                return "Current Objective : Collect Quest";
            }
            else if (CurrentObjective == Objective.SEND_HONORS)
            {
                return "Current Objective : Send Honors";
            }
            else if (CurrentObjective == Objective.SMART_MODE)
            {
                return "Current Objective : Smart Mode";
            }
            else if (CurrentObjective == Objective.POWER_UP_HEROES)
            {
                return "Current Objective : Power Up Heroes";
            }
            else if (CurrentObjective == Objective.FUSE_HEROES)
            {
                return "Current Objective : Fuse Heroes";
            }
            else if (CurrentObjective == Objective.CHANGE_PROFILE)
            {
                return "Current Objective : Change Profile";
            }
            else
            {
                return "ERROR DUDE";
            }
        }

        #endregion Public Methods

        #region Private Methods

        private static void Sleep(int timeout)
        {
            Thread.Sleep(timeout);
        }

        private void AdventureAfterFight()
        {
            AdventureCount++;
            AdventureCount2++;
            if (AdventureCount2 >= entrytolv30)
            {
                h30 += 4;
                AdventureCount2 = 0;
                Log("Hero lv 30 : " + h30);
            }
            if (changemap)
            {
                AdventureCount2 = 0;
            }
            IsAlreadyAdvEnd = false;
            IsAlreadyAdvLoot = true;
            ReportCount(Objective.ADVENTURE);
            ProgressSequence();
            AdventureCheckLimits();
        }

        private void SmartModeAfterFight()
        {
            Log("Collecting Smart Mode Reward Finish", COLOR_SMART_MODE);
            SendTelegram("[Smart Mode] Bot finish collecting smart mode rewards");
            SmartModeCount++;
            ReportSmartCount();
            NextPossibleObjective();
        }

        private void EndAutoRepeat()
        {
            AdventureLimitPowerUp++; //for limiting auto powerup
            AdventureLimitFuse++; //for limiting auto fuse
            AdventureLimitCount2++; //for limiting adventure limit
            if (AISettings.AD_BootMode && (AISettings.AD_BoostAsgar || AISettings.AD_BoostAllMap || (AISettings.AD_BoostModeSequence && isboostsequence)))
            {
                CurrentBoost++;
                this.Log("CurrentBoost = " + CurrentBoost);
            }
            AdventureLimitCheckSlot++;
            AdventureLimitCollectInbox++;
            bool alreadystop = false;
            if (CurrentObjective != Objective.ADVENTURE || CurrentObjective == Objective.CHANGE_PROFILE)
            {
                for (int i = 0; i < 3; i++)
                {
                    WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");

                }
            }
            if (AISettings.AD_EnableProfile1 && AISettings.AD_BootMode && CurrentBoost == 100)
            {
                for (int i = 0; i < 3; i++)
                {
                    WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                    ChangeMode(Objective.CHANGE_PROFILE);
                }
                return;
            }
            if (AISettings.AD_EnableLimit)
            {
                if (AdventureLimitCount2 >= AISettings.AD_Limit)
                {
                    changemap = false;
                    AdventureLimitCount2 = 0;
                    CurrentSequenceCount2 = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                        if (AISettings.AD_EnableProfile3)
                        {
                            ChangeMode(Objective.CHANGE_PROFILE);
                        }

                    }
                }
                else if (AISettings.AD_CheckSlot && AISettings.CS_EnableActive1 && AdventureLimitCheckSlot >= AISettings.CS_Enable1)
                {
                    checkslothero = true;
                    checkslotitem = true;
                    ChangeObjective(Objective.CHECK_SLOT_HERO);
                    for (int i = 0; i < 3; i++)
                    {
                        WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                    }
                }
                else if (AdventureLimitPowerUp >= AISettings.PU_Active1 && AISettings.PU_enableActive1)
                {
                    AdventureLimitPowerUp = 0;
                    ChangeObjective(Objective.POWER_UP_HEROES);
                    for (int i = 0; i < 3; i++)
                    {
                        WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                    }
                }
                else if (AdventureLimitFuse >= AISettings.BF_Active2 && AISettings.BF_EnableActivate2)
                {
                    AdventureLimitFuse = 0;
                    ChangeObjective(Objective.FUSE_HEROES);
                    for (int i = 0; i < 3; i++)
                    {
                        WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                    }
                }
                else if (AdventureLimitCollectInbox >= AISettings.RS_CollectInboxActive && AISettings.RS_CollectInbox)
                {
                    AdventureLimitCollectInbox = 0;
                    ChangeObjective(Objective.COLLECT_INBOX);
                    for (int i = 0; i < 3; i++)
                    {
                        WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                    }
                }
            }
            else if (AISettings.AD_World == World.Sequencer)
            {
                CurrentSequenceCount2++; //for limiting sequence map
                Log("Before: " + CurrentSequenceCount2);
                Log("After: " + CurrentSequenceCount2 + " Progress Sequnce: " + AISettings.AD_AmountSequence[CurrentSequence]);
                if (CurrentSequenceCount2 >= AISettings.AD_AmountSequence[CurrentSequence])
                {
                    alreadystop = true;
                    changemap = true;
                    CurrentSequenceCount2 = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                    }
                }
                if (AISettings.AD_CheckSlot && AISettings.CS_EnableActive1 && AdventureLimitCheckSlot >= AISettings.CS_Enable1)
                {
                    checkslothero = true;
                    checkslotitem = true;
                    ChangeObjective(Objective.CHECK_SLOT_HERO);
                    if (!alreadystop)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                        }
                    }
                }
                else if (AdventureLimitPowerUp >= AISettings.PU_Active1 && AISettings.PU_enableActive1)
                {
                    AdventureLimitPowerUp = 0;
                    ChangeObjective(Objective.POWER_UP_HEROES);
                    if (!alreadystop)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                        }
                    }
                }
                else if (AdventureLimitFuse >= AISettings.BF_Active2 && AISettings.BF_EnableActivate2)
                {
                    AdventureLimitFuse = 0;
                    ChangeObjective(Objective.FUSE_HEROES);
                    if (!alreadystop)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                        }
                    }
                }
                else if (AdventureLimitCollectInbox >= AISettings.RS_CollectInboxActive && AISettings.RS_CollectInbox)
                {
                    AdventureLimitCollectInbox = 0;
                    ChangeObjective(Objective.COLLECT_INBOX);
                    if (!alreadystop)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                        }
                    }
                }
            }
            else
            {
                if (AISettings.AD_CheckSlot && AISettings.CS_EnableActive1 && AdventureLimitCheckSlot >= AISettings.CS_Enable1)
                {
                    checkslothero = true;
                    checkslotitem = true;
                    ChangeObjective(Objective.CHECK_SLOT_HERO);
                    for (int i = 0; i < 3; i++)
                    {
                        WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                    }
                }
                else if (AdventureLimitPowerUp >= AISettings.PU_Active1 && AISettings.PU_enableActive1)
                {
                    AdventureLimitPowerUp = 0;
                    ChangeObjective(Objective.POWER_UP_HEROES);
                    for (int i = 0; i < 3; i++)
                    {
                        WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                    }
                }
                else if (AdventureLimitFuse >= AISettings.BF_Active2 && AISettings.BF_EnableActivate2)
                {
                    AdventureLimitFuse = 0;
                    ChangeObjective(Objective.FUSE_HEROES);
                    for (int i = 0; i < 3; i++)
                    {
                        WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                    }
                }
                else if (AdventureLimitCollectInbox >= AISettings.RS_CollectInboxActive && AISettings.RS_CollectInbox)
                {
                    AdventureLimitCollectInbox = 0;
                    ChangeObjective(Objective.COLLECT_INBOX);
                    for (int i = 0; i < 3; i++)
                    {
                        WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                    }
                }
            }
            alreadystop = false;
            IsAlreadyAdvEnd = true;
        }

        private void AdventureCheckLimits()
        {
            if (CurrentObjective == Objective.CHECK_SLOT_HERO || CurrentObjective == Objective.ADVENTURE || CurrentObjective == Objective.POWER_UP_HEROES || CurrentObjective == Objective.COLLECT_INBOX || CurrentObjective == Objective.FUSE_HEROES)
            {
                if (AISettings.AD_EnableLimit)
                {
                    AdventureLimitCount++;
                    if (AdventureLimitCount >= AISettings.AD_Limit)
                    {
                        Log("Limit reached [Adventure]", COLOR_LIMIT);
                        SendTelegram("[Adventure] Limit Reached");
                        AdventureLimitCount = 0;
                        AdventureLimitPowerUp = 0; //for limiting auto powerup
                        AdventureLimitFuse = 0; //for limiting auto fuse
                        AdventureLimitCount2 = 0; //for limiting adventure limit
                        AdventureLimitCheckSlot = 0;
                        AdventureLimitCollectInbox = 0;
                        IsAdventureLimit = true;
                        if (CurrentObjective == Objective.ADVENTURE)
                        {
                            NextPossibleObjective();
                        }
                    }
                }
                else if (AISettings.AD_World == World.Sequencer)
                {
                    int total = AISettings.AD_AmountSequence.Sum();
                    AdventureLimitCount++;
                    if (AdventureLimitCount >= total)
                    {
                        Log("Limit reached [Adventure Sequence]", COLOR_LIMIT);
                        if (AIProfiles.ST_EnableTelegramMsg1)
                        {
                            SendTelegram("[Adventure Sequence] Limit Reached");
                        }
                        AdventureLimitCount = 0;
                        AdventureLimitPowerUp = 0; //for limiting auto powerup
                        AdventureLimitFuse = 0; //for limiting auto fuse
                        AdventureLimitCount2 = 0; //for limiting adventure limit
                        AdventureLimitCheckSlot = 0;
                        AdventureLimitCollectInbox = 0;
                        IsAdventureLimit = true;
                        if (CurrentObjective == Objective.ADVENTURE && AISettings.AD_NoChangeMode == false)
                        {
                            NextPossibleObjective();
                        }
                    }
                }
            }
        }

        private void Alert(string message)
        {
            ProgressArgs userState = new ProgressArgs(ProgressType.Alert, message);
            Worker.ReportProgress(0, userState);
        }

        private void ArenaAfterFight(bool win)
        {
            if (win)
            {
                ArenaWinCount++;
            }
            else
            {
                ArenaLoseCount++;
            }
            ReportArenaCount();
            ArenaCheckLimits();
        }

        private void ArenaCheckLimits()
        {
            if (AISettings.AR_EnableLimit)
            {
                ArenaLimitCount++;
                if (ArenaLimitCount >= AISettings.AR_Limit)
                {
                    Log("Limit reached [Arena]", COLOR_LIMIT);
                    SendTelegram("[Arena] Limit Reached");
                    ArenaLimitCount = 0;
                    NextPossibleObjective();
                }
            }
        }

        private bool ArenaUseRuby()
        {
            return AISettings.AR_UseRuby && ArenaRubiesCount < AISettings.AR_UseRubyAmount;
        }

        private void BuyKeys()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                ShopPM.Key10Honor100,
                ShopPM.Key1Honor10
            };
            string[] array2 = new string[]
            {
                "10 Key",
                "1 Key"
            };
            int start = -1;
            KeysBoughtHonors = 0;
            while (start <= 1 && !Worker.CancellationPending)
            {
                start++;
                Scene scene;
                SevenKnightsCore.Sleep(1000);
                Log("Start buying keys", COLOR_BUY_KEYS);
                CaptureFrame();
                scene = SceneSearch();
                if (scene.SceneType != SceneType.SHOP)
                {
                    Escape();
                }
                SendTelegram("[Buy Key] Bot will buy the keys with honors first");
                SevenKnightsCore.Sleep(1000);
                PixelMapping mapping;
                mapping = array[start];
                Log(string.Format("Buy {0} with honors", array2[start]), COLOR_BUY_KEYS);
                SevenKnightsCore.Sleep(1000);
                KeysBoughtHonors++;
                WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                CaptureFrame();
                scene = SceneSearch();
                if (scene != null)
                {
                    if (scene.SceneType == SceneType.SHOP_BUY_FAILED_POPUP)
                    {
                        Log("Can't buy key because insufficient honor");
                        WeightedClick(ShopBuyFailedPopupPM.OkButton, 1.0, 1.0, 1, 0, "left");
                        continue;
                    }
                }
                if (scene != null)
                {
                    if (scene.SceneType != SceneType.SHOP_BUY_POPUP)
                    {
                        Log("Can't buy key because insufficient honor2");
                    }
                }
                WeightedClick(ShopBuyPopupPM.BuyButton, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(4000);
                CaptureFrame();
                scene = SceneSearch();
                Log(scene.SceneType.ToString());
                if ((MatchMapping(ShopPurchaseCompletePopupPM.AgainButtonBorder, 2) && MatchMapping(ShopPurchaseCompletePopupPM.OKButtonBorder, 2)) || scene.SceneType == SceneType.SHOP_PURCHASE_COMPLETE_POPUP)
                {
                    int counter = 1;
                    while (true)
                    {
                        SevenKnightsCore.Sleep(1000);
                        Log(string.Format("Keys bought ({0})", counter), COLOR_BUY_KEYS);
                        WeightedClick(ShopPurchaseCompletePopupPM.AgainButton, 1.0, 1.0, 1, 0, "left");
                        SevenKnightsCore.Sleep(3000);
                        CaptureFrame();
                        scene = SceneSearch();
                        if ((!MatchMapping(ShopPurchaseCompletePopupPM.AgainButtonBorder, 2) || !MatchMapping(ShopPurchaseCompletePopupPM.OKButtonBorder, 2)) || scene.SceneType != SceneType.SHOP_PURCHASE_COMPLETE_POPUP)
                        {
                            break;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                }
                if (start < 1)
                {
                    continue;
                }
                else
                {
                    DoneBuyKeys();
                    break;
                }
            }
            DoneBuyKeys();
        }

        private Bitmap CaptureFrame()
        {
            bool sT_ForegroundMode = AIProfiles.ST_ForegroundMode;
            return BlueStacks.CaptureFrame(!sT_ForegroundMode);
        }

        private void ChangeCurrentWave(int wave, int total)
        {
            CurrentWave = wave;
            Log("@ Wave " + wave + "/"+total+" Wave", COLOR_WAVE);
        }

        private void ChangeObjective(Objective objective)
        {
            string message = string.Empty;
            switch (objective)
            {
                case Objective.IDLE:
                    message = "Idle";
                    break;

                case Objective.ADVENTURE:
                    message = "Adventure";
                    break;

                case Objective.ARENA:
                    message = "Arena";
                    break;

                case Objective.CHECK_SLOT_HERO:
                    message = "Checking Slot: Hero";
                    break;

                case Objective.CHECK_SLOT_ITEM:
                    message = "Checking Slot: Item";
                    break;

                case Objective.SELL_HEROES:
                    message = "Sell Heroes";
                    break;

                case Objective.SELL_ITEMS:
                    message = "Sell Items";
                    break;

                case Objective.BUY_KEYS:
                    message = "Buy Keys";
                    break;

                case Objective.COLLECT_INBOX:
                    message = "Collect Inbox";
                    break;

                case Objective.COLLECT_QUESTS:
                    message = "Collect Quests";
                    break;

                case Objective.SEND_HONORS:
                    message = "Send Honors";
                    break;

                case Objective.SMART_MODE:
                    message = "Smart Mode";
                    break;
                case Objective.POWER_UP_HEROES:
                    message = "Power Up Heroes";
                    break;
                case Objective.FUSE_HEROES:
                    message = "Fuse Heroes";
                    break;
                case Objective.CHANGE_PROFILE:
                    message = "Change Profile";
                    break;
            }
            PreviousObjective = CurrentObjective;
            CurrentObjective = objective;
            Worker.ReportProgress(0, new ProgressArgs(ProgressType.OBJECTIVE, message));
        }

        private void DisableObjective(Objective Obj)
        {
            string message = string.Empty;
            switch (Obj)
            {

                case Objective.ADVENTURE:
                    message = "Adventure";
                    AISettings.AD_Enable = false;
                    break;


                case Objective.ARENA:
                    message = "Arena";
                    AISettings.AR_Enable = false;
                    break;

                case Objective.SMART_MODE:
                    message = "Smart Mode";
                    AISettings.SM_Enable = false;
                    break;

                case Objective.POWER_UP_HEROES:
                    message = "Auto Power Up";
                    AISettings.PU_Enable = false;
                    break;

                case Objective.FUSE_HEROES:
                    message = "Auto Bulk Fusion";
                    AISettings.BF_Enable = false;
                    break;

                case Objective.COLLECT_INBOX:
                    message = "Collect Inbox";
                    AISettings.RS_CollectInbox = false;
                    break;

            }
            Log(message + " Disabled", Color.Orange);
        }

        private bool CheckBoost()
        {
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, AdventureStartPM.R_Boost).ScaleByPercent(150))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace(" ", "").Replace("l100", "/100").Replace("l100", "/100").Replace("i100", "/100").Trim();
                    Utility.FilterAscii(text);
                    this.Log("BoostNumber = " + page.GetText().ToLower().Trim());
                    bitmap.Save("Boost.png");
#if DEBUG
                    Console.WriteLine("MapNumber = " + text.Trim());
                    bitmap.Save("MapNumber.png");
# endif
                    if (text.Length >= 2)
                    {
                        int num3 = -1;
                        int num4 = -1;
                        string[] array = text.Split(new char[]
                        {
                            '/'
                        });
                        if (array.Length < 2)
                        {
                            bool result = false;
                            return result;
                        }
                        int.TryParse(array[0], out num3);
                        int.TryParse(array[1], out num4);
                        this.Log("Current: " + num3 + " Max: " + num4);
                        CurrentBoost = num3;
                        if (num3 >= 100)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        this.Log("ErBoostNumber = " + page.GetText().ToLower().Trim());
                        bitmap.Save("ErBoost.png");
                    }
                }
            }
            return false;
        }

        private bool CheckMapNumber(World world, int stage)
        {
            if (world == World.None)
            {
                return true;
            }
            int num = world - World.Sequencer;
            int num2 = stage + 1;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, AdventureStartPM.R_MapNumber))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                        .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                        .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                        .Replace("#", "").Replace("—", "-").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3").Replace("!", "").Replace("?", "").Replace("103", "10").Replace("13;", "10").Replace("cg", "").Replace("203", "20");
                    Utility.FilterAscii(text);
                    this.Log("MapNumber = " + text.Trim());
#if DEBUG
                    Console.WriteLine("MapNumber = " + text.Trim());
                    bitmap.Save("MapNumber.png");
#endif
                    if (text.Length >= 2)
                    {
                        int num3 = -1;
                        int num4 = -1;
                        string[] array = text.Split(new char[]
                        {
                            '-'
                        });
                        if (array.Length < 2)
                        {
                            bool result = false;
                            return result;
                        }
                        int.TryParse(array[0], out num3);
                        int.TryParse(array[1], out num4);
                        this.Log("World: " + num3 + " Map: " + num4);
                        if (num3 >= 8)
                        {
                            this.entrytolv30 = 4;
                        }
                        else
                        {
                            this.entrytolv30 = 7;
                        }
                        if (num3 == num && num4 == num2)
                        {
                            bool result = true;
                            return result;
                        }
                    }
                }
            }
            return false;
        }


        private bool CheckMapNumber2(World world, int stage)
        {
            if (world == World.None)
            {
                return true;
            }
            int num = world - World.Sequencer;
            int num2 = stage + 1;
            Bitmap test = CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, AdventureReadyPM.R_MapNumber))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("»", "-").Replace("—", " -").Replace("3-20", "8-20").Replace("[8-201", "[8-20]").Replace("18-201", "[8-20]").Trim();
                    if (world == World.DarkGrave)
                    {
                        text = text.Replace("14-", "[4-");
                    }
                    Match regex = Regex.Match(text, @"(?<=\[)[^]]+(?=\])");
                    this.Log("MapText: "+text);
                    if (regex.Success)
                    {
                        string test1 = regex.Value;
                        int num3 = -1;
                        int num4 = -1;
                        string[] array2 = test1.Split(new char[]
                        {
                            '-'
                        });
                        int.TryParse(array2[0], out num3);
                        int.TryParse(array2[1], out num4);
                        this.Log("World: " + num3 + " Map: " + num4);
                        if (num3 == num && num4 == num2)
                        {
                            bool result = true;
                            return result;
                        }
                        else
                        {
                            bool result = false;
                            return result;
                        }
                    }
                    else
                    {
                        Log("MapText: " + text);
                        return false;
                    }
                }
            }
        }

        private void ClickDrag(int startX, int startY, int endX, int endY)
        {
            BlueStacks.MainWindowAS.ClickDrag(startX, startY, endX, endY, 0, "left");
        }

        private void CollectInbox()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                InboxPM.HonorsTab,
                InboxPM.KeysTab,
                InboxPM.CurrencyTab,
                InboxPM.TicketTab
            };
            string[] array3 = new string[]
            {
                "Honors",
                "Keys",
                "Currency",
                "Tickets"
            };
            bool[] array4 = new bool[]
            {
                AISettings.RS_CIOnlyHonor,
                AISettings.RS_CIOnlyKey,
                AISettings.RS_CIOnlyCurrency,
                AISettings.RS_CIOnlyTicket
            };
            Log("Start collecting inbox", COLOR_INBOX);
            SendTelegram("[Collect Inbox] Bot is collecting your inbox.");
            int current2 = 0;
            Scene scene;
            while (current2 < 4)
            {
                if (Worker.CancellationPending)
                {
                    return;
                }
                CaptureFrame();
                scene = SceneSearch();
                if (scene != null)
                {
                    if (scene.SceneType != SceneType.INBOX)
                    {
                        DoneCollectInbox();
                        return;
                    }
                }
                if (array4[current2])
                {
                    SevenKnightsCore.Sleep(500);
                    Log(string.Format("Collecting {0}", array3[current2]), COLOR_INBOX);
                    PixelMapping mapping = array[current2];
                    WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(1000);
                    CaptureFrame();
                    if (MatchMapping(InboxPM.CollectAllButtonBackground, 2) && MatchMapping(InboxPM.CollectAllButtonBackground2, 2))
                    {
                        Log(string.Format("Collect All {0} rewards", array3[current2]), COLOR_INBOX);
                        WeightedClick(InboxPM.CollectAllButton, 1.0, 1.0, 1, 0, "left");
                        Sleep(2000);
                        CaptureFrame();
                        scene = SceneSearch();
                        if (scene != null)
                        {
                            if (scene.SceneType == SceneType.INBOX_COLLECT_FAILED_POPUP_2)
                            {
                                WeightedClick(InboxCollectFailedPopupPM.TapArea, 1.0, 1.0, 1, 0, "left");
                                Sleep(500);
                                CaptureFrame();
                                scene = SceneSearch();
                                if (scene != null)
                                {
                                    if (scene.SceneType == SceneType.INBOX_REWARDS_POPUP)
                                    {
                                        Log(string.Format("Collect All {0} rewards success, next tab", array3[current2]), COLOR_INBOX);
                                        WeightedClick(InboxRewardsPopupPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                        Sleep(1000);
                                        CaptureFrame();
                                        if (current2 == 3 && MatchMapping(InboxPM.CollectAllButtonBackground, 2))
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            current2++;
                                        }
                                    }
                                }
                            }
                            else if (scene.SceneType == SceneType.INBOX_REWARDS_POPUP)
                            {
                                Log(string.Format("Collect All {0} rewards success, next tab", array3[current2]), COLOR_INBOX);
                                WeightedClick(InboxRewardsPopupPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                Sleep(1000);
                                CaptureFrame();
                                if (current2 == 3 && MatchMapping(InboxPM.CollectAllButtonBackground, 2))
                                {
                                    continue;
                                }
                                else
                                {
                                    current2++;
                                }
                            }
                            else if (scene.SceneType == SceneType.INBOX_COLLECT_FAILED_POPUP)
                            {
                                Log(string.Format("Collect All {0} rewards failed, next tab", array3[current2]), COLOR_INBOX);
                                Escape();
                                Sleep(2000);
                                current2++;
                            }
                        }
                        else
                        {
                            Log(string.Format("Collect All {0} rewards failed, next tab", array3[current2]), COLOR_INBOX);
                            Escape();
                            Sleep(2000);
                            current2++;
                        }
                    }
                    else
                    {
                        Log(string.Format("{0} tab is empty, next tab", array3[current2]), COLOR_INBOX);
                        current2++;
                    }
                }
                else
                {
                    Log(string.Format("{0} not checked, next tab", array3[current2]), COLOR_INBOX);
                    current2++;
                }
            }
            DoneCollectInbox();
        }

        private void CreateHangFingerprint(int[] array)
        {
            if (array.Length < 50)
            {
                throw new Exception("Invalid array size");
            }
            Point[] array2 = new Point[]
            {
                new Point(188, 38),
                new Point(373, 42),
                new Point(662, 40),
                new Point(158, 381),
                new Point(317, 364),
                new Point(480, 377),
                new Point(645, 357),
                new Point(799, 348),
                new Point(203, 17),
                new Point(677, 17),
                new Point(184, 14),
                new Point(362, 12),
                new Point(653, 10),
                new Point(547, 68),
                new Point(711, 65),
                new Point(889, 66),
                new Point(510, 83),
                new Point(601, 82),
                new Point(714, 79),
                new Point(855, 85),
                new Point(478, 530),
                new Point(248, 528),
                new Point(572, 424),
                new Point(587, 507),
                new Point(671, 427),
                new Point(660, 504),
                new Point(746, 495),
                new Point(766, 416),
                new Point(836, 426),
                new Point(836, 493),
                new Point(919, 491),
                new Point(941, 399),
                new Point(120, 498),
                new Point(43, 489),
                new Point(32, 512),
                new Point(426, 26),
                new Point(506, 27),
                new Point(543, 24),
                new Point(560, 26),
                new Point(868, 26),
                new Point(710, 528),
                new Point(294, 123),
                new Point(303, 124),
                new Point(437, 40),
                new Point(463, 41),
                new Point(606, 94),
                new Point(680, 85),
                new Point(765, 95),
                new Point(815, 87),
                new Point(891, 90)
            };
            for (int i = 0; i < 50; i++)
            {
                array[i] = GetPixel(array2[i].X, array2[i].Y);
            }
        }

        private string CheckOwnername()
        {
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, LobbyPM.OwnerLocation).ScaleByPercent(150))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().Trim();
#if DEBUG
                    Console.WriteLine("Name = " + text.Trim());
                    bitmap.Save("Name.png");
#endif
                    Utility.FilterAscii(text);
                    if (text != "")
                    {
                        PlayerName = text.Trim();
                        Log("Owner Name = " + PlayerName, Color.BlueViolet);
                    }
                    else
                    {
                        PlayerName = "NULL";
                    }
                }
#if DEBUG
                Console.WriteLine("Owner Name = " + PlayerName);
#endif
                return PlayerName;
            }
        }

        private string CheckAndroidPopup()
        {
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, AndroidPopupPM.TitlePopup))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().Trim();
#if DEBUG
                    Console.WriteLine("Name = " + text.Trim());
                    bitmap.Save("Name.png");
#endif
                    Utility.FilterAscii(text);
                    if (text != "")
                    {
                        PlayerName = text.Trim();
                        Log("Title Text = " + PlayerName, Color.BlueViolet);
                    }
                    else
                    {
                        PlayerName = "NULL";
                    }
                }
#if DEBUG
                Console.WriteLine("Owner Name = " + PlayerName);
#endif
                return PlayerName;
            }
        }

        private void CheckArenaScore()
        {
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, ArenaEndPM.ArenaScore))
            {
                int arenaScore = 0;
                using (Page page = Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                        .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                        .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                        .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3").Trim();
#if DEBUG
                    bitmap.Save("ArenaScore2.png");
#endif
                    Utility.FilterAscii(text);
                    Log(string.Format("Text = {0}", text), COLOR_ARENA);
                    string[] test1 = text.Split('(');
                    string test2 = Regex.Replace(test1[0], @"\D", "");
                    Log(string.Format("Arena Score = {0}", test2), COLOR_ARENA);
                    int.TryParse(test2, out arenaScore);
                    ArenaRank = arenaScore;
                    if (AISettings.AR_LimitArena)
                    {
                        if (arenaScore >= AISettings.AR_LimitScore)
                        {
                            SevenKnightsCore.Sleep(800);
                            NextPossibleObjective();
                            Log(string.Format("Arena Score Limit"), Color.BlueViolet);
                        }
                    }
                }
            }
        }

        private void CheckArenaScoreReady()
        {
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, ArenaReadyPM.ArenaScore))
            {
                int arenaScore = 0;
                using (Page page = Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                        .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                        .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                        .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3");
#if DEBUG
                    bitmap.Save("ArenaScore1.png");
#endif
                    string test1 = Regex.Replace(text, @"\D", ""); // เอา String ออกจาก Number
                    Utility.FilterAscii(test1);
                    int.TryParse(test1, out arenaScore);
                    Log(string.Format("Arena Score = {0}", arenaScore), COLOR_ARENA);
                    ArenaRank = arenaScore;
                    if (AISettings.AR_LimitArena)
                    {
                        if (arenaScore >= AISettings.AR_LimitScore)
                        {
                            SevenKnightsCore.Sleep(800);
                            NextPossibleObjective();
                            Log(string.Format("Arena Score Limit"), Color.BlueViolet);
                        }
                    }

                }
            }
        }

        private void Countentrylv30(bool boost)
        {
                        /**
                         * World 1 - 2 = 1 Wave = 16x
                         * World 3 - 5 = 2 Wave = 8x
                         * World 6-7 = 3 Wave = 7x
                         * World 8-13 = 2 Wave = 4x
                         */
            if (this.world3 == World.MysticWoods || this.world3 == World.SilentMine)
            {
                entrytolv30 = 16;
            }
            else if (this.world3 == World.BlazingDesert || this.world3 == World.DarkGrave || this.world3 == World.DragonRuins)
            {
                if (boost)
                {
                    entrytolv30 = 3;
                }
                else
                {
                    entrytolv30 = 8;
                }
            }
            else if (this.world3 == World.FrozenLand || this.world3 == World.Purgatory)
            {
                if (boost)
                {
                    entrytolv30 = 3;
                }
                else
                {
                    entrytolv30 = 7;
                }
            }
            else
            {
                if (boost)
                {
                    entrytolv30 = 2;
                }
                else
                {
                    entrytolv30 = 4;
                }
            }
        }

        private Bitmap CropFrame(Bitmap frame, Rectangle rect)
        {
            rect.X += BlueStacks.OFFSET_X;
            rect.Y += BlueStacks.OFFSET_Y;
            return frame.Clone(rect, frame.PixelFormat);
        }

        private void DoneBuyKeys()
        {
            Log("Done buying keys", COLOR_BUY_KEYS);
            SendTelegram("[Buy Keys] Bot has finished buying keys.");
            NextPossibleObjective();
            SevenKnightsCore.Sleep(300);
            Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DoneCollectInbox()
        {
            Log("Done collecting inbox", COLOR_INBOX);
            SendTelegram("[Collect Inbox] Bot has finished collecting your inbox.");
            NextPossibleObjective();
            SevenKnightsCore.Sleep(1000);
            Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DoneSellHeroes(int sellCount)
        {
            Log("Done selling heroes", COLOR_SELL_HEROES);
            SendTelegram("[Sell Heroes] Bot has finished selling your heroes.");
            if (sellCount == 0)
            {
                Log("No more heroes that satisfied the conditions", COLOR_SELL_HEROES);
                CooldownSellHeroes = 900000;
            }
            NextPossibleObjective();
            SevenKnightsCore.Sleep(300);
            Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DonePowerUpHeroes(int powerUpCount)
        {
            Log("Done powering up heroes. Total Hero: " + powerUpCount.ToString(), COLOR_POWER_UP);
            SendTelegram("[Auto Power Up] Bot has finished powering up your heroes. Total Hero: "+powerUpCount.ToString());
            if (powerUpCount == 0)
            {
                Log("No more heroes that satisfied the conditions", COLOR_POWER_UP);
                NextPossibleObjective();
            }
            if (AISettings.BF_EnableActivate1)
            {
                ChangeObjective(Objective.FUSE_HEROES);
                Escape();
                SevenKnightsCore.Sleep(1000);
                return;
            }
            else
            {
                NextPossibleObjective();
                return;
            }
        }

        private void DoneFuseHeroes()
        {
            Log("Done fusing heroes", COLOR_FUSE);
            SendTelegram("[Auto Bulk Fusion] Bot has finished bulk fuse your heroes.");
            NextPossibleObjective();
            Escape();
            SevenKnightsCore.Sleep(300);
            Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DoneSellHeroesMini()
        {
            SevenKnightsCore.Sleep(1000);
            Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DoneSellItems()
        {
            Log("Done selling items", COLOR_SELL_ITEMS);
            SendTelegram("[Sell Items] Bot has finished selling your items.");
            //if (sellCount == 0)
            // {
            //   this.Log("No more items that satisfied the conditions", this.COLOR_SELL_ITEMS);
            //   this.CooldownSellItems = 900000;
            //}
            NextPossibleObjective();
            SevenKnightsCore.Sleep(300);
            Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DoneHottime()
        {
            Hottimeloop = false;
            Hottimeactive = true;
            SevenKnightsCore.Sleep(800);
            Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void Escape()
        {
            CaptureFrame();
            if (this.MatchMapping(SharedPM.BackButtonAnchor, 2))
            {
                this.WeightedClick(SharedPM.BackButton, 1.0, 1.0, 1, 0, "left");
            }
            else if (this.MatchMapping(SharedPM.BackButtonAnchor2, 2))
            {
                this.WeightedClick(SharedPM.BackButton2, 1.0, 1.0, 1, 0, "left");
            }
            else if (this.MatchMapping(SharedPM.XButtonAnchor, 2))
            {
                this.WeightedClick(SharedPM.XButton, 1.0, 1.0, 1, 0, "left");
            }
            else if (this.MatchMapping(SharedPM.MiniXButtonAnchor, 2))
            {
                this.WeightedClick(SharedPM.MiniXButton, 1.0, 1.0, 1, 0, "left");
            }
            else
            {
                BlueStacks.MainWindowAS.PressKey(27u, 1, 0);
            }
        }

        private bool ExpectingScene(SceneType sceneType, int retry = 5, int sleepInterval = 500)
        {
            for (int i = 0; i < retry; i++)
            {
                if (Worker.CancellationPending)
                {
                    return false;
                }
                CaptureFrame();
                Scene scene = SceneSearch();
                if (scene != null)
                {
                    if (scene.SceneType == sceneType)
                    {
                        return true;
                    }
                }
                SevenKnightsCore.Sleep(sleepInterval);
            }
            return false;
        }

        private bool ExpectingScenes(List<SceneType> sceneTypes, int retry = 5, int sleepInterval = 500)
        {
            for (int i = 0; i < retry; i++)
            {
                if (Worker.CancellationPending)
                {
                    return false;
                }
                CaptureFrame();
                Scene scene = SceneSearch();
                if (scene != null)
                {
                    if (sceneTypes.Contains(scene.SceneType))
                    {
                        return true;
                    }
                }
                SevenKnightsCore.Sleep(sleepInterval);
            }
            return false;
        }

        private int FindShortestWorldPath(int current, int destination, int maxNodes)
        {
            int num = current - destination;
            int num2 = destination - current;
            if (num == 0 || num2 == 0)
            {
                return 0;
            }
            if (num < 0)
            {
                num += maxNodes;
            }
            if (num2 < 0)
            {
                num2 += maxNodes;
            }
            if (num == num2)
            {
                return num2;
            }
            if (num >= num2)
            {
                return num2;
            }
            return -num;
        }

        private int GetPixel(int x, int y)
        {
            return BlueStacks.GetPixel(x, y);
        }

        private Tuple<World, int, int> GetWorldStageFromSequencer()
        {
            if (AISettings.AD_World != World.Sequencer)
            {
                return null;
            }
            if (AISettings.AD_WorldSequence == null || AISettings.AD_WorldSequence.Length <= 0 || AISettings.AD_StageSequence == null || AISettings.AD_StageSequence.Length <= 0 || AISettings.AD_AmountSequence == null || AISettings.AD_AmountSequence.Length <= 0 || AISettings.AD_BoostSequence == null)
            {
                return null;
            }
            World item = (World)AISettings.AD_WorldSequence[CurrentSequence];
            int item2 = AISettings.AD_StageSequence[CurrentSequence];
            int item3 = AISettings.AD_BoostSequence[CurrentSequence];
            return new Tuple<World, int, int>(item, item2, item3);
        }

        private void HandleOutOfKey(SceneType sceneType)
        {
            if (sceneType != SceneType.OUT_OF_KEYS_POPUP)
            {
                return;
            }
            Dictionary<SceneType, PixelMapping[]> dictionary = new Dictionary<SceneType, PixelMapping[]>
            {
                {
                    SceneType.OUT_OF_KEYS_OFFER,
                    new PixelMapping[]
                    {
                        //OutOfKeysPopupPM.ShopButton,
                        //OutOfKeysPopupPM.NoButton
                    }
                }
            };
            PixelMapping[] array = dictionary[sceneType];
            if (IsBuyKeysEnabled())
            {
                WeightedClick(array[0], 1.0, 1.0, 1, 0, "left");
                if (CurrentObjective != Objective.BUY_KEYS)
                {
                    ChangeObjective(Objective.BUY_KEYS);
                    return;
                }
            }
            else
            {
                WeightedClick(array[1], 1.0, 1.0, 1, 0, "left");
                NextPossibleObjective();
            }
        }

        private void HandleSmartMode()
        {
            Rectangle[] R_0 = new Rectangle[]
            {
                SmartLobbyPM.R_GoldenCrystal,
                SmartLobbyPM.R_Gold
            };
            Rectangle R_2 = SmartLobbyPM.R_Star;
            Rectangle[] R_1 = new Rectangle[]
            {
                SmartLobbyPM.R_Horn,
                SmartLobbyPM.R_Scale,
                SmartLobbyPM.R_Essecense
            };
            Log("Start Collecting Smart mode rewards", COLOR_SMART_MODE);
            SendTelegram("[Smart Mode] Bot starting to collecting smart mode rewards");
            SevenKnightsCore.Sleep(500);
            Log("Collect rewards", COLOR_SMART_MODE);
            WeightedClick(SmartLobbyPM.CollectButton, 1.0, 1.0, 1, 0, "left");
            SevenKnightsCore.Sleep(1000);
            CaptureFrame();
            Scene scene = SceneSearch();
            if (scene.SceneType == SceneType.SMART_LOOT_COLLECT_LOBBY)
            {
                WeightedClick(SmartLootCollectPM.OpenAllButton, 1.0, 1.0, 1, 0, "left");
                Log("Collect rewards success", COLOR_SMART_MODE);
                GoldenCrystalCount += ParseSmartResource(R_0[0]);
                ReportResources(ResourceType.GOLDEN_CRYSTAL);
                Sleep(750);
                GoldCount += ParseSmartResource(R_0[1]);
                ReportResources(ResourceType.GOLD);
                Sleep(750);
                HornCount += ParseSmartResource(R_1[0]);
                ReportResources(ResourceType.HORN);
                Sleep(750);
                ScaleCount += ParseSmartResource(R_1[1]);
                ReportResources(ResourceType.SCALE);
                Sleep(750);
                EssecenseCount += ParseSmartResource(R_1[2]);
                ReportResources(ResourceType.ESSENCE);
                Sleep(750);
                StarCount += ParseSmartResource(R_2);
                ReportResources(ResourceType.STAR);
                Sleep(750);
                SmartModeAfterFight();
            }
            else
            {
                Log("Resources Not Available", COLOR_SMART_MODE);
                SmartModeAfterFight();
            }
        }

        private void HeroSortReset(bool sortLevel = true, bool ascending = true)
        {
            if (sortLevel)
            {
                if (!MatchMapping(HeroesPM.SortByBoxExpanded, 2))
                {
                    WeightedClick(HeroesPM.SortByBox, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(300);
                }
                WeightedClick(HeroesPM.SortByLevel, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(AIProfiles.ST_Delay);
            }
            PixelMapping mapping = ascending ? HeroesPM.SortButtonAscending : HeroesPM.SortButtonDescending;
            if (!MatchMapping(mapping, 2))
            {
                WeightedClick(HeroesPM.SortButton, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(AIProfiles.ST_Delay);
            }
            ScrollHeroCards(false);
            SevenKnightsCore.Sleep(500);
        }

        private void InitLoop()
        {
            CurrentObjective = Objective.IDLE;
            NextPossibleObjective();
            MapCheckCount = 0;
            CurrentSequence = 0;
            CurrentSequenceCount = 0;
            CurrentSequenceCount2 = 0; //to stop auto repeat
            CurrentWave = 0;
            KeysBoughtHonors = 0;
            KeysBoughtRubies = 0;
            ArenaRubiesCount = 0;
            HangCounter = 0;
            IdleCounter = 0;
            MapSelectCounter = 0;
            CooldownInbox = 0;
            CooldownSendHonors = 0;
            CooldownSellHeroes = 0;
            CooldownSellItems = 0;
            AdventureCount = 0;
            AdventureCount2 = 0;
            SmartModeCount = 0;
            ArenaWinCount = 0;
            ArenaRank = 0;
            ArenaLoseCount = 0;
            ReportAllCount();
            AdventureLimitCount = 0;
            AdventureLimitCount2 = 0;
            AdventureLimitFuse = 0;
            AdventureLimitPowerUp = 0;
            AdventureLimitCheckSlot = 0;
            AdventureLimitCollectInbox = 0;
            entrytolv30 = 0;
            h30 = 0;
            ArenaLimitCount = 0;
            HeroCount = 0;
            ItemCount = 0;
            MaxHeroUpCount = false;
            nomorehero30 = false;
            AdventureKeys = -1;
            AdventureKeyTime = TimeSpan.MaxValue;
            TowerKeys = -1;
            TowerKeyTime = TimeSpan.MaxValue;
            ArenaKeys = -1;
            ArenaKeyTime = TimeSpan.MaxValue;
            ReportAllKeys();
            GoldCount = -1;
            RubyCount = -1;
            HonorCount = -1;
            TopazCount = -1;
            GoldenCrystalCount = 0;
            HornCount = 0;
            ScaleCount = 0;
            EssecenseCount = 0;
            StarCount = 0;
            SoulCount = 0;
            CurrentBoost = 0;
            ReportAllResources();
            OneSecTimer.Enabled = true;
            checkslothero = false;
            checkslotitem = false;
            changemap = false;
            IsAdventureLimit = false;
            herofull = false;
            itemfull = false;
            isboostsequence = false;
            IsAlreadyAdvEnd = false;
            IsAlreadyAdvLoot = false;
            IsAlreadyAdvLootAuto = false;
            alreadyCollectInboxBuyKeys = false;
            internetdc = 0;
            unknowncollected = false;
            isboostalreadylimit = false;
            alreadyadvready = false;
            PreviousScene = DefaultScene;
        }

        private bool IsBuyKeysEnabled()
        {
            return IsBuyKeysHonors() || IsBuyKeysRubies();
        }

        private bool IsBuyKeysHonors()
        {
            return AISettings.RS_BuyKeyHonors;
        }

        private bool IsBuyKeysRubies()
        {
            return AISettings.RS_BuyKeyRubies && KeysBoughtRubies < AISettings.RS_BuyKeyRubiesAmount;
        }

        private bool IsGameActive()
        {
            IList text = BlueStacks.MainWindowAS.GetText();
            Console.Write(text.Contains("Seven Knights") || text.Contains("Android"));
            return text.Contains("Seven Knights") || text.Contains("Android");
        }

        private bool IsInboxEnabled()
        {
            return AISettings.RS_EnableCI;
        }

        private void Log(string message)
        {
            Log(message, Color.Black);
        }

        private void Log(string message, Color color)
        {
            ProgressArgs userState = new ProgressArgs(ProgressType.EVENT, message, color);
            Worker.ReportProgress(0, userState);
        }

        private void LogError(string message)
        {
            ProgressArgs userState = new ProgressArgs(ProgressType.ERROR, message);
            Worker.ReportProgress(0, userState);
        }

        private void LogScene(string scene)
        {
            string str = Utility.ToTitleCase(scene.Replace("_", " "));
            Log("Scene: " + str, Color.SlateGray);
        }

        private void LongSleep(int timeout, int interval = 1000)
        {
            int num = 0;
            while (!Worker.CancellationPending && num < timeout)
            {
                SevenKnightsCore.Sleep(interval);
                num += interval;
            }
        }

        private void PerformAdventureFight(World w)
        {
            if ((!MatchMapping(AdventureFightPM.FightButtonShown, 2) || !MatchMapping(AdventureFightPM.FightButtonShown2, 2)))
            {
                WeightedClick(AdventureFightPM.ShowFightButton, 1.0, 1.0, 1, 0, "left");
            }
            IsAlreadyAdvLoot = false;
            IsAlreadyAdvLootAuto = false;
            CaptureFrame();
            if (w == World.MysticWoods || w == World.SilentMine)
            {
                if (MatchMapping(AdventureFightPM.AtTurn1Of1_1, 2) && MatchMapping(AdventureFightPM.AtTurn1Of1_2, 2))
                {
                    int num3 = 1;
                    if (CurrentWave < num3)
                    {
                        ChangeCurrentWave(num3, 1);
                    }
                    if (!IsAlreadyAdvEnd)
                    {
                        Sleep(1750);
                        EndAutoRepeat();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else if (w == World.BlazingDesert || w == World.DarkGrave || w == World.DragonRuins || w > World.Purgatory)
            {
                if (MatchMapping(AdventureFightPM.AtTurn1Of2_1, 2) && MatchMapping(AdventureFightPM.AtTurn1Of2_2, 2))
                {
                    int num3 = 1;
                    if (CurrentWave < num3)
                    {
                        ChangeCurrentWave(num3, 2);
                    }
                }
                else if (MatchMapping(AdventureFightPM.AtTurn2Of2_1, 2) && MatchMapping(AdventureFightPM.AtTurn2Of2_2, 2))
                {
                    int num3 = 2;
                    if (CurrentWave < num3)
                    {
                        ChangeCurrentWave(num3, 2);
                    }
                    if (!IsAlreadyAdvEnd)
                    {
                        Sleep(2750);
                        EndAutoRepeat();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else if (w == World.FrozenLand || w == World.Purgatory)
            {
                if (MatchMapping(AdventureFightPM.AtTurn1Of3_1, 2) && MatchMapping(AdventureFightPM.AtTurn1Of3_2, 2))
                {
                    int num3 = 1;
                    if (CurrentWave < num3)
                    {
                        ChangeCurrentWave(num3, 3);
                    }
                }
                else if (MatchMapping(AdventureFightPM.AtTurn2Of3_1, 2) && MatchMapping(AdventureFightPM.AtTurn2Of3_2, 2))
                {
                    int num3 = 2;
                    if (CurrentWave < num3)
                    {
                        ChangeCurrentWave(num3, 3);
                    }
                }
                else if (MatchMapping(AdventureFightPM.AtTurn3Of3_1, 2) && MatchMapping(AdventureFightPM.AtTurn3Of3_2, 2))
                {
                    int num3 = 3;
                    if (CurrentWave < num3)
                    {
                        ChangeCurrentWave(num3, 3);
                    }
                    if (!IsAlreadyAdvEnd)
                    {
                        Sleep(6500);
                        EndAutoRepeat();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        public void MainLoop(object sender, DoWorkEventArgs e)
        {
            bool flag = false;
            bool flag2 = false;
            bool flag3 = false;
            Hottimeloop = true;
            CheckPlayaName = true;
            alreadystop = false;
            Log("Initializing AI...");
            BlueStacks = new BlueStacks();
            BlueStacks.setHandleTitle(AIProfiles.ST_LDTitle);
            string errorMessage;
            if (!BlueStacks.Hook())
            {
                errorMessage = "LDPlayer is not active or not yet initialized";
                SendTelegram("[ERROR] LDPlayer is not active or not yet initialized");
                LogError(errorMessage);
                SynchronizationContext.Send(delegate (object callback)
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }, null);
                return;
            }
            if (BlueStacks.NeedWindowResize())
            {
                Log("W:" + BlueStacks.GetWindowSize().Width + " H:" + BlueStacks.GetWindowSize().Height);
                string text = "LDPlayer needs to be resized. Proceed?";
                SendTelegram("[ERROR] LDPlayer needs to be resized. Check now!");
                DialogResult dialogResult = MessageBox.Show(text, "Restart Required", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.OK)
                {
                    string exePath = BlueStacks.GetExePath();
                    BlueStacks.ResizeWindow();
                    BlueStacks.Kill();
                    SevenKnightsCore.Sleep(1000);
                    Process.Start(exePath);
                }
                return;
            }
            if (BlueStacks.IsGameInstalled())
            {
                if (!BlueStacks.IsGameActive())
                {
                    Log("Launching Seven Knights...");
                    BlueStacks.LaunchGame();
                    LongSleep(3000, 1000);
                }
                InitLoop();
                string value = null;
                while (!Worker.CancellationPending)
                {
                    try
                    {
                        if (!AIProfiles.TMP_Paused && !AIProfiles.TMP_WaitingForKeys && !AIProfiles.TMP_WaitingForInternet)
                        {
                            if (AIProfiles.ST_BlueStacksForceActive)
                            {
                                BlueStacks.MainWindowAS.BringToFront();
                            }
                            int sT_Delay = AIProfiles.ST_Delay;
                            SevenKnightsCore.Sleep(sT_Delay);
                            IdleCounter += sT_Delay;
                            HangCounter += sT_Delay;
                            MapSelectCounter += sT_Delay;
                            CooldownInbox -= sT_Delay;
                            CooldownSendHonors -= sT_Delay;
                            CooldownSellHeroes -= sT_Delay;
                            CooldownSellItems -= sT_Delay;
                            CaptureFrame();
                            if (BlueStacks.MainWindowAS.CurrentFrame != null)
                            {
                                UpdateHangFingerprint();
                                if (HangCounter >= 30000)
                                {
                                    Log("Restarting Seven Knights", Color.DarkRed);
                                    SendTelegram("[ERROR] The game is not responding... Bot will restart the game and continue.");
                                    HangCounter = 0;
                                    if (!BlueStacks.RestartGame(5))
                                    {
                                        errorMessage = "Restart failed";
                                        LogError(errorMessage);
                                        SynchronizationContext.Send(delegate (object callback)
                                        {
                                            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        }, null);
                                        break;
                                    }
                                    IdleCounter = 0;
                                    LongSleep(10000, 1000);
                                }
                                Scene scene = SceneSearch();
                                bool flag4 = false;
                                string text2 = "";
                                if (scene == null)
                                {
                                    Sleep(AIProfiles.ST_Delay);
                                    int sleep = 0;
                                    for (int i = 0; i < 7; i++)
                                    {
                                        CaptureFrame();
                                        scene = SearchScenes();
                                        if (scene != null)
                                        {
                                            text2 = scene.SceneType.ToString();
                                            break;
                                        }
                                        sleep += 1000;
                                        Sleep(sleep);
                                    }
                                    if (scene == null)
                                    {
                                        text2 = "...";
                                        flag4 = true;
                                        IdleCounter += sT_Delay;
                                    }
                                }
                                else
                                {
                                    text2 = scene.SceneType.ToString();
                                }
                                if (!text2.Equals(value))
                                {
                                    if (IdleCounter > 10000)
                                    {
                                        Log("IdleTime = " + IdleCounter / 1000, Color.Orange);
                                    }
                                    LogScene(text2);
                                    value = text2;
                                    IdleCounter = 0;
                                }
                                if (flag4)
                                {
                                    if (!BlueStacks.IsGameActive())
                                    {
                                        Log("Launching Seven Knights...");
                                        BlueStacks.LaunchGame();
                                        LongSleep(3000, 1000);
                                    }
                                    else
                                    {
                                        LogScene("BACKABLE");
                                        Escape();
                                    }
                                }
                                else
                                {
                                    if (scene.SceneType != SceneType.MAP_SELECT)
                                    {
                                        MapSelectCounter = 0;
                                    }
                                    if (scene.SceneType != SceneType.ADVENTURE_START && scene.SceneType != SceneType.MAP_SELECT && scene.SceneType != SceneType.ADVENTURE_READY && scene.SceneType != SceneType.MAP_SELECT_POPUP)
                                    {
                                        MapCheckCount = 0;
                                    }
                                    IdleCounter = 0;
                                    switch (scene.SceneType)
                                    {

                                        case SceneType._ANDROID_POPUP:
                                            string msg = CheckAndroidPopup();
                                            if (AIProfiles.ST_ReconnectInterruptEnable && msg == "Duplicate login")
                                            {
                                                LongSleep(AIProfiles.ST_ReconnectInterruptInterval * 60000, 1000);
                                                if (!BlueStacks.RestartGame(5))
                                                {
                                                    SynchronizationContext.Send(delegate (object callback)
                                                    {
                                                        MessageBox.Show("BlueStacks restart failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                    }, null);
                                                    return;
                                                }
                                            }
                                            else if (msg == "URGENT NOTICE")
                                            {
                                                WeightedClick(AndroidPopupPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            Sleep(2000);
                                            break;
                                        case SceneType._FORCE_CLOSE:
                                            WeightedClick(ForceClosePopupPM.OkBtn, 1.0, 1.0, 1, 1, "left");
                                            Sleep(2000);
                                            break;

                                        case SceneType._NOT_RESPONDING_POPUP:
                                            WeightedClick(AndroidPopupPM.NRWaitText, 1.0, 1.0, 1, 1, "left");
                                            Sleep(2000);
                                            break;

                                        case SceneType.AHRI_CONNECTING:

                                            break;

                                        case SceneType.ARES_CUP_CONTESTANTS:
                                            Escape();
                                            break;

                                        case SceneType.EMULATOR_HOME:
                                            BlueStacks.LaunchGame();
                                            break;

                                        case SceneType._DIALOG:
                                            Escape();
                                            SevenKnightsCore.Sleep(300);
                                            break;

                                        case SceneType.TAP_TO_PLAY:
                                            WeightedClick(TapToPlayPM.TapArea, 1.0, 1.0, 1, 0, "left");
                                            SevenKnightsCore.Sleep(2000);
                                            //this.LongSleep(5000, 1000);
                                            break;

                                        case SceneType.LOADING:
                                            UpdateHangFingerprint();
                                            if (HangCounter >= 30000)
                                            {
                                                Log("Restarting Seven Knights", Color.DarkRed);
                                                SendTelegram("The game is not responding... Bot will restart the game and continue.");
                                                HangCounter = 0;
                                                if (!BlueStacks.RestartGame(5))
                                                {
                                                    errorMessage = "Restart failed";
                                                    LogError(errorMessage);
                                                    SynchronizationContext.Send(delegate (object callback)
                                                    {
                                                        MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                    }, null);
                                                    break;
                                                }
                                                IdleCounter = 0;
                                                LongSleep(10000, 1000);
                                            }
                                            break;

                                        case SceneType.PAUSE:
                                            WeightedClick(PausePM.ContinueButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.NOTICE:
                                            WeightedClick(NoticePM.CloseButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.CHECK_IN:
                                            WeightedClick(CheckInPM.CloseButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.DISCONNECTED_POPUP:
                                            WeightedClick(DisconnectedPopupPM.OKTick, 1.0, 1.0, 1, 0, "left");
                                            LongSleep(3000, 1000);
                                            break;

                                        case SceneType.EXIT_POPUP:
                                            WeightedClick(ExitPopupPM.NoButton, 1.0, 1.0, 1, 0, "left");
                                            Sleep(2000);
                                            break;

                                        case SceneType.TEMPORARY_STORAGE:
                                            WeightedClick(TemporaryStoragePM.CloseButton, 1.0, 1.0, 1, 0, "left");
                                            Sleep(2000);
                                            break;

                                        case SceneType.WIFI_WARNING_POPUP:
                                            WeightedClick(WifiWarningPopupPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.UNKNOWN_AREA:
                                            if (!unknowncollected)
                                            {
                                                WeightedClick(UnknownPopupPM.CollectBtn, 1.0, 1.0, 1, 0, "left");
                                                Sleep(1000);
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;

                                        case SceneType.UNKNOWN_AREA_SUCCESS:
                                            WeightedClick(UnknownPopupPM.CollectBtn, 1.0, 1.0, 1, 0, "left");
                                            unknowncollected = true;
                                            Sleep(1000);
                                            break;

                                        case SceneType.LOBBY:
                                            UpdateAdventureKeys(scene.SceneType);
                                            UpdateGold(scene.SceneType);
                                            UpdateRuby(scene.SceneType);
                                            UpdateHonor(scene.SceneType);
                                            /*
                                            if (CheckPlayaName == true)
                                            {
                                                WeightedClick(LobbyPM.MasteryButton, 1.0, 1.0, 1, 0, "left");
                                                SevenKnightsCore.Sleep(800);
                                                CaptureFrame();
                                                CheckOwnername();
                                                Escape();
                                                SevenKnightsCore.Sleep(800);
                                                CheckPlayaName = false;
                                            }
                                            */
                                            /*
                                            if (MatchMapping(LobbyPM.UnknownAvailable, 3)) //&&Collect Unknown Area true
                                            {
                                                WeightedClick(LobbyPM.UnknownBtn, 1.0, 1.0, 1, 0, "left");
                                                SevenKnightsCore.Sleep(2000);
                                            }*/
                                            if (CurrentObjective == Objective.CHANGE_PROFILE)
                                            {
                                                if (!alreadystop)
                                                {
                                                    SendTelegram("Bot will stop to change profile, you can choose profile in Telegram and start bot again after changing profile");
                                                    Alert("RestartBot");
                                                    alreadystop = true;
                                                }
                                            }
                                            else if (CurrentObjective == Objective.ADVENTURE)
                                            {
                                                WeightedClick(LobbyPM.AdventureButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (CurrentObjective == Objective.ARENA)
                                            {
                                                WeightedClick(LobbyPM.AdventureButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (CurrentObjective == Objective.SMART_MODE)
                                            {
                                                WeightedClick(LobbyPM.SmartButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (CurrentObjective == Objective.SELL_HEROES || CurrentObjective == Objective.FUSE_HEROES || CurrentObjective == Objective.POWER_UP_HEROES)
                                            {
                                                WeightedClick(LobbyPM.HeroButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (CurrentObjective == Objective.CHECK_SLOT_HERO || CurrentObjective == Objective.CHECK_SLOT_ITEM)
                                            {
                                                NextPossibleObjective();
                                            }
                                            else if (CurrentObjective == Objective.BUY_KEYS)
                                            {
                                                WeightedClick(LobbyPM.ShopButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (CurrentObjective == Objective.COLLECT_INBOX)
                                            {
                                                WeightedClick(LobbyPM.InboxButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (CurrentObjective == Objective.COLLECT_QUESTS)
                                            {
                                                WeightedClick(LobbyPM.QuestButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (CurrentObjective == Objective.SEND_HONORS)
                                            {
                                                WeightedClick(LobbyPM.SocialButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (CurrentObjective == Objective.IDLE)
                                            {
                                                NextPossibleObjective();
                                            }
                                            break;
                                        case SceneType.MAP_SELECT:

                                            if (MapSelectCounter >= 10000)

                                            {

                                                WeightedClick(SharedPM.BackButton, 1.0, 1.0, 1, 0, "left");

                                                SevenKnightsCore.Sleep(500);

                                            }

                                            else if (CurrentObjective == Objective.ADVENTURE)

                                            {

                                                World world = AISettings.AD_World;

                                                int stage = AISettings.AD_Stage;

                                                int boost = 0;

                                                if (AISettings.AD_World == World.Sequencer)

                                                {

                                                    Tuple<World, int, int> worldStageFromSequencer = GetWorldStageFromSequencer();

                                                    if (worldStageFromSequencer == null)

                                                    {

                                                        LogError("Stage sequence is empty");

                                                        NextPossibleObjective();

                                                        break;

                                                    }

                                                    world = worldStageFromSequencer.Item1;

                                                    stage = worldStageFromSequencer.Item2;

                                                    boost = worldStageFromSequencer.Item3;

                                                }
                                                World[] AsgarWorld = { World.MysticWoods, World.SilentMine, World.BlazingDesert, World.DarkGrave, World.DragonRuins, World.FrozenLand, World.Purgatory };
                                                if (AsgarWorld.Contains(world)) //check if selected world is asgar cont
                                                {
                                                    //this.Log("Asgar");

                                                    //on MOONLITE ISLE
                                                    if (MatchMapping(MapSelectPM.AishaBoatLeft, 2) || MatchMapping(MapSelectPM.AishaBoatRight, 2)) //check if not in asgar cont
                                                    {
                                                        WeightedClick(MapSelectPM.BtnBottom3, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        CaptureFrame();

                                                        //then
                                                    }
                                                    //checking selected world continent
                                                    if (world == World.MysticWoods)
                                                    {
                                                        WeightedClick(MapSelectPM.Map1Button, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        CaptureFrame();
                                                    }
                                                    else if (world == World.SilentMine)
                                                    {
                                                        WeightedClick(MapSelectPM.Map2Button, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        CaptureFrame();
                                                    }
                                                    else if (world == World.BlazingDesert)
                                                    {
                                                        WeightedClick(MapSelectPM.Map3Button, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        CaptureFrame();
                                                    }
                                                    else if (world == World.DarkGrave)
                                                    {
                                                        WeightedClick(MapSelectPM.Map4Button, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        CaptureFrame();
                                                    }
                                                    else if (world == World.DragonRuins)
                                                    {
                                                        WeightedClick(MapSelectPM.Map5Button, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        CaptureFrame();
                                                    }
                                                    else if (world == World.FrozenLand)
                                                    {
                                                        WeightedClick(MapSelectPM.Map6Button, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        CaptureFrame();
                                                    }
                                                    else if (world == World.Purgatory)
                                                    {
                                                        WeightedClick(MapSelectPM.Map7Button, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        CaptureFrame();
                                                    }
                                                    CheckSoul(world);
                                                    MapZone = "Asgar";

                                                    SelectStageAsgar(world, stage);
                                                }
                                                else //selected world not asgar cont
                                                {
                                                    //this.Log("MoonliteIsle");

                                                    //on ASGAR
                                                    if (MatchMapping(MapSelectPM.MoonBoatLitLeft, 2) || MatchMapping(MapSelectPM.MoonLitBoatRight, 2)) //check if not in moonlinte cont
                                                    {
                                                        WeightedClick(MapSelectPM.BtnBottom3, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        CaptureFrame();

                                                        //then
                                                    }
                                                    //checking selected world continent
                                                    if (world == World.MoonlitIsle)
                                                    {
                                                        WeightedClick(MapSelectPM.Map8Button, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        CaptureFrame();
                                                        CheckSoul(world);
                                                        MapZone = "Aisha";

                                                        SelectStageAisha(world, stage);
                                                    }
                                                    else if (world == World.WesternEmpire)
                                                    {
                                                        WeightedClick(MapSelectPM.Map9Button, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        CaptureFrame();
                                                        CheckSoul(world);
                                                        MapZone = "Aisha";

                                                        SelectStageAisha(world, stage);
                                                    }
                                                    else if (world == World.EasternEmpire)
                                                    {
                                                        WeightedClick(MapSelectPM.Map10Button, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        CaptureFrame();
                                                        CheckSoul(world);
                                                        MapZone = "Aisha";

                                                        SelectStageAisha(world, stage);
                                                    }
                                                    else if (world == World.DarkSanctuary)
                                                    {
                                                        WeightedClick(MapSelectPM.Map11Button, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        CaptureFrame();

                                                        CheckSoul(world);
                                                        MapZone = "Aisha";

                                                        SelectStageDarkSanctuary(world, stage);
                                                    }
                                                    else if (world == World.ShadowsEye)
                                                    {
                                                        WeightedClick(MapSelectPM.Map12Button, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        CaptureFrame();

                                                        CheckSoul(world);
                                                        MapZone = "ShadowsEye";

                                                        SelectStageShadowsEye(world, stage);
                                                    }
                                                    else if (world == World.HeavenlyStairs)
                                                    {
                                                        WeightedClick(MapSelectPM.Map13Button, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        CaptureFrame();

                                                        CheckSoul(world);
                                                        MapZone = "HeavenlyStairs";

                                                        SelectStageHeavenlyStairs(world, stage);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;

                                        case SceneType.MAP_SELECT_POPUP:
                                            Escape();
                                            break;

                                        case SceneType.FULL_ITEM_POPUP:
                                            if (AISettings.AD_StopOnFullItems)
                                            {
                                                Alert("Items Full");
                                                SendTelegram("Bot has stopped because Your inventory is full");
                                                Escape();
                                            }
                                            if (!flag)
                                            {
                                                SendTelegram("Your inventory is full. Bot will start selling them if enabled.");
                                                flag = true;
                                            }
                                            if (AISettings.RS_SellItems && CooldownSellItems <= 0)
                                            {
                                                if (CurrentObjective != Objective.SELL_ITEMS)
                                                {
                                                    ChangeObjective(Objective.SELL_ITEMS);
                                                }
                                                WeightedClick(SharedPM.Full_SellButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                WeightedClick(SharedPM.Full_NoButton, 1.0, 1.0, 1, 0, "left");
                                                itemfull = false;
                                            }
                                            SevenKnightsCore.Sleep(500);
                                            break;

                                        case SceneType.FULL_HERO_POPUP:
                                            if (AISettings.AD_StopOnFullHeroes)
                                            {
                                                Alert("Heroes Full");
                                                SendTelegram("Bot has stopped Because Your hero cards are full");
                                                Escape();
                                            }
                                            if (!flag2)
                                            {
                                                SendTelegram("Your hero cards are full. Bot will start selling them if enabled.");
                                                flag2 = true;
                                            }
                                            if (AISettings.RS_SellHeroes && CooldownSellHeroes <= 0)
                                            {
                                                if (CurrentObjective != Objective.SELL_HEROES)
                                                {
                                                    ChangeObjective(Objective.SELL_HEROES);
                                                }
                                                WeightedClick(SharedPM.Full_NoButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                WeightedClick(SharedPM.Full_ProceedButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            SevenKnightsCore.Sleep(500);
                                            break;


                                        case SceneType.ADVENTURE_READY:
                                            SevenKnightsCore.Sleep(600);
                                            //CheckMapNumber2(World.BlazingDesert, 4);
                                            
                                            alreadyadvready = true;
                                            World world3 = AISettings.AD_World;
                                            int stage3 = AISettings.AD_Stage;
                                            int boost3 = 0;
                                            if (CurrentObjective == Objective.ADVENTURE)
                                            {
                                                if (AISettings.AD_World == World.Sequencer)
                                                {
                                                    Tuple<World, int, int> worldStageFromSequencer2 = GetWorldStageFromSequencer();
                                                    if (worldStageFromSequencer2 == null)
                                                    {
                                                        LogError("Stage sequence is empty");
                                                        NextPossibleObjective();
                                                        break;
                                                    }
                                                    world3 = worldStageFromSequencer2.Item1;
                                                    stage3 = worldStageFromSequencer2.Item2;
                                                    boost3 = worldStageFromSequencer2.Item3;
                                                }
                                                if (CheckMapNumber2(world3, stage3) || MapCheckCount >= 3)
                                                {
                                                    currentworld = world3;
                                                    currentStage = stage3;
                                                    if (boost3 == 0)
                                                    {
                                                        isboostsequence = false;
                                                    }
                                                    else
                                                    {
                                                        isboostsequence = true;
                                                    }
                                                    WeightedClick(AdventureReadyPM.ReadyButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    MapCheckCount++;
                                                    WeightedClick(AdventureReadyPM.CloseButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                SevenKnightsCore.Sleep(500);
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;

                                        case SceneType.ADVENTURE_START:
                                            SevenKnightsCore.Sleep(600);
                                            if (MatchMapping(AdventureStartPM.Auto_KeyPlusButton, 2))
                                            {
                                                SevenKnightsCore.Sleep(2000);
                                            }
                                            if (CurrentObjective == Objective.ADVENTURE)
                                            {
                                                bool boost = false;
                                                World world2 = AISettings.AD_World;
                                                int stage2 = AISettings.AD_Stage;
                                                int boost2 = 0;
                                                if (AISettings.AD_World == World.Sequencer)
                                                {
                                                    Tuple<World, int, int> worldStageFromSequencer2 = GetWorldStageFromSequencer();
                                                    if (worldStageFromSequencer2 == null)
                                                    {
                                                        LogError("Stage sequence is empty");
                                                        NextPossibleObjective();
                                                        break;
                                                    }
                                                    world2 = worldStageFromSequencer2.Item1;
                                                    stage2 = worldStageFromSequencer2.Item2;
                                                    boost2 = worldStageFromSequencer2.Item3;
                                                    if (boost2 == 0)
                                                    {
                                                        isboostsequence = false;
                                                    }
                                                    else
                                                    {
                                                        isboostsequence = true;
                                                    }
                                                }
                                                if (!(currentworld == world2 && currentStage == stage2))
                                                {
                                                    if (changemap == true)
                                                    {
                                                        changemap = false;
                                                        Escape();
                                                        SevenKnightsCore.Sleep(1500);
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Escape();
                                                        SevenKnightsCore.Sleep(1500);
                                                        break;
                                                    }
                                                    
                                                }
                                                else
                                                {
                                                    if ((currentworld == world2 && currentStage == stage2))
                                                    {
                                                        alreadyadvready = true;
                                                    }
                                                    if (!AISettings.AD_Continuous && alreadyadvready)
                                                    {
                                                        alreadyadvready = false;
                                                        SevenKnightsCore.Sleep(1000);
                                                        SelectTeam(SceneType.ADVENTURE_START, world2);
                                                        if (AISettings.AD_UseFriend)
                                                        {
                                                            if (MatchMapping(AdventureStartPM.UseFriendOff, 2))
                                                            {
                                                                WeightedClick(SharedPM.UseFriendButton, 1.0, 1.0, 1, 0, "left");
                                                                SevenKnightsCore.Sleep(1000);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (MatchMapping(AdventureStartPM.UseFriendOn, 2))
                                                            {
                                                                WeightedClick(SharedPM.UseFriendButton, 1.0, 1.0, 1, 0, "left");
                                                                SevenKnightsCore.Sleep(1000);
                                                            }
                                                        }
                                                        if (AISettings.AD_BootMode && CheckBoost())
                                                        {
                                                            boost = true;
                                                            if (MatchMapping(AdventureStartPM.BoostmodeFull) && MatchMapping(AdventureStartPM.BoostmodeFull2))
                                                            {
                                                                Log("Boost Mode 100/100, bot will disable boost mode", Color.Orange);
                                                                SendTelegram("Boost Mode limit");
                                                                AISettings.AD_BootMode = false;
                                                                if (!isboostalreadylimit && AIProfiles.ST_TelegramWarnBoost)
                                                                {
                                                                    isboostalreadylimit = true;
                                                                    Alert("BoostLimit");
                                                                }
                                                                boost = false;
                                                            }
                                                            else
                                                            {
                                                                CaptureFrame();
                                                                if (MatchMapping(AdventureStartPM.BootmodeOff, 2))
                                                                {
                                                                    Log("Boost Mode Off");
                                                                    if (AISettings.AD_BoostModeSequence && isboostsequence)
                                                                    {
                                                                        WeightedClick(AdventureStartPM.UsedBootModeButton, 1.0, 1.0, 1, 0, "left");
                                                                        SevenKnightsCore.Sleep(2000);
                                                                        boost = true;
                                                                    }
                                                                    else if ((world2 == World.MysticWoods || world2 == World.SilentMine || world2 == World.BlazingDesert || world2 == World.DarkGrave || world2 == World.DragonRuins || world2 == World.FrozenLand || world2 == World.Purgatory) && AISettings.AD_BoostAsgar)
                                                                    {
                                                                        WeightedClick(AdventureStartPM.UsedBootModeButton, 1.0, 1.0, 1, 0, "left");
                                                                        SevenKnightsCore.Sleep(2000);
                                                                        boost = true;
                                                                    }
                                                                    else if (AISettings.AD_BoostAllMap)
                                                                    {
                                                                        WeightedClick(AdventureStartPM.UsedBootModeButton, 1.0, 1.0, 1, 0, "left");
                                                                        SevenKnightsCore.Sleep(2000);
                                                                        boost = true;
                                                                    }
                                                                    else
                                                                    {
                                                                        if (MatchMapping(AdventureStartPM.BootmodeOn, 2))
                                                                        {
                                                                            WeightedClick(AdventureStartPM.UsedBootModeButton, 1.0, 1.0, 1, 0, "left");
                                                                            SevenKnightsCore.Sleep(2000);
                                                                            boost = false;
                                                                        }
                                                                    }
                                                                }
                                                                else if (MatchMapping(AdventureStartPM.BootmodeOn, 2))
                                                                {
                                                                    Log("Boost Mode On");
                                                                    if (AISettings.AD_BoostModeSequence && !isboostsequence)
                                                                    {
                                                                        WeightedClick(AdventureStartPM.UsedBootModeButton, 1.0, 1.0, 1, 0, "left");
                                                                        SevenKnightsCore.Sleep(2000);
                                                                        boost = false;
                                                                    }
                                                                    else if ((world2 > World.Purgatory) && AISettings.AD_BoostAsgar)
                                                                    {
                                                                        WeightedClick(AdventureStartPM.UsedBootModeButton, 1.0, 1.0, 1, 0, "left");
                                                                        SevenKnightsCore.Sleep(2000);
                                                                        boost = false;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (MatchMapping(AdventureStartPM.BootmodeOn, 2))
                                                            {
                                                                WeightedClick(AdventureStartPM.UsedBootModeButton, 1.0, 1.0, 1, 0, "left");
                                                                SevenKnightsCore.Sleep(2000);
                                                                boost = false;
                                                            }
                                                        }
                                                        if (MatchMapping(AdventureStartPM.AutoRepeatOff, 2) && (!itemfull || !herofull))
                                                        {
                                                            WeightedClick(AdventureStartPM.AutoRepeatButton, 1.0, 1.0, 1, 0, "left");
                                                            SevenKnightsCore.Sleep(3400);
                                                        }
                                                        if (MatchMapping(AdventureStartPM.AutoRepeatOn, 2) && (itemfull || herofull))
                                                        {
                                                            WeightedClick(AdventureStartPM.AutoRepeatButton, 1.0, 1.0, 1, 0, "left");
                                                            SevenKnightsCore.Sleep(3400);
                                                        }
                                                        this.world3 = world2;
                                                        Countentrylv30(boost);
                                                        SevenKnightsCore.Sleep(1000);
                                                        WeightedClick(SharedPM.PrepareFight_StartButton, 1.0, 1.0, 1, 0, "left");
                                                        SevenKnightsCore.Sleep(1000);
                                                    }
                                                    else
                                                    {
                                                        this.Log("Back to Map Select");
                                                        Escape();
                                                        SevenKnightsCore.Sleep(300);
                                                    }
                                                }
                                            }
                                            else if (CurrentObjective == Objective.CHECK_SLOT_HERO)
                                            {
                                                WeightedClick(SharedPM.PrepareFight_ManageButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;

                                        case SceneType.ADVENTURE_START_AUTO:
                                            break;

                                        case SceneType.NO_MORE_RUBY_POPUP:
                                            if (AISettings.RS_EnableCINoRuby && !alreadyCollectInboxBuyKeys)
                                            {
                                                alreadyCollectInboxBuyKeys = true;
                                                this.Log("No more ruby to buy keys, Bot will collect inbox");
                                                SendTelegram("No more ruby to buy keys, Bot will collect inbox");
                                                this.ChangeObjective(Objective.COLLECT_INBOX);
                                            }
                                            else
                                            {
                                                this.Log("No more ruby to buy keys, Bot will change mode");
                                                SendTelegram("No more ruby to buy keys, Bot will change mode");
                                                this.NextPossibleObjective();
                                            }
                                            WeightedClick(NoMoreRubyPopupPM.TapArea, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.NO_MORE_RUBY_OFFER:
                                            WeightedClick(NoMoreRubyOfferPM.NoBtn, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.NO_MORE_HERO_POPUP:
                                            
                                            if (AISettings.PU_enableActive3)
                                            {
                                                Log("No More Hero to Level Up, bot will powering up hero and fuse");
                                                SendTelegram("No More Hero to Level Up, bot will powering up hero and fuse");
                                                ChangeObjective(Objective.POWER_UP_HEROES);
                                                Escape();
                                            }
                                            else if (AIProfiles.AD_NoHeroUp)
                                            {
                                                Alert("No More Hero 30");
                                                SendTelegram("Bot has stopped Because No More Heroes to be replaced with");
                                                Escape();
                                            }
                                            else
                                            {
                                                SendTelegram("No More Heroes to be replaced, bot will disable adventure");
                                                DisableMode(Objective.ADVENTURE);
                                                Escape();
                                                NextPossibleObjective();
                                            }
                                            break;

                                        case SceneType.ADVENTURE_FIGHT:
                                            if (alreadyCollectInboxBuyKeys)
                                            {
                                                alreadyCollectInboxBuyKeys = false;
                                            }
                                            if (AISettings.AD_HottimeEnable && Hottimeactive && MatchMapping(AdventureFightPM.HottimeNoActive1, 2) && MatchMapping(AdventureFightPM.HottimeNoActive2, 2))
                                            {
                                                Hottimeactive = false;
                                                SendTelegram("Hottime End!");
                                                if (AISettings.AD_EnableProfile2)
                                                {
                                                    ChangeMode(Objective.CHANGE_PROFILE);
                                                }
                                            }
                                            PerformAdventureFight(this.world3);
                                            break;

                                        case SceneType.ADVENTURE_END:
                                            if (CurrentObjective == Objective.CHECK_SLOT_HERO)
                                            {
                                                WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            if (!IsAlreadyAdvEnd)
                                            {
                                                EndAutoRepeat();
                                            }
                                            else
                                            {
                                                SevenKnightsCore.Sleep(750);
                                            }
                                            break;

                                        case SceneType.ADVENTURE_LOST:
                                            AdventureAfterFight();
                                            Log("Your team lost the battle [Adventure]", COLOR_DEATH);
                                            SendTelegram("[Adventure] Your team has lost a battle. Continuing AI.");
                                            WeightedClick(AdventureLostPM.AdventureButton, 1.0, 1.0, 1, 0, "left");
                                            LongSleep(2000, 1000);
                                            break;

                                        case SceneType.VICTORY:
                                            SevenKnightsCore.Sleep(250);
                                            IsAlreadyAdvEnd = false;
                                            CurrentWave = 0;
                                            WeightedClick(VictoryPM.TapToSkipArea, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.AUTO_REPEAT_INFO:
                                            if (AISettings.AD_CheckSlot)
                                            {
                                                checkslothero = true;
                                                checkslotitem = true;
                                                ChangeObjective(Objective.CHECK_SLOT_HERO);
                                            }
                                            CaptureFrame();
                                            ParseGoldAutoRepeat();
                                            Sleep(500);
                                            ParseItemAutoRepeat();
                                            Sleep(500);
                                            ParseHeroAutoRepeat();
                                            Sleep(500);
                                            ParseSoulAutoRepeat();
                                            Sleep(500);
                                            ReportCount(Objective.ADVENTURE);
                                            WeightedClick(AutoRepeatInfoPM.CloseBtn, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.AUTO_REPEAT_STOP:
                                            SevenKnightsCore.Sleep(500);
                                            WeightedClick(AutoRepeatStopPM.YesButton, 1.0, 1.0, 1, 0, "left");
                                            CurrentWave = 0;
                                            break;

                                        case SceneType.AUTO_REPEAT_POPUP:
                                            SevenKnightsCore.Sleep(500);
                                            WeightedClick(AutoRepeatPopupPM.OkBtn, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.ADVENTURE_LOOT:
                                            if (!IsAlreadyAdvLoot)
                                            {
                                                AdventureAfterFight();
                                                SevenKnightsCore.Sleep(500);
                                                if (CurrentObjective == Objective.ADVENTURE)
                                                {
                                                    if (AISettings.AD_Continuous && AISettings.AD_World != World.Sequencer)
                                                    {
                                                        WeightedClick(AdventureLootPM.NextZoneButton, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else if (AISettings.AD_World == World.None)
                                                    {
                                                        WeightedClick(AdventureLootPM.QuickStartButton, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else
                                                    {
                                                        WeightedClick(AdventureLootPM.AgainButton, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                }
                                                else if (CurrentObjective == Objective.CHECK_SLOT_HERO)
                                                {
                                                    WeightedClick(AdventureLootPM.AgainButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    WeightedClick(SharedPM.Loot_LobbyButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                SevenKnightsCore.Sleep(3000);
                                            }
                                            else
                                            {
                                                SevenKnightsCore.Sleep(750);
                                            }
                                            break;
                                        case SceneType.ADVENTURE_LOOT_AUTO:
                                            if (!IsAlreadyAdvLoot)
                                            {
                                                AdventureAfterFight();
                                                IsAlreadyAdvLootAuto = true;
                                                SevenKnightsCore.Sleep(3500);
                                            }
                                            else
                                            {
                                                SevenKnightsCore.Sleep(750);
                                            }
                                            break;
                                        case SceneType.OUT_OF_KEYS_OFFER:
                                            if (!flag3)
                                            {
                                                SendTelegram("[Adventure] Bot will buy more keys or play other modes while waiting.");
                                                flag3 = true;
                                            }
                                            if (CurrentObjective != Objective.BUY_KEYS && AISettings.RS_BuyKeyHonors && KeysBoughtHonors < AISettings.RS_BuyKeyHonorsAmount)
                                            {
                                                ChangeObjective(Objective.BUY_KEYS);
                                                WeightedClick(OutOfKeysOfferPM.BuyButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                Escape();
                                                NextPossibleObjective();
                                            }
                                            break;

                                        case SceneType.OUT_OF_KEYS_POPUP:
                                            if (!flag3)
                                            {
                                                SendTelegram("[Adventure] Bot will buy more keys or play other modes while waiting.");
                                                flag3 = true;
                                            }
                                            if (CurrentObjective != Objective.BUY_KEYS && AISettings.RS_BuyKeyHonors && KeysBoughtHonors < AISettings.RS_BuyKeyHonorsAmount)
                                            {
                                                ChangeObjective(Objective.BUY_KEYS);
                                                Escape();
                                            }
                                            else
                                            {
                                                Escape();
                                                NextPossibleObjective();
                                            }
                                            break;

                                        case SceneType.BATTLE_MODES:
                                            if (AISettings.AD_HottimeEnable && Hottimeloop == true)
                                            {
                                                WeightedClick(BattleModesPM.HottimeButton, 1.0, 1.0, 1, 0, "left");
                                                break;
                                            }
                                            if (CurrentObjective == Objective.ARENA)
                                            {
                                                WeightedClick(BattleModesPM.ArenaButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (CurrentObjective == Objective.ADVENTURE)
                                            {
                                                WeightedClick(BattleModesPM.AdventureButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;

                                        case SceneType.ARENA_READY:
                                            UpdateArenaKeys();
                                            //this.UpdateRuby(scene.SceneType);
                                            //this.UpdateHonor(scene.SceneType);
                                            CaptureFrame();
                                            CheckArenaScoreReady();
                                            if (CurrentObjective == Objective.ARENA)
                                            {
                                                if (ArenaKeys > 0 || ArenaUseRuby())
                                                {
                                                    WeightedClick(ArenaReadyPM.ReadyButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    NextPossibleObjective();
                                                }
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;

                                        case SceneType.ARENA_START:
                                            if (CurrentObjective == Objective.ARENA)
                                            {
                                                if (this.MatchMapping(ArenaStartPM.ArenaLoopOn, 2))
                                                {
                                                    WeightedClick(ArenaStartPM.ArenaLoop, 1.0, 1.0, 1, 0, "left");
                                                }
                                                bool flag5 = ArenaUseRuby();
                                                if (ArenaKeys > 0 || flag5)
                                                {
                                                    WeightedClick(ArenaStartPM.StartButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    NextPossibleObjective();
                                                }
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;

                                        case SceneType.ARENA_FIGHT:
                                            //nothing
                                            break;

                                        case SceneType.ARENA_END:
                                            CaptureFrame();
                                            CheckArenaScore();
                                            if (MatchMapping(ArenaEndPM.QuickStartLoseButton, 2) && MatchMapping(ArenaEndPM.ArenaLoseButton, 2) && MatchMapping(ArenaEndPM.GetStrongerButton, 2))
                                            {
                                                Log("Arena Lose", COLOR_ARENA);
                                                ArenaAfterFight(false);
                                                if (CurrentObjective == Objective.ARENA)
                                                {
                                                    WeightedClick(ArenaEndPM.QuickStartLoseButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    WeightedClick(ArenaEndPM.LobbyLoseButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                            }
                                            else
                                            {
                                                Log("Arena Victory", COLOR_ARENA);
                                                ArenaAfterFight(true);
                                                if (CurrentObjective == Objective.ARENA)
                                                {
                                                    WeightedClick(ArenaEndPM.QuickStartButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    WeightedClick(ArenaEndPM.LobbyButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                            }
                                            LongSleep(2000, 1000);
                                            break;

                                        case SceneType.ARENA_SEASON_END:
                                            SevenKnightsCore.Sleep(500);
                                            NextPossibleObjective();
                                            Escape();
                                            break;

                                        case SceneType.ARENA_FULL_HONOR_POPUP:
                                            if (AISettings.RS_BuyKeyHonors)
                                            {
                                                if (CurrentObjective != Objective.BUY_KEYS)
                                                {
                                                    ChangeObjective(Objective.BUY_KEYS);
                                                    Escape();
                                                }
                                                Escape();
                                            }
                                            else
                                            {
                                                WeightedClick(ArenaFullHonorPopupPM.YesButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            break;

                                        case SceneType.OUT_OF_SWORDS_POPUP:
                                            if (ArenaUseRuby())
                                            {
                                                Log(string.Format("Entering arena using Ruby ({0})", ArenaRubiesCount + 1), COLOR_ARENA);
                                                WeightedClick(OutOfSwordsPopupPM.EnterButton, 1.0, 1.0, 1, 0, "left");
                                                SevenKnightsCore.Sleep(1000);
                                                ArenaRubiesCount++;
                                            }
                                            else
                                            {
                                                Escape();
                                                NextPossibleObjective();
                                            }
                                            SevenKnightsCore.Sleep(1000);
                                            break;

                                        case SceneType.LEVEL_UP_DIALOG:
                                            Log("Player Level Up", COLOR_LEVEL_UP);
                                            WeightedClick(LevelUpDialogPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                            SevenKnightsCore.Sleep(300);
                                            break;

                                        case SceneType.LEADER_ICON:
                                            Log("New Leader Icon Unlocked", COLOR_LEVEL_UP);
                                            WeightedClick(LeaderIconDialogPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                            SevenKnightsCore.Sleep(300);
                                            break;

                                        case SceneType.LEVEL_30_DIALOG:
                                        case SceneType.LEVEL_30_MAX_DIALOG:
                                            Log("Hero Level 40", COLOR_LEVEL_30);
                                            WeightedClick(Level30MaxDialogPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                            SevenKnightsCore.Sleep(300);
                                            break;
                                        case SceneType.POWER_UP_LOBBY:
                                            SevenKnightsCore.Sleep(500);
                                            Escape();
                                            break;
                                        case SceneType.POWER_UP_FAILED_POPUP:
                                            SevenKnightsCore.Sleep(500);
                                            Escape();
                                            break;
                                        case SceneType.POWER_UP_CONFIRM:
                                            SevenKnightsCore.Sleep(500);
                                            WeightedClick(PowerUpConfirmPM.OKbtn, 1.0, 1.0, 1, 0, "left");
                                            break;
                                        case SceneType.POWER_UP_PROCESS:
                                            break;
                                        case SceneType.POWER_UP_SUCCESS:
                                            SevenKnightsCore.Sleep(500);
                                            //Escape();
                                            break;
                                        case SceneType.FUSE_LOBBY:
                                            SevenKnightsCore.Sleep(500);
                                            Escape();
                                            break;
                                        case SceneType.FUSE_CONFIRM:
                                            SevenKnightsCore.Sleep(500);
                                            //Escape();
                                            break;
                                        case SceneType.FUSE_SUCCESS:
                                            SevenKnightsCore.Sleep(500);
                                            Escape();
                                            break;
                                        case SceneType.HEROES:
                                            SevenKnightsCore.Sleep(1000);
                                            CaptureFrame();
                                            if (MatchMapping(HeroesPM.HeroCard1Red1, 2) || MatchMapping(HeroesPM.HeroCard1Red2, 2))
                                            {
                                                Escape();
                                            }
                                            else
                                            {
                                                if (CurrentObjective == Objective.POWER_UP_HEROES)
                                                {
                                                    PowerUpHeroes();
                                                }
                                                else if (CurrentObjective == Objective.FUSE_HEROES)
                                                {
                                                    FuseHeroes();
                                                }
                                                else if (CurrentObjective == Objective.CHECK_SLOT_HERO)
                                                {
                                                    if (checkslothero)
                                                    {
                                                        UpdateHeroCount();
                                                        checkslothero = false;
                                                    }
                                                    else if (checkslotitem)
                                                    {
                                                        WeightedClick(HeroesPM.HeroCard1, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else
                                                    {
                                                        Escape();
                                                    }
                                                    ReportCheckSlot(Objective.CHECK_SLOT_HERO);
                                                    SevenKnightsCore.Sleep(1500);
                                                }
                                                else if (CurrentObjective == Objective.CHECK_SLOT_ITEM)
                                                {
                                                    WeightedClick(HeroesPM.HeroCard1, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    Escape();
                                                }
                                            }
                                            break;

                                        case SceneType.ITEMS:
                                            SevenKnightsCore.Sleep(500);
                                            if (CurrentObjective == Objective.CHECK_SLOT_ITEM)
                                            {
                                                if (checkslotitem)
                                                {
                                                    UpdateItemCount();
                                                }
                                                else
                                                {
                                                    Escape();
                                                }
                                                ReportCheckSlot(Objective.CHECK_SLOT_ITEM);
                                                SevenKnightsCore.Sleep(1500);
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;
                                        case SceneType.HEROES_SAME_TEAM_POPUP:
                                            Escape();
                                            break;

                                        case SceneType.HERO_JOIN:
                                            SevenKnightsCore.Sleep(500);
                                            Log(IsHeroLevel30().ToString());
                                            if (CurrentObjective == Objective.CHECK_SLOT_ITEM && checkslotitem == true && PreviousObjective == Objective.CHECK_SLOT_HERO)
                                            {
                                                WeightedClick(HeroJoinPM.ItemButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (CurrentObjective == Objective.FUSE_HEROES)
                                            {
                                                Escape();
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;

                                        case SceneType.HERO_REMOVE:
                                            Log(IsHeroLevel30().ToString());
                                            if (CurrentObjective == Objective.CHECK_SLOT_ITEM && checkslotitem == true && PreviousObjective == Objective.CHECK_SLOT_HERO)
                                            {
                                                WeightedClick(HeroJoinPM.ItemButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (CurrentObjective == Objective.FUSE_HEROES)
                                            {
                                                Escape();
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;
                                        case SceneType.SELL_HERO_CONFIRM_POPUP:
                                            Escape();
                                            break;

                                        case SceneType.SELL_ITEM_POPUP:
                                            if (AISettings.RS_SellItems)
                                            {
                                                if (CurrentObjective != Objective.SELL_ITEMS)
                                                {
                                                    ChangeObjective(Objective.SELL_ITEMS);
                                                }
                                                SellItems();
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;

                                        case SceneType.SELL_ITEM_LOBBY:
                                            if (CurrentObjective == Objective.SELL_ITEMS)
                                            {
                                                SellItems();
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;

                                        case SceneType.SELL_ITEM_SUCCESS_POPUP:
                                            Escape();
                                            break;
                                        case SceneType.SELL_HEROES_SUCCESS_POPUP:
                                            Escape();
                                            break;

                                        case SceneType.SELL_ITEM_CONFIRM_POPUP:
                                            Escape();
                                            break;

                                        case SceneType.LOOT_HERO:
                                            Escape();
                                            break;

                                        case SceneType.LOOT_ITEM:
                                            Escape();
                                            break;

                                        case SceneType.SHOP_LOBBY:
                                            if (CurrentObjective == Objective.BUY_KEYS)
                                            {
                                                WeightedClick(ShopPM.CommonShop, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;

                                        case SceneType.SHOP:
                                            if (CurrentObjective == Objective.BUY_KEYS)
                                            {
                                                BuyKeys();
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;

                                        case SceneType.SMART_SELECT:
                                            if (CurrentObjective == Objective.SMART_MODE)
                                            {
                                                WeightedClick(SmartSelectPM.CelestialTowerButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;

                                        case SceneType.SMART_LOOT_COLLECT_LOBBY:
                                            if (CurrentObjective == Objective.SMART_MODE)
                                            {
                                                Escape();
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;

                                        case SceneType.SMART_LOBBY:
                                            if (CurrentObjective == Objective.SMART_MODE)
                                            {
                                                HandleSmartMode();
                                            }
                                            else
                                            {
                                                Escape();
                                            }
                                            break;
                                        case SceneType.SHOP_BUY_POPUP:
                                            Escape();
                                            break;

                                        case SceneType.SHOP_BUY_FAILED_POPUP:
                                            Escape();
                                            break;

                                        case SceneType.SHOP_PURCHASE_COMPLETE_POPUP:
                                            Escape();
                                            break;

                                        case SceneType.INBOX:
											if (CurrentObjective == Objective.COLLECT_INBOX)
											{
												CollectInbox();
											}
											else
											{
												Escape();
											}
                                            break;

                                        case SceneType.INBOX_REWARDS_POPUP:
                                            Escape();
                                            break;

                                        case SceneType.INBOX_COLLECT_FAILED_POPUP:
                                            Escape();
                                            break;

                                        case SceneType.INBOX_COLLECT_FAILED_POPUP_2:
                                            Escape();
                                            break;

                                        case SceneType.EVENT_PACKAGE_POPUP:
                                            WeightedClick(Popup3PM.EventPackCloseBtn, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.ONE_DOLLAR_SHOP_POPUP:
                                            WeightedClick(Popup3PM.OneDollarCloseBtn, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.ARENA_WEEK_REWARD:
                                            Escape();
                                            break;

                                        case SceneType.DAILY_QUEST_COMPLETE:
                                            WeightedClick(QuestRewardsPopupPM.OKButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.HOTTIME_POPUP:
                                            SevenKnightsCore.Sleep(300);
                                            CaptureFrame();
                                            if (MatchMapping(StatusBoardPM.ActiveButtonColor, 2) && MatchMapping(StatusBoardPM.ActiveButtonColor2, 2))
                                            {
                                                WeightedClick(StatusBoardPM.ActiveHottimeButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                DoneHottime();
                                            }
                                            break;

                                        case SceneType.HOTTIME_CONFIRM_POPUP:
                                            if (MatchMapping(StatusBoardPM.ConfirmOKtick, 2) && MatchMapping(StatusBoardPM.NoRedCloss, 2) && MatchMapping(StatusBoardPM.ActiveBG, 2))
                                            {
                                                WeightedClick(StatusBoardPM.OKButton, 1.0, 1.0, 1, 0, "left");
                                                Log("Hottime Active", Color.Brown);
                                                DoneHottime();
                                            }
                                            break;

                                        case SceneType.SELL_HERO_FINISH:
                                            WeightedClick(SellHeroConfirmPopupPM.SoldOKButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.RANK_UP:
                                            WeightedClick(ArenaEndPM.RankUpTap, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.SELL_HERO_LOBBY:
                                            if (CurrentObjective == Objective.SELL_HEROES)
                                            {
                                                SellHeroes();
                                            }

                                            else
                                            {
                                                Escape();
                                            }
                                            break;

                                        case SceneType.HELPED_FRIEND:
                                            Escape();
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                Log("Main Frame error?");
                            }
                            if (!IsConnectedToInternet())
                            {
                                internetdc += 1;
                            }
                            else
                            {
                                internetdc = 0;
                            }
                            if (internetdc >= 10)
                            {
                                AIProfiles.TMP_WaitingForInternet = true;
                                Log("Waiting for Internet to reconnect");
                                BlueStacks.TerminateGame();
                            }
                        }
                        else if (AIProfiles.TMP_WaitingForInternet && IsConnectedToInternet())
                        {
                            Log("Internet is connected, Game Resuming");
                            AIProfiles.TMP_WaitingForInternet = false;
                            BlueStacks.LaunchGame();
                        }
                        else if (AIProfiles.TMP_WaitingForKeys)
                        {
                            Random rnd = new Random();
#if DEBUG
							if ((this.AISettings.AD_Enable && this.AdventureKeys >= 1 && rnd.Next(1, (int)this.AdventureKeyTime.TotalMinutes) == 1) ||
								(this.AISettings.AR_Enable && this.ArenaKeys >= 1 && rnd.Next(1, (int)this.ArenaKeyTime.TotalMinutes) == 1))
#else
                            if ((AISettings.AD_Enable && AdventureKeys >= 10 && rnd.Next(1, (int)AdventureKeyTime.TotalSeconds) == 1) ||
                                (AISettings.AR_Enable && ArenaKeys >= 4 && rnd.Next(1, (int)ArenaKeyTime.TotalSeconds) == 1))
#endif
                            {
                                int resumeIn = rnd.Next(1, 60);
                                Log("Resuming in " + resumeIn + " seconds");
                                Sleep(resumeIn * 1000);
                                BlueStacks.LaunchGame();
                                AIProfiles.TMP_WaitingForKeys = false;
                                Log("Keys sufficiently Replenished. Resuming");
                            }
                        }
                        if (!AIProfiles.TMP_WaitingForKeys &&
                            AISettings.GB_WaitForKeys &&
                            (!AISettings.AD_Enable || AdventureKeys == 0) &&
                            (!AISettings.AR_Enable || ArenaKeys == 0))
                        {
                            AIProfiles.TMP_WaitingForKeys = true;
                            Log("Waiting for keys to replenish");
                            BlueStacks.TerminateGame();
                        }
                        MousePos();
                    }
                    catch (Exception ex)
                    {
                        Log(ex.Message.ToString());

                        LogError(ex.Message);
                        LogError(ex.ToString());
                    }
                }
                OneSecTimer.Enabled = false;
                return;
            }
            else
            {
                errorMessage = "Seven Knights not installed in LD Player";
                LogError(errorMessage);
                SynchronizationContext.Send(delegate (object callback)
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }, null);
            }
        }

        //This Function accepts a PixelMapping and send through to MatchPixel.
        private bool MatchMapping(PixelMapping mapping, int tolerance = 2, bool log = false)
        {
            // If if either log paramater or the log property of the mapping it will send true.
            return MatchPixel(mapping.X, mapping.Y, mapping.Color, tolerance, log || mapping.Log);
        }

        //This accepts X and Y coords and expected colour as an Argb integer.
        //The Tolerance is how much of a difference between each colour there in the actual pixel and the expected.
        private bool MatchPixel(int x, int y, int color, int tolerance = 2, bool log = false)
        {
            //Grab the Pixel.
            int currentPixel = GetPixel(x, y);
            //Log to the Log if it's true current pixel if log is true
            if (log)
            {
                Log("X = " + x.ToString() + ", Y = " + y.ToString() + ", Color = " + currentPixel.ToString() + ",");
            }
            //Generate Color objects for each the Target Colour and the Actual Colour.
            Color currentColour = Color.FromArgb(currentPixel);
            Color targetColour = Color.FromArgb(color);
            //this is where we calculate the varience to compare against the tolerance.
            int variance = Math.Max(currentColour.R, targetColour.R) - Math.Min(currentColour.R, targetColour.R) + (Math.Max(currentColour.G, targetColour.G) - Math.Min(currentColour.G, targetColour.G)) + (Math.Max(currentColour.B, targetColour.B) - Math.Min(currentColour.B, targetColour.B));
            //Check the variance vs tolerance and returns the result.
            return variance <= tolerance;
        }

        private void MousePos()
        {
            if (AIProfiles.TMP_LogPixel && AIProfiles.TMP_Paused)
            {
                Sleep(500);
                Point mousePos = BlueStacks.GetMousePos();
                mousePos.X = mousePos.X - BlueStacks.OFFSET_X;
                mousePos.Y = mousePos.Y - BlueStacks.OFFSET_Y;

                if (AIProfiles.TMP_LogPixel)
                {
                    if (AIProfiles.TMP_Paused)
                    {
                        CaptureFrame();
                    }

                    int colour = BlueStacks.GetPixel(mousePos);
                    if (colour != -1)
                    {
                        string message = "X = " + (mousePos.X + ", Y = " + mousePos.Y + ", Color = " + colour);
                        Log(message);
                    }
                    AIProfiles.TMP_LogPixel = false;
                }
                if (AIProfiles.TMP_Paused)
                {
                    ProgressArgs cursorUpdate = new ProgressArgs(ProgressType.CURSORPOS, mousePos);
                    Worker.ReportProgress(0, cursorUpdate);
                    Sleep(1000);
                }
            }
        }

        private void NextPossibleObjective()
        {
            bool aD_Enable = AISettings.AD_Enable;
            bool aR_Enable = AISettings.AR_Enable;
            bool sM_Enable = AISettings.SM_Enable;
            switch (CurrentObjective)
            {
                case Objective.IDLE:
                    if (aD_Enable)
                    {
                        IsAdventureLimit = false;
                        ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    if (aR_Enable)
                    {
                        ChangeObjective(Objective.ARENA);
                        return;
                    }
                    if (sM_Enable)
                    {
                        ChangeObjective(Objective.SMART_MODE);
                        return;
                    }
                    break;

                case Objective.ADVENTURE:
                    if (sM_Enable)
                    {
                        ChangeObjective(Objective.SMART_MODE);
                        return;
                    }
                    if (aR_Enable)
                    {
                        ChangeObjective(Objective.ARENA);
                        return;
                    }
                    ChangeObjective(Objective.IDLE);
                    return;

                case Objective.ARENA:
                    if (aD_Enable)
                    {
                        IsAdventureLimit = false;
                        ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    if (sM_Enable)
                    {
                        ChangeObjective(Objective.SMART_MODE);
                        return;
                    }
                    ChangeObjective(Objective.IDLE);
                    return;

                case Objective.SMART_MODE:
                    if (aR_Enable)
                    {
                        ChangeObjective(Objective.ARENA);
                        return;
                    }
                    if (aD_Enable)
                    {
                        IsAdventureLimit = false;
                        ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    ChangeObjective(Objective.IDLE);
                    return;

                case Objective.CHECK_SLOT_ITEM:
                    if (aD_Enable && (!IsAdventureLimit || AdventureLimitCount < AISettings.AD_Limit))
                    {
                        ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    if (sM_Enable)
                    {
                        ChangeObjective(Objective.SMART_MODE);
                        return;
                    }
                    if (aR_Enable)
                    {
                        ChangeObjective(Objective.ARENA);
                        return;
                    }
                    ChangeObjective(Objective.IDLE);
                    return;
                case Objective.CHECK_SLOT_HERO:
                    if (aD_Enable && (!IsAdventureLimit || AdventureLimitCount < AISettings.AD_Limit))
                    {
                        ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    if (sM_Enable)
                    {
                        ChangeObjective(Objective.SMART_MODE);
                        return;
                    }
                    if (aR_Enable)
                    {
                        ChangeObjective(Objective.ARENA);
                        return;
                    }
                    ChangeObjective(Objective.IDLE);
                    return;
                case Objective.POWER_UP_HEROES:
                    if (aD_Enable && !IsAdventureLimit)
                    {
                        ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    if (sM_Enable)
                    {
                        ChangeObjective(Objective.SMART_MODE);
                        return;
                    }
                    if (aR_Enable)
                    {
                        ChangeObjective(Objective.ARENA);
                        return;
                    }
                    ChangeObjective(Objective.IDLE);
                    return;
                case Objective.FUSE_HEROES:
                    if (aD_Enable && !IsAdventureLimit)
                    {
                        ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    if (sM_Enable)
                    {
                        ChangeObjective(Objective.SMART_MODE);
                        return;
                    }
                    if (aR_Enable)
                    {
                        ChangeObjective(Objective.ARENA);
                        return;
                    }
                    ChangeObjective(Objective.IDLE);
                    return;
                case Objective.SELL_HEROES:
                case Objective.SELL_ITEMS:
                    if (PreviousObjective != CurrentObjective)
                    {
                        ChangeObjective(PreviousObjective);
                        return;
                    }
                    ChangeObjective(Objective.IDLE);
                    break;

                case Objective.BUY_KEYS:
                case Objective.COLLECT_INBOX:
                    if (aD_Enable && !IsAdventureLimit)
                    {
                        ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    if (sM_Enable)
                    {
                        ChangeObjective(Objective.SMART_MODE);
                        return;
                    }
                    if (aR_Enable)
                    {
                        ChangeObjective(Objective.ARENA);
                        return;
                    }
                    ChangeObjective(Objective.IDLE);
                    break;
                case Objective.COLLECT_QUESTS:
                case Objective.SEND_HONORS:
                    if (PreviousObjective == Objective.IDLE || PreviousObjective == Objective.ADVENTURE || PreviousObjective == Objective.ARENA)
                    {
                        ChangeObjective(PreviousObjective);
                        return;
                    }
                    ChangeObjective(Objective.IDLE);
                    return;

                default:
                    return;
            }
        }

        private void OnOneSecEvent(object source, ElapsedEventArgs e)
        {
            if (AIProfiles.ST_EnableHotTimeProfile && ((HotTimeHelper.IsNowHotTime() && !AIProfiles.TMP_UsingHotTimeProfile) || (!HotTimeHelper.IsNowHotTime() && AIProfiles.TMP_UsingHotTimeProfile)))
            {
                AIProfiles.ToggleHotTimeProfile();
                MainForm.Instance.InvokeReloadTabs(true);
            }
            if (AIProfiles.ST_EnableAutoProfile && MaxHeroUpCount)
            {
                MaxHeroUpCount = false;
                AIProfiles.ToggleHotTimeProfile();
                MainForm.Instance.InvokeReloadTabs(true);
            }
            if (AIProfiles.AD_NoHeroUp && nomorehero30)
            {
                nomorehero30 = false;
                Alert("No More Hero 30");
            }
            if (AIProfiles.ST_EnableAutoShutdown && MaxHeroUpCount)
            {
                Log("Shutdown Now!");
                Process.Start("shutdown", "/s /f /t 0");
                SendTelegram("Max Hero lvl up 100/100, PC Will shutdown");
            }
            if (AIProfiles.AD_Pause100 && MaxHeroUpCount)
            {
                MaxHeroUpCount = false;
                SendTelegram("Max Hero lvl up 100/100, Bot Paused");
                Alert("Max Level Up");
            }

            TimeSpan ts = TimeSpan.FromSeconds(1.0);
            if (AdventureKeyTime != TimeSpan.MaxValue)
            {
                AdventureKeyTime = AdventureKeyTime.Subtract(ts);
            }
            if (TowerKeyTime != TimeSpan.MaxValue)
            {
                TowerKeyTime = TowerKeyTime.Subtract(ts);
            }
            if (ArenaKeyTime != TimeSpan.MaxValue)
            {
                ArenaKeyTime = ArenaKeyTime.Subtract(ts);
            }
            if (AdventureKeyTime == TimeSpan.Zero)
            {
                AdventureKeyTime = new TimeSpan(0, 10, 0);
                if (AdventureKeys < 11)
                {
                    AdventureKeys++;
                }
                else
                {
                    AdventureKeyTime = TimeSpan.MaxValue;
                }
            }
            if (TowerKeyTime == TimeSpan.Zero)
            {
                TowerKeyTime = new TimeSpan(0, 30, 0);
                if (TowerKeys < 5)
                {
                    TowerKeys++;
                }
                else
                {
                    TowerKeyTime = TimeSpan.MaxValue;
                }
            }
            if (ArenaKeyTime == TimeSpan.Zero)
            {
                ArenaKeyTime = new TimeSpan(0, 30, 0);
                if (ArenaKeys < 5)
                {
                    ArenaKeys++;
                }
                else
                {
                    ArenaKeyTime = TimeSpan.MaxValue;
                }
            }
            ReportAllKeys();
        }

        private int ParseAdventureKeys(Rectangle rect)
        {
            int num = -1;
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, LobbyPM.R_KeyNormalBase).ScaleByPercent(200))
            {
#if DEBUG
				bitmap.Save("keysOnTop.png");
#endif
                bitmap.Save("keysOnTop.png");
                using (Page page = Tesseractor.Engine.Process(bitmap, PageSegMode.Auto))
                {
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                        .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                        .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                        .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3").Replace("d", "0").Replace("”", "").Replace("3<", "x").Trim();
                    //this.Log("Key Ori Text: " + page.GetText().ToLower().Trim());
                    //this.Log("Key Text: " + text);
                    string test1 = Regex.Replace(text, @"\D", "");
                    //this.Log("Key Regex: " + test1);
                    if (page.GetText().ToLower().Trim().Contains(':') || page.GetText().ToLower().Trim().Contains(' '))
                    {
                        string[] test2 = page.GetText().ToLower().Trim().Split(':');
                        string test3 = Regex.Replace(test2[0], @"\D", "");
                        string test4 = test3.Substring(0, 2);
                        //this.Log("After manipulate: " + test4);
                        //string test3 = test2[0].Replace("x", "");
                        int.TryParse(test4, out num);

                    }
                    else
                    {
                        int.TryParse(test1, out num);
                    }
                }
            }
            return num;
        }

        private int ParseGold(Rectangle rect)
        {
            int result = -1;
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, rect))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = ReplaceNumericResource(page.GetText().Trim());
                    string test1 = Regex.Replace(text, @"\D", "");
                    if (test1.Length >= 1)
                    {
                        int.TryParse(test1, out result);
                    }
                }
            }
            return result;
        }

        private bool ParsePowerUpCount()
        {
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, PowerUpLobbyPM.PowerUpCoun))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(". u", "0").Replace(".", "").Replace(" ", "").Replace("s", "5")
    .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
    .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
    .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3");
                    string text3 = Regex.Replace(text, @"\D", "");
                    Utility.FilterAscii(text3);
                    //this.Log("Before: " + page.GetText());
                    //this.Log("After: " + text);
                    //this.Log("After3: " + text3[0]);
                    int result = -1;
                    int.TryParse(text3[0].ToString(), out result);
                    if (result == 5)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private int ParseSmartResource(Rectangle rect)
        {
            int result = -1;
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, rect))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                        .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                        .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                        .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3");
#if DEBUG
                    bitmap.Save("ArenaScore2.png");
#endif
                    string test1 = Regex.Replace(text, @"\D", ""); // เอา String ออกจาก Number
                    Utility.FilterAscii(test1);
                    //this.Log("Smart TextB: " + text);
                    //this.Log("Smart TextA: " + test1);
                    if (test1.Length >= 1)
                    {
                        int.TryParse(test1, out result);
                    }
                }
            }
            return result;
        }

        private int ParseHonor(Rectangle rect)
        {
            int result = -1;
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(180))
            {
                //bitmap.Save("r_honor.png");
                using (Page page = Tesseractor.Engine.Process(bitmap, null))
                {
                    //this.Log("HO :"+page.GetText().ToLower().Trim());
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                                            .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                                            .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                                            .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3").Replace("110004", "/1000").Replace("n000", "/1000").Trim();
                    if (text.Contains("/"))
                    {
                        string[] array = text.Split(new char[]
                        {
                            '/'
                        });
                        if (array.Length >= 1)
                        {
                            int.TryParse(array[0], out result);
                        }
                    }
                }
            }
            return result;
        }

        private int ParseRuby(Rectangle rect)
        {
            int result = -1;
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(175))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
    .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
    .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "").Replace("}", "3")
    .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3").Replace("*", "").Replace("»", "").Replace(",", "").Trim();
                    string test1 = Regex.Replace(text, @"\D", "");
                    if (test1.Length >= 1)
                    {
                        int.TryParse(test1, out result);
                    }
                    else
                    {
                        result = 0;
                    }
                }
            }
            return result;
        }

        private int ParseTopaz(int offsetX, int offsetY)
        {
            int result = -1;
            Rectangle r_TopazBase = SharedPM.R_TopazBase;
            r_TopazBase.X += offsetX;
            r_TopazBase.Y += offsetY;
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, r_TopazBase))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = ReplaceNumericResource(page.GetText());
                    if (text.Length >= 1)
                    {
                        int.TryParse(text, out result);
                    }
                }
            }
            return result;
        }

        private void ParseGoldAutoRepeat()
        {
            Rectangle rect = AutoRepeatInfoPM.Gold;
            int num = 0;
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(250))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null, PageSegMode.Auto))
                {
                    string text = page.GetText().ToLower().Replace("acquired", "");
                    string text2 = text.Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5").Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace("Z", "2").Replace(")", "").Replace("j", "").Replace("_", "").Replace("‘", "").Replace("'", "").Replace(":", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3").Trim();
                    string text3 = Regex.Replace(text2, @"\D", "");
                    Utility.FilterAscii(text3);
                    int.TryParse(text3, out num);
                    //bitmap.Save("GoldInfo - " + num + ".png");
                    //this.Log("Gold Count: " + text3 + "| GoldText: " + page.GetText().ToLower().Trim());
                    goldadv += num;
                }
            }
        }

        private void ParseItemAutoRepeat()
        {
            Rectangle rect = AutoRepeatInfoPM.Item;
            int num = 0;
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(250))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null, PageSegMode.Auto))
                {
                    string text = page.GetText().ToLower().Replace("acquired", "");
                    string text2 = text.Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5").Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace("Z", "2").Replace(")", "").Replace("j", "").Replace("_", "").Replace("‘", "").Replace("'", "").Replace(":", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3").Trim();
                    string text3 = Regex.Replace(text2, @"\D", "");
                    Utility.FilterAscii(text3);
                    int.TryParse(text3, out num);
                    //bitmap.Save("ItemInfo - " + num + ".png");
                    //this.Log("Item Count: " + text3 + "| ItemText: " + page.GetText().ToLower().Trim());
                    itemadv += num;
                }
            }
        }

        private void ParseHeroAutoRepeat()
        {
            Rectangle rect = AutoRepeatInfoPM.Hero;
            int num = 0;
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(250))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null, PageSegMode.Auto))
                {
                    string text = page.GetText().ToLower().Replace("acquired", "");
                    string text2 = text.Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5").Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace("Z", "2").Replace(")", "").Replace("j", "").Replace("_", "").Replace("‘", "").Replace("'", "").Replace(":", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3").Trim();
                    string text3 = Regex.Replace(text2, @"\D", "");
                    Utility.FilterAscii(text3);
                    int.TryParse(text3, out num);
                    //bitmap.Save("HeroInfo - " + num + ".png");
                    //this.Log("Hero Count: " + text3 + "| HeroText: "+page.GetText().ToLower().Trim());
                    heroadv += num;
                }
            }
        }

        private void ParseSoulAutoRepeat()
        {
            Rectangle rect = AutoRepeatInfoPM.Soul;
            int num = 0;
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(250))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null, PageSegMode.Auto))
                {
                    string text = page.GetText().ToLower().Replace("acquired", "");
                    string text2 = text.Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5").Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace("Z", "2").Replace(")", "").Replace("j", "").Replace("_", "").Replace("‘", "").Replace("'", "").Replace(":", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3").Trim();
                    string text3 = Regex.Replace(text2, @"\D", "");
                    Utility.FilterAscii(text3);
                    int.TryParse(text3, out num);
                    //bitmap.Save("HeroInfo - " + num + ".png");
                    Log("You have got " + num + " Soul.");
                }
            }
        }

        private void ProgressSequence()
        {
            if (AISettings.AD_World != World.Sequencer)
            {
                return;
            }
            if (AISettings.AD_WorldSequence == null || AISettings.AD_StageSequence == null || AISettings.AD_AmountSequence == null)
            {
                return;
            }
            if (AISettings.AD_WorldSequence.Length <= 0 || AISettings.AD_StageSequence.Length <= 0 || AISettings.AD_AmountSequence.Length <= 0)
            {
                return;
            }
            if (CurrentSequence >= AISettings.AD_WorldSequence.Length || CurrentSequence >= AISettings.AD_StageSequence.Length || CurrentSequence >= AISettings.AD_AmountSequence.Length)
            {
                CurrentSequence = 0;
                return;
            }
            int num = AISettings.AD_WorldSequence.Length;
            int arg_CF_0 = AISettings.AD_WorldSequence[CurrentSequence];
            int arg_E2_0 = AISettings.AD_StageSequence[CurrentSequence];
            int num2 = AISettings.AD_AmountSequence[CurrentSequence];
            CurrentSequenceCount++;
            if (CurrentSequenceCount >= num2)
            {
                CurrentSequenceCount = 0;
                CurrentSequence++;
                if (CurrentSequence >= num)
                {
                    CurrentSequence %= num;
                }
            }
            //this.Log("Progress Sequence : " + this.CurrentSequenceCount);
        }

        private string ReplaceNumericResource(string text)
        {
            return Utility.FilterAscii(text).ToLower().Replace("o", "0").Replace("l", "1").Replace("s", "8").Replace(",", "").Replace(".", "").Replace("_", "").Replace(">", "");
        }

        private void ReportAllCount()
        {
            ReportCount(Objective.ADVENTURE);
            ReportArenaCount();
        }

        private void ReportAllKeys()
        {
            ReportKeys(Objective.ADVENTURE);
            ReportKeys(Objective.ARENA);
        }

        private void ReportAllResources()
        {
            ReportResources(ResourceType.GOLD);
            ReportResources(ResourceType.RUBY);
            ReportResources(ResourceType.HONOR);
            ReportResources(ResourceType.TOPAZ);
        }

        private void ReportArenaCount()
        {
            Dictionary<string, object> message = new Dictionary<string, object>
            {
                {
                    "objective",
                    Objective.ARENA
                },
                {
                    "winCount",
                    ArenaWinCount
                },
                {
                    "loseCount",
                    ArenaLoseCount
                },
                {
                    "arenaRank",
                    ArenaRank
                }
            };
            ProgressArgs userState = new ProgressArgs(ProgressType.COUNT, message);
            Worker.ReportProgress(0, userState);
        }

        private void ReportSmartCount()
        {
            Dictionary<string, object> message = new Dictionary<string, object>
            {
                {
                    "objective",
                    Objective.SMART_MODE
                },
                {
                    "count",
                    SmartModeCount
                }
            };
            ProgressArgs userState = new ProgressArgs(ProgressType.COUNT, message);
            Worker.ReportProgress(0, userState);
        }

        private void ReportCount(Objective objective)
        {
            int num = 0;
            int num2 = 0;
            switch (objective)
            {
                case Objective.ADVENTURE:
                    num = AdventureCount;
                    num2 = h30;
                    break;
            }

            Dictionary<string, object> message = new Dictionary<string, object>
                {
                    {
                        "objective",
                        objective
                    },
                    {
                        "count",
                         num
                    },
                    {
                        "h30",
                         num2
                    },
                    {
                        "goldadv",
                         goldadv
                    },
                    {
                        "heroadv",
                         heroadv
                    },
                    {
                        "itemadv",
                         itemadv
                    },
                };

            ProgressArgs userState = new ProgressArgs(ProgressType.COUNT, message);
            Worker.ReportProgress(0, userState);
        }

        private void ReportCheckSlot(Objective objective)
        {
            int num = 0;
            int num2 = 0;
            switch (objective)
            {
                case Objective.CHECK_SLOT_HERO:
                    num = HeroCount;
                    num2 = HeroMax;
                    break;

                case Objective.CHECK_SLOT_ITEM:
                    num = ItemCount;
                    num2 = ItemMax;
                    break;
            }

            Dictionary<string, object> message = new Dictionary<string, object>
                {
                    {
                        "objective",
                        objective
                    },
                    {
                        "count",
                         num
                    },
                    {
                        "max",
                         num2
                    }
                };

            ProgressArgs userState = new ProgressArgs(ProgressType.CHECK_SLOT, message);
            Worker.ReportProgress(0, userState);
        }

        private void ReportKeys(Objective objective)
        {
            int num = 0;
            TimeSpan timeSpan = TimeSpan.MaxValue;
            switch (objective)
            {
                case Objective.ADVENTURE:
                    num = AdventureKeys;
                    timeSpan = AdventureKeyTime;
                    break;

                case Objective.ARENA:
                    num = ArenaKeys;
                    timeSpan = ArenaKeyTime;
                    break;
            }
            Dictionary<string, object> dictionary = new Dictionary<string, object>
            {
                {
                    "objective",
                    objective
                },
                {
                    "keys",
                    num
                }
            };
            if (timeSpan != TimeSpan.MaxValue)
            {
                dictionary.Add("time", timeSpan);
            }
            ProgressArgs userState = new ProgressArgs(ProgressType.KEY, dictionary);
            Worker.ReportProgress(0, userState);
        }

        private void ReportResources(ResourceType resourceType)
        {
            int num = -1;
            switch (resourceType)
            {
                case ResourceType.GOLD:
                    num = GoldCount;
                    break;

                case ResourceType.RUBY:
                    num = RubyCount;
                    break;

                case ResourceType.HONOR:
                    num = HonorCount;
                    break;
                case ResourceType.GOLDEN_CRYSTAL:
                    num = GoldenCrystalCount;
                    break;
                case ResourceType.HORN:
                    num = HornCount;
                    break;
                case ResourceType.SCALE:
                    num = ScaleCount;
                    break;
                case ResourceType.ESSENCE:
                    num = EssecenseCount;
                    break;
                case ResourceType.STAR:
                    num = StarCount;
                    break;
                case ResourceType.SOUL:
                    num = SoulCount;
                    break;
            }
            Dictionary<string, object> message = new Dictionary<string, object>
            {
                {
                    "resourceType",
                    resourceType
                },
                {
                    "value",
                    num
                }
            };
            ProgressArgs userState = new ProgressArgs(ProgressType.RESOURCE, message);
            Worker.ReportProgress(0, userState);
        }

        private Scene SceneSearch()
        {
            Scene scene = SearchScenes();
            if (CurrentScene != null)
            {
                PreviousScene = CurrentScene;
            }
            CurrentScene = scene;
            return scene;
        }

        private void ScrollHeroCards(bool down = true)
        {
            PixelMapping pixelMapping = down ? HeroesPM.ScrollAreaDown : HeroesPM.ScrollAreaUp;
            int num = down ? (-HeroesPM.SCROLL_DELTA) : HeroesPM.SCROLL_DELTA;
            ClickDrag(pixelMapping.X, pixelMapping.Y, pixelMapping.X, pixelMapping.Y + num);
        }

        private Scene SearchScenes()
        {
            try
            {
                CaptureFrame();
                bool flag = MatchMapping(DialogPM.Arena_Intro_CharacterEye, 2) && MatchMapping(DialogPM.Arena_Intro_DimmedBackground, 2);
                if (flag)
                {
                    Scene result = new Scene(SceneType._DIALOG);
                    return result;
                }
                bool flag2 = MatchMapping(AndroidPopupPM.TopLeftBorder, 2) && MatchMapping(AndroidPopupPM.TopRightBorder, 2);
                if (flag2)
                {
                    Scene result = new Scene(SceneType._ANDROID_POPUP);
                    return result;
                }
                if (MatchMapping(ForceClosePopupPM.TopLeftBorder, 2) && MatchMapping(ForceClosePopupPM.TopRightBorder, 2) && MatchMapping(ForceClosePopupPM.ReportBtn, 2) && MatchMapping(ForceClosePopupPM.OkButton, 2))
                {
                    Scene result = new Scene(SceneType._FORCE_CLOSE);
                    return result;
                }
                if (MatchMapping(AndroidPopupPM.NRBackgorund, 2) && MatchMapping(AndroidPopupPM.NRBackground2, 2) && MatchMapping(AndroidPopupPM.NROKText, 2) && MatchMapping(AndroidPopupPM.NRReportText, 2) && MatchMapping(AndroidPopupPM.NRWaitText, 2))
                {
                    Scene result = new Scene(SceneType._NOT_RESPONDING_POPUP);
                    return result;
                }
                if (MatchMapping(AhriConnectingPM.Ahri1, 2) || MatchMapping(AhriConnectingPM.Ahri2, 2) || MatchMapping(AhriConnectingPM.Ahri3, 2))
                {
                    Scene result = new Scene(SceneType.AHRI_CONNECTING);
                    return result;
                }
                if (MatchMapping(AresCupPM.PopupBorder1, 2) && MatchMapping(AresCupPM.PopupBorder2, 2))
                {
                    Scene result = new Scene(SceneType.ARES_CUP_CONTESTANTS);
                    return result;
                }
                if ((MatchMapping(BluestackPM.LDStoreIcon1, 2) && MatchMapping(BluestackPM.LDStoreIcon2, 2) && MatchMapping(BluestackPM.Background, 2)) || MatchMapping(BluestackPM.LDStoreIcon1_2, 2) && MatchMapping(BluestackPM.LDStoreIcon2_2, 2) && MatchMapping(BluestackPM.Background_2, 2))
                {
                    Scene result = new Scene(SceneType.EMULATOR_HOME);
                    return result;
                }
                if (MatchMapping(ExitPopupPM.LeftBorder, 2) && MatchMapping(ExitPopupPM.RightBorder, 2) && MatchMapping(ExitPopupPM.OkButtonBorderLeft, 2) && MatchMapping(ExitPopupPM.TitleBorder1, 2))
                {
                    Scene result = new Scene(SceneType.EXIT_POPUP);
                    return result;
                }
                if (MatchMapping(HeroesPM.IconLeft, 2) && MatchMapping(HeroesPM.IconMiddle, 2) && MatchMapping(HeroesPM.IconRight, 2) && MatchMapping(HeroesPM.OptimizeBorder, 4))
                {
                    Scene result = new Scene(SceneType.HEROES);
                    return result;
                }
                if (MatchMapping(TemporaryStoragePM.TopBorderLeft, 2) && MatchMapping(TemporaryStoragePM.TopBorderRight, 2) && MatchMapping(TemporaryStoragePM.CloseButton, 2))
                {
                    Scene result = new Scene(SceneType.TEMPORARY_STORAGE);
                    return result;
                }
                if (MatchMapping(PowerUpLobbyPM.Point1, 2) && MatchMapping(PowerUpLobbyPM.Point2, 2) && MatchMapping(PowerUpLobbyPM.Point3, 4))
                {
                    Scene result = new Scene(SceneType.POWER_UP_LOBBY);
                    return result;
                }
                if (MatchMapping(PowerUpFailedPopupPM.DimmedBG, 2) && MatchMapping(PowerUpFailedPopupPM.PopupBorder, 2) && MatchMapping(PowerUpFailedPopupPM.GoldIcon, 4))
                {
                    Scene result = new Scene(SceneType.POWER_UP_FAILED_POPUP);
                    return result;
                }
                if (MatchMapping(PowerUpConfirmPM.Point1, 2) && MatchMapping(PowerUpConfirmPM.Point2, 2) && MatchMapping(PowerUpConfirmPM.Point3, 4))
                {
                    Scene result = new Scene(SceneType.POWER_UP_CONFIRM);
                    return result;
                }
                if (MatchMapping(FuseConfirmPM.Point1, 2) && MatchMapping(FuseConfirmPM.Point2, 2) && MatchMapping(FuseConfirmPM.Point3, 2))
                {
                    Scene result = new Scene(SceneType.FUSE_CONFIRM);
                    return result;
                }
                if (MatchMapping(PowerUpProcessPM.Point1, 2) && MatchMapping(PowerUpProcessPM.Point2, 2))
                {
                    Scene result = new Scene(SceneType.POWER_UP_PROCESS);
                    return result;
                }
                if (MatchMapping(PowerUpSuccessPM.Point1, 2) && MatchMapping(PowerUpSuccessPM.Point2, 2) && (MatchMapping(PowerUpSuccessPM.Point3, 4) || MatchMapping(PowerUpSuccessPM.Point4, 4)))
                {
                    Scene result = new Scene(SceneType.POWER_UP_SUCCESS);
                    return result;
                }
                if (MatchMapping(FuseLobbyPM.Point1, 2) && MatchMapping(FuseLobbyPM.Point2, 2) && MatchMapping(FuseLobbyPM.Point3, 4) && MatchMapping(FuseLobbyPM.Point4, 4))
                {
                    Scene result = new Scene(SceneType.FUSE_LOBBY);
                    return result;
                }
                if (MatchMapping(FuseSuccessPM.Point1, 2) && MatchMapping(FuseSuccessPM.Point2, 2) && MatchMapping(FuseSuccessPM.Point3, 4))
                {
                    Scene result = new Scene(SceneType.FUSE_SUCCESS);
                    return result;
                }
                if (MatchMapping(HeroesSameTeamPopupPM.DimmedBG, 2) && MatchMapping(HeroesSameTeamPopupPM.PopupBorderLeft, 2) && MatchMapping(HeroesSameTeamPopupPM.PopupBorderRight, 2))
                {
                    Scene result = new Scene(SceneType.HEROES_SAME_TEAM_POPUP);
                    return result;
                }
                if (MatchMapping(SharedPM.Hero_BlackBar, 2) && MatchMapping(SharedPM.Hero_BottomLeftBorder, 2) && MatchMapping(HeroJoinPM.JoinButtonIcon, 2) && (MatchMapping(HeroJoinPM.SellButton, 2) || MatchMapping(HeroRemovePM.RemoveAllButton, 2)))
                {
                    Scene result = new Scene(SceneType.HERO_JOIN);
                    return result;
                }
                if (MatchMapping(HeroRemovePM.RemoveAllButton, 2) && MatchMapping(HeroRemovePM.PositionButton, 2) && MatchMapping(HeroRemovePM.RemoveButton, 2))
                {
                    Scene result = new Scene(SceneType.HERO_REMOVE);
                    return result;
                }
                if (MatchMapping(Level30DialogPM.CharacterEye, 4) && MatchMapping(Level30DialogPM.DialogBorder, 4) && MatchMapping(Level30DialogPM.InboxIcon, 3))
                {
                    Scene result = new Scene(SceneType.LEVEL_30_DIALOG);
                    return result;
                }
                if (MatchMapping(Level30MaxDialogPM.CharacterEye, 3) && MatchMapping(Level30MaxDialogPM.InboxButton, 4) && MatchMapping(Level30MaxDialogPM.YellowTick, 3) && MatchMapping(Level30MaxDialogPM.NecklaceCharacter, 3))
                {
                    Scene result = new Scene(SceneType.LEVEL_30_MAX_DIALOG);
                    return result;
                }
                if (MatchMapping(LevelUpDialogPM.CharacterEye, 3) && MatchMapping(LevelUpDialogPM.YellowTick, 3))
                {
                    Scene result = new Scene(SceneType.LEVEL_UP_DIALOG);
                    return result;
                }
                if (MatchMapping(LeaderIconDialogPM.Character1, 3) && MatchMapping(LeaderIconDialogPM.Character2, 3) && MatchMapping(LeaderIconDialogPM.LeaderButton, 3))
                {
                    Scene result = new Scene(SceneType.LEADER_ICON);
                    return result;
                }
                if (MatchMapping(LobbyPM.MenuButtonYellowLeft, 2) && MatchMapping(LobbyPM.MenuButtonYellowRight, 2))
                {
                    Scene result = new Scene(SceneType.LOBBY);
                    return result;
                }
                if (MatchMapping(UnknownPopupPM.PopupBorderBottom, 3) && MatchMapping(UnknownPopupPM.PopupBorderTop, 3))
                {
                    Scene result = new Scene(SceneType.UNKNOWN_AREA);
                    return result;
                }
                if (MatchMapping(UnknownPopupSuccessPM.PopupBorderBottom, 3) && MatchMapping(UnknownPopupSuccessPM.PopupBorderTop, 3) && MatchMapping(UnknownPopupSuccessPM.CloseBtnBG, 3))
                {
                    Scene result = new Scene(SceneType.UNKNOWN_AREA_SUCCESS);
                    return result;
                }
                if ((MatchMapping(ArenaFightPM.ChatButton, 2) && MatchMapping(ArenaFightPM.PauseButton, 2) && MatchMapping(ArenaFightPM.TimeBorder, 2)) || (MatchMapping(ArenaFightPM.Point12, 2) && MatchMapping(ArenaFightPM.Point22, 2) && MatchMapping(ArenaFightPM.Point32, 2)))
                {
                    Scene result = new Scene(SceneType.ARENA_FIGHT);
                    return result;
                }
                if (((MatchMapping(AdventureFightPM.FightButtonHidden, 2) && MatchMapping(AdventureFightPM.FightButtonHidden2, 2)) || (MatchMapping(AdventureFightPM.FightButtonShown, 2) && MatchMapping(AdventureFightPM.FightButtonShown2, 2))) && MatchMapping(AdventureFightPM.TurnYellowBar, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_FIGHT);
                    return result;
                }
                if (MatchMapping(StatusBoardPM.LeftTabCon, 2) && MatchMapping(StatusBoardPM.RightTabCol, 2))
                {
                    Scene result = new Scene(SceneType.HOTTIME_POPUP);
                    return result;
                }

                if (MatchMapping(OutOfKeysOfferPM.BuyButtonBorder, 2) && MatchMapping(OutOfKeysOfferPM.RedCross, 2) && MatchMapping(OutOfKeysOfferPM.StartBG, 2))
                {
                    Scene result = new Scene(SceneType.OUT_OF_KEYS_OFFER);
                    return result;
                }

                if (MatchMapping(StatusBoardPM.NoRedCloss, 2) && MatchMapping(StatusBoardPM.ConfirmOKtick, 2) && MatchMapping(StatusBoardPM.ActiveBG, 2))
                {
                    Scene result = new Scene(SceneType.HOTTIME_CONFIRM_POPUP);
                    return result;
                }

                if (MatchMapping(ShopPM.ShopCommon, 2) && MatchMapping(ShopPM.ShopPackge, 2))
                {
                    Scene result = new Scene(SceneType.SHOP_LOBBY);
                    return result;
                }
                if (MatchMapping(AutoRepeatInfoPM.GoldIcon, 2) && MatchMapping(AutoRepeatInfoPM.CardIcon, 2) && MatchMapping(AutoRepeatInfoPM.ChestIcon, 2))
                {
                    Scene result = new Scene(SceneType.AUTO_REPEAT_INFO);
                    return result;
                }
                if (MatchMapping(SmartSelectPM.Point1, 2) && MatchMapping(SmartSelectPM.Point2, 2))
                {
                    Scene result = new Scene(SceneType.SMART_SELECT);
                    return result;
                }
                if (MatchMapping(SmartLobbyPM.Point1, 2) && MatchMapping(SmartLobbyPM.Point2, 2))
                {
                    Scene result = new Scene(SceneType.SMART_LOBBY);
                    return result;
                }
                if (MatchMapping(SmartLootCollectPM.Point1, 2) && MatchMapping(SmartLootCollectPM.Point2, 2))
                {
                    Scene result = new Scene(SceneType.SMART_LOOT_COLLECT_LOBBY);
                    return result;
                }
                if (MatchMapping(ShopPM.BoderRight, 2) && MatchMapping(ShopPM.Borderleft, 2) || (MatchMapping(ShopPM.BoderCompair1, 2) && MatchMapping(ShopPM.BoderCompair2, 2)))
                {
                    Scene result = new Scene(SceneType.SHOP);
                    return result;
                }
                if ((MatchMapping(SharedPM.ShopPopup_DimmedBG, 2) || MatchMapping(SharedPM.ShopPopup_DimmedBG2, 2)) && MatchMapping(ShopBuyPopupPM.PopupBorderLeft, 2) && MatchMapping(ShopBuyPopupPM.RedCross, 2) && MatchMapping(ShopBuyPopupPM.YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.SHOP_BUY_POPUP);
                    return result;
                }
                if (MatchMapping(ShopPurchaseCompletePopupPM.AgainButtonBorder, 2) && MatchMapping(ShopPurchaseCompletePopupPM.OKButtonBorder, 2))
                {
                    Scene result = new Scene(SceneType.SHOP_PURCHASE_COMPLETE_POPUP);
                    return result;
                }
                if ((MatchMapping(SharedPM.ShopPopup_DimmedBG, 2) || MatchMapping(SharedPM.ShopPopup_DimmedBG2, 2)) && ((MatchMapping(ShopBuyFailedPopupPM.PopupBorderLeft, 2) && MatchMapping(ShopBuyFailedPopupPM.YellowTick, 2)) || (MatchMapping(ShopBuyFailedPopupPM.PopupBorderLeft2, 2) && MatchMapping(ShopBuyFailedPopupPM.YellowTick2, 2))))
                {
                    Scene result = new Scene(SceneType.SHOP_BUY_FAILED_POPUP);
                    return result;
                }
                if (MatchMapping(InboxPM.CharacterBody, 3) && MatchMapping(InboxPM.MailIcon, 2) && MatchMapping(InboxPM.CharacterBody2, 3))
                {
                    Scene result = new Scene(SceneType.INBOX);
                    return result;
                }
                if ((MatchMapping(InboxRewardsPopupPM.DimmedBG, 2) && MatchMapping(InboxRewardsPopupPM.DimmedBG2, 2)) && ((MatchMapping(InboxRewardsPopupPM.PopupBorder, 2) && MatchMapping(InboxRewardsPopupPM.YellowTick, 2)) || (MatchMapping(InboxRewardsPopupPM.PopupBorderTickets, 2) && MatchMapping(InboxRewardsPopupPM.PopupBorderTickets2, 2))))
                {
                    Scene result = new Scene(SceneType.INBOX_REWARDS_POPUP);
                    return result;
                }
                if (MatchMapping(InboxCollectFailedPopupPM.DimmedBG_1, 2) && MatchMapping(InboxCollectFailedPopupPM.DimmedBG_2, 2) && MatchMapping(InboxCollectFailedPopupPM.PopupBorder, 2))
                {
                    Scene result = new Scene(SceneType.INBOX_COLLECT_FAILED_POPUP);
                    return result;
                }
                if (MatchMapping(InboxCollectFailedPopupPM.DimmedBG_12, 2) && MatchMapping(InboxCollectFailedPopupPM.DimmedBG_22, 2) && MatchMapping(InboxCollectFailedPopupPM.PopupBorder2, 2))
                {
                    Scene result = new Scene(SceneType.INBOX_COLLECT_FAILED_POPUP_2);
                    return result;
                }
                if (MatchMapping(MasteryPopupPM.TitleBorder, 2) && MatchMapping(MasteryPopupPM.RedBackground, 2) && MatchMapping(MasteryPopupPM.CloseButton, 2))
                {
                    Scene result = new Scene(SceneType.MASTERY_POPUP);
                    return result;
                }
                if (MatchMapping(MapSelectPM.Point1, 2) && (MatchMapping(MapSelectPM.Point2, 2) || MatchMapping(MapSelectPM.Point4, 2)) && MatchMapping(MapSelectPM.Point3, 2))
                {
                    Scene result = new Scene(SceneType.MAP_SELECT);
                    return result;
                }
                if (MatchMapping(OutOfSwordsPopupPM.PopupBorderLeft, 2) && (MatchMapping(OutOfSwordsPopupPM.DimmedBGStart, 2) || MatchMapping(OutOfSwordsPopupPM.DimmedBGEnd, 2) || MatchMapping(OutOfSwordsPopupPM.DimmedBG2Start, 2) || MatchMapping(OutOfSwordsPopupPM.DimmedBG2End, 2)))
                {
                    Scene result = new Scene(SceneType.OUT_OF_SWORDS_POPUP);
                    return result;
                }
                if (MatchMapping(MapSelectPopupPM.PopupBorderLeft, 2) && MatchMapping(MapSelectPopupPM.PopupBorderRight, 2) && MatchMapping(MapSelectPopupPM.DimmedBG, 2))
                {
                    Scene result = new Scene(SceneType.MAP_SELECT_POPUP);
                    return result;
                }
                if (MatchMapping(SharedPM.Full_DimmedBG, 2) && MatchMapping(FullItemPopupPM.SellButtonIcon, 2))
                {
                    Scene result = new Scene(SceneType.FULL_ITEM_POPUP);
                    return result;
                }
                if (MatchMapping(SharedPM.Full_DimmedBG, 2) && MatchMapping(FullHeroPopupPM.SellButtonIcon, 2))
                {
                    Scene result = new Scene(SceneType.FULL_HERO_POPUP);
                    return result;
                }
                if (MatchMapping(BattleModesPM.BorderTopLeft, 2) && MatchMapping(BattleModesPM.BorderBottomRight, 2) && MatchMapping(BattleModesPM.QuestRedScroll, 2))
                {
                    Scene result = new Scene(SceneType.BATTLE_MODES);
                    return result;
                }
                if (MatchMapping(ArenaStartPM.CombatTeamBorderLeft, 2) && MatchMapping(ArenaStartPM.CombatTeamBorderRight, 2) && MatchMapping(ArenaStartPM.FormationBorderLeft, 3))
                {
                    Scene result = new Scene(SceneType.ARENA_START);
                    return result;
                }
                if ((MatchMapping(ArenaEndPM.QuickStartButton, 2) && MatchMapping(ArenaEndPM.ArenaButton, 2)) || (MatchMapping(ArenaEndPM.QuickStartLoseButton, 2) && MatchMapping(ArenaEndPM.ArenaLoseButton, 2) && MatchMapping(ArenaEndPM.GetStrongerButton, 2)))
                {
                    Scene result = new Scene(SceneType.ARENA_END);
                    return result;
                }
                if (MatchMapping(ArenaSeasonEndPM.Point1, 2) && MatchMapping(ArenaSeasonEndPM.Point2, 2) && MatchMapping(ArenaSeasonEndPM.PopupLeftBorder, 2) && MatchMapping(ArenaSeasonEndPM.PopupRightBorder, 2))
                {
                    Scene result = new Scene(SceneType.ARENA_SEASON_END);
                    return result;
                }
                if (MatchMapping(ArenaFullHonorPopupPM.PopupBorderLeft, 2) && MatchMapping(ArenaFullHonorPopupPM.YellowTick, 4) && MatchMapping(ArenaFullHonorPopupPM.DimmedBG, 2))
                {
                    Scene result = new Scene(SceneType.ARENA_FULL_HONOR_POPUP);
                    return result;
                }
                if (MatchMapping(AdventureReadyPM.ReadyButtonBackground, 2) && MatchMapping(AdventureReadyPM.DropListBackground, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_READY);
                    return result;
                }
                if (MatchMapping(SellHeroesLobbyPM.Point1, 2) && MatchMapping(SellHeroesLobbyPM.Point2, 2) && MatchMapping(SellHeroesLobbyPM.BackButton, 2) && MatchMapping(SellHeroesLobbyPM.RefreshButton, 2))
                {
                    Scene result = new Scene(SceneType.SELL_HERO_LOBBY);
                    return result;
                }
                if (MatchMapping(SellItemsLobbyPM.Point1, 2) && MatchMapping(SellItemsLobbyPM.Point2, 2) && MatchMapping(SellItemsLobbyPM.BackButton, 2) && MatchMapping(SellItemsLobbyPM.RefreshButton, 2))
                {
                    Scene result = new Scene(SceneType.SELL_ITEM_LOBBY);
                    return result;
                }
                if (MatchMapping(ItemsPM.Point1, 2) && MatchMapping(ItemsPM.Point2, 2))
                {
                    Scene result = new Scene(SceneType.ITEMS);
                    return result;
                }
                if ((MatchMapping(AutoRepeatPopupPM.NoButton, 2) && MatchMapping(AutoRepeatPopupPM.PopupBorder, 2) && MatchMapping(AutoRepeatPopupPM.ManageBtnBackgroun, 2) && MatchMapping(AutoRepeatPopupPM.OkBtn, 2)))
                {
                    Scene result = new Scene(SceneType.AUTO_REPEAT_POPUP);
                    return result;
                }
                if (MatchMapping(AdventureStartPM.KeyPlusButton, 2) && MatchMapping(AdventureStartPM.LvFriendBorder, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_START);
                    return result;
                }
                if (MatchMapping(AdventureStartPM.Auto_KeyPlusButton, 2) && MatchMapping(AdventureStartPM.Auto_StopButton, 2) && MatchMapping(AdventureStartPM.Auto_BlackBorder, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_START_AUTO);
                    return result;
                }
                if ((MatchMapping(NoMoreHeroPopupPM.DimmedBG, 2) || MatchMapping(NoMoreHeroPopupPM.DimmedBGStart, 2)) && MatchMapping(NoMoreHeroPopupPM.PopupBorderLeft, 2) && MatchMapping(NoMoreHeroPopupPM.PopupBorderRight, 2))
                {
                    Scene result = new Scene(SceneType.NO_MORE_HERO_POPUP);
                    return result;
                }
                if ((MatchMapping(NoMoreRubyPopupPM.DimmedBGEnd, 2) || MatchMapping(NoMoreRubyPopupPM.DimmedBGStart, 2)) && MatchMapping(NoMoreRubyPopupPM.PopupBorderLeft, 2) && MatchMapping(NoMoreRubyPopupPM.PopupBorderRight, 2))
                {
                    Scene result = new Scene(SceneType.NO_MORE_RUBY_POPUP);
                    return result;
                }
                if (MatchMapping(NoMoreRubyOfferPM.DimmedBG, 2) && MatchMapping(NoMoreRubyOfferPM.RubyIcon, 2) && MatchMapping(NoMoreRubyOfferPM.PopupBorderLeft, 2) && MatchMapping(NoMoreRubyOfferPM.PopupBorderRight, 2))
                {
                    Scene result = new Scene(SceneType.NO_MORE_RUBY_OFFER);
                    return result;
                }
                if (MatchMapping(AutoRepeatStopPM.x2Icon, 2) && MatchMapping(AutoRepeatStopPM.GoldIcon, 2) && MatchMapping(AutoRepeatStopPM.PopupBorder, 2))
                {
                    Scene result = new Scene(SceneType.AUTO_REPEAT_STOP);
                    return result;
                }
                if (MatchMapping(VictoryPM.RibbonLeft, 2) && MatchMapping(VictoryPM.RibbonMiddle, 2) && MatchMapping(VictoryPM.RibbonRight, 2))
                {
                    Scene result = new Scene(SceneType.VICTORY);
                    return result;
                }
                if (MatchMapping(SharedPM.Lost_PurpleBase, 2) && MatchMapping(SharedPM.Lost_Moon, 2) && MatchMapping(AdventureLostPM.GetStrongerButton, 2) && MatchMapping(AdventureLostPM.AgainButton, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_LOST);
                    return result;
                }
                if (MatchMapping(AdventureLootPM.EndAutoRepeat, 2) && MatchMapping(AdventureLootPM.Auto_QuickStartButton, 2) && MatchMapping(AdventureLootPM.Auto_LobbyButton, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_LOOT_AUTO);
                    return result;
                }
                if (MatchMapping(AdventureLootPM.AdventureButton, 2) && MatchMapping(AdventureLootPM.QuickStartButton, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_LOOT);
                    return result;
                }
                if (MatchMapping(OutOfKeysPopupPM.PopupBorder, 3) && MatchMapping(OutOfKeysPopupPM.PopupBorder2, 3) && (MatchMapping(OutOfKeysPopupPM.DimmedBGEnd, 2) || MatchMapping(OutOfKeysPopupPM.DimmedBGStart, 2)) && CurrentObjective == Objective.ADVENTURE)
                {
                    Scene result = new Scene(SceneType.OUT_OF_KEYS_POPUP);
                    return result;
                }
                if (MatchMapping(SellHeroConfirmPopupPM.DimmedBG_1, 2) && MatchMapping(SellHeroConfirmPopupPM.DimmedBG_2, 2) && MatchMapping(SellHeroConfirmPopupPM.RedCross, 2) && MatchMapping(SellHeroConfirmPopupPM.SellButtonBG, 2))
                {
                    Scene result = new Scene(SceneType.SELL_HERO_CONFIRM_POPUP);
                    return result;
                }
                if (MatchMapping(SellItemPopupPM.ItemIcon, 2) && MatchMapping(SellItemPopupPM.CloseButton, 2))
                {
                    Scene result = new Scene(SceneType.SELL_ITEM_POPUP);
                    return result;
                }
                if (MatchMapping(SellItemConfirmPopupPM.DimmedBG_1, 2) && MatchMapping(SellItemConfirmPopupPM.DimmedBG_2, 2) && MatchMapping(SellItemConfirmPopupPM.RedCross, 2))
                {
                    Scene result = new Scene(SceneType.SELL_ITEM_CONFIRM_POPUP);
                    return result;
                }
                if (MatchMapping(SellItemSuccessPopupPM.Point1, 2) && MatchMapping(SellItemSuccessPopupPM.Point2, 2) && MatchMapping(SellItemSuccessPopupPM.YellowTick, 2) && MatchMapping(SellItemSuccessPopupPM.DimmedBG, 2))
                {
                    Scene result = new Scene(SceneType.SELL_ITEM_SUCCESS_POPUP);
                    return result;
                }
                if (MatchMapping(SellHeroesSuccessPopupPM.Point1, 2) && MatchMapping(SellHeroesSuccessPopupPM.Point2, 2) && MatchMapping(SellHeroesSuccessPopupPM.YellowTick, 2) && MatchMapping(SellHeroesSuccessPopupPM.DimmedBG, 2))
                {
                    Scene result = new Scene(SceneType.SELL_HEROES_SUCCESS_POPUP);
                    return result;
                }
                if (MatchMapping(NetmarbleSplashPM.Mascot_1, 2) && MatchMapping(NetmarbleSplashPM.Mascot_2, 2) && MatchMapping(NetmarbleSplashPM.WhiteBackground, 2))
                {
                    Scene result = new Scene(SceneType.NETMARBLE_SPLASH);
                    return result;
                }
                if (MatchMapping(PatchUpdatePM.ProgressBar1, 2) && MatchMapping(PatchUpdatePM.ProgressBar2, 2) && MatchMapping(PatchUpdatePM.ProgressBar3, 2))
                {
                    Scene result = new Scene(SceneType.PATCH_UPDATE);
                    return result;
                }
                if (MatchMapping(UpdatePM.Point1, 2) && MatchMapping(UpdatePM.Point2, 2))
                {
                    Scene result = new Scene(SceneType.UPDATE);
                    return result;
                }
                if (MatchMapping(TapToPlayPM.Point1, 2) || MatchMapping(TapToPlayPM.Point2, 2))
                {
                    Scene result = new Scene(SceneType.TAP_TO_PLAY);
                    return result;
                }
                if (MatchMapping(LandingPM.LoadingLanding1, 2) && MatchMapping(LandingPM.LoadingLanding2, 2))
                {
                    Scene result = new Scene(SceneType.LANDING);
                    return result;
                }
                if (MatchMapping(LoadingPM.Point1, 2) && MatchMapping(LoadingPM.LoadingBlueBar, 2) && MatchMapping(LoadingPM.Point2, 2))
                {
                    Scene result = new Scene(SceneType.LOADING);
                    return result;
                }
                if (MatchMapping(NoticePM.TopBorderLeft, 2) && MatchMapping(NoticePM.TopBorderRight, 2))
                {
                    Scene result = new Scene(SceneType.NOTICE);
                    return result;
                }
                if (MatchMapping(CheckInPM.CloseButton, 2) && MatchMapping(CheckInPM.BorderTopLeft, 2) && MatchMapping(CheckInPM.BorderRightBottom, 2))
                {
                    Scene result = new Scene(SceneType.CHECK_IN);
                    return result;
                }
                if (MatchMapping(WifiWarningPopupPM.LeftBorder, 2) && MatchMapping(WifiWarningPopupPM.RightBorder, 2) && MatchMapping(WifiWarningPopupPM.YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.WIFI_WARNING_POPUP);
                    return result;
                }
                if (MatchMapping(QuestRewardsPopupPM.QuestIcon, 2) && MatchMapping(QuestRewardsPopupPM.AragonPic, 2) && MatchMapping(QuestRewardsPopupPM.DimmedBG, 2))
                {
                    Scene result = new Scene(SceneType.DAILY_QUEST_COMPLETE);
                    return result;
                }
                if (MatchMapping(SellHeroConfirmPopupPM.SellButtonbg, 2) && MatchMapping(SellHeroConfirmPopupPM.GoldSellIconbg, 2) && MatchMapping(SellHeroConfirmPopupPM.SoldOKYellowTik, 2))
                {
                    Scene result = new Scene(SceneType.SELL_HERO_FINISH);
                    return result;
                }
                if (MatchMapping(Popup3PM.EventPackPoint1, 2) && MatchMapping(Popup3PM.EventPackPoint2, 2) && MatchMapping(Popup3PM.EventPackCloseBtn))
                {
                    Scene result = new Scene(SceneType.EVENT_PACKAGE_POPUP);
                    return result;
                }
                if (MatchMapping(Popup3PM.OneDollarPoint1, 2) && MatchMapping(Popup3PM.OneDollarPoint2, 2) && MatchMapping(Popup3PM.OneDollarCloseBtn))
                {
                    Scene result = new Scene(SceneType.ONE_DOLLAR_SHOP_POPUP);
                    return result;
                }
                if (MatchMapping(ArenaEndPM.LobbyButtonBG, 2) && MatchMapping(ArenaEndPM.ArenaRankUpPoint1, 2) && MatchMapping(ArenaEndPM.ArenaRankUpPoint2, 2))
                {
                    Scene result = new Scene(SceneType.RANK_UP);
                    return result;
                }
                if (MatchMapping(SharedPM.HelpFriendTik, 2) && MatchMapping(SharedPM.HelpFriendBorder, 2))
                {
                    Scene result = new Scene(SceneType.HELPED_FRIEND);
                    return result;
                }
                if (MatchMapping(PausePM.Point1, 2) && (MatchMapping(PausePM.Point2, 2)))
                {
                    Scene result = new Scene(SceneType.PAUSE);
                    return result;
                }
                if (MatchMapping(DisconnectedPopupPM.Title1, 2) && MatchMapping(DisconnectedPopupPM.Title2, 2) && MatchMapping(DisconnectedPopupPM.Title3, 2) && MatchMapping(DisconnectedPopupPM.OKTick, 2))
                {
                    Scene result = new Scene(SceneType.DISCONNECTED_POPUP);
                    return result;
                }
                if ((MatchMapping(ArenaReadyPM.RecordBorder, 2) && MatchMapping(ArenaReadyPM.ReadyButtonBackground, 2) && MatchMapping(ArenaReadyPM.RubyPlus, 2))
                    || ((MatchMapping(ArenaReadyPM.RewardBackground, 2) && MatchMapping(ArenaReadyPM.CollectBorder, 2))))
                {
                    Scene result = new Scene(SceneType.ARENA_READY);
                    return result;
                }
            }
            catch
            {
                Scene result = null;
                return result;
            }
            return null;
        }

        private int SearchStage(PixelMapping[][] anchorMappings)
        {
            CaptureFrame();
            int num = 0;
            for (int i = 0; i < anchorMappings.Length; i++)
            {
                PixelMapping[] array = anchorMappings[i];
                if (MatchMapping(array[0], 3) && MatchMapping(array[1], 3))
                {
                    break;
                }
                num++;
            }
            return num;
        }

        private void SelectDifficulty()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                MapSelectPM.DifficultyBox,
                MapSelectPM.DifficultyBoxSelectEasy,
                MapSelectPM.DifficultyBoxSelectNormal
            };
            Difficulty aD_Difficulty = Difficulty.None;
            PixelMapping mapping;
            aD_Difficulty = AISettings.AD_Difficulty2nd;
            mapping = array[(int)aD_Difficulty];
            if (MatchMapping(MapSelectPM.DifficultyBoxExpanded, 2))
            {
                WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                return;
            }
            if (aD_Difficulty != Difficulty.None)
            {
                WeightedClick(array[0], 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(500);
                WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
            }
        }

        private void SelectStage(PixelMapping[][] anchorMappings, PixelMapping stageMapping, int pageDestIndex, bool diffAvailable)
        {
            int num = SearchStage(anchorMappings);
            if (num > anchorMappings.Length - 1)
            {
                return;
            }
            if (num != pageDestIndex)
            {
                int num2 = FindShortestWorldPath(num, pageDestIndex, anchorMappings.Length);
                PixelMapping mapping = (num2 > 0) ? MapSelectPM.NextButton : MapSelectPM.PreviousButton;
                for (int i = 0; i < Math.Abs(num2); i++)
                {
                    WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(500);
                }
            }
            SevenKnightsCore.Sleep(500);
            int num3 = SearchStage(anchorMappings);
            if (num3 == pageDestIndex)
            {
                if (diffAvailable)
                {
                    SelectDifficulty();
                }
                SevenKnightsCore.Sleep(500);
                WeightedClick(stageMapping, 1.0, 1.0, 1, 0, "left");
            }
        }

        private void SelectStageAsgar(World world, int stage)
        {
            PixelMapping[][] anchorMappings = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World1Anchor_1,
                    MapSelectPM.World1Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World2Anchor_1,
                    MapSelectPM.World2Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World3Anchor_1,
                    MapSelectPM.World3Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World4Anchor_1,
                    MapSelectPM.World4Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World5Anchor_1,
                    MapSelectPM.World5Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World6Anchor_1,
                    MapSelectPM.World6Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World7Anchor_1,
                    MapSelectPM.World7Anchor_2
                }
            };
            PixelMapping[][] array = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World1Stage1,
                    MapSelectPM.World1Stage2,
                    MapSelectPM.World1Stage3,
                    MapSelectPM.World1Stage4,
                    MapSelectPM.World1Stage5,
                    MapSelectPM.World1Stage6,
                    MapSelectPM.World1Stage7,
                    MapSelectPM.World1Stage8,
                    MapSelectPM.World1Stage9,
                    MapSelectPM.World1Stage10
                },
                new PixelMapping[]
                {
                    MapSelectPM.World2Stage1,
                    MapSelectPM.World2Stage2,
                    MapSelectPM.World2Stage3,
                    MapSelectPM.World2Stage4,
                    MapSelectPM.World2Stage5,
                    MapSelectPM.World2Stage6,
                    MapSelectPM.World2Stage7,
                    MapSelectPM.World2Stage8,
                    MapSelectPM.World2Stage9,
                    MapSelectPM.World2Stage10
                },
                new PixelMapping[]
                {
                    MapSelectPM.World3Stage1,
                    MapSelectPM.World3Stage2,
                    MapSelectPM.World3Stage3,
                    MapSelectPM.World3Stage4,
                    MapSelectPM.World3Stage5,
                    MapSelectPM.World3Stage6,
                    MapSelectPM.World3Stage7,
                    MapSelectPM.World3Stage8,
                    MapSelectPM.World3Stage9,
                    MapSelectPM.World3Stage10
                },
                new PixelMapping[]
                {
                    MapSelectPM.World4Stage1,
                    MapSelectPM.World4Stage2,
                    MapSelectPM.World4Stage3,
                    MapSelectPM.World4Stage4,
                    MapSelectPM.World4Stage5,
                    MapSelectPM.World4Stage6,
                    MapSelectPM.World4Stage7,
                    MapSelectPM.World4Stage8,
                    MapSelectPM.World4Stage9,
                    MapSelectPM.World4Stage10
                },
                new PixelMapping[]
                {
                    MapSelectPM.World5Stage1,
                    MapSelectPM.World5Stage2,
                    MapSelectPM.World5Stage3,
                    MapSelectPM.World5Stage4,
                    MapSelectPM.World5Stage5,
                    MapSelectPM.World5Stage6,
                    MapSelectPM.World5Stage7,
                    MapSelectPM.World5Stage8,
                    MapSelectPM.World5Stage9,
                    MapSelectPM.World5Stage10
                },
                new PixelMapping[]
                {
                    MapSelectPM.World6Stage1,
                    MapSelectPM.World6Stage2,
                    MapSelectPM.World6Stage3,
                    MapSelectPM.World6Stage4,
                    MapSelectPM.World6Stage5,
                    MapSelectPM.World6Stage6,
                    MapSelectPM.World6Stage7,
                    MapSelectPM.World6Stage8,
                    MapSelectPM.World6Stage9,
                    MapSelectPM.World6Stage10
                },
                new PixelMapping[]
                {
                    MapSelectPM.World7Stage1,
                    MapSelectPM.World7Stage2,
                    MapSelectPM.World7Stage3,
                    MapSelectPM.World7Stage4,
                    MapSelectPM.World7Stage5,
                    MapSelectPM.World7Stage6,
                    MapSelectPM.World7Stage7,
                    MapSelectPM.World7Stage8,
                    MapSelectPM.World7Stage9,
                    MapSelectPM.World7Stage10
                }
            };
            if (world == World.None)
            {
                WeightedClick(MapSelectPM.BtnBottom3, 1.0, 1.0, 1, 0, "left");
                return;
            }
            int num = world - World.MysticWoods;
            PixelMapping stageMapping = array[num][stage];
            SelectStage(anchorMappings, stageMapping, num, false);
        }

        private void SelectStageAisha(World world, int stage)
        {
            PixelMapping[][] array = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World8_1Anchor_1,
                    MapSelectPM.World8_1Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World8_3Anchor_1,
                    MapSelectPM.World8_3Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World8_4Anchor_1,
                    MapSelectPM.World8_4Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World9_1Anchor_1,
                    MapSelectPM.World9_1Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World9_2Anchor_1,
                    MapSelectPM.World9_2Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World9_3Anchor_1,
                    MapSelectPM.World9_3Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World10_1Anchor_1,
                    MapSelectPM.World10_1Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World10_2Anchor_1,
                    MapSelectPM.World10_2Anchor_2
                }
            };
            PixelMapping[][] stages = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World8_1Stage1,
                    MapSelectPM.World8_1Stage2,
                    MapSelectPM.World8_1Stage3,
                    MapSelectPM.World8_1Stage4,
                    MapSelectPM.World8_1Stage5,
                    MapSelectPM.World8_2Stage6,
                    MapSelectPM.World8_2Stage7,
                    MapSelectPM.World8_2Stage8,
                    MapSelectPM.World8_2Stage9,
                    MapSelectPM.World8_2Stage10,
                    MapSelectPM.World8_3Stage11,
                    MapSelectPM.World8_3Stage12,
                    MapSelectPM.World8_3Stage13,
                    MapSelectPM.World8_3Stage14,
                    MapSelectPM.World8_3Stage15,
                    MapSelectPM.World8_4Stage16,
                    MapSelectPM.World8_4Stage17,
                    MapSelectPM.World8_4Stage18,
                    MapSelectPM.World8_4Stage19,
                    MapSelectPM.World8_4Stage20,
                },
                new PixelMapping[]
                {
                    MapSelectPM.World9_1Stage1,
                    MapSelectPM.World9_1Stage2,
                    MapSelectPM.World9_1Stage3,
                    MapSelectPM.World9_1Stage4,
                    MapSelectPM.World9_1Stage5,
                    MapSelectPM.World9_2Stage6,
                    MapSelectPM.World9_2Stage7,
                    MapSelectPM.World9_2Stage8,
                    MapSelectPM.World9_2Stage9,
                    MapSelectPM.World9_2Stage10,
                    MapSelectPM.World9_3Stage11,
                    MapSelectPM.World9_3Stage12,
                    MapSelectPM.World9_3Stage13,
                    MapSelectPM.World9_3Stage14,
                    MapSelectPM.World9_3Stage15
                },
                new PixelMapping[]
                {
                    MapSelectPM.World10_1Stage1,
                    MapSelectPM.World10_1Stage2,
                    MapSelectPM.World10_1Stage3,
                    MapSelectPM.World10_1Stage4,
                    MapSelectPM.World10_1Stage5,
                    MapSelectPM.World10_2Stage6,
                    MapSelectPM.World10_2Stage7,
                    MapSelectPM.World10_2Stage8,
                    MapSelectPM.World10_2Stage9,
                    MapSelectPM.World10_2Stage10
                }
            };
            int pageDestIndex = array.Length + 1;
            if (world == World.None)
            {
                WeightedClick(MapSelectPM.BtnBottom2, 1.0, 1.0, 1, 0, "left");
                return;
            }
            PixelMapping stageMapping;
            if (world == World.MoonlitIsle)
            {
                stageMapping = stages[0][stage];
                if (stage < 10)
                {
                    pageDestIndex = 0;
                }
                else if (stage < 15)
                {
                    pageDestIndex = 1;
                }
                else if (stage < 20)
                {
                    pageDestIndex = 2;
                }
            }
            else if (world == World.WesternEmpire)
            {
                stageMapping = stages[1][stage];
                if (stage < 5)
                {
                    pageDestIndex = 4;
                }
                else if (stage < 10)
                {
                    pageDestIndex = 5;
                }
                else if (stage < 15)
                {
                    pageDestIndex = 6;
                }
            }
            else if (world == World.EasternEmpire)
            {
                stageMapping = stages[2][stage];
                if (stage < 5)
                {
                    pageDestIndex = 7;
                }
                else if (stage < 10)
                {
                    pageDestIndex = 8;
                }
            }
            else
            {
                return;
            }
            SelectStage(array, stageMapping, pageDestIndex, true);
        }
        private void SelectStageDarkSanctuary(World world, int stage)
        {
            PixelMapping[][] anchorMappings = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World11_1Anchor_1,
                    MapSelectPM.World11_1Anchor_2
                }
            };
            PixelMapping[][] array = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World11_1Stage1,
                    MapSelectPM.World11_1Stage2,
                    MapSelectPM.World11_1Stage3,
                    MapSelectPM.World11_1Stage4,
                    MapSelectPM.World11_1Stage5,
                    MapSelectPM.World11_2Stage1,
                    MapSelectPM.World11_2Stage2,
                    MapSelectPM.World11_2Stage3,
                    MapSelectPM.World11_2Stage4,
                    MapSelectPM.World11_2Stage5,
                }
            };
            if (world == World.None)
            {
                WeightedClick(MapSelectPM.BtnBottom3, 1.0, 1.0, 1, 0, "left");
                return;
            }
            int num = world - World.DarkSanctuary;
            PixelMapping stageMapping = array[num][stage];
            SelectStage(anchorMappings, stageMapping, num, true);
        }
        private void SelectStageShadowsEye(World world, int stage)
        {
            PixelMapping[][] anchorMappings = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World12_1Anchor_1,
                    MapSelectPM.World12_1Anchor_2
                }
            };
            PixelMapping[][] array = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World12_1Stage1,
                    MapSelectPM.World12_1Stage2,
                    MapSelectPM.World12_1Stage3,
                    MapSelectPM.World12_1Stage4,
                    MapSelectPM.World12_1Stage5,
                    MapSelectPM.World12_1Stage6,
                    MapSelectPM.World12_1Stage7,
                    MapSelectPM.World12_1Stage8,
                    MapSelectPM.World12_1Stage9,
                    MapSelectPM.World12_1Stage10
                }
            };
            if (world == World.None)
            {
                WeightedClick(MapSelectPM.BtnBottom3, 1.0, 1.0, 1, 0, "left");
                return;
            }
            int num = world - World.ShadowsEye;
            PixelMapping stageMapping = array[num][stage];
            SelectStage(anchorMappings, stageMapping, num, true);
        }

        private void SelectStageHeavenlyStairs(World world, int stage)
        {
            PixelMapping[][] anchorMappings = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World13_1Anchor_1,
                    MapSelectPM.World13_1Anchor_2
                }
            };
            PixelMapping[][] array = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    MapSelectPM.World13_1Stage1,
                    MapSelectPM.World13_1Stage2,
                    MapSelectPM.World13_1Stage3,
                    MapSelectPM.World13_1Stage4,
                    MapSelectPM.World13_1Stage5,
                    MapSelectPM.World13_1Stage6,
                    MapSelectPM.World13_1Stage7,
                    MapSelectPM.World13_1Stage8,
                    MapSelectPM.World13_1Stage9,
                    MapSelectPM.World13_1Stage10
                }
            };
            if (world == World.None)
            {
                WeightedClick(MapSelectPM.BtnBottom2, 1.0, 1.0, 1, 0, "left");
                return;
            }
            int num = world - World.HeavenlyStairs;
            PixelMapping stageMapping = array[num][stage];
            SelectStage(anchorMappings, stageMapping, num, true);
        }

        private void SelectTeam(SceneType sceneType, World world)
        {
            Team team = Team.None;
            PixelMapping[] array = new PixelMapping[]
            {
                SharedPM.PrepareFight_TeamAButton,
                SharedPM.PrepareFight_TeamBButton,
                SharedPM.PrepareFight_TeamCButton
            };
            if (sceneType == SceneType.ADVENTURE_START)
            {
                team = AISettings.AD_Team;
            }
            if (team == Team.None)
            {
                return;
            }
            WeightedClick(array[team - Team.A], 1.0, 1.0, 1, 0, "left");
            SevenKnightsCore.Sleep(1000);
        }

        private void SelectTeamHero()
        {
            Team team = Team.None;
            PixelMapping[] array = new PixelMapping[]
            {
                HeroesPM.TeamAButton,
                HeroesPM.TeamBButton,
                HeroesPM.TeamCButton
            };
            team = AISettings.AD_Team;
            if (team == Team.None)
            {
                return;
            }
            WeightedClick(array[team - Team.A], 1.0, 1.0, 1, 0, "left");
            SevenKnightsCore.Sleep(1000);
        }

        private void FuseHeroes()
        {
            Log("Start Fuse heroes", COLOR_FUSE);
            SendTelegram("[Auto Bulk Fusion] bot starting to fuse your heroes");
            int num3 = 0;
            bool fusedone = false;
            while (num3 < 100 && !Worker.CancellationPending)
            {
                CaptureFrame();
                if (ExpectingScene(SceneType.FUSE_SUCCESS, 5, 500))
                {
                    this.Escape();
                }
                else if (ExpectingScene(SceneType.LOBBY, 3, 500))
                {
                    this.WeightedClick(LobbyPM.HeroButton, 1.0, 1.0, 1, 0, "left");
                }
                else
                {
                    if (ExpectingScene(SceneType.HEROES, 15, 1000))
                    {
                        if (fusedone)
                        {
                            fusedone = false;
                        }
                        if (!fusedone)
                        {
                            SevenKnightsCore.Sleep(500);
                            WeightedClick(HeroesPM.BulkFuseBtn, 1.0, 1.0, 1, 0, "left");
                            if (ExpectingScene(SceneType.FUSE_LOBBY, 15, 1000))
                            {
                                CaptureFrame();
                                if ((MatchMapping(FuseLobbyPM.OnlyLvl30Off, 2) || !MatchMapping(FuseLobbyPM.OnlyLvl30On, 2)) && AISettings.BF_OnlyLv30)
                                {
                                    WeightedClick(FuseLobbyPM.OnlyLvl30Btn, 1.0, 1.0, 1, 0, "left");
                                }
                                SevenKnightsCore.Sleep(750);
                                WeightedClick(FuseLobbyPM.RegAllBtn, 1.0, 1.0, 1, 0, "left");
                                SevenKnightsCore.Sleep(750);
                                CaptureFrame();
                                if (!MatchMapping(FuseLobbyPM.FirstEmpty, 5) || !MatchMapping(FuseLobbyPM.FirstEmpty_2, 3))
                                {
                                    Log("Found Hero to Fuse", COLOR_FUSE);
                                    WeightedClick(FuseLobbyPM.FuseBtn, 1.0, 1.0, 1, 0, "left");
                                    if (ExpectingScene(SceneType.FUSE_CONFIRM, 15, 1000))
                                    {
                                        Sleep(1000);
                                        WeightedClick(FuseConfirmPM.OKbtn, 1.0, 1.0, 1, 0, "left");
                                        SevenKnightsCore.Sleep(4800);
                                        this.Escape();
                                        SevenKnightsCore.Sleep(1500);
                                        Log("Fuse Success", COLOR_FUSE);
                                        num3++;
                                        fusedone = true;
                                    }
                                }
                                else
                                {
                                    Log("Not Have hero to Fuse", COLOR_FUSE);
                                    DoneFuseHeroes();
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void PowerUpHeroes()
        {
            PixelMapping[] array2 = new PixelMapping[] {
               HeroesPM.HeroCard1,
               HeroesPM.HeroCard2,
               HeroesPM.HeroCard3,
               HeroesPM.HeroCard4,
               HeroesPM.HeroCard5,
               HeroesPM.HeroCard6,
               HeroesPM.HeroCard7,
               HeroesPM.HeroCard8,
               HeroesPM.HeroCard9,
               HeroesPM.HeroCard10
             };
            PixelMapping[] array = new PixelMapping[] {
               PowerUpLobbyPM.PowerUp1StarBtn, //0  
               PowerUpLobbyPM.PowerUp2StarBtn, //1
               PowerUpLobbyPM.PowerUp3StarBtn, //2
               PowerUpLobbyPM.PowerUp4StarBtn //3
             };
            string[] array3 = new string[] {
              "1 Star Hero",
              "2 Star Hero",
              "3 Star Hero",
              "4 Star Hero"
             };
            if (CurrentObjective == Objective.POWER_UP_HEROES)
            {
                Log("Start powering up heroes", COLOR_POWER_UP);
                SendTelegram("[Auto Power Up] bot starting to powering up your heroes.");
                ScrollHeroCards(false);
                SevenKnightsCore.Sleep(1000);
                if (!MatchMapping(HeroesPM.SortByBoxExpanded, 2))
                {
                    WeightedClick(HeroesPM.SortByBox, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(1500);
                }
                WeightedClick(HeroesPM.SortByNormal, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1500);
                if (!MatchMapping(HeroesPM.SortButtonAscending, 2))
                {
                    WeightedClick(HeroesPM.SortButton, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(1000);
                }
                bool powerupdone = false;
                int herostar = 0;
                int heroclicked = 0;
                int num3 = 0;
                int materials = 0;
                int onlylv30material = 0; //bool
                int onlylv30heroes = 0; //bool
                int order = 0;
                int isenable = 0;
                bool skipstar = false;
                int skipto = 0;
                int powerupsuccess = 0;
                while (num3 < 100 && !Worker.CancellationPending)
                {
                    if (ExpectingScene(SceneType.HEROES, 15, 1000))
                    {
                        if (powerupdone)
                        {
                            powerupdone = false;
                        }
                        if (heroclicked == 10)
                        {
                            heroclicked = 0;
                            ScrollHeroCards(true);
                            Sleep(1000);
                        }
                        if (!powerupdone)
                        {
                            int searchStar = CheckHeroFrameStar(heroclicked);
                            if (searchStar == 99)
                            {
                                Log("Fina,Leah,Cake Hero. Next hero", COLOR_POWER_UP);
                                heroclicked++;
                                num3++;
                                continue;
                            }
                            else
                            {
                                if (skipstar == true && searchStar != skipto)
                                {
                                    heroclicked++;
                                    num3++;
                                    continue;
                                }
                                else
                                {
                                    skipstar = false;
                                    int[] result = CheckPowerUpCondition(searchStar);
                                    onlylv30material = result[1];
                                    isenable = result[0];
                                    order = result[3];
                                    materials = result[2];
                                    int condition = result[4];
                                    onlylv30heroes = result[5];
                                    if (isenable == 0)
                                    {
                                        if (searchStar >= 3 && !AISettings.PU_3Star)
                                        {
                                            Log("Hero doesn't meet requirement, Done Powering up heroes", COLOR_POWER_UP);
                                            DonePowerUpHeroes(powerupsuccess);
                                            return;
                                        }
                                        else
                                        {
                                            heroclicked++;
                                            num3++;
                                            Sleep(500);
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        WeightedClick(array2[heroclicked], 1.0, 1.0, 1, 0, "left");
                                        List<SceneType> list = new List<SceneType>
                                        {
                                            SceneType.HERO_JOIN,
                                            SceneType.HERO_REMOVE
                                        };
                                        if (ExpectingScenes(list, 15, 1000))
                                        {
                                            CaptureFrame();
                                            if (!MatchMapping(SharedPM.Hero_RankUpButton, 3) && MatchMapping(SharedPM.Hero_PowerUpButton))
                                            {
                                                CaptureFrame();
                                                if ((MatchMapping(SharedPM.Hero_UnLocked, 5) || !MatchMapping(SharedPM.Hero_Locked, 3)))
                                                {
                                                    Sleep(500);
                                                    WeightedClick(SharedPM.Hero_PowerUpButton, 1.0, 1.0, 1, 0, "left");
                                                    if (ExpectingScene(SceneType.POWER_UP_LOBBY, 15, 1000))
                                                    {
                                                        CaptureFrame();
                                                        if (MatchMapping(PowerUpLobbyPM.OnlyLevel30Off, 2) && onlylv30material == 1)
                                                        {
                                                            WeightedClick(PowerUpLobbyPM.OnlyLevel30Btn, 1.0, 1.0, 1, 0, "left");
                                                            Sleep(1000);
                                                        }
                                                        if (isenable == 1) //prepare for powerup target in mainform
                                                        {
                                                            switch (condition)
                                                            {
                                                                case 0:
                                                                    int i = materials - 1;
                                                                    Log("Powering up using " + array3[i], COLOR_POWER_UP);
                                                                    WeightedClick(array[i], 1.0, 1.0, 1, 0, "left");
                                                                    Sleep(750);
                                                                    break;
                                                                case 1:
                                                                    if (order == 0) // <= ASCENDING
                                                                    {
                                                                        int i2 = 0;
                                                                        for (i2 = 0; i2 <= materials - 1; i2++)
                                                                        {
                                                                            Log("Powering up using " + array3[i2], COLOR_POWER_UP);
                                                                            WeightedClick(array[i2], 1.0, 1.0, 1, 0, "left");
                                                                            Sleep(750);
                                                                            CaptureFrame();
                                                                            if (ParsePowerUpCount())
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (order == 1) // <= DESCENDING
                                                                    {
                                                                        for (int i2 = materials-1; i2 >= 0; i2--)
                                                                        {
                                                                            Log("Powering up using " + array3[i2], COLOR_POWER_UP);
                                                                            WeightedClick(array[i2], 1.0, 1.0, 1, 0, "left");
                                                                            Sleep(750);
                                                                            CaptureFrame();
                                                                            if (ParsePowerUpCount())
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    break;
                                                                case 2:
                                                                    if (order == 0)
                                                                    {
                                                                        int i3 = materials - 1; //1,2,3,4
                                                                        for(i3=materials-1;i3<4;i3++)
                                                                        {
                                                                            Log("Powering up using " + array3[i3], COLOR_POWER_UP);
                                                                            WeightedClick(array[i3], 1.0, 1.0, 1, 0, "left");
                                                                            Sleep(750);
                                                                            CaptureFrame();
                                                                            if (ParsePowerUpCount())
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    else if (order == 1)
                                                                    {
                                                                        int i3 = materials - 1; //1,2,3,4
                                                                        for (i3 = array3.Length-1; i3 >= materials - 1; i3--)
                                                                        {
                                                                            Log("Powering up using " + array3[i3], COLOR_POWER_UP);
                                                                            WeightedClick(array[i3], 1.0, 1.0, 1, 0, "left");
                                                                            Sleep(750);
                                                                            CaptureFrame();
                                                                            if (ParsePowerUpCount())
                                                                            {
                                                                                break;
                                                                            }
                                                                        }
                                                                    }
                                                                    break;
                                                            }
                                                            Sleep(750);
                                                            CaptureFrame();
                                                            if (ParsePowerUpCount())
                                                            {
                                                                Sleep(500);
                                                                WeightedClick(PowerUpLobbyPM.PowerUpStartBtn, 1.0, 1.0, 1, 0, "left");
                                                                Sleep(500);
                                                                if (ExpectingScene(SceneType.POWER_UP_CONFIRM, 15, 1000))
                                                                {
                                                                    WeightedClick(PowerUpConfirmPM.OKbtn, 1.0, 1.0, 1, 0, "left");
                                                                    Sleep(2700);
                                                                    if (ExpectingScene(SceneType.POWER_UP_SUCCESS, 15, 1000))
                                                                    {
                                                                        Log("Powering up hero success", COLOR_POWER_UP);
                                                                        WeightedClick(PowerUpSuccessPM.TapArea, 1.0, 1.0, 1, 0, "left");
                                                                        Sleep(1000);
                                                                        powerupsuccess++;
                                                                        powerupdone = true;
                                                                        num3++;
                                                                        Escape();
                                                                        continue;
                                                                    }
                                                                }
                                                                else if (ExpectingScene(SceneType.POWER_UP_FAILED_POPUP))
                                                                {
                                                                    Log("Not Enough Gold, Done Powering Up Heroes", COLOR_POWER_UP);
                                                                    Sleep(500);
                                                                    WeightedClick(PowerUpFailedPopupPM.NoBtn, 1.0, 1.0, 1, 0, "left");
                                                                    Sleep(750);
                                                                    Escape();
                                                                    Sleep(750);
                                                                    Escape();
                                                                    Sleep(750);
                                                                    Escape();
                                                                    Sleep(750);
                                                                    DonePowerUpHeroes(powerupsuccess);
                                                                    return;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (searchStar <= 3)
                                                                {
                                                                    if (searchStar == 1 && !AISettings.PU_2Star && !AISettings.PU_3Star)
                                                                    {
                                                                        Log("Material Heroes Not Enough, Done Powering Up Heroes", COLOR_POWER_UP);
                                                                        DonePowerUpHeroes(powerupsuccess);
                                                                        return;
                                                                    }
                                                                    else if (searchStar == 1 && (AISettings.PU_2Star || AISettings.PU_3Star))
                                                                    {
                                                                        skipstar = true;
                                                                        if (AISettings.PU_2Star)
                                                                        {
                                                                            skipto = 2;
                                                                        }
                                                                        else if (AISettings.PU_3Star)
                                                                        {
                                                                            skipto = 3;
                                                                        }
                                                                    }
                                                                    else if (searchStar == 2)
                                                                    {
                                                                        skipstar = true;
                                                                        if (AISettings.PU_3Star)
                                                                        {
                                                                            skipto = 3;
                                                                        }
                                                                        else
                                                                        {
                                                                            Log("Material Heroes Not Enough, Done Powering Up Heroes", COLOR_POWER_UP);
                                                                            DonePowerUpHeroes(powerupsuccess);
                                                                            return;
                                                                        }
                                                                    }
                                                                    else if (searchStar == 3)
                                                                    {
                                                                        Log("Material Heroes Not Enough, Done Powering Up Heroes", COLOR_POWER_UP);
                                                                        DonePowerUpHeroes(powerupsuccess);
                                                                        return;
                                                                    }
                                                                    heroclicked++;
                                                                    Log("Material Heroes Not Enough, next hero", COLOR_POWER_UP);
                                                                    Escape();
                                                                    Sleep(1000);
                                                                    Escape();
                                                                    Sleep(1000);
                                                                    num3++;
                                                                }
                                                                else
                                                                {
                                                                    Log("Material Heroes Not Enough, done powering up heroes", COLOR_POWER_UP);
                                                                    DonePowerUpHeroes(powerupsuccess);
                                                                    return;
                                                                }
                                                            }
                                                            Sleep(1200);
                                                        }
                                                        else if (isenable == 0 && herostar <= 3)
                                                        {
                                                            heroclicked++;
                                                            Log("Hero doesn't meet condition, next hero", COLOR_POWER_UP);
                                                            Escape();
                                                            Sleep(1200);
                                                            Escape();
                                                            Sleep(1200);
                                                            num3++;
                                                            continue;
                                                        }
                                                        else
                                                        {
                                                            Log("Hero doesn't meet condition, Power Up Finish", COLOR_POWER_UP);
                                                            DonePowerUpHeroes(powerupsuccess);
                                                            return;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Log("Scene Error, Not PowerUpLobby", COLOR_POWER_UP);
                                                        Escape();
                                                        Sleep(750);
                                                        Escape();
                                                    }
                                                }
                                                else
                                                {
                                                    Log("Fina,Leah,Cake Hero. Next hero", COLOR_POWER_UP);
                                                    Escape();
                                                    Sleep(750);
                                                    heroclicked++;
                                                    num3++;
                                                    continue;
                                                    
                                                }
                                            }
                                            else
                                            {
                                                Log("Hero Already +5, next hero", COLOR_POWER_UP);
                                                Escape();
                                                Sleep(750);
                                                heroclicked++;
                                                num3++;
                                                continue;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Log("Scene Error, Not in Heroes");
                        Escape();
                    }
                }
            }
        }

        private int[] CheckPowerUpCondition(int star)
        {
            bool[] heropowerup = new bool[]
            {
                AISettings.PU_1Star,
                AISettings.PU_2Star,
                AISettings.PU_3Star,
                AISettings.PU_4Star
            };
            bool[] onlylv30materials = new bool[]
            {
                AISettings.PU_1MOnlyLv30,
                AISettings.PU_2MOnlyLv30,
                AISettings.PU_3MOnlyLv30,
                AISettings.PU_4MOnlyLv30
            };
            /*
             * 1 = 1 Star
             * 2 <= 2 Star
             * 3 <= 3 Star
             * 4 <= 4 Star
             */
            int[] materials = new int[]
            {
                AISettings.PU_1Material, //1 2 3 4
                AISettings.PU_2Material,
                AISettings.PU_3Material,
                AISettings.PU_4Material,
            };
            int[] condition = new int[]
            {
                AISettings.PU_1Condition,
                AISettings.PU_2Condition,
                AISettings.PU_3Condition,
            };
            bool[] onlylvl30heroes = new bool[]
            {
                AISettings.PU_1OnlyLv30,
                AISettings.PU_2OnlyLv30,
                AISettings.PU_3OnlyLv30,
            };
            /*
             * result[0] == enable/disable powerup hero x star
             * result[1] == enable/disable powerup only using lv 30 materials
             * result[2] == materials hero star
             * result[3] == order
             * result[4] == condition materials == , <= , >=
             * result[5] == enable/disable powerup only using lv 30 heroes
             */

            int[] result = new int[6];
            if (star == 1)
            {
                if (heropowerup[0] == true)
                {
                    result[0] = 1;
                    result[3] = AISettings.PU_1Order;
                    if (onlylv30materials[0] == true)
                    {
                        result[1] = 1;
                        result[2] = materials[0];
                        result[4] = condition[0];
                    }
                    else
                    {
                        result[1] = 0;
                        result[2] = materials[0];
                        result[4] = condition[0];
                    }
                    if (onlylvl30heroes[0] == true)
                    {
                        result[5] = 1;
                    }
                    else
                    {
                        result[5] = 0;
                    }
                }
                else
                {
                    result[0] = 0;
                    result[1] = 0;
                    result[2] = 0;
                    result[3] = 0;
                    result[4] = 0;
                    result[5] = 0;
                }
            }
            else if (star == 2)
            {
                result[3] = 1;
                if (heropowerup[1] == true)
                {
                    result[0] = 1;
                    result[3] = AISettings.PU_2Order;
                    if (onlylv30materials[1] == true)
                    {
                        result[1] = 1;
                        result[2] = materials[1];
                        result[4] = condition[1];
                    }
                    else
                    {
                        result[1] = 0;
                        result[4] = condition[1];
                    }
                    if (onlylvl30heroes[0] == true)
                    {
                        result[5] = 1;
                    }
                    else
                    {
                        result[5] = 0;
                    }
                }
                else
                {
                    result[0] = 0;
                    result[1] = 0;
                    result[2] = 0;
                    result[3] = 0;
                    result[4] = 0;
                    result[5] = 0;
                }
            }
            else if (star == 3)
            {
                result[3] = 1;
                if (heropowerup[2] == true)
                {
                    result[0] = 1;
                    result[3] = AISettings.PU_3Order;
                    if (onlylv30materials[2] == true)
                    {
                        result[1] = 1;
                        result[2] = materials[2];
                        result[4] = condition[2];
                    }
                    else
                    {
                        result[1] = 0;
                        result[4] = condition[2];
                    }
                    if (onlylvl30heroes[0] == true)
                    {
                        result[5] = 1;
                    }
                    else
                    {
                        result[5] = 0;
                    }
                }
            }
            else
            {
                result[0] = 0;
                result[1] = 0;
                result[2] = 0;
                result[3] = 0;
                result[4] = 0;
                result[5] = 0;
            }
            return result;
        }

        private int CheckHeroFrameStar(int hero)
        {
            Rectangle[] heroFrame = new Rectangle[]
            {
                HeroesPM.HeroCard1Frame,
                HeroesPM.HeroCard2Frame,
                HeroesPM.HeroCard3Frame,
                HeroesPM.HeroCard4Frame,
                HeroesPM.HeroCard5Frame,
                HeroesPM.HeroCard6Frame,
                HeroesPM.HeroCard7Frame,
                HeroesPM.HeroCard8Frame,
                HeroesPM.HeroCard9Frame,
                HeroesPM.HeroCard10Frame
            };
            string[] imgStarPath = new string[]
            {
                "img/1star.png",
                "img/2star.png",
                "img/3star.png",
                "img/4star.png",
                "img/4star2.png",
                "img/4star3.png",
                "img/5star.png",
            };
            string lockPath = "img/lock.png";
            Bitmap bitmap = CropFrame(CaptureFrame(), heroFrame[hero]);
            bitmap.Save(@"heroFrame.png");
            if (ImageSearch.SearchBool(lockPath, @"heroFrame.png", 0.8))
            {
                return 99; //locked hero
            }
            else
            {
                int starfound = 0;
                if (ImageSearch.SearchBool(@imgStarPath[0], @"heroFrame.png", 0.8))
                {
                    starfound = 1;
                    Log("Found 1 Star Hero");
                    return starfound;
                }
                else if (ImageSearch.SearchBool(@imgStarPath[1], @"heroFrame.png", 0.8))
                {
                    Log("Found 2 Star Hero");
                    return 2;
                }
                else if (ImageSearch.SearchBool(@imgStarPath[2], @"heroFrame.png", 0.8))
                {
                    Log("Found 3 Star Hero");
                    return 3;
                }
                else if (ImageSearch.SearchBool(@imgStarPath[3], @"heroFrame.png", 0.8) || ImageSearch.SearchBool(@imgStarPath[4], @"heroFrame.png", 0.8) || ImageSearch.SearchBool(@imgStarPath[5], @"heroFrame.png", 0.8))
                {
                    Log("Found 4 Star Hero");
                    return 4;
                }
                else if (ImageSearch.SearchBool(@imgStarPath[6], @"heroFrame.png", 0.8))
                {
                    Log("Found 5 Star Hero");
                    return 5;
                }
                else
                {
                    Log("Found 6 Star Hero");
                    return 6;
                }
            }
        }

        private void SellHeroes()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                SellHeroConfirmPopupPM.Star1,
                SellHeroConfirmPopupPM.Star2,
                SellHeroConfirmPopupPM.Star3,
                SellHeroConfirmPopupPM.Star4,
                SellHeroConfirmPopupPM.Star5,
                SellHeroConfirmPopupPM.Star6
            };
            PixelMapping[] array2 = new PixelMapping[]
            {
                HeroesPM.HeroCard1,
                HeroesPM.HeroCard2,
                HeroesPM.HeroCard3,
                HeroesPM.HeroCard4,
                HeroesPM.HeroCard5,
                HeroesPM.HeroCard6,
                HeroesPM.HeroCard7,
                HeroesPM.HeroCard8,
                HeroesPM.HeroCard9,
                HeroesPM.HeroCard10
            };
            PixelMapping[][] array3 = new PixelMapping[][]
            {
                new PixelMapping[]
                {
                    SellHeroConfirmPopupPM.ElementWater_1,
                    SellHeroConfirmPopupPM.ElementWater_2,
                    SellHeroConfirmPopupPM.ElementWater_3
                },
                new PixelMapping[]
                {
                    SellHeroConfirmPopupPM.ElementFire_1,
                    SellHeroConfirmPopupPM.ElementFire_2,
                    SellHeroConfirmPopupPM.ElementFire_3
                },
                new PixelMapping[]
                {
                    SellHeroConfirmPopupPM.ElementLight_1,
                    SellHeroConfirmPopupPM.ElementLight_2,
                    SellHeroConfirmPopupPM.ElementLight_3
                },
                new PixelMapping[]
                {
                    SellHeroConfirmPopupPM.ElementDark_1,
                    SellHeroConfirmPopupPM.ElementDark_2,
                    SellHeroConfirmPopupPM.ElementDark_3
                },
                new PixelMapping[]
                {
                    SellHeroConfirmPopupPM.ElementRock_1,
                    SellHeroConfirmPopupPM.ElementRock_2,
                    SellHeroConfirmPopupPM.ElementRock_3
                }
            };
            Log("Start selling heroes", COLOR_SELL_HEROES);
            SendTelegram("Bot will only sell the hero if the given condition is met.");
            if (!MatchMapping(HeroesPM.SortByBoxExpanded, 2))
            {
                WeightedClick(HeroesPM.SortByBox, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(AIProfiles.ST_Delay);
            }
            WeightedClick(HeroesPM.SortByRank, 1.0, 1.0, 1, 0, "left");
            SevenKnightsCore.Sleep(AIProfiles.ST_Delay);
            if (!MatchMapping(HeroesPM.SortButtonAscending, 2))
            {
                WeightedClick(HeroesPM.SortButton, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(AIProfiles.ST_Delay);
            }
            ScrollHeroCards(false);
            SevenKnightsCore.Sleep(AIProfiles.ST_Delay);
            bool flag = false;
            int monstar = 0;
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            while (num3 < 100 && !Worker.CancellationPending)
            {
                CaptureFrame();
                Scene scene = SceneSearch();
                if (scene != null && scene.SceneType != SceneType.HEROES)
                {
                    Log("Stop Disini4");
                    DoneSellHeroes(-1);
                    return;
                }
                if (MatchMapping(HeroesPM.LastRow_1, 3) && MatchMapping(HeroesPM.LastRow_2, 3))
                {
                    flag = true;
                }
                if (!AISettings.RS_SellHeroAll && num2 >= AISettings.RS_SellHeroAmount)
                {
                    Log("Stop Disini3");
                    DoneSellHeroes(-1);
                    return;
                }
                /**************************************************************************************/
                if (MatchMapping(HeroStar.Star1Loca1, 2) || MatchMapping(HeroStar.Star1Loca2, 2)
                     || MatchMapping(HeroStar.Star1Loca3, 2) || MatchMapping(HeroStar.Star1Loca4, 2) || MatchMapping(HeroStar.Star1Loca5, 2)
                     || MatchMapping(HeroStar.Star1Loca6, 2) || MatchMapping(HeroStar.Star1Loca7, 2)
                     || MatchMapping(HeroStar.Star1Loca8, 2) || MatchMapping(HeroStar.Star1Loca9, 2) || MatchMapping(HeroStar.Star1Loca10, 2))
                {
                    monstar = 1;
                }
                else if (MatchMapping(HeroStar.Star2Loca1, 2) || MatchMapping(HeroStar.Star2Loca2, 2)
                     || MatchMapping(HeroStar.Star2Loca3, 2) || MatchMapping(HeroStar.Star2Loca4, 2) || MatchMapping(HeroStar.Star2Loca5, 2)
                     || MatchMapping(HeroStar.Star2Loca6, 2) || MatchMapping(HeroStar.Star2Loca7, 2)
                     || MatchMapping(HeroStar.Star2Loca8, 2) || MatchMapping(HeroStar.Star2Loca9, 2) || MatchMapping(HeroStar.Star2Loca10, 2)
                     || MatchMapping(HeroStar.Star2Loca1_2, 2) || MatchMapping(HeroStar.Star2Loca2_2, 2)
                     || MatchMapping(HeroStar.Star2Loca3_2, 2) || MatchMapping(HeroStar.Star2Loca4_2, 2) || MatchMapping(HeroStar.Star2Loca5_2, 2)
                     || MatchMapping(HeroStar.Star2Loca6_2, 2) || MatchMapping(HeroStar.Star2Loca7_2, 2)
                     || MatchMapping(HeroStar.Star2Loca8_2, 2) || MatchMapping(HeroStar.Star2Loca9_2, 2) || MatchMapping(HeroStar.Star2Loca10_2, 2))
                {
                    monstar = 2;
                }
                else
                {
                    monstar = 4;
                }

                if (monstar <= AISettings.RS_SellHeroStars)
                {
                    //ตรวจเวล 30
                    SevenKnightsCore.Sleep(500);
                    WeightedClick(array2[num], 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(AIProfiles.ST_Delay);
                    CaptureFrame();
                    scene = SceneSearch();
                    if (scene != null && scene.SceneType != SceneType.HERO_JOIN && scene.SceneType != SceneType.HERO_REMOVE)
                    {
                        Log("Stop Disini2");
                        DoneSellHeroes(-1);
                        return;
                    }
                    if (MatchMapping(HeroJoinPM.KeyLockButton, 2)
                           && MatchMapping(HeroJoinPM.SellButton, 2))
                    {
                        WeightedClick(HeroJoinPM.SellButton, 1.0, 1.0, 1, 0, "left");
                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);
                        WeightedClick(SellHeroConfirmPopupPM.SellLobbyButton, 1.0, 1.0, 1, 0, "left");
                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);
                        CaptureFrame();
                        scene = SceneSearch();
                        if (scene != null && scene.SceneType != SceneType.SELL_HERO_CONFIRM_POPUP)
                        {
                            Log("Stop Sell Hero.");
                            DoneSellHeroes(-1);
                            return;
                        }
                        PixelMapping[][] array4 = array3;
                        for (int j = 0; j < array4.Length; j++)
                        {
                            PixelMapping[] array5 = array4[j];
                            if (MatchMapping(array5[0], 5) && MatchMapping(array5[1], 5) && MatchMapping(array5[2], 5))
                            {
                                Log("-- Found element hero, skipping..", COLOR_SELL_HEROES);
                                WeightedClick(SellHeroConfirmPopupPM.NoButton, 1.0, 1.0, 1, 0, "left");
                                SevenKnightsCore.Sleep(AIProfiles.ST_Delay);
                                Escape();
                                SevenKnightsCore.Sleep(AIProfiles.ST_Delay);
                            }
                        }
                        num2++;
                        WeightedClick(SellHeroConfirmPopupPM.SellButton, 1.0, 1.0, 1, 0, "left");
                        int n = 1;
                        while (n <= 100)
                        {
                            SevenKnightsCore.Sleep(300);
                            CaptureFrame();
                            if (!MatchMapping(SellHeroConfirmPopupPM.SoldOKYellowTik, 2) && !MatchMapping(SellHeroConfirmPopupPM.SellButtonbg, 2))
                            {
                                n++;
                            }
                            else
                            {
                                n = 110;
                                SevenKnightsCore.Sleep(500);
                                WeightedClick(SellHeroConfirmPopupPM.SoldOKButton, 1.0, 1.0, 1, 0, "left");
                                SevenKnightsCore.Sleep(1000);
                                Log(string.Format("-- Hero sold ({0})", num2), COLOR_SELL_HEROES);
                                Escape();
                                SevenKnightsCore.Sleep(AIProfiles.ST_Delay);
                                DoneSellHeroesMini();
                            }
                        }
                    }
                    else
                    {
                        num = num + 1;
                        Escape();
                        SevenKnightsCore.Sleep(500);
                    }
                    if (!flag)
                    {
                        num %= 4;
                    }
                    if (num == 0)
                    {
                        ScrollHeroCards(true);
                        SevenKnightsCore.Sleep(800);
                    }
                    if (flag && num >= array2.Length)
                    {
                        Log("Stop Disini");
                        DoneSellHeroes(num2);
                        return;
                    }
                }
                else
                {
                    Log("Stop Disini1");
                    DoneSellHeroes(-1);
                    return;
                }
                num3++;
                continue;
            }
            return;
        }

        private void SellItems()
        {
            PixelMapping[] BulkButton = new PixelMapping[]
            {
                SellItemsLobbyPM.Star1,
                SellItemsLobbyPM.Star2,
                SellItemsLobbyPM.Star3,
                SellItemsLobbyPM.Star4,
                SellItemsLobbyPM.Star5,
                SellItemsLobbyPM.GoldOre
            };
            string[] array2 = new string[]
            {
                "1 Star Item",
                "2 Star Item",
                "3 Star Item",
                "4 Star Item",
                "5 Star Item",
                "Gold Ore"
            };
            int test = AISettings.RS_SellItemStars;
            Scene scene = SceneSearch();
            Log("Start selling items", COLOR_SELL_ITEMS);
            SendTelegram("Bot will selling items");
            List<int> list = new List<int>();
            for (int i = 0; i < test; i++)
            {
                list.Add(i);
            }
            if (list.Count <= 0)
            {
                Log("Nothing to do", COLOR_HONOR);
                DoneSellItems();
                return;
            }
            foreach (int current in list)
            {
                if (Worker.CancellationPending)
                {
                    return;
                }
                SevenKnightsCore.Sleep(500);
                Log(string.Format("Selling {0}", array2[current]), COLOR_HONOR);
                WeightedClick(SellItemsLobbyPM.BulkButton, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                PixelMapping mapping = BulkButton[current];
                WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                CaptureFrame();
                scene = SceneSearch();
                if (!MatchMapping(SellItemsLobbyPM.Item1Exist, 5) && !MatchMapping(SellItemsLobbyPM.Item2Exist, 5))
                {
                    Log("Item Exist", COLOR_HONOR);
                    WeightedClick(SellItemsLobbyPM.SellButton, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(1000);
                    CaptureFrame();
                    scene = SceneSearch();
                    if (ExpectingScene(SceneType.SELL_ITEM_CONFIRM_POPUP, 15, 1000)) // SELL_ITEM_CONFIRM_POPUP
                    {
                        WeightedClick(SellItemConfirmPopupPM.SellButton, 1.0, 1.0, 1, 0, "left");
                        SevenKnightsCore.Sleep(3000);
                        CaptureFrame();
                        scene = SceneSearch();
                        if (ExpectingScene(SceneType.SELL_ITEM_SUCCESS_POPUP, 10, 2000)) // SELL_ITEM_SUCCESS_POPUP
                        {
                            Escape();
                            SevenKnightsCore.Sleep(1000);
                        }
                    }
                }
                else
                {
                    Log(string.Format("{0} Doesn't Exists ", array2[current]), COLOR_HONOR);
                }
            }
            if (AISettings.RS_SellGoldOre)
            {
                SevenKnightsCore.Sleep(500);
                Log("Selling Gold Ore", COLOR_HONOR);
                WeightedClick(SellItemsLobbyPM.BulkButton, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                WeightedClick(BulkButton[5], 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                CaptureFrame();
                scene = SceneSearch();
                if (!MatchMapping(SellItemsLobbyPM.Item1Exist, 5) && !MatchMapping(SellItemsLobbyPM.Item2Exist, 5))
                {
                    Log("Gold Ore Exist", COLOR_HONOR);
                    WeightedClick(SellItemsLobbyPM.SellButton, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(1000);
                    CaptureFrame();
                    scene = SceneSearch();
                    if (ExpectingScene(SceneType.SELL_ITEM_CONFIRM_POPUP, 15, 1000)) // SELL_ITEM_CONFIRM_POPUP
                    {
                        WeightedClick(SellItemConfirmPopupPM.SellButton, 1.0, 1.0, 1, 0, "left");
                        SevenKnightsCore.Sleep(3000);
                        CaptureFrame();
                        scene = SceneSearch();
                        if (ExpectingScene(SceneType.SELL_ITEM_SUCCESS_POPUP, 10, 2000)) // SELL_ITEM_SUCCESS_POPUP
                        {
                            Escape();
                            SevenKnightsCore.Sleep(1000);
                        }
                    }
                }
                else
                {
                    Log("Gold Ore Doesn't Exist", COLOR_HONOR);
                }
            }
            DoneSellItems();
        }

        private void SendTelegram(string text)
        {
            if (AIProfiles.ST_EnableTelegram == true)
            {
                try
                {
                    bot.sendMessage.send(AIProfiles.ST_TelegramChatID, text);
                }
                catch (Exception ex)
                {
                    Log("Send Telegram Failed! : " + ex);
                }
            }
        }

        private bool IsHeroLevel30(bool retrying = false)
        {
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, SharedPM.Hero_R_Level_30))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Trim().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                        .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                        .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                        .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3");
                    Utility.FilterAscii(text);
                    if (text.Length >= 2)
                    {
                        int lvl = -1;
                        int maxLvl = 30;
                        string[] array = text.Split(new char[]
                            {
                                '/'
                            });

                        if (array.Length >= 1)
                        {
                            int.TryParse(array[0], out lvl);
                        }

                        if (array.Length >= 2)
                        {
                            int.TryParse(array[1].Substring(0, 2), out maxLvl);
                            if (maxLvl < 30)
                            {
                                maxLvl = 30;
                            }
                        }
                        this.Log(string.Format("Level: {0}/{1} String: {2}", lvl, maxLvl, text));
#if DEBUG
						this.Log(string.Format("Level: {0}/{1} String: {2}", lvl, maxLvl, text));
						bitmap.Save(string.Format("{0} of {1}.png", lvl, maxLvl));
#endif
                        if (lvl != maxLvl || lvl < 30)
                        {
                            return false;
                        }
                    }
                    else if (!retrying)
                    {
                        Sleep(1000);
                        IsHeroLevel30(true);
                    }
                }
            }
            return true;
        }

        private void UpdateHeroCount()
        {
            int curHero = HeroCount;
            int maxHero = HeroMax;
            Rectangle rect = HeroesPM.R_HeroCount;
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(200))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = ReplaceNumericResource(page.GetText());
                    Utility.FilterAscii(text);
                    //this.Log("Old Text: " + text);
                    if (text.Length >= 2)
                    {
                        string[] array = text.Split(new char[]
                            {
                                '/'
                            });

                        if (array.Length >= 1)
                        {
                            int.TryParse(array[0], out curHero);
                        }

                        if (array.Length >= 2)
                        {
                            int.TryParse(array[1], out maxHero);
                        }
                        Log(string.Format("HC: {0}/{1} String: {2}", curHero, maxHero, text.Trim()));
#if DEBUG
                        this.Log(string.Format("HC: {0}/{1} String: {2}", curHero, maxHero, text.Trim()));
                        bitmap.Save(string.Format("H_{0} of {1}.png", curHero, maxHero));
#endif
                    }
                    HeroCount = curHero;
                    HeroMax = maxHero;
                    if (curHero >= maxHero)
                    {
                        if (AISettings.RS_SellHeroes && CooldownSellHeroes <= 0)
                        {
                            Log("Heroes Full, Bot will Sell Heroes after check item slot");
                            herofull = true;
                            checkslothero = false;
                        }
                        else
                        {
                            Log("Heroes Full, Bot will check item slot");
                            checkslothero = false;
                            ChangeObjective(Objective.CHECK_SLOT_ITEM);
                        }
                    }
                    else
                    {
                        checkslothero = false;
                        ChangeObjective(Objective.CHECK_SLOT_ITEM);
                    }
                }
            }
        }

        private void CheckSoul(World w)
        {
            int curShard = 0;
            int maxShard = 1000;
            Rectangle rect;
            if (w >= World.MoonlitIsle)
            {
                rect = MapSelectPM.SoulShard_NAsgar;
            }
            else
            {
                rect = MapSelectPM.SoulShard_Asgar;
            }
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(200))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = ReplaceNumericResource(page.GetText().Trim().ToLower().Replace("1000i", "1000/").Replace("n000", "/1000").Replace(" ", "").Replace("|", ""));
                    Utility.FilterAscii(text);
                    if (text.Length >= 2)
                    {
                        string[] array = text.Split(new char[]
                            {
                                '/'
                            });

                        if (array.Length >= 1)
                        {
                            int.TryParse(array[0], out curShard);
                        }

                        if (array.Length >= 2)
                        {
                            int.TryParse(array[1], out maxShard);
                        }
                        SoulCount = curShard;
                        ReportResources(ResourceType.SOUL);
                        //Log(string.Format("Soul: {0}/{1} String: {2}", curShard, maxShard, text.Trim()));
#if DEBUG
                        this.Log(string.Format("HC: {0}/{1} String: {2}", curHero, maxHero, text.Trim()));
                        bitmap.Save(string.Format("H_{0} of {1}.png", curHero, maxHero));
#endif
                    }
                }
            }
        }

        private void UpdateItemCount()
        {
            int curItem = ItemCount;
            int maxItem = ItemMax;
            Rectangle rect = ItemsPM.R_ItemCount;
            CaptureFrame();
            using (Bitmap bitmap = CropFrame(BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(200))
            {
                using (Page page = Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = ReplaceNumericResource(page.GetText());
                    Utility.FilterAscii(text);
                    if (text.Length >= 2)
                    {
                        string[] array = text.Split(new char[]
                            {
                                '/'
                            });

                        if (array.Length >= 1)
                        {
                            int.TryParse(array[0], out curItem);
                        }

                        if (array.Length >= 2)
                        {
                            int.TryParse(array[1], out maxItem);
                        }
                    }
                    Log(string.Format("IC: {0}/{1} String: {2}", curItem, maxItem, text.Trim()));
                    ItemCount = curItem;
                    ItemMax = maxItem;
                    if (curItem >= maxItem)
                    {
                        if (AISettings.RS_SellItems)
                        {
                            Log("Items Full, Bot will Sell Items");
                            itemfull = true;
                            checkslotitem = false;
                        }
                        else
                        {
                            Log("Items Full");
                            itemfull = true;
                            checkslotitem = false;
                            if (AdventureLimitCount >= AISettings.AD_Limit)
                            {
                                Log("Limit reached [Adventure]", COLOR_LIMIT);
                                SendTelegram("Limit Reached [Adventure]");
                                AdventureLimitCount = 0;
                                IsAdventureLimit = true;
                                NextPossibleObjective();
                            }
                            else
                            {
                                ChangeObjective(Objective.ADVENTURE);
                            }
                        }
                    }
                    else
                    {
                        checkslotitem = false;
                        if (AdventureLimitCount >= AISettings.AD_Limit)
                        {
                            Log("Limit reached [Adventure]", COLOR_LIMIT);
                            SendTelegram("Limit Reached [Adventure]");
                            AdventureLimitCount = 0;
                            NextPossibleObjective();
                        }
                        else
                        {
                            ChangeObjective(Objective.ADVENTURE);
                        }
                    }
                }
            }
        }

        private void UpdateAdventureKeys(SceneType sceneType)
        {
            Dictionary<SceneType, Rectangle> dictionary = new Dictionary<SceneType, Rectangle>
            {
                {
                    SceneType.LOBBY,
                    LobbyPM.R_KeyNormalBase
                },
                {
                    SceneType.INBOX,
                    SharedPM.R_KeyNormalBase
                },
                {
                    SceneType.HEROES,
                    SharedPM.R_KeyNormalBase
                },
                {
                    SceneType.SHOP,
                    SharedPM.R_KeyNormalBase
                },
                {
                    SceneType.ADVENTURE_START,
                    SharedPM.R_KeyNormalBase
                },
                {
                    SceneType.MAP_SELECT,
                    SharedPM.R_KeyNormalBase
                }
            };
            Rectangle rect = dictionary[sceneType];
            int num = ParseAdventureKeys(rect);
            if (num != -1)
            {
                AdventureKeys = num;
                ReportKeys(Objective.ADVENTURE);
            }
        }

        private void UpdateArenaKeys()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                ArenaStartPM.Key_4, //0
                ArenaStartPM.Key_3, //1
                ArenaStartPM.Key_2, //2
                ArenaStartPM.Key_1, //3
                ArenaStartPM.Key_0, //4
            };
            int num = 5;
            for (int i = 0; i < 5; i++)
            {
                if (MatchMapping(array[i], 2))
                {
                    num -= 1;
                    //break;
                }
            }
            if (num != 0)
            {
                Log("Arena:" + num);
                ArenaKeys = num;
                ReportKeys(Objective.ARENA);
            }
        }

        private void UpdateGold(SceneType sceneType)
        {
            Dictionary<SceneType, Rectangle> dictionary = new Dictionary<SceneType, Rectangle>
            {
                {
                    SceneType.LOBBY,
                    LobbyPM.R_GoldBase
                },
                {
                    SceneType.INBOX,
                    SharedPM.R_GoldBase
                },
                {
                    SceneType.HEROES,
                    SharedPM.R_GoldBase
                },
                {
                    SceneType.SHOP,
                    SharedPM.R_GoldBase
                },
                {
                    SceneType.MAP_SELECT,
                    SharedPM.R_GoldBase
                },
                {
                    SceneType.ADVENTURE_START,
                    SharedPM.R_GoldBase
                },
                {
                    SceneType.BATTLE_MODES,
                   SharedPM.R_GoldBase
                }
            };
            Rectangle rect = dictionary[sceneType];
            int num = ParseGold(rect);
            if (num != -1)
            {
                GoldCount = num;
                ReportResources(ResourceType.GOLD);
            }
        }

        private void UpdateHangFingerprint()
        {
            if (PreviousFingerprint == null)
            {
                PreviousFingerprint = new int[50];
                CurrentFingerprint = new int[50];
            }
            CreateHangFingerprint(CurrentFingerprint);
            for (int i = 0; i < 50; i++)
            {
                if (PreviousFingerprint[i] != CurrentFingerprint[i])
                {
                    HangCounter = 0;
                }
            }
            CreateHangFingerprint(PreviousFingerprint);
        }

        private void UpdateHonor(SceneType sceneType)
        {
            Dictionary<SceneType, Rectangle> dictionary = new Dictionary<SceneType, Rectangle>
            {
                {
                    SceneType.LOBBY,
                    LobbyPM.R_HonorBase
                },
                {
                    SceneType.INBOX,
                    LobbyPM.R_HonorBase
                },
                {
                    SceneType.SHOP,
                    LobbyPM.R_HonorBase
                },
                {
                    SceneType.BATTLE_MODES,
                    LobbyPM.R_HonorBase
                },
                {
                    SceneType.ARENA_READY,
                    LobbyPM.R_HonorBase
                },
                {
                    SceneType.ARENA_START,
                    LobbyPM.R_HonorBase
                }
            };
            Rectangle rect = dictionary[sceneType];
            int num = ParseHonor(rect);
            if (num != -1)
            {
                HonorCount = num;
                ReportResources(ResourceType.HONOR);
            }
        }

        private void UpdateRuby(SceneType sceneType)
        {
            Dictionary<SceneType, Rectangle> dictionary = new Dictionary<SceneType, Rectangle>
            {
                {
                    SceneType.LOBBY,
                    LobbyPM.R_RubyBase
                },
                {
                    SceneType.INBOX,
                    SharedPM.R_RubyBase
                },
                {
                    SceneType.HEROES,
                    SharedPM.R_RubyBase
                },
                {
                    SceneType.SHOP,
                    SharedPM.R_RubyBase
                },
                {
                    SceneType.MAP_SELECT,
                    SharedPM.R_RubyBase
                },
                {
                    SceneType.BATTLE_MODES,
                    SharedPM.R_RubyBase
                },
                {
                    SceneType.ARENA_READY,
                    SharedPM.R_RubyBase
                },
                {
                    SceneType.ARENA_START,
                    SharedPM.R_RubyBase
                }
            };
            Rectangle rect = dictionary[sceneType];
            int num = ParseRuby(rect);
            if (num != -1)
            {
                RubyCount = num;
                ReportResources(ResourceType.RUBY);
            }
        }

        private void UpdateTopaz(SceneType sceneType)
        {
            Dictionary<SceneType, Point> dictionary = new Dictionary<SceneType, Point>
            {
                {
                    SceneType.LOBBY,
                    new Point(LobbyPM.TOPAZ_OFFSET_X, LobbyPM.TOPAZ_OFFSET_Y)
                },
                {
                    SceneType.SHOP,
                    new Point(ShopPM.TOPAZ_OFFSET_X, ShopPM.TOPAZ_OFFSET_Y)
                }
            };
            Point point = dictionary[sceneType];
            int num = ParseTopaz(point.X, point.Y);
            if (num != -1)
            {
                TopazCount = num;
                ReportResources(ResourceType.TOPAZ);
            }
        }

        private void WeightedClick(PixelMapping mapping, double scale = 1.0, double density = 1.0, int numClicks = 1, int delay = 0, string button = "left")
        {
            BlueStacks.MainWindowAS.Click(mapping.X, mapping.Y, numClicks, delay, button);
        }

#endregion Private Methods
    }
}