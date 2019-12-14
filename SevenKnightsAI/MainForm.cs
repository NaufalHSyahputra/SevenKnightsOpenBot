using ScreenShotDemo;
using SevenKnightsAI.Classes;
using SevenKnightsAI.Classes.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Media;
using System.Reflection;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using Telegram;

namespace SevenKnightsAI
{
    public partial class MainForm : Form
    {
        #region Public Fields

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

        private ControlBluestacks cb;

        private int ms, s, m, h; //Milliseconds | Seconds | Minutes | Hours

        private string test;

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
                MessageBox.Show("No admin permissions. AI might not function as expected!",
                "No Admin Permissions",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning // for Warning  
               );
                this.AppendWarning("No admin permissions. AI might not function as expected!");
            }
            cb = new ControlBluestacks(AIProfiles.ST_LDTitle);
            test = "";
            foreach (KeyValuePair<string, AISettings> current in this.AIProfiles.Settings)
            {
                string profile_name = current.Key.Replace("./profiles\\", "").Replace(".json", "").ToString();
                string profile_key = current.Key;
                test += "[{text:" + profile_name + ",callback_data:CP " + current.Key + "}],";
            }
            test += "[{text:nothing,callback_data:test}]";
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
            ScreenCapture sc = new ScreenCapture();
            Image img = sc.CaptureScreen();
            sc.CaptureWindowToFile(AutoIt.AutoItX.WinGetHandle("LDPlayer"), @"screen.png", System.Drawing.Imaging.ImageFormat.Png);
            this.tabControl1.SelectedIndex = 0;
            Thread.Sleep(1500);
            sc.CaptureWindowToFile(this.Handle, @"report.png", System.Drawing.Imaging.ImageFormat.Png);
            //Bitmap screen = this.AI.BlueStacks.CaptureFrame(!this.AIProfiles.ST_ForegroundMode);
            //screen.Save("C:\\screen.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public void Test(object sender, DoWorkEventArgs e)
        {
            while (AIProfiles.ST_EnableTelegram)
            {
                bot.update = "true";
                if (bot.message_text == "/start" || bot.message_text == "/Start" || bot.message_text == "ResetTelegram")
                {
                    bot.sendKeyboard.keyboard_R1_1 = "ControlAI";
                    bot.sendKeyboard.keyboard_R1_2 = "ControlPC";
                    bot.sendKeyboard.keyboard_R1_3 = "ControlLDPlayer";
                    bot.sendKeyboard.keyboard_R2_1 = "EnableMode";
                    bot.sendKeyboard.keyboard_R2_2 = "DisableMode";
                    bot.sendKeyboard.keyboard_R2_3 = "ChangeMode";
                    bot.sendKeyboard.keyboard_R3_1 = "GetReport";
                    bot.sendKeyboard.keyboard_R3_2 = "ResetTelegram";
                    bot.sendKeyboard.keyboard_R3_3 = "Profile";
                    bot.sendKeyboard.keyboard_R3_4 = "SaveLog";
                    bot.sendKeyboard.send(bot.chat_id, "Welcome to Seven Knights AI Black Telegram AI.\nYour ChatID will automatically added to your bot.");
                    ST_TelegramChatIDTextBox.Text = bot.chat_id;
                }
                if (bot.message_text == "boost")
                {
                    if (this.AISettings.AD_BootMode)
                    {
                        AISettings.AD_BootMode = false;
                        bot.sendMessage.send(bot.chat_id, "Boost Disabled");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "Boost Enabled");
                        AISettings.AD_BootMode = true;
                    }
                }
                if (bot.message_text == "ht")
                {
                    if (this.AISettings.AD_HottimeEnable)
                    {
                        AISettings.AD_HottimeEnable = false;
                        bot.sendMessage.send(bot.chat_id, "HT Disabled");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "HT Enabled");
                        AISettings.AD_HottimeEnable = true;
                    }
                }
                if (bot.message_text.ToLower() == "profile")
                {
                    bot.send_inline_keyboard.sendByArrayString(bot.chat_id, "Choose Profile you want to activate:", test);
                }
                if (bot.data.ToString().Contains("CP "))
                {
                    if (!this.started)
                    {
                        string testa = bot.data.ToString().Replace("CP ", "").Replace("./profiles", "./profiles\\");
                        this.AIProfiles.ChangeProfile(testa);
                        this.ReloadTabs(true);
                        bot.sendMessage.send(bot.chat_id, testa + " Active");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "Change Mode to \"Change Profile\" first to changing your profile");
                    }
                }
                if (bot.message_text == "SaveLog")
                {
                    string datetimeString = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}.txt", DateTime.Now);
                    using (File.Create(datetimeString))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(datetimeString))
                        {
                            streamWriter.Write(this.LG_logTextBox.Text);
                            streamWriter.Write(this.logsBox.Text);
                        }
                    }
                    bot.SendFile.caption = String.Format("Last Log {0}", DateTime.Now.ToString());
                    bot.SendFile.send(bot.chat_id, datetimeString);
                }
                if (bot.message_text == "ControlAI")
                {
                    bot.send_inline_keyboard.keyboard_R1_1 = "Start AI";
                    bot.send_inline_keyboard.keyboard_R1_1_callback_data = "StartAI";
                    bot.send_inline_keyboard.keyboard_R1_2 = "Stop AI";
                    bot.send_inline_keyboard.keyboard_R1_2_callback_data = "StopAI";
                    bot.send_inline_keyboard.keyboard_R1_3 = "Pause AI";
                    bot.send_inline_keyboard.keyboard_R1_3_callback_data = "PauseAI";
                    bot.send_inline_keyboard.keyboard_R2_1 = "Resume AI";
                    bot.send_inline_keyboard.keyboard_R2_1_callback_data = "ResumeAI";
                    bot.send_inline_keyboard.send(bot.chat_id, "Select Mode You Want To Enable : ");
                }
                if (bot.data == "StartAI")
                {

                    this.tabControl1.SelectedTab = tabPage4;
                    Thread.Sleep(5000);
                    if (!this.started)
                    {
                        SendCommand("Start AI");

                        bot.sendMessage.send(bot.chat_id, "AI Started");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "AI Already Started");
                    }
                }
                if (bot.data == "StopAI")
                {
                    if (this.started)
                    {
                        SendCommand("Stop AI");

                        bot.sendMessage.send(bot.chat_id, "AI Stopped");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "AI Already Stopped");

                    }
                }
                if (bot.data == "PauseAI")
                {
                    if (this.started)
                    {
                        SendCommand("Pause AI");
                        bot.sendMessage.send(bot.chat_id, "AI Paused");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "AI Not Running");
                    }
                }
                if (bot.data == "ResumeAI")
                {
                    if (this.AIProfiles.TMP_Paused)
                    {
                        SendCommand("Resume AI");
                        bot.sendMessage.send(bot.chat_id, "AI Resume");
                    }
                    else
                    {
                        bot.sendMessage.send(bot.chat_id, "AI Not Paused");
                    }
                }
                if (bot.message_text == "EnableMode")
                {
                    bot.send_inline_keyboard.keyboard_R1_1 = "Adventure";
                    bot.send_inline_keyboard.keyboard_R1_1_callback_data = "EnableAdventure";
                    bot.send_inline_keyboard.keyboard_R1_2 = "Arena";
                    bot.send_inline_keyboard.keyboard_R1_2_callback_data = "EnableArena";
                    bot.send_inline_keyboard.keyboard_R1_4 = "Raid";
                    bot.send_inline_keyboard.keyboard_R1_4_callback_data = "EnableRaid";
                    bot.send_inline_keyboard.keyboard_R1_3 = "Power Up";
                    bot.send_inline_keyboard.keyboard_R1_3_callback_data = "EnablePowerUp";
                    bot.send_inline_keyboard.keyboard_R2_1 = "Bulk Fusion";
                    bot.send_inline_keyboard.keyboard_R2_1_callback_data = "EnableBulkFusion";
                    bot.send_inline_keyboard.keyboard_R2_2 = "Collect Inbox";
                    bot.send_inline_keyboard.keyboard_R2_2_callback_data = "EnableCollectInbox";
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
                    bot.sendMessage.send(bot.chat_id, "Arena Enabled");
                }
                if (bot.data == "EnableRaid")
                {
                    SendCommand("Enable Raid");
                    bot.sendMessage.send(bot.chat_id, "Raid Enabled");
                }
                if (bot.data == "EnablePowerUp")
                {
                    SendCommand("Enable PowerUp");
                    bot.sendMessage.send(bot.chat_id, "Auto Power Up Enabled");
                }
                if (bot.data == "EnableBulkFusion")
                {
                    SendCommand("Enable BulkFusion");
                    bot.sendMessage.send(bot.chat_id, "Auto Bulk Fusion Enabled");
                }
                if (bot.data == "EnableCollectInbox")
                {
                    SendCommand("Enable Collect Inbox");
                    bot.sendMessage.send(bot.chat_id, "Auto Collect Inbox Enabled");
                }
                if (bot.message_text == "DisableMode")
                {
                    bot.send_inline_keyboard.keyboard_R1_1 = "Adventure";
                    bot.send_inline_keyboard.keyboard_R1_1_callback_data = "DisableAdventure";
                    bot.send_inline_keyboard.keyboard_R1_2 = "Arena";
                    bot.send_inline_keyboard.keyboard_R1_2_callback_data = "DisableArena";
                    bot.send_inline_keyboard.keyboard_R1_4 = "Raid";
                    bot.send_inline_keyboard.keyboard_R1_4_callback_data = "DisableRaid";
                    bot.send_inline_keyboard.keyboard_R1_3 = "Power Up";
                    bot.send_inline_keyboard.keyboard_R1_3_callback_data = "DisablePowerUp";
                    bot.send_inline_keyboard.keyboard_R2_1 = "Bulk Fusion";
                    bot.send_inline_keyboard.keyboard_R2_1_callback_data = "DisableBulkFusion";
                    bot.send_inline_keyboard.keyboard_R2_2 = "Collect Inbox";
                    bot.send_inline_keyboard.keyboard_R2_2_callback_data = "DisableCollectInbox";
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
                    bot.sendMessage.send(bot.chat_id, "Arena Disabled");
                }
                if (bot.data == "DisableRaid")
                {
                    SendCommand("Disable Raid");
                    bot.sendMessage.send(bot.chat_id, "Raid Disabled");
                }
                if (bot.data == "DisablePowerUp")
                {
                    SendCommand("Disable PowerUp");
                    bot.sendMessage.send(bot.chat_id, "Auto Power Up Disabled");
                }
                if (bot.data == "DisableBulkFusion")
                {
                    SendCommand("Disable BulkFusion");
                    bot.sendMessage.send(bot.chat_id, "Auto Bulk Fusion Disabled");
                }
                if (bot.data == "DisableCollectInbox")
                {
                    SendCommand("Disable Collect Inbox");
                    bot.sendMessage.send(bot.chat_id, "Auto Collect Inbox Disabled");
                }
                if (bot.message_text == "ChangeMode")
                {
                    bot.send_inline_keyboard.keyboard_R1_1 = "Adventure";
                    bot.send_inline_keyboard.keyboard_R1_1_callback_data = "CMAdventure";
                    bot.send_inline_keyboard.keyboard_R1_2 = "Arena";
                    bot.send_inline_keyboard.keyboard_R1_2_callback_data = "CMArena";
                    bot.send_inline_keyboard.keyboard_R1_4 = "Raid";
                    bot.send_inline_keyboard.keyboard_R1_4_callback_data = "CMRaid";
                    bot.send_inline_keyboard.keyboard_R1_3 = "Power Up";
                    bot.send_inline_keyboard.keyboard_R1_3_callback_data = "CMPowerUp";
                    bot.send_inline_keyboard.keyboard_R2_1 = "Bulk Fusion";
                    bot.send_inline_keyboard.keyboard_R2_1_callback_data = "CMBulkFusion";
                    bot.send_inline_keyboard.keyboard_R2_2 = "Collect Inbox";
                    bot.send_inline_keyboard.keyboard_R2_2_callback_data = "CMCollectInbox";
                    bot.send_inline_keyboard.keyboard_R2_3 = "Change Profile";
                    bot.send_inline_keyboard.keyboard_R2_3_callback_data = "CMChangeProfile";
                    bot.send_inline_keyboard.send(bot.chat_id, "Select Mode You Want To Activate Right Now : ");
                }
                if (bot.data == "CMAdventure")
                {
                    SendCommand("CM Adventure");
                    bot.sendMessage.send(bot.chat_id, "Change Mode To Adventure");
                }
                if (bot.data == "CMArena")
                {
                    SendCommand("CM Arena");
                    bot.sendMessage.send(bot.chat_id, "Change Mode To Arena");
                }
                if (bot.data == "CMRaid")
                {
                    SendCommand("CM Raid");
                    bot.sendMessage.send(bot.chat_id, "Change Mode To Raid");
                }
                if (bot.data == "CMSmartMode")
                {
                    SendCommand("CM Smart Mode");
                    bot.sendMessage.send(bot.chat_id, "Change Mode To Smart Mode");
                }
                if (bot.data == "CMPowerUp")
                {
                    SendCommand("CM PowerUp");
                    bot.sendMessage.send(bot.chat_id, "Change Mode To Auto Power Up");
                }
                if (bot.data == "CMBulkFusion")
                {
                    SendCommand("CM BulkFusion");
                    bot.sendMessage.send(bot.chat_id, "Change Mode To Auto Bulk Fusion");
                }
                if (bot.data == "CMCollectInbox")
                {
                    SendCommand("CM Collect Inbox");
                    bot.sendMessage.send(bot.chat_id, "Change Mode To Auto Collect Inbox");
                }
                if (bot.data == "CMChangeProfile")
                {
                    SendCommand("CM Change Profile");
                    bot.sendMessage.send(bot.chat_id, "Change Mode To Change Profile");
                }
                if (bot.message_text == "ControlLDPlayer")
                {
                    bot.send_inline_keyboard.keyboard_R1_1 = "Kill LDPlayer";
                    bot.send_inline_keyboard.keyboard_R1_1_callback_data = "KillLDP";
                    bot.send_inline_keyboard.keyboard_R1_2 = "Restart LDPlayer";
                    bot.send_inline_keyboard.keyboard_R1_2_callback_data = "RestartLDP";
                    bot.send_inline_keyboard.keyboard_R1_3 = "Run LDPlayer";
                    bot.send_inline_keyboard.keyboard_R1_3_callback_data = "RunLDP";
                    bot.send_inline_keyboard.keyboard_R2_1 = "Kill 7K";
                    bot.send_inline_keyboard.keyboard_R2_1_callback_data = "Kill7K";
                    bot.send_inline_keyboard.keyboard_R2_2 = "Restart 7K";
                    bot.send_inline_keyboard.keyboard_R2_2_callback_data = "Restat7K";
                    bot.send_inline_keyboard.keyboard_R2_3 = "Run 7K";
                    bot.send_inline_keyboard.keyboard_R2_3_callback_data = "Run7K";
                    bot.send_inline_keyboard.send(bot.chat_id, "Select your choice : ");
                }
                if (bot.data == "KillLDP")
                {
                    SendCommand("KillLDP");
                    bot.sendMessage.send(bot.chat_id, "LD Player will be killed");
                }
                if (bot.data == "RestartLDP")
                {
                    SendCommand("RestartLDP");
                    bot.sendMessage.send(bot.chat_id, "LD Player will restart, and automatically run Seven Knights");
                }
                if (bot.data == "RunLDP")
                {
                    SendCommand("RunLDP");
                    bot.sendMessage.send(bot.chat_id, "LD Player started");
                }
                if (bot.data == "Kill7K")
                {
                    SendCommand("Kill7K");
                    bot.sendMessage.send(bot.chat_id, "Seven Knights will be killed");
                }
                if (bot.data == "Restat7K")
                {
                    SendCommand("Restart7K");
                    bot.sendMessage.send(bot.chat_id, "Seven Knights will restart");
                }
                if (bot.data == "Run7K")
                {
                    SendCommand("Run7K");
                    bot.sendMessage.send(bot.chat_id, "Seven Knights will running");
                }
                if (bot.message_text == "GetReport")
                {
                    CaptureReport();
                    bot.SendPhoto.Show_sending_a_photo = true;
                    bot.SendPhoto.caption = String.Format("Report {0} , {1}", DateTime.Now.ToString(), this.AI.GetMode().ToString());
                    bot.SendPhoto.send(this.AIProfiles.ST_TelegramChatID, @"report.png");
                    bot.SendPhoto.Show_sending_a_photo = true;
                    bot.SendPhoto.caption = String.Format("Last Screenshot {0}", DateTime.Now.ToString());
                    bot.SendPhoto.send(this.AIProfiles.ST_TelegramChatID, @"screen.png");
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
            //if (this.loaded && this.AISettings.AD_World == World.Sequencer)
            //{
            //    this.AD_ShowSequencerForm();
            //}
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
            this.botstatusLabel.Text = "AI Paused";
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
            this.aiButton.Text = "Start AI";
            this.statusToolStripLabel.Text = "Status: AI Stopped";
            this.botstatusLabel.Text = "AI Stopped";
            this.ST_toggleBlueStacksButton.Enabled = false;
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
                    if (progressArgs.Message.ToString() != "Idle")
                    {
                        bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "AI changing objective to: " + progressArgs.Message.ToString());
                    }
                    if (progressArgs.Message.ToString() == "Adventure")
                    {
                        groupBox8.ForeColor = Color.Black;
                    }
                    else if (progressArgs.Message.ToString() == "Arena")
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
                    timerStop();
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
                        else if (objective == Objective.RAID)
                        {
                            int num = (int)dictionary["count"];
                            this.raidCountLabel.Text = "x" + (num).ToString();
                            return;
                        }
                        int num3 = (int)dictionary["count"];
                        string text = string.Format("x" + num3);
                        string text2 = "";
                        string text3 = "";
                        string text4 = "";
                        string text5 = "";
                        if (objective == Objective.ADVENTURE)
                        {
                            text2 = "" + dictionary["h30"]; //hero30
                            text3 = "x" + dictionary["goldadv"]; //goldadv 
                            text4 = "x" + dictionary["heroadv"]; //heroadv
                            text5 = "x" + dictionary["itemadv"]; //itemadv
                        }
                        switch (objective)
                        {
                            case Objective.ADVENTURE:
                                this.adventureCountLabel.Text = text;
                                this.h30advLabel.Text = text2; //hero30
                                this.goldadvLabel.Text = text3;
                                this.heroadvLabel.Text = text4;
                                this.itemadvLabel.Text = text5;
                                return;
                            case Objective.RAID:
                                break;

                            case Objective.ARENA:
                                break;

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
                            case ResourceType.SOUL:
                                label = this.soulLabel;
                                label.Text = text2;
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
                        else if ((string)progressArgs.Message == "RestartBot")
                        {
                            if (this.started)
                            {
                                SendCommand("Stop AI");

                                bot.sendMessage.send(AIProfiles.ST_TelegramChatID, "AI Stopped");
                            }
                            else
                            {
                                bot.sendMessage.send(AIProfiles.ST_TelegramChatID, "AI Already Stopped");

                            }
                        }
                        else if ((string)progressArgs.Message == "ChangeProfile1")
                        {
                            if (this.AISettings.AD_EnableChangeProfile1)
                            {
                                bot.sendMessage.send(AIProfiles.ST_TelegramChatID, "Changing profile success.");
                                ProfileComboBoxItem profileComboBoxItem = AD_ChangeProfile1ComboBox.SelectedItem as ProfileComboBoxItem;
                                this.AIProfiles.ChangeProfile(profileComboBoxItem.Key);
                                this.ReloadTabs(true);
                            }
                        }
                        else if ((string)progressArgs.Message == "ChangeProfile2")
                        {
                            if (this.AISettings.AD_EnableChangeProfile2)
                            {
                                bot.sendMessage.send(AIProfiles.ST_TelegramChatID, "Changing profile success.");
                                ProfileComboBoxItem profileComboBoxItem = AD_ChangeProfile2ComboBox.SelectedItem as ProfileComboBoxItem;
                                this.AIProfiles.ChangeProfile(profileComboBoxItem.Key);
                                this.ReloadTabs(true);
                            }
                        }
                        else if ((string)progressArgs.Message == "ChangeProfile3")
                        {
                            if (this.AISettings.AD_EnableChangeProfile3)
                            {
                                bot.sendMessage.send(AIProfiles.ST_TelegramChatID, "Changing profile success.");
                                ProfileComboBoxItem profileComboBoxItem = AD_ChangeProfile3ComboBox.SelectedItem as ProfileComboBoxItem;
                                this.AIProfiles.ChangeProfile(profileComboBoxItem.Key);
                                this.ReloadTabs(true);
                            }
                        }
                        else if ((string)progressArgs.Message == "ARChangeProfile2")
                        {
                            if (this.AISettings.AR_EnableChangeProfile2)
                            {
                                bot.sendMessage.send(AIProfiles.ST_TelegramChatID, "Changing profile success.");
                                ProfileComboBoxItem profileComboBoxItem = AR_ChangeProfile2ComboBox.SelectedItem as ProfileComboBoxItem;
                                this.AIProfiles.ChangeProfile(profileComboBoxItem.Key);
                                this.ReloadTabs(true);
                            }
                        }
                        else if ((string)progressArgs.Message == "ARChangeProfile1")
                        {
                            if (this.AISettings.AR_EnableChangeProfile1)
                            {
                                bot.sendMessage.send(AIProfiles.ST_TelegramChatID, "Changing profile success.");
                                ProfileComboBoxItem profileComboBoxItem = AR_ChangeProfile1ComboBox.SelectedItem as ProfileComboBoxItem;
                                this.AIProfiles.ChangeProfile(profileComboBoxItem.Key);
                                this.ReloadTabs(true);
                            }
                        }
                        else if ((string)progressArgs.Message == "RDChangeProfile1")
                        {
                            if (this.AISettings.RD_EnableChangeProfile1)
                            {
                                bot.sendMessage.send(AIProfiles.ST_TelegramChatID, "Changing profile success.");
                                ProfileComboBoxItem profileComboBoxItem = RD_ChangeProfile1ComboBox.SelectedItem as ProfileComboBoxItem;
                                this.AIProfiles.ChangeProfile(profileComboBoxItem.Key);
                                this.ReloadTabs(true);
                            }
                        }
                        else if ((string)progressArgs.Message == "SDChangeProfile1")
                        {
                            if (this.AISettings.SD_EnableChangeProfile1)
                            {
                                bot.sendMessage.send(AIProfiles.ST_TelegramChatID, "Changing profile success.");
                                ProfileComboBoxItem profileComboBoxItem = SD_ChangeProfile1ComboBox.SelectedItem as ProfileComboBoxItem;
                                this.AIProfiles.ChangeProfile(profileComboBoxItem.Key);
                                this.ReloadTabs(true);
                            }
                        }
                        else if ((string)progressArgs.Message == "Bot Error2")
                        {
                            cb.Screenshot();
                            Thread.Sleep(2000);
                            bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "AI Stuck, bot will restart seven knights. You still need to ResumeAI");
                            bot.SendPhoto.Show_sending_a_photo = true;
                            bot.SendPhoto.caption = String.Format("Last Screenshot {0}", DateTime.Now.ToString());
                            bot.SendPhoto.send(this.AIProfiles.ST_TelegramChatID, @"C://screen.png");
                            this.PauseAI();
                            Thread.Sleep(5000);
                            Restart7k();
                            Thread.Sleep(8000);
                            this.ResumeAI(); // resume
                        }
                        else if ((string)progressArgs.Message == "Bot Error")
                        {
                            bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "AI Stuck, bot automatically paused");
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
                            bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "AI Paused because no more hero to replace");
                            this.PauseAI();
                            this.AlertSound.PlayLooping();
                            Thread.Sleep(5000);
                            this.AlertSound.Stop();
                        }
                        else if ((string)progressArgs.Message == "BoostLimit")
                        {
                            bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "Boost Already reach limit");
                        }
                        else if ((string)progressArgs.Message == "Max Level Up")
                        {
                            bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "AI Paused because Hero Max Level Up 100/100");
                            this.PauseAI();
                            this.AlertSound.PlayLooping();
                            Thread.Sleep(1500);
                            this.AlertSound.Stop();
                        }
                        else if ((string)progressArgs.Message == "Internet Down")
                        {
                            bot.sendMessage.send(this.AIProfiles.ST_TelegramChatID, "AI Paused because your internet connection is down");
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
            this.AD_enableCheckBox.Checked = this.AISettings.AD_Enable;
            this.AD_EnHottime_Checkbox.Checked = this.AISettings.AD_HottimeEnable;
            this.AD_limitCheckBox.Checked = this.AISettings.AD_EnableLimit;
            this.AD_limitNumericBox.Value = this.AISettings.AD_Limit;
            this.AD_worldComboBox.SelectedIndex = (int)this.AISettings.AD_World;
            this.AD_stageComboBox.SelectedIndex = this.AISettings.AD_Stage;
            this.AD_difficultyComboBox.SelectedValue = this.AISettings.AD_Difficulty;
            this.AD_difficultyComboBox2nd.SelectedValue = this.AISettings.AD_Difficulty2nd;
            this.AD_teamComboBox.SelectedIndex = (int)this.AISettings.AD_Team;
            this.AD_teamComboBox2.SelectedIndex = (int)this.AISettings.AD2_Team;
            this.AD_continuousCheckBox.Checked = this.AISettings.AD_Continuous;
            this.AD_StopOnFullHeroes_Checkbox.Checked = this.AISettings.AD_StopOnFullHeroes;
            this.AD_StopOnFullItems_Checkbox.Checked = this.AISettings.AD_StopOnFullItems;
            this.AD_UseFriendCheckBox.Checked = this.AISettings.AD_UseFriend;
            this.AD_bootmodeCheckBox.Checked = this.AISettings.AD_BootMode;
            if (this.AISettings.AD_BootMode == true)
            {
                this.AD_BoostModeAllMapsRadio.Enabled = true;
                this.AD_BoostModeAsgarRadio.Enabled = true;
                this.AD_BoostModeSequenceRadio.Enabled = true;
            }
            else
            {
                this.AD_BoostModeSequenceRadio.Enabled = false;
                this.AD_BoostModeAllMapsRadio.Enabled = false;
                this.AD_BoostModeAsgarRadio.Enabled = false;
            }
            this.AD_BoostModeAsgarRadio.Checked = this.AISettings.AD_BoostAsgar;
            this.AD_BoostModeAllMapsRadio.Checked = this.AISettings.AD_BoostAllMap;
            this.AD_BoostModeSequenceRadio.Checked = this.AISettings.AD_BoostModeSequence;
            this.AD_EnableProfile1CheckBox.Checked = this.AISettings.AD_EnableProfile1;
            this.AD_EnableProfile2CheckBox.Checked = this.AISettings.AD_EnableProfile2;
            this.AD_EnableProfile3CheckBox.Checked = this.AISettings.AD_EnableProfile3;
            this.AD_NoChangeModeCheckBox.Checked = this.AISettings.AD_NoChangeMode;
            this.ST_EnableTelegramMsg1CheckBox.Checked = this.AIProfiles.ST_EnableTelegramMsg1;
            this.AD_FarmOrderComboBox.SelectedIndex = this.AISettings.AD_FarmOrder;
            /*Change Profile*/
            this.AD_ChangeProfile1CheckBox.Checked = this.AISettings.AD_EnableChangeProfile1;
            this.AD_ChangeProfile2CheckBox.Checked = this.AISettings.AD_EnableChangeProfile2;
            this.AD_ChangeProfile3CheckBox.Checked = this.AISettings.AD_EnableChangeProfile3;
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
            this.AR_EnableChangeProfile1CheckBox.Checked = this.AISettings.AR_EnableChangeProfile1;
            this.AR_EnableChangeProfile2CheckBox.Checked = this.AISettings.AR_EnableChangeProfile2;
        }

        private void InitGlobalProfile()
        {
            this.GB_WaitForKeys.Checked = this.AISettings.GB_WaitForKeys;
        }

        private void InitLogsTab()
        { }

        private void InitRaidTab()
        {
            this.RD_EnableCheckBox.Checked = this.AISettings.RD_Enable;
            this.RD_EnableLimitCheckBox.Checked = this.AISettings.RD_EnableLimit;
            this.RD_LimitNumericBox.Value = this.AISettings.RD_Limit;
            this.RD_FightExtraRaidCheckBox.Checked = this.AISettings.RD_FightExtraRaid;
            this.RD_AccRaidRadio.Checked = this.AISettings.RD_FightAccRaid;
            this.RD_RaidItemRadio.Checked = this.AISettings.RD_FightItemRaid;
            this.RD_JewelRaidRadio.Checked = this.AISettings.RD_FightJewelRaid;
            this.RD_CollectMileageCheckBox.Checked = this.AISettings.RD_EnableCollectMileage;
            this.RD_SellItemCheckBox.Checked = this.AISettings.RD_EnableSellItem;
            this.RD_SellItemRankComboBox.SelectedIndex = this.AISettings.RD_SellItemRank;
            this.RD_SellAccRankComboBox.SelectedIndex = this.AISettings.RD_SellAccRank;
            this.RD_SellJewelRankComboBox.SelectedIndex = this.AISettings.RD_SellJewelRank;
            this.RD_StopNoKeyCheckBox.Checked = this.AISettings.RD_StopOutKey;
            this.RD_ChangeProfile1CheckBox.Checked = this.AISettings.RD_EnableChangeProfile1;
        }

        private void InitSiegeDefenseTab()
        {
            this.SD_EnableCheckBox.Checked = this.AISettings.SD_Enable;
            this.SD_EnableLimitCheckBox.Checked = this.AISettings.SD_EnableLimit;
            this.SD_LimitNumericBox.Value = this.AISettings.SD_Limit;
            this.SD_ChangeProfile1CheckBox.Checked = this.AISettings.SD_EnableChangeProfile1;
        }

        private void InitResourcesTab()
        {
            /*PowerUp Tab*/
            this.PU_enableActive1CheckBox.Checked = this.AISettings.PU_enableActive1;
            this.PU_enableActive2CheckBox.Checked = this.AISettings.PU_enableActive2;
            this.PU_enableActive3CheckBox.Checked = this.AISettings.PU_enableActive3;
            this.PU_enableCheckbox.Checked = this.AISettings.PU_Enable;
            this.PU_1MOnlyLv30CheckBox.Checked = this.AISettings.PU_1MOnlyLv30;
            this.PU_2MOnlyLv30CheckBox.Checked = this.AISettings.PU_2MOnlyLv30;
            this.PU_3MOnlyLv30CheckBox.Checked = this.AISettings.PU_3MOnlyLv30;
            this.PU_4MOnlyLv30CheckBox.Checked = this.AISettings.PU_4MOnlyLv30;
            this.PU_1StarCheckBox.Checked = this.AISettings.PU_1Star;
            this.PU_2StarCheckBox.Checked = this.AISettings.PU_2Star;
            this.PU_3StarCheckBox.Checked = this.AISettings.PU_3Star;
            this.PU_4StarCheckBox.Checked = this.AISettings.PU_4Star;
            this.PU_1MaterialComboBox.SelectedIndex = this.AISettings.PU_1Material - 1;
            this.PU_2MaterialComboBox.SelectedIndex = this.AISettings.PU_2Material - 1;
            this.PU_3MaterialComboBox.SelectedIndex = this.AISettings.PU_3Material - 1;
            this.PU_4MaterialComboBox.SelectedIndex = this.AISettings.PU_4Material - 1;
            this.PU_Active1NumericBox.Value = this.AISettings.PU_Active1;
            this.PU_1ConditionComboBox.SelectedIndex = this.AISettings.PU_1Condition;
            this.PU_2ConditionComboBox.SelectedIndex = this.AISettings.PU_2Condition;
            this.PU_3ConditionComboBox.SelectedIndex = this.AISettings.PU_3Condition;
            this.PU_1OrderComboBox.SelectedIndex = this.AISettings.PU_1Order;
            this.PU_2OrderComboBox.SelectedIndex = this.AISettings.PU_2Order;
            this.PU_3OrderComboBox.SelectedIndex = this.AISettings.PU_3Order;
            this.button5.Visible = false;
            this.button6.Visible = false;
            /*Bulk Fusion Tab*/
            this.BF_EnableActivate1CheckBox.Checked = this.AISettings.BF_EnableActivate1;
            this.BF_EnableActivate2CheckBox.Checked = this.AISettings.BF_EnableActivate2;
            this.BF_EnableCheckBox.Checked = this.AISettings.BF_Enable;
            this.BF_OnlyLv30CheckBox.Checked = this.AISettings.BF_OnlyLv30;
            this.BF_Active2NumericBox.Value = this.AISettings.BF_Active2;
            this.BF_StopMileageCheckBox.Checked = this.AISettings.BF_StopMileage;

            this.RS_CollectInboxCheckBox.Checked = this.AISettings.RS_CollectInbox;
            this.RS_CollectInboxActiveNumericBox.Value = this.AISettings.RS_CollectInboxActive;
            this.RS_EnableCINoRubyCheckBox.Checked = this.AISettings.RS_EnableCINoRuby;
            this.RS_EnableCollectInboxCheckBox.Checked = this.AISettings.RS_EnableCI;
            this.RS_CIOnlyHonorCheckBox.Checked = this.AISettings.RS_CIOnlyHonor;
            this.RS_CIOnlyKeysCheckBox.Checked = this.AISettings.RS_CIOnlyKey;
            this.RS_CIOnlyCurrencyCheckBox.Checked = this.AISettings.RS_CIOnlyCurrency;
            this.RS_CIOnlyTicketsCheckBox.Checked = this.AISettings.RS_CIOnlyTicket;
        }

        private void InitSettingsTab()
        {
            this.ST_RefreshProfiles();
            this.ST_RefreshAD1CProfiles();
            this.ST_RefreshAD2CProfiles();
            this.ST_RefreshAD3CProfiles();
            this.ST_RefreshAR1CProfiles();
            this.ST_RefreshAR2CProfiles();
            this.ST_RefreshSD1CProfiles();
            this.ST_RefreshRD1CProfiles();
            this.ST_delayTrackBar.Value = this.AIProfiles.ST_Delay;
            this.ST_reconnectInterruptCheckBox.Checked = this.AIProfiles.ST_ReconnectInterruptEnable;
            this.ST_reconnectNumericUpDown.Value = this.AIProfiles.ST_ReconnectInterruptInterval;
            this.ST_TelegramEnableCheckBox.Checked = this.AIProfiles.ST_EnableTelegram;
            this.ST_TelegramTokenTextBox.Text = this.AIProfiles.ST_TelegramToken;
            this.ST_TelegramChatIDTextBox.Text = this.AIProfiles.ST_TelegramChatID;
            this.LDTitleTextBox.Text = this.AIProfiles.ST_LDTitle;
            this.ST_foregroundMode.Checked = this.AIProfiles.ST_ForegroundMode;
            this.ST_forceActiveCheckBox.Checked = this.AIProfiles.ST_BlueStacksForceActive;
        }

        private void InitOtherTab()
        {
            this.AD_NoHeroUp_Checkbox.Checked = this.AIProfiles.AD_NoHeroUp;
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

                case 3:
                    this.AISettings.RD_Limit = num2;
                    return;

                case 4:
                    this.AISettings.SD_Limit = num2;
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
            timerReset();
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
            string build = "v" + this.ProductVersion + " - " + Assembly.GetExecutingAssembly().GetLinkerTime().ToLocalTime();
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
                this.aiButton.Text = "&Resume AI";
                this.EnablePause(false);
                timerStop();
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
            this.InitRaidTab();
            this.InitSiegeDefenseTab();
            if (refreshSettings)
            {
                this.InitSettingsTab();
            }
            this.groupBox2.Text = this.ST_currentProfileComboBox.Text;

        }

        private void ReloadChangeProfile()
        {

        }

        private void ResumeAI()
        {
            this.AIProfiles.TMP_Paused = false;
            this.AIProfiles.TMP_WaitingForKeys = false;
            this.tsslCursorPosition.Text = "";
            this.aiButton.Text = "Stop AI";
            this.botstatusLabel.Text = "AI Running";
            this.botstatusLabel.ForeColor = Color.Green;

            this.tabControl1.SelectedTab = tabPage4;
            this.EnablePause(true);
            timerStart();

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

        private void RS_sellAllRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            short num = Convert.ToInt16(radioButton.Tag);
            bool @checked = radioButton.Checked;
            if (num == 0)
            {
                //untNumericBox.Enabled = !@checked;
                this.AISettings.RS_SellHeroAll = @checked;
                return;
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
            short num = Convert.ToInt16(comboBox.Tag);
            if (num == 1)
            {
                ST_currentProfile2ComboBox.SelectedItem = comboBox.SelectedItem;
            }
            else if (num == 2)
            {
                ST_currentProfileComboBox.SelectedItem = comboBox.SelectedItem;
            }
            ProfileComboBoxItem profileComboBoxItem = comboBox.SelectedItem as ProfileComboBoxItem;
            this.AIProfiles.ChangeProfile(profileComboBoxItem.Key);
            this.ReloadTabs(false);
            this.ST_RefreshAD1CProfiles();
            this.ST_RefreshAD2CProfiles();
            this.ST_RefreshAD3CProfiles();
            this.ST_RefreshAR1CProfiles();
            this.ST_RefreshAR2CProfiles();
            this.ST_RefreshRD1CProfiles();
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

        }

        private void ST_foregroundMode_CheckedChanged(object sender, EventArgs e)
        {

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
                //ST_TelegramChatIDTextBox.Text = "";
                //ST_TelegramTokenTextBox.Text = "";
            }
            else
            {
                //ST_TelegramChatIDTextBox.Text = "";
                //ST_TelegramTokenTextBox.Text = "";
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
            this.ST_currentProfile2ComboBox.Items.Clear();
            foreach (KeyValuePair<string, AISettings> current in this.AIProfiles.Settings)
            {
                ProfileComboBoxItem item = new ProfileComboBoxItem(current);
                this.ST_currentProfileComboBox.Items.Add(item);
                this.ST_currentProfile2ComboBox.Items.Add(item);
                if (current.Key == this.AIProfiles.CurrentKey)
                {
                    this.ST_currentProfileComboBox.SelectedIndex = num;
                    this.ST_currentProfile2ComboBox.SelectedIndex = num;
                }
                num++;
            }
            this.groupBox2.Text = this.ST_currentProfileComboBox.Text;
        }

        private void ST_RefreshAD1CProfiles()
        {
            int num = 0;
            this.AD_ChangeProfile1ComboBox.Items.Clear();
            foreach (KeyValuePair<string, AISettings> current in this.AIProfiles.Settings)
            {
                ProfileComboBoxItem item = new ProfileComboBoxItem(current);
                this.AD_ChangeProfile1ComboBox.Items.Add(item);
                if (current.Key == this.AISettings.AD_Profile1)
                {
                    this.AD_ChangeProfile1ComboBox.SelectedIndex = num;
                }
                num++;
            }
        }

        private void ST_RefreshAD2CProfiles()
        {
            int num = 0;
            this.AD_ChangeProfile2ComboBox.Items.Clear();
            foreach (KeyValuePair<string, AISettings> current in this.AIProfiles.Settings)
            {
                ProfileComboBoxItem item = new ProfileComboBoxItem(current);
                this.AD_ChangeProfile2ComboBox.Items.Add(item);
                if (current.Key == this.AISettings.AD_Profile2)
                {
                    this.AD_ChangeProfile2ComboBox.SelectedIndex = num;
                }
                num++;
            }
        }

        private void ST_RefreshAD3CProfiles()
        {
            int num = 0;
            this.AD_ChangeProfile3ComboBox.Items.Clear();
            foreach (KeyValuePair<string, AISettings> current in this.AIProfiles.Settings)
            {
                ProfileComboBoxItem item = new ProfileComboBoxItem(current);
                this.AD_ChangeProfile3ComboBox.Items.Add(item);
                if (current.Key == this.AISettings.AD_Profile3)
                {
                    this.AD_ChangeProfile3ComboBox.SelectedIndex = num;
                }
                num++;
            }
        }

        private void ST_RefreshAR1CProfiles()
        {
            int num = 0;
            this.AR_ChangeProfile1ComboBox.Items.Clear();
            foreach (KeyValuePair<string, AISettings> current in this.AIProfiles.Settings)
            {
                ProfileComboBoxItem item = new ProfileComboBoxItem(current);
                this.AR_ChangeProfile1ComboBox.Items.Add(item);
                if (current.Key == this.AISettings.AR_Profile1)
                {
                    this.AR_ChangeProfile1ComboBox.SelectedIndex = num;
                }
                num++;
            }
        }

        private void ST_RefreshAR2CProfiles()
        {
            int num = 0;
            this.AR_ChangeProfile2ComboBox.Items.Clear();
            foreach (KeyValuePair<string, AISettings> current in this.AIProfiles.Settings)
            {
                ProfileComboBoxItem item = new ProfileComboBoxItem(current);
                this.AR_ChangeProfile2ComboBox.Items.Add(item);
                if (current.Key == this.AISettings.AR_Profile2)
                {
                    this.AR_ChangeProfile2ComboBox.SelectedIndex = num;
                }
                num++;
            }
        }

        private void ST_RefreshRD1CProfiles()
        {
            int num = 0;
            this.RD_ChangeProfile1ComboBox.Items.Clear();
            foreach (KeyValuePair<string, AISettings> current in this.AIProfiles.Settings)
            {
                ProfileComboBoxItem item = new ProfileComboBoxItem(current);
                this.RD_ChangeProfile1ComboBox.Items.Add(item);
                if (current.Key == this.AISettings.RD_Profile1)
                {
                    this.RD_ChangeProfile1ComboBox.SelectedIndex = num;
                }
                num++;
            }
        }

        private void ST_RefreshSD1CProfiles()
        {
            int num = 0;
            this.SD_ChangeProfile1ComboBox.Items.Clear();
            foreach (KeyValuePair<string, AISettings> current in this.AIProfiles.Settings)
            {
                ProfileComboBoxItem item = new ProfileComboBoxItem(current);
                this.SD_ChangeProfile1ComboBox.Items.Add(item);
                if (current.Key == this.AISettings.SD_Profile1)
                {
                    this.SD_ChangeProfile1ComboBox.SelectedIndex = num;
                }
                num++;
            }
        }

        private void StartAI()
        {
            this.Worker = this.AI.Start(this.SynchronizationContext);
            this.Worker.ProgressChanged += new ProgressChangedEventHandler(this.BackgroundWorkerOnProgressChanged);
            this.Worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.BackgroundWorkerOnCompleted);
            this.started = true;
            this.CheckSameLimit();
            this.aiButton.Text = "Stop AI";
            this.botstatusLabel.Text = "AI Running";
            this.botstatusLabel.ForeColor = Color.Green;
            this.ST_toggleBlueStacksButton.Enabled = true;
            this.tabControl1.SelectedTab = tabPage4;
            this.EnablePause(true);
            this.button2.Enabled = true;
            timerReset();
            timerStart();
            this.ST_TelegramTokenTextBox.Enabled = false;
            this.LDTitleTextBox.Enabled = false;
        }

        private void CheckSameLimit()
        {
            if (this.AISettings.PU_Enable && this.AISettings.PU_enableActive1)
            {
                if (this.AISettings.BF_Enable && this.AISettings.BF_EnableActivate2)
                {
                    if (this.AISettings.PU_Active1 == this.AISettings.BF_Active2)
                    {
                        MessageBox.Show("Adventure Limit in Auto Power Up and Auto Bulk Fusion can't have same value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (this.AISettings.AD_CheckSlot && this.AISettings.CS_EnableActive1)
                {
                    if (this.AISettings.PU_Active1 == this.AISettings.CS_Enable1)
                    {
                        MessageBox.Show("Adventure Limit in Auto Power Up and Check Slot can't have same value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (this.AISettings.RS_CollectInbox)
                {
                    if (this.AISettings.PU_Active1 == this.AISettings.RS_CollectInboxActive)
                    {
                        MessageBox.Show("Adventure Limit in Auto Power Up and Collect Inbox can't have same value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (this.AISettings.BF_Enable && this.AISettings.BF_EnableActivate2)
            {
                if (this.AISettings.AD_CheckSlot && this.AISettings.CS_EnableActive1)
                {
                    if (this.AISettings.BF_Active2 == this.AISettings.CS_Enable1)
                    {
                        MessageBox.Show("Adventure Limit in Auto Bulk Fusion and Check Slot can't have same value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (this.AISettings.RS_CollectInbox)
                {
                    if (this.AISettings.BF_Active2 == this.AISettings.RS_CollectInboxActive)
                    {
                        MessageBox.Show("Adventure Limit in Auto Bulk Fusion and Collect Inbox can't have same value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (this.AISettings.CS_EnableActive1 && this.AISettings.AD_CheckSlot)
            {
                if (this.AISettings.RS_CollectInbox)
                {
                    if (this.AISettings.CS_Enable1 == this.AISettings.RS_CollectInboxActive)
                    {
                        MessageBox.Show("Adventure Limit in Check Slot and Collect Inbox can't have same value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
            this.ST_TelegramTokenTextBox.Enabled = true;
            this.LDTitleTextBox.Enabled = true;
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
            timerReset();
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
            if (checkBox.Checked == true)
            {
                this.AD_BoostModeAllMapsRadio.Enabled = true;
                this.AD_BoostModeAsgarRadio.Enabled = true;
                this.AD_BoostModeSequenceRadio.Enabled = true;
            }
            else
            {
                this.AD_BoostModeSequenceRadio.Enabled = false;
                this.AD_BoostModeAllMapsRadio.Enabled = false;
                this.AD_BoostModeAsgarRadio.Enabled = false;
            }
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
            if (e.Error != null)
            {
                AppendLog(e.Error.ToString());
            }
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
                        if ((string)progressArgsT.Message == "Start AI")
                        {
                            this.aiButton.PerformClick();
                        }
                        else if ((string)progressArgsT.Message == "Stop AI")
                        {
                            this.aiButton.PerformClick();
                        }
                        else if ((string)progressArgsT.Message == "Pause AI")
                        {
                            this.aiPause.PerformClick();
                        }
                        else if ((string)progressArgsT.Message == "Resume AI")
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
                        else if ((string)progressArgsT.Message == "Enable PowerUp")
                        {
                            this.AISettings.PU_Enable = true;
                        }
                        else if ((string)progressArgsT.Message == "Enable Raid")
                        {
                            this.AISettings.RD_Enable = true;
                        }
                        else if ((string)progressArgsT.Message == "Enable BulkFusion")
                        {
                            this.AISettings.BF_Enable = true;
                        }
                        else if ((string)progressArgsT.Message == "Enable Collect Inbox")
                        {
                            this.AISettings.RS_EnableCI = true;
                        }
                        else if ((string)progressArgsT.Message == "Disable Adventure")
                        {
                            AI.DisableMode(Objective.ADVENTURE);
                        }
                        else if ((string)progressArgsT.Message == "Disable Raid")
                        {
                            AI.DisableMode(Objective.RAID);
                        }
                        else if ((string)progressArgsT.Message == "Disable Arena")
                        {
                            AI.DisableMode(Objective.ARENA);
                        }
                        else if ((string)progressArgsT.Message == "CM Adventure")
                        {
                            if (AISettings.AD_Enable)
                            {
                                this.AI.ChangeMode(Objective.ADVENTURE, false);
                            }
                        }
                        else if ((string)progressArgsT.Message == "CM Arena")
                        {
                            if (AISettings.AR_Enable)
                            {
                                this.AI.ChangeMode(Objective.ARENA, false);
                            }
                        }
                        else if ((string)progressArgsT.Message == "CM Raid")
                        {
                            if (AISettings.RD_Enable)
                            {
                                this.AI.ChangeMode(Objective.RAID, false);
                            }
                        }
                        else if ((string)progressArgsT.Message == "CM PowerUp")
                        {
                            if (AISettings.PU_Enable)
                            {
                                this.AI.ChangeMode(Objective.POWER_UP_HEROES, false);
                            }
                        }
                        else if ((string)progressArgsT.Message == "CM BulkFusion")
                        {
                            if (AISettings.BF_Enable)
                            {
                                this.AI.ChangeMode(Objective.FUSE_HEROES, false);
                            }
                        }
                        else if ((string)progressArgsT.Message == "CM Collect Inbox")
                        {
                            if (AISettings.RS_EnableCI)
                            {
                                this.AI.ChangeMode(Objective.COLLECT_INBOX, false);
                            }
                        }
                        else if ((string)progressArgsT.Message == "CM Change Profile")
                        {
                            this.AI.ChangeMode(Objective.CHANGE_PROFILE, true);
                        }
                        else if ((string)progressArgsT.Message == "RestartLDP")
                        {
                            cb.RestartLDPlayer();
                            Thread.Sleep(12000);
                            cb.RunApp();
                        }
                        else if ((string)progressArgsT.Message == "RunLDP")
                        {
                            cb.RunLDPlayer();
                        }
                        else if ((string)progressArgsT.Message == "KillLDP")
                        {
                            cb.Kill();
                        }
                        else if ((string)progressArgsT.Message == "Kill7K")
                        {
                            cb.KillAppWithADB();
                        }
                        else if ((string)progressArgsT.Message == "Restart7K")
                        {
                            cb.RestartGame();
                        }
                        else if ((string)progressArgsT.Message == "Run7K")
                        {
                            cb.RunApp();
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

        private void button4_Click_2(object sender, EventArgs e)
        {
            this.AppendLog(this.AI.BlueStacks.ValidateResolution());
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AISettings.RS_SellGoldOre = @checked;
        }

        private void ST_forceActiveCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.AIProfiles.ST_BlueStacksForceActive = @checked;
        }
        private void ST_ToggleBlueStacks(bool force = false, bool show = true)
        {
            if (this.AI.BlueStacks == null || this.AI.BlueStacks.MainWindowAS == null)
            {
                return;
            }
            string arg;
            if (this.AI.BlueStacks.IsHidden || (force && show))
            {
                this.AI.BlueStacks.Show(true);
                arg = "Hide";
            }
            else
            {
                this.AI.BlueStacks.Hide(true);
                arg = "Show";
            }
            this.ST_toggleBlueStacksButton.Text = string.Format("{0} LD Player", arg);
        }
        private void ST_toggleBlueStacksButton_Click(object sender, EventArgs e)
        {
            this.ST_ToggleBlueStacks(false, true);
        }

        private void ST_foregroundMode_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.ST_ToggleBlueStacks(true, true);
            this.AIProfiles.ST_ForegroundMode = @checked;
        }

        private void groupBox7_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox16_Enter(object sender, EventArgs e)
        {

        }

        private void PU_enableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_Enable = checkBox.Checked;
        }

        private void PU_enableActive1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_enableActive1 = checkBox.Checked;
        }

        private void PU_enableActive2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_enableActive2 = checkBox.Checked;
        }

        private void PU_1StarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_1Star = checkBox.Checked;
        }

        private void PU_2StarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_2Star = checkBox.Checked;
        }

        private void PU_3StarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_3Star = checkBox.Checked;
        }

        private void PU_4StarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_4Star = checkBox.Checked;
        }

        private void PU_1OnlyLv30CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_1OnlyLv30 = checkBox.Checked;
        }

        private void PU_2OnlyLv30CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_2OnlyLv30 = checkBox.Checked;
        }

        private void PU_3OnlyLv30CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_3OnlyLv30 = checkBox.Checked;
        }

        private void PU_4OnlyLv30CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_4OnlyLv30 = checkBox.Checked;
        }

        private void PU_1MOnlyLv30CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_1MOnlyLv30 = checkBox.Checked;
        }

        private void PU_2MOnlyLv30CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_2MOnlyLv30 = checkBox.Checked;
        }

        private void PU_3MOnlyLv30CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_3MOnlyLv30 = checkBox.Checked;
        }

        private void PU_4MOnlyLv30CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_4MOnlyLv30 = checkBox.Checked;
        }

        private void PU_Active1NumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int puactive1 = Convert.ToInt32(numericUpDown.Value);
            this.AISettings.PU_Active1 = puactive1;
        }

        private void PU_1MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int num2 = comboBox.SelectedIndex + 1;
            this.AISettings.PU_1Material = num2;
        }

        private void PU_2MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            int num2 = comboBox.SelectedIndex + 1;
            this.AISettings.PU_2Material = num2;
        }

        private void PU_3MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            int num2 = comboBox.SelectedIndex + 1;
            this.AISettings.PU_3Material = num2;
        }

        private void PU_4MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            int num2 = comboBox.SelectedIndex + 1;
            this.AISettings.PU_4Material = num2;
        }

        private void BF_rankComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            int num2 = comboBox.SelectedIndex + 1;
            this.AISettings.BF_Rank = num2;
        }

        private void BF_EnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.BF_Enable = checkBox.Checked;
        }

        private void BF_Activate1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.BF_EnableActivate1 = checkBox.Checked;
        }

        private void BF_Activate2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.BF_EnableActivate2 = checkBox.Checked;
        }

        private void BF_OnlyLv30CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.BF_OnlyLv30 = checkBox.Checked;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) //BF_Activate1
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int aR_UseRubyAmount = Convert.ToInt32(numericUpDown.Value);
            this.AISettings.BF_Active2 = aR_UseRubyAmount;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AI.ChangeMode(Objective.POWER_UP_HEROES, false);
            //AI.ChangeMode(Objective.COLLECT_INBOX);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AI.ChangeMode(Objective.FUSE_HEROES, false);
        }

        private void groupBox23_Enter(object sender, EventArgs e)
        {

        }

        private void PU_enableActive3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.PU_enableActive3 = checkBox.Checked;
        }

        private void CS_Enable1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.CS_EnableActive1 = checkBox.Checked;
        }

        private void CS_Enable1NumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int CS_Enable1 = Convert.ToInt32(numericUpDown.Value);
            this.AISettings.CS_Enable1 = CS_Enable1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            aiButton.Enabled = false;
            if (cb.RestartADB())
            {
                aiButton.Enabled = true;
                MessageBox.Show("Reset ADB Success", "Reset ADB", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                aiButton.Enabled = true;
                MessageBox.Show("Reset ADB Failed, make sure your LD Player is running before Resetting ADB", "Reset ADB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string text = textBox.Text;
            this.AIProfiles.ST_LDTitle = text;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            AI.ChangeMode(Objective.AUTO_SELL);
        }

        private void PU_1ConditionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedIndex == 1 && this.AISettings.PU_1Material == 1)
            {
                MessageBox.Show("You can't choose Less Equal Condition if Materials is 1 star", "Auto Power Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox.SelectedIndex = 0;
            }
            else
            {
                this.AISettings.PU_1Condition = comboBox.SelectedIndex;
            }
        }

        private void PU_2ConditionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedIndex == 1 && this.AISettings.PU_2Material == 1)
            {
                MessageBox.Show("You can't choose Less Equal Condition if Materials is 1 star", "Auto Power Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox.SelectedIndex = 0;
            }
            else
            {
                this.AISettings.PU_2Condition = comboBox.SelectedIndex;
            }
        }

        private void PU_3ConditionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedIndex == 1 && this.AISettings.PU_3Material == 1)
            {
                MessageBox.Show("You can't choose Less Equal Condition if Materials is 1 star", "Auto Power Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox.SelectedIndex = 0;
            }
            else
            {
                this.AISettings.PU_3Condition = comboBox.SelectedIndex;
            }
        }

        private void RS_CollectInboxActiveNumericBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int CollectInboxActive = Convert.ToInt32(numericUpDown.Value);
            this.AISettings.RS_CollectInboxActive = CollectInboxActive;
        }

        private void RS_CollectInboxCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RS_CollectInbox = checkBox.Checked;
        }

        private void AD_BoostModeSequenceRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Radio = sender as RadioButton;
            this.AISettings.AD_BoostModeSequence = Radio.Checked;
        }

        private void RD_Boss_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            short num = Convert.ToInt16(radioButton.Tag);
            bool @checked = radioButton.Checked;
            if (num == 0)
            {
                this.AISettings.RD_FightItemRaid = true;
                this.AISettings.RD_FightJewelRaid = false;
                this.AISettings.RD_FightAccRaid = false;
            }
            else if (num == 1)
            {
                this.AISettings.RD_FightItemRaid = false;
                this.AISettings.RD_FightJewelRaid = true;
                this.AISettings.RD_FightAccRaid = false;
            }
            else if (num == 2)
            {
                this.AISettings.RD_FightItemRaid = false;
                this.AISettings.RD_FightJewelRaid = false;
                this.AISettings.RD_FightAccRaid = true;
            }
        }

        private void PU_1OrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int num2 = comboBox.SelectedIndex;
            this.AISettings.PU_1Order = num2;
        }

        private void PU_2OrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int num2 = comboBox.SelectedIndex;
            this.AISettings.PU_2Order = num2;
        }

        private void PU_3OrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int num2 = comboBox.SelectedIndex;
            this.AISettings.PU_3Order = num2;
        }

        private void ST_delayTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void RS_EnableCINoRubyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RS_EnableCINoRuby = checkBox.Checked;
        }

        private void RS_EnableCollectInboxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RS_EnableCI = checkBox.Checked;
        }

        private void RS_CIOnlyHonorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RS_CIOnlyHonor = checkBox.Checked;
        }

        private void RS_CIOnlyKeysCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RS_CIOnlyKey = checkBox.Checked;
        }

        private void RS_CIOnlyCurrencyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RS_CIOnlyCurrency = checkBox.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ms = ms + 1; //Add 1 millisecond to previous millisecond value. 
            if (ms == 9) //If Miliiseconds = 9
            {
                ms = 0; //Set milliseconds back to 0
                s = s + 1; //Add 1 second to previous second value
                if (s >= 10)
                {
                    timerSecond.Text = s.ToString(); //Change 'Second' label text to the new seconds value
                }
                else
                {
                    timerSecond.Text = "0" + s.ToString(); //Change 'Second' label text to the new seconds value
                }
                if (s == 59) //If seconds = 59
                {
                    s = 0; //Set seconds back to 0
                    m = m + 1; //Add 1 minute to previous minute value
                    if (m >= 10)
                    {
                        timerMinute.Text = m.ToString(); //Change 'Minute' label text to the new minute value
                    }
                    else
                    {
                        timerMinute.Text = "0" + m.ToString(); //Change 'Minute' label text to the new minute value
                    }
                    if (m == 59) //If minutes = 59
                    {
                        m = 0; //Set miniutes back to 0
                        h = h + 1; //Add 1 hour to previous hour value
                        if (h >= 10)
                        {
                            timerHour.Text = h.ToString(); //Change 'Hour' label text to the new hour value
                        }
                        else
                        {
                            timerHour.Text = "0" + h.ToString(); //Change 'Hour' label text to the new hour value
                        }
                    }
                }
            }
        }

        private void timerStart()
        {
            timer1.Start();
        }

        private void timerStop()
        {
            timer1.Stop();
        }

        private void timerReset()
        {
            timer1.Enabled = false;
            ms = 0;
            h = 0;
            s = 0;
            m = 0;
            timerSecond.Text = "00";
            timerMinute.Text = "00";
            timerHour.Text = "00";
        }

        private void splitterStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void AD_Profile1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProfileComboBoxItem profileComboBoxItem = comboBox.SelectedItem as ProfileComboBoxItem;
            AISettings.AD_Profile1 = profileComboBoxItem.Key;
        }

        private void AD_Profile2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProfileComboBoxItem profileComboBoxItem = comboBox.SelectedItem as ProfileComboBoxItem;
            AISettings.AD_Profile2 = profileComboBoxItem.Key;
        }

        private void AD_Profile3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProfileComboBoxItem profileComboBoxItem = comboBox.SelectedItem as ProfileComboBoxItem;
            AISettings.AD_Profile3 = profileComboBoxItem.Key;
        }

        private void AD_EnableProfile1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_EnableProfile1 = checkBox.Checked;
            if (checkBox.Checked == true)
            {
                this.AISettings.AD_EnableChangeProfile1 = false;
                AD_ChangeProfile1CheckBox.Checked = false;
            }
        }

        private void AD_EnableProfile2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_EnableProfile2 = checkBox.Checked;
            if (checkBox.Checked == true)
            {
                this.AISettings.AD_EnableChangeProfile2 = false;
                AD_ChangeProfile2CheckBox.Checked = false;
            }
        }

        private void AD_EnableProfile3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_EnableProfile3 = checkBox.Checked;
            if (checkBox.Checked == true)
            {
                this.AISettings.AD_EnableChangeProfile3 = false;
                AD_ChangeProfile3CheckBox.Checked = false;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.ST_RefreshProfiles();
        }

        private void AD_NoChangeModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_NoChangeMode = checkBox.Checked;
        }

        private void ST_EnableTelegramMsg1CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            bool @checked = checkBox.Checked;
            this.LG_autoScroll = @checked;
            if (@checked)
            {
                this.LG_ScrollToEnd();
            }
        }

        private void BF_StopMileageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.BF_StopMileage = checkBox.Checked;
        }

        private void AD_FarmOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            this.AISettings.AD_FarmOrder = comboBox.SelectedIndex;
        }

        private void AD_ChangeProfile1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProfileComboBoxItem profileComboBoxItem = comboBox.SelectedItem as ProfileComboBoxItem;
            this.AISettings.AD_Profile1 = profileComboBoxItem.Key;
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AD_ChangeProfile2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProfileComboBoxItem profileComboBoxItem = comboBox.SelectedItem as ProfileComboBoxItem;
            this.AISettings.AD_Profile2 = profileComboBoxItem.Key;
        }

        private void GroupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void AD_ChangeProfile3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProfileComboBoxItem profileComboBoxItem = comboBox.SelectedItem as ProfileComboBoxItem;
            this.AISettings.AD_Profile3 = profileComboBoxItem.Key;
        }

        private void AD_ChangeProfile1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_EnableChangeProfile1 = checkBox.Checked;
            if (checkBox.Checked == true)
            {
                this.AISettings.AD_EnableProfile1 = false;
                AD_EnableProfile1CheckBox.Checked = false;
            }
        }

        private void AD_ChangeProfile2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_EnableChangeProfile2 = checkBox.Checked;
            if (checkBox.Checked == true)
            {
                this.AISettings.AD_EnableProfile2 = false;
                AD_EnableProfile2CheckBox.Checked = false;
            }
        }

        private void AD_ChangeProfile3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AD_EnableChangeProfile3 = checkBox.Checked;
            if (checkBox.Checked == true)
            {
                this.AISettings.AD_EnableProfile3 = false;
                AD_EnableProfile3CheckBox.Checked = false;
            }
        }

        private void AR_EnableChangeProfile1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AR_EnableChangeProfile1 = checkBox.Checked;
        }

        private void AR_EnableChangeProfile2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.AR_EnableChangeProfile2 = checkBox.Checked;
        }

        private void AR_ChangeProfile1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProfileComboBoxItem profileComboBoxItem = comboBox.SelectedItem as ProfileComboBoxItem;
            this.AISettings.AR_Profile1 = profileComboBoxItem.Key;
        }

        private void AR_ChangeProfile2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProfileComboBoxItem profileComboBoxItem = comboBox.SelectedItem as ProfileComboBoxItem;
            this.AISettings.AR_Profile2 = profileComboBoxItem.Key;
        }

        private void RD_EnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RD_Enable = checkBox.Checked;
        }

        private void RD_EnableLimitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RD_EnableLimit = checkBox.Checked;
        }

        private void RD_FightExtraRaidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RD_FightExtraRaid = checkBox.Checked;
        }

        private void RD_SellItemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RD_EnableSellItem = checkBox.Checked;
        }

        private void RD_CollectMileageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RD_EnableCollectMileage = checkBox.Checked;
        }

        private void RD_StopNoKeyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RD_StopOutKey = checkBox.Checked;
        }

        private void RD_ChangeProfile1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RD_EnableChangeProfile1 = checkBox.Checked;
        }

        private void RD_ChangeProfile1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProfileComboBoxItem profileComboBoxItem = comboBox.SelectedItem as ProfileComboBoxItem;
            this.AISettings.RD_Profile1 = profileComboBoxItem.Key;
        }

        private void SD_EnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.SD_Enable = checkBox.Checked;
        }

        private void SD_EnableLimitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.SD_EnableLimit = checkBox.Checked;
        }

        private void SD_ChangeProfile1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.SD_EnableChangeProfile1 = checkBox.Checked;
        }

        private void SD_ChangeProfile1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProfileComboBoxItem profileComboBoxItem = comboBox.SelectedItem as ProfileComboBoxItem;
            this.AISettings.SD_Profile1 = profileComboBoxItem.Key;
        }

        private void RD_SellItemRankComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int num2 = comboBox.SelectedIndex;
            this.AISettings.RD_SellItemRank = num2;
        }

        private void RD_SellJewelRankComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int num2 = comboBox.SelectedIndex;
            this.AISettings.RD_SellJewelRank = num2;
        }

        private void RD_SellAccRankComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            int num2 = comboBox.SelectedIndex;
            this.AISettings.RD_SellAccRank = num2;
        }

        private void RS_CIOnlyTicketsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AISettings.RS_CIOnlyTicket = checkBox.Checked;
        }

        private void ST_TelegramWarnHTCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AIProfiles.ST_TelegramWarnHT = checkBox.Checked;
        }

        private void ST_TelegramWarnBoostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            this.AIProfiles.ST_TelegramWarnBoost = checkBox.Checked;
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