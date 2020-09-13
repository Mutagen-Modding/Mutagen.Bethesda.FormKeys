namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Region
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey SurvivalForelhost => ModKey.MakeFormKey(0x2ee8);
            public static FormKey SurvivalArcwindPoint => ModKey.MakeFormKey(0x2ee7);
        }
    }
}
