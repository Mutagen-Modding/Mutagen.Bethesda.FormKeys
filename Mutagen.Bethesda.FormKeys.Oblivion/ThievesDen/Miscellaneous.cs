using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Miscellaneous
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            private static FormLink<IMiscellaneousGetter> Construct(uint id) => new FormLink<IMiscellaneousGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMiscellaneousGetter> DLCConjuredLockpick => Construct(0xba5e);
        }
    }
}
