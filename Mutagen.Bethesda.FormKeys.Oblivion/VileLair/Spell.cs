using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Spell
        {
            private static FormLink<ISpellGetter> Construct(uint id) => new FormLink<ISpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISpellGetter> LairVileShrineBlessing01 => Construct(0xa5d6);
            public static FormLink<ISpellGetter> LairVileShrineBlessing => Construct(0x1379);
            public static FormLink<ISpellGetter> LairVileAbChokeberry => Construct(0x9bff);
            public static FormLink<ISpellGetter> LairVileShrineBlessing03 => Construct(0xa5d0);
            public static FormLink<ISpellGetter> LairVileShrineBlessing02 => Construct(0xa5d4);
        }
    }
}