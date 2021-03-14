using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Impact
        {
            private static FormLink<IImpactGetter> Construct(uint id) => new FormLink<IImpactGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IImpactGetter> WPNWoodSwordBluntGenericImpact => Construct(0x14c29);
            public static FormLink<IImpactGetter> WPNWoodSwordvsDummyImpact => Construct(0x8992);
        }
    }
}
