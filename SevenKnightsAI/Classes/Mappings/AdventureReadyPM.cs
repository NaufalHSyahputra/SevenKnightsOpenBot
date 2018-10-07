using System;
using System.Drawing;

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

        public static readonly Rectangle R_MapNumber = new Rectangle
        {
            X = 183,
            Y = 35,
            Width = 300,
            Height = 27
        };

        #endregion Public Fields
    }
}