namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Water
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            public static FormKey DLC2StandingStoneWater => ModKey.MakeFormKey(0x3805d);
            public static FormKey DLC2ApocryphaWaterSmall => ModKey.MakeFormKey(0x3731a);
            public static FormKey DLC2ApocryphaWaterTamriel => ModKey.MakeFormKey(0x2adec);
            public static FormKey DLC2DefaultWater => ModKey.MakeFormKey(0x28644);
            public static FormKey DLC2ApocryphaWater => ModKey.MakeFormKey(0x1dff1);
            public static FormKey DLC2dunKolbjornBlood => ModKey.MakeFormKey(0x1db5f);
            public static FormKey DLC2_MQDwarven_AnimWaterType => ModKey.MakeFormKey(0x173b6);
        }
    }
}
