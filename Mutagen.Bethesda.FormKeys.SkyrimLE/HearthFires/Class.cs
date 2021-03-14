using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class Class
        {
            private static FormLink<IClassGetter> Construct(uint id) => new FormLink<IClassGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IClassGetter> BYOHHousecarlHjaalmarchClass => Construct(0x19636);
        }
    }
}
