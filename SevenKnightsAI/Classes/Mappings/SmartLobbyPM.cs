using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SmartLobbyPM
    {
        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 93,
            Y = 168,
            Color = 9275781,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 757,
            Y = 160,
            Color = 7762284,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CelestialTowerButton = new PixelMapping
        {
            X = 135,
            Y = 84,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RaidButton = new PixelMapping
        {
            X = 180,
            Y = 82,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping TartarusButton = new PixelMapping
        {
            X = 226,
            Y = 80,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CollectButtonNotAvailable = new PixelMapping
        {
            X = 317,
            Y = 425,
            Color = 1513239,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LootButtonNotAvailable = new PixelMapping
        {
            X = 435,
            Y = 430,
            Color = 1710618,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LootRedIcon = new PixelMapping
        {
            X = 353,
            Y = 419,
            Color = 12592134,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LootRedIcon2 = new PixelMapping
        {
            X = 347,
            Y = 419,
            Color = 11936260,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CollectButton = new PixelMapping
        {
            X = 277,
            Y = 421,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping LootButton = new PixelMapping
        {
            X = 403,
            Y = 422,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly Rectangle R_GoldenCrystal = new Rectangle
        {
            X = 683,
            Y = 27,
            Width = 87,
            Height = 25
        };

        public static readonly Rectangle R_Horn = new Rectangle
        {
            X = 422,
            Y = 28,
            Width = 90,
            Height = 23
        };

        public static readonly Rectangle R_Scale = new Rectangle
        {
            X = 553,
            Y = 28,
            Width = 93,
            Height = 23
        };

        public static readonly Rectangle R_Essecense = new Rectangle
        {
            X = 688,
            Y = 27,
            Width = 81,
            Height = 26
        };

        public static readonly Rectangle R_Star = new Rectangle
        {
            X = 690,
            Y = 26,
            Width = 80,
            Height = 23
        };
    }
}