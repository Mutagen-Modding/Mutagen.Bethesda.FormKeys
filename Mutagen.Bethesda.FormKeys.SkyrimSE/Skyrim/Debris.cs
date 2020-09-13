namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class Debris
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            public static FormKey IceFormDebris14 => ModKey.MakeFormKey(0xdedc9);
            public static FormKey IceFormDebris => ModKey.MakeFormKey(0xdc20b);
            public static FormKey IceWraithDebris => ModKey.MakeFormKey(0x5e98e);
        }
    }
}
