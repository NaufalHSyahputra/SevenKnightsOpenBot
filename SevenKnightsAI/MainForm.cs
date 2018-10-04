using RestSharp;
using SevenKnightsAI.Classes;
using SevenKnightsAI.Classes.Extensions;
using SevenKnightsAI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Media;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Tesseract;
using Telegram;
using ScreenShotDemo;

namespace SevenKnightsAI
{
    public partial class MainForm : Form
    {
        #region Public Fields

        private readonly CheckBox[][] _formationCheckBoxes = new CheckBox[2][];

        private readonly Point[][] _formationPositions = new Point[][]
        {
            new Point[]
            {
                new Point(46, 24),
                new Point(46, 44),
                new Point(25, 13),
                new Point(25, 33),
                new Point(25, 53)
            },
            new Point[]
            {
                new Point(46, 13),
                new Point(46, 33),
                new Point(46, 53),
                new Point(25, 24),
                new Point(25, 44)
            },
            new Point[]
            {
                new Point(46, 33),
                new Point(25, 7),
                new Point(25, 24),
                new Point(25, 41),
                new Point(25, 58)
            },
            new Point[]
            {
                new Point(46, 7),
                new Point(46, 24),
                new Point(46, 41),
                new Point(46, 58),
                new Point(25, 33)
            }
        };

        private readonly List<Button>[] _skillButtons = new List<Button>[10];

        private readonly Color COLOR_SEQUENCE_ERROR = Color.FromArgb(255, 127, 123);

        private readonly Color COLOR_SEQUENCE_OK = Color.FromArgb(178, 209, 255);

        private readonly Color COLOR_SKILL_LOOP = Color.FromArgb(94, 170, 255);

        private SevenKnightsCore AI;

        private AIProfiles AIProfiles;

        private SoundPlayer AlertSound;

        private bool LG_autoScroll = true;

        private bool loaded;

        private bool started;

        private SynchronizationContext SynchronizationContext;

        private BackgroundWorker Worker;

        private BackgroundWorker Worker2 = new BackgroundWorker();

        private DateTime StartTime;

        private Stopwatch timer1;

        private ControlBluestacks cb = new ControlBluestacks();

        #endregion Private Fields

        #region Public Properties

        public static MainForm Instance
        {
            get;

            private set;
        }

        public AISettings AISettings
        {
            get
            {
                return this.AIProfiles.CurrentProfile;
            }
        }

