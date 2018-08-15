using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class DisconnectedPopupPM
    {
        public static readonly PixelMapping LeftBorder = new PixelMapping
        {
            X = 288,
            Y = 142,
            Color = 16298771,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OkButton = new PixelMapping
        {
            X = 363,
            Y = 357,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping OkButtonBorderLeft = new PixelMapping
        {
            X = 343,
            Y = 347,
            Color = 15060112,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OkButtonBorderRight = new PixelMapping
        {
            X = 485,
            Y = 350,
            Color = 11047009,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RightBorder = new PixelMapping
        {
            X = 517,
            Y = 142,
            Color = 15049745,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 363,
            Y = 357,
            Color = 16759067,
            Type = MappingType.ANCHOR
        };
    }
}