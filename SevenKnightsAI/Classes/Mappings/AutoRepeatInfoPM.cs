using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AutoRepeatInfoPM
    {
        public static readonly PixelMapping GoldIcon = new PixelMapping
        {
            X = 440,
            Y = 216,
            Color = 15446857,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping CardIcon = new PixelMapping
        {
            X = 436,
            Y = 163,
            Color = 16711162,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping ChestIcon = new PixelMapping
        {
            X = 597,
            Y = 162,
            Color = 11239494,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CloseBtn = new PixelMapping
        {
            X = 716,
            Y = 77,
            Color = 13254668,
            Type = MappingType.BOTH
        };

        public static readonly Rectangle RaidGauge = new Rectangle
        {
            X = 523,
            Y = 268,
            Width = 103,
            Height = 25
        };

        public static readonly Rectangle Gold = new Rectangle
        {
            X = 463,
            Y = 209, 
            Width = 110,
            Height = 30
        };

        public static readonly Rectangle Hero = new Rectangle
        {
            X = 464,
            Y = 159,
            Width = 97,
            Height = 26
        };

        public static readonly Rectangle Item = new Rectangle
        {
            X = 620,
            Y = 159,
            Width = 97,
            Height = 26
        };
    }
}