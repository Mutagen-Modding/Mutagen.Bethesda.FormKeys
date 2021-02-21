using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class ANpcSpawn
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            private static FormLink<IANpcSpawnGetter> Construct(uint id) => new FormLink<IANpcSpawnGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IANpcSpawnGetter> DLCOrreryBandit3 => Construct(0x11c3d5);
            public static FormLink<IANpcSpawnGetter> DLCOrreyBandit4 => Construct(0x11c3d7);
            public static FormLink<IANpcSpawnGetter> DLCOrreryBandit5 => Construct(0x11c3d8);
            public static FormLink<IANpcSpawnGetter> DLCOrreyBandit1 => Construct(0x11c3d1);
            public static FormLink<IANpcSpawnGetter> DLCOrreyBandit2 => Construct(0x11c3d4);
        }
    }
}
