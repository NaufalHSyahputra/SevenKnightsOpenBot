using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureReadyPM
    {
        #region Public Fields

        public static readonly PixelMapping CloseButton = new PixelMapping
        {
            X = 724,
            Y = 55,
            Color = 14079702,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 479,
            Y = 483,
            Color = 11123409,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyButtonBackground = new PixelMapping
        {
            X = 441,
            Y = 484,
            Color = 148119,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping DropListBackground = new PixelMapping
        {
            X = 839,
            Y = 475,
            Color = 7162915,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle R_MapNumber = new Rectangle
        {
            X = 376,
            Y = 43,
            Width = 203,
            Height = 28
        };

        #endregion Public Fields
    }
}