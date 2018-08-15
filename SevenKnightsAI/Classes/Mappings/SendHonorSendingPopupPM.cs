using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SendHonorSendingPopupPM
    {
        public static readonly PixelMapping CancelButton = new PixelMapping
        {
            X = 480,
            Y = 396,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping RedCross = new PixelMapping
        {
            X = 423,
            Y = 396,
            Color = 13581321,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GoldIconPlusBG = new PixelMapping
        {
            X = 710,
            Y = 28,
            Color = 3748123,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SocialTabBG = new PixelMapping
        {
            X = 373,
            Y = 73,
            Color = 788485,
            Type = MappingType.ANCHOR
        };

    }
}