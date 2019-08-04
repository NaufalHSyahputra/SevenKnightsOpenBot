using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ItemsPM
    {
        #region Public Fields

        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 328,
            Y = 500,
            Color = 3480848,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 484,
            Y = 492,
            Color = 15522171,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle R_ItemCount = new Rectangle
        {
            X = 435,
            Y = 123,
            Width = 90,
            Height = 28
        };
        #endregion Public Fields
    }
}