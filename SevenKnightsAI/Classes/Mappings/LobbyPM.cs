using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class LobbyPM
    {
        #region Public Fields

        public static readonly PixelMapping StatusBoard = new PixelMapping //evan hair
        {
            X = 52,
            Y = 256,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping MasteryButton = new PixelMapping
        {
            X = 52,
            Y = 93,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 911,
            Y = 470,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int GOLD_OFFSET_X = 0;

        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly PixelMapping GuildButton = new PixelMapping
        {
            X = 258,
            Y = 494,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HeroButton = new PixelMapping
        {
            X = 39,
            Y = 481,
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
            X = 846,
            Y = 32,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int KEY_OFFSET_X = 0;

        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly PixelMapping MenuButtonYellowLeft = new PixelMapping //Chest
        {
            X = 920,
            Y = 32,
            Color = 16711422,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MenuButtonYellowRight = new PixelMapping //Chest
        {
            X = 947,
            Y = 31,
            Color = 16777215,
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
            X = 621,
            Y = 495,
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
            X = 208,
            Y = 171,
            Width = 190,
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
            X = 479,
            Y = 21,
            Width = 109,
            Height = 23
        };

        public static readonly Rectangle R_HonorBase = new Rectangle
        {
            X = 687,
            Y = 22,
            Width = 77,
            Height = 23
        };

        public static readonly Rectangle R_KeyNormalBase = new Rectangle
        {
            X = 338,
            Y = 19,
            Width = 79,
            Height = 26
        };

        public static readonly Rectangle R_KeyTopBase = new Rectangle
        {
            X = 327,
            Y = 17,
            Width = 38,
            Height = 15
        };

        public static readonly Rectangle R_KeyTime = new Rectangle
        {
            X = 315,
            Y = 31,
            Width = 52,
            Height = 16
        };

        public static readonly Rectangle R_RubyBase = new Rectangle
        {
            X = 656,
            Y = 21,
            Width = 75,
            Height = 22
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
            X = 822,
            Y = 486,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping UnknownAvailable = new PixelMapping
        {
            X = 31,
            Y = 326,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping UnknownBtn = new PixelMapping
        {
            X = 67,
            Y = 347,
            Color = 8942952,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}