        public bool IsElevated
        {
            get
            {
                return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        #endregion Public Properties

        #region Public Constructors

        public MainForm()
        {
            this.InitializeComponent();
            this.Init();
            this.ReloadTabs(true);
            if (!this.IsElevated)
            {
                this.adminToolStripLabel.Visible = false;
                MessageBox.Show("No admin permissions. Bot might not function as expected!",
                "No Admin Permissions",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning // for Warning  
               );
                this.AppendWarning("No admin permissions. Bot might not function as expected!");
            }
            //BackgroudWorker for Telegram
        }

        #endregion Public Constructors

        #region Public Methods

        public void InvokeReloadTabs(bool refreshSettings)
        {
            base.Invoke(new MethodInvoker(delegate
            {
                this.ReloadTabs(refreshSettings);
            }));
        }

        public void CaptureReport()
        {
            cb.Screenshot();
            this.tabControl1.SelectedIndex = 0;
            Thread.Sleep(3000);
            ScreenCapture sc = new ScreenCapture();
            Image img = sc.CaptureScreen();
            sc.CaptureWindowToFile(this.Handle, "C:\\report.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //Bitmap screen = this.AI.BlueStacks.CaptureFrame(!this.AIProfiles.ST_ForegroundMode);
            //screen.Save("C:\\screen.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public void Test(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                bot.update = "true";
                if (bot.message_text == "/start" || bot.message_text == "/Start" || bot.message_text == "ResetTelegram")
                {
                    bot.sendKeyboard.keyboard_R1_1 = "ControlBot";
                    bot.sendKeyboard.keyboard_R1_2 = "ControlPC";
                    bot.sendKeyboard.keyboard_R1_3 = "ControlBluestacks";
                    bot.sendKeyboard.keyboard_R2_1 = "EnableMode";
                    bot.sendKeyboard.keyboard_R2_2 = "DisableMode";
                    bot.sendKeyboard.keyboard_R3_1 = "GetReport";
                    bot.sendKeyboard.keyboard_R3_2 = "ResetTelegram";
                    bot.sendKeyboard.send(bot.chat_id, "Welcome to Seven Knights OpenBot Telegram Bot.\nYour ChatID will automatically added to your bot.");
                    ST_TelegramChatIDTextBox.Text = bot.chat_id;
                }
                if (bot.message_text == "ControlBot")
                {
                    bot.send_inline_keyboard.keyboard_R1_1 = "Start Bot";
                    bot.send_inline_keyboard.keyboard_R1_1_callback_data = "StartBot";
                    bot.send_inline_keyboard.keyboard_R1_2 = "Stop Bot";
                    bot.send_inline_keyboard.keyboard_R1_2_callback_data = "StopBot";
                    bot.send_inline_keyboard.keyboard_R1_3 = "Pause Bot";
                    bot.send_inline_keyboard.keyboard_R1_3_callback_data = "PauseBot";
                    bot.send_inline_keyboard.keyboard_R2_1 = "Restart Bot";
                    bot.send_inline_keyboard.keyboard_R2_1_callback_data = "RestartBot";
                    bot.send_inline_keyboard.send(bot.chat_id, "Select Mode You Want To Enable : ");
                }
                if (bot.data == "StartBot")
                {

                    this.tabControl1.SelectedTab = tabPage4;
                    Thread.Sleep(5000);
                    if (!this.started)
                    {
                        SendCommand("Start Bot");

                        bot.sendMessage.send(bot.chat_id, "Bot Started");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "Bot Already Started");
                    }
                }
                if (bot.data == "StopBot")
                {
                    if (this.started)
                    {
                        SendCommand("Stop Bot");

                        bot.sendMessage.send(bot.chat_id, "Bot Stopped");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "Bot Already Stopped");

                    }
                }
                if (bot.data == "PauseBot")
                {
                    if (this.started)
                    {
                        SendCommand("Pause Bot");
                        bot.sendMessage.send(bot.chat_id, "Bot Paused");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "Bot Not Running");
                    }
                }
                if (bot.data == "ResumeBot")
                {
                    if (this.AIProfiles.TMP_Paused)
                    {
                        SendCommand("Resume Bot");
                        bot.sendMessage.send(bot.chat_id, "Bot Resume");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "Bot Not Paused");
                    }
                }
                if (bot.message_text == "EnableMode")
                {
                    bot.send_inline_keyboard.keyboard_R1_1 = "Adventure";
                    bot.send_inline_keyboard.keyboard_R1_1_callback_data = "EnableAdventure";
                    bot.send_inline_keyboard.keyboard_R1_2 = "Arena";
                    bot.send_inline_keyboard.keyboard_R1_2_callback_data = "EnableArena";
                    bot.send_inline_keyboard.keyboard_R1_3 = "Smart Mode";
                    bot.send_inline_keyboard.keyboard_R1_3_callback_data = "EnableSmartMode";
                    bot.send_inline_keyboard.send(bot.chat_id, "Select Mode You Want To Enable : ");
                }
                if (bot.data == "EnableAdventure")
                {
                    SendCommand("Enable Adventure");
                    bot.sendMessage.send(bot.chat_id, "Adventure Enabled");
                }
                if (bot.data == "EnableArena")
                {
                    SendCommand("Enable Arena");
                    bot.sendMessage.send(bot.chat_id, "Adventure Enabled");
                }
                if (bot.data == "EnableSmartMode")
                {
                    SendCommand("Enable Smart Mode");
                    bot.sendMessage.send(bot.chat_id, "Smart Mode Enabled");
                }
                if (bot.message_text == "DisableMode")
                {
                    bot.send_inline_keyboard.keyboard_R1_1 = "Adventure";
                    bot.send_inline_keyboard.keyboard_R1_1_callback_data = "DisableAdventure";
                    bot.send_inline_keyboard.keyboard_R1_2 = "Arena";
                    bot.send_inline_keyboard.keyboard_R1_2_callback_data = "DisableArena";
                    bot.send_inline_keyboard.keyboard_R1_3 = "Smart Mode";
                    bot.send_inline_keyboard.keyboard_R1_3_callback_data = "DisableSmartMode";
                    bot.send_inline_keyboard.send(bot.chat_id, "Select Mode You Want To Disable : ");
                }
                if (bot.data == "DisableAdventure")
                {
                    SendCommand("Disable Adventure");
                    bot.sendMessage.send(bot.chat_id, "Adventure Disabled");
                }
                if (bot.data == "DisableArena")
                {
                    SendCommand("Disable Arena");
                    bot.sendMessage.send(bot.chat_id, "Adventure Disabled");
                }
                if (bot.data == "DisableSmartMode")
                {
                    SendCommand("Disable Smart Mode");
                    bot.sendMessage.send(bot.chat_id, "Smart Mode Disabled");
                }
                if (bot.message_text == "ControlBluestacks")
                {
                    bot.send_inline_keyboard.keyboard_R1_1 = "Kill Bluestacks";
                    bot.send_inline_keyboard.keyboard_R1_1_callback_data = "KillBS";
                    bot.send_inline_keyboard.keyboard_R1_2 = "Restart Bluestacks";
                    bot.send_inline_keyboard.keyboard_R1_2_callback_data = "RestartBS";
                    bot.send_inline_keyboard.keyboard_R2_1 = "Kill 7K";
                    bot.send_inline_keyboard.keyboard_R2_1_callback_data = "Kill7K";
                    bot.send_inline_keyboard.keyboard_R2_2 = "Restart 7K";
                    bot.send_inline_keyboard.keyboard_R2_2_callback_data = "Restat7K";
                    bot.send_inline_keyboard.send(bot.chat_id, "Select your choice : ");
                }
                if (bot.data == "KillBS")
                {
                    SendCommand("KillBS");
                    bot.sendMessage.send(bot.chat_id, "Bluestacks will be killed");
                }
                if (bot.data == "RestartBS")
                {
                    SendCommand("RestartBS");
                    bot.sendMessage.send(bot.chat_id, "Bluestacks will restart, and automatically run Seven Knights");
                }
                if (bot.data == "Kill7K")
                {
                    SendCommand("Kill7K");
                    bot.sendMessage.send(bot.chat_id, "Seven Knights will be killed");
                }
                if (bot.data == "Restart7K")
                {
                    SendCommand("Restart7K");
                    bot.sendMessage.send(bot.chat_id, "Seven Knights will restart");
                }
                if (bot.message_text == "GetReport")
                {
                    CaptureReport();
                    bot.SendPhoto.Show_sending_a_photo = true;
                    bot.SendPhoto.caption = String.Format("Report {0} , {1}", DateTime.Now.ToString(), this.AI.GetMode().ToString());
                    bot.SendPhoto.send(this.AIProfiles.ST_TelegramChatID, @"C://report.jpg");
                    bot.SendPhoto.Show_sending_a_photo = true;
                    bot.SendPhoto.caption = String.Format("Last Screenshot {0}", DateTime.Now.ToString());
                    bot.SendPhoto.send(this.AIProfiles.ST_TelegramChatID, @"C://screenshot.png");
                }
                if (bot.message_text == "ControlPC")
                {
                    bot.send_inline_keyboard.keyboard_R1_1 = "Shutdown";
                    bot.send_inline_keyboard.keyboard_R1_1_callback_data = "Shutdown";
                    bot.send_inline_keyboard.keyboard_R1_2 = "Restart";
                    bot.send_inline_keyboard.keyboard_R1_2_callback_data = "Restart";
                    bot.send_inline_keyboard.send(bot.chat_id, "Select Mode You Want To Enable : ");
                }
                if (bot.data == "Shutdown")
                {
                    bot.sendMessage.send(bot.chat_id, "PC will Shutdown Now!");
                    Process.Start("shutdown", "/s /f /t 0");
                }
                if (bot.data == "Restart")
                {
                    bot.sendMessage.send(bot.chat_id, "PC will Restart Now!");
                    Process.Start("shutdown", "/r /t 0");
                }
            }
        }

        #endregion Public Methods

        #region Private Methods

        private void AD_continuousCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_Continuous = checkBox.Checked;
        }

        private void AD_difficultyComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            this.AISettings.AD_Difficulty = comboBox.SelectedValue as Difficulty? ?? Difficulty.None;
        }

        private void AD_difficultyComboBox2nd_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            this.AISettings.AD_Difficulty2nd = comboBox.SelectedValue as Difficulty? ?? Difficulty.None;
        }

        private void AD_PopulateStage(int stages)
        {
            int selectedIndex = this.AD_stageComboBox.SelectedIndex;
            this.AD_stageComboBox.Items.Clear();
            for (int i = 0; i < stages; i++)
            {
                string item = (i + 1).ToString();
                this.AD_stageComboBox.Items.Add(item);
            }
            int num = this.AD_stageComboBox.Items.Count - 1;
            if (selectedIndex > num)
            {
                this.AD_stageComboBox.SelectedIndex = num;
                return;
            }
        }

        private void AD_PopulateDifficulty(params Difficulty[] enabledDifficulties)
        {
            Dictionary<Difficulty, string> items = new Dictionary<Difficulty, string>();

            List<Difficulty> difficulties = new List<Difficulty>(enabledDifficulties);
            if (difficulties.Contains(Difficulty.None))
                items.Add(Difficulty.None, "---");
            if (difficulties.Contains(Difficulty.Easy))
                items.Add(Difficulty.Easy, Difficulty.Easy.ToString());
            if (difficulties.Contains(Difficulty.Normal))
                items.Add(Difficulty.Normal, Difficulty.Normal.ToString());
            if (difficulties.Contains(Difficulty.Hard))
                items.Add(Difficulty.Hard, Difficulty.Hard.ToString());

            Difficulty selectedDifficulty = this.AD_difficultyComboBox.SelectedValue as Difficulty? ?? Difficulty.None;
            if (!difficulties.Contains(selectedDifficulty))
                selectedDifficulty = Difficulty.None;

            this.AD_difficultyComboBox.SelectedValueChanged -= this.AD_difficultyComboBox_SelectedValueChanged;
            this.AD_difficultyComboBox.DisplayMember = "Value";
            this.AD_difficultyComboBox.ValueMember = "Key";
            this.AD_difficultyComboBox.DataSource = new BindingSource(items, null);
            this.AD_difficultyComboBox.SelectedValueChanged += this.AD_difficultyComboBox_SelectedValueChanged;

            this.AD_difficultyComboBox.SelectedValue = selectedDifficulty;
        }

        private void AD_PopulateDifficulty2nd(params Difficulty[] enabledDifficulties)
        {
            Dictionary<Difficulty, string> items = new Dictionary<Difficulty, string>();

            List<Difficulty> difficulties = new List<Difficulty>(enabledDifficulties);
            if (difficulties.Contains(Difficulty.None))
                items.Add(Difficulty.None, "---");
            if (difficulties.Contains(Difficulty.Easy))
                items.Add(Difficulty.Easy, Difficulty.Easy.ToString());
            if (difficulties.Contains(Difficulty.Normal))
                items.Add(Difficulty.Normal, Difficulty.Normal.ToString());
            if (difficulties.Contains(Difficulty.Hard))
                items.Add(Difficulty.Hard, Difficulty.Hard.ToString());

            Difficulty selectedDifficulty = this.AD_difficultyComboBox2nd.SelectedValue as Difficulty? ?? Difficulty.None;
            if (!difficulties.Contains(selectedDifficulty))
                selectedDifficulty = Difficulty.None;

            this.AD_difficultyComboBox2nd.SelectedValueChanged -= this.AD_difficultyComboBox2nd_SelectedValueChanged;
            this.AD_difficultyComboBox2nd.DisplayMember = "Value";
            this.AD_difficultyComboBox2nd.ValueMember = "Key";
            this.AD_difficultyComboBox2nd.DataSource = new BindingSource(items, null);
            this.AD_difficultyComboBox2nd.SelectedValueChanged += this.AD_difficultyComboBox2nd_SelectedValueChanged;

            this.AD_difficultyComboBox2nd.SelectedValue = selectedDifficulty;
        }

        private void AD_sequenceButton_Click(object sender, EventArgs e)
        {
            this.AD_ShowSequencerForm();
        }

        private void AD_ShowSequencerForm()
        {
            StageSequencerForm stageSequencerForm = new StageSequencerForm(this.AISettings, this.started);
            stageSequencerForm.ShowDialog(this);
            this.AD_UpdateSequenceButton();
        }

        private void AD_stageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            this.AISettings.AD_Stage = comboBox.SelectedIndex;
        }

        private void AD_StopOnFullHeroes_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_StopOnFullHeroes = checkBox.Checked;
        }

        private void AD_StopOnFullItems_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_StopOnFullItems = checkBox.Checked;
        }

        private void AD_UpdateSequenceButton()
        {
            if (!this.AD_sequenceButton.Enabled)
            {
                this.AD_sequenceButton.BackColor = Control.DefaultBackColor;
                return;
            }
            if (this.AISettings.AD_WorldSequence == null || this.AISettings.AD_WorldSequence.Length <= 0)
            {
                this.AD_sequenceButton.BackColor = this.COLOR_SEQUENCE_ERROR;
                return;
            }
            this.AD_sequenceButton.BackColor = this.COLOR_SEQUENCE_OK;
        }

        private void AD_worldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            this.AD_stageComboBox.Enabled = (comboBox.SelectedIndex != 0 && comboBox.SelectedIndex != 1);
            this.AD_sequenceButton.Enabled = (comboBox.SelectedIndex == 1);
            this.AISettings.AD_World = (World)comboBox.SelectedIndex;
            this.AD_UpdateSequenceButton();
            if (this.AISettings.AD_World == World.None || this.AISettings.AD_World == World.Sequencer || this.AISettings.AD_World == World.MoonlitIsle)
            {
                this.AD_PopulateStage(20);
            }
            else if (this.AISettings.AD_World == World.WesternEmpire)
            {
                this.AD_PopulateStage(15);
            }
            else
            {
                this.AD_PopulateStage(10);
            }
            this.AD_PopulateDifficulty2nd(Difficulty.None, Difficulty.Easy, Difficulty.Normal);
            this.AD_PopulateDifficulty(Difficulty.None, Difficulty.Easy, Difficulty.Normal, Difficulty.Hard);
            if (this.loaded && this.AISettings.AD_World == World.Sequencer)
            {
                this.AD_ShowSequencerForm();
            }
        }

        private void aiButton_Click(object sender, EventArgs e)
        {
            if (this.AIProfiles.TMP_Paused)
            {
                this.ResumeAI();
                return;
            }
            if (!this.started)
            {
                if (this.ST_TelegramEnableCheckBox.Checked && this.ST_TelegramChatIDTextBox.Text == "")
                {
                    MessageBox.Show("Error : Telegram ChatID empty. Uncheck Enable Telegram Checkbox if you not want use telegram");
                }
                else
                {
                    this.StartAI();
                    return;
                }
            }
            else
            {
                this.StopAI();
                return;
            }
        }

        private void aiPause_Click(object sender, EventArgs e)
        {
            this.PauseAI();
            this.botstatusLabel.Text = "Bot Paused";
            this.botstatusLabel.ForeColor = Color.Orange;
        }

        private void AppendLog(string message)
        {
            this.AppendLog(message, Color.Black);
        }

        private void AppendLog(string message, Color color)
        {
            RichTextBox lG_logTextBox = this.LG_logTextBox;
            RichTextBox logsBox = this.logsBox;
            string text = DateTime.Now.ToString("[hh:mm:ss tt]  ", CultureInfo.InvariantCulture);
            //ubah datetime nya kebentuk UTC
            lG_logTextBox.AppendText(text, Color.Black);
            lG_logTextBox.AppendText(message, color);
            lG_logTextBox.AppendText(Environment.NewLine);
            logsBox.AppendText(text, Color.Black);
            logsBox.AppendText(message, color);
            logsBox.AppendText(Environment.NewLine);

        }

        private void AppendWarning(string message)
        {
            this.AppendLog("WARNING: " + message, Color.Tan);
        }

        private void AR_useRubyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AISettings.AR_UseRuby = @checked;
        }

        private void AR_useRubyNumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int aR_UseRubyAmount = Convert.ToInt32(numericUpDown.Value);
            this.AISettings.AR_UseRubyAmount = aR_UseRubyAmount;
        }

        private void BackgroundWorkerOnCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.started = false;
            this.aiButton.Text = "Start Bot";
            this.statusToolStripLabel.Text = "Status: Bot Stopped";
            this.botstatusLabel.Text = "Bot Stopped";
            this.botstatusLabel.ForeColor = Color.Red;
            try
            {
                Exception arg_39_0 = e.Error;
            }
            finally
            {
                this.Worker.Dispose();
            }
        }

        private void BackgroundWorkerOnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressArgs progressArgs = e.UserState as ProgressArgs;
            if (progressArgs == null)
            {
                return;
            }
            Label label = null;
            switch (progressArgs.Type)
            {
                case ProgressType.OBJECTIVE:
                    this.statusToolStripLabel.Text = string.Format("Status: {0}", progressArgs.Message.ToString());
                    this.UpdateCurrentProfileStatus();
                    this.AppendLog("Changing objective to: " + progressArgs.Message.ToString(), Color.Tomato);
                    if (progressArgs.Message.ToString() == "Adventure")
                    {
                        groupBox8.ForeColor = Color.Black;
                    }else if(progressArgs.Message.ToString() == "Arena")
                    {
                        groupBox8.ForeColor = Color.Green;
                    }
                    else
                    {
                        groupBox8.ForeColor = Color.Black;
                    }
                    return;

                case ProgressType.EVENT:
                    this.AppendLog(progressArgs.Message.ToString(), progressArgs.Color);
                    this.UpdateCurrentProfileStatus();
                    return;

                case ProgressType.ERROR:
                    this.AppendLog("ERROR: " + progressArgs.Message, Color.Firebrick);
                    timer1.Stop();
                    return;

                case ProgressType.WARNING:
                    this.AppendWarning(progressArgs.Message.ToString());
                    return;

                case ProgressType.COUNT:
                    {
                        Dictionary<string, object> dictionary = progressArgs.Message as Dictionary<string, object>;
                        Objective objective = (Objective)dictionary["objective"];
                        string arg = Utility.ToTitleCase(objective.ToString().Replace("_", " "));
                        if (objective == Objective.ARENA)
                        {
                            int num = (int)dictionary["winCount"];
                            int num2 = (int)dictionary["loseCount"];
                            int numm2 = (int)dictionary["arenaRank"];
                            this.arenaWinLabel2.Text = num.ToString();
                            this.arenaLoseLabel2.Text = num2.ToString();
                            this.arenaCountLabel.Text = "x" + (num + num2).ToString();
                            this.rankArenaLabel.Text = numm2.ToString();
                            return;
                        }
                        else if(objective == Objective.SMART_MODE)
                        {
                            int num = (int)dictionary["count"];
                            this.SmartModeCountLabel.Text = "x" + num.ToString();
                        }

                        int num3 = (int)dictionary["count"];
                        string text = string.Format("x" + num3);
                        string text2 = "";
                        string text3 = "";
                        string text4 = "";
                        string text5 = "";
                        if (objective == Objective.CHECK_SLOT_HERO)
                        {
                            string t1 = "" + dictionary["hc"];
                            string t2 = "" + dictionary["hm"];
                            text = string.Format("{0}/{1}", t1, t2);
                        }
                        else if (objective == Objective.ADVENTURE)
                        {
                            text2 = "" + dictionary["h30"]; //hero30
                        }
                        switch (objective)
                        {
                            case Objective.ADVENTURE:
                                this.adventureCountLabel.Text = text;
                                //this.heroadvLabel.Text = text5;
                                this.goldadvLabel.Text = text2; //hero30
                                //this.itemadvLabel.Text = text4;
                                return;

                            case Objective.ARENA:
                                break;

                            case Objective.CHECK_SLOT_HERO:
                                this.heroslotLabel.Text = text; //??
                                return;

                            default:
                                return;
                        }
                        break;
                    }
                case ProgressType.KEY:
                    {
                        Dictionary<string, object> dictionary = progressArgs.Message as Dictionary<string, object>;
                        Objective objective = (Objective)dictionary["objective"];
                        int num4 = (int)dictionary["keys"];
                        string text2;
                        if (num4 == -1)
                        {
                            text2 = "-";
                        }
                        else if (dictionary.ContainsKey("time"))
                        {
                            string arg2 = ((TimeSpan)dictionary["time"]).ToString("mm':'ss");
                            text2 = string.Format("x{0} ({1})", num4, arg2);
                        }
                        else
                        {
                            text2 = string.Format("x{0}", num4);
                        }
                        switch (objective)
                        {
                            case Objective.ADVENTURE:
                                label = this.adventureKeysLabel2;
                                break;

                            case Objective.ARENA:
                                label = this.arenaKeysLabel2;
                                break;
                        }
                        if (text2 != null)
                        {
                            label.Text = text2;
                            return;
                        }
                        break;
                    }
                case ProgressType.RESOURCE:
                    {
                        Dictionary<string, object> dictionary = progressArgs.Message as Dictionary<string, object>;
                        ResourceType resourceType = (ResourceType)dictionary["resourceType"];
                        int num5 = (int)dictionary["value"];
                        string text2;
                        if (num5 == -1)
                        {
                            text2 = "-";
                        }
                        else
                        {
                            text2 = num5.ToString("N0");
                        }
                        switch (resourceType)
                        {
                            case ResourceType.GOLD:
                                label = this.goldLabel2;
                                label.Text = text2;
                                break;

                            case ResourceType.RUBY:
                                label = this.rubyLabel2;
                                label.Text = text2;
                                break;

                            case ResourceType.HONOR:
                                label = this.honorLabel2;
                                label.Text = text2;
                                break;
                            case ResourceType.GOLDEN_CRYSTAL:
                                label = this.goldencrystalLabel;
                                label.Text = text2;
                                break;
                            case ResourceType.HORN:
                                label = this.hornLabel;
                                label.Text = text2;
                                break;
                            case ResourceType.SCALE:
                                label = this.scaleLabel;
                                label.Text = text2;
                                break;
                            case ResourceType.ESSENCE:
                                label = this.essenceLabel;
                                label.Text = text2;
                                break;
                            case ResourceType.STAR:
                                label = this.starLabel;
                                label.Text = text2;
                                break;
                        }
                        break;
                    }
                case ProgressType.CHECK_SLOT:
                    {
                        Dictionary<string, object> dictionary = progressArgs.Message as Dictionary<string, object>;
                        Objective objective = (Objective)dictionary["objective"];
                        int num = (int)dictionary["count"];
                        int num2 = (int)dictionary["max"];
                        string text2 = string.Format("{0} / {1}", num, num2);
                        switch (objective)
                        {
                            case Objective.CHECK_SLOT_HERO:
                                this.heroslotLabel.Text = text2;
                                break;

                            case Objective.CHECK_SLOT_ITEM:
                                this.itemslotLabel.Text = text2;
                                break;
                        }
                        break;
                    }
                case ProgressType.CURSORPOS:
                    {
                        Point curpos = (Point)progressArgs.Message;
                        this.tsslCursorPosition.Text = string.Format("X: {0}, Y: {1}", curpos.X, curpos.Y);
                        break;
                    }
                case ProgressType.Alert:
                    {
                        if ((string)progressArgs.Message == "Heroes Full")
                        {
                            if (this.AISettings.AD_StopOnFullHeroes)
                            {
                                this.PauseAI();
                                this.AlertSound.PlayLooping();
                                AutoClosingMessageBox.Show("Heroes Full!", "Heroes Full!", 5000);
                                this.AlertSound.Stop();
                            }
                        }
                        else if ((string)progressArgs.Message == "Items Full")
                        {
                            if (this.AISettings.AD_StopOnFullItems)
                            {
                                this.PauseAI();
                                this.AlertSound.PlayLooping();
                                AutoClosingMessageBox.Show("Items Full!", "Items Full!", 5000);
                                this.AlertSound.Stop();
                            }
                        }
                        else if ((string)progressArgs.Message == "Items Full")
                        {
                            if (this.AISettings.AD_StopOnFullItems)
                            {
                                this.PauseAI();
                                this.AlertSound.PlayLooping();
                                AutoClosingMessageBox.Show("Items Full!", "Items Full!", 5000);
                                this.AlertSound.Stop();
                            }
                        }
                        else if ((string)progressArgs.Message == "Bot Error2")
                        {
                            bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "Bot Stuck, bot will restart seven knights. You still need to ResumeBot");
                            this.aiPause.PerformClick();
                            CaptureReport();
                            bot.SendPhoto.Show_sending_a_photo = true;
                            bot.SendPhoto.caption = String.Format("Last Screenshot {0}", DateTime.Now.ToString());
                            bot.SendPhoto.send(this.AIProfiles.ST_TelegramChatID, @"C://screen.png");
                            this.AlertSound.PlayLooping();
                            Thread.Sleep(5000);
                            this.AlertSound.Stop();
                            Thread.Sleep(5000);
                            Restart7k();
                            Thread.Sleep(5000);
                            aiButton.PerformClick(); // resume
                        }
                        else if ((string)progressArgs.Message == "Bot Error")
                        {
                            bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "Bot Stuck, bot automatically paused");
                            this.PauseAI();
                            this.AlertSound.PlayLooping();
                            Thread.Sleep(5000);
                            this.AlertSound.Stop();
                        }
                        else if ((string)progressArgs.Message == "Hero Level 30")
                        {
                            this.PauseAI();
                            this.AlertSound.PlayLooping();
                            Thread.Sleep(5000);
                            this.AlertSound.Stop();
                        }
                        else if ((string)progressArgs.Message == "No More Hero 30")
                        {
                            bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "Bot Paused because no more hero to replace");
                            this.PauseAI();
                            this.AlertSound.PlayLooping();
                            Thread.Sleep(5000);
                            this.AlertSound.Stop();
                        }
                        else if ((string)progressArgs.Message == "Max Level Up")
                        {
                            bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "Bot Paused because Hero Max Level Up 100/100");
                            this.PauseAI();
                            this.AlertSound.PlayLooping();
                            Thread.Sleep(1500);
                            this.AlertSound.Stop();
                        }
                        else if ((string)progressArgs.Message == "Internet Down")
                        {
                            bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "Bot Paused because your internet connection is down");
                            this.PauseAI();
                            this.AlertSound.PlayLooping();
                            Thread.Sleep(1500);
                            this.AlertSound.Stop();
                        }
                        break;
                    }
                default:
                    return;
            }
        }

        private void enableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            switch (num)
            {
                case 0:
                    this.AISettings.AD_Enable = @checked;
                    return;

                case 2:
                    this.AISettings.AR_Enable = @checked;
                    return;

                default:
                    return;
            }
        }

        private void EnablePause(bool value)
        {
            ContextMenu contextMenu = this.aiButton.ContextMenu;
            MenuItem menuItem = contextMenu.MenuItems[0];
            menuItem.Enabled = value;
            aiPause.Enabled = value;
        }

        private Control FindControlByTag(Control.ControlCollection controls, int tag)
        {
            foreach (Control control in controls)
            {
                if (control.Tag != null && Convert.ToInt32(control.Tag) == tag)
                {
                    return control;
                }
            }
            return null;
        }

        private void GB_WaitForKeys_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AISettings.GB_WaitForKeys = @checked;
        }

        private void Init()
        {
            MainForm.Instance = this;
            this.SynchronizationContext = SynchronizationContext.Current;
            HotTimeHelper.ImportHotTimeSchedule();
            try
            {
                this.AIProfiles = AIProfiles.Load();
            }
            catch (AISettingsException ex)
            {
                if (ex.ErrorCode != -1)
                {
                    MessageBox.Show("Error loading settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                this.AIProfiles = new AIProfiles(new AISettings());
            }
            this.AI = new SevenKnightsCore(this.AIProfiles);
        }

        private void InitAdventureTab()
        {
            for (int i = 0; i < 3; i++)
            {
                this._skillButtons[i] = new List<Button>();
            }
            this.AD_enableCheckBox.Checked = this.AISettings.AD_Enable;
            this.AD_EnHottime_Checkbox.Checked = this.AISettings.AD_HottimeEnable;
            this.AD_limitCheckBox.Checked = this.AISettings.AD_EnableLimit;
            this.AD_limitNumericBox.Value = this.AISettings.AD_Limit;
            this.AD_worldComboBox.SelectedIndex = (int)this.AISettings.AD_World;
            this.AD_stageComboBox.SelectedIndex = this.AISettings.AD_Stage;
            this.AD_difficultyComboBox.SelectedValue = this.AISettings.AD_Difficulty;
            this.AD_difficultyComboBox2nd.SelectedValue = this.AISettings.AD_Difficulty2nd;
            this.AD_teamComboBox.SelectedIndex = (int)this.AISettings.AD_Team;
            this.AD_continuousCheckBox.Checked = this.AISettings.AD_Continuous;
            this.AD_StopOnFullHeroes_Checkbox.Checked = this.AISettings.AD_StopOnFullHeroes;
            this.AD_StopOnFullItems_Checkbox.Checked = this.AISettings.AD_StopOnFullItems;
            this.AD_UseFriendCheckBox.Checked = this.AISettings.AD_UseFriend;
            this.AD_bootmodeCheckBox.Checked = this.AISettings.AD_BootMode;
        }

        private void InitArenaTab()
        {
            this.AR_enableCheckBox.Checked = this.AISettings.AR_Enable;
            this.AR_limitCheckBox.Checked = this.AISettings.AR_EnableLimit;
            this.AR_limitNumericBox.Value = this.AISettings.AR_Limit;
            this.AR_useRubyCheckBox.Checked = this.AISettings.AR_UseRuby;
            this.AR_useRubyNumericBox.Value = this.AISettings.AR_UseRubyAmount;
            this.AR_stopArenaCheckBox.Checked = this.AISettings.AR_LimitArena;
            this.AR_stopArenaNumericBox.Value = this.AISettings.AR_LimitScore;
        }

        private void InitGlobalProfile()
        {
            this.GB_WaitForKeys.Checked = this.AISettings.GB_WaitForKeys;
        }

        private void InitLogsTab()
        { }

        private void InitResourcesTab()
        {
            this.RS_sellHeroesCheckBox.Checked = this.AISettings.RS_SellHeroes;
            this.RS_heroStarsComboBox.SelectedIndex = this.AISettings.RS_SellHeroStars - 1;
            this.RS_heroAmountNumericBox.Value = this.AISettings.RS_SellHeroAmount;
            this.RS_heroAllRadioButton.Checked = this.AISettings.RS_SellHeroAll;
            this.RS_heroAmountRadioButton.Checked = !this.AISettings.RS_SellHeroAll;
            this.RS_sellItemsCheckBox.Checked = this.AISettings.RS_SellItems;
            this.RS_itemStarsComboBox.SelectedIndex = this.AISettings.RS_SellItemStars - 1;
            this.RS_itemAmountNumericBox.Value = this.AISettings.RS_SellItemAmount;
            this.RS_itemAllRadioButton.Checked = this.AISettings.RS_SellItemAll;
            this.RS_itemAmountRadioButton.Checked = !this.AISettings.RS_SellItemAll;
            this.RS_inboxHonors.Checked = this.AISettings.RS_InboxHonors;
            this.RS_inboxMaterials.Checked = this.AISettings.RS_InboxKeys;
            this.RS_InboxKeys.Checked = this.AISettings.RS_InboxGold;
            this.RS_luckyBoxCheckBox.Checked = this.AISettings.RS_CollectLuckyBox;
            this.RS_luckyChestCheckBox.Checked = this.AISettings.RS_CollectLuckyChest;
            this.RS_specialQuestsDailyCheckBox.Checked = this.AISettings.RS_SpecialQuestsDaily;
            this.RS_specialQuestsWeeklyCheckBox.Checked = this.AISettings.RS_SpecialQuestsWeekly;
            this.RS_specialQuestsMonthlyCheckBox.Checked = this.AISettings.RS_SpecialQuestsMonthly;
            this.RS_questsBattleCheckBox.Checked = this.AISettings.RS_QuestsBattle;
            this.RS_questsHeroCheckBox.Checked = this.AISettings.RS_QuestsHero;
            this.RS_questsItemCheckBox.Checked = this.AISettings.RS_QuestsItem;
            this.RS_questsSocialCheckBox.Checked = this.AISettings.RS_QuestsSocial;
            this.RS_sendHonorsFacebook.Checked = this.AISettings.RS_SendHonorsFacebook;
            this.RS_sendHonorsInGame.Checked = this.AISettings.RS_SendHonorsInGame;
            this.RS_buyKeyHonorsCheckBox.Checked = this.AISettings.RS_BuyKeyHonors;
            this.RS_buyKeyHonorsComboBox.SelectedIndex = (int)this.AISettings.RS_BuyKeyHonorsType;
            this.RS_buyKeyHonorsNumericBox.Value = this.AISettings.RS_BuyKeyHonorsAmount;
            this.RS_buyKeyRubiesCheckBox.Checked = this.AISettings.RS_BuyKeyRubies;
            this.RS_buyKeyRubiesComboBox.SelectedIndex = (int)this.AISettings.RS_BuyKeyRubiesType;
            this.RS_buyKeyRubiesNumericBox.Value = this.AISettings.RS_BuyKeyRubiesAmount;
        }

        private void InitSettingsTab()
        {
            this.ST_RefreshProfiles();
            this.ST_delayTrackBar.Value = this.AIProfiles.ST_Delay;
            this.ST_reconnectInterruptCheckBox.Checked = this.AIProfiles.ST_ReconnectInterruptEnable;
            this.ST_reconnectNumericUpDown.Value = this.AIProfiles.ST_ReconnectInterruptInterval;
            this.ST_TelegramEnableCheckBox.Checked = this.AIProfiles.ST_EnableTelegram;
            this.ST_TelegramTokenTextBox.Text = this.AIProfiles.ST_TelegramToken;
            this.ST_TelegramChatIDTextBox.Text = this.AIProfiles.ST_TelegramChatID;
        }

        private void InitOtherTab()
        {
            this.AD_NoHeroUp_Checkbox.Checked = this.AIProfiles.AD_NoHeroUp;
        }

        private void InitSmartModeTab()
        {
            this.SM_EnableCheckBox.Checked = this.AISettings.SM_Enable;
            this.SM_CollectRaidCheckBox.Checked = this.AISettings.SM_CollectRaid;
            this.SM_CollectTartarusCheckBox.Checked = this.AISettings.SM_CollectTartarus;
            this.SM_CollectTowerCheckBox.Checked = this.AISettings.SM_CollectTower;
        }

        private void LG_clearButton_Click(object sender, EventArgs e)
        {
            this.LG_logTextBox.Clear();
            this.LG_logTextBox.Refresh();
            this.logsBox.Clear();
            this.logsBox.Refresh();
        }

        private void LG_exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = string.Format("{0}.log", "sevenknights-".AppendTimeStamp());
            saveFileDialog.Filter = "Log files (*.log)|*.log|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = Application.StartupPath;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    streamWriter.Write(this.LG_logTextBox.Text);
                    streamWriter.Write(this.logsBox.Text);
                }
            }
        }

        private void LG_LogPixel_Click(object sender, EventArgs e)
        {
            this.LogPixel();
        }

        private void LG_logTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.LG_autoScroll)
            {
                this.LG_ScrollToEnd();
            }
        }

        private void LG_SaveScreen_Click(object sender, EventArgs e)
        {

            /*
             * Bitmap screen = this.AI.BlueStacks.CaptureFrame(!this.AIProfiles.ST_ForegroundMode);
            screen.Save("C:\\screen.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "bmp";
            saveFileDialog.Filter = "Bitmap file (*.bmp)|*.bmp";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.SupportMultiDottedExtensions = false;
            saveFileDialog.Title = "Save Screen As";
            

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                screen.Save(saveFileDialog.FileName);
            }
            */
        }

        private void LG_scrollCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.LG_autoScroll = @checked;
            if (@checked)
            {
                this.LG_ScrollToEnd();
            }
        }

        private void LG_ScrollToEnd()
        {
            this.LG_logTextBox.SelectionStart = this.LG_logTextBox.Text.Length;
            this.LG_logTextBox.ScrollToCaret();
            this.logsBox.SelectionStart = this.logsBox.Text.Length;
            this.logsBox.ScrollToCaret();
        }

        private void limitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            switch (num)
            {
                case 0:
                    this.AISettings.AD_EnableLimit = @checked;
                    return;

                case 2:
                    this.AISettings.AR_EnableLimit = @checked;
                    return;

                default:
                    return;
            }
        }

        private void limitNumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            short num = Convert.ToInt16(numericUpDown.Tag);
            int num2 = Convert.ToInt32(numericUpDown.Value);
            switch (num)
            {
                case 0:
                    this.AISettings.AD_Limit = num2;
                    return;

                case 2:
                    this.AISettings.AR_Limit = num2;
                    return;

                case 6:
                    this.AISettings.AD_CurrH30 = num2;
                    return;
                default:
                    return;
            }
        }

        private void LogPixel()
        {
            if (this.Worker != null)
            {
                this.AIProfiles.TMP_LogPixel = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        { }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bot.token = this.AIProfiles.ST_TelegramToken;
            this.Worker2.DoWork += new DoWorkEventHandler(Test);
            this.Worker2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.Worker2_RunWorkerCompleted);
            this.Worker2.ProgressChanged += new ProgressChangedEventHandler(this.Worker2_ProgressChanged);
            this.Worker2.WorkerReportsProgress = true;
            this.Worker2.WorkerSupportsCancellation = true;
            Worker2.RunWorkerAsync();
            timer1 = new Stopwatch();
            bot.CheckForIllegalCrossThreadCalls = false;
            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItem = new MenuItem("Pause");
            contextMenu.MenuItems.Add(menuItem);
            this.aiButton.ContextMenu = contextMenu;
            menuItem.Enabled = false;
            menuItem.Click += delegate (object _sender, EventArgs _e)
            {
                this.PauseAI();
            };

            //Loading Sound file and preparing it to play if needed.
            this.AlertSound = new SoundPlayer(SevenKnightsAI.Properties.Resources.Alien_AlarmDrum_KevanGC_893953959);
            string build = "v" + this.ProductVersion + " - " + Assembly.GetExecutingAssembly().GetLinkerTime().ToShortDateString();
            this.tsslBuildInfo.Text = "Build: " + build;
            AppendLog("Loaded Build :  " + build, Color.LightSeaGreen);
            this.loaded = true;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        { }

        private void PauseAI()
        {
            if (this.Worker != null)
            {
                this.AIProfiles.TMP_Paused = true;
                this.aiButton.Text = "&Resume Bot";
                this.EnablePause(false);
                timer1.Stop();
            }

            this.tabControl1.SelectedTab = tabPage4;
        }

        private void ReloadTabs(bool refreshSettings)
        {
            this.InitAdventureTab();
            this.InitGlobalProfile();
            this.InitArenaTab();
            this.InitResourcesTab();
            this.InitLogsTab();
            this.InitOtherTab();
            this.InitSmartModeTab();
            if (refreshSettings)
            {
                this.InitSettingsTab();
            }
        }

        private void ResumeAI()
        {
            this.AIProfiles.TMP_Paused = false;
            this.AIProfiles.TMP_WaitingForKeys = false;
            this.tsslCursorPosition.Text = "";
            this.aiButton.Text = "Stop Bot";
            this.botstatusLabel.Text = "Bot Running";
            this.botstatusLabel.ForeColor = Color.Green;

            this.tabControl1.SelectedTab = tabPage4;
            this.EnablePause(true);
            timer1.Start();
            
        }

        private void RS_buyKeysCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            if (num == 0)
            {
                this.AISettings.RS_BuyKeyHonors = @checked;
                return;
            }
            if (num == 1)
            {
                this.AISettings.RS_BuyKeyRubies = @checked;
            }
        }

        private void RS_buyKeysComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            short num = Convert.ToInt16(comboBox.Tag);
            int selectedIndex = comboBox.SelectedIndex;
            if (num == 0)
            {
                this.AISettings.RS_BuyKeyHonorsType = (BuyKeyHonorsType)selectedIndex;
                return;
            }
            if (num == 1)
            {
                this.AISettings.RS_BuyKeyRubiesType = (BuyKeyRubiesType)selectedIndex;
            }
        }

        private void RS_buyKeysNumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            short num = Convert.ToInt16(numericUpDown.Tag);
            int num2 = Convert.ToInt32(numericUpDown.Value);
            if (num == 0)
            {
                this.AISettings.RS_BuyKeyHonorsAmount = num2;
                return;
            }
            if (num == 1)
            {
                this.AISettings.RS_BuyKeyRubiesAmount = num2;
            }
        }

        private void RS_collectGiftCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            switch (num)
            {
                case 0:
                    this.AISettings.RS_CollectLuckyChest = @checked;
                    return;

                case 1:
                    this.AISettings.RS_CollectLuckyBox = @checked;
                    return;

                default:
                    return;
            }
        }

        private void RS_collectInboxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            switch (num)
            {
                case 0:
                    this.AISettings.RS_InboxHonors = @checked;
                    return;

                case 1:
                    this.AISettings.RS_InboxKeys = @checked;
                    return;

                case 2:
                    this.AISettings.RS_InboxGold = @checked;
                    return;

                case 3:
                    this.AISettings.RS_InboxRubies = @checked;
                    return;

                case 4:
                    this.AISettings.RS_InboxTickets = @checked;
                    return;

                default:
                    return;
            }
        }

        private void RS_collectQuestsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            switch (num)
            {
                case 0:
                    this.AISettings.RS_SpecialQuestsDaily = @checked;
                    return;

                case 1:
                    this.AISettings.RS_SpecialQuestsWeekly = @checked;
                    return;

                case 2:
                    this.AISettings.RS_SpecialQuestsMonthly = @checked;
                    return;

                case 3:
                    this.AISettings.RS_QuestsBattle = @checked;
                    return;

                case 4:
                    this.AISettings.RS_QuestsHero = @checked;
                    return;

                case 5:
                    this.AISettings.RS_QuestsItem = @checked;
                    return;

                case 6:
                    this.AISettings.RS_QuestsSocial = @checked;
                    return;

                default:
                    return;
            }
        }

        private void RS_sellAllRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            short num = Convert.ToInt16(radioButton.Tag);
            bool @checked = radioButton.Checked;
            if (num == 0)
            {
                this.RS_heroAmountNumericBox.Enabled = !@checked;
                this.AISettings.RS_SellHeroAll = @checked;
                return;
            }
            if (num == 1)
            {
                this.RS_itemAmountNumericBox.Enabled = !@checked;
                this.AISettings.RS_SellItemAll = @checked;
            }
        }

        private void RS_sellAmountNumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            short num = Convert.ToInt16(numericUpDown.Tag);
            int num2 = Convert.ToInt32(numericUpDown.Value);
            if (num == 0)
            {
                this.AISettings.RS_SellHeroAmount = num2;
                return;
            }
            if (num == 1)
            {
                this.AISettings.RS_SellItemAmount = num2;
            }
        }

        private void RS_sellCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            if (num == 0)
            {
                this.AISettings.RS_SellHeroes = @checked;
                return;
            }
            if (num == 1)
            {
                this.AISettings.RS_SellItems = @checked;
            }
        }

        private void RS_sellStarsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            short num = Convert.ToInt16(comboBox.Tag);
            int num2 = comboBox.SelectedIndex + 1;
            if (num == 0)
            {
                this.AISettings.RS_SellHeroStars = num2;
                return;
            }
            if (num == 1)
            {
                this.AISettings.RS_SellItemStars = num2;
            }
        }

        private void RS_sendHonorsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            short num = Convert.ToInt16(checkBox.Tag);
            bool @checked = checkBox.Checked;
            if (num == 0)
            {
                this.AISettings.RS_SendHonorsFacebook = @checked;
                return;
            }
            if (num == 1)
            {
                this.AISettings.RS_SendHonorsInGame = @checked;
            }
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.AIProfiles.Save();
                MessageBox.Show("Settings has been saved!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot save settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ST_currentProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProfileComboBoxItem profileComboBoxItem = comboBox.SelectedItem as ProfileComboBoxItem;
            this.AIProfiles.ChangeProfile(profileComboBoxItem.Key);
            this.ReloadTabs(false);
        }

        private void ST_delayTrackBar_ValueChanged(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            int value = trackBar.Value;
            this.ST_delayValueLabel.Text = value.ToString() + " ms";
            this.AIProfiles.ST_Delay = value;
        }

        private void ST_forceActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.ST_BlueStacksForceActive = @checked;
        }

        private void ST_foregroundMode_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.ST_ForegroundMode = @checked;
        }

        private void ST_hotTimeProfileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.ST_EnableHotTimeProfile = @checked;
        }

        private void ST_autoProfileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.ST_EnableAutoProfile = @checked;
        }

        private void ST_AutoShutdownCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.ST_EnableAutoShutdown = @checked;
        }

        private void ST_TelegramEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.ST_EnableTelegram = @checked;
            if (checkBox.Checked)
            {
                ST_TelegramTokenTextBox.Enabled = true;
                ST_TelegramChatIDTextBox.Text = "";
                ST_TelegramTokenTextBox.Text = "";
            }
            else
            {
                ST_TelegramChatIDTextBox.Text = "";
                ST_TelegramTokenTextBox.Text = "";
                ST_TelegramTokenTextBox.Enabled = false;
            }
        }

        private void ST_hotTimeProfileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProfileComboBoxItem profileComboBoxItem = comboBox.SelectedItem as ProfileComboBoxItem;
            this.AIProfiles.ST_HotTimeProfile = profileComboBoxItem.Key;
        }

        private void ST_manageProfileButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@Environment.CurrentDirectory + "//profiles"))
            {
                saveSettingsButton.PerformClick();
            }
            CreateNewProfiles cnp = new CreateNewProfiles();
            cnp.Show();
        }

        private void ST_opacityTrackBar_ValueChanged(object sender, EventArgs e)
        {
            TrackBar trackBar = sender as TrackBar;
            int value = trackBar.Value;
            base.Opacity = (double)value / (double)trackBar.Maximum;
        }

        private void ST_TelegramTokenTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string text = textBox.Text;
            this.AIProfiles.ST_TelegramToken = text;
            bot.token = ST_TelegramTokenTextBox.Text;
        }

        private void ST_TelegramChatIDTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string text = textBox.Text;
            this.AIProfiles.ST_TelegramChatID = text;
        }

        private void ST_reconnectInterruptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.ST_ReconnectInterruptEnable = @checked;
        }

        private void ST_reconnectNumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            decimal value = numericUpDown.Value;
            this.AIProfiles.ST_ReconnectInterruptInterval = (int)value;
        }

        private void ST_RefreshProfiles()
        {
            int num = 0;
            this.ST_currentProfileComboBox.Items.Clear();
            foreach (KeyValuePair<string, AISettings> current in this.AIProfiles.Settings)
            {
                ProfileComboBoxItem item = new ProfileComboBoxItem(current);
                this.ST_currentProfileComboBox.Items.Add(item);
                if (current.Key == this.AIProfiles.CurrentKey)
                {
                    this.ST_currentProfileComboBox.SelectedIndex = num;
                }
                num++;
            }
            this.groupBox2.Text = "Current Profiles: "+ this.ST_currentProfileComboBox.Text;
        }

        private void StartAI()
        {
            this.Worker = this.AI.Start(this.SynchronizationContext);
            this.Worker.ProgressChanged += new ProgressChangedEventHandler(this.BackgroundWorkerOnProgressChanged);
            this.Worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.BackgroundWorkerOnCompleted);
            this.started = true;
            this.aiButton.Text = "Stop Bot";
            this.botstatusLabel.Text = "Bot Running";
            this.botstatusLabel.ForeColor = Color.Green;

            this.tabControl1.SelectedTab = tabPage4;
            this.EnablePause(true);
            this.button2.Enabled = true;
            timer1.Reset();
            timer1.Start();
            timer2.Start();

        }

        private string Restart7k()
        {
            string messages;

            if (!this.AI.BlueStacks.RestartGame(5))
            {
                messages = "Error Restart Seven Knights";
            }
            else
            {
                messages = "Restart Seven Knights Success";
            }
            return messages;
        }

        private void StopAI()
        {

            this.tabControl1.SelectedTab = tabPage4;
            if (this.Worker != null)
            {
                this.Worker.CancelAsync();
                this.EnablePause(false);
                this.button2.Enabled = false;
                this.profileToolStripLabel.Text = string.Empty;
                this.AIProfiles.TMP_Paused = false;
                this.AIProfiles.TMP_WaitingForKeys = false;
                if (this.AIProfiles.TMP_UsingHotTimeProfile)
                {
                    this.AIProfiles.ToggleHotTimeProfile();
                    for (int i = 0; i < 2; i++)
                    {
                        this.ReloadTabs(true);
                    }
                }
            }
            timer1.Stop();
            timer.Text = "00:00:00";
        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null)
            {
                return;
            }
            short num = Convert.ToInt16(comboBox.Tag);
            Team selectedIndex = (Team)comboBox.SelectedIndex;
            switch (num)
            {
                case 0:
                    this.AISettings.AD_Team = selectedIndex;
                    return;

                default:
                    return;
            }
        }

        private void UpdateCurrentProfileStatus()
        {
            this.profileToolStripLabel.Text = string.Format("[Profile: {0}]", this.AIProfiles.CurrentProfileName);
        }

        private void AD_CheckingHeroes_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_CheckingHeroes = checkBox.Checked;
        }
        // ***************************************
        private void AD_EnHottime_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_HottimeEnable = checkBox.Checked;
        }
        private void AD_UseFriendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_UseFriend = checkBox.Checked;
        }
        private void AD_bootmodeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_BootMode = checkBox.Checked;
            MessageBox.Show("Enable Boost in Asgar map only coming soon");
        }

        private void AD_teamComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null)
            {
                return;
            }
            short num = Convert.ToInt16(comboBox.Tag);
            Team selectedIndex = (Team)comboBox.SelectedIndex;
            this.AISettings.AD2_Team = selectedIndex;
            return;
        }

        private void AR_stopArenaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AR_LimitArena = checkBox.Checked;
        }

        private void AR_stopArenaNumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int num = Convert.ToInt32(numericUpDown.Value);
            this.AISettings.AR_LimitScore = num;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - StartTime;

            // Start with the days if greater than 0.
            string text = "";
            if (elapsed.Days > 0)
                text += elapsed.Days.ToString() + ".";

            // Convert milliseconds into tenths of seconds.
            int tenths = elapsed.Milliseconds / 100;

            // Compose the rest of the elapsed time.
            text +=
                elapsed.Hours.ToString("00") + ":" +
                elapsed.Minutes.ToString("00") + ":" +
                elapsed.Seconds.ToString("00");

            timer.Text = text;
        }

        private void logsBox_TextChanged(object sender, EventArgs e)
        {
            if (this.LG_autoScroll)
            {
                this.LG_ScrollToEnd();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateNewProfiles cnp = new CreateNewProfiles();
            cnp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ST_RefreshProfiles();
        }

        private void Worker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AppendLog(e.Error.ToString());
        }

        private void Worker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressArgsTelegram progressArgsT = e.UserState as ProgressArgsTelegram;
            if (progressArgsT == null)
            {
                return;
            }
            switch (progressArgsT.Type)
            {
                case ProgressType.COMMANDT:
                    {
                        if ((string)progressArgsT.Message == "Start Bot")
                        {
                            this.aiButton.PerformClick();
                        }
                        else if ((string)progressArgsT.Message == "Stop Bot")
                        {
                            this.aiButton.PerformClick();
                        }
                        else if ((string)progressArgsT.Message == "Pause Bot")
                        {
                            this.aiPause.PerformClick();
                        }
                        else if ((string)progressArgsT.Message == "Resume Bot")
                        {
                            this.aiButton.PerformClick();
                        }
                        else if ((string)progressArgsT.Message == "Enable Adventure")
                        {
                            this.AISettings.AD_Enable = true;
                        }
                        else if ((string)progressArgsT.Message == "Enable Arena")
                        {
                            this.AISettings.AR_Enable = true;
                        }
                        else if ((string)progressArgsT.Message == "Disable Adventure")
                        {
                            AI.DisableMode(Objective.ADVENTURE);
                        }
                        else if ((string)progressArgsT.Message == "Disable Arena")
                        {
                            AI.DisableMode(Objective.ARENA);
                        }
                        else if ((string)progressArgsT.Message == "Change Mode Adventure")
                        {
                            this.AI.ChangeMode(Objective.ADVENTURE);
                        }
                        else if ((string)progressArgsT.Message == "Change Mode Arena")
                        {
                            this.AI.ChangeMode(Objective.ARENA);
                        }
                        else if ((string)progressArgsT.Message == "RestartBS")
                        {
                            cb.RestartBluestacks();
                        }
                        else if ((string)progressArgsT.Message == "KillBS")
                        {
                            cb.Kill();
                        }
                        else if ((string)progressArgsT.Message == "Kill7K")
                        {
                            cb.TerminateGame();
                        }
                        else if ((string)progressArgsT.Message == "Restart7K")
                        {
                            cb.RestartGame();
                        }
                        break;
                    }
            }
        }

        private void SendCommand(string message)
        {
            ProgressArgsTelegram userState = new ProgressArgsTelegram(ProgressType.COMMANDT, message);
            this.Worker2.ReportProgress(0, userState);
        }

        private void AD_NoHeroUp_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.AD_NoHeroUp = @checked;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = timer1.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
