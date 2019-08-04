using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenKnightsAI.Classes.Mappings
{
    class AresCupPopupPM
    {
        public static readonly PixelMapping PopupBorderTop = new PixelMapping
        {
            X = 109,
            Y = 108,
            Color = 14599052,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupBorderBottom = new PixelMapping
        {
            X = 851,
            Y = 438,
            Color = 9200953,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping PopupCloseBtn = new PixelMapping
        {
            X = 826,
            Y = 58,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping PopupTitle = new PixelMapping
        {
            X = 388,
            Y = 61,
            Color = 16758288,
            Type = MappingType.ANCHOR
        };

    }
}
