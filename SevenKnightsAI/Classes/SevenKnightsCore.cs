using RestSharp;
using SevenKnightsAI.Classes.Extensions;
using SevenKnightsAI.Classes.Imaging;
using SevenKnightsAI.Classes.Mappings;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Tesseract;
using Telegram;

namespace SevenKnightsAI.Classes
{
    internal class SevenKnightsCore
    {
        #region Public Fields

        public BlueStacks BlueStacks;

        #endregion Public Fields

        #region Private Fields

        private const int COOLDOWN_INBOX = 1800000;
        private const int COOLDOWN_QUESTS = 1800000;
        private const int COOLDOWN_HERO = 900000;
        private const int COOLDOWN_SELL_HEROES = 900000;
        private const int COOLDOWN_SELL_ITEMS = 900000;
        private const int COOLDOWN_SEND_HONORS = 1800000;
        private const int HANG_FINGERPRINT_SIZE = 50;
        private const int MAX_HANG_TIME = 30000;
        private const int MAX_HERO_MANAGE_ATTEMPS = 3;
        private const int MAX_IDLE_TIME = 8000;
        private const int MAX_MAP_SELECT_TIME = 10000;
        private const int PIXEL_TOLERANCE = 2;
        private const string PUSHBULLET_TOKEN = "";
        private const int SLEEP_L = 1000;
        private const int SLEEP_M = 500;
        private const int SLEEP_S = 300;
        private const int SLEEP_XL = 2000;
        private const int SLEEP_XS = 100;
        private const int SLEEP_XXL = 3000;

        private readonly Color COLOR_ARENA = Color.RosyBrown;
        private readonly Color COLOR_BUY_KEYS = Color.IndianRed;
        private readonly Color COLOR_DEATH = Color.Indigo;
        private readonly Color COLOR_HONOR = Color.Navy;
        private readonly Color COLOR_INBOX = Color.MediumTurquoise;
        private readonly Color COLOR_LEVEL_30 = Color.MediumPurple;
        private readonly Color COLOR_LEVEL_UP = Color.Orchid;
        private readonly Color COLOR_LIMIT = Color.Peru;
        private readonly Color COLOR_QUEST = Color.SandyBrown;
        private readonly Color COLOR_SELL_HEROES = Color.MediumVioletRed;
        private readonly Color COLOR_SELL_ITEMS = Color.SeaGreen;
        private readonly Color COLOR_SMART_MODE = Color.SteelBlue;

        private int AdventureCount;
        private int AdventureCount2;
        private int AdventureKeys;
        private TimeSpan AdventureKeyTime;
        private int AdventureLimitCount;
        private int AdventureLimitCount2;
        private bool IsAdventureLimit;
        private bool IsAlreadyAdvEnd;
        private bool IsAlreadyAdvFight;
        private bool IsAlreadyAdvLoot;
        private AIProfiles AIProfiles;
        private int ArenaKeys;
        private TimeSpan ArenaKeyTime;
        private int ArenaLimitCount;
        private int ArenaLoseCount;
        private int ArenaRubiesCount;
        private int ArenaWinCount;
        private int ArenaRank;
        private int CollectQuestsCount;
        private int CollectQuestsTotal;
        private int CooldownInbox;
        private int CooldownQuests;
        private int CooldownSellHeroes;
        private int CooldownSellItems;
        private int CooldownSendHonors;
        private int[] CurrentFingerprint;
        private Objective CurrentObjective;
        private Scene CurrentScene;
        private int CurrentSequence;
        private int CurrentSequenceCount;
        private int CurrentSequenceCount2;
        private int GoldCount;
        private int HangCounter;
        private int HonorCount;
        private int IdleCounter;
        private int KeysBoughtHonors;
        private int KeysBoughtRubies;
        private int MapCheckCount;
        private int MapSelectCounter;
        private System.Timers.Timer OneSecTimer;
        private int[] PreviousFingerprint;
        private Objective PreviousObjective;
        private Scene PreviousScene;
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
        private string PlayerName = "";
        private bool CheckPlayaName;
        private bool checkslothero;
        private bool checkslotitem;
        private bool herofull;
        private bool itemfull;
        private int goldadv;
        private int heroadv;
        private int itemadv;
        private int entrytolv30;
        private int h30;
        private World world3; //for give delay to adventure_fight
        private int internetdc;
        private int SmartModeCount;
        private int GoldenCrystalCount;
        private int HornCount;
        private int ScaleCount;
        private int EssecenseCount;
        private int StarCount;

        #endregion Private Fields

        #region Private Properties

        private AISettings AISettings
        {
            get
            {
                return this.AIProfiles.CurrentProfile;
            }
        }

        #endregion Private Properties

        #region Public Constructors

        public SevenKnightsCore(AIProfiles profile)
        {
            this.AIProfiles = profile;
            //if (this.AIProfiles.ST_EnableTelegram)
            //{
            bot.token = "455541103:AAH5Aw6kS5-yH0OFkcrKbCbrfsb8goRmfcA";
            //}
            this.OneSecTimer = new System.Timers.Timer(1000.0);
            this.OneSecTimer.Elapsed += new ElapsedEventHandler(this.OnOneSecEvent);
            try
            {
                this.Tesseractor = new Tesseractor("eng");
            }
            catch (TesseractException)
            {
                MessageBox.Show("Tesseract engine could not be initialized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.Tesseractor = null;
            }
        }

        #endregion Public Constructors

        #region Public Methods

        public static bool IsConnectedToInternet()
        {
            bool returnValue = false;
            try
            {

                int Desc;
                returnValue = Utility.InternetGetConnectedState(out Desc, 0);
            }
            catch
            {
                returnValue = false;
            }
            return returnValue;
        }

        public BackgroundWorker Start(SynchronizationContext synchronizationContext)
        {
            this.SynchronizationContext = synchronizationContext;
            this.Worker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            this.Worker.DoWork += new DoWorkEventHandler(this.MainLoop);
            this.Worker.RunWorkerAsync();
            return this.Worker;
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
            if (this.CurrentObjective == Objective.IDLE)
            {
                return "Current Objective : Idle";
            }
            else if (this.CurrentObjective == Objective.ADVENTURE)
            {
                return "Current Objective : Adventure";
            }
            else if (this.CurrentObjective == Objective.ARENA)
            {
                return "Current Objective : Arena";
            }
            else if (this.CurrentObjective == Objective.CHECK_SLOT_HERO)
            {
                return "Current Objective : Checking Hero Slot";
            }
            else if (this.CurrentObjective == Objective.CHECK_SLOT_ITEM)
            {
                return "Current Objective : Checking Item Slot";
            }
            else if (this.CurrentObjective == Objective.SELL_HEROES)
            {
                return "Current Objective : Sell Heroes";
            }
            else if (this.CurrentObjective == Objective.SELL_ITEMS)
            {
                return "Current Objective : Sell Items";
            }
            else if (this.CurrentObjective == Objective.BUY_KEYS)
            {
                return "Current Objective : Buy Keys";
            }
            else if (this.CurrentObjective == Objective.COLLECT_INBOX)
            {
                return "Current Objective : Collect Inbox";
            }
            else if (this.CurrentObjective == Objective.COLLECT_QUESTS)
            {
                return "Current Objective : Collect Quest";
            }
            else if (this.CurrentObjective == Objective.SEND_HONORS)
            {
                return "Current Objective : Send Honors";
            }
            else if (this.CurrentObjective == Objective.SMART_MODE)
            {
                return "Current Objective : Smart Mode";
            }
            else
            {
                return "ERROR DUDE";
            }
        }

        #endregion Public Methods

        #region Private Methods

        private static void Sleep(int timeout) => Thread.Sleep(timeout);

        private void AdventureAfterFight()
        {
            this.AdventureCount++;
            this.AdventureCount2++;
            if(this.AdventureCount2 >= this.entrytolv30)
            {
                this.h30 += 4;
                this.AdventureCount2 = 0;
                this.Log("Hero 30 : " + this.h30);
            }
            this.IsAlreadyAdvEnd = false;
            this.IsAlreadyAdvFight = false;
            this.IsAlreadyAdvLoot = true;
            this.ReportCount(Objective.ADVENTURE);
            this.ProgressSequence();
            this.AdventureCheckLimits();
        }

        private void SmartModeAfterFight()
        {
            this.SmartModeCount++;
            this.ReportSmartCount();
        }

        private void EndAutoRepeat()
        {
            this.AdventureLimitCount2++;
            this.Log("Before: " + this.CurrentSequenceCount2);
            this.CurrentSequenceCount2++;
            this.Log("After: " + this.CurrentSequenceCount2 + " Progress Sequnce: " + this.AISettings.AD_AmountSequence[this.CurrentSequence]);
            if (this.AdventureLimitCount2 >= this.AISettings.AD_Limit)
            {
                this.AdventureLimitCount2 = 0;
                this.CurrentSequenceCount2 = 0;
                for (int i = 0; i < 3; i++)
                {
                    this.WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");

                }
            }
            else if (this.CurrentSequenceCount2 >= this.AISettings.AD_AmountSequence[this.CurrentSequence])
            {
                this.CurrentSequenceCount2 = 0;
                this.checkslothero = true;
                this.checkslotitem = true;
                if (this.AISettings.AD_CheckSlot)
                {
                    this.ChangeObjective(Objective.CHECK_SLOT_HERO);
                }
                for (int i = 0; i < 3; i++)
                {
                    this.WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                }
            }
            else
            {
                SevenKnightsCore.Sleep(3000);
            }
            this.IsAlreadyAdvEnd = true;
        }

        private void AdventureCheckLimits()
        {
            if (this.CurrentObjective == Objective.CHECK_SLOT_HERO || this.CurrentObjective == Objective.ADVENTURE)
            {
                if (this.AISettings.AD_EnableLimit)
                {
                    this.AdventureLimitCount++;
                    if (this.AdventureLimitCount >= this.AISettings.AD_Limit)
                    {
                        this.Log("Limit reached [Adventure]", this.COLOR_LIMIT);
                        SendTelegram(this.AIProfiles.ST_TelegramChatID, "Limit Reached [Adventure]");
                        this.AdventureLimitCount = 0;
                        this.IsAdventureLimit = true;
                        this.NextPossibleObjective();
                    }
                }
            }
        }

        private void Alert(string message)
        {
            ProgressArgs userState = new ProgressArgs(ProgressType.Alert, message);
            this.Worker.ReportProgress(0, userState);
        }

        private void ArenaAfterFight(bool win)
        {
            if (win)
            {
                this.ArenaWinCount++;
            }
            else
            {
                this.ArenaLoseCount++;
            }
            this.ReportArenaCount();
            this.ArenaCheckLimits();
        }

        private void ArenaCheckLimits()
        {
            if (this.AISettings.AR_EnableLimit)
            {
                this.ArenaLimitCount++;
                if (this.ArenaLimitCount >= this.AISettings.AR_Limit)
                {
                    this.Log("Limit reached [Arena]", this.COLOR_LIMIT);
                    SendTelegram(this.AIProfiles.ST_TelegramChatID, "Limit Reached [Arena]");
                    this.ArenaLimitCount = 0;
                    this.NextPossibleObjective();
                }
            }
        }

        private bool ArenaUseRuby()
        {
            return this.AISettings.AR_UseRuby && this.ArenaRubiesCount < this.AISettings.AR_UseRubyAmount;
        }

        private void BuyKeys()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                ShopPM.Key10Honor100,
                ShopPM.Key1Honor10
            };
            String[] array2 = new String[]
            {
                "10 Key",
                "1 Key"
            };
            int start = -1;
            this.KeysBoughtHonors = 0;
            while (start <= 1 && !this.Worker.CancellationPending)
            {
                start++;
                Scene scene;
                SevenKnightsCore.Sleep(1000);
                this.Log("Start buying keys", this.COLOR_BUY_KEYS);
                this.CaptureFrame();
                scene = this.SceneSearch();
                if (scene.SceneType != SceneType.SHOP)
                {
                    this.Escape();
                }
                SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot will buy the keys with honors first, then with rubies.");
                SevenKnightsCore.Sleep(1000);
                PixelMapping mapping;
                mapping = array[start];
                this.Log(string.Format("Buy {0} with honors", array2[start]), this.COLOR_BUY_KEYS);
                SevenKnightsCore.Sleep(1000);
                this.KeysBoughtHonors++;
                this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                this.CaptureFrame();
                scene = this.SceneSearch();
                if (scene != null && scene.SceneType == SceneType.SHOP_BUY_FAILED_POPUP)
                {
                    this.Log("Can't buy key because insufficient honor");
                    this.WeightedClick(ShopBuyFailedPopupPM.OkButton, 1.0, 1.0, 1, 0, "left");
                    continue;
                }
                if (scene != null && scene.SceneType != SceneType.SHOP_BUY_POPUP)
                {
                    this.Log("Can't buy key because insufficient honor2");
                }
                this.WeightedClick(ShopBuyPopupPM.BuyButton, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(4000);
                this.CaptureFrame();
                scene = this.SceneSearch();
                this.Log(scene.SceneType.ToString());
                if ((this.MatchMapping(ShopPurchaseCompletePopupPM.AgainButtonBorder, 2) && this.MatchMapping(ShopPurchaseCompletePopupPM.OKButtonBorder, 2)) || scene.SceneType == SceneType.SHOP_PURCHASE_COMPLETE_POPUP)
                {
                    int counter = 1;
                    while (true)
                    {
                        SevenKnightsCore.Sleep(1000);
                        this.Log(String.Format("Keys bought ({0})", counter), this.COLOR_BUY_KEYS);
                        this.WeightedClick(ShopPurchaseCompletePopupPM.AgainButton, 1.0, 1.0, 1, 0, "left");
                        SevenKnightsCore.Sleep(3000);
                        this.CaptureFrame();
                        scene = this.SceneSearch();
                        if ((!this.MatchMapping(ShopPurchaseCompletePopupPM.AgainButtonBorder, 2) || !this.MatchMapping(ShopPurchaseCompletePopupPM.OKButtonBorder, 2)) || scene.SceneType != SceneType.SHOP_PURCHASE_COMPLETE_POPUP)
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
                    this.DoneBuyKeys();
                    break;
                }
            }
            this.DoneBuyKeys();
        }

        private Bitmap CaptureFrame()
        {
            bool sT_ForegroundMode = this.AIProfiles.ST_ForegroundMode;
            return this.BlueStacks.CaptureFrame(!sT_ForegroundMode);
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
            }
            this.PreviousObjective = this.CurrentObjective;
            this.CurrentObjective = objective;
            this.Worker.ReportProgress(0, new ProgressArgs(ProgressType.OBJECTIVE, message));
        }

        private void DisableObjective(Objective Obj)
        {
            string message = string.Empty;
            switch (Obj)
            {

                case Objective.ADVENTURE:
                    message = "Adventure";
                    this.AISettings.AD_Enable = false;
                    break;


                case Objective.ARENA:
                    message = "Arena";
                    this.AISettings.AD_Enable = false;
                    break;

            }
            this.Log(message + " Disabled", Color.Orange);
        }

