using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class InboxPM
    {
        public static readonly PixelMapping AttachCollectButton = new PixelMapping
        {
            X = 702,
            Y = 206,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping AttachCollectButtonBackground = new PixelMapping
        {
            X = 702,
            Y = 206,
            Color = 13141507,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CharacterBody = new PixelMapping
        {
            X = 152,
            Y = 185,
            Color = 7835333,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CollectAllButton = new PixelMapping
        {
            X = 717,
            Y = 447,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CollectAllButtonBackground = new PixelMapping
        {
            X = 717,
            Y = 447,
            Color = 15118595,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CurrencyTab = new PixelMapping //currency tab
        {
            X = 552,
            Y = 132,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping CurrencyTabRedIcon = new PixelMapping //currency tab
        {
            X = 502,
            Y = 104,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly int GOLD_OFFSET_X = 276;

        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly PixelMapping HonorsTab = new PixelMapping
        {
            X = 326,
            Y = 131,
            Color = 0,
            Type = MappingType.BUTTON
        };
        public static readonly PixelMapping HonorsTabRedIcon = new PixelMapping
        {
            X = 281,
            Y = 105,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly int HONOR_OFFSET_X = 279;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly PixelMapping KeysTab = new PixelMapping 
        {
            X = 444,
            Y = 131,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping KeysTabRedIcon = new PixelMapping 
        {
            X = 394,
            Y = 104,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly int KEY_OFFSET_X = 274;

        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly PixelMapping MailButton = new PixelMapping
        {
            X = 47,
            Y = 418,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping MailIcon = new PixelMapping
        {
            X = 47,
            Y = 418,
            Color = 7085840,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MaterialTab = new PixelMapping
        {
            X = 655,
            Y = 132,
            Color = 0,
            Type = MappingType.BUTTON
        };
        
        public static readonly PixelMapping MaterialTabRedIcon = new PixelMapping
        {
            X = 609,
            Y = 104,
            Color = 13116423,
            Type = MappingType.ANCHOR
        };

        public static readonly int RUBY_OFFSET_X = 277;

        public static readonly int RUBY_OFFSET_Y = 0;

        public static readonly PixelMapping TicketTab = new PixelMapping
        {
            X = 895,
            Y = 135,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping TicketTabRedIcon = new PixelMapping
        {
            X = 839,
            Y = 102,
            Color = 12920833,
            Type = MappingType.ANCHOR
        };
    }
}