using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SendHonorFailedPopupPM
    {
        public static readonly PixelMapping OkButton = new PixelMapping
        {
            X = 480,
            Y = 396,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 429,
            Y = 388,
            Color = 16774744,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoFriendYellowTick = new PixelMapping
        {
            X = 420,
            Y = 400,
            Color = 16757782,
            Type = MappingType.ANCHOR
        };
    }
}