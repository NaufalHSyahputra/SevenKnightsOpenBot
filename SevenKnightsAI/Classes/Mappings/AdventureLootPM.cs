using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureLootPM
    {
        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 756,
            Y = 321,
            Color = 10516284,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping EndAutoRepeat = new PixelMapping
        {
            X = 757,
            Y = 349,
            Color = 7291147,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AgainButton = new PixelMapping
        {
            X = 757,
            Y = 131,
            Color = 10253093,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping NextZoneButton = new PixelMapping
        {
            X = 744,
            Y = 237,
            Color = 13148748,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping QuickStartButton = new PixelMapping
        {
            X = 668,
            Y = 424,
            Color = 3743506,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Auto_QuickStartButton = new PixelMapping
        {
            X = 666,
            Y = 429,
            Color = 3479304,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Auto_LobbyButton = new PixelMapping
        {
            X = 757,
            Y = 415,
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