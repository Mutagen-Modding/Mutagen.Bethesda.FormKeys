using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class ANpcSpawn
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            private static FormLink<IANpcSpawnGetter> Construct(uint id) => new FormLink<IANpcSpawnGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IANpcSpawnGetter> LairVilePrisoner => Construct(0xdb1);
            public static FormLink<IANpcSpawnGetter> RowleyEardwulf => Construct(0x3286);
            public static FormLink<IANpcSpawnGetter> LairVileMinion => Construct(0xe1b);
        }
    }
}
