using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Debris
        {
            private static FormLink<IDebrisGetter> Construct(uint id) => new FormLink<IDebrisGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDebrisGetter> DLC2TentacleDebris => Construct(0x39e47);
        }
    }
}
