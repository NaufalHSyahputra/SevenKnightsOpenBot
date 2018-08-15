using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SevenKnightsAI.Classes
{
    internal class AIProfiles
    {
        public Dictionary<string, AISettings> Settings
        {
            get;
            private set;
        }

        [XmlElement(ElementName = "ST_BlueStacksForceActive")]
        public bool ST_BlueStacksForceActive;

        [XmlElement(ElementName = "ST_Delay")]
        public int ST_Delay;

        [XmlElement(ElementName = "ST_EnableHotTimeProfile")]
        public bool ST_EnableHotTimeProfile;

        [XmlElement(ElementName = "ST_EnableAutoProfile")]
        public bool ST_EnableAutoProfile;

        [XmlElement(ElementName = "ST_EnableAutoShutdown")]
        public bool ST_EnableAutoShutdown;

        [XmlElement(ElementName = "AD_Pause100")]
        public bool AD_Pause100;

        [XmlElement(ElementName = "AD_NoHeroUp")]
        public bool AD_NoHeroUp;

        [XmlElement(ElementName = "ST_EnableTelegram")]
        public bool ST_EnableTelegram;

        [XmlElement(ElementName = "ST_ForegroundMode")]
        public bool ST_ForegroundMode;

        [XmlElement(ElementName = "ST_HotTimeProfile")]
        public string ST_HotTimeProfile;

        [XmlElement(ElementName = "ST_TelegramToken")]
        public string ST_TelegramToken;

        [XmlElement(ElementName = "ST_TelegramChatID")]
        public string ST_TelegramChatID;

        [XmlElement(ElementName = "ST_ReconnectInterruptEnable")]
        public bool ST_ReconnectInterruptEnable;

        [XmlElement(ElementName = "ST_ReconnectInterruptInterval")]
        public int ST_ReconnectInterruptInterval;

        public string TMP_NormalProfile;
        public bool TMP_LogPixel;
        public bool TMP_WaitingForKeys;
        public bool TMP_Paused;
        public bool TMP_UsingHotTimeProfile;

        public static readonly string FILE_EXTENSION = ".json";
        public static readonly string FILE_NAME = "_global";
        public static readonly string PATH = "./profiles";
        public static readonly string FILE_PATH = AIProfiles.PATH + "\\" + AIProfiles.FILE_NAME + AIProfiles.FILE_EXTENSION;

        public AIProfiles()
        {
            this.Settings = new Dictionary<string, AISettings>();
            this.CurrentKey = null;
            this.ST_Delay = 1800;
            this.ST_ReconnectInterruptEnable = true;
            this.ST_ReconnectInterruptInterval = 10;
            this.ST_EnableHotTimeProfile = false;
            this.ST_EnableAutoProfile = false;
            this.ST_EnableAutoShutdown = false;
            this.AD_Pause100 = false;
            this.AD_NoHeroUp = false;
            this.ST_EnableTelegram = false;
            this.ST_HotTimeProfile = null;
            this.ST_BlueStacksForceActive = false;
            this.ST_ForegroundMode = false;
        }

        public AIProfiles(AISettings initSettings) : this()
        {
            this.CurrentKey = AIProfiles.PATH + "\\Default" + AIProfiles.FILE_EXTENSION;
            this.Settings.Add(this.CurrentKey, initSettings);
        }

        public void ChangeProfile(string key)
        {
            if (key != null && this.Settings.ContainsKey(key))
            {
                this.CurrentKey = key;
            }
        }

        public static AIProfiles Load()
        {
            AIProfiles aIProfiles = new AIProfiles();
            if (!Directory.Exists(AIProfiles.PATH))
            {
                throw new AISettingsException("Directory does not exist", -1);
            }
            if (File.Exists(AIProfiles.FILE_PATH))
            {
                string value = File.ReadAllText(AIProfiles.FILE_PATH);
                Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(value);
                try
                {
                    aIProfiles.ST_Delay = Convert.ToInt32(dictionary["ST_Delay"]);
                }
                catch (Exception)
                { }
                try
                {
                    aIProfiles.ST_ReconnectInterruptEnable = (bool)dictionary["ST_ReconnectInterruptEnable"];
                }
                catch (Exception)
                { }
                try
                {
                    aIProfiles.ST_ReconnectInterruptInterval = Convert.ToInt32(dictionary["ST_ReconnectInterruptInterval"]);
                }
                catch (Exception)
                { }
                try
                {
                    aIProfiles.ST_EnableHotTimeProfile = (bool)dictionary["ST_EnableHotTimeProfile"];
                }
                catch (Exception)
                { }
                try
                {
                    aIProfiles.ST_EnableAutoProfile = (bool)dictionary["ST_EnableAutoProfile"];
                }
                catch (Exception)
                { }
                try
                {
                    aIProfiles.ST_EnableAutoShutdown = (bool)dictionary["ST_EnableAutoShutdown"];
                }
                catch (Exception)
                { }
                try
                {
                    aIProfiles.AD_Pause100 = (bool)dictionary["AD_Pause100"];
                }
                catch (Exception)
                { }
                try
                {
                    aIProfiles.AD_NoHeroUp = (bool)dictionary["AD_NoHeroUp"];
                }
                catch (Exception)
                { }
                try
                {
                    aIProfiles.ST_EnableTelegram = (bool)dictionary["ST_EnableTelegram"];
                }
                catch (Exception)
                { }
                try
                {
                    aIProfiles.ST_HotTimeProfile = (string)dictionary["ST_HotTimeProfile"];
                }
                catch (Exception)
                { }
                try
                {
                    aIProfiles.ST_BlueStacksForceActive = (bool)dictionary["ST_BlueStacksForceActive"];
                }
                catch (Exception)
                { }
                try
                {
                    aIProfiles.ST_TelegramToken = ((dictionary["ST_TelegramToken"] == null) ? null : dictionary["ST_TelegramToken"].ToString());
                }
                catch (Exception)
                { }
                try
                {
                    aIProfiles.ST_TelegramChatID = ((dictionary["ST_TelegramChatID"] == null) ? null : dictionary["ST_TelegramChatID"].ToString());
                }
                catch (Exception)
                { }
                try
                {
                    aIProfiles.ST_ForegroundMode = (bool)dictionary["ST_ForegroundMode"];
                }
                catch (Exception)
                { }
            }
            string text = null;
            string[] files = Directory.GetFiles(AIProfiles.PATH);
            for (int i = 0; i < files.Length; i++)
            {
                string text2 = files[i];
                if (text2.EndsWith(AIProfiles.FILE_EXTENSION) && !(text2 == AIProfiles.FILE_PATH))
                {
                    text2.Substring(text2.IndexOf('\\') + 1);
                    AISettings value2 = AISettings.Load(text2);
                    aIProfiles.Settings.Add(text2, value2);
                    if (string.IsNullOrEmpty(text))
                    {
                        text = text2;
                    }
                }
            }
            if (aIProfiles.Settings.Count <= 0)
            {
                throw new AISettingsException("No profile available", -1);
            }
            aIProfiles.CurrentKey = text;
            return aIProfiles;
        }

        public void Save()
        {
            Directory.CreateDirectory("profiles");
            Dictionary<string, object> value = new Dictionary<string, object>
            {
                {
                    "ST_Delay",
                    this.ST_Delay
                },
                {
                    "ST_ReconnectInterruptEnable",
                    this.ST_ReconnectInterruptEnable
                },
                {
                    "ST_ReconnectInterruptInterval",
                    this.ST_ReconnectInterruptInterval
                },
                {
                    "ST_EnableHotTimeProfile",
                    this.ST_EnableHotTimeProfile
                },
                {
                    "ST_EnableAutoProfile",
                    this.ST_EnableAutoProfile
                },
                {
                    "ST_EnableAutoShutdown",
                    this.ST_EnableAutoShutdown
                },
                {
                    "AD_Pause100",
                    this.AD_Pause100
                },
                {
                    "AD_NoHeroUp",
                    this.AD_NoHeroUp
                },
                {
                    "ST_EnableTelegram",
                    this.ST_EnableTelegram
                },
                {
                    "ST_HotTimeProfile",
                    this.ST_HotTimeProfile
                },
                {
                    "ST_BlueStacksForceActive",
                    this.ST_BlueStacksForceActive
                },
                {
                    "ST_TelegramToken",
                    this.ST_TelegramToken
                },
                {
                    "ST_TelegramChatID",
                    this.ST_TelegramChatID
                },
                {
                    "ST_ForegroundMode",
                    this.ST_ForegroundMode
                }
            };
            string data = JsonConvert.SerializeObject(value);
            File.WriteAllText(AIProfiles.FILE_PATH, data);
            this.CurrentProfile.Save(this.CurrentKey);
        }

        public void ToggleHotTimeProfile()
        {
            if (!this.TMP_UsingHotTimeProfile)
            {
                this.TMP_NormalProfile = this.CurrentKey;
                this.ChangeProfile(this.ST_HotTimeProfile);
            }
            else
            {
                this.ChangeProfile(this.TMP_NormalProfile);
                this.TMP_NormalProfile = null;
            }
            this.TMP_UsingHotTimeProfile = !this.TMP_UsingHotTimeProfile;
        }

        public string CurrentKey
        {
            get;
            private set;
        }

        public AISettings CurrentProfile
        {
            get
            {
                return this.Settings[this.CurrentKey];
            }
        }

        public string CurrentProfileName
        {
            get
            {
                return this.CurrentKey.Substring(this.CurrentKey.IndexOf('\\') + 1).Replace(AIProfiles.FILE_EXTENSION, "");
            }
        }
    }
}