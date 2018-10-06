using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ItemsPM
    {
        #region Public Fields

        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 269,
            Y = 108,
            Color = 16561683,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 761,
            Y = 412,
            Color = 11902059,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle R_ItemCount = new Rectangle
        {
            X = 364,
            Y = 105,
            Width = 64,
            Height = 21
        };
        #endregion Public Fields
    }
}