using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class Debris
        {
            private static FormLink<IDebrisGetter> Construct(uint id) => new FormLink<IDebrisGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDebrisGetter> IceFormDebris14 => Construct(0xdedc9);
            public static FormLink<IDebrisGetter> IceFormDebris => Construct(0xdc20b);
            public static FormLink<IDebrisGetter> IceWraithDebris => Construct(0x5e98e);
        }
    }
}
