using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class BattleModesPM
    {
        #region Public Fields

        public static readonly PixelMapping ArenaButton = new PixelMapping
        {
            X = 553,
            Y = 348,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 727,
            Y = 416,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SpecialDungeonButton = new PixelMapping
        {
            X = 216,
            Y = 184,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping BorderBottomRight = new PixelMapping //Adventure Button
        {
            X = 664,
            Y = 403,
            Color = 12236198,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BorderTopLeft = new PixelMapping //Back Button
        {
            X = 22,
            Y = 34,
            Color = 12991755,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BossFightButton = new PixelMapping
        {
            X = 398,
            Y = 197,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CastleRushButton = new PixelMapping
        {
            X = 654,
            Y = 186,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping QuestRedScroll = new PixelMapping
        {
            X = 23,
            Y = 435,
            Color = 16249313,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GuildWarButton = new PixelMapping
        {
            X = 422,
            Y = 310,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}