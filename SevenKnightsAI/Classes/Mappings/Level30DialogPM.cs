using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class Level30DialogPM
    {
        public static readonly Rectangle R_HeroLvlUpCount = new Rectangle
        {
            X = 510,
            Y = 485,
            Width = 35,
            Height = 20
        };

        public static readonly Rectangle R_HeroLvlUpCount2 = new Rectangle
        {
            X = 525,
            Y = 483,
            Width = 32,
            Height = 23
        };

        public static readonly PixelMapping CharacterEye = new PixelMapping
        {
            X = 163,
            Y = 118,
            Color = 15654860,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DialogBorder = new PixelMapping
        {
            X = 952,
            Y = 322,
            Color = 6440475,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping InboxButton = new PixelMapping
        {
            X = 658,
            Y = 467,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping InboxIcon = new PixelMapping
        {
            X = 622,
            Y = 481,
            Color = 13344312,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OkButton = new PixelMapping
        {
            X = 835,
            Y = 467,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}