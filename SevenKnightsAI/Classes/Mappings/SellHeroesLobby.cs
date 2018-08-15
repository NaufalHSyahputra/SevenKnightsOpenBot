using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class SellHeroesLobbyPM
    {

        public static readonly PixelMapping Point1 = new PixelMapping
        {
            X = 673,
            Y = 77,
            Color = 4006419,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Point2 = new PixelMapping
        {
            X = 173,
            Y = 449,
            Color = 16776347,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping BackButton = new PixelMapping
        {
            X = 20,
            Y = 29,
            Color = 12663051,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping RefreshButton = new PixelMapping
        {
            X = 429,
            Y = 452,
            Color = 7428658,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping BulkButton = new PixelMapping
        {
            X = 295,
            Y = 442,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping LastRow_1 = new PixelMapping //top left card no 8
        {
            X = 806,
            Y = 286,
            Color = 4799022,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping LastRow_2 = new PixelMapping //top right card no 8
        {
            X = 914,
            Y = 286,
            Color = 3944998,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Ascending = new PixelMapping //top right card no 8
        {
            X = 871,
            Y = 84,
            Color = 10251093,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Descending = new PixelMapping //top right card no 8
        {
            X = 871,
            Y = 84,
            Color = 13670527,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping HeroCard1 = new PixelMapping
        {
            X = 508,
            Y = 186,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HeroCard2 = new PixelMapping
        {
            X = 623,
            Y = 176,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HeroCard3 = new PixelMapping
        {
            X = 745,
            Y = 183,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HeroCard4 = new PixelMapping
        {
            X = 866,
            Y = 183,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HeroCard5 = new PixelMapping
        {
            X = 512,
            Y = 347,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HeroCard6 = new PixelMapping
        {
            X = 633,
            Y = 354,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HeroCard7 = new PixelMapping
        {
            X = 747,
            Y = 346,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HeroCard8 = new PixelMapping
        {
            X = 856,
            Y = 354,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HeroCheck1 = new PixelMapping
        {
            X = 464,
            Y = 133,
            Color = 16703546,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping HeroCheck2 = new PixelMapping
        {
            X = 581,
            Y = 135,
            Color = 16706378,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping HeroCheck3 = new PixelMapping
        {
            X = 698,
            Y = 134,
            Color = 16704577,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping HeroCheck4 = new PixelMapping
        {
            X = 815,
            Y = 135,
            Color = 16706378,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping HeroCheck5 = new PixelMapping
        {
            X = 464,
            Y = 303,
            Color = 16637752,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping HeroCheck6 = new PixelMapping
        {
            X = 582,
            Y = 304,
            Color = 16704318,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping HeroCheck7 = new PixelMapping
        {
            X = 698,
            Y = 305,
            Color = 16705605,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping HeroCheck8 = new PixelMapping
        {
            X = 816,
            Y = 305,
            Color = 16705605,
            Type = MappingType.ANCHOR
        };

        public static readonly Rectangle levelsmall1 = new Rectangle
        {
            X = 532,
            Y = 200,
            Width = 34,
            Height = 24
        };

        public static readonly Rectangle levelsmall2 = new Rectangle
        {
            X = 648,
            Y = 200,
            Width = 34,
            Height = 24
        };

        public static readonly Rectangle levelsmall3 = new Rectangle
        {
            X = 766,
            Y = 202,
            Width = 34,
            Height = 24
        };

        public static readonly Rectangle levelsmall4 = new Rectangle
        {
            X = 882,
            Y = 200,
            Width = 34,
            Height = 24
        };

        public static readonly Rectangle levelsmall5 = new Rectangle
        {
            X = 532,
            Y = 369,
            Width = 34,
            Height = 24
        };

        public static readonly Rectangle levelsmall6 = new Rectangle
        {
            X = 648,
            Y = 369,
            Width = 34,
            Height = 24
        };

        public static readonly Rectangle levelsmall7 = new Rectangle
        {
            X = 764,
            Y = 368,
            Width = 34,
            Height = 24
        };

        public static readonly Rectangle levelsmall8 = new Rectangle
        {
            X = 882,
            Y = 366,
            Width = 34,
            Height = 24
        };

        public static readonly PixelMapping SaleTypeButton = new PixelMapping
        {
            X = 539,
            Y = 82,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SellButton = new PixelMapping
        {
            X = 215,
            Y = 488,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}
