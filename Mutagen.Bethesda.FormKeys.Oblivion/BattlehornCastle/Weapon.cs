using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class BattlehornCastle
    {
        public static class Weapon
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCBattlehornCastle.esp");
            private static FormLink<IWeaponGetter> Construct(uint id) => new FormLink<IWeaponGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWeaponGetter> DLCBattlehornDragonsword04 => Construct(0x147ef);
            public static FormLink<IWeaponGetter> DLCBattlehornDragonsword05 => Construct(0x147f0);
            public static FormLink<IWeaponGetter> DLCBattlehornDragonsword06 => Construct(0x147f1);
            public static FormLink<IWeaponGetter> BattlehornSparringDagger => Construct(0xbb20);
            public static FormLink<IWeaponGetter> DLCBattlehornDragonsword01 => Construct(0x12e13);
            public static FormLink<IWeaponGetter> BattlehornSparringWarhammer => Construct(0xbb1e);
            public static FormLink<IWeaponGetter> BattlehornSparringWarAxe => Construct(0xbb1f);
            public static FormLink<IWeaponGetter> DLCBattlehornDragonsword02 => Construct(0x147ec);
            public static FormLink<IWeaponGetter> DLCBattlehornDragonsword03 => Construct(0x147ee);
        }
    }
}
