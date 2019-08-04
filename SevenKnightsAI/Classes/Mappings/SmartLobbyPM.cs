using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SmartLobbyPM
    {
        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 889,
            Y = 144,
            Color = 13619671,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 354,
            Y = 78,
            Color = 2302755,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CollectButton = new PixelMapping
        {
            X = 395,
            Y = 487,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly Rectangle R_GoldenCrystal = new Rectangle
        {
            X = 230,
            Y = 100,
            Width = 96,
            Height = 29
        };

        public static readonly Rectangle R_Gold = new Rectangle
        {
            X = 250,
            Y = 139,
            Width = 79,
            Height = 25
        };

        public static readonly Rectangle R_Horn = new Rectangle
        {
            X = 487,
            Y = 102,
            Width = 85,
            Height = 27
        };

        public static readonly Rectangle R_Scale = new Rectangle
        {
            X = 484,
            Y = 136,
            Width = 88,
            Height = 29
        };

        public static readonly Rectangle R_Essecense = new Rectangle
        {
            X = 496,
            Y = 174,
            Width = 75,
            Height = 24
        };

        public static readonly Rectangle R_Star = new Rectangle
        {
            X = 723,
            Y = 101,
            Width = 82,
            Height = 29
        };
    }
}