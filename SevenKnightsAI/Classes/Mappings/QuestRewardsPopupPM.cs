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
            X = 527,
            Y = 406,
            Color = 3482640,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AragonPic = new PixelMapping
        {
            X = 116,
            Y = 93,
            Color = 16175794,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OKButton = new PixelMapping
        {
            X = 670,
            Y = 402,
            Color = 0,
            Type = MappingType.BUTTON
        };

    }
}