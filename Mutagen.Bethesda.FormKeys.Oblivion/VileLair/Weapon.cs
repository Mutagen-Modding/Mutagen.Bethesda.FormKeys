using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Weapon
        {
            private static FormLink<IWeaponGetter> Construct(uint id) => new FormLink<IWeaponGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWeaponGetter> LairVileEviscerator05 => Construct(0xb97e);
            public static FormLink<IWeaponGetter> LairVileEviscerator20 => Construct(0x60bb);
            public static FormLink<IWeaponGetter> LairVileEviscerator25 => Construct(0x60bc);
            public static FormLink<IWeaponGetter> LairVileEviscerator30 => Construct(0x60bd);
            public static FormLink<IWeaponGetter> LairVileEviscerator01 => Construct(0x60b6);
            public static FormLink<IWeaponGetter> LairVileEviscerator10 => Construct(0x60b9);
            public static FormLink<IWeaponGetter> LairVileEviscerator15 => Construct(0x60ba);
        }
    }
}
