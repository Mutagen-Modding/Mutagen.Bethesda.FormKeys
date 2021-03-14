using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class ColorRecord
        {
            private static FormLink<IColorRecordGetter> Construct(uint id) => new FormLink<IColorRecordGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IColorRecordGetter> HairColor16AlbinoWhite => Construct(0x378e);
        }
    }
}
