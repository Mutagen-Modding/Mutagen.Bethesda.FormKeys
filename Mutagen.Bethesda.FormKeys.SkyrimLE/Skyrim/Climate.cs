// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Skyrim
{
    public static partial class Climate
    {
        private static FormLink<IClimateGetter> Construct(uint id) => new FormLink<IClimateGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IClimateGetter> KarthspireClimate => Construct(0xf91);
        public static FormLink<IClimateGetter> BloatedMansClimate => Construct(0xe7c4e);
        public static FormLink<IClimateGetter> SovngardeClimate => Construct(0x90a91);
        public static FormLink<IClimateGetter> BlackreachClimate => Construct(0x239fb);
        public static FormLink<IClimateGetter> SkyrimClimate => Construct(0x812);
        public static FormLink<IClimateGetter> DefaultClimate => Construct(0x15f);
    }
}
