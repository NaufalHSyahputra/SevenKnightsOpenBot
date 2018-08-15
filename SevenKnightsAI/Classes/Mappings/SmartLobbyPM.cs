using System;

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
            X = 313,
            Y = 427,
            Color = 1513239,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LootButtonNotAvailable = new PixelMapping
        {
            X = 434,
            Y = 427,
            Color = 1644825,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LootRedIcon = new PixelMapping
        {
            X = 347,
            Y = 418,
            Color = 12526598,
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
    }
}