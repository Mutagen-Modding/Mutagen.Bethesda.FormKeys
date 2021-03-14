using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Debris
        {
            private static FormLink<IDebrisGetter> Construct(uint id) => new FormLink<IDebrisGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDebrisGetter> dlc1TestPhilIceFormDebris => Construct(0x10fef);
            public static FormLink<IDebrisGetter> IceDebris => Construct(0xd97a);
        }
    }
}
