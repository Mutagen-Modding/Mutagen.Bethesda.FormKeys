namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class Water
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey DLC1FrostreachWaterNoFlow => ModKey.MakeFormKey(0x19c98);
            public static FormKey LavaSettingsDUPLICATE001 => ModKey.MakeFormKey(0x14b88);
            public static FormKey LavaSettings => ModKey.MakeFormKey(0x14b86);
            public static FormKey DLC1FrostreachWaterFlowNE => ModKey.MakeFormKey(0xce72);
            public static FormKey DLC1FrostreachWaterFlowSE => ModKey.MakeFormKey(0xce71);
            public static FormKey DLC01DarkFallCaveDarkStillWater => ModKey.MakeFormKey(0xc7c2);
            public static FormKey DLC1WaterFastFlow => ModKey.MakeFormKey(0x6afd);
            public static FormKey DLC1DungeonWaterFlow => ModKey.MakeFormKey(0x6aeb);
            public static FormKey DLC1BloodWater => ModKey.MakeFormKey(0x42b7);
            public static FormKey DefaultWaterColdDUPLICATE000 => ModKey.MakeFormKey(0x2932);
            public static FormKey DefaultWaterCold => ModKey.MakeFormKey(0x1c18);
        }
    }
}
