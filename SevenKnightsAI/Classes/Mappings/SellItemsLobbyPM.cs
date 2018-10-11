using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SellItemsLobbyPM
    {

        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 199,
            Y = 367,
            Color = 10389080,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 51,
            Y = 363,
            Color = 16777134,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping BackButton = new PixelMapping
        {
            X = 32,
            Y = 28,
            Color = 14326612,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ItemTab = new PixelMapping
        {
            X = 428,
            Y = 68,
            Color = 1707014,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AccTab = new PixelMapping
        {
            X = 534,
            Y = 61,
            Color = 2100998,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping JewelTab = new PixelMapping
        {
            X = 683,
            Y = 66,
            Color = 1772806,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ItemTabSelected = new PixelMapping
        {
            X = 435,
            Y = 66,
            Color = 11759108,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AccTabSelected = new PixelMapping
        {
            X = 535,
            Y = 67,
            Color = 11561732,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping JewelTabSelected = new PixelMapping
        {
            X = 687,
            Y = 62,
            Color = 12482564,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RefreshButton = new PixelMapping
        {
            X = 346,
            Y = 326,
            Color = 12690804,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping BulkButton = new PixelMapping
        {
            X = 280,
            Y = 367,
            Color = 0,
            Type = MappingType.BUTTON
        };
        //Button in Bulk Regist
        public static readonly PixelMapping Star1 = new PixelMapping
        {
            X = 306,
            Y = 327,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Star2 = new PixelMapping
        {
            X = 282,
            Y = 296,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Star3 = new PixelMapping
        {
            X = 282,
            Y = 263,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Star4 = new PixelMapping
        {
            X = 283,
            Y = 229,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Star5 = new PixelMapping
        {
            X = 282,
            Y = 196,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping GoldOre = new PixelMapping
        {
            X = 283,
            Y = 160,
            Color = 0,
            Type = MappingType.BUTTON
        };
        // Star in First Box
        public static readonly PixelMapping Item1Exist = new PixelMapping
        {
            X = 64,
            Y = 106,
            Color = 5915160,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Item2Exist = new PixelMapping
        {
            X = 84,
            Y = 130,
            Color = 1970697,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SellButton = new PixelMapping
        {
            X = 188,
            Y = 431,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly Rectangle R_ItemCount = new Rectangle
        {
            X = 375,
            Y = 117,
            Width = 68,
            Height = 25
        };
    }
}
