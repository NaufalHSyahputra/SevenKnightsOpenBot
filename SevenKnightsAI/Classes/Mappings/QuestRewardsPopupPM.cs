using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class QuestRewardsPopupPM
    {
        public static readonly PixelMapping DimmedBG = new PixelMapping
        {
            X = 210,
            Y = 59,
            Color = 3753280,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestIcon = new PixelMapping
        {
            X = 543,
            Y = 431,
            Color = 14005066,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AragonPic = new PixelMapping
        {
            X = 132,
            Y = 92,
            Color = 13399378,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OKButton = new PixelMapping
        {
            X = 689,
            Y = 426,
            Color = 0,
            Type = MappingType.BUTTON
        };

    }
}