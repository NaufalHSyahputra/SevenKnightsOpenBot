using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenKnightsAI.Classes.Mappings
{
    class StatusBoardPM
    {
        public static readonly PixelMapping LeftTabCon = new PixelMapping
        {
            X = 321,
            Y = 25,
            Color = 14791764,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping RightTabCol = new PixelMapping
        {
            X = 480,
            Y = 28,
            Color = 13869388,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping ContentsTab = new PixelMapping
        {
            X = 262,
            Y = 102,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping ContentsTabSelect = new PixelMapping
        {
            X = 262,
            Y = 102,
            Color = 11364356,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping HottimeTabSelect = new PixelMapping
        {
            X = 397,
            Y = 99,
            Color = 11956228,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping HottimeTab = new PixelMapping
        {
            X = 397,
            Y = 99,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping HeroRateTab = new PixelMapping
        {
            X = 549,
            Y = 87,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping HottimeRedIcon = new PixelMapping
        {
            X = 309,
            Y = 78,
            Color = 12526598,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ActiveButtonColor = new PixelMapping
        {
            X = 663,
            Y = 415,
            Color = 11303523,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ActiveBG = new PixelMapping
        {
            X = 651,
            Y = 413,
            Color = 1247749,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping StatusBar = new PixelMapping
        {
            X = 198,
            Y = 516,
            Color = 0,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ActiveHottimeButton = new PixelMapping
        {
            X = 663,
            Y = 415,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ConfirmOKtick = new PixelMapping
        {
            X = 436,
            Y = 337,
            Color = 16765235,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping NoRedCloss = new PixelMapping
        {
            X = 261,
            Y = 336,
            Color = 14433544,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping HottimeBG = new PixelMapping
        {
            X = 478,
            Y = 117,
            Color = 3218689,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping OKButton = new PixelMapping
        {
            X = 436,
            Y = 337,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ClosButton = new PixelMapping
        {
            X = 860,
            Y = 48,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}
