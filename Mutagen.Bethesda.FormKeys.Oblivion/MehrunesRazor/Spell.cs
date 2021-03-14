using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Spell
        {
            private static FormLink<ISpellGetter> Construct(uint id) => new FormLink<ISpellGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ISpellGetter> DL9NerfDetectionDisease => Construct(0x2728);
            public static FormLink<ISpellGetter> DL9AbFastKill => Construct(0x27eb);
            public static FormLink<ISpellGetter> DL9AbChampFX => Construct(0x1a25);
            public static FormLink<ISpellGetter> DL9DisPrion => Construct(0x2729);
        }
    }
}
