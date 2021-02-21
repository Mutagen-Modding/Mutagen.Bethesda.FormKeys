using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class Debris
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<IDebrisGetter> Construct(uint id) => new FormLink<IDebrisGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDebrisGetter> IceFormDebris14 => Construct(0xdedc9);
            public static FormLink<IDebrisGetter> IceFormDebris => Construct(0xdc20b);
            public static FormLink<IDebrisGetter> IceWraithDebris => Construct(0x5e98e);
        }
    }
}
