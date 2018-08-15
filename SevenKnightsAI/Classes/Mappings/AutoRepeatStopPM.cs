using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AutoRepeatStopPM
    {
        public static readonly PixelMapping x2Icon = new PixelMapping
        {
            X = 56,
            Y = 421,
            Color = 4934475,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping GoldIcon = new PixelMapping
        {
            X = 559,
            Y = 43,
            Color = 4272923,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping PopupBorder = new PixelMapping
        {
            X = 527,
            Y = 249,
            Color = 12562041,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 273,
            Y = 374,
            Color = 13384458,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping YesButton = new PixelMapping
        {
            X = 470,
            Y = 370,
            Color = 16768576,
            Type = MappingType.BOTH
        };

    }
}