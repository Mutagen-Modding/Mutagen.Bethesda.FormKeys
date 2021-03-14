using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Water
        {
            private static FormLink<IWaterGetter> Construct(uint id) => new FormLink<IWaterGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWaterGetter> DefaultWaterFlowBlend => Construct(0x1235);
            public static FormLink<IWaterGetter> DefaultWaterFlow => Construct(0x1234);
            public static FormLink<IWaterGetter> RiverWaterFlowBlend => Construct(0x1233);
            public static FormLink<IWaterGetter> RiverWaterFlow => Construct(0x1232);
        }
    }
}
