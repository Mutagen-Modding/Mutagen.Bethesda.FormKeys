namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class VolumetricLighting
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey VLSoulCairn => ModKey.MakeFormKey(0x14cf8);
        }
    }
}
