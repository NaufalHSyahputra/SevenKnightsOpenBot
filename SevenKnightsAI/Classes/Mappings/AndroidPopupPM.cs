using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AndroidPopupPM
    {
        public static readonly Rectangle TitlePopup = new Rectangle
        {
            X = 246,
            Y = 216,
            Width = 409,
            Height = 36
        };

        public static readonly PixelMapping OkButton = new PixelMapping
        {
            X = 684,
            Y = 323,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping TopLeftBorder = new PixelMapping
        {
            X = 684,
            Y = 215,
            Color = 15658734,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TopRightBorder = new PixelMapping
        {
            X = 247,
            Y = 332,
            Color = 15658734,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TopLeftBorder2 = new PixelMapping
        {
            X = 259,
            Y = 206,
            Color = 16442274,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TopRightBorder2 = new PixelMapping
        {
            X = 698,
            Y = 204,
            Color = 15915421,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle TitlePopup2 = new Rectangle
        {
            X = 286,
            Y = 141,
            Width = 390,
            Height = 30
        };
        public static readonly Rectangle DescPopup = new Rectangle
        {
            X = 266,
            Y = 180,
            Width = 430,
            Height = 201
        };

        /*Force Close Popup*/

        public static readonly PixelMapping FCBorder = new PixelMapping
        {
            X = 588,
            Y = 312,
            Color = 2401176,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping FCBorder2 = new PixelMapping
        {
            X = 687,
            Y = 312,
            Color = 1679251,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping FCBorder3 = new PixelMapping
        {
            X = 258,
            Y = 257,
            Color = 6381921,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping FCBorder4 = new PixelMapping
        {
            X = 547,
            Y = 260,
            Color = 2894892,
            Type = MappingType.ANCHOR
        };

        /*Not Responding Popup*/

        public static readonly PixelMapping NRBackgorund = new PixelMapping
        {
            X = 237,
            Y = 224,
            Color = 15658734,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NRBackground2 = new PixelMapping
        {
            X = 717,
            Y = 348,
            Color = 15658734,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NRReportText = new PixelMapping
        {
            X = 275,
            Y = 328,
            Color = 38536,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NRWaitText = new PixelMapping
        {
            X = 609,
            Y = 324,
            Color = 38536,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping NROKText = new PixelMapping
        {
            X = 687,
            Y = 328,
            Color = 38536,
            Type = MappingType.ANCHOR
        };

    }
}