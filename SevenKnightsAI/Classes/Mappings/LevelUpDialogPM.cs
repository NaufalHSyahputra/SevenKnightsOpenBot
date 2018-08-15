using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class LevelUpDialogPM
    {
        public static readonly PixelMapping CharacterEye = new PixelMapping
        {
            X = 173,
            Y = 124,
            Color = 9919535,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping InboxButton = new PixelMapping
        {
            X = 619,
            Y = 489,
            Color = 13410361,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OkButton = new PixelMapping
        {
            X = 711,
            Y = 425,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping YellowTick = new PixelMapping
        {
            X = 711,
            Y = 425,
            Color = 16768319,
            Type = MappingType.ANCHOR
        };
    }
}