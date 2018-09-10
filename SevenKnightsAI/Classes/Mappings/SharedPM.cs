using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SharedPM
    {
        #region Public Fields

        public static readonly PixelMapping BackButton = new PixelMapping //Red Back button
        {
            X = 31,
            Y = 38,
            Color = 13846028,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping BackButtonAnchor = new PixelMapping //Red Back button
        {
            X = 31,
            Y = 38,
            Color = 13846028,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BackButton2 = new PixelMapping //yellow back button
        {
            X = 21,
            Y = 35,
            Color = 16776629,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping BackButtonAnchor2 = new PixelMapping //yellow back button
        {
            X = 21,
            Y = 35,
            Color = 16776629,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_AutoSkillButton = new PixelMapping
        {
            X = 128,
            Y = 496,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_AutoSkillOff = new PixelMapping
        {
            X = 127,
            Y = 524,
            Color = 7033650,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_AutoSkillOnBottom = new PixelMapping
        {
            //X = 128,
            //Y = 525,
            //Color = 7481611,
            X = 130,
            Y = 496,
            Color = 7748889,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_AutoSkillOnTop = new PixelMapping
        {
            //X = 128,
            //Y = 466,
            //Color = 3547410,
            X = 120,
            Y = 496,
            Color = 8866079,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_ChatButton = new PixelMapping
        {
            X = 785,
            Y = 169,
            Color = 14009213,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Fight_PauseButton = new PixelMapping
        {
            X = 790,
            Y = 121,
            Color = 13811577,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Fight_Skill1 = new PixelMapping
        {
            X = 576,
            Y = 436,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill1_Q1_1 = new PixelMapping
        {
            X = 590,
            Y = 419,
            Color = 16244104,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill1_Q1_2 = new PixelMapping
        {
            X = 587,
            Y = 426,
            Color = 12157741,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill2 = new PixelMapping
        {
            X = 668,
            Y = 444,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill2_Q1_1 = new PixelMapping
        {
            X = 675,
            Y = 420,
            Color = 16707492,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill2_Q1_2 = new PixelMapping
        {
            X = 674,
            Y = 429,
            Color = 15519103,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill3 = new PixelMapping
        {
            X = 762,
            Y = 420,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill3_Q1_1 = new PixelMapping
        {
            X = 759,
            Y = 428,
            Color = 14597744,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill3_Q1_2 = new PixelMapping
        {
            X = 744,
            Y = 444,
            Color = 6578782,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill4 = new PixelMapping
        {
            X = 826,
            Y = 441,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill4_Q1_1 = new PixelMapping
        {
            X = 847,
            Y = 421,
            Color = 16571254,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill4_Q1_2 = new PixelMapping
        {
            X = 850,
            Y = 406,
            Color = 15651203,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill5 = new PixelMapping
        {
            X = 921,
            Y = 434,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill5_Q1_1 = new PixelMapping
        {
            X = 932,
            Y = 421,
            Color = 16770702,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill5_Q1_2 = new PixelMapping
        {
            X = 931,
            Y = 428,
            Color = 14596966,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill6 = new PixelMapping
        {
            X = 569,
            Y = 495,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill6_Q1_1 = new PixelMapping
        {
            X = 590,
            Y = 477,
            Color = 16770443,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill6_Q1_2 = new PixelMapping
        {
            X = 589,
            Y = 484,
            Color = 14991981,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill7 = new PixelMapping
        {
            X = 665,
            Y = 502,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill7_Q1_1 = new PixelMapping
        {
            X = 676,
            Y = 475,
            Color = 16705428,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill7_Q1_2 = new PixelMapping
        {
            X = 673,
            Y = 484,
            Color = 15254375,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill8 = new PixelMapping
        {
            X = 737,
            Y = 497,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill8_Q1_1 = new PixelMapping
        {
            X = 759,
            Y = 477,
            Color = 16771221,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill8_Q1_2 = new PixelMapping
        {
            X = 759,
            Y = 482,
            Color = 13608787,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill9 = new PixelMapping
        {
            X = 828,
            Y = 507,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill9_Q1_1 = new PixelMapping
        {
            X = 847,
            Y = 475,
            Color = 16705428,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill9_Q1_2 = new PixelMapping
        {
            X = 845,
            Y = 485,
            Color = 15453565,
            Type = MappingType.ANCHOR
        };
        
        public static readonly PixelMapping Fight_Skill10 = new PixelMapping
        {
            X = 919,
            Y = 508,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill10_Q1_1 = new PixelMapping
        {
            X = 932,
            Y = 476,
            Color = 16771995,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill10_Q1_2 = new PixelMapping
        {
            X = 931,
            Y = 485,
            Color = 14925157,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill11 = new PixelMapping
        {
            X = 581,
            Y = 386,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping Fight_Skill11_Q1_1 = new PixelMapping
        {
            X = 590,
            Y = 364,
            Color = 16772253,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill11_Q1_2 = new PixelMapping
        {
            X = 589,
            Y = 374,
            Color = 14134609,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill12 = new PixelMapping
        {
            X = 662,
            Y = 381,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill12_Q1_1 = new PixelMapping
        {
            X = 695,
            Y = 365,
            Color = 16770700,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill12_Q1_2 = new PixelMapping
        {
            X = 694,
            Y = 372,
            Color = 14794344,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill13 = new PixelMapping
        {
            X = 747,
            Y = 381,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill13_Q1_1 = new PixelMapping
        {
            X = 772,
            Y = 367,
            Color = 16702843,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill13_Q1_2 = new PixelMapping
        {
            X = 771,
            Y = 370,
            Color = 13674579,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill14 = new PixelMapping
        {
            X = 832,
            Y = 381,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill14_Q1_1 = new PixelMapping
        {
            X = 850,
            Y = 367,
            Color = 16702842,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill14_Q1_2 = new PixelMapping
        {
            X = 848,
            Y = 374,
            Color = 14664054,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill15 = new PixelMapping
        {
            X = 920,
            Y = 381,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill15_Q1_1 = new PixelMapping
        {
            X = 927,
            Y = 365,
            Color = 16771738,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill15_Q1_2 = new PixelMapping
        {
            X = 926,
            Y = 372,
            Color = 14729592,
            Type = MappingType.ANCHOR
        };
        /* Skill 5 Special Dungeon*/
        public static readonly PixelMapping Fight_Skill16 = new PixelMapping
        {
            X = 603,
            Y = 495,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_Skill16_Q1_1 = new PixelMapping
        {
            X = 618,
            Y = 476,
            Color = 16772513,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_Skill16_Q1_2 = new PixelMapping
        {
            X = 617,
            Y = 484,
            Color = 14927485,
            Type = MappingType.ANCHOR
        };
        /* Skill 5 Special Dungeon*/
        public static readonly PixelMapping Fight_SpeedButton = new PixelMapping
        {
            X = 44,
            Y = 496,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_SpeedOff = new PixelMapping
        {
            X = 43,
            Y = 491,
            Color = 5586469,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_SpeedOn = new PixelMapping
        {
            X = 50,
            Y = 486,
            Color = 4465168,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Friends_DimmedBG_1 = new PixelMapping
        {
            X = 751,
            Y = 28,
            Color = 4207374,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Friends_DimmedBG_2 = new PixelMapping
        {
            X = 450,
            Y = 112,
            Color = 1122080,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Friends_PopupBorder = new PixelMapping
        {
            X = 260,
            Y = 203,
            Color = 16772008,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Full_DimmedBG = new PixelMapping
        {
            X = 424,
            Y = 39,
            Color = 4076316,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Full_NoButton = new PixelMapping
        {
            X = 293,
            Y = 352,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Full_ProceedButton = new PixelMapping
        {
            X = 380,
            Y = 350,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Full_SellButton = new PixelMapping
        {
            X = 536,
            Y = 350,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping GiftFull_CancelButton = new PixelMapping
        {
            X = 375,
            Y = 396,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping GiftFull_DimmedBG = new PixelMapping
        {
            X = 885,
            Y = 18,
            Color = 4930058,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GiftFull_PopupBorder = new PixelMapping
        {
            X = 260,
            Y = 200,
            Color = 16639654,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GiftFull_RedCross = new PixelMapping
        {
            X = 314,
            Y = 394,
            Color = 14171656,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Hero_BlackBar = new PixelMapping
        {
            X = 814,
            Y = 47,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Hero_BottomLeftBorder = new PixelMapping //preview button
        {
            X = 26,
            Y = 429,
            Color = 6774872,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Hero_LeaderButton = new PixelMapping
        {
            X = 710,
            Y = 479,
            Color = 13999149,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Hero_Level30_1 = new PixelMapping
        {
            X = 658,
            Y = 74,
            Color = 16777215,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Hero_Level30_2 = new PixelMapping
        {
            X = 664,
            Y = 82,
            Color = 16777215,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Hero_Level30_3 = new PixelMapping
        {
            X = 657,
            Y = 93,
            Color = 16514043,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle Hero_R_Level_30 = new Rectangle
        {
            X = 624,
            Y = 90,
            Width = 125,
            Height = 33
            //X = 636,
            //Y = 63,
            //Width = 134,
            //Height = 39
        };

        public static readonly PixelMapping Loot_HeroButton = new PixelMapping
        {
            X = 51,
            Y = 499,
            Color = 2231301,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Loot_LobbyButton = new PixelMapping
        {
            X = 766,
            Y = 419,
            Color = 16242800,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Lost_LobbyButton = new PixelMapping
        {
            X = 892,
            Y = 476,
            Color = 16177007,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Lost_Moon = new PixelMapping
        {
            X = 459,
            Y = 86,
            Color = 16777215,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Lost_PurpleBase = new PixelMapping
        {
            X = 316,
            Y = 377,
            Color = 6047401,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping PrepareFight_ManageButton = new PixelMapping
        {
            X = 325,
            Y = 411,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PrepareFight_Mastery_1 = new PixelMapping
        {
            X = 396,
            Y = 152,
            Color = 15782941,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PrepareFight_Mastery_2 = new PixelMapping
        {
            X = 399,
            Y = 162,
            Color = 15519773,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PrepareFight_Mastery_3 = new PixelMapping
        {
            X = 400,
            Y = 159,
            Color = 16769568,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PrepareFight_MasteryButton = new PixelMapping
        {
            X = 382,
            Y = 182,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PrepareFight_StartButton = new PixelMapping
        {
            X = 548,
            Y = 424,
            Color = 5973262,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PrepareFight_TeamAButton = new PixelMapping
        {
            X = 144,
            Y = 78,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PrepareFight_TeamBButton = new PixelMapping
        {
            X = 229,
            Y = 75,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PrepareFight_TeamCButton = new PixelMapping
        {
            X = 314,
            Y = 78,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Quests_Background = new PixelMapping
        {
            X = 50,
            Y = 67,
            Color = 7116174,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Quests_CharacterArmor = new PixelMapping
        {
            X = 155,
            Y = 97,
            Color = 13003591,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle R_GoldBase = new Rectangle
        {
            X = 373,
            Y = 29,
            Width = 70,
            Height = 23
        };

        public static readonly Rectangle R_HonorBase = new Rectangle
        {
            X = 591,
            Y = 31,
            Width = 67,
            Height = 21
        };

        public static readonly Rectangle R_KeyNormalBase = new Rectangle
        {
            X = 258,
            Y = 30,
            Width = 60,
            Height = 22
        };

        public static readonly Rectangle R_KeyOnTopTimeBase = new Rectangle
        {
            X = 50,
            Y = 9,
            Width = 67,
            Height = 20
        };

        public static readonly Rectangle R_RubyBase = new Rectangle
        {
            X = 495,
            Y = 33,
            Width = 49,
            Height = 20
        };

        public static readonly Rectangle R_TimeBase = new Rectangle
        {
            X = 68,
            Y = 28,
            Width = 50,
            Height = 20
        };

        public static readonly Rectangle R_TopazBase = new Rectangle
        {
            X = 1,
            Y = 19,
            Width = 53,
            Height = 20
        };

        public static readonly PixelMapping Rewards_OkButton = new PixelMapping
        {
            X = 486,
            Y = 396,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Rewards_PopupBorder = new PixelMapping
        {
            X = 260,
            Y = 200,
            Color = 16639654,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Rewards_YellowTick = new PixelMapping
        {
            X = 421,
            Y = 401,
            Color = 16756754,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ShopPopup_DimmedBG = new PixelMapping
        {
            X = 97,
            Y = 76,
            Color = 3547649,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping UseFriendButton = new PixelMapping
        {
            X = 665,
            Y = 136,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping FriendClick = new PixelMapping
        {
            X = 470,
            Y = 470,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HelpFriendOK = new PixelMapping
        {
            X = 361,
            Y = 375,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HelpFriendTik = new PixelMapping
        {
            X = 361,
            Y = 375,
            Color = 16760609,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping HelpFriendBorder = new PixelMapping
        {
            X = 336,
            Y = 285,
            Color = 12922891,
            Type = MappingType.ANCHOR
        };
        #endregion Public Fields
    }
}