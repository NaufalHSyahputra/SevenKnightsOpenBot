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
            X = 464,
            Y = 81,
            Color = 16437096,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 61,
            Y = 389,
            Color = 14657105,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping BackButton = new PixelMapping
        {
            X = 24,
            Y = 38,
            Color = 16372103,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ItemTab = new PixelMapping
        {
            X = 442,
            Y = 80,
            Color = 12219140,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AccTab = new PixelMapping
        {
            X = 590,
            Y = 70,
            Color = 13863428,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping JewelTab = new PixelMapping
        {
            X = 701,
            Y = 81,
            Color = 12022020,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ItemTabSelected = new PixelMapping
        {
            X = 442,
            Y = 80,
            Color = 12219140,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AccTabSelected = new PixelMapping
        {
            X = 590,
            Y = 70,
            Color = 13863428,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping JewelTabSelected = new PixelMapping
        {
            X = 701,
            Y = 81,
            Color = 12022020,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RefreshButton = new PixelMapping
        {
            X = 360,
            Y = 345,
            Color = 14861708,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping BulkButton = new PixelMapping
        {
            X = 295,
            Y = 387,
            Color = 0,
            Type = MappingType.BUTTON
        };
        //Button in Bulk Regist
        public static readonly PixelMapping Star1 = new PixelMapping
        {
            X = 237,
            Y = 350,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Star2 = new PixelMapping
        {
            X = 342,
            Y = 314,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Star3 = new PixelMapping
        {
            X = 238,
            Y = 280,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Star4 = new PixelMapping
        {
            X = 233,
            Y = 244,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Star5 = new PixelMapping
        {
            X = 295,
            Y = 217,
            Color = 0,
            Type = MappingType.BUTTON
        };
        // Star in First Box
        public static readonly PixelMapping Star1Exists = new PixelMapping
        {
            X = 72,
            Y = 150,
            Color = 16500284,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Star2Exists = new PixelMapping
        {
            X = 67,
            Y = 149,
            Color = 16105786,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Star3Exists = new PixelMapping
        {
            X = 61,
            Y = 150,
            Color = 16499513,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Star4Exists = new PixelMapping
        {
            X = 57,
            Y = 149,
            Color = 16306243,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Star5Exists = new PixelMapping
        {
            X = 54,
            Y = 150,
            Color = 15642674,
            Type = MappingType.BOTH
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
