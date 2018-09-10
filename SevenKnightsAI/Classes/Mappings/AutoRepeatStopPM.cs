using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AutoRepeatStopPM
    {
        public static readonly PixelMapping x2Icon = new PixelMapping
        {
            X = 39,
            Y = 452,
            Color = 4934475,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping GoldIcon = new PixelMapping
        {
            X = 119,
            Y = 428,
            Color = 3748132,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping PopupBorder = new PixelMapping
        {
            X = 432,
            Y = 118,
            Color = 16430099,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 272,
            Y = 368,
            Color = 9575696,
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