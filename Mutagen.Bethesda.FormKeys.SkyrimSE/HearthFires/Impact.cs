namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Impact
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            public static FormKey WPNWoodSwordBluntGenericImpact => ModKey.MakeFormKey(0x14c29);
            public static FormKey WPNWoodSwordvsDummyImpact => ModKey.MakeFormKey(0x8992);
        }
    }
}
