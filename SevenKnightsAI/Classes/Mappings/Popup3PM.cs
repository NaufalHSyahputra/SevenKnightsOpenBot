using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenKnightsAI.Classes.Mappings
{
    class Popup3PM
    {

        /* Special Quest Popup */
        public static readonly PixelMapping QuestCharacterPic = new PixelMapping
        {
            X = 201,
            Y = 177,
            Color = 10803678,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestPoint1 = new PixelMapping
        {
            X = 264,
            Y = 308,
            Color = 5103082,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestPoint2 = new PixelMapping //Pentagon Card
        {
            X = 784,
            Y = 294,
            Color = 8603194,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestRedCrossButton = new PixelMapping
        {
            X = 828,
            Y = 96,
            Color = 13057291,
            Type = MappingType.BOTH
        };

        /* Package Shop */
        public static readonly PixelMapping EventPackPoint1 = new PixelMapping // "P" in "PACKAGE"
        {
            X = 494,
            Y = 38,
            Color = 14005581,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping EventPackPoint2 = new PixelMapping // "P" in "SHOP"
        {
            X = 307,
            Y = 40,
            Color = 14135625,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping EventPackCloseBtn = new PixelMapping
        {
            X = 787,
            Y = 34,
            Color = 13320716,
            Type = MappingType.BOTH
        };

    }
}
