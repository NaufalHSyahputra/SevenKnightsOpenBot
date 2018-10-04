using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class LobbyPM
    {
        #region Public Fields

        public static readonly PixelMapping StatusBoard = new PixelMapping //evan hair
        {
            X = 48,
            Y = 212,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping MasteryButton = new PixelMapping
        {
            X = 48,
            Y = 73,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 735,
            Y = 416,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int GOLD_OFFSET_X = 0;

        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly PixelMapping GuildButton = new PixelMapping
        {
            X = 219,
            Y = 405,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HeroButton = new PixelMapping
        {
            X = 32,
            Y = 414,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int HONOR_OFFSET_X = 0;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly PixelMapping InboxAvailable = new PixelMapping
        {
            X = 690,
            Y = 15,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping InboxButton = new PixelMapping
        {
            X = 703,
            Y = 25,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int KEY_OFFSET_X = 0;

        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly PixelMapping MenuButtonYellowLeft = new PixelMapping //Chest
        {
            X = 647,
            Y = 22,
            Color = 12223286,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MenuButtonYellowRight = new PixelMapping //Chest
        {
            X = 675,
            Y = 36,
            Color = 9987110,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestAvailable = new PixelMapping
        {
            X = 76,
            Y = 389,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestButton = new PixelMapping
        {
            X = 90,
            Y = 411,
            Color = 0,
            Type = MappingType.BUTTON
        };
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
            X = 515,
            Y = 415,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SocialAvailable = new PixelMapping
        {
            X = 138,
            Y = 391,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SocialButton = new PixelMapping
        {
            X = 159,
            Y = 411,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int TOPAZ_OFFSET_X = 0;

        public static readonly int TOPAZ_OFFSET_Y = 0;

        public static readonly Rectangle OwnerLocation = new Rectangle
        {
            X = 167,
            Y = 138,
            Width = 185,
            Height = 35
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
            X = 355,
            Y = 18,
            Width = 72,
            Height = 21
        };

        public static readonly Rectangle R_HonorBase = new Rectangle
        {
            X = 573,
            Y = 18,
            Width = 64,
            Height = 21
        };

        public static readonly Rectangle R_KeyNormalBase = new Rectangle
        {
            X = 248,
            Y = 15, 
            Width = 56,
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
            X = 476,
            Y = 18,
            Width = 50,
            Height = 23
        };

        /* Smart Mode */

        public static readonly PixelMapping SmartAvailable = new PixelMapping
        {
            X = 569,
            Y = 385,
            Color = 12919558,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SmartButton = new PixelMapping
        {
            X = 595,
            Y = 415,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}