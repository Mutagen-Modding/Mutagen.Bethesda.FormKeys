using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Climate
        {
            private static FormLink<IClimateGetter> Construct(uint id) => new FormLink<IClimateGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IClimateGetter> DLC2ApocryphaClimateNew => Construct(0x34cfc);
            public static FormLink<IClimateGetter> DLC2ApocryphaClimate => Construct(0x1c48e);
        }
    }
}
