using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SmartLobbyPM
    {
        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 277,
            Y = 61,
            Color = 8487554,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 525,
            Y = 66,
            Color = 4474181,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CelestialTowerButton = new PixelMapping
        {
            X = 114,
            Y = 82,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RaidButton = new PixelMapping
        {
            X = 158,
            Y = 85,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping TartarusButton = new PixelMapping
        {
            X = 204,
            Y = 83,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CollectButton = new PixelMapping
        {
            X = 267,
            Y = 410,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping LootButton = new PixelMapping
        {
            X = 391,
            Y = 412,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly Rectangle R_GoldenCrystal = new Rectangle
        {
            X = 662,
            Y = 18,
            Width = 88,
            Height = 21
        };

        public static readonly Rectangle R_Horn = new Rectangle
        {
            X = 407,
            Y = 18,
            Width = 89,
            Height = 21
        };

        public static readonly Rectangle R_Scale = new Rectangle
        {
            X = 533,
            Y = 17,
            Width = 90,
            Height = 22
        };

        public static readonly Rectangle R_Essecense = new Rectangle
        {
            X = 663,
            Y = 19,
            Width = 87,
            Height = 21
        };

        public static readonly Rectangle R_Star = new Rectangle
        {
            X = 668,
            Y = 17,
            Width = 82,
            Height = 24
        };
    }
}