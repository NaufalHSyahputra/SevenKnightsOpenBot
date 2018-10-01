using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class BattleModesPM
    {
        #region Public Fields

        public static readonly PixelMapping ArenaButton = new PixelMapping
        {
            X = 560,
            Y = 378,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 715,
            Y = 459,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SpecialDungeonButton = new PixelMapping
        {
            X = 224,
            Y = 203,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping BorderBottomRight = new PixelMapping //Adventure Button
        {
            X = 667,
            Y = 443,
            Color = 13421246,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BorderTopLeft = new PixelMapping //Back Button
        {
            X = 25,
            Y = 35,
            Color = 13188876,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BossFightButton = new PixelMapping
        {
            X = 663,
            Y = 208,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CastleRushButton = new PixelMapping
        {
            X = 356,
            Y = 219,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping QuestRedScroll = new PixelMapping
        {
            X = 26,
            Y = 477,
            Color = 9733211,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GuildWarButton = new PixelMapping
        {
            X = 402,
            Y = 344,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}