using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class ASpell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            private static FormLink<IASpellGetter> Construct(uint id) => new FormLink<IASpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IASpellGetter> LairVileShrineBlessing01 => Construct(0xa5d6);
            public static FormLink<IASpellGetter> LairVileShrineBlessing => Construct(0x1379);
            public static FormLink<IASpellGetter> LairVileAbChokeberry => Construct(0x9bff);
            public static FormLink<IASpellGetter> LairVileShrineBlessing03 => Construct(0xa5d0);
            public static FormLink<IASpellGetter> LairVileShrineBlessing02 => Construct(0xa5d4);
        }
    }
}
