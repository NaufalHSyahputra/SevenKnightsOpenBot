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

        [XmlElement(ElementName = "AD_BoostSequence")]
        public int[] AD_BoostSequence;

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

        [XmlElement(ElementName = "AD_FarmOrder")]
        public int AD_FarmOrder;

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

        [XmlElement(ElementName = "AD_BoostAsgar")]
        public bool AD_BoostAsgar;

        [XmlElement(ElementName = "AD_BoostModeSequence")]
        public bool AD_BoostModeSequence;

        [XmlElement(ElementName = "AD_BoostAllMap")]
        public bool AD_BoostAllMap;

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

        [XmlElement(ElementName = "RS_SellGoldOre")]
        public bool RS_SellGoldOre;

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

        [XmlElement(ElementName = "RS_CollectInbox")]
        public bool RS_CollectInbox;

        [XmlElement(ElementName = "RS_EnableCI")]
        public bool RS_EnableCI;

        [XmlElement(ElementName = "RS_CIOnlyHonor")]
        public bool RS_CIOnlyHonor;

        [XmlElement(ElementName = "RS_CIOnlyKey")]
        public bool RS_CIOnlyKey;

        [XmlElement(ElementName = "RS_CIOnlyCurrency")]
        public bool RS_CIOnlyCurrency;

        [XmlElement(ElementName = "RS_CIOnlyTicket")]
        public bool RS_CIOnlyTicket;

        [XmlElement(ElementName = "RS_EnableCINoRuby")]
        public bool RS_EnableCINoRuby;

        [XmlElement(ElementName = "RS_CollectInboxActive")]
        public int RS_CollectInboxActive;

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

        [XmlElement(ElementName = "AD_CurrH30")]
        public int AD_CurrH30;

        [XmlElement(ElementName = "SM_CollectTower")]
        public bool SM_CollectTower;

        [XmlElement(ElementName = "SM_CollectRaid")]
        public bool SM_CollectRaid;

        [XmlElement(ElementName = "SM_CollectTartarus")]
        public bool SM_CollectTartarus;

        [XmlElement(ElementName = "SM_Enable")]
        public bool SM_Enable;

        [XmlElement(ElementName = "PU_Enable")]
        public bool PU_Enable;

        [XmlElement(ElementName = "PU_enableActive1")]
        public bool PU_enableActive1;

        [XmlElement(ElementName = "PU_Active1")]
        public int PU_Active1;

        [XmlElement(ElementName = "PU_enableActive2")]
        public bool PU_enableActive2;

        [XmlElement(ElementName = "PU_enableActive3")]
        public bool PU_enableActive3;

        [XmlElement(ElementName = "PU_1Star")]
        public bool PU_1Star;

        [XmlElement(ElementName = "PU_2Star")]
        public bool PU_2Star;

        [XmlElement(ElementName = "PU_3Star")]
        public bool PU_3Star;

        [XmlElement(ElementName = "PU_4Star")]
        public bool PU_4Star;

        [XmlElement(ElementName = "PU_1OnlyLv30")]
        public bool PU_1OnlyLv30;

        [XmlElement(ElementName = "PU_2OnlyLv30")]
        public bool PU_2OnlyLv30;

        [XmlElement(ElementName = "PU_3OnlyLv30")]
        public bool PU_3OnlyLv30;

        [XmlElement(ElementName = "PU_4OnlyLv30")]
        public bool PU_4OnlyLv30;

        [XmlElement(ElementName = "PU_1MOnlyLv30")]
        public bool PU_1MOnlyLv30;

        [XmlElement(ElementName = "PU_2MOnlyLv30")]
        public bool PU_2MOnlyLv30;

        [XmlElement(ElementName = "PU_3MOnlyLv30")]
        public bool PU_3MOnlyLv30;

        [XmlElement(ElementName = "PU_4MOnlyLv30")]
        public bool PU_4MOnlyLv30;

        [XmlElement(ElementName = "PU_1Material")]
        public int PU_1Material;

        [XmlElement(ElementName = "PU_1Condition")]
        public int PU_1Condition;

        [XmlElement(ElementName = "PU_2Condition")]
        public int PU_2Condition;

        [XmlElement(ElementName = "PU_3Condition")]
        public int PU_3Condition;

        [XmlElement(ElementName = "PU_2Material")]
        public int PU_2Material;

        [XmlElement(ElementName = "PU_3Material")]
        public int PU_3Material;

        [XmlElement(ElementName = "PU_4Material")]
        public int PU_4Material;

        [XmlElement(ElementName = "PU_1Order")]
        public int PU_1Order;

        [XmlElement(ElementName = "PU_2Order")]
        public int PU_2Order;

        [XmlElement(ElementName = "PU_3Order")]
        public int PU_3Order;

        [XmlElement(ElementName = "BF_Enable")]
        public bool BF_Enable;

        [XmlElement(ElementName = "BF_EnableActivate1")]
        public bool BF_EnableActivate1;

        [XmlElement(ElementName = "BF_EnableActivate2")]
        public bool BF_EnableActivate2;

        [XmlElement(ElementName = "BF_OnlyLv30")]
        public bool BF_OnlyLv30;

        [XmlElement(ElementName = "BF_StopMileage")]
        public bool BF_StopMileage;

        [XmlElement(ElementName = "BF_Rank")]
        public int BF_Rank;

        [XmlElement(ElementName = "BF_Active2")]
        public int BF_Active2;

        [XmlElement(ElementName = "CS_EnableActive1")]
        public bool CS_EnableActive1;

        [XmlElement(ElementName = "CS_Enable1")]
        public int CS_Enable1;

        [XmlElement(ElementName = "AD_Profile1")]
        public string AD_Profile1;

        [XmlElement(ElementName = "AD_Profile2")]
        public string AD_Profile2;

        [XmlElement(ElementName = "AD_Profile3")]
        public string AD_Profile3;

        [XmlElement(ElementName = "AD_EnableProfile1")]
        public bool AD_EnableProfile1;

        [XmlElement(ElementName = "AD_EnableProfile2")]
        public bool AD_EnableProfile2;

        [XmlElement(ElementName = "AD_EnableProfile3")]
        public bool AD_EnableProfile3;

        [XmlElement(ElementName = "AD_NoChangeMode")]
        public bool AD_NoChangeMode; 

        public string Version = Application.ProductVersion;

        #endregion Public Fields

        #region Public Constructors

        public AISettings()
        {
            SM_CollectRaid = false;
            SM_CollectTartarus = false;
            SM_Enable = false;
            PU_Enable = false;
            PU_enableActive1 = false;
            PU_enableActive2 = false;
            PU_enableActive3 = false;
            PU_1Star = false;
            PU_2Star = false;
            PU_3Star = false;
            PU_4Star = false;
            PU_1OnlyLv30 = false;
            PU_2OnlyLv30 = false;
            PU_3OnlyLv30 = false;
            PU_4OnlyLv30 = false;
            PU_1MOnlyLv30 = false;
            PU_2MOnlyLv30 = false;
            PU_3MOnlyLv30 = false;
            PU_4MOnlyLv30 = false;
            BF_Enable = false;
            BF_EnableActivate1 = false;
            BF_EnableActivate2 = false;
            BF_OnlyLv30 = false;
            BF_StopMileage = false;
            BF_Rank = 1;
            BF_Active2 = 1;
            PU_1Material = 1;
            PU_2Material = 1;
            PU_3Material = 1;
            PU_4Material = 1;
            CS_EnableActive1 = false;
            CS_Enable1 = 1;
            SM_CollectTower = false;
            AD_Enable = true;
            AD_HottimeEnable = false;
            AD_EnableLimit = false;
            AD_Limit = 0;
            AD_Stage = 0;
            AD_FarmOrder = 0;
            AD_Continuous = false;
            AD_StopOnFullHeroes = false;
            AD_StopOnFullItems = true;
            AD_CheckSlot = false;
            AD_CheckingHeroes = false;
            AD_UseFriend = false;
            AD_BootMode = false;
            AD_BoostAsgar = false;
            AD_BoostModeSequence = false;
            AD_BoostAllMap = false;
            GB_WaitForKeys = false;
            AR_Enable = true;
            AR_EnableLimit = false;
            AR_Limit = 0;
            AR_UseRuby = false;
            AR_LimitArena = false;
            AR_LimitScore = 4300;
            AR_UseRubyAmount = 0;
            RS_SellHeroes = false;
            RS_SellHeroStars = 1;
            RS_SellHeroAmount = 0;
            RS_SellHeroAll = true;
            RS_SellItems = false;
            RS_SellItemStars = 1;
            RS_SellItemAmount = 0;
            RS_SellItemAll = true;
            RS_InboxHonors = false;
            RS_InboxKeys = false;
            RS_InboxGold = false;
            RS_InboxRubies = false;
            RS_InboxTickets = false;
            RS_CollectLuckyChest = false;
            RS_CollectLuckyBox = false;
            RS_CollectInbox = false;
            RS_EnableCINoRuby = false;
            RS_CIOnlyHonor = false;
            RS_CIOnlyKey = false;
            RS_CIOnlyCurrency = false;
            RS_CIOnlyTicket = false;
            RS_EnableCI = false;
            RS_CollectInboxActive = 0;
            RS_BuyKeyHonors = false;
            RS_SellGoldOre = false;
            RS_BuyKeyHonorsType = BuyKeyHonorsType.Key1Honor10;
            RS_BuyKeyHonorsAmount = 0;
            RS_BuyKeyRubies = false;
            RS_BuyKeyRubiesType = BuyKeyRubiesType.Key5Ruby10;
            RS_BuyKeyRubiesAmount = 0;
            AD_CurrH30 = 0;
            PU_Active1 = 0;
            AD_Profile1 = null;
            AD_Profile2 = null;
            AD_Profile3 = null;
            AD_EnableProfile1 = false;
            AD_EnableProfile2 = false;
            AD_EnableProfile3 = false;
            AD_NoChangeMode = false;
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
                    aISettings.PU_Enable = (bool)dictionary["PU_Enable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_enableActive1 = (bool)dictionary["PU_enableActive1"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_enableActive2 = (bool)dictionary["PU_enableActive2"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_enableActive3 = (bool)dictionary["PU_enableActive3"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_1Star = (bool)dictionary["PU_1Star"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_2Star = (bool)dictionary["PU_2Star"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_3Star = (bool)dictionary["PU_3Star"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_4Star = (bool)dictionary["PU_4Star"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_1OnlyLv30 = (bool)dictionary["PU_1OnlyLv30"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_2OnlyLv30 = (bool)dictionary["PU_2OnlyLv30"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_3OnlyLv30 = (bool)dictionary["PU_3OnlyLv30"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_4OnlyLv30 = (bool)dictionary["PU_4OnlyLv30"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_1MOnlyLv30 = (bool)dictionary["PU_1MOnlyLv30"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_2MOnlyLv30 = (bool)dictionary["PU_2MOnlyLv30"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_3MOnlyLv30 = (bool)dictionary["PU_3MOnlyLv30"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_4MOnlyLv30 = (bool)dictionary["PU_4MOnlyLv30"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.BF_Enable = (bool)dictionary["BF_Enable"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.BF_EnableActivate1 = (bool)dictionary["BF_EnableActivate1"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.BF_EnableActivate2 = (bool)dictionary["BF_EnableActivate2"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.BF_OnlyLv30 = (bool)dictionary["BF_OnlyLv30"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.BF_StopMileage = (bool)dictionary["BF_StopMileage"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_Active1 = Convert.ToInt32(dictionary["PU_Active1"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.BF_Active2 = Convert.ToInt32(dictionary["BF_Active2"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.BF_Rank = Convert.ToInt32(dictionary["BF_Rank"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_1Material = Convert.ToInt32(dictionary["PU_1Material"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_1Condition = Convert.ToInt32(dictionary["PU_1Condition"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_2Condition = Convert.ToInt32(dictionary["PU_2Condition"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_3Condition = Convert.ToInt32(dictionary["PU_3Condition"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_1Order = Convert.ToInt32(dictionary["PU_1Order"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_2Order = Convert.ToInt32(dictionary["PU_2Order"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_3Order = Convert.ToInt32(dictionary["PU_3Order"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_2Material = Convert.ToInt32(dictionary["PU_2Material"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_3Material = Convert.ToInt32(dictionary["PU_3Material"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.PU_4Material = Convert.ToInt32(dictionary["PU_4Material"]);
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.CS_EnableActive1 = (bool)dictionary["CS_EnableActive1"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.CS_Enable1 = Convert.ToInt32(dictionary["CS_Enable1"]);
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
                    aISettings.AD_FarmOrder = Convert.ToInt32(dictionary["AD_FarmOrder"]);
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
                    aISettings.AD_BoostSequence = ((dictionary["AD_BoostSequence"] == null) ? null : ((JArray)dictionary["AD_BoostSequence"]).ToObject<int[]>());
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
                    aISettings.AD_BoostAsgar = (bool)dictionary["AD_BoostAsgar"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_BoostModeSequence = (bool)dictionary["AD_BoostModeSequence"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_BoostAllMap = (bool)dictionary["AD_BoostAllMap"];
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
                    aISettings.RS_CollectInbox = (bool)dictionary["RS_CollectInbox"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_EnableCINoRuby = (bool)dictionary["RS_EnableCINoRuby"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_CIOnlyHonor = (bool)dictionary["RS_CIOnlyHonor"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_CIOnlyKey = (bool)dictionary["RS_CIOnlyKey"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_CIOnlyCurrency = (bool)dictionary["RS_CIOnlyCurrency"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_CIOnlyTicket = (bool)dictionary["RS_CIOnlyTicket"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_EnableCI = (bool)dictionary["RS_EnableCI"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.RS_CollectInboxActive = Convert.ToInt32(dictionary["RS_CollectInboxActive"]);
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
                    aISettings.RS_SellGoldOre = (bool)dictionary["RS_SellGoldOre"];
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
                    aISettings.AD_Profile1 = (string)dictionary["AD_Profile1"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Profile2 = (string)dictionary["AD_Profile2"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_Profile3 = (string)dictionary["AD_Profile3"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_EnableProfile1 = (bool)dictionary["AD_EnableProfile1"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_EnableProfile2 = (bool)dictionary["AD_EnableProfile2"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_EnableProfile3 = (bool)dictionary["AD_EnableProfile3"];
                }
                catch (Exception)
                { }
                try
                {
                    aISettings.AD_NoChangeMode = (bool)dictionary["AD_NoChangeMode"];
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
                    SM_CollectTower
                },
                {
                    "SM_Enable",
                    SM_Enable
                },
                {
                    "PU_Enable",
                    PU_Enable
                },
                {
                    "PU_enableActive1",
                    PU_enableActive1
                },
                {
                    "PU_enableActive2",
                    PU_enableActive2
                },
                {
                    "PU_enableActive3",
                    PU_enableActive3
                },
                {
                    "PU_Active1",
                    PU_Active1
                },
                {
                    "PU_1Star",
                    PU_1Star
                },
                {
                    "PU_2Star",
                    PU_2Star
                },
                {
                    "PU_3Star",
                    PU_3Star
                },
                {
                    "PU_4Star",
                    PU_4Star
                },
                {
                    "PU_1OnlyLv30",
                    PU_1OnlyLv30
                },
                {
                    "PU_2OnlyLv30",
                    PU_2OnlyLv30
                },
                {
                    "PU_3OnlyLv30",
                    PU_3OnlyLv30
                },
                {
                    "PU_4OnlyLv30",
                    PU_4OnlyLv30
                },
                {
                    "PU_1MOnlyLv30",
                    PU_1MOnlyLv30
                },
                {
                    "PU_2MOnlyLv30",
                    PU_2MOnlyLv30
                },
                {
                    "PU_3MOnlyLv30",
                    PU_3MOnlyLv30
                },
                {
                    "PU_4MOnlyLv30",
                    PU_4MOnlyLv30
                },
                {
                    "PU_1Material",
                    PU_1Material
                },
                {
                    "PU_1Condition",
                    PU_1Condition
                },
                {
                    "PU_2Condition",
                    PU_2Condition
                },
                {
                    "PU_3Condition",
                    PU_3Condition
                },
                {
                    "PU_1Order",
                    PU_1Order
                },
                {
                    "PU_2Order",
                    PU_2Order
                },
                {
                    "PU_3Order",
                    PU_3Order
                },
                {
                    "PU_2Material",
                    PU_2Material
                },
                {
                    "PU_3Material",
                    PU_3Material
                },
                {
                    "PU_4Material",
                    PU_4Material
                },
                {
                    "BF_Enable",
                    BF_Enable
                },
                {
                    "BF_EnableActivate1",
                    BF_EnableActivate1
                },
                {
                    "BF_EnableActivate2",
                    BF_EnableActivate2
                },
                {
                    "BF_Active2",
                    BF_Active2
                },
                {
                    "BF_OnlyLv30",
                    BF_OnlyLv30
                },
                {
                    "BF_StopMileage",
                    BF_StopMileage
                },
                {
                    "BF_Rank",
                    BF_Rank
                },
                {
                    "CS_Enable1",
                    CS_Enable1
                },
                {
                    "CS_EnableActive1",
                    CS_EnableActive1
                },
                {
                    "SM_CollectRaid",
                    SM_CollectRaid
                },
                {
                    "SM_CollectTartarus",
                    SM_CollectTartarus
                },
                {
                    "AD_Enable",
                    AD_Enable
                },
                {
                    "AD_EnableLimit",
                    AD_EnableLimit
                },
                {
                    "AD_Limit",
                    AD_Limit
                },
                {
                    "AD_Difficulty",
                    AD_Difficulty
                },
                {
                    "AD_Difficulty2nd",
                    AD_Difficulty2nd
                },
                {
                    "AD_World",
                    AD_World
                },
                {
                    "AD_Stage",
                    AD_Stage
                },
                {
                    "AD_FarmOrder",
                    AD_FarmOrder
                },
                {
                    "AD_WorldSequence",
                    AD_WorldSequence
                },
                {
                    "AD_StageSequence",
                    AD_StageSequence
                },
                {
                    "AD_AmountSequence",
                    AD_AmountSequence
                },
                {
                    "AD_BoostSequence",
                    AD_BoostSequence
                },
                {
                    "AD_Continuous",
                    AD_Continuous
                },
                {
                    "AD_Team",
                    AD_Team
                },
                {
                    "AD2_Team",
                    AD2_Team
                },
                {
                    "AD_StopOnFullHeroes",
                    AD_StopOnFullHeroes
                },
                {
                    "AD_StopOnFullItems",
                    AD_StopOnFullItems
                },
                {
                    "AD_CheckSlot",
                    AD_CheckSlot
                },
                {
                    "AD_CheckingHeroes",
                    AD_CheckingHeroes
                },

                {
                    "GB_WaitForKeys",
                    GB_WaitForKeys
                },

                {
                    "AR_Enable",
                    AR_Enable
                },
                {
                    "AR_EnableLimit",
                    AR_EnableLimit
                },
                {
                    "AR_Limit",
                    AR_Limit
                },
                {
                    "AR_UseRuby",
                    AR_UseRuby
                },
                {
                    "AR_UseRubyAmount",
                    AR_UseRubyAmount
                },
                {
                    "AR_Mastery",
                    AR_Mastery
                },
                {
                    "AR_LimitArena",
                    AR_LimitArena
                },
                {
                    "AR_LimitScore",
                    AR_LimitScore
                },

                {
                    "RS_SellHeroes",
                    RS_SellHeroes
                },
                {
                    "RS_SellHeroStars",
                    RS_SellHeroStars
                },
                {
                    "RS_SellHeroAmount",
                    RS_SellHeroAmount
                },
                {
                    "RS_SellHeroAll",
                    RS_SellHeroAll
                },
                {
                    "RS_SellItems",
                    RS_SellItems
                },
                {
                    "RS_SellItemStars",
                    RS_SellItemStars
                },
                {
                    "RS_SellItemAmount",
                    RS_SellItemAmount
                },
                {
                    "RS_SellItemAll",
                    RS_SellItemAll
                },
                {
                    "RS_InboxHonors",
                    RS_InboxHonors
                },
                {
                    "RS_InboxKeys",
                    RS_InboxKeys
                },
                {
                    "RS_InboxGold",
                    RS_InboxGold
                },
                {
                    "RS_InboxRubies",
                    RS_InboxRubies
                },
                {
                    "RS_InboxTickets",
                    RS_InboxTickets
                },
                {
                    "RS_CollectLuckyChest",
                    RS_CollectLuckyChest
                },
                {
                    "RS_CollectLuckyBox",
                    RS_CollectLuckyBox
                },
                {
                    "RS_CollectInbox",
                    RS_CollectInbox
                },
                {
                    "RS_EnableCINoRuby",
                    RS_EnableCINoRuby
                },
                {
                    "RS_CIOnlyHonor",
                    RS_CIOnlyHonor
                },
                {
                    "RS_CIOnlyKey",
                    RS_CIOnlyKey
                },
                {
                    "RS_CIOnlyCurrency",
                    RS_CIOnlyCurrency
                },
                {
                    "RS_CIOnlyTicket",
                    RS_CIOnlyTicket
                },
                {
                    "RS_EnableCI",
                    RS_EnableCI
                },
                {
                    "RS_CollectInboxActive",
                    RS_CollectInboxActive
                },
                {
                    "RS_BuyKeyHonors",
                    RS_BuyKeyHonors
                },
                {
                    "RS_SellGoldOre",
                    RS_SellGoldOre
                },
                {
                    "RS_BuyKeyHonorsType",
                    RS_BuyKeyHonorsType
                },
                {
                    "RS_BuyKeyHonorsAmount",
                    RS_BuyKeyHonorsAmount
                },
                {
                    "RS_BuyKeyRubies",
                    RS_BuyKeyRubies
                },
                {
                    "RS_BuyKeyRubiesType",
                    RS_BuyKeyRubiesType
                },
                {
                    "RS_BuyKeyRubiesAmount",
                    RS_BuyKeyRubiesAmount
                },
                {
                    "AD_HottimeEnable",
                    AD_HottimeEnable
                },
                {
                    "AD_UseFriend",
                    AD_UseFriend
                },
                {
                    "AD_BootMode",
                    AD_BootMode
                },
                {
                    "AD_BoostAsgar",
                    AD_BoostAsgar
                },
                {
                    "AD_BoostModeSequence",
                    AD_BoostModeSequence
                },
                {
                    "AD_BoostAllMap",
                    AD_BoostAllMap
                },
                {
                    "AD_Profile1",
                    AD_Profile1
                },
                {
                    "AD_Profile2",
                    AD_Profile2
                },
                {
                    "AD_Profile3",
                    AD_Profile3
                },
                {
                    "AD_EnableProfile1",
                    AD_EnableProfile1
                },
                {
                    "AD_EnableProfile2",
                    AD_EnableProfile2
                },
                {
                    "AD_EnableProfile3",
                    AD_EnableProfile3
                },
                {
                    "AD_NoChangeMode",
                    AD_NoChangeMode
                }
            };
            string data = JsonConvert.SerializeObject(value);
            File.WriteAllText(filePath, data);
        }

        #endregion Public Methods
    }
}