namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Sound
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            public static FormKey AMBTowerGardenLP01 => ModKey.MakeFormKey(0x680a);
            public static FormKey AMBTowerGardenLP02 => ModKey.MakeFormKey(0x680b);
            public static FormKey AMBTowerGardenLP03 => ModKey.MakeFormKey(0x680c);
            public static FormKey AMBTowerGardenLP04 => ModKey.MakeFormKey(0x680d);
            public static FormKey AMBTowerGardenLP05 => ModKey.MakeFormKey(0x680e);
            public static FormKey DRSTowerLoadDoorOpen => ModKey.MakeFormKey(0x681d);
            public static FormKey DRSTowerLoadDoorClose => ModKey.MakeFormKey(0x681e);
            public static FormKey DRSTowerWallOpen => ModKey.MakeFormKey(0x6d08);
            public static FormKey DRSTowerWallClose => ModKey.MakeFormKey(0x6d09);
            public static FormKey AMBTowerHoodOrnamentLP => ModKey.MakeFormKey(0x90b7);
            public static FormKey AMBTowerRoomToneLP => ModKey.MakeFormKey(0x6807);
        }
    }
}
