using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class Water
        {
            private static FormLink<IWaterGetter> Construct(uint id) => new FormLink<IWaterGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWaterGetter> DLC1FrostreachWaterNoFlow => Construct(0x19c98);
            public static FormLink<IWaterGetter> LavaSettingsDUPLICATE001 => Construct(0x14b88);
            public static FormLink<IWaterGetter> LavaSettings => Construct(0x14b86);
            public static FormLink<IWaterGetter> DLC1FrostreachWaterFlowNE => Construct(0xce72);
            public static FormLink<IWaterGetter> DLC1FrostreachWaterFlowSE => Construct(0xce71);
            public static FormLink<IWaterGetter> DLC01DarkFallCaveDarkStillWater => Construct(0xc7c2);
            public static FormLink<IWaterGetter> DLC1WaterFastFlow => Construct(0x6afd);
            public static FormLink<IWaterGetter> DLC1DungeonWaterFlow => Construct(0x6aeb);
            public static FormLink<IWaterGetter> DLC1BloodWater => Construct(0x42b7);
            public static FormLink<IWaterGetter> DefaultWaterColdDUPLICATE000 => Construct(0x2932);
            public static FormLink<IWaterGetter> DefaultWaterCold => Construct(0x1c18);
        }
    }
}
