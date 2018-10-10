using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AutoRepeatInfoPM
    {
        public static readonly PixelMapping GoldIcon = new PixelMapping
        {
            X = 426,
            Y = 203,
            Color = 15120474,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping CardIcon = new PixelMapping
        {
            X = 422,
            Y = 153,
            Color = 14460227,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping ChestIcon = new PixelMapping
        {
            X = 583,
            Y = 149,
            Color = 9600875,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CloseBtn = new PixelMapping
        {
            X = 698,
            Y = 65,
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
            X = 447,
            Y = 197, 
            Width = 130,
            Height = 22
        };

        public static readonly Rectangle Hero = new Rectangle
        {
            X = 446,
            Y = 149,
            Width = 108,
            Height = 22
        };

        public static readonly Rectangle Item = new Rectangle
        {
            X = 603,
            Y = 148,
            Width = 90,
            Height = 22
        };
    }
}