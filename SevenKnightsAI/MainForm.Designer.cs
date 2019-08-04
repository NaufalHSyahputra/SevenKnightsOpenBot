namespace SevenKnightsAI
{
	
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ST_TelegramChatIDTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ST_TelegramTokenTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ST_TelegramEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.ST_TelegramWarnBoostCheckBox = new System.Windows.Forms.CheckBox();
            this.ST_TelegramWarnHTCheckBox = new System.Windows.Forms.CheckBox();
            this.ST_opacityLabel = new System.Windows.Forms.Label();
            this.ST_manageProfileButton = new System.Windows.Forms.Button();
            this.ST_currentProfileComboBox = new System.Windows.Forms.ComboBox();
            this.ST_currentProfileLabel = new System.Windows.Forms.Label();
            this.ST_opacityTrackBar = new System.Windows.Forms.TrackBar();
            this.ST_reconnectNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ST_reconnectInterruptCheckBox = new System.Windows.Forms.CheckBox();
            this.ST_delayValueLabel = new System.Windows.Forms.Label();
            this.ST_delayLabel = new System.Windows.Forms.Label();
            this.ST_delayTrackBar = new System.Windows.Forms.TrackBar();
            this.arenaKeysLabel2 = new System.Windows.Forms.Label();
            this.adventureKeysLabel2 = new System.Windows.Forms.Label();
            this.honorLabel2 = new System.Windows.Forms.Label();
            this.rubyLabel2 = new System.Windows.Forms.Label();
            this.goldLabel2 = new System.Windows.Forms.Label();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SmartModePictureBox = new System.Windows.Forms.PictureBox();
            this.arenaPictureBox = new System.Windows.Forms.PictureBox();
            this.adventurePictureBox = new System.Windows.Forms.PictureBox();
            this.SmartModeCountLabel = new System.Windows.Forms.Label();
            this.arenaCountLabel = new System.Windows.Forms.Label();
            this.adventureCountLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.aiPause = new System.Windows.Forms.Button();
            this.aiButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.adminToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.profileToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCursorPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslBuildInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AD_difficultyComboBox = new System.Windows.Forms.ComboBox();
            this.AD_difficultyComboBox2nd = new System.Windows.Forms.ComboBox();
            this.GB_WaitForKeys = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.LG_logTextBox = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.logsBox = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timerSecond = new System.Windows.Forms.Label();
            this.timerMinute = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timerHour = new System.Windows.Forms.Label();
            this.botstatusLabel = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.itemslotLabel = new System.Windows.Forms.Label();
            this.heroslotLabel = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.itemadvLabel = new System.Windows.Forms.Label();
            this.heroadvLabel = new System.Windows.Forms.Label();
            this.goldadvLabel = new System.Windows.Forms.Label();
            this.h30advLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.soulLabel = new System.Windows.Forms.Label();
            this.essenceLabel = new System.Windows.Forms.Label();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.starLabel = new System.Windows.Forms.Label();
            this.goldencrystalLabel = new System.Windows.Forms.Label();
            this.hornLabel = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rankArenaLabel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.arenaLoseLabel2 = new System.Windows.Forms.Label();
            this.arenaWinLabel2 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.AD_EnableProfile1CheckBox = new System.Windows.Forms.CheckBox();
            this.AD_EnableProfile2CheckBox = new System.Windows.Forms.CheckBox();
            this.AD_EnableProfile3CheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.AD_NoChangeModeCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_EnHottime_Checkbox = new System.Windows.Forms.CheckBox();
            this.AD_NoHeroUp_Checkbox = new System.Windows.Forms.CheckBox();
            this.AD_limitLabel = new System.Windows.Forms.Label();
            this.AD_limitNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AD_limitCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_enableCheckBox = new System.Windows.Forms.CheckBox();
            this.AD_StopOnFullItems_Checkbox = new System.Windows.Forms.CheckBox();
            this.AD_StopOnFullHeroes_Checkbox = new System.Windows.Forms.CheckBox();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.AD_BoostModeSequenceRadio = new System.Windows.Forms.RadioButton();
            this.AD_BoostModeAllMapsRadio = new System.Windows.Forms.RadioButton();
            this.AD_BoostModeAsgarRadio = new System.Windows.Forms.RadioButton();
            this.AD_bootmodeCheckBox = new System.Windows.Forms.CheckBox();
            this.ADCH_ChangeHeroGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AD_teamLabel = new System.Windows.Forms.Label();
            this.AD_teamComboBox2 = new System.Windows.Forms.ComboBox();
            this.AD_teamComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.AD_UseFriendCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.AD_difficultyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AD_worldLabel = new System.Windows.Forms.Label();
            this.AD_stageLabel = new System.Windows.Forms.Label();
            this.AD_worldComboBox = new System.Windows.Forms.ComboBox();
            this.AD_stageComboBox = new System.Windows.Forms.ComboBox();
            this.AD_sequenceButton = new System.Windows.Forms.Button();
            this.AD_continuousCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.SM_EnableCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.SM_CollectTartarusCheckBox = new System.Windows.Forms.CheckBox();
            this.SM_CollectRaidCheckBox = new System.Windows.Forms.CheckBox();
            this.SM_CollectTowerCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.AR_enableCheckBox = new System.Windows.Forms.CheckBox();
            this.AR_limitLabel = new System.Windows.Forms.Label();
            this.AR_stopArenaCheckBox = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.AR_limitNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AR_useRubyCheckBox = new System.Windows.Forms.CheckBox();
            this.AR_limitCheckBox = new System.Windows.Forms.CheckBox();
            this.AR_useRubyLabel = new System.Windows.Forms.Label();
            this.AR_useRubyNumericBox = new System.Windows.Forms.NumericUpDown();
            this.AR_stopArenaNumericBox = new System.Windows.Forms.NumericUpDown();
            this.GC_formationPanel = new System.Windows.Forms.Panel();
            this.GC_pos5CheckBox = new System.Windows.Forms.CheckBox();
            this.GC_pos4CheckBox = new System.Windows.Forms.CheckBox();
            this.GC_pos3CheckBox = new System.Windows.Forms.CheckBox();
            this.GC_pos2CheckBox = new System.Windows.Forms.CheckBox();
            this.GC_pos1CheckBox = new System.Windows.Forms.CheckBox();
            this.GC_teamComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PU_enableActive3CheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PU_Active1NumericBox = new System.Windows.Forms.NumericUpDown();
            this.PU_enableActive1CheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.PU_4MOnlyLv30CheckBox = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.PU_4OnlyLv30CheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PU_4MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.PU_enableActive2CheckBox = new System.Windows.Forms.CheckBox();
            this.PU_4StarCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.PU_3OrderComboBox = new System.Windows.Forms.ComboBox();
            this.PU_3OnlyLv30CheckBox = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.PU_3ConditionComboBox = new System.Windows.Forms.ComboBox();
            this.PU_3MOnlyLv30CheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PU_3MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.PU_3StarCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.PU_2OrderComboBox = new System.Windows.Forms.ComboBox();
            this.PU_2OnlyLv30CheckBox = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.PU_2ConditionComboBox = new System.Windows.Forms.ComboBox();
            this.PU_2MOnlyLv30CheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PU_2MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.PU_2StarCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.PU_1OrderComboBox = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.PU_1ConditionComboBox = new System.Windows.Forms.ComboBox();
            this.PU_1MOnlyLv30CheckBox = new System.Windows.Forms.CheckBox();
            this.PU_1OnlyLv30CheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PU_1MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.PU_1StarCheckBox = new System.Windows.Forms.CheckBox();
            this.PU_enableCheckbox = new System.Windows.Forms.CheckBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.BF_Active2NumericBox = new System.Windows.Forms.NumericUpDown();
            this.BF_EnableActivate2CheckBox = new System.Windows.Forms.CheckBox();
            this.BF_EnableActivate1CheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BF_OnlyLv30CheckBox = new System.Windows.Forms.CheckBox();
            this.BF_rankComboBox = new System.Windows.Forms.ComboBox();
            this.BF_EnableCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.RS_CIOnlyTicketsCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_CIOnlyHonorCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_CIOnlyCurrencyCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_CIOnlyKeysCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_EnableCollectInboxCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_EnableCINoRubyCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_CollectInboxCheckBox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.RS_CollectInboxActiveNumericBox = new System.Windows.Forms.NumericUpDown();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.tabPage19 = new System.Windows.Forms.TabPage();
            this.ST_blueStacksGroupBox = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.ST_forceActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.ST_toggleBlueStacksButton = new System.Windows.Forms.Button();
            this.ST_foregroundMode = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.LDTitleTextBox = new System.Windows.Forms.TextBox();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.label79 = new System.Windows.Forms.Label();
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.groupBox39 = new System.Windows.Forms.GroupBox();
            this.tabPage21 = new System.Windows.Forms.TabPage();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.ST_EnableTelegramMsg1CheckBox = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.screenshotButton = new System.Windows.Forms.Button();
            this.resourcesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ST_EmulatorNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.topheaderPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_opacityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_reconnectNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_delayTrackBar)).BeginInit();
            this.summaryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmartModePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arenaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventurePictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AD_limitNumericBox)).BeginInit();
            this.tabPage15.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.ADCH_ChangeHeroGroupBox.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AR_limitNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AR_useRubyNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AR_stopArenaNumericBox)).BeginInit();
            this.GC_formationPanel.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PU_Active1NumericBox)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BF_Active2NumericBox)).BeginInit();
            this.groupBox16.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_CollectInboxActiveNumericBox)).BeginInit();
            this.tabPage18.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.tabPage19.SuspendLayout();
            this.ST_blueStacksGroupBox.SuspendLayout();
            this.groupBox38.SuspendLayout();
            this.tabPage20.SuspendLayout();
            this.groupBox39.SuspendLayout();
            this.tabPage21.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.resourcesTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topheaderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.linkLabel2);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.ST_TelegramChatIDTextBox);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.ST_TelegramTokenTextBox);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.ST_TelegramEnableCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 150);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Telegram Bot Setup";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(55, 127);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "How to use Telegram Bot : ";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(189, 127);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(112, 13);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://goo.gl/obtKV2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::SevenKnightsAI.Properties.Resources.telegramLogo;
            this.pictureBox2.Location = new System.Drawing.Point(7, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // ST_TelegramChatIDTextBox
            // 
            this.ST_TelegramChatIDTextBox.Enabled = false;
            this.ST_TelegramChatIDTextBox.Location = new System.Drawing.Point(118, 88);
            this.ST_TelegramChatIDTextBox.Name = "ST_TelegramChatIDTextBox";
            this.ST_TelegramChatIDTextBox.Size = new System.Drawing.Size(347, 20);
            this.ST_TelegramChatIDTextBox.TabIndex = 4;
            this.ST_TelegramChatIDTextBox.TextChanged += new System.EventHandler(this.ST_TelegramChatIDTextBox_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(55, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Chat ID";
            // 
            // ST_TelegramTokenTextBox
            // 
            this.ST_TelegramTokenTextBox.Enabled = false;
            this.ST_TelegramTokenTextBox.Location = new System.Drawing.Point(118, 62);
            this.ST_TelegramTokenTextBox.Name = "ST_TelegramTokenTextBox";
            this.ST_TelegramTokenTextBox.Size = new System.Drawing.Size(347, 20);
            this.ST_TelegramTokenTextBox.TabIndex = 2;
            this.ST_TelegramTokenTextBox.TextChanged += new System.EventHandler(this.ST_TelegramTokenTextBox_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(55, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Bot Token";
            // 
            // ST_TelegramEnableCheckBox
            // 
            this.ST_TelegramEnableCheckBox.AutoSize = true;
            this.ST_TelegramEnableCheckBox.Location = new System.Drawing.Point(55, 30);
            this.ST_TelegramEnableCheckBox.Name = "ST_TelegramEnableCheckBox";
            this.ST_TelegramEnableCheckBox.Size = new System.Drawing.Size(125, 17);
            this.ST_TelegramEnableCheckBox.TabIndex = 0;
            this.ST_TelegramEnableCheckBox.Text = "Enable Telegram Bot";
            this.ST_TelegramEnableCheckBox.UseVisualStyleBackColor = true;
            this.ST_TelegramEnableCheckBox.CheckedChanged += new System.EventHandler(this.ST_TelegramEnableCheckBox_CheckedChanged);
            // 
            // ST_TelegramWarnBoostCheckBox
            // 
            this.ST_TelegramWarnBoostCheckBox.AutoSize = true;
            this.ST_TelegramWarnBoostCheckBox.Location = new System.Drawing.Point(288, 375);
            this.ST_TelegramWarnBoostCheckBox.Name = "ST_TelegramWarnBoostCheckBox";
            this.ST_TelegramWarnBoostCheckBox.Size = new System.Drawing.Size(206, 17);
            this.ST_TelegramWarnBoostCheckBox.TabIndex = 14;
            this.ST_TelegramWarnBoostCheckBox.Text = "Send Message when Boost reach limit";
            this.ST_TelegramWarnBoostCheckBox.UseVisualStyleBackColor = true;
            this.ST_TelegramWarnBoostCheckBox.Visible = false;
            this.ST_TelegramWarnBoostCheckBox.CheckedChanged += new System.EventHandler(this.ST_TelegramWarnBoostCheckBox_CheckedChanged);
            // 
            // ST_TelegramWarnHTCheckBox
            // 
            this.ST_TelegramWarnHTCheckBox.AutoSize = true;
            this.ST_TelegramWarnHTCheckBox.Location = new System.Drawing.Point(8, 375);
            this.ST_TelegramWarnHTCheckBox.Name = "ST_TelegramWarnHTCheckBox";
            this.ST_TelegramWarnHTCheckBox.Size = new System.Drawing.Size(209, 17);
            this.ST_TelegramWarnHTCheckBox.TabIndex = 13;
            this.ST_TelegramWarnHTCheckBox.Text = "Send Message when Hot Time is done";
            this.ST_TelegramWarnHTCheckBox.UseVisualStyleBackColor = true;
            this.ST_TelegramWarnHTCheckBox.Visible = false;
            this.ST_TelegramWarnHTCheckBox.CheckedChanged += new System.EventHandler(this.ST_TelegramWarnHTCheckBox_CheckedChanged);
            // 
            // ST_opacityLabel
            // 
            this.ST_opacityLabel.AutoSize = true;
            this.ST_opacityLabel.Location = new System.Drawing.Point(6, 90);
            this.ST_opacityLabel.Name = "ST_opacityLabel";
            this.ST_opacityLabel.Size = new System.Drawing.Size(72, 13);
            this.ST_opacityLabel.TabIndex = 10;
            this.ST_opacityLabel.Text = "Transparency";
            // 
            // ST_manageProfileButton
            // 
            this.ST_manageProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_manageProfileButton.Location = new System.Drawing.Point(289, 16);
            this.ST_manageProfileButton.Name = "ST_manageProfileButton";
            this.ST_manageProfileButton.Size = new System.Drawing.Size(80, 23);
            this.ST_manageProfileButton.TabIndex = 2;
            this.ST_manageProfileButton.Text = "New Profiles";
            this.ST_manageProfileButton.UseVisualStyleBackColor = true;
            this.ST_manageProfileButton.Click += new System.EventHandler(this.ST_manageProfileButton_Click);
            // 
            // ST_currentProfileComboBox
            // 
            this.ST_currentProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ST_currentProfileComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_currentProfileComboBox.FormattingEnabled = true;
            this.ST_currentProfileComboBox.Location = new System.Drawing.Point(82, 18);
            this.ST_currentProfileComboBox.Name = "ST_currentProfileComboBox";
            this.ST_currentProfileComboBox.Size = new System.Drawing.Size(200, 21);
            this.ST_currentProfileComboBox.TabIndex = 1;
            this.ST_currentProfileComboBox.SelectedIndexChanged += new System.EventHandler(this.ST_currentProfileComboBox_SelectedIndexChanged);
            // 
            // ST_currentProfileLabel
            // 
            this.ST_currentProfileLabel.AutoSize = true;
            this.ST_currentProfileLabel.Location = new System.Drawing.Point(3, 22);
            this.ST_currentProfileLabel.Name = "ST_currentProfileLabel";
            this.ST_currentProfileLabel.Size = new System.Drawing.Size(73, 13);
            this.ST_currentProfileLabel.TabIndex = 0;
            this.ST_currentProfileLabel.Text = "Current Profile";
            // 
            // ST_opacityTrackBar
            // 
            this.ST_opacityTrackBar.AutoSize = false;
            this.ST_opacityTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.ST_opacityTrackBar.Location = new System.Drawing.Point(84, 86);
            this.ST_opacityTrackBar.Maximum = 100;
            this.ST_opacityTrackBar.Minimum = 20;
            this.ST_opacityTrackBar.Name = "ST_opacityTrackBar";
            this.ST_opacityTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ST_opacityTrackBar.Size = new System.Drawing.Size(104, 27);
            this.ST_opacityTrackBar.TabIndex = 11;
            this.ST_opacityTrackBar.TickFrequency = 10;
            this.ST_opacityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ST_opacityTrackBar.Value = 100;
            this.ST_opacityTrackBar.ValueChanged += new System.EventHandler(this.ST_opacityTrackBar_ValueChanged);
            // 
            // ST_reconnectNumericUpDown
            // 
            this.ST_reconnectNumericUpDown.Location = new System.Drawing.Point(225, 52);
            this.ST_reconnectNumericUpDown.Name = "ST_reconnectNumericUpDown";
            this.ST_reconnectNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.ST_reconnectNumericUpDown.TabIndex = 4;
            this.ST_reconnectNumericUpDown.ValueChanged += new System.EventHandler(this.ST_reconnectNumericBox_ValueChanged);
            // 
            // ST_reconnectInterruptCheckBox
            // 
            this.ST_reconnectInterruptCheckBox.AutoSize = true;
            this.ST_reconnectInterruptCheckBox.Location = new System.Drawing.Point(9, 52);
            this.ST_reconnectInterruptCheckBox.Name = "ST_reconnectInterruptCheckBox";
            this.ST_reconnectInterruptCheckBox.Size = new System.Drawing.Size(210, 17);
            this.ST_reconnectInterruptCheckBox.TabIndex = 3;
            this.ST_reconnectInterruptCheckBox.Text = "Reconnect on interrupt within (minutes)";
            this.ST_reconnectInterruptCheckBox.UseVisualStyleBackColor = true;
            this.ST_reconnectInterruptCheckBox.CheckedChanged += new System.EventHandler(this.ST_reconnectInterruptCheckBox_CheckedChanged);
            // 
            // ST_delayValueLabel
            // 
            this.ST_delayValueLabel.AutoSize = true;
            this.ST_delayValueLabel.Location = new System.Drawing.Point(229, 26);
            this.ST_delayValueLabel.Name = "ST_delayValueLabel";
            this.ST_delayValueLabel.Size = new System.Drawing.Size(47, 13);
            this.ST_delayValueLabel.TabIndex = 2;
            this.ST_delayValueLabel.Text = "2000 ms";
            // 
            // ST_delayLabel
            // 
            this.ST_delayLabel.Location = new System.Drawing.Point(6, 26);
            this.ST_delayLabel.Name = "ST_delayLabel";
            this.ST_delayLabel.Size = new System.Drawing.Size(49, 13);
            this.ST_delayLabel.TabIndex = 1;
            this.ST_delayLabel.Text = "Delay";
            // 
            // ST_delayTrackBar
            // 
            this.ST_delayTrackBar.AutoSize = false;
            this.ST_delayTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.ST_delayTrackBar.LargeChange = 100;
            this.ST_delayTrackBar.Location = new System.Drawing.Point(61, 19);
            this.ST_delayTrackBar.Maximum = 3000;
            this.ST_delayTrackBar.Minimum = 500;
            this.ST_delayTrackBar.Name = "ST_delayTrackBar";
            this.ST_delayTrackBar.Size = new System.Drawing.Size(162, 27);
            this.ST_delayTrackBar.SmallChange = 100;
            this.ST_delayTrackBar.TabIndex = 0;
            this.ST_delayTrackBar.TickFrequency = 100;
            this.ST_delayTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ST_delayTrackBar.Value = 2000;
            this.ST_delayTrackBar.ValueChanged += new System.EventHandler(this.ST_delayTrackBar_ValueChanged);
            // 
            // arenaKeysLabel2
            // 
            this.arenaKeysLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.arenaKeysLabel2.AutoSize = true;
            this.arenaKeysLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arenaKeysLabel2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.arenaKeysLabel2.Location = new System.Drawing.Point(247, 33);
            this.arenaKeysLabel2.Name = "arenaKeysLabel2";
            this.arenaKeysLabel2.Size = new System.Drawing.Size(16, 18);
            this.arenaKeysLabel2.TabIndex = 10;
            this.arenaKeysLabel2.Text = "0";
            // 
            // adventureKeysLabel2
            // 
            this.adventureKeysLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.adventureKeysLabel2.AutoSize = true;
            this.adventureKeysLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adventureKeysLabel2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.adventureKeysLabel2.Location = new System.Drawing.Point(85, 33);
            this.adventureKeysLabel2.Name = "adventureKeysLabel2";
            this.adventureKeysLabel2.Size = new System.Drawing.Size(16, 18);
            this.adventureKeysLabel2.TabIndex = 8;
            this.adventureKeysLabel2.Text = "0";
            // 
            // honorLabel2
            // 
            this.honorLabel2.AutoSize = true;
            this.honorLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.honorLabel2.ForeColor = System.Drawing.SystemColors.Info;
            this.honorLabel2.Location = new System.Drawing.Point(384, 0);
            this.honorLabel2.Name = "honorLabel2";
            this.honorLabel2.Size = new System.Drawing.Size(16, 18);
            this.honorLabel2.TabIndex = 7;
            this.honorLabel2.Text = "0";
            // 
            // rubyLabel2
            // 
            this.rubyLabel2.AutoSize = true;
            this.rubyLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rubyLabel2.ForeColor = System.Drawing.SystemColors.Info;
            this.rubyLabel2.Location = new System.Drawing.Point(236, 0);
            this.rubyLabel2.Name = "rubyLabel2";
            this.rubyLabel2.Size = new System.Drawing.Size(16, 18);
            this.rubyLabel2.TabIndex = 3;
            this.rubyLabel2.Text = "0";
            // 
            // goldLabel2
            // 
            this.goldLabel2.AutoSize = true;
            this.goldLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldLabel2.ForeColor = System.Drawing.SystemColors.Info;
            this.goldLabel2.Location = new System.Drawing.Point(88, 0);
            this.goldLabel2.Name = "goldLabel2";
            this.goldLabel2.Size = new System.Drawing.Size(16, 18);
            this.goldLabel2.TabIndex = 1;
            this.goldLabel2.Text = "0";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.button8);
            this.summaryGroupBox.Controls.Add(this.pictureBox5);
            this.summaryGroupBox.Controls.Add(this.pictureBox3);
            this.summaryGroupBox.Controls.Add(this.SmartModePictureBox);
            this.summaryGroupBox.Controls.Add(this.arenaPictureBox);
            this.summaryGroupBox.Controls.Add(this.arenaKeysLabel2);
            this.summaryGroupBox.Controls.Add(this.adventurePictureBox);
            this.summaryGroupBox.Controls.Add(this.SmartModeCountLabel);
            this.summaryGroupBox.Controls.Add(this.adventureKeysLabel2);
            this.summaryGroupBox.Controls.Add(this.arenaCountLabel);
            this.summaryGroupBox.Controls.Add(this.adventureCountLabel);
            this.summaryGroupBox.Location = new System.Drawing.Point(8, 576);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(349, 130);
            this.summaryGroupBox.TabIndex = 4;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Modes && Keys";
            this.summaryGroupBox.Enter += new System.EventHandler(this.summaryGroupBox_Enter);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(251, 8);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 22);
            this.button8.TabIndex = 29;
            this.button8.Text = "&Export";
            this.toolTip.SetToolTip(this.button8, "Use this when you got an error. Send log file to Admin");
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SevenKnightsAI.Properties.Resources.icon_key_arena;
            this.pictureBox5.Location = new System.Drawing.Point(208, 29);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox5, "Arena Keys");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SevenKnightsAI.Properties.Resources.icon_advkey;
            this.pictureBox3.Location = new System.Drawing.Point(43, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox3, "Adventure Keys");
            // 
            // SmartModePictureBox
            // 
            this.SmartModePictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_smart;
            this.SmartModePictureBox.Location = new System.Drawing.Point(130, 82);
            this.SmartModePictureBox.Name = "SmartModePictureBox";
            this.SmartModePictureBox.Size = new System.Drawing.Size(37, 36);
            this.SmartModePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SmartModePictureBox.TabIndex = 10;
            this.SmartModePictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.SmartModePictureBox, "Gold Chamber");
            // 
            // arenaPictureBox
            // 
            this.arenaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("arenaPictureBox.Image")));
            this.arenaPictureBox.Location = new System.Drawing.Point(246, 82);
            this.arenaPictureBox.Name = "arenaPictureBox";
            this.arenaPictureBox.Size = new System.Drawing.Size(37, 36);
            this.arenaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arenaPictureBox.TabIndex = 9;
            this.arenaPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.arenaPictureBox, "Arena");
            // 
            // adventurePictureBox
            // 
            this.adventurePictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_adv;
            this.adventurePictureBox.Location = new System.Drawing.Point(7, 82);
            this.adventurePictureBox.Name = "adventurePictureBox";
            this.adventurePictureBox.Size = new System.Drawing.Size(37, 36);
            this.adventurePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adventurePictureBox.TabIndex = 8;
            this.adventurePictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.adventurePictureBox, "Adventure");
            this.adventurePictureBox.Click += new System.EventHandler(this.adventurePictureBox_Click);
            // 
            // SmartModeCountLabel
            // 
            this.SmartModeCountLabel.AutoSize = true;
            this.SmartModeCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmartModeCountLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.SmartModeCountLabel.Location = new System.Drawing.Point(173, 89);
            this.SmartModeCountLabel.Name = "SmartModeCountLabel";
            this.SmartModeCountLabel.Size = new System.Drawing.Size(25, 20);
            this.SmartModeCountLabel.TabIndex = 3;
            this.SmartModeCountLabel.Text = "x0";
            // 
            // arenaCountLabel
            // 
            this.arenaCountLabel.AutoSize = true;
            this.arenaCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arenaCountLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.arenaCountLabel.Location = new System.Drawing.Point(289, 89);
            this.arenaCountLabel.Name = "arenaCountLabel";
            this.arenaCountLabel.Size = new System.Drawing.Size(25, 20);
            this.arenaCountLabel.TabIndex = 2;
            this.arenaCountLabel.Text = "x0";
            // 
            // adventureCountLabel
            // 
            this.adventureCountLabel.AutoSize = true;
            this.adventureCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adventureCountLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.adventureCountLabel.Location = new System.Drawing.Point(48, 89);
            this.adventureCountLabel.Name = "adventureCountLabel";
            this.adventureCountLabel.Size = new System.Drawing.Size(25, 20);
            this.adventureCountLabel.TabIndex = 1;
            this.adventureCountLabel.Text = "x0";
            this.adventureCountLabel.Click += new System.EventHandler(this.adventureCountLabel_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(237, 193);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Auto Scroll";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // aiPause
            // 
            this.aiPause.Enabled = false;
            this.aiPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aiPause.Location = new System.Drawing.Point(16, 51);
            this.aiPause.Name = "aiPause";
            this.aiPause.Size = new System.Drawing.Size(102, 30);
            this.aiPause.TabIndex = 8;
            this.aiPause.Text = "&Pause";
            this.aiPause.UseVisualStyleBackColor = true;
            this.aiPause.Click += new System.EventHandler(this.aiPause_Click);
            // 
            // aiButton
            // 
            this.aiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aiButton.Location = new System.Drawing.Point(16, 15);
            this.aiButton.Name = "aiButton";
            this.aiButton.Size = new System.Drawing.Size(102, 30);
            this.aiButton.TabIndex = 3;
            this.aiButton.Text = "Start AI";
            this.aiButton.UseVisualStyleBackColor = true;
            this.aiButton.Click += new System.EventHandler(this.aiButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Silver;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripLabel,
            this.profileToolStripLabel,
            this.statusToolStripLabel,
            this.splitterStatusLabel,
            this.tsslCursorPosition,
            this.tsslBuildInfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 719);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(505, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // adminToolStripLabel
            // 
            this.adminToolStripLabel.Name = "adminToolStripLabel";
            this.adminToolStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // profileToolStripLabel
            // 
            this.profileToolStripLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.profileToolStripLabel.Name = "profileToolStripLabel";
            this.profileToolStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // statusToolStripLabel
            // 
            this.statusToolStripLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusToolStripLabel.Name = "statusToolStripLabel";
            this.statusToolStripLabel.Size = new System.Drawing.Size(103, 17);
            this.statusToolStripLabel.Text = "Status: AI Stopped";
            // 
            // splitterStatusLabel
            // 
            this.splitterStatusLabel.Name = "splitterStatusLabel";
            this.splitterStatusLabel.Size = new System.Drawing.Size(350, 17);
            this.splitterStatusLabel.Spring = true;
            this.splitterStatusLabel.Click += new System.EventHandler(this.splitterStatusLabel_Click);
            // 
            // tsslCursorPosition
            // 
            this.tsslCursorPosition.Name = "tsslCursorPosition";
            this.tsslCursorPosition.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslBuildInfo
            // 
            this.tsslBuildInfo.Name = "tsslBuildInfo";
            this.tsslBuildInfo.Size = new System.Drawing.Size(37, 17);
            this.tsslBuildInfo.Text = "Build:";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettingsButton.Location = new System.Drawing.Point(289, 45);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(80, 23);
            this.saveSettingsButton.TabIndex = 5;
            this.saveSettingsButton.Text = "Save Profile";
            this.saveSettingsButton.UseVisualStyleBackColor = true;
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // Event
            // 
            this.Event.Name = "Event";
            // 
            // Time
            // 
            this.Time.Name = "Time";
            // 
            // Details
            // 
            this.Details.Name = "Details";
            // 
            // AD_difficultyComboBox
            // 
            this.AD_difficultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_difficultyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AD_difficultyComboBox.FormattingEnabled = true;
            this.AD_difficultyComboBox.Items.AddRange(new object[] {
            "--",
            "Easy",
            "Normal",
            "Hard"});
            this.AD_difficultyComboBox.Location = new System.Drawing.Point(70, 133);
            this.AD_difficultyComboBox.MaxDropDownItems = 3;
            this.AD_difficultyComboBox.Name = "AD_difficultyComboBox";
            this.AD_difficultyComboBox.Size = new System.Drawing.Size(60, 21);
            this.AD_difficultyComboBox.TabIndex = 7;
            this.toolTip.SetToolTip(this.AD_difficultyComboBox, "For Map 1 to Map 7");
            this.AD_difficultyComboBox.Visible = false;
            this.AD_difficultyComboBox.SelectedValueChanged += new System.EventHandler(this.AD_difficultyComboBox_SelectedValueChanged);
            // 
            // AD_difficultyComboBox2nd
            // 
            this.AD_difficultyComboBox2nd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_difficultyComboBox2nd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AD_difficultyComboBox2nd.FormattingEnabled = true;
            this.AD_difficultyComboBox2nd.Items.AddRange(new object[] {
            "--",
            "Easy",
            "Normal",
            "Hard"});
            this.AD_difficultyComboBox2nd.Location = new System.Drawing.Point(70, 96);
            this.AD_difficultyComboBox2nd.MaxDropDownItems = 3;
            this.AD_difficultyComboBox2nd.Name = "AD_difficultyComboBox2nd";
            this.AD_difficultyComboBox2nd.Size = new System.Drawing.Size(60, 21);
            this.AD_difficultyComboBox2nd.TabIndex = 27;
            this.toolTip.SetToolTip(this.AD_difficultyComboBox2nd, "For Map 8 +");
            this.AD_difficultyComboBox2nd.SelectedValueChanged += new System.EventHandler(this.AD_difficultyComboBox2nd_SelectedValueChanged);
            // 
            // GB_WaitForKeys
            // 
            this.GB_WaitForKeys.AutoSize = true;
            this.GB_WaitForKeys.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GB_WaitForKeys.Location = new System.Drawing.Point(37, 255);
            this.GB_WaitForKeys.Name = "GB_WaitForKeys";
            this.GB_WaitForKeys.Size = new System.Drawing.Size(72, 17);
            this.GB_WaitForKeys.TabIndex = 11;
            this.GB_WaitForKeys.Text = "Wait on 0";
            this.toolTip.SetToolTip(this.GB_WaitForKeys, "Wait Key");
            this.GB_WaitForKeys.UseVisualStyleBackColor = true;
            this.GB_WaitForKeys.Visible = false;
            this.GB_WaitForKeys.CheckedChanged += new System.EventHandler(this.GB_WaitForKeys_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(156, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 28;
            this.button1.Text = "&Export";
            this.toolTip.SetToolTip(this.button1, "Use this when you got an error. Send log file to Admin");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LG_exportButton_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(76, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 22);
            this.button2.TabIndex = 27;
            this.button2.Text = "&Log Pixel";
            this.toolTip.SetToolTip(this.button2, "Requries bot to be running or paused\r\n\r\nMouse over pixel to Log while keeping the" +
        " bot focused\r\nPress Alt+L");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LG_LogPixel_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SevenKnightsAI.Properties.Resources.icon_gold1;
            this.pictureBox6.Location = new System.Drawing.Point(63, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(19, 18);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox6, "Gold");
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(211, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(19, 18);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox8, "Ruby");
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::SevenKnightsAI.Properties.Resources.icon_honor1;
            this.pictureBox9.Location = new System.Drawing.Point(359, 3);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(19, 18);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 14;
            this.pictureBox9.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox9, "Honor");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SevenKnightsAI.Properties.Resources.icon_item;
            this.pictureBox4.Location = new System.Drawing.Point(6, 67);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox4, "Arena Keys");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SevenKnightsAI.Properties.Resources.lv30_icon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox1, "Arena Keys");
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::SevenKnightsAI.Properties.Resources.hero_icon;
            this.pictureBox18.Location = new System.Drawing.Point(6, 18);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(37, 39);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 36;
            this.pictureBox18.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox18, "Gold");
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::SevenKnightsAI.Properties.Resources.icon_gold1;
            this.pictureBox15.Location = new System.Drawing.Point(6, 63);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(37, 38);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 35;
            this.pictureBox15.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox15, "Gold");
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::SevenKnightsAI.Properties.Resources.icon_item;
            this.pictureBox13.Location = new System.Drawing.Point(6, 153);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(37, 36);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 29;
            this.pictureBox13.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox13, "Arena Keys");
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::SevenKnightsAI.Properties.Resources.cards_icon;
            this.pictureBox12.Location = new System.Drawing.Point(6, 107);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(37, 40);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 29;
            this.pictureBox12.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox12, "Arena Keys");
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::SevenKnightsAI.Properties.Resources.soulIcon;
            this.pictureBox16.Location = new System.Drawing.Point(355, 60);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(32, 34);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 20;
            this.pictureBox16.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox16, "Gold");
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::SevenKnightsAI.Properties.Resources.icon_ess;
            this.pictureBox11.Location = new System.Drawing.Point(357, 19);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(30, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 18;
            this.pictureBox11.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox11, "Gold");
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::SevenKnightsAI.Properties.Resources.icon_golden;
            this.pictureBox14.Location = new System.Drawing.Point(6, 19);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(30, 32);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 14;
            this.pictureBox14.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox14, "Gold");
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::SevenKnightsAI.Properties.Resources.icon_star;
            this.pictureBox17.Location = new System.Drawing.Point(194, 19);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(30, 32);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 14;
            this.pictureBox17.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox17, "Gold");
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::SevenKnightsAI.Properties.Resources.icon_scale;
            this.pictureBox10.Location = new System.Drawing.Point(194, 60);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 16;
            this.pictureBox10.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox10, "Gold");
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::SevenKnightsAI.Properties.Resources.icon_horn;
            this.pictureBox7.Location = new System.Drawing.Point(6, 60);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox7, "Gold");
            // 
            // LG_logTextBox
            // 
            this.LG_logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LG_logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LG_logTextBox.Location = new System.Drawing.Point(0, 0);
            this.LG_logTextBox.Name = "LG_logTextBox";
            this.LG_logTextBox.ReadOnly = true;
            this.LG_logTextBox.Size = new System.Drawing.Size(478, 333);
            this.LG_logTextBox.TabIndex = 1;
            this.LG_logTextBox.Text = "";
            this.LG_logTextBox.TextChanged += new System.EventHandler(this.LG_logTextBox_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage18);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(-4, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(513, 456);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Controls.Add(this.groupBox10);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.ImageKey = "icon_report.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(505, 429);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Report";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.logsBox);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Location = new System.Drawing.Point(9, 203);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(320, 220);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Log";
            // 
            // logsBox
            // 
            this.logsBox.BackColor = System.Drawing.SystemColors.Control;
            this.logsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logsBox.Location = new System.Drawing.Point(6, 19);
            this.logsBox.Name = "logsBox";
            this.logsBox.ReadOnly = true;
            this.logsBox.Size = new System.Drawing.Size(308, 168);
            this.logsBox.TabIndex = 24;
            this.logsBox.Text = "";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(6, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LG_clearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.timerSecond);
            this.groupBox1.Controls.Add(this.timerMinute);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.timerHour);
            this.groupBox1.Controls.Add(this.botstatusLabel);
            this.groupBox1.Location = new System.Drawing.Point(174, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 82);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Green;
            this.label24.Location = new System.Drawing.Point(112, 44);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(12, 18);
            this.label24.TabIndex = 27;
            this.label24.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(82, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = ":";
            // 
            // timerSecond
            // 
            this.timerSecond.AutoSize = true;
            this.timerSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerSecond.ForeColor = System.Drawing.Color.Green;
            this.timerSecond.Location = new System.Drawing.Point(121, 45);
            this.timerSecond.Name = "timerSecond";
            this.timerSecond.Size = new System.Drawing.Size(24, 18);
            this.timerSecond.TabIndex = 25;
            this.timerSecond.Text = "00";
            // 
            // timerMinute
            // 
            this.timerMinute.AutoSize = true;
            this.timerMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerMinute.ForeColor = System.Drawing.Color.Green;
            this.timerMinute.Location = new System.Drawing.Point(91, 45);
            this.timerMinute.Name = "timerMinute";
            this.timerMinute.Size = new System.Drawing.Size(24, 18);
            this.timerMinute.TabIndex = 24;
            this.timerMinute.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Time :";
            // 
            // timerHour
            // 
            this.timerHour.AutoSize = true;
            this.timerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerHour.ForeColor = System.Drawing.Color.Green;
            this.timerHour.Location = new System.Drawing.Point(63, 45);
            this.timerHour.Name = "timerHour";
            this.timerHour.Size = new System.Drawing.Size(24, 18);
            this.timerHour.TabIndex = 18;
            this.timerHour.Text = "00";
            // 
            // botstatusLabel
            // 
            this.botstatusLabel.AutoSize = true;
            this.botstatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botstatusLabel.ForeColor = System.Drawing.Color.Red;
            this.botstatusLabel.Location = new System.Drawing.Point(30, 18);
            this.botstatusLabel.Name = "botstatusLabel";
            this.botstatusLabel.Size = new System.Drawing.Size(79, 18);
            this.botstatusLabel.TabIndex = 20;
            this.botstatusLabel.Text = "AI Stopped";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.pictureBox4);
            this.groupBox9.Controls.Add(this.pictureBox1);
            this.groupBox9.Controls.Add(this.itemslotLabel);
            this.groupBox9.Controls.Add(this.heroslotLabel);
            this.groupBox9.Location = new System.Drawing.Point(335, 310);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(159, 114);
            this.groupBox9.TabIndex = 34;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Slot";
            // 
            // itemslotLabel
            // 
            this.itemslotLabel.AutoSize = true;
            this.itemslotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemslotLabel.Location = new System.Drawing.Point(64, 76);
            this.itemslotLabel.Name = "itemslotLabel";
            this.itemslotLabel.Size = new System.Drawing.Size(13, 18);
            this.itemslotLabel.TabIndex = 26;
            this.itemslotLabel.Text = "-";
            // 
            // heroslotLabel
            // 
            this.heroslotLabel.AutoSize = true;
            this.heroslotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroslotLabel.Location = new System.Drawing.Point(64, 28);
            this.heroslotLabel.Name = "heroslotLabel";
            this.heroslotLabel.Size = new System.Drawing.Size(13, 18);
            this.heroslotLabel.TabIndex = 5;
            this.heroslotLabel.Text = "-";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.pictureBox18);
            this.groupBox10.Controls.Add(this.pictureBox15);
            this.groupBox10.Controls.Add(this.pictureBox13);
            this.groupBox10.Controls.Add(this.pictureBox12);
            this.groupBox10.Controls.Add(this.itemadvLabel);
            this.groupBox10.Controls.Add(this.heroadvLabel);
            this.groupBox10.Controls.Add(this.goldadvLabel);
            this.groupBox10.Controls.Add(this.h30advLabel);
            this.groupBox10.Location = new System.Drawing.Point(335, 115);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(158, 195);
            this.groupBox10.TabIndex = 33;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Adventure";
            // 
            // itemadvLabel
            // 
            this.itemadvLabel.AutoSize = true;
            this.itemadvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemadvLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.itemadvLabel.Location = new System.Drawing.Point(61, 162);
            this.itemadvLabel.Name = "itemadvLabel";
            this.itemadvLabel.Size = new System.Drawing.Size(16, 18);
            this.itemadvLabel.TabIndex = 34;
            this.itemadvLabel.Tag = "";
            this.itemadvLabel.Text = "0";
            // 
            // heroadvLabel
            // 
            this.heroadvLabel.AutoSize = true;
            this.heroadvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroadvLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.heroadvLabel.Location = new System.Drawing.Point(61, 117);
            this.heroadvLabel.Name = "heroadvLabel";
            this.heroadvLabel.Size = new System.Drawing.Size(16, 18);
            this.heroadvLabel.TabIndex = 32;
            this.heroadvLabel.Tag = "";
            this.heroadvLabel.Text = "0";
            // 
            // goldadvLabel
            // 
            this.goldadvLabel.AutoSize = true;
            this.goldadvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldadvLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.goldadvLabel.Location = new System.Drawing.Point(61, 74);
            this.goldadvLabel.Name = "goldadvLabel";
            this.goldadvLabel.Size = new System.Drawing.Size(16, 18);
            this.goldadvLabel.TabIndex = 30;
            this.goldadvLabel.Tag = "";
            this.goldadvLabel.Text = "0";
            // 
            // h30advLabel
            // 
            this.h30advLabel.AutoSize = true;
            this.h30advLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h30advLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.h30advLabel.Location = new System.Drawing.Point(61, 29);
            this.h30advLabel.Name = "h30advLabel";
            this.h30advLabel.Size = new System.Drawing.Size(16, 18);
            this.h30advLabel.TabIndex = 28;
            this.h30advLabel.Tag = "";
            this.h30advLabel.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.pictureBox16);
            this.groupBox4.Controls.Add(this.soulLabel);
            this.groupBox4.Controls.Add(this.pictureBox11);
            this.groupBox4.Controls.Add(this.essenceLabel);
            this.groupBox4.Controls.Add(this.pictureBox14);
            this.groupBox4.Controls.Add(this.pictureBox17);
            this.groupBox4.Controls.Add(this.pictureBox10);
            this.groupBox4.Controls.Add(this.scaleLabel);
            this.groupBox4.Controls.Add(this.starLabel);
            this.groupBox4.Controls.Add(this.goldencrystalLabel);
            this.groupBox4.Controls.Add(this.pictureBox7);
            this.groupBox4.Controls.Add(this.hornLabel);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(488, 103);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resources:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(434, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 18);
            this.label13.TabIndex = 21;
            this.label13.Text = "/ 1000";
            // 
            // soulLabel
            // 
            this.soulLabel.AutoSize = true;
            this.soulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soulLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.soulLabel.Location = new System.Drawing.Point(396, 64);
            this.soulLabel.Name = "soulLabel";
            this.soulLabel.Size = new System.Drawing.Size(16, 18);
            this.soulLabel.TabIndex = 19;
            this.soulLabel.Text = "0";
            // 
            // essenceLabel
            // 
            this.essenceLabel.AutoSize = true;
            this.essenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.essenceLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.essenceLabel.Location = new System.Drawing.Point(396, 25);
            this.essenceLabel.Name = "essenceLabel";
            this.essenceLabel.Size = new System.Drawing.Size(16, 18);
            this.essenceLabel.TabIndex = 17;
            this.essenceLabel.Text = "0";
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.scaleLabel.Location = new System.Drawing.Point(230, 64);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(16, 18);
            this.scaleLabel.TabIndex = 15;
            this.scaleLabel.Text = "0";
            // 
            // starLabel
            // 
            this.starLabel.AutoSize = true;
            this.starLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.starLabel.Location = new System.Drawing.Point(230, 24);
            this.starLabel.Name = "starLabel";
            this.starLabel.Size = new System.Drawing.Size(16, 18);
            this.starLabel.TabIndex = 13;
            this.starLabel.Text = "0";
            // 
            // goldencrystalLabel
            // 
            this.goldencrystalLabel.AutoSize = true;
            this.goldencrystalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldencrystalLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.goldencrystalLabel.Location = new System.Drawing.Point(42, 25);
            this.goldencrystalLabel.Name = "goldencrystalLabel";
            this.goldencrystalLabel.Size = new System.Drawing.Size(16, 18);
            this.goldencrystalLabel.TabIndex = 13;
            this.goldencrystalLabel.Text = "0";
            // 
            // hornLabel
            // 
            this.hornLabel.AutoSize = true;
            this.hornLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hornLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.hornLabel.Location = new System.Drawing.Point(42, 64);
            this.hornLabel.Name = "hornLabel";
            this.hornLabel.Size = new System.Drawing.Size(16, 18);
            this.hornLabel.TabIndex = 13;
            this.hornLabel.Text = "0";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rankArenaLabel);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.arenaLoseLabel2);
            this.groupBox8.Controls.Add(this.arenaWinLabel2);
            this.groupBox8.Controls.Add(this.label45);
            this.groupBox8.Location = new System.Drawing.Point(6, 115);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(162, 82);
            this.groupBox8.TabIndex = 29;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Arena";
            // 
            // rankArenaLabel
            // 
            this.rankArenaLabel.AutoSize = true;
            this.rankArenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankArenaLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.rankArenaLabel.Location = new System.Drawing.Point(78, 49);
            this.rankArenaLabel.Name = "rankArenaLabel";
            this.rankArenaLabel.Size = new System.Drawing.Size(16, 18);
            this.rankArenaLabel.TabIndex = 26;
            this.rankArenaLabel.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 49);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 13);
            this.label26.TabIndex = 25;
            this.label26.Text = "Rank : ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(101, 22);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(12, 13);
            this.label25.TabIndex = 24;
            this.label25.Text = "/";
            // 
            // arenaLoseLabel2
            // 
            this.arenaLoseLabel2.AutoSize = true;
            this.arenaLoseLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arenaLoseLabel2.ForeColor = System.Drawing.Color.Crimson;
            this.arenaLoseLabel2.Location = new System.Drawing.Point(119, 18);
            this.arenaLoseLabel2.Name = "arenaLoseLabel2";
            this.arenaLoseLabel2.Size = new System.Drawing.Size(16, 18);
            this.arenaLoseLabel2.TabIndex = 23;
            this.arenaLoseLabel2.Text = "0";
            // 
            // arenaWinLabel2
            // 
            this.arenaWinLabel2.AutoSize = true;
            this.arenaWinLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arenaWinLabel2.ForeColor = System.Drawing.Color.Green;
            this.arenaWinLabel2.Location = new System.Drawing.Point(78, 18);
            this.arenaWinLabel2.Name = "arenaWinLabel2";
            this.arenaWinLabel2.Size = new System.Drawing.Size(16, 18);
            this.arenaWinLabel2.TabIndex = 5;
            this.arenaWinLabel2.Text = "0";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(4, 20);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(69, 13);
            this.label45.TabIndex = 4;
            this.label45.Text = "Win / Lose : ";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tabControl2);
            this.tabPage5.ImageKey = "icon_mode.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(505, 429);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Mode";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage11);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage17);
            this.tabControl2.Location = new System.Drawing.Point(2, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(508, 429);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tabControl5);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(500, 403);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Adventure";
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage1);
            this.tabControl5.Controls.Add(this.tabPage15);
            this.tabControl5.Location = new System.Drawing.Point(-3, 0);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(508, 404);
            this.tabControl5.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox19);
            this.tabPage1.Controls.Add(this.groupBox23);
            this.tabPage1.Controls.Add(this.GB_WaitForKeys);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(500, 378);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Control";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.AD_EnableProfile1CheckBox);
            this.groupBox19.Controls.Add(this.AD_EnableProfile2CheckBox);
            this.groupBox19.Controls.Add(this.AD_EnableProfile3CheckBox);
            this.groupBox19.Location = new System.Drawing.Point(8, 127);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(486, 51);
            this.groupBox19.TabIndex = 21;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Stop Bot When..";
            // 
            // AD_EnableProfile1CheckBox
            // 
            this.AD_EnableProfile1CheckBox.AutoSize = true;
            this.AD_EnableProfile1CheckBox.Location = new System.Drawing.Point(6, 23);
            this.AD_EnableProfile1CheckBox.Name = "AD_EnableProfile1CheckBox";
            this.AD_EnableProfile1CheckBox.Size = new System.Drawing.Size(97, 17);
            this.AD_EnableProfile1CheckBox.TabIndex = 31;
            this.AD_EnableProfile1CheckBox.Text = "Boost 100/100";
            this.AD_EnableProfile1CheckBox.UseVisualStyleBackColor = true;
            this.AD_EnableProfile1CheckBox.CheckedChanged += new System.EventHandler(this.AD_EnableProfile1CheckBox_CheckedChanged);
            // 
            // AD_EnableProfile2CheckBox
            // 
            this.AD_EnableProfile2CheckBox.AutoSize = true;
            this.AD_EnableProfile2CheckBox.Location = new System.Drawing.Point(196, 23);
            this.AD_EnableProfile2CheckBox.Name = "AD_EnableProfile2CheckBox";
            this.AD_EnableProfile2CheckBox.Size = new System.Drawing.Size(84, 17);
            this.AD_EnableProfile2CheckBox.TabIndex = 30;
            this.AD_EnableProfile2CheckBox.Text = "Hottime End";
            this.AD_EnableProfile2CheckBox.UseVisualStyleBackColor = true;
            this.AD_EnableProfile2CheckBox.CheckedChanged += new System.EventHandler(this.AD_EnableProfile2CheckBox_CheckedChanged);
            // 
            // AD_EnableProfile3CheckBox
            // 
            this.AD_EnableProfile3CheckBox.AutoSize = true;
            this.AD_EnableProfile3CheckBox.Location = new System.Drawing.Point(372, 23);
            this.AD_EnableProfile3CheckBox.Name = "AD_EnableProfile3CheckBox";
            this.AD_EnableProfile3CheckBox.Size = new System.Drawing.Size(99, 17);
            this.AD_EnableProfile3CheckBox.TabIndex = 29;
            this.AD_EnableProfile3CheckBox.Text = "Adventure Limit";
            this.AD_EnableProfile3CheckBox.UseVisualStyleBackColor = true;
            this.AD_EnableProfile3CheckBox.CheckedChanged += new System.EventHandler(this.AD_EnableProfile3CheckBox_CheckedChanged);
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.AD_NoChangeModeCheckBox);
            this.groupBox23.Controls.Add(this.AD_EnHottime_Checkbox);
            this.groupBox23.Controls.Add(this.AD_NoHeroUp_Checkbox);
            this.groupBox23.Controls.Add(this.AD_limitLabel);
            this.groupBox23.Controls.Add(this.AD_limitNumericBox);
            this.groupBox23.Controls.Add(this.AD_limitCheckBox);
            this.groupBox23.Controls.Add(this.AD_enableCheckBox);
            this.groupBox23.Controls.Add(this.AD_StopOnFullItems_Checkbox);
            this.groupBox23.Controls.Add(this.AD_StopOnFullHeroes_Checkbox);
            this.groupBox23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox23.Location = new System.Drawing.Point(8, 6);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(486, 115);
            this.groupBox23.TabIndex = 0;
            this.groupBox23.TabStop = false;
            this.groupBox23.Enter += new System.EventHandler(this.groupBox23_Enter);
            // 
            // AD_NoChangeModeCheckBox
            // 
            this.AD_NoChangeModeCheckBox.AutoSize = true;
            this.AD_NoChangeModeCheckBox.Location = new System.Drawing.Point(6, 67);
            this.AD_NoChangeModeCheckBox.Name = "AD_NoChangeModeCheckBox";
            this.AD_NoChangeModeCheckBox.Size = new System.Drawing.Size(233, 17);
            this.AD_NoChangeModeCheckBox.TabIndex = 28;
            this.AD_NoChangeModeCheckBox.Text = "No Change Mode After Adv Sequence Limit";
            this.AD_NoChangeModeCheckBox.UseVisualStyleBackColor = true;
            this.AD_NoChangeModeCheckBox.CheckedChanged += new System.EventHandler(this.AD_NoChangeModeCheckBox_CheckedChanged);
            // 
            // AD_EnHottime_Checkbox
            // 
            this.AD_EnHottime_Checkbox.AutoSize = true;
            this.AD_EnHottime_Checkbox.Location = new System.Drawing.Point(6, 21);
            this.AD_EnHottime_Checkbox.Name = "AD_EnHottime_Checkbox";
            this.AD_EnHottime_Checkbox.Size = new System.Drawing.Size(95, 17);
            this.AD_EnHottime_Checkbox.TabIndex = 27;
            this.AD_EnHottime_Checkbox.Text = "Active Hottime";
            this.AD_EnHottime_Checkbox.UseVisualStyleBackColor = true;
            this.AD_EnHottime_Checkbox.CheckedChanged += new System.EventHandler(this.AD_EnHottime_Checkbox_CheckedChanged);
            // 
            // AD_NoHeroUp_Checkbox
            // 
            this.AD_NoHeroUp_Checkbox.AutoSize = true;
            this.AD_NoHeroUp_Checkbox.Location = new System.Drawing.Point(6, 44);
            this.AD_NoHeroUp_Checkbox.Name = "AD_NoHeroUp_Checkbox";
            this.AD_NoHeroUp_Checkbox.Size = new System.Drawing.Size(245, 17);
            this.AD_NoHeroUp_Checkbox.TabIndex = 4;
            this.AD_NoHeroUp_Checkbox.Text = "Pause when there are no more hero to replace";
            this.AD_NoHeroUp_Checkbox.UseVisualStyleBackColor = true;
            this.AD_NoHeroUp_Checkbox.CheckedChanged += new System.EventHandler(this.AD_NoHeroUp_Checkbox_CheckedChanged);
            // 
            // AD_limitLabel
            // 
            this.AD_limitLabel.AutoSize = true;
            this.AD_limitLabel.Location = new System.Drawing.Point(379, 23);
            this.AD_limitLabel.Name = "AD_limitLabel";
            this.AD_limitLabel.Size = new System.Drawing.Size(70, 13);
            this.AD_limitLabel.TabIndex = 16;
            this.AD_limitLabel.Text = "times per visit";
            // 
            // AD_limitNumericBox
            // 
            this.AD_limitNumericBox.Location = new System.Drawing.Point(324, 20);
            this.AD_limitNumericBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.AD_limitNumericBox.Name = "AD_limitNumericBox";
            this.AD_limitNumericBox.Size = new System.Drawing.Size(49, 20);
            this.AD_limitNumericBox.TabIndex = 15;
            this.AD_limitNumericBox.Tag = "0";
            this.AD_limitNumericBox.ValueChanged += new System.EventHandler(this.limitNumericBox_ValueChanged);
            // 
            // AD_limitCheckBox
            // 
            this.AD_limitCheckBox.Location = new System.Drawing.Point(274, 22);
            this.AD_limitCheckBox.Name = "AD_limitCheckBox";
            this.AD_limitCheckBox.Size = new System.Drawing.Size(47, 17);
            this.AD_limitCheckBox.TabIndex = 14;
            this.AD_limitCheckBox.Tag = "0";
            this.AD_limitCheckBox.Text = "Limit";
            this.AD_limitCheckBox.UseVisualStyleBackColor = true;
            this.AD_limitCheckBox.CheckedChanged += new System.EventHandler(this.limitCheckBox_CheckedChanged);
            // 
            // AD_enableCheckBox
            // 
            this.AD_enableCheckBox.AutoSize = true;
            this.AD_enableCheckBox.Checked = true;
            this.AD_enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AD_enableCheckBox.Location = new System.Drawing.Point(6, 0);
            this.AD_enableCheckBox.Name = "AD_enableCheckBox";
            this.AD_enableCheckBox.Size = new System.Drawing.Size(111, 17);
            this.AD_enableCheckBox.TabIndex = 1;
            this.AD_enableCheckBox.Tag = "0";
            this.AD_enableCheckBox.Text = "Enable Adventure";
            this.AD_enableCheckBox.UseVisualStyleBackColor = true;
            this.AD_enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // AD_StopOnFullItems_Checkbox
            // 
            this.AD_StopOnFullItems_Checkbox.AutoSize = true;
            this.AD_StopOnFullItems_Checkbox.Location = new System.Drawing.Point(274, 66);
            this.AD_StopOnFullItems_Checkbox.Name = "AD_StopOnFullItems_Checkbox";
            this.AD_StopOnFullItems_Checkbox.Size = new System.Drawing.Size(120, 17);
            this.AD_StopOnFullItems_Checkbox.TabIndex = 25;
            this.AD_StopOnFullItems_Checkbox.Text = "Pause On Full Items";
            this.AD_StopOnFullItems_Checkbox.UseVisualStyleBackColor = true;
            this.AD_StopOnFullItems_Checkbox.CheckedChanged += new System.EventHandler(this.AD_StopOnFullItems_Checkbox_CheckedChanged);
            // 
            // AD_StopOnFullHeroes_Checkbox
            // 
            this.AD_StopOnFullHeroes_Checkbox.AutoSize = true;
            this.AD_StopOnFullHeroes_Checkbox.Location = new System.Drawing.Point(274, 43);
            this.AD_StopOnFullHeroes_Checkbox.Name = "AD_StopOnFullHeroes_Checkbox";
            this.AD_StopOnFullHeroes_Checkbox.Size = new System.Drawing.Size(112, 17);
            this.AD_StopOnFullHeroes_Checkbox.TabIndex = 25;
            this.AD_StopOnFullHeroes_Checkbox.Text = "Pause Full Heroes";
            this.AD_StopOnFullHeroes_Checkbox.UseVisualStyleBackColor = true;
            this.AD_StopOnFullHeroes_Checkbox.CheckedChanged += new System.EventHandler(this.AD_StopOnFullHeroes_Checkbox_CheckedChanged);
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.groupBox5);
            this.tabPage15.Controls.Add(this.ADCH_ChangeHeroGroupBox);
            this.tabPage15.Controls.Add(this.groupBox26);
            this.tabPage15.Controls.Add(this.groupBox27);
            this.tabPage15.Location = new System.Drawing.Point(4, 22);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(500, 378);
            this.tabPage15.TabIndex = 0;
            this.tabPage15.Text = "Adventure Option";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.AD_BoostModeSequenceRadio);
            this.groupBox5.Controls.Add(this.AD_BoostModeAllMapsRadio);
            this.groupBox5.Controls.Add(this.AD_BoostModeAsgarRadio);
            this.groupBox5.Controls.Add(this.AD_bootmodeCheckBox);
            this.groupBox5.Location = new System.Drawing.Point(229, 141);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(251, 84);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            // 
            // AD_BoostModeSequenceRadio
            // 
            this.AD_BoostModeSequenceRadio.AutoSize = true;
            this.AD_BoostModeSequenceRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AD_BoostModeSequenceRadio.Location = new System.Drawing.Point(12, 48);
            this.AD_BoostModeSequenceRadio.Name = "AD_BoostModeSequenceRadio";
            this.AD_BoostModeSequenceRadio.Size = new System.Drawing.Size(103, 17);
            this.AD_BoostModeSequenceRadio.TabIndex = 31;
            this.AD_BoostModeSequenceRadio.TabStop = true;
            this.AD_BoostModeSequenceRadio.Text = "Boost Sequence";
            this.AD_BoostModeSequenceRadio.UseVisualStyleBackColor = true;
            this.AD_BoostModeSequenceRadio.CheckedChanged += new System.EventHandler(this.AD_BoostModeSequenceRadio_CheckedChanged);
            // 
            // AD_BoostModeAllMapsRadio
            // 
            this.AD_BoostModeAllMapsRadio.AutoSize = true;
            this.AD_BoostModeAllMapsRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AD_BoostModeAllMapsRadio.Location = new System.Drawing.Point(102, 25);
            this.AD_BoostModeAllMapsRadio.Name = "AD_BoostModeAllMapsRadio";
            this.AD_BoostModeAllMapsRadio.Size = new System.Drawing.Size(64, 17);
            this.AD_BoostModeAllMapsRadio.TabIndex = 30;
            this.AD_BoostModeAllMapsRadio.TabStop = true;
            this.AD_BoostModeAllMapsRadio.Text = "All Maps";
            this.AD_BoostModeAllMapsRadio.UseVisualStyleBackColor = true;
            this.AD_BoostModeAllMapsRadio.CheckedChanged += new System.EventHandler(this.AD_BoostModeAllMapsRadio_CheckedChanged);
            // 
            // AD_BoostModeAsgarRadio
            // 
            this.AD_BoostModeAsgarRadio.AutoSize = true;
            this.AD_BoostModeAsgarRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AD_BoostModeAsgarRadio.Location = new System.Drawing.Point(12, 25);
            this.AD_BoostModeAsgarRadio.Name = "AD_BoostModeAsgarRadio";
            this.AD_BoostModeAsgarRadio.Size = new System.Drawing.Size(75, 17);
            this.AD_BoostModeAsgarRadio.TabIndex = 29;
            this.AD_BoostModeAsgarRadio.TabStop = true;
            this.AD_BoostModeAsgarRadio.Text = "Asgar Only";
            this.AD_BoostModeAsgarRadio.UseVisualStyleBackColor = true;
            this.AD_BoostModeAsgarRadio.CheckedChanged += new System.EventHandler(this.AD_BoostModeAsgarRadio_CheckedChanged);
            // 
            // AD_bootmodeCheckBox
            // 
            this.AD_bootmodeCheckBox.AutoSize = true;
            this.AD_bootmodeCheckBox.Location = new System.Drawing.Point(12, 0);
            this.AD_bootmodeCheckBox.Name = "AD_bootmodeCheckBox";
            this.AD_bootmodeCheckBox.Size = new System.Drawing.Size(119, 17);
            this.AD_bootmodeCheckBox.TabIndex = 28;
            this.AD_bootmodeCheckBox.Text = "Enable Boost Mode";
            this.AD_bootmodeCheckBox.UseVisualStyleBackColor = true;
            this.AD_bootmodeCheckBox.CheckedChanged += new System.EventHandler(this.AD_bootmodeCheckBox_CheckedChanged);
            // 
            // ADCH_ChangeHeroGroupBox
            // 
            this.ADCH_ChangeHeroGroupBox.Controls.Add(this.label3);
            this.ADCH_ChangeHeroGroupBox.Controls.Add(this.AD_teamLabel);
            this.ADCH_ChangeHeroGroupBox.Controls.Add(this.AD_teamComboBox2);
            this.ADCH_ChangeHeroGroupBox.Controls.Add(this.AD_teamComboBox);
            this.ADCH_ChangeHeroGroupBox.Location = new System.Drawing.Point(223, 6);
            this.ADCH_ChangeHeroGroupBox.Name = "ADCH_ChangeHeroGroupBox";
            this.ADCH_ChangeHeroGroupBox.Size = new System.Drawing.Size(266, 90);
            this.ADCH_ChangeHeroGroupBox.TabIndex = 18;
            this.ADCH_ChangeHeroGroupBox.TabStop = false;
            this.ADCH_ChangeHeroGroupBox.Text = "Change Hero Setting";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 30);
            this.label3.TabIndex = 29;
            this.label3.Text = "Team (Map 13)";
            this.label3.Visible = false;
            // 
            // AD_teamLabel
            // 
            this.AD_teamLabel.Location = new System.Drawing.Point(9, 24);
            this.AD_teamLabel.Name = "AD_teamLabel";
            this.AD_teamLabel.Size = new System.Drawing.Size(62, 13);
            this.AD_teamLabel.TabIndex = 8;
            this.AD_teamLabel.Text = "Team";
            // 
            // AD_teamComboBox2
            // 
            this.AD_teamComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_teamComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AD_teamComboBox2.FormattingEnabled = true;
            this.AD_teamComboBox2.Items.AddRange(new object[] {
            "--",
            "A",
            "B",
            "C"});
            this.AD_teamComboBox2.Location = new System.Drawing.Point(77, 51);
            this.AD_teamComboBox2.Name = "AD_teamComboBox2";
            this.AD_teamComboBox2.Size = new System.Drawing.Size(52, 21);
            this.AD_teamComboBox2.TabIndex = 28;
            this.AD_teamComboBox2.Tag = "0";
            this.AD_teamComboBox2.Visible = false;
            this.AD_teamComboBox2.SelectedIndexChanged += new System.EventHandler(this.AD_teamComboBox2_SelectedIndexChanged);
            // 
            // AD_teamComboBox
            // 
            this.AD_teamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_teamComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AD_teamComboBox.FormattingEnabled = true;
            this.AD_teamComboBox.Items.AddRange(new object[] {
            "--",
            "A",
            "B",
            "C"});
            this.AD_teamComboBox.Location = new System.Drawing.Point(77, 22);
            this.AD_teamComboBox.Name = "AD_teamComboBox";
            this.AD_teamComboBox.Size = new System.Drawing.Size(52, 21);
            this.AD_teamComboBox.TabIndex = 9;
            this.AD_teamComboBox.Tag = "0";
            this.AD_teamComboBox.SelectedIndexChanged += new System.EventHandler(this.teamComboBox_SelectedIndexChanged);
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.AD_UseFriendCheckBox);
            this.groupBox26.Location = new System.Drawing.Point(223, 101);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(263, 140);
            this.groupBox26.TabIndex = 1;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Other Setting";
            // 
            // AD_UseFriendCheckBox
            // 
            this.AD_UseFriendCheckBox.AutoSize = true;
            this.AD_UseFriendCheckBox.Location = new System.Drawing.Point(6, 17);
            this.AD_UseFriendCheckBox.Name = "AD_UseFriendCheckBox";
            this.AD_UseFriendCheckBox.Size = new System.Drawing.Size(118, 17);
            this.AD_UseFriendCheckBox.TabIndex = 28;
            this.AD_UseFriendCheckBox.Text = "Always Use Friends";
            this.AD_UseFriendCheckBox.UseVisualStyleBackColor = true;
            this.AD_UseFriendCheckBox.CheckedChanged += new System.EventHandler(this.AD_UseFriendCheckBox_CheckedChanged);
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.AD_difficultyComboBox2nd);
            this.groupBox27.Controls.Add(this.AD_difficultyLabel);
            this.groupBox27.Controls.Add(this.label1);
            this.groupBox27.Controls.Add(this.AD_difficultyComboBox);
            this.groupBox27.Controls.Add(this.AD_worldLabel);
            this.groupBox27.Controls.Add(this.AD_stageLabel);
            this.groupBox27.Controls.Add(this.AD_worldComboBox);
            this.groupBox27.Controls.Add(this.AD_stageComboBox);
            this.groupBox27.Controls.Add(this.AD_sequenceButton);
            this.groupBox27.Controls.Add(this.AD_continuousCheckBox);
            this.groupBox27.Location = new System.Drawing.Point(6, 6);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(211, 235);
            this.groupBox27.TabIndex = 0;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Map Setting";
            // 
            // AD_difficultyLabel
            // 
            this.AD_difficultyLabel.Location = new System.Drawing.Point(6, 139);
            this.AD_difficultyLabel.Name = "AD_difficultyLabel";
            this.AD_difficultyLabel.Size = new System.Drawing.Size(54, 13);
            this.AD_difficultyLabel.TabIndex = 6;
            this.AD_difficultyLabel.Text = "Difficulty";
            this.AD_difficultyLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Difficulty (Map 8+)";
            // 
            // AD_worldLabel
            // 
            this.AD_worldLabel.Location = new System.Drawing.Point(6, 19);
            this.AD_worldLabel.Name = "AD_worldLabel";
            this.AD_worldLabel.Size = new System.Drawing.Size(62, 13);
            this.AD_worldLabel.TabIndex = 0;
            this.AD_worldLabel.Text = "World";
            // 
            // AD_stageLabel
            // 
            this.AD_stageLabel.Location = new System.Drawing.Point(6, 51);
            this.AD_stageLabel.Name = "AD_stageLabel";
            this.AD_stageLabel.Size = new System.Drawing.Size(62, 13);
            this.AD_stageLabel.TabIndex = 2;
            this.AD_stageLabel.Text = "Stage";
            // 
            // AD_worldComboBox
            // 
            this.AD_worldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_worldComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AD_worldComboBox.FormattingEnabled = true;
            this.AD_worldComboBox.Items.AddRange(new object[] {
            "-- Quick Start",
            "-- Sequencer",
            "1 - Mystic Woods",
            "2 - Silent Mine",
            "3 - Blazing Desert",
            "4 - Dark Grave",
            "5 - Dragon Ruins",
            "6 - Frozen Land",
            "7 - Purgatory",
            "8 - Moonlit Isle",
            "9 - Western Empire",
            "10 - Eastern Empire",
            "11 - Dark Sanctuary",
            "12 - Shadow\'s Eye",
            "13 - Heavenly Stairs"});
            this.AD_worldComboBox.Location = new System.Drawing.Point(69, 16);
            this.AD_worldComboBox.Name = "AD_worldComboBox";
            this.AD_worldComboBox.Size = new System.Drawing.Size(127, 21);
            this.AD_worldComboBox.TabIndex = 1;
            this.AD_worldComboBox.SelectedIndexChanged += new System.EventHandler(this.AD_worldComboBox_SelectedIndexChanged);
            // 
            // AD_stageComboBox
            // 
            this.AD_stageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_stageComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AD_stageComboBox.FormattingEnabled = true;
            this.AD_stageComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.AD_stageComboBox.Location = new System.Drawing.Point(70, 46);
            this.AD_stageComboBox.Name = "AD_stageComboBox";
            this.AD_stageComboBox.Size = new System.Drawing.Size(52, 21);
            this.AD_stageComboBox.TabIndex = 3;
            this.AD_stageComboBox.SelectedIndexChanged += new System.EventHandler(this.AD_stageComboBox_SelectedIndexChanged);
            // 
            // AD_sequenceButton
            // 
            this.AD_sequenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AD_sequenceButton.Location = new System.Drawing.Point(128, 47);
            this.AD_sequenceButton.Name = "AD_sequenceButton";
            this.AD_sequenceButton.Size = new System.Drawing.Size(69, 23);
            this.AD_sequenceButton.TabIndex = 4;
            this.AD_sequenceButton.Text = "Sequence";
            this.AD_sequenceButton.UseVisualStyleBackColor = true;
            this.AD_sequenceButton.Click += new System.EventHandler(this.AD_sequenceButton_Click);
            // 
            // AD_continuousCheckBox
            // 
            this.AD_continuousCheckBox.AutoSize = true;
            this.AD_continuousCheckBox.Location = new System.Drawing.Point(70, 73);
            this.AD_continuousCheckBox.Name = "AD_continuousCheckBox";
            this.AD_continuousCheckBox.Size = new System.Drawing.Size(128, 17);
            this.AD_continuousCheckBox.TabIndex = 5;
            this.AD_continuousCheckBox.Text = "Progress to next zone";
            this.AD_continuousCheckBox.UseVisualStyleBackColor = true;
            this.AD_continuousCheckBox.CheckedChanged += new System.EventHandler(this.AD_continuousCheckBox_CheckedChanged);
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.SM_EnableCheckBox);
            this.tabPage11.Controls.Add(this.groupBox11);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(500, 403);
            this.tabPage11.TabIndex = 8;
            this.tabPage11.Text = "Smart Mode";
            // 
            // SM_EnableCheckBox
            // 
            this.SM_EnableCheckBox.AutoSize = true;
            this.SM_EnableCheckBox.Location = new System.Drawing.Point(6, 15);
            this.SM_EnableCheckBox.Name = "SM_EnableCheckBox";
            this.SM_EnableCheckBox.Size = new System.Drawing.Size(119, 17);
            this.SM_EnableCheckBox.TabIndex = 4;
            this.SM_EnableCheckBox.Text = "Enable Smart Mode";
            this.SM_EnableCheckBox.UseVisualStyleBackColor = true;
            this.SM_EnableCheckBox.CheckedChanged += new System.EventHandler(this.SM_EnableCheckBox_CheckedChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.SM_CollectTartarusCheckBox);
            this.groupBox11.Controls.Add(this.SM_CollectRaidCheckBox);
            this.groupBox11.Controls.Add(this.SM_CollectTowerCheckBox);
            this.groupBox11.Location = new System.Drawing.Point(6, 140);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(486, 68);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Visible = false;
            // 
            // SM_CollectTartarusCheckBox
            // 
            this.SM_CollectTartarusCheckBox.AutoSize = true;
            this.SM_CollectTartarusCheckBox.Location = new System.Drawing.Point(6, 34);
            this.SM_CollectTartarusCheckBox.Name = "SM_CollectTartarusCheckBox";
            this.SM_CollectTartarusCheckBox.Size = new System.Drawing.Size(100, 17);
            this.SM_CollectTartarusCheckBox.TabIndex = 3;
            this.SM_CollectTartarusCheckBox.Tag = "1";
            this.SM_CollectTartarusCheckBox.Text = "Collect Tartarus";
            this.SM_CollectTartarusCheckBox.UseVisualStyleBackColor = true;
            this.SM_CollectTartarusCheckBox.CheckedChanged += new System.EventHandler(this.SM_CollectTartarusCheckBox_CheckedChanged);
            // 
            // SM_CollectRaidCheckBox
            // 
            this.SM_CollectRaidCheckBox.AutoSize = true;
            this.SM_CollectRaidCheckBox.Location = new System.Drawing.Point(252, 34);
            this.SM_CollectRaidCheckBox.Name = "SM_CollectRaidCheckBox";
            this.SM_CollectRaidCheckBox.Size = new System.Drawing.Size(83, 17);
            this.SM_CollectRaidCheckBox.TabIndex = 2;
            this.SM_CollectRaidCheckBox.Tag = "1";
            this.SM_CollectRaidCheckBox.Text = "Collect Raid";
            this.SM_CollectRaidCheckBox.UseVisualStyleBackColor = true;
            this.SM_CollectRaidCheckBox.CheckedChanged += new System.EventHandler(this.SM_CollectRaidCheckBox_CheckedChanged);
            // 
            // SM_CollectTowerCheckBox
            // 
            this.SM_CollectTowerCheckBox.AutoSize = true;
            this.SM_CollectTowerCheckBox.Location = new System.Drawing.Point(112, 34);
            this.SM_CollectTowerCheckBox.Name = "SM_CollectTowerCheckBox";
            this.SM_CollectTowerCheckBox.Size = new System.Drawing.Size(133, 17);
            this.SM_CollectTowerCheckBox.TabIndex = 1;
            this.SM_CollectTowerCheckBox.Tag = "1";
            this.SM_CollectTowerCheckBox.Text = "Collect Celestial Tower";
            this.SM_CollectTowerCheckBox.UseVisualStyleBackColor = true;
            this.SM_CollectTowerCheckBox.CheckedChanged += new System.EventHandler(this.SM_CollectTowerCheckBox_CheckedChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox29);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(500, 403);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Arena";
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.AR_enableCheckBox);
            this.groupBox29.Controls.Add(this.AR_limitLabel);
            this.groupBox29.Controls.Add(this.AR_stopArenaCheckBox);
            this.groupBox29.Controls.Add(this.label18);
            this.groupBox29.Controls.Add(this.AR_limitNumericBox);
            this.groupBox29.Controls.Add(this.AR_useRubyCheckBox);
            this.groupBox29.Controls.Add(this.AR_limitCheckBox);
            this.groupBox29.Controls.Add(this.AR_useRubyLabel);
            this.groupBox29.Controls.Add(this.AR_useRubyNumericBox);
            this.groupBox29.Controls.Add(this.AR_stopArenaNumericBox);
            this.groupBox29.Controls.Add(this.GC_formationPanel);
            this.groupBox29.Controls.Add(this.GC_teamComboBox);
            this.groupBox29.Location = new System.Drawing.Point(6, 5);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(488, 142);
            this.groupBox29.TabIndex = 0;
            this.groupBox29.TabStop = false;
            // 
            // AR_enableCheckBox
            // 
            this.AR_enableCheckBox.AutoSize = true;
            this.AR_enableCheckBox.Checked = true;
            this.AR_enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AR_enableCheckBox.Location = new System.Drawing.Point(6, 0);
            this.AR_enableCheckBox.Name = "AR_enableCheckBox";
            this.AR_enableCheckBox.Size = new System.Drawing.Size(90, 17);
            this.AR_enableCheckBox.TabIndex = 1;
            this.AR_enableCheckBox.Tag = "2";
            this.AR_enableCheckBox.Text = "Enable Arena";
            this.AR_enableCheckBox.UseVisualStyleBackColor = true;
            this.AR_enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // AR_limitLabel
            // 
            this.AR_limitLabel.AutoSize = true;
            this.AR_limitLabel.Location = new System.Drawing.Point(102, 25);
            this.AR_limitLabel.Name = "AR_limitLabel";
            this.AR_limitLabel.Size = new System.Drawing.Size(70, 13);
            this.AR_limitLabel.TabIndex = 22;
            this.AR_limitLabel.Text = "times per visit";
            // 
            // AR_stopArenaCheckBox
            // 
            this.AR_stopArenaCheckBox.AutoSize = true;
            this.AR_stopArenaCheckBox.Location = new System.Drawing.Point(6, 72);
            this.AR_stopArenaCheckBox.Name = "AR_stopArenaCheckBox";
            this.AR_stopArenaCheckBox.Size = new System.Drawing.Size(111, 17);
            this.AR_stopArenaCheckBox.TabIndex = 0;
            this.AR_stopArenaCheckBox.Text = "Stop Arena When";
            this.AR_stopArenaCheckBox.UseVisualStyleBackColor = true;
            this.AR_stopArenaCheckBox.CheckedChanged += new System.EventHandler(this.AR_stopArenaCheckBox_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(177, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "pts";
            // 
            // AR_limitNumericBox
            // 
            this.AR_limitNumericBox.Location = new System.Drawing.Point(59, 21);
            this.AR_limitNumericBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.AR_limitNumericBox.Name = "AR_limitNumericBox";
            this.AR_limitNumericBox.Size = new System.Drawing.Size(37, 20);
            this.AR_limitNumericBox.TabIndex = 21;
            this.AR_limitNumericBox.Tag = "2";
            this.AR_limitNumericBox.ValueChanged += new System.EventHandler(this.limitNumericBox_ValueChanged);
            // 
            // AR_useRubyCheckBox
            // 
            this.AR_useRubyCheckBox.AutoSize = true;
            this.AR_useRubyCheckBox.Location = new System.Drawing.Point(6, 47);
            this.AR_useRubyCheckBox.Name = "AR_useRubyCheckBox";
            this.AR_useRubyCheckBox.Size = new System.Drawing.Size(107, 17);
            this.AR_useRubyCheckBox.TabIndex = 0;
            this.AR_useRubyCheckBox.Text = "Enter using Ruby";
            this.AR_useRubyCheckBox.UseVisualStyleBackColor = true;
            this.AR_useRubyCheckBox.CheckedChanged += new System.EventHandler(this.AR_useRubyCheckBox_CheckedChanged);
            // 
            // AR_limitCheckBox
            // 
            this.AR_limitCheckBox.Location = new System.Drawing.Point(6, 24);
            this.AR_limitCheckBox.Name = "AR_limitCheckBox";
            this.AR_limitCheckBox.Size = new System.Drawing.Size(47, 17);
            this.AR_limitCheckBox.TabIndex = 20;
            this.AR_limitCheckBox.Tag = "2";
            this.AR_limitCheckBox.Text = "Limit";
            this.AR_limitCheckBox.UseVisualStyleBackColor = true;
            this.AR_limitCheckBox.CheckedChanged += new System.EventHandler(this.limitCheckBox_CheckedChanged);
            // 
            // AR_useRubyLabel
            // 
            this.AR_useRubyLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AR_useRubyLabel.AutoSize = true;
            this.AR_useRubyLabel.Location = new System.Drawing.Point(157, 48);
            this.AR_useRubyLabel.Name = "AR_useRubyLabel";
            this.AR_useRubyLabel.Size = new System.Drawing.Size(31, 13);
            this.AR_useRubyLabel.TabIndex = 12;
            this.AR_useRubyLabel.Text = "times";
            // 
            // AR_useRubyNumericBox
            // 
            this.AR_useRubyNumericBox.Location = new System.Drawing.Point(116, 45);
            this.AR_useRubyNumericBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.AR_useRubyNumericBox.Name = "AR_useRubyNumericBox";
            this.AR_useRubyNumericBox.Size = new System.Drawing.Size(37, 20);
            this.AR_useRubyNumericBox.TabIndex = 11;
            this.AR_useRubyNumericBox.ValueChanged += new System.EventHandler(this.AR_useRubyNumericBox_ValueChanged);
            // 
            // AR_stopArenaNumericBox
            // 
            this.AR_stopArenaNumericBox.Location = new System.Drawing.Point(120, 71);
            this.AR_stopArenaNumericBox.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.AR_stopArenaNumericBox.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AR_stopArenaNumericBox.Name = "AR_stopArenaNumericBox";
            this.AR_stopArenaNumericBox.Size = new System.Drawing.Size(51, 20);
            this.AR_stopArenaNumericBox.TabIndex = 11;
            this.AR_stopArenaNumericBox.Value = new decimal(new int[] {
            4300,
            0,
            0,
            0});
            this.AR_stopArenaNumericBox.ValueChanged += new System.EventHandler(this.AR_stopArenaNumericBox_ValueChanged);
            // 
            // GC_formationPanel
            // 
            this.GC_formationPanel.BackColor = System.Drawing.Color.Silver;
            this.GC_formationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GC_formationPanel.Controls.Add(this.GC_pos5CheckBox);
            this.GC_formationPanel.Controls.Add(this.GC_pos4CheckBox);
            this.GC_formationPanel.Controls.Add(this.GC_pos3CheckBox);
            this.GC_formationPanel.Controls.Add(this.GC_pos2CheckBox);
            this.GC_formationPanel.Controls.Add(this.GC_pos1CheckBox);
            this.GC_formationPanel.Location = new System.Drawing.Point(118, 238);
            this.GC_formationPanel.Name = "GC_formationPanel";
            this.GC_formationPanel.Size = new System.Drawing.Size(80, 85);
            this.GC_formationPanel.TabIndex = 4;
            this.GC_formationPanel.Tag = "1";
            this.GC_formationPanel.Visible = false;
            // 
            // GC_pos5CheckBox
            // 
            this.GC_pos5CheckBox.AutoSize = true;
            this.GC_pos5CheckBox.Enabled = false;
            this.GC_pos5CheckBox.Location = new System.Drawing.Point(3, 61);
            this.GC_pos5CheckBox.Name = "GC_pos5CheckBox";
            this.GC_pos5CheckBox.Size = new System.Drawing.Size(15, 14);
            this.GC_pos5CheckBox.TabIndex = 4;
            this.GC_pos5CheckBox.Tag = "4";
            this.GC_pos5CheckBox.UseVisualStyleBackColor = true;
            this.GC_pos5CheckBox.Visible = false;
            // 
            // GC_pos4CheckBox
            // 
            this.GC_pos4CheckBox.AutoSize = true;
            this.GC_pos4CheckBox.Enabled = false;
            this.GC_pos4CheckBox.Location = new System.Drawing.Point(3, 48);
            this.GC_pos4CheckBox.Name = "GC_pos4CheckBox";
            this.GC_pos4CheckBox.Size = new System.Drawing.Size(15, 14);
            this.GC_pos4CheckBox.TabIndex = 3;
            this.GC_pos4CheckBox.Tag = "3";
            this.GC_pos4CheckBox.UseVisualStyleBackColor = true;
            this.GC_pos4CheckBox.Visible = false;
            // 
            // GC_pos3CheckBox
            // 
            this.GC_pos3CheckBox.AutoSize = true;
            this.GC_pos3CheckBox.Enabled = false;
            this.GC_pos3CheckBox.Location = new System.Drawing.Point(3, 35);
            this.GC_pos3CheckBox.Name = "GC_pos3CheckBox";
            this.GC_pos3CheckBox.Size = new System.Drawing.Size(15, 14);
            this.GC_pos3CheckBox.TabIndex = 2;
            this.GC_pos3CheckBox.Tag = "2";
            this.GC_pos3CheckBox.UseVisualStyleBackColor = true;
            this.GC_pos3CheckBox.Visible = false;
            // 
            // GC_pos2CheckBox
            // 
            this.GC_pos2CheckBox.AutoSize = true;
            this.GC_pos2CheckBox.Enabled = false;
            this.GC_pos2CheckBox.Location = new System.Drawing.Point(3, 22);
            this.GC_pos2CheckBox.Name = "GC_pos2CheckBox";
            this.GC_pos2CheckBox.Size = new System.Drawing.Size(15, 14);
            this.GC_pos2CheckBox.TabIndex = 1;
            this.GC_pos2CheckBox.Tag = "1";
            this.GC_pos2CheckBox.UseVisualStyleBackColor = true;
            this.GC_pos2CheckBox.Visible = false;
            // 
            // GC_pos1CheckBox
            // 
            this.GC_pos1CheckBox.AutoSize = true;
            this.GC_pos1CheckBox.Enabled = false;
            this.GC_pos1CheckBox.Location = new System.Drawing.Point(3, 9);
            this.GC_pos1CheckBox.Name = "GC_pos1CheckBox";
            this.GC_pos1CheckBox.Size = new System.Drawing.Size(15, 14);
            this.GC_pos1CheckBox.TabIndex = 0;
            this.GC_pos1CheckBox.Tag = "0";
            this.GC_pos1CheckBox.UseVisualStyleBackColor = true;
            this.GC_pos1CheckBox.Visible = false;
            // 
            // GC_teamComboBox
            // 
            this.GC_teamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GC_teamComboBox.Enabled = false;
            this.GC_teamComboBox.FormattingEnabled = true;
            this.GC_teamComboBox.Items.AddRange(new object[] {
            "--",
            "A",
            "B",
            "C"});
            this.GC_teamComboBox.Location = new System.Drawing.Point(118, 179);
            this.GC_teamComboBox.Name = "GC_teamComboBox";
            this.GC_teamComboBox.Size = new System.Drawing.Size(52, 21);
            this.GC_teamComboBox.TabIndex = 2;
            this.GC_teamComboBox.Tag = "1";
            this.GC_teamComboBox.Visible = false;
            this.GC_teamComboBox.SelectedIndexChanged += new System.EventHandler(this.teamComboBox_SelectedIndexChanged);
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.tabControl3);
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Size = new System.Drawing.Size(500, 403);
            this.tabPage17.TabIndex = 5;
            this.tabPage17.Text = "Resources";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Controls.Add(this.tabPage9);
            this.tabControl3.Controls.Add(this.tabPage12);
            this.tabControl3.Location = new System.Drawing.Point(-3, -1);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(508, 404);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PU_enableActive3CheckBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.PU_Active1NumericBox);
            this.tabPage2.Controls.Add(this.PU_enableActive1CheckBox);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.PU_enableCheckbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(500, 378);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Auto Power Up";
            // 
            // PU_enableActive3CheckBox
            // 
            this.PU_enableActive3CheckBox.Location = new System.Drawing.Point(247, 31);
            this.PU_enableActive3CheckBox.Name = "PU_enableActive3CheckBox";
            this.PU_enableActive3CheckBox.Size = new System.Drawing.Size(230, 18);
            this.PU_enableActive3CheckBox.TabIndex = 21;
            this.PU_enableActive3CheckBox.Tag = "0";
            this.PU_enableActive3CheckBox.Text = "Activate When No More Hero to Level Up";
            this.PU_enableActive3CheckBox.UseVisualStyleBackColor = true;
            this.PU_enableActive3CheckBox.CheckedChanged += new System.EventHandler(this.PU_enableActive3CheckBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "times Adventure";
            // 
            // PU_Active1NumericBox
            // 
            this.PU_Active1NumericBox.Location = new System.Drawing.Point(347, 5);
            this.PU_Active1NumericBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.PU_Active1NumericBox.Name = "PU_Active1NumericBox";
            this.PU_Active1NumericBox.Size = new System.Drawing.Size(49, 20);
            this.PU_Active1NumericBox.TabIndex = 18;
            this.PU_Active1NumericBox.Tag = "0";
            this.PU_Active1NumericBox.ValueChanged += new System.EventHandler(this.PU_Active1NumericBox_ValueChanged);
            // 
            // PU_enableActive1CheckBox
            // 
            this.PU_enableActive1CheckBox.Location = new System.Drawing.Point(247, 7);
            this.PU_enableActive1CheckBox.Name = "PU_enableActive1CheckBox";
            this.PU_enableActive1CheckBox.Size = new System.Drawing.Size(94, 18);
            this.PU_enableActive1CheckBox.TabIndex = 17;
            this.PU_enableActive1CheckBox.Tag = "0";
            this.PU_enableActive1CheckBox.Text = "Activate After:";
            this.PU_enableActive1CheckBox.UseVisualStyleBackColor = true;
            this.PU_enableActive1CheckBox.CheckedChanged += new System.EventHandler(this.PU_enableActive1CheckBox_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox14);
            this.groupBox7.Controls.Add(this.groupBox15);
            this.groupBox7.Controls.Add(this.groupBox13);
            this.groupBox7.Controls.Add(this.groupBox12);
            this.groupBox7.Location = new System.Drawing.Point(6, 53);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(486, 322);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Auto Power Up Setting";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter_1);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.button6);
            this.groupBox14.Controls.Add(this.comboBox3);
            this.groupBox14.Controls.Add(this.PU_4MOnlyLv30CheckBox);
            this.groupBox14.Controls.Add(this.button5);
            this.groupBox14.Controls.Add(this.PU_4OnlyLv30CheckBox);
            this.groupBox14.Controls.Add(this.label6);
            this.groupBox14.Controls.Add(this.PU_4MaterialComboBox);
            this.groupBox14.Controls.Add(this.PU_enableActive2CheckBox);
            this.groupBox14.Controls.Add(this.PU_4StarCheckBox);
            this.groupBox14.Enabled = false;
            this.groupBox14.Location = new System.Drawing.Point(237, 173);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox14.Size = new System.Drawing.Size(242, 143);
            this.groupBox14.TabIndex = 10;
            this.groupBox14.TabStop = false;
            this.groupBox14.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(116, 107);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 24);
            this.button6.TabIndex = 21;
            this.button6.Text = "change to fuse";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "==",
            "<=",
            ">="});
            this.comboBox3.Location = new System.Drawing.Point(71, 41);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(38, 21);
            this.comboBox3.TabIndex = 12;
            // 
            // PU_4MOnlyLv30CheckBox
            // 
            this.PU_4MOnlyLv30CheckBox.AutoSize = true;
            this.PU_4MOnlyLv30CheckBox.Location = new System.Drawing.Point(6, 23);
            this.PU_4MOnlyLv30CheckBox.Name = "PU_4MOnlyLv30CheckBox";
            this.PU_4MOnlyLv30CheckBox.Size = new System.Drawing.Size(117, 17);
            this.PU_4MOnlyLv30CheckBox.TabIndex = 11;
            this.PU_4MOnlyLv30CheckBox.Text = "Material Only Lv 30";
            this.PU_4MOnlyLv30CheckBox.UseVisualStyleBackColor = true;
            this.PU_4MOnlyLv30CheckBox.CheckedChanged += new System.EventHandler(this.PU_4MOnlyLv30CheckBox_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 102);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 35);
            this.button5.TabIndex = 20;
            this.button5.Text = "change to powerup";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // PU_4OnlyLv30CheckBox
            // 
            this.PU_4OnlyLv30CheckBox.AutoSize = true;
            this.PU_4OnlyLv30CheckBox.Location = new System.Drawing.Point(9, 88);
            this.PU_4OnlyLv30CheckBox.Name = "PU_4OnlyLv30CheckBox";
            this.PU_4OnlyLv30CheckBox.Size = new System.Drawing.Size(103, 17);
            this.PU_4OnlyLv30CheckBox.TabIndex = 9;
            this.PU_4OnlyLv30CheckBox.Text = "Hero Only Lv 30";
            this.PU_4OnlyLv30CheckBox.UseVisualStyleBackColor = true;
            this.PU_4OnlyLv30CheckBox.Visible = false;
            this.PU_4OnlyLv30CheckBox.CheckedChanged += new System.EventHandler(this.PU_4OnlyLv30CheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Material";
            // 
            // PU_4MaterialComboBox
            // 
            this.PU_4MaterialComboBox.FormattingEnabled = true;
            this.PU_4MaterialComboBox.Items.AddRange(new object[] {
            "★",
            "★★",
            "★★★",
            "★★★★"});
            this.PU_4MaterialComboBox.Location = new System.Drawing.Point(116, 41);
            this.PU_4MaterialComboBox.Name = "PU_4MaterialComboBox";
            this.PU_4MaterialComboBox.Size = new System.Drawing.Size(122, 21);
            this.PU_4MaterialComboBox.TabIndex = 8;
            this.PU_4MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.PU_4MaterialComboBox_SelectedIndexChanged);
            // 
            // PU_enableActive2CheckBox
            // 
            this.PU_enableActive2CheckBox.Enabled = false;
            this.PU_enableActive2CheckBox.Location = new System.Drawing.Point(9, 68);
            this.PU_enableActive2CheckBox.Name = "PU_enableActive2CheckBox";
            this.PU_enableActive2CheckBox.Size = new System.Drawing.Size(175, 18);
            this.PU_enableActive2CheckBox.TabIndex = 20;
            this.PU_enableActive2CheckBox.Tag = "0";
            this.PU_enableActive2CheckBox.Text = "Activate When Hero Slot Full";
            this.PU_enableActive2CheckBox.UseVisualStyleBackColor = true;
            this.PU_enableActive2CheckBox.Visible = false;
            this.PU_enableActive2CheckBox.CheckedChanged += new System.EventHandler(this.PU_enableActive2CheckBox_CheckedChanged);
            // 
            // PU_4StarCheckBox
            // 
            this.PU_4StarCheckBox.AutoSize = true;
            this.PU_4StarCheckBox.Location = new System.Drawing.Point(6, 0);
            this.PU_4StarCheckBox.Name = "PU_4StarCheckBox";
            this.PU_4StarCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PU_4StarCheckBox.Size = new System.Drawing.Size(112, 17);
            this.PU_4StarCheckBox.TabIndex = 2;
            this.PU_4StarCheckBox.Text = "Power Up ★★★★";
            this.PU_4StarCheckBox.UseVisualStyleBackColor = true;
            this.PU_4StarCheckBox.CheckedChanged += new System.EventHandler(this.PU_4StarCheckBox_CheckedChanged);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.PU_3OrderComboBox);
            this.groupBox15.Controls.Add(this.PU_3OnlyLv30CheckBox);
            this.groupBox15.Controls.Add(this.label23);
            this.groupBox15.Controls.Add(this.PU_3ConditionComboBox);
            this.groupBox15.Controls.Add(this.PU_3MOnlyLv30CheckBox);
            this.groupBox15.Controls.Add(this.label7);
            this.groupBox15.Controls.Add(this.PU_3MaterialComboBox);
            this.groupBox15.Controls.Add(this.PU_3StarCheckBox);
            this.groupBox15.Location = new System.Drawing.Point(6, 143);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox15.Size = new System.Drawing.Size(225, 119);
            this.groupBox15.TabIndex = 9;
            this.groupBox15.TabStop = false;
            // 
            // PU_3OrderComboBox
            // 
            this.PU_3OrderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PU_3OrderComboBox.FormattingEnabled = true;
            this.PU_3OrderComboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.PU_3OrderComboBox.Location = new System.Drawing.Point(97, 76);
            this.PU_3OrderComboBox.Name = "PU_3OrderComboBox";
            this.PU_3OrderComboBox.Size = new System.Drawing.Size(122, 21);
            this.PU_3OrderComboBox.TabIndex = 16;
            this.PU_3OrderComboBox.SelectedIndexChanged += new System.EventHandler(this.PU_3OrderComboBox_SelectedIndexChanged);
            // 
            // PU_3OnlyLv30CheckBox
            // 
            this.PU_3OnlyLv30CheckBox.AutoSize = true;
            this.PU_3OnlyLv30CheckBox.Enabled = false;
            this.PU_3OnlyLv30CheckBox.Location = new System.Drawing.Point(119, 23);
            this.PU_3OnlyLv30CheckBox.Name = "PU_3OnlyLv30CheckBox";
            this.PU_3OnlyLv30CheckBox.Size = new System.Drawing.Size(100, 17);
            this.PU_3OnlyLv30CheckBox.TabIndex = 9;
            this.PU_3OnlyLv30CheckBox.Text = "Hero Only Lv30";
            this.PU_3OnlyLv30CheckBox.UseVisualStyleBackColor = true;
            this.PU_3OnlyLv30CheckBox.CheckedChanged += new System.EventHandler(this.PU_3OnlyLv30CheckBox_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 76);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 13);
            this.label23.TabIndex = 15;
            this.label23.Text = "Material order:";
            // 
            // PU_3ConditionComboBox
            // 
            this.PU_3ConditionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PU_3ConditionComboBox.FormattingEnabled = true;
            this.PU_3ConditionComboBox.Items.AddRange(new object[] {
            "==",
            "<=",
            ">="});
            this.PU_3ConditionComboBox.Location = new System.Drawing.Point(53, 46);
            this.PU_3ConditionComboBox.Name = "PU_3ConditionComboBox";
            this.PU_3ConditionComboBox.Size = new System.Drawing.Size(38, 21);
            this.PU_3ConditionComboBox.TabIndex = 12;
            this.PU_3ConditionComboBox.SelectedIndexChanged += new System.EventHandler(this.PU_3ConditionComboBox_SelectedIndexChanged);
            // 
            // PU_3MOnlyLv30CheckBox
            // 
            this.PU_3MOnlyLv30CheckBox.AutoSize = true;
            this.PU_3MOnlyLv30CheckBox.Location = new System.Drawing.Point(6, 23);
            this.PU_3MOnlyLv30CheckBox.Name = "PU_3MOnlyLv30CheckBox";
            this.PU_3MOnlyLv30CheckBox.Size = new System.Drawing.Size(114, 17);
            this.PU_3MOnlyLv30CheckBox.TabIndex = 11;
            this.PU_3MOnlyLv30CheckBox.Text = "Material Only Lv30";
            this.PU_3MOnlyLv30CheckBox.UseVisualStyleBackColor = true;
            this.PU_3MOnlyLv30CheckBox.CheckedChanged += new System.EventHandler(this.PU_3MOnlyLv30CheckBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Material";
            // 
            // PU_3MaterialComboBox
            // 
            this.PU_3MaterialComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PU_3MaterialComboBox.FormattingEnabled = true;
            this.PU_3MaterialComboBox.Items.AddRange(new object[] {
            "★",
            "★★",
            "★★★",
            "★★★★"});
            this.PU_3MaterialComboBox.Location = new System.Drawing.Point(97, 46);
            this.PU_3MaterialComboBox.Name = "PU_3MaterialComboBox";
            this.PU_3MaterialComboBox.Size = new System.Drawing.Size(122, 21);
            this.PU_3MaterialComboBox.TabIndex = 8;
            this.PU_3MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.PU_3MaterialComboBox_SelectedIndexChanged);
            // 
            // PU_3StarCheckBox
            // 
            this.PU_3StarCheckBox.AutoSize = true;
            this.PU_3StarCheckBox.Location = new System.Drawing.Point(6, 0);
            this.PU_3StarCheckBox.Name = "PU_3StarCheckBox";
            this.PU_3StarCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PU_3StarCheckBox.Size = new System.Drawing.Size(103, 17);
            this.PU_3StarCheckBox.TabIndex = 2;
            this.PU_3StarCheckBox.Text = "Power Up ★★★";
            this.PU_3StarCheckBox.UseVisualStyleBackColor = true;
            this.PU_3StarCheckBox.CheckedChanged += new System.EventHandler(this.PU_3StarCheckBox_CheckedChanged);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.PU_2OrderComboBox);
            this.groupBox13.Controls.Add(this.PU_2OnlyLv30CheckBox);
            this.groupBox13.Controls.Add(this.label17);
            this.groupBox13.Controls.Add(this.PU_2ConditionComboBox);
            this.groupBox13.Controls.Add(this.PU_2MOnlyLv30CheckBox);
            this.groupBox13.Controls.Add(this.label5);
            this.groupBox13.Controls.Add(this.PU_2MaterialComboBox);
            this.groupBox13.Controls.Add(this.PU_2StarCheckBox);
            this.groupBox13.Location = new System.Drawing.Point(237, 18);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox13.Size = new System.Drawing.Size(243, 119);
            this.groupBox13.TabIndex = 8;
            this.groupBox13.TabStop = false;
            // 
            // PU_2OrderComboBox
            // 
            this.PU_2OrderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PU_2OrderComboBox.FormattingEnabled = true;
            this.PU_2OrderComboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.PU_2OrderComboBox.Location = new System.Drawing.Point(86, 79);
            this.PU_2OrderComboBox.Name = "PU_2OrderComboBox";
            this.PU_2OrderComboBox.Size = new System.Drawing.Size(149, 21);
            this.PU_2OrderComboBox.TabIndex = 14;
            this.PU_2OrderComboBox.SelectedIndexChanged += new System.EventHandler(this.PU_2OrderComboBox_SelectedIndexChanged);
            // 
            // PU_2OnlyLv30CheckBox
            // 
            this.PU_2OnlyLv30CheckBox.AutoSize = true;
            this.PU_2OnlyLv30CheckBox.Enabled = false;
            this.PU_2OnlyLv30CheckBox.Location = new System.Drawing.Point(132, 23);
            this.PU_2OnlyLv30CheckBox.Name = "PU_2OnlyLv30CheckBox";
            this.PU_2OnlyLv30CheckBox.Size = new System.Drawing.Size(100, 17);
            this.PU_2OnlyLv30CheckBox.TabIndex = 9;
            this.PU_2OnlyLv30CheckBox.Text = "Hero Only Lv30";
            this.PU_2OnlyLv30CheckBox.UseVisualStyleBackColor = true;
            this.PU_2OnlyLv30CheckBox.CheckedChanged += new System.EventHandler(this.PU_2OnlyLv30CheckBox_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Material order:";
            // 
            // PU_2ConditionComboBox
            // 
            this.PU_2ConditionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PU_2ConditionComboBox.FormattingEnabled = true;
            this.PU_2ConditionComboBox.Items.AddRange(new object[] {
            "==",
            "<=",
            ">="});
            this.PU_2ConditionComboBox.Location = new System.Drawing.Point(69, 51);
            this.PU_2ConditionComboBox.Name = "PU_2ConditionComboBox";
            this.PU_2ConditionComboBox.Size = new System.Drawing.Size(38, 21);
            this.PU_2ConditionComboBox.TabIndex = 12;
            this.PU_2ConditionComboBox.SelectedIndexChanged += new System.EventHandler(this.PU_2ConditionComboBox_SelectedIndexChanged);
            // 
            // PU_2MOnlyLv30CheckBox
            // 
            this.PU_2MOnlyLv30CheckBox.AutoSize = true;
            this.PU_2MOnlyLv30CheckBox.Location = new System.Drawing.Point(6, 23);
            this.PU_2MOnlyLv30CheckBox.Name = "PU_2MOnlyLv30CheckBox";
            this.PU_2MOnlyLv30CheckBox.Size = new System.Drawing.Size(114, 17);
            this.PU_2MOnlyLv30CheckBox.TabIndex = 11;
            this.PU_2MOnlyLv30CheckBox.Text = "Material Only Lv30";
            this.PU_2MOnlyLv30CheckBox.UseVisualStyleBackColor = true;
            this.PU_2MOnlyLv30CheckBox.CheckedChanged += new System.EventHandler(this.PU_2MOnlyLv30CheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Material";
            // 
            // PU_2MaterialComboBox
            // 
            this.PU_2MaterialComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PU_2MaterialComboBox.FormattingEnabled = true;
            this.PU_2MaterialComboBox.Items.AddRange(new object[] {
            "★",
            "★★",
            "★★★",
            "★★★★"});
            this.PU_2MaterialComboBox.Location = new System.Drawing.Point(113, 51);
            this.PU_2MaterialComboBox.Name = "PU_2MaterialComboBox";
            this.PU_2MaterialComboBox.Size = new System.Drawing.Size(122, 21);
            this.PU_2MaterialComboBox.TabIndex = 8;
            this.PU_2MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.PU_2MaterialComboBox_SelectedIndexChanged);
            // 
            // PU_2StarCheckBox
            // 
            this.PU_2StarCheckBox.AutoSize = true;
            this.PU_2StarCheckBox.Location = new System.Drawing.Point(6, 0);
            this.PU_2StarCheckBox.Name = "PU_2StarCheckBox";
            this.PU_2StarCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PU_2StarCheckBox.Size = new System.Drawing.Size(94, 17);
            this.PU_2StarCheckBox.TabIndex = 2;
            this.PU_2StarCheckBox.Text = "Power Up ★★";
            this.PU_2StarCheckBox.UseVisualStyleBackColor = true;
            this.PU_2StarCheckBox.CheckedChanged += new System.EventHandler(this.PU_2StarCheckBox_CheckedChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.PU_1OrderComboBox);
            this.groupBox12.Controls.Add(this.label21);
            this.groupBox12.Controls.Add(this.PU_1ConditionComboBox);
            this.groupBox12.Controls.Add(this.PU_1MOnlyLv30CheckBox);
            this.groupBox12.Controls.Add(this.PU_1OnlyLv30CheckBox);
            this.groupBox12.Controls.Add(this.label4);
            this.groupBox12.Controls.Add(this.PU_1MaterialComboBox);
            this.groupBox12.Controls.Add(this.PU_1StarCheckBox);
            this.groupBox12.Location = new System.Drawing.Point(6, 18);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox12.Size = new System.Drawing.Size(225, 119);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            // 
            // PU_1OrderComboBox
            // 
            this.PU_1OrderComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PU_1OrderComboBox.FormattingEnabled = true;
            this.PU_1OrderComboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.PU_1OrderComboBox.Location = new System.Drawing.Point(97, 79);
            this.PU_1OrderComboBox.Name = "PU_1OrderComboBox";
            this.PU_1OrderComboBox.Size = new System.Drawing.Size(122, 21);
            this.PU_1OrderComboBox.TabIndex = 16;
            this.PU_1OrderComboBox.SelectedIndexChanged += new System.EventHandler(this.PU_1OrderComboBox_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 87);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Material order:";
            // 
            // PU_1ConditionComboBox
            // 
            this.PU_1ConditionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PU_1ConditionComboBox.FormattingEnabled = true;
            this.PU_1ConditionComboBox.Items.AddRange(new object[] {
            "==",
            "<=",
            ">="});
            this.PU_1ConditionComboBox.Location = new System.Drawing.Point(53, 51);
            this.PU_1ConditionComboBox.Name = "PU_1ConditionComboBox";
            this.PU_1ConditionComboBox.Size = new System.Drawing.Size(38, 21);
            this.PU_1ConditionComboBox.TabIndex = 11;
            this.PU_1ConditionComboBox.SelectedIndexChanged += new System.EventHandler(this.PU_1ConditionComboBox_SelectedIndexChanged);
            // 
            // PU_1MOnlyLv30CheckBox
            // 
            this.PU_1MOnlyLv30CheckBox.AutoSize = true;
            this.PU_1MOnlyLv30CheckBox.Location = new System.Drawing.Point(6, 23);
            this.PU_1MOnlyLv30CheckBox.Name = "PU_1MOnlyLv30CheckBox";
            this.PU_1MOnlyLv30CheckBox.Size = new System.Drawing.Size(114, 17);
            this.PU_1MOnlyLv30CheckBox.TabIndex = 10;
            this.PU_1MOnlyLv30CheckBox.Text = "Material Only Lv30";
            this.PU_1MOnlyLv30CheckBox.UseVisualStyleBackColor = true;
            this.PU_1MOnlyLv30CheckBox.CheckedChanged += new System.EventHandler(this.PU_1MOnlyLv30CheckBox_CheckedChanged);
            // 
            // PU_1OnlyLv30CheckBox
            // 
            this.PU_1OnlyLv30CheckBox.AutoSize = true;
            this.PU_1OnlyLv30CheckBox.Enabled = false;
            this.PU_1OnlyLv30CheckBox.Location = new System.Drawing.Point(122, 23);
            this.PU_1OnlyLv30CheckBox.Name = "PU_1OnlyLv30CheckBox";
            this.PU_1OnlyLv30CheckBox.Size = new System.Drawing.Size(100, 17);
            this.PU_1OnlyLv30CheckBox.TabIndex = 9;
            this.PU_1OnlyLv30CheckBox.Text = "Hero Only Lv30";
            this.PU_1OnlyLv30CheckBox.UseVisualStyleBackColor = true;
            this.PU_1OnlyLv30CheckBox.CheckedChanged += new System.EventHandler(this.PU_1OnlyLv30CheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Material";
            // 
            // PU_1MaterialComboBox
            // 
            this.PU_1MaterialComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PU_1MaterialComboBox.FormattingEnabled = true;
            this.PU_1MaterialComboBox.Items.AddRange(new object[] {
            "★",
            "★★",
            "★★★",
            "★★★★"});
            this.PU_1MaterialComboBox.Location = new System.Drawing.Point(97, 51);
            this.PU_1MaterialComboBox.Name = "PU_1MaterialComboBox";
            this.PU_1MaterialComboBox.Size = new System.Drawing.Size(122, 21);
            this.PU_1MaterialComboBox.TabIndex = 8;
            this.PU_1MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.PU_1MaterialComboBox_SelectedIndexChanged);
            // 
            // PU_1StarCheckBox
            // 
            this.PU_1StarCheckBox.AutoSize = true;
            this.PU_1StarCheckBox.Location = new System.Drawing.Point(6, 0);
            this.PU_1StarCheckBox.Name = "PU_1StarCheckBox";
            this.PU_1StarCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PU_1StarCheckBox.Size = new System.Drawing.Size(85, 17);
            this.PU_1StarCheckBox.TabIndex = 2;
            this.PU_1StarCheckBox.Text = "Power Up ★";
            this.PU_1StarCheckBox.UseVisualStyleBackColor = true;
            this.PU_1StarCheckBox.CheckedChanged += new System.EventHandler(this.PU_1StarCheckBox_CheckedChanged);
            // 
            // PU_enableCheckbox
            // 
            this.PU_enableCheckbox.AutoSize = true;
            this.PU_enableCheckbox.Location = new System.Drawing.Point(6, 8);
            this.PU_enableCheckbox.Name = "PU_enableCheckbox";
            this.PU_enableCheckbox.Size = new System.Drawing.Size(134, 17);
            this.PU_enableCheckbox.TabIndex = 0;
            this.PU_enableCheckbox.Text = "Enable Auto Power Up";
            this.PU_enableCheckbox.UseVisualStyleBackColor = true;
            this.PU_enableCheckbox.CheckedChanged += new System.EventHandler(this.PU_enableCheckbox_CheckedChanged);
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage9.Controls.Add(this.label15);
            this.tabPage9.Controls.Add(this.BF_Active2NumericBox);
            this.tabPage9.Controls.Add(this.BF_EnableActivate2CheckBox);
            this.tabPage9.Controls.Add(this.BF_EnableActivate1CheckBox);
            this.tabPage9.Controls.Add(this.groupBox16);
            this.tabPage9.Controls.Add(this.BF_EnableCheckBox);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(500, 378);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "Auto Bulk Fusion";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(406, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "times Adventure";
            // 
            // BF_Active2NumericBox
            // 
            this.BF_Active2NumericBox.Location = new System.Drawing.Point(347, 28);
            this.BF_Active2NumericBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.BF_Active2NumericBox.Name = "BF_Active2NumericBox";
            this.BF_Active2NumericBox.Size = new System.Drawing.Size(49, 20);
            this.BF_Active2NumericBox.TabIndex = 25;
            this.BF_Active2NumericBox.Tag = "0";
            this.BF_Active2NumericBox.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // BF_EnableActivate2CheckBox
            // 
            this.BF_EnableActivate2CheckBox.Location = new System.Drawing.Point(249, 30);
            this.BF_EnableActivate2CheckBox.Name = "BF_EnableActivate2CheckBox";
            this.BF_EnableActivate2CheckBox.Size = new System.Drawing.Size(104, 18);
            this.BF_EnableActivate2CheckBox.TabIndex = 24;
            this.BF_EnableActivate2CheckBox.Tag = "0";
            this.BF_EnableActivate2CheckBox.Text = "Activate After:";
            this.BF_EnableActivate2CheckBox.UseVisualStyleBackColor = true;
            this.BF_EnableActivate2CheckBox.CheckedChanged += new System.EventHandler(this.BF_Activate2CheckBox_CheckedChanged);
            // 
            // BF_EnableActivate1CheckBox
            // 
            this.BF_EnableActivate1CheckBox.Location = new System.Drawing.Point(249, 6);
            this.BF_EnableActivate1CheckBox.Name = "BF_EnableActivate1CheckBox";
            this.BF_EnableActivate1CheckBox.Size = new System.Drawing.Size(170, 18);
            this.BF_EnableActivate1CheckBox.TabIndex = 23;
            this.BF_EnableActivate1CheckBox.Tag = "0";
            this.BF_EnableActivate1CheckBox.Text = "Activate After Auto Power Up";
            this.BF_EnableActivate1CheckBox.UseVisualStyleBackColor = true;
            this.BF_EnableActivate1CheckBox.CheckedChanged += new System.EventHandler(this.BF_Activate1CheckBox_CheckedChanged);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label11);
            this.groupBox16.Controls.Add(this.BF_OnlyLv30CheckBox);
            this.groupBox16.Controls.Add(this.BF_rankComboBox);
            this.groupBox16.Location = new System.Drawing.Point(8, 54);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(486, 49);
            this.groupBox16.TabIndex = 22;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Auto Bulk Fusion Setting";
            this.groupBox16.Enter += new System.EventHandler(this.groupBox16_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(263, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Rank: ";
            this.label11.Visible = false;
            // 
            // BF_OnlyLv30CheckBox
            // 
            this.BF_OnlyLv30CheckBox.AutoSize = true;
            this.BF_OnlyLv30CheckBox.Location = new System.Drawing.Point(6, 21);
            this.BF_OnlyLv30CheckBox.Name = "BF_OnlyLv30CheckBox";
            this.BF_OnlyLv30CheckBox.Size = new System.Drawing.Size(77, 17);
            this.BF_OnlyLv30CheckBox.TabIndex = 9;
            this.BF_OnlyLv30CheckBox.Text = "Only Lv 30";
            this.BF_OnlyLv30CheckBox.UseVisualStyleBackColor = true;
            this.BF_OnlyLv30CheckBox.CheckedChanged += new System.EventHandler(this.BF_OnlyLv30CheckBox_CheckedChanged);
            // 
            // BF_rankComboBox
            // 
            this.BF_rankComboBox.FormattingEnabled = true;
            this.BF_rankComboBox.Items.AddRange(new object[] {
            "★★★",
            "★★★★",
            "★★★★★",
            "Register All"});
            this.BF_rankComboBox.Location = new System.Drawing.Point(308, 19);
            this.BF_rankComboBox.Name = "BF_rankComboBox";
            this.BF_rankComboBox.Size = new System.Drawing.Size(103, 21);
            this.BF_rankComboBox.TabIndex = 8;
            this.BF_rankComboBox.Visible = false;
            this.BF_rankComboBox.SelectedIndexChanged += new System.EventHandler(this.BF_rankComboBox_SelectedIndexChanged);
            // 
            // BF_EnableCheckBox
            // 
            this.BF_EnableCheckBox.AutoSize = true;
            this.BF_EnableCheckBox.Location = new System.Drawing.Point(8, 7);
            this.BF_EnableCheckBox.Name = "BF_EnableCheckBox";
            this.BF_EnableCheckBox.Size = new System.Drawing.Size(142, 17);
            this.BF_EnableCheckBox.TabIndex = 21;
            this.BF_EnableCheckBox.Text = "Enable Auto Bulk Fusion";
            this.BF_EnableCheckBox.UseVisualStyleBackColor = true;
            this.BF_EnableCheckBox.CheckedChanged += new System.EventHandler(this.BF_EnableCheckBox_CheckedChanged);
            // 
            // tabPage12
            // 
            this.tabPage12.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage12.Controls.Add(this.groupBox17);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(500, 378);
            this.tabPage12.TabIndex = 6;
            this.tabPage12.Text = "Collect Inbox";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.groupBox18);
            this.groupBox17.Controls.Add(this.RS_EnableCollectInboxCheckBox);
            this.groupBox17.Controls.Add(this.RS_EnableCINoRubyCheckBox);
            this.groupBox17.Controls.Add(this.RS_CollectInboxCheckBox);
            this.groupBox17.Controls.Add(this.label14);
            this.groupBox17.Controls.Add(this.RS_CollectInboxActiveNumericBox);
            this.groupBox17.Location = new System.Drawing.Point(5, 6);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(488, 213);
            this.groupBox17.TabIndex = 23;
            this.groupBox17.TabStop = false;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.RS_CIOnlyTicketsCheckBox);
            this.groupBox18.Controls.Add(this.RS_CIOnlyHonorCheckBox);
            this.groupBox18.Controls.Add(this.RS_CIOnlyCurrencyCheckBox);
            this.groupBox18.Controls.Add(this.RS_CIOnlyKeysCheckBox);
            this.groupBox18.Location = new System.Drawing.Point(6, 76);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(476, 68);
            this.groupBox18.TabIndex = 25;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Collect Only: ";
            // 
            // RS_CIOnlyTicketsCheckBox
            // 
            this.RS_CIOnlyTicketsCheckBox.AutoSize = true;
            this.RS_CIOnlyTicketsCheckBox.Location = new System.Drawing.Point(361, 19);
            this.RS_CIOnlyTicketsCheckBox.Name = "RS_CIOnlyTicketsCheckBox";
            this.RS_CIOnlyTicketsCheckBox.Size = new System.Drawing.Size(61, 17);
            this.RS_CIOnlyTicketsCheckBox.TabIndex = 4;
            this.RS_CIOnlyTicketsCheckBox.Tag = "1";
            this.RS_CIOnlyTicketsCheckBox.Text = "Tickets";
            this.RS_CIOnlyTicketsCheckBox.UseVisualStyleBackColor = true;
            this.RS_CIOnlyTicketsCheckBox.CheckedChanged += new System.EventHandler(this.RS_CIOnlyTicketsCheckBox_CheckedChanged);
            // 
            // RS_CIOnlyHonorCheckBox
            // 
            this.RS_CIOnlyHonorCheckBox.AutoSize = true;
            this.RS_CIOnlyHonorCheckBox.Location = new System.Drawing.Point(6, 19);
            this.RS_CIOnlyHonorCheckBox.Name = "RS_CIOnlyHonorCheckBox";
            this.RS_CIOnlyHonorCheckBox.Size = new System.Drawing.Size(55, 17);
            this.RS_CIOnlyHonorCheckBox.TabIndex = 3;
            this.RS_CIOnlyHonorCheckBox.Tag = "1";
            this.RS_CIOnlyHonorCheckBox.Text = "Honor";
            this.RS_CIOnlyHonorCheckBox.UseVisualStyleBackColor = true;
            this.RS_CIOnlyHonorCheckBox.CheckedChanged += new System.EventHandler(this.RS_CIOnlyHonorCheckBox_CheckedChanged);
            // 
            // RS_CIOnlyCurrencyCheckBox
            // 
            this.RS_CIOnlyCurrencyCheckBox.AutoSize = true;
            this.RS_CIOnlyCurrencyCheckBox.Location = new System.Drawing.Point(221, 19);
            this.RS_CIOnlyCurrencyCheckBox.Name = "RS_CIOnlyCurrencyCheckBox";
            this.RS_CIOnlyCurrencyCheckBox.Size = new System.Drawing.Size(68, 17);
            this.RS_CIOnlyCurrencyCheckBox.TabIndex = 2;
            this.RS_CIOnlyCurrencyCheckBox.Tag = "1";
            this.RS_CIOnlyCurrencyCheckBox.Text = "Currency";
            this.RS_CIOnlyCurrencyCheckBox.UseVisualStyleBackColor = true;
            this.RS_CIOnlyCurrencyCheckBox.CheckedChanged += new System.EventHandler(this.RS_CIOnlyCurrencyCheckBox_CheckedChanged);
            // 
            // RS_CIOnlyKeysCheckBox
            // 
            this.RS_CIOnlyKeysCheckBox.AutoSize = true;
            this.RS_CIOnlyKeysCheckBox.Location = new System.Drawing.Point(108, 19);
            this.RS_CIOnlyKeysCheckBox.Name = "RS_CIOnlyKeysCheckBox";
            this.RS_CIOnlyKeysCheckBox.Size = new System.Drawing.Size(49, 17);
            this.RS_CIOnlyKeysCheckBox.TabIndex = 1;
            this.RS_CIOnlyKeysCheckBox.Tag = "1";
            this.RS_CIOnlyKeysCheckBox.Text = "Keys";
            this.RS_CIOnlyKeysCheckBox.UseVisualStyleBackColor = true;
            this.RS_CIOnlyKeysCheckBox.CheckedChanged += new System.EventHandler(this.RS_CIOnlyKeysCheckBox_CheckedChanged);
            // 
            // RS_EnableCollectInboxCheckBox
            // 
            this.RS_EnableCollectInboxCheckBox.Location = new System.Drawing.Point(6, 0);
            this.RS_EnableCollectInboxCheckBox.Name = "RS_EnableCollectInboxCheckBox";
            this.RS_EnableCollectInboxCheckBox.Size = new System.Drawing.Size(141, 18);
            this.RS_EnableCollectInboxCheckBox.TabIndex = 24;
            this.RS_EnableCollectInboxCheckBox.Tag = "0";
            this.RS_EnableCollectInboxCheckBox.Text = "Enable Collect Inbox";
            this.RS_EnableCollectInboxCheckBox.UseVisualStyleBackColor = true;
            this.RS_EnableCollectInboxCheckBox.CheckedChanged += new System.EventHandler(this.RS_EnableCollectInboxCheckBox_CheckedChanged);
            // 
            // RS_EnableCINoRubyCheckBox
            // 
            this.RS_EnableCINoRubyCheckBox.Location = new System.Drawing.Point(6, 52);
            this.RS_EnableCINoRubyCheckBox.Name = "RS_EnableCINoRubyCheckBox";
            this.RS_EnableCINoRubyCheckBox.Size = new System.Drawing.Size(262, 18);
            this.RS_EnableCINoRubyCheckBox.TabIndex = 23;
            this.RS_EnableCINoRubyCheckBox.Tag = "0";
            this.RS_EnableCINoRubyCheckBox.Text = "Collect Inbox When No More Ruby to Buy Keys";
            this.RS_EnableCINoRubyCheckBox.UseVisualStyleBackColor = true;
            this.RS_EnableCINoRubyCheckBox.CheckedChanged += new System.EventHandler(this.RS_EnableCINoRubyCheckBox_CheckedChanged);
            // 
            // RS_CollectInboxCheckBox
            // 
            this.RS_CollectInboxCheckBox.Location = new System.Drawing.Point(6, 26);
            this.RS_CollectInboxCheckBox.Name = "RS_CollectInboxCheckBox";
            this.RS_CollectInboxCheckBox.Size = new System.Drawing.Size(119, 18);
            this.RS_CollectInboxCheckBox.TabIndex = 20;
            this.RS_CollectInboxCheckBox.Tag = "0";
            this.RS_CollectInboxCheckBox.Text = "Collect Inbox After:";
            this.RS_CollectInboxCheckBox.UseVisualStyleBackColor = true;
            this.RS_CollectInboxCheckBox.CheckedChanged += new System.EventHandler(this.RS_CollectInboxCheckBox_CheckedChanged_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(186, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "times Adventure";
            // 
            // RS_CollectInboxActiveNumericBox
            // 
            this.RS_CollectInboxActiveNumericBox.Location = new System.Drawing.Point(126, 21);
            this.RS_CollectInboxActiveNumericBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.RS_CollectInboxActiveNumericBox.Name = "RS_CollectInboxActiveNumericBox";
            this.RS_CollectInboxActiveNumericBox.Size = new System.Drawing.Size(49, 20);
            this.RS_CollectInboxActiveNumericBox.TabIndex = 21;
            this.RS_CollectInboxActiveNumericBox.Tag = "0";
            this.RS_CollectInboxActiveNumericBox.ValueChanged += new System.EventHandler(this.RS_CollectInboxActiveNumericBox_ValueChanged);
            // 
            // tabPage18
            // 
            this.tabPage18.Controls.Add(this.tabControl6);
            this.tabPage18.ImageKey = "icon_setting.png";
            this.tabPage18.Location = new System.Drawing.Point(4, 23);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Size = new System.Drawing.Size(505, 429);
            this.tabPage18.TabIndex = 2;
            this.tabPage18.Text = "Setting";
            // 
            // tabControl6
            // 
            this.tabControl6.Controls.Add(this.tabPage19);
            this.tabControl6.Controls.Add(this.tabPage20);
            this.tabControl6.Controls.Add(this.tabPage21);
            this.tabControl6.Location = new System.Drawing.Point(-3, 0);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(508, 433);
            this.tabControl6.TabIndex = 0;
            // 
            // tabPage19
            // 
            this.tabPage19.Controls.Add(this.ST_blueStacksGroupBox);
            this.tabPage19.Controls.Add(this.groupBox38);
            this.tabPage19.Location = new System.Drawing.Point(4, 22);
            this.tabPage19.Name = "tabPage19";
            this.tabPage19.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage19.Size = new System.Drawing.Size(500, 407);
            this.tabPage19.TabIndex = 0;
            this.tabPage19.Text = "Option";
            // 
            // ST_blueStacksGroupBox
            // 
            this.ST_blueStacksGroupBox.Controls.Add(this.button7);
            this.ST_blueStacksGroupBox.Controls.Add(this.ST_forceActiveCheckBox);
            this.ST_blueStacksGroupBox.Controls.Add(this.ST_toggleBlueStacksButton);
            this.ST_blueStacksGroupBox.Controls.Add(this.ST_foregroundMode);
            this.ST_blueStacksGroupBox.Controls.Add(this.label16);
            this.ST_blueStacksGroupBox.Controls.Add(this.LDTitleTextBox);
            this.ST_blueStacksGroupBox.Location = new System.Drawing.Point(8, 131);
            this.ST_blueStacksGroupBox.Name = "ST_blueStacksGroupBox";
            this.ST_blueStacksGroupBox.Size = new System.Drawing.Size(485, 96);
            this.ST_blueStacksGroupBox.TabIndex = 8;
            this.ST_blueStacksGroupBox.TabStop = false;
            this.ST_blueStacksGroupBox.Text = "LD Player Setting";
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(11, 59);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Reset ADB";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ST_forceActiveCheckBox
            // 
            this.ST_forceActiveCheckBox.AutoSize = true;
            this.ST_forceActiveCheckBox.Location = new System.Drawing.Point(364, 63);
            this.ST_forceActiveCheckBox.Name = "ST_forceActiveCheckBox";
            this.ST_forceActiveCheckBox.Size = new System.Drawing.Size(92, 17);
            this.ST_forceActiveCheckBox.TabIndex = 1;
            this.ST_forceActiveCheckBox.Text = "Always on top";
            this.ST_forceActiveCheckBox.UseVisualStyleBackColor = true;
            this.ST_forceActiveCheckBox.CheckedChanged += new System.EventHandler(this.ST_forceActiveCheckBox_CheckedChanged_1);
            // 
            // ST_toggleBlueStacksButton
            // 
            this.ST_toggleBlueStacksButton.Enabled = false;
            this.ST_toggleBlueStacksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_toggleBlueStacksButton.Location = new System.Drawing.Point(179, 59);
            this.ST_toggleBlueStacksButton.Name = "ST_toggleBlueStacksButton";
            this.ST_toggleBlueStacksButton.Size = new System.Drawing.Size(124, 23);
            this.ST_toggleBlueStacksButton.TabIndex = 0;
            this.ST_toggleBlueStacksButton.Text = "Hide LD Player";
            this.ST_toggleBlueStacksButton.UseVisualStyleBackColor = true;
            this.ST_toggleBlueStacksButton.Click += new System.EventHandler(this.ST_toggleBlueStacksButton_Click);
            // 
            // ST_foregroundMode
            // 
            this.ST_foregroundMode.AutoSize = true;
            this.ST_foregroundMode.Location = new System.Drawing.Point(364, 24);
            this.ST_foregroundMode.Name = "ST_foregroundMode";
            this.ST_foregroundMode.Size = new System.Drawing.Size(110, 17);
            this.ST_foregroundMode.TabIndex = 9;
            this.ST_foregroundMode.Text = "Foreground Mode";
            this.ST_foregroundMode.UseVisualStyleBackColor = true;
            this.ST_foregroundMode.CheckedChanged += new System.EventHandler(this.ST_foregroundMode_CheckedChanged_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "LD Player Title";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // LDTitleTextBox
            // 
            this.LDTitleTextBox.Location = new System.Drawing.Point(88, 21);
            this.LDTitleTextBox.Name = "LDTitleTextBox";
            this.LDTitleTextBox.Size = new System.Drawing.Size(215, 20);
            this.LDTitleTextBox.TabIndex = 10;
            this.LDTitleTextBox.Text = "LDPlayer";
            this.LDTitleTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox38
            // 
            this.groupBox38.Controls.Add(this.label79);
            this.groupBox38.Controls.Add(this.ST_delayLabel);
            this.groupBox38.Controls.Add(this.ST_opacityLabel);
            this.groupBox38.Controls.Add(this.ST_opacityTrackBar);
            this.groupBox38.Controls.Add(this.ST_delayTrackBar);
            this.groupBox38.Controls.Add(this.ST_delayValueLabel);
            this.groupBox38.Controls.Add(this.ST_reconnectInterruptCheckBox);
            this.groupBox38.Controls.Add(this.ST_reconnectNumericUpDown);
            this.groupBox38.Location = new System.Drawing.Point(8, 6);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Size = new System.Drawing.Size(485, 119);
            this.groupBox38.TabIndex = 0;
            this.groupBox38.TabStop = false;
            this.groupBox38.Text = "Delay Setting";
            // 
            // label79
            // 
            this.label79.Location = new System.Drawing.Point(-136, 13);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(49, 13);
            this.label79.TabIndex = 13;
            this.label79.Text = "Delay";
            // 
            // tabPage20
            // 
            this.tabPage20.Controls.Add(this.groupBox39);
            this.tabPage20.Location = new System.Drawing.Point(4, 22);
            this.tabPage20.Name = "tabPage20";
            this.tabPage20.Size = new System.Drawing.Size(500, 407);
            this.tabPage20.TabIndex = 2;
            this.tabPage20.Text = "Profile";
            // 
            // groupBox39
            // 
            this.groupBox39.Controls.Add(this.saveSettingsButton);
            this.groupBox39.Controls.Add(this.ST_manageProfileButton);
            this.groupBox39.Controls.Add(this.ST_currentProfileComboBox);
            this.groupBox39.Controls.Add(this.ST_currentProfileLabel);
            this.groupBox39.Location = new System.Drawing.Point(8, 3);
            this.groupBox39.Name = "groupBox39";
            this.groupBox39.Size = new System.Drawing.Size(481, 75);
            this.groupBox39.TabIndex = 7;
            this.groupBox39.TabStop = false;
            this.groupBox39.Text = "Profile";
            // 
            // tabPage21
            // 
            this.tabPage21.Controls.Add(this.groupBox20);
            this.tabPage21.Controls.Add(this.ST_TelegramWarnBoostCheckBox);
            this.tabPage21.Controls.Add(this.groupBox3);
            this.tabPage21.Controls.Add(this.ST_TelegramWarnHTCheckBox);
            this.tabPage21.Location = new System.Drawing.Point(4, 22);
            this.tabPage21.Name = "tabPage21";
            this.tabPage21.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage21.Size = new System.Drawing.Size(500, 407);
            this.tabPage21.TabIndex = 1;
            this.tabPage21.Text = "Remote Bot";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.ST_EnableTelegramMsg1CheckBox);
            this.groupBox20.Location = new System.Drawing.Point(8, 162);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(486, 142);
            this.groupBox20.TabIndex = 15;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Telegram Bot Setting";
            // 
            // ST_EnableTelegramMsg1CheckBox
            // 
            this.ST_EnableTelegramMsg1CheckBox.AutoSize = true;
            this.ST_EnableTelegramMsg1CheckBox.Location = new System.Drawing.Point(6, 19);
            this.ST_EnableTelegramMsg1CheckBox.Name = "ST_EnableTelegramMsg1CheckBox";
            this.ST_EnableTelegramMsg1CheckBox.Size = new System.Drawing.Size(175, 17);
            this.ST_EnableTelegramMsg1CheckBox.TabIndex = 0;
            this.ST_EnableTelegramMsg1CheckBox.Text = "Adventure Sequence Limit Alert";
            this.ST_EnableTelegramMsg1CheckBox.UseVisualStyleBackColor = true;
            this.ST_EnableTelegramMsg1CheckBox.CheckedChanged += new System.EventHandler(this.ST_EnableTelegramMsg1CheckBox_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "mode.ico");
            this.imageList1.Images.SetKeyName(1, "mode22.ico");
            this.imageList1.Images.SetKeyName(2, "favicon2.ico");
            this.imageList1.Images.SetKeyName(3, "favicon.ico");
            this.imageList1.Images.SetKeyName(4, "offer_inter.png");
            this.imageList1.Images.SetKeyName(5, "award_star_gold_3.png");
            this.imageList1.Images.SetKeyName(6, "icon-2pages.gif");
            this.imageList1.Images.SetKeyName(7, "icon_mode.png");
            this.imageList1.Images.SetKeyName(8, "icon_report.png");
            this.imageList1.Images.SetKeyName(9, "icon_setting.png");
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.screenshotButton);
            this.groupBox2.Controls.Add(this.aiButton);
            this.groupBox2.Controls.Add(this.aiPause);
            this.groupBox2.Location = new System.Drawing.Point(363, 576);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 130);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // screenshotButton
            // 
            this.screenshotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.screenshotButton.Location = new System.Drawing.Point(16, 87);
            this.screenshotButton.Name = "screenshotButton";
            this.screenshotButton.Size = new System.Drawing.Size(102, 27);
            this.screenshotButton.TabIndex = 17;
            this.screenshotButton.Text = "&Save Profile";
            this.screenshotButton.UseVisualStyleBackColor = true;
            this.screenshotButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // resourcesTableLayoutPanel
            // 
            this.resourcesTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.resourcesTableLayoutPanel.ColumnCount = 7;
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.resourcesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.resourcesTableLayoutPanel.Controls.Add(this.pictureBox6, 1, 0);
            this.resourcesTableLayoutPanel.Controls.Add(this.pictureBox8, 3, 0);
            this.resourcesTableLayoutPanel.Controls.Add(this.pictureBox9, 5, 0);
            this.resourcesTableLayoutPanel.Controls.Add(this.honorLabel2, 6, 0);
            this.resourcesTableLayoutPanel.Controls.Add(this.rubyLabel2, 4, 0);
            this.resourcesTableLayoutPanel.Controls.Add(this.goldLabel2, 2, 0);
            this.resourcesTableLayoutPanel.Location = new System.Drawing.Point(0, 544);
            this.resourcesTableLayoutPanel.Name = "resourcesTableLayoutPanel";
            this.resourcesTableLayoutPanel.RowCount = 1;
            this.resourcesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.resourcesTableLayoutPanel.Size = new System.Drawing.Size(504, 24);
            this.resourcesTableLayoutPanel.TabIndex = 11;
            // 
            // ST_EmulatorNameTextBox
            // 
            this.ST_EmulatorNameTextBox.Location = new System.Drawing.Point(0, 0);
            this.ST_EmulatorNameTextBox.Name = "ST_EmulatorNameTextBox";
            this.ST_EmulatorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ST_EmulatorNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // topheaderPictureBox
            // 
            this.topheaderPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topheaderPictureBox.Image = global::SevenKnightsAI.Properties.Resources.myth_cover3;
            this.topheaderPictureBox.Location = new System.Drawing.Point(0, 0);
            this.topheaderPictureBox.Name = "topheaderPictureBox";
            this.topheaderPictureBox.Size = new System.Drawing.Size(508, 99);
            this.topheaderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topheaderPictureBox.TabIndex = 0;
            this.topheaderPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.aiButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(505, 741);
            this.Controls.Add(this.resourcesTableLayoutPanel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.topheaderPictureBox);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seven Knights AI Black";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_opacityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_reconnectNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_delayTrackBar)).EndInit();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmartModePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arenaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventurePictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AD_limitNumericBox)).EndInit();
            this.tabPage15.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ADCH_ChangeHeroGroupBox.ResumeLayout(false);
            this.groupBox26.ResumeLayout(false);
            this.groupBox26.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox27.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AR_limitNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AR_useRubyNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AR_stopArenaNumericBox)).EndInit();
            this.GC_formationPanel.ResumeLayout(false);
            this.GC_formationPanel.PerformLayout();
            this.tabPage17.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PU_Active1NumericBox)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BF_Active2NumericBox)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.tabPage12.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_CollectInboxActiveNumericBox)).EndInit();
            this.tabPage18.ResumeLayout(false);
            this.tabControl6.ResumeLayout(false);
            this.tabPage19.ResumeLayout(false);
            this.ST_blueStacksGroupBox.ResumeLayout(false);
            this.ST_blueStacksGroupBox.PerformLayout();
            this.groupBox38.ResumeLayout(false);
            this.groupBox38.PerformLayout();
            this.tabPage20.ResumeLayout(false);
            this.groupBox39.ResumeLayout(false);
            this.groupBox39.PerformLayout();
            this.tabPage21.ResumeLayout(false);
            this.tabPage21.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.resourcesTableLayoutPanel.ResumeLayout(false);
            this.resourcesTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topheaderPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		
		private global::System.Windows.Forms.ToolStripStatusLabel adminToolStripLabel;

		
		private global::System.Windows.Forms.Label adventureCountLabel;



		
		private global::System.Windows.Forms.PictureBox adventurePictureBox;








































































		
		private global::System.Windows.Forms.Button aiButton;

		
		private global::System.Windows.Forms.Label arenaCountLabel;



		
		private global::System.Windows.Forms.PictureBox arenaPictureBox;













		
		private global::System.ComponentModel.IContainer components;


		
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Details;

		
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Event;






























































		
		private global::System.Windows.Forms.ToolStripStatusLabel profileToolStripLabel;























































































		
		private global::System.Windows.Forms.Button saveSettingsButton;


		
		private global::System.Windows.Forms.ToolStripStatusLabel splitterStatusLabel;

		
		private global::System.Windows.Forms.StatusStrip statusStrip;



		
		private global::System.Windows.Forms.ComboBox ST_currentProfileComboBox;

		
		private global::System.Windows.Forms.Label ST_currentProfileLabel;

		
		private global::System.Windows.Forms.Label ST_delayLabel;

		
		private global::System.Windows.Forms.TrackBar ST_delayTrackBar;

		
		private global::System.Windows.Forms.Label ST_delayValueLabel;





		
		private global::System.Windows.Forms.Button ST_manageProfileButton;

		
		private global::System.Windows.Forms.Label ST_opacityLabel;

		
		private global::System.Windows.Forms.TrackBar ST_opacityTrackBar;








		
		private global::System.Windows.Forms.CheckBox ST_reconnectInterruptCheckBox;

		
		private global::System.Windows.Forms.NumericUpDown ST_reconnectNumericUpDown;


		
		private global::System.Windows.Forms.GroupBox summaryGroupBox;


		
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Time;

		
		private global::System.Windows.Forms.ToolTip toolTip;



		
		private global::System.Windows.Forms.PictureBox topheaderPictureBox;


        private System.Windows.Forms.Button aiPause;
		private System.Windows.Forms.ToolStripStatusLabel tsslCursorPosition;
		private System.Windows.Forms.ToolStripStatusLabel tsslBuildInfo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label adventureKeysLabel2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label arenaKeysLabel2;
        private System.Windows.Forms.Label honorLabel2;
        private System.Windows.Forms.Label rubyLabel2;
        private System.Windows.Forms.Label goldLabel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.RichTextBox LG_logTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox ST_TelegramChatIDTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox ST_TelegramTokenTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox ST_TelegramEnableCheckBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage18;
        private System.Windows.Forms.TabControl tabControl6;
        private System.Windows.Forms.TabPage tabPage19;
        private System.Windows.Forms.TabPage tabPage20;
        private System.Windows.Forms.GroupBox groupBox39;
        private System.Windows.Forms.TabPage tabPage21;
        private System.Windows.Forms.GroupBox groupBox38;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button screenshotButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripStatusLabel statusToolStripLabel;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.CheckBox GB_WaitForKeys;
        private System.Windows.Forms.CheckBox AD_EnHottime_Checkbox;
        private System.Windows.Forms.CheckBox AD_NoHeroUp_Checkbox;
        private System.Windows.Forms.Label AD_limitLabel;
        private System.Windows.Forms.NumericUpDown AD_limitNumericBox;
        private System.Windows.Forms.CheckBox AD_limitCheckBox;
        private System.Windows.Forms.CheckBox AD_enableCheckBox;
        private System.Windows.Forms.CheckBox AD_StopOnFullItems_Checkbox;
        private System.Windows.Forms.CheckBox AD_StopOnFullHeroes_Checkbox;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.CheckBox AD_bootmodeCheckBox;
        private System.Windows.Forms.CheckBox AD_UseFriendCheckBox;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.ComboBox AD_difficultyComboBox2nd;
        private System.Windows.Forms.Label AD_difficultyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AD_difficultyComboBox;
        private System.Windows.Forms.Label AD_worldLabel;
        private System.Windows.Forms.Label AD_stageLabel;
        private System.Windows.Forms.ComboBox AD_worldComboBox;
        private System.Windows.Forms.ComboBox AD_stageComboBox;
        private System.Windows.Forms.Button AD_sequenceButton;
        private System.Windows.Forms.CheckBox AD_continuousCheckBox;
        private System.Windows.Forms.GroupBox ADCH_ChangeHeroGroupBox;
        private System.Windows.Forms.Label AD_teamLabel;
        private System.Windows.Forms.ComboBox AD_teamComboBox2;
        private System.Windows.Forms.ComboBox AD_teamComboBox;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox SM_CollectTartarusCheckBox;
        private System.Windows.Forms.CheckBox SM_CollectRaidCheckBox;
        private System.Windows.Forms.CheckBox SM_CollectTowerCheckBox;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label AR_limitLabel;
        private System.Windows.Forms.CheckBox AR_enableCheckBox;
        private System.Windows.Forms.NumericUpDown AR_limitNumericBox;
        private System.Windows.Forms.CheckBox AR_limitCheckBox;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.CheckBox AR_stopArenaCheckBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox AR_useRubyCheckBox;
        private System.Windows.Forms.Label AR_useRubyLabel;
        private System.Windows.Forms.NumericUpDown AR_useRubyNumericBox;
        private System.Windows.Forms.NumericUpDown AR_stopArenaNumericBox;
        private System.Windows.Forms.Panel GC_formationPanel;
        private System.Windows.Forms.CheckBox GC_pos5CheckBox;
        private System.Windows.Forms.CheckBox GC_pos4CheckBox;
        private System.Windows.Forms.CheckBox GC_pos3CheckBox;
        private System.Windows.Forms.CheckBox GC_pos2CheckBox;
        private System.Windows.Forms.CheckBox GC_pos1CheckBox;
        private System.Windows.Forms.ComboBox GC_teamComboBox;
        private System.Windows.Forms.TabPage tabPage17;
        private System.Windows.Forms.PictureBox SmartModePictureBox;
        private System.Windows.Forms.Label SmartModeCountLabel;
        private System.Windows.Forms.CheckBox SM_EnableCheckBox;
        private System.Windows.Forms.TableLayoutPanel resourcesTableLayoutPanel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox logsBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label botstatusLabel;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label itemslotLabel;
        private System.Windows.Forms.Label heroslotLabel;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label h30advLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label essenceLabel;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.Label starLabel;
        private System.Windows.Forms.Label goldencrystalLabel;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label hornLabel;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label rankArenaLabel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label arenaLoseLabel2;
        private System.Windows.Forms.Label arenaWinLabel2;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton AD_BoostModeAllMapsRadio;
        private System.Windows.Forms.RadioButton AD_BoostModeAsgarRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ST_EmulatorNameTextBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label itemadvLabel;
        private System.Windows.Forms.Label heroadvLabel;
        private System.Windows.Forms.Label goldadvLabel;
        private System.Windows.Forms.GroupBox ST_blueStacksGroupBox;
        private System.Windows.Forms.CheckBox ST_forceActiveCheckBox;
        private System.Windows.Forms.Button ST_toggleBlueStacksButton;
        private System.Windows.Forms.CheckBox ST_foregroundMode;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox PU_1StarCheckBox;
        private System.Windows.Forms.CheckBox PU_enableCheckbox;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.CheckBox PU_enableActive2CheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown PU_Active1NumericBox;
        private System.Windows.Forms.CheckBox PU_enableActive1CheckBox;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.CheckBox PU_4OnlyLv30CheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PU_4MaterialComboBox;
        private System.Windows.Forms.CheckBox PU_4StarCheckBox;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.CheckBox PU_3OnlyLv30CheckBox;
        private System.Windows.Forms.ComboBox PU_3MaterialComboBox;
        private System.Windows.Forms.CheckBox PU_3StarCheckBox;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.CheckBox PU_2OnlyLv30CheckBox;
        private System.Windows.Forms.ComboBox PU_2MaterialComboBox;
        private System.Windows.Forms.CheckBox PU_2StarCheckBox;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox PU_1OnlyLv30CheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PU_1MaterialComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown BF_Active2NumericBox;
        private System.Windows.Forms.CheckBox BF_EnableActivate2CheckBox;
        private System.Windows.Forms.CheckBox BF_EnableActivate1CheckBox;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox BF_OnlyLv30CheckBox;
        private System.Windows.Forms.ComboBox BF_rankComboBox;
        private System.Windows.Forms.CheckBox BF_EnableCheckBox;
        private System.Windows.Forms.CheckBox PU_4MOnlyLv30CheckBox;
        private System.Windows.Forms.CheckBox PU_3MOnlyLv30CheckBox;
        private System.Windows.Forms.CheckBox PU_2MOnlyLv30CheckBox;
        private System.Windows.Forms.CheckBox PU_1MOnlyLv30CheckBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox PU_enableActive3CheckBox;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label soulLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox LDTitleTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox PU_1ConditionComboBox;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox PU_3ConditionComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox PU_2ConditionComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown RS_CollectInboxActiveNumericBox;
        private System.Windows.Forms.CheckBox RS_CollectInboxCheckBox;
        private System.Windows.Forms.RadioButton AD_BoostModeSequenceRadio;
        private System.Windows.Forms.ComboBox PU_2OrderComboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox PU_3OrderComboBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox PU_1OrderComboBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.CheckBox RS_EnableCINoRubyCheckBox;
        private System.Windows.Forms.CheckBox RS_EnableCollectInboxCheckBox;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.CheckBox RS_CIOnlyTicketsCheckBox;
        private System.Windows.Forms.CheckBox RS_CIOnlyHonorCheckBox;
        private System.Windows.Forms.CheckBox RS_CIOnlyCurrencyCheckBox;
        private System.Windows.Forms.CheckBox RS_CIOnlyKeysCheckBox;
        private System.Windows.Forms.CheckBox ST_TelegramWarnBoostCheckBox;
        private System.Windows.Forms.CheckBox ST_TelegramWarnHTCheckBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerSecond;
        private System.Windows.Forms.Label timerMinute;
        private System.Windows.Forms.Label timerHour;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.CheckBox AD_EnableProfile1CheckBox;
        private System.Windows.Forms.CheckBox AD_EnableProfile2CheckBox;
        private System.Windows.Forms.CheckBox AD_EnableProfile3CheckBox;
        private System.Windows.Forms.CheckBox AD_NoChangeModeCheckBox;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.CheckBox ST_EnableTelegramMsg1CheckBox;
    }
}
