using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureFightPM
    {
        #region Public Fields

        public static readonly PixelMapping AtTurn1Of2 = new PixelMapping
        {
            X = 475,
            Y = 27,
            Color = 4662552,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AtTurn1Of3_1 = new PixelMapping
        {
            X = 443,
            Y = 29,
            Color = 2103881,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AtTurn1Of3_2 = new PixelMapping
        {
            X = 457,
            Y = 23,
            Color = 16117499,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AtTurn2Of2 = new PixelMapping
        {
            X = 563,
            Y = 17,
            Color = 16711166,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AtTurn2Of3_1 = new PixelMapping
        {
            X = 498,
            Y = 29,
            Color = 2300738,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AtTurn2Of3_2 = new PixelMapping
        {
            X = 512,
            Y = 23,
            Color = 16315132,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AtTurn3Of3_1 = new PixelMapping
        {
            X = 552,
            Y = 29,
            Color = 2104148,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AtTurn3Of3_2 = new PixelMapping
        {
            X = 567,
            Y = 23,
            Color = 16249339,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GoldIcon = new PixelMapping
        {
            X = 543,
            Y = 33,
            Color = 16568424,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn1Of1 = new PixelMapping
        {
            X = 563,
            Y = 21,
            Color = 3875857,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn1Of2 = new PixelMapping
        {
            X = 480,
            Y = 21,
            Color = 4402197,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn1Of3 = new PixelMapping
        {
            X = 450,
            Y = 21,
            Color = 4204819,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn2Of2 = new PixelMapping
        {
            X = 566,
            Y = 21,
            Color = 15855080,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn2Of3 = new PixelMapping
        {
            X = 508,
            Y = 19,
            Color = 16382456,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Turn3Of3 = new PixelMapping
        {
            X = 563,
            Y = 21,
            Color = 4205337,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_AweakButton = new PixelMapping
        {
            X = 924,
            Y = 233,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Fight_AweakOff = new PixelMapping
        {
            X = 924,
            Y = 233,
            Color = 4599579,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Fight_AweakOn = new PixelMapping
        {
            X = 924,
            Y = 233,
            Color = 8539426,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle LootHero = new Rectangle
        {
            X = 837,
            Y = 7,
            Width = 44,
            Height = 39
        };
        public static readonly Rectangle LootItem = new Rectangle
        {
            X = 916,
            Y = 8,
            Width = 44,
            Height = 39
        };
        public static readonly Rectangle LootGold = new Rectangle
        {
            X = 673,
            Y = 4,
            Width = 95,
            Height = 44
        };

        public static readonly PixelMapping StopButton = new PixelMapping
        {
            X = 245,
            Y = 426,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}