using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AutoRepeatInfoPM
    {
        public static readonly PixelMapping GoldIcon = new PixelMapping
        {
            X = 531,
            Y = 206,
            Color = 9390602,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping CardIcon = new PixelMapping
        {
            X = 529,
            Y = 154,
            Color = 15052104,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping ChestIcon = new PixelMapping
        {
            X = 708,
            Y = 154,
            Color = 3087632,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CloseBtn = new PixelMapping
        {
            X = 837,
            Y = 59,
            Color = 16777215,
            Type = MappingType.BOTH
        };

        public static readonly Rectangle Gold = new Rectangle
        {
            X = 546,
            Y = 189,
            Width = 141,
            Height = 31
        };

        public static readonly Rectangle Hero = new Rectangle
        {
            X = 551,
            Y = 142,
            Width = 113,
            Height = 30
        };

        public static readonly Rectangle Item = new Rectangle
        {
            X = 719,
            Y = 141,
            Width = 103,
            Height = 30
        };

        public static readonly Rectangle Soul = new Rectangle
        {
            X = 549,
            Y = 244,
            Width = 123,
            Height = 23
        };
    }
}