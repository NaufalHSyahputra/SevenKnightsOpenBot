using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class QuestSelectPM
    {
        #region Public Fields

        public static readonly PixelMapping QuestAvailable = new PixelMapping
        {
            X = 515,
            Y = 223,
            Color = 13051905,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestButton = new PixelMapping
        {
            X = 470,
            Y = 236,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestIcon = new PixelMapping
        {
            X = 499,
            Y = 241,
            Color = 4725273,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SpecialQuestAvailable = new PixelMapping
        {
            X = 316,
            Y = 207,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SpecialQuestButton = new PixelMapping
        {
            X = 342,
            Y = 236,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SpecialQuestIcon = new PixelMapping
        {
            X = 351,
            Y = 246,
            Color = 14198106,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TitleBorderLeft = new PixelMapping
        {
            X = 270,
            Y = 161,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TitleBorderRight = new PixelMapping
        {
            X = 568,
            Y = 164,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        #endregion Public Fields
    }
}