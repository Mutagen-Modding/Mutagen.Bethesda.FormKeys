using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Npc
        {
            private static FormLink<INpcGetter> Construct(uint id) => new FormLink<INpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<INpcGetter> LairVilePrisoner => Construct(0xdb1);
            public static FormLink<INpcGetter> RowleyEardwulf => Construct(0x3286);
            public static FormLink<INpcGetter> LairVileMinion => Construct(0xe1b);
        }
    }
}
