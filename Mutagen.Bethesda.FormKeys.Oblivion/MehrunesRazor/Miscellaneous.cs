using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Miscellaneous
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCMehrunesRazor.esp");
            private static FormLink<IMiscellaneousGetter> Construct(uint id) => new FormLink<IMiscellaneousGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMiscellaneousGetter> DL9Gem0IronNugget => Construct(0x14c0);
            public static FormLink<IMiscellaneousGetter> DL9Bezoar01 => Construct(0x1a16);
            public static FormLink<IMiscellaneousGetter> DL9EmptyFlask => Construct(0xdb7);
        }
    }
}