        private bool CheckMapNumber(World world, int stage)
        {
            if (world == World.None)
            {
                return true;
            }
            int num = world - World.Sequencer;
            int num2 = stage + 1;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, AdventureStartPM.R_MapNumber).ScaleByPercent(128))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = page.GetText().ToLower().Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
                        .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
                        .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("f", "").Replace("[", "").Replace("]", "")
                        .Replace("#", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3").Replace("!", "");
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
                        if(num3 >= 8)
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

        private void ClickDrag(int startX, int startY, int endX, int endY)
        {
            this.BlueStacks.MainWindowAS.ClickDrag(startX, startY, endX, endY, 0, "left");
        }

        private void CollectInbox()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                InboxPM.HonorsTab,
                InboxPM.KeysTab,
                InboxPM.CurrencyTab,
                InboxPM.MaterialTab
            };
            PixelMapping[] array2 = new PixelMapping[]
            {
                InboxPM.HonorsTabRedIcon,
                InboxPM.KeysTabRedIcon,
                InboxPM.CurrencyTabRedIcon,
                InboxPM.MaterialTabRedIcon
            };
            string[] array3 = new string[]
            {
                "Honors",
                "Keys",
                "Currency",
                "Material"
            };
            bool[] array4 = new bool[]
            {
                this.AISettings.RS_InboxHonors, //honor
                this.AISettings.RS_InboxKeys, //key
                this.AISettings.RS_InboxGold,// currency
                this.AISettings.RS_InboxRubies //material
            };
            this.Log("Start collecting inbox", this.COLOR_INBOX);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot is collecting your inbox.");
            List<int> list = new List<int>();
            for (int i = 0; i < array2.Length; i++)
            {
                if (this.MatchMapping(array2[i], 4) && array4[i])
                {
                    list.Add(i);
                }
            }
            foreach (int current in list)
            {
                this.Log(string.Format("- Got Tab: {0}", array3[current]), this.COLOR_INBOX);
            }
            if (list.Count <= 0)
            {
                this.Log("Nothing to collect", this.COLOR_INBOX);
                this.DoneCollectInbox();
                return;
            }
            foreach (int current2 in list)
            {
                if (this.Worker.CancellationPending)
                {
                    return;
                }
                SevenKnightsCore.Sleep(500);
                this.Log(string.Format("Collecting {0}", array3[current2]), this.COLOR_INBOX);
                PixelMapping mapping = array[current2];
                this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                this.CaptureFrame();
                Scene scene = this.SceneSearch();
                if (scene != null && scene.SceneType != SceneType.INBOX)
                {
                    this.DoneCollectInbox();
                    return;
                }
                if (current2 == 4)
                {
                    while (!this.Worker.CancellationPending)
                    {
                        this.CaptureFrame();
                        scene = this.SceneSearch();
                        if (scene != null && scene.SceneType != SceneType.INBOX)
                        {
                            this.DoneCollectInbox();
                            return;
                        }
                        if (!this.MatchMapping(InboxPM.AttachCollectButtonBackground, 4))
                        {
                            this.DoneCollectInbox();
                            return;
                        }
                        this.WeightedClick(InboxPM.AttachCollectButton, 1.0, 1.0, 1, 0, "left");
                        SevenKnightsCore.Sleep(1000);
                        if (!this.HandleInboxCollected(current2))
                        {
                            this.DoneCollectInbox();
                            return;
                        }
                        SevenKnightsCore.Sleep(500);
                    }
                }
                else if (this.MatchMapping(InboxPM.CollectAllButtonBackground, 4))
                {
                    this.WeightedClick(InboxPM.CollectAllButton, 1.0, 1.0, 1, 0, "left");
                    this.LongSleep(1000, 1000);
                    if (!this.HandleInboxCollected(current2))
                    {
                        SevenKnightsCore.Sleep(300);
                        this.Escape();
                    }
                }
                else
                {
                    SevenKnightsCore.Sleep(300);
                    this.Escape();
                }
            }
            this.DoneCollectInbox();
        }

        private void CollectQuests()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                QuestPM.BattleTab,
                QuestPM.HeroTab,
                QuestPM.ItemTab,
                QuestPM.SocialTab
            };
            PixelMapping[] array2 = new PixelMapping[]
            {
                QuestPM.BattleAvailable,
                QuestPM.HeroAvailable,
                QuestPM.ItemAvailable,
                QuestPM.SocialAvailable
            };
            string[] array3 = new string[]
            {
                "Battle",
                "Hero",
                "Item",
                "Social"
            };
            bool[] array4 = new bool[]
            {
                this.AISettings.RS_QuestsBattle,
                this.AISettings.RS_QuestsHero,
                this.AISettings.RS_QuestsItem,
                this.AISettings.RS_QuestsSocial
            };
            this.Log("Start collecting quests", this.COLOR_QUEST);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot is collecting quests.");
            List<int> list = new List<int>();
            for (int i = 0; i < array2.Length; i++)
            {
                if (this.MatchMapping(array2[i], 4) && array4[i])
                {
                    list.Add(i);
                }
            }
            foreach (int current in list)
            {
                this.Log(string.Format("- Got Tab: {0}", array3[current]), this.COLOR_QUEST);
            }
            if (list.Count <= 0)
            {
                this.Log("Nothing to collect", this.COLOR_QUEST);
                this.DoneCollectQuests();
                return;
            }
            foreach (int current2 in list)
            {
                if (this.Worker.CancellationPending)
                {
                    return;
                }
                SevenKnightsCore.Sleep(500);
                this.Log(string.Format("Collecting {0} quest", array3[current2]), this.COLOR_QUEST);
                PixelMapping mapping = array[current2];
                this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                this.CaptureFrame();
                Scene scene = this.SceneSearch();
                if (scene != null && scene.SceneType != SceneType.QUEST)
                {
                    this.DoneCollectQuests();
                    return;
                }
                if (this.MatchMapping(QuestPM.CollectAllButtonBackground, 4))
                {
                    this.WeightedClick(QuestPM.CollectAllButton, 1.0, 1.0, 1, 0, "left");
                    this.LongSleep(1000, 1000);
                    while (!this.Worker.CancellationPending && this.MatchMapping(QuestPM.CollectAllButtonBackground, 4))
                    {
                        this.CaptureFrame();
                        SevenKnightsCore.Sleep(500);
                    }
                    SevenKnightsCore.Sleep(1000);
                    this.CaptureFrame();
                    scene = this.SceneSearch();
                    if (scene == null || scene.SceneType != SceneType.QUEST_REWARDS_POPUP || scene.SceneType != SceneType.LOOT_HERO || scene.SceneType != SceneType.LOOT_ITEM)
                    {
                        SevenKnightsCore.Sleep(300);
                        this.Escape();
                    }
                }
            }
            this.DoneCollectQuests();
        }

        private void CollectSpecialQuests()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                SpecialQuestPM.DailyTab,
                SpecialQuestPM.WeeklyTab,
                SpecialQuestPM.MonthlyTab
            };
            PixelMapping[] array2 = new PixelMapping[]
            {
                SpecialQuestPM.DailyAvailable,
                SpecialQuestPM.WeeklyAvailable,
                SpecialQuestPM.MonthlyAvailable
            };
            string[] array3 = new string[]
            {
                "Daily",
                "Weekly",
                "Monthly"
            };
            bool[] array4 = new bool[]
            {
                this.AISettings.RS_SpecialQuestsDaily,
                this.AISettings.RS_SpecialQuestsWeekly,
                this.AISettings.RS_SpecialQuestsMonthly
            };
            this.Log("Start collecting special quests", this.COLOR_QUEST);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot is collecting special quests.");
            List<int> list = new List<int>();
            for (int i = 0; i < array2.Length; i++)
            {
                if (this.MatchMapping(array2[i], 4) && array4[i])
                {
                    list.Add(i);
                }
            }
            foreach (int current in list)
            {
                this.Log(string.Format("- Got Tab: {0}", array3[current]), this.COLOR_QUEST);
            }
            if (list.Count <= 0)
            {
                this.Log("Nothing to collect", this.COLOR_QUEST);
                this.DoneCollectSpecialQuests();
                return;
            }
            foreach (int current2 in list)
            {
                if (this.Worker.CancellationPending)
                {
                    return;
                }
                SevenKnightsCore.Sleep(500);
                this.Log(string.Format("Collecting {0} quest", array3[current2]), this.COLOR_QUEST);
                PixelMapping mapping = array[current2];
                this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                this.CaptureFrame();
                Scene scene = this.SceneSearch();
                if (scene != null && scene.SceneType != SceneType.SPECIAL_QUEST)
                {
                    this.DoneCollectSpecialQuests();
                    return;
                }
                while (!this.Worker.CancellationPending)
                {
                    this.CaptureFrame();
                    scene = this.SceneSearch();
                    if (scene != null && scene.SceneType != SceneType.SPECIAL_QUEST)
                    {
                        this.DoneCollectSpecialQuests();
                        return;
                    }
                    if (!this.MatchMapping(SpecialQuestPM.CollectButtonBackground, 4))
                    {
                        break;
                    }
                    this.WeightedClick(SpecialQuestPM.CollectButton, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(500);
                    if (!this.HandleSpecialQuestsCollected(current2))
                    {
                        break;
                    }
                    SevenKnightsCore.Sleep(500);
                }
                this.CaptureFrame();
                scene = this.SceneSearch();
                if (scene != null && scene.SceneType != SceneType.SPECIAL_QUEST)
                {
                    this.DoneCollectSpecialQuests();
                    return;
                }
                if (this.MatchMapping(SpecialQuestPM.CollectMainButtonBackground, 4))
                {
                    this.WeightedClick(SpecialQuestPM.CollectMainButton, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(1000);
                    if (!this.HandleSpecialQuestsCollected(current2))
                    {
                        SevenKnightsCore.Sleep(300);
                        this.Escape();
                    }
                }
            }
            this.DoneCollectSpecialQuests();
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
                array[i] = this.GetPixel(array2[i].X, array2[i].Y);
            }
        }

        private string CheckOwnername()
        {
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, LobbyPM.OwnerLocation).ScaleByPercent(150))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
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
                        this.Log("Owner Name = " + PlayerName, Color.BlueViolet);
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
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, ArenaEndPM.ArenaScore))
            {
                int arenaScore = 0;
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
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
                    int.TryParse(test1, out arenaScore);
                    this.Log(string.Format("Arena Score = {0}", arenaScore), this.COLOR_ARENA);
                    ArenaRank = arenaScore;
                    if (this.AISettings.AR_LimitArena)
                    {
                        if (arenaScore >= this.AISettings.AR_LimitScore)
                        {
                            SevenKnightsCore.Sleep(800);
                            this.NextPossibleObjective();
                            this.Log(string.Format("Arena Score Limit"), Color.BlueViolet);
                        }
                    }
                }
            }
        }

        private void CheckArenaScoreReady()
        {
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, ArenaReadyPM.ArenaScore))
            {
                int arenaScore = 0;
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
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
                    this.Log(string.Format("Arena Score = {0}", arenaScore), this.COLOR_ARENA);
                    ArenaRank = arenaScore;
                    if (this.AISettings.AR_LimitArena)
                    {
                        if (arenaScore >= this.AISettings.AR_LimitScore)
                        {
                            SevenKnightsCore.Sleep(800);
                            this.NextPossibleObjective();
                            this.Log(string.Format("Arena Score Limit"), Color.BlueViolet);
                        }
                    }

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
            this.Log("Done buying keys", this.COLOR_BUY_KEYS);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot has finished buying keys.");
            this.NextPossibleObjective();
            SevenKnightsCore.Sleep(300);
            this.Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DoneCollectAllQuests()
        {
            if (this.CollectQuestsTotal >= 1)
            {
                this.Log("Done collecting all quests", this.COLOR_QUEST);
            }
            this.CollectQuestsCount = -1;
            this.CollectQuestsTotal = -1;
            this.NextPossibleObjective();
        }

        private void DoneCollectInbox()
        {
            this.Log("Done collecting inbox", this.COLOR_INBOX);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot has finished collecting your inbox.");
            this.NextPossibleObjective();
            SevenKnightsCore.Sleep(300);
            this.Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DoneCollectQuests()
        {
            this.Log("Done collecting quests", this.COLOR_QUEST);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot has finished collecting quests.");
            this.CollectQuestsCount++;
            if (this.CollectQuestsCount == this.CollectQuestsTotal)
            {
                this.DoneCollectAllQuests();
            }
            SevenKnightsCore.Sleep(300);
            this.Escape();
            SevenKnightsCore.Sleep(500);
        }

        private void DoneCollectSpecialQuests()
        {
            this.Log("Done collecting special quests", this.COLOR_QUEST);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot has finished collecting special quests.");
            this.CollectQuestsCount++;
            if (this.CollectQuestsCount == this.CollectQuestsTotal)
            {
                this.DoneCollectAllQuests();
            }
            SevenKnightsCore.Sleep(300);
            this.Escape();
            SevenKnightsCore.Sleep(500);
        }

        private void DoneSellHeroes(int sellCount)
        {
            this.Log("Done selling heroes", this.COLOR_SELL_HEROES);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot has finished selling your heroes.");
            if (sellCount == 0)
            {
                this.Log("No more heroes that satisfied the conditions", this.COLOR_SELL_HEROES);
                this.CooldownSellHeroes = 900000;
            }
            this.NextPossibleObjective();
            SevenKnightsCore.Sleep(300);
            this.Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DoneSellHeroesMini()
        {
            SevenKnightsCore.Sleep(1000);
            this.Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DoneSellItems()
        {
            this.Log("Done selling items", this.COLOR_SELL_ITEMS);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot has finished selling your items.");
            //if (sellCount == 0)
            // {
            //   this.Log("No more items that satisfied the conditions", this.COLOR_SELL_ITEMS);
            //   this.CooldownSellItems = 900000;
            //}
            this.NextPossibleObjective();
            SevenKnightsCore.Sleep(300);
            this.Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void DoneSendHonors()
        {
            this.Log("Done sending honors", this.COLOR_HONOR);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot has finished selling your heroes.");
            this.NextPossibleObjective();
            SevenKnightsCore.Sleep(300);
            this.Escape();
            SevenKnightsCore.Sleep(500);
        }

        private void DoneHottime()
        {
            SevenKnightsCore.Sleep(800);
            this.Escape();
            SevenKnightsCore.Sleep(1000);
        }

        private void Escape()
        {
            this.BlueStacks.MainWindowAS.PressKey(27u, 1, 0);
        }

        private bool ExpectingScene(SceneType sceneType, int retry = 5, int sleepInterval = 500)
        {
            for (int i = 0; i < retry; i++)
            {
                if (this.Worker.CancellationPending)
                {
                    return false;
                }
                this.CaptureFrame();
                Scene scene = this.SceneSearch();
                if (scene != null || scene.SceneType == sceneType)
                {
                    return true;
                }
                SevenKnightsCore.Sleep(sleepInterval);
            }
            return false;
        }

        private bool ExpectingScenes(List<SceneType> sceneTypes, int retry = 5, int sleepInterval = 500)
        {
            for (int i = 0; i < retry; i++)
            {
                if (this.Worker.CancellationPending)
                {
                    return false;
                }
                this.CaptureFrame();
                Scene scene = this.SceneSearch();
                if (scene != null || sceneTypes.Contains(scene.SceneType))
                {
                    return true;
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
            return this.BlueStacks.GetPixel(x, y);
        }

        private Tuple<World, int> GetWorldStageFromSequencer()
        {
            if (this.AISettings.AD_World != World.Sequencer)
            {
                return null;
            }
            if (this.AISettings.AD_WorldSequence == null || this.AISettings.AD_WorldSequence.Length <= 0 || this.AISettings.AD_StageSequence == null || this.AISettings.AD_StageSequence.Length <= 0 || this.AISettings.AD_AmountSequence == null || this.AISettings.AD_AmountSequence.Length <= 0)
            {
                return null;
            }
            World item = (World)this.AISettings.AD_WorldSequence[this.CurrentSequence];
            int item2 = this.AISettings.AD_StageSequence[this.CurrentSequence];
            return new Tuple<World, int>(item, item2);
        }

        private bool HandleInboxCollected(int tabIndex)
        {
            while (!this.Worker.CancellationPending && this.MatchMapping(InboxPM.AttachCollectButtonBackground, 4))
            {
                this.CaptureFrame();
                SevenKnightsCore.Sleep(500);
            }
            SevenKnightsCore.Sleep(1000);
            this.CaptureFrame();
            Scene scene = this.SceneSearch();
            if (scene == null || (scene.SceneType != SceneType.INBOX_REWARDS_POPUP && scene.SceneType != SceneType.LOOT_HERO && scene.SceneType != SceneType.LOOT_ITEM && scene.SceneType != SceneType.INBOX_SELECT_HERO && scene.SceneType != SceneType.INBOX_COLLECT_FAILED_POPUP))
            {
                return false;
            }
            if (scene.SceneType == SceneType.INBOX_REWARDS_POPUP)
            {
                this.Log("-- Rewards collected", this.COLOR_INBOX);
            }
            else if (scene.SceneType == SceneType.LOOT_ITEM)
            {
                this.Log("-- Item ticket collected", this.COLOR_INBOX);
            }
            else if (scene.SceneType == SceneType.LOOT_HERO)
            {
                this.Log("-- Hero ticket collected", this.COLOR_INBOX);
            }
            else
            {
                if (scene.SceneType == SceneType.INBOX_SELECT_HERO)
                {
                    this.Log("Found a hero card that needs to be selected", this.COLOR_INBOX);
                    SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot will skip and not collect this card.");
                    return false;
                }
                if (scene.SceneType != SceneType.INBOX_COLLECT_FAILED_POPUP)
                {
                    return false;
                }
                if (tabIndex == 4)
                {
                    return false;
                }
            }
            if (scene.SceneType == SceneType.INBOX_REWARDS_POPUP)
            {
                this.WeightedClick(SharedPM.Rewards_OkButton, 1.0, 1.0, 1, 0, "left");
            }
            else
            {
                this.Escape();
            }
            SevenKnightsCore.Sleep(500);
            return true;
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
                    SceneType.OUT_OF_KEYS_POPUP,
                    new PixelMapping[]
                    {
                        OutOfKeysPopupPM.ShopButton,
                        OutOfKeysPopupPM.NoButton
                    }
                }
            };
            PixelMapping[] array = dictionary[sceneType];
            if (this.IsBuyKeysEnabled())
            {
                this.WeightedClick(array[0], 1.0, 1.0, 1, 0, "left");
                if (this.CurrentObjective != Objective.BUY_KEYS)
                {
                    this.ChangeObjective(Objective.BUY_KEYS);
                    return;
                }
            }
            else
            {
                this.WeightedClick(array[1], 1.0, 1.0, 1, 0, "left");
                this.NextPossibleObjective();
            }
        }

        private void HandleSmartMode()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                SmartLobbyPM.CelestialTowerButton,
                SmartLobbyPM.RaidButton,
                SmartLobbyPM.TartarusButton
            };

            String[] array2 = new String[]
            {
                "Celestial Tower",
                "Raid",
                "Tartarus"
            };

            bool[] array4 = new bool[]
            {
                this.AISettings.SM_CollectTower,
                this.AISettings.SM_CollectRaid,
                this.AISettings.SM_CollectTartarus
            };

            Rectangle R_0 = SmartLobbyPM.R_GoldenCrystal;
            Rectangle R_2 = SmartLobbyPM.R_Star;
            Rectangle[] R_1 = new Rectangle[]
            {
                SmartLobbyPM.R_Horn,
                SmartLobbyPM.R_Scale,
                SmartLobbyPM.R_Essecense
            };
            this.Log("Start Collect Smart mode", this.COLOR_SMART_MODE);
            int start = -1;
            bool stopSmartMode = false;
            while (start <= 2 || stopSmartMode)
            {
                start++;
                if (start > 2)
                {
                    stopSmartMode = true;
                    this.SmartModeAfterFight();
                    this.NextPossibleObjective();
                    break;
                }
                if (array4[start])
                {
                    SevenKnightsCore.Sleep(1000);
                    PixelMapping mapping;
                    mapping = array[start];
                    this.Log(string.Format("Collect: {0}", array2[start]), this.COLOR_SMART_MODE);
                    SevenKnightsCore.Sleep(1000);
                    this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(3000);
					this.WeightedClick(SmartLobbyPM.CollectButton, 1.0, 1.0, 1, 0, "left");
					this.Log("Collect Resource success", this.COLOR_SMART_MODE);
					SevenKnightsCore.Sleep(3000);
					this.WeightedClick(SmartLobbyPM.LootButton, 1.0, 1.0, 1, 0, "left");
					SevenKnightsCore.Sleep(2000);
					this.CaptureFrame();
					Scene scene = this.SceneSearch();
                    this.Log(scene.SceneType.ToString());
					if (scene.SceneType == SceneType.SMART_LOOT_COLLECT_LOBBY)
					{
						this.Log("Collect Loot success", this.COLOR_SMART_MODE);
						this.Escape();
						SevenKnightsCore.Sleep(4000);
                    }
                    else
                    {
                        this.Log("Loot Not Available", this.COLOR_SMART_MODE);
                    }
                    if(start == 0)
                    {
                        this.GoldenCrystalCount = this.ParseSmartResource(R_0);
                        this.ReportResources(ResourceType.GOLDEN_CRYSTAL);
                    }else if(start == 1)
                    {
                        this.HornCount = this.ParseSmartResource(R_1[0]);
                        this.ReportResources(ResourceType.HORN);
                        this.ScaleCount = this.ParseSmartResource(R_1[1]);
                        this.ReportResources(ResourceType.SCALE);
                        this.EssecenseCount = this.ParseSmartResource(R_1[2]);
                        this.ReportResources(ResourceType.ESSENCE);
                    }else if(start == 2)
                    {
                        this.StarCount = this.ParseSmartResource(R_2);
                        this.ReportResources(ResourceType.STAR);
                    }
                }
                else
                {
                    continue;
                }
            }
        }

        private bool HandleSpecialQuestsCollected(int tabIndex)
        {
            while (!this.Worker.CancellationPending && (this.MatchMapping(QuestPM.CollectAllButtonBackground, 4) || this.MatchMapping(QuestPM.CollectButtonBackground, 2) || this.MatchMapping(SpecialQuestPM.CollectMainButtonBackground, 4) || this.MatchMapping(SpecialQuestPM.CollectButtonBackground, 2)))
            {
                this.CaptureFrame();
                SevenKnightsCore.Sleep(500);
            }
            SevenKnightsCore.Sleep(300);
            this.CaptureFrame();
            Scene scene = this.SceneSearch();
            if (scene == null || (scene.SceneType != SceneType.QUEST_REWARDS_POPUP && scene.SceneType != SceneType.LOOT_ITEM && scene.SceneType != SceneType.LOOT_HERO && scene.SceneType != SceneType.QUEST_COLLECT_FAILED_POPUP))
            {
                return false;
            }
            if (scene.SceneType == SceneType.QUEST_REWARDS_POPUP)
            {
                this.Log("-- Rewards collected", this.COLOR_QUEST);
            }
            else if (scene.SceneType == SceneType.LOOT_ITEM)
            {
                this.Log("-- Item ticket collected", this.COLOR_QUEST);
            }
            else if (scene.SceneType == SceneType.LOOT_HERO)
            {
                this.Log("-- Hero ticket collected", this.COLOR_QUEST);
            }
            else
            {
                if (scene.SceneType == SceneType.QUEST_COLLECT_FAILED_POPUP)
                {
                    this.Escape();
                    SevenKnightsCore.Sleep(500);
                    return false;
                }
                return false;
            }
            if (scene.SceneType == SceneType.QUEST_REWARDS_POPUP)
            {
                this.WeightedClick(SharedPM.Rewards_OkButton, 1.0, 1.0, 1, 0, "left");
            }
            else
            {
                this.Escape();
            }
            SevenKnightsCore.Sleep(500);
            return true;
        }

        private void HeroSortReset(bool sortLevel = true, bool ascending = true)
        {
            if (sortLevel)
            {
                if (!this.MatchMapping(HeroesPM.SortByBoxExpanded, 2))
                {
                    this.WeightedClick(HeroesPM.SortByBox, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(300);
                }
                this.WeightedClick(HeroesPM.SortByLevel, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
            }
            PixelMapping mapping = ascending ? HeroesPM.SortButtonAscending : HeroesPM.SortButtonDescending;
            if (!this.MatchMapping(mapping, 2))
            {
                this.WeightedClick(HeroesPM.SortButton, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
            }
            this.ScrollHeroCards(false);
            SevenKnightsCore.Sleep(500);
        }

        private void InitLoop()
        {
            this.CurrentObjective = Objective.IDLE;
            this.NextPossibleObjective();
            this.MapCheckCount = 0;
            this.CurrentSequence = 0;
            this.CurrentSequenceCount = 0;
            this.CurrentSequenceCount2 = 0; //to stop auto repeat
            this.KeysBoughtHonors = 0;
            this.KeysBoughtRubies = 0;
            this.ArenaRubiesCount = 0;
            this.CollectQuestsCount = -1;
            this.CollectQuestsTotal = -1;
            this.HangCounter = 0;
            this.IdleCounter = 0;
            this.MapSelectCounter = 0;
            this.CooldownInbox = 0;
            this.CooldownQuests = 0;
            this.CooldownSendHonors = 0;
            this.CooldownSellHeroes = 0;
            this.CooldownSellItems = 0;
            this.AdventureCount = 0;
            this.SmartModeCount = 0;
            this.ArenaWinCount = 0;
            this.ArenaRank = 0;
            this.ArenaLoseCount = 0;
            this.ReportAllCount();
            this.AdventureLimitCount = 0;
            this.AdventureLimitCount2 = 0;
            this.entrytolv30 = 0;
            this.h30 = 0;
            this.ArenaLimitCount = 0;
            this.HeroCount = 0;
            this.ItemCount = 0;
            this.MaxHeroUpCount = false;
            this.nomorehero30 = false;
            this.AdventureKeys = -1;
            this.AdventureKeyTime = TimeSpan.MaxValue;
            this.TowerKeys = -1;
            this.TowerKeyTime = TimeSpan.MaxValue;
            this.ArenaKeys = -1;
            this.ArenaKeyTime = TimeSpan.MaxValue;
            this.ReportAllKeys();
            this.GoldCount = -1;
            this.RubyCount = -1;
            this.HonorCount = -1;
            this.TopazCount = -1;
            this.GoldenCrystalCount = 0;
            this.HornCount = 0;
            this.ScaleCount = 0;
            this.EssecenseCount = 0;
            this.StarCount = 0;
            this.ReportAllResources();
            this.OneSecTimer.Enabled = true;
            this.checkslothero = false;
            this.checkslotitem = false;
            this.IsAdventureLimit = false;
            this.herofull = false;
            this.itemfull = false;
            this.IsAlreadyAdvEnd = false;
            this.IsAlreadyAdvFight = false;
            this.IsAlreadyAdvLoot = false;
            this.internetdc = 0;
        }

        private bool IsAnyQuestsEnabled()
        {
            return this.IsSpecialQuestsEnabled() || this.IsQuestsEnabled();
        }

        private bool IsBuyKeysEnabled()
        {
            return this.IsBuyKeysHonors() || this.IsBuyKeysRubies();
        }

        private bool IsBuyKeysHonors()
        {
            return this.AISettings.RS_BuyKeyHonors;
        }

        private bool IsBuyKeysRubies()
        {
            return this.AISettings.RS_BuyKeyRubies && this.KeysBoughtRubies < this.AISettings.RS_BuyKeyRubiesAmount;
        }

        private bool IsGameActive()
        {
            IList text = this.BlueStacks.MainWindowAS.GetText();
            Console.Write(text.Contains("Seven Knights") || text.Contains("Android"));
            return text.Contains("Seven Knights") || text.Contains("Android");
        }

        private bool IsInboxEnabled()
        {
            return this.AISettings.RS_InboxHonors || this.AISettings.RS_InboxKeys || this.AISettings.RS_InboxGold || this.AISettings.RS_InboxRubies || this.AISettings.RS_InboxTickets;
        }

        private bool IsQuestsEnabled()
        {
            return this.AISettings.RS_QuestsBattle || this.AISettings.RS_QuestsHero || this.AISettings.RS_QuestsItem || this.AISettings.RS_QuestsSocial;
        }

        private bool IsSendHonorsEnabled()
        {
            return this.AISettings.RS_SendHonorsFacebook || this.AISettings.RS_SendHonorsInGame;
        }

        private bool IsSpecialQuestsEnabled()
        {
            return this.AISettings.RS_SpecialQuestsDaily || this.AISettings.RS_SpecialQuestsWeekly || this.AISettings.RS_SpecialQuestsMonthly;
        }

        private void Log(string message)
        {
            this.Log(message, Color.Black);
        }

        private void Log(string message, Color color)
        {
            ProgressArgs userState = new ProgressArgs(ProgressType.EVENT, message, color);
            this.Worker.ReportProgress(0, userState);
        }

        private void LogError(string message)
        {
            ProgressArgs userState = new ProgressArgs(ProgressType.ERROR, message);
            this.Worker.ReportProgress(0, userState);
        }

        private void LogScene(string scene)
        {
            string str = Utility.ToTitleCase(scene.Replace("_", " "));
            this.Log("Scene: " + str, Color.SlateGray);
        }

        private void LongSleep(int timeout, int interval = 1000)
        {
            int num = 0;
            while (!this.Worker.CancellationPending && num < timeout)
            {
                SevenKnightsCore.Sleep(interval);
                num += interval;
            }
        }

        public void MainLoop(object sender, DoWorkEventArgs e)
        {
            bool flag = false;
            bool flag2 = false;
            bool flag3 = false;
            this.Hottimeloop = true;
            this.CheckPlayaName = true;
            this.Log("Initializing AI...");
            this.BlueStacks = new BlueStacks();
            string errorMessage;
            if (!this.BlueStacks.Hook())
            {
                errorMessage = "LDPlayer is not active or not yet initialized";
                SendTelegram(this.AIProfiles.ST_TelegramChatID, "ERROR : LDPlayer is not active or not yet initialized");
                this.LogError(errorMessage);
                this.SynchronizationContext.Send(delegate (object callback)
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }, null);
                return;
            }
            if (this.BlueStacks.NeedWindowResize())
            {
                string text = "LDPlayer needs to be resized. Proceed?";
                SendTelegram(this.AIProfiles.ST_TelegramChatID, "ERROR : LDPlayer needs to be resized.Check now!");
                DialogResult dialogResult = MessageBox.Show(text, "Restart Required", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.OK)
                {
                    this.BlueStacks.ResizeWindow();
                    SevenKnightsCore.Sleep(1000);
                }
                return;
            }
            if (this.BlueStacks.IsGameInstalled())
            {
                if (!this.BlueStacks.IsGameActive())
                {
                    this.Log("Launching Seven Knights...");
                    this.BlueStacks.LaunchGame();
                    this.LongSleep(3000, 1000);
                }
                this.InitLoop();
                string value = null;
                while (!this.Worker.CancellationPending)
                {
                    try
                    {
                        if (!this.AIProfiles.TMP_Paused && !this.AIProfiles.TMP_WaitingForKeys && !this.AIProfiles.TMP_WaitingForInternet)
                        {
                            if (this.AIProfiles.ST_BlueStacksForceActive)
                            {
                                this.BlueStacks.MainWindowAS.BringToFront();
                            }
                            int sT_Delay = this.AIProfiles.ST_Delay;
                            SevenKnightsCore.Sleep(sT_Delay);
                            this.IdleCounter += sT_Delay;
                            this.HangCounter += sT_Delay;
                            this.MapSelectCounter += sT_Delay;
                            this.CooldownInbox -= sT_Delay;
                            this.CooldownQuests -= sT_Delay;
                            this.CooldownSendHonors -= sT_Delay;
                            this.CooldownSellHeroes -= sT_Delay;
                            this.CooldownSellItems -= sT_Delay;
                            this.CaptureFrame();
                            if (this.BlueStacks.MainWindowAS.CurrentFrame != null)
                            {
                                this.UpdateHangFingerprint();
                                if (this.HangCounter >= 30000)
                                {
                                    this.Log("Restarting Seven Knights", Color.DarkRed);
                                    SendTelegram(this.AIProfiles.ST_TelegramChatID, "The game is not responding... Bot will restart the game and continue.");
                                    this.HangCounter = 0;
                                    if (!this.BlueStacks.RestartGame(5))
                                    {
                                        errorMessage = "Restart failed";
                                        this.LogError(errorMessage);
                                        this.SynchronizationContext.Send(delegate (object callback)
                                        {
                                            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        }, null);
                                        break;
                                    }
                                    this.IdleCounter = 0;
                                    this.LongSleep(10000, 1000);
                                }
                                Scene scene = this.SceneSearch();
                                bool flag4 = false;
                                string text2 = "";
                                if (scene == null)
                                {
                                    Sleep(this.AIProfiles.ST_Delay);
                                    int sleep = 0;
                                    for (int i = 0; i < 6; i++)
                                    {
                                        this.CaptureFrame();
                                        scene = this.SearchScenes();
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
                                        this.IdleCounter += sT_Delay;
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
                                        this.Log("IdleTime = " + IdleCounter / 1000, Color.Orange);
                                    }
                                    this.LogScene(text2);
                                    value = text2;
                                    IdleCounter = 0;
                                }
                                if (flag4)
                                {
                                    if ((this.MatchMapping(SharedPM.BackButton, 2) && this.MatchMapping(SharedPM.BackButtonAnchor, 2)) || (this.MatchMapping(SharedPM.BackButton2, 2) && this.MatchMapping(SharedPM.BackButtonAnchor2, 2)))
                                    {
                                        this.LogScene("BACKABLE");
                                        this.Escape();
                                    }
                                    else if (this.IdleCounter >= sT_Delay)
                                    {
                                        this.Escape();
                                        this.Log("cannot find scene escape");
                                        this.Alert("Bot Error2");
                                        this.IdleCounter = 0;
                                    }
                                }
                                else
                                {
                                    if (scene.SceneType != SceneType.MAP_SELECT)
                                    {
                                        this.MapSelectCounter = 0;
                                    }
                                    if (scene.SceneType != SceneType.ADVENTURE_START && scene.SceneType != SceneType.MAP_SELECT && scene.SceneType != SceneType.ADVENTURE_READY && scene.SceneType != SceneType.MAP_SELECT_POPUP)
                                    {
                                        this.MapCheckCount = 0;
                                    }
                                    this.IdleCounter = 0;
                                    switch (scene.SceneType)
                                    {

                                        case SceneType._ANDROID_POPUP:
                                            if (this.AIProfiles.ST_ReconnectInterruptEnable)
                                            {
                                                this.LongSleep(this.AIProfiles.ST_ReconnectInterruptInterval * 60000, 1000);
                                                if (!this.BlueStacks.RestartGame(5))
                                                {
                                                    this.SynchronizationContext.Send(delegate (object callback)
                                                    {
                                                        MessageBox.Show("BlueStacks restart failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                    }, null);
                                                    return;
                                                }
                                            }
                                            break;

                                        case SceneType.BLUESTACK_HOME:
                                            this.BlueStacks.LaunchGame();
                                            break;

                                        case SceneType._DIALOG:
                                            this.Escape();
                                            SevenKnightsCore.Sleep(300);
                                            break;

                                        case SceneType.TAP_TO_PLAY:
                                            this.WeightedClick(TapToPlayPM.TapArea, 1.0, 1.0, 1, 0, "left");
                                            SevenKnightsCore.Sleep(2000);
                                            //this.LongSleep(5000, 1000);
                                            break;

                                        case SceneType.PAUSE:
                                            SevenKnightsCore.Sleep(500);
                                            this.WeightedClick(PausePM.ContinueButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.NOTICE:
                                            this.WeightedClick(NoticePM.CloseButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.CHECK_IN:
                                            this.Escape();
                                            break;

                                        case SceneType.DISCONNECTED_POPUP:
                                            this.WeightedClick(DisconnectedPopupPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                            this.LongSleep(3000, 1000);
                                            break;

                                        case SceneType.WIFI_WARNING_POPUP:
                                            this.WeightedClick(WifiWarningPopupPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.LOBBY:
                                            this.UpdateAdventureKeys(scene.SceneType);
                                            this.UpdateGold(scene.SceneType);
                                            this.UpdateRuby(scene.SceneType);
                                            this.UpdateHonor(scene.SceneType);
                                            if (this.CheckPlayaName == true)
                                            {
                                                this.WeightedClick(LobbyPM.MasteryButton, 1.0, 1.0, 1, 0, "left");
                                                SevenKnightsCore.Sleep(800);
                                                this.CaptureFrame();
                                                this.CheckOwnername();
                                                this.Escape();
                                                SevenKnightsCore.Sleep(800);
                                                this.CheckPlayaName = false;
                                            }
                                            if (this.AISettings.AD_HottimeEnable && this.Hottimeloop == true)
                                            {
                                                this.WeightedClick(LobbyPM.StatusBoard, 1.0, 1.0, 1, 0, "left");
                                                this.Hottimeloop = false;
                                                SevenKnightsCore.Sleep(800);
                                            }
                                            if (this.IsSendHonorsEnabled() && this.CooldownSendHonors <= 0)
                                            {
                                                this.CooldownSendHonors = 1800000;
                                                if (this.IsSendHonorsEnabled() && this.CurrentObjective != Objective.COLLECT_QUESTS && this.CurrentObjective != Objective.COLLECT_INBOX && this.CurrentObjective != Objective.SEND_HONORS && this.CurrentObjective != Objective.BUY_KEYS && this.CurrentObjective != Objective.SMART_MODE)
                                                {
                                                    this.ChangeObjective(Objective.SEND_HONORS);
                                                }
                                            }
                                            else if (this.MatchMapping(LobbyPM.QuestAvailable, 3) && this.IsAnyQuestsEnabled() && this.CooldownQuests <= 0)
                                            {
                                                this.CooldownQuests = 1800000;
                                                if (this.IsAnyQuestsEnabled() && this.CurrentObjective != Objective.COLLECT_QUESTS && this.CurrentObjective != Objective.COLLECT_INBOX && this.CurrentObjective != Objective.SEND_HONORS && this.CurrentObjective != Objective.BUY_KEYS && this.CurrentObjective != Objective.SMART_MODE)
                                                {
                                                    this.ChangeObjective(Objective.COLLECT_QUESTS);
                                                }
                                            }
                                            else if (this.MatchMapping(LobbyPM.InboxAvailable, 3) && this.IsInboxEnabled() && this.CooldownInbox <= 0)
                                            {
                                                this.CooldownInbox = 1800000;
                                                if (this.IsInboxEnabled() && this.CurrentObjective != Objective.COLLECT_INBOX && this.CurrentObjective != Objective.COLLECT_QUESTS && this.CurrentObjective != Objective.SEND_HONORS && this.CurrentObjective != Objective.BUY_KEYS && this.CurrentObjective != Objective.SMART_MODE)
                                                {
                                                    this.ChangeObjective(Objective.COLLECT_INBOX);
                                                }
                                            }
                                            if (this.CurrentObjective == Objective.ADVENTURE)
                                            {
                                                this.WeightedClick(LobbyPM.AdventureButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.ARENA)
                                            {
                                                this.WeightedClick(LobbyPM.AdventureButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.SMART_MODE)
                                            {
                                                this.WeightedClick(LobbyPM.SmartButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.SELL_HEROES)
                                            {
                                                this.WeightedClick(LobbyPM.HeroButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.CHECK_SLOT_HERO || this.CurrentObjective == Objective.CHECK_SLOT_ITEM)
                                            {
                                                this.NextPossibleObjective();
                                            }
                                            else if (this.CurrentObjective == Objective.BUY_KEYS)
                                            {
                                                this.WeightedClick(LobbyPM.ShopButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.COLLECT_INBOX)
                                            {
                                                this.WeightedClick(LobbyPM.InboxButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.COLLECT_QUESTS)
                                            {
                                                this.WeightedClick(LobbyPM.QuestButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.SEND_HONORS)
                                            {
                                                this.WeightedClick(LobbyPM.SocialButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.IDLE)
                                            {
                                                this.NextPossibleObjective();
                                            }
                                            break;
                                        case SceneType.MAP_SELECT:

                                            if (this.MapSelectCounter >= 10000)

                                            {

                                                this.WeightedClick(SharedPM.BackButton, 1.0, 1.0, 1, 0, "left");

                                                SevenKnightsCore.Sleep(500);

                                            }

                                            else if (this.CurrentObjective == Objective.ADVENTURE)

                                            {

                                                World world = this.AISettings.AD_World;

                                                int stage = this.AISettings.AD_Stage;

                                                if (this.AISettings.AD_World == World.Sequencer)

                                                {

                                                    Tuple<World, int> worldStageFromSequencer = this.GetWorldStageFromSequencer();

                                                    if (worldStageFromSequencer == null)

                                                    {

                                                        this.LogError("Stage sequence is empty");

                                                        this.NextPossibleObjective();

                                                        break;

                                                    }

                                                    world = worldStageFromSequencer.Item1;

                                                    stage = worldStageFromSequencer.Item2;

                                                }

                                                //this.Log("Wrold =" + world);

                                                if (world == World.ShadowsEye)

                                                {

                                                    //this.Log("ShadowsEYE");

                                                    //on ASGAR

                                                    if (this.MatchMapping(MapSelectPM.MoonBoatLitLeft, 2) && this.MatchMapping(MapSelectPM.MoonLitBoatRight, 2))

                                                    {

                                                        //this.Log("1,1");

                                                        this.WeightedClick(MapSelectPM.RightBottomBTN, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        this.CaptureFrame();
                                                            
                                                        //then

                                                    }

                                                    //on Aisha

                                                    if (this.MatchMapping(MapSelectPM.AishaBoatLeft, 2) && this.MatchMapping(MapSelectPM.AishaBoatRight, 2))

                                                    {

                                                        //this.Log("1,2");

                                                        this.WeightedClick(MapSelectPM.RightBottomBTN, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        this.CaptureFrame();

                                                    }



                                                    this.MapZone = "ShadowsEye";

                                                    this.SelectStageShadowsEye(world, stage);

                                                }

                                                else if (world == World.MoonlitIsle || world == World.WesternEmpire || world == World.EasternEmpire || world == World.DarkSanctuary)

                                                {

                                                    //this.Log("Aisha");

                                                    //on ASGAR

                                                    if (this.MatchMapping(MapSelectPM.MoonBoatLitLeft, 2) && this.MatchMapping(MapSelectPM.MoonLitBoatRight, 2))

                                                    {

                                                        //this.Log("2,1");

                                                        this.WeightedClick(MapSelectPM.RightBottomBTN, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        this.CaptureFrame();

                                                    }

                                                    this.MapZone = "Aisha";

                                                    this.SelectStageAisha(world, stage);

                                                }

                                                else

                                                {

                                                    //this.Log("Asgar");

                                                    //on shadow eye

                                                    if (this.MatchMapping(MapSelectPM.World12_1Anchor_1, 2) && this.MatchMapping(MapSelectPM.World12_1Anchor_2, 2))

                                                    {

                                                        //this.Log("3,1");

                                                        this.WeightedClick(MapSelectPM.RightBottomBTN, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        //then

                                                        this.CaptureFrame();

                                                    }

                                                    //on aisha

                                                    //if (this.MatchMapping(MapSelectPM.AishaBoatLeft, 2) && this.MatchMapping(MapSelectPM.AishaBoatRight, 2))

                                                    if (this.MatchMapping(MapSelectPM.AishaBoatLeft, 2) || this.MatchMapping(MapSelectPM.AishaBoatRight, 2))

                                                    {

                                                        //this.Log("3,2");

                                                        this.WeightedClick(MapSelectPM.QuickStartMidButton, 1.0, 1.0, 1, 0, "left");

                                                        SevenKnightsCore.Sleep(AIProfiles.ST_Delay);

                                                        this.CaptureFrame();

                                                    }



                                                    this.MapZone = "Asgar";

                                                    this.SelectStageAsgar(world, stage);

                                                }

                                            }

                                            else

                                            {

                                                this.Escape();

                                            }

                                            break;

                                        case SceneType.MAP_SELECT_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.FULL_ITEM_POPUP:
                                            if (this.AISettings.AD_StopOnFullItems)
                                            {
                                                this.Alert("Items Full");
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot has stopped because Your inventory is full");
                                                this.Escape();
                                            }
                                            if (!flag)
                                            {
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "Your inventory is full. Bot will start selling them if enabled.");
                                                flag = true;
                                            }
                                            if (this.AISettings.RS_SellItems && this.CooldownSellItems <= 0)
                                            {
                                                if (this.CurrentObjective != Objective.SELL_ITEMS)
                                                {
                                                    this.ChangeObjective(Objective.SELL_ITEMS);
                                                }
                                                this.WeightedClick(SharedPM.Full_SellButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.WeightedClick(SharedPM.Full_NoButton, 1.0, 1.0, 1, 0, "left");
                                                this.itemfull = false;
                                            }
                                            SevenKnightsCore.Sleep(500);
                                            break;

                                        case SceneType.FULL_HERO_POPUP:
                                            if (this.AISettings.AD_StopOnFullHeroes)
                                            {
                                                this.Alert("Heroes Full");
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot has stopped Because Your hero cards are full");
                                                this.Escape();
                                            }
                                            if (!flag2)
                                            {
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "Your hero cards are full. Bot will start selling them if enabled.");
                                                flag2 = true;
                                            }
                                            if (this.AISettings.RS_SellHeroes && this.CooldownSellHeroes <= 0)
                                            {
                                                if (this.CurrentObjective != Objective.SELL_HEROES)
                                                {
                                                    this.ChangeObjective(Objective.SELL_HEROES);
                                                }
                                                this.WeightedClick(SharedPM.Full_NoButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.WeightedClick(SharedPM.Full_ProceedButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            SevenKnightsCore.Sleep(500);
                                            break;


                                        case SceneType.ADVENTURE_READY:
                                            SevenKnightsCore.Sleep(600);
                                            if (this.CurrentObjective == Objective.ADVENTURE && ExpectingScene(SceneType.ADVENTURE_READY, 3, 500))
                                            {
                                                this.WeightedClick(AdventureReadyPM.ReadyButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.WeightedClick(AdventureReadyPM.CloseButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            SevenKnightsCore.Sleep(500);
                                            break;

                                        case SceneType.ADVENTURE_START:
                                            SevenKnightsCore.Sleep(600);
                                            if (this.MatchMapping(AdventureStartPM.Auto_KeyPlusButton, 2))
                                            {
                                                SevenKnightsCore.Sleep(2000);
                                            }
                                            if (this.CurrentObjective == Objective.ADVENTURE)
                                            {
                                                World world2 = this.AISettings.AD_World;
                                                int stage2 = this.AISettings.AD_Stage;
                                                if (this.AISettings.AD_World == World.Sequencer)
                                                {
                                                    Tuple<World, int> worldStageFromSequencer2 = this.GetWorldStageFromSequencer();
                                                    if (worldStageFromSequencer2 == null)
                                                    {
                                                        this.LogError("Stage sequence is empty");
                                                        this.NextPossibleObjective();
                                                        break;
                                                    }
                                                    world2 = worldStageFromSequencer2.Item1;
                                                    stage2 = worldStageFromSequencer2.Item2;
                                                }
                                                if (this.AISettings.AD_Continuous || this.CheckMapNumber(world2, stage2) || this.MapCheckCount >= 3)
                                                {
                                                    this.SelectTeam(SceneType.ADVENTURE_START);
                                                    if (this.AISettings.AD_UseFriend)
                                                    {
                                                        if (this.MatchMapping(AdventureStartPM.UseFriendOff, 2))
                                                        {
                                                            this.WeightedClick(SharedPM.UseFriendButton, 1.0, 1.0, 1, 0, "left");
                                                            SevenKnightsCore.Sleep(600);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (this.MatchMapping(AdventureStartPM.UseFriendOn, 2))
                                                        {
                                                            this.WeightedClick(SharedPM.UseFriendButton, 1.0, 1.0, 1, 0, "left");
                                                            SevenKnightsCore.Sleep(600);
                                                        }
                                                    }
                                                    if (this.AISettings.AD_BootMode)
                                                    {
                                                        if (this.MatchMapping(AdventureStartPM.BootmodeOff, 2))
                                                        {
                                                            this.WeightedClick(AdventureStartPM.UsedBootModeButton, 1.0, 1.0, 1, 0, "left");
                                                            SevenKnightsCore.Sleep(600);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (this.MatchMapping(AdventureStartPM.BootmodeOn, 2))
                                                        {
                                                            this.WeightedClick(AdventureStartPM.UsedBootModeButton, 1.0, 1.0, 1, 0, "left");
                                                            SevenKnightsCore.Sleep(600);
                                                        }
                                                    }
                                                    if (this.MatchMapping(AdventureStartPM.AutoRepeatOff, 2) && (!this.itemfull || !this.herofull))
                                                    {
                                                        this.WeightedClick(AdventureStartPM.AutoRepeatButton, 1.0, 1.0, 1, 0, "left");
                                                        SevenKnightsCore.Sleep(1000);
                                                    }
                                                    if (this.MatchMapping(AdventureStartPM.AutoRepeatOn, 2) && (!this.itemfull || !this.herofull))
                                                    {
                                                        this.WeightedClick(AdventureStartPM.AutoRepeatButton, 1.0, 1.0, 1, 0, "left");
                                                        SevenKnightsCore.Sleep(1000);
                                                    }
                                                    this.world3 = world2;
                                                    SevenKnightsCore.Sleep(500);
                                                    this.WeightedClick(SharedPM.PrepareFight_StartButton, 1.0, 1.0, 1, 0, "left");
                                                    SevenKnightsCore.Sleep(600);
                                                }
                                                else
                                                {
                                                    this.MapCheckCount++;
                                                    this.Escape();
                                                    SevenKnightsCore.Sleep(300);
                                                }
                                            }
                                            else if (this.CurrentObjective == Objective.CHECK_SLOT_HERO)
                                            {
                                                this.WeightedClick(SharedPM.PrepareFight_ManageButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.ADVENTURE_START_AUTO:
                                            SevenKnightsCore.Sleep(1000);
                                            break;

                                        case SceneType.NO_MORE_HERO_POPUP:
                                            if (this.AIProfiles.AD_NoHeroUp)
                                            {
                                                this.Alert("No More Hero 30");
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot has stopped Because No More Heroes to be replaced with");
                                                this.Escape();
                                            }
                                            else
                                            {
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "No More Heroes to be replaced, bot will disable adventure");
                                                this.DisableMode(Objective.ADVENTURE);
                                                this.Escape();
                                                this.NextPossibleObjective();
                                            }
                                            break;

                                        case SceneType.ADVENTURE_FIGHT:
                                            /*This created to avoid bot detect adventure_end scene when in boss round*/
                                            if (!this.IsAlreadyAdvFight)
                                            {
                                                this.IsAlreadyAdvFight = true;
                                                if (this.world3 < World.MoonlitIsle)
                                                {
                                                    SevenKnightsCore.Sleep(35000); //sleep 1 minute when battle 3 wave map 
                                                }
                                                else
                                                {
                                                    SevenKnightsCore.Sleep(25000); //sleep 30 second when battle in 2 wave map
                                                }
                                            }
                                            //this.PerformFightTatics(scene.SceneType);
                                            this.IsAlreadyAdvLoot = false;
                                            break;

                                        case SceneType.ADVENTURE_END:
                                            SevenKnightsCore.Sleep(500);
                                            this.CaptureFrame();
                                            Scene scenex = this.SceneSearch();
                                            SceneType sceneType2 = this.PreviousScene.SceneType;
                                            if (this.CurrentObjective == Objective.CHECK_SLOT_HERO)
                                            {
                                                this.WeightedClick(AdventureFightPM.StopButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            if (!this.IsAlreadyAdvEnd)
                                            {
                                                if ((!this.MatchMapping(SharedPM.Fight_PauseButton, 2) || !this.MatchMapping(SharedPM.Fight_ChatButton, 2)) && (sceneType2 != SceneType.ADVENTURE_LOOT_AUTO || sceneType2 != SceneType.VICTORY))
                                                {
                                                    this.EndAutoRepeat();
                                                }
                                                else
                                                {
                                                    SevenKnightsCore.Sleep(2500);
                                                }
                                            }
                                            else
                                            {
                                                SevenKnightsCore.Sleep(750);
                                            }
                                            break;

                                        case SceneType.ADVENTURE_LOST:
                                            this.AdventureAfterFight();
                                            this.Log("Your team lost the battle [Adventure]", this.COLOR_DEATH);
                                            SendTelegram(this.AIProfiles.ST_TelegramChatID, "[Adventure] Your team has lost a battle. Continuing AI.");
                                            this.WeightedClick(AdventureLostPM.AdventureButton, 1.0, 1.0, 1, 0, "left");
                                            this.LongSleep(2000, 1000);
                                            break;

                                        case SceneType.VICTORY:
                                            SevenKnightsCore.Sleep(250);
                                            this.IsAlreadyAdvEnd = false;
                                            break;

                                        case SceneType.AUTO_REPEAT_INFO:
                                                this.checkslothero = true;
                                                this.checkslotitem = true;
                                                if (this.AISettings.AD_CheckSlot)
                                                {
                                                    this.ChangeObjective(Objective.CHECK_SLOT_HERO);
                                                }
                                                this.WeightedClick(AutoRepeatInfoPM.CloseBtn, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.AUTO_REPEAT_STOP:
                                            SevenKnightsCore.Sleep(500);
                                            this.WeightedClick(AutoRepeatStopPM.YesButton, 1.0, 1.0, 1, 0, "left");
                                            SevenKnightsCore.Sleep(2200);
                                            break;

                                        case SceneType.AUTO_REPEAT_POPUP:
                                            SevenKnightsCore.Sleep(500);
                                            this.WeightedClick(AutoRepeatPopupPM.YesButton, 1.0, 1.0, 1, 0, "left");
                                            SevenKnightsCore.Sleep(2000);
                                            break;

                                        case SceneType.ADVENTURE_LOOT:
                                            if (!this.IsAlreadyAdvLoot)
                                            {
                                                this.AdventureAfterFight();
                                                SevenKnightsCore.Sleep(500);
                                                if (this.CurrentObjective == Objective.ADVENTURE)
                                                {
                                                    if (this.AISettings.AD_Continuous && this.AISettings.AD_World != World.Sequencer)
                                                    {
                                                        this.WeightedClick(AdventureLootPM.NextZoneButton, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else if (this.AISettings.AD_World == World.None)
                                                    {
                                                        this.WeightedClick(AdventureLootPM.QuickStartButton, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else
                                                    {
                                                        this.WeightedClick(AdventureLootPM.AgainButton, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                }
                                                else if (this.CurrentObjective == Objective.CHECK_SLOT_HERO)
                                                {
                                                    this.WeightedClick(AdventureLootPM.AgainButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    this.WeightedClick(SharedPM.Loot_LobbyButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                SevenKnightsCore.Sleep(3000);
                                            }
                                            else
                                            {
                                                SevenKnightsCore.Sleep(750);
                                            }
                                            break;
                                        case SceneType.ADVENTURE_LOOT_AUTO:
                                            if (!this.IsAlreadyAdvLoot)
                                            {
                                                this.AdventureAfterFight();
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
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "[Adventure] Bot will buy more keys or play other modes while waiting.");
                                                flag3 = true;
                                            }
                                            if (this.CurrentObjective != Objective.BUY_KEYS && this.AISettings.RS_BuyKeyHonors && this.KeysBoughtHonors < this.AISettings.RS_BuyKeyHonorsAmount)
                                            {
                                                this.ChangeObjective(Objective.BUY_KEYS);
                                                this.Escape();
                                            }
                                            else
                                            {
                                                this.Escape();
                                                this.NextPossibleObjective();
                                            }
                                            break;

                                        case SceneType.OUT_OF_KEYS_POPUP:
                                            if (!flag3)
                                            {
                                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "[Adventure] Bot will buy more keys or play other modes while waiting.");
                                                flag3 = true;
                                            }
                                            this.HandleOutOfKey(scene.SceneType);
                                            break;

                                        case SceneType.BATTLE_MODES:
                                            if (this.CurrentObjective == Objective.ARENA)
                                            {
                                                this.WeightedClick(BattleModesPM.ArenaButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else if (this.CurrentObjective == Objective.ADVENTURE)
                                            {
                                                this.WeightedClick(BattleModesPM.AdventureButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.ARENA_READY:
                                            this.UpdateArenaKeys();
                                            //this.UpdateRuby(scene.SceneType);
                                            //this.UpdateHonor(scene.SceneType);
                                            this.CheckArenaScoreReady();
                                            if (this.CurrentObjective == Objective.ARENA)
                                            {
                                                if (this.ArenaKeys > 0 || this.ArenaUseRuby())
                                                {
                                                    this.WeightedClick(ArenaReadyPM.ReadyButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    this.NextPossibleObjective();
                                                }
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.ARENA_START:
                                            if (this.CurrentObjective == Objective.ARENA)
                                            {
                                                bool flag5 = this.ArenaUseRuby();
                                                if (this.ArenaKeys > 0 || flag5)
                                                {
                                                    this.WeightedClick(ArenaStartPM.StartButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    this.NextPossibleObjective();
                                                }
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.ARENA_FIGHT:
                                            //nothing
                                            break;

                                        case SceneType.ARENA_END:
                                            if (this.MatchMapping(ArenaEndPM.GetStrongerButton, 2))
                                            {
                                                this.Log("Arena Lose", this.COLOR_ARENA);
                                                this.ArenaAfterFight(false);
                                            }
                                            else
                                            {
                                                this.Log("Arena Victory", this.COLOR_ARENA);
                                                this.ArenaAfterFight(true);
                                            }
                                            this.CheckArenaScore();
                                            if (this.CurrentObjective == Objective.ARENA)
                                            {
                                                this.WeightedClick(ArenaEndPM.QuickStartButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.WeightedClick(ArenaEndPM.LobbyButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            this.LongSleep(2000, 1000);
                                            break;

                                        case SceneType.ARENA_SEASON_END:
                                            SevenKnightsCore.Sleep(500);
                                            this.NextPossibleObjective();
                                            this.Escape();
                                            break;

                                        case SceneType.ARENA_FULL_HONOR_POPUP:
                                            if (this.AISettings.RS_BuyKeyHonors)
                                            {
                                                if (this.CurrentObjective != Objective.BUY_KEYS)
                                                {
                                                    this.ChangeObjective(Objective.BUY_KEYS);
                                                    this.Escape();
                                                }
                                                this.Escape();
                                            }
                                            else
                                            {
                                                this.WeightedClick(ArenaFullHonorPopupPM.YesButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            break;

                                        case SceneType.OUT_OF_SWORDS_POPUP:
                                            if (this.ArenaUseRuby())
                                            {
                                                this.Log(string.Format("Entering arena using Ruby ({0})", this.ArenaRubiesCount + 1), this.COLOR_ARENA);
                                                this.WeightedClick(OutOfSwordsPopupPM.EnterButton, 1.0, 1.0, 1, 0, "left");
                                                SevenKnightsCore.Sleep(1000);
                                                this.ArenaRubiesCount++;
                                            }
                                            else
                                            {
                                                this.Escape();
                                                this.NextPossibleObjective();
                                            }
                                            SevenKnightsCore.Sleep(1000);
                                            break;

                                        case SceneType.LEVEL_UP_DIALOG:
                                            this.Log("Player Level Up", this.COLOR_LEVEL_UP);
                                            this.WeightedClick(LevelUpDialogPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                            SevenKnightsCore.Sleep(300);
                                            break;

                                        case SceneType.LEVEL_30_DIALOG:
                                        case SceneType.LEVEL_30_MAX_DIALOG:
                                            this.Log("Hero Level 30", this.COLOR_LEVEL_30);
                                            this.WeightedClick(Level30MaxDialogPM.OkButton, 1.0, 1.0, 1, 0, "left");
                                            SevenKnightsCore.Sleep(300);
                                            break;

                                        case SceneType.HEROES:
                                            SevenKnightsCore.Sleep(500);
                                            if (this.CurrentObjective == Objective.CHECK_SLOT_HERO)
                                            {
                                                if (this.checkslothero)
                                                {
                                                    this.UpdateHeroCount();
                                                    this.checkslothero = false;
                                                }
                                                else if (this.checkslotitem)
                                                {
                                                    this.WeightedClick(HeroesPM.HeroCard1, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    this.Escape();
                                                }
                                                ReportCheckSlot(Objective.CHECK_SLOT_HERO);
                                                SevenKnightsCore.Sleep(1500);
                                            }
                                            else if (this.CurrentObjective == Objective.CHECK_SLOT_ITEM)
                                            {
                                                this.WeightedClick(HeroesPM.HeroCard1, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.ITEMS:
                                            SevenKnightsCore.Sleep(500);
                                            if (this.CurrentObjective == Objective.CHECK_SLOT_ITEM)
                                            {
                                                if (this.checkslotitem)
                                                {
                                                    this.UpdateItemCount();
                                                }
                                                else
                                                {
                                                    this.Escape();
                                                }
                                                ReportCheckSlot(Objective.CHECK_SLOT_ITEM);
                                                SevenKnightsCore.Sleep(1500);
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.HEROES_SAME_TEAM_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.HERO_JOIN:
                                            SevenKnightsCore.Sleep(500);
                                            if (this.CurrentObjective == Objective.CHECK_SLOT_ITEM && this.checkslotitem == true && this.PreviousObjective == Objective.CHECK_SLOT_HERO)
                                            {
                                                this.WeightedClick(HeroJoinPM.ItemButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.HERO_REMOVE:
                                            if (this.CurrentObjective == Objective.CHECK_SLOT_ITEM && this.checkslotitem == true && this.PreviousObjective == Objective.CHECK_SLOT_HERO)
                                            {
                                                this.WeightedClick(HeroJoinPM.ItemButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;
                                        case SceneType.SELL_HERO_CONFIRM_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.SELL_ITEM_POPUP:
                                            if (this.AISettings.RS_SellItems)
                                            {
                                                if (this.CurrentObjective != Objective.SELL_ITEMS)
                                                {
                                                    this.ChangeObjective(Objective.SELL_ITEMS);
                                                }
                                                this.SellItems();
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.SELL_ITEM_LOBBY:
                                            if (this.CurrentObjective == Objective.SELL_ITEMS)
                                            {
                                                this.SellItems();
                                            }

                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.SELL_ITEM_SUCCESS_POPUP:
                                            this.Escape();
                                            break;
                                        case SceneType.SELL_HEROES_SUCCESS_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.SELL_ITEM_CONFIRM_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.LOOT_HERO:
                                            this.Escape();
                                            break;

                                        case SceneType.LOOT_ITEM:
                                            this.Escape();
                                            break;

                                        case SceneType.SHOP_LOBBY:
                                            if (this.CurrentObjective == Objective.BUY_KEYS)
                                            {
                                                this.WeightedClick(ShopPM.CommonShop, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.SHOP:
                                            if (this.CurrentObjective == Objective.BUY_KEYS)
                                            {
                                                this.BuyKeys();
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.SMART_SELECT:
                                            if (this.CurrentObjective == Objective.SMART_MODE)
                                            {
                                                this.WeightedClick(SmartSelectPM.CelestialTowerButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.SMART_LOOT_COLLECT_LOBBY:
                                            if(this.CurrentObjective == Objective.SMART_MODE)
                                            {
                                                this.Escape();
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.SMART_LOBBY:
                                            if (this.CurrentObjective == Objective.SMART_MODE)
                                            {
                                                this.HandleSmartMode();
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;
                                        case SceneType.SHOP_BUY_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.SHOP_BUY_FAILED_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.SHOP_PURCHASE_COMPLETE_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.INBOX:
                                            if (this.IsInboxEnabled())
                                            {
                                                if (this.CurrentObjective != Objective.COLLECT_INBOX && this.PreviousObjective != Objective.COLLECT_INBOX)
                                                {
                                                    this.ChangeObjective(Objective.COLLECT_INBOX);
                                                }
                                                if (this.CurrentObjective == Objective.COLLECT_INBOX)
                                                {
                                                    this.CollectInbox();
                                                }
                                                else
                                                {
                                                    this.Escape();
                                                }
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.INBOX_REWARDS_POPUP:
                                            this.WeightedClick(SharedPM.Rewards_OkButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.INBOX_COLLECT_FAILED_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.INBOX_SELECT_HERO:
                                            this.Escape();
                                            break;

                                        case SceneType.QUEST_SELECT:
                                            if (this.CurrentObjective == Objective.COLLECT_QUESTS && this.IsAnyQuestsEnabled())
                                            {
                                                bool flag6 = this.IsSpecialQuestsEnabled() && this.MatchMapping(QuestSelectPM.SpecialQuestAvailable, 4);
                                                bool flag7 = this.IsQuestsEnabled() && this.MatchMapping(QuestSelectPM.QuestAvailable, 4);
                                                if (this.CollectQuestsTotal == -1 || this.CollectQuestsCount == -1)
                                                {
                                                    this.CollectQuestsCount = 0;
                                                    this.CollectQuestsTotal = 0;
                                                    if (flag6)
                                                    {
                                                        this.CollectQuestsTotal++;
                                                    }
                                                    if (flag7)
                                                    {
                                                        this.CollectQuestsTotal++;
                                                    }
                                                }
                                                if (this.CollectQuestsCount == 0 && this.CollectQuestsTotal == 1)
                                                {
                                                    if (flag6)
                                                    {
                                                        this.WeightedClick(QuestSelectPM.SpecialQuestButton, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                    else if (flag7)
                                                    {
                                                        this.WeightedClick(QuestSelectPM.QuestButton, 1.0, 1.0, 1, 0, "left");
                                                    }
                                                }
                                                else if (this.CollectQuestsCount == 0 && this.CollectQuestsTotal == 2)
                                                {
                                                    this.WeightedClick(QuestSelectPM.SpecialQuestButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                else
                                                {
                                                    if (this.CollectQuestsCount != 1 || this.CollectQuestsTotal != 2)
                                                    {
                                                        this.DoneCollectAllQuests();
                                                        break;
                                                    }
                                                    this.WeightedClick(QuestSelectPM.QuestButton, 1.0, 1.0, 1, 0, "left");
                                                }
                                                this.LongSleep(1000, 1000);
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.SPECIAL_QUEST:
                                            if (this.CurrentObjective == Objective.COLLECT_QUESTS && this.IsSpecialQuestsEnabled())
                                            {
                                                this.CollectSpecialQuests();
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.QUEST:
                                            if (this.CurrentObjective == Objective.COLLECT_QUESTS && this.IsQuestsEnabled())
                                            {
                                                this.CollectQuests();
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.QUEST_REWARDS_POPUP:
                                            this.WeightedClick(SharedPM.Rewards_OkButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.QUEST_COLLECT_FAILED_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.SOCIAL_SELECT:
                                            if (this.CurrentObjective == Objective.SEND_HONORS && this.IsSendHonorsEnabled())
                                            {
                                                this.WeightedClick(SocialSelectPM.FriendsButton, 1.0, 1.0, 1, 0, "left");
                                                SevenKnightsCore.Sleep(500);
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.FRIENDS:
                                            if (this.CurrentObjective == Objective.SEND_HONORS && this.IsSendHonorsEnabled())
                                            {
                                                this.SendHonors();
                                            }
                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.SEND_HONOR_SENDING_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.SEND_HONOR_FAILED_POPUP:
                                            this.WeightedClick(SendHonorFailedPopupPM.YellowTick, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.SEND_HONOR_CONFIRM_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.SEND_HONOR_END_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.SEND_HONOR_FULL_POPUP:
                                            this.Escape();
                                            break;

                                        case SceneType.SPECIAL_QUEST_POPUP:
                                            this.WeightedClick(Popup3PM.QuestRedCrossButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.EVENT_PACKAGE_POPUP:
                                            this.WeightedClick(Popup3PM.EventPackCloseBtn, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.ARENA_WEEK_REWARD:
                                            this.Escape();
                                            break;

                                        case SceneType.DAILY_QUEST_COMPLETE:
                                            this.WeightedClick(QuestRewardsPopupPM.OKButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.STATUS_BOARD:
                                            SevenKnightsCore.Sleep(300);
                                            if (this.MatchMapping(StatusBoardPM.ContentsTabSelect, 2) && this.MatchMapping(StatusBoardPM.HottimeRedIcon, 2))
                                            {
                                                this.WeightedClick(StatusBoardPM.HottimeTab, 1.0, 1.0, 1, 0, "left");
                                                SevenKnightsCore.Sleep(800);
                                                this.WeightedClick(StatusBoardPM.ActiveHottimeButton, 1.0, 1.0, 1, 0, "left");
                                            }
                                            else
                                            {
                                                this.DoneHottime();
                                            }
                                            break;

                                        case SceneType.HOTTIME_CONFIRM_POPUP:
                                            if (this.MatchMapping(StatusBoardPM.ConfirmOKtick, 2) && this.MatchMapping(StatusBoardPM.NoRedCloss, 2) && this.MatchMapping(StatusBoardPM.ActiveBG, 2))
                                            {
                                                this.WeightedClick(StatusBoardPM.OKButton, 1.0, 1.0, 1, 0, "left");
                                                this.Log("Hottime Active", Color.Brown);
                                                this.DoneHottime();
                                            }
                                            break;

                                        case SceneType.SELL_HERO_FINISH:
                                            this.WeightedClick(SellHeroConfirmPopupPM.SoldOKButton, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.RANK_UP:
                                            this.WeightedClick(ArenaEndPM.RankUpTik, 1.0, 1.0, 1, 0, "left");
                                            break;

                                        case SceneType.SELL_HERO_LOBBY:
                                            if (this.CurrentObjective == Objective.SELL_HEROES)
                                            {
                                                this.SellHeroes();
                                            }

                                            else
                                            {
                                                this.Escape();
                                            }
                                            break;

                                        case SceneType.HELPED_FRIEND:
                                            this.Escape();
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                this.Log("Main Frame error?");
                            }
                        }
                        else if (this.AIProfiles.TMP_WaitingForInternet && IsConnectedToInternet())
                        {
                            this.Log("Internet is connected, Game Resuming");
                            this.AIProfiles.TMP_WaitingForInternet = false;
                            this.BlueStacks.LaunchGame();
                        }
                        else if (this.AIProfiles.TMP_WaitingForKeys)
                        {
                            Random rnd = new Random();
#if DEBUG
							if ((this.AISettings.AD_Enable && this.AdventureKeys >= 1 && rnd.Next(1, (int)this.AdventureKeyTime.TotalMinutes) == 1) ||
								(this.AISettings.AR_Enable && this.ArenaKeys >= 1 && rnd.Next(1, (int)this.ArenaKeyTime.TotalMinutes) == 1))
#else
                            if ((this.AISettings.AD_Enable && this.AdventureKeys >= 10 && rnd.Next(1, (int)this.AdventureKeyTime.TotalSeconds) == 1) ||
                                (this.AISettings.AR_Enable && this.ArenaKeys >= 4 && rnd.Next(1, (int)this.ArenaKeyTime.TotalSeconds) == 1))
#endif
                            {
                                int resumeIn = rnd.Next(1, 60);
                                this.Log("Resuming in " + resumeIn + " seconds");
                                Sleep(resumeIn * 1000);
                                this.BlueStacks.LaunchGame();
                                this.AIProfiles.TMP_WaitingForKeys = false;
                                this.Log("Keys sufficiently Replenished. Resuming");
                            }
                        }
                        if (!this.AIProfiles.TMP_WaitingForKeys &&
                            this.AISettings.GB_WaitForKeys &&
                            (!this.AISettings.AD_Enable || this.AdventureKeys == 0) &&
                            (!this.AISettings.AR_Enable || this.ArenaKeys == 0))
                        {
                            this.AIProfiles.TMP_WaitingForKeys = true;
                            this.Log("Waiting for keys to replenish");
                            this.BlueStacks.TerminateGame();
                        }
                        MousePos();
                    }
                    catch (Exception ex)
                    {
                        this.Log(ex.Message.ToString());
                        this.LogError(ex.Message);
                        this.LogError(ex.ToString());
                    }
                }
                this.OneSecTimer.Enabled = false;
                return;
            }
            else
            {
                this.Log("7K ga keinstall");
                errorMessage = "Seven Knights not installed in BlueStacks";
                this.LogError(errorMessage);
                this.SynchronizationContext.Send(delegate (object callback)
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }, null);
            }
        }

        //This Function accepts a PixelMapping and send through to MatchPixel.
        private bool MatchMapping(PixelMapping mapping, int tolerance = 2, bool log = false)
        {
            // If if either log paramater or the log property of the mapping it will send true.
            return this.MatchPixel(mapping.X, mapping.Y, mapping.Color, tolerance, log || mapping.Log);
        }

        //This accepts X and Y coords and expected colour as an Argb integer.
        //The Tolerance is how much of a difference between each colour there in the actual pixel and the expected.
        private bool MatchPixel(int x, int y, int color, int tolerance = 2, bool log = false)
        {
            //Grab the Pixel.
            int currentPixel = this.GetPixel(x, y);
            //Log to the Log if it's true current pixel if log is true
            if (log)
            {
                this.Log("X = " + x.ToString() + ", Y = " + y.ToString() + ", Color = " + currentPixel.ToString() + ",");
            }
            //Generate Color objects for each the Target Colour and the Actual Colour.
            Color currentColour = Color.FromArgb(currentPixel);
            Color targetColour = Color.FromArgb(color);
            //this is where we calculate the varience to compare against the tolerance.
            int variance = (int)(Math.Max(currentColour.R, targetColour.R) - Math.Min(currentColour.R, targetColour.R) + (Math.Max(currentColour.G, targetColour.G) - Math.Min(currentColour.G, targetColour.G)) + (Math.Max(currentColour.B, targetColour.B) - Math.Min(currentColour.B, targetColour.B)));
            //Check the variance vs tolerance and returns the result.
            return variance <= tolerance;
        }

        private void MousePos()
        {
            if (this.AIProfiles.TMP_LogPixel && this.AIProfiles.TMP_Paused)
            {
                Sleep(500);
                Point mousePos = this.BlueStacks.GetMousePos();
                mousePos.X = mousePos.X - BlueStacks.OFFSET_X;
                mousePos.Y = mousePos.Y - BlueStacks.OFFSET_Y;

                if (this.AIProfiles.TMP_LogPixel)
                {
                    if (this.AIProfiles.TMP_Paused)
                        this.CaptureFrame();
                    int colour = this.BlueStacks.GetPixel(mousePos);
                    if (colour != -1)
                    {
                        string message = "X = " + (mousePos.X + ", Y = " + mousePos.Y + ", Color = " + colour);
                        this.Log(message);
                    }
                    this.AIProfiles.TMP_LogPixel = false;
                }
                if (this.AIProfiles.TMP_Paused)
                {
                    ProgressArgs cursorUpdate = new ProgressArgs(ProgressType.CURSORPOS, mousePos);
                    this.Worker.ReportProgress(0, cursorUpdate);
                    Sleep(1000);
                }
            }
        }

        private void NextPossibleObjective()
        {
            bool aD_Enable = this.AISettings.AD_Enable;
            bool aR_Enable = this.AISettings.AR_Enable;
            bool sM_Enable = this.AISettings.SM_Enable;
            switch (this.CurrentObjective)
            {
                case Objective.IDLE:
                    if (aD_Enable)
                    {
                        this.IsAdventureLimit = false;
                        this.ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    if (aR_Enable)
                    {
                        this.ChangeObjective(Objective.ARENA);
                        return;
                    }
                    if (sM_Enable)
                    {
                        this.ChangeObjective(Objective.SMART_MODE);
                        return;
                    }
                    break;

                case Objective.ADVENTURE:
                    if (sM_Enable)
                    {
                        this.ChangeObjective(Objective.SMART_MODE);
                        return;
                    }
                    if (aR_Enable)
                    {
                        this.ChangeObjective(Objective.ARENA);
                        return;
                    }
                    this.ChangeObjective(Objective.IDLE);
                    return;

                case Objective.ARENA:
                    if (aD_Enable)
                    {
                        this.IsAdventureLimit = false;
                        this.ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    if (sM_Enable)
                    {
                        this.ChangeObjective(Objective.SMART_MODE);
                        return;
                    }
                    this.ChangeObjective(Objective.IDLE);
                    return;

                case Objective.SMART_MODE:
                    if (aR_Enable)
                    {
                        this.ChangeObjective(Objective.ARENA);
                        return;
                    }
                    if (aD_Enable)
                    {
                        this.IsAdventureLimit = false;
                        this.ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    this.ChangeObjective(Objective.IDLE);
                    return;

                case Objective.CHECK_SLOT_ITEM:
                    if (aD_Enable && (!this.IsAdventureLimit || this.AdventureLimitCount < this.AISettings.AD_Limit))
                    {
                        this.ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    if (sM_Enable)
                    {
                        this.ChangeObjective(Objective.SMART_MODE);
                        return;
                    }
                    if (aR_Enable)
                    {
                        this.ChangeObjective(Objective.ARENA);
                        return;
                    }
                    this.ChangeObjective(Objective.IDLE);
                    return;
                case Objective.CHECK_SLOT_HERO:
                    if (aD_Enable && this.AdventureLimitCount < this.AISettings.AD_Limit && !this.IsAdventureLimit)
                    {
                        this.ChangeObjective(Objective.ADVENTURE);
                        return;
                    }
                    if (sM_Enable)
                    {
                        this.ChangeObjective(Objective.SMART_MODE);
                        return;
                    }
                    if (aR_Enable)
                    {
                        this.ChangeObjective(Objective.ARENA);
                        return;
                    }
                    this.ChangeObjective(Objective.IDLE);
                    return;
                case Objective.SELL_HEROES:
                case Objective.SELL_ITEMS:
                    if (this.PreviousObjective != this.CurrentObjective)
                    {
                        this.ChangeObjective(this.PreviousObjective);
                        return;
                    }
                    this.ChangeObjective(Objective.IDLE);
                    break;

                case Objective.BUY_KEYS:
                case Objective.COLLECT_INBOX:
                case Objective.COLLECT_QUESTS:
                case Objective.SEND_HONORS:
                    if (this.PreviousObjective == Objective.IDLE || this.PreviousObjective == Objective.ADVENTURE || this.PreviousObjective == Objective.ARENA)
                    {
                        this.ChangeObjective(this.PreviousObjective);
                        return;
                    }
                    this.ChangeObjective(Objective.IDLE);
                    return;

                default:
                    return;
            }
        }

        private void OnOneSecEvent(object source, ElapsedEventArgs e)
        {
            if (this.AIProfiles.ST_EnableHotTimeProfile && ((HotTimeHelper.IsNowHotTime() && !this.AIProfiles.TMP_UsingHotTimeProfile) || (!HotTimeHelper.IsNowHotTime() && this.AIProfiles.TMP_UsingHotTimeProfile)))
            {
                this.AIProfiles.ToggleHotTimeProfile();
                MainForm.Instance.InvokeReloadTabs(true);
            }
            if (this.AIProfiles.ST_EnableAutoProfile && MaxHeroUpCount)
            {
                this.MaxHeroUpCount = false;
                this.AIProfiles.ToggleHotTimeProfile();
                MainForm.Instance.InvokeReloadTabs(true);
            }
            if (this.AIProfiles.AD_NoHeroUp && nomorehero30)
            {
                this.nomorehero30 = false;
                this.Alert("No More Hero 30");
                //this.AIProfiles.ToggleHotTimeProfile();
                //MainForm.Instance.InvokeReloadTabs(true);
            }
            if (this.AIProfiles.ST_EnableAutoShutdown && MaxHeroUpCount)
            {
                this.Log("Shutdown Now!");
                Process.Start("shutdown", "/s /f /t 0");
                this.SendTelegram(this.AIProfiles.ST_TelegramChatID, "Max Hero lvl up 100/100, PC Will shutdown");
            }
            if (this.AIProfiles.AD_Pause100 && MaxHeroUpCount)
            {
                MaxHeroUpCount = false;
                this.SendTelegram(this.AIProfiles.ST_TelegramChatID, "Max Hero lvl up 100/100, Bot Paused");
                this.Alert("Max Level Up");
            }

            if (!IsConnectedToInternet())
            {
                this.internetdc += 1;
            }
            else
            {
                this.internetdc = 0;
            }
            if (this.internetdc >= 10)
            {
                this.AIProfiles.TMP_WaitingForInternet = true;
                this.Log("Waiting for Internet to reconnect");
                this.BlueStacks.TerminateGame();
            }

            TimeSpan ts = TimeSpan.FromSeconds(1.0);
            if (this.AdventureKeyTime != TimeSpan.MaxValue)
            {
                this.AdventureKeyTime = this.AdventureKeyTime.Subtract(ts);
            }
            if (this.TowerKeyTime != TimeSpan.MaxValue)
            {
                this.TowerKeyTime = this.TowerKeyTime.Subtract(ts);
            }
            if (this.ArenaKeyTime != TimeSpan.MaxValue)
            {
                this.ArenaKeyTime = this.ArenaKeyTime.Subtract(ts);
            }
            if (this.AdventureKeyTime == TimeSpan.Zero)
            {
                this.AdventureKeyTime = new TimeSpan(0, 10, 0);
                if (this.AdventureKeys < 11)
                {
                    this.AdventureKeys++;
                }
                else
                {
                    this.AdventureKeyTime = TimeSpan.MaxValue;
                }
            }
            if (this.TowerKeyTime == TimeSpan.Zero)
            {
                this.TowerKeyTime = new TimeSpan(0, 30, 0);
                if (this.TowerKeys < 5)
                {
                    this.TowerKeys++;
                }
                else
                {
                    this.TowerKeyTime = TimeSpan.MaxValue;
                }
            }
            if (this.ArenaKeyTime == TimeSpan.Zero)
            {
                this.ArenaKeyTime = new TimeSpan(0, 30, 0);
                if (this.ArenaKeys < 5)
                {
                    this.ArenaKeys++;
                }
                else
                {
                    this.ArenaKeyTime = TimeSpan.MaxValue;
                }
            }
            this.ReportAllKeys();
        }

        private int ParseAdventureKeys(Rectangle rect)
        {
            int num = -1;
            int result = 0;
            TimeSpan adventureKeyTime = TimeSpan.MaxValue;
            using (Bitmap bitmap3 = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(200))
            {
#if DEBUG
                bitmap3.Save("r_normalbase.png");
#endif
                using (Page page3 = this.Tesseractor.Engine.Process(bitmap3, null))
                {
                    string text3 = page3.GetText().Replace(" ", "").Replace("f", "").Replace("ﬁ", "").Replace("-", "").Replace("‘", "").Replace(",", "").Replace("l", "1").Replace(".", "").Replace("'", "").Replace("~", "").Trim();
                    Utility.FilterAscii(text3);
                    string text4 = Regex.Replace(text3, @"\t|\n|\r", "|");
                    this.Log(text4);
                    //bitmap3.Save("AdvKey.png");
                    if (text4.ToLower().Contains("|"))
                    {
                        string[] array = text4.Split(new char[]
{
                            '|'
                        });
                        if (array.Length >= 1)
                        {
                            int.TryParse(array[0].Substring(1), out result);
                            string time = array[1];
                            string s = time.Substring(0, 2);
                            string s2 = time.Substring(3, 2);
                            int minutes;
                            int.TryParse(s, out minutes);
                            int seconds;
                            int.TryParse(s2, out seconds);
                            adventureKeyTime = new TimeSpan(0, minutes, seconds);
                        }
                    }
                    if (result > 0)
                    {
                        num = result;
                    }
                    else if (text3.ToLower().Contains("x"))
                    {
                        int.TryParse(text3.Substring(1), out num);
                    }
                    else if (text3.ToLower().Contains("X"))
                    {
                        int.TryParse(text3.Substring(1), out num);
                    }
                    else
                    {
                        this.AdventureKeys = 0;
                        num = 0;
                        this.AdventureKeyTime = adventureKeyTime;
                    }
                }
            }
            this.AdventureKeyTime = adventureKeyTime;
            return num;
        }

        private int ParseGold(Rectangle rect)
        {
            int result = -1;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = this.ReplaceNumericResource(page.GetText());
                    if (text.Length >= 1)
                    {
                        int.TryParse(text, out result);
                    }
                }
            }
            return result;
        }

        private int ParseSmartResource(Rectangle rect)
        {
            int result = -1;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = this.ReplaceNumericResource(page.GetText());
                    this.Log("Smart Text: " + text);
                    if (text.Length >= 1)
                    {
                        int.TryParse(text, out result);
                    }
                }
            }
            return result;
        }

        private int ParseHonor(Rectangle rect)
        {
            int result = -1;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = this.ReplaceNumericResource(page.GetText().ToLower().Trim());
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
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(175))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = this.ReplaceNumericResource(page.GetText().Trim());
                    if (text.Length >= 1)
                    {
                        int.TryParse(text, out result);
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
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, r_TopazBase))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = this.ReplaceNumericResource(page.GetText());
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
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(250))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null, PageSegMode.Auto))
                {
                    string text = page.GetText().ToLower().Replace("accpired", "").Replace("acquired", "").Replace("acmired", "").Trim();
                    string text2 = text.Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
    .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace("Z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
    .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3").Trim();

                    //this.Log("OldText =" + "'" + page.GetText().ToLower() + "'");
                    string text1 = Regex.Replace(text2, @"\D", "");
                    Utility.FilterAscii(text1);
                    //bitmap.Save("GoldAdv.png");
                    //this.Log("NewText = " + text1);
                    int.TryParse(text1, out num);
#if DEBUG
                    bitmap.Save("HeroCount.png");
                    Console.WriteLine("NewText = " + text1);
#endif
                }
            }
            this.goldadv += num;
        }

        private void ParseItemAutoRepeat()
        {
            Rectangle rect = AutoRepeatInfoPM.Item;
            int num = 0;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(200))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null, PageSegMode.Auto))
                {
                    string text = page.GetText().ToLower().Replace("accpired", "").Replace("acquired", "").Replace("acmired", "").Trim();
                    string text2 = text.Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
    .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace("Z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
    .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3").Trim();
                    //this.Log("OldText =" + "'" + text2 + "'");
                    string text1 = Regex.Replace(text2, @"\D", "");
                    Utility.FilterAscii(text1);
                    //bitmap.Save("ItemAdv.png");
                    //this.Log("NewText = " + text1);
                    int.TryParse(text1, out num);
#if DEBUG
                    bitmap.Save("HeroCount.png");
                    Console.WriteLine("NewText = " + text1);
#endif
                }
            }
            this.itemadv += num;
        }

        private void ParseHeroAutoRepeat()
        {
            Rectangle rect = AutoRepeatInfoPM.Hero;
            int num = 0;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(200))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null, PageSegMode.Auto))
                {
                    string text = page.GetText().ToLower().Replace("accpired", "").Replace("acquired", "").Replace("acmired", "").Trim();
                    string text2 = text.Replace("l", "1").Replace(".", "").Replace(" ", "").Replace("s", "5")
    .Replace("o", "0").Replace("i", "1").Replace("z", "2").Replace("Z", "2").Replace(")", "").Replace("j", "").Replace("_", "")
    .Replace("‘", "").Replace("'", "").Replace(":", "").Replace("$", "5").Replace("e", "").Replace("q", "2").Replace("§", "3").Trim();

                    //this.Log("OldText =" + "'" + text2 + "'");
                    string text1 = Regex.Replace(text2, @"\D", "");
                    Utility.FilterAscii(text1);
                    //bitmap.Save("HeroAdv.png");
                    //this.Log("NewText = " + text1);
                    int.TryParse(text1, out num);
#if DEBUG
                    bitmap.Save("HeroCount.png");
                    Console.WriteLine("NewText = " + text1);
#endif
                }
            }
            this.heroadv += num;
        }

        private void ProgressSequence()
        {
            if (this.AISettings.AD_World != World.Sequencer)
            {
                return;
            }
            if (this.AISettings.AD_WorldSequence == null || this.AISettings.AD_StageSequence == null || this.AISettings.AD_AmountSequence == null)
            {
                return;
            }
            if (this.AISettings.AD_WorldSequence.Length <= 0 || this.AISettings.AD_StageSequence.Length <= 0 || this.AISettings.AD_AmountSequence.Length <= 0)
            {
                return;
            }
            if (this.CurrentSequence >= this.AISettings.AD_WorldSequence.Length || this.CurrentSequence >= this.AISettings.AD_StageSequence.Length || this.CurrentSequence >= this.AISettings.AD_AmountSequence.Length)
            {
                this.CurrentSequence = 0;
                return;
            }
            int num = this.AISettings.AD_WorldSequence.Length;
            int arg_CF_0 = this.AISettings.AD_WorldSequence[this.CurrentSequence];
            int arg_E2_0 = this.AISettings.AD_StageSequence[this.CurrentSequence];
            int num2 = this.AISettings.AD_AmountSequence[this.CurrentSequence];
            this.CurrentSequenceCount++;
            if (this.CurrentSequenceCount >= num2)
            {
                this.CurrentSequenceCount = 0;
                this.CurrentSequence++;
                if (this.CurrentSequence >= num)
                {
                    this.CurrentSequence %= num;
                }
            }
            this.Log("Progress Sequence : " + this.CurrentSequenceCount);
        }

        private string ReplaceNumericResource(string text)
        {
            return Utility.FilterAscii(text).ToLower().Replace("o", "0").Replace("l", "1").Replace("s", "8").Replace(",", "").Replace(".", "");
        }

        private void ReportAllCount()
        {
            this.ReportCount(Objective.ADVENTURE);
            this.ReportArenaCount();
        }

        private void ReportAllKeys()
        {
            this.ReportKeys(Objective.ADVENTURE);
            this.ReportKeys(Objective.ARENA);
        }

        private void ReportAllResources()
        {
            this.ReportResources(ResourceType.GOLD);
            this.ReportResources(ResourceType.RUBY);
            this.ReportResources(ResourceType.HONOR);
            this.ReportResources(ResourceType.TOPAZ);
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
                    this.ArenaWinCount
                },
                {
                    "loseCount",
                    this.ArenaLoseCount
                },
                {
                    "arenaRank",
                    this.ArenaRank
                }
            };
            ProgressArgs userState = new ProgressArgs(ProgressType.COUNT, message);
            this.Worker.ReportProgress(0, userState);
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
                    this.SmartModeCount
                }
            };
            ProgressArgs userState = new ProgressArgs(ProgressType.COUNT, message);
            this.Worker.ReportProgress(0, userState);
        }

        private void ReportCount(Objective objective)
        {
            int num = 0;
            int num2 = 0;
            switch (objective)
            {
                case Objective.ADVENTURE:
                    num = this.AdventureCount;
                    num2 = this.h30;
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
                }
                };

            ProgressArgs userState = new ProgressArgs(ProgressType.COUNT, message);
            this.Worker.ReportProgress(0, userState);
        }

        private void ReportCheckSlot(Objective objective)
        {
            int num = 0;
            int num2 = 0;
            switch (objective)
            {
                case Objective.CHECK_SLOT_HERO:
                    num = this.HeroCount;
                    num2 = this.HeroMax;
                    break;

                case Objective.CHECK_SLOT_ITEM:
                    num = this.ItemCount;
                    num2 = this.ItemMax;
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
            this.Worker.ReportProgress(0, userState);
        }

        private void ReportKeys(Objective objective)
        {
            int num = 0;
            TimeSpan timeSpan = TimeSpan.MaxValue;
            switch (objective)
            {
                case Objective.ADVENTURE:
                    num = this.AdventureKeys;
                    timeSpan = this.AdventureKeyTime;
                    break;

                case Objective.ARENA:
                    num = this.ArenaKeys;
                    timeSpan = this.ArenaKeyTime;
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
            this.Worker.ReportProgress(0, userState);
        }

        private void ReportResources(ResourceType resourceType)
        {
            int num = -1;
            switch (resourceType)
            {
                case ResourceType.GOLD:
                    num = this.GoldCount;
                    break;

                case ResourceType.RUBY:
                    num = this.RubyCount;
                    break;

                case ResourceType.HONOR:
                    num = this.HonorCount;
                    break;
                case ResourceType.GOLDEN_CRYSTAL:
                    num = this.GoldenCrystalCount;
                    break;
                case ResourceType.HORN:
                    num = this.HornCount;
                    break;
                case ResourceType.SCALE:
                    num = this.ScaleCount;
                    break;
                case ResourceType.ESSENCE:
                    num = this.EssecenseCount;
                    break;
                case ResourceType.STAR:
                    num = this.StarCount;
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
            this.Worker.ReportProgress(0, userState);
        }

        private Scene SceneSearch()
        {
            Scene scene = this.SearchScenes();
            if (this.CurrentScene != null)
            {
                this.PreviousScene = this.CurrentScene;
            }
            this.CurrentScene = scene;
            return scene;
        }

        private void ScrollHeroCards(bool down = true)
        {
            PixelMapping pixelMapping = down ? HeroesPM.ScrollAreaDown : HeroesPM.ScrollAreaUp;
            int num = down ? (-HeroesPM.SCROLL_DELTA) : HeroesPM.SCROLL_DELTA;
            this.ClickDrag(pixelMapping.X, pixelMapping.Y, pixelMapping.X, pixelMapping.Y + num);
        }

        private void ScrollShopKeys(bool right = true)
        {
            int num = 500;
            PixelMapping pixelMapping = right ? ShopPM.ScrollAreaRight : ShopPM.ScrollAreaLeft;
            int num2 = right ? (-num) : num;
            this.ClickDrag(pixelMapping.X, pixelMapping.Y, pixelMapping.X + num2, pixelMapping.Y + num2);
        }

        private Scene SearchScenes()
        {
            try
            {
                bool flag = this.MatchMapping(DialogPM.Arena_Intro_CharacterEye, 2) && this.MatchMapping(DialogPM.Arena_Intro_DimmedBackground, 2);
                if (flag)
                {
                    Scene result = new Scene(SceneType._DIALOG);
                    return result;
                }
                bool flag2 = this.MatchMapping(AndroidPopupPM.TopLeftBorder, 2) && this.MatchMapping(AndroidPopupPM.TopRightBorder, 2);
                if (flag2)
                {
                    Scene result = new Scene(SceneType._ANDROID_POPUP);
                    return result;
                }
                if (this.MatchMapping(BluestackPM.SevenKnightIconTop, 2) && this.MatchMapping(BluestackPM.SevenKnightIcon, 2) && this.MatchMapping(BluestackPM.Background, 2))
                {
                    Scene result = new Scene(SceneType.BLUESTACK_HOME);
                    return result;
                }
                if (this.MatchMapping(HeroesPM.IconLeft, 2) && this.MatchMapping(HeroesPM.IconMiddle, 2) && this.MatchMapping(HeroesPM.IconRight, 2) && this.MatchMapping(HeroesPM.OptimizeBorder, 4))
                {
                    Scene result = new Scene(SceneType.HEROES);
                    return result;
                }
                if (this.MatchMapping(HeroesSameTeamPopupPM.DimmedBG, 2) && this.MatchMapping(HeroesSameTeamPopupPM.PopupBorderLeft, 2) && this.MatchMapping(HeroesSameTeamPopupPM.PopupBorderRight, 2))
                {
                    Scene result = new Scene(SceneType.HEROES_SAME_TEAM_POPUP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Hero_BlackBar, 2) && this.MatchMapping(SharedPM.Hero_BottomLeftBorder, 2) && this.MatchMapping(HeroJoinPM.JoinButtonIcon, 2) && (this.MatchMapping(HeroJoinPM.SellButton, 2) || this.MatchMapping(HeroRemovePM.RemoveAllButton, 2)))
                {
                    Scene result = new Scene(SceneType.HERO_JOIN);
                    return result;
                }
                if (this.MatchMapping(HeroRemovePM.RemoveAllButton, 2) &&
                    this.MatchMapping(HeroRemovePM.PositionButton, 2) &&
                    this.MatchMapping(HeroRemovePM.RemoveButtonIcon, 2))
                {
                    Scene result = new Scene(SceneType.HERO_REMOVE);
                    return result;
                }
                if (this.MatchMapping(Level30DialogPM.CharacterEye, 4) && this.MatchMapping(Level30DialogPM.DialogBorder, 4) && this.MatchMapping(Level30DialogPM.InboxIcon, 3))
                {
                    Scene result = new Scene(SceneType.LEVEL_30_DIALOG);
                    return result;
                }
                if (this.MatchMapping(Level30MaxDialogPM.CharacterEye, 3) && this.MatchMapping(Level30MaxDialogPM.InboxButton, 4) && this.MatchMapping(Level30MaxDialogPM.YellowTick, 3) && this.MatchMapping(Level30MaxDialogPM.NecklaceCharacter, 3))
                {
                    Scene result = new Scene(SceneType.LEVEL_30_MAX_DIALOG);
                    return result;
                }
                if (this.MatchMapping(LevelUpDialogPM.CharacterEye, 3) && this.MatchMapping(LevelUpDialogPM.YellowTick, 3))
                {
                    Scene result = new Scene(SceneType.LEVEL_UP_DIALOG);
                    return result;
                }
                if (this.MatchMapping(LobbyPM.MenuButtonYellowLeft, 1) && this.MatchMapping(LobbyPM.MenuButtonYellowRight, 1))
                {
                    Scene result = new Scene(SceneType.LOBBY);
                    return result;
                }
                if (this.MatchMapping(QuestSelectPM.TitleBorderLeft, 1) && this.MatchMapping(QuestSelectPM.TitleBorderRight, 1) && this.MatchMapping(QuestSelectPM.SpecialQuestIcon, 3) && this.MatchMapping(QuestSelectPM.QuestIcon, 3))
                {
                    Scene result = new Scene(SceneType.QUEST_SELECT);
                    return result;
                }
                if (this.MatchMapping(SocialSelectPM.TitleBorderLeft, 1) && this.MatchMapping(SocialSelectPM.TitleBorderRight, 1) && this.MatchMapping(SocialSelectPM.FriendsIcon, 3) && this.MatchMapping(SocialSelectPM.FriendshipIcon, 3))
                {
                    Scene result = new Scene(SceneType.SOCIAL_SELECT);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Quests_Background, 3) && this.MatchMapping(SharedPM.Quests_CharacterArmor, 2) && this.MatchMapping(SpecialQuestPM.StatusBorder, 3))
                {
                    Scene result = new Scene(SceneType.SPECIAL_QUEST);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Quests_Background, 3) && this.MatchMapping(SharedPM.Quests_CharacterArmor, 2))
                {
                    Scene result = new Scene(SceneType.QUEST);
                    return result;
                }
                if (this.MatchMapping(ArenaFightPM.ChatButton, 2) && this.MatchMapping(ArenaFightPM.PauseButton, 2))
                {
                    Scene result = new Scene(SceneType.ARENA_FIGHT);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Fight_PauseButton, 2) || this.MatchMapping(SharedPM.Fight_ChatButton, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_FIGHT);
                    return result;
                }
                if (this.MatchMapping(AdventureFightPM.GoldIcon, 5) && (!this.MatchMapping(SharedPM.Fight_PauseButton, 5) || !this.MatchMapping(SharedPM.Fight_ChatButton, 5)))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_END);
                    return result;
                }
                if (this.MatchMapping(StatusBoardPM.LeftTabCon, 2) && this.MatchMapping(StatusBoardPM.RightTabCol, 2))
                {
                    Scene result = new Scene(SceneType.STATUS_BOARD);
                    return result;
                }

                if (this.MatchMapping(OutOfKeysOfferPM.BuyButtonBorder, 2) && this.MatchMapping(OutOfKeysOfferPM.RedCross, 2) && this.MatchMapping(OutOfKeysOfferPM.StartBG, 2))
                {
                    Scene result = new Scene(SceneType.OUT_OF_KEYS_OFFER);
                    return result;
                }

                if (this.MatchMapping(StatusBoardPM.NoRedCloss, 2) && this.MatchMapping(StatusBoardPM.ConfirmOKtick, 2) && this.MatchMapping(StatusBoardPM.ActiveBG, 2))
                {
                    Scene result = new Scene(SceneType.HOTTIME_CONFIRM_POPUP);
                    return result;
                }

                if (this.MatchMapping(ShopPM.ShopCommon, 2) && this.MatchMapping(ShopPM.ShopPackge, 2))
                {
                    Scene result = new Scene(SceneType.SHOP_LOBBY);
                    return result;
                }
                if (this.MatchMapping(AutoRepeatInfoPM.GoldIcon, 2) && this.MatchMapping(AutoRepeatInfoPM.CardIcon, 2) && this.MatchMapping(AutoRepeatInfoPM.ChestIcon, 2))
                {
                    Scene result = new Scene(SceneType.AUTO_REPEAT_INFO);
                    return result;
                }
                if (this.MatchMapping(SmartSelectPM.Point1, 2) && this.MatchMapping(SmartSelectPM.Point2, 2))
                {
                    Scene result = new Scene(SceneType.SMART_SELECT);
                    return result;
                }
                if (this.MatchMapping(SmartLobbyPM.Point1, 2) && this.MatchMapping(SmartLobbyPM.Point2, 2))
                {
                    Scene result = new Scene(SceneType.SMART_LOBBY);
                    return result;
                }
                if (this.MatchMapping(SmartLootCollectPM.Point1, 2) && this.MatchMapping(SmartLootCollectPM.Point2, 2) && this.MatchMapping(SmartLootCollectPM.Card, 2))
                {
                    Scene result = new Scene(SceneType.SMART_LOOT_COLLECT_LOBBY);
                    return result;
                }
                if (this.MatchMapping(ShopPM.BoderRight, 2) && this.MatchMapping(ShopPM.Borderleft, 2) || (this.MatchMapping(ShopPM.BoderCompair1, 2) && this.MatchMapping(ShopPM.BoderCompair2, 2)))
                {
                    Scene result = new Scene(SceneType.SHOP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.ShopPopup_DimmedBG, 2) && this.MatchMapping(ShopBuyPopupPM.PopupBorderLeft, 2) && this.MatchMapping(ShopBuyPopupPM.RedCross, 2) && this.MatchMapping(ShopBuyPopupPM.YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.SHOP_BUY_POPUP);
                    return result;
                }
                if (this.MatchMapping(ShopPurchaseCompletePopupPM.AgainButtonBorder, 2) && this.MatchMapping(ShopPurchaseCompletePopupPM.OKButtonBorder, 2))
                {
                    Scene result = new Scene(SceneType.SHOP_PURCHASE_COMPLETE_POPUP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.ShopPopup_DimmedBG, 2) && (this.MatchMapping(ShopBuyFailedPopupPM.PopupBorderLeft, 2) && this.MatchMapping(ShopBuyFailedPopupPM.YellowTick, 2)) || (this.MatchMapping(ShopBuyFailedPopupPM.PopupBorderLeft2, 2) && this.MatchMapping(ShopBuyFailedPopupPM.YellowTick2, 2)))
                {
                    Scene result = new Scene(SceneType.SHOP_BUY_FAILED_POPUP);
                    return result;
                }
                if (this.MatchMapping(InboxPM.CharacterBody, 3) && this.MatchMapping(InboxPM.MailIcon, 2))
                {
                    Scene result = new Scene(SceneType.INBOX);
                    return result;
                }
                if (this.MatchMapping(InboxRewardsPopupPM.DimmedBG, 2) && this.MatchMapping(SharedPM.Rewards_PopupBorder, 2) && this.MatchMapping(SharedPM.Rewards_YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.INBOX_REWARDS_POPUP);
                    return result;
                }
                if (this.MatchMapping(InboxCollectFailedPopupPM.DimmedBG_1, 2) && this.MatchMapping(InboxCollectFailedPopupPM.DimmedBG_2, 2) && this.MatchMapping(InboxCollectFailedPopupPM.PopupBorder, 2))
                {
                    Scene result = new Scene(SceneType.INBOX_COLLECT_FAILED_POPUP);
                    return result;
                }
                if (this.MatchMapping(QuestRewardsPopupPM.DimmedBG, 2) && this.MatchMapping(SharedPM.Rewards_PopupBorder, 2) && this.MatchMapping(SharedPM.Rewards_YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.QUEST_REWARDS_POPUP);
                    return result;
                }
                if (this.MatchMapping(QuestCollectFailedPopupPM.DimmedBG_1, 2) && this.MatchMapping(QuestCollectFailedPopupPM.DimmedBG_2, 2) && this.MatchMapping(QuestCollectFailedPopupPM.PopupBorder, 2))
                {
                    Scene result = new Scene(SceneType.QUEST_COLLECT_FAILED_POPUP);
                    return result;
                }
                if (this.MatchMapping(DisconnectedPopupPM.LeftBorder, 2) && this.MatchMapping(DisconnectedPopupPM.YellowTick, 2) && this.MatchMapping(DisconnectedPopupPM.OkButtonBorderLeft, 2) && this.MatchMapping(DisconnectedPopupPM.OkButtonBorderRight, 2))
                {
                    Scene result = new Scene(SceneType.DISCONNECTED_POPUP);
                    return result;
                }
                if (this.MatchMapping(MasteryPopupPM.TitleBorder, 2) && this.MatchMapping(MasteryPopupPM.RedBackground, 2) && this.MatchMapping(MasteryPopupPM.CloseButton, 2))
                {
                    Scene result = new Scene(SceneType.MASTERY_POPUP);
                    return result;
                }
                if ((this.MatchMapping(MapSelectPM.QuickStartMidIcon, 2) || this.MatchMapping(MapSelectPM.QuickStartLeftButton, 2)) && this.MatchMapping(MapSelectPM.BottomRightPanel, 3))
                {
                    Scene result = new Scene(SceneType.MAP_SELECT);
                    return result;
                }
                if (this.MatchMapping(OutOfSwordsPopupPM.PopupBorderLeft, 2) && (this.MatchMapping(OutOfSwordsPopupPM.DimmedBGStart, 2) || this.MatchMapping(OutOfSwordsPopupPM.DimmedBGEnd, 2) || this.MatchMapping(OutOfSwordsPopupPM.DimmedBG2Start, 2) || this.MatchMapping(OutOfSwordsPopupPM.DimmedBG2End, 2)))
                {
                    Scene result = new Scene(SceneType.OUT_OF_SWORDS_POPUP);
                    return result;
                }
                if (this.MatchMapping(MapSelectPopupPM.PopupBorderLeft, 2) && this.MatchMapping(MapSelectPopupPM.PopupBorderRight, 2) && this.MatchMapping(MapSelectPopupPM.DimmedBG, 2))
                {
                    Scene result = new Scene(SceneType.MAP_SELECT_POPUP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Full_DimmedBG, 2) && this.MatchMapping(FullItemPopupPM.SellButtonIcon, 2))
                {
                    Scene result = new Scene(SceneType.FULL_ITEM_POPUP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Full_DimmedBG, 2) && this.MatchMapping(FullHeroPopupPM.SellButtonIcon, 2))
                {
                    Scene result = new Scene(SceneType.FULL_HERO_POPUP);
                    return result;
                }
                if (this.MatchMapping(BattleModesPM.BorderTopLeft, 2) && this.MatchMapping(BattleModesPM.BorderBottomRight, 2) && this.MatchMapping(BattleModesPM.QuestRedScroll, 2))
                {
                    Scene result = new Scene(SceneType.BATTLE_MODES);
                    return result;
                }
                if (this.MatchMapping(ArenaStartPM.CombatTeamBorderLeft, 2) && this.MatchMapping(ArenaStartPM.CombatTeamBorderRight, 2) && this.MatchMapping(ArenaStartPM.FormationBorderLeft, 3))
                {
                    Scene result = new Scene(SceneType.ARENA_START);
                    return result;
                }
                if (this.MatchMapping(ArenaEndPM.QuickStartButton, 2) && this.MatchMapping(ArenaEndPM.ArenaButton, 2))
                {
                    Scene result = new Scene(SceneType.ARENA_END);
                    return result;
                }
                if (this.MatchMapping(ArenaSeasonEndPM.Point1, 2) && this.MatchMapping(ArenaSeasonEndPM.Point2, 2) && this.MatchMapping(ArenaSeasonEndPM.PopupLeftBorder, 2) && this.MatchMapping(ArenaSeasonEndPM.PopupRightBorder, 2))
                {
                    Scene result = new Scene(SceneType.ARENA_SEASON_END);
                    return result;
                }
                if (this.MatchMapping(ArenaFullHonorPopupPM.PopupBorderLeft, 2) && this.MatchMapping(ArenaFullHonorPopupPM.YellowTick, 4) && this.MatchMapping(ArenaFullHonorPopupPM.DimmedBG, 2))
                {
                    Scene result = new Scene(SceneType.ARENA_FULL_HONOR_POPUP);
                    return result;
                }
                if (this.MatchMapping(AdventureReadyPM.ReadyButtonBackground, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_READY);
                    return result;
                }
                if (this.MatchMapping(SellHeroesLobbyPM.Point1, 2) && this.MatchMapping(SellHeroesLobbyPM.Point2, 2) && this.MatchMapping(SellHeroesLobbyPM.BackButton, 2) && this.MatchMapping(SellHeroesLobbyPM.RefreshButton, 2))
                {
                    Scene result = new Scene(SceneType.SELL_HERO_LOBBY);
                    return result;
                }
                if (this.MatchMapping(SellItemsLobbyPM.Point1, 2) && this.MatchMapping(SellItemsLobbyPM.Point2, 2) && this.MatchMapping(SellItemsLobbyPM.BackButton, 2) && this.MatchMapping(SellItemsLobbyPM.RefreshButton, 2))
                {
                    Scene result = new Scene(SceneType.SELL_ITEM_LOBBY);
                    return result;
                }
                if (this.MatchMapping(ItemsPM.Point1, 2) && this.MatchMapping(ItemsPM.Point2, 2))
                {
                    Scene result = new Scene(SceneType.ITEMS);
                    return result;
                }
                if ((this.MatchMapping(AutoRepeatPopupPM.GoldIcon, 2) && this.MatchMapping(AutoRepeatPopupPM.TopLeftBorder, 2) && this.MatchMapping(AutoRepeatPopupPM.NoButton, 2) && this.MatchMapping(AutoRepeatPopupPM.YesButton, 2)) || (this.MatchMapping(AutoRepeatPopupPM.GoldIcon_NoHotTime, 2) && this.MatchMapping(AutoRepeatPopupPM.TopLeftBorder_NoHotTime, 2) && this.MatchMapping(AutoRepeatPopupPM.NoButton_NoHotTime, 2) && this.MatchMapping(AutoRepeatPopupPM.YesButton_NoHotTime, 2)))
                {
                    Scene result = new Scene(SceneType.AUTO_REPEAT_POPUP);
                    return result;
                }
                if (this.MatchMapping(AdventureStartPM.KeyPlusButton, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_START);
                    return result;
                }
                if (this.MatchMapping(AdventureStartPM.Auto_KeyPlusButton, 2) && this.MatchMapping(AdventureStartPM.Auto_StopButton, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_START_AUTO);
                    return result;
                }
                if (this.MatchMapping(NoMoreHeroPopupPM.DimmedBG, 2) && this.MatchMapping(NoMoreHeroPopupPM.PopupBorderLeft, 2) && this.MatchMapping(NoMoreHeroPopupPM.PopupBorderRight, 2))
                {
                    Scene result = new Scene(SceneType.NO_MORE_HERO_POPUP);
                    return result;
                }
                if (this.MatchMapping(AutoRepeatStopPM.x2Icon, 2) && this.MatchMapping(AutoRepeatStopPM.GoldIcon, 2) && this.MatchMapping(AutoRepeatStopPM.PopupBorder, 2))
                {
                    Scene result = new Scene(SceneType.AUTO_REPEAT_STOP);
                    return result;
                }
                if (this.MatchMapping(VictoryPM.RibbonLeft, 2) && this.MatchMapping(VictoryPM.RibbonMiddle, 2) && this.MatchMapping(VictoryPM.RibbonRight, 2))
                {
                    Scene result = new Scene(SceneType.VICTORY);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Lost_PurpleBase, 2) && this.MatchMapping(SharedPM.Lost_Moon, 2) && this.MatchMapping(AdventureLostPM.GetStrongerButton, 2) && this.MatchMapping(AdventureLostPM.AgainButton, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_LOST);
                    return result;
                }
                if (this.MatchMapping(AdventureLootPM.EndAutoRepeat, 2) && this.MatchMapping(AdventureLootPM.Auto_QuickStartButton, 2) && this.MatchMapping(AdventureLootPM.Auto_LobbyButton, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_LOOT_AUTO);
                    return result;
                }
                if (this.MatchMapping(AdventureLootPM.AdventureButton, 2) && this.MatchMapping(AdventureLootPM.QuickStartButton, 2))
                {
                    Scene result = new Scene(SceneType.ADVENTURE_LOOT);
                    return result;
                }
                if (this.MatchMapping(LootItemPM.ItemBorder, 4) && this.MatchMapping(LootItemPM.OkButton, 2) && this.MatchMapping(LootItemPM.OkButtonIcon, 2))
                {
                    Scene result = new Scene(SceneType.LOOT_ITEM);
                    return result;
                }
                if (this.MatchMapping(LootHeroPM.OkButton, 2) && this.MatchMapping(LootHeroPM.OkButtonIcon, 2))
                {
                    Scene result = new Scene(SceneType.LOOT_HERO);
                    return result;
                }

                if (this.MatchMapping(OutOfKeysPopupPM.PopupBorder, 3) && this.MatchMapping(OutOfKeysPopupPM.NoButtonBorder, 3) && this.MatchMapping(OutOfKeysPopupPM.DimmedBG, 2) && this.CurrentObjective == Objective.ADVENTURE)
                {
                    Scene result = new Scene(SceneType.OUT_OF_KEYS_POPUP);
                    return result;
                }
                if (this.MatchMapping(FriendsPM.Background, 2) && this.MatchMapping(FriendsPM.HonorIcon, 2))
                {
                    Scene result = new Scene(SceneType.FRIENDS);
                    return result;
                }
                if (this.MatchMapping(SendHonorSendingPopupPM.SocialTabBG, 2) && this.MatchMapping(SendHonorSendingPopupPM.RedCross, 2) && this.MatchMapping(SendHonorSendingPopupPM.GoldIconPlusBG, 2))
                {
                    Scene result = new Scene(SceneType.SEND_HONOR_SENDING_POPUP);
                    return result;
                }
                if (this.MatchMapping(SharedPM.Friends_DimmedBG_1, 2) && this.MatchMapping(SharedPM.Friends_DimmedBG_2, 2) && this.MatchMapping(SharedPM.Friends_PopupBorder, 2) && this.MatchMapping(SendHonorFailedPopupPM.YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.SEND_HONOR_FAILED_POPUP);
                    return result;
                }
                if (this.HonorCount >= 300 && this.MatchMapping(SharedPM.Friends_DimmedBG_1, 2) && this.MatchMapping(SharedPM.Friends_DimmedBG_2, 2) && this.MatchMapping(SharedPM.Friends_PopupBorder, 2) && this.MatchMapping(SendHonorFullPopupPM.RedCross, 2) && this.MatchMapping(SendHonorFullPopupPM.YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.SEND_HONOR_FULL_POPUP);
                    return result;
                }
                if (this.MatchMapping(SendHonorConfirmPopupPM.RedCross, 2) && this.MatchMapping(SendHonorConfirmPopupPM.YellowTick, 2) && this.MatchMapping(SendHonorConfirmPopupPM.GoldPlusBG, 2))
                {
                    Scene result = new Scene(SceneType.SEND_HONOR_CONFIRM_POPUP);
                    return result;
                }
                if (this.MatchMapping(SendHonorEndPM.borderbottomright, 2) && this.MatchMapping(SendHonorEndPM.bordertopleft, 2) && (this.MatchMapping(SendHonorEndPM.DimmedInGameTab, 2) || this.MatchMapping(SendHonorEndPM.DimmedFBTab, 2)))
                {
                    Scene result = new Scene(SceneType.SEND_HONOR_END_POPUP);
                    return result;
                }
                if (this.MatchMapping(SellHeroConfirmPopupPM.DimmedBG_1, 2) && this.MatchMapping(SellHeroConfirmPopupPM.DimmedBG_2, 2) && this.MatchMapping(SellHeroConfirmPopupPM.RedCross, 2) && this.MatchMapping(SellHeroConfirmPopupPM.SellButtonBG, 2))
                {
                    Scene result = new Scene(SceneType.SELL_HERO_CONFIRM_POPUP);
                    return result;
                }
                if (this.MatchMapping(SellItemPopupPM.ItemIcon, 2) && this.MatchMapping(SellItemPopupPM.CloseButton, 2))
                {
                    Scene result = new Scene(SceneType.SELL_ITEM_POPUP);
                    return result;
                }
                if (this.MatchMapping(SellItemConfirmPopupPM.DimmedBG_1, 2) && this.MatchMapping(SellItemConfirmPopupPM.DimmedBG_2, 2) && this.MatchMapping(SellItemConfirmPopupPM.RedCross, 2))
                {
                    Scene result = new Scene(SceneType.SELL_ITEM_CONFIRM_POPUP);
                    return result;
                }
                if (this.MatchMapping(SellItemSuccessPopupPM.Point1, 2) && this.MatchMapping(SellItemSuccessPopupPM.Point2, 2) && this.MatchMapping(SellItemSuccessPopupPM.YellowTick, 2) && this.MatchMapping(SellItemSuccessPopupPM.DimmedBG, 2))
                {
                    Scene result = new Scene(SceneType.SELL_ITEM_SUCCESS_POPUP);
                    return result;
                }
                if (this.MatchMapping(SellHeroesSuccessPopupPM.Point1, 2) && this.MatchMapping(SellHeroesSuccessPopupPM.Point2, 2) && this.MatchMapping(SellHeroesSuccessPopupPM.YellowTick, 2) && this.MatchMapping(SellHeroesSuccessPopupPM.DimmedBG, 2))
                {
                    Scene result = new Scene(SceneType.SELL_HEROES_SUCCESS_POPUP);
                    return result;
                }
                if (this.MatchMapping(InboxSelectHeroPM.Background, 2) && this.MatchMapping(InboxSelectHeroPM.SelectedBorder, 2) && this.MatchMapping(InboxSelectHeroPM.TitleBorder, 2) && this.MatchMapping(InboxSelectHeroPM.SelectButtonBorder, 2))
                {
                    Scene result = new Scene(SceneType.INBOX_SELECT_HERO);
                    return result;
                }
                if (this.MatchMapping(NetmarbleSplashPM.Mascot_1, 2) && this.MatchMapping(NetmarbleSplashPM.Mascot_2, 2) && this.MatchMapping(NetmarbleSplashPM.WhiteBackground, 2))
                {
                    Scene result = new Scene(SceneType.NETMARBLE_SPLASH);
                    return result;
                }
                if (this.MatchMapping(PatchUpdatePM.ProgressBarLeft, 2) && this.MatchMapping(PatchUpdatePM.ProgressBarRight, 2))
                {
                    Scene result = new Scene(SceneType.PATCH_UPDATE);
                    return result;
                }
                if (this.MatchMapping(TapToPlayPM.Point1, 2) && !this.MatchMapping(LandingPM.Shield, 2))
                {
                    Scene result = new Scene(SceneType.TAP_TO_PLAY);
                    return result;
                }
                if (this.MatchMapping(LandingPM.Shield, 2))
                {
                    Scene result = new Scene(SceneType.LANDING);
                    return result;
                }
                if (this.MatchMapping(LandingPM.LeftCheck, 2))
                {
                    Scene result = new Scene(SceneType.LOADING);
                    return result;
                }
                if (this.MatchMapping(NoticePM.TopBorderLeft, 2) && this.MatchMapping(NoticePM.TopBorderRight, 2))
                {
                    Scene result = new Scene(SceneType.NOTICE);
                    return result;
                }
                if (this.MatchMapping(CheckInPM.CloseButton, 2) && this.MatchMapping(CheckInPM.BorderTopLeft, 2) && this.MatchMapping(CheckInPM.BorderRightBottom, 2))
                {
                    Scene result = new Scene(SceneType.CHECK_IN);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.QuestCharacterPic, 2) && this.MatchMapping(Popup3PM.QuestPoint1, 2) && this.MatchMapping(Popup3PM.QuestPoint2, 2) && this.MatchMapping(Popup3PM.QuestRedCrossButton, 2))
                {
                    Scene result = new Scene(SceneType.SPECIAL_QUEST_POPUP);
                    return result;
                }
                if (this.MatchMapping(WifiWarningPopupPM.LeftBorder, 2) && this.MatchMapping(WifiWarningPopupPM.RightBorder, 2) && this.MatchMapping(WifiWarningPopupPM.YellowTick, 2))
                {
                    Scene result = new Scene(SceneType.WIFI_WARNING_POPUP);
                    return result;
                }
                if (this.MatchMapping(QuestRewardsPopupPM.QuestIcon, 2) && this.MatchMapping(QuestRewardsPopupPM.AragonPic, 2))
                {
                    Scene result = new Scene(SceneType.DAILY_QUEST_COMPLETE);
                    return result;
                }
                if (this.MatchMapping(SellHeroConfirmPopupPM.SellButtonbg, 2) && this.MatchMapping(SellHeroConfirmPopupPM.GoldSellIconbg, 2) && this.MatchMapping(SellHeroConfirmPopupPM.SoldOKYellowTik, 2))
                {
                    Scene result = new Scene(SceneType.SELL_HERO_FINISH);
                    return result;
                }
                if (this.MatchMapping(Popup3PM.EventPackPoint1, 2) && this.MatchMapping(Popup3PM.EventPackPoint2, 2) && this.MatchMapping(Popup3PM.EventPackCloseBtn))
                {
                    Scene result = new Scene(SceneType.EVENT_PACKAGE_POPUP);
                    return result;
                }
                if (this.MatchMapping(ArenaEndPM.QuickStartButtonBG, 2) && this.MatchMapping(ArenaEndPM.LobbyButtonBG, 2) && this.MatchMapping(ArenaEndPM.RankUpTik, 2))
                {
                    Scene result = new Scene(SceneType.RANK_UP);
                    return result;
                }
                if (this.MatchMapping(SendHonorConfirmPopupPM.GoldPlusBG, 2) && this.MatchMapping(SendHonorFailedPopupPM.NoFriendYellowTick, 2))
                {
                    Scene result = new Scene(SceneType.SEND_HONOR_NO_FRIEND_TO_SEND);
                    return result;
                }
                if (this.MatchMapping(SharedPM.HelpFriendTik, 2) && this.MatchMapping(SharedPM.HelpFriendBorder, 2))
                {
                    Scene result = new Scene(SceneType.HELPED_FRIEND);
                    return result;
                }
                if (this.MatchMapping(PausePM.Point1, 2) && (this.MatchMapping(PausePM.Point2, 2)))
                {
                    Scene result = new Scene(SceneType.PAUSE);
                    return result;
                }
                if ((this.MatchMapping(ArenaReadyPM.RecordBorder, 2) && this.MatchMapping(ArenaReadyPM.ReadyButtonBackground, 2) && this.MatchMapping(ArenaReadyPM.RubyPlus, 2))
                    || ((this.MatchMapping(ArenaReadyPM.RewardBackground, 2) && this.MatchMapping(ArenaReadyPM.CollectBorder, 2))))
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
            this.CaptureFrame();
            int num = 0;
            for (int i = 0; i < anchorMappings.Length; i++)
            {
                PixelMapping[] array = anchorMappings[i];
                if (this.MatchMapping(array[0], 3) && this.MatchMapping(array[1], 3))
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
                MapSelectPM.DifficultyBoxSelectNormal,
                MapSelectPM.DifficultyBoxSelectHard
            };
            Difficulty aD_Difficulty = Difficulty.None;
            PixelMapping mapping;
            if (MapZone.Equals("Asgar"))
            {
                aD_Difficulty = this.AISettings.AD_Difficulty;
            }
            else if (MapZone.Equals("Aisha") || MapZone.Equals("ShadowsEye"))
            {
                aD_Difficulty = this.AISettings.AD_Difficulty2nd;
            }
            mapping = array[(int)aD_Difficulty];
            if (this.MatchMapping(MapSelectPM.DifficultyBoxExpanded, 2))
            {
                this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                return;
            }
            if (aD_Difficulty != Difficulty.None)
            {
                this.WeightedClick(array[0], 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(500);
                this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
            }
        }

        private void SelectStage(PixelMapping[][] anchorMappings, PixelMapping stageMapping, int pageDestIndex)
        {
            int num = this.SearchStage(anchorMappings);
            if (num > anchorMappings.Length - 1)
            {
                return;
            }
            if (num != pageDestIndex)
            {
                int num2 = this.FindShortestWorldPath(num, pageDestIndex, anchorMappings.Length);
                PixelMapping mapping = (num2 > 0) ? MapSelectPM.NextButton : MapSelectPM.PreviousButton;
                for (int i = 0; i < Math.Abs(num2); i++)
                {
                    this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(500);
                }
            }
            SevenKnightsCore.Sleep(500);
            int num3 = this.SearchStage(anchorMappings);
            if (num3 == pageDestIndex)
            {
                this.SelectDifficulty();
                SevenKnightsCore.Sleep(500);
                this.WeightedClick(stageMapping, 1.0, 1.0, 1, 0, "left");
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
                this.WeightedClick(MapSelectPM.QuickStartMidButton, 1.0, 1.0, 1, 0, "left");
                return;
            }
            int num = world - World.MysticWoods;
            PixelMapping stageMapping = array[num][stage];
            this.SelectStage(anchorMappings, stageMapping, num);
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
                    MapSelectPM.World8_2Anchor_1,
                    MapSelectPM.World8_2Anchor_2
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
                },
                new PixelMapping[]
                {
                    MapSelectPM.World11_1Anchor_1,
                    MapSelectPM.World11_1Anchor_2
                },
                new PixelMapping[]
                {
                    MapSelectPM.World11_2Anchor_1,
                    MapSelectPM.World11_2Anchor_2
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
                },
                new PixelMapping[]
                {
                    MapSelectPM.World11_1Stage1,
                    MapSelectPM.World11_1Stage2,
                    MapSelectPM.World11_1Stage3,
                    MapSelectPM.World11_1Stage4,
                    MapSelectPM.World11_1Stage5,
                    MapSelectPM.World11_2Stage6,
                    MapSelectPM.World11_2Stage7,
                    MapSelectPM.World11_2Stage8,
                    MapSelectPM.World11_2Stage9,
                    MapSelectPM.World11_2Stage10
                }
            };
            int pageDestIndex = array.Length + 1;
            if (world == World.None)
            {
                this.WeightedClick(MapSelectPM.QuickStartLeftButton, 1.0, 1.0, 1, 0, "left");
                return;
            }
            PixelMapping stageMapping;
            if (world == World.MoonlitIsle)
            {
                stageMapping = stages[0][stage];
                if (stage < 5)
                {
                    pageDestIndex = 0;
                }
                else if (stage < 10)
                {
                    pageDestIndex = 1;
                }
                else if (stage < 15)
                {
                    pageDestIndex = 2;
                }
                else if (stage < 20)
                {
                    pageDestIndex = 3;
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
            else if (world == World.DarkSanctuary)
            {
                stageMapping = stages[3][stage];
                if (stage < 5)
                {
                    pageDestIndex = 9;
                }
                else if (stage < 10)
                {
                    pageDestIndex = 10;
                }
            }
            else
            {
                return;
            }
            this.SelectStage(array, stageMapping, pageDestIndex);
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
                this.WeightedClick(MapSelectPM.QuickStartMidButton, 1.0, 1.0, 1, 0, "left");
                return;
            }
            int num = world - World.ShadowsEye;
            PixelMapping stageMapping = array[num][stage];
            this.SelectStage(anchorMappings, stageMapping, num);
        }

        private void SelectTeam(SceneType sceneType)
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
                team = this.AISettings.AD_Team;
            }
            if (team == Team.None)
            {
                return;
            }
            this.WeightedClick(array[team - Team.A], 1.0, 1.0, 1, 0, "left");
            SevenKnightsCore.Sleep(500);
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
            team = this.AISettings.AD_Team;
            if (team == Team.None)
            {
                return;
            }
            this.WeightedClick(array[team - Team.A], 1.0, 1.0, 1, 0, "left");
            SevenKnightsCore.Sleep(500);
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
            this.Log("Start selling heroes", this.COLOR_SELL_HEROES);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot will only sell the hero if the given condition is met.");
            if (!this.MatchMapping(HeroesPM.SortByBoxExpanded, 2))
            {
                this.WeightedClick(HeroesPM.SortByBox, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
            }
            this.WeightedClick(HeroesPM.SortByRank, 1.0, 1.0, 1, 0, "left");
            SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
            if (!this.MatchMapping(HeroesPM.SortButtonAscending, 2))
            {
                this.WeightedClick(HeroesPM.SortButton, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
            }
            this.ScrollHeroCards(false);
            SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
            bool flag = false;
            int monstar = 0;
            int num = 0;
            int num2 = 0;
            int num3 = 0;
            while (num3 < 100 && !this.Worker.CancellationPending)
            {
                this.CaptureFrame();
                Scene scene = this.SceneSearch();
                if (scene != null && scene.SceneType != SceneType.HEROES)
                {
                    this.Log("Stop Disini4");
                    this.DoneSellHeroes(-1);
                    return;
                }
                if (this.MatchMapping(HeroesPM.LastRow_1, 3) && this.MatchMapping(HeroesPM.LastRow_2, 3))
                {
                    flag = true;
                }
                if (!this.AISettings.RS_SellHeroAll && num2 >= this.AISettings.RS_SellHeroAmount)
                {
                    this.Log("Stop Disini3");
                    this.DoneSellHeroes(-1);
                    return;
                }
                /**************************************************************************************/
                if (this.MatchMapping(HeroStar.Star1Loca1, 2) || this.MatchMapping(HeroStar.Star1Loca2, 2)
                     || this.MatchMapping(HeroStar.Star1Loca3, 2) || this.MatchMapping(HeroStar.Star1Loca4, 2) || this.MatchMapping(HeroStar.Star1Loca5, 2)
                     || this.MatchMapping(HeroStar.Star1Loca1R1, 2) || this.MatchMapping(HeroStar.Star1Loca2R1, 2)
                     || this.MatchMapping(HeroStar.Star1Loca3R1, 2) || this.MatchMapping(HeroStar.Star1Loca4R1, 2) || this.MatchMapping(HeroStar.Star1Loca5R1, 2)
                     || this.MatchMapping(HeroStar.Star1Loca1R2, 2) || this.MatchMapping(HeroStar.Star1Loca2R2, 2)
                     || this.MatchMapping(HeroStar.Star1Loca3R2, 2) || this.MatchMapping(HeroStar.Star1Loca4R2, 2) || this.MatchMapping(HeroStar.Star1Loca5R2, 2))
                {
                    monstar = 1;
                }
                else if (this.MatchMapping(HeroStar.Star2Loca1, 2) || this.MatchMapping(HeroStar.Star2Loca2, 2)
                     || this.MatchMapping(HeroStar.Star2Loca3, 2) || this.MatchMapping(HeroStar.Star2Loca4, 2) || this.MatchMapping(HeroStar.Star2Loca5, 2)
                     || this.MatchMapping(HeroStar.Star2Loca1R3, 2) || this.MatchMapping(HeroStar.Star2Loca2R3, 2)
                     || this.MatchMapping(HeroStar.Star2Loca3R3, 2) || this.MatchMapping(HeroStar.Star2Loca4R3, 2) || this.MatchMapping(HeroStar.Star2Loca5R3, 2)
                     || this.MatchMapping(HeroStar.Star2Loca1R4, 2) || this.MatchMapping(HeroStar.Star2Loca2R4, 2)
                     || this.MatchMapping(HeroStar.Star2Loca3R4, 2) || this.MatchMapping(HeroStar.Star2Loca4R4, 2) || this.MatchMapping(HeroStar.Star2Loca5R4, 2)
                     || this.MatchMapping(HeroStar.Star2Loca1R5, 2) || this.MatchMapping(HeroStar.Star2Loca2R5, 2)
                     || this.MatchMapping(HeroStar.Star2Loca3R5, 2) || this.MatchMapping(HeroStar.Star2Loca4R5, 2) || this.MatchMapping(HeroStar.Star2Loca5R5, 2))
                {
                    monstar = 2;
                }
                else if (this.MatchMapping(HeroStar.Star3Loca1R1, 2) || this.MatchMapping(HeroStar.Star3Loca2R1, 2)
                     || this.MatchMapping(HeroStar.Star3Loca3R1, 2) || this.MatchMapping(HeroStar.Star3Loca4R1, 2)
                     || this.MatchMapping(HeroStar.Star3Loca3R2, 2) || this.MatchMapping(HeroStar.Star3Loca4R2, 2)
                     || this.MatchMapping(HeroStar.Star3Loca3R2, 2) || this.MatchMapping(HeroStar.Star3Loca4R2, 2)
                     || this.MatchMapping(HeroStar.Star3Loca3R3, 2) || this.MatchMapping(HeroStar.Star3Loca4R3, 2)
                     || this.MatchMapping(HeroStar.Star3Loca3R3, 2) || this.MatchMapping(HeroStar.Star3Loca4R3, 2))
                {
                    monstar = 3;
                }
                else
                {
                    monstar = 4;
                }
                if (monstar <= this.AISettings.RS_SellHeroStars)
                {
                    //ตรวจเวล 30
                    SevenKnightsCore.Sleep(500);
                    this.WeightedClick(array2[num], 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
                    this.CaptureFrame();
                    scene = this.SceneSearch();
                    if (scene != null && scene.SceneType != SceneType.HERO_JOIN && scene.SceneType != SceneType.HERO_REMOVE)
                    {
                        this.Log("Stop Disini2");
                        this.DoneSellHeroes(-1);
                        return;
                    }
                    if (this.MatchMapping(HeroJoinPM.KeyLockButton, 2)
                            && this.MatchMapping(HeroJoinPM.SellButton, 2))
                    {
                        this.WeightedClick(HeroJoinPM.SellButton, 1.0, 1.0, 1, 0, "left");
                        SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
                        this.WeightedClick(SellHeroConfirmPopupPM.SellLobbyButton, 1.0, 1.0, 1, 0, "left");
                        SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
                        this.CaptureFrame();
                        scene = this.SceneSearch();
                        if (scene != null && scene.SceneType != SceneType.SELL_HERO_CONFIRM_POPUP)
                        {
                            this.Log("Stop Sell Hero.");
                            this.DoneSellHeroes(-1);
                            return;
                        }
                        PixelMapping[][] array4 = array3;
                        for (int j = 0; j < array4.Length; j++)
                        {
                            PixelMapping[] array5 = array4[j];
                            if (this.MatchMapping(array5[0], 5) && this.MatchMapping(array5[1], 5) && this.MatchMapping(array5[2], 5))
                            {
                                this.Log("-- Found element hero, skipping..", this.COLOR_SELL_HEROES);
                                this.WeightedClick(SellHeroConfirmPopupPM.NoButton, 1.0, 1.0, 1, 0, "left");
                                SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
                                this.Escape();
                                SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
                            }
                        }
                        num2++;
                        this.WeightedClick(SellHeroConfirmPopupPM.SellButton, 1.0, 1.0, 1, 0, "left");
                        int n = 1;
                        while (n <= 100)
                        {
                            SevenKnightsCore.Sleep(300);
                            this.CaptureFrame();
                            if (!this.MatchMapping(SellHeroConfirmPopupPM.SoldOKYellowTik, 2) && !this.MatchMapping(SellHeroConfirmPopupPM.SellButtonbg, 2))
                            {
                                n++;
                            }
                            else
                            {
                                n = 110;
                                SevenKnightsCore.Sleep(500);
                                this.WeightedClick(SellHeroConfirmPopupPM.SoldOKButton, 1.0, 1.0, 1, 0, "left");
                                SevenKnightsCore.Sleep(1000);
                                this.Log(string.Format("-- Hero sold ({0})", num2), this.COLOR_SELL_HEROES);
                                this.Escape();
                                SevenKnightsCore.Sleep(this.AIProfiles.ST_Delay);
                                this.DoneSellHeroesMini();
                            }
                        }
                    }
                    else
                    {
                        num = num + 1;
                        this.Escape();
                        SevenKnightsCore.Sleep(500);
                    }
                    if (!flag)
                    {
                        num %= 4;
                    }
                    if (num == 0)
                    {
                        this.ScrollHeroCards(true);
                        SevenKnightsCore.Sleep(800);
                    }
                    if (flag && num >= array2.Length)
                    {
                        this.Log("Stop Disini");
                        this.DoneSellHeroes(num2);
                        return;
                    }
                }
                else
                {
                    this.Log("Stop Disini1");
                    this.DoneSellHeroes(-1);
                    return;
                }
                num3++;
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
                SellItemsLobbyPM.Star5
            };
            PixelMapping[] StartExists = new PixelMapping[]
            {
                SellItemsLobbyPM.Star1Exists,
                SellItemsLobbyPM.Star2Exists,
                SellItemsLobbyPM.Star3Exists,
                SellItemsLobbyPM.Star4Exists,
                SellItemsLobbyPM.Star5Exists
            };
            string[] array2 = new string[]
            {
                "1 Star Item",
                "2 Star Item",
                "3 Star Item",
                "4 Star Item",
                "5 Star Item"
            };
            int test = this.AISettings.RS_SellItemStars;
            Scene scene = this.SceneSearch();
            this.Log("Start selling items", this.COLOR_SELL_ITEMS);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot will selling items");
            List<int> list = new List<int>();
            for (int i = 0; i < test; i++)
            {
                list.Add(i);
            }
            if (list.Count <= 0)
            {
                this.Log("Nothing to do", this.COLOR_HONOR);
                this.DoneSellItems();
                return;
            }
            foreach (int current in list)
            {
                if (this.Worker.CancellationPending)
                {
                    return;
                }
                SevenKnightsCore.Sleep(500);
                this.Log(string.Format("Selling {0}", array2[current]), this.COLOR_HONOR);
                this.WeightedClick(SellItemsLobbyPM.BulkButton, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                PixelMapping mapping = BulkButton[current];
                this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                this.CaptureFrame();
                scene = this.SceneSearch();
                if (this.MatchMapping(StartExists[current], 2))
                {
                    this.Log(string.Format("{0} Exists ", array2[current]), this.COLOR_HONOR);
                    this.WeightedClick(SellItemsLobbyPM.SellButton, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(1000);
                    this.CaptureFrame();
                    scene = this.SceneSearch();
                    if (this.ExpectingScene(SceneType.SELL_ITEM_CONFIRM_POPUP, 10, 1000)) // SELL_ITEM_CONFIRM_POPUP
                    {
                        this.WeightedClick(SellItemConfirmPopupPM.SellButton, 1.0, 1.0, 1, 0, "left");
                        SevenKnightsCore.Sleep(3000);
                        this.CaptureFrame();
                        scene = this.SceneSearch();
                        if (this.ExpectingScene(SceneType.SELL_ITEM_SUCCESS_POPUP, 10, 2000)) // SELL_ITEM_SUCCESS_POPUP
                        {
                            this.Escape();
                            SevenKnightsCore.Sleep(1000);
                        }
                    }
                }
                else
                {
                    this.Log(string.Format("{0} Doesn't Exists ", array2[current]), this.COLOR_HONOR);
                }
            }
            this.DoneSellItems();
        }

        private void SendHonors()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                FriendsPM.FacebookTab,
                FriendsPM.InGameTab
            };
            PixelMapping arg_34_0 = FriendsPM.Facebook_TabSelected;
            PixelMapping arg_3A_0 = FriendsPM.InGame_TabSelected;
            string[] array2 = new string[]
            {
                "Facebook friends",
                "In-Game friends"
            };
            bool[] array3 = new bool[]
            {
                this.AISettings.RS_SendHonorsFacebook,
                this.AISettings.RS_SendHonorsInGame
            };

            this.Log("Start sending honors", this.COLOR_HONOR);
            SendTelegram(this.AIProfiles.ST_TelegramChatID, "Bot is sending honors to friends.");
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array3[i])
                {
                    list.Add(i);
                }
            }
            if (list.Count <= 0)
            {
                this.Log("Nothing to do", this.COLOR_HONOR);
                this.DoneSendHonors();
                return;
            }
            foreach (int current in list)
            {
                if (this.Worker.CancellationPending)
                {
                    return;
                }
                SevenKnightsCore.Sleep(500);
                this.Log(string.Format("Sending to {0}", array2[current]), this.COLOR_HONOR);
                PixelMapping mapping = array[current];
                this.WeightedClick(mapping, 1.0, 1.0, 1, 0, "left");
                SevenKnightsCore.Sleep(1000);
                this.CaptureFrame();
                Scene scene = this.SceneSearch();
                if (scene != null && scene.SceneType != SceneType.FRIENDS)
                {
                    this.DoneSendHonors();
                    return;
                }
                this.UpdateHonor(SceneType.FRIENDS);
                if (current == 0 && this.MatchMapping(FriendsPM.Facebook_NotConnected, 4))
                {
                    this.Log("Not connected to facebook", this.COLOR_HONOR);
                }
                else
                {
                    this.WeightedClick(FriendsPM.SortByLogin, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(500);
                    this.WeightedClick(FriendsPM.SendAllButton, 1.0, 1.0, 1, 0, "left");
                    SevenKnightsCore.Sleep(1000);
                    this.CaptureFrame();
                    if (this.MatchMapping(SendHonorConfirmPopupPM.RedCross, 2) && this.MatchMapping(SendHonorConfirmPopupPM.YellowTick, 2) && this.MatchMapping(SendHonorConfirmPopupPM.GoldPlusBG, 2))
                    {
                        this.WeightedClick(SendHonorConfirmPopupPM.HonorsGiftButton, 1.0, 1.0, 1, 0, "left");
                        SevenKnightsCore.Sleep(1000);
                        this.CaptureFrame();
                        while (!this.Worker.CancellationPending && this.MatchMapping(SendHonorSendingPopupPM.RedCross, 2))
                        {
                            this.CaptureFrame();
                            SevenKnightsCore.Sleep(500);
                        }
                        SevenKnightsCore.Sleep(500);
                        this.CaptureFrame();
                        scene = this.SceneSearch();
                        if (scene == null || scene.SceneType != SceneType.SEND_HONOR_FAILED_POPUP || scene.SceneType != SceneType.SEND_HONOR_FULL_POPUP || scene.SceneType != SceneType.SEND_HONOR_CONFIRM_POPUP)
                        {
                            SevenKnightsCore.Sleep(1000);
                        }
                        else
                        {
                            if (scene.SceneType == SceneType.SEND_HONOR_END_POPUP)
                            {
                                this.Log("Send Honor End Popup");
                                this.Escape();
                                //this.WeightedClick(SendHonorEndPopupPM.PopupClick, 1.0, 1.0, 1, 0, "left");
                                SevenKnightsCore.Sleep(300);
                            }
                            if (scene.SceneType == SceneType.SEND_HONOR_FULL_POPUP || scene.SceneType == SceneType.SEND_HONOR_CONFIRM_POPUP)
                            {
                                this.DoneSendHonors();
                                return;
                            }
                            if (scene.SceneType == SceneType.SEND_HONOR_FAILED_POPUP)
                            {
                                SevenKnightsCore.Sleep(300);
                                this.Escape();
                            }

                        }
                    }
                    else
                    {
                        SevenKnightsCore.Sleep(300);
                        this.Escape();
                    }
                }
            }
            this.DoneSendHonors();
        }

        private void SendTelegram(string chatid, string text)
        {
            if (this.AIProfiles.ST_EnableTelegram == true)
            {
                try
                {
                    bot.sendMessage.send(chatid, text);
                }
                catch (Exception ex)
                {
                    this.Log("Send Telegram Failed! : " + ex);
                }
            }
        }

        private void UpdateHeroCount()
        {
            int curHero = HeroCount;
            int maxHero = HeroMax;
            Rectangle rect = HeroesPM.R_HeroCount;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(200))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = this.ReplaceNumericResource(page.GetText());
                    Utility.FilterAscii(text);
                    //this.Log("Old Text: " + text);
                    if (text.Length >= 2)
                    {
                        string[] array = text.Split(new char[]
                            {
                                '/'
                            });

                        if (array.Length >= 1)
                            int.TryParse(array[0], out curHero);
                        if (array.Length >= 2)
                        {
                            int.TryParse(array[1], out maxHero);
                        }
#if DEBUG
                        this.Log(string.Format("HC: {0}/{1} String: {2}", curHero, maxHero, text.Trim()));
                        bitmap.Save(string.Format("H_{0} of {1}.png", curHero, maxHero));
#endif
                    }
                    this.HeroCount = curHero;
                    this.HeroMax = maxHero;
                    if (curHero >= maxHero)
                    {
                        if (this.AISettings.RS_SellHeroes && this.CooldownSellHeroes <= 0)
                        {
                            this.Log("Heroes Full, Bot will Sell Heroes after check item slot");
                            this.herofull = true;
                            this.checkslothero = false;
                        }
                        else
                        {
                            this.Log("Heroes Full, Bot will check item slot");
                            this.checkslothero = false;
                            this.ChangeObjective(Objective.CHECK_SLOT_ITEM);
                        }
                    }
                    else
                    {
                        this.checkslothero = false;
                        this.ChangeObjective(Objective.CHECK_SLOT_ITEM);
                    }
                }
            }
        }

        private void UpdateItemCount()
        {
            int curItem = ItemCount;
            int maxItem = ItemMax;
            Rectangle rect = ItemsPM.R_ItemCount;
            using (Bitmap bitmap = this.CropFrame(this.BlueStacks.MainWindowAS.CurrentFrame, rect).ScaleByPercent(200))
            {
                using (Page page = this.Tesseractor.Engine.Process(bitmap, null))
                {
                    string text = this.ReplaceNumericResource(page.GetText());
                    Utility.FilterAscii(text);
                    if (text.Length >= 2)
                    {
                        string[] array = text.Split(new char[]
                            {
                                '/'
                            });

                        if (array.Length >= 1)
                            int.TryParse(array[0], out curItem);
                        if (array.Length >= 2)
                        {
                            int.TryParse(array[1], out maxItem);
                        }
                    }
                    this.ItemCount = curItem;
                    this.ItemMax = maxItem;
                    if (curItem >= maxItem)
                    {
                        if (this.AISettings.RS_SellItems)
                        {
                            this.Log("Items Full, Bot will Sell Items");
                            this.itemfull = true;
                            this.checkslotitem = false;
                        }
                        else
                        {
                            this.Log("Items Full");
                            this.itemfull = true;
                            this.checkslotitem = false;
                            if (this.AdventureLimitCount >= this.AISettings.AD_Limit)
                            {
                                this.Log("Limit reached [Adventure]", this.COLOR_LIMIT);
                                SendTelegram(this.AIProfiles.ST_TelegramChatID, "Limit Reached [Adventure]");
                                this.AdventureLimitCount = 0;
                                this.IsAdventureLimit = true;
                                this.NextPossibleObjective();
                            }
                            else
                            {
                                this.ChangeObjective(Objective.ADVENTURE);
                            }
                        }
                    }
                    else
                    {
                        this.checkslotitem = false;
                        if (this.AdventureLimitCount >= this.AISettings.AD_Limit)
                        {
                            this.Log("Limit reached [Adventure]", this.COLOR_LIMIT);
                            SendTelegram(this.AIProfiles.ST_TelegramChatID, "Limit Reached [Adventure]");
                            this.AdventureLimitCount = 0;
                            this.NextPossibleObjective();
                        }
                        else
                        {
                            this.ChangeObjective(Objective.ADVENTURE);
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
                },
                {
                    SceneType.FRIENDS,
                    SharedPM.R_KeyNormalBase
                },
                {
                    SceneType.QUEST,
                    SharedPM.R_KeyNormalBase
                },
                {
                    SceneType.SPECIAL_QUEST,
                    SharedPM.R_KeyNormalBase
                }
            };
            Rectangle rect = dictionary[sceneType];
            int num = this.ParseAdventureKeys(rect);
            if (num != -1)
            {
                this.AdventureKeys = num;
                this.ReportKeys(Objective.ADVENTURE);
            }
        }

        private void UpdateArenaKeys()
        {
            PixelMapping[] array = new PixelMapping[]
            {
                ArenaStartPM.Key_0,
                ArenaStartPM.Key_1,
                ArenaStartPM.Key_2,
                ArenaStartPM.Key_3,
                ArenaStartPM.Key_4,
                ArenaStartPM.Key_5
            };
            int num = -1;
            for (int i = 0; i < 6; i++)
            {
                if (!this.MatchMapping(array[i], 2))
                {
                    num = i;
                    break;
                }
            }
            if (num != -1)
            {
                this.ArenaKeys = num;
                this.ReportKeys(Objective.ARENA);
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
                },
                {
                    SceneType.FRIENDS,
                    SharedPM.R_GoldBase
                },
                {
                    SceneType.QUEST,
                    SharedPM.R_GoldBase
                },
                {
                    SceneType.SPECIAL_QUEST,
                    SharedPM.R_GoldBase
                }
            };
            Rectangle rect = dictionary[sceneType];
            int num = this.ParseGold(rect);
            if (num != -1)
            {
                this.GoldCount = num;
                this.ReportResources(ResourceType.GOLD);
            }
        }

        private void UpdateHangFingerprint()
        {
            if (this.PreviousFingerprint == null)
            {
                this.PreviousFingerprint = new int[50];
                this.CurrentFingerprint = new int[50];
            }
            this.CreateHangFingerprint(this.CurrentFingerprint);
            for (int i = 0; i < 50; i++)
            {
                if (this.PreviousFingerprint[i] != this.CurrentFingerprint[i])
                {
                    this.HangCounter = 0;
                }
            }
            this.CreateHangFingerprint(this.PreviousFingerprint);
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
                },
                {
                    SceneType.FRIENDS,
                    LobbyPM.R_HonorBase
                },
                {
                    SceneType.QUEST,
                    LobbyPM.R_HonorBase
                },
                {
                    SceneType.SPECIAL_QUEST,
                    LobbyPM.R_HonorBase
                }
            };
            Rectangle rect = dictionary[sceneType];
            int num = this.ParseHonor(rect);
            if (num != -1)
            {
                this.HonorCount = num;
                this.ReportResources(ResourceType.HONOR);
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
                },
                {
                    SceneType.QUEST,
                    SharedPM.R_RubyBase
                },
                {
                    SceneType.SPECIAL_QUEST,
                    SharedPM.R_RubyBase
                }
            };
            Rectangle rect = dictionary[sceneType];
            int num = this.ParseRuby(rect);
            if (num != -1)
            {
                this.RubyCount = num;
                this.ReportResources(ResourceType.RUBY);
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
            int num = this.ParseTopaz(point.X, point.Y);
            if (num != -1)
            {
                this.TopazCount = num;
                this.ReportResources(ResourceType.TOPAZ);
            }
        }

        private void WeightedClick(PixelMapping mapping, double scale = 1.0, double density = 1.0, int numClicks = 1, int delay = 0, string button = "left")
        {
            this.BlueStacks.MainWindowAS.Click(mapping.X, mapping.Y, numClicks, delay, button);
        }

        #endregion Private Methods
    }
}