using System;

namespace SevenKnightsAI.Classes
{
    internal enum Objective
    {
        IDLE, //0

        ADVENTURE, //1

        SMART_MODE,

        ARENA, //5

        CHECK_SLOT_HERO, //7

        CHECK_SLOT_ITEM, //7

        SELL_HEROES, //8

        SELL_ITEMS, //9

        BUY_KEYS, //10

        COLLECT_INBOX, //11

        COLLECT_QUESTS, //12

        SEND_HONORS, //13
    }
}