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
            X = 377,
            Y = 264,
            Color = 15581795,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping TopLeftBorder_NoHotTime = new PixelMapping
        {
            X = 205,
            Y = 169,
            Color = 16047520,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping NoButton_NoHotTime = new PixelMapping
        {
            X = 270,
            Y = 371,
            Color = 14499080,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping YesButton_NoHotTime = new PixelMapping
        {
            X = 472,
            Y = 370,
            Color = 16768576,
            Type = MappingType.BOTH
        };

    }
}