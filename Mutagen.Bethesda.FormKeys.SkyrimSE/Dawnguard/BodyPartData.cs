namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class BodyPartData
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey GargoyleBodyPartData => ModKey.MakeFormKey(0xa2c7);
            public static FormKey ChaurusFlyerBodyPartData => ModKey.MakeFormKey(0x5205);
        }
    }
}
