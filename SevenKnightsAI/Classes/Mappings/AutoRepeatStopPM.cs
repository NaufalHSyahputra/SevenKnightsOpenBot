using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AutoRepeatStopPM
    {
        public static readonly PixelMapping x2Icon = new PixelMapping
        {
            X = 41,
            Y = 405,
            Color = 4539201,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping GoldIcon = new PixelMapping
        {
            X = 543,
            Y = 28,
            Color = 4931618,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping PopupBorder = new PixelMapping
        {
            X = 217,
            Y = 154,
            Color = 15587227,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoButton = new PixelMapping
        {
            X = 262,
            Y = 354,
            Color = 14695688,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping YesButton = new PixelMapping
        {
            X = 455,
            Y = 355,
            Color = 16766006,
            Type = MappingType.BOTH
        };

    }
}