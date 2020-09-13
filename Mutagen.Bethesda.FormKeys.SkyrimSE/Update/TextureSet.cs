namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class TextureSet
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey LandscapeMountainSlab02Mask => ModKey.MakeFormKey(0x2e34);
            public static FormKey LandscapeMountainSlab01Mask => ModKey.MakeFormKey(0x2e33);
            public static FormKey LandscapeDirtCliffs01Mask => ModKey.MakeFormKey(0x2e32);
            public static FormKey LandscapeSnow02Landscape => ModKey.MakeFormKey(0x2ca1);
            public static FormKey LandscapeSnow01Landscape => ModKey.MakeFormKey(0x2ca0);
        }
    }
}
