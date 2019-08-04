using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AutoRepeatInfoPM
    {
        public static readonly PixelMapping GoldIcon = new PixelMapping
        {
            X = 538,
            Y = 226,
            Color = 9654545,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping CardIcon = new PixelMapping
        {
            X = 532,
            Y = 161,
            Color = 16711159,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping ChestIcon = new PixelMapping
        {
            X = 714,
            Y = 163,
            Color = 4071435,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CloseBtn = new PixelMapping
        {
            X = 836,
            Y = 63,
            Color = 7238011,
            Type = MappingType.BOTH
        };

        public static readonly Rectangle Gold = new Rectangle
        {
            X = 553,
            Y = 218,
            Width = 135,
            Height = 23
        };

        public static readonly Rectangle Hero = new Rectangle
        {
            X = 553,
            Y = 158,
            Width = 120,
            Height = 27
        };

        public static readonly Rectangle Item = new Rectangle
        {
            X = 726,
            Y = 159,
            Width = 103,
            Height = 23
        };

        public static readonly Rectangle Soul = new Rectangle
        {
            X = 554,
            Y = 279,
            Width = 110,
            Height = 26
        };
    }
}