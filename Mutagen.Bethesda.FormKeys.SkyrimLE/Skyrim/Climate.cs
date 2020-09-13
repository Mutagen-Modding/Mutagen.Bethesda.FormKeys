namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class Climate
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            public static FormKey KarthspireClimate => ModKey.MakeFormKey(0xf91);
            public static FormKey BloatedMansClimate => ModKey.MakeFormKey(0xe7c4e);
            public static FormKey SovngardeClimate => ModKey.MakeFormKey(0x90a91);
            public static FormKey BlackreachClimate => ModKey.MakeFormKey(0x239fb);
            public static FormKey SkyrimClimate => ModKey.MakeFormKey(0x812);
            public static FormKey DefaultClimate => ModKey.MakeFormKey(0x15f);
        }
    }
}
