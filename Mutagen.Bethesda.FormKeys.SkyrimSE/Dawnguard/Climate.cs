using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class Climate
        {
            private static FormLink<IClimateGetter> Construct(uint id) => new FormLink<IClimateGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IClimateGetter> SoulCairnClimate => Construct(0x1409);
        }
    }
}
