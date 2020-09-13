namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class ImageSpace
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey ISKarthspireFogNIGHT => ModKey.MakeFormKey(0x1bd1);
            public static FormKey ISKarthspireFogDUSK => ModKey.MakeFormKey(0x1bd0);
            public static FormKey ISKarthspireFogDAY => ModKey.MakeFormKey(0x1bcf);
            public static FormKey ISKarthspireFogDAWN => ModKey.MakeFormKey(0x1bce);
            public static FormKey UnderwaterImageSpace => ModKey.MakeFormKey(0x946);
        }
    }
}
