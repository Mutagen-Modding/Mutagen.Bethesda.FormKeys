using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class Scroll
        {
            private static FormLink<IScrollGetter> Construct(uint id) => new FormLink<IScrollGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IScrollGetter> DLC1dunRedwaterDenTelekinesisScroll => Construct(0x14042);
        }
    }
}
