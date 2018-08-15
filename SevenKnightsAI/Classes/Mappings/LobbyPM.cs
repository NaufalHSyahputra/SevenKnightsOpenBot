using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class LobbyPM
    {
        #region Public Fields

        public static readonly PixelMapping StatusBoard = new PixelMapping //evan hair
        {
            X = 55,
            Y = 237,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping MasteryButton = new PixelMapping
        {
            X = 49,
            Y = 88,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 725,
            Y = 438,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int GOLD_OFFSET_X = 0;

        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly PixelMapping GuildButton = new PixelMapping
        {
            X = 251,
            Y = 423,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HeroButton = new PixelMapping
        {
            X = 34,
            Y = 424,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int HONOR_OFFSET_X = 0;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly PixelMapping InboxAvailable = new PixelMapping
        {
            X = 711,
            Y = 26,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping InboxButton = new PixelMapping
        {
            X = 724,
            Y = 39,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int KEY_OFFSET_X = 0;

        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly PixelMapping MenuButtonYellowLeft = new PixelMapping //Chest
        {
            X = 667,
            Y = 34,
            Color = 12750142,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MenuButtonYellowRight = new PixelMapping //Chest
        {
            X = 695,
            Y = 46,
            Color = 10644523,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestAvailable = new PixelMapping
        {
            X = 86,
            Y = 401,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestButton = new PixelMapping
        {
            X = 108,
            Y = 440,
            Color = 0,
            Type = MappingType.BUTTON
        };

        //public static readonly int RUBY_OFFSET_X = 10;
        public static readonly int RUBY_OFFSET_X = 0;

        public static readonly int RUBY_OFFSET_Y = 0;

        public static readonly PixelMapping RudysGiftButton = new PixelMapping
        {
            X = 910,
            Y = 402,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ShopButton = new PixelMapping
        {
            X = 736,
            Y = 516,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SocialAvailable = new PixelMapping
        {
            X = 158,
            Y = 400,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SocialButton = new PixelMapping
        {
            X = 184,
            Y = 427,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int TOPAZ_OFFSET_X = 0;

        public static readonly int TOPAZ_OFFSET_Y = 0;

        public static readonly Rectangle OwnerLocation = new Rectangle
        {
            X = 181,
            Y = 156,
            Width = 180,
            Height = 30
        };

        /* Exploration */

        public static readonly PixelMapping ExplorationAvailable1 = new PixelMapping
        {
            X = 510,
            Y = 90,
            Color = 9862248,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ExplorationAvailable2 = new PixelMapping
        {
            X = 492,
            Y = 86,
            Color = 8999210,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ExplorationLobbyButton = new PixelMapping
        {
            X = 492,
            Y = 86,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly Rectangle R_GoldBase = new Rectangle
        {
            X = 371,
            Y = 31,
            Width = 73,
            Height = 21
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
            X = 259,
            Y = 28,
            Width = 60,
            Height = 25
        };

        public static readonly Rectangle R_KeyTopBase = new Rectangle
        {
            X = 258,
            Y = 30,
            Width = 60,
            Height = 22
        };

        public static readonly Rectangle R_RubyBase = new Rectangle
        {
            X = 495,
            Y = 33,
            Width = 49,
            Height = 20
        };

        /* Smart Mode */

        public static readonly PixelMapping SmartAvailable = new PixelMapping
        {
            X = 583,
            Y = 408,
            Color = 12526598,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SmartButton = new PixelMapping
        {
            X = 611,
            Y = 430,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}