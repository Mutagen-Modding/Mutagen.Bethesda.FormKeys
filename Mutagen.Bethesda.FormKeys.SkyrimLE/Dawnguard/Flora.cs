using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Flora
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IFloraGetter> Construct(uint id) => new FormLink<IFloraGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFloraGetter> DLC01SoulHusk02 => Construct(0x12dba);
            public static FormLink<IFloraGetter> DLC01SoulHusk01 => Construct(0x12db9);
            public static FormLink<IFloraGetter> DLC01Gleamblossom01 => Construct(0x10f37);
        }
    }
}
