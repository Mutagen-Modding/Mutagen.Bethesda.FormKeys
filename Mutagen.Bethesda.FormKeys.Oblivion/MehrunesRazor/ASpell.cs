using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class ASpell
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            private static FormLink<IASpellGetter> Construct(uint id) => new FormLink<IASpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IASpellGetter> DL9NerfDetectionDisease => Construct(0x2728);
            public static FormLink<IASpellGetter> DL9AbFastKill => Construct(0x27eb);
            public static FormLink<IASpellGetter> DL9AbChampFX => Construct(0x1a25);
            public static FormLink<IASpellGetter> DL9DisPrion => Construct(0x2729);
        }
    }
}
