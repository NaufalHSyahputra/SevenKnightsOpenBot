using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SpecialQuestPM
    {
        public static readonly PixelMapping CollectButton = new PixelMapping
        {
            X = 740,
            Y = 218,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CollectButtonBackground = new PixelMapping
        {
            X = 740,
            Y = 218,
            Color = 15779074,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CollectMainButton = new PixelMapping
        {
            X = 741,
            Y = 132,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CollectMainButtonBackground = new PixelMapping
        {
            X = 741,
            Y = 132,
            Color = 14722563,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DailyAvailable = new PixelMapping
        {
            X = 281,
            Y = 75,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DailyTab = new PixelMapping
        {
            X = 378,
            Y = 94,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int GOLD_OFFSET_X = 277;

        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly int HONOR_OFFSET_X = 279;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly int KEY_OFFSET_X = 274;

        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly PixelMapping MonthlyAvailable = new PixelMapping
        {
            X = 643,
            Y = 75,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MonthlyTab = new PixelMapping
        {
            X = 712,
            Y = 94,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int RUBY_OFFSET_X = 276;

        public static readonly int RUBY_OFFSET_Y = 0;

        public static readonly PixelMapping StatusBorder = new PixelMapping
        {
            X = 446,
            Y = 131,
            Color = 13944726,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping WeeklyAvailable = new PixelMapping
        {
            X = 464,
            Y = 76,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping WeeklyTab = new PixelMapping
        {
            X = 543,
            Y = 91,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}