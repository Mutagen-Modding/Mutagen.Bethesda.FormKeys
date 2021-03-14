using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Key
        {
            private static FormLink<IKeyGetter> Construct(uint id) => new FormLink<IKeyGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IKeyGetter> DLC1RuunvaldKey01 => Construct(0x13833);
            public static FormLink<IKeyGetter> DLC1RedwaterDenKey2 => Construct(0x8e20);
            public static FormLink<IKeyGetter> DLC1RedwaterDenKey1 => Construct(0x8e1f);
            public static FormLink<IKeyGetter> DLC1VQ05BoneyardKey => Construct(0x4bd5);
            public static FormLink<IKeyGetter> DLC1_WESC_DawnguardCacheKey => Construct(0x34fb);
        }
    }
}
