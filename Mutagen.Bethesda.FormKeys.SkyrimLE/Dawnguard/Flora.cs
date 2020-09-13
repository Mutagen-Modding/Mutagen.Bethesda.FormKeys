namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Flora
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey DLC01SoulHusk02 => ModKey.MakeFormKey(0x12dba);
            public static FormKey DLC01SoulHusk01 => ModKey.MakeFormKey(0x12db9);
            public static FormKey DLC01Gleamblossom01 => ModKey.MakeFormKey(0x10f37);
        }
    }
}
