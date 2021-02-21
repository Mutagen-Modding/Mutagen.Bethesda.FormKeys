using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Door
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IDoorGetter> Construct(uint id) => new FormLink<IDoorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDoorGetter> RedoranLDoor01_MinUse => Construct(0x3cfcc);
            public static FormLink<IDoorGetter> DLC2TelMithrynDoor03 => Construct(0x3ca70);
            public static FormLink<IDoorGetter> DLC2RRMineDoorFrame01 => Construct(0x3c4aa);
            public static FormLink<IDoorGetter> DLC2RRDoor01 => Construct(0x3c4a7);
            public static FormLink<IDoorGetter> DLC2RRDoorLoad01 => Construct(0x3abd2);
            public static FormLink<IDoorGetter> RedoranADoor01 => Construct(0x3a742);
            public static FormLink<IDoorGetter> RedoranLDoor01 => Construct(0x3a740);
            public static FormLink<IDoorGetter> DLC2TelMithrynDoor02 => Construct(0x38bad);
            public static FormLink<IDoorGetter> DLC2RRJailGrate01 => Construct(0x337d1);
            public static FormLink<IDoorGetter> DweKagrumezGate04 => Construct(0x323ff);
            public static FormLink<IDoorGetter> DLC2TelMithrynDoor01 => Construct(0x2c417);
            public static FormLink<IDoorGetter> DweKagrumezGate03 => Construct(0x2c01f);
            public static FormLink<IDoorGetter> DweKagrumezGate02 => Construct(0x2c01e);
            public static FormLink<IDoorGetter> DweKagrumezGate01 => Construct(0x2c01d);
            public static FormLink<IDoorGetter> DLC2ThirskMeadHallDoors => Construct(0x2a56c);
            public static FormLink<IDoorGetter> DLC2DwePtnDoorBg01 => Construct(0x26ada);
            public static FormLink<IDoorGetter> DLC2IceDoorNoName => Construct(0x25f73);
            public static FormLink<IDoorGetter> DLC2SecretStoneDoor => Construct(0x25db1);
            public static FormLink<IDoorGetter> DLC2DweFacadeLiftLeverLoadUp01 => Construct(0x20754);
            public static FormLink<IDoorGetter> DLC2DweFacadeLiftLeverLoadDown01 => Construct(0x20753);
            public static FormLink<IDoorGetter> DLC2ApoWarpBookDoor => Construct(0x1ef79);
            public static FormLink<IDoorGetter> DLC2dunNchardakDoorSeal => Construct(0x1d4bc);
            public static FormLink<IDoorGetter> DLC2dunNchardakDweDoorLarge01NoName => Construct(0x1c686);
            public static FormLink<IDoorGetter> DLC2IceDoorExtLoad => Construct(0x1c654);
            public static FormLink<IDoorGetter> DLC2MineSecretDoor01NONAME => Construct(0x1ad53);
            public static FormLink<IDoorGetter> DLC2IceDoor => Construct(0x1aae8);
        }
    }
}
