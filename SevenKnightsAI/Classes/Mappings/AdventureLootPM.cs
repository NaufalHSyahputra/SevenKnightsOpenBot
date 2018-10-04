using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureLootPM
    {
        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 737,
            Y = 312,
            Color = 10714947,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping EndAutoRepeat = new PixelMapping
        {
            X = 740,
            Y = 319,
            Color = 5645582,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AgainButton = new PixelMapping
        {
            X = 734,
            Y = 130,
            Color = 5120784,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping NextZoneButton = new PixelMapping
        {
            X = 735,
            Y = 227,
            Color = 16111214,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping QuickStartButton = new PixelMapping
        {
            X = 649,
            Y = 396,
            Color = 16110958,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Auto_QuickStartButton = new PixelMapping
        {
            X = 648,
            Y = 395,
            Color = 9337663,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Auto_LobbyButton = new PixelMapping
        {
            X = 734,
            Y = 400,
            Color = 4599816,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GoldLootIcon = new PixelMapping
        {
            X = 474,
            Y = 210,
            Color = 9198114,
            Type = MappingType.BOTH
        };

        public static readonly Rectangle GoldAmount = new Rectangle
        {
            X = 443,
            Y = 311,
            Width = 82,
            Height = 30
        };

        public static readonly Rectangle DragonPoint = new Rectangle
        {
            X = 428,
            Y = 457,
            Width = 100,
            Height = 23
        };

        public static readonly PixelMapping RewardItem = new PixelMapping
        {
            X = 786,
            Y = 480,
            Color = 5317647,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardCard1Star = new PixelMapping
        {
            X = 786,
            Y = 480,
            Color = 5317647,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardCard2Star = new PixelMapping
        {
            X = 786,
            Y = 480,
            Color = 5317647,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardCard3Star = new PixelMapping
        {
            X = 786,
            Y = 480,
            Color = 5317647,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RewardCard4Star = new PixelMapping
        {
            X = 786,
            Y = 480,
            Color = 5317647,
            Type = MappingType.ANCHOR
        };
    }
}