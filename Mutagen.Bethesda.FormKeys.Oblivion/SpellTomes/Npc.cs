using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class SpellTomes
    {
        public static class Npc
        {
            private static FormLink<INpcGetter> Construct(uint id) => new FormLink<INpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<INpcGetter> DLCTomeConjurer => Construct(0x40ee);
        }
    }
}