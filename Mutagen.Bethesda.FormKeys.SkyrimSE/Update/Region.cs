using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Region
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IRegionGetter> Construct(uint id) => new FormLink<IRegionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IRegionGetter> SurvivalForelhost => Construct(0x2ee8);
            public static FormLink<IRegionGetter> SurvivalArcwindPoint => Construct(0x2ee7);
        }
    }
}
