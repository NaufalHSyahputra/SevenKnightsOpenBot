using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class ForceClosePopupPM
    {
        public static readonly PixelMapping OkButton = new PixelMapping
        {
            X = 687,
            Y = 309,
            Color = 3123356,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping OkBtn = new PixelMapping
        {
            X = 682,
            Y = 327,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping TopLeftBorder = new PixelMapping
        {
            X = 547,
            Y = 259,
            Color = 6579300 ,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ReportBtn = new PixelMapping
        {
            X = 605,
            Y = 312,
            Color = 2795162,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TopRightBorder = new PixelMapping
        {
            X = 352,
            Y = 268,
            Color = 2039583,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle DescPopup = new Rectangle
        {
            X = 266,
            Y = 180,
            Width = 430,
            Height = 201
        };
    }
}