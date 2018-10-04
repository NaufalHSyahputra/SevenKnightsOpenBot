using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AutoRepeatPopupPM
    {
        public static readonly PixelMapping GoldIcon = new PixelMapping
        {
            X = 366,
            Y = 269,
            Color = 16440198,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping TopLeftBorder = new PixelMapping
        {
            X = 204,
            Y = 168,
            Color = 15784605,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 271,
            Y = 369,
            Color = 15088647,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping YesButton = new PixelMapping
        {
            X = 468,
            Y = 375,
            Color = 16759838,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping GoldIcon_NoHotTime = new PixelMapping
        {
            X = 365,
            Y = 251,
            Color = 14394448,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping TopLeftBorder_NoHotTime = new PixelMapping
        {
            X = 195,
            Y = 154,
            Color = 15587227,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping NoButton_NoHotTime = new PixelMapping
        {
            X = 262,
            Y = 356,
            Color = 14040329,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping YesButton_NoHotTime = new PixelMapping
        {
            X = 451,
            Y = 358,
            Color = 16760609,
            Type = MappingType.BOTH
        };

    }
}