// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static partial class ADamageType
    {
        private static FormLink<IADamageTypeGetter> Construct(uint id) => new FormLink<IADamageTypeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IADamageTypeGetter> dtPhysical => Construct(0x60a87);
        public static FormLink<IADamageTypeGetter> dtRadiationIngestion => Construct(0x60a86);
        public static FormLink<IADamageTypeGetter> dtRadiationExposure => Construct(0x60a85);
        public static FormLink<IADamageTypeGetter> dtPoison => Construct(0x60a84);
        public static FormLink<IADamageTypeGetter> dtCryo => Construct(0x60a83);
        public static FormLink<IADamageTypeGetter> dtFire => Construct(0x60a82);
        public static FormLink<IADamageTypeGetter> dtEnergy => Construct(0x60a81);
        public static FormLink<IADamageTypeGetter> dtElectrical => Construct(0x60a80);
    }
}
