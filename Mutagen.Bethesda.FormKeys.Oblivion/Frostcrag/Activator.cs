using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Activator
        {
            private static FormLink<IActivatorGetter> Construct(uint id) => new FormLink<IActivatorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IActivatorGetter> FrostcragAlchemyStation01 => Construct(0x858b);
            public static FormLink<IActivatorGetter> Tombstone02TimTest => Construct(0x8c2d);
            public static FormLink<IActivatorGetter> FrostCragLavaFake => Construct(0x593d);
            public static FormLink<IActivatorGetter> TowerEntranceWallAnim01 => Construct(0x3ef8);
            public static FormLink<IActivatorGetter> Tombstone02AN => Construct(0xf65d);
            public static FormLink<IActivatorGetter> TeleportTest01 => Construct(0x3ef9);
            public static FormLink<IActivatorGetter> FrostcragSpellmakingingStationBefore => Construct(0xd1f);
            public static FormLink<IActivatorGetter> FrostcragAtronachAltar => Construct(0xd18);
            public static FormLink<IActivatorGetter> FrostcragSpellmakingingStation => Construct(0xd1a);
            public static FormLink<IActivatorGetter> CelestialExchanger01 => Construct(0x581e);
            public static FormLink<IActivatorGetter> FrostcragEnchantingStation => Construct(0xd1b);
            public static FormLink<IActivatorGetter> FrostcragEnchantingStationBefore => Construct(0xd1e);
            public static FormLink<IActivatorGetter> FrostCragTeleport01 => Construct(0x8001);
        }
    }
}
