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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.arenaKeysLabel2 = new System.Windows.Forms.Label();
            this.adventureKeysLabel2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.honorLabel2 = new System.Windows.Forms.Label();
            this.rubyLabel2 = new System.Windows.Forms.Label();
            this.goldLabel2 = new System.Windows.Forms.Label();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.SmartModePictureBox = new System.Windows.Forms.PictureBox();
            this.arenaPictureBox = new System.Windows.Forms.PictureBox();
            this.adventurePictureBox = new System.Windows.Forms.PictureBox();
            this.SmartModeCountLabel = new System.Windows.Forms.Label();
            this.arenaCountLabel = new System.Windows.Forms.Label();
            this.adventureCountLabel = new System.Windows.Forms.Label();
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
            this.topheaderPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RS_sellHeroesCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_sendHonorsFacebook = new System.Windows.Forms.CheckBox();
            this.RS_sendHonorsInGame = new System.Windows.Forms.CheckBox();
            this.AD_difficultyComboBox = new System.Windows.Forms.ComboBox();
            this.AD_difficultyComboBox2nd = new System.Windows.Forms.ComboBox();
            this.GB_WaitForKeys = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.botstatusLabel = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.itemslotLabel = new System.Windows.Forms.Label();
            this.heroslotLabel = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.goldadvLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.AD_CheckSlot_CheckBox = new System.Windows.Forms.CheckBox();
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
            this.AD_BoostModeAllMapsRadio = new System.Windows.Forms.RadioButton();
            this.AD_BoostModeAsgarRadio = new System.Windows.Forms.RadioButton();
            this.AD_bootmodeCheckBox = new System.Windows.Forms.CheckBox();
            this.ADCH_ChangeHeroGroupBox = new System.Windows.Forms.GroupBox();
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
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.SM_EnableCheckBox = new System.Windows.Forms.CheckBox();
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
            this.RS_buyKeysGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_buyKeyRubiesLabel = new System.Windows.Forms.Label();
            this.RS_buyKeyRubiesNumericBox = new System.Windows.Forms.NumericUpDown();
            this.RS_buyKeyRubiesComboBox = new System.Windows.Forms.ComboBox();
            this.RS_buyKeyRubiesCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_buyKeyHonorsLabel = new System.Windows.Forms.Label();
            this.RS_buyKeyHonorsNumericBox = new System.Windows.Forms.NumericUpDown();
            this.RS_buyKeyHonorsComboBox = new System.Windows.Forms.ComboBox();
            this.RS_buyKeyHonorsCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_sendHonorsGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_giftsGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_luckyBoxCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_luckyChestCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_collectQuestsGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_questsSocialCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_questsItemCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_questsHeroCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_questsBattleCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_specialQuestsMonthlyCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_specialQuestsWeeklyCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_specialQuestsDailyCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_questsNormalLabel = new System.Windows.Forms.Label();
            this.RS_questsSpecialLabel = new System.Windows.Forms.Label();
            this.RS_sellingGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_itemRadioPanel = new System.Windows.Forms.Panel();
            this.RS_itemAmountRadioButton = new System.Windows.Forms.RadioButton();
            this.RS_itemAllRadioButton = new System.Windows.Forms.RadioButton();
            this.RS_heroRadioPanel = new System.Windows.Forms.Panel();
            this.RS_heroAmountRadioButton = new System.Windows.Forms.RadioButton();
            this.RS_heroAllRadioButton = new System.Windows.Forms.RadioButton();
            this.RS_itemAmountNumericBox = new System.Windows.Forms.NumericUpDown();
            this.RS_heroAmountNumericBox = new System.Windows.Forms.NumericUpDown();
            this.RS_itemStarsComboBox = new System.Windows.Forms.ComboBox();
            this.RS_heroStarsComboBox = new System.Windows.Forms.ComboBox();
            this.RS_sellItemsCheckBox = new System.Windows.Forms.CheckBox();
            this.RS_inboxGroupBox = new System.Windows.Forms.GroupBox();
            this.RS_InboxCurrency = new System.Windows.Forms.CheckBox();
            this.RS_InboxKeys = new System.Windows.Forms.CheckBox();
            this.RS_inboxMaterials = new System.Windows.Forms.CheckBox();
            this.RS_inboxHonors = new System.Windows.Forms.CheckBox();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.tabPage19 = new System.Windows.Forms.TabPage();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label79 = new System.Windows.Forms.Label();
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.groupBox39 = new System.Windows.Forms.GroupBox();
            this.tabPage21 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.screenshotButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.resourcesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_opacityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_reconnectNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_delayTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.summaryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmartModePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arenaPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventurePictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topheaderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.RS_buyKeysGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_buyKeyRubiesNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_buyKeyHonorsNumericBox)).BeginInit();
            this.RS_sendHonorsGroupBox.SuspendLayout();
            this.RS_giftsGroupBox.SuspendLayout();
            this.RS_collectQuestsGroupBox.SuspendLayout();
            this.RS_sellingGroupBox.SuspendLayout();
            this.RS_itemRadioPanel.SuspendLayout();
            this.RS_heroRadioPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_itemAmountNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_heroAmountNumericBox)).BeginInit();
            this.RS_inboxGroupBox.SuspendLayout();
            this.tabPage18.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.tabPage19.SuspendLayout();
            this.groupBox38.SuspendLayout();
            this.tabPage20.SuspendLayout();
            this.groupBox39.SuspendLayout();
            this.tabPage21.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.resourcesTableLayoutPanel.SuspendLayout();
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
            this.groupBox3.Size = new System.Drawing.Size(486, 158);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Telegram Bot";
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
            this.ST_manageProfileButton.Location = new System.Drawing.Point(225, 16);
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
            this.ST_currentProfileComboBox.FormattingEnabled = true;
            this.ST_currentProfileComboBox.Location = new System.Drawing.Point(82, 18);
            this.ST_currentProfileComboBox.Name = "ST_currentProfileComboBox";
            this.ST_currentProfileComboBox.Size = new System.Drawing.Size(112, 21);
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
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SevenKnightsAI.Properties.Resources.icon_key_arena;
            this.pictureBox5.Location = new System.Drawing.Point(212, 29);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox5, "Arena Keys");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SevenKnightsAI.Properties.Resources.icon_advkey;
            this.pictureBox3.Location = new System.Drawing.Point(50, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox3, "Adventure Keys");
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
            // honorLabel2
            // 
            this.honorLabel2.AutoSize = true;
            this.honorLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.honorLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
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
            this.rubyLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
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
            this.goldLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.goldLabel2.Location = new System.Drawing.Point(88, 0);
            this.goldLabel2.Name = "goldLabel2";
            this.goldLabel2.Size = new System.Drawing.Size(16, 18);
            this.goldLabel2.TabIndex = 1;
            this.goldLabel2.Text = "0";
            // 
            // summaryGroupBox
            // 
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
            // SmartModePictureBox
            // 
            this.SmartModePictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_smart;
            this.SmartModePictureBox.Location = new System.Drawing.Point(135, 82);
            this.SmartModePictureBox.Name = "SmartModePictureBox";
            this.SmartModePictureBox.Size = new System.Drawing.Size(32, 32);
            this.SmartModePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SmartModePictureBox.TabIndex = 10;
            this.SmartModePictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.SmartModePictureBox, "Gold Chamber");
            // 
            // arenaPictureBox
            // 
            this.arenaPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("arenaPictureBox.Image")));
            this.arenaPictureBox.Location = new System.Drawing.Point(251, 82);
            this.arenaPictureBox.Name = "arenaPictureBox";
            this.arenaPictureBox.Size = new System.Drawing.Size(32, 32);
            this.arenaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arenaPictureBox.TabIndex = 9;
            this.arenaPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.arenaPictureBox, "Arena");
            // 
            // adventurePictureBox
            // 
            this.adventurePictureBox.Image = global::SevenKnightsAI.Properties.Resources.icon_adv;
            this.adventurePictureBox.Location = new System.Drawing.Point(10, 82);
            this.adventurePictureBox.Name = "adventurePictureBox";
            this.adventurePictureBox.Size = new System.Drawing.Size(32, 32);
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
            // aiPause
            // 
            this.aiPause.Enabled = false;
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
            this.statusStrip.Size = new System.Drawing.Size(502, 22);
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
            this.splitterStatusLabel.Size = new System.Drawing.Size(347, 17);
            this.splitterStatusLabel.Spring = true;
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
            this.saveSettingsButton.Location = new System.Drawing.Point(225, 46);
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
            // topheaderPictureBox
            // 
            this.topheaderPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topheaderPictureBox.Image = global::SevenKnightsAI.Properties.Resources.lubu_cover;
            this.topheaderPictureBox.Location = new System.Drawing.Point(0, 0);
            this.topheaderPictureBox.Name = "topheaderPictureBox";
            this.topheaderPictureBox.Size = new System.Drawing.Size(508, 90);
            this.topheaderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topheaderPictureBox.TabIndex = 0;
            this.topheaderPictureBox.TabStop = false;
            // 
            // RS_sellHeroesCheckBox
            // 
            this.RS_sellHeroesCheckBox.AutoSize = true;
            this.RS_sellHeroesCheckBox.Location = new System.Drawing.Point(7, 20);
            this.RS_sellHeroesCheckBox.Name = "RS_sellHeroesCheckBox";
            this.RS_sellHeroesCheckBox.Size = new System.Drawing.Size(220, 17);
            this.RS_sellHeroesCheckBox.TabIndex = 2;
            this.RS_sellHeroesCheckBox.Tag = "0";
            this.RS_sellHeroesCheckBox.Text = "Lv.30 heroes with ★ less than or equal to";
            this.toolTip.SetToolTip(this.RS_sellHeroesCheckBox, "BETA Function");
            this.RS_sellHeroesCheckBox.UseVisualStyleBackColor = true;
            this.RS_sellHeroesCheckBox.CheckedChanged += new System.EventHandler(this.RS_sellCheckBox_CheckedChanged);
            // 
            // RS_sendHonorsFacebook
            // 
            this.RS_sendHonorsFacebook.AutoSize = true;
            this.RS_sendHonorsFacebook.Location = new System.Drawing.Point(7, 20);
            this.RS_sendHonorsFacebook.Name = "RS_sendHonorsFacebook";
            this.RS_sendHonorsFacebook.Size = new System.Drawing.Size(127, 17);
            this.RS_sendHonorsFacebook.TabIndex = 0;
            this.RS_sendHonorsFacebook.Tag = "0";
            this.RS_sendHonorsFacebook.Text = "To Facebook Friends";
            this.toolTip.SetToolTip(this.RS_sendHonorsFacebook, "BETA Function");
            this.RS_sendHonorsFacebook.UseVisualStyleBackColor = true;
            this.RS_sendHonorsFacebook.CheckedChanged += new System.EventHandler(this.RS_sendHonorsCheckBox_CheckedChanged);
            // 
            // RS_sendHonorsInGame
            // 
            this.RS_sendHonorsInGame.AutoSize = true;
            this.RS_sendHonorsInGame.Location = new System.Drawing.Point(7, 44);
            this.RS_sendHonorsInGame.Name = "RS_sendHonorsInGame";
            this.RS_sendHonorsInGame.Size = new System.Drawing.Size(119, 17);
            this.RS_sendHonorsInGame.TabIndex = 1;
            this.RS_sendHonorsInGame.Tag = "1";
            this.RS_sendHonorsInGame.Text = "To In-Game Friends";
            this.toolTip.SetToolTip(this.RS_sendHonorsInGame, "BETA Function");
            this.RS_sendHonorsInGame.UseVisualStyleBackColor = true;
            this.RS_sendHonorsInGame.CheckedChanged += new System.EventHandler(this.RS_sendHonorsCheckBox_CheckedChanged);
            // 
            // AD_difficultyComboBox
            // 
            this.AD_difficultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_difficultyComboBox.FormattingEnabled = true;
            this.AD_difficultyComboBox.Items.AddRange(new object[] {
            "--",
            "Easy",
            "Normal",
            "Hard"});
            this.AD_difficultyComboBox.Location = new System.Drawing.Point(69, 95);
            this.AD_difficultyComboBox.MaxDropDownItems = 3;
            this.AD_difficultyComboBox.Name = "AD_difficultyComboBox";
            this.AD_difficultyComboBox.Size = new System.Drawing.Size(60, 21);
            this.AD_difficultyComboBox.TabIndex = 7;
            this.toolTip.SetToolTip(this.AD_difficultyComboBox, "For Map 1 to Map 7");
            this.AD_difficultyComboBox.SelectedValueChanged += new System.EventHandler(this.AD_difficultyComboBox_SelectedValueChanged);
            // 
            // AD_difficultyComboBox2nd
            // 
            this.AD_difficultyComboBox2nd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AD_difficultyComboBox2nd.FormattingEnabled = true;
            this.AD_difficultyComboBox2nd.Items.AddRange(new object[] {
            "--",
            "Easy",
            "Normal",
            "Hard"});
            this.AD_difficultyComboBox2nd.Location = new System.Drawing.Point(69, 129);
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
            this.GB_WaitForKeys.ForeColor = System.Drawing.Color.Blue;
            this.GB_WaitForKeys.Location = new System.Drawing.Point(6, 65);
            this.GB_WaitForKeys.Name = "GB_WaitForKeys";
            this.GB_WaitForKeys.Size = new System.Drawing.Size(72, 17);
            this.GB_WaitForKeys.TabIndex = 11;
            this.GB_WaitForKeys.Text = "Wait on 0";
            this.toolTip.SetToolTip(this.GB_WaitForKeys, "Wait Key");
            this.GB_WaitForKeys.UseVisualStyleBackColor = true;
            this.GB_WaitForKeys.CheckedChanged += new System.EventHandler(this.GB_WaitForKeys_CheckedChanged);
            // 
            // button1
            // 
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
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SevenKnightsAI.Properties.Resources.icon_item;
            this.pictureBox4.Location = new System.Drawing.Point(6, 73);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox4, "Arena Keys");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SevenKnightsAI.Properties.Resources.icon_card;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox1, "Arena Keys");
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::SevenKnightsAI.Properties.Resources.icon_ess;
            this.pictureBox11.Location = new System.Drawing.Point(364, 19);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(26, 28);
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
            this.pictureBox14.Size = new System.Drawing.Size(26, 28);
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
            this.pictureBox17.Size = new System.Drawing.Size(26, 28);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 14;
            this.pictureBox17.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox17, "Gold");
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::SevenKnightsAI.Properties.Resources.icon_scale;
            this.pictureBox10.Location = new System.Drawing.Point(275, 60);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(26, 28);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 16;
            this.pictureBox10.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox10, "Gold");
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::SevenKnightsAI.Properties.Resources.icon_horn;
            this.pictureBox7.Location = new System.Drawing.Point(81, 60);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(26, 28);
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
            this.tabControl1.Location = new System.Drawing.Point(0, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 456);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Controls.Add(this.groupBox10);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox8);
            this.tabPage4.ImageKey = "icon-2pages.gif";
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(500, 429);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Report";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.logsBox);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Controls.Add(this.button3);
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(237, 197);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Auto Scroll";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LG_clearButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(359, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 27);
            this.button4.TabIndex = 28;
            this.button4.Text = "Test Button";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.timer);
            this.groupBox1.Controls.Add(this.botstatusLabel);
            this.groupBox1.Location = new System.Drawing.Point(174, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 82);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Time :";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.Green;
            this.timer.Location = new System.Drawing.Point(77, 45);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(64, 18);
            this.timer.TabIndex = 18;
            this.timer.Text = "00:00:00";
            // 
            // botstatusLabel
            // 
            this.botstatusLabel.AutoSize = true;
            this.botstatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botstatusLabel.ForeColor = System.Drawing.Color.Red;
            this.botstatusLabel.Location = new System.Drawing.Point(38, 18);
            this.botstatusLabel.Name = "botstatusLabel";
            this.botstatusLabel.Size = new System.Drawing.Size(90, 18);
            this.botstatusLabel.TabIndex = 20;
            this.botstatusLabel.Text = "Bot Stopped";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.pictureBox4);
            this.groupBox9.Controls.Add(this.pictureBox1);
            this.groupBox9.Controls.Add(this.itemslotLabel);
            this.groupBox9.Controls.Add(this.heroslotLabel);
            this.groupBox9.Location = new System.Drawing.Point(335, 203);
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
            this.itemslotLabel.Location = new System.Drawing.Point(64, 77);
            this.itemslotLabel.Name = "itemslotLabel";
            this.itemslotLabel.Size = new System.Drawing.Size(13, 18);
            this.itemslotLabel.TabIndex = 26;
            this.itemslotLabel.Text = "-";
            // 
            // heroslotLabel
            // 
            this.heroslotLabel.AutoSize = true;
            this.heroslotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroslotLabel.Location = new System.Drawing.Point(64, 25);
            this.heroslotLabel.Name = "heroslotLabel";
            this.heroslotLabel.Size = new System.Drawing.Size(13, 18);
            this.heroslotLabel.TabIndex = 5;
            this.heroslotLabel.Text = "-";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.goldadvLabel);
            this.groupBox10.Controls.Add(this.label9);
            this.groupBox10.Location = new System.Drawing.Point(341, 115);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(153, 82);
            this.groupBox10.TabIndex = 33;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Adventure";
            // 
            // goldadvLabel
            // 
            this.goldadvLabel.AutoSize = true;
            this.goldadvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldadvLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.goldadvLabel.Location = new System.Drawing.Point(72, 16);
            this.goldadvLabel.Name = "goldadvLabel";
            this.goldadvLabel.Size = new System.Drawing.Size(16, 18);
            this.goldadvLabel.TabIndex = 28;
            this.goldadvLabel.Tag = "";
            this.goldadvLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Hero 30:";
            // 
            // groupBox4
            // 
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
            this.groupBox4.Text = "Smart Mode Resources";
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
            this.scaleLabel.Location = new System.Drawing.Point(307, 64);
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
            this.starLabel.Location = new System.Drawing.Point(226, 25);
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
            this.goldencrystalLabel.Location = new System.Drawing.Point(38, 25);
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
            this.hornLabel.Location = new System.Drawing.Point(113, 66);
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
            this.label25.Location = new System.Drawing.Point(104, 22);
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
            this.tabPage5.ImageKey = "offer_inter.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(500, 429);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Mode";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage11);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage17);
            this.tabControl2.Location = new System.Drawing.Point(-4, 0);
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
            this.tabControl5.Location = new System.Drawing.Point(-4, 0);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(508, 404);
            this.tabControl5.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox23);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(500, 378);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Control";
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.AD_CheckSlot_CheckBox);
            this.groupBox23.Controls.Add(this.GB_WaitForKeys);
            this.groupBox23.Controls.Add(this.AD_EnHottime_Checkbox);
            this.groupBox23.Controls.Add(this.AD_NoHeroUp_Checkbox);
            this.groupBox23.Controls.Add(this.AD_limitLabel);
            this.groupBox23.Controls.Add(this.AD_limitNumericBox);
            this.groupBox23.Controls.Add(this.AD_limitCheckBox);
            this.groupBox23.Controls.Add(this.AD_enableCheckBox);
            this.groupBox23.Controls.Add(this.AD_StopOnFullItems_Checkbox);
            this.groupBox23.Controls.Add(this.AD_StopOnFullHeroes_Checkbox);
            this.groupBox23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox23.Location = new System.Drawing.Point(8, 6);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(486, 121);
            this.groupBox23.TabIndex = 0;
            this.groupBox23.TabStop = false;
            // 
            // AD_CheckSlot_CheckBox
            // 
            this.AD_CheckSlot_CheckBox.AutoSize = true;
            this.AD_CheckSlot_CheckBox.Location = new System.Drawing.Point(274, 86);
            this.AD_CheckSlot_CheckBox.Name = "AD_CheckSlot_CheckBox";
            this.AD_CheckSlot_CheckBox.Size = new System.Drawing.Size(136, 17);
            this.AD_CheckSlot_CheckBox.TabIndex = 26;
            this.AD_CheckSlot_CheckBox.Text = "Check Slot Hero && Item";
            this.AD_CheckSlot_CheckBox.UseVisualStyleBackColor = true;
            this.AD_CheckSlot_CheckBox.CheckedChanged += new System.EventHandler(this.AD_CheckSlot_CheckBox_CheckedChanged);
            // 
            // AD_EnHottime_Checkbox
            // 
            this.AD_EnHottime_Checkbox.AutoSize = true;
            this.AD_EnHottime_Checkbox.Location = new System.Drawing.Point(6, 19);
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
            this.AD_NoHeroUp_Checkbox.Location = new System.Drawing.Point(6, 42);
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
            this.AD_limitLabel.Location = new System.Drawing.Point(379, 20);
            this.AD_limitLabel.Name = "AD_limitLabel";
            this.AD_limitLabel.Size = new System.Drawing.Size(70, 13);
            this.AD_limitLabel.TabIndex = 16;
            this.AD_limitLabel.Text = "times per visit";
            // 
            // AD_limitNumericBox
            // 
            this.AD_limitNumericBox.Location = new System.Drawing.Point(324, 17);
            this.AD_limitNumericBox.Maximum = new decimal(new int[] {
            200,
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
            this.AD_limitCheckBox.Location = new System.Drawing.Point(274, 19);
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
            this.AD_StopOnFullItems_Checkbox.Location = new System.Drawing.Point(274, 63);
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
            this.AD_StopOnFullHeroes_Checkbox.Location = new System.Drawing.Point(274, 40);
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
            this.groupBox5.Controls.Add(this.AD_BoostModeAllMapsRadio);
            this.groupBox5.Controls.Add(this.AD_BoostModeAsgarRadio);
            this.groupBox5.Controls.Add(this.AD_bootmodeCheckBox);
            this.groupBox5.Location = new System.Drawing.Point(223, 114);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(263, 63);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            // 
            // AD_BoostModeAllMapsRadio
            // 
            this.AD_BoostModeAllMapsRadio.AutoSize = true;
            this.AD_BoostModeAllMapsRadio.Enabled = false;
            this.AD_BoostModeAllMapsRadio.Location = new System.Drawing.Point(118, 25);
            this.AD_BoostModeAllMapsRadio.Name = "AD_BoostModeAllMapsRadio";
            this.AD_BoostModeAllMapsRadio.Size = new System.Drawing.Size(65, 17);
            this.AD_BoostModeAllMapsRadio.TabIndex = 30;
            this.AD_BoostModeAllMapsRadio.TabStop = true;
            this.AD_BoostModeAllMapsRadio.Text = "All Maps";
            this.AD_BoostModeAllMapsRadio.UseVisualStyleBackColor = true;
            this.AD_BoostModeAllMapsRadio.CheckedChanged += new System.EventHandler(this.AD_BoostModeAllMapsRadio_CheckedChanged);
            // 
            // AD_BoostModeAsgarRadio
            // 
            this.AD_BoostModeAsgarRadio.AutoSize = true;
            this.AD_BoostModeAsgarRadio.Enabled = false;
            this.AD_BoostModeAsgarRadio.Location = new System.Drawing.Point(12, 25);
            this.AD_BoostModeAsgarRadio.Name = "AD_BoostModeAsgarRadio";
            this.AD_BoostModeAsgarRadio.Size = new System.Drawing.Size(100, 17);
            this.AD_BoostModeAsgarRadio.TabIndex = 29;
            this.AD_BoostModeAsgarRadio.TabStop = true;
            this.AD_BoostModeAsgarRadio.Text = "Asgar Map Only";
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
            this.ADCH_ChangeHeroGroupBox.Controls.Add(this.AD_teamLabel);
            this.ADCH_ChangeHeroGroupBox.Controls.Add(this.AD_teamComboBox2);
            this.ADCH_ChangeHeroGroupBox.Controls.Add(this.AD_teamComboBox);
            this.ADCH_ChangeHeroGroupBox.Location = new System.Drawing.Point(223, 6);
            this.ADCH_ChangeHeroGroupBox.Name = "ADCH_ChangeHeroGroupBox";
            this.ADCH_ChangeHeroGroupBox.Size = new System.Drawing.Size(266, 59);
            this.ADCH_ChangeHeroGroupBox.TabIndex = 18;
            this.ADCH_ChangeHeroGroupBox.TabStop = false;
            this.ADCH_ChangeHeroGroupBox.Text = "Change Hero Setting";
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
            this.AD_teamComboBox2.Enabled = false;
            this.AD_teamComboBox2.FormattingEnabled = true;
            this.AD_teamComboBox2.Items.AddRange(new object[] {
            "--",
            "A",
            "B",
            "C"});
            this.AD_teamComboBox2.Location = new System.Drawing.Point(164, 22);
            this.AD_teamComboBox2.Name = "AD_teamComboBox2";
            this.AD_teamComboBox2.Size = new System.Drawing.Size(60, 21);
            this.AD_teamComboBox2.TabIndex = 28;
            this.AD_teamComboBox2.Tag = "0";
            this.AD_teamComboBox2.Visible = false;
            this.AD_teamComboBox2.SelectedIndexChanged += new System.EventHandler(this.AD_teamComboBox2_SelectedIndexChanged);
            // 
            // AD_teamComboBox
            // 
            this.AD_teamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.groupBox26.Location = new System.Drawing.Point(223, 71);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(263, 112);
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
            this.groupBox27.Size = new System.Drawing.Size(211, 177);
            this.groupBox27.TabIndex = 0;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Map Setting";
            // 
            // AD_difficultyLabel
            // 
            this.AD_difficultyLabel.Location = new System.Drawing.Point(6, 103);
            this.AD_difficultyLabel.Name = "AD_difficultyLabel";
            this.AD_difficultyLabel.Size = new System.Drawing.Size(54, 13);
            this.AD_difficultyLabel.TabIndex = 6;
            this.AD_difficultyLabel.Text = "Difficulty";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 128);
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
            "12 - Shadow\'s EYE"});
            this.AD_worldComboBox.Location = new System.Drawing.Point(69, 16);
            this.AD_worldComboBox.Name = "AD_worldComboBox";
            this.AD_worldComboBox.Size = new System.Drawing.Size(127, 21);
            this.AD_worldComboBox.TabIndex = 1;
            this.AD_worldComboBox.SelectedIndexChanged += new System.EventHandler(this.AD_worldComboBox_SelectedIndexChanged);
            // 
            // AD_stageComboBox
            // 
            this.AD_stageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.tabPage11.Controls.Add(this.groupBox11);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(500, 403);
            this.tabPage11.TabIndex = 8;
            this.tabPage11.Text = "Smart Mode";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.SM_EnableCheckBox);
            this.groupBox11.Controls.Add(this.SM_CollectTartarusCheckBox);
            this.groupBox11.Controls.Add(this.SM_CollectRaidCheckBox);
            this.groupBox11.Controls.Add(this.SM_CollectTowerCheckBox);
            this.groupBox11.Location = new System.Drawing.Point(8, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(486, 68);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            // 
            // SM_EnableCheckBox
            // 
            this.SM_EnableCheckBox.AutoSize = true;
            this.SM_EnableCheckBox.Location = new System.Drawing.Point(6, 0);
            this.SM_EnableCheckBox.Name = "SM_EnableCheckBox";
            this.SM_EnableCheckBox.Size = new System.Drawing.Size(119, 17);
            this.SM_EnableCheckBox.TabIndex = 4;
            this.SM_EnableCheckBox.Text = "Enable Smart Mode";
            this.SM_EnableCheckBox.UseVisualStyleBackColor = true;
            this.SM_EnableCheckBox.CheckedChanged += new System.EventHandler(this.SM_EnableCheckBox_CheckedChanged);
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
            this.label18.Location = new System.Drawing.Point(170, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "pts";
            // 
            // AR_limitNumericBox
            // 
            this.AR_limitNumericBox.Location = new System.Drawing.Point(59, 21);
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
            this.AR_useRubyNumericBox.Name = "AR_useRubyNumericBox";
            this.AR_useRubyNumericBox.Size = new System.Drawing.Size(37, 20);
            this.AR_useRubyNumericBox.TabIndex = 11;
            this.AR_useRubyNumericBox.ValueChanged += new System.EventHandler(this.AR_useRubyNumericBox_ValueChanged);
            // 
            // AR_stopArenaNumericBox
            // 
            this.AR_stopArenaNumericBox.Location = new System.Drawing.Point(116, 70);
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
            this.tabPage17.Controls.Add(this.RS_buyKeysGroupBox);
            this.tabPage17.Controls.Add(this.RS_sendHonorsGroupBox);
            this.tabPage17.Controls.Add(this.RS_collectQuestsGroupBox);
            this.tabPage17.Controls.Add(this.RS_sellingGroupBox);
            this.tabPage17.Controls.Add(this.RS_inboxGroupBox);
            this.tabPage17.Location = new System.Drawing.Point(4, 22);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Size = new System.Drawing.Size(500, 403);
            this.tabPage17.TabIndex = 5;
            this.tabPage17.Text = "Resources";
            // 
            // RS_buyKeysGroupBox
            // 
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyRubiesLabel);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyRubiesNumericBox);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyRubiesComboBox);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyRubiesCheckBox);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyHonorsLabel);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyHonorsNumericBox);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyHonorsComboBox);
            this.RS_buyKeysGroupBox.Controls.Add(this.RS_buyKeyHonorsCheckBox);
            this.RS_buyKeysGroupBox.Location = new System.Drawing.Point(169, 267);
            this.RS_buyKeysGroupBox.Name = "RS_buyKeysGroupBox";
            this.RS_buyKeysGroupBox.Size = new System.Drawing.Size(325, 80);
            this.RS_buyKeysGroupBox.TabIndex = 5;
            this.RS_buyKeysGroupBox.TabStop = false;
            this.RS_buyKeysGroupBox.Text = "Buy Keys";
            // 
            // RS_buyKeyRubiesLabel
            // 
            this.RS_buyKeyRubiesLabel.Location = new System.Drawing.Point(256, 49);
            this.RS_buyKeyRubiesLabel.Name = "RS_buyKeyRubiesLabel";
            this.RS_buyKeyRubiesLabel.Size = new System.Drawing.Size(35, 13);
            this.RS_buyKeyRubiesLabel.TabIndex = 7;
            this.RS_buyKeyRubiesLabel.Text = "times";
            // 
            // RS_buyKeyRubiesNumericBox
            // 
            this.RS_buyKeyRubiesNumericBox.Location = new System.Drawing.Point(213, 45);
            this.RS_buyKeyRubiesNumericBox.Name = "RS_buyKeyRubiesNumericBox";
            this.RS_buyKeyRubiesNumericBox.Size = new System.Drawing.Size(37, 20);
            this.RS_buyKeyRubiesNumericBox.TabIndex = 6;
            this.RS_buyKeyRubiesNumericBox.Tag = "1";
            this.RS_buyKeyRubiesNumericBox.ValueChanged += new System.EventHandler(this.RS_buyKeysNumericBox_ValueChanged);
            // 
            // RS_buyKeyRubiesComboBox
            // 
            this.RS_buyKeyRubiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS_buyKeyRubiesComboBox.FormattingEnabled = true;
            this.RS_buyKeyRubiesComboBox.Items.AddRange(new object[] {
            "5 Keys with 10 Rubies",
            "10 Keys with 20 Rubies",
            "20 Keys with 35 Rubies",
            "40 Keys with 45 Rubies",
            "100 Keys with 100 Rubbies"});
            this.RS_buyKeyRubiesComboBox.Location = new System.Drawing.Point(57, 44);
            this.RS_buyKeyRubiesComboBox.Name = "RS_buyKeyRubiesComboBox";
            this.RS_buyKeyRubiesComboBox.Size = new System.Drawing.Size(150, 21);
            this.RS_buyKeyRubiesComboBox.TabIndex = 5;
            this.RS_buyKeyRubiesComboBox.Tag = "1";
            this.RS_buyKeyRubiesComboBox.SelectedIndexChanged += new System.EventHandler(this.RS_buyKeysComboBox_SelectedIndexChanged);
            // 
            // RS_buyKeyRubiesCheckBox
            // 
            this.RS_buyKeyRubiesCheckBox.AutoSize = true;
            this.RS_buyKeyRubiesCheckBox.Location = new System.Drawing.Point(7, 48);
            this.RS_buyKeyRubiesCheckBox.Name = "RS_buyKeyRubiesCheckBox";
            this.RS_buyKeyRubiesCheckBox.Size = new System.Drawing.Size(44, 17);
            this.RS_buyKeyRubiesCheckBox.TabIndex = 4;
            this.RS_buyKeyRubiesCheckBox.Tag = "1";
            this.RS_buyKeyRubiesCheckBox.Text = "Buy";
            this.RS_buyKeyRubiesCheckBox.UseVisualStyleBackColor = true;
            this.RS_buyKeyRubiesCheckBox.CheckedChanged += new System.EventHandler(this.RS_buyKeysCheckBox_CheckedChanged);
            // 
            // RS_buyKeyHonorsLabel
            // 
            this.RS_buyKeyHonorsLabel.Location = new System.Drawing.Point(256, 21);
            this.RS_buyKeyHonorsLabel.Name = "RS_buyKeyHonorsLabel";
            this.RS_buyKeyHonorsLabel.Size = new System.Drawing.Size(35, 13);
            this.RS_buyKeyHonorsLabel.TabIndex = 3;
            this.RS_buyKeyHonorsLabel.Text = "times";
            // 
            // RS_buyKeyHonorsNumericBox
            // 
            this.RS_buyKeyHonorsNumericBox.Location = new System.Drawing.Point(213, 17);
            this.RS_buyKeyHonorsNumericBox.Name = "RS_buyKeyHonorsNumericBox";
            this.RS_buyKeyHonorsNumericBox.Size = new System.Drawing.Size(37, 20);
            this.RS_buyKeyHonorsNumericBox.TabIndex = 2;
            this.RS_buyKeyHonorsNumericBox.Tag = "0";
            this.RS_buyKeyHonorsNumericBox.ValueChanged += new System.EventHandler(this.RS_buyKeysNumericBox_ValueChanged);
            // 
            // RS_buyKeyHonorsComboBox
            // 
            this.RS_buyKeyHonorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS_buyKeyHonorsComboBox.FormattingEnabled = true;
            this.RS_buyKeyHonorsComboBox.Items.AddRange(new object[] {
            "1 Key with 10 Honors",
            "10 Keys with 100 Honors"});
            this.RS_buyKeyHonorsComboBox.Location = new System.Drawing.Point(57, 16);
            this.RS_buyKeyHonorsComboBox.Name = "RS_buyKeyHonorsComboBox";
            this.RS_buyKeyHonorsComboBox.Size = new System.Drawing.Size(150, 21);
            this.RS_buyKeyHonorsComboBox.TabIndex = 1;
            this.RS_buyKeyHonorsComboBox.Tag = "0";
            this.RS_buyKeyHonorsComboBox.SelectedIndexChanged += new System.EventHandler(this.RS_buyKeysComboBox_SelectedIndexChanged);
            // 
            // RS_buyKeyHonorsCheckBox
            // 
            this.RS_buyKeyHonorsCheckBox.AutoSize = true;
            this.RS_buyKeyHonorsCheckBox.Location = new System.Drawing.Point(7, 20);
            this.RS_buyKeyHonorsCheckBox.Name = "RS_buyKeyHonorsCheckBox";
            this.RS_buyKeyHonorsCheckBox.Size = new System.Drawing.Size(44, 17);
            this.RS_buyKeyHonorsCheckBox.TabIndex = 0;
            this.RS_buyKeyHonorsCheckBox.Tag = "0";
            this.RS_buyKeyHonorsCheckBox.Text = "Buy";
            this.RS_buyKeyHonorsCheckBox.UseVisualStyleBackColor = true;
            this.RS_buyKeyHonorsCheckBox.CheckedChanged += new System.EventHandler(this.RS_buyKeysCheckBox_CheckedChanged);
            // 
            // RS_sendHonorsGroupBox
            // 
            this.RS_sendHonorsGroupBox.Controls.Add(this.RS_giftsGroupBox);
            this.RS_sendHonorsGroupBox.Controls.Add(this.RS_sendHonorsInGame);
            this.RS_sendHonorsGroupBox.Controls.Add(this.RS_sendHonorsFacebook);
            this.RS_sendHonorsGroupBox.Location = new System.Drawing.Point(9, 267);
            this.RS_sendHonorsGroupBox.Name = "RS_sendHonorsGroupBox";
            this.RS_sendHonorsGroupBox.Size = new System.Drawing.Size(146, 80);
            this.RS_sendHonorsGroupBox.TabIndex = 4;
            this.RS_sendHonorsGroupBox.TabStop = false;
            this.RS_sendHonorsGroupBox.Text = "Send Honors";
            // 
            // RS_giftsGroupBox
            // 
            this.RS_giftsGroupBox.Controls.Add(this.RS_luckyBoxCheckBox);
            this.RS_giftsGroupBox.Controls.Add(this.RS_luckyChestCheckBox);
            this.RS_giftsGroupBox.Enabled = false;
            this.RS_giftsGroupBox.Location = new System.Drawing.Point(62, 86);
            this.RS_giftsGroupBox.Name = "RS_giftsGroupBox";
            this.RS_giftsGroupBox.Size = new System.Drawing.Size(168, 18);
            this.RS_giftsGroupBox.TabIndex = 2;
            this.RS_giftsGroupBox.TabStop = false;
            this.RS_giftsGroupBox.Text = "Gifts";
            this.RS_giftsGroupBox.Visible = false;
            // 
            // RS_luckyBoxCheckBox
            // 
            this.RS_luckyBoxCheckBox.AutoSize = true;
            this.RS_luckyBoxCheckBox.Location = new System.Drawing.Point(7, 44);
            this.RS_luckyBoxCheckBox.Name = "RS_luckyBoxCheckBox";
            this.RS_luckyBoxCheckBox.Size = new System.Drawing.Size(111, 17);
            this.RS_luckyBoxCheckBox.TabIndex = 1;
            this.RS_luckyBoxCheckBox.Tag = "1";
            this.RS_luckyBoxCheckBox.Text = "Collect Lucky Box";
            this.RS_luckyBoxCheckBox.UseVisualStyleBackColor = true;
            this.RS_luckyBoxCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectGiftCheckBox_CheckedChanged);
            // 
            // RS_luckyChestCheckBox
            // 
            this.RS_luckyChestCheckBox.AutoSize = true;
            this.RS_luckyChestCheckBox.Location = new System.Drawing.Point(7, 20);
            this.RS_luckyChestCheckBox.Name = "RS_luckyChestCheckBox";
            this.RS_luckyChestCheckBox.Size = new System.Drawing.Size(150, 17);
            this.RS_luckyChestCheckBox.TabIndex = 0;
            this.RS_luckyChestCheckBox.Tag = "0";
            this.RS_luckyChestCheckBox.Text = "Collect May\'s Lucky Chest";
            this.RS_luckyChestCheckBox.UseVisualStyleBackColor = true;
            this.RS_luckyChestCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectGiftCheckBox_CheckedChanged);
            // 
            // RS_collectQuestsGroupBox
            // 
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsSocialCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsItemCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsHeroCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsBattleCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_specialQuestsMonthlyCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_specialQuestsWeeklyCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_specialQuestsDailyCheckBox);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsNormalLabel);
            this.RS_collectQuestsGroupBox.Controls.Add(this.RS_questsSpecialLabel);
            this.RS_collectQuestsGroupBox.Location = new System.Drawing.Point(9, 165);
            this.RS_collectQuestsGroupBox.Name = "RS_collectQuestsGroupBox";
            this.RS_collectQuestsGroupBox.Size = new System.Drawing.Size(485, 96);
            this.RS_collectQuestsGroupBox.TabIndex = 3;
            this.RS_collectQuestsGroupBox.TabStop = false;
            this.RS_collectQuestsGroupBox.Text = "Collect Quests";
            // 
            // RS_questsSocialCheckBox
            // 
            this.RS_questsSocialCheckBox.AutoSize = true;
            this.RS_questsSocialCheckBox.Location = new System.Drawing.Point(406, 57);
            this.RS_questsSocialCheckBox.Name = "RS_questsSocialCheckBox";
            this.RS_questsSocialCheckBox.Size = new System.Drawing.Size(55, 17);
            this.RS_questsSocialCheckBox.TabIndex = 8;
            this.RS_questsSocialCheckBox.Tag = "6";
            this.RS_questsSocialCheckBox.Text = "Social";
            this.RS_questsSocialCheckBox.UseVisualStyleBackColor = true;
            this.RS_questsSocialCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_questsItemCheckBox
            // 
            this.RS_questsItemCheckBox.AutoSize = true;
            this.RS_questsItemCheckBox.Location = new System.Drawing.Point(294, 58);
            this.RS_questsItemCheckBox.Name = "RS_questsItemCheckBox";
            this.RS_questsItemCheckBox.Size = new System.Drawing.Size(46, 17);
            this.RS_questsItemCheckBox.TabIndex = 7;
            this.RS_questsItemCheckBox.Tag = "5";
            this.RS_questsItemCheckBox.Text = "Item";
            this.RS_questsItemCheckBox.UseVisualStyleBackColor = true;
            this.RS_questsItemCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_questsHeroCheckBox
            // 
            this.RS_questsHeroCheckBox.AutoSize = true;
            this.RS_questsHeroCheckBox.Location = new System.Drawing.Point(170, 54);
            this.RS_questsHeroCheckBox.Name = "RS_questsHeroCheckBox";
            this.RS_questsHeroCheckBox.Size = new System.Drawing.Size(49, 17);
            this.RS_questsHeroCheckBox.TabIndex = 6;
            this.RS_questsHeroCheckBox.Tag = "4";
            this.RS_questsHeroCheckBox.Text = "Hero";
            this.RS_questsHeroCheckBox.UseVisualStyleBackColor = true;
            this.RS_questsHeroCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_questsBattleCheckBox
            // 
            this.RS_questsBattleCheckBox.AutoSize = true;
            this.RS_questsBattleCheckBox.Location = new System.Drawing.Point(62, 57);
            this.RS_questsBattleCheckBox.Name = "RS_questsBattleCheckBox";
            this.RS_questsBattleCheckBox.Size = new System.Drawing.Size(53, 17);
            this.RS_questsBattleCheckBox.TabIndex = 5;
            this.RS_questsBattleCheckBox.Tag = "3";
            this.RS_questsBattleCheckBox.Text = "Battle";
            this.RS_questsBattleCheckBox.UseVisualStyleBackColor = true;
            this.RS_questsBattleCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_specialQuestsMonthlyCheckBox
            // 
            this.RS_specialQuestsMonthlyCheckBox.AutoSize = true;
            this.RS_specialQuestsMonthlyCheckBox.Location = new System.Drawing.Point(336, 20);
            this.RS_specialQuestsMonthlyCheckBox.Name = "RS_specialQuestsMonthlyCheckBox";
            this.RS_specialQuestsMonthlyCheckBox.Size = new System.Drawing.Size(63, 17);
            this.RS_specialQuestsMonthlyCheckBox.TabIndex = 4;
            this.RS_specialQuestsMonthlyCheckBox.Tag = "2";
            this.RS_specialQuestsMonthlyCheckBox.Text = "Monthly";
            this.RS_specialQuestsMonthlyCheckBox.UseVisualStyleBackColor = true;
            this.RS_specialQuestsMonthlyCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_specialQuestsWeeklyCheckBox
            // 
            this.RS_specialQuestsWeeklyCheckBox.AutoSize = true;
            this.RS_specialQuestsWeeklyCheckBox.Location = new System.Drawing.Point(221, 19);
            this.RS_specialQuestsWeeklyCheckBox.Name = "RS_specialQuestsWeeklyCheckBox";
            this.RS_specialQuestsWeeklyCheckBox.Size = new System.Drawing.Size(62, 17);
            this.RS_specialQuestsWeeklyCheckBox.TabIndex = 3;
            this.RS_specialQuestsWeeklyCheckBox.Tag = "1";
            this.RS_specialQuestsWeeklyCheckBox.Text = "Weekly";
            this.RS_specialQuestsWeeklyCheckBox.UseVisualStyleBackColor = true;
            this.RS_specialQuestsWeeklyCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_specialQuestsDailyCheckBox
            // 
            this.RS_specialQuestsDailyCheckBox.AutoSize = true;
            this.RS_specialQuestsDailyCheckBox.Location = new System.Drawing.Point(119, 20);
            this.RS_specialQuestsDailyCheckBox.Name = "RS_specialQuestsDailyCheckBox";
            this.RS_specialQuestsDailyCheckBox.Size = new System.Drawing.Size(49, 17);
            this.RS_specialQuestsDailyCheckBox.TabIndex = 2;
            this.RS_specialQuestsDailyCheckBox.Tag = "0";
            this.RS_specialQuestsDailyCheckBox.Text = "Daily";
            this.RS_specialQuestsDailyCheckBox.UseVisualStyleBackColor = true;
            this.RS_specialQuestsDailyCheckBox.CheckedChanged += new System.EventHandler(this.RS_collectQuestsCheckBox_CheckedChanged);
            // 
            // RS_questsNormalLabel
            // 
            this.RS_questsNormalLabel.AutoSize = true;
            this.RS_questsNormalLabel.Location = new System.Drawing.Point(7, 58);
            this.RS_questsNormalLabel.Name = "RS_questsNormalLabel";
            this.RS_questsNormalLabel.Size = new System.Drawing.Size(43, 13);
            this.RS_questsNormalLabel.TabIndex = 1;
            this.RS_questsNormalLabel.Text = "Normal:";
            // 
            // RS_questsSpecialLabel
            // 
            this.RS_questsSpecialLabel.AutoSize = true;
            this.RS_questsSpecialLabel.Location = new System.Drawing.Point(7, 20);
            this.RS_questsSpecialLabel.Name = "RS_questsSpecialLabel";
            this.RS_questsSpecialLabel.Size = new System.Drawing.Size(45, 13);
            this.RS_questsSpecialLabel.TabIndex = 0;
            this.RS_questsSpecialLabel.Text = "Special:";
            // 
            // RS_sellingGroupBox
            // 
            this.RS_sellingGroupBox.Controls.Add(this.RS_itemRadioPanel);
            this.RS_sellingGroupBox.Controls.Add(this.RS_heroRadioPanel);
            this.RS_sellingGroupBox.Controls.Add(this.RS_itemAmountNumericBox);
            this.RS_sellingGroupBox.Controls.Add(this.RS_heroAmountNumericBox);
            this.RS_sellingGroupBox.Controls.Add(this.RS_itemStarsComboBox);
            this.RS_sellingGroupBox.Controls.Add(this.RS_heroStarsComboBox);
            this.RS_sellingGroupBox.Controls.Add(this.RS_sellHeroesCheckBox);
            this.RS_sellingGroupBox.Controls.Add(this.RS_sellItemsCheckBox);
            this.RS_sellingGroupBox.Location = new System.Drawing.Point(9, 3);
            this.RS_sellingGroupBox.Name = "RS_sellingGroupBox";
            this.RS_sellingGroupBox.Size = new System.Drawing.Size(485, 95);
            this.RS_sellingGroupBox.TabIndex = 0;
            this.RS_sellingGroupBox.TabStop = false;
            this.RS_sellingGroupBox.Text = "Selling";
            // 
            // RS_itemRadioPanel
            // 
            this.RS_itemRadioPanel.Controls.Add(this.RS_itemAmountRadioButton);
            this.RS_itemRadioPanel.Controls.Add(this.RS_itemAllRadioButton);
            this.RS_itemRadioPanel.Enabled = false;
            this.RS_itemRadioPanel.Location = new System.Drawing.Point(310, 52);
            this.RS_itemRadioPanel.Name = "RS_itemRadioPanel";
            this.RS_itemRadioPanel.Size = new System.Drawing.Size(108, 25);
            this.RS_itemRadioPanel.TabIndex = 11;
            this.RS_itemRadioPanel.Tag = "1";
            // 
            // RS_itemAmountRadioButton
            // 
            this.RS_itemAmountRadioButton.Enabled = false;
            this.RS_itemAmountRadioButton.Location = new System.Drawing.Point(46, 4);
            this.RS_itemAmountRadioButton.Name = "RS_itemAmountRadioButton";
            this.RS_itemAmountRadioButton.Size = new System.Drawing.Size(61, 17);
            this.RS_itemAmountRadioButton.TabIndex = 10;
            this.RS_itemAmountRadioButton.TabStop = true;
            this.RS_itemAmountRadioButton.Tag = "1";
            this.RS_itemAmountRadioButton.Text = "Amount";
            this.RS_itemAmountRadioButton.UseVisualStyleBackColor = true;
            this.RS_itemAmountRadioButton.Visible = false;
            // 
            // RS_itemAllRadioButton
            // 
            this.RS_itemAllRadioButton.AutoSize = true;
            this.RS_itemAllRadioButton.Enabled = false;
            this.RS_itemAllRadioButton.Location = new System.Drawing.Point(3, 4);
            this.RS_itemAllRadioButton.Name = "RS_itemAllRadioButton";
            this.RS_itemAllRadioButton.Size = new System.Drawing.Size(36, 17);
            this.RS_itemAllRadioButton.TabIndex = 9;
            this.RS_itemAllRadioButton.TabStop = true;
            this.RS_itemAllRadioButton.Tag = "1";
            this.RS_itemAllRadioButton.Text = "All";
            this.RS_itemAllRadioButton.UseVisualStyleBackColor = true;
            this.RS_itemAllRadioButton.Visible = false;
            this.RS_itemAllRadioButton.CheckedChanged += new System.EventHandler(this.RS_sellAllRadioButton_CheckedChanged);
            // 
            // RS_heroRadioPanel
            // 
            this.RS_heroRadioPanel.Controls.Add(this.RS_heroAmountRadioButton);
            this.RS_heroRadioPanel.Controls.Add(this.RS_heroAllRadioButton);
            this.RS_heroRadioPanel.Location = new System.Drawing.Point(310, 16);
            this.RS_heroRadioPanel.Name = "RS_heroRadioPanel";
            this.RS_heroRadioPanel.Size = new System.Drawing.Size(108, 25);
            this.RS_heroRadioPanel.TabIndex = 2;
            this.RS_heroRadioPanel.Tag = "0";
            // 
            // RS_heroAmountRadioButton
            // 
            this.RS_heroAmountRadioButton.Location = new System.Drawing.Point(46, 4);
            this.RS_heroAmountRadioButton.Name = "RS_heroAmountRadioButton";
            this.RS_heroAmountRadioButton.Size = new System.Drawing.Size(63, 17);
            this.RS_heroAmountRadioButton.TabIndex = 10;
            this.RS_heroAmountRadioButton.TabStop = true;
            this.RS_heroAmountRadioButton.Tag = "0";
            this.RS_heroAmountRadioButton.Text = "Amount";
            this.RS_heroAmountRadioButton.UseVisualStyleBackColor = true;
            // 
            // RS_heroAllRadioButton
            // 
            this.RS_heroAllRadioButton.AutoSize = true;
            this.RS_heroAllRadioButton.Location = new System.Drawing.Point(3, 4);
            this.RS_heroAllRadioButton.Name = "RS_heroAllRadioButton";
            this.RS_heroAllRadioButton.Size = new System.Drawing.Size(36, 17);
            this.RS_heroAllRadioButton.TabIndex = 9;
            this.RS_heroAllRadioButton.TabStop = true;
            this.RS_heroAllRadioButton.Tag = "0";
            this.RS_heroAllRadioButton.Text = "All";
            this.RS_heroAllRadioButton.UseVisualStyleBackColor = true;
            this.RS_heroAllRadioButton.CheckedChanged += new System.EventHandler(this.RS_sellAllRadioButton_CheckedChanged);
            // 
            // RS_itemAmountNumericBox
            // 
            this.RS_itemAmountNumericBox.Enabled = false;
            this.RS_itemAmountNumericBox.Location = new System.Drawing.Point(427, 52);
            this.RS_itemAmountNumericBox.Name = "RS_itemAmountNumericBox";
            this.RS_itemAmountNumericBox.Size = new System.Drawing.Size(37, 20);
            this.RS_itemAmountNumericBox.TabIndex = 8;
            this.RS_itemAmountNumericBox.Tag = "1";
            this.RS_itemAmountNumericBox.Visible = false;
            this.RS_itemAmountNumericBox.ValueChanged += new System.EventHandler(this.RS_sellAmountNumericBox_ValueChanged);
            // 
            // RS_heroAmountNumericBox
            // 
            this.RS_heroAmountNumericBox.Location = new System.Drawing.Point(427, 17);
            this.RS_heroAmountNumericBox.Name = "RS_heroAmountNumericBox";
            this.RS_heroAmountNumericBox.Size = new System.Drawing.Size(37, 20);
            this.RS_heroAmountNumericBox.TabIndex = 7;
            this.RS_heroAmountNumericBox.Tag = "0";
            this.RS_heroAmountNumericBox.ValueChanged += new System.EventHandler(this.RS_sellAmountNumericBox_ValueChanged);
            // 
            // RS_itemStarsComboBox
            // 
            this.RS_itemStarsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS_itemStarsComboBox.FormattingEnabled = true;
            this.RS_itemStarsComboBox.Items.AddRange(new object[] {
            "★",
            "★★",
            "★★★",
            "★★★★"});
            this.RS_itemStarsComboBox.Location = new System.Drawing.Point(226, 54);
            this.RS_itemStarsComboBox.Name = "RS_itemStarsComboBox";
            this.RS_itemStarsComboBox.Size = new System.Drawing.Size(78, 21);
            this.RS_itemStarsComboBox.TabIndex = 4;
            this.RS_itemStarsComboBox.Tag = "1";
            this.RS_itemStarsComboBox.SelectedIndexChanged += new System.EventHandler(this.RS_sellStarsComboBox_SelectedIndexChanged);
            // 
            // RS_heroStarsComboBox
            // 
            this.RS_heroStarsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RS_heroStarsComboBox.FormattingEnabled = true;
            this.RS_heroStarsComboBox.Items.AddRange(new object[] {
            "★",
            "★★"});
            this.RS_heroStarsComboBox.Location = new System.Drawing.Point(226, 18);
            this.RS_heroStarsComboBox.Name = "RS_heroStarsComboBox";
            this.RS_heroStarsComboBox.Size = new System.Drawing.Size(78, 21);
            this.RS_heroStarsComboBox.TabIndex = 3;
            this.RS_heroStarsComboBox.Tag = "0";
            this.RS_heroStarsComboBox.SelectedIndexChanged += new System.EventHandler(this.RS_sellStarsComboBox_SelectedIndexChanged);
            // 
            // RS_sellItemsCheckBox
            // 
            this.RS_sellItemsCheckBox.AutoSize = true;
            this.RS_sellItemsCheckBox.Location = new System.Drawing.Point(7, 56);
            this.RS_sellItemsCheckBox.Name = "RS_sellItemsCheckBox";
            this.RS_sellItemsCheckBox.Size = new System.Drawing.Size(207, 17);
            this.RS_sellItemsCheckBox.TabIndex = 0;
            this.RS_sellItemsCheckBox.Tag = "1";
            this.RS_sellItemsCheckBox.Text = "Every item with ★ less than or equal to";
            this.RS_sellItemsCheckBox.UseVisualStyleBackColor = true;
            this.RS_sellItemsCheckBox.CheckedChanged += new System.EventHandler(this.RS_sellCheckBox_CheckedChanged);
            // 
            // RS_inboxGroupBox
            // 
            this.RS_inboxGroupBox.Controls.Add(this.RS_InboxCurrency);
            this.RS_inboxGroupBox.Controls.Add(this.RS_InboxKeys);
            this.RS_inboxGroupBox.Controls.Add(this.RS_inboxMaterials);
            this.RS_inboxGroupBox.Controls.Add(this.RS_inboxHonors);
            this.RS_inboxGroupBox.Location = new System.Drawing.Point(9, 104);
            this.RS_inboxGroupBox.Name = "RS_inboxGroupBox";
            this.RS_inboxGroupBox.Size = new System.Drawing.Size(485, 55);
            this.RS_inboxGroupBox.TabIndex = 1;
            this.RS_inboxGroupBox.TabStop = false;
            this.RS_inboxGroupBox.Text = "Collect Inbox";
            // 
            // RS_InboxCurrency
            // 
            this.RS_InboxCurrency.AutoSize = true;
            this.RS_InboxCurrency.Location = new System.Drawing.Point(242, 23);
            this.RS_InboxCurrency.Name = "RS_InboxCurrency";
            this.RS_InboxCurrency.Size = new System.Drawing.Size(68, 17);
            this.RS_InboxCurrency.TabIndex = 3;
            this.RS_InboxCurrency.Tag = "2";
            this.RS_InboxCurrency.Text = "Currency";
            this.RS_InboxCurrency.UseVisualStyleBackColor = true;
            this.RS_InboxCurrency.CheckedChanged += new System.EventHandler(this.RS_collectInboxCheckBox_CheckedChanged);
            // 
            // RS_InboxKeys
            // 
            this.RS_InboxKeys.AutoSize = true;
            this.RS_InboxKeys.Location = new System.Drawing.Point(119, 23);
            this.RS_InboxKeys.Name = "RS_InboxKeys";
            this.RS_InboxKeys.Size = new System.Drawing.Size(49, 17);
            this.RS_InboxKeys.TabIndex = 2;
            this.RS_InboxKeys.Tag = "1";
            this.RS_InboxKeys.Text = "Keys";
            this.RS_InboxKeys.UseVisualStyleBackColor = true;
            this.RS_InboxKeys.CheckedChanged += new System.EventHandler(this.RS_collectInboxCheckBox_CheckedChanged);
            // 
            // RS_inboxMaterials
            // 
            this.RS_inboxMaterials.AutoSize = true;
            this.RS_inboxMaterials.Location = new System.Drawing.Point(387, 23);
            this.RS_inboxMaterials.Name = "RS_inboxMaterials";
            this.RS_inboxMaterials.Size = new System.Drawing.Size(68, 17);
            this.RS_inboxMaterials.TabIndex = 1;
            this.RS_inboxMaterials.Tag = "3";
            this.RS_inboxMaterials.Text = "Materials";
            this.RS_inboxMaterials.UseVisualStyleBackColor = true;
            this.RS_inboxMaterials.CheckedChanged += new System.EventHandler(this.RS_collectInboxCheckBox_CheckedChanged);
            // 
            // RS_inboxHonors
            // 
            this.RS_inboxHonors.AutoSize = true;
            this.RS_inboxHonors.Location = new System.Drawing.Point(7, 23);
            this.RS_inboxHonors.Name = "RS_inboxHonors";
            this.RS_inboxHonors.Size = new System.Drawing.Size(60, 17);
            this.RS_inboxHonors.TabIndex = 0;
            this.RS_inboxHonors.Tag = "0";
            this.RS_inboxHonors.Text = "Honors";
            this.RS_inboxHonors.UseVisualStyleBackColor = true;
            this.RS_inboxHonors.CheckedChanged += new System.EventHandler(this.RS_collectInboxCheckBox_CheckedChanged);
            // 
            // tabPage18
            // 
            this.tabPage18.Controls.Add(this.tabControl6);
            this.tabPage18.ImageKey = "icon_setting.png";
            this.tabPage18.Location = new System.Drawing.Point(4, 23);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Size = new System.Drawing.Size(500, 429);
            this.tabPage18.TabIndex = 2;
            this.tabPage18.Text = "Setting";
            // 
            // tabControl6
            // 
            this.tabControl6.Controls.Add(this.tabPage19);
            this.tabControl6.Controls.Add(this.tabPage20);
            this.tabControl6.Controls.Add(this.tabPage21);
            this.tabControl6.Location = new System.Drawing.Point(-4, 0);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(508, 433);
            this.tabControl6.TabIndex = 0;
            // 
            // tabPage19
            // 
            this.tabPage19.Controls.Add(this.groupBox38);
            this.tabPage19.Location = new System.Drawing.Point(4, 22);
            this.tabPage19.Name = "tabPage19";
            this.tabPage19.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage19.Size = new System.Drawing.Size(500, 407);
            this.tabPage19.TabIndex = 0;
            this.tabPage19.Text = "Option";
            // 
            // groupBox38
            // 
            this.groupBox38.Controls.Add(this.button5);
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
            this.groupBox38.Size = new System.Drawing.Size(486, 119);
            this.groupBox38.TabIndex = 0;
            this.groupBox38.TabStop = false;
            this.groupBox38.Text = "Delay Setting";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(304, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 27);
            this.button5.TabIndex = 29;
            this.button5.Text = "Test Bluestacks";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            this.tabPage21.Controls.Add(this.groupBox3);
            this.tabPage21.Location = new System.Drawing.Point(4, 22);
            this.tabPage21.Name = "tabPage21";
            this.tabPage21.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage21.Size = new System.Drawing.Size(500, 407);
            this.tabPage21.TabIndex = 1;
            this.tabPage21.Text = "Remote Bot";
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
            this.screenshotButton.Location = new System.Drawing.Point(16, 87);
            this.screenshotButton.Name = "screenshotButton";
            this.screenshotButton.Size = new System.Drawing.Size(102, 27);
            this.screenshotButton.TabIndex = 17;
            this.screenshotButton.Text = "&Save Profile";
            this.screenshotButton.UseVisualStyleBackColor = true;
            this.screenshotButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
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
            // MainForm
            // 
            this.AcceptButton = this.aiButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(502, 741);
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
            this.Text = "Seven Knights OpenBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_opacityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_reconnectNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ST_delayTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmartModePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arenaPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventurePictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topheaderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
            this.RS_buyKeysGroupBox.ResumeLayout(false);
            this.RS_buyKeysGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_buyKeyRubiesNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_buyKeyHonorsNumericBox)).EndInit();
            this.RS_sendHonorsGroupBox.ResumeLayout(false);
            this.RS_sendHonorsGroupBox.PerformLayout();
            this.RS_giftsGroupBox.ResumeLayout(false);
            this.RS_giftsGroupBox.PerformLayout();
            this.RS_collectQuestsGroupBox.ResumeLayout(false);
            this.RS_collectQuestsGroupBox.PerformLayout();
            this.RS_sellingGroupBox.ResumeLayout(false);
            this.RS_sellingGroupBox.PerformLayout();
            this.RS_itemRadioPanel.ResumeLayout(false);
            this.RS_itemRadioPanel.PerformLayout();
            this.RS_heroRadioPanel.ResumeLayout(false);
            this.RS_heroRadioPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RS_itemAmountNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RS_heroAmountNumericBox)).EndInit();
            this.RS_inboxGroupBox.ResumeLayout(false);
            this.RS_inboxGroupBox.PerformLayout();
            this.tabPage18.ResumeLayout(false);
            this.tabControl6.ResumeLayout(false);
            this.tabPage19.ResumeLayout(false);
            this.groupBox38.ResumeLayout(false);
            this.groupBox38.PerformLayout();
            this.tabPage20.ResumeLayout(false);
            this.groupBox39.ResumeLayout(false);
            this.groupBox39.PerformLayout();
            this.tabPage21.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.resourcesTableLayoutPanel.ResumeLayout(false);
            this.resourcesTableLayoutPanel.PerformLayout();
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
        private System.Windows.Forms.Timer timer2;
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
        private System.Windows.Forms.GroupBox RS_buyKeysGroupBox;
        private System.Windows.Forms.Label RS_buyKeyRubiesLabel;
        private System.Windows.Forms.NumericUpDown RS_buyKeyRubiesNumericBox;
        private System.Windows.Forms.ComboBox RS_buyKeyRubiesComboBox;
        private System.Windows.Forms.CheckBox RS_buyKeyRubiesCheckBox;
        private System.Windows.Forms.Label RS_buyKeyHonorsLabel;
        private System.Windows.Forms.NumericUpDown RS_buyKeyHonorsNumericBox;
        private System.Windows.Forms.ComboBox RS_buyKeyHonorsComboBox;
        private System.Windows.Forms.CheckBox RS_buyKeyHonorsCheckBox;
        private System.Windows.Forms.GroupBox RS_sendHonorsGroupBox;
        private System.Windows.Forms.GroupBox RS_giftsGroupBox;
        private System.Windows.Forms.CheckBox RS_luckyBoxCheckBox;
        private System.Windows.Forms.CheckBox RS_luckyChestCheckBox;
        private System.Windows.Forms.CheckBox RS_sendHonorsInGame;
        private System.Windows.Forms.CheckBox RS_sendHonorsFacebook;
        private System.Windows.Forms.GroupBox RS_collectQuestsGroupBox;
        private System.Windows.Forms.CheckBox RS_questsSocialCheckBox;
        private System.Windows.Forms.CheckBox RS_questsItemCheckBox;
        private System.Windows.Forms.CheckBox RS_questsHeroCheckBox;
        private System.Windows.Forms.CheckBox RS_questsBattleCheckBox;
        private System.Windows.Forms.CheckBox RS_specialQuestsMonthlyCheckBox;
        private System.Windows.Forms.CheckBox RS_specialQuestsWeeklyCheckBox;
        private System.Windows.Forms.CheckBox RS_specialQuestsDailyCheckBox;
        private System.Windows.Forms.Label RS_questsNormalLabel;
        private System.Windows.Forms.Label RS_questsSpecialLabel;
        private System.Windows.Forms.GroupBox RS_sellingGroupBox;
        private System.Windows.Forms.Panel RS_itemRadioPanel;
        private System.Windows.Forms.RadioButton RS_itemAmountRadioButton;
        private System.Windows.Forms.RadioButton RS_itemAllRadioButton;
        private System.Windows.Forms.Panel RS_heroRadioPanel;
        private System.Windows.Forms.RadioButton RS_heroAmountRadioButton;
        private System.Windows.Forms.RadioButton RS_heroAllRadioButton;
        private System.Windows.Forms.NumericUpDown RS_itemAmountNumericBox;
        private System.Windows.Forms.NumericUpDown RS_heroAmountNumericBox;
        private System.Windows.Forms.ComboBox RS_itemStarsComboBox;
        private System.Windows.Forms.ComboBox RS_heroStarsComboBox;
        private System.Windows.Forms.CheckBox RS_sellHeroesCheckBox;
        private System.Windows.Forms.CheckBox RS_sellItemsCheckBox;
        private System.Windows.Forms.GroupBox RS_inboxGroupBox;
        private System.Windows.Forms.CheckBox RS_InboxCurrency;
        private System.Windows.Forms.CheckBox RS_InboxKeys;
        private System.Windows.Forms.CheckBox RS_inboxMaterials;
        private System.Windows.Forms.CheckBox RS_inboxHonors;
        private System.Windows.Forms.PictureBox SmartModePictureBox;
        private System.Windows.Forms.Label SmartModeCountLabel;
        private System.Windows.Forms.CheckBox SM_EnableCheckBox;
        private System.Windows.Forms.CheckBox AD_CheckSlot_CheckBox;
        private System.Windows.Forms.TableLayoutPanel resourcesTableLayoutPanel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox logsBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label botstatusLabel;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label itemslotLabel;
        private System.Windows.Forms.Label heroslotLabel;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label goldadvLabel;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.Button button5;
    }
}
