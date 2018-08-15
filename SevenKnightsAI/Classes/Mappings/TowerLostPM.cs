using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class TowerLostPM
    {
        public static readonly PixelMapping GetStrongerButton = new PixelMapping
        {
            X = 761,
            Y = 241,
            Color = 15654014,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ReadyButton = new PixelMapping
        {
            X = 749,
            Y = 337,
            Color = 16111214,
            Type = MappingType.BOTH
        };
    }
}