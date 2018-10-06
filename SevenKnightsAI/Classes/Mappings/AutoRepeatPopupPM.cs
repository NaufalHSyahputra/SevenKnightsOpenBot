using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AutoRepeatPopupPM
    {
        public static readonly PixelMapping GoldIcon = new PixelMapping
        {
            X = 379,
            Y = 261,
            Color = 15627781,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping TopLeftBorder = new PixelMapping
        {
            X = 195,
            Y = 205,
            Color = 11441509,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 263,
            Y = 353,
            Color = 15023111,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping YesButton = new PixelMapping
        {
            X = 452,
            Y = 359,
            Color = 16759067,
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