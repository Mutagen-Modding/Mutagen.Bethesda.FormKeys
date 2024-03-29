// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE;

public static partial class Dragonborn
{
    public static partial class Water
    {
        private static FormLink<IWaterGetter> Construct(uint id) => new FormLink<IWaterGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IWaterGetter> DLC2StandingStoneWater => Construct(0x3805d);
        public static FormLink<IWaterGetter> DLC2ApocryphaWaterSmall => Construct(0x3731a);
        public static FormLink<IWaterGetter> DLC2ApocryphaWaterTamriel => Construct(0x2adec);
        public static FormLink<IWaterGetter> DLC2DefaultWater => Construct(0x28644);
        public static FormLink<IWaterGetter> DLC2ApocryphaWater => Construct(0x1dff1);
        public static FormLink<IWaterGetter> DLC2dunKolbjornBlood => Construct(0x1db5f);
        public static FormLink<IWaterGetter> DLC2_MQDwarven_AnimWaterType => Construct(0x173b6);
    }
}