ts.Hours, ts.Minutes, ts.Seconds);
            timer.Text = elapsedTime;
        }

        private void SM_CollectTowerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AISettings.SM_CollectTower = @checked;
        }

        private void SM_CollectRaidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AISettings.SM_CollectRaid = @checked;
        }

        private void SM_CollectTartarusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AISettings.SM_CollectTartarus = @checked;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            cb.RunApp();
        }
        private void SM_EnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AISettings.SM_Enable = @checked;
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void AD_CheckSlot_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AISettings.AD_CheckSlot = @checked;
        }
        

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void adventurePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void adventureCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void summaryGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap screen = this.AI.BlueStacks.CaptureFrame(!this.AIProfiles.ST_ForegroundMode);
            screen.Save("C:\\screenTest.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show("Open C:\\screenTest.jpg, if image show 7k game then you're bluestacks is fine");
        }

        private void AD_BoostModeAsgarRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Radio = sender as RadioButton;
            this.AISettings.AD_BoostAsgar = Radio.Checked;
        }

        private void AD_BoostModeAllMapsRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Radio = sender as RadioButton;
            this.AISettings.AD_BoostAllMap = Radio.Checked;
        }
        #endregion Private Methods 
    }
    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;
        AutoClosingMessageBox(string text, string caption, int timeout)
        {
            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            using (_timeoutTimer)
                MessageBox.Show(text, caption);
        }
        public static void Show(string text, string caption, int timeout)
        {
            new AutoClosingMessageBox(text, caption, timeout);
        }
        void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }
}