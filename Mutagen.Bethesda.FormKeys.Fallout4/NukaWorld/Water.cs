// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class NukaWorld
{
    public static partial class Water
    {
        private static FormLink<IWaterGetter> Construct(uint id) => new FormLink<IWaterGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IWaterGetter> DLC04IrradiatedWater => Construct(0x53919);
        public static FormLink<IWaterGetter> DLC04QuantumRiverWaterInt => Construct(0x2bd99);
        public static FormLink<IWaterGetter> DLC04QuantumRiverWater => Construct(0x19572);
    }
}
