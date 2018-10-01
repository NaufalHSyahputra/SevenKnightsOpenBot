using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class LobbyPM
    {
        #region Public Fields

        public static readonly PixelMapping StatusBoard = new PixelMapping //evan hair
        {
            X = 64,
            Y = 220,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping MasteryButton = new PixelMapping
        {
            X = 49,
            Y = 77,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 687,
            Y = 456,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int GOLD_OFFSET_X = 0;

        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly PixelMapping GuildButton = new PixelMapping
        {
            X = 231,
            Y = 447,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HeroButton = new PixelMapping
        {
            X = 28,
            Y = 449,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int HONOR_OFFSET_X = 0;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly PixelMapping InboxAvailable = new PixelMapping
        {
            X = 696,
            Y = 16,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping InboxButton = new PixelMapping
        {
            X = 713,
            Y = 29,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int KEY_OFFSET_X = 0;

        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly PixelMapping MenuButtonYellowLeft = new PixelMapping //Chest
        {
            X = 650,
            Y = 23,
            Color = 12091700,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MenuButtonYellowRight = new PixelMapping //Chest
        {
            X = 680,
            Y = 40,
            Color = 8804129,
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
            X = 101,
            Y = 450,
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
            X = 507,
            Y = 449,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SocialAvailable = new PixelMapping
        {
            X = 149,
            Y = 428,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SocialButton = new PixelMapping
        {
            X = 171,
            Y = 447,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int TOPAZ_OFFSET_X = 0;

        public static readonly int TOPAZ_OFFSET_Y = 0;

        public static readonly Rectangle OwnerLocation = new Rectangle
        {
            X = 160,
            Y = 157,
            Width = 188,
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
            X = 335,
            Y = 18,
            Width = 77,
            Height = 26
        };

        public static readonly Rectangle R_HonorBase = new Rectangle
        {
            X = 568,
            Y = 16,
            Width = 74,
            Height = 26
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
            X = 464,
            Y = 18,
            Width = 54,
            Height = 25
        };

        /* Smart Mode */

        public static readonly PixelMapping SmartAvailable = new PixelMapping
        {
            X = 561,
            Y = 427,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SmartButton = new PixelMapping
        {
            X = 592,
            Y = 453,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}