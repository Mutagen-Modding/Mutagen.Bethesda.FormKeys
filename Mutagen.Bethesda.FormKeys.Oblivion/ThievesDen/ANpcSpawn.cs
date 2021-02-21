using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class ANpcSpawn
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            private static FormLink<IANpcSpawnGetter> Construct(uint id) => new FormLink<IANpcSpawnGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IANpcSpawnGetter> DLC06Fence => Construct(0x348f);
            public static FormLink<IANpcSpawnGetter> DLC06Supplier => Construct(0x3492);
            public static FormLink<IANpcSpawnGetter> DLC06StealthTrainer => Construct(0x2fa1);
            public static FormLink<IANpcSpawnGetter> DLC06FirstMate => Construct(0x398b);
            public static FormLink<IANpcSpawnGetter> DLC06Pirate03 => Construct(0x11ad6);
            public static FormLink<IANpcSpawnGetter> DLC06Pirate01 => Construct(0x398e);
            public static FormLink<IANpcSpawnGetter> DLC06Pirate02 => Construct(0x398f);
            public static FormLink<IANpcSpawnGetter> DLC06SecurityTrainer => Construct(0x348b);
            public static FormLink<IANpcSpawnGetter> DLC06Fletcher => Construct(0x2f9f);
            public static FormLink<IANpcSpawnGetter> DLC06CreatureSkeleton4Champion => Construct(0x11ade);
            public static FormLink<IANpcSpawnGetter> DLCBoar => Construct(0x3e8f);
            public static FormLink<IANpcSpawnGetter> DL06Dog => Construct(0x34a2);
            public static FormLink<IANpcSpawnGetter> DLC06CreatureSkeleton1 => Construct(0x11ad8);
            public static FormLink<IANpcSpawnGetter> DLC06CreatureSkeleton2 => Construct(0x11ada);
            public static FormLink<IANpcSpawnGetter> DLC06CreatureSkeleton3Hero => Construct(0x11adc);
            public static FormLink<IANpcSpawnGetter> DLC06UndeadPirate100 => Construct(0x11ae0);
        }
    }
}
