using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Sound
        {
            private static FormLink<ISoundGetter> Construct(uint id) => new FormLink<ISoundGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISoundGetter> AMBTowerGardenLP01 => Construct(0x680a);
            public static FormLink<ISoundGetter> AMBTowerGardenLP02 => Construct(0x680b);
            public static FormLink<ISoundGetter> AMBTowerGardenLP03 => Construct(0x680c);
            public static FormLink<ISoundGetter> AMBTowerGardenLP04 => Construct(0x680d);
            public static FormLink<ISoundGetter> AMBTowerGardenLP05 => Construct(0x680e);
            public static FormLink<ISoundGetter> DRSTowerLoadDoorOpen => Construct(0x681d);
            public static FormLink<ISoundGetter> DRSTowerLoadDoorClose => Construct(0x681e);
            public static FormLink<ISoundGetter> DRSTowerWallOpen => Construct(0x6d08);
            public static FormLink<ISoundGetter> DRSTowerWallClose => Construct(0x6d09);
            public static FormLink<ISoundGetter> AMBTowerHoodOrnamentLP => Construct(0x90b7);
            public static FormLink<ISoundGetter> AMBTowerRoomToneLP => Construct(0x6807);
        }
    }
}
