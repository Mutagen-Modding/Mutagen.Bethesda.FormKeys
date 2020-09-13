namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Water
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey DefaultWaterFlowBlend => ModKey.MakeFormKey(0x1235);
            public static FormKey DefaultWaterFlow => ModKey.MakeFormKey(0x1234);
            public static FormKey RiverWaterFlowBlend => ModKey.MakeFormKey(0x1233);
            public static FormKey RiverWaterFlow => ModKey.MakeFormKey(0x1232);
        }
    }
}
