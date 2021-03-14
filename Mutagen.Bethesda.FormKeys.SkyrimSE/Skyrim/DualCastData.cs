using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class DualCastData
        {
            private static FormLink<IDualCastDataGetter> Construct(uint id) => new FormLink<IDualCastDataGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDualCastDataGetter> doomSerpentDualCastData => Construct(0xe5f62);
            public static FormLink<IDualCastDataGetter> FrostStormDualCastData => Construct(0x201f3);
        }
    }
}
