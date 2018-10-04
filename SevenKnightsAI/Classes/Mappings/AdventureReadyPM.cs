using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureReadyPM
    {
        #region Public Fields

        public static readonly PixelMapping CloseButton = new PixelMapping
        {
            X = 605,
            Y = 45,
            Color = 13517580,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 403,
            Y = 403,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyButtonBackground = new PixelMapping
        {
            X = 403,
            Y = 403,
            Color = 16577478,
            Type = MappingType.ANCHOR
        };

        #endregion Public Fields
    }
}