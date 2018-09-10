using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SevenKnightsAI.Classes
{
    public class AISettings
    {
        #region Public Fields

        [XmlElement(ElementName = "AD_AmountSequence")]
        public int[] AD_AmountSequence;

        [XmlElement(ElementName = "AD_Continuous")]
        public bool AD_Continuous;

        [XmlElement(ElementName = "AD_Difficulty")]
        public Difficulty AD_Difficulty;

        [XmlElement(ElementName = "AD_Difficulty2nd")]
        public Difficulty AD_Difficulty2nd;

        [XmlElement(ElementName = "AD_Enable")]
        public bool AD_Enable;

        [XmlElement(ElementName = "AD_HottimeEnable")]
        public bool AD_HottimeEnable;

        [XmlElement(ElementName = "AD_EnableLimit")]
        public bool AD_EnableLimit;

        [XmlElement(ElementName = "AD_Limit")]
        public int AD_Limit;

        [XmlElement(ElementName = "AD_Stage")]
        public int AD_Stage;

        [XmlElement(ElementName = "AD_StageSequence")]
        public int[] AD_StageSequence;

        [XmlElement(ElementName = "AD_StopOnFullHeroes")]
        public bool AD_StopOnFullHeroes;

        [XmlElement(ElementName = "AD_StopOnFullItems")]
        public bool AD_StopOnFullItems;

        [XmlElement(ElementName = "AD_CheckSlot")]
        public bool AD_CheckSlot;

        [XmlElement(ElementName = "AD_CheckingHeroes")]
        public bool AD_CheckingHeroes;

        [XmlElement(ElementName = "AD_Team")]
        public Team AD_Team;

        [XmlElement(ElementName = "AD2_Team")]
        public Team AD2_Team;

        [XmlElement(ElementName = "AD_World")]
        public World AD_World;

        [XmlElement(ElementName = "AD_WorldSequence")]
        public int[] AD_WorldSequence;

        [XmlElement(ElementName = "AD_UseFriend")]
        public bool AD_UseFriend;

        [XmlElement(ElementName = "AD_BootMode")]
        public bool AD_BootMode;

        [XmlElement(ElementName = "AR_Enable")]
        public bool AR_Enable;

        [XmlElement(ElementName = "AR_EnableLimit")]
        public bool AR_EnableLimit;

        [XmlElement(ElementName = "AR_Limit")]
        public int AR_Limit;

        [XmlElement(ElementName = "AR_Mastery")]
        public Mastery AR_Mastery;

        [XmlElement(ElementName = "AR_UseRuby")]
        public bool AR_UseRuby;

        [XmlElement(ElementName = "AR_LimitArena")]
        public bool AR_LimitArena;

        [XmlElement(ElementName = "AR_LimitScore")]
        public int AR_LimitScore;

        [XmlElement(ElementName = "AR_UseRubyAmount")]
        public int AR_UseRubyAmount;

        [XmlElement(ElementName = "GB_WaitForKeys")]
        public bool GB_WaitForKeys;

        [XmlElement(ElementName = "RS_BuyKeyHonors")]
        public bool RS_BuyKeyHonors;

        [XmlElement(ElementName = "RS_BuyKeyHonorsAmount")]
        public int RS_BuyKeyHonorsAmount;

        [XmlElement(ElementName = "RS_BuyKeyHonorsType")]
        public BuyKeyHonorsType RS_BuyKeyHonorsType;

        [XmlElement(ElementName = "RS_BuyKeyRubies")]
        public bool RS_BuyKeyRubies;

        [XmlElement(ElementName = "RS_BuyKeyRubiesAmount")]
        public int RS_BuyKeyRubiesAmount;

        [XmlElement(ElementName = "RS_BuyKeyRubiesType")]
        public BuyKeyRubiesType RS_BuyKeyRubiesType;

        [XmlElement(ElementName = "RS_CollectLuckyBox")]
        public bool RS_CollectLuckyBox;

        [XmlElement(ElementName = "RS_CollectLuckyChest")]
        public bool RS_CollectLuckyChest;

        [XmlElement(ElementName = "RS_InboxGold")]
        public bool RS_InboxGold;

        [XmlElement(ElementName = "RS_InboxHonors")]
        public bool RS_InboxHonors;

        [XmlElement(ElementName = "RS_InboxKeys")]
        public bool RS_InboxKeys;

        [XmlElement(ElementName = "RS_InboxRubies")]
        public bool RS_InboxRubies;

        [XmlElement(ElementName = "RS_InboxTickets")]
        public bool RS_InboxTickets;

        [XmlElement(ElementName = "RS_QuestsBattle")]
        public bool RS_QuestsBattle;

        [XmlElement(ElementName = "RS_QuestsHero")]
        public bool RS_QuestsHero;

        [XmlElement(ElementName = "RS_QuestsItem")]
        public bool RS_QuestsItem;

        [XmlElement(ElementName = "RS_QuestsSocial")]
        public bool RS_QuestsSocial;

        [XmlElement(ElementName = "RS_SellHeroAll")]
        public bool RS_SellHeroAll;

        [XmlElement(ElementName = "RS_SellHeroAmount")]
        public int RS_SellHeroAmount;

        [XmlElement(ElementName = "RS_SellHeroes")]
        public bool RS_SellHeroes;

        [XmlElement(ElementName = "RS_SellHeroStars")]
        public int RS_SellHeroStars;

        [XmlElement(ElementName = "RS_SellItemAll")]
        public bool RS_SellItemAll;

        [XmlElement(ElementName = "RS_SellItemAmount")]
        public int RS_SellItemAmount;

        [XmlElement(ElementName = "RS_SellItems")]
        public bool RS_SellItems;

        [XmlElement(ElementName = "RS_SellItemStars")]
        public int RS_SellItemStars;

        [XmlElement(ElementName = "RS_SendHonorsFacebook")]
        public bool RS_SendHonorsFacebook;

        [XmlElement(ElementName = "RS_SendHonorsInGame")]
        public bool RS_SendHonorsInGame;

        [XmlElement(ElementName = "RS_SpecialQuestsDaily")]
        public bool RS_SpecialQuestsDaily;

        [XmlElement(ElementName = "RS_SpecialQuestsMonthly")]
        public bool RS_SpecialQuestsMonthly;

        [XmlElement(ElementName = "RS_SpecialQuestsWeekly")]
        public bool RS_SpecialQuestsWeekly;

        [XmlElement(ElementName = "AD_CurrH30")]
        public int AD_CurrH30;

        [XmlElement(ElementName = "ST_Stop100")]
        public bool ST_Stop100;

        [XmlElement(ElementName = "EX_Enable")]
        public bool EX_Enable;

        [XmlElement(ElementName = "EX_Send")]
        public bool EX_Send;

        [XmlElement(ElementName = "AD_SummonAuto")]
        public bool AD_SummonAuto;

        [XmlElement(ElementName = "SM_CollectTower")]
        public bool SM_CollectTower;

        [XmlElement(ElementName = "SM_CollectRaid")]
        public bool SM_CollectRaid;

        [XmlElement(ElementName = "SM_CollectTartarus")]
        public bool SM_CollectTartarus;

        [XmlElement(ElementName = "SM_Enable")]
        public bool SM_Enable;


        public string Version = Application.ProductVersion;

        #endregion Public Fields

        #region Public Constructors

        public AISettings()
        {
            this.EX_Enable = true;
            this.EX_Send = true;
            this.AD_SummonAuto = true;
            this.SM_CollectRaid = false;
            this.SM_CollectTartarus = false;
            this.SM_Enable = false;
            this.SM_CollectTower = false;
            this.AD_Enable = true;
            this.AD_HottimeEnable = false;
            this.AD_EnableLimit = false;
            this.AD_Limit = 0;
            this.AD_Stage = 0;
            this.AD_Continuous = false;
            this.AD_StopOnFullHeroes = false;
            this.AD_StopOnFullItems = true;
            this.AD_CheckSlot = true;
            this.AD_CheckingHeroes = true;
            this.AD_UseFriend = false;
            this.AD_BootMode = false;
            this.GB_WaitForKeys = false;
            this.AR_Enable = true;
            this.AR_EnableLimit = false;
            this.AR_Limit = 0;
            this.AR_UseRuby = false;
            this.AR_LimitArena = false;
            this.AR_LimitScore = 4300;
            this.AR_UseRubyAmount = 0;
            this.RS_SellHeroes = false;
            this.RS_SellHeroStars = 1;
            this.RS_SellHeroAmount = 0;
            this.RS_SellHeroAll = true;
            this.RS_SellItems = false;
            this.RS_SellItemStars = 1;
            this.RS_SellItemAmount = 0;
            this.RS_SellItemAll = true;
            this.RS_InboxHonors = false;
            this.RS_InboxKeys = false;
            this.RS_InboxGold = false;
            this.RS_InboxRubies = false;
            this.RS_InboxTickets = false;
            this.RS_CollectLuckyChest = false;
            this.RS_CollectLuckyBox = false;
            this.RS_SpecialQuestsDaily = false;
            this.RS_SpecialQuestsWeekly = false;
            this.RS_SpecialQuestsMonthly = false;
            this.RS_QuestsBattle = false;
            this.RS_QuestsHero = false;
            this.RS_QuestsItem = false;
            this.RS_QuestsSocial = false;
            this.RS_SendHonorsFacebook = false;
            this.RS_SendHonorsInGame = false;
            this.RS_BuyKeyHonors = false;
            this.RS_BuyKeyHonorsType = BuyKeyHonorsType.Key1Honor10;
            this.RS_BuyKeyHonorsAmount = 0;
            this.RS_BuyKeyRubies = false;
            this.RS_BuyKeyRubiesType = BuyKeyRubiesType.Key5Ruby10;
            this.RS_BuyKeyRubiesAmount = 0;
            this.AD_CurrH30 = 0;
            this.ST_Stop100 = true;
        }

        #endregion Public Constructors

        #region Public Methods

        public static AISettings Load(string filePath)
        {
            if (File.Exists(filePath))
            {
                string value = File.ReadAllText(filePath);
                Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(value);
                AISettings aISettings = new AISettings();
                try
                {
                    aISettings.AD_SummonAuto = (bool)dictionary["AD_SummonAuto"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SM_CollectRaid = (bool)dictionary["SM_CollectRaid"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SM_CollectTartarus = (bool)dictionary["SM_CollectTartarus"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SM_Enable = (bool)dictionary["SM_Enable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.SM_CollectTower = (bool)dictionary["SM_CollectTower"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.EX_Enable = (bool)dictionary["EX_Enable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.EX_Send = (bool)dictionary["EX_Send"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Enable = (bool)dictionary["AD_Enable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_HottimeEnable = (bool)dictionary["AD_HottimeEnable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_EnableLimit = (bool)dictionary["AD_EnableLimit"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Limit = Convert.ToInt32(dictionary["AD_Limit"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Difficulty = (Difficulty)Convert.ToInt32(dictionary["AD_Difficulty"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Difficulty2nd = (Difficulty)Convert.ToInt32(dictionary["AD_Difficulty2nd"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_World = (World)Convert.ToInt32(dictionary["AD_World"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Stage = Convert.ToInt32(dictionary["AD_Stage"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_WorldSequence = ((dictionary["AD_WorldSequence"] == null) ? null : ((JArray)dictionary["AD_WorldSequence"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_StageSequence = ((dictionary["AD_StageSequence"] == null) ? null : ((JArray)dictionary["AD_StageSequence"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_AmountSequence = ((dictionary["AD_AmountSequence"] == null) ? null : ((JArray)dictionary["AD_AmountSequence"]).ToObject<int[]>());
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Continuous = (bool)dictionary["AD_Continuous"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Team = (Team)Convert.ToInt32(dictionary["AD_Team"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD2_Team = (Team)Convert.ToInt32(dictionary["AD2_Team"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_StopOnFullHeroes = (bool)dictionary["AD_StopOnFullHeroes"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_StopOnFullItems = (bool)dictionary["AD_StopOnFullItems"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_CheckSlot = (bool)dictionary["AD_CheckSlot"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_UseFriend = (bool)dictionary["AD_UseFriend"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_BootMode = (bool)dictionary["AD_BootMode"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_CheckingHeroes = (bool)dictionary["AD_CheckingHeroes"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.GB_WaitForKeys = (bool)dictionary["GB_WaitForKeys"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_Enable = (bool)dictionary["AR_Enable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_EnableLimit = (bool)dictionary["AR_EnableLimit"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_Limit = Convert.ToInt32(dictionary["AR_Limit"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_UseRuby = (bool)dictionary["AR_UseRuby"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_UseRubyAmount = Convert.ToInt32(dictionary["AR_UseRubyAmount"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_Mastery = (Mastery)Convert.ToInt32(dictionary["AR_Mastery"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_LimitArena = (bool)dictionary["AR_LimitArena"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AR_LimitScore = Convert.ToInt32(dictionary["AR_LimitScore"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellHeroes = (bool)dictionary["RS_SellHeroes"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellHeroStars = Convert.ToInt32(dictionary["RS_SellHeroStars"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellHeroAmount = Convert.ToInt32(dictionary["RS_SellHeroAmount"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellHeroAll = (bool)dictionary["RS_SellHeroAll"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellItems = (bool)dictionary["RS_SellItems"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellItemStars = Convert.ToInt32(dictionary["RS_SellItemStars"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellItemAmount = Convert.ToInt32(dictionary["RS_SellItemAmount"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SellItemAll = (bool)dictionary["RS_SellItemAll"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_InboxHonors = (bool)dictionary["RS_InboxHonors"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_InboxKeys = (bool)dictionary["RS_InboxKeys"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_InboxGold = (bool)dictionary["RS_InboxGold"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_InboxRubies = (bool)dictionary["RS_InboxRubies"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_InboxTickets = (bool)dictionary["RS_InboxTickets"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_CollectLuckyChest = (bool)dictionary["RS_CollectLuckyChest"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_CollectLuckyBox = (bool)dictionary["RS_CollectLuckyBox"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SpecialQuestsDaily = (bool)dictionary["RS_SpecialQuestsDaily"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SpecialQuestsWeekly = (bool)dictionary["RS_SpecialQuestsWeekly"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SpecialQuestsMonthly = (bool)dictionary["RS_SpecialQuestsMonthly"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_QuestsBattle = (bool)dictionary["RS_QuestsBattle"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_QuestsHero = (bool)dictionary["RS_QuestsHero"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_QuestsItem = (bool)dictionary["RS_QuestsItem"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_QuestsSocial = (bool)dictionary["RS_QuestsSocial"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SendHonorsFacebook = (bool)dictionary["RS_SendHonorsFacebook"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_SendHonorsInGame = (bool)dictionary["RS_SendHonorsInGame"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_BuyKeyHonors = (bool)dictionary["RS_BuyKeyHonors"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_BuyKeyHonorsType = (BuyKeyHonorsType)Convert.ToInt32(dictionary["RS_BuyKeyHonorsType"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_BuyKeyHonorsAmount = Convert.ToInt32(dictionary["RS_BuyKeyHonorsAmount"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_BuyKeyRubies = (bool)dictionary["RS_BuyKeyRubies"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_BuyKeyRubiesType = (BuyKeyRubiesType)Convert.ToInt32(dictionary["RS_BuyKeyRubiesType"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_BuyKeyRubiesAmount = Convert.ToInt32(dictionary["RS_BuyKeyRubiesAmount"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.ST_Stop100 = (bool)dictionary["ST_Stop100"];
                }
                catch (Exception)
                { }
                return aISettings;
            }
            throw new AISettingsException("Settings file not found", -1);
        }

        public void Save(string filePath)
        {
            Dictionary<string, object> value = new Dictionary<string, object>
            {
                {
                    "SM_CollectTower",
                    this.SM_CollectTower
                },
                {
                    "SM_Enable",
                    this.SM_Enable
                },
                {
                    "SM_CollectRaid",
                    this.SM_CollectRaid
                },
                {
                    "SM_CollectTartarus",
                    this.SM_CollectTartarus
                },
                {
                    "AD_Enable",
                    this.AD_Enable
                },
                {
                    "AD_EnableLimit",
                    this.AD_EnableLimit
                },
                {
                    "AD_Limit",
                    this.AD_Limit
                },
                {
                    "AD_Difficulty",
                    this.AD_Difficulty
                },
                {
                    "AD_Difficulty2nd",
                    this.AD_Difficulty2nd
                },
                {
                    "AD_World",
                    this.AD_World
                },
                {
                    "AD_Stage",
                    this.AD_Stage
                },
                {
                    "AD_WorldSequence",
                    this.AD_WorldSequence
                },
                {
                    "AD_StageSequence",
                    this.AD_StageSequence
                },
                {
                    "AD_AmountSequence",
                    this.AD_AmountSequence
                },
                {
                    "AD_Continuous",
                    this.AD_Continuous
                },
                {
                    "AD_Team",
                    this.AD_Team
                },
                {
                    "AD2_Team",
                    this.AD2_Team
                },
                {
                    "AD_StopOnFullHeroes",
                    this.AD_StopOnFullHeroes
                },
                {
                    "AD_StopOnFullItems",
                    this.AD_StopOnFullItems
                },
                {
                    "AD_CheckSlot",
                    this.AD_CheckSlot
                },
                {
                    "AD_CheckingHeroes",
                    this.AD_CheckingHeroes
                },

                {
                    "GB_WaitForKeys",
                    this.GB_WaitForKeys
                },

                {
                    "AR_Enable",
                    this.AR_Enable
                },
                {
                    "AR_EnableLimit",
                    this.AR_EnableLimit
                },
                {
                    "AR_Limit",
                    this.AR_Limit
                },
                {
                    "AR_UseRuby",
                    this.AR_UseRuby
                },
                {
                    "AR_UseRubyAmount",
                    this.AR_UseRubyAmount
                },
                {
                    "AR_Mastery",
                    this.AR_Mastery
                },
                {
                    "AR_LimitArena",
                    this.AR_LimitArena
                },
                {
                    "AR_LimitScore",
                    this.AR_LimitScore
                },

                {
                    "RS_SellHeroes",
                    this.RS_SellHeroes
                },
                {
                    "RS_SellHeroStars",
                    this.RS_SellHeroStars
                },
                {
                    "RS_SellHeroAmount",
                    this.RS_SellHeroAmount
                },
                {
                    "RS_SellHeroAll",
                    this.RS_SellHeroAll
                },
                {
                    "RS_SellItems",
                    this.RS_SellItems
                },
                {
                    "RS_SellItemStars",
                    this.RS_SellItemStars
                },
                {
                    "RS_SellItemAmount",
                    this.RS_SellItemAmount
                },
                {
                    "RS_SellItemAll",
                    this.RS_SellItemAll
                },
                {
                    "RS_InboxHonors",
                    this.RS_InboxHonors
                },
                {
                    "RS_InboxKeys",
                    this.RS_InboxKeys
                },
                {
                    "RS_InboxGold",
                    this.RS_InboxGold
                },
                {
                    "RS_InboxRubies",
                    this.RS_InboxRubies
                },
                {
                    "RS_InboxTickets",
                    this.RS_InboxTickets
                },
                {
                    "RS_CollectLuckyChest",
                    this.RS_CollectLuckyChest
                },
                {
                    "RS_CollectLuckyBox",
                    this.RS_CollectLuckyBox
                },
                {
                    "RS_SpecialQuestsDaily",
                    this.RS_SpecialQuestsDaily
                },
                {
                    "RS_SpecialQuestsWeekly",
                    this.RS_SpecialQuestsWeekly
                },
                {
                    "RS_SpecialQuestsMonthly",
                    this.RS_SpecialQuestsMonthly
                },
                {
                    "RS_QuestsBattle",
                    this.RS_QuestsBattle
                },
                {
                    "RS_QuestsHero",
                    this.RS_QuestsHero
                },
                {
                    "RS_QuestsItem",
                    this.RS_QuestsItem
                },
                {
                    "RS_QuestsSocial",
                    this.RS_QuestsSocial
                },
                {
                    "RS_SendHonorsFacebook",
                    this.RS_SendHonorsFacebook
                },
                {
                    "RS_SendHonorsInGame",
                    this.RS_SendHonorsInGame
                },
                {
                    "RS_BuyKeyHonors",
                    this.RS_BuyKeyHonors
                },
                {
                    "RS_BuyKeyHonorsType",
                    this.RS_BuyKeyHonorsType
                },
                {
                    "RS_BuyKeyHonorsAmount",
                    this.RS_BuyKeyHonorsAmount
                },
                {
                    "RS_BuyKeyRubies",
                    this.RS_BuyKeyRubies
                },
                {
                    "RS_BuyKeyRubiesType",
                    this.RS_BuyKeyRubiesType
                },
                {
                    "RS_BuyKeyRubiesAmount",
                    this.RS_BuyKeyRubiesAmount
                },
                {
                    "AD_HottimeEnable",
                    this.AD_HottimeEnable
                },
                {
                    "AD_UseFriend",
                    this.AD_UseFriend
                },
                {
                    "AD_BootMode",
                    this.AD_BootMode
                },
                {
                    "ST_Stop100",
                    this.ST_Stop100
                }
            };
            string data = JsonConvert.SerializeObject(value);
            File.WriteAllText(filePath, data);
        }

        #endregion Public Methods
    }
}