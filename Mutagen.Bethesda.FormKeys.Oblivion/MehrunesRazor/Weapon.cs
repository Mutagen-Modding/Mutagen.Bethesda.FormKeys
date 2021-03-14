using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Weapon
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            private static FormLink<IWeaponGetter> Construct(uint id) => new FormLink<IWeaponGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWeaponGetter> DL9ChampAxe02 => Construct(0x272b);
            public static FormLink<IWeaponGetter> DL9ChampAxe03 => Construct(0x272f);
            public static FormLink<IWeaponGetter> DL9ChampAxe04 => Construct(0x2730);
            public static FormLink<IWeaponGetter> DL9ChampAxe05 => Construct(0x2731);
            public static FormLink<IWeaponGetter> DL9ChampAxe06 => Construct(0x2732);
            public static FormLink<IWeaponGetter> DL9ChampAxe07 => Construct(0x2734);
            public static FormLink<IWeaponGetter> DL9ChampAxe08 => Construct(0x2735);
            public static FormLink<IWeaponGetter> DL9LostHoe => Construct(0x49b7);
            public static FormLink<IWeaponGetter> DL9RockPick => Construct(0x274a);
            public static FormLink<IWeaponGetter> DL9RockRake => Construct(0x274b);
            public static FormLink<IWeaponGetter> DL9MehrunesRazor02 => Construct(0x5fb8);
            public static FormLink<IWeaponGetter> DL9MehrunesRazor03 => Construct(0x5fb9);
            public static FormLink<IWeaponGetter> DL9MehrunesRazor04 => Construct(0x5fba);
            public static FormLink<IWeaponGetter> DL9MehrunesRazor05 => Construct(0x5fbb);
            public static FormLink<IWeaponGetter> DL9MehrunesRazor06 => Construct(0x5fbc);
            public static FormLink<IWeaponGetter> DL9MehrunesRazor07 => Construct(0x5fbd);
            public static FormLink<IWeaponGetter> DL9MehrunesRazor08 => Construct(0x5fbe);
            public static FormLink<IWeaponGetter> DL9MehrunesRazor01 => Construct(0x1ab0);
            public static FormLink<IWeaponGetter> DL9ChampAxe01 => Construct(0xb555);
        }
    }
}
