using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class Class
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("HearthFires.esm");
            private static FormLink<IClassGetter> Construct(uint id) => new FormLink<IClassGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IClassGetter> BYOHHousecarlHjaalmarchClass => Construct(0x19636);
        }
    }
}
