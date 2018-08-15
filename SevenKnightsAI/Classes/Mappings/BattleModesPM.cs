using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class BattleModesPM
    {
        #region Public Fields

        public static readonly PixelMapping ArenaButton = new PixelMapping
        {
            X = 574,
            Y = 362,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 682,
            Y = 422,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CelestialTowerButton = new PixelMapping
        {
            X = 764,
            Y = 90,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SpecialDungeonButton = new PixelMapping
        {
            X = 225,
            Y = 199,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RaidButton = new PixelMapping
        {
            X = 534,
            Y = 105,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping BorderBottomRight = new PixelMapping //Adventure Button
        {
            X = 710,
            Y = 443,
            Color = 13474397,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BorderTopLeft = new PixelMapping //Back Button
        {
            X = 31,
            Y = 42,
            Color = 13583116,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BossFightButton = new PixelMapping
        {
            X = 618,
            Y = 203,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CastleRushButton = new PixelMapping
        {
            X = 363,
            Y = 212,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int GOLD_OFFSET_X = 218;

        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly PixelMapping GoldPlusButton = new PixelMapping
        {
            X = 550,
            Y = 29,
            Color = 11573327,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestRedScroll = new PixelMapping
        {
            X = 27,
            Y = 454,
            Color = 6898973,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GuildWarButton = new PixelMapping
        {
            X = 260,
            Y = 400,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int HONOR_OFFSET_X = 227;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly int RUBY_OFFSET_X = 223;

        public static readonly int RUBY_OFFSET_Y = 0;

        #endregion Public Fields
    }
}