namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class VolumetricLighting
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            public static FormKey VLDLC2Apocrypha => ModKey.MakeFormKey(0x1e2d1);
            public static FormKey VLDLC2Ash01Sunset => ModKey.MakeFormKey(0x1e2d0);
            public static FormKey VLDLC2Ash01Night => ModKey.MakeFormKey(0x1e2cf);
            public static FormKey VLDLC2Ash01Sunrise => ModKey.MakeFormKey(0x1e2ce);
            public static FormKey VLDLC2Ash01Day => ModKey.MakeFormKey(0x1e2cd);
        }
    }
}
