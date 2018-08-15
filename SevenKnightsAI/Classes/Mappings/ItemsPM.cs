using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ItemsPM
    {
        #region Public Fields

        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 541,
            Y = 432,
            Color = 14201414,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 666,
            Y = 433,
            Color = 15982975,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle R_ItemCount = new Rectangle
        {
            X = 375,
            Y = 117,
            Width = 68,
            Height = 25
        };
        #endregion Public Fields
    }
}