using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SellItemPopupPM
    {
        public static readonly PixelMapping CloseButton = new PixelMapping
        {
            //X = 682,
            //Y = 67,
            //Color = 12794379,
            //Type = MappingType.BOTH
            X = 898,
            Y = 32,
            Color = 12794379,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ItemIcon = new PixelMapping
        {
            //X = 244,
            //Y = 56,
            //Color = 16049284,
            //Type = MappingType.ANCHOR
            X = 333,
            Y = 83,
            Color = 13807166,
            Type = MappingType.ANCHOR
        };

        // ยังไม่ได้ตรวจสอบ ---------------------------------------------------------------------------------
        public static readonly Rectangle R_ScrollBarArea = new Rectangle
        {
            X = 700,
            Y = 120,
            Width = 2,
            Height = 342
        };

        public static readonly PixelMapping ScrollAreaDown = new PixelMapping
        {
            X = 450,
            Y = 500,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ScrollAreaUp = new PixelMapping
        {
            X = 450,
            Y = 105,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int SCROLL_DELTA = 0;

        public static readonly int SCROLL_DOUBLE_DELTA = 113;

        // ถึงตรงนี้นะที่ยังไม่ตรวจสอบ -------------------------------------------------------------------------

        public static readonly PixelMapping SellButtonRow1 = new PixelMapping
        {
            //X = 650,
            //Y = 117,
            //Color = 13999149,
            //Type = MappingType.BOTH
            X = 702,
            Y = 217,
            Color = 16049282,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping SellButtonRow2 = new PixelMapping
        {
            //X = 650,
            //Y = 202,
            //Color = 13999149,
            //Type = MappingType.BOTH
            X = 702,
            Y = 327,
            Color = 13999149,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping SellButtonRow3 = new PixelMapping
        {
            //X = 650,
            //Y = 286,
            //Color = 13999149,
            //Type = MappingType.BOTH
            X = 702,
            Y = 437,
            Color = 13999149,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping SellButtonRow4 = new PixelMapping    // ไม่มี
        {
            //X = 650,
            //Y = 371,
            //Color = 13999149,
            //Type = MappingType.BOTH
            X = 650,
            Y = 371,
            Color = 13999149,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping SellButtonRow5 = new PixelMapping    // ไม่มี
        {
            //X = 650,
            //Y = 455,
            //Color = 13999149,
            //Type = MappingType.BOTH
            X = 650,
            Y = 455,
            Color = 13999149,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping SortButton = new PixelMapping
        {
            X = 877,
            Y = 137,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SortButtonAscending = new PixelMapping
        {
            //X = 614,
            //Y = 72,
            //Color = 13473149,
            //Type = MappingType.ANCHOR
            X = 882,
            Y = 142,
            Color = 13473149,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SortButtonDescending = new PixelMapping
        {
            //X = 613,
            //Y = 63,
            //Color = 13670528,
            //Type = MappingType.ANCHOR
            X = 882,
            Y = 133,
            Color = 13670528,
            Type = MappingType.ANCHOR
        };
    }
}