using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class TowerSelectPM
    {
        public static readonly PixelMapping GoldChamberButton = new PixelMapping
        {
            X = 633,
            Y = 319,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PreviewBorderLeft = new PixelMapping //Gold icon in tower
        {
            X = 340,
            Y = 283,
            Color = 13145930,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PreviewBorderRight = new PixelMapping //Gold Icon in Gold Mine
        {
            X = 658,
            Y = 405,
            Color = 15447896,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 750,
            Y = 380,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ReadyDisabled = new PixelMapping
        {
            X = 585,
            Y = 327,
            Color = 7943469,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GoldMindCheck = new PixelMapping
        {
            X = 691,
            Y = 376,
            Color = 16771072,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CollectButton = new PixelMapping
        {
            X = 702,
            Y = 441,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly Rectangle GoldMineCalc = new Rectangle
        {
            X = 794,
            Y = 465,
            Width = 101,
            Height = 31
        };
        public static readonly Rectangle GoldMineGoldAmount = new Rectangle
        {
            X = 674,
            Y = 397,
            Width = 60,
            Height = 28
        };

        public static readonly Rectangle GoldMineAvailable = new Rectangle
        {
            X = 743,
            Y = 396,
            Width = 27,
            Height = 27
        };
    }
}