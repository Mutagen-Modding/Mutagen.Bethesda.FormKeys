namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Debris
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey dlc1TestPhilIceFormDebris => ModKey.MakeFormKey(0x10fef);
            public static FormKey IceDebris => ModKey.MakeFormKey(0xd97a);
        }
    }
}
